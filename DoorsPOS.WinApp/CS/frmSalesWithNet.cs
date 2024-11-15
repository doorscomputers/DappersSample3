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
	public partial class frmSalesWithNet
	{
		public frmSalesWithNet()
		{
			InitializeComponent();
		}
		
		public void frmSalesWithNet_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmSalesWithNet_Load(object sender, EventArgs e)
		{
			//TODO: This line of code loads data into the 'DsSalesWithCost.vwSaleswCost' table. You can move, or remove it, as needed.
			this.VwSaleswCostTableAdapter.Fill(this.DsSalesWithCost.vwSaleswCost);
			//TODO: This line of code loads data into the 'DsItemsSold.vwSales' table. You can move, or remove it, as needed.
			// Me.VwSalesTableAdapter.Fill(Me.DsItemsSold.vwSales)
			
		}
		
		public void GridControl1_DoubleClick(object sender, EventArgs e)
		{
			ShowGridPreview(GridControl1);
		}
		
		public void ShowGridPreview(GridControl grid)
		{
			// Check whether the GridControl can be previewed.
			if (!grid.IsPrintingAvailable)
			{
				MessageBox.Show("The \'DevExpress.XtraPrinting\' library is not found", "Error");
				return ;
			}
			
			// Opens the Preview window.
			grid.ShowPrintPreview();
		}
		
		//Sub PrintGrid(ByVal grid As GridControl)
		//    ' Check whether the GridControl can be printed.
		//    If Not grid.IsPrintingAvailable Then
		//        MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error")
		//        Return
		//    End If
		
		//    ' Print.
		//    grid.Print()
		//End Sub
		
	}
}
