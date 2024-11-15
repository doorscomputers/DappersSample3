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
using System.Runtime.InteropServices;

//Imports PDSA.Data
namespace DoorsPOS.WinApp
{
	public partial class frmPOS
	{
		
#region Default Instance
		
		private static frmPOS defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
public static frmPOS Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmPOS();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		decimal vincentives = 0;
		private const int SM_CXSCREEN = 0;
		private const int SM_CYSCREEN = 1;
		private static IntPtr HWND_TOP = IntPtr.Zero;
		private const int SWP_SHOWWINDOW = 64;
		[DllImport("user32.dll",EntryPoint="SetWindowPos", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndIntertAfter, int X, int Y, int cx, int cy, int uFlags);
		[DllImport("user32.dll",EntryPoint="GetSystemMetrics", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		private static extern int GetSystemMetrics(int Which);
		string cItemID;
		decimal nPrice;
		decimal nCost;
		int nProdID;
		string cItem;
		string cItemName;
		
		int entityval;
		
		stocksManager mgr;
		stocksManager mgr2;
		stocksManager mgr3;
		stocksManager mgr4;
		stocksManager mgr6;
		stocksCollection col1;
		pos_hdrManager oh;
		pos_hdrtmpManager oht;
		pos_detManager od1;
		pos_detManager od2;
		pos_detManager od3;
		pos_detManager od4;
		pos_detManager od5;
		pos_detManager od6;
		pos_detManager od7;
		pos_detManager od8;
		pos_detManager od9;
		pos_detManager od10;
		pos_detManager od11;
		pos_detManager od12;
		pos_detManager od13;
		pos_detManager od14;
		pos_detManager od15;
		pos_detManager od16;
		pos_dettmpManager odt1;
		pos_dettmpManager odt2;
		pos_dettmpManager odt3;
		pos_dettmpManager odt4;
		pos_dettmpManager odt5;
		pos_dettmpManager odt6;
		pos_dettmpManager odt7;
		pos_dettmpManager odt8;
		pos_dettmpManager odt9;
		pos_dettmpManager odt10;
		pos_dettmpManager odt11;
		pos_dettmpManager odt12;
		pos_dettmpManager odt13;
		pos_dettmpManager odt14;
		pos_dettmpManager odt15;
		pos_dettmpManager odt16;
		ArrayList malOrderDetails = new ArrayList();
		
		public override string Text {get; set;}
		public PDSA.DataLayer.DataClasses.PDSATransaction Tran;
		public PDSA.DataLayer.DataClasses.PDSATransaction Tran2;
		public PDSA.DataLayer.DataClasses.PDSATransaction Tran3;
		public PDSA.DataLayer.DataClasses.PDSATransaction Tran4;
		private int mOrderId = 0;
		int ii;
		int grdCount;
		int cntr;
		private pos_hdrtmp mOrderHeader = new pos_hdrtmp();
		private pos_dettmp mOrderLine1 = new pos_dettmp();
		public int qtyy = 1; // qtyy is the quantity pre-set by the cashier
		public static int vpieces = 1;
		public static int vdisc = 0;
		public static decimal vdiscamnt = 0;
		public static decimal vtotalsales = 0;
		public static decimal Tots = 0;
		public static string vtendered = string.Empty;
		public static string vchange = string.Empty;
		public decimal origprice = 0;
		public decimal NuPrice = 0;
		int itemcnt = 0;
		public static bool passcorrect = false;
		
		public string vItem = string.Empty;
		public int vStckid = 0;
		public decimal vPrice = 0;
		public decimal vWPrice = 0;
		public string vbocde = string.Empty;
		public int vAvlbl = 0;
		public int vInnerQty = 0;
		
public int ScreenX
		{
			get
			{
				return GetSystemMetrics(SM_CXSCREEN);
			}
		}
		
public int ScreenY
		{
			get
			{
				return GetSystemMetrics(SM_CYSCREEN);
			}
		}
		
		private void FullScreen()
		{
			this.WindowState = FormWindowState.Maximized;
			this.FormBorderStyle = FormBorderStyle.None;
			this.TopMost = true;
			SetWindowPos(this.Handle, HWND_TOP, 0, 0, ScreenX, ScreenY, SWP_SHOWWINDOW);
		}
		
		public void NormalScreen()
		{
			this.WindowState = FormWindowState.Normal;
			this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			this.TopMost = false;
		}
		
		public void frmPOS_Activated(object sender, EventArgs e)
		{
			txtTendered.Text = vtendered;
			lblChange.Text = vchange;
		}
		
		public void frmPOS_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		public void frmPOS_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			//If e.KeyCode = Keys.Escape Then
			//    e.Handled = True
			//End If
			
			if (e.KeyCode == Keys.Alt)
			{
				txtBarcode.Text = "";
			}
			
			if (e.KeyCode == Keys.F2)
			{
				e.Handled = true;
				frmPriceLookup2 frm = new frmPriceLookup2();
				frm.ShowDialog();
				//txtBarcode.Focus()
				//btnSearchItems.Focus()
				txtitem.Focus();
				txtitem.Text = string.Empty;
			}
			
			if (e.KeyCode == Keys.F3)
			{
				e.Handled = true;
				frmCreditPayment frmcp = new frmCreditPayment();
				frmcp.ShowDialog();
				btnnew.Focus();
			}
			
			
			
			if (e.KeyCode == Keys.F12)
			{
				bool vYesNo = true;
				int grdcountt = 0;
				int iiiay = 0;
				grdcountt = PosGrid.Rows.Count;
				try
				{
					
					for (iiiay = 0; iiiay <= grdcountt - 1; iiiay++)
					{
						if (System.Convert.ToDecimal(PosGrid.Rows[iiiay].Cells[5].Value) <= 0)
						{
							
							// Zero Price found
							MessageBox.Show("There is an Item with a Price that is Not valid or less than 0.1");
							vYesNo = false;
							//Exit For
							return;
						}
						
						if (System.Convert.ToInt32(PosGrid.Rows[iiiay].Cells[2].Value) <= 0)
						{
							
							// Zero Qty found
							MessageBox.Show("There is an Item with a Qty that is Not valid or equal to 0");
							vYesNo = false;
							//Exit For
							return;
						}
						
						if (System.Convert.ToDecimal(PosGrid.Rows[iiiay].Cells[6].Value) <= 0)
						{
							
							// Zero Qty found
							MessageBox.Show("There is an Item with an Amount that is Not valid or equal to 0");
							vYesNo = false;
							//Exit For
							return;
						}
						
					}
					
					
					
					
					
					
					
					
					
					//'Try to check if there is a price that is not valid(less than or equal to zero and letters maybe)
					//Dim IIII As Integer = 0
					//For IIII = 0 To PosGrid.Rows.Count - 1
					//    Dim number As Decimal
					//    Dim result As Boolean = Decimal.TryParse(CStr(CDec(PosGrid.Rows(IIII).Cells(4).Value)), number)
					//    If CDec(CStr(PosGrid.Rows(IIII).Cells(4).Value)) <= 0 Then
					//        MessageBox.Show("W A R N I N G !!!!!! Price Must be Greater than Zero")
					//        Exit Sub
					//    End If
					//    If result Then
					//        ' Console.WriteLine("Converted '{0}' to {1}.", PosGrid.Rows(IIII).Cells(4).Value, number)
					//    Else
					//        If PosGrid.Rows(IIII).Cells(4).Value Is Nothing Then PosGrid.Rows(IIII).Cells(4).Value = ""
					//        MessageBox.Show("W A R N I N G !!!!!! Price Must be Greater than Zero")
					//        MessageBox.Show(CStr(PosGrid.Rows(IIII).Cells(4).Value))
					//        Exit Sub
					//        Exit For
					//    End If
					
					//Next
					
					//IF no problem them take payment
					
					
					if (vYesNo == false)
					{
						return;
					}
					if (btnSaves.Enabled == false)
					{
						return;
					}
					TakePayment();
					
					//If PosGrid.Rows.Count >= 1 Then
					//    If txtTendered.Text = "0" Then
					//        MessageBox.Show("Sales Transaction is not yet paid!")
					//        btnSave.Focus()
					//        Exit Sub
					//    End If
					
					//End If
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			
			if (e.KeyCode == Keys.F4)
			{
				//'~~~ Calling it and passing the name of the form to be displayed
				//Dim myObj As abcLockScreen = New abcLockScreen
				//myObj.LockSystemAndShow(Form2)
			}
			
			
			if (e.KeyCode == Keys.F5)
			{
				//If btnnew.Enabled = False Then
				if (PosGrid.Rows.Count > 0)
				{
					SuspendTrans();
				}
				else
				{
					//btnSearchItems.Focus()
					txtitem.Focus();
					txtitem.Text = string.Empty;
					//txtBarcode.Focus()
					//End If
				}
			}
			
			if (e.KeyCode == Keys.F6)
			{
				if (btnnew.Enabled == false)
				{
					if (PosGrid.Rows.Count > 1)
					{
						MessageBox.Show("Pls. finish the existing sales transaction before retrieving a suspended sale.");
						return;
					}
					else
					{
						RetrieveTrans();
					}
				}
			}
			
			if (e.KeyCode == Keys.F7)
			{
				if (btnnew.Enabled == false)
				{
					cmbPriceMode.Text = "Refund";
					//txtBarcode.Focus()
					//btnSearchItems.Focus()
					txtitem.Focus();
					txtitem.Text = string.Empty;
				}
			}
			
			if (e.KeyCode == Keys.F8)
			{
				//If PosGrid.Rows.Count > 1 Then
				//MessageBox.Show("Pls. finish the existing sales transaction before retrieving a suspended sale.")
				//Exit Sub
				//Else
				//Call RetrieveTrans()
				//End If
				RePrint();
			}
			
			
			
			if (e.KeyCode == Keys.F9)
			{
				
				itemcnt = 0;
				vdisc = 0;
				vdiscamnt = 0;
				VarsModule.vEmpID = 1;
				txtTendered.Text = "0";
				try
				{
					
					txtSum.Text = "0";
					PosGrid.Rows.Clear();
					txtBarcode.Text = string.Empty;
					txtitem.Text = string.Empty;
					//txtTendered.Text = "0"
					//lblChange.Text = "0"
					ceWtid.Value = 1;
					vtotalsales = 0;
					VarsModule.vpTotalSales = 0;
					txtcustid.Text = "205";
					txtqty.Text = "0";
					txtlastname.Text = "CASH";
					txtfirstname.Text = string.Empty;
					btnSaves.Enabled = true;
					btnPriceMode.Enabled = true;
					btnType.Enabled = true;
					btnSuspend.Enabled = true;
					btnRetrieve.Enabled = true;
					btnRemove.Enabled = true;
					btnDiscount.Enabled = true;
					Button1.Enabled = true; // this is the Set Quantity button
					btnCustomers.Enabled = true;
					txtBarcode.Enabled = true;
					btnSearchItems.Enabled = true;
					btnReprint.Enabled = true;
					txtbcodes.Text = string.Empty;
					txtStckid.Text = string.Empty;
					btnType.Enabled = true;
					btnPriceMode.Enabled = true;
					btnCustomers.Enabled = true;
					btnSuspend.Enabled = true;
					btnRetrieve.Enabled = true;
					btnRemove.Enabled = true;
					cmbPriceMode.Text = "Retail";
					cmbPaymentType.Text = "CASH";
					btnChequePayment.Enabled = true;
					//GridLookUpEdit2.Enabled = True
					txtitem.Enabled = true;
					
					//txtBarcode.Focus()
					//btnSearchItems.Focus()
					txtitem.Focus();
					txtitem.Text = string.Empty;
					btnnew.Enabled = false;
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			
			
			
			
			
			if (e.KeyCode == Keys.F10)
			{
				if (btnSaves.Enabled == true && PosGrid.Rows.Count >= 1)
				{
					MessageBox.Show("Please Complete a Pending Sales Transaction First");
					return;
				}
				txtBarcode.Enabled = false;
				btnBcode.Enabled = false;
				btnSearchItems.Enabled = false;
				btnPriceMode.Enabled = false;
				btnType.Enabled = false;
				btnSaves.Enabled = false;
				btnSuspend.Enabled = false;
				btnRetrieve.Enabled = false;
				btnRemove.Enabled = false;
				btnCreditPay.Enabled = false;
				btnChequePayment.Enabled = false;
				btnnew.Enabled = false;
				btnLookuprice.Enabled = false;
				btnPickup.Enabled = false;
				btnAddCash.Enabled = false;
				btnDiscount.Enabled = false;
				Button1.Enabled = false;
				btnCustomers.Enabled = false;
				PosGrid.Enabled = false;
				
				frmReading frmread = new frmReading();
				frmread.ShowDialog();
				frmread = null;
				this.Close();
			}
			
			if (e.KeyCode == Keys.G && e.Control == true)
			{
				PosGrid.Focus();
			}
			if (e.KeyCode == Keys.F1)
			{
				SetQuantity();
			}
			
			
			if (e.KeyCode == Keys.E && e.Shift == true)
			{
				InputPassword();
			}
			
			if (e.KeyCode == Keys.I && e.Control == true)
			{
				txtitem.Focus();
			}
			
			if (e.KeyCode == Keys.Q && e.Control == true)
			{
				try
				{
					frmQty formQty = new frmQty();
					formQty.ShowDialog();
					txtitem.Focus();
					txtitem.Text = string.Empty;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				
			}
			
		}
		//Private Sub txtBarcode_GotFocus(sender As Object, e As System.EventArgs) Handles txtBarcode.GotFocus
		//GridLookUpEdit1.EditValue = vbNullString
		//End Sub
		
		public void InputPassword()
		{
			ModCon.username = string.Empty;
			try
			{
				waitersManager mgremp = new waitersManager();
				waitersCollection cols = new waitersCollection();
				mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword;
				string strIncentive = string.Empty;
				strIncentive = Interaction.InputBox("Please Enter your Password.", "", "", -1, -1);
				
				mgremp.Entity.pword = strIncentive.Trim();
				cols = mgremp.BuildCollection();
				if (mgremp.DataObject.RowsAffected > 0)
				{
					ceWtid.Value = mgremp.DataObject.Entity.wtid;
					MessageBox.Show(mgremp.DataObject.Entity.waiter);
				}
				else
				{
					MessageBox.Show("Not a valid password, try again.");
					
				}
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
		public void SendItemtoGrid()
		{
			// get the details of the item
			//Dim R As POS.POSDS.ItemsRow = Button1.Tag
			// next search for the barcode in the datagridview
			qtyy = vpieces;
			
			int I = 0;
			int ItemLoc = -1;
			
			try
			{
				
				for (I = 0; I <= PosGrid.Rows.Count - 1; I++)
				{
					if (nProdID == System.Convert.ToInt32(PosGrid.Rows[I].Cells[0].Value))
					{
						
						// item found
						ItemLoc = I;
						break;
					}
				}
				
				// if item is not found, add it
				if (ItemLoc == -1)
				{
					if (qtyy == 1)
					{
						if (cmbPriceMode.Text == "Retail")
						{
							PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail, qtyy, mgr.DataObject.Entity.retail, mgr.DataObject.Entity.retail);
							//ElseIf cmbPriceMode.Text = "Wholesale" Then
							//PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail2, qtyy, mgr.DataObject.Entity.retail2, mgr.DataObject.Entity.retail2)
						}
						//New Code
						if (cmbPriceMode.Text == "Refund")
						{
							PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail, qtyy * -1, mgr.DataObject.Entity.retail * -1);
						}
						//end of new code
					}
					else
					{
						
						if (cmbPriceMode.Text == "Retail")
						{
							PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail, qtyy, mgr.DataObject.Entity.retail * qtyy, mgr.DataObject.Entity.retail);
							//Else
							//PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail2, qtyy, mgr.DataObject.Entity.retail2 * qtyy, mgr.DataObject.Entity.retail2)
						}
						
						if (cmbPriceMode.Text == "Refund")
						{
							PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail, qtyy * -1, mgr.DataObject.Entity.retail * (qtyy * -1));
							cmbPriceMode.Text = "Retail";
							//Else
							// PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail2, qtyy, mgr.DataObject.Entity.retail2 * (qtyy * -1))
						}
						
						
					}
					
					
				}
				else
				{
					if (cmbPriceMode.Text == "Retail")
					{
						// if item is already there increase its count
						int ItemCount = System.Convert.ToInt32(PosGrid.Rows[ItemLoc].Cells[5].Value);
						ItemCount++;
						decimal NewPrice = mgr.DataObject.Entity.retail * ItemCount;
						PosGrid.Rows[ItemLoc].Cells[5].Value = ItemCount;
						PosGrid.Rows[ItemLoc].Cells[6].Value = NewPrice;
						//ElseIf cmbPriceMode.Text = "Wholesale" Then
						//' if item is already there increase its count
						//Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(5).Value)
						//ItemCount += 1
						//Dim NewPrice As Decimal = mgr.DataObject.Entity.retail2 * ItemCount
						//PosGrid.Rows(ItemLoc).Cells(5).Value = ItemCount
						//PosGrid.Rows(ItemLoc).Cells(6).Value = NewPrice
					}
					else
					{
						int ItemCount = System.Convert.ToInt32(PosGrid.Rows[ItemLoc].Cells[5].Value);
						ItemCount++;
						decimal NewPrice = mgr.DataObject.Entity.retail * (ItemCount * -1);
						PosGrid.Rows[ItemLoc].Cells[5].Value = ItemCount;
						PosGrid.Rows[ItemLoc].Cells[6].Value = NewPrice;
						cmbPriceMode.Text = "Retail";
					}
					
				}
				//' next clear textbox1 and set focus to it
				//TextBox1.Text = ""
				//TextBox1.Focus()
				// compute the total for the recipt
				//Dim Tots As Decimal = 0
				Tots = 0;
				for (I = 0; I <= PosGrid.Rows.Count - 1; I++)
				{
					Tots += System.Convert.ToDecimal(PosGrid.Rows[I].Cells[6].Value);
				}
				
				txtCounts.Text = (PosGrid.Rows.Count).ToString();
				
				//Scroll to the last row.
				this.PosGrid.FirstDisplayedScrollingRowIndex = this.PosGrid.RowCount - 1;
				
				//Select the last row.
				this.PosGrid.Rows[this.PosGrid.RowCount - 1].Selected = true;
				
				//CalcEdit1.Value = Tots
				txtSum.Text = Strings.FormatNumber(Tots, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); //FormatNumber(CStr(Tots))
				CheckSumifNegative();
				VarsModule.vpTotalSales = Tots;
				//TextEdit1.Text = FormatCurrency(CStr(Tots))
				qtyy = 1;
				vpieces = 1;
				//itemcnt = PosGrid.Rows.Count
				
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
		public void SendItemtoGrid2()
		{
			// get the details of the item
			//Dim R As POS.POSDS.ItemsRow = Button1.Tag
			// next search for the barcode in the datagridview
			int I = 0;
			int ItemLoc = -1;
			
			
			try
			{
				
				for (I = 0; I <= PosGrid.Rows.Count - 1; I++)
				{
					if (nProdID == System.Convert.ToInt32(PosGrid.Rows[I].Cells[0].Value))
					{
						
						// item found
						ItemLoc = I;
						break;
					}
				}
				
				// if item is not found, add it
				if (ItemLoc == -1)
				{
					if (qtyy == 1)
					{
						PosGrid.Rows.Add(mgr4.DataObject.Entity.stckid, mgr4.DataObject.Entity.barcode, mgr4.DataObject.Entity.itemdesc, mgr4.DataObject.Entity.cost, mgr4.DataObject.Entity.retail, qtyy, mgr4.DataObject.Entity.retail, mgr4.DataObject.Entity.retail);
					}
					else
					{
						PosGrid.Rows.Add(mgr4.DataObject.Entity.stckid, mgr4.DataObject.Entity.barcode, mgr4.DataObject.Entity.itemdesc, mgr4.DataObject.Entity.cost, mgr4.DataObject.Entity.retail, qtyy, mgr4.DataObject.Entity.retail * qtyy, mgr4.DataObject.Entity.retail);
					}
				}
				else
				{
					// if item is already there increase its count
					int ItemCount = System.Convert.ToInt32(PosGrid.Rows[ItemLoc].Cells[5].Value);
					ItemCount++;
					decimal NewPrice = mgr.DataObject.Entity.retail * ItemCount;
					PosGrid.Rows[ItemLoc].Cells[5].Value = ItemCount;
					PosGrid.Rows[ItemLoc].Cells[6].Value = NewPrice;
				}
				
				
				//' next clear textbox1 and set focus to it
				//TextBox1.Text = ""
				//TextBox1.Focus()
				
				// compute the total for the recipt
				//Dim Tots As Decimal = 0
				for (I = 0; I <= PosGrid.Rows.Count - 1; I++)
				{
					Tots += System.Convert.ToDecimal(PosGrid.Rows[I].Cells[6].Value);
				}
				txtCounts.Text = (PosGrid.Rows.Count).ToString();
				
				//Scroll to the last row.
				this.PosGrid.FirstDisplayedScrollingRowIndex = this.PosGrid.RowCount - 1;
				
				//Select the last row.
				this.PosGrid.Rows[this.PosGrid.RowCount - 1].Selected = true;
				
				//CalcEdit1.Value = Tots
				txtSum.Text = Strings.FormatNumber(Tots, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); //FormatNumber(CStr(Tots))
				CheckSumifNegative();
				VarsModule.vpTotalSales = Tots;
				//TextEdit1.Text = FormatCurrency(CStr(Tots))
				qtyy = 1;
				//itemcnt = PosGrid.Rows.Count
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
		public void SendItemtoGrid3()
		{
			int I = 0;
			int ItemLoc = -1;
			//Uncomment this if the ceQTy Control will be removed
			//qtyy = vpieces
			
			try
			{
				
				for (I = 0; I <= PosGrid.Rows.Count - 1; I++)
				{
					if (nProdID == System.Convert.ToInt32(PosGrid.Rows[I].Cells[0].Value))
					{
						
						// item found
						ItemLoc = I;
						break;
					}
				}
				
				// if item is not found, add it
				if (ItemLoc == -1)
				{
					
					if (qtyy == 1)
					{
						if (cmbPriceMode.Text == "Retail")
						{
							//++This is the original COde
							//PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.retail, qtyy, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail, 0, mgr6.DataObject.Entity.incentive)
							//++End of Original Code
							PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail, 0, mgr6.DataObject.Entity.incentive);
							
							
							// MessageBox.Show(CStr(mgr6.DataObject.Entity.incentive))
							//ElseIf cmbPriceMode.Text = "Whooesale" Then
							//PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.retail2, qtyy, mgr6.DataObject.Entity.retail2, mgr6.DataObject.Entity.retail2, 0, mgr6.DataObject.Entity.incentive)
						}
						
						if (cmbPriceMode.Text == "Wholesale")
						{
							//++This is the original COde
							//PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.retail, qtyy, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail, 0, mgr6.DataObject.Entity.incentive)
							//++End of Original Code
							PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail2, mgr6.DataObject.Entity.retail2, mgr6.DataObject.Entity.retail2, 0, mgr6.DataObject.Entity.incentive);
							
							
							// MessageBox.Show(CStr(mgr6.DataObject.Entity.incentive))
							//ElseIf cmbPriceMode.Text = "Whooesale" Then
							//PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.retail2, qtyy, mgr6.DataObject.Entity.retail2, mgr6.DataObject.Entity.retail2, 0, mgr6.DataObject.Entity.incentive)
						}
						
						
						
						//New Code
						if (cmbPriceMode.Text == "Refund")
						{
							//PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.retail, (qtyy * -1), mgr6.DataObject.Entity.retail * (qtyy * -1), mgr6.DataObject.Entity.retail, 0, mgr6.DataObject.Entity.incentive)
							PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, (qtyy * -1), mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail * (qtyy * -1), mgr6.DataObject.Entity.retail, 0, mgr6.DataObject.Entity.incentive);
						}
						//end of new code
						
						
					}
					else
					{
						if (cmbPriceMode.Text == "Retail")
						{
							//PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.retail, qtyy, mgr6.DataObject.Entity.retail * qtyy, mgr6.DataObject.Entity.retail, 0, mgr6.DataObject.Entity.incentive)
							PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail * qtyy, mgr6.DataObject.Entity.retail, 0, mgr6.DataObject.Entity.incentive);
							//Else
							//   'PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.retail2, qtyy, mgr6.DataObject.Entity.retail2 * qtyy, mgr6.DataObject.Entity.retail2, 0, mgr6.DataObject.Entity.incentive)
							//  PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail2, mgr6.DataObject.Entity.retail2 * qtyy, mgr6.DataObject.Entity.retail2, 0, mgr6.DataObject.Entity.incentive)
						}
						
						if (cmbPriceMode.Text == "Wholesale")
						{
							PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail2, mgr6.DataObject.Entity.retail2 * qtyy, mgr6.DataObject.Entity.retail2, 0, mgr6.DataObject.Entity.incentive);
						}
						
						
						
						if (cmbPriceMode.Text == "Refund")
						{
							//PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.retail, qtyy, mgr6.DataObject.Entity.retail * (qtyy * -1), mgr6.DataObject.Entity.retail * (qtyy * -1), 0, mgr6.DataObject.Entity.incentive)
							PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail * (qtyy * -1), mgr6.DataObject.Entity.retail * (qtyy * -1), 0, mgr6.DataObject.Entity.incentive);
							cmbPriceMode.Text = "Retail";
							//Else
							// PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail2, qtyy, mgr.DataObject.Entity.retail2 * (qtyy * -1))
						}
						
						
						
					}
				}
				else
				{
					if (cmbPriceMode.Text == "Retail")
					{
						// if item is already there increase its count
						//Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(5).Value)
						int ItemCount = System.Convert.ToInt32(PosGrid.Rows[ItemLoc].Cells[2].Value);
						ItemCount += (int) ceQtyy.Value;
						decimal NewPrice = mgr6.DataObject.Entity.retail * ItemCount;
						decimal NewIncentv = mgr6.DataObject.Entity.incentive * ItemCount;
						//PosGrid.Rows(ItemLoc).Cells(5).Value = ItemCount
						PosGrid.Rows[ItemLoc].Cells[2].Value = ItemCount;
						PosGrid.Rows[ItemLoc].Cells[6].Value = NewPrice;
						PosGrid.Rows[ItemLoc].Cells[9].Value = NewIncentv;
						//ElseIf cmbPriceMode.Text = "Wholesale" Then
						//    ' if item is already there increase its count
						//    Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(5).Value)
						//    ItemCount += 1
						//    Dim NewPrice As Decimal = mgr.DataObject.Entity.retail2 * ItemCount
						//    PosGrid.Rows(ItemLoc).Cells(5).Value = ItemCount
						//    PosGrid.Rows(ItemLoc).Cells(6).Value = NewPrice
						//Else
						//' if item is already there increase its count
						//'Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(5).Value)
						//Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(2).Value)
						//ItemCount += CInt(ceQtyy.Value)
						//Dim NewPrice As Decimal = mgr6.DataObject.Entity.retail2 * ItemCount
						//Dim NewIncentvv As Decimal = mgr6.DataObject.Entity.incentive * ItemCount
						//'PosGrid.Rows(ItemLoc).Cells(5).Value = ItemCount
						//PosGrid.Rows(ItemLoc).Cells(2).Value = ItemCount
						//PosGrid.Rows(ItemLoc).Cells(6).Value = NewPrice
						//PosGrid.Rows(ItemLoc).Cells(9).Value = NewIncentvv
					}
					
				}
				// compute the total for the recipt
				Tots = 0;
				for (I = 0; I <= PosGrid.Rows.Count - 1; I++)
				{
					//MessageBox.Show(CStr(PosGrid.Rows.Count))
					Tots += System.Convert.ToDecimal(PosGrid.Rows[I].Cells[6].Value);
				}
				txtCounts.Text = (PosGrid.Rows.Count).ToString();
				//Scroll to the last row.
				this.PosGrid.FirstDisplayedScrollingRowIndex = this.PosGrid.RowCount - 1;
				
				//Select the last row.
				this.PosGrid.Rows[this.PosGrid.RowCount - 1].Selected = true;
				
				//CalcEdit1.Value = Tots
				txtSum.Text = Strings.FormatNumber(Tots, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); //FormatNumber(CStr(Tots))
				CheckSumifNegative();
				//New Code 02/21/2014
				VarsModule.vpTotalSales = Tots;
				//End of New Code 02/21/2014
				
				//TextEdit1.Text = FormatCurrency(CStr(Tots))
				qtyy = 1;
				vpieces = 1;
				
				if (System.Convert.ToInt32(PosGrid.SelectedRows[0].Cells[2].Value) <= 0)
				{
					PosGrid.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Red;
				}
				else
				{
					PosGrid.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
				}
				
				//If CDec(PosGrid.SelectedRows.Item(0).Cells(5).Value) <= 0 Then
				if (System.Convert.ToDecimal(PosGrid.SelectedRows[0].Cells[5].Value) <= 0)
				{
					PosGrid.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Red;
				}
				else
				{
					PosGrid.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
				}
				
				
				//'itemcnt = PosGrid.Rows.Count
				//txtBarcode.Focus()
				//btnSearchItems.Focus()
				txtitem.Text = string.Empty;
				txtitem.Focus();
				
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
		
		public void txtitem_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt == true & e.KeyCode == Keys.Tab)
			{
				e.Handled = true;
			}
			
			if (e.Alt == true & e.KeyCode == Keys.F4)
			{
				e.Handled = true;
			}
			//If e.KeyCode = Keys.Left Then
			//    txtBarcode.Focus()
			//    txtitem.Text = ""
			//End If
			
			if (e.KeyCode == Keys.Down)
			{
				dgitems.Focus();
			}
			
			if (e.KeyCode == Keys.Escape)
			{
				
				dgitems.Visible = false;
				txtitem.Focus();
				txtitem.SelectAll();
				
				e.SuppressKeyPress = true;
			}
			
			
		}
		
		public void txtitem_KeyPress(object sender, KeyPressEventArgs e)
		{
			//If e.KeyChar = Chr(13) Then
			//    'LookupEditKeypress()
			//    ceQtyy.Focus()
			//End If
			
			if (e.KeyChar == '\u001B')
			{
				dgitems.Visible = false;
			}
			
			if (e.KeyChar == '\r')
			{
				if (dgitems.Rows.Count < 1)
				{
					return;
				}
				try
				{
					int vRow = 0;
					int vint = 0;
					string x1 = string.Empty;
					string x2 = string.Empty;
					// Dim x2 As Integer = 0
					int x3 = 0;
					decimal x4 = 0;
					int x5 = 0;
					string x6 = string.Empty;
					vRow = 0; //dgitems.CurrentRow.Index
					//vint = CInt(dgitems(0, vRow).Value)
					//x1 = CStr(dgitems(1, vRow).Value)
					//x2 = CStr(dgitems(2, vRow).Value)
					//x3 = CDec(dgitems(12, vRow).Value)
					//x4 = CDec(dgitems(13, vRow).Value)
					vint = System.Convert.ToInt32(dgitems[0, vRow].Value);
					x1 = (dgitems[1, vRow].Value).ToString();
					x2 = (dgitems[2, vRow].Value).ToString();
					x3 = System.Convert.ToInt32(dgitems[3, vRow].Value);
					x4 = System.Convert.ToDecimal(dgitems[4, vRow].Value);
					x5 = System.Convert.ToInt32(dgitems[6, vRow].Value);
					//x6 = CStr(dgitems(7, vRow).Value)
					vStckid = vint;
					vItem = x2;
					vAvlbl = x3;
					vbocde = x1;
					vPrice = x3;
					vWPrice = x4;
					vInnerQty = x5;
					
					txtbcodes.Text = string.Empty;
					txtStckid.Text = string.Empty;
					txtitem.Text = vItem.ToString();
					txtbcodes.Text = vbocde.ToString();
					txtBarcode.Text = vbocde.ToString();
					txtStckid.Text = vStckid.ToString();
					//'txtBarcode.SelectAll()
					//If txtStckid.Text = String.Empty Then
					//    Exit Sub
					//Else
					//    ItemsearchExecute()
					//End If
					//txtitem.Focus()
					
					
					ceQtyy.Focus();
					dgitems.Visible = false;
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				//e.SuppressKeyPress = True
			}
		}
		
		public void txtitem_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Alt == true & e.KeyCode == Keys.Tab)
			{
				e.Handled = true;
			}
			
			if (e.Alt == true & e.KeyCode == Keys.F4)
			{
				e.Handled = true;
			}
		}
		
		//Private Sub DisplayException(ByVal ex As Exception)
		//    tbException.Text = ex.ToString()
		
		//    MessageBox.Show("Exception Occurred. Check the Exception Tab for More Info.")
		//End Sub
		public void txtItem_TextChanged(object sender, System.EventArgs e)
		{
			//If txtItem.Text.Trim = String.Empty Then
			//    DGSearch.DataSource = ""
			//    DGSearch.Visible = False
			//End If
			
			//Dim i, j As Integer
			//i = 0
			//If String.IsNullOrEmpty(txtItem.Text) Then
			//    DGSearch.DataSource = ""
			//    DGSearch.Visible = False
			//End If
			
			//If Not String.IsNullOrEmpty(txtItem.Text) Then
			//    Try
			//        mgr3 = New stocksManager()
			//        Dim entity As stocks = New stocks
			
			//        mgr3.DataObject.WhereFilter = stocksData.WhereFilters.Likeitem
			//        mgr3.Entity.item = txtItem.Text.Trim()
			//        mgr3.DataObject.SelectFilter = stocksData.SelectFilters.GridBox
			//        col1 = mgr3.BuildCollection
			//        tbSQL.Text = mgr3.DataObject.SQL
			
			//        If mgr3.DataObject.RowsAffected > 0 Then
			//            j = mgr3.DataObject.RowsAffected
			//        End If
			
			//        For i = 0 To (j - 1)
			//            'lstgroups.Items.Add(mgr2.DataObject.DataSetObject.Tables(0).Rows(I)(0)) ' .Tables(0).Rows(i)(0))
			//            'DGSearch.Rows.Add(mgr3.DataObject.Entity.stckid, mgr3.DataObject.Entity.barcode, mgr3.DataObject.Entity.item)
			//            MsgBox(mgr3.DataObject.DataSetObject.Tables(0).Rows(i)(0))
			//            MsgBox(mgr3.DataObject.DataSetObject.Tables(0).Rows(i)(1))
			//            MsgBox(mgr3.DataObject.DataSetObject.Tables(0).Rows(i)(2))
			//            DGSearch.Rows.Add(mgr3.DataObject.DataSetObject.Tables(0).Rows(i)(0), mgr3.DataObject.DataSetObject.Tables(0).Rows(i)(1), mgr3.DataObject.DataSetObject.Tables(0).Rows(i)(2))
			//        Next
			
			//        'nProdID = mgr3.DataObject.Entity.stckid
			//        'cItem = mgr3.DataObject.Entity.item
			//        DGSearch.Top = (txtItem.Top + txtItem.Height)
			//        DGSearch.Left = txtItem.Left
			//        DGSearch.Visible = True
			//    Catch ex As Exception
			//        MessageBox.Show(ex.ToString())
			//    End Try
			
			//End If
			if (txtitem.Text == string.Empty)
			{
				//MessageBox.Show("Enter an item description to seaarch.")
				//txtitem.Focus()
				dgitems.Visible = false;
				return;
			}
			else
			{
				
				vwStocksManager mgrloaditem = default(vwStocksManager);
				vwStocksCollection cols;
				
				try
				{
					
					mgrloaditem = new vwStocksManager();
					mgrloaditem.DataObject.SelectFilter = vwStocksData.SelectFilters.All;
					mgrloaditem.DataObject.WhereFilter = vwStocksData.WhereFilters.likeitem;
					mgrloaditem.Entity.itemdesc = txtitem.Text.Trim();
					mgrloaditem.DataObject.OrderByFilter = vwStocksData.OrderByFilters.itemdescript;
					cols = mgrloaditem.BuildCollection();
					if (mgrloaditem.DataObject.RowsAffected > 0)
					{
						
						dgitems.DataSource = mgrloaditem.DataObject.GetDataTable();
						dgitems.Visible = true;
						dgitems.Columns[0].Visible = false;
						dgitems.Columns[1].Visible = false;
						dgitems.Columns[4].Visible = false;
						dgitems.Columns[6].Visible = false;
						dgitems.Columns[7].Visible = false;
						dgitems.Columns[2].Width = 500;
						dgitems.Columns[2].HeaderText = "Item Description";
						dgitems.Columns[3].HeaderText = "Available";
						dgitems.Columns[5].HeaderText = "Retail Price";
						dgitems.Columns[6].HeaderText = "Whole Sale";
						dgitems.Columns[7].HeaderText = "Packaging";
						//dgitems.Columns(7).HeaderText = "Barcode"
						dgitems.Columns[3].Width = 150;
						dgitems.Columns[5].Width = 150;
						//dgitems.Columns(8).Visible = False
						//dgitems.Columns(9).Visible = False
						//dgitems.Columns(10).Visible = False
						dgitems.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
						dgitems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
						dgitems.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 14.0F, FontStyle.Regular);
						
						this.dgitems.RowTemplate.Height = 26;
						this.dgitems.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14.0F, FontStyle.Regular);
						this.dgitems.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14.0F, FontStyle.Regular);
						this.dgitems.Columns["item_desc"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16.0F, FontStyle.Regular);
						this.dgitems.Columns["retail"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16.0F, FontStyle.Regular);
						this.dgitems.Columns["available"].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16.0F, FontStyle.Regular);
						
						this.dgitems.Columns["retail"].DefaultCellStyle.Format = "c";
						this.dgitems.Columns["retail2"].DefaultCellStyle.Format = "c";
						this.dgitems.Columns["retail"].DefaultCellStyle.Alignment = 
							DataGridViewContentAlignment.MiddleRight;
						this.dgitems.Columns["retail2"].DefaultCellStyle.Alignment = 
							DataGridViewContentAlignment.MiddleRight;
						this.dgitems.Columns["Available"].DefaultCellStyle.Alignment = 
							DataGridViewContentAlignment.MiddleRight;
						// ''.DefaultCellStyle.NullValue = "no entry"
						//'.Columns("Packaging").DefaultCellStyle.Alignment = _
						//'DataGridViewContentAlignment.MiddleRight()
						//.DefaultCellStyle.WrapMode = DataGridViewTriState.True
						//.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
						this.dgitems.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
						//.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
						this.dgitems.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
						this.dgitems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
						this.dgitems.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
						//txtfilter.Enabled = True
						//btnFilter.Enabled = True
						//dgitems.Focus()
					}
					else
					{
						//MessageBox.Show("No item(s) related to the search criteria!")
						txtitem.Focus();
						
						//txtitem.SelectAll()
					}
					
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
		
		
		public void PosGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			//Dim msg As String = _
			//String.Format("Editing Cell at ({0}, {1})", _
			//e.ColumnIndex, e.RowIndex)
			//Me.Text = msg
			//origprice = CDec(PosGrid.SelectedRows.Item(0).Cells(4).Value)
		}
		
