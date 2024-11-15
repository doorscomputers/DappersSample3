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
	public partial class frmBegCash
	{
		public frmBegCash()
		{
			InitializeComponent();
		}
		public PDSA.DataLayer.DataClasses.PDSATransaction Trantr;
		public void btnOk_Click(object sender, EventArgs e)
		{
			btnOk_ClickExtracted();
		}
		public void btnOk_ClickExtracted()
		{
			if (cebegcash.Value > 0)
			{
				tblreadingManager mgrtr = new tblreadingManager();
				tblreadingCollection col = new tblreadingCollection();
				Trantr = new PDSATransaction();
				
				try
				{
					mgrtr.Entity.datereading = DateAndTime.Now;
					mgrtr.Entity.cashier = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					mgrtr.Entity.begincash = cebegcash.Value;
					Trantr.Add(mgrtr.DataObject);
					Trantr.Execute();
					frmPOS frm = new frmPOS();
					frm.Show();
					frm = null;
					this.Close();
				}
				catch (PDSAValidationException ex)
				{
					MessageBox.Show(ex.Message);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				this.Close();
			}
			else
			{
				MessageBox.Show("Enter a Cash value Greater than Zero.");
				cebegcash.Focus();
			}
		}
		
		public void frmBegCash_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmBegCash_Load(object sender, EventArgs e)
		{
			if (PDSAAppConfig.CurrentLoginID != "Admin")
			{
				cmbUserType.Text = "Cashier";
			}
			else
			{
				cmbUserType.Text = "Admin";
			}
		}
		public void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void cebegcash_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				btnOk_ClickExtracted();
				this.Close();
			}
		}
		
		public void cebegcash_EditValueChanged(object sender, EventArgs e)
		{
			
		}
	}
}
