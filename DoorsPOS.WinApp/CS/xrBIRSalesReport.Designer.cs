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
	partial class xrBIRSalesReport : DevExpress.XtraReports.UI.XtraReport
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
			this.XrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.XrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xRLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xRLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.DsReading1 = new DoorsPOS.WinApp.dsReading();
			this.TblreadingTableAdapter = new DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter();
			this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
			this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
			this.calcEndBal = new DevExpress.XtraReports.UI.CalculatedField();
			this.XrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize) this.DsReading1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel39, this.XrLabel38, this.XrLabel37, this.XrLabel36, this.XrLabel35, this.XrLabel34, this.XrLabel33, this.XrLabel32, this.XrLabel31, this.XrLabel30, this.XrLabel29, this.XrLabel28, this.XrLabel27, this.XrLabel26});
			this.Detail.HeightF = (float) (32.29167F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel32
			//
			this.XrLabel32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totvat", "{0:n2}")});
			this.XrLabel32.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel32.LocationFloat = new DevExpress.Utils.PointFloat((float) (480.8333F), (float) (0.0F));
			this.XrLabel32.Name = "XrLabel32";
			this.XrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel32.SizeF = new System.Drawing.SizeF((float) (80.20825F), (float) (23.0F));
			this.XrLabel32.StylePriority.UseFont = false;
			this.XrLabel32.StylePriority.UseTextAlignment = false;
			this.XrLabel32.Text = "XrLabel32";
			this.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel31
			//
			this.XrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalsales", "{0:n2}")});
			this.XrLabel31.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel31.LocationFloat = new DevExpress.Utils.PointFloat((float) (392.2917F), (float) (0.0F));
			this.XrLabel31.Name = "XrLabel31";
			this.XrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel31.SizeF = new System.Drawing.SizeF((float) (80.20828F), (float) (23.0F));
			this.XrLabel31.StylePriority.UseFont = false;
			this.XrLabel31.StylePriority.UseTextAlignment = false;
			this.XrLabel31.Text = "XrLabel31";
			this.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel30
			//
			this.XrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.calcEndBal", "{0:n2}")});
			this.XrLabel30.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel30.LocationFloat = new DevExpress.Utils.PointFloat((float) (229.7916F), (float) (0.0F));
			this.XrLabel30.Name = "XrLabel30";
			this.XrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel30.SizeF = new System.Drawing.SizeF((float) (77.08336F), (float) (23.0F));
			this.XrLabel30.StylePriority.UseFont = false;
			this.XrLabel30.StylePriority.UseTextAlignment = false;
			this.XrLabel30.Text = "XrLabel30";
			this.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel29
			//
			this.XrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.prevtotal", "{0:n2}")});
			this.XrLabel29.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel29.LocationFloat = new DevExpress.Utils.PointFloat((float) (312.0834F), (float) (0.0F));
			this.XrLabel29.Name = "XrLabel29";
			this.XrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel29.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel29.StylePriority.UseFont = false;
			this.XrLabel29.StylePriority.UseTextAlignment = false;
			this.XrLabel29.Text = "XrLabel29";
			this.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel28
			//
			this.XrLabel28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.endreceipt")});
			this.XrLabel28.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel28.LocationFloat = new DevExpress.Utils.PointFloat((float) (154.7917F), (float) (0.0F));
			this.XrLabel28.Name = "XrLabel28";
			this.XrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel28.SizeF = new System.Drawing.SizeF((float) (74.99998F), (float) (23.0F));
			this.XrLabel28.StylePriority.UseFont = false;
			this.XrLabel28.StylePriority.UseTextAlignment = false;
			this.XrLabel28.Text = "XrLabel28";
			this.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel27
			//
			this.XrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.begreceipt")});
			this.XrLabel27.Font = new System.Drawing.Font("Times New Roman", (float) (8.25F));
			this.XrLabel27.LocationFloat = new DevExpress.Utils.PointFloat((float) (79.79167F), (float) (0.0F));
			this.XrLabel27.Name = "XrLabel27";
			this.XrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel27.SizeF = new System.Drawing.SizeF((float) (74.99998F), (float) (23.0F));
			this.XrLabel27.StylePriority.UseFont = false;
			this.XrLabel27.Text = "XrLabel27";
			//
			//XrLabel26
			//
			this.XrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.datereading", "{0:MM/dd/yyyy}")});
			this.XrLabel26.Font = new System.Drawing.Font("Times New Roman", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.XrLabel26.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel26.Name = "XrLabel26";
			this.XrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel26.SizeF = new System.Drawing.SizeF((float) (69.79166F), (float) (23.0F));
			this.XrLabel26.StylePriority.UseFont = false;
			this.XrLabel26.Text = "XrLabel26";
			//
			//TopMargin
			//
			this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel25, this.XrLabel24, this.XrLabel23, this.XrLabel22, this.XrLabel21, this.XrLabel20, this.XrLabel19, this.XrLabel18, this.XrLabel17, this.XrLabel16, this.XrLabel15, this.XrLabel14, this.XrLabel13, this.XrLabel12, this.XrLabel11, this.XrLabel10, this.XrLabel9, this.XrLabel8, this.XrLabel7, this.XrLabel6, this.XrLabel5, this.XrLabel4, this.xRLabel3, this.XrLabel2, this.xRLabel1});
			this.TopMargin.HeightF = (float) (145.625F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel25
			//
			this.XrLabel25.LocationFloat = new DevExpress.Utils.PointFloat((float) (1283.958F), (float) (98.66667F));
			this.XrLabel25.Multiline = true;
			this.XrLabel25.Name = "XrLabel25";
			this.XrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel25.SizeF = new System.Drawing.SizeF((float) (96.04163F), (float) (23.0F));
			this.XrLabel25.StylePriority.UseTextAlignment = false;
			this.XrLabel25.Text = "Remarks";
			this.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel24
			//
			this.XrLabel24.LocationFloat = new DevExpress.Utils.PointFloat((float) (1217.292F), (float) (122.625F));
			this.XrLabel24.Multiline = true;
			this.XrLabel24.Name = "XrLabel24";
			this.XrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel24.SizeF = new System.Drawing.SizeF((float) (60.41663F), (float) (23.0F));
			this.XrLabel24.StylePriority.UseTextAlignment = false;
			this.XrLabel24.Text = "Counter";
			this.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel23
			//
			this.XrLabel23.LocationFloat = new DevExpress.Utils.PointFloat((float) (1217.292F), (float) (98.66667F));
			this.XrLabel23.Multiline = true;
			this.XrLabel23.Name = "XrLabel23";
			this.XrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel23.SizeF = new System.Drawing.SizeF((float) (60.41663F), (float) (23.0F));
			this.XrLabel23.StylePriority.UseTextAlignment = false;
			this.XrLabel23.Text = "Reset";
			this.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel22
			//
			this.XrLabel22.LocationFloat = new DevExpress.Utils.PointFloat((float) (1111.042F), (float) (122.625F));
			this.XrLabel22.Multiline = true;
			this.XrLabel22.Name = "XrLabel22";
			this.XrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel22.SizeF = new System.Drawing.SizeF((float) (96.875F), (float) (23.0F));
			this.XrLabel22.StylePriority.UseTextAlignment = false;
			this.XrLabel22.Text = "Overflow";
			this.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel21
			//
			this.XrLabel21.LocationFloat = new DevExpress.Utils.PointFloat((float) (1111.042F), (float) (98.66667F));
			this.XrLabel21.Multiline = true;
			this.XrLabel21.Name = "XrLabel21";
			this.XrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel21.SizeF = new System.Drawing.SizeF((float) (96.875F), (float) (23.0F));
			this.XrLabel21.StylePriority.UseTextAlignment = false;
			this.XrLabel21.Text = "Sales Overrun";
			this.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel20
			//
			this.XrLabel20.LocationFloat = new DevExpress.Utils.PointFloat((float) (1019.375F), (float) (98.66667F));
			this.XrLabel20.Multiline = true;
			this.XrLabel20.Name = "XrLabel20";
			this.XrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel20.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel20.StylePriority.UseTextAlignment = false;
			this.XrLabel20.Text = "Voids";
			this.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel19
			//
			this.XrLabel19.LocationFloat = new DevExpress.Utils.PointFloat((float) (926.6666F), (float) (98.66667F));
			this.XrLabel19.Multiline = true;
			this.XrLabel19.Name = "XrLabel19";
			this.XrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel19.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel19.StylePriority.UseTextAlignment = false;
			this.XrLabel19.Text = "Returns";
			this.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel18
			//
			this.XrLabel18.LocationFloat = new DevExpress.Utils.PointFloat((float) (833.9583F), (float) (98.66667F));
			this.XrLabel18.Multiline = true;
			this.XrLabel18.Name = "XrLabel18";
			this.XrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel18.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel18.StylePriority.UseTextAlignment = false;
			this.XrLabel18.Text = "Discounts";
			this.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel17
			//
			this.XrLabel17.LocationFloat = new DevExpress.Utils.PointFloat((float) (741.25F), (float) (121.6667F));
			this.XrLabel17.Multiline = true;
			this.XrLabel17.Name = "XrLabel17";
			this.XrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel17.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel17.StylePriority.UseTextAlignment = false;
			this.XrLabel17.Text = "Sales";
			this.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel16
			//
			this.XrLabel16.LocationFloat = new DevExpress.Utils.PointFloat((float) (652.7083F), (float) (121.6667F));
			this.XrLabel16.Multiline = true;
			this.XrLabel16.Name = "XrLabel16";
			this.XrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel16.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel16.StylePriority.UseTextAlignment = false;
			this.XrLabel16.Text = "Sales";
			this.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel15
			//
			this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat((float) (741.25F), (float) (98.66667F));
			this.XrLabel15.Multiline = true;
			this.XrLabel15.Name = "XrLabel15";
			this.XrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel15.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel15.StylePriority.UseTextAlignment = false;
			this.XrLabel15.Text = "Zero Rated";
			this.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel14
			//
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat((float) (652.7083F), (float) (98.66667F));
			this.XrLabel14.Multiline = true;
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel14.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel14.StylePriority.UseTextAlignment = false;
			this.XrLabel14.Text = "VAT Exempt";
			this.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel13
			//
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat((float) (566.25F), (float) (98.66667F));
			this.XrLabel13.Multiline = true;
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel13.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel13.StylePriority.UseTextAlignment = false;
			this.XrLabel13.Text = "VAT Amount";
			this.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel12
			//
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat((float) (480.8333F), (float) (98.66667F));
			this.XrLabel12.Multiline = true;
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel12.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.Text = "VAT Sales";
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel11
			//
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat((float) (392.2917F), (float) (98.66667F));
			this.XrLabel11.Multiline = true;
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel11.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			this.XrLabel11.Text = "Total Sales";
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel10
			//
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (312.0834F), (float) (121.6667F));
			this.XrLabel10.Multiline = true;
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "Balance";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel9
			//
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (312.0834F), (float) (98.66667F));
			this.XrLabel9.Multiline = true;
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel9.StylePriority.UseTextAlignment = false;
			this.XrLabel9.Text = "Beginning";
			this.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel8
			//
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (226.6667F), (float) (121.6667F));
			this.XrLabel8.Multiline = true;
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "Balance";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel7
			//
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (226.6667F), (float) (98.66667F));
			this.XrLabel7.Multiline = true;
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel7.StylePriority.UseTextAlignment = false;
			this.XrLabel7.Text = "Ending " + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10));
			this.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel6
			//
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (170.4167F), (float) (121.6667F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (56.25003F), (float) (23.0F));
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "To";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel5
			//
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (79.79167F), (float) (121.6667F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (42.70834F), (float) (23.0F));
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "From";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel4
			//
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (79.79167F), (float) (98.66667F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (146.875F), (float) (23.0F));
			this.XrLabel4.StylePriority.UseTextAlignment = false;
			this.XrLabel4.Text = "Invoice Number";
			this.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//xRLabel3
			//
			this.xRLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (98.66667F));
			this.xRLabel3.Name = "xRLabel3";
			this.xRLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.xRLabel3.SizeF = new System.Drawing.SizeF((float) (69.79166F), (float) (23.0F));
			this.xRLabel3.Text = "Date";
			//
			//XrLabel2
			//
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (46.95832F));
			this.XrLabel2.Multiline = true;
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (1370.0F), (float) (20.91667F));
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "POS X, Serial Number XX-AXXX Machine Number XXXXXXXXX";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//xRLabel1
			//
			this.xRLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.xRLabel1.Multiline = true;
			this.xRLabel1.Name = "xRLabel1";
			this.xRLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.xRLabel1.SizeF = new System.Drawing.SizeF((float) (1370.0F), (float) (46.95834F));
			this.xRLabel1.StylePriority.UseTextAlignment = false;
			this.xRLabel1.Text = "BIR Sales Report" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "Store Code :XXX" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "Tin Number: XXX-XXX-XXX-000" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10));
			this.xRLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (5.0F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//DsReading1
			//
			this.DsReading1.DataSetName = "dsReading";
			this.DsReading1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//TblreadingTableAdapter
			//
			this.TblreadingTableAdapter.ClearBeforeFill = true;
			//
			//DateFrom
			//
			this.DateFrom.Description = "DateFrom";
			this.DateFrom.Name = "DateFrom";
			this.DateFrom.Type = typeof(DateTime);
			this.DateFrom.ValueInfo = "2014-07-01";
			//
			//DateTo
			//
			this.DateTo.Description = "DateTo";
			this.DateTo.Name = "DateTo";
			this.DateTo.Type = typeof(DateTime);
			this.DateTo.ValueInfo = "2099-01-01";
			//
			//calcEndBal
			//
			this.calcEndBal.DataMember = "tblreading";
			this.calcEndBal.Expression = "[prevtotal] + [totalsales]";
			this.calcEndBal.Name = "calcEndBal";
			//
			//XrLabel33
			//
			this.XrLabel33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.sumvat", "{0:n2}")});
			this.XrLabel33.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel33.LocationFloat = new DevExpress.Utils.PointFloat((float) (566.2501F), (float) (0.0F));
			this.XrLabel33.Name = "XrLabel33";
			this.XrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel33.SizeF = new System.Drawing.SizeF((float) (80.20825F), (float) (23.0F));
			this.XrLabel33.StylePriority.UseFont = false;
			this.XrLabel33.StylePriority.UseTextAlignment = false;
			this.XrLabel33.Text = "XrLabel33";
			this.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel34
			//
			this.XrLabel34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totnonvat", "{0:n2}")});
			this.XrLabel34.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel34.LocationFloat = new DevExpress.Utils.PointFloat((float) (652.7083F), (float) (0.0F));
			this.XrLabel34.Name = "XrLabel34";
			this.XrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel34.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel34.StylePriority.UseFont = false;
			this.XrLabel34.StylePriority.UseTextAlignment = false;
			this.XrLabel34.Text = "XrLabel34";
			this.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel35
			//
			this.XrLabel35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totzerorated", "{0:n2}")});
			this.XrLabel35.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel35.LocationFloat = new DevExpress.Utils.PointFloat((float) (732.9166F), (float) (0.0F));
			this.XrLabel35.Name = "XrLabel35";
			this.XrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel35.SizeF = new System.Drawing.SizeF((float) (88.54181F), (float) (23.0F));
			this.XrLabel35.StylePriority.UseFont = false;
			this.XrLabel35.StylePriority.UseTextAlignment = false;
			this.XrLabel35.Text = "XrLabel35";
			this.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel36
			//
			this.XrLabel36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totaldiscount", "{0:n2}")});
			this.XrLabel36.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel36.LocationFloat = new DevExpress.Utils.PointFloat((float) (833.9583F), (float) (0.0F));
			this.XrLabel36.Name = "XrLabel36";
			this.XrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel36.SizeF = new System.Drawing.SizeF((float) (80.20831F), (float) (23.0F));
			this.XrLabel36.StylePriority.UseFont = false;
			this.XrLabel36.StylePriority.UseTextAlignment = false;
			this.XrLabel36.Text = "XrLabel36";
			this.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel37
			//
			this.XrLabel37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalrefs", "{0:n2}")});
			this.XrLabel37.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel37.LocationFloat = new DevExpress.Utils.PointFloat((float) (926.6666F), (float) (0.0F));
			this.XrLabel37.Name = "XrLabel37";
			this.XrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel37.SizeF = new System.Drawing.SizeF((float) (80.20837F), (float) (23.0F));
			this.XrLabel37.StylePriority.UseFont = false;
			this.XrLabel37.StylePriority.UseTextAlignment = false;
			this.XrLabel37.Text = "XrLabel37";
			this.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel38
			//
			this.XrLabel38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.cntvoids", "{0:n2}")});
			this.XrLabel38.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel38.LocationFloat = new DevExpress.Utils.PointFloat((float) (1019.375F), (float) (0.0F));
			this.XrLabel38.Name = "XrLabel38";
			this.XrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel38.SizeF = new System.Drawing.SizeF((float) (80.20819F), (float) (23.0F));
			this.XrLabel38.StylePriority.UseFont = false;
			this.XrLabel38.StylePriority.UseTextAlignment = false;
			this.XrLabel38.Text = "XrLabel38";
			this.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel39
			//
			this.XrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.cashreadid")});
			this.XrLabel39.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel39.LocationFloat = new DevExpress.Utils.PointFloat((float) (1206.875F), (float) (0.0F));
			this.XrLabel39.Name = "XrLabel39";
			this.XrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel39.SizeF = new System.Drawing.SizeF((float) (70.8335F), (float) (23.0F));
			this.XrLabel39.StylePriority.UseFont = false;
			this.XrLabel39.StylePriority.UseTextAlignment = false;
			this.XrLabel39.Text = "XrLabel39";
			this.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//xrBIRSalesReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {this.calcEndBal});
			this.DataAdapter = this.TblreadingTableAdapter;
			this.DataMember = "tblreading";
			this.DataSource = this.DsReading1;
			this.FilterString = "[datereading] >= ?DateFrom And [datereading] <= ?DateTo";
			this.Landscape = true;
			this.Margins = new System.Drawing.Printing.Margins(5, 5, 146, 5);
			this.PageHeight = 850;
			this.PageWidth = 1400;
			this.PaperKind = System.Drawing.Printing.PaperKind.Legal;
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.DateFrom, this.DateTo});
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "14.1";
			((System.ComponentModel.ISupportInitialize) this.DsReading1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel xRLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel25;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel24;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel23;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel22;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel21;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel20;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel19;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel18;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel17;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel16;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel15;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel14;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel13;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel xRLabel3;
		internal DoorsPOS.WinApp.dsReading DsReading1;
		internal DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter TblreadingTableAdapter;
		internal DevExpress.XtraReports.Parameters.Parameter DateFrom;
		internal DevExpress.XtraReports.Parameters.Parameter DateTo;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel26;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel32;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel31;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel30;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel29;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel28;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel27;
		internal DevExpress.XtraReports.UI.CalculatedField calcEndBal;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel39;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel38;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel37;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel36;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel35;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel34;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel33;
	}
	
}
