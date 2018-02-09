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
	public partial class frmConvertStocks
	{
		public frmConvertStocks()
		{
			InitializeComponent();
		}
		private PDSA.DataLayer.DataClasses.PDSATransaction TranBo;
		stocksManager mgr8;
		int mOrderId = 0;
		PDSA.DataLayer.DataClasses.PDSATransaction Tran2;
		PDSA.DataLayer.DataClasses.PDSATransaction Tran3;
		public void frmConvertStocks_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmConvertStocks_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (btnSave.Enabled == true)
			{
				e.Cancel = true;
				MessageBox.Show("Save or Cancel the Conversion of Items First Before Closing the Form.");
			}
		}
		
		public void frmConvertStocks_Load(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			
			
			this.Cursor = Cursors.Default;
		}
		
		public void btnItemSearch_Click(object sender, EventArgs e)
		{
			frmItemSearch frmitemserch = new frmItemSearch();
			frmitemserch.ShowDialog();
			txtItem.Text = string.Empty;
			txtStckId.Text = string.Empty;
			txtItem.Text = frmitemserch.vItem.ToString();
			txtStckId.Text = frmitemserch.vStckid.ToString();
			ceInner.Value = frmitemserch.vInnerQty;
			ceAvlbl.Value = frmitemserch.vAvlbl;
			
			if (txtStckId.Text == string.Empty)
			{
				return;
			}
			else
			{
				ItemsearchExecute();
			}
			btnItemsearch2.Focus();
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
					//txtPrice.Text = FormatNumber(CStr(mgr8.DataObject.Entity.cost), 2)
					ceQty.Focus();
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
		
		public void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void btnSave_Click(object sender, EventArgs e)
		{
			if (cePcs.Value <= 1)
			{
				MessageBox.Show("Cannot convert quantity");
				return;
			}
			if (ceQty.Value > ceAvlbl.Value)
			{
				MessageBox.Show("Quantity to be converted must not be greater than the available stock.");
				return;
			}
			if (txtItem.Text == string.Empty)
			{
				MessageBox.Show("Please select an item to be converted.");
				txtItem.Focus();
				return;
			}
			
			if (ceQty.Value <= 0)
			{
				MessageBox.Show("Please enter the number of items to be converted.");
				ceQty.Focus();
				return;
			}
			
			if (deBoDate.Text == string.Empty)
			{
				MessageBox.Show("Please enter the date the item was converted.");
				deBoDate.Focus();
				return;
			}
			
			if (ceInner.Value < 2)
			{
				MessageBox.Show("The Item Innerbox Qty is not valid and should be at least 2.");
				ceInner.Focus();
				return;
			}
			
			
			TranBo = new PDSA.DataLayer.DataClasses.PDSATransaction(); // did not change but the transaction is about converting items to pieces
			TranBo.AfterSubmit += TranBo_AfterSubmit;
			TranBo.BeforeSubmit += Tran_BeforeSubmit;
			Tran2 = new PDSA.DataLayer.DataClasses.PDSATransaction();
			Tran3 = new PDSA.DataLayer.DataClasses.PDSATransaction();
			convertstckManager mgrbo = new convertstckManager(); // mgrbo is just a variable but it is pertaining to the convertstck table
			
			try
			{
				mgrbo.DataObject.TransactionType = PDSATransactionType.Insert;
				mgrbo.DataObject.Entity.innerqty = (int) ceInner.Value;
				mgrbo.DataObject.Entity.condate = DateTime.Parse(deBoDate.Text);
				mgrbo.DataObject.Entity.fromstckid = int.Parse(txtStckId.Text);
				mgrbo.DataObject.Entity.tostckid = int.Parse(txtstckid2.Text);
				mgrbo.DataObject.Entity.fromqty = (int) ceQty.Value;
				mgrbo.DataObject.Entity.InsertedBy = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				mgrbo.DataObject.Entity.ModifiedBy = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				mgrbo.DataObject.Entity.InsertedOn = DateTime.Now;
				mgrbo.DataObject.Entity.toqty = (int) cePcs.Value;
				TranBo.Add(mgrbo.DataObject);
				TranBo.Execute();
				
				spConvertFirstManager mgrspBo = new spConvertFirstManager();
				mgrspBo.Entity.StckIid = int.Parse(txtStckId.Text);
				mgrspBo.Entity.Convertid = mOrderId;
				Tran2.Add(mgrspBo.DataObject);
				//TranBo.Add(mgrspBo.DataObject)
				
				spConvertsecondManager mgrspconsec = new spConvertsecondManager();
				mgrspconsec.Entity.StckIid = int.Parse(txtstckid2.Text);
				mgrspconsec.Entity.Convertid = mOrderId;
				Tran2.Add(mgrspconsec.DataObject);
				//TranBo.Add(mgrspconsec.DataObject)
				
				Tran2.Execute();
				//TranBo.Execute()
				DisableControls();
				MessageBox.Show("Conversion Entry Successfully Saved", "Saved");
				InitControls();
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
		private void TranBo_AfterSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			// Get the SQL Identity generated and store into local variable
			if (e.ClassName == "convertstckData")
			{
				mOrderId = ((convertstck) e.DataClassTable.EntityObject).convertid;
			}
		}
		
		private void Tran_BeforeSubmit(object sender, PDSA.DataLayer.DataClasses.PDSATransactionEventArgs e)
		{
			// Put local order id into line item objects prior to submitting INSERT statement
			if (e.ClassName == "convertstckData")
			{
				((convertstck) e.DataClassTable.EntityObject).convertid = mOrderId;
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
			txtitem2.Text = "";
			txtStckId.Text = "";
			txtstckid2.Text = "";
			ceQty.Value = 0;
			cePcs.Value = 0;
			ceAvlbl.Value = 0;
			
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
				if (ceInner.Value >= 2)
				{
					cePcs.Value = (int) (ceInner.Value * ceQty.Value);
					btnSave.Focus();
				}
				else
				{
					MessageBox.Show("Quantity must be at least greater than or equal to 2.Make sure the item to be converted is not a PC item");
				}
				
			}
		}
		
		public void btnItemsearch2_Click(object sender, EventArgs e)
		{
			frmItemSearch frmitemserch2 = new frmItemSearch();
			frmitemserch2.ShowDialog();
			txtitem2.Text = string.Empty;
			txtstckid2.Text = string.Empty;
			txtitem2.Text = frmitemserch2.vItem.ToString();
			txtstckid2.Text = frmitemserch2.vStckid.ToString();
			if (txtstckid2.Text == string.Empty)
			{
				return;
			}
			else
			{
				ItemsearchExecute();
			}
			ceQty.Focus();
		}
		
		public void ceQty_LostFocus(object sender, EventArgs e)
		{
			
			
		}
	}
}
