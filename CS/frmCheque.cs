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

using PDSA.DataLayer.DataClasses;
using PDSA.Validation;

namespace DoorsPOS.WinApp
{
	public partial class frmCheque
	{
		public frmCheque()
		{
			InitializeComponent();
		}
		public void btnsave_Click(object sender, EventArgs e)
		{
			if (ceamount.Value <= 0)
			{
				MessageBox.Show("Please enter cheque amount.");
				ceamount.Focus();
				return;
			}
			
			if ((depaydate.EditValue).ToString() == "")
			{
				MessageBox.Show("Please enter cheque amount.");
				depaydate.Focus();
				return;
			}
			
			if (txtcheque.Text == "" || txtcheque.Text == string.Empty)
			{
				MessageBox.Show("Please enter cheque details like Cheque #, Bank and Account Name.");
				txtcheque.Focus();
				return;
			}
			if (txtbank.Text == "" || txtbank.Text == string.Empty)
			{
				MessageBox.Show("Please enter cheque details like Name of Bank and Account Name.");
				txtbank.Focus();
				return;
			}
			
			if (txtacntname.Text == "" || txtacntname.Text == string.Empty)
			{
				MessageBox.Show("Please enter cheque details like Name of Bank and Account Name.");
				txtacntname.Focus();
				return;
			}
			
			
			int ansint = 7;
			ansint = (int) (Interaction.MsgBox("Are you sure you want to Save the Cheque payment?", MsgBoxStyle.YesNo, "Cheque Payment Confirmation"));
			if (ansint == 6)
			{
				try
				{
					PDSATransaction tranmgr = new PDSATransaction();
					chkpayManager mgrpay = new chkpayManager();
					tblreadingManager mgrrdng = new tblreadingManager();
					
					///''''''''''''
					
					mgrpay.Entity.chkdate = System.Convert.ToDateTime(depaydate.EditValue);
					mgrpay.Entity.bank = txtbank.Text;
					mgrpay.Entity.payee = txtacntname.Text;
					mgrpay.Entity.chkno = txtcheque.Text;
					mgrpay.Entity.amnt = Convert.ToDecimal(ceamount.Value);
					mgrpay.Entity.chkremark = txtremark.Text;
					mgrpay.Entity.cashier = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					//mgrpay.DataObject.Insert()
					
					mgrrdng.DataObject.SelectFilter = tblreadingData.SelectFilters.All;
					mgrrdng.DataObject.WhereFilter = tblreadingData.WhereFilters.CashierStatus;
					mgrrdng.Entity.cashier = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					mgrrdng.DataObject.Load();
					if (mgrrdng.DataObject.RowsAffected > 0)
					{
						mgrrdng.Entity.totalcheque = Convert.ToDecimal(ceamount.Value) + mgrrdng.Entity.totalcheque;
						mgrrdng.DataObject.UpdateFilter = tblreadingData.UpdateFilters.PrimaryKey;
					}
					
					mgrpay.DataObject.TransactionType = PDSA.DataLayer.DataClasses.PDSATransactionType.Insert;
					mgrrdng.DataObject.TransactionType = PDSATransactionType.Update;
					tranmgr.Add(mgrpay.DataObject);
					tranmgr.Add(mgrrdng.DataObject);
					tranmgr.Execute();
					
					disable();
					initialvals();
					MessageBox.Show("Cheque Payment successfully saved.");
				}
				catch (PDSAValidationException ex)
				{
					MessageBox.Show(ex.Message);
				}
				catch (Exception ex)
				{
					DisplayException(ex);
				}
				
				this.Close();
			}
		}
		private void DisplayException(Exception ex)
		{
			//tbException.Text = ex.ToString()
			MessageBox.Show(ex.ToString());
			//MessageBox.Show("Exception Occurred. Check the Exception Tab for More Info.")
		}
		
		public void enable()
		{
			btnnew.Enabled = false;
			btnsave.Enabled = true;
			btncancel.Enabled = true;
			btnclose.Enabled = false;
		}
		public void disable()
		{
			btnnew.Enabled = true;
			btnsave.Enabled = false;
			btncancel.Enabled = false;
			btnclose.Enabled = true;
		}
		public void initialvals()
		{
			ceamount.Value = 0;
			txtacntname.Text = string.Empty;
			txtbank.Text = string.Empty;
			txtcheque.Text = string.Empty;
			depaydate.EditValue = DateAndTime.Today;
		}
		
		public void btnnew_Click(object sender, EventArgs e)
		{
			enable();
			initialvals();
		}
		
		public void btncancel_Click(object sender, EventArgs e)
		{
			int ansint = 7;
			ansint = (int) (Interaction.MsgBox("Are you sure you want to cancel the payment?", MsgBoxStyle.YesNo, "Cancel Confirmation"));
			if (ansint == 6)
			{
				disable();
				initialvals();
			}
		}
		
		public void btnclose_Click(object sender, EventArgs e)
		{
			if (btnsave.Enabled == true)
			{
				int ans = 0;
				ans = (int) (Interaction.MsgBox("Pending Cheque payment transaction not saved. Click Yes to Save or No to Cancel Payment and Close the form.", MsgBoxStyle.YesNo, null));
				if (ans == 7)
				{
					return;
				}
				else
				{
					this.Close();
				}
			}
			else
			{
				this.Close();
			}
		}
		
		public void frmCheque_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmCheque_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				if (btnsave.Enabled == true)
				{
					int ans = 0;
					ans = (int) (Interaction.MsgBox("Pending Cheque payment transaction not saved. Click Yes to Save or No to Cancel Payment and Close the form.", MsgBoxStyle.YesNo, null));
					if (ans == 7)
					{
						return;
					}
					else
					{
						this.Close();
					}
				}
				else
				{
					this.Close();
				}
			}
		}
		
		public void frmCheque_Load(object sender, EventArgs e)
		{
			depaydate.EditValue = DateAndTime.Today;
		}
	}
}