		public void PosGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			//Dim mgrcp As tblChangedPriceManager
			//Dim dgvrowints As Integer = 0
			//Dim msgtran As PDSATransaction = New PDSATransaction()
			//String.Format("Finished Editing Cell at ({0}, {1})", _
			//e.ColumnIndex, e.RowIndex)
			//Me.Text = msg
			// NuPrice = CDec(PosGrid.SelectedRows.Item(0).Cells(4).Value)
			
			//If origprice <> NuPrice Then
			
			
			//    'TryToParse(CStr(PosGrid.SelectedRows.Item(0).Cells(4).Value))
			
			
			//    Try
			//        mgrcp = New tblChangedPriceManager()
			
			//        dgvrowints = Convert.ToInt32(PosGrid.CurrentRow.Index.ToString)
			//        'save selected item that is removed
			//        mgrcp.Entity.stckid = Convert.ToInt32(PosGrid.Rows(ii).Cells(0).Value)
			//        mgrcp.Entity.cpdate = DateAndTime.Now()
			//        mgrcp.Entity.oldprice = origprice
			//        mgrcp.Entity.newprice = NuPrice
			//        mgrcp.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
			//        msgtran.Add(mgrcp.DataObject)
			//        msgtran.Execute()
			//        '    Dim NewTot As Decimal = 0
			//        '    Dim iii As Integer = 0
			//        '    Dim ItemCnt1 As Integer = 0
			//        '    Dim NewPrices As Decimal = 0
			//        '    NewTot = 0
			//        '    iii = 0
			//        '    'ItemCnt = PosGrid.Rows(CInt(PosGrid.SelectedRows(0).Cells(5).Value)) Then
			//        '    ItemCnt1 = CInt(PosGrid.SelectedRows.Item(0).Cells(5).Value)
			//        '    'ItemCnt = ItemCnt + 1
			//        '    PosGrid.SelectedRows.Item(0).Cells(5).Value = ItemCnt1
			//        '    Dim NewPrice As Decimal = CDec(PosGrid.SelectedRows.Item(0).Cells(4).Value) * ItemCnt1
			//        '    PosGrid.SelectedRows.Item(0).Cells(6).Value = NewPrices
			
