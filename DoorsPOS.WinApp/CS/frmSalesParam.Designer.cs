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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class frmSalesParam : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
			((System.ComponentModel.ISupportInitialize) this.dashboardViewer1).BeginInit();
			this.SuspendLayout();
			//
			//dashboardViewer1
			//
			this.dashboardViewer1.DashboardSource = typeof(DoorsPOS.WinApp.Win_Dashboards.SaleswithParam);
			this.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dashboardViewer1.Location = new System.Drawing.Point(0, 0);
			this.dashboardViewer1.Name = "dashboardViewer1";
			this.dashboardViewer1.PrintingOptions.DocumentContentOptions.FilterState = DevExpress.DashboardWin.DashboardPrintingFilterState.None;
			this.dashboardViewer1.PrintingOptions.FontInfo.GdiCharSet = System.Convert.ToByte(0);
			this.dashboardViewer1.PrintingOptions.FontInfo.Name = null;
			this.dashboardViewer1.Size = new System.Drawing.Size(661, 477);
			this.dashboardViewer1.TabIndex = 0;
			//
			//frmSalesParam
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(661, 477);
			this.Controls.Add(this.dashboardViewer1);
			this.Name = "frmSalesParam";
			this.Text = "frmSalesParam";
			((System.ComponentModel.ISupportInitialize) this.dashboardViewer1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
	}
	
}
