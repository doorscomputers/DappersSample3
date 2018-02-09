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
using DevExpress.XtraEditors.Controls;
//using System.Windows.Forms.Form;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;

namespace DoorsPOS.WinApp
{
	public partial class frmReading
	{
		public frmReading()
		{
			InitializeComponent();
		}
		
		public void ceCheque_GotFocus(object sender, EventArgs e)
		{
			ceCheque.SelectAll();
		}
		//Private Sub ceCheque_EditValueChanged(sender As Object, e As EventArgs) Handles ceCheque.EditValueChanged
		//    Dim decCheque As Decimal = 0
		
		//    decCheque = CDec(ceCheque.Text) * 1
		//    Dim amnt As Decimal = 0
		//    'Cheque.Text = FormatNumber(CStr(decCheque), 2)
		//    amnt = Convert.ToDecimal(Cheque.Text) + Convert.ToDecimal(Thousand.Text) + Convert.ToDecimal(FiveHundred.Text) + Convert.ToDecimal(twohundred.Text) + Convert.ToDecimal(OneHundred.Text) + Convert.ToDecimal(Fifty.Text) + Convert.ToDecimal(Twenty.Text) + Convert.ToDecimal(Ten.Text) + Convert.ToDecimal(Five.Text) + Convert.ToDecimal(One.Text) + Convert.ToDecimal(Cents.Text)
		//    'amnt = CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text)
		//    TotalAmount.Text = FormatNumber(CStr(amnt), 2)
		//End Sub
		
		//Private Sub ceThousand_EditValueChanged(sender As Object, e As EventArgs) Handles ceThousand.EditValueChanged
		//    Thousand.Text = CStr(CDec(ceThousand.Value * 1000))
		//    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
		//End Sub
		
		//Private Sub ceFiveHundred_EditValueChanged(sender As Object, e As EventArgs) Handles ceFiveHundred.EditValueChanged
		//    FiveHundred.Text = CStr(CDec(ceFiveHundred.Value * 500))
		//    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
		//End Sub
		
		//Private Sub ceTwoHundred_EditValueChanged(sender As Object, e As EventArgs) Handles ceTwoHundred.EditValueChanged
		//    twohundred.Text = CStr(CDec(ceTwoHundred.Value * 200))
		//    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
		//End Sub
		
		//Private Sub ceOneHundred_EditValueChanged(sender As Object, e As EventArgs) Handles ceOneHundred.EditValueChanged
		//    OneHundred.Text = CStr(CDec(ceOneHundred.Value * 100))
		//    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
		//End Sub
		
		//Private Sub ceFifty_EditValueChanged(sender As Object, e As EventArgs) Handles ceFifty.EditValueChanged
		//    Fifty.Text = CStr(CDec(ceFifty.Value * 50))
		//    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
		//End Sub
		
		//Private Sub ceTwenty_EditValueChanged(sender As Object, e As EventArgs) Handles ceTwenty.EditValueChanged
		//    Twenty.Text = CStr(CDec(ceTwenty.Value * 20))
		//    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
		//End Sub
		
		//Private Sub ceTen_EditValueChanged(sender As Object, e As EventArgs) Handles ceTen.EditValueChanged
		//    Ten.Text = CStr(CDec(ceTen.Value * 10))
		//    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
		//End Sub
		
		//Private Sub ceFive_EditValueChanged(sender As Object, e As EventArgs) Handles ceFive.EditValueChanged
		//    Five.Text = CStr(CDec(ceFive.Value * 5))
		//    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
		//End Sub
		
		//Private Sub ceOne_EditValueChanged(sender As Object, e As EventArgs) Handles ceOne.EditValueChanged
		//    One.Text = CStr(CDec(ceOne.Value * 1))
		//    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
		//End Sub
		
