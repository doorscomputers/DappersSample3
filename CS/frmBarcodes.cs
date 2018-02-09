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
	public partial class frmBarcodes
	{
		public frmBarcodes()
		{
			InitializeComponent();
		}
		stocksManager mgr9;
		
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
				txtBarcode.Focus();
			}
			txtBarcode.Focus();
		}
		
		public void frmManualInv_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		public void frmManualInv_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (btnSave.Enabled == true)
			{
				e.Cancel = true;
				MessageBox.Show("Save or Cancel the Entry First Before Closing the Form.");
			}
		}
		
		public void btnSave_Click(object sender, EventArgs e)
		{
			if (txtItem.Text == string.Empty)
			{
				MessageBox.Show("Please select the item counted.");
				txtItem.Focus();
				return;
			}
			if (txtBarcode.Text == string.Empty)
			{
				MessageBox.Show("New Barcode is Empty. Enter a New Barcode");
				txtBarcode.Focus();
				return;
			}
			
			if (deBoDate.Text == string.Empty)
			{
				MessageBox.Show("Please enter the date the item was counted.");
				deBoDate.Focus();
				return;
			}
			
			PDSATransaction tranBarcode = new PDSATransaction();
			tblBarcodesManager mgrBarcode = new tblBarcodesManager();
			try
			{
				mgrBarcode.DataObject.TransactionType = PDSATransactionType.Insert;
				mgrBarcode.DataObject.Entity.barcode = txtBarcode.Text;
				mgrBarcode.DataObject.Entity.dateadded = DateTime.Parse(deBoDate.Text);
				mgrBarcode.DataObject.Entity.stckid = int.Parse(txtStckId.Text.Trim());
				tranBarcode.Add(mgrBarcode.DataObject);
				tranBarcode.Execute();
				
				DisableControls();
				MessageBox.Show("New Barcode Successfully Saved", "Saved");
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
		
		private void ceQty_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				btnSave.Focus();
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
			txtStckId.Text = string.Empty;
			txtBarcode.Text = string.Empty;
		}
		
		public void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void txtBarcode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSave.Focus();
			}
		}
		
		public void txtBarcode_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
