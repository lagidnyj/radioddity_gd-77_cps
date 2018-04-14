namespace DMR
{
	partial class DownloadContactsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvDownloadeContacts = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.callsign = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastheard = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnImport = new System.Windows.Forms.Button();
			this.btnDownloadLastHeard = new System.Windows.Forms.Button();
			this.txtIDStart = new System.Windows.Forms.TextBox();
			this.lblIDStart = new System.Windows.Forms.Label();
			this.lblMessage = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSelectAll = new System.Windows.Forms.Button();
			this.btnDownloadDMRMARC = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDownloadeContacts)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDownloadeContacts
			// 
			this.dgvDownloadeContacts.AllowUserToAddRows = false;
			this.dgvDownloadeContacts.AllowUserToDeleteRows = false;
			this.dgvDownloadeContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDownloadeContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.callsign,
            this.name,
            this.lastheard});
			this.dgvDownloadeContacts.Location = new System.Drawing.Point(21, 39);
			this.dgvDownloadeContacts.Name = "dgvDownloadeContacts";
			this.dgvDownloadeContacts.ReadOnly = true;
			this.dgvDownloadeContacts.Size = new System.Drawing.Size(551, 439);
			this.dgvDownloadeContacts.TabIndex = 0;
			// 
			// id
			// 
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// callsign
			// 
			this.callsign.HeaderText = "Callsign";
			this.callsign.Name = "callsign";
			this.callsign.ReadOnly = true;
			// 
			// name
			// 
			this.name.HeaderText = "Name";
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// lastheard
			// 
			this.lastheard.HeaderText = "Last heard (days ago)";
			this.lastheard.Name = "lastheard";
			this.lastheard.ReadOnly = true;
			this.lastheard.Width = 175;
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(643, 405);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(129, 28);
			this.btnImport.TabIndex = 1;
			this.btnImport.Text = "Import selected";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnDownloadLastHeard
			// 
			this.btnDownloadLastHeard.Location = new System.Drawing.Point(582, 90);
			this.btnDownloadLastHeard.Name = "btnDownloadLastHeard";
			this.btnDownloadLastHeard.Size = new System.Drawing.Size(197, 32);
			this.btnDownloadLastHeard.TabIndex = 2;
			this.btnDownloadLastHeard.Text = "Download \'Last Heard\' data";
			this.btnDownloadLastHeard.UseVisualStyleBackColor = true;
			this.btnDownloadLastHeard.Click += new System.EventHandler(this.btnDownloadLastHeard_Click);
			// 
			// txtIDStart
			// 
			this.txtIDStart.Location = new System.Drawing.Point(709, 43);
			this.txtIDStart.Name = "txtIDStart";
			this.txtIDStart.Size = new System.Drawing.Size(63, 23);
			this.txtIDStart.TabIndex = 3;
			// 
			// lblIDStart
			// 
			this.lblIDStart.AutoSize = true;
			this.lblIDStart.Location = new System.Drawing.Point(578, 43);
			this.lblIDStart.Name = "lblIDStart";
			this.lblIDStart.Size = new System.Drawing.Size(127, 16);
			this.lblIDStart.TabIndex = 4;
			this.lblIDStart.Text = "Region Prefix code";
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(18, 9);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(386, 16);
			this.lblMessage.TabIndex = 5;
			this.lblMessage.Text = "Enter the ID prefix code for your region and press Download";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Callsign";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Name";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Last heard\n(Days ago)";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 150;
			// 
			// btnSelectAll
			// 
			this.btnSelectAll.Location = new System.Drawing.Point(581, 240);
			this.btnSelectAll.Name = "btnSelectAll";
			this.btnSelectAll.Size = new System.Drawing.Size(124, 28);
			this.btnSelectAll.TabIndex = 1;
			this.btnSelectAll.Text = "Select all";
			this.btnSelectAll.UseVisualStyleBackColor = true;
			this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
			// 
			// btnDownloadDMRMARC
			// 
			this.btnDownloadDMRMARC.Location = new System.Drawing.Point(581, 128);
			this.btnDownloadDMRMARC.Name = "btnDownloadDMRMARC";
			this.btnDownloadDMRMARC.Size = new System.Drawing.Size(197, 32);
			this.btnDownloadDMRMARC.TabIndex = 2;
			this.btnDownloadDMRMARC.Text = "Download \'DMR MARC\' data";
			this.btnDownloadDMRMARC.UseVisualStyleBackColor = true;
			this.btnDownloadDMRMARC.Click += new System.EventHandler(this.btnDownloadDMRMARC_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(643, 450);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 28);
			this.button1.TabIndex = 1;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// DownloadContactsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 494);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.lblIDStart);
			this.Controls.Add(this.txtIDStart);
			this.Controls.Add(this.btnDownloadDMRMARC);
			this.Controls.Add(this.btnDownloadLastHeard);
			this.Controls.Add(this.btnSelectAll);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.dgvDownloadeContacts);
			this.Font = new System.Drawing.Font("Arial", 10F);
			this.Name = "DownloadContactsForm";
			this.Text = "Download contacts from \'Last Heard\'";
			this.Load += new System.EventHandler(this.DownloadContacts_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDownloadeContacts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDownloadeContacts;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnDownloadLastHeard;
		private System.Windows.Forms.TextBox txtIDStart;
		private System.Windows.Forms.Label lblIDStart;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn callsign;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastheard;
		private System.Windows.Forms.Button btnSelectAll;
		private System.Windows.Forms.Button btnDownloadDMRMARC;
		private System.Windows.Forms.Button button1;
	}
}