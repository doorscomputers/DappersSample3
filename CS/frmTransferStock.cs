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
	public partial class frmTransferStock
	{
		public frmTransferStock()
		{
			InitializeComponent();
		}
		stocksManager mgr7;
		transfer_hdrManager mgrdrheader; // Transfer_hdr
		transfer_detManager mgrdrdetail; // transfer_det
		decimal Totss = 0;
		//Private mOrderId As Integer = 0
		private int mdrId = 0;
		private PDSA.DataLayer.DataClasses.PDSATransaction TranHdrtmp;
		private PDSA.DataLayer.DataClasses.PDSATransaction TranDr;
		
		public void frmTransferStock_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmTransferStock_FormClosing(object sender, FormClosingEventArgs e)
		{
			int vRows = drgrid.Rows.Count;
			if (vRows > 0)
			{
				MessageBox.Show("Transfer List still Exist. Please Save/Post or Click New before closing the Transfer Entry Form.");
				e.Cancel = true;
			}
		}
		public void frmTransferStock_Load(object sender, EventArgs e)
		{
			LoadLocation();
			this.Cursor = Cursors.WaitCursor;
			dedlvrydate.EditValue = DateTime.Today;
			drgrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			drgrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			drgrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			//drgrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
			this.Cursor = Cursors.Default;
		}
		public void LoadLocation()
		{
			locationManager mgrloc = new locationManager();
			try
			{
				locationManager mgrs = new locationManager();
				mgrs.DataObject.OrderByFilter = locationData.OrderByFilters.location;
				locationCollection cols = default(locationCollection);
				cols = mgrs.BuildCollection();
				leLocation.Properties.DisplayMember = "location";
				leLocation.Properties.ValueMember = "locid";
				leLocation.Properties.DataSource = cols;
				
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
		
		public void btnItemSearch_Click(object sender, EventArgs e)
		{
			try
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
			catch (PDSA.Validation.PDSAValidationException ex)
			{
				MessageBox.Show(ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
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
				MessageBox.Show("Qty to be transferred cannot be less than or equal to zero");
				ceQty.Focus();
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
					drgrid.Rows.Add(mgr7.DataObject.Entity.stckid, mgr7.DataObject.Entity.itemdesc, ceQty.Value, mgr7.DataObject.Entity.cost, Amount3);
				}
				else
				{
					
					// if item is already there increase its count
					int ItemCount = System.Convert.ToInt32(drgrid.Rows[ItemLoc].Cells[2].Value);
					ItemCount += (int) ceQty.Value;
					decimal NewPrice = mgr7.DataObject.Entity.cost * ItemCount;
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
		
		public void ceQty_LostFocus(object sender, EventArgs e)
		{
			if (ceQty.Value < 0)
			{
				MessageBox.Show("Qty Trasnferred cannot be equal or less than zero");
				
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
		
		private void TranDr_AfterSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			if (e.ClassName == "transfer_hdrData") // Transfer_hdr
			{
				mdrId = ((transfer_hdr) e.DataClassTable.EntityObject).tid;
			}
		}
		
		private void TranDr_BeforeSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			// Put local order id into line item objects prior to submitting INSERT statement
			if (e.ClassName == "transfer_detData") // Transfer_det
			{
				((transfer_det) e.DataClassTable.EntityObject).tid = mdrId;
			}
		}
		public void drgrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			//Dim roww As Integer = DGRetrieve.CurrentCellAddress.Y
			//Dim varrowindex As Integer = 0
			//Dim vqty As Integer = 0
			//Dim vamnt As Decimal = 0
			//varrowindex = drgrid.SelectedCells(0).RowIndex
			//vqty = CInt(drgrid.Rows(varrowindex).Cells(2).Value)
			//vamnt = CDec(drgrid.Rows(varrowindex).Cells(4).Value)
			
			//'Dim rowww As Integer = CInt(DGRetrieve.CurrentRow.Selected())
			//drgrid.Rows(varrowindex).Cells(5).Value = vqty * vamnt
			//Dim I As Integer = 0
			//Totss = 0
			//For I = 0 To drgrid.Rows.Count - 1
			//    Totss += CDec(drgrid.Rows(I).Cells(5).Value)
			//Next
			//txtsum.Text = FormatNumber(Totss, 2)
			//txtGrand.Text = FormatNumber(Totss, 2)
			
		}
		
		public void btnPost_Click(object sender, EventArgs e)
		{
			if (leLocation.Text == string.Empty)
			{
				MessageBox.Show("Identify the location where you are transferring the stock.");
				leLocation.Focus();
				return;
			}
			int ansint = 0;
			ansint = 7;
			ansint = (int) (Interaction.MsgBox("Please make sure All information entered are correct(Where to transfer,Items,Date Transferred etc.) before clicking yes to Save!", MsgBoxStyle.YesNo, null));
			if (ansint == 7)
			{
				return;
			}
			
			if (drgrid.Rows.Count <= 0)
			{
				MessageBox.Show("No Item to be transferred on the list.");
				btnItemSearch.Focus();
				return;
			}
			
			int grdCount = 0;
			int iii = 0;
			TranDr = new PDSA.DataLayer.DataClasses.PDSATransaction();
			TranDr.AfterSubmit += TranDr_AfterSubmit;
			TranDr.BeforeSubmit += TranDr_BeforeSubmit;
			mgrdrheader = new transfer_hdrManager(); // Transfer_hdr
			mgrdrheader.DataObject.TransactionType = PDSATransactionType.Insert;
			try
			{
				
				mgrdrheader.Entity.tdate = DateTime.Parse(dedlvrydate.Text);
				mgrdrheader.Entity.locid = System.Convert.ToInt32(leLocation.EditValue);
				mgrdrheader.Entity.dtInsertdt = DateTime.Now;
				mgrdrheader.Entity.dtLastUpdatedt = DateTime.Now;
				mgrdrheader.Entity.tamnt = decimal.Parse(txtsum.Text);
				mgrdrheader.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				
				TranDr.Add(mgrdrheader.DataObject);
				
				//save trasfer_det on the grid
				grdCount = drgrid.Rows.Count;
				for (iii = 0; iii <= grdCount - 1; iii++)
				{
					mgrdrdetail = new transfer_detManager();
					mgrdrdetail.DataObject.TransactionType = PDSATransactionType.Insert;
					mgrdrdetail.Entity.tid = mdrId;
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
					
					mgrdrdetail.Entity.price = System.Convert.ToDecimal(drgrid.Rows[iii].Cells[3].Value);
					mgrdrdetail.Entity.tamnt = System.Convert.ToDecimal(drgrid.Rows[iii].Cells[4].Value);
					TranDr.Add(mgrdrdetail.DataObject);
				}
				TranDr.Execute();
				
				PDSA.DataLayer.DataClasses.PDSATransaction TranSpTrans = new PDSA.DataLayer.DataClasses.PDSATransaction();
				spTransferProcManager mgrspDrTrans = new spTransferProcManager();
				
				mgrspDrTrans.Entity.tid = mdrId;
				TranSpTrans.Add(mgrspDrTrans.DataObject);
				TranSpTrans.Execute();
				MessageBox.Show("Transfer Stocks Transaction Successfully Posted.");
				InitCtrls();
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
			//btnRetrieve.Enabled = False
			//btnSave.Enabled = False
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
			//btnRetrieve.Enabled = True
			//btnSave.Enabled = True
			btnNew.Enabled = false;
		}
		
		public void InitCtrls()
		{
			ceQty.Value = 0;
			ceCost.Value = 0;
			txtItem.Text = string.Empty;
			drgrid.Rows.Clear();
		}
		
		public void drgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
