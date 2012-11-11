namespace RemoteManager
{
	partial class EditForm
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
			if (disposing && (components != null)) {
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
			this.txtStationName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRDPHost = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtRDPPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtRDPUsername = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtRDPDomain = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtVNCPassword = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtVNCHost = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbBoxDefault = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtStationName
			// 
			this.txtStationName.Location = new System.Drawing.Point(87, 6);
			this.txtStationName.Name = "txtStationName";
			this.txtStationName.Size = new System.Drawing.Size(133, 20);
			this.txtStationName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Station name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Host:";
			// 
			// txtRDPHost
			// 
			this.txtRDPHost.Location = new System.Drawing.Point(70, 19);
			this.txtRDPHost.Name = "txtRDPHost";
			this.txtRDPHost.Size = new System.Drawing.Size(126, 20);
			this.txtRDPHost.TabIndex = 2;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(170, 271);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(50, 22);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtRDPPassword);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtRDPUsername);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtRDPDomain);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtRDPHost);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(208, 127);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "RDP";
			// 
			// txtRDPPassword
			// 
			this.txtRDPPassword.Location = new System.Drawing.Point(70, 97);
			this.txtRDPPassword.Name = "txtRDPPassword";
			this.txtRDPPassword.Size = new System.Drawing.Size(126, 20);
			this.txtRDPPassword.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Password:";
			// 
			// txtRDPUsername
			// 
			this.txtRDPUsername.Location = new System.Drawing.Point(70, 71);
			this.txtRDPUsername.Name = "txtRDPUsername";
			this.txtRDPUsername.Size = new System.Drawing.Size(126, 20);
			this.txtRDPUsername.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Username:";
			// 
			// txtRDPDomain
			// 
			this.txtRDPDomain.Location = new System.Drawing.Point(70, 45);
			this.txtRDPDomain.Name = "txtRDPDomain";
			this.txtRDPDomain.Size = new System.Drawing.Size(126, 20);
			this.txtRDPDomain.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Domain:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtVNCPassword);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.txtVNCHost);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Location = new System.Drawing.Point(12, 187);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(208, 76);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "VNC";
			// 
			// txtVNCPassword
			// 
			this.txtVNCPassword.Location = new System.Drawing.Point(70, 45);
			this.txtVNCPassword.Name = "txtVNCPassword";
			this.txtVNCPassword.Size = new System.Drawing.Size(126, 20);
			this.txtVNCPassword.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Password:";
			// 
			// txtVNCHost
			// 
			this.txtVNCHost.Location = new System.Drawing.Point(70, 19);
			this.txtVNCHost.Name = "txtVNCHost";
			this.txtVNCHost.Size = new System.Drawing.Size(126, 20);
			this.txtVNCHost.TabIndex = 6;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "Host:";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(114, 271);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(50, 22);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Default:";
			// 
			// cmbBoxDefault
			// 
			this.cmbBoxDefault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBoxDefault.FormattingEnabled = true;
			this.cmbBoxDefault.Location = new System.Drawing.Point(87, 32);
			this.cmbBoxDefault.Name = "cmbBoxDefault";
			this.cmbBoxDefault.Size = new System.Drawing.Size(133, 21);
			this.cmbBoxDefault.TabIndex = 8;
			// 
			// EditForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(233, 301);
			this.Controls.Add(this.cmbBoxDefault);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtStationName);
			this.MaximizeBox = false;
			this.Name = "EditForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Remote Manager Editor";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtStationName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRDPHost;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtRDPUsername;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtRDPDomain;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtVNCPassword;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtVNCHost;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtRDPPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbBoxDefault;
	}
}