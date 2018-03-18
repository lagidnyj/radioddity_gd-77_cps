﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace DMR
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct RxListOneFW31x
	{
		public const int CNT_CONTACT_PER_RX_LIST = 31;
		public const int LEN_RX_LIST_NAME = 32;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = LEN_RX_LIST_NAME)]
		private byte[] name;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = CNT_CONTACT_PER_RX_LIST)]
		private ushort[] contactList;

		private ushort reserve;

		public string Name
		{
			get
			{
				return Settings.smethod_25(this.name);
			}
			set
			{
				byte[] array = Settings.smethod_23(value);
				this.name.smethod_0((byte)255);
				Array.Copy(array, 0, this.name, 0, Math.Min(array.Length, this.name.Length));
			}
		}

		public ushort[] ContactList
		{
			get
			{
				return this.contactList;
			}
			set
			{
				this.contactList.smethod_0((ushort)0);
				Array.Copy(value, 0, this.contactList, 0, value.Length);
			}
		}

		public byte ValidCount
		{
			get
			{
				List<ushort> list = new List<ushort>(this.contactList);
				List<ushort> list2 = list.FindAll(RxListOneFW31x.smethod_0);
				return (byte)list2.Count;
			}
		}

		public RxListOneFW31x(int index)
		{

			this = default(RxListOneFW31x);
			this.name = new byte[LEN_RX_LIST_NAME];
			this.contactList = new ushort[CNT_CONTACT_PER_RX_LIST];
		}

		public void Verify()
		{
			List<ushort> list = new List<ushort>(this.contactList);
			List<ushort> list2 = list.FindAll(RxListOneFW31x.smethod_1);
			while (list2.Count < this.contactList.Length)
			{
				list2.Add(0);
			}
			this.contactList = list2.ToArray();
		}

		[CompilerGenerated]
		private static bool smethod_0(ushort ushort_0)
		{
			if (ushort_0 != 0 && ContactForm.data.DataIsValid(ushort_0 - 1))
			{
				return ContactForm.data.IsGroupCall(ushort_0 - 1);
			}
			return false;
		}

		[CompilerGenerated]
		private static bool smethod_1(ushort ushort_0)
		{
			if (ushort_0 != 0 && ContactForm.data.DataIsValid(ushort_0 - 1))
			{
				return ContactForm.data.IsGroupCall(ushort_0 - 1);
			}
			return false;
		}
	}

}