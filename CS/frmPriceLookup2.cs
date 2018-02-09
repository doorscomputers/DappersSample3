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
	public partial class frmPriceLookup2
	{
		public frmPriceLookup2()
		{
			InitializeComponent();
		}
		public string vItem = string.Empty;
		public int vStckid = 0;
		public decimal vPrice = 0;
		public decimal vWPrice = 0;
		public string vbocde = string.Empty;
		private PDSA.DataLayer.DataClasses.PDSATransaction TranspDelstock;
		public void btnSearch_Click(object sender, EventArgs e)
		{
			
			DelItems();
			
			LoadItems();
			
			//txtitem.Focus()
			//txtitem.SelectAll()
		}
		public void DelItems()
		{
			//Dim TranspDelStock As New PDSATransaction()
			//Dim mgrdelitem As spDelposstocksManager
			
			//Try
			
			//    mgrdelitem = New spDelposstocksManager()
			//    mgrdelitem.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
			//    TranspDelStock.Add(mgrdelitem.DataObject)
			//    TranspDelStock.Execute()
			//Catch ex As PDSAValidationException
			//    '    MessageBox.Show(ex.Message)
			//Catch ex As Exception
			//    MessageBox.Show(ex.ToString())
			//End Try
			TranspDelstock = new PDSA.DataLayer.DataClasses.PDSATransaction();
			posstocksManager mgrdelitem = new posstocksManager();
			try
			{
				mgrdelitem.DataObject.TransactionType = PDSATransactionType.Delete;
				mgrdelitem.DataObject.SelectFilter = posstocksData.SelectFilters.All;
				mgrdelitem.DataObject.DeleteFilter = posstocksData.DeleteFilters.DeleteByUserID;
				mgrdelitem.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				TranspDelstock.Add(mgrdelitem.DataObject);
				TranspDelstock.Execute();
				
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
		public void LoadItems()
		{
			if (txtitem.Text == string.Empty)
			{
				MessageBox.Show("Enter an item description to seaarch.");
				txtitem.Focus();
				return;
			}
			else
			{
				PDSA.DataLayer.DataClasses.PDSATransaction TranspStock = new PDSA.DataLayer.DataClasses.PDSATransaction();
				spStocksManager mgrloaditem = default(spStocksManager);
				
				try
				{
					
					mgrloaditem = new spStocksManager();
					mgrloaditem.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					mgrloaditem.Entity.itemdesc = txtitem.Text.Trim();
					TranspStock.Add(mgrloaditem.DataObject);
					TranspStock.Execute();
					
					posstocksManager mgritem = new posstocksManager();
					posstocksCollection cols = default(posstocksCollection);
					mgritem.DataObject.WhereFilter = posstocksData.WhereFilters.cashier;
					mgritem.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					mgritem.Entity.itemdesc = txtitem.Text.Trim();
					mgritem.DataObject.OrderByFilter = posstocksData.OrderByFilters.item_desc;
					cols = mgritem.BuildCollection();
					if (mgritem.DataObject.RowsAffected > 0)
					{
						dgitems.DataSource = cols;
						dgitems.Columns[0].Visible = false;
						dgitems.Columns[5].Visible = false;
						dgitems.Columns[6].Visible = false;
						dgitems.Columns[7].Visible = false;
						dgitems.Columns[8].Visible = false;
						dgitems.Columns[1].Width = 500;
						dgitems.Columns[1].HeaderText = "Item Description";
						dgitems.Columns[2].HeaderText = "Available";
						dgitems.Columns[3].HeaderText = "Retail Price";
						dgitems.Columns[4].HeaderText = "Whole Sale";
						dgitems.Columns[2].Width = 100;
						dgitems.Columns[3].Width = 150;
						dgitems.Columns[4].Width = 150;
						txtfilter.Enabled = true;
						btnFilter.Enabled = true;
						dgitems.Focus();
					}
					else
					{
						MessageBox.Show("No item(s) related to the search criteria!");
						txtitem.Focus();
						txtitem.SelectAll();
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
		public void LoadItemsbyBarcode()
		{
			if (txtBarcode.Text == string.Empty)
			{
				MessageBox.Show("Barcode is Blank, Scan another or proceed to Item Search");
				txtitem.Focus();
				return;
			}
			else
			{
				
				//Dim mgrloaditembc As vwStocksManager
				
				try
				{
					
					vwStocksLookupManager mgritems = new vwStocksLookupManager();
					vwStocksLookupCollection colss = default(vwStocksLookupCollection);
					mgritems.DataObject.WhereFilter = vwStocksLookupData.WhereFilters.barcode;
					mgritems.Entity.barcode = txtBarcode.Text.Trim();
					mgritems.DataObject.OrderByFilter = vwStocksLookupData.OrderByFilters.barcode;
					colss = mgritems.BuildCollection();
					if (mgritems.DataObject.RowsAffected > 0)
					{
						dgitems.DataSource = colss;
						//dgitems.Columns(0).Visible = False
						dgitems.Columns[5].Visible = false;
						dgitems.Columns[6].Visible = false;
						dgitems.Columns[7].Visible = false;
						//dgitems.Columns(8).Visible = False
						dgitems.Columns[0].Width = 160;
						dgitems.Columns[1].Width = 380;
						dgitems.Columns[0].HeaderText = "Barcode";
						dgitems.Columns[1].HeaderText = "Item Description";
						dgitems.Columns[2].HeaderText = "Available";
						dgitems.Columns[3].HeaderText = "Retail Price";
						dgitems.Columns[4].HeaderText = "Whole Sale";
						dgitems.Columns[2].Width = 100;
						dgitems.Columns[3].Width = 135;
						dgitems.Columns[4].Width = 135;
						
						this.dgitems.Columns["retail"].DefaultCellStyle.Format = "c";
						this.dgitems.Columns["retail2"].DefaultCellStyle.Format = "c";
						this.dgitems.Columns["retail"].DefaultCellStyle.Alignment = 
							DataGridViewContentAlignment.MiddleRight;
						this.dgitems.Columns["retail2"].DefaultCellStyle.Alignment = 
							DataGridViewContentAlignment.MiddleRight;
						this.dgitems.Columns["Available"].DefaultCellStyle.Alignment = 
							DataGridViewContentAlignment.MiddleRight;
						//.DefaultCellStyle.NullValue = "no entry"
						this.dgitems.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
						this.dgitems.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
						this.dgitems.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
						this.dgitems.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
						
						
						
						//dgitems.Columns(5).Width = 0
						//txtfilter.Enabled = True
						//btnFilter.Enabled = True
						//dgitems.Focus()
						txtBarcode.Focus();
						txtBarcode.SelectAll();
					}
					else
					{
						MessageBox.Show("No item(s) related to the search criteria!");
						txtitem.Focus();
						txtitem.SelectAll();
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
		public void SearchItems2()
		{
			if (txtitem.Text == string.Empty)
			{
				MessageBox.Show("Enter an item description to seaarch.");
				txtitem.Focus();
				return;
			}
			else
			{
				
				posstocksManager mgritem = default(posstocksManager);
				posstocksCollection cols = default(posstocksCollection);
				try
				{
					mgritem = new posstocksManager();
					mgritem.DataObject.SelectFilter = posstocksData.SelectFilters.All;
					mgritem.DataObject.WhereFilter = posstocksData.WhereFilters.Likeitem_desc;
					mgritem.Entity.itemdesc = txtfilter.Text.Trim();
					mgritem.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					mgritem.DataObject.OrderByFilter = posstocksData.OrderByFilters.item_desc;
					cols = mgritem.BuildCollection();
					if (mgritem.DataObject.RowsAffected > 0)
					{
						dgitems.DataSource = cols;
						dgitems.Columns[0].Visible = false;
						dgitems.Columns[5].Visible = false;
						dgitems.Columns[6].Visible = false;
						dgitems.Columns[7].Visible = false;
						dgitems.Columns[8].Visible = false;
						dgitems.Columns[1].Width = 500;
						dgitems.Columns[1].HeaderText = "Item Description";
						dgitems.Columns[2].HeaderText = "Available";
						dgitems.Columns[3].HeaderText = "Retail Price";
						dgitems.Columns[4].HeaderText = "Whole Sale";
						dgitems.Columns[2].Width = 100;
						dgitems.Columns[3].Width = 150;
						dgitems.Columns[4].Width = 150;
						dgitems.Focus();
					}
					else
					{
						MessageBox.Show("No item(s) related to the search criteria!");
						txtitem.Focus();
						txtitem.SelectAll();
					}
					
				}
				catch (PDSA.Validation.PDSAValidationException)
				{
					//    MessageBox.Show(ex.Message)
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		public void SearchItems()
		{
			if (txtitem.Text == string.Empty)
			{
				MessageBox.Show("Enter an item description to seaarch.");
				txtitem.Focus();
				return;
			}
			else
			{
				
				stocksManager mgritem = default(stocksManager);
				stocksCollection cols = default(stocksCollection);
				try
				{
					mgritem = new stocksManager();
					mgritem.DataObject.SelectFilter = stocksData.SelectFilters.positems;
					//mgritem.DataObject.WhereFilter = stocksData.WhereFilters.Likebarcode
					mgritem.DataObject.WhereFilter = stocksData.WhereFilters.likeitem;
					mgritem.Entity.itemdesc = txtitem.Text.Trim();
					mgritem.DataObject.OrderByFilter = stocksData.OrderByFilters.itemdesc;
					cols = mgritem.BuildCollection();
					if (mgritem.DataObject.RowsAffected > 0)
					{
						dgitems.DataSource = cols;
						dgitems.Columns[0].Visible = false;
						dgitems.Columns[1].Visible = false;
						//dgitems.Columns(1).Width = 500
						dgitems.Columns[2].HeaderText = "Item Description";
						dgitems.Columns[3].HeaderText = "Available";
						dgitems.Columns[4].HeaderText = "Retail Price";
						dgitems.Columns[8].HeaderText = "Whole Sale";
						dgitems.Columns[2].Width = 500;
						dgitems.Columns[3].Width = 300;
						//dgitems.Columns(4).Width = 400
						dgitems.Columns[4].Visible = false;
						dgitems.Columns[5].Visible = false;
						dgitems.Columns[6].Visible = false;
						//dgitems.Columns(7).Visible = False
						dgitems.Columns[8].Visible = false;
						dgitems.Columns[9].Visible = false;
						dgitems.Columns[10].Visible = false;
						dgitems.Columns[11].Visible = false;
						
						dgitems.Columns[13].Visible = false;
						dgitems.Columns[14].Visible = false;
						dgitems.Columns[15].Visible = false;
						dgitems.Columns[16].Visible = false;
						dgitems.Columns[17].Visible = false;
						dgitems.Columns[18].Visible = false;
						dgitems.Columns[19].Visible = false;
						dgitems.Columns[20].Visible = false;
						dgitems.Columns[21].Visible = false;
						dgitems.Columns[22].Visible = false;
						dgitems.Columns[23].Visible = false;
						dgitems.Columns[24].Visible = false;
						dgitems.Columns[25].Visible = false;
						dgitems.Columns[26].Visible = false;
						dgitems.Columns[27].Visible = false;
						dgitems.Columns[28].Visible = false;
						dgitems.Columns[29].Visible = false;
						dgitems.Columns[30].Visible = false;
						dgitems.Columns[31].Visible = false;
						dgitems.Columns[32].Visible = false;
						dgitems.Focus();
					}
					else
					{
						MessageBox.Show("No item(s) related to the search criteria!");
						txtitem.Focus();
						txtitem.SelectAll();
					}
					
				}
				catch (PDSA.Validation.PDSAValidationException)
				{
					//    MessageBox.Show(ex.Message)
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		public void txtitem_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				dgitems.Focus();
			}
			if (e.KeyCode == Keys.Right)
			{
				btnSearch.Focus();
			}
		}
		public void txtitem_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				DelItems();
				LoadItems();
			}
		}
		
		public void frmPriceLookup2_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmPriceLookup2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
		public void frmPriceLookup2_Load(object sender, EventArgs e)
		{
			txtitem.Focus();
		}
		
		public void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void btnItem_Click(object sender, EventArgs e)
		{
			txtitem.Focus();
			txtitem.SelectAll();
		}
		
		public void btnFilter_Click(object sender, EventArgs e)
		{
			txtfilter.Focus();
			txtfilter.SelectAll();
		}
		
		public void txtfilter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SearchItems2();
			}
		}
		
		public void Button1_Click(object sender, EventArgs e)
		{
			txtBarcode.Focus();
			txtBarcode.SelectAll();
		}
		
		public void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				LoadItemsbyBarcode();
			}
		}
		
		public void txtBarcode_EditValueChanged(object sender, EventArgs e)
		{
			
		}
		
		public void txtitem_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}