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
	public partial class frmEmployee
	{
		
		public frmEmployee()
		{
			
			InitializeComponent();
			// This line of code is generated by Data Source Configuration Wizard
			WaitersTableAdapter1.Fill(DsEmployees1.waiters);
		}
		
		public void simBtnSave_Click(object sender, EventArgs e)
		{
			try
			{
				c1DataViewSet1.Update();
			}
			catch (Exception)
			{
				MessageBox.Show("Not Saved, Password too weak!");
			}
			
		}
	}
}
