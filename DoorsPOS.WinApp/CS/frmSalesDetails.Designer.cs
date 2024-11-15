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
	partial class frmSalesDetails : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmSalesDetails_Load);
			this.PivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.PivotGridControl1.DoubleClick += new System.EventHandler(this.PivotGridControl1_DoubleClick);
			this.VwSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsItemsSoldBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsItemsSold = new DoorsPOS.WinApp.dsItemsSold();
			this.fielddtInsertdt1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldposdate1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldposdate = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fielditemdesc1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldqty1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fielddetamnt1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.VwSalesTableAdapter = new DoorsPOS.WinApp.dsItemsSoldTableAdapters.vwSalesTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwSalesBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemsSoldBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemsSold).BeginInit();
			this.SuspendLayout();
			//
			//PivotGridControl1
			//
			this.PivotGridControl1.DataSource = this.VwSalesBindingSource;
			this.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {this.fielddtInsertdt1, this.fieldposdate1, this.fieldposdate, this.fielditemdesc1, this.fieldqty1, this.fielddetamnt1});
			this.PivotGridControl1.Location = new System.Drawing.Point(0, 0);
			this.PivotGridControl1.Name = "PivotGridControl1";
			this.PivotGridControl1.Size = new System.Drawing.Size(1013, 487);
			this.PivotGridControl1.TabIndex = 0;
			//
			//VwSalesBindingSource
			//
			this.VwSalesBindingSource.DataMember = "vwSales";
			this.VwSalesBindingSource.DataSource = this.DsItemsSoldBindingSource;
			//
			//DsItemsSoldBindingSource
			//
			this.DsItemsSoldBindingSource.DataSource = this.DsItemsSold;
			this.DsItemsSoldBindingSource.Position = 0;
			//
			//DsItemsSold
			//
			this.DsItemsSold.DataSetName = "dsItemsSold";
			this.DsItemsSold.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//fielddtInsertdt1
			//
			this.fielddtInsertdt1.AreaIndex = 0;
			this.fielddtInsertdt1.Caption = "Date Sold";
			this.fielddtInsertdt1.FieldName = "dtInsert_dt";
			this.fielddtInsertdt1.Name = "fielddtInsertdt1";
			this.fielddtInsertdt1.Width = 160;
			//
			//fieldposdate1
			//
			this.fieldposdate1.AreaIndex = 1;
			this.fieldposdate1.Caption = "Year";
			this.fieldposdate1.FieldName = "pos_date";
			this.fieldposdate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldposdate1.Name = "fieldposdate1";
			this.fieldposdate1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldposdate1.UnboundFieldName = "fieldposdate1";
			//
			//fieldposdate
			//
			this.fieldposdate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldposdate.AreaIndex = 0;
			this.fieldposdate.Caption = "Month";
			this.fieldposdate.FieldName = "pos_date";
			this.fieldposdate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldposdate.Name = "fieldposdate";
			this.fieldposdate.UnboundFieldName = "fieldposdate";
			//
			//fielditemdesc1
			//
			this.fielditemdesc1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fielditemdesc1.AreaIndex = 1;
			this.fielditemdesc1.Caption = "Items Sold";
			this.fielditemdesc1.FieldName = "item_desc";
			this.fielditemdesc1.Name = "fielditemdesc1";
			//
			//fieldqty1
			//
			this.fieldqty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldqty1.AreaIndex = 0;
			this.fieldqty1.Caption = "Qty Sold";
			this.fieldqty1.FieldName = "qty";
			this.fieldqty1.Name = "fieldqty1";
			this.fieldqty1.ValueFormat.FormatString = "N0";
			this.fieldqty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			//
			//fielddetamnt1
			//
			this.fielddetamnt1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fielddetamnt1.AreaIndex = 1;
			this.fielddetamnt1.Caption = "Amount";
			this.fielddetamnt1.FieldName = "det_amnt";
			this.fielddetamnt1.Name = "fielddetamnt1";
			this.fielddetamnt1.ValueFormat.FormatString = "N2";
			this.fielddetamnt1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			//
			//VwSalesTableAdapter
			//
			this.VwSalesTableAdapter.ClearBeforeFill = true;
			//
			//frmSalesDetails
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1013, 487);
			this.Controls.Add(this.PivotGridControl1);
			this.Name = "frmSalesDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Items Sold";
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwSalesBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemsSoldBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemsSold).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraPivotGrid.PivotGridControl PivotGridControl1;
		internal System.Windows.Forms.BindingSource DsItemsSoldBindingSource;
		internal DoorsPOS.WinApp.dsItemsSold DsItemsSold;
		internal System.Windows.Forms.BindingSource VwSalesBindingSource;
		internal DoorsPOS.WinApp.dsItemsSoldTableAdapters.vwSalesTableAdapter VwSalesTableAdapter;
		internal DevExpress.XtraPivotGrid.PivotGridField fielddtInsertdt1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldposdate1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldposdate;
		internal DevExpress.XtraPivotGrid.PivotGridField fielditemdesc1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldqty1;
		internal DevExpress.XtraPivotGrid.PivotGridField fielddetamnt1;
	}
	
}
