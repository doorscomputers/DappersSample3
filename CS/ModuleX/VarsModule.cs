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


namespace DoorsPOS.WinApp
{
	sealed class VarsModule
	{
		public static decimal TotalSold = 0;
		public static int QtySold = 0;
		public static int QtyRefund = 0;
		public static bool payconfirm = false;
		public static decimal vpTotalSales = 0;
		public static int vEmpID = 0;
		
		public static void OpenCashdrawer()
		{
			//Modify DrawerCode to your receipt printer open drawer code
			string DrawerCode = '\u001B' + "\u0070" + "\u0030" + "\u0040" + "\u0040";
			//Modify PrinterName to your receipt printer name
			string PrinterName = "EPSON TMU220";
			
			mdlPrint.RawPrinter.PrintRaw(PrinterName, DrawerCode);
		}
	}
	
}
