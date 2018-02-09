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
	partial class XRItemsAboveMaxim : DevExpress.XtraReports.UI.XtraReport
	{
		
		//XtraReport overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		//Required by the Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Designer
		//It can be modified using the Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.XrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.XrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.XrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.XrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.XrTable2 = new DevExpress.XtraReports.UI.XRTable();
			this.XrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
			this.XrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.DsItemsMinMax1 = new DoorsPOS.WinApp.dsItemsMinMax();
			this.StocksTableAdapter = new DoorsPOS.WinApp.dsItemsMinMaxTableAdapters.stocksTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.XrTable1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.XrTable2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemsMinMax1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrTable1});
			this.Detail.HeightF = (float) (25.0F);
			this.Detail.MultiColumn.ColumnCount = 2;
			this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("item_desc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrTable1
			//
			this.XrTable1.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (0.0F));
			this.XrTable1.Name = "XrTable1";
			this.XrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {this.XrTableRow1});
			this.XrTable1.SizeF = new System.Drawing.SizeF((float) (318.125F), (float) (25.0F));
			//
			//XrTableRow1
			//
			this.XrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {this.XrTableCell1, this.XrTableCell2, this.XrTableCell4, this.XrTableCell3});
			this.XrTableRow1.Name = "XrTableRow1";
			this.XrTableRow1.Weight = 1.0D;
			//
			//XrTableCell1
			//
			this.XrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "stocks.item_desc")});
			this.XrTableCell1.Name = "XrTableCell1";
			this.XrTableCell1.Text = "XrTableCell1";
			this.XrTableCell1.Weight = 1.6777995420517078D;
			//
			//XrTableCell2
			//
			this.XrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "stocks.available", "{0:#,#}")});
			this.XrTableCell2.Name = "XrTableCell2";
			this.XrTableCell2.StylePriority.UseTextAlignment = false;
			this.XrTableCell2.Text = "XrTableCell2";
			this.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell2.Weight = 0.40864419370815597D;
			//
			//XrTableCell4
			//
			this.XrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "stocks.minimum")});
			this.XrTableCell4.Name = "XrTableCell4";
			this.XrTableCell4.StylePriority.UseTextAlignment = false;
			this.XrTableCell4.Text = "XrTableCell4";
			this.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell4.Weight = 0.36345736571235665D;
			//
			//XrTableCell3
			//
			this.XrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "stocks.maximum")});
			this.XrTableCell3.Name = "XrTableCell3";
			this.XrTableCell3.StylePriority.UseTextAlignment = false;
			this.XrTableCell3.Text = "XrTableCell3";
			this.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell3.Weight = 0.55009889852777938D;
			//
			//TopMargin
			//
			this.TopMargin.HeightF = (float) (16.0F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrPageInfo2});
			this.BottomMargin.HeightF = (float) (29.16667F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrPageInfo2
			//
			this.XrPageInfo2.Format = "{0:#,#}";
			this.XrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.00003178914F), (float) (10.00001F));
			this.XrPageInfo2.Name = "XrPageInfo2";
			this.XrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrPageInfo2.SizeF = new System.Drawing.SizeF((float) (150.0F), (float) (15.625F));
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrTable2, this.XrPageInfo1, this.XrLabel1});
			this.ReportHeader.HeightF = (float) (69.79166F);
			this.ReportHeader.Name = "ReportHeader";
			//
			//XrTable2
			//
			this.XrTable2.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrTable2.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.00003178914F), (float) (55.20833F));
			this.XrTable2.Name = "XrTable2";
			this.XrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {this.XrTableRow2});
			this.XrTable2.SizeF = new System.Drawing.SizeF((float) (318.125F), (float) (14.58333F));
			this.XrTable2.StylePriority.UseFont = false;
			//
			//XrTableRow2
			//
			this.XrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {this.XrTableCell5, this.XrTableCell6, this.XrTableCell7, this.XrTableCell8});
			this.XrTableRow2.Name = "XrTableRow2";
			this.XrTableRow2.Weight = 1.0D;
			//
			//XrTableCell5
			//
			this.XrTableCell5.Name = "XrTableCell5";
			this.XrTableCell5.Text = "Item Description";
			this.XrTableCell5.Weight = 1.7875D;
			//
			//XrTableCell6
			//
			this.XrTableCell6.Name = "XrTableCell6";
			this.XrTableCell6.StylePriority.UseTextAlignment = false;
			this.XrTableCell6.Text = "Available";
			this.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell6.Weight = 1.5312499046325683D;
			//
			//XrTableCell7
			//
			this.XrTableCell7.Name = "XrTableCell7";
			this.XrTableCell7.StylePriority.UseTextAlignment = false;
			this.XrTableCell7.Text = "Min";
			this.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell7.Weight = 0.57812483787536606D;
			//
			//XrTableCell8
			//
			this.XrTableCell8.Name = "XrTableCell8";
			this.XrTableCell8.StylePriority.UseTextAlignment = false;
			this.XrTableCell8.Text = "Max";
			this.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell8.Weight = 0.87500060081481923D;
			//
			//XrPageInfo1
			//
			this.XrPageInfo1.Format = "{0:MM/dd/yyyy h:mm tt}";
			this.XrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.00003178914F), (float) (23.95835F));
			this.XrPageInfo1.Name = "XrPageInfo1";
			this.XrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.XrPageInfo1.SizeF = new System.Drawing.SizeF((float) (150.0F), (float) (15.625F));
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.00003178914F), (float) (0.0F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (728.0F), (float) (23.95834F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "ITEMS ABOVE MAXIMUM RE-ORDER LEVEL";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//DsItemsMinMax1
			//
			this.DsItemsMinMax1.DataSetName = "dsItemsMinMax";
			this.DsItemsMinMax1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//StocksTableAdapter
			//
			this.StocksTableAdapter.ClearBeforeFill = true;
			//
			//XRItemsAboveMaxim
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.ReportHeader});
			this.DataAdapter = this.StocksTableAdapter;
			this.DataMember = "stocks";
			this.DataSource = this.DsItemsMinMax1;
			this.FilterString = "[available] >= [maximum]";
			this.Margins = new System.Drawing.Printing.Margins(67, 55, 16, 29);
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "13.2";
			((System.ComponentModel.ISupportInitialize) this.XrTable1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.XrTable2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemsMinMax1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRPageInfo XrPageInfo1;
		internal DevExpress.XtraReports.UI.XRTable XrTable2;
		internal DevExpress.XtraReports.UI.XRTableRow XrTableRow2;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell5;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell6;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell7;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell8;
		internal DoorsPOS.WinApp.dsItemsMinMax DsItemsMinMax1;
		internal DoorsPOS.WinApp.dsItemsMinMaxTableAdapters.stocksTableAdapter StocksTableAdapter;
		internal DevExpress.XtraReports.UI.XRTable XrTable1;
		internal DevExpress.XtraReports.UI.XRTableRow XrTableRow1;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell1;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell2;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell4;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell3;
		internal DevExpress.XtraReports.UI.XRPageInfo XrPageInfo2;
	}
	
}