			//        '    'Recompute the total
			//        '    For iii = 0 To PosGrid.Rows.Count - 1
			//        '        NewTot += CDec(PosGrid.Rows(iii).Cells(6).Value)
			//        '    Next
			//        '    'CalcEdit1.Value = Totsss
			//        '    txtSum.Text = FormatNumber(CStr(NewTot))
			//        '    vpTotalSales = NewTot
			//        '    'TextEdit1.Text = FormatCurrency(CStr(Totsss))
			
			//    Catch ex As PDSAValidationException
			//        MessageBox.Show(ex.Message)
			//    Catch ex As Exception
			//        MessageBox.Show(ex.ToString())
			//    End Try
			//End If
		}
		public void PosGrid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			int ItemCnt = 0;
			// Dim ItemLocc As String
			decimal Totsss = new decimal();
			int iii = 0;
			try
			{
				
				//uSer pressed the add key to add more qty incremented by 1
				if (e.KeyCode == Keys.Add)
				{
					Totsss = 0;
					iii = 0;
					if (cmbPriceMode.Text == "Refund")
					{
						ItemCnt = System.Convert.ToInt32(PosGrid.SelectedRows[0].Cells[2].Value);
						ItemCnt--;
						PosGrid.SelectedRows[0].Cells[2].Value = ItemCnt;
						decimal NewPrice2 = (System.Convert.ToDecimal(PosGrid.SelectedRows[0].Cells[5].Value)) * ItemCnt;
						PosGrid.SelectedRows[0].Cells[6].Value = NewPrice2;
					}
					else
					{
						//ItemCnt = PosGrid.Rows(CInt(PosGrid.SelectedRows(0).Cells(5).Value)) Then
						ItemCnt = System.Convert.ToInt32(PosGrid.SelectedRows[0].Cells[2].Value);
						ItemCnt++;
						PosGrid.SelectedRows[0].Cells[2].Value = ItemCnt;
						decimal NewPrice = (System.Convert.ToDecimal(PosGrid.SelectedRows[0].Cells[5].Value)) * ItemCnt;
						PosGrid.SelectedRows[0].Cells[6].Value = NewPrice;
					}
					
					//Recompute the total
					for (iii = 0; iii <= PosGrid.Rows.Count - 1; iii++)
					{
						Totsss += System.Convert.ToDecimal(PosGrid.Rows[iii].Cells[6].Value);
					}
					//CalcEdit1.Value = Totsss
					txtSum.Text = Strings.FormatNumber(Totsss, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); //FormatNumber(CStr(Totsss))
					CheckSumifNegative();
					VarsModule.vpTotalSales = Totsss;
					//TextEdit1.Text = FormatCurrency(CStr(Totsss))
					
					
				}
				
				//User pressed the minus key to subtract quantity by 1
				if (e.KeyCode == Keys.Subtract)
				{
					Totsss = 0;
					iii = 0;
					if (cmbPriceMode.Text == "Refund")
					{
						ItemCnt = System.Convert.ToInt32(PosGrid.SelectedRows[0].Cells[5].Value);
						ItemCnt++;
						if (ItemCnt == 0)
						{
							ItemCnt = 1;
						}
						PosGrid.SelectedRows[0].Cells[5].Value = ItemCnt;
						decimal NewPrice3 = (System.Convert.ToDecimal(PosGrid.SelectedRows[0].Cells[5].Value)) * ItemCnt;
						PosGrid.SelectedRows[0].Cells[6].Value = NewPrice3;
					}
					else
					{
						ItemCnt = System.Convert.ToInt32(PosGrid.SelectedRows[0].Cells[5].Value);
						ItemCnt--;
						if (ItemCnt == 0)
						{
							ItemCnt = 1;
						}
						PosGrid.SelectedRows[0].Cells[5].Value = ItemCnt;
						decimal NewPrice = (System.Convert.ToDecimal(PosGrid.SelectedRows[0].Cells[5].Value)) * ItemCnt;
						PosGrid.SelectedRows[0].Cells[6].Value = NewPrice;
					}
					//Recompute the total
					for (iii = 0; iii <= PosGrid.Rows.Count - 1; iii++)
					{
						Totsss += System.Convert.ToDecimal(PosGrid.Rows[iii].Cells[6].Value);
					}
					//CalcEdit1.Value = Totsss
					txtSum.Text = Strings.FormatNumber(Totsss, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); //FormatNumber(CStr(Totsss))
					CheckSumifNegative();
					VarsModule.vpTotalSales = Totsss;
					
					//TextEdit1.Text = FormatCurrency(CStr(Totsss))
					
					if (e.KeyCode == Keys.Enter)
					{
						txtitem.Focus();
					}
					
					
				}
				
				if (e.KeyCode == Keys.D)
				{
					VoidItem();
				}
				
				
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
		
		//Private Sub ceQty_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
		//    If e.KeyChar = Chr(13) Then
		//        If qtyy < 1 Then
		//            qtyy = 1
		//        End If
		//        qtyy = CInt(ceQty.Value)
		//        ceQty.Visible = False
		//        txtBarcode.Focus()
		//    End If
		
		//    If e.KeyChar = Chr(Keys.Escape) Then
		//        If ceQty.Value < 1 Then
		//            ceQty.Value = 1
		//        End If
		//        qtyy = CInt(ceQty.Value)
		//        ceQty.Visible = False
		//        txtBarcode.Focus()
		//    End If
		//End Sub
		//Private Sub ceQty_LostFocus(sender As Object, e As System.EventArgs)
		//    If ceQty.Value < 1 Then
		//        ceQty.Value = 1
		//    End If
		//    qtyy = CInt(ceQty.Value)
		//    ceQty.Visible = False
		//End Sub
		private void Label1_Click(System.Object sender, System.EventArgs e)
		{
			//txtBarcode.Text = String.Empty
			try
			{
				
				if (!string.IsNullOrEmpty(txtBarcode.Text))
				{
					txtBarcode.SelectAll();
				}
				//leCust.EditValue = vbNullString
				//'leItems.EditValue = vbNullString
				txtBarcode.Text = "";
				//txtBarcode.Focus()
				//btnSearchItems.Focus()
				txtitem.Focus();
				txtitem.Text = string.Empty;
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
		
		
		
		public void frmPOS_Load(object sender, System.EventArgs e)
		{
			//DevExpress.Utils.AppearanceObject.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0F)
			//txtCashier.Text = PDSAAppConfig.CurrentLoginID
			string strm = "";
			string strd = "";
			string stry = "";
			strm = DateTime.Today.Month.ToString();
			strd = DateTime.Today.Day.ToString();
			stry = DateTime.Today.Year.ToString();
			
			Timer1.Start();
			this.Cursor = Cursors.WaitCursor;
			this.Text = "Inventory and Sales Monitoring System-Current User--"; // & PDSAAppConfig.CurrentLoginID
			PosGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
			PosGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			PosGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
			PosGrid.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			PosGrid.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			lblName.Text = Strings.UCase(System.Convert.ToString(PDSAAppConfig.CurrentLoginID));
			lblDate.Text = strm + "/" + strd + "/" + stry;
			
			this.Cursor = Cursors.Default;
			//+Latest Comments
			//Loads_frm()
			//Load_Emps()
			//+End of Latest Comment
			//++I commented btnnewfocus to automatically call New Transaction
			//btnnew.Focus()
			NewTransaction();
			//++End of Comment
			
			//FullScreen()
			//Loads_frm()
		}
		public void Loads_frm()
		{
			//'TODO: This line of code loads data into the 'DoorsposDataSet.stocks' table. You can move, or remove it, as needed.
			
			//Me.StocksTableAdapter.Fill(Me.DoorsposDataSet.stocks)
			//GridLookUpEdit1.Properties.View.OptionsBehavior.AutoPopulateColumns = False
			// Set column widths according to their contents.
			//GridLookUpEdit1.Properties.View.BestFitColumns()
			// Specify the total dropdown width.
			//GridLookUpEdit1.Properties.PopupFormWidth = 860
			
			//GridLookUpEdit1.Properties.View.Columns(1).Width = 100
			// GridLookUpEdit1.Properties.View.Columns(2).Width = 20
			//GridLookUpEdit1.Properties.View.Columns(3).Width = 30
			//Set the header  style of POS datagridview
			//GridLookUpEdit1.Properties.View.Columns(0).Width = 100
			//GridLookUpEdit1.Properties.View.Columns(1).Width = 100
			//GridLookUpEdit1.Properties.PopupFormWidth = 900
			
			PosGrid.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomRight;
			PosGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomRight;
			int pbarint = 0;
			string strm = "";
			vwStocksManager mgrstocks = default(vwStocksManager);
			vwStocksCollection cols = default(vwStocksCollection);
			try
			{
				mgrstocks = new vwStocksManager();
				mgrstocks.DataObject.SelectFilter = vwStocksData.SelectFilters.All;
				mgrstocks.DataObject.OrderByFilter = vwStocksData.OrderByFilters.itemdescript;
				cols = mgrstocks.BuildCollection();
				//GridLookUpEdit2.Properties.View.OptionsBehavior.AutoPopulateColumns = False
				
				//GridLookUpEdit2.Properties.View.BestFitColumns()
				//GridLookUpEdit2.Properties.View.Columns(9).Width = 30
				//GridLookUpEdit2.Properties.View.Columns(10).Width = 30
				GridLookUpEdit2.Properties.PopupFormWidth = 860;
				
				
				GridLookUpEdit2.Properties.DisplayMember = "itemdesc";
				GridLookUpEdit2.Properties.ValueMember = "stckid";
				//GridLookUpEdit2.EditValue = "itemdesc"
				GridLookUpEdit2.Properties.DataSource = cols;
				// ''tbSQL.Text = mgr.DataObject.SQL
			}
			catch (PDSA.Validation.PDSAValidationException ex)
			{
				MessageBox.Show(ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			//LoadCust()
			//'FullScreen()
		}
		public void LoadCust()
		{
			//Dim mgrmembers As membersManager
			//Dim cols As membersCollection
			//Try
			//    mgrmembers = New membersManager
			//    mgrmembers.DataObject.SelectFilter = membersData.SelectFilters.All
			//    mgrmembers.DataObject.OrderByFilter = membersData.OrderByFilters.lastname
			//    cols = mgrmembers.BuildCollection()
			
			//    gleCust.Properties.View.OptionsBehavior.AutoPopulateColumns = False
			
			//    gleCust.Properties.View.BestFitColumns()
			//    gleCust.Properties.PopupFormWidth = 300
			
			//    gleCust.Properties.DisplayMember = "lastname"
			//    gleCust.Properties.ValueMember = "CustId"
			//    gleCust.EditValue = "custid"
			//    MessageBox.Show(CStr(gleCust.Properties.ValueMember))
			//    gleCust.Properties.DataSource = cols
			
			//Catch ex As PDSAValidationException
			//    MessageBox.Show(ex.Message)
			//Catch ex As Exception
			//    MessageBox.Show(ex.ToString())
			//End Try
		}
		public void Load_Emps()
		{
			waitersManager mgrsemps = default(waitersManager);
			waitersCollection colsemps = default(waitersCollection);
			try
			{
				mgrsemps = new waitersManager();
				mgrsemps.DataObject.SelectFilter = waitersData.SelectFilters.All;
				colsemps = mgrsemps.BuildCollection();
				//mgrsemps.DataObject.OrderByFilter = vwStocksData.OrderByFilters.itemdescript
				dgEmps.DataSource = colsemps;
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
		
		public void txtBarcode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			//If e.KeyCode = 40 And DataGridView1.RowCount > 0 Then
			//DataGridView1.Focus()
			//Me.DataGridView1.Rows(Me.DataGridView1.RowCount - 1).Selected = True
			
			//End If
			if (e.Alt == true & e.KeyCode == Keys.Tab)
			{
				e.Handled = true;
			}
			
			if (e.Alt == true & e.KeyCode == Keys.F4)
			{
				e.Handled = true;
			}
			
			
			if (e.KeyCode == Keys.Right)
			{
				//'txtBarcode.Text = String.Empty
				//'txtItem.Focus()
				txtitem.Text = string.Empty;
				txtitem.Focus();
				txtitem.Text = string.Empty;
				//leItems.Text = String.Empty
				//leItems.Focus()
			}
			
			if (e.KeyCode == Keys.Down)
			{
				PosGrid.Focus();
			}
			
			if (e.KeyCode == Keys.F1)
			{
				e.Handled = true;
				frmQty formQty = new frmQty();
				formQty.ShowDialog();
			}
			
			
			if (e.KeyCode == Keys.Enter)
			{
				if (!string.IsNullOrEmpty(txtBarcode.Text))
				{
					
					try
					{
						mgr = new stocksManager();
						mgr.DataObject.WhereFilter = stocksData.WhereFilters.barcode;
						mgr.Entity.barcode = txtBarcode.Text.Trim();
						//MessageBox.Show("Total Record Count is " & _
						//mgr.DataObject.RowCount().ToString())
						tbSQL.Text = mgr.DataObject.SQL;
						
						col1 = mgr.BuildCollection();
						
						
						if (mgr.DataObject.RowsAffected > 0)
						{
							
							//DataGridView1.DataSource = col1 'mgr.BuildCollection()
							nProdID = mgr.DataObject.Entity.stckid;
							txtitem.Text = mgr.DataObject.Entity.itemdesc;
							txtbcodes.Text = mgr.DataObject.Entity.barcode;
							txtStckid.Text = (mgr.DataObject.Entity.stckid).ToString();
							txtqty.Text = (qtyy).ToString();
							SendItemtoGrid();
						}
						else
						{
							//MessageBox.Show("B A R C O D E  N O T  F O U N D")
							frmNotFound frmnotfawn = new frmNotFound();
							frmnotfawn.ShowDialog();
							txtTendered.Text = "0";
							lblChange.Text = "0";
						}
						
					}
					catch (PDSA.Validation.PDSAValidationException ex)
					{
						MessageBox.Show(ex.Message);
						
						// Catch ex As Exception
						//MsgBox(ex.Message.ToString())
						// MessageBox.Show(ex.ToString())
					}
					//Else
					//    Try
					//        mgr2 = New stocksManager()
					
					//        mgr2.DataObject.WhereFilter = stocksData.WhereFilters.Likeitem
					//        mgr2.Entity.item = txtItem.Text.Trim()
					//        col1 = mgr2.BuildCollection()
					
					//        If mgr2.DataObject.RowsAffected > 0 Then
					
					//            'DataGridView1.DataSource = col1 'mgr.BuildCollection()
					//            cItem = mgr2.DataObject.Entity.item
					//            SendItemtoGrid()
					
					//        End If
					
					//    Catch ex As Exception
					//        'ex.Message.ToString()
					//    End Try
					
				}
				txtBarcode.SelectAll();
			}
		}
		
		public void BCodeFocus()
		{
			try
			{
				if (!string.IsNullOrEmpty(txtBarcode.Text))
				{
					txtBarcode.SelectAll();
				}
				// leCust.EditValue = vbNullString
				//'leItems.EditValue = vbNullString
				txtBarcode.Text = "";
				txtBarcode.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		public void txtBarcode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				txtTendered.Text = "0";
				lblChange.Text = "0";
				if (txtBarcode.Text == string.Empty)
				{
					MessageBox.Show("B a r c o d e   n o t   f o u n d   o r   e m p t y !");
				}
			}
		}
		
		
		public void SuspendTrans()
		{
			if (PosGrid.Rows.Count < 1)
			{
				MessageBox.Show("No Items to Suspend");
				return;
			}
			ArrayList myAL = new ArrayList();
			oht = new pos_hdrtmpManager();
			if (Interaction.MsgBox("Are you sure you want to suspend this transaction?", (MsgBoxStyle) ((int) MsgBoxStyle.Information + MsgBoxStyle.YesNo), null) == MsgBoxResult.Yes)
			{
				if (PosGrid.Rows.Count < 1)
				{
					MessageBox.Show("Item List is  B l a n k");
					//btnSearchItems.Focus()
					//txtBarcode.Focus()
					txtitem.Focus();
					txtitem.Text = string.Empty;
					return;
				}
				
				try
				{
					
					Tran = new PDSA.DataLayer.DataClasses.PDSATransaction();
					Tran.AfterSubmit += Tran_AfterSubmit;
					Tran.BeforeSubmit += Tran_BeforeSubmit;
					Tran2 = new PDSA.DataLayer.DataClasses.PDSATransaction();
					oht.DataObject.TransactionType = PDSATransactionType.Insert;
					
					
					//oht.Entity.custid = 205
					//oht.Entity.posdate = DateTime.Today()
					//    oht.Entity.status = False
					
					//    oht.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
					//    Tran.Add(oht.DataObject)
					//    Tran.Execute()
					//    grdCount = PosGrid.Rows.Count
					//    For ii = 0 To grdCount - 1
					//        odt1.Entity.postmphdrid = mOrderId
					//        odt1.Entity.stckid = Convert.ToInt32(PosGrid.Rows(ii).Cells(0).Value)
					//        odt1.Entity.barcode = CStr(PosGrid.Rows(ii).Cells(1).Value)
					//        odt1.Entity.itemdesc = CStr(PosGrid.Rows(ii).Cells(2).Value)
					//        odt1.Entity.cost = Convert.ToDecimal(PosGrid.Rows(ii).Cells(3).Value)
					//        odt1.Entity.price = Convert.ToDecimal(PosGrid.Rows(ii).Cells(4).Value)
					//        odt1.Entity.qty = Convert.ToInt32(PosGrid.Rows(ii).Cells(5).Value)
					//        odt1.Entity.detamnt = Convert.ToDecimal(PosGrid.Rows(ii).Cells(4).Value) * Convert.ToInt32(PosGrid.Rows(ii).Cells(5).Value)
					
					//        myAL.Add(odt1.DataObject.Entity)
					
					//        Tran2.Add(odt1.DataObject)
					//        Tran2.Execute()
					//        Tran2.RemoveAt(0)
					//    Next
					
					//Catch ex As PDSAValidationException
					//    MessageBox.Show(ex.Message)
					//Catch ex As Exception
					//    MessageBox.Show(ex.ToString())
					//End Try
					if (txtcustid.Text == "0")
					{
						txtcustid.Text = "205";
					}
					oht.Entity.custid = Convert.ToInt32(txtcustid.Text);
					oht.Entity.posdate = DateTime.Now;
					oht.Entity.status = false;
					//gOT pUZZLED WHY I have 2 status so I commented it below , comment up if it is the right one
					//oht.Entity.status = False
					//*************
					oht.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					Tran.Add(oht.DataObject);
					//commented on june 12 2014 and brought it down
					//Catch ex As PDSAValidationException
					//    MessageBox.Show(ex.Message)
					//    Exit Sub
					//Catch ex As Exception
					//    MessageBox.Show(ex.ToString())
					//    Exit Sub
					//End Try
					//end of comment on june 12 2014 and brought it down
					
					grdCount = PosGrid.Rows.Count;
					for (ii = 0; ii <= grdCount - 1; ii++)
					{
						odt1 = new pos_dettmpManager();
						odt1.DataObject.TransactionType = PDSATransactionType.Insert;
						odt1.Entity.postmphdrid = mOrderId;
						odt1.Entity.stckid = Convert.ToInt32(PosGrid.Rows[ii].Cells[0].Value);
						odt1.Entity.barcode = (PosGrid.Rows[ii].Cells[1].Value).ToString();
						odt1.Entity.itemdesc = (PosGrid.Rows[ii].Cells[4].Value).ToString();
						odt1.Entity.cost = Convert.ToDecimal(PosGrid.Rows[ii].Cells[3].Value);
						odt1.Entity.price = Convert.ToDecimal(PosGrid.Rows[ii].Cells[5].Value);
						odt1.Entity.ws = Convert.ToDecimal(PosGrid.Rows[ii].Cells[7].Value);
						odt1.Entity.qty = Convert.ToInt32(PosGrid.Rows[ii].Cells[2].Value);
						odt1.Entity.detamnt = Convert.ToDecimal(PosGrid.Rows[ii].Cells[5].Value) * Convert.ToInt32(PosGrid.Rows[ii].Cells[2].Value);
						odt1.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
						odt1.Entity.detdisc = (short) (Convert.ToDecimal(PosGrid.Rows[ii].Cells[8].Value));
						odt1.Entity.incentiv = Convert.ToDecimal(PosGrid.Rows[ii].Cells[9].Value) * Convert.ToInt32(PosGrid.Rows[ii].Cells[2].Value);
						Tran.Add(odt1.DataObject);
					}
					Tran.Execute();
					PosGrid.Rows.Clear();
					txtSum.Text = "0";
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
		
		private void Tran_AfterSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			// Get the SQL Identity generated and store into local variable
			if (e.ClassName == "pos_hdrtmpData")
			{
				mOrderId = ((pos_hdrtmp) e.DataClassTable.EntityObject).postmphdrid;
			}
		}
		
		private void Tran_BeforeSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			// Put local order id into line item objects prior to submitting INSERT statement
			//If e.ClassName = "pos_dettmpData" Then
			// DirectCast(e.DataClassTable.EntityObject, pos_dettmp).postmphdrid = mOrderId
			//End If
			if (e.ClassName == "pos_dettmpData")
			{
				((pos_dettmp) e.DataClassTable.EntityObject).postmphdrid = mOrderId;
			}
			
		}
		
		//Private Sub Tran2_AfterSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles Tran.AfterSubmit
		//    ' Get the SQL Identity generated and store into local variable
		//    If e.ClassName = "pos_hdrtmpData" Then
		//        mOrderId = DirectCast(e.DataClassTable.EntityObject, pos_hdrtmp).postmphdrid
		//    End If
		//End Sub
		
		//Private Sub Tran2_BeforeSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles Tran.BeforeSubmit
		//    ' Put local order id into line item objects prior to submitting INSERT statement
		//    If e.ClassName = "pos_dettmpData" Then
		//        DirectCast(e.DataClassTable.EntityObject, pos_dettmp).postmphdrid = mOrderId
		//    End If
		//End Sub
		
		// Private Sub btnRetrieve_Click(sender As System.Object, e As System.EventArgs) Handles btnRetrieve.Click
		//Dim mgrRetrieve As pos_hdrtmpManager
		//Dim col3 As pos_hdrtmpCollection
		
		//Try
		//    mgrRetrieve = New pos_hdrtmpManager()
		//    mgrRetrieve.DataObject.WhereFilter = pos_hdrtmpData.WhereFilters.sInsert_id
		//    mgrRetrieve.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
		//    tbSQL.Text = mgrRetrieve.DataObject.SQL
		//    col3 = mgrRetrieve.BuildCollection
		//    If mgrRetrieve.DataObject.RowsAffected > 0 Then
		//        DGRetrieve.Visible = True
		//        DGRetrieve.Focus()
		//        DGRetrieve.DataSource = col3
		
		//    Else
		//        MessageBox.Show("N o   S u s p e n d e d   S a l e   t o   D i s p l a y")
		//        DGRetrieve.Visible = False
		//        txtBarcode.Focus()
		
		//    End If
		//    'PosGrid.Rows.Add(mgr.DataObject.Entity.s, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.item, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail,                 qtyy, mgr.DataObject.Entity.retail)
		
		
		//Catch ex As PDSAValidationException
		//    MessageBox.Show(ex.Message)
		
		//Catch ex As Exception
		//    MessageBox.Show(ex.ToString())
		//End Try
		//Dim mgrRetrieve As vwSuspendHdrManager
		//Dim col3 As vwSuspendHdrCollection
		
		//Try
		//    mgrRetrieve = New vwSuspendHdrManager()
		//    mgrRetrieve.DataObject.WhereFilter = vwSuspendHdrData.WhereFilters.cashstatus
		//    mgrRetrieve.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
		//    mgrRetrieve.Entity.status = False
		//    tbSQL.Text = mgrRetrieve.DataObject.SQL
		//    col3 = mgrRetrieve.BuildCollection()
		//    If mgrRetrieve.DataObject.RowsAffected > 0 Then
		//        DGRetrieve.Visible = True
		//        DGRetrieve.Focus()
		//        DGRetrieve.DataSource = col3
		
		//    Else
		//        MessageBox.Show("N o   S u s p e n d e d   S a l e   t o   D i s p l a y")
		//        DGRetrieve.Visible = False
		//        txtBarcode.Focus()
		
		//    End If
		//    'PosGrid.Rows.Add(mgr.DataObject.Entity.s, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.item, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail,                 qtyy, mgr.DataObject.Entity.retail)
		
		//Catch ex As PDSAValidationException
		//    MessageBox.Show(ex.Message)
		
		//Catch ex As Exception
		//    MessageBox.Show(ex.ToString())
		//End Try
		//    If PosGrid.Rows.Count > 1 Then
		//        MessageBox.Show("Pls. Finish or Cancel the existing sales transaction first before retrieving a suspended sales transaction")
		//        Exit Sub
		//    End If
		//    Call RetrieveTrans()
		
		//End Sub
		
		public void RetrieveTrans()
		{
			vwSuspendedSaleManager mgrRetrieve = default(vwSuspendedSaleManager);
			vwSuspendedSaleCollection col3;
			
			this.DGRetrieve.DefaultCellStyle.Font = new Font("Tahoma", 16);
			
			try
			{
				mgrRetrieve = new vwSuspendedSaleManager();
				mgrRetrieve.DataObject.SelectFilter = vwSuspendedSaleData.SelectFilters.SuspendedItems;
				mgrRetrieve.DataObject.WhereFilter = vwSuspendedSaleData.WhereFilters.cashstatus;
				mgrRetrieve.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				mgrRetrieve.Entity.status = false;
				
				//tbSQL.Text = mgrRetrieve.DataObject.SQL
				col3 = mgrRetrieve.BuildCollection();
				if (mgrRetrieve.DataObject.RowsAffected > 0)
				{
					DGRetrieve.Visible = true;
					DGRetrieve.Focus();
					DGRetrieve.DataSource = mgrRetrieve.DataObject.GetDataTable(); //col3
					this.DGRetrieve.AutoResizeColumns();
					this.DGRetrieve.Columns[3].Visible = false;
					this.DGRetrieve.Columns[2].Visible = false;
					this.DGRetrieve.Columns["det_amnt"].DefaultCellStyle.Format = "c";
					this.DGRetrieve.Columns["det_amnt"].DefaultCellStyle.Alignment = 
						DataGridViewContentAlignment.MiddleRight;
				}
				else
				{
					MessageBox.Show("N o   S u s p e n d e d   S a l e   t o   D i s p l a y");
					DGRetrieve.Visible = false;
					//btnSearchItems.Focus()
					//txtBarcode.Focus()
					txtitem.Focus();
					txtitem.Text = string.Empty;
				}
				//PosGrid.Rows.Add(mgr.DataObject.Entity.s, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.item, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail,                 qtyy, mgr.DataObject.Entity.retail)
				
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
		private void SetDefaultCellStyles()
		{
			
			DataGridViewCellStyle highlightCellStyle = new DataGridViewCellStyle();
			highlightCellStyle.BackColor = Color.Red;
			
			DataGridViewCellStyle currencyCellStyle = new DataGridViewCellStyle();
			currencyCellStyle.Format = "N";
			currencyCellStyle.ForeColor = Color.Green;
			
			this.DGRetrieve.DefaultCellStyle.BackColor = Color.Beige;
			this.DGRetrieve.DefaultCellStyle.Font = new Font("Tahoma", 12);
			this.DGRetrieve.Rows[3].DefaultCellStyle = highlightCellStyle;
			this.DGRetrieve.Rows[3].DefaultCellStyle = highlightCellStyle;
			this.DGRetrieve.Columns["qty"].DefaultCellStyle = currencyCellStyle;
			this.DGRetrieve.Columns["qty"].DefaultCellStyle = currencyCellStyle;
			this.DGRetrieve.Rows[0].Visible = false;
			this.DGRetrieve.Rows[4].Visible = false;
		}
		
		public void DGRetrieve_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			int ii = 0;
			
			//If e.KeyCode = Keys.Escape Then
			//    DGRetrieve.Visible = False
			//    txtitem.Focus()
			//    Exit Sub
			//End If
			
			if (e.KeyCode == Keys.Enter)
			{
				int vCellVal = 0;
				int row = DGRetrieve.CurrentCellAddress.Y;
				int column = DGRetrieve.CurrentCellAddress.X;
				vwSuspendedCollection col4;
				
				if (column > 1)
				{
					MessageBox.Show("Please select the suspended sale on the first column or select the second column to Cancel Retrieval of Suspended Sale");
					return;
				}
				
				if (column == 0) // this is the main code to be executed
				{
					//MessageBox.Show(row.ToString + " " + column.ToString)
					vCellVal = System.Convert.ToInt32(DGRetrieve.CurrentCell.Value);
					vwSuspendedManager mgrRetriv = default(vwSuspendedManager);
					pos_hdrtmpManager mgrHdrTmp = default(pos_hdrtmpManager);
					
					try
					{
						mgrRetriv = new vwSuspendedManager();
						mgrRetriv.DataObject.WhereFilter = vwSuspendedData.WhereFilters.SuspendId;
						mgrRetriv.Entity.postmphdrid = vCellVal;
						//tbSQL.Text = mgrRetriv.DataObject.SQL
						col4 = mgrRetriv.BuildCollection();
						if (mgrRetriv.DataObject.RowsAffected > 0)
						{
							//send the suspended value to POSGrid
							//Dim mgrsend As vwSuspendedManager
							//mgrsend = New vwSuspendedManager()
							//mgrsend.DataObject.WhereFilter = vwSuspendedData.WhereFilters.SuspendId
							//mgrsend.Entity.postmphdrid = vCellVal
							//Dim col5 As vwSuspendedCollection
							//col5 = mgrsend.BuildCollection()
							//If mgrsend.DataObject.RowsAffected > 0 Then
							for (ii = 0; ii <= mgrRetriv.DataObject.GetDataTable().Rows.Count - 1; ii++)
							{
								PosGrid.Rows.Add(mgrRetriv.DataObject.GetDataTable().Rows[ii]["stckid"], (mgrRetriv.DataObject.GetDataTable().Rows[ii]["barcode"]).ToString(), mgrRetriv.DataObject.GetDataTable().Rows[ii]["qty"], mgrRetriv.DataObject.GetDataTable().Rows[ii]["cost"], (mgrRetriv.DataObject.GetDataTable().Rows[ii]["item_desc"]).ToString(), mgrRetriv.DataObject.GetDataTable().Rows[ii]["price"], mgrRetriv.DataObject.GetDataTable().Rows[ii]["det_amnt"], mgrRetriv.DataObject.GetDataTable().Rows[ii]["cost"], mgrRetriv.DataObject.GetDataTable().Rows[ii]["det_disc"], mgrRetriv.DataObject.GetDataTable().Rows[ii]["incentiv"]);
							}
							decimal Tots22 = 0;
							int iii = 0;
							for (iii = 0; iii <= PosGrid.Rows.Count - 1; iii++)
							{
								Tots22 += System.Convert.ToDecimal(PosGrid.Rows[iii].Cells[6].Value);
							}
							txtSum.Text = Strings.FormatNumber(Tots22, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); //FormatNumber(CStr(Tots22))
							CheckSumifNegative();
							//This is a new code 02/21/2014
							VarsModule.vpTotalSales = Tots22;
							//End of New Code 02/21/2014
							//End If
							DGRetrieve.Visible = false;
						}
						//delete the records for the hdrtmp it will cascade delete the data on hdr_detiltmp
						mgrHdrTmp = new pos_hdrtmpManager();
						mgrHdrTmp.DataObject.DeleteByPK(vCellVal);
						
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
				btnBcode.PerformClick();
				
				if (column == 1)
				{
					DGRetrieve.Visible = false;
					txtitem.Focus();
				}
				txtitem.Focus();
			}
		}
		public void Employees()
		{
			waitersManager mgrEmpRetrieve = default(waitersManager);
			waitersCollection col33 = default(waitersCollection);
			
			try
			{
				mgrEmpRetrieve = new waitersManager();
				mgrEmpRetrieve.DataObject.SelectFilter = waitersData.SelectFilters.ListBox;
				//mgrEmpRetrieve.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
				//mgrEmpRetrieve.Entity.status = False
				//tbSQL.Text = mgrRetrieve.DataObject.SQL
				col33 = mgrEmpRetrieve.BuildCollection();
				if (mgrEmpRetrieve.DataObject.RowsAffected > 0)
				{
					dgEmps.Visible = true;
					dgEmps.Focus();
					dgEmps.DataSource = col33;
					
				}
				else
				{
					MessageBox.Show("No Current Cashier Names to Display");
					dgEmps.Visible = false;
					//btnSearchItems.Focus()
					txtitem.Focus();
					txtitem.Text = string.Empty;
					//txtBarcode.Focus()
					
				}
				
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
		public void TakePayments()
		{
			MessageBox.Show("Payment Executed and Saved!");
			//txtBarcode.Focus()
			//btnSearchItems.Focus()
			txtitem.Focus();
			txtitem.Text = string.Empty;
		}
		public void txtBarcode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Alt == true & e.KeyCode == Keys.Tab)
			{
				e.Handled = true;
			}
			
			if (e.Alt == true & e.KeyCode == Keys.F4)
			{
				e.Handled = true;
			}
		}
		private void leItems_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Alt == true & e.KeyCode == Keys.Tab)
			{
				e.Handled = true;
			}
			
			if (e.Alt == true & e.KeyCode == Keys.F4)
			{
				e.Handled = true;
			}
		}
		
		public void GridLookUpEdit2_Enter(object sender, EventArgs e)
		{
			
		}
		
		public void GridLookUpEdit2_GotFocus(object sender, EventArgs e)
		{
			
		}
		//Private Sub GridLookUpEdit1_KeyDown(sender As Object, e As KeyEventArgs)
		//    If e.Alt = True And e.KeyCode = Keys.Tab Then
		//        e.Handled = True
		//    End If
		
		//    If e.Alt = True And e.KeyCode = Keys.F4 Then
		//        e.Handled = True
		//    End If
		//    If e.KeyCode = Keys.Left Then
		//        txtBarcode.Focus()
		//        txtItem.Text = ""
		//    End If
		
		//End Sub
		
		//Private Sub GridLookUpEdit1_KeyPress(sender As Object, e As KeyPressEventArgs)
		
		//    If e.KeyChar = Chr(13) Then
		//        Try
		//            mgr6 = New stocksManager()
		//            mgr6.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey
		//            'MessageBox.Show(CType(leItems.EditValue, stocks))
		//            ' mgr6.DataObject.Entity.stckid = CInt(leCust.EditValue)
		
		//            col1 = mgr6.BuildCollection()
		
		//            If mgr6.DataObject.RowsAffected > 0 Then
		
		//                'DataGridView1.DataSource = col1 'mgr.BuildCollection()
		//                nProdID = mgr6.DataObject.Entity.stckid
		//                SendItemtoGrid3()
		
		//            End If
		
		//        Catch ex As PDSAValidationException
		//            MessageBox.Show(ex.Message)
		
		//        Catch ex As Exception
		
		//        End Try
		//    End If
		//End Sub
		
		//Private Sub GridLookUpEdit1_KeyUp(sender As Object, e As KeyEventArgs)
		//    If e.Alt = True And e.KeyCode = Keys.Tab Then
		//        e.Handled = True
		//    End If
		
		//    If e.Alt = True And e.KeyCode = Keys.F4 Then
		//        e.Handled = True
		//    End If
		//End Sub
		
		//Private Sub GridLookUpEdit1_KeyDown1(sender As Object, e As KeyEventArgs)
		//    If e.Alt = True And e.KeyCode = Keys.Tab Then
		//        e.Handled = True
		//    End If
		
		//    If e.Alt = True And e.KeyCode = Keys.F4 Then
		//        e.Handled = True
		//    End If
		//    If e.KeyCode = Keys.Left Then
		//        txtBarcode.Focus()
		//        txtItem.Text = ""
		//    End If
		
		//End Sub
		
		//Private Sub GridLookUpEdit1_KeyPress1(sender As Object, e As KeyPressEventArgs)
		//    If e.KeyChar = Chr(13) Then
		
		//    End If
		
		//    If e.KeyChar = Chr(13) Then
		//        Try
		//            mgr6 = New stocksManager()
		//            mgr6.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey
		//            ' 'MessageBox.Show(CType(leItems.EditValue, stocks))
		//            ' mgr6.DataObject.Entity.stckid = CInt(leCust.EditValue)
		
		//            col1 = mgr6.BuildCollection()
		
		//            If mgr6.DataObject.RowsAffected > 0 Then
		
		//                'DataGridView1.DataSource = col1 'mgr.BuildCollection()
		//                nProdID = mgr6.DataObject.Entity.stckid
		//                SendItemtoGrid3()
		
		//            End If
		
		//        Catch ex As PDSAValidationException
		//            MessageBox.Show(ex.Message)
		
		//        Catch ex As Exception
		
		//        End Try
		//    End If
		//End Sub
		
		//Private Sub GridLookUpEdit1_KeyUp1(sender As Object, e As KeyEventArgs)
		//    If e.Alt = True And e.KeyCode = Keys.Tab Then
		//        e.Handled = True
		//    End If
		
		//    If e.Alt = True And e.KeyCode = Keys.F4 Then
		//        e.Handled = True
		//    End If
		
		//End Sub
		
		//Private Sub GridLookUpEdit1_EditValueChanged_2(sender As Object, e As EventArgs) Handles GridLookUpEdit1.EditValueChanged
		
		//End Sub
		public void GridLookUpEdit2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Alt == true & e.KeyCode == Keys.Tab)
			{
				e.Handled = true;
			}
			
			if (e.Alt == true & e.KeyCode == Keys.F4)
			{
				e.Handled = true;
			}
			if (e.KeyCode == Keys.Left)
			{
				txtBarcode.Focus();
				txtitem.Text = "";
			}
		}
		
		public void GridLookUpEdit2_KeyPress(object sender, KeyPressEventArgs e)
		{
			
			if (e.KeyChar == '\r')
			{
				//LookupEditKeypress()
				ceQtyy.Focus();
			}
		}
		private void LookupEditKeypress()
		{
			try
			{
				if (txtitem.Text == string.Empty)
				{
					MessageBox.Show("Please select an Item before pressing the enter key!");
					return;
				}
				
				mgr6 = new stocksManager();
				mgr6.DataObject.SelectFilter = stocksData.SelectFilters.positems;
				mgr6.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey;
				// 'MessageBox.Show(CType(leItems.EditValue, stocks))
				mgr6.DataObject.Entity.stckid = vStckid; //CInt(GridLookUpEdit2.EditValue)
				
				col1 = mgr6.BuildCollection();
				
				if (mgr6.DataObject.RowsAffected > 0)
				{
					
					//DataGridView1.DataSource = col1 'mgr.BuildCollection()
					nProdID = mgr6.DataObject.Entity.stckid;
					vincentives = mgr6.DataObject.Entity.incentive;
					if (mgr6.DataObject.Entity.incentive > 0 & ceWtid.Value == 1)
					{
						//username = String.Empty
						try
						{
							//Dim mgremp As New waitersManager()
							//Dim cols As New waitersCollection
							//mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword
							//Dim strIncentive As String = String.Empty
							//strIncentive = InputBox("Please Enter your Password.")
							
							//mgremp.Entity.pword = Trim(strIncentive)
							//cols = mgremp.BuildCollection()
							//If mgremp.DataObject.RowsAffected > 0 Then
							//ceWtid.Value = mgremp.DataObject.Entity.wtid
							//MessageBox.Show(CStr(mgremp.DataObject.Entity.waiter))
							//Else
							//MessageBox.Show("Not a valid password, try again.")
							//Exit Sub
							//End If
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
					
					SendItemtoGrid3();
					
				}
				
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
		
		public void ItemsearchExecute()
		{
			try
			{
				mgr6 = new stocksManager();
				mgr6.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey;
				// 'MessageBox.Show(CType(leItems.EditValue, stocks))
				mgr6.DataObject.Entity.stckid = int.Parse(txtStckid.Text);
				
				col1 = mgr6.BuildCollection();
				
				if (mgr6.DataObject.RowsAffected > 0)
				{
					
					//DataGridView1.DataSource = col1 'mgr.BuildCollection()
					nProdID = mgr6.DataObject.Entity.stckid;
					SendItemtoGrid3();
					
				}
				
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
		
		public void GridLookUpEdit2_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Alt == true & e.KeyCode == Keys.Tab)
			{
				e.Handled = true;
			}
			
			if (e.Alt == true & e.KeyCode == Keys.F4)
			{
				e.Handled = true;
			}
			
		}
		
		//Public Sub OpenCashdrawer()
		//    'Modify DrawerCode to your receipt printer open drawer code
		//    Dim DrawerCode As String = Chr(27) & Chr(112) & Chr(48) & Chr(64) & Chr(64)
		//    'Modify PrinterName to your receipt printer name
		//    Dim PrinterName As String = "EPSON TMU220"
		
		//    RawPrinter.PrintRaw(PrinterName, DrawerCode)
		//End Sub
		public void TakePayment()
		{
			
			VarsModule.payconfirm = false;
			if (PosGrid.Rows.Count < 1)
			{
				MessageBox.Show("Sales Transaction is B l a n k.");
				return;
			}
			frmPayment frmpay = new frmPayment();
			frmpay.txtTotAmnt.Text = Strings.FormatNumber(txtSum.Text, -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault); //FormatNumber(CStr(vpTotalSales)) ' FormatNumber(txtSum.Text)
			frmpay.ceTendered.Value = decimal.Parse(txtSum.Text); //vpTotalSales 'Tots 'CDec(txtSum.Text)
			
			frmpay.txtChange.Text = "0";
			frmpay.ShowDialog();
			
			if (VarsModule.payconfirm == true)
			{
				Save_Trans();
			}
			
			//'txtTendered.Text = FormatNumber(CStr(frmPayment.ceTendered.Value)) 'vtendered
			//'lblChange.Text = FormatNumber(frmPayment.txtChange.Text) 'vchange
			btnnew.Focus();
		}
		public void Save_Trans()
		{
			
			//Dim spBalUpdate As spBalanceupdateManager
			//Dim spAuditInv As spProductBalanceupdateandItemLedgerEntryManager
			
			//'Dim spItemLedger As spProductBalanceupdateandItemLedgerEntryManager
			
			
			if (cmbPriceMode.Text == "")
			{
				MessageBox.Show("Select Retail or Wholesale");
				cmbPriceMode.Focus();
				return;
			}
			
			if (PosGrid.Rows.Count < 0)
			{
				MessageBox.Show("I t e m  L i s t  is  B l a n k");
				//btnSearchItems.Focus()
				
				txtitem.Focus();
				txtitem.Text = string.Empty;
				//txtBarcode.Focus()
				return;
			}
			if (cmbPaymentType.Text == "")
			{
				MessageBox.Show("Select if the Payment type is Cash, Credit or Cheque.", "Payment Type", MessageBoxButtons.OK);
				cmbPaymentType.Focus();
				return;
			}
			
			
			try
			{
				PDSATransaction tran3 = new PDSATransaction();
				//Dim tran4 As PDSATransaction = New PDSATransaction()
				Tran4 = new PDSATransaction();
				
				Tran = new PDSATransaction();
				Tran.AfterSubmit += Tran_AfterSubmit;
				Tran.BeforeSubmit += Tran_BeforeSubmit;
				Tran2 = new PDSATransaction();
				//oht = New pos_hdrtmpManager()
				
				ArrayList myAL = new ArrayList();
				ArrayList MyAl2 = new ArrayList();
				
				//oht.DataObject.TransactionType = PDSATransactionType.Insert
				
				//Try
				oht = new pos_hdrtmpManager();
				oht.DataObject.TransactionType = PDSATransactionType.Insert;
				if (txtcustid.Text == "0")
				{
					txtcustid.Text = "205";
				}
				oht.Entity.custid = Convert.ToInt32(txtcustid.Text);
				oht.Entity.posdate = DateTime.Now;
				oht.Entity.status = true;
				oht.Entity.totsales = Convert.ToDecimal(txtSum.Text);
				//vtotalsales 'vpTotalSales 'Tots
				oht.Entity.mowd = Convert.ToString(cmbPaymentType.Text);
				oht.Entity.disc = vdisc;
				oht.Entity.discamnt = vdiscamnt;
				oht.Entity.tendered = Convert.ToDecimal(vtendered);
				oht.Entity.Cheyns = Convert.ToDecimal(vchange);
				oht.Entity.tid = "t1";
				oht.Entity.wtid = (int) ceWtid.Value;
				oht.Entity.trminal = 1;
				//gOT pUZZLED WHY I have 2 status so I commented it below , comment up if it is the right one
				//oht.Entity.status = False
				//*************
				oht.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				//oht.DataObject.TransactionType = PDSATransactionType.Insert
				
				//'Dim mOrderHeader As New pos_hdrtmp()
				//'Dim mOrderLine1 As New pos_dettmp()
				//'oh.Entity = mOrderHeader
				//'od1.Entity = mOrderLine1
				Tran.Add(oht.DataObject);
				//Tran.Execute()
				//Catch ex As PDSAValidationException
				//    MessageBox.Show(ex.Message)
				//    Exit Sub
				//Catch ex As Exception
				//    MessageBox.Show(ex.ToString())
				//    Exit Sub
				//End Try
				
				
				grdCount = PosGrid.Rows.Count;
				for (ii = 0; ii <= grdCount - 1; ii++)
				{
					odt1 = new pos_dettmpManager();
					odt1.DataObject.TransactionType = PDSATransactionType.Insert;
					odt1.Entity.postmphdrid = mOrderId;
					odt1.Entity.stckid = Convert.ToInt32(PosGrid.Rows[ii].Cells[0].Value);
					odt1.Entity.barcode = (PosGrid.Rows[ii].Cells[1].Value).ToString();
					//odt1.Entity.itemdesc = CStr(PosGrid.Rows(ii).Cells(2).Value)
					odt1.Entity.cost = Convert.ToDecimal(PosGrid.Rows[ii].Cells[3].Value);
					odt1.Entity.price = Convert.ToDecimal(PosGrid.Rows[ii].Cells[5].Value);
					// this is the orig code below, then next line is change to cells(7)
					//odt1.Entity.ws = Convert.ToDecimal(PosGrid.Rows(ii).Cells(6).Value)
					odt1.Entity.ws = Convert.ToDecimal(PosGrid.Rows[ii].Cells[7].Value);
					odt1.Entity.qty = Convert.ToInt32(PosGrid.Rows[ii].Cells[2].Value);
					odt1.Entity.detamnt = Convert.ToDecimal(PosGrid.Rows[ii].Cells[6].Value); //Convert.ToDecimal(PosGrid.Rows(ii).Cells(4).Value) * Convert.ToInt32(PosGrid.Rows(ii).Cells(5).Value)
					odt1.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					if (Convert.ToDecimal(PosGrid.Rows[ii].Cells[8].Value) > 0)
					{
						odt1.Entity.detdisc = (short) (Convert.ToDecimal(PosGrid.Rows[ii].Cells[8].Value));
					}
					odt1.Entity.incentiv = Convert.ToDecimal(PosGrid.Rows[ii].Cells[9].Value);
					
					//myAL.Add(odt1.DataObject.Entity)
					Tran.Add(odt1.DataObject);
					//Tran2.Add(odt1.DataObject)
					//Tran2.Execute()
					//Tran2.RemoveAt(0)
				}
				
				Tran.Execute();
				ceRefno.Value = mOrderId;
				
				//'Commented for TodaRaba Pharmacy (without Printer)
				//Dim posrep As New xrReceiptTodaRaba()
				//'posrep.DataSource = sqlDT
				//posrep.Parameter1.Value = mOrderId
				//posrep.RequestParameters = False
				//posrep.PrintingSystem.ShowMarginsWarning = False
				//posrep.Print()
				//ceRefno.Value = mOrderId
				//'End of Comment for TodaRaba Pharmacy (without Printer)
				
				
				//********Commented it to display the values
				//txtSum.Text = "0"
				//ctotsalesvat.Value = 0
				//clessvat.Value = 0
				//cnosc.Value = 0
				//clesssc.Value = 0
				//camntnetvat.Value = 0
				//cvatablesales.Value = 0
				//cvatablexempt.Value = 0
				//cvatamnt.Value = 0
				//PosGrid.Rows.Clear()
				//******************* Uncomment if I want to clear values immediately
				//'btnBcode.PerformClick()
				//MessageBox.Show(CStr(mOrderId))
				//sqlSTR = "exec receiptpos @posid=" & mOrderId
				// MessageBox.Show(sqlSTR)
				//sqlSTRR = "SELECT pos_hdrtmp.postmp_hdrid, pos_hdrtmp.pos_date, pos_hdrtmp.custid, pos_hdrtmp.pos_amnt, pos_hdrtmp.tendered, pos_hdrtmp.Cheyns,pos_hdrtmp.Sc, pos_hdrtmp.totsales, pos_hdrtmp.less_vat, pos_hdrtmp.nov, pos_hdrtmp.less_sc, pos_hdrtmp.vatable, pos_hdrtmp.exempt, pos_hdrtmp.vatamnt, pos_hdrtmp.tid, pos_hdrtmp.wtid, pos_dettmp.stckid, pos_dettmp.cost, pos_dettmp.price, pos_dettmp.qty, stocks.barcode, stocks.item_desc, tbls.tdesc, waiters.waiter FROM pos_hdrtmp INNER JOIN pos_dettmp ON pos_hdrtmp.postmp_hdrid = pos_dettmp.postmp_hdrid INNER JOIN stocks ON pos_dettmp.stckid = stocks.stckid INNER JOIN tbls ON pos_hdrtmp.tid = tbls.tid INNER JOIN waiters ON pos_hdrtmp.wtid = waiters.wtid"
				//ExecuteSQLQuery(sqlSTR)
				//Catch sqlex As SqlClient.SqlException When sqlex.Number = 1205
				//    MessageBox.Show("test")
				//    wait(1500)
				//    Save_Trans()
				//    Exit Sub
				
			}
			catch (PDSATransactionException ex)
			{
				//MessageBox.Show("Please press F12 to try again.", "Server Locked")
				MessageBox.Show(ex.Message);
				return;
			}
			catch (PDSAValidationException ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return;
			}
			
			UpdateBalances();
			
			//'this is to execute the stored procedures
			//'Stored Proc 1
			//If cmbPaymentType.Text = "CREDIT" Then
			//    ceRefno.Value = mOrderId
			//    spBalUpdate = New spBalanceupdateManager()
			//    spBalUpdate.Entity.postmphdrid = mOrderId
			//    spBalUpdate.Entity.custid = CInt(txtcustid.Text)
			//    tran3.Add(spBalUpdate.DataObject)
			//    tran3.Execute()
			//End If
			//'ceRefno.Value = mOrderId
			//'Stored Proc 2
			//spAuditInv = New spProductBalanceupdateandItemLedgerEntryManager()
			//spAuditInv.Entity.postmphdrid = mOrderId
			//Tran4.Add(spAuditInv.DataObject)
			//Tran4.Execute()
			
			
			
			
			//Catch ex As PDSAValidationException
			//    MessageBox.Show(ex.Message)
			//Catch ex As PDSATransactionException
			//    MessageBox.Show(ex.Message)
			//Catch ex As Exception
			//    MessageBox.Show(ex.ToString())
			//End Try
		}
		// Loops for a specificied period of time (milliseconds)
		private void UpdateBalances()
		{
			spBalanceupdateManager spBalUpdate = default(spBalanceupdateManager);
			
			try
			{
				
				PDSATransaction tran5 = new PDSATransaction();
				
				if (cmbPaymentType.Text == "CREDIT")
				{
					ceRefno.Value = mOrderId;
					spBalUpdate = new spBalanceupdateManager();
					spBalUpdate.Entity.postmphdrid = mOrderId;
					spBalUpdate.Entity.custid = int.Parse(txtcustid.Text);
					tran5.Add(spBalUpdate.DataObject);
					tran5.Execute();
				}
				
				UpdateBalances2();
			}
			catch (PDSAValidationException ex)
			{
				MessageBox.Show(ex.Message);
				//Call UpdateBalances()
				return;
			}
			catch (PDSATransactionException ex)
			{
				MessageBox.Show(ex.Message);
				//Call UpdateBalances()
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				//Call UpdateBalances()
				return;
			}
			
		}
		private void UpdateBalances2()
		{
			
			spProductBalanceupdateandItemLedgerEntryManager spAuditInv = default(spProductBalanceupdateandItemLedgerEntryManager);
			try
			{
				PDSATransaction tran6 = new PDSATransaction();
				spAuditInv = new spProductBalanceupdateandItemLedgerEntryManager();
				spAuditInv.Entity.postmphdrid = mOrderId;
				tran6.Add(spAuditInv.DataObject);
				tran6.Execute();
				
				//btnSaves.Enabled = True
				SaveTransButtons();
				//btnnew.Focus()
				//Automatically Call new transaction
				NewTransaction();
				
				
			}
			catch (PDSAValidationException ex)
			{
				MessageBox.Show(ex.Message);
				//Call UpdateBalances2()
				return;
			}
			catch (PDSATransactionException ex)
			{
				MessageBox.Show(ex.Message);
				//Call UpdateBalances2()
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				//Call UpdateBalances2()
				return;
			}
		}
		
		
		private void wait(int interval)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			while (sw.ElapsedMilliseconds < interval)
			{
				// Allows UI to remain responsive
				Application.DoEvents();
			}
			sw.Stop();
		}
		
		public void LessDiscount()
		{
			
			decimal computedamnt = 0;
			computedamnt = Tots - vdiscamnt;
			txtSum.Text = Strings.FormatNumber(vtotalsales, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); //FormatNumber(CStr(vtotalsales))
			CheckSumifNegative();
			VarsModule.vpTotalSales = vtotalsales;
		}
		
		public void NewTrans()
		{
			try
			{
				if (PosGrid.Rows.Count >= 1)
				{
					if (btnSaves.Enabled == true)
					{
						MessageBox.Show("Sales Transaction is not yet paid!");
						btnSaves.Focus();
						return;
					}
					txtSum.Text = "0";
					PosGrid.Rows.Clear();
					txtBarcode.Text = string.Empty;
					txtitem.Text = string.Empty;
					//txtTendered.Text = "0"
					//lblChange.Text = "0"
					ceWtid.Value = 1;
					vtotalsales = 0;
					VarsModule.vpTotalSales = 0;
					txtcustid.Text = "205";
					txtqty.Text = "0";
					txtlastname.Text = "CASH";
					txtfirstname.Text = string.Empty;
					btnSaves.Enabled = true;
					btnPriceMode.Enabled = true;
					btnType.Enabled = true;
					btnSuspend.Enabled = true;
					btnRetrieve.Enabled = true;
					btnRemove.Enabled = true;
					btnDiscount.Enabled = true;
					Button1.Enabled = true; // this is the Set Quantity button
					btnCustomers.Enabled = true;
					txtBarcode.Enabled = true;
					btnSearchItems.Enabled = true;
					btnReprint.Enabled = true;
					txtbcodes.Text = string.Empty;
					txtStckid.Text = string.Empty;
					btnType.Enabled = true;
					btnPriceMode.Enabled = true;
					btnCustomers.Enabled = true;
					btnSuspend.Enabled = true;
					btnRetrieve.Enabled = true;
					btnRemove.Enabled = true;
					cmbPriceMode.Text = "Retail";
					cmbPaymentType.Text = "CASH";
					btnChequePayment.Enabled = true;
					//GridLookUpEdit2.Enabled = True
					txtitem.Enabled = true;
					
					//txtBarcode.Focus()
					//btnSearchItems.Focus()
					txtitem.Focus();
					txtitem.Text = string.Empty;
					btnnew.Enabled = false;
					
				}
				else
				{
					ceWtid.Value = 1;
					vtotalsales = 0;
					VarsModule.vpTotalSales = 0;
					txtBarcode.Enabled = true;
					btnSearchItems.Enabled = true;
					PosGrid.Enabled = true;
					btnnew.Enabled = false;
					btnSaves.Enabled = true;
					btnType.Enabled = true;
					btnPriceMode.Enabled = true;
					btnCustomers.Enabled = true;
					btnSuspend.Enabled = true;
					btnRetrieve.Enabled = true;
					btnRemove.Enabled = true;
					//GridLookUpEdit2.Enabled = True
					txtitem.Enabled = true;
					txtitem.Focus();
					txtitem.Text = string.Empty;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		public void SaveTransButtons()
		{
			btnSaves.Enabled = false;
			txtBarcode.Enabled = false;
			btnSearchItems.Enabled = false;
			btnPriceMode.Enabled = false;
			btnType.Enabled = false;
			btnSuspend.Enabled = false;
			btnRetrieve.Enabled = false;
			btnRemove.Enabled = false;
			btnDiscount.Enabled = false;
			Button1.Enabled = false; // this is the Set Quantity button
			btnCustomers.Enabled = false;
			btnType.Enabled = false;
			btnPriceMode.Enabled = false;
			btnSuspend.Enabled = false;
			btnRetrieve.Enabled = false;
			btnRemove.Enabled = false;
			GridLookUpEdit2.Enabled = false;
			btnnew.Enabled = true;
			btnnew.Focus();
		}
		
		public void OpenCustForm()
		{
			frmCustSearch frmcust = new frmCustSearch();
			cmbPaymentType.Text = "CREDIT";
			frmcust.ShowDialog();
			txtcustid.Text = (frmcust.vCustid).ToString();
			txtlastname.Text = frmcust.vLname;
			txtfirstname.Text = frmcust.vFname;
			//txtBarcode.Focus()
			//btnSearchItems.Focus()
			txtitem.Focus();
			txtitem.Text = string.Empty;
		}
		
		public void PosGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			passcorrect = true;
			//Dim frm As frmPasswordInput
			//frm = New frmPasswordInput
			//'frm.MdiParent = Me
			//frm.WindowState = FormWindowState.Normal
			//frm.ShowDialog()
			//frm = Nothing
			//ceWtid.Value = vEmpID
			
			if (passcorrect == true)
			{
				//MessageBox.Show(CStr(ceWtid.Value))
				if (this.PosGrid.CurrentCell.ColumnIndex == 4)
				{
					if (e.Control is TextBox)
					{
						TextBox tb = (TextBox) e.Control;
						tb.KeyPress += this.tb_KeyPress;
					}
				}
			}
		}
		private void tb_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
			{
				Keys key = System.Windows.Forms.Keys.A;
				if (!((key == Keys.Back) 
					|| (key == Keys.Delete)))
				{
					e.Handled = true;
				}
			}
		}
		
		public void PosGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (PosGrid.Rows.Count > 0)
			{
				try
				{
					
					decimal number;
					bool result = decimal.TryParse((PosGrid.SelectedRows[0].Cells[2].Value).ToString(), out number);
					bool result2 = decimal.TryParse((PosGrid.SelectedRows[0].Cells[5].Value).ToString(), out number);
					
					if (result && result2)
					{
						//Console.WriteLine("Converted '{0}' to {1}.", CStr(PosGrid.SelectedRows.Item(0).Cells(5).Value), number)
						PosGrid.SelectedRows[0].Cells[6].Value = (decimal.Parse((PosGrid.SelectedRows[0].Cells[2].Value).ToString())) * decimal.Parse((PosGrid.SelectedRows[0].Cells[5].Value).ToString());
						//If (dgvr.Cells(7).Value < dgvr.Cells(10).Value) Then
						//dgvr.DefaultCellStyle.ForeColor = Color.Red
						//End If
						if (System.Convert.ToInt32(PosGrid.SelectedRows[0].Cells[2].Value) <= 0)
						{
							PosGrid.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Red;
						}
						else
						{
							PosGrid.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
						}
						
						if (System.Convert.ToDecimal(PosGrid.SelectedRows[0].Cells[5].Value) <= 0)
						{
							PosGrid.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Red;
						}
						else
						{
							PosGrid.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
						}
						
						decimal Recompute = 0;
						int aii = 0;
						for (aii = 0; aii <= PosGrid.Rows.Count - 1; aii++)
						{
							Recompute += System.Convert.ToDecimal(PosGrid.Rows[aii].Cells[6].Value);
						}
						//CalcEdit1.Value = Totss
						txtSum.Text = Strings.FormatNumber(Recompute, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); //FormatNumber(CStr(Recompute))
						CheckSumifNegative();
						VarsModule.vpTotalSales = Recompute;
						
					}
					else
					{
						if ((PosGrid.SelectedRows[0].Cells[5].Value).ToString() == null)
						{
							PosGrid.SelectedRows[0].Cells[2].Value = 0;
						}
						MessageBox.Show("W A R N I N G !!!!!! Price or Qty Must be Greater than Zero", (PosGrid.SelectedRows[0].Cells[5].Value).ToString());
						PosGrid.SelectedRows[0].Cells[2].Value = 0;
						
						decimal Recomputes = 0;
						int aiii = 0;
						for (aiii = 0; aiii <= PosGrid.Rows.Count - 1; aiii++)
						{
							Recomputes += System.Convert.ToDecimal(PosGrid.Rows[aiii].Cells[6].Value);
						}
						
						txtSum.Text = Strings.FormatNumber(Recomputes, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); // FormatNumber(CStr(Recomputes))
						CheckSumifNegative();
						VarsModule.vpTotalSales = Recomputes;
						
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			
		}
		
		public void RePrint()
		{
			try
			{
				xrReprint posrep2 = new xrReprint();
				//posrep.DataSource = sqlDT
				posrep2.cashier.Value = PDSAAppConfig.CurrentLoginID;
				posrep2.RequestParameters = true;
				posrep2.PrintingSystem.ShowMarginsWarning = false;
				posrep2.ShowPreview();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void PosGrid_DoubleClick(object sender, EventArgs e)
		{
			int itemcount = 0;
			itemcount = PosGrid.Rows.Count;
			MessageBox.Show((itemcount).ToString(), "Total Kinds of Items Bought");
		}
		
		public void btnSearchItems_Click(object sender, EventArgs e)
		{
			if (btnnew.Enabled == true)
			{
				txtTendered.Text = "0";
				lblChange.Text = "0";
				itemcnt = 0;
				vdisc = 0;
				vdiscamnt = 0;
				NewTrans();
			}
			
			frmItemSearch formitemserch = new frmItemSearch();
			formitemserch.ShowDialog();
			txtitem.Text = string.Empty;
			txtbcodes.Text = string.Empty;
			txtStckid.Text = string.Empty;
			txtitem.Text = formitemserch.vItem.ToString();
			txtbcodes.Text = formitemserch.vbocde.ToString();
			txtBarcode.Text = formitemserch.vbocde.ToString();
			txtStckid.Text = formitemserch.vStckid.ToString();
			//txtBarcode.SelectAll()
			if (txtStckid.Text == string.Empty)
			{
				return;
			}
			else
			{
				ItemsearchExecute();
			}
			txtitem.Focus();
			
		}
		
		public void btnCustomers_Click(object sender, EventArgs e)
		{
			OpenCustForm();
		}
		
		public void btnPriceMode_Click(object sender, EventArgs e)
		{
			if (btnnew.Enabled == true)
			{
				MessageBox.Show("Click New Transaction First before selecting Wholesale or Retail.");
				btnnew.Focus();
				return;
			}
			
			if (cmbPriceMode.Text == "Retail")
			{
				cmbPriceMode.Text = "Wholesale";
				//txtBarcode.Focus()
				//btnSearchItems.Focus()
				txtitem.Focus();
				txtitem.Text = string.Empty;
			}
			
			
			if (cmbPriceMode.Text == "Wholesale")
			{
				cmbPriceMode.Text = "Refund";
				//txtBarcode.Focus()
				//btnSearchItems.Focus()
				txtitem.Focus();
				txtitem.Text = string.Empty;
			}
			
			if (cmbPriceMode.Text == "Refund")
			{
				cmbPriceMode.Text = "Retail";
				//txtBarcode.Focus()
				//btnSearchItems.Focus()
				txtitem.Focus();
				txtitem.Text = string.Empty;
			}
			
			
		}
		
		
		public void btnCreditPay_Click(object sender, EventArgs e)
		{
			frmCreditPayment frmcp = new frmCreditPayment();
			frmcp.ShowDialog();
			btnnew.Focus();
		}
		
		public void btnSaves_Click(object sender, EventArgs e)
		{
			//Not yet tested to open the cash drawer
			//OpenCashdrawer()
			
			//Try to check if there is a price that is not valid(less than or equal to zero and letters maybe)
			bool vYesNo = true;
			try
			{
				//Try to check if there is a price that is not valid(less than or equal to zero and letters maybe)
				int I = 0;
				for (I = 0; I <= PosGrid.Rows.Count - 1; I++)
				{
					if (decimal.Parse((PosGrid.SelectedRows[0].Cells[5].Value).ToString()) <= 0)
					{
						
						// Zero Price found
						MessageBox.Show("There is an Item with a Price that is Not valid or less than 0.1");
						vYesNo = false;
						break;
						return;
					}
				}
				
				I = 0;
				for (I = 0; I <= PosGrid.Rows.Count - 1; I++)
				{
					if (int.Parse((PosGrid.SelectedRows[0].Cells[2].Value).ToString()) <= 0)
					{
						
						// Zero Qty found
						MessageBox.Show("There is an Item with a Qty that is Not valid or equal t 0");
						vYesNo = false;
						break;
						return;
					}
				}
				
				
				if (vYesNo == false)
				{
					return;
				}
				
				
				//IF no problem them take payment
				TakePayment();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void btnSuspend_Click(object sender, EventArgs e)
		{
			if (PosGrid.Rows.Count > 0)
			{
				SuspendTrans();
			}
			else
			{
				//txtBarcode.Focus()
				//btnSearchItems.Focus()
				MessageBox.Show("No items to Suspend");
				txtitem.Focus();
				txtitem.Text = string.Empty;
			}
		}
		
		public void btnRetrieve_Click(object sender, EventArgs e)
		{
			if (PosGrid.Rows.Count > 1)
			{
				MessageBox.Show("Pls. Finish or Cancel the existing sales transaction first before retrieving a suspended sales transaction");
				return;
			}
			RetrieveTrans();
		}
		
		public void btnType_Click(object sender, EventArgs e)
		{
			try
			{
				if (btnnew.Enabled == true)
				{
					MessageBox.Show("Click New Transaction First before selecting a payment type.");
					btnnew.Focus();
					return;
				}
				
				if (cmbPaymentType.Text == "CASH")
				{
					cmbPaymentType.Text = "CHEQUE";
					btnCustomers.Enabled = false;
					btnChequePayment.Enabled = true;
					//'btnCustomers.Focus()
					//'Call OpenCustForm()
					//'btnnew.Focus()
					//txtBarcode.Focus()
					//btnSearchItems.Focus()
					txtitem.Focus();
					txtitem.Text = string.Empty;
					return;
					//btnSave.Focus()
				}
				if (cmbPaymentType.Text == "CHEQUE")
				{
					cmbPaymentType.Text = "CREDIT";
					btnChequePayment.Enabled = true;
					//btnSave.Focus()
					OpenCustForm();
					btnCustomers.Enabled = true;
					//txtBarcode.Focus()
					//btnSearchItems.Focus()
					txtitem.Focus();
					txtitem.Text = string.Empty;
					return;
				}
				if (cmbPaymentType.Text == "CREDIT")
				{
					cmbPaymentType.Text = "CASH";
					//btnSave.Focus()
					btnChequePayment.Enabled = false;
					btnCustomers.Enabled = true;
					//txtBarcode.Focus()
					//btnSearchItems.Focus()
					txtitem.Focus();
					txtitem.Text = string.Empty;
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void btnChequePayment_Click(object sender, EventArgs e)
		{
			try
			{
				cmbPaymentType.Text = "CHEQUE";
				if (btnSaves.Enabled == true)
				{
					MessageBox.Show("Press F12 to Take Cheque Payment before entering the Cheque Details");
					return;
				}
				else
				{
					frmCheque frm = new frmCheque();
					frm.ShowDialog();
					btnnew.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void btnRemove_Click(object sender, EventArgs e)
		{
			VoidItem();
		}
		private void VoidItem()
		{
			if (PosGrid.Rows.Count == 0)
			{
				//txtBarcode.Focus()
				//btnSearchItems.Focus()
				txtitem.Focus();
				txtitem.Text = string.Empty;
				return;
			}
			
			decimal Totss = 0;
			int ii = 0;
			posVoidManager mgrvoid = default(posVoidManager);
			PDSATransaction voidtrans = default(PDSATransaction);
			PDSATransaction voidsp;
			procpdsaTableIds_GetMaxIDManager mgrspvoid = new procpdsaTableIds_GetMaxIDManager();
			try
			{
				
				if (PosGrid.SelectedRows.Count == 0)
				{
					return;
				}
				voidsp = new PDSATransaction();
				voidtrans = new PDSATransaction();
				mgrvoid = new posVoidManager();
				mgrspvoid.Entity.sFieldName = "voidid";
				mgrspvoid.Entity.sTableName = "posVoid";
				
				
				int dgvrowint = 0;
				dgvrowint = Convert.ToInt32(PosGrid.CurrentRow.Index.ToString());
				//save selected item that is removed
				mgrvoid.Entity.voidid = mgrspvoid.Entity.RETURNVALUE + 1;
				mgrvoid.Entity.stckid = Convert.ToInt32(PosGrid.Rows[ii].Cells[0].Value);
				mgrvoid.Entity.barcode = (PosGrid.Rows[ii].Cells[1].Value).ToString();
				mgrvoid.Entity.cost = Convert.ToDecimal(PosGrid.Rows[ii].Cells[3].Value);
				mgrvoid.Entity.price = Convert.ToDecimal(PosGrid.Rows[ii].Cells[5].Value);
				mgrvoid.Entity.qty = Convert.ToInt32(PosGrid.Rows[ii].Cells[2].Value);
				//mgrvoid.Entity.detamnt = Convert.ToDecimal(PosGrid.Rows(ii).Cells(4).Value) * Convert.ToInt32(PosGrid.Rows(ii).Cells(5).Value)
				mgrvoid.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				voidtrans.Add(mgrvoid.DataObject);
				voidtrans.Execute();
				
				PosGrid.Rows.Remove(PosGrid.SelectedRows[0]);
				for (ii = 0; ii <= PosGrid.Rows.Count - 1; ii++)
				{
					Totss += System.Convert.ToDecimal(PosGrid.Rows[ii].Cells[6].Value);
				}
				//CalcEdit1.Value = Totss
				txtSum.Text = Strings.FormatNumber(Totss, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); //FormatNumber(CStr(Totss))
				CheckSumifNegative();
				VarsModule.vpTotalSales = Totss;
				//TextEdit1.Text = FormatCurrency(CStr(Totss))
				btnBcode.PerformClick();
				//txtBarcode.Focus()
				txtitem.Focus();
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
		public void btnReprint_Click(object sender, EventArgs e)
		{
			RePrint();
			//txtBarcode.Focus()
			//btnSearchItems.Focus()
			txtitem.Focus();
			txtitem.Text = string.Empty;
		}
		
		public void Timer1_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToLongTimeString();
			
			if (cmbPriceMode.Text == "Wholesale" || cmbPriceMode.Text == "Refund")
			{
				if (cmbPriceMode.ForeColor == Color.Black)
				{
					cmbPriceMode.ForeColor = Color.Red;
				}
				else
				{
					cmbPriceMode.ForeColor = Color.Black;
				}
			}
			
			if (cmbPaymentType.Text == "CREDIT" || cmbPaymentType.Text == "CHEQUE")
			{
				if (cmbPaymentType.ForeColor == Color.Black)
				{
					cmbPaymentType.ForeColor = Color.Red;
				}
				else
				{
					cmbPaymentType.ForeColor = Color.Black;
				}
				
			}
			
		}
		
		public void btnLookuprice_Click(object sender, EventArgs e)
		{
			frmPriceLookup2 frm = new frmPriceLookup2();
			frm.Show();
			txtitem.Focus();
		}
		
		public void btnPickup_Click(object sender, EventArgs e)
		{
			try
			{
				frmPickup frm = new frmPickup();
				frm.ShowDialog();
				if (btnnew.Enabled == true)
				{
					btnnew.Focus();
				}
				else
				{
					//txtBarcode.Focus()
					//btnSearchItems.Focus()
					txtitem.Focus();
					txtitem.Text = string.Empty;
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void SimpleButton1_Click(object sender, EventArgs e)
		{
			//Try
			//    Dim formQty As New frmQty
			//    formQty.ShowDialog()
			//    'txtBarcode.Focus()
			//    'btnSearchItems.Focus()
			//    txtitem.Text=String.Empty
			//    txtitem.focus()
			//Catch ex As Exception
			//    MessageBox.Show(ex.ToString())
			//End Try
			SetQuantity();
		}
		public void SetQuantity()
		{
			try
			{
				frmQty formQty = new frmQty();
				formQty.ShowDialog();
				//txtBarcode.Focus()
				//btnSearchItems.Focus()
				PosGrid.Rows[PosGrid.RowCount - 1].Cells[2].Value = vpieces;
				//Me.PosGrid.Rows(Me.PosGrid.RowCount - 1).Selected = True
				txtitem.Text = string.Empty;
				txtitem.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void btnAddCash_Click(object sender, EventArgs e)
		{
			try
			{
				frmAddtnlCash frm = new frmAddtnlCash();
				frm.ShowDialog();
				btnnew.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void btnDiscount_Click(object sender, EventArgs e)
		{
			if (PosGrid.Rows.Count == 0 || btnnew.Enabled == true)
			{
				MessageBox.Show("Item List is Blank!");
				return;
			}
			
			passcorrect = true;
			//passcorrect = False
			//Dim frm As frmPasswordInput
			//frm = New frmPasswordInput
			//'frm.MdiParent = Me
			//frm.WindowState = FormWindowState.Normal
			//frm.ShowDialog()
			//frm = Nothing
			
			
			if (passcorrect == true)
			{
				
				decimal vdetdisc = 0; // this is the discount computed per item that was divided from the vdiscamnt variable to the total itemcount which is vItemCount
				int ayayay = 0;
				for (ayayay = 0; ayayay <= PosGrid.Rows.Count - 1; ayayay++)
				{
					PosGrid.Rows[ayayay].Cells[8].Value = 0;
				}
				
				if (btnSaves.Enabled == false)
				{
					MessageBox.Show("Discount is not allowed if Sales Transaction is already paid.");
					return;
				}
				if (PosGrid.Rows.Count < 1)
				{
					MessageBox.Show("Item List is  B l a n k");
					return;
				}
				
				//Recalculate the total on the Grid and post it on txtsum before applying any discount
				int I = 0;
				Tots = 0;
				for (I = 0; I <= PosGrid.Rows.Count - 1; I++)
				{
					Tots += System.Convert.ToDecimal(PosGrid.Rows[I].Cells[6].Value);
				}
				
				
				
				txtCounts.Text = (PosGrid.Rows.Count).ToString();
				txtSum.Text = Strings.FormatNumber(Tots, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); // FormatNumber(CStr(Tots))
				CheckSumifNegative();
				VarsModule.vpTotalSales = Tots;
				
				
				try
				{
					
					vdisc = 0;
					vdiscamnt = 0;
					vtotalsales = Tots; //CDec(txtSum.Text) My New Comments 12 21 13
					//vpTotalSales = CDec(txtSum.Text) My New Comments 12 21 13
					frmDiscount frmdisc = new frmDiscount();
					frmdisc.ShowDialog();
					txtSum.Text = Strings.FormatNumber(vtotalsales, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); //FormatNumber(CStr(vtotalsales))
					CheckSumifNegative();
					
					if (vtotalsales == 0)
					{
						txtSum.Text = Strings.FormatNumber(Tots, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); //FormatNumber(CStr(Tots))
						CheckSumifNegative();
						VarsModule.vpTotalSales = Tots;
					}
					
					
					int vItemCount = 0;
					int ay = 0;
					for (ay = 0; ay <= PosGrid.Rows.Count - 1; ay++)
					{
						vItemCount += System.Convert.ToInt32(PosGrid.Rows[ay].Cells[5].Value);
					}
					
					if (vdiscamnt > 0)
					{
						vdetdisc = vdiscamnt / vItemCount;
						int ayay = 0;
						for (ayay = 0; ayay <= PosGrid.Rows.Count - 1; ayay++)
						{
							PosGrid.Rows[ayay].Cells[8].Value = vdetdisc * System.Convert.ToInt32(PosGrid.Rows[ayay].Cells[2].Value);
						}
					}
					txtSum.Text = Strings.FormatNumber(vtotalsales, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); //FormatNumber(CStr(vtotalsales))
					CheckSumifNegative();
					//txtBarcode.Focus()
					//btnSearchItems.Focus()
					txtitem.Focus();
					txtitem.Text = string.Empty;
					//txtBarcode.SelectAll()
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		private void CheckSumifNegative()
		{
			if (decimal.Parse(txtSum.Text) < 0)
			{
				txtSum.ForeColor = Color.Red;
			}
			else
			{
				txtSum.ForeColor = Color.Green;
			}
		}
		
		public void btnnew_Click(object sender, EventArgs e)
		{
			
			//Try
			
			//    txtTendered.Text = "0"
			//    lblChange.Text = "0"
			//    itemcnt = 0
			//    vdisc = 0
			//    vdiscamnt = 0
			//    NewTrans()
			//Catch ex As Exception
			//    MessageBox.Show(ex.ToString())
			//End Try
			NewTransaction();
		}
		
		public void NewTransaction()
		{
			try
			{
				itemcnt = 0;
				vdisc = 0;
				vdiscamnt = 0;
				VarsModule.vEmpID = 1;
				txtTendered.Text = "0";
				NewTrans();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void btnBcode_Click(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(txtBarcode.Text))
				{
					txtBarcode.SelectAll();
				}
				//' leCust.EditValue = vbNullString
				//'leItems.EditValue = vbNullString
				//txtBarcode.Text = ""
				//txtBarcode.Focus()
				BCodeFocus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void btnRefund_Click(object sender, EventArgs e)
		{
			if (btnnew.Enabled == false)
			{
				cmbPriceMode.Text = "Refund";
				//btnSearchItems.Focus()
				//txtBarcode.Focus()
				txtitem.Focus();
				txtitem.Text = string.Empty;
			}
		}
		
		
		public void dgEmps_KeyDown(object sender, KeyEventArgs e)
		{
			
			if (e.KeyCode == Keys.Enter)
			{
				int vCellVal = 0;
				int row = DGRetrieve.CurrentCellAddress.Y;
				int column = DGRetrieve.CurrentCellAddress.X;
				//Dim col4 As waitersCollection
				
				if (column > 1)
				{
					MessageBox.Show("Please select Employee Name for the Incentive Amount");
					return;
				}
				
				if (column == 0) // this is the main code to be executed
				{
					MessageBox.Show(row.ToString() + " " + column.ToString());
					vCellVal = System.Convert.ToInt32(dgEmps.CurrentCell.Value);
					//Dim mgrRetrivEmp As waitersManager
					
					try
					{
						//   mgrRetrivEmp = New waitersManager()
						//   mgrRetrivEmp.DataObject.WhereFilter = waitersData.WhereFilters.PrimaryKey
						//  mgrRetrivEmp.Entity.wtid = vCellVal
						
						//col4 = mgrRetrivEmp.BuildCollection()
						//If mgrRetrivEmp.DataObject.RowsAffected > 0 Then
						//ceWtid.Value = mgrRetrivEmp.DataObject.Entity.wtid
						ceWtid.Value = vCellVal;
						this.Text = System.Convert.ToString("Inventory and Sales Monitoring System" + (dgEmps.CurrentCell.Value).ToString());
						dgEmps.Visible = false;
						//End If
						
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
				
				if (column == 1)
				{
					dgEmps.Visible = false;
				}
				
			}
		}
		
		public void ceQtyy_GotFocus(object sender, EventArgs e)
		{
			ceQtyy.Value = 1;
			ceQtyy.SelectAll();
		}
		
		public void ceQtyy_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (ceQtyy.Value == 0)
				{
					MessageBox.Show("Qty Sold cannot be equal to Zero!");
					return;
				}
				txtqty.Text = ceQtyy.Text;
				qtyy = (int) ceQtyy.Value;
				LookupEditKeypress();
				//ItemsearchExecute()
				
			}
		}
		
		public void dgitems_KeyDown(object sender, KeyEventArgs e)
		{
			
			if (e.KeyCode == Keys.Enter)
			{
				
				if (dgitems.Rows.Count < 1)
				{
					return;
				}
				try
				{
					int vRow = 0;
					int vint = 0;
					string x1 = string.Empty;
					string x2 = string.Empty;
					// Dim x2 As Integer = 0
					int x3 = 0;
					decimal x4 = 0;
					int x5 = 0;
					string x6 = string.Empty;
					vRow = dgitems.CurrentRow.Index;
					//vint = CInt(dgitems(0, vRow).Value)
					//x1 = CStr(dgitems(1, vRow).Value)
					//x2 = CStr(dgitems(2, vRow).Value)
					//x3 = CDec(dgitems(12, vRow).Value)
					//x4 = CDec(dgitems(13, vRow).Value)
					vint = System.Convert.ToInt32(dgitems[0, vRow].Value);
					x1 = (dgitems[1, vRow].Value).ToString();
					x2 = (dgitems[2, vRow].Value).ToString();
					x3 = System.Convert.ToInt32(dgitems[3, vRow].Value);
					x4 = System.Convert.ToDecimal(dgitems[4, vRow].Value);
					x5 = System.Convert.ToInt32(dgitems[6, vRow].Value);
					//x6 = CStr(dgitems(7, vRow).Value)
					vStckid = vint;
					vItem = x2;
					vAvlbl = x3;
					vbocde = x1;
					vPrice = x3;
					vWPrice = x4;
					vInnerQty = x5;
					
					txtbcodes.Text = string.Empty;
					txtStckid.Text = string.Empty;
					txtitem.Text = vItem.ToString();
					txtbcodes.Text = vbocde.ToString();
					txtBarcode.Text = vbocde.ToString();
					txtStckid.Text = vStckid.ToString();
					//'txtBarcode.SelectAll()
					//If txtStckid.Text = String.Empty Then
					//    Exit Sub
					//Else
					//    ItemsearchExecute()
					//End If
					//txtitem.Focus()
					
					dgitems.Visible = false;
					ceQtyy.Focus();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				e.SuppressKeyPress = true;
			}
			
			if (e.KeyCode == Keys.Escape)
			{
				
				dgitems.Visible = false;
				txtitem.Focus();
				txtitem.SelectAll();
				
				e.SuppressKeyPress = true;
			}
			
		}
		
		public void PosGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				int ansint = 7;
				ansint = (int) (Interaction.MsgBox("Are you sure you want Delete the selected Row?", MsgBoxStyle.YesNo, "Delete Row Confirmation"));
				if (ansint == 6)
				{
					VoidItem();
				}
			}
		}
		
		public void DGRetrieve_KeyPress(object sender, KeyPressEventArgs e)
		{
			
			if (e.KeyChar == '\u001B')
			{
				DGRetrieve.Visible = false;
				txtitem.Focus();
			}
		}
		
		public void dgitems_KeyPress(object sender, KeyPressEventArgs e)
		{
			
			if (e.KeyChar == '\u001B')
			{
				DGRetrieve.Visible = false;
				// I just added this one, new modification october 17 , 2014
				dgitems.Visible = false;
				txtitem.Focus();
			}
		}
		
		
	}
}
