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
	public partial class frmItemLedgerPvt
	{
		public frmItemLedgerPvt()
		{
			InitializeComponent();
		}
		
		public void frmItemLedgerPvt_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmItemLedgerPvt_Load(object sender, EventArgs e)
		{
			//TODO: This line of code loads data into the 'DsLedger.vwItemLedger2' table. You can move, or remove it, as needed.
			this.VwItemLedger2TableAdapter.Fill(this.DsLedger.vwItemLedger2);
			
		}
		
		public void PivotGridControl1_DoubleClick(object sender, EventArgs e)
		{
			PivotGridControl1.ShowPrintPreview();
		}
		
	}
}
