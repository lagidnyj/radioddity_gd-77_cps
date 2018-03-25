using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace DMR
{
	public partial class DownloadContactsForm : Form
	{
		public ContactsForm parentForm=null;
		public MainForm mainForm=null;
		public TreeNode treeNode = null;

		public DownloadContactsForm()
		{
			InitializeComponent();
			if (int.Parse(GeneralSetForm.data.RadioId) / 10000 > 0)
			{
				this.txtIDStart.Text = (int.Parse(GeneralSetForm.data.RadioId) / 10000).ToString();
			}
		}

		private bool addPrivateContact(string id,string callsignAndName)
		{
			int minIndex = ContactForm.data.GetMinIndex();
			if (minIndex < 0)
			{
				return false;
			}
			ContactForm.data.SetIndex(minIndex, 1);// Not sure what this does
			ContactForm.ContactOne value = new ContactForm.ContactOne(minIndex);// get next available index
			value.Name = callsignAndName;
			value.CallId = string.Format("{0:d8}", int.Parse(id));
			value.CallTypeS = ContactForm.SZ_CALL_TYPE[1];// Private call 
			value.RingStyleS = ContactForm.DefaultContact.RingStyleS;
			value.CallRxToneS = ContactForm.SZ_CALL_RX_TONE[0];// Call tone off
			ContactForm.data[minIndex] = value;

			int[] array = new int[3] {8,10,7};// Note array index 1 appears to be Private call in terms of the tree view
			if (parentForm != null)
			{
				mainForm.InsertTreeViewNode(parentForm.Node, minIndex, typeof(ContactForm), array[1], ContactForm.data);
			}
			else
			{
				mainForm.InsertTreeViewNode(treeNode, minIndex, typeof(ContactForm), array[1], ContactForm.data);
			}

			return true;
		}

		private void btnDownload_Click(object sender, EventArgs e)
		{
			if (txtIDStart.Text == "" || int.Parse(txtIDStart.Text) == 0)
			{
				MessageBox.Show(Settings.dicCommon["DownloadContactsRegionEmpty"]);//"Please enter the 3 digit Region previx code. e.g. 505 for Australia.");
				return;
			}
			lblMessage.Text = Settings.dicCommon["DownloadContactsDownloading"];
			this.Refresh();
			WebClient wc = new WebClient();
			string str;
			try
			{
				str = wc.DownloadString("http://ham-digital.org/user_by_lh.php?id=" + txtIDStart.Text + "&cnt=1024");
			}
			catch(Exception)
			{
				MessageBox.Show(Settings.dicCommon["UnableDownloadFromInternet"]);
				return;
			}
			dgvDownloadeContacts.SuspendLayout();
			string[] linesArr = str.Split('\n');
			string[] lineArr;
			bool found;
			string name;
			int ownRadioId = int.Parse(GeneralSetForm.data.RadioId);
			int currentID;
			for (int i = linesArr.Length - 2; i >1; i--)
			{
				found = false;
				lineArr = linesArr[i].Split(';');


				if (ownRadioId == int.Parse(lineArr[2]))
				{
					found=true;
				}
				else
				{
					currentID = int.Parse(lineArr[2]);
					for (int j = 0; j < ContactForm.data.Count; j++)
					{
						if (ContactForm.data.DataIsValid(j))
						{
							if (int.Parse(ContactForm.data[j].CallId) == currentID)
							{
								found = true;
								break;
							}
						}
					}
				}
				if (found == false)
				{
					if (lineArr[3].IndexOf(" ") != -1)
					{
						name = lineArr[3].Substring(0, lineArr[3].IndexOf(" "));
					}
					else
					{
						name = lineArr[3];
					}
					this.dgvDownloadeContacts.Rows.Insert(0, lineArr[2], lineArr[1], name, lineArr[4]);
				}
			}
			lblMessage.Text = string.Format(Settings.dicCommon["DownloadContactsMessageAdded"], this.dgvDownloadeContacts.RowCount);
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			if (this.dgvDownloadeContacts.SelectedRows.Count == 0)
			{
				MessageBox.Show(Settings.dicCommon["DownloadContactsSelectContactsToImport"]);//Please select the contacts you would like to import");
			}
			else
			{
				foreach (DataGridViewRow row in this.dgvDownloadeContacts.SelectedRows)
				{
					if (addPrivateContact(row.Cells[0].Value + "", row.Cells[1].Value + " " + row.Cells[2].Value) == false)
					{
						MessageBox.Show(Settings.dicCommon["DownloadContactsTooMany"],Settings.dicCommon["Warning"]);//"Not all contacts could be imported because the maximum number of Digital Contacts has been reached","Warning");
						break;
					}
				}
				// need to check if the form has been opened from the Digital Contacts form or directly from the top level menu
				if (parentForm != null)
				{
					parentForm.DispData();
					mainForm.RefreshRelatedForm(base.GetType());
				}
				MessageBox.Show(Settings.dicCommon["DownloadContactsImportComplete"]);
				this.Close();
			}
		}

		private void btnSelectAll_Click(object sender, EventArgs e)
		{
			this.dgvDownloadeContacts.SelectAll();
		}

		private void DownloadContacts_Load(object sender, EventArgs e)
		{
			Settings.smethod_59(base.Controls);
			Settings.smethod_68(this);// Update texts etc from language xml file
		}
	}
}