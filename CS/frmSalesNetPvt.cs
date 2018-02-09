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

using DevExpress.XtraGrid;

namespace DoorsPOS.WinApp
{
	public partial class frmSalesWithNetPvt
	{
		public frmSalesWithNetPvt()
		{
			InitializeComponent();
		}
		
		public void frmSalesWithNetPvt_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmSalesWithNetPvt_Load(object sender, EventArgs e)
		{
			//TODO: This line of code loads data into the 'DsSalesWithCost.vwSaleswCost' table. You can move, or remove it, as needed.
			this.VwSaleswCostTableAdapter.Fill(this.DsSalesWithCost.vwSaleswCost);
			//TODO: This line of code loads data into the 'DsItemsSold.vwSales' table. You can move, or remove it, as needed.
		}
		
		public void PivotGridControl1_DoubleClick(object sender, EventArgs e)
		{
			PivotGridControl1.ShowPrintPreview();
		}
		
		
	}
}
