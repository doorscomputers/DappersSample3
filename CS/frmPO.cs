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
using DevExpress.Skins;

namespace DoorsPOS.WinApp
{
	public partial class frmPO
	{
		public frmPO()
		{
			InitializeComponent();
		}
		pohdrtmpManager mgrpohdrtmp;
		podettmpManager mgrpodettmp;
		//Dim mgrdrheader As pohdrtmpManager
		stocksManager mgrseven;
		decimal Totss = 0;
		private int mOrderId = 0;
		private int mdrId = 0;
		private PDSA.DataLayer.DataClasses.PDSATransaction TranDr;
		public void frmPO_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		public void comboBoxEdit1_SelectedIndexChanged(System.Object sender, System.EventArgs e) //AddHandler ComboBoxEdit1.SelectedIndexChanged, AddressOf comboBoxEdit1_SelectedIndexChanged
		{
			// Add available skin names to the combo box.
			foreach (SkinContainer cnt in SkinManager.Default.Skins)
			{
				ComboBoxEdit1.Properties.Items.Add(cnt.SkinName);
			}
			ComboBoxEdit comboBox = (ComboBoxEdit) sender;
			string skinName = comboBox.Text;
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = skinName;
		}
		
		public void frmPO_FormClosing(object sender, FormClosingEventArgs e)
		{
			int vRows = drgrid.Rows.Count;
			if (vRows > 0)
			{
				MessageBox.Show("Purchase Order List Exist. Please Save/Post or Click New before closing the PO Entry Form.");
				e.Cancel = true;
			}
		}
		
