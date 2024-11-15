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
	partial class frmReceivedStcksGrd : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmReceivedStcksGrd_Load);
			this.PivotGridControl1.DoubleClick += new System.EventHandler(this.PivotGridControl1_DoubleClick);
			this.VwReceivedStocksBindingSource = new System.Windows.Forms.BindingSource();
			this.DsReceivedStcksBindingSource = new System.Windows.Forms.BindingSource();
			this.DsReceivedStcks = new DoorsPOS.WinApp.dsReceivedStcks();
			this.fielditemdesc = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldlocation = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldqty = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldrdate = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldsInsertid = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldrdate4 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldrdate1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldrdate2 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldrdate3 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.VwReceivedStocksTableAdapter = new DoorsPOS.WinApp.dsReceivedStcksTableAdapters.vwReceivedStocksTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwReceivedStocksBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsReceivedStcksBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsReceivedStcks).BeginInit();
			this.SuspendLayout();
			//
			//PivotGridControl1
			//
			this.PivotGridControl1.DataSource = this.VwReceivedStocksBindingSource;
			this.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {this.fielditemdesc, this.fieldlocation, this.fieldqty, this.fieldrdate, this.fieldsInsertid, this.fieldrdate4, this.fieldrdate1, this.fieldrdate2, this.fieldrdate3});
			this.PivotGridControl1.Location = new System.Drawing.Point(0, 0);
			this.PivotGridControl1.Name = "PivotGridControl1";
			this.PivotGridControl1.Size = new System.Drawing.Size(809, 489);
			this.PivotGridControl1.TabIndex = 0;
			//
			//VwReceivedStocksBindingSource
			//
			this.VwReceivedStocksBindingSource.DataMember = "vwReceivedStocks";
			this.VwReceivedStocksBindingSource.DataSource = this.DsReceivedStcksBindingSource;
			//
			//DsReceivedStcksBindingSource
			//
			this.DsReceivedStcksBindingSource.DataSource = this.DsReceivedStcks;
			this.DsReceivedStcksBindingSource.Position = 0;
			//
			//DsReceivedStcks
			//
			this.DsReceivedStcks.DataSetName = "dsReceivedStcks";
			this.DsReceivedStcks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//fielditemdesc
			//
			this.fielditemdesc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fielditemdesc.AreaIndex = 1;
			this.fielditemdesc.Caption = "Items Received";
			this.fielditemdesc.FieldName = "item_desc";
			this.fielditemdesc.Name = "fielditemdesc";
			this.fielditemdesc.Width = 194;
			//
			//fieldlocation
			//
			this.fieldlocation.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldlocation.AreaIndex = 0;
			this.fieldlocation.Caption = "Received From";
			this.fieldlocation.FieldName = "location";
			this.fieldlocation.Name = "fieldlocation";
			this.fieldlocation.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			//
			//fieldqty
			//
			this.fieldqty.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldqty.AreaIndex = 0;
			this.fieldqty.Caption = "Qty Received";
			this.fieldqty.FieldName = "qty";
			this.fieldqty.Name = "fieldqty";
			//
			//fieldrdate
			//
			this.fieldrdate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldrdate.AreaIndex = 2;
			this.fieldrdate.Caption = "Date Transferred";
			this.fieldrdate.CellFormat.FormatString = "d";
			this.fieldrdate.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fieldrdate.FieldName = "rdate";
			this.fieldrdate.Name = "fieldrdate";
			this.fieldrdate.ValueFormat.FormatString = "d";
			this.fieldrdate.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fieldrdate.Width = 151;
			//
			//fieldsInsertid
			//
			this.fieldsInsertid.AreaIndex = 0;
			this.fieldsInsertid.Caption = "Employee";
			this.fieldsInsertid.FieldName = "sInsert_id";
			this.fieldsInsertid.Name = "fieldsInsertid";
			//
			//fieldrdate4
			//
			this.fieldrdate4.AreaIndex = 1;
			this.fieldrdate4.Caption = "Week";
			this.fieldrdate4.FieldName = "rdate";
			this.fieldrdate4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateWeekOfMonth;
			this.fieldrdate4.Name = "fieldrdate4";
			this.fieldrdate4.UnboundFieldName = "fieldrdate4";
			//
			//fieldrdate1
			//
			this.fieldrdate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldrdate1.AreaIndex = 1;
			this.fieldrdate1.Caption = "Month";
			this.fieldrdate1.FieldName = "rdate";
			this.fieldrdate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldrdate1.Name = "fieldrdate1";
			this.fieldrdate1.UnboundFieldName = "fieldrdate1";
			//
			//fieldrdate2
			//
			this.fieldrdate2.AreaIndex = 2;
			this.fieldrdate2.Caption = "Qtr";
			this.fieldrdate2.FieldName = "rdate";
			this.fieldrdate2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
			this.fieldrdate2.Name = "fieldrdate2";
			this.fieldrdate2.UnboundFieldName = "fieldrdate2";
			//
			//fieldrdate3
			//
			this.fieldrdate3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldrdate3.AreaIndex = 0;
			this.fieldrdate3.Caption = "Year";
			this.fieldrdate3.FieldName = "rdate";
			this.fieldrdate3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldrdate3.Name = "fieldrdate3";
			this.fieldrdate3.UnboundFieldName = "fieldrdate3";
			//
			//VwReceivedStocksTableAdapter
			//
			this.VwReceivedStocksTableAdapter.ClearBeforeFill = true;
			//
			//frmReceivedStcksGrd
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(809, 489);
			this.Controls.Add(this.PivotGridControl1);
			this.Name = "frmReceivedStcksGrd";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Received Stocks";
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwReceivedStocksBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsReceivedStcksBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsReceivedStcks).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraPivotGrid.PivotGridControl PivotGridControl1;
		internal System.Windows.Forms.BindingSource DsReceivedStcksBindingSource;
		internal DoorsPOS.WinApp.dsReceivedStcks DsReceivedStcks;
		internal System.Windows.Forms.BindingSource VwReceivedStocksBindingSource;
		internal DoorsPOS.WinApp.dsReceivedStcksTableAdapters.vwReceivedStocksTableAdapter VwReceivedStocksTableAdapter;
		internal DevExpress.XtraPivotGrid.PivotGridField fielditemdesc;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldlocation;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldqty;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldrdate;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldsInsertid;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldrdate4;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldrdate1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldrdate2;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldrdate3;
	}
	
}
