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
	partial class frmBOGrid : System.Windows.Forms.Form
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
			this.PivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			base.Load += new System.EventHandler(frmBOGrid_Load);
			this.PivotGridControl1.DoubleClick += new System.EventHandler(this.PivotGridControl1_DoubleClick);
			this.VwBOBindingSource = new System.Windows.Forms.BindingSource();
			this.DsBO = new DoorsPOS.WinApp.dsBO();
			this.fieldbodate1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldqty1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fielditemdesc1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldsupplier1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.VwBOTableAdapter = new DoorsPOS.WinApp.dsBOTableAdapters.vwBOTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwBOBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsBO).BeginInit();
			this.SuspendLayout();
			//
			//PivotGridControl1
			//
			this.PivotGridControl1.DataSource = this.VwBOBindingSource;
			this.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {this.fieldbodate1, this.fieldqty1, this.fielditemdesc1, this.fieldsupplier1});
			this.PivotGridControl1.Location = new System.Drawing.Point(0, 0);
			this.PivotGridControl1.Name = "PivotGridControl1";
			this.PivotGridControl1.Size = new System.Drawing.Size(779, 510);
			this.PivotGridControl1.TabIndex = 0;
			//
			//VwBOBindingSource
			//
			this.VwBOBindingSource.DataMember = "vwBO";
			this.VwBOBindingSource.DataSource = this.DsBO;
			//
			//DsBO
			//
			this.DsBO.DataSetName = "dsBO";
			this.DsBO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//fieldbodate1
			//
			this.fieldbodate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldbodate1.AreaIndex = 0;
			this.fieldbodate1.Caption = "BO Date";
			this.fieldbodate1.FieldName = "bodate";
			this.fieldbodate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
			this.fieldbodate1.Name = "fieldbodate1";
			this.fieldbodate1.UnboundFieldName = "fieldbodate1";
			this.fieldbodate1.Width = 164;
			//
			//fieldqty1
			//
			this.fieldqty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldqty1.AreaIndex = 0;
			this.fieldqty1.Caption = "Qty";
			this.fieldqty1.FieldName = "qty";
			this.fieldqty1.Name = "fieldqty1";
			//
			//fielditemdesc1
			//
			this.fielditemdesc1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fielditemdesc1.AreaIndex = 0;
			this.fielditemdesc1.Caption = "Item Description";
			this.fielditemdesc1.FieldName = "item_desc";
			this.fielditemdesc1.Name = "fielditemdesc1";
			this.fielditemdesc1.Width = 170;
			//
			//fieldsupplier1
			//
			this.fieldsupplier1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldsupplier1.AreaIndex = 1;
			this.fieldsupplier1.Caption = "Supplier";
			this.fieldsupplier1.FieldName = "supplier";
			this.fieldsupplier1.Name = "fieldsupplier1";
			this.fieldsupplier1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			//
			//VwBOTableAdapter
			//
			this.VwBOTableAdapter.ClearBeforeFill = true;
			//
			//frmBOGrid
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 510);
			this.Controls.Add(this.PivotGridControl1);
			this.Name = "frmBOGrid";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "BO ";
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwBOBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsBO).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraPivotGrid.PivotGridControl PivotGridControl1;
		internal DoorsPOS.WinApp.dsBO DsBO;
		internal System.Windows.Forms.BindingSource VwBOBindingSource;
		internal DoorsPOS.WinApp.dsBOTableAdapters.vwBOTableAdapter VwBOTableAdapter;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldbodate1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldqty1;
		internal DevExpress.XtraPivotGrid.PivotGridField fielditemdesc1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldsupplier1;
	}
	
}
