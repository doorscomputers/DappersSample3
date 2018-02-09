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
	partial class frmSearchItemsforRefunds : System.Windows.Forms.Form
	{
		public frmSearchItemsforRefunds()
		{
			DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Tahoma", (float) (12.5F));
			// Track User Flag must be set here or it won't be set in time
			// MyBase.UserTrack = False
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			// This is done for apparent speed
			Control ctlSelected;
			ctlSelected = PDSAForms.GetActiveMDIChildControl(this);
			
			//Add any initialization after the InitializeComponent() call
			
			//MyBase.CheckSecurityOnControls = True
		}
		
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
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.btnButton1 = new System.Windows.Forms.Button();
			this.btnButton1.Click += new System.EventHandler(this.btnButton1_Click);
			this.lblLabel1 = new System.Windows.Forms.Label();
			this.lblLabel1.Click += new System.EventHandler(this.lblLabel1_Click);
			this.txtItem = new DevExpress.XtraEditors.TextEdit();
			this.txtItem.EditValueChanged += new System.EventHandler(this.txtItem_EditValueChanged);
			this.txtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyDown);
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtItem.Properties).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.gridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(1167, 381);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gridView1});
			//
			//gridView1
			//
			this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
			this.gridView1.GridControl = this.GridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowAutoFilterRow = true;
			this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
			//
			//btnButton1
			//
			this.btnButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btnButton1.Location = new System.Drawing.Point(1050, 0);
			this.btnButton1.Name = "btnButton1";
			this.btnButton1.Size = new System.Drawing.Size(105, 26);
			this.btnButton1.TabIndex = 1;
			this.btnButton1.Text = "&Search";
			this.btnButton1.UseVisualStyleBackColor = true;
			//
			//lblLabel1
			//
			this.lblLabel1.AutoSize = true;
			this.lblLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblLabel1.Location = new System.Drawing.Point(620, 6);
			this.lblLabel1.Name = "lblLabel1";
			this.lblLabel1.Size = new System.Drawing.Size(114, 20);
			this.lblLabel1.TabIndex = 3;
			this.lblLabel1.Text = "Item to Search";
			//
			//txtItem
			//
			this.txtItem.Location = new System.Drawing.Point(740, 0);
			this.txtItem.Name = "txtItem";
			this.txtItem.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			this.txtItem.Properties.Appearance.Options.UseFont = true;
			this.txtItem.Size = new System.Drawing.Size(293, 26);
			this.txtItem.TabIndex = 0;
			//
			//frmSearchItemsforRefunds
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1167, 381);
			this.Controls.Add(this.txtItem);
			this.Controls.Add(this.lblLabel1);
			this.Controls.Add(this.btnButton1);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmSearchItemsforRefunds";
			this.Text = "Search Items for Refunds";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtItem.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		internal System.Windows.Forms.Button btnButton1;
		internal System.Windows.Forms.Label lblLabel1;
		internal DevExpress.XtraEditors.TextEdit txtItem;
	}
	
}
