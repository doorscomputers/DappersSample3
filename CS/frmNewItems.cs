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
	public partial class frmNewItems
	{
		public frmNewItems()
		{
			InitializeComponent();
		}
		stocksManager mgrstock;
		//Dim colStocks As stocksCollection
		PDSA.DataLayer.DataClasses.PDSATransaction trans;
		
		public void frmNewItems_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmNewItems_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (btnSave.Enabled == true)
			{
				MessageBox.Show("There is a pending data entry,Save or Cancel before Closing.");
				e.Cancel = true;
			}
		}
		
		public void frmNewItems_Load(object sender, EventArgs e)
		{
			btnNew.Focus();
			DisableCtrols();
			btnSave.Enabled = false;
			btnCancel.Enabled = false;
			this.Cursor = Cursors.WaitCursor;
			LoadSupplier();
			LoadCategory();
			LoadBrand();
			LoadType();
			this.Cursor = Cursors.Default;
			
		}
		
		public void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public void InitControls()
		{
			txtBarcode.Text = string.Empty;
			txtItem.Text = string.Empty;
			//leSuppliers.Text = String.Empty
			//leCategories.Text = String.Empty
			//leBrand.Text = String.Empty
			//leType.Text = String.Empty
			ceCost.Value = 0;
			ceRetail.Value = 0;
			ceWholesale.Value = 0;
			ceMin.Value = 0;
			ceMax.Value = 0;
			compmup1.Value = 0;
			compmup2.Text = "0";
			compretail.Text = "0";
			compwholesale.Value = 0;
		}
		
		private void EnableCtrols()
		{
			btnNew.Enabled = false;
			btnClose.Enabled = false;
			btnSave.Enabled = true;
			btnCancel.Enabled = true;
			txtBarcode.Enabled = true;
			txtItem.Enabled = true;
			leSuppliers.Enabled = true;
			leCategories.Enabled = true;
			leBrand.Enabled = true;
			leType.Enabled = true;
			ceCost.Enabled = true;
			ceRetail.Enabled = true;
			ceWholesale.Enabled = true;
			ceMin.Enabled = true;
			ceMax.Enabled = true;
			GroupControl1.Enabled = true;
			
		}
		
		private void DisableCtrols()
		{
			btnNew.Enabled = true;
			btnClose.Enabled = true;
			btnSave.Enabled = true;
			btnCancel.Enabled = true;
			txtBarcode.Enabled = false;
			txtItem.Enabled = false;
			leSuppliers.Enabled = false;
			leCategories.Enabled = false;
			leBrand.Enabled = false;
			leType.Enabled = false;
			ceCost.Enabled = false;
			ceRetail.Enabled = false;
			ceWholesale.Enabled = false;
			ceMin.Enabled = false;
			ceMax.Enabled = false;
			btnClose.Enabled = false;
			GroupControl1.Enabled = false;
		}
		private void ClearCtrls()
		{
			txtBarcode.Text = string.Empty;
			txtItem.Text = string.Empty;
			ceCost.Value = 0;
			ceRetail.Value = 0;
			ceWholesale.Value = 0;
			ceMin.Value = 0;
			ceMax.Value = 0;
		}
		public void btnNew_Click(object sender, EventArgs e)
		{
			EnableCtrols();
			InitControls();
			txtBarcode.Focus();
		}
		public void btnSave_Click(object sender, EventArgs e)
		{
			if (leSuppliers.Text == string.Empty)
			{
				MessageBox.Show("Wholesale must be greater than Zero.");
			}
			
			//Enable this check if the client wants to have a wholesale validation
			//If ceWholesale.Value <= 0 Then
			//    MessageBox.Show("Wholesale must be greater than Zero.")
			//    ceWholesale.Focus()
			//    Exit Sub
			//End If
			if (ceRetail.Value <= 0)
			{
				MessageBox.Show("Retail Must be greater than Zero.");
				ceRetail.Focus();
				return;
			}
			if (ceCost.Value <= 0)
			{
				MessageBox.Show("Cost must be Greater than Zero");
				ceCost.Focus();
				return;
			}
			
			if (txtItem.Text == string.Empty)
			{
				MessageBox.Show("Item Description Must not be Blank");
				txtItem.Focus();
				return;
			}
			
			if (txtBarcode.Text == string.Empty)
			{
				MessageBox.Show("Item Code Must not be Blank");
				txtBarcode.Focus();
				return;
			}
			else
			{
				
				try
				{
					trans = new PDSATransaction();
					mgrstock = new stocksManager();
					mgrstock.Entity.barcode = txtBarcode.Text.Trim();
					mgrstock.Entity.itemdesc = txtItem.Text.Trim();
					mgrstock.Entity.available = 0;
					mgrstock.Entity.beginvstock = 0;
					mgrstock.Entity.supcode = System.Convert.ToInt32(leSuppliers.EditValue);
					mgrstock.Entity.categoryid = System.Convert.ToInt32(leCategories.EditValue);
					mgrstock.Entity.cost = ceCost.Value;
					mgrstock.Entity.dept = System.Convert.ToInt32(leBrand.EditValue);
					//mgrstock.Entity.lastcost = 0
					//mgrstock.Entity.lastprice = 0
					//mgrstock.Entity.lastwholesale = 0
					mgrstock.Entity.markup = (int) compmup1.Value;
					mgrstock.Entity.markup2 = System.Convert.ToInt32(compmup2.EditValue);
					mgrstock.Entity.maximum = (int) ceMax.Value;
					mgrstock.Entity.minimum = (int) ceMin.Value;
					mgrstock.Entity.retail = ceRetail.Value;
					mgrstock.Entity.retail2 = ceWholesale.Value;
					mgrstock.Entity.sizeid = System.Convert.ToInt32(leType.EditValue);
					mgrstock.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					trans.Add(mgrstock.DataObject);
					trans.Execute();
					
					btnSave.Enabled = false;
					btnCancel.Enabled = false;
					btnClose.Enabled = true;
					btnNew.Enabled = true;
					btnNew.Focus();
					MessageBox.Show("New Item Successfully Saved", "New Item");
					
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
		
		public void btnCancel_Click(object sender, EventArgs e)
		{
			DisableCtrols();
			btnNew.Focus();
			btnSave.Enabled = false;
			btnCancel.Enabled = false;
			btnClose.Enabled = true;
			InitControls();
		}
		
		public void txtBarcode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (txtBarcode.Text != "")
				{
					try
					{
						stocksManager mgrbcode = new stocksManager();
						mgrbcode.DataObject.SelectFilter = stocksData.SelectFilters.ListBox;
						mgrbcode.DataObject.WhereFilter = stocksData.WhereFilters.barcode;
						mgrbcode.Entity.barcode = txtBarcode.Text.Trim();
						mgrbcode.DataObject.Load();
						if (mgrbcode.DataObject.RowsAffected > 0)
						{
							MessageBox.Show("Barocde Already exist", "Duplicate Barcode found");
							//txtBarcode.Text = ""
							txtBarcode.Focus();
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
			}
		}
		
		public void txtBarcode_Layout(object sender, LayoutEventArgs e)
		{
			
		}
		
		public void txtBarcode_LostFocus(object sender, EventArgs e)
		{
			
		}
		
		public void txtItem_LostFocus(object sender, EventArgs e)
		{
			if (txtItem.Text.Trim() != "")
			{
				try
				{
					stocksManager mgrdesc = new stocksManager();
					mgrdesc.DataObject.SelectFilter = stocksData.SelectFilters.All;
					mgrdesc.DataObject.WhereFilter = stocksData.WhereFilters.items;
					mgrdesc.Entity.itemdesc = txtItem.Text.Trim();
					mgrdesc.DataObject.Load();
					if (mgrdesc.DataObject.RowsAffected > 0)
					{
						MessageBox.Show("Item Description Already exist", "Duplicate Item Description found");
						txtItem.Focus();
						
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
		}
		
		private void LoadSupplier()
		{
			suppliersManager mgrs = new suppliersManager();
			mgrs.DataObject.OrderByFilter = suppliersData.OrderByFilters.supplier;
			suppliersCollection cols = mgrs.BuildCollection();
			leSuppliers.Properties.DisplayMember = "supplier";
			leSuppliers.Properties.ValueMember = "supcode";
			leSuppliers.Properties.DataSource = cols;
			
		}
		private void LoadCategory()
		{
			categoriesManager mgrcat = new categoriesManager();
			mgrcat.DataObject.OrderByFilter = categoriesData.OrderByFilters.catgory;
			categoriesCollection colscat = mgrcat.BuildCollection();
			leCategories.Properties.DisplayMember = "catgory";
			leCategories.Properties.ValueMember = "categoryid";
			leCategories.Properties.DataSource = colscat;
		}
		
		private void LoadBrand()
		{
			deptManager mgrbrand = new deptManager();
			//mgrbrand.DataObject.OrderByFilter = deptData.OrderByFilters.DEPT
			deptCollection colsdept = mgrbrand.BuildCollection();
			leBrand.Properties.DisplayMember = "DEPTD";
			leBrand.Properties.ValueMember = "deptid";
			leBrand.Properties.DataSource = colsdept;
		}
		
		private void LoadType()
		{
			wsizeManager mgrsize = new wsizeManager();
			mgrsize.DataObject.OrderByFilter = wsizeData.OrderByFilters.sayz;
			wsizeCollection cols = mgrsize.BuildCollection();
			leType.Properties.DisplayMember = "sayz";
			leType.Properties.ValueMember = "sizeid";
			leType.Properties.DataSource = cols;
		}
		
		private void CheckRetail()
		{
			if (ceCost.Value >= 0.1 & ceRetail.Value >= 0.1)
			{
				if (ceRetail.Value <= ceCost.Value)
				{
					MessageBox.Show("Retail Amount Must be Higher than the Cost", "Retail Amount Error");
					ceRetail.Value = 0;
					return;
				}
			}
		}
		private void CheckWholesale()
		{
			if (ceWholesale.Value >= 0.1 & ceRetail.Value >= 0.1)
			{
				if (ceWholesale.Value <= ceCost.Value || ceWholesale.Value >= ceRetail.Value)
				{
					MessageBox.Show("Wholesale Must be Higher than the Cost and Lesser than the Retail", "Wholesale Amount Error");
					ceWholesale.Value = 0;
					return;
				}
			}
		}
		public void ceRetail_LostFocus(object sender, EventArgs e)
		{
			CheckRetail();
		}
		public void ceWholesale_LostFocus(object sender, EventArgs e)
		{
			CheckWholesale();
		}
		
		public void compmup1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				if (ceCost.Value > 0)
				{
					compretail.Text = (ceCost.Value + (ceCost.Value * (compmup1.Value / 100))).ToString();
					ceRetail.Value = ceCost.Value + (ceCost.Value * (compmup1.Value / 100));
				}
			}
		}
		
		public void compwholesale_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				if (ceCost.Value > 0)
				{
					compmup2.EditValue = ((compwholesale.Value - ceCost.Value) * 100) / ceCost.Value;
					
				}
			}
		}
		
		
		
		
		public void txtBarcode_EditValueChanged(object sender, EventArgs e)
		{
			
		}
	}
}
