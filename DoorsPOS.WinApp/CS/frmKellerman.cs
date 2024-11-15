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

using KellermanSoftware.NetDataAccessLayer;

namespace DoorsPOS.WinApp
{
	public partial class frmKellerman
	{
		public frmKellerman()
		{
			// VBConversions Note: Non-static class variable initialization is below.  Class variables cannot be initially assigned non-static values in C#.
			db = DataHelper.SessionFactory();
			
			InitializeComponent();
		}
		IDataHelper db; // VBConversions Note: Initial value cannot be assigned here since it is non-static.  Assignment has been moved to the class constructors.
		public void frmKellerman_Load(object sender, EventArgs e)
		{
			
			
		}
		
		public void btnButton1_Click(object sender, EventArgs e)
		{
			//Try
			//    db.UserName = "Warren Dulnuone"
			//    db.LicenseKey = "Gm3q8dSenI1fsj0kpm6zYZgjcv9cwydHrq0HRIoJCWY="
			//    db.Mapper.DefaultPrimaryKeyName = "ID"
			//    db.Mapper.PluralTableNames = False
			//    db.OpenConnection()
			//    db.CreateClassFromTable("doorspos", "bank", @"..\..\banko.vb")
			//    db.Setup("doorspos.Business.Entities")
			//    Dim customer As New tblsample
			
			//    customer.accountname = "John Smith"
			//    customer.accountno = "987"
			//    db.Save(customer)
			//Catch ex As Exception
			//    MessageBox.Show(ex.ToString)
			//End Try
			
		}
	}
}
