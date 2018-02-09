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

using DevExpress.XtraEditors;
using PDSA.DataLayer.DataClasses;
using PDSA.Validation;
//using DynamicComponents.Number2Text;

namespace DoorsPOS.WinApp
{
	public partial class frmDrPayment
	{
		public frmDrPayment()
		{
			InitializeComponent();
		}
		DynamicComponents.Number2Text oTextNum = new DynamicComponents.Number2Text();
		dlvry_hdrManager mgrSupBal = new dlvry_hdrManager();
		dlvry_hdrCollection colSupBal;
		decimal Tots = 0;
		private PDSA.DataLayer.DataClasses.PDSATransaction TranPayment; //Payment Transaction
		paymnthdrManager mgrHP; // Payment HEader Manager
		paymntdetlManager mgrDP; //Payment Detail Manager
		int mPid = 0;
		dlvry_hdrManager mgrdlvry;
		suppliersManager mgrSupplier;
		
		public void frmDrPayment_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmDrPayment_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Dim vRowss As Integer = dgPayment.Rows.Count
			//If vRowss > 0 Then
			//    MessageBox.Show("Payment List Exist. Please Save before closing the Delivery Entry Form.")
			//    e.Cancel = True
			//End If
		}
		public void frmDrPayment_Load(object sender, EventArgs e)
		{
			oTextNum = new DynamicComponents.Number2Text();
			this.Cursor = Cursors.WaitCursor;
			LoadBank();
			LoadSupplier();
			this.Cursor = Cursors.Default;
			GroupControl1.Enabled = false;
			GroupControl2.Enabled = false;
		}
		public void leBank_LostFocus(object sender, EventArgs e)
		{
			//MessageBox.Show(CStr(leBank.EditValue))
		}
		
		private void LoadBank()
		{
			try
			{
				//Dim mgrbank As bankManager = New bankManager()
				//Dim colbank As bankCollection
				
				//mgrbank.DataObject.SelectFilter = bankData.SelectFilters.All
				//colbank = mgrbank.BuildCollection()
				//leBank.Properties.DisplayMember = "bank"
				//leBank.Properties.ValueMember = "bankid"
				//leBank.Properties.DataSource = colbank
				spBanksManager mgrbank = new spBanksManager();
				spBanksCollection colbank = mgrbank.BuildCollection();
				
				leBank.Properties.DisplayMember = "bank";
				leBank.Properties.ValueMember = "bankid";
				leBank.Properties.DataSource = colbank;
				//leBank.Properties.Columns(0).Visible = False
			}
			catch (PDSA.Validation.PDSAValidationException ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return;
			}
			
		}
		
		private void LoadSupplier()
		{
			try
			{
				suppliersManager mgrs = new suppliersManager();
				mgrs.DataObject.OrderByFilter = suppliersData.OrderByFilters.supplier;
				suppliersCollection cols = default(suppliersCollection);
				cols = mgrs.BuildCollection();
				leSupplier.Properties.DisplayMember = "supplier";
				leSupplier.Properties.ValueMember = "supcode";
				leSupplier.Properties.DataSource = cols;
			}
			catch (PDSA.Validation.PDSAValidationException ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return;
			}
			
		}
		
		private void LoadSupBal()
		{
			try
			{
				mgrSupBal.DataObject.WhereFilter = dlvry_hdrData.WhereFilters.SupplierUnpd;
				mgrSupBal.Entity.supcode = System.Convert.ToInt32(leSupplier.EditValue);
				colSupBal = mgrSupBal.BuildCollection();
				
				ledrs.Properties.DisplayMember = "drinv";
				ledrs.Properties.ValueMember = "drid";
				ledrs.Properties.DataSource = colSupBal;
			}
			catch (PDSA.Validation.PDSAValidationException ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return;
			}
		}
		
		private void GetBalAmnt()
		{
			dlvry_hdrManager mgrGetbal = new dlvry_hdrManager();
			int vInt = 0;
			vInt = System.Convert.ToInt32(ledrs.EditValue);
			mgrGetbal.DataObject.LoadByPK(vInt);
			ceAmount.Value = mgrGetbal.DataObject.Entity.drbal;
			
		}
		public void EnableBtns()
		{
			try
			{
				dgPayment.Rows.Clear();
				GroupControl2.Enabled = true;
				GroupControl1.Enabled = true;
				btnSave.Enabled = true;
				btnCancel.Enabled = true;
				btnNew.Enabled = false;
				deDatePaid.EditValue = DateAndTime.Today;
				deChkDate.EditValue = DateAndTime.Today;
				//Catch ex As PDSAValidationException
				//    MessageBox.Show(ex.Message)
				//    Exit Sub
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return;
			}
		}
		
