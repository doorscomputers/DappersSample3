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
using DevExpress.XtraEditors;



namespace DoorsPOS.WinApp
{
	public partial class frmDelivery
	{
		public frmDelivery()
		{
			InitializeComponent();
		}
		dlvryhdrtmpManager mgrhdrtmp;
		dlvrydettmpManager drd;
		dlvry_hdrManager mgrdrheader;
		dlvry_detManager mgrdrdetail;
		stocksManager mgr7;
		decimal Totss = 0;
		decimal vGrandTotal = 0;
		private int mOrderId = 0;
		private int mdrId = 0;
		private PDSA.DataLayer.DataClasses.PDSATransaction TranHdrtmp;
		private PDSA.DataLayer.DataClasses.PDSATransaction TranDr;
		public void frmDelivery_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
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
			
		}
		public void frmDelivery_FormClosing(object sender, FormClosingEventArgs e)
		{
			int vRows = drgrid.Rows.Count;
			if (vRows > 0) // If vRows > 0 Then
			{
				MessageBox.Show("Delivery List Exist. Please Save/Post or Click New before closing the Delivery Entry Form.");
				e.Cancel = true;
			}
		}
		
		public void frmDelivery_Load(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			dedlvrydate.EditValue = DateTime.Today;
			drgrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			drgrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			drgrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			drgrid.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			//Dim btn As New DataGridViewButtonColumn()
			//drgrid.Columns.Add(btn)
			//btn.HeaderText = "Remove"
			//btn.Text = "Remove"
			//btn.Name = "Remove"
			//btn.UseColumnTextForButtonValue = True
			
			LoadSupplier();
			//load_items()
			this.Cursor = Cursors.Default;
		}
		
