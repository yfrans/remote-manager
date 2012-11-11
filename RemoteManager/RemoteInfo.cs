using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using MSTSCLib;
using System.Windows.Forms;

namespace RemoteManager
{
	[Serializable]
	public abstract class RemoteInfo
	{
		public enum RemoteInfoType { RDP, RDPFS, VNC };

		public delegate void DisconnectEvtArgs(RemoteInfo sender);
		public abstract event DisconnectEvtArgs Disconnected;

		public string Host { get; set; }
		public ushort Port { get; set; }
		public string Password { get; set; }
		public string Username { get; set; }

		private string _uniqueName;
		public string UniqueName
		{
			get
			{
				if (_uniqueName == null)
					_uniqueName = Guid.NewGuid().ToString();
				return _uniqueName;
			}
		}

		public delegate void SendClipboardDlg();
		public SendClipboardDlg SendClipboard { get; set; }

		public delegate void ShowFullscreenDlg(bool fullScreen);
		public ShowFullscreenDlg ShowFullscreen { get; set; }

		protected RemoteInfo() { }

		protected RemoteInfo(string host)
		{
			Host = host;
			Password = "";
		}

		public abstract RemoteUserControl GetRemoteUserControl(Size startResolution);
	}

	[Serializable]
	public class RemoteInfoRDP : RemoteInfo
	{
		private enum DisconnectReason
		{
			NoInformationIsAvailable = 0,
			LocalDisconnection = 1,
			RemoteDisconnectionByUser = 2,
			RemoteDisconnectionByServer = 3,
			DNSNameLookupFailure = 260,
			OutOfMemory1 = 262,
			ConnectionTimedOut = 264,
			WinsockSocketConnectFailure = 516,
			OutOfMemory2 = 518,
			HostNotFound = 520,
			WinsockSendCallFailure = 772,
			OutOfMemory3 = 774,
			InvalidIPAddress = 776,
			WinsockRecvCallFailure = 1028,
			InvalidSecurityData = 1030,
			InternalError = 1032,
			InvalidEncryptionMethodSpecified = 1286,
			DNSLookupFailed = 1288,
			FailedToFindTheRequestedServerDeviceOrHost = 1540,
			InvalidServerSecurityData = 1542,
			InternalTimerError = 1544,
			TimeoutOccurred = 1796,
			FailedToUnpackServerCertificate = 1798,
			BadIPAddressSpecified = 2052,
			InternalSecurityError1 = 2056,
			SocketClosed = 2308,
			InternalSecurityError2 = 2310,
			LicensingTimeout = 2312,
			InternalSecurityError3 = 2566,
			EncryptionError = 2822,
			DecryptionError = 3078
		}

		public override event RemoteInfo.DisconnectEvtArgs Disconnected;

		public string Domain { get; set; }

		public RemoteInfoRDP() { }

		public RemoteInfoRDP(string host, string username, string password)
			: base(host)
		{
			Username = username;
			Password = password;
			Port = 3389;
		}

		public override RemoteUserControl GetRemoteUserControl(Size startResolution)
		{
			var client = new AxMSTSCLib.AxMsRdpClient7();
			client.OnDisconnected += client_OnDisconnected;
			client.OnLogonError += client_OnLogonError;
			return new RemoteUserControl(
				this.UniqueName,
				client,
				client.Connect,
				client.Disconnect,
				() => { client.FullScreen = true; },
				() =>
				{
					client.Server = this.Host;
					client.UserName = this.Username;
					client.Domain = this.Domain;
					client.AdvancedSettings3.SmartSizing = true;
					((IMsTscNonScriptable)client.GetOcx()).ClearTextPassword = Password;
					if (startResolution != Size.Empty)
					{
						client.FullScreen = true;
						client.DesktopWidth = startResolution.Width;
						client.DesktopHeight = startResolution.Height;
					}
				}
			);
		}

		void client_OnLogonError(object sender, AxMSTSCLib.IMsTscAxEvents_OnLogonErrorEvent e)
		{
			MessageBox.Show("Logon error");
		}

		void client_OnDisconnected(object sender, AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent e)
		{
			var add = this.Host + " RDP session connection error:\n";
			var message = "Unknown error while connecting.";
			if (Enum.IsDefined(typeof(DisconnectReason), e.discReason))
			{
				if (((DisconnectReason)e.discReason) == DisconnectReason.LocalDisconnection)
					message = null;
				else
					message = ((DisconnectReason)e.discReason).ToString();
			}

			if (message != null)
				UI.ShowError(add + message, "Connection error");

			if (Disconnected != null)
				Disconnected(this);
		}
	}

	[Serializable]
	public class RemoteInfoVNC : RemoteInfo
	{
		public override event RemoteInfo.DisconnectEvtArgs Disconnected;

		public RemoteInfoVNC() { }

		public RemoteInfoVNC(string host, string password)
			: base(host)
		{
			Port = 5900;
			Password = password;
		}

		public override RemoteUserControl GetRemoteUserControl(Size startResolution)
		{
			var client = new VncSharp.RemoteDesktop();
			client.ConnectionLost += client_ConnectionLost;
			return new RemoteUserControl(
				UniqueName,
				client,
				() => { client.Connect(this.Host, false, true); },
				client.Disconnect,
				null,
				() =>
				{
					client.VncPort = this.Port;
					client.GetPassword = new VncSharp.AuthenticateDelegate(() => { return this.Password; });
				}
			);
		}

		void client_ConnectionLost(object sender, EventArgs e)
		{
			if (Disconnected != null)
				Disconnected(this);
		}
	}
}