		public void frmPO_Load(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			dedlvrydate.EditValue = DateTime.Today;
			drgrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			drgrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			drgrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			//drgrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
			//Dim btn As New DataGridViewButtonColumn()
			//drgrid.Columns.Add(btn)
			//btn.HeaderText = "Remove"
			//btn.Text = "Remove"
			//btn.Name = "Remove"
			//btn.UseColumnTextForButtonValue = True
			LoadSupplier();
			btnNew.Focus();
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
			catch (PDSA.Validation.PDSAValidationException ex)
			{
				MessageBox.Show(ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}
		
		public void btnAdd_Click(object sender, EventArgs e)
		{
			
			if (ceQty.Value <= 0)
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
			ceQty.Value = 0;
			ceCost.Value = 0;
			txtStckid.Text = string.Empty;
			txtSupcode.Text = string.Empty;
			dedlvrydate.Focus();
		}
		
		public void SendItemtoGrid()
		{
			
			int I = 0;
			int ItemLoc = -1;
			int nProdIDD = 0;
			decimal Amount3 = 0;
			if (ceQty.Value > 0)
			{
				Amount3 = ceQty.Value * ceCost.Value;
			}
			else
			{
				Amount3 = 0;
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
					drgrid.Rows.Add(mgrseven.DataObject.Entity.stckid, mgrseven.DataObject.Entity.itemdesc, ceQty.Value, mgrseven.DataObject.Entity.cost, Amount3);
				}
				else
				{
					
					// if item is already there increase its count
					int ItemCount = System.Convert.ToInt32(drgrid.Rows[ItemLoc].Cells[2].Value);
					ItemCount += (int) ceQty.Value;
					decimal NewPrice = mgrseven.DataObject.Entity.cost * ItemCount;
					drgrid.Rows[ItemLoc].Cells[2].Value = ItemCount;
					drgrid.Rows[ItemLoc].Cells[4].Value = NewPrice;
					
				}
				decimal Totsss = 0;
				
				for (I = 0; I <= drgrid.Rows.Count - 1; I++)
				{
					Totsss += System.Convert.ToDecimal(drgrid.Rows[I].Cells[4].Value);
				}
				//Select the last row.
				this.drgrid.Rows[this.drgrid.RowCount - 1].Selected = true;
				//Scroll to the last row.
				this.drgrid.FirstDisplayedScrollingRowIndex = this.drgrid.RowCount - 1;
				
				txtsum.Text = Strings.FormatNumber((Totsss).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
				ceQty.Value = 1;
				txtItem.Text = string.Empty;
				ceCost.Value = 0;
				txtStckid.Text = string.Empty;
				
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
		
		//Private Sub btnSupSearch_Click(sender As Object, e As EventArgs) Handles btnSupSearch.Click
		//    Dim frmSupsearch As New frmSupplierSearch
		//    frmSupsearch.ShowDialog()
		//    Try
		//        txtSupplier.Text = String.Empty
		//        txtSupplier.Text = frmSupsearch.vSupplier.ToString()
		//        txtSupcode.Text = frmSupsearch.vSupCode.ToString()
		//        If txtSupcode.Text = String.Empty Then
		//            MessageBox.Show("Please Select a supplier!")
		//            Exit Sub
		//        End If
		
		//    Catch ex As Exception
		//        MessageBox.Show(ex.ToString())
		//    End Try
		
		//End Sub
		
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
				mgrseven = new stocksManager();
				mgrseven.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey;
				// 'MessageBox.Show(CType(leItems.EditValue, stocks))
				mgrseven.DataObject.Entity.stckid = int.Parse(txtStckid.Text);
				
				col1 = mgrseven.BuildCollection();
				
				if (mgrseven.DataObject.RowsAffected > 0)
				{
					
					nStckid = mgrseven.DataObject.Entity.stckid;
					ceCost.Value = mgrseven.DataObject.Entity.cost;
					
					ceQty.Focus();
					//SendItemtoGrid()
					
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
		public void ceQty_LostFocus(object sender, EventArgs e)
		{
			if (ceQty.Value < 0)
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
						drgrid.Rows.Remove(drgrid.SelectedRows[0]);
						for (ii = 0; ii <= drgrid.Rows.Count - 1; ii++)
						{
							Totss += System.Convert.ToDecimal(drgrid.Rows[ii].Cells[4].Value);
						}
						
						txtsum.Text = Strings.FormatNumber((Totss).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
						
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
		private void Tran_AfterSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			if (e.ClassName == "pohdrtmpData")
			{
				mOrderId = ((pohdrtmp) e.DataClassTable.EntityObject).poidtmp;
			}
		}
		
		private void Tran_BeforeSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			// Put local order id into line item objects prior to submitting INSERT statement
			if (e.ClassName == "podettmpData")
			{
				((podettmp) e.DataClassTable.EntityObject).poidtmp = mOrderId;
			}
		}
		
		public void btnRetrieve_Click(object sender, EventArgs e)
		{
			if (drgrid.Rows.Count > 0)
			{
				MessageBox.Show("There is a Pending PO Entry. Pelase save or delete it first!");
				return;
			}
			vwPoSavedManager mgrRetrieve = default(vwPoSavedManager); //vwSuspendDlvryManager
			vwPoSavedCollection col5 = default(vwPoSavedCollection); //vwSuspendDlvryCollection
			
			try
			{
				mgrRetrieve = new vwPoSavedManager(); //vwSuspendDlvryManager()
				mgrRetrieve.DataObject.WhereFilter = vwPoSavedData.WhereFilters.sInsert_id; //vwSuspendDlvryData.WhereFilters.employee
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
					MessageBox.Show("N o   S u s p e n d e d   Purchase Order   t o   D i s p l a y");
					DGRetrieve.Visible = false;
					leSupplier.Focus();
					
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
				vwPOSuspendedCollection col4; //vwDlvrySuspendedCollection
				
				if (column > 1)
				{
					MessageBox.Show("Please select the suspended PO on the first column or select the second column to Cancel Retrieval of Suspended PO");
					return;
				}
				
				if (column == 0) // this is the main code to be executed
				{
					
					vCellVal = System.Convert.ToInt32(DGRetrieve.CurrentCell.Value);
					vwPOSuspendedManager mgrRetrivDr = default(vwPOSuspendedManager); //vwDlvrySuspendedManager
					pohdrtmpManager mgrdrTmp = default(pohdrtmpManager); //dlvryhdrtmpManager
					
					try
					{
						mgrRetrivDr = new vwPOSuspendedManager(); //vwDlvrySuspendedManager()
						mgrRetrivDr.DataObject.WhereFilter = vwPOSuspendedData.WhereFilters.poid; //vwDlvrySuspendedData.WhereFilters.DrKey
						mgrRetrivDr.Entity.poidtmp = vCellVal;
						
						col4 = mgrRetrivDr.BuildCollection();
						if (mgrRetrivDr.DataObject.RowsAffected > 0)
						{
							for (ii = 0; ii <= mgrRetrivDr.DataObject.GetDataTable().Rows.Count - 1; ii++)
							{
								drgrid.Rows.Add(mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["stckid"], (mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["item_desc"]).ToString(), (mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["qty"]).ToString(), mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["cost"], mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["podetamnt"]);
								//txtSupcode.Text = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("supcode"))
								//txtSupplier.Text = CStr(mgrRetrivDr.DataObject.GetDataTable.Rows(ii)("supplier"))
								dedlvrydate.EditValue = (mgrRetrivDr.DataObject.GetDataTable().Rows[ii]["podate"]).ToString();
							}
							decimal Tots22 = 0;
							int iii = 0;
							for (iii = 0; iii <= drgrid.Rows.Count - 1; iii++)
							{
								Tots22 += System.Convert.ToDecimal(drgrid.Rows[iii].Cells[4].Value);
							}
							txtsum.Text = Strings.FormatNumber((Tots22).ToString(), -1, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
							DGRetrieve.Visible = false;
						}
						
						//delete the records for the hdrtmp it will cascade delete the data on hdr_detiltmp
						mgrdrTmp = new pohdrtmpManager(); //dlvryhdrtmpManager()
						mgrdrTmp.DataObject.DeleteByPK(vCellVal);
						
						
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
				leSupplier.Focus();
				
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
			drgrid.Rows[varrowindex].Cells[4].Value = vqty * vamnt;
			int I = 0;
			Totss = 0;
			for (I = 0; I <= drgrid.Rows.Count - 1; I++)
			{
				Totss += System.Convert.ToDecimal(drgrid.Rows[I].Cells[4].Value);
			}
			txtsum.Text = Strings.FormatNumber(Totss, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
		}
		
		public void btnPost_Click(object sender, EventArgs e)
		{
			int ansint = 0;
			ansint = 7;
			ansint = (int) (Interaction.MsgBox("Please make sure All information entered are correct(Supplier,Items Ordered,Date Ordered etc.) before clicking yes to save!", MsgBoxStyle.YesNo, null));
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
			if (leSupplier.Text == string.Empty)
			{
				MessageBox.Show("Please select a supplier before saving.");
				leSupplier.Focus();
				return;
			}
			
			int grdCount = 0;
			int iii = 0;
			TranDr = new PDSA.DataLayer.DataClasses.PDSATransaction();
			TranDr.AfterSubmit += Tran_AfterSubmit;
			TranDr.BeforeSubmit += Tran_BeforeSubmit;
			mgrpohdrtmp = new pohdrtmpManager(); //dlvry_hdrManager()
			mgrpohdrtmp.DataObject.TransactionType = PDSATransactionType.Insert;
			try
			{
				
				mgrpohdrtmp.Entity.podate = DateTime.Parse(dedlvrydate.Text);
				mgrpohdrtmp.Entity.dtInsertdt = DateTime.Now;
				mgrpohdrtmp.Entity.dtLastUpdatedt = DateTime.Now;
				mgrpohdrtmp.Entity.dlivered = true;
				mgrpohdrtmp.Entity.drpsted = true;
				mgrpohdrtmp.Entity.poamnt = decimal.Parse(txtsum.Text); //vGrandTotal
				mgrpohdrtmp.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				mgrpohdrtmp.Entity.supcode = int.Parse(txtSupcode.Text);
				TranDr.Add(mgrpohdrtmp.DataObject);
				
				
				grdCount = drgrid.Rows.Count;
				for (iii = 0; iii <= grdCount - 1; iii++)
				{
					mgrpodettmp = new podettmpManager();
					mgrpodettmp.DataObject.TransactionType = PDSATransactionType.Insert;
					mgrpodettmp.Entity.poidtmp = mOrderId; //mdrId
					mgrpodettmp.Entity.stckid = Convert.ToInt32(drgrid.Rows[iii].Cells[0].Value);
					mgrpodettmp.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					if (System.Convert.ToInt32(drgrid.Rows[iii].Cells[2].Value) > 0)
					{
						mgrpodettmp.Entity.qty = System.Convert.ToInt32(drgrid.Rows[iii].Cells[2].Value);
					}
					else
					{
						mgrpodettmp.Entity.qty = 0;
					}
					mgrpodettmp.Entity.cost = System.Convert.ToDecimal(drgrid.Rows[iii].Cells[4].Value);
					mgrpodettmp.Entity.podetamnt = System.Convert.ToDecimal(drgrid.Rows[iii].Cells[4].Value);
					TranDr.Add(mgrpodettmp.DataObject);
				}
				TranDr.Execute();
				
				//Dim TranDrSp As New PDSATransaction()
				//Dim mgrspDrTrans As New spDlvryProcManager()
				
				//mgrspDrTrans.Entity.drdrid = mdrId
				//mgrspDrTrans.Entity.supcode = CInt(Trim(txtSupcode.Text))
				//TranDrSp.Add(mgrspDrTrans.DataObject)
				//TranDrSp.Execute()
				MessageBox.Show("Delivery Transaction Successfully Posted.");
				//btnPost.Enabled = False
				Disablectrl();
				
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
			//If txtSupcode.Text = String.Empty Then
			//MessageBox.Show("Please select a supplier before saving.")
			//Exit Sub
			//End If
			
			int grdCount = 0;
			int iii = 0;
			TranDr = new PDSA.DataLayer.DataClasses.PDSATransaction();
			TranDr.AfterSubmit += Tran_AfterSubmit;
			TranDr.BeforeSubmit += Tran_BeforeSubmit;
			
			try
			{
				mgrpohdrtmp = new pohdrtmpManager();
				mgrpohdrtmp.Entity.podate = DateTime.Parse(dedlvrydate.Text);
				mgrpohdrtmp.Entity.dtInsertdt = DateTime.Now;
				mgrpohdrtmp.Entity.dtLastUpdatedt = DateTime.Now;
				mgrpohdrtmp.Entity.dlivered = false;
				mgrpohdrtmp.Entity.drpsted = false;
				mgrpohdrtmp.Entity.poamnt = decimal.Parse(txtsum.Text); //vGrandTotal
				mgrpohdrtmp.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				mgrpohdrtmp.Entity.supcode = System.Convert.ToInt32(leSupplier.EditValue); //CInt(txtSupcode.Text)
				TranDr.Add(mgrpohdrtmp.DataObject);
				
				grdCount = drgrid.Rows.Count;
				for (iii = 0; iii <= grdCount - 1; iii++)
				{
					mgrpodettmp = new podettmpManager(); //dlvry_detManager()
					mgrpodettmp.DataObject.TransactionType = PDSATransactionType.Insert;
					mgrpodettmp.Entity.poidtmp = mOrderId; //mdrId
					mgrpodettmp.Entity.stckid = Convert.ToInt32(drgrid.Rows[iii].Cells[0].Value);
					mgrpodettmp.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					if (System.Convert.ToInt32(drgrid.Rows[iii].Cells[2].Value) > 0)
					{
						mgrpodettmp.Entity.qty = System.Convert.ToInt32(drgrid.Rows[iii].Cells[2].Value);
					}
					else
					{
						mgrpodettmp.Entity.qty = 0;
					}
					mgrpodettmp.Entity.cost = System.Convert.ToDecimal(drgrid.Rows[iii].Cells[4].Value);
					mgrpodettmp.Entity.podetamnt = System.Convert.ToDecimal(drgrid.Rows[iii].Cells[4].Value);
					TranDr.Add(mgrpodettmp.DataObject);
				}
				TranDr.Execute();
				MessageBox.Show("PO successfuly saved.");
				//btnSave.Enabled = False
				Disablectrl();
				
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
		
		private void Disablectrl()
		{
			GroupControl1.Enabled = false;
			dedlvrydate.Enabled = false;
			btnItemSearch.Enabled = false;
			ceQty.Enabled = false;
			ceCost.Enabled = false;
			btnAdd.Enabled = false;
			drgrid.Enabled = false;
			btnPost.Enabled = false;
			btnRetrieve.Enabled = false;
			btnSave.Enabled = false;
			btnNew.Enabled = true;
		}
		
		private void Enablectrl()
		{
			GroupControl1.Enabled = true;
			dedlvrydate.Enabled = true;
			btnItemSearch.Enabled = true;
			ceQty.Enabled = true;
			ceCost.Enabled = true;
			btnAdd.Enabled = true;
			drgrid.Enabled = true;
			btnPost.Enabled = true;
			btnRetrieve.Enabled = true;
			btnSave.Enabled = true;
			btnNew.Enabled = false;
		}
		
		private void LoadSupplier()
		{
			suppliersManager mgrs = new suppliersManager();
			mgrs.DataObject.OrderByFilter = suppliersData.OrderByFilters.supplier;
			suppliersCollection cols = default(suppliersCollection);
			cols = mgrs.BuildCollection();
			leSupplier.Properties.DisplayMember = "supplier";
			leSupplier.Properties.ValueMember = "supcode";
			leSupplier.Properties.DataSource = cols;
		}
		
		
	}
	
	
	
	
}
