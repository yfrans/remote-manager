namespace RemoteManager
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControlSessions = new System.Windows.Forms.TabControl();
			this.stationsContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.stationsContextNewStation = new System.Windows.Forms.ToolStripMenuItem();
			this.stationsContextSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.stationsContextEditStation = new System.Windows.Forms.ToolStripMenuItem();
			this.stationsContextDeleteStation = new System.Windows.Forms.ToolStripMenuItem();
			this.stationsContextSep2 = new System.Windows.Forms.ToolStripSeparator();
			this.stationsContextStartRDP = new System.Windows.Forms.ToolStripMenuItem();
			this.stationsContextStartRDPFS = new System.Windows.Forms.ToolStripMenuItem();
			this.stationsContextStartVNC = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainerMain = new System.Windows.Forms.SplitContainer();
			this.listBoxStations = new System.Windows.Forms.ListBox();
			this.stationsContext.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
			this.splitContainerMain.Panel1.SuspendLayout();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlSessions
			// 
			this.tabControlSessions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlSessions.Location = new System.Drawing.Point(0, 0);
			this.tabControlSessions.Name = "tabControlSessions";
			this.tabControlSessions.SelectedIndex = 0;
			this.tabControlSessions.Size = new System.Drawing.Size(795, 582);
			this.tabControlSessions.TabIndex = 1;
			// 
			// stationsContext
			// 
			this.stationsContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stationsContextNewStation,
            this.stationsContextSep1,
            this.stationsContextEditStation,
            this.stationsContextDeleteStation,
            this.stationsContextSep2,
            this.stationsContextStartRDP,
            this.stationsContextStartRDPFS,
            this.stationsContextStartVNC});
			this.stationsContext.Name = "contextMenuStrip1";
			this.stationsContext.Size = new System.Drawing.Size(226, 148);
			// 
			// stationsContextNewStation
			// 
			this.stationsContextNewStation.Name = "stationsContextNewStation";
			this.stationsContextNewStation.Size = new System.Drawing.Size(225, 22);
			this.stationsContextNewStation.Text = "New Station";
			// 
			// stationsContextSep1
			// 
			this.stationsContextSep1.Name = "stationsContextSep1";
			this.stationsContextSep1.Size = new System.Drawing.Size(222, 6);
			// 
			// stationsContextEditStation
			// 
			this.stationsContextEditStation.Name = "stationsContextEditStation";
			this.stationsContextEditStation.Size = new System.Drawing.Size(225, 22);
			this.stationsContextEditStation.Text = "Edit Station";
			// 
			// stationsContextDeleteStation
			// 
			this.stationsContextDeleteStation.Name = "stationsContextDeleteStation";
			this.stationsContextDeleteStation.Size = new System.Drawing.Size(225, 22);
			this.stationsContextDeleteStation.Text = "Delete Station";
			// 
			// stationsContextSep2
			// 
			this.stationsContextSep2.Name = "stationsContextSep2";
			this.stationsContextSep2.Size = new System.Drawing.Size(222, 6);
			// 
			// stationsContextStartRDP
			// 
			this.stationsContextStartRDP.Name = "stationsContextStartRDP";
			this.stationsContextStartRDP.Size = new System.Drawing.Size(225, 22);
			this.stationsContextStartRDP.Text = "Start RDP Session";
			// 
			// stationsContextStartRDPFS
			// 
			this.stationsContextStartRDPFS.Name = "stationsContextStartRDPFS";
			this.stationsContextStartRDPFS.Size = new System.Drawing.Size(225, 22);
			this.stationsContextStartRDPFS.Text = "Start Full Screen RDP Session";
			// 
			// stationsContextStartVNC
			// 
			this.stationsContextStartVNC.Name = "stationsContextStartVNC";
			this.stationsContextStartVNC.Size = new System.Drawing.Size(225, 22);
			this.stationsContextStartVNC.Text = "Start VNC Session";
			// 
			// splitContainerMain
			// 
			this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
			this.splitContainerMain.Name = "splitContainerMain";
			// 
			// splitContainerMain.Panel1
			// 
			this.splitContainerMain.Panel1.Controls.Add(this.listBoxStations);
			// 
			// splitContainerMain.Panel2
			// 
			this.splitContainerMain.Panel2.Controls.Add(this.tabControlSessions);
			this.splitContainerMain.Size = new System.Drawing.Size(899, 582);
			this.splitContainerMain.SplitterDistance = 100;
			this.splitContainerMain.TabIndex = 3;
			// 
			// listBoxStations
			// 
			this.listBoxStations.ContextMenuStrip = this.stationsContext;
			this.listBoxStations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxStations.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxStations.FormattingEnabled = true;
			this.listBoxStations.ItemHeight = 18;
			this.listBoxStations.Location = new System.Drawing.Point(0, 0);
			this.listBoxStations.Name = "listBoxStations";
			this.listBoxStations.Size = new System.Drawing.Size(100, 582);
			this.listBoxStations.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(899, 582);
			this.Controls.Add(this.splitContainerMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Remote Manager";
			this.stationsContext.ResumeLayout(false);
			this.splitContainerMain.Panel1.ResumeLayout(false);
			this.splitContainerMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
			this.splitContainerMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlSessions;
		private System.Windows.Forms.SplitContainer splitContainerMain;
		private System.Windows.Forms.ContextMenuStrip stationsContext;
		private System.Windows.Forms.ListBox listBoxStations;
		private System.Windows.Forms.ToolStripMenuItem stationsContextNewStation;
		private System.Windows.Forms.ToolStripSeparator stationsContextSep1;
		private System.Windows.Forms.ToolStripMenuItem stationsContextEditStation;
		private System.Windows.Forms.ToolStripMenuItem stationsContextDeleteStation;
		private System.Windows.Forms.ToolStripSeparator stationsContextSep2;
		private System.Windows.Forms.ToolStripMenuItem stationsContextStartRDP;
		private System.Windows.Forms.ToolStripMenuItem stationsContextStartRDPFS;
		private System.Windows.Forms.ToolStripMenuItem stationsContextStartVNC;


	}
}

