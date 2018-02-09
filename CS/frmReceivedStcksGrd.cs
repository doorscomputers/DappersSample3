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
	public partial class frmReceivedStcksGrd
	{
		public frmReceivedStcksGrd()
		{
			InitializeComponent();
		}
		
		public void frmReceivedStcksGrd_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmReceivedStcksGrd_Load(object sender, EventArgs e)
		{
			//TODO: This line of code loads data into the 'DsReceivedStcks.vwReceivedStocks' table. You can move, or remove it, as needed.
			this.VwReceivedStocksTableAdapter.Fill(this.DsReceivedStcks.vwReceivedStocks);
			
		}
		public void PivotGridControl1_DoubleClick(object sender, EventArgs e)
		{
			PivotGridControl1.ShowPrintPreview();
		}
		
	}
}
