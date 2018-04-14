using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMR
{
	class DmrMarcData
	{
		public List<DmrMarcDataDataItem> users {get; set; }
		public override string ToString()
		{
			string retVal = String.Empty;
			foreach (DmrMarcDataDataItem i in users)
			{
				retVal += i.ToString() + "\n";
			}
			return retVal;
		}
	}

	public class DmrMarcDataDataItem
	{
		public string country { get; set; }
		public string callsign { get; set; }
		public string name { get; set; }
		public string radio_id { get; set; }
		public string surname { get; set; }
		public string state { get; set; }
		public string city { get; set; }
		public string remarks { get; set; }

		public string ToString()
		{
			return radio_id + " " + " " + callsign + " " + name + " " + surname + " " + city + " " + state + " " + country + " " + remarks;
		}
	}
}
