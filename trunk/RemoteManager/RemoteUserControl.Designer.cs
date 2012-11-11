namespace RemoteManager
{
	partial class RemoteUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlMain = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsBtnDisconnect = new System.Windows.Forms.ToolStripButton();
			this.tsBtnFullscreen = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 25);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(409, 261);
			this.pnlMain.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnDisconnect,
            this.tsBtnFullscreen});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(409, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsBtnDisconnect
			// 
			this.tsBtnDisconnect.Image = global::RemoteManager.Properties.Resources.rm_disconnect;
			this.tsBtnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBtnDisconnect.Name = "tsBtnDisconnect";
			this.tsBtnDisconnect.Size = new System.Drawing.Size(86, 22);
			this.tsBtnDisconnect.Text = "Disconnect";
			this.tsBtnDisconnect.Click += new System.EventHandler(this.tsBtnDisconnect_Click);
			// 
			// tsBtnFullscreen
			// 
			this.tsBtnFullscreen.Image = global::RemoteManager.Properties.Resources.rm_fullscreen;
			this.tsBtnFullscreen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBtnFullscreen.Name = "tsBtnFullscreen";
			this.tsBtnFullscreen.Size = new System.Drawing.Size(80, 22);
			this.tsBtnFullscreen.Text = "Fullscreen";
			this.tsBtnFullscreen.Click += new System.EventHandler(this.tsBtnFullscreen_Click);
			// 
			// RemoteUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.toolStrip1);
			this.Name = "RemoteUserControl";
			this.Size = new System.Drawing.Size(409, 286);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsBtnDisconnect;
		private System.Windows.Forms.ToolStripButton tsBtnFullscreen;
	}
}
