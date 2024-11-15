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
	public partial class frmAddCashGrid
	{
		public frmAddCashGrid()
		{
			InitializeComponent();
		}
		
		public void frmAddCashGrid_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmAddCashGrid_Load(object sender, EventArgs e)
		{
			//TODO: This line of code loads data into the 'DsAddCash.additnlcash' table. You can move, or remove it, as needed.
			this.AdditnlcashTableAdapter.Fill(this.DsAddCash.additnlcash);
			
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
				MessageBox.Show("The Printing\' library is not found", "Error");
				return ;
			}
			
			// Opens the Preview window.
			grid.ShowPrintPreview();
		}
		
		
	}
}
