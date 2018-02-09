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
	public partial class frmExpired
	{
		public frmExpired()
		{
			InitializeComponent();
		}
		
		public void frmExpired_Load(object sender, EventArgs e)
		{
			//TODO: This line of code loads data into the 'DsspExpiration.spExpirationDate' table. You can move, or remove it, as needed.
			this.spExpirationDateTableAdapter.Fill(this.DsspExpiration.spExpirationDate);
			//TODO: This line of code loads data into the 'DsvwExpired.vwExpired' table. You can move, or remove it, as needed.
			
			
		}
	}
}
