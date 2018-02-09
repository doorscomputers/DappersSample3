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
	public partial class frmPayment
	{
		public frmPayment()
		{
			InitializeComponent();
		}
		public static decimal vTender = 0;
		public void ceTendered_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				VarsModule.payconfirm = true;
				decimal vtendered = ceTendered.Value;
				decimal vtotamnt = decimal.Parse(txtTotAmnt.Text);
				decimal vchange = 0;
				
				if (vtendered < vtotamnt)
				{
					MessageBox.Show("Payment must be greater than or equal to the Total Amount Purchased!");
					ceTendered.Focus();
					return;
				}
				else
				{
					try
					{
						vchange = vtendered - vtotamnt;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString());
					}
				}
				//Call frmPOS.TakePayment()
				CallExtracted();
			}
			
			if (e.KeyCode == Keys.Escape)
			{
				//vTender = CDec(ceTendered.Value)
				vTender = 0;
				this.Close();
				//Me.Hide()
				frmPOS.Default.txtTendered.Text = "0";
				frmPOS.Default.lblChange.Text = "0";
				frmPOS.Default.btnnew.Focus();
				//frmPOS.Activate()
				
			}
			
		}
		public void CallExtracted()
		{
			vTender = ceTendered.Value;
			
			frmPOS.vtendered = Strings.FormatNumber((ceTendered.Value).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
			frmPOS.vchange = Strings.FormatNumber(txtChange.Text, -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
			//ne comment, uncomment if something goes wrong
			// just to prevent form from closing so that cashiers can see the change
			//and amount to be paid and tendered
			this.Close();
			
			//frmPOS.Activate()
			
		}
		
		public void CallExtracted2()
		{
			vTender = 0;
			
			frmPOS.vtendered = Strings.FormatNumber((0).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
			frmPOS.vchange = Strings.FormatNumber((0).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
			this.Close();
			
			frmPOS.Default.Activate();
			
		}
		public void frmPayment_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmPayment_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F1:
					e.Handled = true;
					ceTendered.Value = 100;
					ceTendered.Focus();
					break;
					//ceTendered.SelectAll()
				case Keys.F2:
					e.Handled = true;
					ceTendered.Value = 200;
					ceTendered.Focus();
					break;
					//ceTendered.SelectAll()
				case Keys.F3:
					e.Handled = true;
					ceTendered.Value = 300;
					ceTendered.Focus();
					break;
					//ceTendered.SelectAll()
				case Keys.F4:
					e.Handled = true;
					ceTendered.Value = 400;
					ceTendered.Focus();
					break;
					
				case Keys.F5:
					e.Handled = true;
					ceTendered.Value = 500;
					ceTendered.Focus();
					break;
					
				case Keys.F6:
					e.Handled = true;
					ceTendered.Value = 600;
					ceTendered.Focus();
					break;
					
				case Keys.F7:
					e.Handled = true;
					ceTendered.Value = 700;
					ceTendered.Focus();
					break;
					
				case Keys.F8:
					e.Handled = true;
					ceTendered.Value = 800;
					ceTendered.Focus();
					break;
					
				case Keys.F9:
					e.Handled = true;
					ceTendered.Value = 900;
					ceTendered.Focus();
					break;
					
				case Keys.F10:
					e.Handled = true;
					ceTendered.Value = 1000;
					ceTendered.Focus();
					break;
					
			}
		}
		
		public void frmPayment_Load(object sender, EventArgs e)
		{
			//'txtTotAmnt.Text = FormatNumber(CStr(frmPOS.Tots))
			//txtTotAmnt.Text = FormatNumber(CStr(vpTotalSales))
			//'txtTotAmnt.Text = FormatNumber(CStr(frmPOS.vtotalsales))
			//ceTendered.Value = vpTotalSales 'frmPOS.Tots
			txtChange.Text = "0";
			ceTendered.Focus();
			ceTendered.SelectAll();
		}
		
		public void ceTendered_EditValueChanged(object sender, EventArgs e)
		{
			decimal vtenderedd = ceTendered.Value;
			decimal vtotamntt = decimal.Parse(txtTotAmnt.Text);
			decimal vchangee = 0;
			try
			{
				vchangee = vtenderedd - vtotamntt;
				txtChange.Text = Strings.FormatNumber((vchangee).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void SimpleButton10_Click(object sender, EventArgs e)
		{
			
		}
	}
}