		public void load_supplier()
		{
			suppliersManager mgrsup = default(suppliersManager);
			suppliersCollection cols;
			try
			{
				mgrsup = new suppliersManager();
				mgrsup.DataObject.SelectFilter = suppliersData.SelectFilters.ListBox;
				mgrsup.DataObject.OrderByFilter = suppliersData.OrderByFilters.supplier;
				
				mgrsup.DataObject.Load();
				cols = mgrsup.BuildCollection();
				//GridLookUpEdit1.Properties.PopupFormWidth = 720
				//GridLookUpEdit1.Properties.DisplayMember = "supplier"
				//GridLookUpEdit1.Properties.ValueMember = "supcode"
				//GridLookUpEdit1.Properties.DataSource = cols
				
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
		
		private void ComputeDue()
		{
			if (cmbType.Text == "COD" || cmbType.Text == "I.S.")
			{
				deDue.EditValue = System.Convert.ToDateTime(dedlvrydate.EditValue);
			}
			else
			{
				if (ceDays.Value > 0)
				{
					deDue.EditValue = DateAndTime.DateAdd(DateInterval.Day, (double) ceDays.Value, System.Convert.ToDateTime(dedlvrydate.EditValue));
				}
			}
		}
		
		public void ceDays_LostFocus(object sender, EventArgs e)
		{
			ComputeDue();
		}
		
		public void btnAdd_Click(object sender, EventArgs e)
		{
			if (ceCost.Value == 0)
			{
				MessageBox.Show("Item Cost Must be Greater than zero");
				return;
			}
			
			if (ceQty.Value <= 0 & ceFree.Value <= 0)
			{
				MessageBox.Show("Qty Delivered cannot be equal or less than zero");
				return;
			}
			else
			{
				SendItemtoGrid();
				btnItemSearch.Focus();
			}
		}
		public void btnNew_Click(object sender, EventArgs e)
		{
			Enablectrl();
			drgrid.Rows.Clear();
			dedlvrydate.EditValue = DateTime.Today;
			txtInv.Text = string.Empty;
			ceDays.Value = 0;
			deDue.EditValue = DateTime.Today;
			ceQty.Value = 0;
			ceFree.Value = 0;
			ceCost.Value = 0;
			cediscamnt.Value = 0;
			txtStckid.Text = string.Empty;
			txtSupcode.Text = string.Empty;
			txtsum.Text = "0";
			cediscamnt.Value = 0;
			txtGrand.Text = "0";
			dedlvrydate.Focus();
			
		}
		
		public void SendItemtoGrid()
		{
			
			int I = 0;
			int ItemLoc = -1;
			int nProdIDD = 0;
			decimal Amount3 = 0;
			
			try
			{
				if (ceQty.Value > 0)
				{
					Amount3 = ceQty.Value * ceCost.Value;
					if (ceAmountDisc.Value > 0)
					{
						Amount3 -= ceAmountDisc.Value;
					}
				}
				else
				{
					Amount3 = 0;
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
			
			
			try
			{
				nProdIDD = int.Parse(txtStckid.Text);
				for (I = 0; I <= drgrid.Rows.Count - 1; I++)
				{
					if (nProdIDD == System.Convert.ToInt32(drgrid.Rows[I].Cells[0].Value))
					{
						// item found
						ItemLoc = I;
						break;
					}
				}
				
				// if item is not found, add it
				
				
				if (ItemLoc == -1)
				{
					drgrid.Rows.Add(mgr7.DataObject.Entity.stckid, mgr7.DataObject.Entity.itemdesc, ceQty.Value, ceFree.Value, mgr7.DataObject.Entity.cost, Amount3, deExpDate.EditValue, txtLotNo.Text, cePrcentDisc.Value, cediscamnt.Value);
				}
				else
				{
					
					// if item is already there increase its count
					int ItemCount = System.Convert.ToInt32(drgrid.Rows[ItemLoc].Cells[2].Value);
					ItemCount += (int) ceQty.Value;
					decimal NewPrice = mgr7.DataObject.Entity.cost * ItemCount;
					drgrid.Rows[ItemLoc].Cells[2].Value = ItemCount;
					drgrid.Rows[ItemLoc].Cells[5].Value = NewPrice;
					
				}
				decimal Totsss = 0;
				
				for (I = 0; I <= drgrid.Rows.Count - 1; I++)
				{
					Totsss += System.Convert.ToDecimal(drgrid.Rows[I].Cells[5].Value);
				}
				//Select the last row.
				this.drgrid.Rows[this.drgrid.RowCount - 1].Selected = true;
				//Scroll to the last row.
				this.drgrid.FirstDisplayedScrollingRowIndex = this.drgrid.RowCount - 1;
				
				
				
				txtsum.Text = Strings.FormatNumber((Totsss).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
				txtGrand.Text = Strings.FormatNumber((Totsss).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
				ceQty.Value = 1;
				ceFree.Value = 0;
				txtItem.Text = string.Empty;
				ceCost.Value = 0;
				txtStckid.Text = string.Empty;
				txtLotNo.Text = string.Empty;
				deExpDate.Text = string.Empty;
				cePrcentDisc.Value = 0;
				cediscamnt.Value = 0;
				ceAmountDisc.Value = 0;
				
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
		
		public void btnSupSearch_Click(object sender, EventArgs e)
		{
			frmSupplierSearch frmSupsearch = new frmSupplierSearch();
			frmSupsearch.ShowDialog();
			try
			{
				txtSupplier.Text = string.Empty;
				txtSupplier.Text = frmSupsearch.vSupplier.ToString();
				txtSupcode.Text = frmSupsearch.vSupCode.ToString();
				if (txtSupcode.Text == string.Empty)
				{
					MessageBox.Show("Please Select a supplier!");
					return;
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			txtInv.Focus();
		}
		
		public void btnItemSearch_Click(object sender, EventArgs e)
		{
			frmItemSearch frmitemserch = new frmItemSearch();
			frmitemserch.ShowDialog();
			txtItem.Text = string.Empty;
			txtStckid.Text = string.Empty;
			txtItem.Text = frmitemserch.vItem.ToString();
			txtStckid.Text = frmitemserch.vStckid.ToString();
			if (txtStckid.Text == string.Empty)
			{
				return;
			}
			else
			{
				ItemsearchExecute();
			}
			
		}
		
		private void ItemsearchExecute()
		{
			stocksCollection col1;
			int nStckid = 0;
			try
			{
				mgr7 = new stocksManager();
				mgr7.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey;
				// 'MessageBox.Show(CType(leItems.EditValue, stocks))
				mgr7.DataObject.Entity.stckid = int.Parse(txtStckid.Text);
				
				col1 = mgr7.BuildCollection();
				
				if (mgr7.DataObject.RowsAffected > 0)
				{
					
					nStckid = mgr7.DataObject.Entity.stckid;
					ceCost.Value = mgr7.DataObject.Entity.cost;
					
					ceQty.Focus();
					//SendItemtoGrid()
					
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
		public void ceQty_LostFocus(object sender, EventArgs e)
		{
			if (ceQty.Value < 0 | ceFree.Value < 0)
			{
				MessageBox.Show("Qty Delivered cannot be equal or less than zero");
				
			}
		}
		public void ceFree_LostFocus(object sender, EventArgs e)
		{
			if (ceQty.Value < 0 | ceFree.Value < 0)
			{
				MessageBox.Show("Qty Delivered cannot be equal or less than zero");
				
			}
			
		}
		
		public void drgrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
			if (e.ColumnIndex == -1)
			{
				int ansint = 7;
				ansint = (int) (Interaction.MsgBox("Are you sure you want Delete the selected Row?", MsgBoxStyle.YesNo, "Delete Row Confirmation"));
				if (ansint == 6)
				{
					
					
					int ii = 0;
					try
					{
						
						// If drgrid.SelectedRows.Count = 0 Then
						//Exit Sub
						//End If
						
						drgrid.Rows.Remove(drgrid.SelectedRows[0]);
						for (ii = 0; ii <= drgrid.Rows.Count - 1; ii++)
						{
							Totss += System.Convert.ToDecimal(drgrid.Rows[ii].Cells[5].Value);
						}
						txtsum.Text = Strings.FormatNumber((Totss).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
						txtGrand.Text = Strings.FormatNumber((Totss).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
						cediscamnt.Value = 0;
						
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
			}
			
			
		}
		
		public void cediscamnt_EditValueChanged(object sender, EventArgs e)
		{
			if (txtsum.Text == "")
			{
				return;
			}
			
			decimal vSubTotals = 0;
			decimal vGrandTotals = 0;
			vSubTotals = decimal.Parse(txtsum.Text);
			
			if (cediscamnt.Value < 0)
			{
				MessageBox.Show("Discount can\'t be less than or equal to zero!");
				return;
			}
			if (cediscamnt.Value > vSubTotals)
			{
				MessageBox.Show("Discount can\'t be greater than the Total Amount!");
				return;
			}
			
			vGrandTotals = vSubTotals - cediscamnt.Value;
			txtGrand.Text = Strings.FormatNumber(vGrandTotals, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
			
		}
		
		public void ceCost_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				
				stocksManager mgrstk = new stocksManager();
				decimal vmarkup = 0; // markup
				decimal vprices = 0; // cost of the item
				decimal vmupamnt = 0; // markup amount
				decimal vFinalPrice = 0; // Final Price
				PDSATransaction trans = new PDSATransaction();
				mgrstk.DataObject.SelectFilter = stocksData.SelectFilters.All;
				mgrstk.DataObject.LoadByPK(int.Parse(txtStckid.Text));
				vmarkup = (decimal) mgrstk.DataObject.Entity.markup;
				vprices = mgrstk.DataObject.Entity.cost;
				vmupamnt = (ceCost.Value) * (vmarkup / 100);
				vFinalPrice = (ceCost.Value) + vmupamnt;
				mgrstk.DataObject.TransactionType = PDSATransactionType.Update;
				mgrstk.Entity.cost = ceCost.Value;
				mgrstk.Entity.retail = vFinalPrice;
				trans.Add(mgrstk.DataObject);
				trans.Execute();
				MessageBox.Show("Retail Price updated successfully. Retail Price is now" + (vFinalPrice).ToString());
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
		private void Tran_AfterSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			if (e.ClassName == "dlvryhdrtmpData")
			{
				mOrderId = ((dlvryhdrtmp) e.DataClassTable.EntityObject).dridtmp;
			}
		}
		
		private void Tran_BeforeSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			// Put local order id into line item objects prior to submitting INSERT statement
			if (e.ClassName == "dlvrydettmpData")
			{
				((dlvrydettmp) e.DataClassTable.EntityObject).dridtmp = mOrderId;
			}
		}
		private void TranDr_AfterSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			if (e.ClassName == "dlvry_hdrData")
			{
				mdrId = ((dlvry_hdr) e.DataClassTable.EntityObject).drid;
			}
		}
		
		private void TranDr_BeforeSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			// Put local order id into line item objects prior to submitting INSERT statement
			if (e.ClassName == "dlvry_detData")
			{
				((dlvry_det) e.DataClassTable.EntityObject).drid = mdrId;
			}
		}
		
		public void btnRetrieve_Click(object sender, EventArgs e)
		{
			if (drgrid.Rows.Count > 0)
			{
				MessageBox.Show("There is a Pending Delivery Entry. Pelase save it first!");
				return;
			}
			vwSuspendDlvryManager mgrRetrieve = default(vwSuspendDlvryManager);
			vwSuspendDlvryCollection col5 = default(vwSuspendDlvryCollection);
			
			try
			{
				mgrRetrieve = new vwSuspendDlvryManager();
				mgrRetrieve.DataObject.WhereFilter = vwSuspendDlvryData.WhereFilters.employee;
				mgrRetrieve.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				
				col5 = mgrRetrieve.BuildCollection();
				if (mgrRetrieve.DataObject.RowsAffected > 0)
				{
					DGRetrieve.Visible = true;
					DGRetrieve.Focus();
					DGRetrieve.DataSource = col5;
					
				}
				else
				{
					MessageBox.Show("N o   S u s p e n d e d   Delivery   t o   D i s p l a y");
					DGRetrieve.Visible = false;
					btnSupSearch.Focus();
					
					
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
		public void DGRetrieve_KeyDown(object sender, KeyEventArgs e)
		{
			int ii = 0;
			if (e.KeyCode == Keys.Enter)
			{
				//If DGRetrieve.Rows.Count <= 0 Then
				//    Exit Sub
				//End If
				int vCellVal = 0;
				int row = DGRetrieve.CurrentCellAddress.Y;
				int column = DGRetrieve.CurrentCellAddress.X;
				vwDlvrySuspendedCollection col4;
				
				if (column > 1)
				{
					MessageBox.Show("Please select the suspended Delivery on the first column or select the second column to Cancel Retrieval of Suspended Delivery");
					return;
				}
				
				if (column == 0) // this is the main code to be executed
				{
					
					vCellVal = System.Convert.ToInt32(DGRetrieve.CurrentCell.Value);
					vwDlvrySuspendedManager mgrRetrivDr = default(vwDlvrySuspendedManager);
					dlvryhdrtmpManager mgrdrTmp = default(dlvryhdrtmpManager);
					
					try
					{
						mgrRetrivDr = new vwDlvrySuspendedManager();
						mgrRetrivDr.DataObject.WhereFilter = vwDlvrySuspendedData.WhereFilters.DrKey;
						mgrRetrivDr.Entity.dridtmp = vCellVal;
						
						col4 = mgrRetrivDr.BuildCollection();
						if (mgrRetrivDr.DataObject.RowsAffected > 0)
						{
							for (ii = 0; ii <= mgrRetrivDr.DataObject.GetDataTable().Rows.Count - 1; ii++)
							{
								drgrid.Rows.Add(mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["stckid"], (mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["item_desc"]).ToString(), (mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["qty"]).ToString(), mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["freee"], mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["cost"], mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["drdetamnt"]);
								txtSupcode.Text = (mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["supcode"]).ToString();
								txtSupplier.Text = (mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["supplier"]).ToString();
								ceDays.Value = decimal.Parse((mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["terms"]).ToString());
								deDue.EditValue = (mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["drdue"]).ToString();
								dedlvrydate.EditValue = (mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["drdate"]).ToString();
								txtInv.Text = (mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["drinv"]).ToString();
								leSupplier.Text = (mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["supplier"]).ToString();
							}
							decimal Tots22 = 0;
							int iii = 0;
							for (iii = 0; iii <= drgrid.Rows.Count - 1; iii++)
							{
								Tots22 += System.Convert.ToDecimal(drgrid.Rows[iii].Cells[5].Value);
							}
							txtsum.Text = Strings.FormatNumber((Tots22).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
							txtGrand.Text = Strings.FormatNumber((Tots22).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
							
							DGRetrieve.Visible = false;
							btnItemSearch.Focus();
						}
						
						//delete the records for the hdrtmp it will cascade delete the data on hdr_detiltmp
						mgrdrTmp = new dlvryhdrtmpManager();
						mgrdrTmp.DataObject.DeleteByPK(vCellVal);
						//btnItemSearch.Focus()
						
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
				//'btnSupSearch.Focus()
				//leSupplier.Focus()
				btnItemSearch.Focus();
				if (column == 1)
				{
					DGRetrieve.Visible = false;
				}
				
			}
		}
		
		public void drgrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			int roww = DGRetrieve.CurrentCellAddress.Y;
			int varrowindex = 0;
			int vqty = 0;
			decimal vamnt = 0;
			varrowindex = drgrid.SelectedCells[0].RowIndex;
			vqty = System.Convert.ToInt32(drgrid.Rows[varrowindex].Cells[2].Value);
			vamnt = System.Convert.ToDecimal(drgrid.Rows[varrowindex].Cells[4].Value);
			
			//Dim rowww As Integer = CInt(DGRetrieve.CurrentRow.Selected())
			drgrid.Rows[varrowindex].Cells[5].Value = vqty * vamnt;
			int I = 0;
			Totss = 0;
			for (I = 0; I <= drgrid.Rows.Count - 1; I++)
			{
				Totss += System.Convert.ToDecimal(drgrid.Rows[I].Cells[5].Value);
			}
			txtsum.Text = Strings.FormatNumber(Totss, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
			txtGrand.Text = Strings.FormatNumber(Totss, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
			
		}
		
		public void btnPost_Click(object sender, EventArgs e)
		{
			int ansint = 0;
			ansint = 7;
			ansint = (int) (Interaction.MsgBox("Please make sure All information entered are correct(invoice#,Supplier,Items,Date Delivered etc.) before clicking yes to save!", MsgBoxStyle.YesNo, null));
			if (ansint == 7)
			{
				return;
			}
			
			if (drgrid.Rows.Count <= 0)
			{
				MessageBox.Show("Item list is empty!");
				btnItemSearch.Focus();
				return;
			}
			//If txtSupcode.Text = String.Empty Then
			//    MessageBox.Show("Please select a supplier before saving.")
			//    btnSupSearch.Focus()
			//    Exit Sub
			//End If
			if (leSupplier.Text == string.Empty)
			{
				MessageBox.Show("Please select a supplier before saving.");
				leSupplier.Focus();
				return;
			}
			if (txtInv.Text == string.Empty)
			{
				MessageBox.Show("Please Enter an Invoice# before saving.");
				txtInv.Focus();
				return;
			}
			
			int grdCount = 0;
			int iii = 0;
			TranDr = new PDSATransaction();
			TranDr.AfterSubmit += TranDr_AfterSubmit;
			TranDr.BeforeSubmit += TranDr_BeforeSubmit;
			mgrdrheader = new dlvry_hdrManager();
			mgrdrheader.DataObject.TransactionType = PDSATransactionType.Insert;
			try
			{
				
				mgrdrheader.Entity.drdate = DateTime.Parse(dedlvrydate.Text);
				mgrdrheader.Entity.ttype = "COD";
				mgrdrheader.Entity.terms = (short) ceDays.Value;
				mgrdrheader.Entity.drdue = DateTime.Parse(deDue.Text);
				mgrdrheader.Entity.drdscamnt = cediscamnt.Value;
				mgrdrheader.Entity.dtInsertdt = DateTime.Now;
				mgrdrheader.Entity.dtLastUpdatedt = DateTime.Now;
				mgrdrheader.Entity.drinv = txtInv.Text.Trim();
				mgrdrheader.Entity.paid = false;
				mgrdrheader.Entity.drpsted = true;
				mgrdrheader.Entity.drbal = decimal.Parse(txtGrand.Text); //vGrandTotal
				mgrdrheader.Entity.dramnt = decimal.Parse(txtsum.Text);
				mgrdrheader.Entity.drpsted = false;
				mgrdrheader.Entity.drsubtot = decimal.Parse(txtsum.Text);
				mgrdrheader.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				mgrdrheader.Entity.supcode = System.Convert.ToInt32(leSupplier.EditValue); //CInt(txtSupcode.Text)
				//mgrdrheader.Entity.iConcurrencyid
				TranDr.Add(mgrdrheader.DataObject);
				
				
				grdCount = drgrid.Rows.Count;
				for (iii = 0; iii <= grdCount - 1; iii++)
				{
					mgrdrdetail = new dlvry_detManager();
					mgrdrdetail.DataObject.TransactionType = PDSATransactionType.Insert;
					mgrdrdetail.Entity.drid = mdrId;
					mgrdrdetail.Entity.stckid = Convert.ToInt32(drgrid.Rows[iii].Cells[0].Value);
					mgrdrdetail.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					if (System.Convert.ToInt32(drgrid.Rows[iii].Cells[2].Value) > 0)
					{
						mgrdrdetail.Entity.qty = System.Convert.ToInt32(drgrid.Rows[iii].Cells[2].Value);
					}
					else
					{
						mgrdrdetail.Entity.qty = 0;
					}
					if (System.Convert.ToInt32(drgrid.Rows[iii].Cells[3].Value) > 0)
					{
						mgrdrdetail.Entity.freee = System.Convert.ToInt32(drgrid.Rows[iii].Cells[3].Value);
					}
					else
					{
						mgrdrdetail.Entity.freee = 0;
					}
					mgrdrdetail.Entity.cost = System.Convert.ToDecimal(drgrid.Rows[iii].Cells[4].Value);
					mgrdrdetail.Entity.drdetamnt = System.Convert.ToDecimal(drgrid.Rows[iii].Cells[5].Value);
					mgrdrdetail.Entity.lotno = (drgrid.Rows[iii].Cells[7].Value).ToString();
					if ((drgrid.Rows[iii].Cells[6].Value).ToString() != string.Empty)
					{
						mgrdrdetail.Entity.expdate = System.Convert.ToDateTime(drgrid.Rows[iii].Cells[6].Value);
					}
					mgrdrdetail.Entity.disc = System.Convert.ToInt32(drgrid.Rows[iii].Cells[8].Value);
					mgrdrdetail.Entity.discamnt = System.Convert.ToDecimal(drgrid.Rows[iii].Cells[9].Value);
					//drd.Entity.detamnt = Convert.ToDecimal(drdgrid.Rows(iii).Cells(4).Value) * Convert.ToInt32(drdgrid.Rows(iii).Cells(5).Value)
					
					TranDr.Add(mgrdrdetail.DataObject);
				}
				TranDr.Execute();
				
				PDSATransaction TranDrSp = new PDSATransaction();
				spDlvryProcManager mgrspDrTrans = new spDlvryProcManager();
				
				mgrspDrTrans.Entity.drdrid = mdrId;
				mgrspDrTrans.Entity.supcode = System.Convert.ToInt32(leSupplier.EditValue);
				TranDrSp.Add(mgrspDrTrans.DataObject);
				TranDrSp.Execute();
				MessageBox.Show("Delivery Transaction Successfully Posted.");
				//btnPost.Enabled = False
				Disablectrl();
				
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
		}
		
		public void btnSave_Click(object sender, EventArgs e)
		{
			
			int ansint = 0;
			ansint = 7;
			ansint = (int) (Interaction.MsgBox("Please make sure you selected the correct supplier and entered the correct items and totals before clicking yes!", MsgBoxStyle.YesNo, null));
			if (ansint == 7)
			{
				return;
			}
			//Check Before Saving
			if (drgrid.Rows.Count <= 0)
			{
				MessageBox.Show("Item list is empty!");
				return;
			}
			
			if (leSupplier.Text == string.Empty)
			{
				MessageBox.Show("Please select a supplier before saving.");
				leSupplier.Focus();
				return;
			}
			//If txtSupcode.Text = String.Empty Then
			//MessageBox.Show("Please select a supplier before saving.")
			//Exit Sub
			//End If
			if (txtInv.Text == string.Empty)
			{
				MessageBox.Show("Invoice NUmber cannot be left blank before saving.");
				return;
			}
			
			
			int grdCount = 0;
			int iii = 0;
			
			try
			{
				
				TranHdrtmp = new PDSATransaction();
				TranHdrtmp.AfterSubmit += Tran_AfterSubmit;
				TranHdrtmp.BeforeSubmit += Tran_BeforeSubmit;
				mgrhdrtmp = new dlvryhdrtmpManager();
				//drd = New dlvrydettmpManager()
				//mgrhdrtmp.DataObject.TransactionType = PDSATransactionType.Insert
				mgrhdrtmp.Entity.drdate = DateTime.Parse(dedlvrydate.Text);
				mgrhdrtmp.Entity.ttype = "COD";
				mgrhdrtmp.Entity.terms = (short) ceDays.Value;
				mgrhdrtmp.Entity.drdue = DateTime.Parse(deDue.Text);
				mgrhdrtmp.Entity.drdscamnt = cediscamnt.Value;
				mgrhdrtmp.Entity.dtInsertdt = DateTime.Now;
				mgrhdrtmp.Entity.dtLastUpdatedt = DateTime.Now;
				mgrhdrtmp.Entity.drinv = txtInv.Text.Trim();
				
				mgrhdrtmp.Entity.drbal = vGrandTotal;
				mgrhdrtmp.Entity.dramnt = vGrandTotal;
				mgrhdrtmp.Entity.drpsted = false;
				mgrhdrtmp.Entity.drsubtot = Totss;
				mgrhdrtmp.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				mgrhdrtmp.Entity.supcode = System.Convert.ToInt32(leSupplier.EditValue); //CInt(txtSupcode.Text)
				TranHdrtmp.Add(mgrhdrtmp.DataObject);
				
				
				grdCount = drgrid.Rows.Count;
				for (iii = 0; iii <= grdCount - 1; iii++)
				{
					drd = new dlvrydettmpManager();
					drd.DataObject.TransactionType = PDSATransactionType.Insert;
					drd.Entity.dridtmp = mOrderId;
					drd.Entity.stckid = Convert.ToInt32(drgrid.Rows[iii].Cells[0].Value);
					drd.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					if (System.Convert.ToInt32(drgrid.Rows[iii].Cells[2].Value) > 0)
					{
						drd.Entity.qty = System.Convert.ToInt32(drgrid.Rows[iii].Cells[2].Value);
					}
					else
					{
						drd.Entity.qty = 0;
					}
					if (System.Convert.ToInt32(drgrid.Rows[iii].Cells[3].Value) > 0)
					{
						drd.Entity.freee = System.Convert.ToInt32(drgrid.Rows[iii].Cells[3].Value);
					}
					else
					{
						drd.Entity.freee = 0;
					}
					drd.Entity.cost = System.Convert.ToDecimal(drgrid.Rows[iii].Cells[4].Value);
					drd.Entity.drdetamnt = System.Convert.ToDecimal(drgrid.Rows[iii].Cells[5].Value);
					//drd.Entity.detamnt = Convert.ToDecimal(drdgrid.Rows(iii).Cells(4).Value) * Convert.ToInt32(drdgrid.Rows(iii).Cells(5).Value)
					
					TranHdrtmp.Add(drd.DataObject);
				}
				
				TranHdrtmp.Execute();
				MessageBox.Show("Delivery successfuly saved.");
				drgrid.Rows.Clear();
				//btnSave.Enabled = False
				Disablectrl();
				
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
		}
		
		private void Disablectrl()
		{
			GroupControl1.Enabled = false;
			dedlvrydate.Enabled = false;
			btnSupSearch.Enabled = false;
			leSupplier.Enabled = false;
			txtInv.Enabled = false;
			ceDays.Enabled = false;
			deDue.Enabled = false;
			btnItemSearch.Enabled = false;
			ceQty.Enabled = false;
			ceFree.Enabled = false;
			ceCost.Enabled = false;
			btnAdd.Enabled = false;
			drgrid.Enabled = false;
			btnPost.Enabled = false;
			btnRetrieve.Enabled = false;
			btnSave.Enabled = false;
			cediscamnt.Enabled = false;
			btnNew.Enabled = true;
		}
		
		private void Enablectrl()
		{
			GroupControl1.Enabled = true;
			dedlvrydate.Enabled = true;
			btnSupSearch.Enabled = true;
			leSupplier.Enabled = true;
			txtInv.Enabled = true;
			ceDays.Enabled = true;
			deDue.Enabled = true;
			btnItemSearch.Enabled = true;
			ceQty.Enabled = true;
			ceFree.Enabled = true;
			ceCost.Enabled = true;
			btnAdd.Enabled = true;
			drgrid.Enabled = true;
			btnPost.Enabled = true;
			btnRetrieve.Enabled = true;
			btnSave.Enabled = true;
			cediscamnt.Enabled = true;
			btnNew.Enabled = false;
			
		}
		
		public void txtInv_LostFocus(object sender, EventArgs e)
		{
			if (txtInv.Text != "")
			{
				vwDlvryManager mgrinv = new vwDlvryManager();
				mgrinv.DataObject.SelectFilter = vwDlvryData.SelectFilters.All;
				mgrinv.DataObject.WhereFilter = vwDlvryData.WhereFilters.drinv;
				mgrinv.Entity.drinv = txtInv.Text.Trim();
				mgrinv.DataObject.Load();
				if (mgrinv.DataObject.RowsAffected > 0)
				{
					MessageBox.Show("Invoice number already exist-" + "Issued by " + mgrinv.DataObject.Entity.supplier + " On " + System.Convert.ToString(mgrinv.DataObject.Entity.drdate) + "-Posted by " + mgrinv.DataObject.Entity.sInsertid + " - And is Paid?  " + System.Convert.ToString(mgrinv.DataObject.Entity.paid));
					txtInv.Text = "";
					txtInv.Focus();
				}
				
			}
		}
		
		public void dedlvrydate_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				leSupplier.Focus();
			}
		}
		
		public void leSupplier_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				txtInv.Focus();
			}
		}
		
		public void btnAdd_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				ceAmountDisc.Focus();
			}
		}
		
		public void ceAmountDisc_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				cePrcentDisc.Focus();
			}
		}
		
		public void cePrcentDisc_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				deExpDate.Focus();
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				ceAmountDisc.Value = (decimal) ((((int) ceQty.Value) * ceCost.Value) * ((double) ((int) cePrcentDisc.Value) / 100));
			}
			
		}
		
		public void deExpDate_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				txtLotNo.Focus();
			}
		}
		
		public void LabelControl13_Click(object sender, EventArgs e)
		{
			txtLotNo.Focus();
		}
		
		public void LabelControl8_Click(object sender, EventArgs e)
		{
			ceQty.Focus();
		}
		
		public void LabelControl1_Click(object sender, EventArgs e)
		{
			dedlvrydate.Focus();
		}
		
		public void LabelControl2_Click(object sender, EventArgs e)
		{
			leSupplier.Focus();
		}
		
		public void LabelControl3_Click(object sender, EventArgs e)
		{
			txtInv.Focus();
		}
		
		public void LabelControl5_Click(object sender, EventArgs e)
		{
			ceDays.Focus();
		}
		
		public void LabelControl4_Click(object sender, EventArgs e)
		{
			deDue.Focus();
		}
		
		public void LabelControl9_Click(object sender, EventArgs e)
		{
			ceCost.Focus();
		}
		
		public void LabelControl14_Click(object sender, EventArgs e)
		{
			deExpDate.Focus();
		}
		
		public void LabelControl16_Click(object sender, EventArgs e)
		{
			ceAmountDisc.Focus();
		}
		
		public void LabelControl15_Click(object sender, EventArgs e)
		{
			cePrcentDisc.Focus();
		}
		
		
		
		
		public void cePrcentDisc_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void drgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		public void DGRetrieve_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
