using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RemoteManager
{
	[Serializable]
	public class RemoteManagerData
	{
		#region Private members
		private const string FILE_NAME = "data.rmd";
		private List<RemoteStation> _remoteStations;
		private static RemoteManagerData _instance;
		#endregion

		#region Properties
		public static RemoteManagerData Instance
		{
			get
			{
				if (_instance == null)
					_instance = Load();
				return _instance;
			}
		}

		public RemoteStation this[string name]
		{
			get
			{
				return _remoteStations.FirstOrDefault(rs => rs.Name.ToLower().Equals(name.ToLower()));
			}
		}

		public RemoteStation[] All
		{
			get
			{
				return _remoteStations.ToArray();
			}
		}
		#endregion

		#region Constructor
		private RemoteManagerData()
		{
			_remoteStations = new List<RemoteStation>();
		}
		#endregion

		#region Public methods
		public bool Add(RemoteStation remoteStation)
		{
			if (!(this[remoteStation.Name] == null))
				return false;

			_remoteStations.Add(remoteStation);
			_remoteStations.Sort((r1, r2) => { return String.Compare(r1.Name, r2.Name); });
			return true;
		}

		public void Remove(RemoteStation remoteStation)
		{
			_remoteStations.Remove(remoteStation);
		}

		public void Save()
		{
			try
			{
				using (var file = File.Open(FILE_NAME, FileMode.OpenOrCreate))
				{
					var serializer = new BinaryFormatter();
					serializer.Serialize(file, this);
				}
			}
			catch
			{
				if (File.Exists(FILE_NAME))
					File.Delete(FILE_NAME);
			}
		}
		#endregion

		#region Private methods
		private static RemoteManagerData Load()
		{
			var ret = new RemoteManagerData();

			if (!File.Exists(FILE_NAME))
				return ret;

			try
			{
				using (var file = File.Open(FILE_NAME, FileMode.Open))
				{
					var serializer = new BinaryFormatter();
					var loadedObject = serializer.Deserialize(file);
					if (loadedObject != null)
						if (loadedObject is RemoteManagerData)
							ret = (RemoteManagerData)loadedObject;
				}
			}
			catch
			{
				File.Delete(FILE_NAME);
			}

			return ret;
		}
		#endregion
	}
}
