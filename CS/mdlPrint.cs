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

namespace DoorsPOS.WinApp
{
	sealed class mdlPrint
	{
		public class RawPrinter
		{
			// ----- Define the data type that supplies basic print job information to the spooler.
			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]public struct DOCINFO
			{
				[MarshalAs(UnmanagedType.LPWStr)]public string pDocName;
				[MarshalAs(UnmanagedType.LPWStr)]public string pOutputFile;
				[MarshalAs(UnmanagedType.LPWStr)]public string pDataType;
			}
			
			// ----- Define interfaces to the functions supplied in the DLL.
			[DllImport("winspool.drv", EntryPoint = "OpenPrinterW", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]public static  extern bool OpenPrinter(string printerName, ref IntPtr hPrinter, int printerDefaults);
			
			[DllImport("winspool.drv", EntryPoint = "ClosePrinter", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]public static  extern bool ClosePrinter(IntPtr hPrinter);
			
			[DllImport("winspool.drv", EntryPoint = "StartDocPrinterW", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]public static  extern bool StartDocPrinter(IntPtr hPrinter, int level, ref DOCINFO documentInfo);
			
			[DllImport("winspool.drv", EntryPoint = "EndDocPrinter", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]public static  extern bool EndDocPrinter(IntPtr hPrinter);
			
			[DllImport("winspool.drv", EntryPoint = "StartPagePrinter", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]public static  extern bool StartPagePrinter(IntPtr hPrinter);
			
			[DllImport("winspool.drv", EntryPoint = "EndPagePrinter", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]public static  extern bool EndPagePrinter(IntPtr hPrinter);
			
			[DllImport("winspool.drv", EntryPoint = "WritePrinter", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]public static  extern bool WritePrinter(IntPtr hPrinter, IntPtr buffer, int bufferLength, ref int bytesWritten);
			
			public static bool PrintRaw(string printerName, string origString)
			{
				bool returnValue = default(bool);
				// ----- Send a string of  raw data to  the printer.
				IntPtr hPrinter = default(IntPtr);
				DOCINFO spoolData = new DOCINFO();
				IntPtr dataToSend = default(IntPtr);
				int dataSize = 0;
				int bytesWritten = 0;
				
				// ----- The internal format of a .NET String is just
				//       different enough from what the printer expects
				//       that there will be a problem if we send it
				//       directly. Convert it to ANSI format before
				//       sending.
				dataSize = origString.Length;
				dataToSend = Marshal.StringToCoTaskMemAnsi(origString);
				
				// ----- Prepare information for the spooler.
				spoolData.pDocName = "OpenDrawer"; // class='highlight'
				spoolData.pDataType = "RAW";
				
				try
				{
					// ----- Open a channel to  the printer or spooler.
					OpenPrinter(printerName, ref hPrinter, 0);
					
					// ----- Start a new document and Section 1.1.
					StartDocPrinter(hPrinter, 1, ref spoolData);
					StartPagePrinter(hPrinter);
					
					// ----- Send the data to the printer.
					WritePrinter(hPrinter, dataToSend, 
						dataSize, ref bytesWritten);
					
					// ----- Close everything that we opened.
					EndPagePrinter(hPrinter);
					EndDocPrinter(hPrinter);
					ClosePrinter(hPrinter);
					returnValue = true;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error occurred: " + ex.ToString());
					returnValue = false;
				}
				finally
				{
					// ----- Get rid of the special ANSI version.
					Marshal.FreeCoTaskMem(dataToSend);
				}
				return returnValue;
			}
		}
	}
	
}
