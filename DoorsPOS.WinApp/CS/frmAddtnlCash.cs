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
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;


namespace DoorsPOS.WinApp
{
	public partial class frmAddtnlCash
	{
		public frmAddtnlCash()
		{
			InitializeComponent();
		}
		public void btnsave_Click(object sender, EventArgs e)
		{
			if (ceamount.Value <= 0)
			{
				MessageBox.Show("Please enter amount added.");
				return;
			}
			
			if ((depaydate.EditValue).ToString() == "")
			{
				MessageBox.Show("Please enter amount added.");
				return;
			}
			
			int ansint = 7;
			ansint = (int) (Interaction.MsgBox("Are you sure you want to Save the Additional Cash Amount?", MsgBoxStyle.YesNo, "Additional Cash Save Confirmation"));
			if (ansint == 6)
			{
				try
				{
					PDSATransaction tranmgr = new PDSATransaction();
					additnlcashManager mgrpay = new additnlcashManager();
					tblreadingManager mgrrdng = new tblreadingManager();
					
					///''''''''''''
					
					mgrpay.Entity.posdate = System.Convert.ToDateTime(depaydate.EditValue);
					mgrpay.Entity.acamnt = Convert.ToDecimal(ceamount.Value);
					mgrpay.Entity.acremarks = txtremark.Text;
					mgrpay.Entity.cashier = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					
					mgrrdng.DataObject.SelectFilter = tblreadingData.SelectFilters.All;
					mgrrdng.DataObject.WhereFilter = tblreadingData.WhereFilters.CashierStatus;
					mgrrdng.Entity.cashier = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					mgrrdng.DataObject.Load();
					if (mgrrdng.DataObject.RowsAffected > 0)
					{
						mgrrdng.Entity.addcash = Convert.ToDecimal(ceamount.Value) + mgrrdng.Entity.addcash;
						mgrrdng.DataObject.UpdateFilter = tblreadingData.UpdateFilters.PrimaryKey;
					}
					
					mgrpay.DataObject.TransactionType = PDSA.DataLayer.DataClasses.PDSATransactionType.Insert;
					mgrrdng.DataObject.TransactionType = PDSATransactionType.Update;
					tranmgr.Add(mgrpay.DataObject);
					tranmgr.Add(mgrrdng.DataObject);
					tranmgr.Execute();
					
					int intgc = 0;
					intgc = mgrpay.Entity.acid;
					
					xrAddCash2 xraddcash = new xrAddCash2();
					xraddcash.adcashid.Value = intgc;
					xraddcash.RequestParameters = false;
					xraddcash.PrintingSystem.ShowMarginsWarning = false;
					xraddcash.PrintingSystem.StartPrint += ReportOnStartPrint;
					xraddcash.Print();
					
					disable();
					initialvals();
					MessageBox.Show("Addtional Cash successfully saved.");
				}
				catch (PDSAValidationException ex)
				{
					MessageBox.Show(ex.Message);
				}
				catch (Exception ex)
				{
					DisplayException(ex);
				}
				
				this.Close();
			}
		}
		private void ReportOnStartPrint(object sender, DevExpress.XtraPrinting.PrintDocumentEventArgs e)
		{
			e.PrintDocument.PrinterSettings.Copies = (short) 2;
		}
		private void DisplayException(Exception ex)
		{
			//tbException.Text = ex.ToString()
			MessageBox.Show(ex.ToString());
			//MessageBox.Show("Exception Occurred. Check the Exception Tab for More Info.")
		}
		
		public void enable()
		{
			btnnew.Enabled = false;
			btnsave.Enabled = true;
			btncancel.Enabled = true;
			btnclose.Enabled = false;
		}
		public void disable()
		{
			btnnew.Enabled = true;
			btnsave.Enabled = false;
			btncancel.Enabled = false;
			btnclose.Enabled = true;
		}
		public void initialvals()
		{
			ceamount.Value = 0;
			txtremark.Text = string.Empty;
			depaydate.EditValue = DateAndTime.Today;
		}
		
		public void btnnew_Click(object sender, EventArgs e)
		{
			enable();
			initialvals();
		}
		
		public void btncancel_Click(object sender, EventArgs e)
		{
			int ansint = 7;
			ansint = (int) (Interaction.MsgBox("Are you sure you want to cancel Additonal Cash Entry?", MsgBoxStyle.YesNo, "Cancel Confirmation"));
			if (ansint == 6)
			{
				disable();
				initialvals();
			}
		}
		
		public void btnclose_Click(object sender, EventArgs e)
		{
			if (btnsave.Enabled == true)
			{
				int ans = 0;
				ans = (int) (Interaction.MsgBox("Pending Additional Cash Transaction not saved. Click Yes to Save or No to Cancel Payment and Close the form.", MsgBoxStyle.YesNo, null));
				if (ans == 7)
				{
					return;
				}
				else
				{
					this.Close();
				}
			}
			else
			{
				this.Close();
			}
		}
		
		public void frmAddtnlCash_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmAddtnlCash_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				if (btnsave.Enabled == true)
				{
					int ans = 0;
					ans = (int) (Interaction.MsgBox("Pending Additional Cash Transaction not saved. Click Yes to Save or No to Cancel Payment and Close the form.", MsgBoxStyle.YesNo, null));
					if (ans == 7)
					{
						return;
					}
					else
					{
						this.Close();
					}
				}
				else
				{
					this.Close();
				}
			}
		}
		public void frmAddtnlCash_Load(object sender, EventArgs e)
		{
			depaydate.EditValue = DateAndTime.Today;
		}
	}
}
