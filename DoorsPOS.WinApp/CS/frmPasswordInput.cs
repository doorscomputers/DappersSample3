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


namespace DoorsPOS.WinApp
{
	public partial class frmPasswordInput
	{
		public frmPasswordInput()
		{
			InitializeComponent();
		}
		
		public void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ModCon.username = string.Empty;
				try
				{
					waitersManager mgremp = new waitersManager();
					waitersCollection cols = new waitersCollection();
					mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword;
					
					mgremp.Entity.pword = txtPassword.Text.ToString().Trim();
					cols = mgremp.BuildCollection();
					if (mgremp.DataObject.RowsAffected > 0)
					{
						frmPOS.Default.ceWtid.Value = mgremp.DataObject.Entity.wtid;
						//MessageBox.Show(CStr(vEmpID))
						//MessageBox.Show(CStr(mgremp.DataObject.Entity.waiter))
						VarsModule.vEmpID = mgremp.DataObject.Entity.wtid;
						//MessageBox.Show(CStr(vEmpID))
						frmPOS.passcorrect = true;
						this.Close();
					}
					else
					{
						MessageBox.Show("Not a valid password, try again.");
						//Me.Close()
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
		
		public void frmPasswordInput_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmPasswordInput_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F4)
			{
				//'~~~ Calling it and passing the name of the form to be displayed
				//Dim myObj As abcLockScreen = New abcLockScreen
				//myObj.LockSystemAndShow(Form2)
				e.Handled = true;
			}
		}
		
	}
}
