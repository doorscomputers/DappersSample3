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
	partial class xrTransfers : DevExpress.XtraReports.UI.XtraReport
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
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.DsTransfered1 = new DoorsPOS.WinApp.dsTransfered();
			this.VwTransferedTableAdapter = new DoorsPOS.WinApp.dsTransferedTableAdapters.vwTransferedTableAdapter();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
			this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
			((System.ComponentModel.ISupportInitialize) this.DsTransfered1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel3, this.XrLabel2});
			this.Detail.HeightF = (float) (23.0F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("item_desc", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel3
			//
			this.XrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwTransfered.qty")});
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (511.4583F), (float) (0.0F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "XrLabel3";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel2
			//
			this.XrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwTransfered.item_desc")});
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (260.4167F), (float) (0.0F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (216.6667F), (float) (23.0F));
			this.XrLabel2.Text = "XrLabel2";
			//
			//TopMargin
			//
			this.TopMargin.HeightF = (float) (20.83333F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//DsTransfered1
			//
			this.DsTransfered1.DataSetName = "dsTransfered";
			this.DsTransfered1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VwTransferedTableAdapter
			//
			this.VwTransferedTableAdapter.ClearBeforeFill = true;
			//
			//XrLabel1
			//
			this.XrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwTransfered.location")});
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (123.5417F), (float) (0.0F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (135.8333F), (float) (23.0F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.Text = "XrLabel1";
			//
			//GroupHeader1
			//
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel7, this.XrLabel1, this.XrLabel9, this.XrLabel10});
			this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("location", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.GroupHeader1.HeightF = (float) (23.0F);
			this.GroupHeader1.Name = "GroupHeader1";
			//
			//XrLabel7
			//
			this.XrLabel7.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.41667F), (float) (0.0F));
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (99.58336F), (float) (23.0F));
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.Text = "Transferred to:";
			//
			//XrLabel9
			//
			this.XrLabel9.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (259.375F), (float) (0.0F));
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (122.9167F), (float) (23.0F));
			this.XrLabel9.StylePriority.UseFont = false;
			this.XrLabel9.Text = "Items Transferred";
			//
			//XrLabel10
			//
			this.XrLabel10.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (488.5416F), (float) (0.0F));
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (122.9167F), (float) (23.0F));
			this.XrLabel10.StylePriority.UseFont = false;
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "Qty Transferred";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel4
			//
			this.XrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwTransfered.tdate", "{0:MM/dd/yyyy}")});
			this.XrLabel4.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (123.5417F), (float) (0.0F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (213.5417F), (float) (23.0F));
			this.XrLabel4.StylePriority.UseFont = false;
			this.XrLabel4.Text = "XrLabel4";
			//
			//GroupHeader2
			//
			this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel8, this.XrLabel4});
			this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("tdate", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.GroupHeader2.HeightF = (float) (23.0F);
			this.GroupHeader2.Level = 1;
			this.GroupHeader2.Name = "GroupHeader2";
			//
			//XrLabel8
			//
			this.XrLabel8.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.41667F), (float) (0.0F));
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (113.125F), (float) (23.0F));
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.Text = "Date Transferred:";
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel6, this.XrPageInfo1, this.XrLabel5});
			this.ReportHeader.HeightF = (float) (60.41667F);
			this.ReportHeader.Name = "ReportHeader";
			//
			//XrLabel6
			//
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.41667F), (float) (32.29167F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (72.91667F), (float) (23.0F));
			this.XrLabel6.Text = "Printed On:";
			//
			//XrPageInfo1
			//
			this.XrPageInfo1.Format = "{0:MM/dd/yyyy h:mm tt}";
			this.XrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat((float) (83.33334F), (float) (32.29167F));
			this.XrPageInfo1.Name = "XrPageInfo1";
			this.XrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.XrPageInfo1.SizeF = new System.Drawing.SizeF((float) (176.0417F), (float) (23.0F));
			//
			//XrLabel5
			//
			this.XrLabel5.Font = new System.Drawing.Font("Times New Roman", (float) (14.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (265.0F), (float) (23.0F));
			this.XrLabel5.StylePriority.UseFont = false;
			this.XrLabel5.Text = "Transferred Stocks Report";
			//
			//DateFrom
			//
			this.DateFrom.Description = "Beg Date";
			this.DateFrom.Name = "DateFrom";
			this.DateFrom.Type = typeof(DateTime);
			//
			//DateTo
			//
			this.DateTo.Description = "End Date";
			this.DateTo.Name = "DateTo";
			this.DateTo.Type = typeof(DateTime);
			this.DateTo.ValueInfo = "2014-01-01";
			//
			//xrTransfers
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.GroupHeader1, this.GroupHeader2, this.ReportHeader});
			this.DataAdapter = this.VwTransferedTableAdapter;
			this.DataMember = "vwTransfered";
			this.DataSource = this.DsTransfered1;
			this.FilterString = "[tdate] Between(?DateFrom, ?DateTo)";
			this.Margins = new System.Drawing.Printing.Margins(100, 100, 21, 100);
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.DateFrom, this.DateTo});
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "13.2";
			((System.ComponentModel.ISupportInitialize) this.DsTransfered1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DoorsPOS.WinApp.dsTransfered DsTransfered1;
		internal DoorsPOS.WinApp.dsTransferedTableAdapters.vwTransferedTableAdapter VwTransferedTableAdapter;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRPageInfo XrPageInfo1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.Parameters.Parameter DateFrom;
		internal DevExpress.XtraReports.Parameters.Parameter DateTo;
	}
	
}
