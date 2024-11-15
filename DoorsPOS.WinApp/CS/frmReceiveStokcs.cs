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
	public partial class frmReceiveStokcs
	{
		public frmReceiveStokcs()
		{
			InitializeComponent();
		}
		stocksManager mgr7;
		receive_hdrManager mgrdrheader; // receive_hdr
		receive_detManager mgrdrdetail; // receive_det
		decimal Totss = 0;
		private int mdrId = 0;
		private PDSA.DataLayer.DataClasses.PDSATransaction TranHdrtmp;
		private PDSA.DataLayer.DataClasses.PDSATransaction TranDr;
		
		public string vItem = string.Empty;
		public int vStckid = 0;
		public decimal vPrice = 0;
		public decimal vWPrice = 0;
		public string vbocde = string.Empty;
		public int vAvlbl = 0;
		public int vInnerQty = 0;
		
		public void frmReceiveStokcs_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmReceiveStokcs_FormClosing(object sender, FormClosingEventArgs e)
		{
			int vRows = drgrid.Rows.Count;
			if (vRows > 0)
			{
				MessageBox.Show("Receive List still Exist. Please Save/Post or Click New before closing the receive Entry Form.");
				e.Cancel = true;
			}
		}
		public void frmReceiveStokcs_Load(object sender, EventArgs e)
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
				MessageBox.Show("Qty to be Received cannot be less than or equal to zero");
				ceQty.Focus();
				return;
			}
			else
			{
				SendItemtoGrid();
				//btnItemSearch.Focus()
				txtItem.Focus();
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
				MessageBox.Show("Qty Received cannot be equal or less than zero");
				
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
			if (e.ClassName == "receive_hdrData") // receive_hdr
			{
				mdrId = ((receive_hdr) e.DataClassTable.EntityObject).rid;
			}
		}
		
		private void TranDr_BeforeSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			// Put local order id into line item objects prior to submitting INSERT statement
			if (e.ClassName == "receive_detData") // receive_det
			{
				((receive_det) e.DataClassTable.EntityObject).rid = mdrId;
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
				MessageBox.Show("Identify the location where you are receiving the stock.");
				leLocation.Focus();
				return;
			}
			int ansint = 0;
			ansint = 7;
			ansint = (int) (Interaction.MsgBox("Please make sure All information entered are correct(Where to receive,Items,Date Received etc.) before clicking yes to Save!", MsgBoxStyle.YesNo, null));
			if (ansint == 7)
			{
				return;
			}
			
			if (drgrid.Rows.Count <= 0)
			{
				MessageBox.Show("No Item to be Received on the list.");
				btnItemSearch.Focus();
				return;
			}
			
			int grdCount = 0;
			int iii = 0;
			TranDr = new PDSA.DataLayer.DataClasses.PDSATransaction();
			TranDr.AfterSubmit += TranDr_AfterSubmit;
			TranDr.BeforeSubmit += TranDr_BeforeSubmit;
			mgrdrheader = new receive_hdrManager(); // receive_hdr
			mgrdrheader.DataObject.TransactionType = PDSATransactionType.Insert;
			try
			{
				
				mgrdrheader.Entity.rdate = DateTime.Parse(dedlvrydate.Text);
				mgrdrheader.Entity.locid = System.Convert.ToInt32(leLocation.EditValue);
				mgrdrheader.Entity.dtInsertdt = DateTime.Now;
				mgrdrheader.Entity.dtLastUpdatedt = DateTime.Now;
				mgrdrheader.Entity.ramnt = decimal.Parse(txtsum.Text);
				mgrdrheader.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				
				TranDr.Add(mgrdrheader.DataObject);
				
				//save trasfer_det on the grid
				grdCount = drgrid.Rows.Count;
				for (iii = 0; iii <= grdCount - 1; iii++)
				{
					mgrdrdetail = new receive_detManager();
					mgrdrdetail.DataObject.TransactionType = PDSATransactionType.Insert;
					mgrdrdetail.Entity.rid = mdrId;
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
					mgrdrdetail.Entity.ramnt = System.Convert.ToDecimal(drgrid.Rows[iii].Cells[4].Value);
					TranDr.Add(mgrdrdetail.DataObject);
				}
				TranDr.Execute();
				
				PDSA.DataLayer.DataClasses.PDSATransaction TranSpTrans = new PDSA.DataLayer.DataClasses.PDSATransaction();
				spReceiveProcManager mgrspDrTrans = new spReceiveProcManager();
				
				mgrspDrTrans.Entity.rid = mdrId;
				TranSpTrans.Add(mgrspDrTrans.DataObject);
				TranSpTrans.Execute();
				MessageBox.Show("Received Stocks Transaction Successfully Posted.");
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
			txtItem.Enabled = false;
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
			txtItem.Enabled = true;
		}
		
		public void InitCtrls()
		{
			ceQty.Value = 0;
			ceCost.Value = 0;
			txtItem.Text = string.Empty;
			drgrid.Rows.Clear();
		}
		
		public void txtItem_KeyDown(object sender, KeyEventArgs e)
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
				txtItem.Focus();
				txtItem.SelectAll();
				
				e.SuppressKeyPress = true;
			}
		}
		
		public void txtItem_KeyPress(object sender, KeyPressEventArgs e)
		{
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
					txtItem.Text = vItem.ToString();
					txtbcodes.Text = vbocde.ToString();
					//txtBarcode.Text = vbocde.ToString
					txtStckid.Text = vStckid.ToString();
					
					//'txtBarcode.SelectAll()
					//If txtStckid.Text = String.Empty Then
					//    Exit Sub
					//Else
					//    ItemsearchExecute()
					//End If
					//txtitem.Focus()
					
					
					ceQty.Focus();
					dgitems.Visible = false;
					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				//e.SuppressKeyPress = True
			}
		}
		
		public void txtItem_KeyUp(object sender, KeyEventArgs e)
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
		
		public void txtItem_TextChanged(object sender, EventArgs e)
		{
			if (txtItem.Text == string.Empty)
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
					mgrloaditem.Entity.itemdesc = txtItem.Text.Trim();
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
						txtItem.Focus();
						
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
					txtItem.Text = vItem.ToString();
					txtbcodes.Text = vbocde.ToString();
					//txtBarcode.Text = vbocde.ToString
					txtStckid.Text = vStckid.ToString();
					
					if (txtStckid.Text == string.Empty)
					{
						return;
					}
					else
					{
						ItemsearchExecute();
					}
					
					
					
					// ''txtBarcode.SelectAll()
					//'If txtStckid.Text = String.Empty Then
					//'    Exit Sub
					//'Else
					//'    ItemsearchExecute()
					//'End If
					//'txtitem.Focus()
					
					dgitems.Visible = false;
					//ceQty.Focus()
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
				txtItem.Focus();
				txtItem.SelectAll();
				
				e.SuppressKeyPress = true;
			}
		}
		
		public void dgitems_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\u001B')
			{
				//DGRetrieve.Visible = False
				dgitems.Visible = false;
				txtItem.Focus();
			}
		}
		
		public void drgrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (drgrid.Rows.Count > 0)
			{
				try
				{
					
					decimal number;
					bool result = decimal.TryParse((drgrid.SelectedRows[0].Cells[2].Value).ToString(), out number);
					bool result2 = decimal.TryParse((drgrid.SelectedRows[0].Cells[4].Value).ToString(), out number);
					
					if (result && result2)
					{
						//Console.WriteLine("Converted '{0}' to {1}.", CStr(drgrid.SelectedRows.Item(0).Cells(5).Value), number)
						drgrid.SelectedRows[0].Cells[4].Value = (decimal.Parse((drgrid.SelectedRows[0].Cells[2].Value).ToString())) * decimal.Parse((drgrid.SelectedRows[0].Cells[3].Value).ToString());
						//If (dgvr.Cells(7).Value < dgvr.Cells(10).Value) Then
						//dgvr.DefaultCellStyle.ForeColor = Color.Red
						//End If
						if (System.Convert.ToInt32(drgrid.SelectedRows[0].Cells[2].Value) <= 0)
						{
							drgrid.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Red;
						}
						else
						{
							drgrid.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
						}
						
						if (System.Convert.ToDecimal(drgrid.SelectedRows[0].Cells[4].Value) <= 0)
						{
							drgrid.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Red;
						}
						else
						{
							drgrid.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
						}
						
						decimal Recompute = 0;
						int aii = 0;
						for (aii = 0; aii <= drgrid.Rows.Count - 1; aii++)
						{
							Recompute += System.Convert.ToDecimal(drgrid.Rows[aii].Cells[4].Value);
						}
						//CalcEdit1.Value = Totss
						txtsum.Text = Strings.FormatNumber(Recompute, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); //FormatNumber(CStr(Recompute))
						CheckSumifNegative();
						VarsModule.vpTotalSales = Recompute;
						
					}
					else
					{
						if ((drgrid.SelectedRows[0].Cells[4].Value).ToString() == null)
						{
							drgrid.SelectedRows[0].Cells[2].Value = 0;
						}
						MessageBox.Show("W A R N I N G !!!!!! Price or Qty Must be Greater than Zero", (drgrid.SelectedRows[0].Cells[4].Value).ToString());
						drgrid.SelectedRows[0].Cells[2].Value = 0;
						
						decimal Recomputes = 0;
						int aiii = 0;
						for (aiii = 0; aiii <= drgrid.Rows.Count - 1; aiii++)
						{
							Recomputes += System.Convert.ToDecimal(drgrid.Rows[aiii].Cells[4].Value);
						}
						
						txtsum.Text = Strings.FormatNumber(Recomputes, 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, TriState.True, TriState.True); // FormatNumber(CStr(Recomputes))
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
		
		private void CheckSumifNegative()
		{
			if (decimal.Parse(txtsum.Text) < 0)
			{
				txtsum.ForeColor = Color.Red;
			}
			else
			{
				txtsum.ForeColor = Color.Green;
			}
		}
		
	}
}
