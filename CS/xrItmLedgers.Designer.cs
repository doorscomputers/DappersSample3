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
	partial class xrItmLedgers : DevExpress.XtraReports.UI.XtraReport
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
			this.XrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.XrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.DsLedger1 = new DoorsPOS.WinApp.dsLedger();
			this.VwItemLedger2TableAdapter = new DoorsPOS.WinApp.dsLedgerTableAdapters.vwItemLedger2TableAdapter();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.Item = new DevExpress.XtraReports.Parameters.Parameter();
			this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
			this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
			this.XrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
			((System.ComponentModel.ISupportInitialize) this.XrTable1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsLedger1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrTable1});
			this.Detail.HeightF = (float) (25.0F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("trans_Date", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrTable1
			//
			this.XrTable1.LocationFloat = new DevExpress.Utils.PointFloat((float) (16.16669F), (float) (0.0F));
			this.XrTable1.Name = "XrTable1";
			this.XrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {this.XrTableRow1});
			this.XrTable1.SizeF = new System.Drawing.SizeF((float) (966.6666F), (float) (25.0F));
			//
			//XrTableRow1
			//
			this.XrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {this.XrTableCell1, this.XrTableCell2, this.XrTableCell3, this.XrTableCell4, this.XrTableCell8, this.XrTableCell7, this.XrTableCell5, this.XrTableCell6, this.XrTableCell10, this.XrTableCell9, this.XrTableCell11});
			this.XrTableRow1.Name = "XrTableRow1";
			this.XrTableRow1.Weight = 1.0D;
			//
			//XrTableCell1
			//
			this.XrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwItemLedger2.trans_Date", "{0:MM/dd/yyyy h:mm tt}")});
			this.XrTableCell1.Name = "XrTableCell1";
			this.XrTableCell1.Text = "XrTableCell1";
			this.XrTableCell1.Weight = 2.3229170227050782D;
			//
			//XrTableCell2
			//
			this.XrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwItemLedger2.qty_purchased")});
			this.XrTableCell2.Name = "XrTableCell2";
			this.XrTableCell2.StylePriority.UseTextAlignment = false;
			this.XrTableCell2.Text = "XrTableCell2";
			this.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell2.Weight = 0.87499984741210923D;
			//
			//XrTableCell3
			//
			this.XrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwItemLedger2.qty_sold", "{0:n2}")});
			this.XrTableCell3.Name = "XrTableCell3";
			this.XrTableCell3.StylePriority.UseTextAlignment = false;
			this.XrTableCell3.Text = "XrTableCell3";
			this.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell3.Weight = 0.70833312988281227D;
			//
			//XrTableCell4
			//
			this.XrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwItemLedger2.qtyreceived")});
			this.XrTableCell4.Name = "XrTableCell4";
			this.XrTableCell4.StylePriority.UseTextAlignment = false;
			this.XrTableCell4.Text = "XrTableCell4";
			this.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell4.Weight = 0.75000000000000011D;
			//
			//XrTableCell8
			//
			this.XrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwItemLedger2.qtyreturned")});
			this.XrTableCell8.Name = "XrTableCell8";
			this.XrTableCell8.StylePriority.UseTextAlignment = false;
			this.XrTableCell8.Text = "XrTableCell8";
			this.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell8.Weight = 0.62630195617675777D;
			//
			//XrTableCell7
			//
			this.XrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwItemLedger2.qtytransfrd")});
			this.XrTableCell7.Name = "XrTableCell7";
			this.XrTableCell7.StylePriority.UseTextAlignment = false;
			this.XrTableCell7.Text = "XrTableCell7";
			this.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell7.Weight = 0.62630195617675777D;
			//
			//XrTableCell5
			//
			this.XrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwItemLedger2.free")});
			this.XrTableCell5.Name = "XrTableCell5";
			this.XrTableCell5.StylePriority.UseTextAlignment = false;
			this.XrTableCell5.Text = "XrTableCell5";
			this.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell5.Weight = 0.49869995117187488D;
			//
			//XrTableCell6
			//
			this.XrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwItemLedger2.backorder")});
			this.XrTableCell6.Name = "XrTableCell6";
			this.XrTableCell6.StylePriority.UseTextAlignment = false;
			this.XrTableCell6.Text = "XrTableCell6";
			this.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell6.Weight = 0.47916622161865241D;
			//
			//XrTableCell10
			//
			this.XrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwItemLedger2.manualinv")});
			this.XrTableCell10.Name = "XrTableCell10";
			this.XrTableCell10.StylePriority.UseTextAlignment = false;
			this.XrTableCell10.Text = "XrTableCell10";
			this.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell10.Weight = 0.84244747161865252D;
			//
			//XrTableCell9
			//
			this.XrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwItemLedger2.Previous_Stock_Balance")});
			this.XrTableCell9.Name = "XrTableCell9";
			this.XrTableCell9.StylePriority.UseTextAlignment = false;
			this.XrTableCell9.Text = "XrTableCell9";
			this.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell9.Weight = 0.96874935150146479D;
			//
			//XrTableCell11
			//
			this.XrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwItemLedger2.Running_Stock_Balance")});
			this.XrTableCell11.Name = "XrTableCell11";
			this.XrTableCell11.StylePriority.UseTextAlignment = false;
			this.XrTableCell11.Text = "XrTableCell11";
			this.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell11.Weight = 0.96874874114990239D;
			//
			//TopMargin
			//
			this.TopMargin.HeightF = (float) (16.66667F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (34.375F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel15
			//
			this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat((float) (335.9583F), (float) (101.0417F));
			this.XrLabel15.Name = "XrLabel15";
			this.XrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel15.SizeF = new System.Drawing.SizeF((float) (70.83334F), (float) (23.0F));
			this.XrLabel15.StylePriority.UseTextAlignment = false;
			this.XrLabel15.Text = "Sold";
			this.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (14.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (18.25002F), (float) (0.0F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (244.7917F), (float) (23.95833F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.Text = "I t e m   L e d g e r";
			//
			//XrLabel14
			//
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat((float) (235.9584F), (float) (101.0417F));
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel14.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel14.StylePriority.UseTextAlignment = false;
			this.XrLabel14.Text = "Purchase";
			this.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel23
			//
			this.XrLabel23.LocationFloat = new DevExpress.Utils.PointFloat((float) (885.9584F), (float) (101.0417F));
			this.XrLabel23.Name = "XrLabel23";
			this.XrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel23.SizeF = new System.Drawing.SizeF((float) (96.87494F), (float) (23.0F));
			this.XrLabel23.StylePriority.UseTextAlignment = false;
			this.XrLabel23.Text = "Current Stock";
			this.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel16
			//
			this.XrLabel16.LocationFloat = new DevExpress.Utils.PointFloat((float) (422.4167F), (float) (101.0417F));
			this.XrLabel16.Name = "XrLabel16";
			this.XrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel16.SizeF = new System.Drawing.SizeF((float) (59.375F), (float) (23.0F));
			this.XrLabel16.StylePriority.UseTextAlignment = false;
			this.XrLabel16.Text = "Recevd";
			this.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel17
			//
			this.XrLabel17.LocationFloat = new DevExpress.Utils.PointFloat((float) (481.7917F), (float) (101.0417F));
			this.XrLabel17.Name = "XrLabel17";
			this.XrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel17.SizeF = new System.Drawing.SizeF((float) (62.63019F), (float) (23.0F));
			this.XrLabel17.StylePriority.UseTextAlignment = false;
			this.XrLabel17.Text = "Ret";
			this.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel18
			//
			this.XrLabel18.LocationFloat = new DevExpress.Utils.PointFloat((float) (544.4218F), (float) (101.0417F));
			this.XrLabel18.Name = "XrLabel18";
			this.XrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel18.SizeF = new System.Drawing.SizeF((float) (58.3334F), (float) (23.0F));
			this.XrLabel18.StylePriority.UseTextAlignment = false;
			this.XrLabel18.Text = "Transfer";
			this.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel19
			//
			this.XrLabel19.LocationFloat = new DevExpress.Utils.PointFloat((float) (604.8386F), (float) (101.0417F));
			this.XrLabel19.Name = "XrLabel19";
			this.XrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel19.SizeF = new System.Drawing.SizeF((float) (52.0835F), (float) (23.0F));
			this.XrLabel19.StylePriority.UseTextAlignment = false;
			this.XrLabel19.Text = "Free";
			this.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel20
			//
			this.XrLabel20.LocationFloat = new DevExpress.Utils.PointFloat((float) (656.9221F), (float) (101.0417F));
			this.XrLabel20.Name = "XrLabel20";
			this.XrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel20.SizeF = new System.Drawing.SizeF((float) (47.91663F), (float) (23.0F));
			this.XrLabel20.StylePriority.UseTextAlignment = false;
			this.XrLabel20.Text = "BO";
			this.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel21
			//
			this.XrLabel21.LocationFloat = new DevExpress.Utils.PointFloat((float) (718.2501F), (float) (101.0417F));
			this.XrLabel21.Name = "XrLabel21";
			this.XrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel21.SizeF = new System.Drawing.SizeF((float) (70.83331F), (float) (23.0F));
			this.XrLabel21.StylePriority.UseTextAlignment = false;
			this.XrLabel21.Text = "Manual";
			this.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel22
			//
			this.XrLabel22.LocationFloat = new DevExpress.Utils.PointFloat((float) (789.0834F), (float) (101.0417F));
			this.XrLabel22.Name = "XrLabel22";
			this.XrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel22.SizeF = new System.Drawing.SizeF((float) (96.87494F), (float) (23.0F));
			this.XrLabel22.StylePriority.UseTextAlignment = false;
			this.XrLabel22.Text = "Previous Stock";
			this.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrPageInfo1
			//
			this.XrPageInfo1.Format = "{0:MM/dd/yyyy h:mm tt}";
			this.XrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.33335F), (float) (27.08333F));
			this.XrPageInfo1.Name = "XrPageInfo1";
			this.XrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.XrPageInfo1.SizeF = new System.Drawing.SizeF((float) (139.5833F), (float) (23.95833F));
			//
			//DsLedger1
			//
			this.DsLedger1.DataSetName = "dsLedger";
			this.DsLedger1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VwItemLedger2TableAdapter
			//
			this.VwItemLedger2TableAdapter.ClearBeforeFill = true;
			//
			//GroupHeader1
			//
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel2, this.XrLabel1, this.XrPageInfo1, this.XrLabel16, this.XrLabel21, this.XrLabel20, this.XrLabel19, this.XrLabel18, this.XrLabel17, this.XrLabel22, this.XrLabel23, this.XrLabel14, this.XrLabel15});
			this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("item_desc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.GroupHeader1.HeightF = (float) (124.0417F);
			this.GroupHeader1.Name = "GroupHeader1";
			this.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand;
			//
			//XrLabel2
			//
			this.XrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwItemLedger2.item_desc")});
			this.XrLabel2.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (18.25002F), (float) (58.95834F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (426.0417F), (float) (23.0F));
			this.XrLabel2.StylePriority.UseFont = false;
			this.XrLabel2.Text = "XrLabel2";
			//
			//Item
			//
			this.Item.Description = "Item";
			this.Item.Name = "Item";
			//
			//DateFrom
			//
			this.DateFrom.Description = "Beg. Date";
			this.DateFrom.Name = "DateFrom";
			this.DateFrom.Type = typeof(DateTime);
			//
			//DateTo
			//
			this.DateTo.Description = "End Date";
			this.DateTo.Name = "DateTo";
			this.DateTo.Type = typeof(DateTime);
			//
			//XrControlStyle1
			//
			this.XrControlStyle1.Name = "XrControlStyle1";
			this.XrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			//
			//xrItmLedgers
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.GroupHeader1});
			this.DataAdapter = this.VwItemLedger2TableAdapter;
			this.DataMember = "vwItemLedger2";
			this.DataSource = this.DsLedger1;
			this.FilterString = "StartsWith([item_desc], ?Item) And [trans_Date] Between(?DateFrom, ?DateTo)";
			this.Landscape = true;
			this.Margins = new System.Drawing.Printing.Margins(54, 47, 17, 34);
			this.PageHeight = 850;
			this.PageWidth = 1100;
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.Item, this.DateFrom, this.DateTo});
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {this.XrControlStyle1});
			this.Version = "13.2";
			((System.ComponentModel.ISupportInitialize) this.XrTable1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsLedger1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel15;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel14;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel23;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel16;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel17;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel18;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel19;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel20;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel21;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel22;
		internal DevExpress.XtraReports.UI.XRPageInfo XrPageInfo1;
		internal DevExpress.XtraReports.UI.XRTable XrTable1;
		internal DevExpress.XtraReports.UI.XRTableRow XrTableRow1;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell1;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell2;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell3;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell4;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell8;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell7;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell5;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell6;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell10;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell9;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell11;
		internal DoorsPOS.WinApp.dsLedger DsLedger1;
		internal DoorsPOS.WinApp.dsLedgerTableAdapters.vwItemLedger2TableAdapter VwItemLedger2TableAdapter;
		internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.Parameters.Parameter Item;
		internal DevExpress.XtraReports.Parameters.Parameter DateFrom;
		internal DevExpress.XtraReports.Parameters.Parameter DateTo;
		internal DevExpress.XtraReports.UI.XRControlStyle XrControlStyle1;
	}
	
}
