using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using MSTSCLib;
using System.Text.RegularExpressions;

namespace RemoteManager
{
	public partial class MainForm : Form
	{
		#region Private members / poroperties
		private RemoteStation SelectedRemoteStation
		{
			get
			{
				if (listBoxStations.SelectedIndex >= 0)
					return (RemoteStation)listBoxStations.SelectedItem;
				return null;
			}
		}
		#endregion

		#region Constructor
		public MainForm()
		{
			InitializeComponent();

			// Form events
			this.FormClosing += MainForm_FormClosing;
			
			// Listbox event
			this.listBoxStations.MouseDoubleClick += listBoxStations_MouseDoubleClick;
			this.listBoxStations.MouseDown += listBoxStations_MouseDown;

			// Context events (No need to check for SelectedStation != null - already done by Opening)
			this.stationsContext.Opening += stationsContext_Opening;
			this.stationsContextStartRDP.Click += (s, e) => { StartSession(SelectedRemoteStation.RDP); };
			this.stationsContextStartRDPFS.Click += (s, e) => { StartSession(SelectedRemoteStation.RDP, true); };
			this.stationsContextStartVNC.Click += (s, e) => { StartSession(SelectedRemoteStation.VNC); };
			this.stationsContextEditStation.Click += (s, a) => { EditStation(); };
			this.stationsContextNewStation.Click += (s, a) => { EditStation(true); };
			this.stationsContextDeleteStation.Click += stationsContextDeleteStation_Click;

			// Fill listbox
			FillListbox();
		}
		#endregion

		#region Events
		private void stationsContextDeleteStation_Click(object sender, EventArgs e)
		{
			if (UI.Ask("Are you sure you want to delete station: " + SelectedRemoteStation.Name + "?")
				== System.Windows.Forms.DialogResult.Yes)
			{
				RemoteManagerData.Instance.Remove(SelectedRemoteStation);
				RemoteManagerData.Instance.Save();
				FillListbox();
			}
		}

		private void listBoxStations_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
				listBoxStations.SelectedIndex = listBoxStations.IndexFromPoint(e.Location);
		}

		private void stationsContext_Opening(object sender, CancelEventArgs e)
		{
			foreach (ToolStripItem tsi in stationsContext.Items)
				tsi.Enabled = false;

			stationsContextNewStation.Enabled = true;

			if (SelectedRemoteStation != null)
			{
				var isActive = false;

				if (SelectedRemoteStation.RDP != null)
					if (!IsActive(SelectedRemoteStation.RDP))
					{
						stationsContextStartRDP.Enabled = true;
						stationsContextStartRDPFS.Enabled = true;
					}
					else
					{
						isActive = true;
					}

				if (SelectedRemoteStation.VNC != null)
					if (!IsActive(SelectedRemoteStation.VNC))
						stationsContextStartVNC.Enabled = true;
					else
						isActive = true;

				if (!isActive)
				{
					stationsContextDeleteStation.Enabled = true;
					stationsContextEditStation.Enabled = true;
				}
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (TabPage t in tabControlSessions.TabPages)
				if (t.Controls[0] is RemoteUserControl)
					((RemoteUserControl)t.Controls[0]).Disconnect();
		}

		private void listBoxStations_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (SelectedRemoteStation != null)
				if (SelectedRemoteStation.Default != null)
					StartSession(SelectedRemoteStation.Default);
				else
					UI.ShowError("No default session is configured for this station.");
		}
		#endregion

		#region Private methods
		private void FillListbox()
		{
			listBoxStations.Items.Clear();
			listBoxStations.Items.AddRange(RemoteManagerData.Instance.All);
		}

		private void EditStation(bool newStation = false)
		{
			var edit = new EditForm(newStation ? null : SelectedRemoteStation.Name);
			if (edit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				FillListbox();
		}

		private void StartSession(RemoteInfo remoteInfo, bool fullscreen = false)
		{
			var exist = FindTabByName(remoteInfo.UniqueName);
			if (exist > -1)
			{
				tabControlSessions.SelectedIndex = exist;
			}
			else
			{
				remoteInfo.Disconnected += SessionDisconnected;
				var remoteUserControl = remoteInfo.GetRemoteUserControl(fullscreen ? Screen.GetBounds(this).Size : Size.Empty);
				var tabPage = new TabPage(SelectedRemoteStation.Name);
				tabPage.Controls.Add(remoteUserControl);
				tabControlSessions.TabPages.Add(tabPage);
				tabControlSessions.SelectedTab = tabPage;
				remoteUserControl.StartSession();
			}
		}

		private void SessionDisconnected(RemoteInfo sender)
		{
			sender.Disconnected -= SessionDisconnected;
			var index = FindTabByName(sender.UniqueName);
			if (index > -1)
				tabControlSessions.TabPages.RemoveAt(index);
				if (index > 0)
					tabControlSessions.SelectedIndex = index - 1;
		}

		private int FindTabByName(string name)
		{
			for (var i = 0; i < tabControlSessions.TabPages.Count; i++)
				if (tabControlSessions.TabPages[i].Controls.ContainsKey(name))
					return i;
			return -1;
		}

		private bool IsActive(RemoteInfo remoteInfo)
		{
			return FindTabByName(remoteInfo.UniqueName) > -1;
		}
		#endregion
	}
}
