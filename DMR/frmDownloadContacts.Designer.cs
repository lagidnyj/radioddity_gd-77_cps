namespace DMR
{
	partial class frmDownloadContacts
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnImport = new System.Windows.Forms.Button();
			this.btnDownload = new System.Windows.Forms.Button();
			this.txtIDStart = new System.Windows.Forms.TextBox();
			this.lblIDStart = new System.Windows.Forms.Label();
			this.lblMessage = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.callsign = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastheard = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.callsign,
            this.name,
            this.lastheard});
			this.dataGridView1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.Location = new System.Drawing.Point(21, 39);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(463, 439);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnImport
			// 
			this.btnImport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.btnDownload.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.txtIDStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIDStart.Location = new System.Drawing.Point(626, 43);
			this.txtIDStart.Name = "txtIDStart";
			this.txtIDStart.Size = new System.Drawing.Size(63, 26);
			this.txtIDStart.TabIndex = 3;
			this.txtIDStart.Text = "505";
			// 
			// lblIDStart
			// 
			this.lblIDStart.AutoSize = true;
			this.lblIDStart.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIDStart.Location = new System.Drawing.Point(495, 43);
			this.lblIDStart.Name = "lblIDStart";
			this.lblIDStart.Size = new System.Drawing.Size(125, 20);
			this.lblIDStart.TabIndex = 4;
			this.lblIDStart.Text = "Region Prefix code";
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			// frmDownloadContacts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 494);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.lblIDStart);
			this.Controls.Add(this.txtIDStart);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frmDownloadContacts";
			this.Text = "Download contacts from \'Last Heard\'";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
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