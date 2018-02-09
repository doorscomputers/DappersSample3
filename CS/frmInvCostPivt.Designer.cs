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
	partial class frmInvCostPivt : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmInvCostPivt_Load);
			this.PivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.PivotGridControl1.DoubleClick += new System.EventHandler(this.PivotGridControl1_DoubleClick);
			this.StocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsItemCostRetail = new DoorsPOS.WinApp.dsItemCostRetail();
			this.fielditemdesc1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldavailable1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldcost1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.PivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.CostAmnt = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldretail1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.StocksTableAdapter = new DoorsPOS.WinApp.dsItemCostRetailTableAdapters.stocksTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.StocksBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemCostRetail).BeginInit();
			this.SuspendLayout();
			//
			//PivotGridControl1
			//
			this.PivotGridControl1.DataSource = this.StocksBindingSource;
			this.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {this.fielditemdesc1, this.fieldavailable1, this.fieldcost1, this.PivotGridField2, this.CostAmnt, this.fieldretail1});
			this.PivotGridControl1.Location = new System.Drawing.Point(0, 0);
			this.PivotGridControl1.Name = "PivotGridControl1";
			this.PivotGridControl1.Size = new System.Drawing.Size(868, 451);
			this.PivotGridControl1.TabIndex = 0;
			//
			//StocksBindingSource
			//
			this.StocksBindingSource.DataMember = "stocks";
			this.StocksBindingSource.DataSource = this.DsItemCostRetail;
			//
			//DsItemCostRetail
			//
			this.DsItemCostRetail.DataSetName = "dsItemCostRetail";
			this.DsItemCostRetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//fielditemdesc1
			//
			this.fielditemdesc1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fielditemdesc1.AreaIndex = 0;
			this.fielditemdesc1.Caption = "Item Description";
			this.fielditemdesc1.FieldName = "item_desc";
			this.fielditemdesc1.Name = "fielditemdesc1";
			this.fielditemdesc1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fielditemdesc1.Width = 208;
			//
			//fieldavailable1
			//
			this.fieldavailable1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldavailable1.AreaIndex = 1;
			this.fieldavailable1.Caption = "Available";
			this.fieldavailable1.FieldName = "available";
			this.fieldavailable1.Name = "fieldavailable1";
			this.fieldavailable1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			//
			//fieldcost1
			//
			this.fieldcost1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldcost1.AreaIndex = 2;
			this.fieldcost1.Caption = "Item Cost";
			this.fieldcost1.CellFormat.FormatString = "N2";
			this.fieldcost1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldcost1.FieldName = "cost";
			this.fieldcost1.GrandTotalText = "Total";
			this.fieldcost1.Name = "fieldcost1";
			this.fieldcost1.TotalCellFormat.FormatString = "N2";
			this.fieldcost1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldcost1.TotalValueFormat.FormatString = "N2";
			this.fieldcost1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldcost1.ValueFormat.FormatString = "N2";
			this.fieldcost1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			//
			//PivotGridField2
			//
			this.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.PivotGridField2.AreaIndex = 1;
			this.PivotGridField2.Caption = "Retail Amount";
			this.PivotGridField2.CellFormat.FormatString = "N2";
			this.PivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.PivotGridField2.Name = "PivotGridField2";
			this.PivotGridField2.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.PivotGridField2.TotalCellFormat.FormatString = "N2";
			this.PivotGridField2.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.PivotGridField2.TotalValueFormat.FormatString = "N2";
			this.PivotGridField2.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.PivotGridField2.UnboundExpression = "[available] * [retail]";
			this.PivotGridField2.UnboundFieldName = "PivotGridField2";
			this.PivotGridField2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.PivotGridField2.ValueFormat.FormatString = "N2";
			this.PivotGridField2.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			//
			//CostAmnt
			//
			this.CostAmnt.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.CostAmnt.AreaIndex = 0;
			this.CostAmnt.Caption = "Cost Amount";
			this.CostAmnt.CellFormat.FormatString = "N2";
			this.CostAmnt.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.CostAmnt.Name = "CostAmnt";
			this.CostAmnt.UnboundExpression = "[available] * [cost]";
			this.CostAmnt.UnboundFieldName = "CostAmnt";
			this.CostAmnt.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			//
			//fieldretail1
			//
			this.fieldretail1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldretail1.AreaIndex = 3;
			this.fieldretail1.Caption = "Item Price";
			this.fieldretail1.CellFormat.FormatString = "N2";
			this.fieldretail1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldretail1.FieldName = "retail";
			this.fieldretail1.Name = "fieldretail1";
			this.fieldretail1.ValueFormat.FormatString = "N2";
			this.fieldretail1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			//
			//StocksTableAdapter
			//
			this.StocksTableAdapter.ClearBeforeFill = true;
			//
			//frmInvCostPivt
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 451);
			this.Controls.Add(this.PivotGridControl1);
			this.Name = "frmInvCostPivt";
			this.Text = "Inventory Cost with Amount Total";
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.StocksBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemCostRetail).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraPivotGrid.PivotGridControl PivotGridControl1;
		internal DoorsPOS.WinApp.dsItemCostRetail DsItemCostRetail;
		internal System.Windows.Forms.BindingSource StocksBindingSource;
		internal DoorsPOS.WinApp.dsItemCostRetailTableAdapters.stocksTableAdapter StocksTableAdapter;
		internal DevExpress.XtraPivotGrid.PivotGridField fielditemdesc1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldavailable1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldcost1;
		internal DevExpress.XtraPivotGrid.PivotGridField PivotGridField2;
		internal DevExpress.XtraPivotGrid.PivotGridField CostAmnt;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldretail1;
	}
	
}
