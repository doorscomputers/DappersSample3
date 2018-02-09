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
	public partial class frmDiscount
	{
		public frmDiscount()
		{
			InitializeComponent();
		}
		
		public void ceDisc_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				frmPOS.vdisc = 0;
				frmPOS.vdiscamnt = 0;
				this.Close();
			}
		}
		
		public void ceDisc_KeyPress(object sender, KeyPressEventArgs e)
		{
			int ansstr = 0;
			decimal percentamnt = 0;
			//Dim origtotal As Decimal = 0
			if (e.KeyChar == '\r')
			{
				
				
				//If e.KeyCode = Keys.Enter Then
				if (ceDisc.Value < 0)
				{
					ceDisc.Value = 0;
					MessageBox.Show("Discount should be a positive number.");
					return;
				}
				ansstr = System.Convert.ToInt32(MessageBox.Show("Select Yes for Percent(%) Discount OR No for Amount Discount", "Type of Discount", MessageBoxButtons.YesNo));
				if (ceDisc.Value == 0)
				{
					frmPOS.vtotalsales = 0;
					this.Close();
					return;
				}
				
				if (ansstr == 6)
				{
					try
					{
						if (ceDisc.Value >= 100)
						{
							MessageBox.Show("Percent Discount must not be greater than or equal to 100%");
							return;
						}
						
						frmPOS.vdisc = (int) ceDisc.Value;
						percentamnt = (decimal) ((frmPOS.vtotalsales) * ((double) ((int) ceDisc.Value) / 100)); //CDec((CDec(frmPOS.vtotalsales) / 1.12) * (CInt(ceDisc.Value) / 100))
						frmPOS.vdiscamnt = percentamnt;
						frmPOS.vtotalsales = frmPOS.vtotalsales - percentamnt; // CDec((frmPOS.vtotalsales / 1.12) - percentamnt)
						VarsModule.vpTotalSales = frmPOS.vtotalsales; //frmPOS.vtotalsales - percentamnt
						//frmPOS.LessDiscount()
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString());
					}
					
				}
				else
				{
					try
					{
						if (ceDisc.Value > frmPOS.vtotalsales)
						{
							MessageBox.Show("Amount Discount must not be greater than or equal to the Total Amount to be paid!");
							return;
						}
						frmPOS.vdiscamnt = ceDisc.Value;
						frmPOS.vtotalsales = frmPOS.vtotalsales - frmPOS.vdiscamnt;
						VarsModule.vpTotalSales = frmPOS.vtotalsales; //CDec(frmPOS.vtotalsales - frmPOS.vdiscamnt)
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString());
					}
					
				}
				this.Close();
				
			}
		}
		
		public void frmDiscount_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
	}
}
