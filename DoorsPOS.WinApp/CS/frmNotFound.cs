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
	public partial class frmNotFound
	{
		public frmNotFound()
		{
			InitializeComponent();
		}
		
		public void frmNotFound_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmNotFound_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				this.Close();
				this.Dispose();
			}
			
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				this.Close();
				this.Dispose();
			}
		}
		
		public void frmNotFound_Load(object sender, EventArgs e)
		{
			Timer1.Interval = 100;
			Timer1.Enabled = true;
			Timer1.Start();
		}
		
		public void Timer1_Tick(object sender, EventArgs e)
		{
			if (Label1.ForeColor == Color.Black && Label2.ForeColor == Color.Black && Label3.ForeColor == Color.Black)
			{
				Label1.ForeColor = Color.Red;
				Label2.ForeColor = Color.Red;
				Label3.ForeColor = Color.Red;
			}
			else
			{
				Label1.ForeColor = Color.Black;
				Label2.ForeColor = Color.Black;
				Label3.ForeColor = Color.Black;
			}
			
		}
	}
}
