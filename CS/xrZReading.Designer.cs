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
	partial class xrZReading : DevExpress.XtraReports.UI.XtraReport
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
			this.XrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
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
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xRLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.DsReading1 = new DoorsPOS.WinApp.dsReading();
			this.TblreadingTableAdapter = new DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter();
			this.Curentdate = new DevExpress.XtraReports.UI.CalculatedField();
			this.TerminalNo = new DevExpress.XtraReports.Parameters.Parameter();
			this.TenderTot = new DevExpress.XtraReports.UI.CalculatedField();
			this.totalvatsales = new DevExpress.XtraReports.UI.CalculatedField();
			this.XrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel55 = new DevExpress.XtraReports.UI.XRLabel();
			this.totaldailytrans = new DevExpress.XtraReports.UI.CalculatedField();
			this.XrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel57 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel60 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
			this.readingid = new DevExpress.XtraReports.Parameters.Parameter();
			((System.ComponentModel.ISupportInitialize) this.DsReading1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel61, this.XrLabel60, this.XrLabel59, this.XrLabel58, this.XrLabel57, this.XrLabel56, this.XrLabel55, this.XrLabel54, this.XrLabel53, this.XrLabel50, this.XrLabel39, this.XrLabel52, this.XrLabel51, this.XrLabel49, this.XrLabel48, this.XrLabel47, this.XrLabel46, this.XrLabel45, this.XrLabel43, this.XrLabel44, this.XrLabel42, this.XrLabel41, this.XrLabel40, this.XrLabel38, this.XrLabel37, this.XrLabel36, this.XrLabel35, this.XrLabel33, this.XrLabel34, this.XrLabel32, this.XrLabel31, this.XrLabel30, this.XrLabel29, this.XrLabel26, this.XrLabel27, this.XrLabel28, this.XrLabel25, this.XrLabel24, this.XrLabel23, this.XrLabel22, this.XrLabel21, this.XrLabel20, this.XrLabel19, this.XrLabel18, this.XrLabel17, this.XrLabel16, this.XrLabel15, this.XrLabel14, this.XrLabel13, this.XrLabel12, this.XrLabel11, this.XrLabel10, this.XrLabel9, this.XrLabel8, this.XrLabel7});
			this.Detail.HeightF = (float) (693.75F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.StylePriority.UseTextAlignment = false;
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel39
			//
			this.XrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalvatsales", "{0:n2}")});
			this.XrLabel39.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1248F), (float) (296.4167F));
			this.XrLabel39.Name = "XrLabel39";
			this.XrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel39.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04169F));
			this.XrLabel39.StylePriority.UseTextAlignment = false;
			this.XrLabel39.Text = "XrLabel39";
			this.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel52
			//
			this.XrLabel52.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totnonvat", "{0:n2}")});
			this.XrLabel52.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1248F), (float) (276.6251F));
			this.XrLabel52.Name = "XrLabel52";
			this.XrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel52.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04169F));
			this.XrLabel52.StylePriority.UseTextAlignment = false;
			this.XrLabel52.Text = "XrLabel52";
			this.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel51
			//
			this.XrLabel51.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.sumvat", "{0:n2}")});
			this.XrLabel51.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1248F), (float) (317.2501F));
			this.XrLabel51.Name = "XrLabel51";
			this.XrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel51.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04169F));
			this.XrLabel51.StylePriority.UseTextAlignment = false;
			this.XrLabel51.Text = "XrLabel51";
			this.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel49
			//
			this.XrLabel49.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.TenderTot", "{0:n2}")});
			this.XrLabel49.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1248F), (float) (176.3334F));
			this.XrLabel49.Name = "XrLabel49";
			this.XrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel49.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04169F));
			this.XrLabel49.StylePriority.UseTextAlignment = false;
			this.XrLabel49.Text = "XrLabel49";
			this.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel48
			//
			this.XrLabel48.LocationFloat = new DevExpress.Utils.PointFloat((float) (179.0F), (float) (195.0834F));
			this.XrLabel48.Multiline = true;
			this.XrLabel48.Name = "XrLabel48";
			this.XrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel48.SizeF = new System.Drawing.SizeF((float) (97.12485F), (float) (12.83334F));
			this.XrLabel48.StylePriority.UseTextAlignment = false;
			this.XrLabel48.Text = "************";
			this.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel47
			//
			this.XrLabel47.LocationFloat = new DevExpress.Utils.PointFloat((float) (179.0F), (float) (162.7917F));
			this.XrLabel47.Multiline = true;
			this.XrLabel47.Name = "XrLabel47";
			this.XrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel47.SizeF = new System.Drawing.SizeF((float) (97.12485F), (float) (10.75002F));
			this.XrLabel47.StylePriority.UseTextAlignment = false;
			this.XrLabel47.Text = "************";
			this.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel46
			//
			this.XrLabel46.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totzerorated", "{0:n2}")});
			this.XrLabel46.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1249F), (float) (124.9584F));
			this.XrLabel46.Name = "XrLabel46";
			this.XrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel46.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04168F));
			this.XrLabel46.StylePriority.UseTextAlignment = false;
			this.XrLabel46.Text = "XrLabel46";
			this.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel45
			//
			this.XrLabel45.LocationFloat = new DevExpress.Utils.PointFloat((float) (212.3332F), (float) (143.0F));
			this.XrLabel45.Multiline = true;
			this.XrLabel45.Name = "XrLabel45";
			this.XrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel45.SizeF = new System.Drawing.SizeF((float) (63.79164F), (float) (18.04169F));
			this.XrLabel45.StylePriority.UseTextAlignment = false;
			this.XrLabel45.Text = "0";
			this.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel43
			//
			this.XrLabel43.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totvat")});
			this.XrLabel43.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1249F), (float) (106.9167F));
			this.XrLabel43.Name = "XrLabel43";
			this.XrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel43.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04168F));
			this.XrLabel43.StylePriority.UseTextAlignment = false;
			this.XrLabel43.Text = "XrLabel43";
			this.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel44
			//
			this.XrLabel44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totnonvat", "{0:n2}")});
			this.XrLabel44.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1249F), (float) (83.91669F));
			this.XrLabel44.Name = "XrLabel44";
			this.XrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel44.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel44.StylePriority.UseTextAlignment = false;
			this.XrLabel44.Text = "XrLabel44";
			this.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel42
			//
			this.XrLabel42.LocationFloat = new DevExpress.Utils.PointFloat((float) (178.9999F), (float) (39.91668F));
			this.XrLabel42.Multiline = true;
			this.XrLabel42.Name = "XrLabel42";
			this.XrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel42.SizeF = new System.Drawing.SizeF((float) (97.12498F), (float) (18.04168F));
			this.XrLabel42.StylePriority.UseTextAlignment = false;
			this.XrLabel42.Text = "0";
			this.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel41
			//
			this.XrLabel41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totaldiscount", "{0:n2}")});
			this.XrLabel41.LocationFloat = new DevExpress.Utils.PointFloat((float) (179.0F), (float) (21.875F));
			this.XrLabel41.Name = "XrLabel41";
			this.XrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel41.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04168F));
			this.XrLabel41.StylePriority.UseTextAlignment = false;
			this.XrLabel41.Text = "XrLabel41";
			this.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel40
			//
			this.XrLabel40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalsales", "{0:n2}")});
			this.XrLabel40.LocationFloat = new DevExpress.Utils.PointFloat((float) (179.0F), (float) (0.0F));
			this.XrLabel40.Name = "XrLabel40";
			this.XrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel40.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04168F));
			this.XrLabel40.StylePriority.UseTextAlignment = false;
			this.XrLabel40.Text = "XrLabel40";
			this.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel38
			//
			this.XrLabel38.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00004F), (float) (629.667F));
			this.XrLabel38.Multiline = true;
			this.XrLabel38.Name = "XrLabel38";
			this.XrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel38.SizeF = new System.Drawing.SizeF((float) (163.7916F), (float) (18.04175F));
			this.XrLabel38.StylePriority.UseTextAlignment = false;
			this.XrLabel38.Text = "Total Transaction for Today:";
			this.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel37
			//
			this.XrLabel37.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00004F), (float) (610.917F));
			this.XrLabel37.Multiline = true;
			this.XrLabel37.Name = "XrLabel37";
			this.XrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel37.SizeF = new System.Drawing.SizeF((float) (163.7916F), (float) (18.04175F));
			this.XrLabel37.StylePriority.UseTextAlignment = false;
			this.XrLabel37.Text = "Transaction Number  (End):";
			this.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel36
			//
			this.XrLabel36.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00004F), (float) (592.8752F));
			this.XrLabel36.Multiline = true;
			this.XrLabel36.Name = "XrLabel36";
			this.XrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel36.SizeF = new System.Drawing.SizeF((float) (163.7916F), (float) (18.04175F));
			this.XrLabel36.StylePriority.UseTextAlignment = false;
			this.XrLabel36.Text = "Transaction Number  (Beg):";
			this.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel35
			//
			this.XrLabel35.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00004F), (float) (574.8335F));
			this.XrLabel35.Multiline = true;
			this.XrLabel35.Name = "XrLabel35";
			this.XrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel35.SizeF = new System.Drawing.SizeF((float) (120.0416F), (float) (18.04169F));
			this.XrLabel35.StylePriority.UseTextAlignment = false;
			this.XrLabel35.Text = "Z-Reading Counter:";
			this.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel33
			//
			this.XrLabel33.Font = new System.Drawing.Font("Times New Roman", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.XrLabel33.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999983F), (float) (543.9584F));
			this.XrLabel33.Multiline = true;
			this.XrLabel33.Name = "XrLabel33";
			this.XrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel33.SizeF = new System.Drawing.SizeF((float) (268.9999F), (float) (18.04169F));
			this.XrLabel33.StylePriority.UseFont = false;
			this.XrLabel33.StylePriority.UseTextAlignment = false;
			this.XrLabel33.Text = "** GRAND ACCUNULATING INVOICE TOTAL  **";
			this.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel34
			//
			this.XrLabel34.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.000007947286F), (float) (562.0001F));
			this.XrLabel34.Multiline = true;
			this.XrLabel34.Name = "XrLabel34";
			this.XrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel34.SizeF = new System.Drawing.SizeF((float) (289.0F), (float) (12.83331F));
			this.XrLabel34.StylePriority.UseTextAlignment = false;
			this.XrLabel34.Text = "======================================";
			this.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel32
			//
			this.XrLabel32.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.000007947286F), (float) (524.1667F));
			this.XrLabel32.Multiline = true;
			this.XrLabel32.Name = "XrLabel32";
			this.XrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel32.SizeF = new System.Drawing.SizeF((float) (289.0F), (float) (17.00002F));
			this.XrLabel32.StylePriority.UseTextAlignment = false;
			this.XrLabel32.Text = "======================================";
			this.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel31
			//
			this.XrLabel31.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00002F), (float) (492.5834F));
			this.XrLabel31.Multiline = true;
			this.XrLabel31.Name = "XrLabel31";
			this.XrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel31.SizeF = new System.Drawing.SizeF((float) (120.0416F), (float) (18.04169F));
			this.XrLabel31.StylePriority.UseTextAlignment = false;
			this.XrLabel31.Text = "Grand Total End:";
			this.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel30
			//
			this.XrLabel30.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999983F), (float) (474.5417F));
			this.XrLabel30.Multiline = true;
			this.XrLabel30.Name = "XrLabel30";
			this.XrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel30.SizeF = new System.Drawing.SizeF((float) (120.0416F), (float) (18.04169F));
			this.XrLabel30.StylePriority.UseTextAlignment = false;
			this.XrLabel30.Text = "Sales for Today:";
			this.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel29
			//
			this.XrLabel29.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00002F), (float) (454.7501F));
			this.XrLabel29.Multiline = true;
			this.XrLabel29.Name = "XrLabel29";
			this.XrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel29.SizeF = new System.Drawing.SizeF((float) (120.0416F), (float) (18.04169F));
			this.XrLabel29.StylePriority.UseTextAlignment = false;
			this.XrLabel29.Text = "Grand Total (Beg) :";
			this.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel26
			//
			this.XrLabel26.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (402.7084F));
			this.XrLabel26.Multiline = true;
			this.XrLabel26.Name = "XrLabel26";
			this.XrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel26.SizeF = new System.Drawing.SizeF((float) (289.0F), (float) (17.00002F));
			this.XrLabel26.StylePriority.UseTextAlignment = false;
			this.XrLabel26.Text = "======================================";
			this.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel27
			//
			this.XrLabel27.Font = new System.Drawing.Font("Times New Roman", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.XrLabel27.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999983F), (float) (419.7083F));
			this.XrLabel27.Multiline = true;
			this.XrLabel27.Name = "XrLabel27";
			this.XrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel27.SizeF = new System.Drawing.SizeF((float) (268.9999F), (float) (18.04169F));
			this.XrLabel27.StylePriority.UseFont = false;
			this.XrLabel27.StylePriority.UseTextAlignment = false;
			this.XrLabel27.Text = "** GRAND ACCUNULATING TOTAL SALES **";
			this.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel28
			//
			this.XrLabel28.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (437.7501F));
			this.XrLabel28.Multiline = true;
			this.XrLabel28.Name = "XrLabel28";
			this.XrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel28.SizeF = new System.Drawing.SizeF((float) (289.0F), (float) (17.0F));
			this.XrLabel28.StylePriority.UseTextAlignment = false;
			this.XrLabel28.Text = "======================================";
			this.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel25
			//
			this.XrLabel25.LocationFloat = new DevExpress.Utils.PointFloat((float) (26.66667F), (float) (384.6667F));
			this.XrLabel25.Multiline = true;
			this.XrLabel25.Name = "XrLabel25";
			this.XrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel25.SizeF = new System.Drawing.SizeF((float) (84.62498F), (float) (18.04169F));
			this.XrLabel25.StylePriority.UseTextAlignment = false;
			this.XrLabel25.Text = "SUBTOTAL";
			this.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel24
			//
			this.XrLabel24.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (354.25F));
			this.XrLabel24.Multiline = true;
			this.XrLabel24.Name = "XrLabel24";
			this.XrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel24.SizeF = new System.Drawing.SizeF((float) (149.2083F), (float) (18.04169F));
			this.XrLabel24.StylePriority.UseTextAlignment = false;
			this.XrLabel24.Text = "Total Zero-Rated Sales:";
			this.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel23
			//
			this.XrLabel23.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00002F), (float) (335.2917F));
			this.XrLabel23.Multiline = true;
			this.XrLabel23.Name = "XrLabel23";
			this.XrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel23.SizeF = new System.Drawing.SizeF((float) (149.2083F), (float) (18.04169F));
			this.XrLabel23.StylePriority.UseTextAlignment = false;
			this.XrLabel23.Text = "Total VAT Exempt Sales:";
			this.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel22
			//
			this.XrLabel22.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.99999F), (float) (317.2501F));
			this.XrLabel22.Multiline = true;
			this.XrLabel22.Name = "XrLabel22";
			this.XrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel22.SizeF = new System.Drawing.SizeF((float) (133.8333F), (float) (18.04169F));
			this.XrLabel22.StylePriority.UseTextAlignment = false;
			this.XrLabel22.Text = "VAT (12%):";
			this.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel21
			//
			this.XrLabel21.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999998F), (float) (296.4167F));
			this.XrLabel21.Multiline = true;
			this.XrLabel21.Name = "XrLabel21";
			this.XrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel21.SizeF = new System.Drawing.SizeF((float) (133.8333F), (float) (18.04169F));
			this.XrLabel21.StylePriority.UseTextAlignment = false;
			this.XrLabel21.Text = "Total VAT Sales:";
			this.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel20
			//
			this.XrLabel20.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999998F), (float) (276.6251F));
			this.XrLabel20.Multiline = true;
			this.XrLabel20.Name = "XrLabel20";
			this.XrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel20.SizeF = new System.Drawing.SizeF((float) (133.8333F), (float) (18.04169F));
			this.XrLabel20.StylePriority.UseTextAlignment = false;
			this.XrLabel20.Text = "Total Non-VAT Sales:";
			this.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel19
			//
			this.XrLabel19.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.000007947286F), (float) (259.6251F));
			this.XrLabel19.Multiline = true;
			this.XrLabel19.Name = "XrLabel19";
			this.XrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel19.SizeF = new System.Drawing.SizeF((float) (289.0F), (float) (17.00002F));
			this.XrLabel19.StylePriority.UseTextAlignment = false;
			this.XrLabel19.Text = "======================================";
			this.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel18
			//
			this.XrLabel18.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00002F), (float) (241.5834F));
			this.XrLabel18.Multiline = true;
			this.XrLabel18.Name = "XrLabel18";
			this.XrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel18.SizeF = new System.Drawing.SizeF((float) (268.9999F), (float) (18.04169F));
			this.XrLabel18.StylePriority.UseTextAlignment = false;
			this.XrLabel18.Text = "** TAX REPORT **";
			this.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel17
			//
			this.XrLabel17.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (224.5834F));
			this.XrLabel17.Multiline = true;
			this.XrLabel17.Name = "XrLabel17";
			this.XrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel17.SizeF = new System.Drawing.SizeF((float) (289.0F), (float) (17.00002F));
			this.XrLabel17.StylePriority.UseTextAlignment = false;
			this.XrLabel17.Text = "======================================";
			this.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel16
			//
			this.XrLabel16.LocationFloat = new DevExpress.Utils.PointFloat((float) (26.66667F), (float) (206.5417F));
			this.XrLabel16.Multiline = true;
			this.XrLabel16.Name = "XrLabel16";
			this.XrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel16.SizeF = new System.Drawing.SizeF((float) (84.62501F), (float) (18.04169F));
			this.XrLabel16.StylePriority.UseTextAlignment = false;
			this.XrLabel16.Text = "TOTAL";
			this.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel15
			//
			this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat((float) (26.66667F), (float) (176.3334F));
			this.XrLabel15.Multiline = true;
			this.XrLabel15.Name = "XrLabel15";
			this.XrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel15.SizeF = new System.Drawing.SizeF((float) (84.62501F), (float) (18.04169F));
			this.XrLabel15.StylePriority.UseTextAlignment = false;
			this.XrLabel15.Text = "SUBTOTAL";
			this.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel14
			//
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999998F), (float) (143.0F));
			this.XrLabel14.Multiline = true;
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel14.SizeF = new System.Drawing.SizeF((float) (190.875F), (float) (18.04169F));
			this.XrLabel14.StylePriority.UseTextAlignment = false;
			this.XrLabel14.Text = "IO STD CHARTERED STRGT:";
			this.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel13
			//
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00002F), (float) (124.9584F));
			this.XrLabel13.Multiline = true;
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel13.SizeF = new System.Drawing.SizeF((float) (149.2083F), (float) (18.04168F));
			this.XrLabel13.StylePriority.UseTextAlignment = false;
			this.XrLabel13.Text = "ZR Zero Rated TIN:";
			this.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel12
			//
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00002F), (float) (106.9167F));
			this.XrLabel12.Multiline = true;
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel12.SizeF = new System.Drawing.SizeF((float) (149.2083F), (float) (18.04168F));
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.Text = "CA Cash:";
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel11
			//
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (88.87501F));
			this.XrLabel11.Multiline = true;
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel11.SizeF = new System.Drawing.SizeF((float) (149.2083F), (float) (18.04168F));
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			this.XrLabel11.Text = "VE Vat Exempted:";
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel10
			//
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00002F), (float) (70.12501F));
			this.XrLabel10.Multiline = true;
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (149.2083F), (float) (18.04168F));
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "Tender Details:";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel9
			//
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (39.91668F));
			this.XrLabel9.Multiline = true;
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (149.2083F), (float) (18.04168F));
			this.XrLabel9.StylePriority.UseTextAlignment = false;
			this.XrLabel9.Text = "Total Non-Merchandise:";
			this.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel8
			//
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (21.875F));
			this.XrLabel8.Multiline = true;
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (149.2083F), (float) (18.04168F));
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "Total Discounts:";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel7
			//
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel7.Multiline = true;
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (149.2083F), (float) (18.04168F));
			this.XrLabel7.StylePriority.UseTextAlignment = false;
			this.XrLabel7.Text = "Total Merchandise Sales:";
			this.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//TopMargin
			//
			this.TopMargin.HeightF = (float) (5.0F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (10.0F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel6, this.XrLabel5, this.XrLabel4, this.XrLabel3, this.XrLabel2, this.xRLabel1});
			this.ReportHeader.HeightF = (float) (142.7083F);
			this.ReportHeader.Name = "ReportHeader";
			//
			//XrLabel6
			//
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.000007947286F), (float) (121.0F));
			this.XrLabel6.Multiline = true;
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (289.0F), (float) (17.00002F));
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "======================================";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel5
			//
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (97.75F));
			this.XrLabel5.Multiline = true;
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (269.0F), (float) (23.25002F));
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "\"FUND TOTAL\"";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel4
			//
			this.XrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "Curentdate")});
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (143.8333F), (float) (62.58335F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (135.1667F), (float) (23.0F));
			this.XrLabel4.Text = "XrLabel4";
			//
			//XrLabel3
			//
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (93.5833F), (float) (62.33333F));
			this.XrLabel3.Multiline = true;
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (50.24998F), (float) (23.25002F));
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "REG:001";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel2
			//
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (62.58338F));
			this.XrLabel2.Multiline = true;
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (72.12498F), (float) (23.25002F));
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "SN:L3A098";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//xRLabel1
			//
			this.xRLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.xRLabel1.Multiline = true;
			this.xRLabel1.Name = "xRLabel1";
			this.xRLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.xRLabel1.SizeF = new System.Drawing.SizeF((float) (269.0F), (float) (50.08334F));
			this.xRLabel1.StylePriority.UseTextAlignment = false;
			this.xRLabel1.Text = "ABC Company" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "#24 Street JKLMK" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "Z/Terminal Reading";
			this.xRLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
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
			//Curentdate
			//
			this.Curentdate.Expression = "Now()";
			this.Curentdate.Name = "Curentdate";
			//
			//TerminalNo
			//
			this.TerminalNo.Description = "TerminalNo";
			this.TerminalNo.Name = "TerminalNo";
			this.TerminalNo.Type = typeof(int);
			this.TerminalNo.ValueInfo = "0";
			this.TerminalNo.Visible = false;
			//
			//TenderTot
			//
			this.TenderTot.DataMember = "tblreading";
			this.TenderTot.Expression = "[totnonvat] + [totvat]+[totzerorated]";
			this.TenderTot.Name = "TenderTot";
			//
			//totalvatsales
			//
			this.totalvatsales.DataMember = "tblreading";
			this.totalvatsales.Expression = "[totalsales] - [sumvat]";
			this.totalvatsales.Name = "totalvatsales";
			//
			//XrLabel50
			//
			this.XrLabel50.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totzerorated", "{0:n2}")});
			this.XrLabel50.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1248F), (float) (354.25F));
			this.XrLabel50.Name = "XrLabel50";
			this.XrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel50.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel50.StylePriority.UseTextAlignment = false;
			this.XrLabel50.Text = "XrLabel50";
			this.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel53
			//
			this.XrLabel53.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.TenderTot", "{0:n2}")});
			this.XrLabel53.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1249F), (float) (206.5417F));
			this.XrLabel53.Name = "XrLabel53";
			this.XrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel53.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04169F));
			this.XrLabel53.StylePriority.UseTextAlignment = false;
			this.XrLabel53.Text = "XrLabel49";
			this.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel54
			//
			this.XrLabel54.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.prevtotal", "{0:n2}")});
			this.XrLabel54.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1249F), (float) (456.4999F));
			this.XrLabel54.Name = "XrLabel54";
			this.XrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel54.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04175F));
			this.XrLabel54.StylePriority.UseTextAlignment = false;
			this.XrLabel54.Text = "XrLabel54";
			this.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel55
			//
			this.XrLabel55.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalsales", "{0:n2}")});
			this.XrLabel55.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1248F), (float) (474.5417F));
			this.XrLabel55.Name = "XrLabel55";
			this.XrLabel55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel55.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04175F));
			this.XrLabel55.StylePriority.UseTextAlignment = false;
			this.XrLabel55.Text = "XrLabel55";
			this.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//totaldailytrans
			//
			this.totaldailytrans.DataMember = "tblreading";
			this.totaldailytrans.Expression = "[prevtotal] + [totalsales]";
			this.totaldailytrans.Name = "totaldailytrans";
			//
			//XrLabel56
			//
			this.XrLabel56.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totaldailytrans", "{0:n2}")});
			this.XrLabel56.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1249F), (float) (493.2917F));
			this.XrLabel56.Name = "XrLabel56";
			this.XrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel56.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04175F));
			this.XrLabel56.StylePriority.UseTextAlignment = false;
			this.XrLabel56.Text = "XrLabel56";
			this.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel57
			//
			this.XrLabel57.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.begreceipt", "{0:n2}")});
			this.XrLabel57.LocationFloat = new DevExpress.Utils.PointFloat((float) (179.0F), (float) (592.8752F));
			this.XrLabel57.Name = "XrLabel57";
			this.XrLabel57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel57.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04175F));
			this.XrLabel57.StylePriority.UseTextAlignment = false;
			this.XrLabel57.Text = "XrLabel57";
			this.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel58
			//
			this.XrLabel58.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.endreceipt", "{0:n2}")});
			this.XrLabel58.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1248F), (float) (610.917F));
			this.XrLabel58.Name = "XrLabel58";
			this.XrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel58.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04175F));
			this.XrLabel58.StylePriority.UseTextAlignment = false;
			this.XrLabel58.Text = "XrLabel58";
			this.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel59
			//
			this.XrLabel59.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totaldailytrans", "{0:n2}")});
			this.XrLabel59.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1249F), (float) (629.667F));
			this.XrLabel59.Name = "XrLabel59";
			this.XrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel59.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04175F));
			this.XrLabel59.StylePriority.UseTextAlignment = false;
			this.XrLabel59.Text = "XrLabel56";
			this.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel60
			//
			this.XrLabel60.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalsales", "{0:n2}")});
			this.XrLabel60.LocationFloat = new DevExpress.Utils.PointFloat((float) (176.1248F), (float) (384.6667F));
			this.XrLabel60.Name = "XrLabel60";
			this.XrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel60.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.04168F));
			this.XrLabel60.StylePriority.UseTextAlignment = false;
			this.XrLabel60.Text = "XrLabel40";
			this.XrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel61
			//
			this.XrLabel61.LocationFloat = new DevExpress.Utils.PointFloat((float) (212.3332F), (float) (336.2083F));
			this.XrLabel61.Multiline = true;
			this.XrLabel61.Name = "XrLabel61";
			this.XrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel61.SizeF = new System.Drawing.SizeF((float) (63.79164F), (float) (18.04169F));
			this.XrLabel61.StylePriority.UseTextAlignment = false;
			this.XrLabel61.Text = "0";
			this.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//readingid
			//
			this.readingid.Description = "readingid";
			this.readingid.Name = "readingid";
			this.readingid.Type = typeof(int);
			this.readingid.ValueInfo = "0";
			this.readingid.Visible = false;
			//
			//xrZReading
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.ReportHeader});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {this.Curentdate, this.TenderTot, this.totalvatsales, this.totaldailytrans});
			this.DataAdapter = this.TblreadingTableAdapter;
			this.DataMember = "tblreading";
			this.DataSource = this.DsReading1;
			this.FilterString = "[terminal] = ?TerminalNo And [cashreadid] = ?readingid";
			this.Margins = new System.Drawing.Printing.Margins(4, 6, 5, 10);
			this.PageHeight = 1169;
			this.PageWidth = 299;
			this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.PaperName = "Roll Paper 76 x 297 mm";
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.TerminalNo, this.readingid});
			this.PrinterName = "EPSON TM-U220 Receipt";
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "14.1";
			((System.ComponentModel.ISupportInitialize) this.DsReading1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel xRLabel1;
		internal DoorsPOS.WinApp.dsReading DsReading1;
		internal DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter TblreadingTableAdapter;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.CalculatedField Curentdate;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel38;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel37;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel36;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel35;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel33;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel34;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel32;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel31;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel30;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel29;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel26;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel27;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel28;
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
		internal DevExpress.XtraReports.UI.XRLabel XrLabel42;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel41;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel40;
		internal DevExpress.XtraReports.Parameters.Parameter TerminalNo;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel46;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel45;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel43;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel44;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel49;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel48;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel47;
		internal DevExpress.XtraReports.UI.CalculatedField TenderTot;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel39;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel52;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel51;
		internal DevExpress.XtraReports.UI.CalculatedField totalvatsales;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel50;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel53;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel56;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel55;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel54;
		internal DevExpress.XtraReports.UI.CalculatedField totaldailytrans;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel59;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel58;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel57;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel60;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel61;
		internal DevExpress.XtraReports.Parameters.Parameter readingid;
	}
	
}
