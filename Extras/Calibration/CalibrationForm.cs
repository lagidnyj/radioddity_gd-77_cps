using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace DMR
{
	public partial class CalibrationForm : Form
	{
		//private CalibrationData _vhfData;
		//private CalibrationData _uhfData;

		public CalibrationForm()
		{
			InitializeComponent();
			// Need to setup the VHF and UHF data storage class first, as its used when initialising the components
			int calibrationDataSize = Marshal.SizeOf(typeof(CalibrationData));
			byte[] array = new byte[calibrationDataSize];
			Array.Copy(MainForm.CommsBuffer, 0x8F000, array, 0, calibrationDataSize);
			this.calibrationBandControlUHF.data  = (CalibrationData)ByteToData(array);

			array = new byte[calibrationDataSize];
			Array.Copy(MainForm.CommsBuffer, 0x8F070, array, 0, calibrationDataSize);
			this.calibrationBandControlVHF.data  = (CalibrationData)ByteToData(array);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			int calibrationDataSize = Marshal.SizeOf(typeof(CalibrationData));
			/* Superseded. This block of data is now presumed to be DMR Tx and Rx Gagin controls
			Console.WriteLine(BitConverter.ToString(this.calibrationBandControlVHF.data.UnknownBlock1).Replace("-", ""));
			if ("A00FC012A00FC012" != BitConverter.ToString(this.calibrationBandControlUHF.data.UnknownBlock1).Replace("-", "") ||
				"5005CC065005CC06" != BitConverter.ToString(this.calibrationBandControlVHF.data.UnknownBlock1).Replace("-", ""))
			{
				MessageBox.Show("The UHF signature block is not set to 0xA00FC012A00FC012\nOr the VHF signature is not set to 05005CC065005CC06\nUse the hex editor to fix this problem.","Data Error!");
			}
			*/
			byte[] array = DataToByte(this.calibrationBandControlUHF.data);
			Array.Copy(array, 0, MainForm.CommsBuffer, 0x8F000, calibrationDataSize);

			array = DataToByte(this.calibrationBandControlVHF.data);
			Array.Copy(array, 0, MainForm.CommsBuffer, 0x8F070, calibrationDataSize);
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private CalibrationData ByteToData(byte[] byte_0)
		{
			int num = Marshal.SizeOf(typeof(CalibrationData));
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(byte_0, 0, intPtr, num);
			object result = Marshal.PtrToStructure(intPtr, typeof(CalibrationData));
			Marshal.FreeHGlobal(intPtr);
			return (CalibrationData)result;
		}

		public static byte[] DataToByte(CalibrationData object_0)
		{
			int num = Marshal.SizeOf(typeof(CalibrationData));
			byte[] array = new byte[num];
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr(object_0, intPtr, false);
			Marshal.Copy(intPtr, array, 0, num);
			Marshal.FreeHGlobal(intPtr);
			return array;
		}

		private void onFormLoad(object sender, EventArgs e)
		{

		}
	}
}