		public void DisableBtns()
		{
			try
			{
				
				GroupControl2.Enabled = false;
				GroupControl1.Enabled = false;
				btnSave.Enabled = false;
				btnCancel.Enabled = false;
				btnNew.Enabled = true;
				btnSave.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return;
			}
		}
		
		public void btnSave_Click(object sender, EventArgs e)
		{
			decimal vAp = 0; // vAP is equal to Amount Paid
			decimal vTotP = 0; // Total Invoices
			if (txtTotInv.Text == "0" || txtTotInv.Text == string.Empty)
			{
				MessageBox.Show("No item in the list to process");
				return;
			}
			if (txtChkNo.Text == string.Empty)
			{
				MessageBox.Show("Please enter a cheque no. before saving.");
				return;
			}
			
			if (deDatePaid.Text == string.Empty)
			{
				MessageBox.Show("Date Paid must not be blank.");
				return;
			}
			
			int grdcounts = 0;
			grdcounts = dgPayment.Rows.Count;
			if (grdcounts < 1)
			{
				MessageBox.Show("No item in the list to process");
				return;
			}
			
			vAp = ceAmntPd.Value;
			vTotP = decimal.Parse(txtTotInv.Text);
			if (vAp != vTotP)
			{
				MessageBox.Show("Please make sure the Total Amount Paid is equal than the Total Invoice(s) Balance to be Paid.", "Amount not Equal", MessageBoxButtons.OK);
				return;
			}
			
			int ansint = 0;
			ansint = 7;
			ansint = (int) (Interaction.MsgBox("Please make sure you selected the correct supplier and entered the correct invoice(s) and totals before clicking yes!", MsgBoxStyle.YesNo, null));
			if (ansint == 7)
			{
				return;
			}
			//Call Save Payment Procedure
			SavePayment();
			DisableBtns();
			ClearCtrls();
			btnNew.Focus();
		}
		private void SavePayment()
		{
			int grdCount = 0;
			int iii = 0;
			TranPayment = new PDSA.DataLayer.DataClasses.PDSATransaction();
			TranPayment.AfterSubmit += TranPayment_AfterSubmit;
			TranPayment.BeforeSubmit += Tranpayment_BeforeSubmit;
			mgrHP = new paymnthdrManager();
			mgrHP.DataObject.TransactionType = PDSATransactionType.Insert;
			try
			{
				//Save Header Section of Invoice Payment
				mgrHP.Entity.paydate = DateTime.Parse(deDatePaid.Text);
				mgrHP.Entity.amntpaid = ceAmntPd.Value;
				mgrHP.Entity.bankid = System.Convert.ToInt32(leBank.EditValue);
				mgrHP.Entity.chqdate = DateTime.Parse(deChkDate.Text);
				//mgrHP.Entity.dtInsertdt = Date.Now
				//mgrHP.Entity.dtLastUpdatedt = Date.Now
				mgrHP.Entity.chqno = txtChkNo.Text.Trim();
				mgrHP.Entity.remarks = txtremarks.Text.Trim();
				mgrHP.Entity.supcode = System.Convert.ToInt32(leSupplier.EditValue);
				
				mgrHP.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				TranPayment.Add(mgrHP.DataObject);
				TranPayment.Execute();
				grdCount = dgPayment.Rows.Count;
				//TranPayment = New PDSATransaction()
				for (iii = 0; iii <= grdCount - 1; iii++)
				{
					mgrDP = new paymntdetlManager();
					mgrDP.DataObject.TransactionType = PDSATransactionType.Insert;
					mgrDP.Entity.payid = mPid;
					mgrDP.Entity.drinv = (dgPayment.Rows[iii].Cells[1].Value).ToString();
					mgrDP.Entity.amnt = System.Convert.ToDecimal(dgPayment.Rows[iii].Cells[2].Value);
					mgrDP.Entity.drid = System.Convert.ToInt32(dgPayment.Rows[iii].Cells[0].Value);
					TranPayment.Add(mgrDP.DataObject);
					//TranPayment.Execute()
					//Update dlvry_hdr paid field to true
					mgrdlvry = new dlvry_hdrManager();
					//TranPayment = New PDSATransaction()
					mgrdlvry.DataObject.SelectFilter = dlvry_hdrData.SelectFilters.All;
					mgrdlvry.DataObject.LoadByPK(System.Convert.ToInt32(dgPayment.Rows[iii].Cells[0].Value));
					mgrdlvry.DataObject.TransactionType = PDSATransactionType.Update;
					mgrdlvry.Entity.paid = true;
					TranPayment.Add(mgrdlvry.DataObject);
					//TranPayment.Execute()
					//Update the balance on suppliers by subtractivng the amount to the current balance
					mgrSupplier = new suppliersManager();
					//TranPayment = New PDSATransaction()
					mgrSupplier.DataObject.SelectFilter = suppliersData.SelectFilters.All;
					mgrSupplier.DataObject.LoadByPK(System.Convert.ToInt32(leSupplier.EditValue));
					mgrSupplier.DataObject.TransactionType = PDSATransactionType.Update;
					mgrSupplier.Entity.balance = mgrSupplier.Entity.balance - decimal.Parse(txtTotInv.Text);
					TranPayment.Add(mgrSupplier.DataObject);
					//TranPayment.Execute()
				}
				//execute Transaction on Payment Saving and Update the Paid to true on dlvry_hdr
				//to exclude in the payment selection
				TranPayment.Execute();
				//Stored Proc
				//Dim TranDrSp As New PDSATransaction()
				//Dim mgrspDrTrans As New spDlvryProcManager()
				//mgrspDrTrans.Entity.drdrid = mPid
				//mgrspDrTrans.Entity.supcode = CInt(Trim(txtSupcode.Text))
				//TranDrSp.Add(mgrspDrTrans.DataObject)
				//TranDrSp.Execute()
				MessageBox.Show("Invoice Payment Successfully Saved.");
				DisableBtns();
			}
			catch (PDSA.Validation.PDSAValidationException ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				MessageBox.Show(mgrSupplier.DataObject.ClassName);
				MessageBox.Show(mgrSupplier.DataObject.SQL);
				return;
			}
		}
		private void TranPayment_AfterSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			if (e.ClassName == "paymnthdrData")
			{
				mPid = ((paymnthdr) e.DataClassTable.EntityObject).payid;
			}
		}
		private void Tranpayment_BeforeSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			// Put local order id into line item objects prior to submitting INSERT statement
			if (e.ClassName == "paymntdetlData")
			{
				((paymntdetl) e.DataClassTable.EntityObject).payid = mPid;
			}
		}
		public void btnNew_Click(object sender, EventArgs e)
		{
			EnableBtns();
		}
		
		public void btnCancel_Click(object sender, EventArgs e)
		{
			int ansint = 0;
			ansint = 7;
			ansint = (int) (Interaction.MsgBox("Please make sure you selected the correct supplier and entered the correct items and totals before clicking yes!", MsgBoxStyle.YesNo, null));
			if (ansint == 7)
			{
				return;
			}
			DisableBtns();
			ClearCtrls();
		}
		public void SendItemtoGrid()
		{
			
			int I = 0;
			int ItemLoc = -1;
			int nDrid = 0;
			try
			{
				nDrid = int.Parse(ledrs.Text);
				for (I = 0; I <= dgPayment.Rows.Count - 1; I++)
				{
					//nDrid = CInt(ledrs.Text) 'If nDrid = CInt(dgPayment.Rows(I).Cells(1).Value) Then
					if (nDrid == System.Convert.ToInt32(dgPayment.Rows[I].Cells[1].Value))
					{
						// item found
						ItemLoc = I;
						break;
					}
				}
				// if item is not found, add it
				if (ItemLoc == -1)
				{
					int vInv = 0;
					string vBal = "";
					vInv = System.Convert.ToInt32(ledrs.EditValue);
					dgPayment.Rows.Add(vInv, ledrs.Text, ceAmount.Value);
				}
				else
				{
					//MessageBox.Show("Invoice No. is already on the list to be paid.")
					return;
				}
				
				Tots = 0;
				if (dgPayment.Rows.Count >= 1)
				{
					for (I = 0; I <= dgPayment.Rows.Count - 1; I++)
					{
						Tots += System.Convert.ToDecimal(dgPayment.Rows[I].Cells[2].Value);
					}
				}
				
				//Scroll to the last row.
				this.dgPayment.FirstDisplayedScrollingRowIndex = this.dgPayment.RowCount - 1;
				
				//Select the last row.
				this.dgPayment.Rows[this.dgPayment.RowCount - 1].Selected = true;
				
				//CalcEdit1.Value = Tots
				txtTotInv.Text = Strings.FormatNumber((Tots).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
				
			}
			catch (PDSA.Validation.PDSAValidationException ex)
			{
				MessageBox.Show(ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		public void txtremarks_LostFocus(object sender, EventArgs e)
		{
			ledrs.Focus();
		}
		
		public void ledrs_GotFocus(object sender, EventArgs e)
		{
			LoadSupBal();
		}
		
		public void ledrs_LostFocus(object sender, EventArgs e)
		{
			if (ledrs.Text != "")
			{
				GetBalAmnt();
				//ceAmount.Value = mgrSupBal.DataObject.Entity.drbal
			}
		}
		
		public void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if (ledrs.Text != "" && (double) ceAmount.Value >= 0.1)
				{
					SendItemtoGrid();
					ledrs.Text = "";
					ceAmount.Value = 0;
					ledrs.Focus();
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return;
			}
		}
		
		public void dgPayment_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				decimal Totss = 0;
				int ansint = 7;
				ansint = (int) (Interaction.MsgBox("Are you sure you want Delete the selected Payment?", MsgBoxStyle.YesNo, "Delete Row Confirmation"));
				if (ansint == 6)
				{
					int ii = 0;
					try
					{
						dgPayment.Rows.Remove(dgPayment.SelectedRows[0]);
						for (ii = 0; ii <= dgPayment.Rows.Count - 1; ii++)
						{
							Totss += System.Convert.ToDecimal(dgPayment.Rows[ii].Cells[2].Value);
						}
						txtTotInv.Text = Strings.FormatNumber((Totss).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
					}
					catch (PDSA.Validation.PDSAValidationException ex)
					{
						MessageBox.Show(ex.Message);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString());
					}
				}
			}
		}
		private void ClearCtrls()
		{
			deDatePaid.EditValue = DateAndTime.Today;
			ceAmntPd.Value = 0;
			deChkDate.EditValue = DateAndTime.Today;
			txtChkNo.Text = string.Empty;
			leBank.Text = string.Empty;
			leSupplier.Text = string.Empty;
			txtremarks.Text = string.Empty;
			ledrs.Text = string.Empty;
			ceAmount.Value = 0;
			txtTotInv.Text = "0";
		}
		
		public void txtTotInv_GotFocus(object sender, EventArgs e)
		{
			txtTotInv.Enabled = false;
		}
		
		public void txtTotInv_LostFocus(object sender, EventArgs e)
		{
			txtTotInv.Enabled = true;
		}
		
		public void txtChkNo_LostFocus(object sender, EventArgs e)
		{
			if (txtChkNo.Text != "")
			{
				try
				{
					paymnthdrManager mgrchq = new paymnthdrManager();
					mgrchq.DataObject.SelectFilter = paymnthdrData.SelectFilters.All;
					mgrchq.DataObject.WhereFilter = paymnthdrData.WhereFilters.chqno;
					mgrchq.Entity.chqno = txtChkNo.Text.Trim();
					mgrchq.DataObject.Load();
					if (mgrchq.DataObject.RowsAffected > 0)
					{
						MessageBox.Show("Cheque no. is already Issued", "Cheque No. Duplicate", MessageBoxButtons.OK);
					}
				}
				catch (PDSA.Validation.PDSAValidationException ex)
				{
					MessageBox.Show(ex.Message);
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return;
				}
			}
		}
		
		private void textOfNumber()
		{
			
			oTextNum.setRegistrationKey("3842-539-837-306-5999"); // replace with your purchased serial number once you get one
			
			oTextNum.setCurrency("Peso", "Pesos", "cent", "cents");
			this.txtremarks.RightToLeft = RightToLeft.No;
			this.txtremarks.Text = oTextNum.translateNumber((valid(this.ceAmount.Text)).ToString(), DynamicComponents.Number2Text.Language_ID.English);
			
		}
		private decimal valid(string str)
		{
			//On Error Resume Next VBConversions Warning: On Error Resume Next not supported in C#
			if (str == "")
			{
				return decimal.Parse("0.0");
			}
			else
			{
				return decimal.Parse(str);
			}
			
		}
		
		public void ceAmount_Leave(object sender, EventArgs e)
		{
			textOfNumber();
		}
	}
}