		//Private Sub ceCents_EditValueChanged(sender As Object, e As EventArgs) Handles ceCents.EditValueChanged
		//    Cents.Text = CStr(CDec(ceCents.Value * 0.25))
		//    TotalAmount.Text = CStr(CDec(Cheque.Text) + CDec(Thousand.Text) + CDec(FiveHundred.Text) + CDec(twohundred.Text) + CDec(OneHundred.Text) + CDec(Fifty.Text) + CDec(Twenty.Text) + CDec(Ten.Text) + CDec(Five.Text) + CDec(One.Text) + CDec(Cents.Text))
		//End Sub
		
		public void ceCheque_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				e.Handled = true;
				ceThousand.Focus();
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				ceThousand.Focus();
				calcgt();
				ceThousand.Focus();
			}
			
		}
		
		public void ceThousand_GotFocus(object sender, EventArgs e)
		{
			ceThousand.SelectAll();
		}
		
		public void ceThousand_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				e.Handled = true;
				ceCheque.Focus();
			}
			if (e.KeyCode == Keys.Down)
			{
				e.Handled = true;
				ceFiveHundred.Focus();
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				cekAmnt.Value = ceThousand.Value * 1000;
				calcgt();
				ceFiveHundred.Focus();
			}
			
		}
		
		public void ceFiveHundred_GotFocus(object sender, EventArgs e)
		{
			ceFiveHundred.SelectAll();
		}
		
		public void ceFiveHundred_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				ceThousand.Focus();
			}
			if (e.KeyCode == Keys.Down)
			{
				ceTwoHundred.Focus();
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				cefivehamnt.Value = ceFiveHundred.Value * 500;
				ceGT.Value = 0;
				calcgt();
				ceTwoHundred.Focus();
			}
		}
		
		public void ceTwoHundred_GotFocus(object sender, EventArgs e)
		{
			ceTwoHundred.SelectAll();
		}
		
		public void ceTwoHundred_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				ceFiveHundred.Focus();
			}
			if (e.KeyCode == Keys.Down)
			{
				ceOneHundred.Focus();
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				cethamnt.Value = ceTwoHundred.Value * 200;
				ceGT.Value = 0;
				calcgt();
			}
		}
		
		public void ceOneHundred_GotFocus(object sender, EventArgs e)
		{
			ceOneHundred.SelectAll();
		}
		
		public void ceOneHundred_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				ceTwoHundred.Focus();
			}
			if (e.KeyCode == Keys.Down)
			{
				ceFifty.Focus();
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				ceonehundredamnt.Value = ceOneHundred.Value * 100;
				ceGT.Value = 0;
				calcgt();
			}
		}
		
		public void ceFifty_GotFocus(object sender, EventArgs e)
		{
			ceFifty.SelectAll();
		}
		
		public void ceFifty_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				ceOneHundred.Focus();
			}
			if (e.KeyCode == Keys.Down)
			{
				ceTwenty.Focus();
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				cefiftyamnt.Value = ceFifty.Value * 50;
				ceGT.Value = 0;
				calcgt();
			}
		}
		
		public void ceTwenty_GotFocus(object sender, EventArgs e)
		{
			ceTwenty.SelectAll();
		}
		
		public void ceTwenty_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				ceFifty.Focus();
			}
			if (e.KeyCode == Keys.Down)
			{
				ceTen.Focus();
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				cetwentyamnt.Value = ceTwenty.Value * 20;
				ceGT.Value = 0;
				calcgt();
			}
		}
		
		public void ceTen_GotFocus(object sender, EventArgs e)
		{
			ceTen.SelectAll();
		}
		
		public void ceTen_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				ceTwenty.Focus();
			}
			if (e.KeyCode == Keys.Down)
			{
				ceFive.Focus();
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				cetenamnt.Value = ceTen.Value * 10;
				ceGT.Value = 0;
				calcgt();
			}
		}
		
		public void ceFive_GotFocus(object sender, EventArgs e)
		{
			ceFive.SelectAll();
		}
		
		public void ceFive_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				ceTen.Focus();
			}
			if (e.KeyCode == Keys.Down)
			{
				ceOne.Focus();
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				cefiveamnt.Value = ceFive.Value * 5;
				ceGT.Value = 0;
				calcgt();
			}
		}
		
		public void ceOne_GotFocus(object sender, EventArgs e)
		{
			ceOne.SelectAll();
		}
		
		public void ceOne_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				ceFive.Focus();
			}
			if (e.KeyCode == Keys.Down)
			{
				ceCents.Focus();
			}
			if (e.KeyCode == Keys.Enter)
			{
				ceonepesoamnt.Value = ceOne.Value * 1;
				ceGT.Value = 0;
				calcgt();
			}
		}
		
		public void ceCents_GotFocus(object sender, EventArgs e)
		{
			ceCents.SelectAll();
		}
		
		public void ceCents_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				ceOne.Focus();
			}
			if (e.KeyCode == Keys.Down)
			{
				btnSave.Focus();
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				cecentsamnt.Value = (decimal) (ceCents.Value * 0.25);
				ceGT.Value = 0;
				calcgt();
			}
		}
		
		private void calcgt()
		{
			ceGT.Value = ceCheque.Value + cekAmnt.Value + cefivehamnt.Value + cethamnt.Value + ceonehundredamnt.Value + cefiftyamnt.Value + cetwentyamnt.Value + cetenamnt.Value + cefiveamnt.Value + ceonepesoamnt.Value + cecentsamnt.Value;
		}
		public void frmReading_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void btnSave_Click(object sender, EventArgs e)
		{
			
			if (ceCheque.Value < 0)
			{
				MessageBox.Show("Negative Values are not allowed!");
				ceCheque.Focus();
				return;
			}
			
			if (ceThousand.Value < 0)
			{
				MessageBox.Show("Negative Values are not allowed!");
				ceThousand.Focus();
				return;
			}
			if (ceFiveHundred.Value < 0)
			{
				MessageBox.Show("Negative Values are not allowed!");
				ceFiveHundred.Focus();
				return;
			}
			if (ceTwoHundred.Value < 0)
			{
				MessageBox.Show("Negative Values are not allowed!");
				ceTwoHundred.Focus();
				return;
			}
			if (ceOneHundred.Value < 0)
			{
				MessageBox.Show("Negative Values are not allowed!");
				ceOneHundred.Focus();
				return;
			}
			if (ceFifty.Value < 0)
			{
				MessageBox.Show("Negative Values are not allowed!");
				ceFifty.Focus();
				return;
			}
			if (ceTwenty.Value < 0)
			{
				MessageBox.Show("Negative Values are not allowed!");
				ceTwenty.Focus();
				return;
			}
			if (ceTen.Value < 0)
			{
				MessageBox.Show("Negative Values are not allowed!");
				ceTen.Focus();
				return;
			}
			if (ceFive.Value < 0)
			{
				MessageBox.Show("Negative Values are not allowed!");
				ceFive.Focus();
				return;
			}
			if (ceOne.Value < 0)
			{
				MessageBox.Show("Negative Values are not allowed!");
				ceOne.Focus();
				return;
			}
			if (ceCents.Value < 0)
			{
				MessageBox.Show("Negative Values are not allowed!");
				ceCents.Focus();
				return;
			}
			int ansreading = 7;
			ansreading = (int) (Interaction.MsgBox("Make sure all the Cash Count are entered correctly before continuing. Please Confirm by Clicking Yes", MsgBoxStyle.YesNo, "Confirm Cash Count"));
			if (ansreading == 7)
			{
				return;
			}
			btnSave.Enabled = false;
			tblreadingManager mgr = default(tblreadingManager);
			PDSATransaction tran = default(PDSATransaction);
			
			PDSATransaction tran5 = default(PDSATransaction);
			decimal totalcashbd = 0; // Total Cash Breakdown
			decimal computerresults = 0;
			decimal vovershort = 0;
			
			spTmptoFinalPOSManager mgrtransfer = default(spTmptoFinalPOSManager);
			
			try
			{
				ModCon.sqlSTR = "exec spGetTotalSalesDiscountCredit @TotalSales2=0,@TotalSales=0,@TotalDiscamnt=0,@TotalCredit=0,@TotalRefunds=0,@CountTotalSales=0,@CountTotalRefunds=0,@CountTotalDiscounts=0,@CountSenior=0,@Countdiscreg=0,@CountVoids=0,@CountReceipt=0,@BegReceipt=0,@EndReceipt=0,@Terminal=1,@InsertID=" + PDSAAppConfig.CurrentLoginID;
				// MessageBox.Show(sqlSTR)
				//sqlSTRR = "SELECT pos_hdrtmp.postmp_hdrid, pos_hdrtmp.pos_date, pos_hdrtmp.custid, pos_hdrtmp.pos_amnt, pos_hdrtmp.tendered, pos_hdrtmp.Cheyns,pos_hdrtmp.Sc, pos_hdrtmp.totsales, pos_hdrtmp.less_vat, pos_hdrtmp.nov, pos_hdrtmp.less_sc, pos_hdrtmp.vatable, pos_hdrtmp.exempt, pos_hdrtmp.vatamnt, pos_hdrtmp.tid, pos_hdrtmp.wtid, pos_dettmp.stckid, pos_dettmp.cost, pos_dettmp.price, pos_dettmp.qty, stocks.barcode, stocks.item_desc, tbls.tdesc, waiters.waiter FROM pos_hdrtmp INNER JOIN pos_dettmp ON pos_hdrtmp.postmp_hdrid = pos_dettmp.postmp_hdrid INNER JOIN stocks ON pos_dettmp.stckid = stocks.stckid INNER JOIN tbls ON pos_hdrtmp.tid = tbls.tid INNER JOIN waiters ON pos_hdrtmp.wtid = waiters.wtid"
				ModCon.ExecuteSQLQuery(ModCon.sqlSTR);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				MessageBox.Show("Reading Not Saved. Please Try Again");
				return;
			}
			
			
			try
			{
				//'execute the stored proc to get the total sales
				//'tran4 = New PDSATransaction()
				//'tran5 = New PDSATransaction()
				//sqlSTR = "exec spGetTotalSalesDiscountCredit @TotalSales2=0,@TotalSales=0,@TotalDiscamnt=0,@TotalCredit=0,@TotalRefunds=0,@CountTotalSales=0,@CountTotalRefunds=0,@CountTotalDiscounts=0,@CountSenior=0,@Countdiscreg=0,@CountVoids=0,@CountReceipt=0,@BegReceipt=0,@EndReceipt=0,@InsertID=" & PDSAAppConfig.CurrentLoginID
				//' MessageBox.Show(sqlSTR)
				//'sqlSTRR = "SELECT pos_hdrtmp.postmp_hdrid, pos_hdrtmp.pos_date, pos_hdrtmp.custid, pos_hdrtmp.pos_amnt, pos_hdrtmp.tendered, pos_hdrtmp.Cheyns,pos_hdrtmp.Sc, pos_hdrtmp.totsales, pos_hdrtmp.less_vat, pos_hdrtmp.nov, pos_hdrtmp.less_sc, pos_hdrtmp.vatable, pos_hdrtmp.exempt, pos_hdrtmp.vatamnt, pos_hdrtmp.tid, pos_hdrtmp.wtid, pos_dettmp.stckid, pos_dettmp.cost, pos_dettmp.price, pos_dettmp.qty, stocks.barcode, stocks.item_desc, tbls.tdesc, waiters.waiter FROM pos_hdrtmp INNER JOIN pos_dettmp ON pos_hdrtmp.postmp_hdrid = pos_dettmp.postmp_hdrid INNER JOIN stocks ON pos_dettmp.stckid = stocks.stckid INNER JOIN tbls ON pos_hdrtmp.tid = tbls.tid INNER JOIN waiters ON pos_hdrtmp.wtid = waiters.wtid"
				//ExecuteSQLQuery(sqlSTR)
				
				//mgrgetsalestot = New spGetTransAmountManager()
				//mgrgetsalestot.Entity.InsertID = PDSAAppConfig.CurrentLoginID
				//mgrgetsalestot.DataObject.Execute()
				//tran4.Add(mgrgetsalestot.DataObject)
				//tran4.Execute()
				
				tran = new PDSATransaction();
				mgr = new tblreadingManager();
				//mgr.DataObject.SelectFilter = tblreadingData.SelectFilters.All
				mgr.DataObject.WhereFilter = tblreadingData.WhereFilters.cashierupstd;
				mgr.Entity.cashier = (PDSAAppConfig.CurrentLoginID).ToString();
				mgr.DataObject.Load();
				if (mgr.DataObject.RowsAffected > 0)
				{
					
					mgr.DataObject.Entity.totalcheque = Convert.ToDecimal(ceCheque.Value);
					mgr.DataObject.Entity.thousndp = Convert.ToDecimal(ceThousand.Value);
					mgr.DataObject.Entity.fiehundredp = Convert.ToDecimal(ceFiveHundred.Value);
					mgr.DataObject.Entity.twohundredp = Convert.ToDecimal(ceTwoHundred.Value);
					mgr.DataObject.Entity.onehundredp = Convert.ToDecimal(ceOneHundred.Value);
					mgr.DataObject.Entity.fiftyp = Convert.ToDecimal(ceFifty.Value);
					mgr.DataObject.Entity.twentyp = Convert.ToDecimal(ceTwenty.Value);
					mgr.DataObject.Entity.tenp = Convert.ToDecimal(ceTen.Value);
					mgr.DataObject.Entity.fivep = Convert.ToDecimal(ceFive.Value);
					mgr.DataObject.Entity.onep = Convert.ToDecimal(ceOne.Value);
					mgr.DataObject.Entity.twentyfive = Convert.ToDecimal(ceCents.Value);
					//'mgr.DataObject.Entity.overshort = Convert.ToDecimal(TotalAmount.Text)
					//mgr.DataObject.Entity.status = True
					
					//Total all the cash count and Add cheque amount to be subtracted to the computer generated results
					totalcashbd = (decimal) ((Convert.ToDecimal(ceCheque.Value) * 1) + (Convert.ToDecimal(ceThousand.Value) * 1000) + (Convert.ToDecimal(ceFiveHundred.Value * 500)) + (Convert.ToDecimal(ceTwoHundred.Value) * 200) + 
						(Convert.ToDecimal(ceOneHundred.Value) * 100) + (Convert.ToDecimal(ceFifty.Value) * 50) + (Convert.ToDecimal(ceTwenty.Value) * 20) 
						+ (Convert.ToDecimal(ceTen.Value) * 10) + (Convert.ToDecimal(ceFive.Value) * 5) + (Convert.ToDecimal(ceOne.Value) * 1) + 
						(Convert.ToDecimal(ceCents.Value) * 0.25));
					
					// computerresults = (mgr.DataObject.Entity.totalsales + mgr.DataObject.Entity.addcash + mgr.DataObject.Entity.payments + mgr.DataObject.Entity.begincash) - (mgr.DataObject.Entity.totalcredit + mgr.DataObject.Entity.pickup)
					computerresults = (mgr.DataObject.Entity.totalsales + mgr.DataObject.Entity.addcash + mgr.DataObject.Entity.payments + mgr.DataObject.Entity.begincash) - (mgr.DataObject.Entity.pickup); //- (mgr.DataObject.Entity.totaldiscount) 'vovershort = computerresults - totalcashbd
					
					//computerresults = (mgr.DataObject.Entity.totalsales + mgr.DataObject.Entity.addcash + mgr.DataObject.Entity.payments + mgr.DataObject.Entity.begincash) - (mgr.DataObject.Entity.pickup) 'vovershort = computerresults - totalcashbd  '
					vovershort = totalcashbd - computerresults;
					mgr.DataObject.Entity.overshort = vovershort;
					//update transaction code below
					mgr.DataObject.TransactionType = PDSATransactionType.Update;
					tran.Add(mgr.DataObject);
					tran.Execute();
					
					//execute stored proc to transfer temporary sales data to pos_hdr and pos_det
					tran5 = new PDSATransaction();
					mgrtransfer = new spTmptoFinalPOSManager();
					mgrtransfer.Entity.InsertID = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					mgrtransfer.Entity.trminal = 1;
					tran5.Add(mgrtransfer.DataObject);
					tran5.Execute();
					
					tblreadingManager mgrr = new tblreadingManager();
					PDSATransaction tranr = new PDSATransaction();
					
					//mgr.DataObject.SelectFilter = tblreadingData.SelectFilters.All
					mgrr.DataObject.WhereFilter = tblreadingData.WhereFilters.cashierupstd;
					mgrr.Entity.cashier = (PDSAAppConfig.CurrentLoginID).ToString();
					mgrr.DataObject.Load();
					if (mgrr.DataObject.RowsAffected > 0)
					{
						mgrr.DataObject.Entity.status = true;
						mgrr.DataObject.TransactionType = PDSATransactionType.Update;
						tranr.Add(mgrr.DataObject);
						tranr.Execute();
					}
					MessageBox.Show("Cash Breakdown Successfully Saved");
				}
			}
			catch (PDSAValidationException ex)
			{
				MessageBox.Show(ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}
		
		public void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void PrintReading()
		{
			
			
			//Dim rep As New Zout()
			//rep.ParamCashier.Value = PDSAAppConfig.CurrentLoginID
			//rep.RequestParameters = False
			//rep.PrintingSystem.ShowMarginsWarning = False
			//rep.Print()
			
			
			this.Close();
			
		}
		
		public void frmReading_Load(object sender, EventArgs e)
		{
			ceCheque.Focus();
		}
		
		public void ceCheque_Spin(object sender, SpinEventArgs e)
		{
			e.Handled = true;
		}
		
		public void ceThousand_Spin(object sender, SpinEventArgs e)
		{
			e.Handled = true;
		}
		
		public void ceFiveHundred_Spin(object sender, SpinEventArgs e)
		{
			e.Handled = true;
		}
		
		public void ceTwoHundred_Spin(object sender, SpinEventArgs e)
		{
			e.Handled = true;
		}
		public void ceOneHundred_Spin(object sender, SpinEventArgs e)
		{
			e.Handled = true;
		}
		public void ceFifty_Spin(object sender, SpinEventArgs e)
		{
			e.Handled = true;
		}
		
		public void ceTwenty_Spin(object sender, SpinEventArgs e)
		{
			e.Handled = true;
		}
		public void ceTen_Spin(object sender, SpinEventArgs e)
		{
			e.Handled = true;
		}
		
		public void ceFive_Spin(object sender, SpinEventArgs e)
		{
			e.Handled = true;
		}
		
		public void ceOne_Spin(object sender, SpinEventArgs e)
		{
			e.Handled = true;
		}
		public void ceCents_Spin(object sender, SpinEventArgs e)
		{
			e.Handled = true;
		}
		
		public void ceThousand_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void ceFiveHundred_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void ceTwoHundred_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void ceOneHundred_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void ceFifty_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void ceTwenty_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void ceTen_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void ceFive_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void ceOne_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void ceCents_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void ceCheque_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void ceCheque_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
	}
}
