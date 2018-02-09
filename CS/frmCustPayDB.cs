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
	public partial class frmCustPayDB
	{
		public frmCustPayDB()
		{
			InitializeComponent();
		}
		//Private mFormsTracker As PDSAFormsTracker
		public void frmCustPayDB_FormClosed(object sender, FormClosedEventArgs e)
		{
			//mFormsTracker.CloseAll()
			this.Dispose();
		}
		
		public void frmCustPayDB_Load(object sender, EventArgs e)
		{
			//mFormsTracker = New PDSAFormsTracker
			//PDSAFormsTracker.FormsTracker = mFormsTracker
		}
	}
}
