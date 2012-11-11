using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RemoteManager
{
	public class UI
	{
		public static void ShowError(string message, string title = "Error")
		{
			MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static DialogResult Ask(string question, string title = "User Confirmation", bool showCancel = false)
		{
			return MessageBox.Show(question, title, showCancel ? MessageBoxButtons.YesNoCancel : MessageBoxButtons.YesNo);
		}
	}
}
