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
	partial class xrInvoice : DevExpress.XtraReports.UI.XtraReport
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
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.DsAddtnlCash1 = new DoorsPOS.WinApp.dsAddtnlCash();
			this.AdditnlcashTableAdapter = new DoorsPOS.WinApp.dsAddtnlCashTableAdapters.additnlcashTableAdapter();
			this.SpDataSet11 = new DoorsPOS.WinApp.SpDataSet1();
			this.ReceiptposTableAdapter = new DoorsPOS.WinApp.SpDataSet1TableAdapters.receiptposTableAdapter();
			this.Parameter1 = new DevExpress.XtraReports.Parameters.Parameter();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.Total = new DevExpress.XtraReports.UI.CalculatedField();
			this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.XrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.CustName = new DevExpress.XtraReports.UI.CalculatedField();
			this.XrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize) this.DsAddtnlCash1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.SpDataSet11).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel12, this.XrLabel11, this.XrLabel10, this.XrLabel9});
			this.Detail.HeightF = (float) (33.33333F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//TopMargin
			//
			this.TopMargin.HeightF = (float) (17.70833F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (50.0F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//DsAddtnlCash1
			//
			this.DsAddtnlCash1.DataSetName = "dsAddtnlCash";
			this.DsAddtnlCash1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//AdditnlcashTableAdapter
			//
			this.AdditnlcashTableAdapter.ClearBeforeFill = true;
			//
			//SpDataSet11
			//
			this.SpDataSet11.DataSetName = "SpDataSet1";
			this.SpDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//ReceiptposTableAdapter
			//
			this.ReceiptposTableAdapter.ClearBeforeFill = true;
			//
			//Parameter1
			//
			this.Parameter1.Description = "Parameter1";
			this.Parameter1.Name = "Parameter1";
			this.Parameter1.Type = typeof(int);
			this.Parameter1.ValueInfo = "0";
			this.Parameter1.Visible = false;
			//
			//PageHeader
			//
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel17, this.XrLabel16, this.XrLabel15, this.XrLabel8, this.XrLabel7, this.XrLabel5, this.XrLabel6, this.XrLabel4, this.XrLabel3, this.XrLabel2, this.XrLabel1});
			this.PageHeader.HeightF = (float) (106.25F);
			this.PageHeader.Name = "PageHeader";
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (14.25F), System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (225.0F), (float) (23.0F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.Text = "L i q u i t r a d e ";
			//
			//XrLabel2
			//
			this.XrLabel2.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F));
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (517.2916F), (float) (0.0F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel2.StylePriority.UseFont = false;
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "Invoice No.:";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel3
			//
			this.XrLabel3.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F));
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (35.41667F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (81.25F), (float) (23.0F));
			this.XrLabel3.StylePriority.UseFont = false;
			this.XrLabel3.Text = "Customer:";
			//
			//XrLabel4
			//
			this.XrLabel4.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F));
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (517.2916F), (float) (35.41667F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel4.StylePriority.UseFont = false;
			this.XrLabel4.StylePriority.UseTextAlignment = false;
			this.XrLabel4.Text = "Date:";
			this.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel6
			//
			this.XrLabel6.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (83.25002F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (146.875F), (float) (23.0F));
			this.XrLabel6.StylePriority.UseFont = false;
			this.XrLabel6.Text = "Item Description";
			//
			//XrLabel5
			//
			this.XrLabel5.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (376.6667F), (float) (83.25002F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (70.83331F), (float) (23.0F));
			this.XrLabel5.StylePriority.UseFont = false;
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "Quantity";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel7
			//
			this.XrLabel7.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (640.2083F), (float) (83.25002F));
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (85.41669F), (float) (23.0F));
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.StylePriority.UseTextAlignment = false;
			this.XrLabel7.Text = "Amount";
			this.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel8
			//
			this.XrLabel8.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (488.1249F), (float) (83.25002F));
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (97.91669F), (float) (23.0F));
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "Price";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel9
			//
			this.XrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.item_desc")});
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (359.375F), (float) (23.0F));
			this.XrLabel9.Text = "XrLabel9";
			//
			//XrLabel10
			//
			this.XrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.qty", "{0:n}")});
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (389.1667F), (float) (0.0F));
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (58.33334F), (float) (23.0F));
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "XrLabel10";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel11
			//
			this.XrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.price", "{0:n2}")});
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat((float) (486.0417F), (float) (0.0F));
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel11.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			this.XrLabel11.Text = "XrLabel11";
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel12
			//
			this.XrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.det_amnt", "{0:n2}")});
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat((float) (625.625F), (float) (0.0F));
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel12.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.Text = "XrLabel12";
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//Total
			//
			this.Total.Expression = "[].Sum([det_amnt])";
			this.Total.Name = "Total";
			//
			//XrLabel13
			//
			this.XrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "Total", "{0:n2}")});
			this.XrLabel13.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat((float) (583.9583F), (float) (0.0F));
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel13.SizeF = new System.Drawing.SizeF((float) (141.6667F), (float) (23.0F));
			this.XrLabel13.StylePriority.UseFont = false;
			this.XrLabel13.StylePriority.UseTextAlignment = false;
			this.XrLabel13.Text = "XrLabel13";
			this.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//ReportFooter
			//
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel13, this.XrLabel14});
			this.ReportFooter.HeightF = (float) (28.125F);
			this.ReportFooter.Name = "ReportFooter";
			//
			//XrLabel14
			//
			this.XrLabel14.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat((float) (502.7083F), (float) (0.0F));
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel14.SizeF = new System.Drawing.SizeF((float) (81.25F), (float) (23.0F));
			this.XrLabel14.StylePriority.UseFont = false;
			this.XrLabel14.StylePriority.UseTextAlignment = false;
			this.XrLabel14.Text = "TOTAL:";
			this.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel15
			//
			this.XrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.postmp_hdrid")});
			this.XrLabel15.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F));
			this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat((float) (617.2916F), (float) (0.0F));
			this.XrLabel15.Name = "XrLabel15";
			this.XrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel15.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel15.StylePriority.UseFont = false;
			this.XrLabel15.StylePriority.UseTextAlignment = false;
			this.XrLabel15.Text = "XrLabel15";
			this.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel16
			//
			this.XrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.pos_date", "{0:MM/dd/yyyy}")});
			this.XrLabel16.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F));
			this.XrLabel16.LocationFloat = new DevExpress.Utils.PointFloat((float) (617.2916F), (float) (35.41667F));
			this.XrLabel16.Name = "XrLabel16";
			this.XrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel16.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel16.StylePriority.UseFont = false;
			this.XrLabel16.Text = "XrLabel16";
			//
			//CustName
			//
			this.CustName.Expression = "[lastname]+\',\' + [firstname]";
			this.CustName.Name = "CustName";
			//
			//XrLabel17
			//
			this.XrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustName")});
			this.XrLabel17.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F));
			this.XrLabel17.LocationFloat = new DevExpress.Utils.PointFloat((float) (91.25001F), (float) (35.41667F));
			this.XrLabel17.Name = "XrLabel17";
			this.XrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel17.SizeF = new System.Drawing.SizeF((float) (260.4167F), (float) (23.0F));
			this.XrLabel17.StylePriority.UseFont = false;
			this.XrLabel17.Text = "XrLabel17";
			//
			//xrInvoice
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.PageHeader, this.ReportFooter});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {this.Total, this.CustName});
			this.DataAdapter = this.ReceiptposTableAdapter;
			this.DataMember = "receiptpos";
			this.DataSource = this.SpDataSet11;
			this.FilterString = "[postmp_hdrid] = ?Parameter1";
			this.Margins = new System.Drawing.Printing.Margins(50, 50, 18, 50);
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.Parameter1});
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "13.2";
			((System.ComponentModel.ISupportInitialize) this.DsAddtnlCash1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.SpDataSet11).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DoorsPOS.WinApp.dsAddtnlCash DsAddtnlCash1;
		internal DoorsPOS.WinApp.dsAddtnlCashTableAdapters.additnlcashTableAdapter AdditnlcashTableAdapter;
		internal DoorsPOS.WinApp.SpDataSet1 SpDataSet11;
		internal DoorsPOS.WinApp.SpDataSet1TableAdapters.receiptposTableAdapter ReceiptposTableAdapter;
		internal DevExpress.XtraReports.Parameters.Parameter Parameter1;
		internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.CalculatedField Total;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel13;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel14;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel17;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel16;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel15;
		internal DevExpress.XtraReports.UI.CalculatedField CustName;
	}
	
}
