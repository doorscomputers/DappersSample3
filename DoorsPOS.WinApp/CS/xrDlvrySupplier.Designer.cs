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
	partial class xrDlvrySupplier : DevExpress.XtraReports.UI.XtraReport
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
			DevExpress.XtraReports.UI.XRSummary XrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.DsvwDeliveries1 = new DoorsPOS.WinApp.dsvwDeliveries();
			this.VwDlvryDetailsTableAdapter = new DoorsPOS.WinApp.dsvwDeliveriesTableAdapters.vwDlvryDetailsTableAdapter();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.XrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
			this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.XrLine3 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.XrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine2 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize) this.DsvwDeliveries1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.HeightF = (float) (0.0F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel5
			//
			this.XrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.item_desc")});
			this.XrLabel5.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F));
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (11.04167F), (float) (0.0F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (344.7917F), (float) (23.0F));
			this.XrLabel5.StylePriority.UseFont = false;
			this.XrLabel5.Text = "XrLabel5";
			//
			//XrLabel3
			//
			this.XrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.drdetamnt", "{0:n2}")});
			this.XrLabel3.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F));
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (635.4998F), (float) (0.0F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel3.StylePriority.UseFont = false;
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "XrLabel3";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel4
			//
			this.XrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.cost", "{0:n2}")});
			this.XrLabel4.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F));
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (506.3332F), (float) (0.0F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel4.StylePriority.UseFont = false;
			this.XrLabel4.StylePriority.UseTextAlignment = false;
			this.XrLabel4.Text = "XrLabel4";
			this.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel2
			//
			this.XrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.qty", "{0:n2}")});
			this.XrLabel2.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F));
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (420.9165F), (float) (0.0F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (69.79166F), (float) (23.0F));
			this.XrLabel2.StylePriority.UseFont = false;
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "XrLabel2";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//TopMargin
			//
			this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel7});
			this.TopMargin.HeightF = (float) (23.0F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel7
			//
			this.XrLabel7.Font = new System.Drawing.Font("Times New Roman", (float) (14.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999974F), (float) (0.0F));
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (344.7917F), (float) (23.0F));
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.Text = "Deliveries per Supplier";
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (14.5F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//DsvwDeliveries1
			//
			this.DsvwDeliveries1.DataSetName = "dsvwDeliveries";
			this.DsvwDeliveries1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VwDlvryDetailsTableAdapter
			//
			this.VwDlvryDetailsTableAdapter.ClearBeforeFill = true;
			//
			//XrLabel6
			//
			this.XrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.dtInsert_dt", "{0:MM/dd/yyyy}")});
			this.XrLabel6.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (49.66672F), (float) (33.08334F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (179.5833F), (float) (23.0F));
			this.XrLabel6.StylePriority.UseFont = false;
			this.XrLabel6.Text = "XrLabel6";
			//
			//GroupHeader1
			//
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLine1, this.XrLabel1, this.XrLabel9, this.XrLabel10, this.XrLabel11, this.XrLabel12, this.XrLabel6, this.XrLabel8});
			this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("supplier", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.GroupHeader1.HeightF = (float) (88.54168F);
			this.GroupHeader1.Level = 1;
			this.GroupHeader1.Name = "GroupHeader1";
			//
			//XrLine1
			//
			this.XrLine1.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.58333F), (float) (2.083333F));
			this.XrLine1.Name = "XrLine1";
			this.XrLine1.SizeF = new System.Drawing.SizeF((float) (725.0F), (float) (8.000007F));
			//
			//XrLabel1
			//
			this.XrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.supplier")});
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999974F), (float) (10.08334F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (359.375F), (float) (23.0F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.Text = "XrLabel1";
			//
			//XrLabel9
			//
			this.XrLabel9.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (11.04167F), (float) (65.54168F));
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (243.75F), (float) (23.0F));
			this.XrLabel9.StylePriority.UseFont = false;
			this.XrLabel9.Text = "Item Description";
			//
			//XrLabel10
			//
			this.XrLabel10.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (367.7917F), (float) (65.54168F));
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (123.9583F), (float) (23.0F));
			this.XrLabel10.StylePriority.UseFont = false;
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "Qty";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel11
			//
			this.XrLabel11.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat((float) (544.8749F), (float) (65.54168F));
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel11.SizeF = new System.Drawing.SizeF((float) (62.5F), (float) (23.0F));
			this.XrLabel11.StylePriority.UseFont = false;
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			this.XrLabel11.Text = "Cost";
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel12
			//
			this.XrLabel12.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat((float) (674.0415F), (float) (65.54168F));
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel12.SizeF = new System.Drawing.SizeF((float) (62.5F), (float) (23.0F));
			this.XrLabel12.StylePriority.UseFont = false;
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.Text = "Amount";
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel8
			//
			this.XrLabel8.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F));
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (13.20839F), (float) (33.08334F));
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (36.45833F), (float) (23.0F));
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.Text = "Date ";
			//
			//GroupHeader2
			//
			this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel5, this.XrLabel3, this.XrLabel4, this.XrLabel2});
			this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("dtInsert_dt", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.GroupHeader2.HeightF = (float) (23.0F);
			this.GroupHeader2.Name = "GroupHeader2";
			//
			//DateFrom
			//
			this.DateFrom.Description = "DateFrom";
			this.DateFrom.Name = "DateFrom";
			this.DateFrom.Type = typeof(DateTime);
			this.DateFrom.ValueInfo = "2014-01-01";
			//
			//DateTo
			//
			this.DateTo.Description = "DateTo";
			this.DateTo.Name = "DateTo";
			this.DateTo.Type = typeof(DateTime);
			this.DateTo.ValueInfo = "2014-01-01";
			//
			//ReportFooter
			//
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel13, this.XrLine3, this.XrLabel16});
			this.ReportFooter.HeightF = (float) (78.20829F);
			this.ReportFooter.Name = "ReportFooter";
			this.ReportFooter.StylePriority.UseTextAlignment = false;
			this.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLine3
			//
			this.XrLine3.LocationFloat = new DevExpress.Utils.PointFloat((float) (490.625F), (float) (3.750006F));
			this.XrLine3.Name = "XrLine3";
			this.XrLine3.SizeF = new System.Drawing.SizeF((float) (244.8748F), (float) (6.25F));
			//
			//XrLabel16
			//
			this.XrLabel16.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel16.LocationFloat = new DevExpress.Utils.PointFloat((float) (332.3748F), (float) (10.00001F));
			this.XrLabel16.Name = "XrLabel16";
			this.XrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel16.SizeF = new System.Drawing.SizeF((float) (243.75F), (float) (23.0F));
			this.XrLabel16.StylePriority.UseFont = false;
			this.XrLabel16.StylePriority.UseTextAlignment = false;
			this.XrLabel16.Text = " Grand Total";
			this.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//GroupFooter2
			//
			this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel15, this.XrLine2, this.XrLabel14});
			this.GroupFooter2.HeightF = (float) (33.00001F);
			this.GroupFooter2.Level = 1;
			this.GroupFooter2.Name = "GroupFooter2";
			//
			//XrLabel15
			//
			this.XrLabel15.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat((float) (332.3748F), (float) (10.00001F));
			this.XrLabel15.Name = "XrLabel15";
			this.XrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel15.SizeF = new System.Drawing.SizeF((float) (243.75F), (float) (23.0F));
			this.XrLabel15.StylePriority.UseFont = false;
			this.XrLabel15.StylePriority.UseTextAlignment = false;
			this.XrLabel15.Text = "Sub-Total";
			this.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLine2
			//
			this.XrLine2.LocationFloat = new DevExpress.Utils.PointFloat((float) (490.625F), (float) (2.083333F));
			this.XrLine2.Name = "XrLine2";
			this.XrLine2.SizeF = new System.Drawing.SizeF((float) (247.9167F), (float) (6.25F));
			//
			//XrLabel14
			//
			this.XrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.drdetamnt")});
			this.XrLabel14.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat((float) (576.1248F), (float) (8.333333F));
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel14.SizeF = new System.Drawing.SizeF((float) (160.4167F), (float) (23.0F));
			this.XrLabel14.StylePriority.UseFont = false;
			this.XrLabel14.StylePriority.UseTextAlignment = false;
			XrSummary2.FormatString = "{0:n2}";
			XrSummary2.IgnoreNullValues = true;
			XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.XrLabel14.Summary = XrSummary2;
			this.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel13
			//
			this.XrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.drdetamnt")});
			this.XrLabel13.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat((float) (589.6665F), (float) (10.00001F));
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel13.SizeF = new System.Drawing.SizeF((float) (145.8333F), (float) (23.0F));
			this.XrLabel13.StylePriority.UseFont = false;
			this.XrLabel13.StylePriority.UseTextAlignment = false;
			XrSummary1.FormatString = "{0:n2}";
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Page;
			this.XrLabel13.Summary = XrSummary1;
			this.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//xrDlvrySupplier
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.GroupHeader1, this.GroupHeader2, this.ReportFooter, this.GroupFooter2});
			this.DataAdapter = this.VwDlvryDetailsTableAdapter;
			this.DataMember = "vwDlvryDetails";
			this.DataSource = this.DsvwDeliveries1;
			this.FilterString = "[dtInsert_dt] >= ?DateFrom And [dtInsert_dt] <= ?DateTo";
			this.Margins = new System.Drawing.Printing.Margins(47, 53, 23, 14);
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.DateFrom, this.DateTo});
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "13.2";
			((System.ComponentModel.ISupportInitialize) this.DsvwDeliveries1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DoorsPOS.WinApp.dsvwDeliveries DsvwDeliveries1;
		internal DoorsPOS.WinApp.dsvwDeliveriesTableAdapters.vwDlvryDetailsTableAdapter VwDlvryDetailsTableAdapter;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.Parameters.Parameter DateFrom;
		internal DevExpress.XtraReports.Parameters.Parameter DateTo;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		internal DevExpress.XtraReports.UI.XRLine XrLine1;
		internal DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel14;
		internal DevExpress.XtraReports.UI.XRLine XrLine2;
		internal DevExpress.XtraReports.UI.XRLine XrLine3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel16;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel15;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel13;
	}
	
}
