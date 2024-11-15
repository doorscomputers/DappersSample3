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
	public partial class frmManualInv
	{
		public frmManualInv()
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
				ceQty.Focus();
			}
			ceQty.Focus();
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
			
			if (ceQty.Value < 0)
			{
				MessageBox.Show("Please enter the number of items counted.");
				ceQty.Focus();
				return;
			}
			
			if (deBoDate.Text == string.Empty)
			{
				MessageBox.Show("Please enter the date the item was counted.");
				deBoDate.Focus();
				return;
			}
			
			
			PDSATransaction TranMI = new PDSATransaction();
			InvntoryManager mgrMI = new InvntoryManager();
			
			try
			{
				mgrMI.DataObject.TransactionType = PDSATransactionType.Insert;
				mgrMI.DataObject.Entity.amnt = 0;
				//mgrMI.DataObject.Entity.amnt = 0
				mgrMI.DataObject.Entity.prevavlbl = 0; //frmItemSearch.vAvlbl
				mgrMI.DataObject.Entity.midate = DateTime.Parse(deBoDate.Text);
				mgrMI.DataObject.Entity.qty = (int) ceQty.Value;
				mgrMI.DataObject.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				mgrMI.DataObject.Entity.sLastUpdateid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				mgrMI.DataObject.Entity.stckid = int.Parse(txtStckId.Text.Trim());
				
				TranMI.Add(mgrMI.DataObject);
				
				spInvntoryManager mgrspInv = new spInvntoryManager();
				mgrspInv.Entity.StckIid = int.Parse(txtStckId.Text);
				TranMI.Add(mgrspInv.DataObject);
				
				TranMI.Execute();
				DisableControls();
				MessageBox.Show("Manual Inventory Entry Successfully Saved", "Saved");
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
		
		public void ceQty_KeyPress(object sender, KeyPressEventArgs e)
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
			txtStckId.Text = "";
			ceQty.Value = 0;
		}
		
		public void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
	}
}
