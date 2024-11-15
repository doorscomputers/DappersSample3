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
	public partial class frmPriceLookup
	{
		public frmPriceLookup()
		{
			InitializeComponent();
		}
		
		public void frmPriceLookup_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmPriceLookup_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				this.Close();
			}
		}
		
		public void frmPriceLookup_Load(object sender, EventArgs e)
		{
			//TODO: This line of code loads data into the 'DsvwItems.vwItems' table. You can move, or remove it, as needed.
			this.VwItemsTableAdapter.Fill(this.DsvwItems.vwItems);
			
		}
	}
}
