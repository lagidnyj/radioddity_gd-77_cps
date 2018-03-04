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
			this.btnDownload = new System.Windows.Forms.Button();
			this.txtIDStart = new System.Windows.Forms.TextBox();
			this.lblIDStart = new System.Windows.Forms.Label();
			this.lblMessage = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.dgvDownloadeContacts.Size = new System.Drawing.Size(463, 439);
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
			this.lastheard.HeaderText = "Last heard";
			this.lastheard.Name = "lastheard";
			this.lastheard.ReadOnly = true;
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(560, 448);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(129, 30);
			this.btnImport.TabIndex = 1;
			this.btnImport.Text = "Import selected";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnDownload
			// 
			this.btnDownload.Location = new System.Drawing.Point(499, 90);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(197, 45);
			this.btnDownload.TabIndex = 2;
			this.btnDownload.Text = "Download \'Last Heard\' data";
			this.btnDownload.UseVisualStyleBackColor = true;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// txtIDStart
			// 
			this.txtIDStart.Location = new System.Drawing.Point(626, 43);
			this.txtIDStart.Name = "txtIDStart";
			this.txtIDStart.Size = new System.Drawing.Size(63, 26);
			this.txtIDStart.TabIndex = 3;
			this.txtIDStart.Text = "505";
			// 
			// lblIDStart
			// 
			this.lblIDStart.AutoSize = true;
			this.lblIDStart.Location = new System.Drawing.Point(495, 43);
			this.lblIDStart.Name = "lblIDStart";
			this.lblIDStart.Size = new System.Drawing.Size(125, 20);
			this.lblIDStart.TabIndex = 4;
			this.lblIDStart.Text = "Region Prefix code";
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(18, 9);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(466, 19);
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
			this.dataGridViewTextBoxColumn4.HeaderText = "Last heard";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// DownloadContactsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 494);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.lblIDStart);
			this.Controls.Add(this.txtIDStart);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.dgvDownloadeContacts);
			this.Name = "DownloadContactsForm";
			this.Text = "Download contacts from \'Last Heard\'";
			((System.ComponentModel.ISupportInitialize)(this.dgvDownloadeContacts)).EndInit();
			this.Font = new System.Drawing.Font("Arial", 10F);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDownloadeContacts;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn callsign;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastheard;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.TextBox txtIDStart;
		private System.Windows.Forms.Label lblIDStart;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
	}
}