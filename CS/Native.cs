// VBConversions Note: VB project level imports
using System.Data;
using System.Collections.Generic;
using PDSA.Data;
using PDSA.WinForms.Forms;
using PDSA.Security;
using System.Diagnostics;
using PDSA.Common;
using PDSA.WinForms;
using PDSA.WinForms.Security;
using PDSA.PDSACryptography;
using DoorsPOS.Utility;
using Microsoft.VisualBasic;
using System.Collections;
using System;
using DoorsPOS.BusinessLayer;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using DoorsPOS.DataLayer;
// End of VB project level imports

using System.Runtime.InteropServices;


/// <summary>
/// Win32 API needed for LockSystem mode.
/// </summary>
/// <remarks></remarks>
namespace DoorsPOS.WinApp
{
	[HideModuleName()]internal sealed class Native
	{
		
		public const int GENERIC_ALL = 0x10000000;
		public const int DESKTOP_SWITCHDESKTOP = 0x100;
		
		[DllImport("user32.dll", ExactSpelling=true, CharSet=CharSet.Auto, SetLastError=true)]
		public static extern IntPtr GetThreadDesktop(int threadId);
		[DllImport("user32.dll", ExactSpelling=true, CharSet=CharSet.Auto, SetLastError=true)]
		public static extern IntPtr OpenInputDesktop(int flags, bool inherit, int desiredAccess);
		[DllImport("user32.dll", ExactSpelling=true, CharSet=CharSet.Auto, SetLastError=true)]
		public static extern IntPtr CreateDesktop(string desktop, string device, IntPtr devmode, int flags, int desiredAccess, IntPtr lpsa);
		[DllImport("user32.dll", ExactSpelling=true, CharSet=CharSet.Auto, SetLastError=true)]
		[MarshalAs(UnmanagedType.Bool)] public static extern bool SetThreadDesktop(IntPtr desktop);
		[DllImport("user32.dll", ExactSpelling=true, CharSet=CharSet.Auto, SetLastError=true)]
		[MarshalAs(UnmanagedType.Bool)] public static extern bool SwitchDesktop(IntPtr desktop);
		[DllImport("user32.dll", ExactSpelling=true, CharSet=CharSet.Auto, SetLastError=true)]
		[MarshalAs(UnmanagedType.Bool)] public static extern bool CloseDesktop(IntPtr desktop);
		
	}
}
