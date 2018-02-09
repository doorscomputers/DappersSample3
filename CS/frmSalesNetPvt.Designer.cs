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
	partial class frmSalesWithNetPvt : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmSalesWithNetPvt_Load);
			this.PivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.PivotGridControl1.DoubleClick += new System.EventHandler(this.PivotGridControl1_DoubleClick);
			this.VwSaleswCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsSalesWithCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsSalesWithCost = new DoorsPOS.WinApp.dsSalesWithCost();
			this.fielddtInsertdt1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fielditemdesc1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldprice1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldqty1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fielddetamnt1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldcost1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.CostAmount = new DevExpress.XtraPivotGrid.PivotGridField();
			this.Profit = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fielddtInsertdt = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fielddtInsertdt2 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fielddtInsertdt3 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.VwSaleswCostTableAdapter = new DoorsPOS.WinApp.dsSalesWithCostTableAdapters.vwSaleswCostTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwSaleswCostBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsSalesWithCostBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsSalesWithCost).BeginInit();
			this.SuspendLayout();
			//
			//PivotGridControl1
			//
			this.PivotGridControl1.DataSource = this.VwSaleswCostBindingSource;
			this.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {this.fielddtInsertdt1, this.fielditemdesc1, this.fieldprice1, this.fieldqty1, this.fielddetamnt1, this.fieldcost1, this.CostAmount, this.Profit, this.fielddtInsertdt, this.fielddtInsertdt2, this.fielddtInsertdt3});
			this.PivotGridControl1.Location = new System.Drawing.Point(0, 0);
			this.PivotGridControl1.Name = "PivotGridControl1";
			this.PivotGridControl1.Size = new System.Drawing.Size(876, 446);
			this.PivotGridControl1.TabIndex = 0;
			//
			//VwSaleswCostBindingSource
			//
			this.VwSaleswCostBindingSource.DataMember = "vwSaleswCost";
			this.VwSaleswCostBindingSource.DataSource = this.DsSalesWithCostBindingSource;
			//
			//DsSalesWithCostBindingSource
			//
			this.DsSalesWithCostBindingSource.DataSource = this.DsSalesWithCost;
			this.DsSalesWithCostBindingSource.Position = 0;
			//
			//DsSalesWithCost
			//
			this.DsSalesWithCost.DataSetName = "dsSalesWithCost";
			this.DsSalesWithCost.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//fielddtInsertdt1
			//
			this.fielddtInsertdt1.AreaIndex = 0;
			this.fielddtInsertdt1.Caption = "Date Sold";
			this.fielddtInsertdt1.FieldName = "dtInsert_dt";
			this.fielddtInsertdt1.Name = "fielddtInsertdt1";
			//
			//fielditemdesc1
			//
			this.fielditemdesc1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fielditemdesc1.AreaIndex = 0;
			this.fielditemdesc1.Caption = "Item Description";
			this.fielditemdesc1.FieldName = "item_desc";
			this.fielditemdesc1.Name = "fielditemdesc1";
			this.fielditemdesc1.Width = 106;
			//
			//fieldprice1
			//
			this.fieldprice1.AreaIndex = 2;
			this.fieldprice1.Caption = "Price";
			this.fieldprice1.FieldName = "price";
			this.fieldprice1.Name = "fieldprice1";
			this.fieldprice1.Width = 69;
			//
			//fieldqty1
			//
			this.fieldqty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldqty1.AreaIndex = 0;
			this.fieldqty1.Caption = "Qty Sold";
			this.fieldqty1.FieldName = "qty";
			this.fieldqty1.Name = "fieldqty1";
			this.fieldqty1.Width = 57;
			//
			//fielddetamnt1
			//
			this.fielddetamnt1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fielddetamnt1.AreaIndex = 2;
			this.fielddetamnt1.Caption = "Sold Amount";
			this.fielddetamnt1.FieldName = "det_amnt";
			this.fielddetamnt1.Name = "fielddetamnt1";
			this.fielddetamnt1.Width = 83;
			//
			//fieldcost1
			//
			this.fieldcost1.AreaIndex = 1;
			this.fieldcost1.Caption = "Cost";
			this.fieldcost1.FieldName = "cost";
			this.fieldcost1.Name = "fieldcost1";
			this.fieldcost1.Width = 75;
			//
			//CostAmount
			//
			this.CostAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.CostAmount.AreaIndex = 1;
			this.CostAmount.Caption = "Cost Amount";
			this.CostAmount.Name = "CostAmount";
			this.CostAmount.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.CostAmount.UnboundExpression = "[cost] * [qty]";
			this.CostAmount.UnboundFieldName = "PivotGridField1";
			this.CostAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.CostAmount.Width = 90;
			//
			//Profit
			//
			this.Profit.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.Profit.AreaIndex = 3;
			this.Profit.Caption = "Profit";
			this.Profit.Name = "Profit";
			this.Profit.UnboundExpression = "[det_amnt] - [PivotGridField1]";
			this.Profit.UnboundFieldName = "Profit";
			this.Profit.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			//
			//fielddtInsertdt
			//
			this.fielddtInsertdt.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fielddtInsertdt.AreaIndex = 1;
			this.fielddtInsertdt.Caption = "Month";
			this.fielddtInsertdt.FieldName = "dtInsert_dt";
			this.fielddtInsertdt.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fielddtInsertdt.Name = "fielddtInsertdt";
			this.fielddtInsertdt.UnboundFieldName = "fielddtInsertdt";
			//
			//fielddtInsertdt2
			//
			this.fielddtInsertdt2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fielddtInsertdt2.AreaIndex = 0;
			this.fielddtInsertdt2.Caption = "Year";
			this.fielddtInsertdt2.FieldName = "dtInsert_dt";
			this.fielddtInsertdt2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fielddtInsertdt2.Name = "fielddtInsertdt2";
			this.fielddtInsertdt2.UnboundFieldName = "fielddtInsertdt2";
			//
			//fielddtInsertdt3
			//
			this.fielddtInsertdt3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fielddtInsertdt3.AreaIndex = 1;
			this.fielddtInsertdt3.Caption = "Date Sold";
			this.fielddtInsertdt3.FieldName = "dtInsert_dt";
			this.fielddtInsertdt3.Name = "fielddtInsertdt3";
			this.fielddtInsertdt3.Width = 146;
			//
			//VwSaleswCostTableAdapter
			//
			this.VwSaleswCostTableAdapter.ClearBeforeFill = true;
			//
			//frmSalesWithNetPvt
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(876, 446);
			this.Controls.Add(this.PivotGridControl1);
			this.Name = "frmSalesWithNetPvt";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Sales With Net Income";
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwSaleswCostBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsSalesWithCostBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsSalesWithCost).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraPivotGrid.PivotGridControl PivotGridControl1;
		internal System.Windows.Forms.BindingSource DsSalesWithCostBindingSource;
		internal DoorsPOS.WinApp.dsSalesWithCost DsSalesWithCost;
		internal System.Windows.Forms.BindingSource VwSaleswCostBindingSource;
		internal DoorsPOS.WinApp.dsSalesWithCostTableAdapters.vwSaleswCostTableAdapter VwSaleswCostTableAdapter;
		internal DevExpress.XtraPivotGrid.PivotGridField fielddtInsertdt1;
		internal DevExpress.XtraPivotGrid.PivotGridField fielditemdesc1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldprice1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldqty1;
		internal DevExpress.XtraPivotGrid.PivotGridField fielddetamnt1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldcost1;
		internal DevExpress.XtraPivotGrid.PivotGridField CostAmount;
		internal DevExpress.XtraPivotGrid.PivotGridField Profit;
		internal DevExpress.XtraPivotGrid.PivotGridField fielddtInsertdt;
		internal DevExpress.XtraPivotGrid.PivotGridField fielddtInsertdt2;
		internal DevExpress.XtraPivotGrid.PivotGridField fielddtInsertdt3;
	}
	
}
