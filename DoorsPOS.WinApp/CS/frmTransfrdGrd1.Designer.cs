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
	partial class frmTransfrdGrd1 : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmTransfrdGrd1_Load);
			this.PivotGridControl1.DoubleClick += new System.EventHandler(this.PivotGridControl1_DoubleClick);
			this.VwTransferedBindingSource = new System.Windows.Forms.BindingSource();
			this.DsTransferedBindingSource = new System.Windows.Forms.BindingSource();
			this.DsTransfered = new DoorsPOS.WinApp.dsTransfered();
			this.fieldtdate1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fielditemdesc1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldqty1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldsInsertid1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldlocation1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldtdate = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldtdate2 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.VwTransferedTableAdapter = new DoorsPOS.WinApp.dsTransferedTableAdapters.vwTransferedTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwTransferedBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsTransferedBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsTransfered).BeginInit();
			this.SuspendLayout();
			//
			//PivotGridControl1
			//
			this.PivotGridControl1.DataSource = this.VwTransferedBindingSource;
			this.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {this.fieldtdate1, this.fielditemdesc1, this.fieldqty1, this.fieldsInsertid1, this.fieldlocation1, this.fieldtdate, this.fieldtdate2});
			this.PivotGridControl1.Location = new System.Drawing.Point(0, 0);
			this.PivotGridControl1.Name = "PivotGridControl1";
			this.PivotGridControl1.Size = new System.Drawing.Size(904, 451);
			this.PivotGridControl1.TabIndex = 0;
			//
			//VwTransferedBindingSource
			//
			this.VwTransferedBindingSource.DataMember = "vwTransfered";
			this.VwTransferedBindingSource.DataSource = this.DsTransferedBindingSource;
			//
			//DsTransferedBindingSource
			//
			this.DsTransferedBindingSource.DataSource = this.DsTransfered;
			this.DsTransferedBindingSource.Position = 0;
			//
			//DsTransfered
			//
			this.DsTransfered.DataSetName = "dsTransfered";
			this.DsTransfered.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//fieldtdate1
			//
			this.fieldtdate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldtdate1.AreaIndex = 0;
			this.fieldtdate1.Caption = "Year";
			this.fieldtdate1.FieldName = "tdate";
			this.fieldtdate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldtdate1.Name = "fieldtdate1";
			this.fieldtdate1.UnboundFieldName = "fieldtdate1";
			this.fieldtdate1.Width = 88;
			//
			//fielditemdesc1
			//
			this.fielditemdesc1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fielditemdesc1.AreaIndex = 1;
			this.fielditemdesc1.Caption = "Item Description";
			this.fielditemdesc1.FieldName = "item_desc";
			this.fielditemdesc1.Name = "fielditemdesc1";
			this.fielditemdesc1.Width = 203;
			//
			//fieldqty1
			//
			this.fieldqty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldqty1.AreaIndex = 0;
			this.fieldqty1.Caption = "Qty Transferred";
			this.fieldqty1.FieldName = "qty";
			this.fieldqty1.Name = "fieldqty1";
			//
			//fieldsInsertid1
			//
			this.fieldsInsertid1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldsInsertid1.AreaIndex = 2;
			this.fieldsInsertid1.Caption = "Encoder";
			this.fieldsInsertid1.FieldName = "sInsert_id";
			this.fieldsInsertid1.Name = "fieldsInsertid1";
			//
			//fieldlocation1
			//
			this.fieldlocation1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldlocation1.AreaIndex = 0;
			this.fieldlocation1.Caption = "Transferred To";
			this.fieldlocation1.FieldName = "location";
			this.fieldlocation1.Name = "fieldlocation1";
			//
			//fieldtdate
			//
			this.fieldtdate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldtdate.AreaIndex = 1;
			this.fieldtdate.Caption = "Month";
			this.fieldtdate.FieldName = "tdate";
			this.fieldtdate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldtdate.Name = "fieldtdate";
			this.fieldtdate.UnboundFieldName = "fieldtdate";
			//
			//fieldtdate2
			//
			this.fieldtdate2.AreaIndex = 0;
			this.fieldtdate2.Caption = "Date";
			this.fieldtdate2.FieldName = "tdate";
			this.fieldtdate2.Name = "fieldtdate2";
			//
			//VwTransferedTableAdapter
			//
			this.VwTransferedTableAdapter.ClearBeforeFill = true;
			//
			//frmTransfrdGrd1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 451);
			this.Controls.Add(this.PivotGridControl1);
			this.Name = "frmTransfrdGrd1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Transferred Stocks View1";
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwTransferedBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsTransferedBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsTransfered).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraPivotGrid.PivotGridControl PivotGridControl1;
		internal System.Windows.Forms.BindingSource DsTransferedBindingSource;
		internal DoorsPOS.WinApp.dsTransfered DsTransfered;
		internal System.Windows.Forms.BindingSource VwTransferedBindingSource;
		internal DoorsPOS.WinApp.dsTransferedTableAdapters.vwTransferedTableAdapter VwTransferedTableAdapter;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldtdate1;
		internal DevExpress.XtraPivotGrid.PivotGridField fielditemdesc1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldqty1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldsInsertid1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldlocation1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldtdate;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldtdate2;
	}
	
}
