using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemoteManager
{
	public partial class RemoteUserControl : UserControl
	{
		private Control _clientControl;
		private Action _connect;
		private Action _disconnect;
		private Action _goFullScreen;
		private Action _initialize;

		public RemoteUserControl(
			string uniqueName,
			Control clientControl,
			Action connect,
			Action disconnect,
			Action goFullscreen,
			Action initialize
			)
		{
			InitializeComponent();
			this.Dock = DockStyle.Fill;
			this.Name = uniqueName;

			_clientControl = clientControl;
			_connect = connect;
			_disconnect = disconnect;
			_goFullScreen = goFullscreen;
			_initialize = initialize;
		}

		public void StartSession()
		{
			_clientControl.Dock = DockStyle.Fill;

			tsBtnDisconnect.Enabled = _disconnect != null;
			tsBtnFullscreen.Enabled = _goFullScreen != null;

			pnlMain.Controls.Add(_clientControl);

			if (_initialize != null && _connect != null)
			{
				_initialize();
				_connect();
			}
		}

		public void Disconnect()
		{
			if (_disconnect != null)
				_disconnect();
		}

		public void GoFullScreen()
		{
			if (_goFullScreen != null)
				_goFullScreen();
		}

		private void tsBtnDisconnect_Click(object sender, EventArgs e)
		{
			Disconnect();
		}

		private void tsBtnFullscreen_Click(object sender, EventArgs e)
		{
			GoFullScreen();
		}
	}
}
