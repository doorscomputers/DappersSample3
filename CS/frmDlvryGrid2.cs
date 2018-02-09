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
	public partial class frmDlvryGrid2
	{
		public frmDlvryGrid2()
		{
			InitializeComponent();
		}
		
		public void frmDlvryGrid2_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmDlvryGrid2_Load(object sender, EventArgs e)
		{
			//TODO: This line of code loads data into the 'DsvwDeliveries.vwDlvryDetails' table. You can move, or remove it, as needed.
			this.VwDlvryDetailsTableAdapter.Fill(this.DsvwDeliveries.vwDlvryDetails);
			
		}
		
		public void GridControl1_DoubleClick(object sender, EventArgs e)
		{
			GridControl1.ShowPrintPreview();
		}
		
	}
}
