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
	public partial class frmBackorder
	{
		public frmBackorder()
		{
			InitializeComponent();
		}
		stocksManager mgr8;
		
		public void frmBackorder_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmBackorder_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (btnSave.Enabled == true)
			{
				e.Cancel = true;
				MessageBox.Show("Save or Cancel the Entry First Before Closing the Form.");
			}
		}
		
		public void frmBackorder_Load(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			LoadSupplier();
			
			this.Cursor = Cursors.Default;
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
		
		public void btnItemSearch_Click(object sender, EventArgs e)
		{
			frmItemSearch frmitemserch = new frmItemSearch();
			frmitemserch.ShowDialog();
			txtItem.Text = string.Empty;
			txtStckId.Text = string.Empty;
			txtItem.Text = frmitemserch.vItem.ToString();
			txtStckId.Text = frmitemserch.vStckid.ToString();
			if (txtStckId.Text == string.Empty)
			{
				return;
			}
			else
			{
				ItemsearchExecute();
			}
			ceQty.Focus();
		}
		
		private void ItemsearchExecute()
		{
			stocksCollection col2;
			int nStckid = 0;
			try
			{
				mgr8 = new stocksManager();
				mgr8.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey;
				mgr8.DataObject.Entity.stckid = int.Parse(txtStckId.Text);
				col2 = mgr8.BuildCollection();
				if (mgr8.DataObject.RowsAffected > 0)
				{
					nStckid = mgr8.DataObject.Entity.stckid;
					txtPrice.Text = Strings.FormatNumber((mgr8.DataObject.Entity.cost).ToString(), 2, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault, (Microsoft.VisualBasic.TriState) Microsoft.VisualBasic.TriState.UseDefault);
					ceQty.Focus();
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
		
		public void btnSave_Click(object sender, EventArgs e)
		{
			if (txtItem.Text == string.Empty)
			{
				MessageBox.Show("Please select an item to be returned.");
				txtItem.Focus();
				return;
			}
			
			if (ceQty.Value <= 0)
			{
				MessageBox.Show("Please enter the number of items to be returned.");
				ceQty.Focus();
				return;
			}
			
			if (deBoDate.Text == string.Empty)
			{
				MessageBox.Show("Please enter the date the item was returned.");
				deBoDate.Focus();
				return;
			}
			
			if (leSupplier.Text == string.Empty)
			{
				MessageBox.Show("Please select the supplier of the item to be returned.");
				leSupplier.Focus();
				return;
			}
			
			
			PDSATransaction TranBo = new PDSATransaction();
			boManager mgrbo = new boManager();
			
			try
			{
				mgrbo.DataObject.TransactionType = PDSATransactionType.Insert;
				mgrbo.DataObject.Entity.amnt = 0;
				mgrbo.DataObject.Entity.bodate = DateTime.Parse(deBoDate.Text);
				mgrbo.DataObject.Entity.prevavlbl = 0;
				mgrbo.DataObject.Entity.price = 0;
				mgrbo.DataObject.Entity.qty = (int) ceQty.Value;
				mgrbo.DataObject.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				mgrbo.DataObject.Entity.sLastUpdateid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				mgrbo.DataObject.Entity.stckid = int.Parse(txtStckId.Text.Trim());
				mgrbo.DataObject.Entity.supcode = System.Convert.ToInt32(leSupplier.EditValue);
				TranBo.Add(mgrbo.DataObject);
				
				spBackOrderManager mgrspBo = new spBackOrderManager();
				mgrspBo.Entity.StckIid = int.Parse(txtStckId.Text);
				TranBo.Add(mgrspBo.DataObject);
				
				TranBo.Execute();
				DisableControls();
				MessageBox.Show("Back Order Entry Successfully Saved", "Saved");
				InitControls();
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
		
		private void EnableControls()
		{
			btnSave.Enabled = true;
			btnCancel.Enabled = true;
			GroupControl1.Enabled = true;
			btnClose.Enabled = false;
			btnNew.Enabled = false;
			deBoDate.Focus();
		}
		
		private void DisableControls()
		{
			btnSave.Enabled = false;
			btnCancel.Enabled = false;
			GroupControl1.Enabled = false;
			btnClose.Enabled = true;
			btnNew.Enabled = true;
			btnNew.Focus();
		}
		
		private void InitControls()
		{
			deBoDate.EditValue = DateAndTime.Today;
			txtItem.Text = "";
			txtStckId.Text = "";
			txtPrice.Text = "";
			ceQty.Value = 0;
		}
		
		public void btnCancel_Click(object sender, EventArgs e)
		{
			DisableControls();
			InitControls();
		}
		
		public void btnNew_Click(object sender, EventArgs e)
		{
			EnableControls();
			InitControls();
		}
		
		public void ceQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				btnSave.Focus();
			}
		}
		
	}
}
