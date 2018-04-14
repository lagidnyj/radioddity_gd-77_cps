using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;

namespace DMR
{
	public partial class DownloadContactsForm : Form
	{
		public ContactsForm parentForm=null;
		public MainForm mainForm=null;
		public TreeNode treeNode = null;
		private bool _isDownloading = false;

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

		private void DMRMARCDownloadCompleteHandler(object sender=null, DownloadStringCompletedEventArgs e=null)
		{
			string ownRadioId = GeneralSetForm.data.RadioId;
			int currentID;
			bool found;
			string name;

			string json = e.Result;// File.ReadAllText("d:\\dmr-marc.json");
			try
			{
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				serializer.MaxJsonLength = Int32.MaxValue;
				DmrMarcData data = serializer.Deserialize<DmrMarcData>(json);
				string filter = txtIDStart.Text;
				int filterLength = filter.Length;
				List<DmrMarcDataDataItem> records = data.users.FindAll(r => r.radio_id.Substring(0, filterLength) == filter);

				//				records.Sort((x, y) => Math.Sign(int.Parse(x.radio_id.Substring(4, 3)) - int.Parse(y.radio_id.Substring(4, 3))));// Sorting of Australian data --- wasnt useful


				foreach (DmrMarcDataDataItem i in records)
				{
					found = false;


					if (ownRadioId == i.radio_id)
					{
						found = true;
					}
					else
					{
						currentID = int.Parse(i.radio_id);
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
						name = i.name + " " + i.surname;

						this.dgvDownloadeContacts.Rows.Insert(0, i.radio_id, i.callsign, name, "");
					}
				}
				lblMessage.Text = string.Format(Settings.dicCommon["DownloadContactsMessageAdded"], this.dgvDownloadeContacts.RowCount);


			}
			catch (Exception ex)
			{
				MessageBox.Show(Settings.dicCommon["UnableDownloadFromInternet"]);
			}
			finally
			{
				_wc = null;
				_isDownloading = false;
				Cursor.Current = Cursors.Default;
			}
		}

		private void downloadProgressHandler(object sender, DownloadProgressChangedEventArgs e)
		{
			// Note. The server does not report the total file size. Therefore in order to display some sort of progress percentage we have to use an estimated total size
			const int ESTIMATED_FILE_SIZE_PERCENTAGE_DIVIDER = 15000000 / 100;
			try
			{
				BeginInvoke((Action)(() =>
					{
						lblMessage.Text = Settings.dicCommon["DownloadContactsDownloading"] + e.BytesReceived / ESTIMATED_FILE_SIZE_PERCENTAGE_DIVIDER + "%";
					}));
			}
			catch (Exception)
			{
				// No nothing
			}
		}
		WebClient _wc = null;

		private void btnDownloadDMRMARC_Click(object sender, EventArgs e)
		{
			//DMRMARCDownloadCompleteHandler();return; // Debugging only
			if (Cursor.Current == Cursors.WaitCursor || _isDownloading)
			{
				MessageBox.Show("Already downloading");
				return;
			}
			if (txtIDStart.Text == "" || int.Parse(txtIDStart.Text) == 0)
			{
				MessageBox.Show(Settings.dicCommon["DownloadContactsRegionEmpty"]);//"Please enter the 3 digit Region previx code. e.g. 505 for Australia.");
				return;
			}
			lblMessage.Text = Settings.dicCommon["DownloadContactsDownloading"];
			this.Refresh();
			_wc = new WebClient();
			try
			{
				Application.DoEvents();
				_wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(DMRMARCDownloadCompleteHandler);
				_wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgressHandler);
				_wc.DownloadStringAsync(new Uri("http://www.dmr-marc.net/cgi-bin/trbo-database/datadump.cgi?table=users&format=json"));
			}
			catch (Exception)
			{
				MessageBox.Show(Settings.dicCommon["UnableDownloadFromInternet"]);
				return;
			}
			_isDownloading = true;
			Cursor.Current = Cursors.WaitCursor;
		}


		private void btnDownloadLastHeard_Click(object sender, EventArgs e)
		{
			if (Cursor.Current == Cursors.WaitCursor || _isDownloading)
			{
				MessageBox.Show("Already downloading");
				return;
			}
			if (txtIDStart.Text == "" || int.Parse(txtIDStart.Text) == 0)
			{
				MessageBox.Show(Settings.dicCommon["DownloadContactsRegionEmpty"]);//"Please enter the 3 digit Region previx code. e.g. 505 for Australia.");
				return;
			}
			lblMessage.Text = Settings.dicCommon["DownloadContactsDownloading"];
			this.Refresh();

			_wc = new WebClient();
			string str;
			try
			{
				_isDownloading = true;
				Cursor.Current = Cursors.WaitCursor;
				Application.DoEvents();
				str = _wc.DownloadString("http://ham-digital.org/user_by_lh.php?id=" + txtIDStart.Text + "&cnt=1024");
			}
			catch (Exception)
			{
				_isDownloading = false;
				Cursor.Current = Cursors.Default;
				MessageBox.Show(Settings.dicCommon["UnableDownloadFromInternet"]);
				return;
			}
			finally
			{
				_wc = null;
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
			Cursor.Current = Cursors.Default;
			_isDownloading = false;
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
						MessageBox.Show(Settings.dicCommon["DownloadContactsTooMany"], Settings.dicCommon["Warning"]);//"Not all contacts could be imported because the maximum number of Digital Contacts has been reached","Warning");
						break;
					}
					else
					{
						this.dgvDownloadeContacts.Rows.Remove(row);
					}
				}

				// need to check if the form has been opened from the Digital Contacts form or directly from the top level menu
				if (parentForm != null)
				{
					parentForm.DispData();
					mainForm.RefreshRelatedForm(base.GetType());
				}
				MessageBox.Show(Settings.dicCommon["DownloadContactsImportComplete"]);
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

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void onFormClosing(object sender, FormClosingEventArgs e)
		{
			if (_wc != null)
			{
				_wc.CancelAsync();
			}
		}
	}
}