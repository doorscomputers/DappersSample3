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
	partial class frmBestCustomer : System.Windows.Forms.Form
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
			this.DashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
			((System.ComponentModel.ISupportInitialize) this.DashboardViewer1).BeginInit();
			this.SuspendLayout();
			//
			//DashboardViewer1
			//
			this.DashboardViewer1.AllowPrintDashboardItems = true;
			this.DashboardViewer1.DashboardSource = typeof(DoorsPOS.WinApp.Win_Dashboards.DBBestCust);
			this.DashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DashboardViewer1.Location = new System.Drawing.Point(0, 0);
			this.DashboardViewer1.Name = "DashboardViewer1";
			this.DashboardViewer1.Size = new System.Drawing.Size(1075, 497);
			this.DashboardViewer1.TabIndex = 0;
			//
			//frmBestCustomer
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1075, 497);
			this.Controls.Add(this.DashboardViewer1);
			this.KeyPreview = true;
			this.MinimizeBox = false;
			this.Name = "frmBestCustomer";
			this.Text = "Best Customer";
			((System.ComponentModel.ISupportInitialize) this.DashboardViewer1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.DashboardWin.DashboardViewer DashboardViewer1;
	}
	
}
