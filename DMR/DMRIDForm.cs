using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DMR
{

	



	public partial class DMRIDForm : Form
	{

		private BindingSource _dataSource = new BindingSource();

		public struct ChangedByte
		{
			public byte[] DMRID;
			public byte[] Callsign;

		}

		public DMRIDForm()
		{
			InitializeComponent();
			loadData();
		}

		private void loadData()
		{
			_dataSource.Add(new DMRIDObject("5053124","VK3KYY"));
			_dataSource.Add(new DMRIDObject("5053125", "VK3KYY"));
			_dataSource.Add(new DMRIDObject("5053126", "VK3KYY"));
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.AutoSize = true;
			dataGridView1.DataSource = _dataSource;
		}

		public static byte[] StructureArrayToByteArray(ChangedByte[] objs)
		{
			int structSize = Marshal.SizeOf(typeof(ChangedByte));
			int len = objs.Length * structSize;
			byte[] arr = new byte[len];
			IntPtr ptr = Marshal.AllocHGlobal(len);
			for (int i = 0; i < objs.Length; i++)
			{
				Marshal.StructureToPtr(objs[i], ptr + i * structSize, true);
			}
			Marshal.Copy(ptr, arr, 0, len);
			Marshal.FreeHGlobal(ptr);
			return arr;
		}
	}


	#region "DMR ID Object"
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct DMRIDObject
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		private byte[] _dmrid;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		private byte[] _callsign;

		public string dmrid
		{
			get
			{
				return Encoding.ASCII.GetString(_dmrid);
			}
			set
			{
				Array.Clear(_dmrid, 0, 4);
				_dmrid = Encoding.ASCII.GetBytes(value);
			}
		}

		public string callsign
		{
			get
			{
				return Encoding.ASCII.GetString(_callsign);
			}
			set
			{
				Array.Clear(_callsign, 0, 8);
				_callsign = Encoding.ASCII.GetBytes(value);
			}
		}

		public DMRIDObject(string id, string callsign)
		{

			_dmrid = Encoding.ASCII.GetBytes(id);
			_callsign = Encoding.ASCII.GetBytes(callsign);
		}
	}	
	#endregion
}
