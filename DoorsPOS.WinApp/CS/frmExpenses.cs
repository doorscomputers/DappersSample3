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
	public partial class frmExpenses
	{
		public frmExpenses()
		{
			InitializeComponent();
		}
		stocksManager mgr8;
		public void frmExpenses_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		
		public void frmExpenses_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (btnSave.Enabled == true)
			{
				e.Cancel = true;
				MessageBox.Show("Save or Cancel the Entry First Before Closing the Form.");
			}
		}
		
		public void frmExpenses_Load(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			LoadExpenses();
			
			this.Cursor = Cursors.Default;
		}
		
		private void LoadExpenses()
		{
			tblExpensesManager mgrs = new tblExpensesManager();
			mgrs.DataObject.OrderByFilter = tblExpensesData.OrderByFilters.expdesc;
			tblExpensesCollection cols = default(tblExpensesCollection);
			cols = mgrs.BuildCollection();
			leexpenses.Properties.DisplayMember = "expdesc";
			leexpenses.Properties.ValueMember = "expenseid";
			leexpenses.Properties.DataSource = cols;
		}
		
		public void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void EnableControls()
		{
			btnSave.Enabled = true;
			btnCancel.Enabled = true;
			GroupControl1.Enabled = true;
			btnClose.Enabled = false;
			btnNew.Enabled = false;
			deexpDate.Focus();
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
			deexpDate.EditValue = DateAndTime.Today;
			txtRemarks.Text = "";
			ceAmount.Value = 0;
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
		
		public void btnSave_Click(object sender, EventArgs e)
		{
			if (leexpenses.Text == string.Empty)
			{
				MessageBox.Show("Please select the expense type before saving");
				leexpenses.Focus();
				return;
			}
			
			if (ceAmount.Value <= 0)
			{
				MessageBox.Show("Please enter the Amount");
				ceAmount.Focus();
				return;
			}
			
			if (deexpDate.Text == string.Empty)
			{
				MessageBox.Show("Please enter the date of expenditure");
				deexpDate.Focus();
				return;
			}
			
			
			PDSA.DataLayer.DataClasses.PDSATransaction TranBo = new PDSA.DataLayer.DataClasses.PDSATransaction();
			tblExpenseTransManager mgrexp = new tblExpenseTransManager();
			
			try
			{
				mgrexp.DataObject.TransactionType = PDSATransactionType.Insert;
				mgrexp.DataObject.Entity.expdate = DateTime.Parse(deexpDate.Text);
				mgrexp.DataObject.Entity.expamount = ceAmount.Value;
				mgrexp.DataObject.Entity.expenseid = System.Convert.ToInt32(leexpenses.EditValue);
				mgrexp.DataObject.Entity.sInsertid = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
				mgrexp.DataObject.Entity.expremarks = txtRemarks.Text;
				TranBo.Add(mgrexp.DataObject);
				//later on put a code here to call a stored proc to save the data to an accounting type
				
				TranBo.Execute();
				DisableControls();
				MessageBox.Show("Expenses Entry Form Successfully Saved", "Saving Successful");
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
		
		public void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				btnSave.Focus();
			}
		}
		
		public void ceAmount_EditValueChanged(object sender, EventArgs e)
		{
			
		}
	}
}
