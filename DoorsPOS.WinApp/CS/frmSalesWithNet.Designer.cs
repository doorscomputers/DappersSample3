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
	partial class frmSalesWithNet : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmSalesWithNet_Load);
			this.C1DataViewSet1 = new C1.C1DataExtender.C1DataViewSet();
			this.DsSalesWithCost = new DoorsPOS.WinApp.dsSalesWithCost();
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwSaleswCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.coldtInsert_dt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcost = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldet_amnt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.CostAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Profit = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwSaleswCostTableAdapter = new DoorsPOS.WinApp.dsSalesWithCostTableAdapters.vwSaleswCostTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.C1DataViewSet1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsSalesWithCost).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwSaleswCostBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//C1DataViewSet1
			//
			this.C1DataViewSet1.DataSet = this.DsSalesWithCost;
			this.C1DataViewSet1.DiagramXML = "";
			//
			//DsSalesWithCost
			//
			this.DsSalesWithCost.DataSetName = "dsSalesWithCost";
			this.DsSalesWithCost.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwSaleswCostBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(1059, 487);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwSaleswCostBindingSource
			//
			this.VwSaleswCostBindingSource.DataMember = "vwSaleswCost";
			this.VwSaleswCostBindingSource.DataSource = this.DsSalesWithCost;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.coldtInsert_dt, this.colitem_desc, this.colcost, this.colprice, this.colqty, this.coldet_amnt, this.CostAmount, this.Profit});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "cost", this.colcost, ""), new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", this.coldet_amnt, "SUM={0:N2}"), new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Profit", this.Profit, "SUM={0:N2}"), new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CostAmount", this.CostAmount, "SUM={0:N2}"), new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", this.colqty, "SUM={0:0.##}")});
			this.GridView1.Name = "GridView1";
			//
			//coldtInsert_dt
			//
			this.coldtInsert_dt.Caption = "Date Sold";
			this.coldtInsert_dt.FieldName = "dtInsert_dt";
			this.coldtInsert_dt.Name = "coldtInsert_dt";
			this.coldtInsert_dt.Visible = true;
			this.coldtInsert_dt.VisibleIndex = 0;
			this.coldtInsert_dt.Width = 113;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Sold";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 1;
			this.colitem_desc.Width = 228;
			//
			//colcost
			//
			this.colcost.AppearanceHeader.Options.UseTextOptions = true;
			this.colcost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colcost.Caption = "Cost";
			this.colcost.DisplayFormat.FormatString = "N2";
			this.colcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colcost.FieldName = "cost";
			this.colcost.Name = "colcost";
			this.colcost.Visible = true;
			this.colcost.VisibleIndex = 2;
			this.colcost.Width = 115;
			//
			//colprice
			//
			this.colprice.AppearanceHeader.Options.UseTextOptions = true;
			this.colprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colprice.Caption = "Price";
			this.colprice.DisplayFormat.FormatString = "N2";
			this.colprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colprice.FieldName = "price";
			this.colprice.Name = "colprice";
			this.colprice.Visible = true;
			this.colprice.VisibleIndex = 3;
			this.colprice.Width = 115;
			//
			//colqty
			//
			this.colqty.AppearanceHeader.Options.UseTextOptions = true;
			this.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colqty.Caption = "Qty Sold";
			this.colqty.FieldName = "qty";
			this.colqty.Name = "colqty";
			this.colqty.Visible = true;
			this.colqty.VisibleIndex = 4;
			this.colqty.Width = 115;
			//
			//coldet_amnt
			//
			this.coldet_amnt.AppearanceHeader.Options.UseTextOptions = true;
			this.coldet_amnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coldet_amnt.Caption = "Sold Amount";
			this.coldet_amnt.DisplayFormat.FormatString = "N2";
			this.coldet_amnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coldet_amnt.FieldName = "det_amnt";
			this.coldet_amnt.Name = "coldet_amnt";
			this.coldet_amnt.Visible = true;
			this.coldet_amnt.VisibleIndex = 6;
			this.coldet_amnt.Width = 115;
			//
			//CostAmount
			//
			this.CostAmount.AppearanceHeader.Options.UseTextOptions = true;
			this.CostAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.CostAmount.Caption = "Cost Amount";
			this.CostAmount.DisplayFormat.FormatString = "N2";
			this.CostAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.CostAmount.FieldName = "CostAmount";
			this.CostAmount.Name = "CostAmount";
			this.CostAmount.UnboundExpression = "[cost] * [qty]";
			this.CostAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.CostAmount.Visible = true;
			this.CostAmount.VisibleIndex = 5;
			this.CostAmount.Width = 115;
			//
			//Profit
			//
			this.Profit.AppearanceHeader.Options.UseTextOptions = true;
			this.Profit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.Profit.Caption = "Profit";
			this.Profit.DisplayFormat.FormatString = "N2";
			this.Profit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.Profit.FieldName = "Profit";
			this.Profit.Name = "Profit";
			this.Profit.UnboundExpression = "[det_amnt] - [CostAmount]";
			this.Profit.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.Profit.Visible = true;
			this.Profit.VisibleIndex = 7;
			this.Profit.Width = 130;
			//
			//VwSaleswCostTableAdapter
			//
			this.VwSaleswCostTableAdapter.ClearBeforeFill = true;
			//
			//frmSalesWithNet
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1059, 487);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmSalesWithNet";
			this.Text = "Sales With Computed Profit based on Cost when the Item was Sold";
			((System.ComponentModel.ISupportInitialize) this.C1DataViewSet1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsSalesWithCost).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwSaleswCostBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal C1.C1DataExtender.C1DataViewSet C1DataViewSet1;
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DevExpress.XtraGrid.Columns.GridColumn coldtInsert_dt;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colprice;
		internal DevExpress.XtraGrid.Columns.GridColumn colqty;
		internal DevExpress.XtraGrid.Columns.GridColumn coldet_amnt;
		internal DoorsPOS.WinApp.dsSalesWithCost DsSalesWithCost;
		internal System.Windows.Forms.BindingSource VwSaleswCostBindingSource;
		internal DoorsPOS.WinApp.dsSalesWithCostTableAdapters.vwSaleswCostTableAdapter VwSaleswCostTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colcost;
		internal DevExpress.XtraGrid.Columns.GridColumn CostAmount;
		internal DevExpress.XtraGrid.Columns.GridColumn Profit;
	}
	
}
