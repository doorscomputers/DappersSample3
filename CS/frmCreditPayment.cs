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
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;

namespace DoorsPOS.WinApp
{
	public partial class frmCreditPayment
	{
		public frmCreditPayment()
		{
			InitializeComponent();
		}
		public void btnsearch_Click(object sender, EventArgs e)
		{
			//'Dim mgr As New membersManager
			//'Dim cols As membersCollection
			//'mgr.DataObject.SelectFilter = membersData.SelectFilters.WithBalance
			//'mgr.DataObject.OrderByFilter = membersData.OrderByFilters.lastname
			//'cols = mgr.BuildCollection()
			//'GridControl1.DataSource = cols
			//gridControl1.Visible = True
			//gridControl1.Focus()
			//'SendKeys.Send("CTRL" + "F")
			InvokeSearch();
		}
		public void InvokeSearch()
		{
			gridControl1.Visible = true;
			gridControl1.Focus();
		}
		public void btnsave_Click(object sender, EventArgs e)
		{
			if (ceamount.Value <= 0)
			{
				MessageBox.Show("Please enter an amount paid by the customer.");
				return;
			}
			
			if ((depaydate.EditValue).ToString() == "")
			{
				MessageBox.Show("Please enter the date paid by the customer.");
				return;
			}
			
			if (txtcheque.Text != "")
			{
				if (txtbank.Text == "" || txtacntname.Text == "")
				{
					MessageBox.Show("Please enter cheque details like Cheque #, Bank Name and Account Name.");
					return;
				}
			}
			
			if (cebalance.Value <= 0)
			{
				MessageBox.Show("Customer has zero balance but you can still accept payment.");
			}
			
			int ansint = 7;
			ansint = (int) (Interaction.MsgBox("Are you sure you want to Save the payment?", MsgBoxStyle.YesNo, "Payment Confirmation"));
			if (ansint == 6)
			{
				try
				{
					PDSA.DataLayer.DataClasses.PDSATransaction tranmgr = default(PDSA.DataLayer.DataClasses.PDSATransaction);
					membersManager mgr = new membersManager();
					tblreadingManager mgrrdng = new tblreadingManager();
					tranmgr = new PDSA.DataLayer.DataClasses.PDSATransaction();
					mgr.DataObject.LoadByPK(int.Parse(txtcustid.Text));
					decimal vresult = Convert.ToDecimal(cebalance.Value - ceamount.Value);
					mgr.Entity.Balance = vresult;
					mgr.DataObject.UpdateFilter = membersData.UpdateFilters.PrimaryKey;
					tranmgr.Add(mgr.DataObject);
					//mgr.DataObject.Update()
					///'''''''''''''
					paymentManager mgrpay = new paymentManager();
					mgrpay.Entity.CustID = Convert.ToInt32(txtcustid.Text);
					mgrpay.Entity.PayDate = System.Convert.ToDateTime(depaydate.EditValue);
					mgrpay.Entity.BankName = txtbank.Text;
					mgrpay.Entity.AccountName = txtacntname.Text;
					mgrpay.Entity.CheckNo = txtcheque.Text;
					mgrpay.Entity.Amount = Convert.ToDecimal(ceamount.Value);
					mgrpay.Entity.OldBal = Convert.ToDecimal(cebalance.Value);
					mgrpay.Entity.NewBal = Convert.ToDecimal(cebalance.Value) - Convert.ToDecimal(ceamount.Value);
					mgrpay.Entity.Remarks = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					mgrpay.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					mgrpay.Entity.TimeEncoded = DateAndTime.Now;
					//mgrpay.DataObject.Insert()
					tranmgr.Add(mgrpay.DataObject);
					
					mgrrdng.DataObject.SelectFilter = tblreadingData.SelectFilters.All;
					mgrrdng.DataObject.WhereFilter = tblreadingData.WhereFilters.CashierStatus;
					mgrrdng.Entity.cashier = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					mgrrdng.DataObject.Load();
					if (mgrrdng.DataObject.RowsAffected > 0)
					{
						mgrrdng.Entity.payments = mgrrdng.Entity.payments + Convert.ToDecimal(ceamount.Value);
						mgrrdng.DataObject.UpdateFilter = tblreadingData.UpdateFilters.PrimaryKey;
					}
					mgr.DataObject.TransactionType = PDSA.DataLayer.DataClasses.PDSATransactionType.Update;
					mgrpay.DataObject.TransactionType = PDSA.DataLayer.DataClasses.PDSATransactionType.Insert;
					mgrrdng.DataObject.TransactionType = PDSATransactionType.Update;
					tranmgr.Add(mgrrdng.DataObject);
					
					//tranmgr = New PDSATransaction()
					//tranmgr.Add(mgr.DataObject)
					//tranmgr.Add(mgrpay.DataObject)
					//tranmgr.Add(mgrrdng.DataObject)
					tranmgr.Execute();
					
					xrCustPayReceipt pospaycredit = new xrCustPayReceipt();
					//AddHandler pospaycredit.PrintingSystem.StartPrint, AddressOf ReportOnStartPrint
					//posrep.DataSource = sqlDT
					pospaycredit.cID.Value = int.Parse(txtcustid.Text);
					pospaycredit.CurDate.Value = System.Convert.ToDateTime(depaydate.EditValue);
					pospaycredit.RequestParameters = false;
					pospaycredit.PrintingSystem.ShowMarginsWarning = false;
					
					pospaycredit.Print();
					
					
					disable();
					initialvals();
					
					
					//MessageBox.Show(CStr(mgr.DataObject.SQL))
					MessageBox.Show("Payment successfully saved.");
					
					this.Close();
				}
				catch (PDSA.Validation.PDSAValidationException ex)
				{
					MessageBox.Show(ex.Message);
				}
				catch (Exception ex)
				{
					DisplayException(ex);
				}
			}
		}
		private void ReportOnStartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
		{
			e.PrintDocument.PrinterSettings.Copies = (short) 2;
		}
		private void DisplayException(Exception ex)
		{
			//tbException.Text = ex.ToString()
			MessageBox.Show(ex.ToString());
			//MessageBox.Show("Exception Occurred. Check the Exception Tab for More Info.")
		}
		public void frmCreditPayment_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		public void frmCreditPayment_Load(object sender, EventArgs e)
		{
			//TODO: This line of code loads data into the 'DsBalance.MemberBalance' table. You can move, or remove it, as needed.
			this.MemberBalanceTableAdapter.Fill(this.DsBalance.MemberBalance);
			gridControl1.Enabled = true;
			btnnew.Focus();
		}
		public void enable()
		{
			btnnew.Enabled = false;
			btnsave.Enabled = true;
			btncancel.Enabled = true;
			btnclose.Enabled = false;
			btnsearch.Enabled = true;
		}
		public void disable()
		{
			btnnew.Enabled = true;
			btnsave.Enabled = false;
			btncancel.Enabled = false;
			btnclose.Enabled = true;
			btnsearch.Enabled = false;
		}
		public void initialvals()
		{
			txtcustid.Text = string.Empty;
			txtlast.Text = string.Empty;
			txtfirst.Text = string.Empty;
			cebalance.Value = 0;
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
			InvokeSearch();
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
				ans = (int) (Interaction.MsgBox("Pending Credit payment transaction not saved. Click Yes to Save or No to Cancel Payment and Close the form.", MsgBoxStyle.YesNo, null));
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
		public void gridControl1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				
				string value = "";
				string vlast = string.Empty;
				string vfirst = string.Empty;
				string vmid = string.Empty;
				string vcustid = string.Empty;
				decimal vbal = 0;
				
				if (GridView1.SelectedRowsCount > 0)
				{
					vlast = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, "lastname").ToString();
					//value = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, "custid").ToString
					vfirst = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "firstname").ToString();
					vbal = Convert.ToDecimal(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "balance"));
					value = (GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns[3])).ToString();
					//vcustid = CStr(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(4)))
					vcustid = GridView1.GetRowCellDisplayText(GridView1.FocusedRowHandle, GridView1.Columns["custid"]);
					txtcustid.Text = vcustid;
					txtlast.Text = vfirst;
					txtfirst.Text = vlast;
					cebalance.Value = vbal;
					gridControl1.Visible = false;
					depaydate.Focus();
				}
			}
		}
	}
}
