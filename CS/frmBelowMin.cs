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

using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;


namespace DoorsPOS.WinApp
{
	public partial class frmBelowMin
	{
		public frmBelowMin()
		{
			InitializeComponent();
		}
		
		public void frmBelowMin_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void Button1_Click(object sender, EventArgs e)
		{
			XrItemsBelowMinim belowmin = new XrItemsBelowMinim();
			belowmin.PrintingSystem.ShowMarginsWarning = false;
			belowmin.ShowPreview();
		}
	}
}
