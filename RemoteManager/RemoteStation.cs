using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteManager
{
	[Serializable]
	public class RemoteStation
	{
		public string Name { get; set; }
		public RemoteInfoRDP RDP { get; set; }
		public RemoteInfoVNC VNC { get; set; }

		public string DefaultRemoteType { get; set; }
		
		public RemoteInfo Default
		{
			get
			{
				if (DefaultRemoteType != null) {
					var p = this.GetType().GetProperty(DefaultRemoteType);
					if (p != null)
						return (RemoteInfo)p.GetValue(this, null);
					else
						DefaultRemoteType = null;
				}
				return null;
			}
		}

		public RemoteStation(string name)
		{
			Name = name;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
