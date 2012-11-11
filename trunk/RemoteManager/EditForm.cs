using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemoteManager
{
	public partial class EditForm : Form
	{
		#region Private members
		private string _oldName;
		private RemoteStation _edit;
		#endregion

		#region Constructor
		public EditForm(string name)
		{
			InitializeComponent();
			_oldName = null;

			if (name != null)
			{
				_oldName = name.ToLower();
				_edit = RemoteManagerData.Instance[name];
			}

			txtRDPUsername.TextChanged += (s, e) => { AddRemoveDefault("RDP", ((TextBox)s).TextLength > 0); };
			txtVNCHost.TextChanged += (s, e) => { AddRemoveDefault("VNC", ((TextBox)s).TextLength > 0); };

			FillAndInitialize();
		}
		#endregion

		#region Events
		private void btnSave_Click(object sender, EventArgs e)
		{
			var error = new StringBuilder();
			var newName = txtStationName.Text.ToLower();

			if (newName.Length == 0)
				error.AppendLine("Station name cannot be empty.");

			if (_oldName == null ? true : !_oldName.Equals(newName))
				if (RemoteManagerData.Instance[newName] != null)
					error.AppendLine("Station name already exist.");

			if (txtRDPHost.TextLength > 0 && txtRDPUsername.TextLength == 0 ||
				txtRDPHost.TextLength == 0 && txtRDPUsername.TextLength > 0)
				error.AppendLine("Incomplete RDP information.");

			if (txtVNCPassword.TextLength > 0 && txtVNCHost.TextLength == 0)
				error.AppendLine("Incomplete VNC information.");

			if (error.Length > 0)
			{
				UI.ShowError(error.ToString());
				return;
			}

			_edit.Name = txtStationName.Text;
			if (txtRDPHost.TextLength > 0)
			{
				if (_edit.RDP == null)
					_edit.RDP = new RemoteInfoRDP();
				_edit.RDP.Host = txtRDPHost.Text;
				_edit.RDP.Domain = txtRDPDomain.Text;
				_edit.RDP.Username = txtRDPUsername.Text;
				_edit.RDP.Password = txtRDPPassword.Text;
			}
			else
			{
				_edit.RDP = null;
			}

			if (txtVNCHost.TextLength > 0)
			{
				if (_edit.VNC == null)
					_edit.VNC = new RemoteInfoVNC();
				_edit.VNC.Host = txtVNCHost.Text;
				_edit.VNC.Password = txtVNCPassword.Text;
			}
			else
			{
				_edit.VNC = null;
			}

			_edit.DefaultRemoteType = (string)cmbBoxDefault.SelectedItem;

			if (_oldName == null)	// New station
				RemoteManagerData.Instance.Add(_edit);

			RemoteManagerData.Instance.Save();

			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}
		#endregion

		#region Private methods
		private void AddRemoveDefault(string type, bool add)
		{
			if (add)
			{
				if (!cmbBoxDefault.Items.Contains(type))
					cmbBoxDefault.Items.Add(type);
			}
			else
			{
				cmbBoxDefault.Items.Remove(type);
				cmbBoxDefault.SelectedIndex = 0;
			}
		}

		private void FillAndInitialize()
		{
			cmbBoxDefault.Items.Add("");

			if (_edit == null)
				_edit = new RemoteStation("New Station");

			txtStationName.Text = _edit.Name;
			txtRDPHost.Text = _edit.RDP != null ? _edit.RDP.Host : "";
			txtRDPDomain.Text = _edit.RDP != null ? _edit.RDP.Domain : "";
			txtRDPUsername.Text = _edit.RDP != null ? _edit.RDP.Username : "";
			txtRDPPassword.Text = _edit.RDP != null ? _edit.RDP.Password : "";
			txtVNCHost.Text = _edit.VNC != null ? _edit.VNC.Host : "";
			txtVNCPassword.Text = _edit.VNC != null ? _edit.VNC.Password : "";
			cmbBoxDefault.SelectedItem = _edit.DefaultRemoteType;
		}
		#endregion
	}
}
