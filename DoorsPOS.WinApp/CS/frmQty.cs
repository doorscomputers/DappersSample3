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
	public partial class frmQty
	{
		public frmQty()
		{
			InitializeComponent();
		}
		
		public void ceQty_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Escape)
				{
					//If ceQty.Value < 1 Then
					//ceQty.Value = 1
					//End If
					//frmPOS.qtyy = CInt(ceQty.Value)
					this.Close();
					frmPOS.Default.txtBarcode.Focus();
					frmPOS.Default.Activate();
					
				}
				
				if (e.KeyCode == Keys.Enter)
				{
					if (ceQty.Value < 1)
					{
						ceQty.Value = 1;
					}
					frmPOS.vpieces = (int) ceQty.Value;
					this.Close();
					//frmPOS.txtBarcode.Focus()
					frmPOS.Default.GridLookUpEdit2.Focus();
					frmPOS.Default.Activate();
					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void frmQty_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmQty_Load(object sender, EventArgs e)
		{
			ceQty.Value = 1;
			ceQty.SelectAll();
		}
		
		public void ceQty_EditValueChanged(object sender, EventArgs e)
		{
			
		}
	}
}
