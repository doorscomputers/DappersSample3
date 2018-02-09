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
	partial class xrDlvry : DevExpress.XtraReports.UI.XtraReport
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
			DevExpress.XtraReports.UI.XRSummary XrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.DsvwDeliveries1 = new DoorsPOS.WinApp.dsvwDeliveries();
			this.VwDlvryDetailsTableAdapter = new DoorsPOS.WinApp.dsvwDeliveriesTableAdapters.vwDlvryDetailsTableAdapter();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.XrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.XrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
			this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
			this.XrLine1 = new DevExpress.XtraReports.UI.XRLine();
			((System.ComponentModel.ISupportInitialize) this.DsvwDeliveries1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel6, this.XrLabel5, this.XrLabel4, this.XrLabel3, this.XrLabel2});
			this.Detail.HeightF = (float) (27.08333F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("dtInsert_dt", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel6
			//
			this.XrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.dtInsert_dt", "{0:MM/dd/yyyy}")});
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (151.4583F), (float) (23.0F));
			this.XrLabel6.Text = "XrLabel6";
			//
			//XrLabel5
			//
			this.XrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.supplier")});
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (566.6667F), (float) (0.0F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (175.3333F), (float) (23.0F));
			this.XrLabel5.Text = "XrLabel5";
			//
			//XrLabel4
			//
			this.XrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.cost")});
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (296.875F), (float) (0.0F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel4.StylePriority.UseTextAlignment = false;
			this.XrLabel4.Text = "XrLabel4";
			this.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel3
			//
			this.XrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.drdetamnt")});
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (426.0417F), (float) (0.0F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "XrLabel3";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel2
			//
			this.XrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.qty")});
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (181.25F), (float) (0.0F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "XrLabel2";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//TopMargin
			//
			this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel7});
			this.TopMargin.HeightF = (float) (25.0F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel7
			//
			this.XrLabel7.Font = new System.Drawing.Font("Times New Roman", (float) (14.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (344.7917F), (float) (23.0F));
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.Text = "Deliveries per Item";
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (19.79167F);
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
			//XrLabel1
			//
			this.XrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.item_desc")});
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00004F), (float) (0.0F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (516.0416F), (float) (23.0F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.Text = "XrLabel1";
			//
			//GroupHeader1
			//
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel12, this.XrLabel11, this.XrLabel10, this.XrLabel9, this.XrLabel8, this.XrLabel1});
			this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("item_desc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.GroupHeader1.HeightF = (float) (53.54171F);
			this.GroupHeader1.Name = "GroupHeader1";
			//
			//XrLabel12
			//
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat((float) (566.6667F), (float) (30.54171F));
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel12.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.Text = "Supplier";
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel11
			//
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat((float) (426.0417F), (float) (30.54167F));
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel11.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			this.XrLabel11.Text = "Amount";
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel10
			//
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (296.875F), (float) (30.54167F));
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "Cost";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel9
			//
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (181.25F), (float) (30.54171F));
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel9.StylePriority.UseTextAlignment = false;
			this.XrLabel9.Text = "Qty";
			this.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel8
			//
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00004F), (float) (30.54167F));
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel8.Text = "Date Delivered";
			//
			//GroupFooter1
			//
			this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLine1, this.XrLabel15, this.XrLabel13, this.XrLabel14});
			this.GroupFooter1.HeightF = (float) (29.24999F);
			this.GroupFooter1.Name = "GroupFooter1";
			//
			//XrLabel15
			//
			this.XrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.drdetamnt")});
			this.XrLabel15.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat((float) (395.8333F), (float) (3.124992F));
			this.XrLabel15.Name = "XrLabel15";
			this.XrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel15.SizeF = new System.Drawing.SizeF((float) (130.2083F), (float) (23.0F));
			this.XrLabel15.StylePriority.UseFont = false;
			this.XrLabel15.StylePriority.UseTextAlignment = false;
			XrSummary1.FormatString = "{0:n2}";
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.XrLabel15.Summary = XrSummary1;
			this.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel13
			//
			this.XrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwDlvryDetails.qty")});
			this.XrLabel13.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat((float) (169.7917F), (float) (3.124992F));
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel13.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel13.StylePriority.UseFont = false;
			this.XrLabel13.StylePriority.UseTextAlignment = false;
			XrSummary2.FormatString = "{0:#,#}";
			XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.XrLabel13.Summary = XrSummary2;
			this.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel14
			//
			this.XrLabel14.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (3.124992F));
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel14.SizeF = new System.Drawing.SizeF((float) (151.4583F), (float) (23.0F));
			this.XrLabel14.StylePriority.UseFont = false;
			this.XrLabel14.Text = "Total Delivered Qty:";
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
			//XrLine1
			//
			this.XrLine1.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00004F), (float) (26.12499F));
			this.XrLine1.Name = "XrLine1";
			this.XrLine1.SizeF = new System.Drawing.SizeF((float) (729.1667F), (float) (3.125F));
			//
			//xrDlvry
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.GroupHeader1, this.GroupFooter1});
			this.DataAdapter = this.VwDlvryDetailsTableAdapter;
			this.DataMember = "vwDlvryDetails";
			this.DataSource = this.DsvwDeliveries1;
			this.FilterString = "[dtInsert_dt] Between(?DateFrom, ?DateTo)";
			this.Margins = new System.Drawing.Printing.Margins(53, 45, 25, 20);
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
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel13;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel14;
		internal DevExpress.XtraReports.Parameters.Parameter DateFrom;
		internal DevExpress.XtraReports.Parameters.Parameter DateTo;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel15;
		internal DevExpress.XtraReports.UI.XRLine XrLine1;
	}
	
}
