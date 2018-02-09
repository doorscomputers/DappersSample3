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
	partial class ZoutReprint : DevExpress.XtraReports.UI.XtraReport
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
			this.XrLabel106 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel105 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel104 = new DevExpress.XtraReports.UI.XRLabel();
			this.xRLine6 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel89 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel103 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel102 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel101 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel100 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel99 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel98 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel97 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel96 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel95 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel94 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel93 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel92 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel91 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel90 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel88 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel87 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel86 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel80 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel79 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel78 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel76 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel75 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine5 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel69 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine4 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel74 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel73 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel72 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel71 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine3 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel70 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel68 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel67 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel66 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel64 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel63 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel60 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel55 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel57 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine2 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.DsReading1 = new DoorsPOS.WinApp.dsReading();
			this.TblreadingTableAdapter = new DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.XrLabel85 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel84 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel83 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel82 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel81 = new DevExpress.XtraReports.UI.XRLabel();
			this.xRLTin194 = new DevExpress.XtraReports.UI.XRLabel();
			this.xRLABCCompany = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel77 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.k = new DevExpress.XtraReports.UI.CalculatedField();
			this.fh = new DevExpress.XtraReports.UI.CalculatedField();
			this.th = new DevExpress.XtraReports.UI.CalculatedField();
			this.oh = new DevExpress.XtraReports.UI.CalculatedField();
			this.ffty = new DevExpress.XtraReports.UI.CalculatedField();
			this.twnty = new DevExpress.XtraReports.UI.CalculatedField();
			this.tn = new DevExpress.XtraReports.UI.CalculatedField();
			this.fve = new DevExpress.XtraReports.UI.CalculatedField();
			this.ones = new DevExpress.XtraReports.UI.CalculatedField();
			this.tfc = new DevExpress.XtraReports.UI.CalculatedField();
			this.totcashcnt = new DevExpress.XtraReports.UI.CalculatedField();
			this.postrans = new DevExpress.XtraReports.UI.CalculatedField();
			this.Result1 = new DevExpress.XtraReports.UI.CalculatedField();
			this.Result2 = new DevExpress.XtraReports.UI.CalculatedField();
			this.RefNo = new DevExpress.XtraReports.Parameters.Parameter();
			this.totaccsales = new DevExpress.XtraReports.UI.CalculatedField();
			this.calctotalsales = new DevExpress.XtraReports.UI.CalculatedField();
			this.NetSalesReceipt = new DevExpress.XtraReports.UI.CalculatedField();
			this.VAT = new DevExpress.XtraReports.UI.CalculatedField();
			this.netSalesperPOS = new DevExpress.XtraReports.UI.CalculatedField();
			this.NetsalesforFS = new DevExpress.XtraReports.UI.CalculatedField();
			this.vTotalSales = new DevExpress.XtraReports.UI.CalculatedField();
			((System.ComponentModel.ISupportInitialize) this.DsReading1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel106, this.XrLabel105, this.XrLabel104, this.xRLine6, this.XrLabel89, this.XrLabel103, this.XrLabel102, this.XrLabel101, this.XrLabel100, this.XrLabel99, this.XrLabel98, this.XrLabel97, this.XrLabel96, this.XrLabel95, this.XrLabel94, this.XrLabel93, this.XrLabel92, this.XrLabel91, this.XrLabel90, this.XrLabel88, this.XrLabel87, this.XrLabel86, this.XrLabel80, this.XrLabel79, this.XrLabel78, this.XrLabel76, this.XrLabel75, this.XrLine5, this.XrLabel69, this.XrLine4, this.XrLabel74, this.XrLabel73, this.XrLabel72, this.XrLabel71, this.XrLine3, this.XrLabel70, this.XrLabel68, this.XrLine1, this.XrLabel67, this.XrLabel66, this.XrLabel65, this.XrLabel64, this.XrLabel63, this.XrLabel62, this.XrLabel61, this.XrLabel60, this.XrLabel31, this.XrLabel47, this.XrLabel46, this.XrLabel45, this.XrLabel41, this.XrLabel44, this.XrLabel40, this.XrLabel58, this.XrLabel39, this.XrLabel37, this.XrLabel36, this.XrLabel35, this.XrLabel34, this.XrLabel33, this.XrLabel32, this.XrLabel38, this.XrLabel59, this.XrLabel5, this.XrLabel26, this.XrLabel27, this.XrLabel28, this.XrLabel43, this.XrLabel42, this.XrLabel29, this.XrLabel48, this.XrLabel25, this.XrLabel49, this.XrLabel51, this.XrLabel52, this.XrLabel53, this.XrLabel54, this.XrLabel55, this.XrLabel56, this.XrLabel57, this.XrLabel50, this.XrLine2, this.XrLabel24, this.XrLabel22, this.XrLabel6, this.XrLabel7, this.XrLabel8, this.XrLabel9, this.XrLabel10, this.XrLabel11, this.XrLabel12, this.XrLabel23, this.XrLabel13, this.XrLabel15, this.XrLabel16, this.XrLabel17, this.XrLabel18, this.XrLabel19, this.XrLabel20, this.XrLabel21, this.XrLabel14, this.XrLabel30});
			this.Detail.HeightF = (float) (964.2706F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel106
			//
			this.XrLabel106.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.cntcredits", "{0:n}")});
			this.XrLabel106.LocationFloat = new DevExpress.Utils.PointFloat((float) (133.5F), (float) (460.4791F));
			this.XrLabel106.Name = "XrLabel106";
			this.XrLabel106.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel106.SizeF = new System.Drawing.SizeF((float) (42.45833F), (float) (15.70835F));
			this.XrLabel106.StylePriority.UseTextAlignment = false;
			this.XrLabel106.Text = "XrLabel106";
			this.XrLabel106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel105
			//
			this.XrLabel105.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totaldiscount", "{0:n2}")});
			this.XrLabel105.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel105.LocationFloat = new DevExpress.Utils.PointFloat((float) (184.3752F), (float) (778.7292F));
			this.XrLabel105.Name = "XrLabel105";
			this.XrLabel105.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel105.SizeF = new System.Drawing.SizeF((float) (89.70815F), (float) (15.70834F));
			this.XrLabel105.StylePriority.UseFont = false;
			this.XrLabel105.StylePriority.UseTextAlignment = false;
			this.XrLabel105.Text = "XrLabel103";
			this.XrLabel105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel104
			//
			this.XrLabel104.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel104.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.95848F), (float) (778.7292F));
			this.XrLabel104.Name = "XrLabel104";
			this.XrLabel104.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel104.SizeF = new System.Drawing.SizeF((float) (114.3751F), (float) (15.70837F));
			this.XrLabel104.StylePriority.UseFont = false;
			this.XrLabel104.StylePriority.UseTextAlignment = false;
			this.XrLabel104.Text = "Total Discount";
			this.XrLabel104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//xRLine6
			//
			this.xRLine6.LocationFloat = new DevExpress.Utils.PointFloat((float) (179.1667F), (float) (434.375F));
			this.xRLine6.Name = "xRLine6";
			this.xRLine6.SizeF = new System.Drawing.SizeF((float) (96.87498F), (float) (2.0F));
			//
			//XrLabel89
			//
			this.XrLabel89.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.netSalesperPOS", "{0:n2}")});
			this.XrLabel89.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel89.LocationFloat = new DevExpress.Utils.PointFloat((float) (182.1248F), (float) (396.7708F));
			this.XrLabel89.Name = "XrLabel89";
			this.XrLabel89.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel89.SizeF = new System.Drawing.SizeF((float) (95.08337F), (float) (15.70834F));
			this.XrLabel89.StylePriority.UseFont = false;
			this.XrLabel89.StylePriority.UseTextAlignment = false;
			this.XrLabel89.Text = "XrLabel89";
			this.XrLabel89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel103
			//
			this.XrLabel103.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totaldiscount", "{0:n2}")});
			this.XrLabel103.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel103.LocationFloat = new DevExpress.Utils.PointFloat((float) (187.5F), (float) (381.0624F));
			this.XrLabel103.Name = "XrLabel103";
			this.XrLabel103.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel103.SizeF = new System.Drawing.SizeF((float) (89.70815F), (float) (15.70834F));
			this.XrLabel103.StylePriority.UseFont = false;
			this.XrLabel103.StylePriority.UseTextAlignment = false;
			this.XrLabel103.Text = "XrLabel103";
			this.XrLabel103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel102
			//
			this.XrLabel102.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.cnttotaldiscounts")});
			this.XrLabel102.LocationFloat = new DevExpress.Utils.PointFloat((float) (143.3334F), (float) (381.0624F));
			this.XrLabel102.Name = "XrLabel102";
			this.XrLabel102.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel102.SizeF = new System.Drawing.SizeF((float) (35.66664F), (float) (15.70834F));
			this.XrLabel102.StylePriority.UseTextAlignment = false;
			this.XrLabel102.Text = "XrLabel102";
			this.XrLabel102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel101
			//
			this.XrLabel101.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel101.LocationFloat = new DevExpress.Utils.PointFloat((float) (16.20827F), (float) (381.0624F));
			this.XrLabel101.Name = "XrLabel101";
			this.XrLabel101.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel101.SizeF = new System.Drawing.SizeF((float) (105.3749F), (float) (15.70834F));
			this.XrLabel101.StylePriority.UseFont = false;
			this.XrLabel101.StylePriority.UseTextAlignment = false;
			this.XrLabel101.Text = "Total Discounts";
			this.XrLabel101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel100
			//
			this.XrLabel100.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalsales", "{0:n2}")});
			this.XrLabel100.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel100.LocationFloat = new DevExpress.Utils.PointFloat((float) (177.2082F), (float) (363.3541F));
			this.XrLabel100.Name = "XrLabel100";
			this.XrLabel100.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel100.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel100.StylePriority.UseFont = false;
			this.XrLabel100.StylePriority.UseTextAlignment = false;
			this.XrLabel100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel99
			//
			this.XrLabel99.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel99.LocationFloat = new DevExpress.Utils.PointFloat((float) (16.20827F), (float) (363.3541F));
			this.XrLabel99.Name = "XrLabel99";
			this.XrLabel99.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel99.SizeF = new System.Drawing.SizeF((float) (88.4584F), (float) (15.70834F));
			this.XrLabel99.StylePriority.UseFont = false;
			this.XrLabel99.StylePriority.UseTextAlignment = false;
			this.XrLabel99.Text = "Gross Sales";
			this.XrLabel99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel98
			//
			this.XrLabel98.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.vTotalSales", "{0:n2}")});
			this.XrLabel98.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel98.LocationFloat = new DevExpress.Utils.PointFloat((float) (179.0F), (float) (295.3958F));
			this.XrLabel98.Name = "XrLabel98";
			this.XrLabel98.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel98.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70834F));
			this.XrLabel98.StylePriority.UseFont = false;
			this.XrLabel98.StylePriority.UseTextAlignment = false;
			this.XrLabel98.Text = "XrLabel98";
			this.XrLabel98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel97
			//
			this.XrLabel97.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel97.LocationFloat = new DevExpress.Utils.PointFloat((float) (17.87461F), (float) (295.3958F));
			this.XrLabel97.Name = "XrLabel97";
			this.XrLabel97.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel97.SizeF = new System.Drawing.SizeF((float) (113.4169F), (float) (15.70834F));
			this.XrLabel97.StylePriority.UseFont = false;
			this.XrLabel97.StylePriority.UseTextAlignment = false;
			this.XrLabel97.Text = "Total Sales:";
			this.XrLabel97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel96
			//
			this.XrLabel96.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.NetsalesforFS", "{0:n2}")});
			this.XrLabel96.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel96.LocationFloat = new DevExpress.Utils.PointFloat((float) (177.2081F), (float) (444.7708F));
			this.XrLabel96.Name = "XrLabel96";
			this.XrLabel96.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel96.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70834F));
			this.XrLabel96.StylePriority.UseFont = false;
			this.XrLabel96.StylePriority.UseTextAlignment = false;
			this.XrLabel96.Text = "XrLabel96";
			this.XrLabel96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel95
			//
			this.XrLabel95.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel95.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.95848F), (float) (476.1874F));
			this.XrLabel95.Name = "XrLabel95";
			this.XrLabel95.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel95.SizeF = new System.Drawing.SizeF((float) (138.9585F), (float) (15.70834F));
			this.XrLabel95.StylePriority.UseFont = false;
			this.XrLabel95.StylePriority.UseTextAlignment = false;
			this.XrLabel95.Text = "Net Sales for Receipt";
			this.XrLabel95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel94
			//
			this.XrLabel94.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel94.LocationFloat = new DevExpress.Utils.PointFloat((float) (16.20827F), (float) (444.7708F));
			this.XrLabel94.Name = "XrLabel94";
			this.XrLabel94.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel94.SizeF = new System.Drawing.SizeF((float) (109.7084F), (float) (15.70834F));
			this.XrLabel94.StylePriority.UseFont = false;
			this.XrLabel94.StylePriority.UseTextAlignment = false;
			this.XrLabel94.Text = "Net Sales for FS";
			this.XrLabel94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel93
			//
			this.XrLabel93.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.VAT", "{0:n2}")});
			this.XrLabel93.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel93.LocationFloat = new DevExpress.Utils.PointFloat((float) (177.2082F), (float) (412.4792F));
			this.XrLabel93.Name = "XrLabel93";
			this.XrLabel93.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel93.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70834F));
			this.XrLabel93.StylePriority.UseFont = false;
			this.XrLabel93.StylePriority.UseTextAlignment = false;
			this.XrLabel93.Text = "XrLabel93";
			this.XrLabel93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel92
			//
			this.XrLabel92.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.NetSalesReceipt", "{0:n2}")});
			this.XrLabel92.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel92.LocationFloat = new DevExpress.Utils.PointFloat((float) (175.9583F), (float) (476.1874F));
			this.XrLabel92.Name = "XrLabel92";
			this.XrLabel92.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel92.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel92.StylePriority.UseFont = false;
			this.XrLabel92.StylePriority.UseTextAlignment = false;
			this.XrLabel92.Text = "XrLabel92";
			this.XrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel91
			//
			this.XrLabel91.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel91.LocationFloat = new DevExpress.Utils.PointFloat((float) (16.20827F), (float) (413.4374F));
			this.XrLabel91.Name = "XrLabel91";
			this.XrLabel91.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel91.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel91.StylePriority.UseFont = false;
			this.XrLabel91.StylePriority.UseTextAlignment = false;
			this.XrLabel91.Text = "12% VAT";
			this.XrLabel91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel90
			//
			this.XrLabel90.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.cntreceipt")});
			this.XrLabel90.LocationFloat = new DevExpress.Utils.PointFloat((float) (136.5417F), (float) (396.7708F));
			this.XrLabel90.Name = "XrLabel90";
			this.XrLabel90.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel90.SizeF = new System.Drawing.SizeF((float) (42.45833F), (float) (15.70835F));
			this.XrLabel90.StylePriority.UseTextAlignment = false;
			this.XrLabel90.Text = "XrLabel90";
			this.XrLabel90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel88
			//
			this.XrLabel88.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel88.LocationFloat = new DevExpress.Utils.PointFloat((float) (16.91653F), (float) (396.7708F));
			this.XrLabel88.Name = "XrLabel88";
			this.XrLabel88.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel88.SizeF = new System.Drawing.SizeF((float) (113.4169F), (float) (15.70834F));
			this.XrLabel88.StylePriority.UseFont = false;
			this.XrLabel88.StylePriority.UseTextAlignment = false;
			this.XrLabel88.Text = "Net Sales per POS";
			this.XrLabel88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel87
			//
			this.XrLabel87.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.cnttotalrefunds")});
			this.XrLabel87.LocationFloat = new DevExpress.Utils.PointFloat((float) (144.2084F), (float) (311.1041F));
			this.XrLabel87.Name = "XrLabel87";
			this.XrLabel87.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel87.SizeF = new System.Drawing.SizeF((float) (34.79155F), (float) (15.70837F));
			this.XrLabel87.StylePriority.UseTextAlignment = false;
			this.XrLabel87.Text = "XrLabel87";
			this.XrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel86
			//
			this.XrLabel86.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.calctotalsales")});
			this.XrLabel86.LocationFloat = new DevExpress.Utils.PointFloat((float) (108.4583F), (float) (326.8125F));
			this.XrLabel86.Name = "XrLabel86";
			this.XrLabel86.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel86.SizeF = new System.Drawing.SizeF((float) (70.54169F), (float) (15.70834F));
			this.XrLabel86.StylePriority.UseTextAlignment = false;
			this.XrLabel86.Text = "XrLabel86";
			this.XrLabel86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel80
			//
			this.XrLabel80.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalsales", "{0:n2}")});
			this.XrLabel80.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel80.LocationFloat = new DevExpress.Utils.PointFloat((float) (179.0F), (float) (326.8124F));
			this.XrLabel80.Name = "XrLabel80";
			this.XrLabel80.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel80.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel80.StylePriority.UseFont = false;
			this.XrLabel80.StylePriority.UseTextAlignment = false;
			this.XrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel79
			//
			this.XrLabel79.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalrefs", "{0:n2}")});
			this.XrLabel79.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel79.LocationFloat = new DevExpress.Utils.PointFloat((float) (179.0F), (float) (311.1041F));
			this.XrLabel79.Name = "XrLabel79";
			this.XrLabel79.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel79.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel79.StylePriority.UseFont = false;
			this.XrLabel79.StylePriority.UseTextAlignment = false;
			this.XrLabel79.Text = "XrLabel63";
			this.XrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel78
			//
			this.XrLabel78.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel78.LocationFloat = new DevExpress.Utils.PointFloat((float) (18.45833F), (float) (311.1041F));
			this.XrLabel78.Name = "XrLabel78";
			this.XrLabel78.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel78.SizeF = new System.Drawing.SizeF((float) (90.00011F), (float) (15.70837F));
			this.XrLabel78.StylePriority.UseFont = false;
			this.XrLabel78.StylePriority.UseTextAlignment = false;
			this.XrLabel78.Text = "Total Refunds";
			this.XrLabel78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel76
			//
			this.XrLabel76.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totaccsales", "{0:n2}")});
			this.XrLabel76.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel76.LocationFloat = new DevExpress.Utils.PointFloat((float) (27.37511F), (float) (933.417F));
			this.XrLabel76.Name = "XrLabel76";
			this.XrLabel76.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel76.SizeF = new System.Drawing.SizeF((float) (242.3749F), (float) (19.81268F));
			this.XrLabel76.StylePriority.UseFont = false;
			this.XrLabel76.StylePriority.UseTextAlignment = false;
			this.XrLabel76.Text = "XrLabel76";
			this.XrLabel76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel75
			//
			this.XrLabel75.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel75.LocationFloat = new DevExpress.Utils.PointFloat((float) (13.08346F), (float) (917.7078F));
			this.XrLabel75.Name = "XrLabel75";
			this.XrLabel75.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel75.SizeF = new System.Drawing.SizeF((float) (246.375F), (float) (15.70837F));
			this.XrLabel75.StylePriority.UseFont = false;
			this.XrLabel75.StylePriority.UseTextAlignment = false;
			this.XrLabel75.Text = "TOTAL ACCUMULATED SALES";
			this.XrLabel75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLine5
			//
			this.XrLine5.LocationFloat = new DevExpress.Utils.PointFloat((float) (175.9583F), (float) (794.4376F));
			this.XrLine5.Name = "XrLine5";
			this.XrLine5.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (5.208313F));
			//
			//XrLabel69
			//
			this.XrLabel69.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel69.LocationFloat = new DevExpress.Utils.PointFloat((float) (150.4167F), (float) (860.3755F));
			this.XrLabel69.Name = "XrLabel69";
			this.XrLabel69.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel69.SizeF = new System.Drawing.SizeF((float) (24.79172F), (float) (15.70837F));
			this.XrLabel69.StylePriority.UseFont = false;
			this.XrLabel69.StylePriority.UseTextAlignment = false;
			this.XrLabel69.Text = "-";
			this.XrLabel69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLine4
			//
			this.XrLine4.LocationFloat = new DevExpress.Utils.PointFloat((float) (169.75F), (float) (886.5845F));
			this.XrLine4.Name = "XrLine4";
			this.XrLine4.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (5.208313F));
			//
			//XrLabel74
			//
			this.XrLabel74.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.Result2", "{0:n2}")});
			this.XrLabel74.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel74.LocationFloat = new DevExpress.Utils.PointFloat((float) (185.625F), (float) (870.8754F));
			this.XrLabel74.Name = "XrLabel74";
			this.XrLabel74.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel74.SizeF = new System.Drawing.SizeF((float) (88.45831F), (float) (15.70834F));
			this.XrLabel74.StylePriority.UseFont = false;
			this.XrLabel74.StylePriority.UseTextAlignment = false;
			this.XrLabel74.Text = "XrLabel72";
			this.XrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel73
			//
			this.XrLabel73.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.Result1", "{0:n2}")});
			this.XrLabel73.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel73.LocationFloat = new DevExpress.Utils.PointFloat((float) (185.625F), (float) (847.4795F));
			this.XrLabel73.Name = "XrLabel73";
			this.XrLabel73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel73.SizeF = new System.Drawing.SizeF((float) (88.45831F), (float) (15.70834F));
			this.XrLabel73.StylePriority.UseFont = false;
			this.XrLabel73.StylePriority.UseTextAlignment = false;
			this.XrLabel73.Text = "XrLabel71";
			this.XrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel72
			//
			this.XrLabel72.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.Result2", "{0:n2}")});
			this.XrLabel72.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel72.LocationFloat = new DevExpress.Utils.PointFloat((float) (135.3753F), (float) (799.6459F));
			this.XrLabel72.Name = "XrLabel72";
			this.XrLabel72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel72.SizeF = new System.Drawing.SizeF((float) (140.6664F), (float) (15.70831F));
			this.XrLabel72.StylePriority.UseFont = false;
			this.XrLabel72.StylePriority.UseTextAlignment = false;
			this.XrLabel72.Text = "XrLabel72";
			this.XrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel71
			//
			this.XrLabel71.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.Result1", "{0:n2}")});
			this.XrLabel71.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel71.LocationFloat = new DevExpress.Utils.PointFloat((float) (188.7498F), (float) (720.8541F));
			this.XrLabel71.Name = "XrLabel71";
			this.XrLabel71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel71.SizeF = new System.Drawing.SizeF((float) (88.45831F), (float) (15.70834F));
			this.XrLabel71.StylePriority.UseFont = false;
			this.XrLabel71.StylePriority.UseTextAlignment = false;
			this.XrLabel71.Text = "XrLabel71";
			this.XrLabel71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLine3
			//
			this.XrLine3.LocationFloat = new DevExpress.Utils.PointFloat((float) (175.9583F), (float) (712.25F));
			this.XrLine3.Name = "XrLine3";
			this.XrLine3.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (5.208313F));
			//
			//XrLabel70
			//
			this.XrLabel70.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel70.LocationFloat = new DevExpress.Utils.PointFloat((float) (141.0416F), (float) (758.3539F));
			this.XrLabel70.Name = "XrLabel70";
			this.XrLabel70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel70.SizeF = new System.Drawing.SizeF((float) (24.79172F), (float) (15.70837F));
			this.XrLabel70.StylePriority.UseFont = false;
			this.XrLabel70.StylePriority.UseTextAlignment = false;
			this.XrLabel70.Text = "-";
			this.XrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel68
			//
			this.XrLabel68.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel68.LocationFloat = new DevExpress.Utils.PointFloat((float) (141.0416F), (float) (685.4373F));
			this.XrLabel68.Name = "XrLabel68";
			this.XrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel68.SizeF = new System.Drawing.SizeF((float) (24.79172F), (float) (15.70837F));
			this.XrLabel68.StylePriority.UseFont = false;
			this.XrLabel68.StylePriority.UseTextAlignment = false;
			this.XrLabel68.Text = "+";
			this.XrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLine1
			//
			this.XrLine1.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00001F), (float) (815.3542F));
			this.XrLine1.Name = "XrLine1";
			this.XrLine1.SizeF = new System.Drawing.SizeF((float) (254.0833F), (float) (10.33337F));
			//
			//XrLabel67
			//
			this.XrLabel67.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel67.LocationFloat = new DevExpress.Utils.PointFloat((float) (16.20827F), (float) (763.0208F));
			this.XrLabel67.Name = "XrLabel67";
			this.XrLabel67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel67.SizeF = new System.Drawing.SizeF((float) (114.3751F), (float) (15.70837F));
			this.XrLabel67.StylePriority.UseFont = false;
			this.XrLabel67.StylePriority.UseTextAlignment = false;
			this.XrLabel67.Text = "Total Pickup";
			this.XrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel66
			//
			this.XrLabel66.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.pickup", "{0:n2}")});
			this.XrLabel66.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel66.LocationFloat = new DevExpress.Utils.PointFloat((float) (188.7498F), (float) (763.0208F));
			this.XrLabel66.Name = "XrLabel66";
			this.XrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel66.SizeF = new System.Drawing.SizeF((float) (88.45831F), (float) (15.70834F));
			this.XrLabel66.StylePriority.UseFont = false;
			this.XrLabel66.StylePriority.UseTextAlignment = false;
			this.XrLabel66.Text = "XrLabel40";
			this.XrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel65
			//
			this.XrLabel65.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel65.LocationFloat = new DevExpress.Utils.PointFloat((float) (16.20827F), (float) (747.3126F));
			this.XrLabel65.Name = "XrLabel65";
			this.XrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel65.SizeF = new System.Drawing.SizeF((float) (114.3751F), (float) (15.70837F));
			this.XrLabel65.StylePriority.UseFont = false;
			this.XrLabel65.StylePriority.UseTextAlignment = false;
			this.XrLabel65.Text = "Total COH";
			this.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel64
			//
			this.XrLabel64.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.postrans", "{0:n2}")});
			this.XrLabel64.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel64.LocationFloat = new DevExpress.Utils.PointFloat((float) (188.7498F), (float) (747.3126F));
			this.XrLabel64.Name = "XrLabel64";
			this.XrLabel64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel64.SizeF = new System.Drawing.SizeF((float) (88.45831F), (float) (15.70834F));
			this.XrLabel64.StylePriority.UseFont = false;
			this.XrLabel64.StylePriority.UseTextAlignment = false;
			this.XrLabel64.Text = "XrLabel45";
			this.XrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel63
			//
			this.XrLabel63.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalcheque", "{0:n2}")});
			this.XrLabel63.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel63.LocationFloat = new DevExpress.Utils.PointFloat((float) (188.7498F), (float) (696.5416F));
			this.XrLabel63.Name = "XrLabel63";
			this.XrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel63.SizeF = new System.Drawing.SizeF((float) (88.45831F), (float) (15.70834F));
			this.XrLabel63.StylePriority.UseFont = false;
			this.XrLabel63.StylePriority.UseTextAlignment = false;
			this.XrLabel63.Text = "XrLabel42";
			this.XrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel62
			//
			this.XrLabel62.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel62.LocationFloat = new DevExpress.Utils.PointFloat((float) (16.20827F), (float) (696.5416F));
			this.XrLabel62.Name = "XrLabel62";
			this.XrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel62.SizeF = new System.Drawing.SizeF((float) (98.4584F), (float) (15.70837F));
			this.XrLabel62.StylePriority.UseFont = false;
			this.XrLabel62.StylePriority.UseTextAlignment = false;
			this.XrLabel62.Text = "Total Cheques";
			this.XrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel61
			//
			this.XrLabel61.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel61.LocationFloat = new DevExpress.Utils.PointFloat((float) (16.20827F), (float) (670.7706F));
			this.XrLabel61.Name = "XrLabel61";
			this.XrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel61.SizeF = new System.Drawing.SizeF((float) (114.3751F), (float) (15.70837F));
			this.XrLabel61.StylePriority.UseFont = false;
			this.XrLabel61.StylePriority.UseTextAlignment = false;
			this.XrLabel61.Text = "Total Cash Count";
			this.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel60
			//
			this.XrLabel60.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totcashcnt", "{0:n2}")});
			this.XrLabel60.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel60.LocationFloat = new DevExpress.Utils.PointFloat((float) (188.7498F), (float) (670.7706F));
			this.XrLabel60.Name = "XrLabel60";
			this.XrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel60.SizeF = new System.Drawing.SizeF((float) (88.45831F), (float) (15.70834F));
			this.XrLabel60.StylePriority.UseFont = false;
			this.XrLabel60.StylePriority.UseTextAlignment = false;
			this.XrLabel60.Text = "XrLabel49";
			this.XrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel31
			//
			this.XrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.begincash", "{0:n2}")});
			this.XrLabel31.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel31.LocationFloat = new DevExpress.Utils.PointFloat((float) (179.0F), (float) (504.3958F));
			this.XrLabel31.Name = "XrLabel31";
			this.XrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel31.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel31.StylePriority.UseFont = false;
			this.XrLabel31.StylePriority.UseTextAlignment = false;
			this.XrLabel31.Text = "XrLabel31";
			this.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel47
			//
			this.XrLabel47.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel47.LocationFloat = new DevExpress.Utils.PointFloat((float) (5.083338F), (float) (640.479F));
			this.XrLabel47.Name = "XrLabel47";
			this.XrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel47.SizeF = new System.Drawing.SizeF((float) (255.625F), (float) (15.70834F));
			this.XrLabel47.StylePriority.UseFont = false;
			this.XrLabel47.StylePriority.UseTextAlignment = false;
			this.XrLabel47.Text = "TotCashCount+TotCheques - (Total COH - Pickup)";
			this.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel46
			//
			this.XrLabel46.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel46.LocationFloat = new DevExpress.Utils.PointFloat((float) (2.208598F), (float) (586.0208F));
			this.XrLabel46.Name = "XrLabel46";
			this.XrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel46.SizeF = new System.Drawing.SizeF((float) (122.8333F), (float) (17.79169F));
			this.XrLabel46.StylePriority.UseFont = false;
			this.XrLabel46.StylePriority.UseTextAlignment = false;
			this.XrLabel46.Text = "TOTAL COH";
			this.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel45
			//
			this.XrLabel45.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.postrans", "{0:n2}")});
			this.XrLabel45.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel45.LocationFloat = new DevExpress.Utils.PointFloat((float) (179.0F), (float) (586.0208F));
			this.XrLabel45.Name = "XrLabel45";
			this.XrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel45.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (17.79169F));
			this.XrLabel45.StylePriority.UseFont = false;
			this.XrLabel45.StylePriority.UseTextAlignment = false;
			this.XrLabel45.Text = "XrLabel45";
			this.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel41
			//
			this.XrLabel41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalsales", "{0:n2}")});
			this.XrLabel41.LocationFloat = new DevExpress.Utils.PointFloat((float) (145.3338F), (float) (559.6042F));
			this.XrLabel41.Name = "XrLabel41";
			this.XrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel41.SizeF = new System.Drawing.SizeF((float) (35.45811F), (float) (15.70837F));
			this.XrLabel41.StylePriority.UseTextAlignment = false;
			this.XrLabel41.Text = "XrLabel41";
			this.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrLabel41.Visible = false;
			//
			//XrLabel44
			//
			this.XrLabel44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.addcash", "{0:n2}")});
			this.XrLabel44.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel44.LocationFloat = new DevExpress.Utils.PointFloat((float) (179.0F), (float) (531.7397F));
			this.XrLabel44.Name = "XrLabel44";
			this.XrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel44.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel44.StylePriority.UseFont = false;
			this.XrLabel44.StylePriority.UseTextAlignment = false;
			this.XrLabel44.Text = "XrLabel44";
			this.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel40
			//
			this.XrLabel40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.pickup", "{0:n2}")});
			this.XrLabel40.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel40.LocationFloat = new DevExpress.Utils.PointFloat((float) (179.0F), (float) (609.0208F));
			this.XrLabel40.Name = "XrLabel40";
			this.XrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel40.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel40.StylePriority.UseFont = false;
			this.XrLabel40.StylePriority.UseTextAlignment = false;
			this.XrLabel40.Text = "XrLabel40";
			this.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel58
			//
			this.XrLabel58.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalcredit", "{0:n2}")});
			this.XrLabel58.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel58.LocationFloat = new DevExpress.Utils.PointFloat((float) (175.9583F), (float) (460.4791F));
			this.XrLabel58.Name = "XrLabel58";
			this.XrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel58.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel58.StylePriority.UseFont = false;
			this.XrLabel58.StylePriority.UseTextAlignment = false;
			this.XrLabel58.Text = "XrLabel58";
			this.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel39
			//
			this.XrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.payments", "{0:n2}")});
			this.XrLabel39.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel39.LocationFloat = new DevExpress.Utils.PointFloat((float) (183.9167F), (float) (559.6042F));
			this.XrLabel39.Name = "XrLabel39";
			this.XrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel39.SizeF = new System.Drawing.SizeF((float) (95.0833F), (float) (15.70837F));
			this.XrLabel39.StylePriority.UseFont = false;
			this.XrLabel39.StylePriority.UseTextAlignment = false;
			this.XrLabel39.Text = "XrLabel39";
			this.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel37
			//
			this.XrLabel37.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel37.LocationFloat = new DevExpress.Utils.PointFloat((float) (13.08346F), (float) (889.7095F));
			this.XrLabel37.Name = "XrLabel37";
			this.XrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel37.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel37.StylePriority.UseFont = false;
			this.XrLabel37.StylePriority.UseTextAlignment = false;
			this.XrLabel37.Text = "Over/Short";
			this.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel36
			//
			this.XrLabel36.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel36.LocationFloat = new DevExpress.Utils.PointFloat((float) (18.45833F), (float) (326.8124F));
			this.XrLabel36.Name = "XrLabel36";
			this.XrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel36.SizeF = new System.Drawing.SizeF((float) (63.58324F), (float) (15.70834F));
			this.XrLabel36.StylePriority.UseFont = false;
			this.XrLabel36.StylePriority.UseTextAlignment = false;
			this.XrLabel36.Text = "Sales";
			this.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel35
			//
			this.XrLabel35.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel35.LocationFloat = new DevExpress.Utils.PointFloat((float) (18.00016F), (float) (559.6042F));
			this.XrLabel35.Name = "XrLabel35";
			this.XrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel35.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel35.StylePriority.UseFont = false;
			this.XrLabel35.StylePriority.UseTextAlignment = false;
			this.XrLabel35.Text = "Payments";
			this.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel34
			//
			this.XrLabel34.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel34.LocationFloat = new DevExpress.Utils.PointFloat((float) (18.00016F), (float) (609.0208F));
			this.XrLabel34.Name = "XrLabel34";
			this.XrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel34.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel34.StylePriority.UseFont = false;
			this.XrLabel34.StylePriority.UseTextAlignment = false;
			this.XrLabel34.Text = "Pickup";
			this.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel33
			//
			this.XrLabel33.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel33.LocationFloat = new DevExpress.Utils.PointFloat((float) (18.00016F), (float) (531.7397F));
			this.XrLabel33.Name = "XrLabel33";
			this.XrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel33.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel33.StylePriority.UseFont = false;
			this.XrLabel33.StylePriority.UseTextAlignment = false;
			this.XrLabel33.Text = "Addtnl Cash";
			this.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel32
			//
			this.XrLabel32.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel32.LocationFloat = new DevExpress.Utils.PointFloat((float) (18.00016F), (float) (504.3958F));
			this.XrLabel32.Name = "XrLabel32";
			this.XrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel32.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel32.StylePriority.UseFont = false;
			this.XrLabel32.StylePriority.UseTextAlignment = false;
			this.XrLabel32.Text = "Beg. Cash";
			this.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel38
			//
			this.XrLabel38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.overshort", "{0:n2}")});
			this.XrLabel38.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel38.LocationFloat = new DevExpress.Utils.PointFloat((float) (174.0833F), (float) (891.7928F));
			this.XrLabel38.Name = "XrLabel38";
			this.XrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel38.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel38.StylePriority.UseFont = false;
			this.XrLabel38.StylePriority.UseTextAlignment = false;
			this.XrLabel38.Text = "XrLabel38";
			this.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel59
			//
			this.XrLabel59.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel59.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.95848F), (float) (460.4791F));
			this.XrLabel59.Name = "XrLabel59";
			this.XrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel59.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel59.StylePriority.UseFont = false;
			this.XrLabel59.StylePriority.UseTextAlignment = false;
			this.XrLabel59.Text = "Total Credit";
			this.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel5
			//
			this.XrLabel5.Font = new System.Drawing.Font("Times New Roman", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (158.875F), (float) (14.66667F));
			this.XrLabel5.StylePriority.UseFont = false;
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "Cash Count";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel26
			//
			this.XrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.twentyp", "{0:#,#}")});
			this.XrLabel26.LocationFloat = new DevExpress.Utils.PointFloat((float) (108.4583F), (float) (122.2918F));
			this.XrLabel26.Name = "XrLabel26";
			this.XrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel26.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel26.StylePriority.UseTextAlignment = false;
			this.XrLabel26.Text = "XrLabel26";
			this.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel27
			//
			this.XrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.twohundredp", "{0:#,#}")});
			this.XrLabel27.LocationFloat = new DevExpress.Utils.PointFloat((float) (108.4583F), (float) (75.1667F));
			this.XrLabel27.Name = "XrLabel27";
			this.XrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel27.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel27.StylePriority.UseTextAlignment = false;
			this.XrLabel27.Text = "XrLabel27";
			this.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel28
			//
			this.XrLabel28.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel28.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00001F), (float) (217.5002F));
			this.XrLabel28.Name = "XrLabel28";
			this.XrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel28.SizeF = new System.Drawing.SizeF((float) (169.2917F), (float) (15.99983F));
			this.XrLabel28.StylePriority.UseFont = false;
			this.XrLabel28.StylePriority.UseTextAlignment = false;
			this.XrLabel28.Text = "Close Amount";
			this.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel43
			//
			this.XrLabel43.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel43.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (201.7918F));
			this.XrLabel43.Name = "XrLabel43";
			this.XrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel43.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel43.StylePriority.UseFont = false;
			this.XrLabel43.StylePriority.UseTextAlignment = false;
			this.XrLabel43.Text = "Total Cheques";
			this.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel42
			//
			this.XrLabel42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalcheque", "{0:n2}")});
			this.XrLabel42.LocationFloat = new DevExpress.Utils.PointFloat((float) (162.0834F), (float) (201.7918F));
			this.XrLabel42.Name = "XrLabel42";
			this.XrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel42.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70834F));
			this.XrLabel42.StylePriority.UseTextAlignment = false;
			this.XrLabel42.Text = "XrLabel42";
			this.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel29
			//
			this.XrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.k", "{0:n2}")});
			this.XrLabel29.LocationFloat = new DevExpress.Utils.PointFloat((float) (162.0834F), (float) (43.75F));
			this.XrLabel29.Name = "XrLabel29";
			this.XrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel29.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel29.StylePriority.UseTextAlignment = false;
			this.XrLabel29.Text = "k";
			this.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel48
			//
			this.XrLabel48.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.th", "{0:n2}")});
			this.XrLabel48.LocationFloat = new DevExpress.Utils.PointFloat((float) (162.0834F), (float) (75.1667F));
			this.XrLabel48.Name = "XrLabel48";
			this.XrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel48.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel48.StylePriority.UseTextAlignment = false;
			this.XrLabel48.Text = "XrLabel48";
			this.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel25
			//
			this.XrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.twentyfive", "{0:#,#}")});
			this.XrLabel25.LocationFloat = new DevExpress.Utils.PointFloat((float) (108.4583F), (float) (186.0835F));
			this.XrLabel25.Name = "XrLabel25";
			this.XrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel25.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel25.StylePriority.UseTextAlignment = false;
			this.XrLabel25.Text = "XrLabel25";
			this.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel49
			//
			this.XrLabel49.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totcashcnt", "{0:n2}")});
			this.XrLabel49.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel49.LocationFloat = new DevExpress.Utils.PointFloat((float) (136.5417F), (float) (233.5F));
			this.XrLabel49.Name = "XrLabel49";
			this.XrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel49.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.66661F));
			this.XrLabel49.StylePriority.UseFont = false;
			this.XrLabel49.StylePriority.UseTextAlignment = false;
			this.XrLabel49.Text = "XrLabel49";
			this.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel51
			//
			this.XrLabel51.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.oh", "{0:n2}")});
			this.XrLabel51.LocationFloat = new DevExpress.Utils.PointFloat((float) (162.0834F), (float) (90.87505F));
			this.XrLabel51.Name = "XrLabel51";
			this.XrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel51.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel51.StylePriority.UseTextAlignment = false;
			this.XrLabel51.Text = "XrLabel51";
			this.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel52
			//
			this.XrLabel52.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.ffty", "{0:n2}")});
			this.XrLabel52.LocationFloat = new DevExpress.Utils.PointFloat((float) (162.0834F), (float) (106.5834F));
			this.XrLabel52.Name = "XrLabel52";
			this.XrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel52.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel52.StylePriority.UseTextAlignment = false;
			this.XrLabel52.Text = "XrLabel52";
			this.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel53
			//
			this.XrLabel53.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.twnty", "{0:n2}")});
			this.XrLabel53.LocationFloat = new DevExpress.Utils.PointFloat((float) (162.0834F), (float) (122.2918F));
			this.XrLabel53.Name = "XrLabel53";
			this.XrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel53.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel53.StylePriority.UseTextAlignment = false;
			this.XrLabel53.Text = "XrLabel53";
			this.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel54
			//
			this.XrLabel54.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.tn", "{0:n2}")});
			this.XrLabel54.LocationFloat = new DevExpress.Utils.PointFloat((float) (162.0834F), (float) (138.0001F));
			this.XrLabel54.Name = "XrLabel54";
			this.XrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel54.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel54.StylePriority.UseTextAlignment = false;
			this.XrLabel54.Text = "XrLabel54";
			this.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel55
			//
			this.XrLabel55.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.fve", "{0:n2}")});
			this.XrLabel55.LocationFloat = new DevExpress.Utils.PointFloat((float) (162.0834F), (float) (154.6668F));
			this.XrLabel55.Name = "XrLabel55";
			this.XrLabel55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel55.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel55.StylePriority.UseTextAlignment = false;
			this.XrLabel55.Text = "XrLabel55";
			this.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel56
			//
			this.XrLabel56.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.ones", "{0:n2}")});
			this.XrLabel56.LocationFloat = new DevExpress.Utils.PointFloat((float) (162.0834F), (float) (170.3751F));
			this.XrLabel56.Name = "XrLabel56";
			this.XrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel56.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel56.StylePriority.UseTextAlignment = false;
			this.XrLabel56.Text = "XrLabel56";
			this.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel57
			//
			this.XrLabel57.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.tfc", "{0:n2}")});
			this.XrLabel57.LocationFloat = new DevExpress.Utils.PointFloat((float) (162.0834F), (float) (186.0835F));
			this.XrLabel57.Name = "XrLabel57";
			this.XrLabel57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel57.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel57.StylePriority.UseTextAlignment = false;
			this.XrLabel57.Text = "XrLabel57";
			this.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel50
			//
			this.XrLabel50.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.fh", "{0:n2}")});
			this.XrLabel50.LocationFloat = new DevExpress.Utils.PointFloat((float) (162.0834F), (float) (59.45835F));
			this.XrLabel50.Name = "XrLabel50";
			this.XrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel50.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel50.StylePriority.UseTextAlignment = false;
			this.XrLabel50.Text = "XrLabel50";
			this.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLine2
			//
			this.XrLine2.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00004F), (float) (252.1666F));
			this.XrLine2.Name = "XrLine2";
			this.XrLine2.SizeF = new System.Drawing.SizeF((float) (270.9999F), (float) (14.66666F));
			//
			//XrLabel24
			//
			this.XrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.thousndp", "{0:#,#}")});
			this.XrLabel24.LocationFloat = new DevExpress.Utils.PointFloat((float) (108.4583F), (float) (43.75F));
			this.XrLabel24.Name = "XrLabel24";
			this.XrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel24.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel24.StylePriority.UseTextAlignment = false;
			this.XrLabel24.Text = "XrLabel24";
			this.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel22
			//
			this.XrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.fiftyp", "{0:#,#}")});
			this.XrLabel22.LocationFloat = new DevExpress.Utils.PointFloat((float) (108.4583F), (float) (106.5834F));
			this.XrLabel22.Name = "XrLabel22";
			this.XrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel22.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel22.StylePriority.UseTextAlignment = false;
			this.XrLabel22.Text = "XrLabel22";
			this.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel6
			//
			this.XrLabel6.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (20.83333F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (14.66667F));
			this.XrLabel6.StylePriority.UseFont = false;
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "Denomination";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel7
			//
			this.XrLabel7.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (108.4583F), (float) (21.875F));
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (14.66667F));
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.StylePriority.UseTextAlignment = false;
			this.XrLabel7.Text = "No. of Pcs.";
			this.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel8
			//
			this.XrLabel8.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (44.79167F));
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (14.66667F));
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "One Thousand";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel9
			//
			this.XrLabel9.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (59.45835F));
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel9.StylePriority.UseFont = false;
			this.XrLabel9.StylePriority.UseTextAlignment = false;
			this.XrLabel9.Text = "Five Hundred";
			this.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel10
			//
			this.XrLabel10.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (75.1667F));
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel10.StylePriority.UseFont = false;
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "Two Hundred";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel11
			//
			this.XrLabel11.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (90.87505F));
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel11.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel11.StylePriority.UseFont = false;
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			this.XrLabel11.Text = "One Hundred";
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel12
			//
			this.XrLabel12.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (106.5834F));
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel12.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel12.StylePriority.UseFont = false;
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.Text = "Fifty";
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel23
			//
			this.XrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.tenp", "{0:#,#}")});
			this.XrLabel23.LocationFloat = new DevExpress.Utils.PointFloat((float) (108.4583F), (float) (138.0001F));
			this.XrLabel23.Name = "XrLabel23";
			this.XrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel23.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel23.StylePriority.UseTextAlignment = false;
			this.XrLabel23.Text = "XrLabel23";
			this.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel13
			//
			this.XrLabel13.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (138.0001F));
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel13.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel13.StylePriority.UseFont = false;
			this.XrLabel13.StylePriority.UseTextAlignment = false;
			this.XrLabel13.Text = "Ten";
			this.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel15
			//
			this.XrLabel15.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (154.6668F));
			this.XrLabel15.Name = "XrLabel15";
			this.XrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel15.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel15.StylePriority.UseFont = false;
			this.XrLabel15.StylePriority.UseTextAlignment = false;
			this.XrLabel15.Text = "Five";
			this.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel16
			//
			this.XrLabel16.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel16.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (170.3751F));
			this.XrLabel16.Name = "XrLabel16";
			this.XrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel16.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel16.StylePriority.UseFont = false;
			this.XrLabel16.StylePriority.UseTextAlignment = false;
			this.XrLabel16.Text = "One";
			this.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel17
			//
			this.XrLabel17.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel17.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (186.0835F));
			this.XrLabel17.Name = "XrLabel17";
			this.XrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel17.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel17.StylePriority.UseFont = false;
			this.XrLabel17.StylePriority.UseTextAlignment = false;
			this.XrLabel17.Text = "25 Cents";
			this.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel18
			//
			this.XrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.onehundredp", "{0:#,#}")});
			this.XrLabel18.LocationFloat = new DevExpress.Utils.PointFloat((float) (108.4583F), (float) (90.87505F));
			this.XrLabel18.Name = "XrLabel18";
			this.XrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel18.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel18.StylePriority.UseTextAlignment = false;
			this.XrLabel18.Text = "XrLabel18";
			this.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel19
			//
			this.XrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.onep", "{0:#,#}")});
			this.XrLabel19.LocationFloat = new DevExpress.Utils.PointFloat((float) (108.4583F), (float) (170.3751F));
			this.XrLabel19.Name = "XrLabel19";
			this.XrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel19.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel19.StylePriority.UseTextAlignment = false;
			this.XrLabel19.Text = "XrLabel19";
			this.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel20
			//
			this.XrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.fiehundredp", "{0:#,#}")});
			this.XrLabel20.LocationFloat = new DevExpress.Utils.PointFloat((float) (108.4583F), (float) (59.45835F));
			this.XrLabel20.Name = "XrLabel20";
			this.XrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel20.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel20.StylePriority.UseTextAlignment = false;
			this.XrLabel20.Text = "XrLabel20";
			this.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel21
			//
			this.XrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.fivep", "{0:#,#}")});
			this.XrLabel21.LocationFloat = new DevExpress.Utils.PointFloat((float) (108.4583F), (float) (154.6668F));
			this.XrLabel21.Name = "XrLabel21";
			this.XrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel21.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel21.StylePriority.UseTextAlignment = false;
			this.XrLabel21.Text = "XrLabel21";
			this.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel14
			//
			this.XrLabel14.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (122.2918F));
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel14.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel14.StylePriority.UseFont = false;
			this.XrLabel14.StylePriority.UseTextAlignment = false;
			this.XrLabel14.Text = "Twenty";
			this.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel30
			//
			this.XrLabel30.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel30.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00001F), (float) (266.8333F));
			this.XrLabel30.Name = "XrLabel30";
			this.XrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel30.SizeF = new System.Drawing.SizeF((float) (254.0833F), (float) (17.79169F));
			this.XrLabel30.StylePriority.UseFont = false;
			this.XrLabel30.StylePriority.UseTextAlignment = false;
			this.XrLabel30.Text = "POS TRANSACTIONS";
			this.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
			//DsReading1
			//
			this.DsReading1.DataSetName = "dsReading";
			this.DsReading1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//TblreadingTableAdapter
			//
			this.TblreadingTableAdapter.ClearBeforeFill = true;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel85, this.XrLabel84, this.XrLabel83, this.XrLabel82, this.XrLabel1, this.XrLabel81, this.xRLTin194, this.xRLABCCompany, this.XrLabel77, this.XrLabel2, this.XrLabel3, this.XrLabel4});
			this.ReportHeader.HeightF = (float) (192.9584F);
			this.ReportHeader.Name = "ReportHeader";
			this.ReportHeader.StylePriority.UseTextAlignment = false;
			this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel85
			//
			this.XrLabel85.LocationFloat = new DevExpress.Utils.PointFloat((float) (187.5F), (float) (171.1667F));
			this.XrLabel85.Name = "XrLabel85";
			this.XrLabel85.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel85.SizeF = new System.Drawing.SizeF((float) (13.37502F), (float) (14.66667F));
			this.XrLabel85.StylePriority.UseTextAlignment = false;
			this.XrLabel85.Text = "-";
			this.XrLabel85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel84
			//
			this.XrLabel84.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.endreceipt")});
			this.XrLabel84.LocationFloat = new DevExpress.Utils.PointFloat((float) (200.8751F), (float) (171.1667F));
			this.XrLabel84.Name = "XrLabel84";
			this.XrLabel84.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel84.SizeF = new System.Drawing.SizeF((float) (80.12491F), (float) (14.66667F));
			this.XrLabel84.Text = "XrLabel84";
			//
			//XrLabel83
			//
			this.XrLabel83.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.begreceipt")});
			this.XrLabel83.LocationFloat = new DevExpress.Utils.PointFloat((float) (89.41669F), (float) (171.1667F));
			this.XrLabel83.Name = "XrLabel83";
			this.XrLabel83.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel83.SizeF = new System.Drawing.SizeF((float) (89.58337F), (float) (14.66667F));
			this.XrLabel83.StylePriority.UseTextAlignment = false;
			this.XrLabel83.Text = "XrLabel83";
			this.XrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel82
			//
			this.XrLabel82.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (171.1667F));
			this.XrLabel82.Name = "XrLabel82";
			this.XrLabel82.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel82.SizeF = new System.Drawing.SizeF((float) (89.41669F), (float) (14.66667F));
			this.XrLabel82.StylePriority.UseTextAlignment = false;
			this.XrLabel82.Text = "Receipt(s):";
			this.XrLabel82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel1
			//
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (89.41669F), (float) (156.5F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (137.875F), (float) (14.66667F));
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "Juan De la Cruz";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel81
			//
			this.XrLabel81.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (78.125F));
			this.XrLabel81.Multiline = true;
			this.XrLabel81.Name = "XrLabel81";
			this.XrLabel81.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel81.SizeF = new System.Drawing.SizeF((float) (289.0F), (float) (49.04167F));
			this.XrLabel81.StylePriority.UseTextAlignment = false;
			this.XrLabel81.Text = "CASHIER BALANCE REPORT" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "Baguio Branch" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "Store #0001" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "Register 01" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "June 26, 2014 (T" + 
				"hur)" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "Juan De la Cruz" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "X-READING";
			this.XrLabel81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//xRLTin194
			//
			this.xRLTin194.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (28.125F));
			this.xRLTin194.Multiline = true;
			this.xRLTin194.Name = "xRLTin194";
			this.xRLTin194.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.xRLTin194.SizeF = new System.Drawing.SizeF((float) (289.0F), (float) (49.04167F));
			this.xRLTin194.StylePriority.UseTextAlignment = false;
			this.xRLTin194.Text = "Tin# 194-586-289" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "POS01 SN: XX - CXXXX" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "BIR PERMIT  NO.: XXXX-XXX-XXXXX-XXX";
			this.xRLTin194.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//xRLABCCompany
			//
			this.xRLABCCompany.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.xRLABCCompany.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (0.0F));
			this.xRLABCCompany.Name = "xRLABCCompany";
			this.xRLABCCompany.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.xRLABCCompany.SizeF = new System.Drawing.SizeF((float) (289.0F), (float) (23.0F));
			this.xRLABCCompany.StylePriority.UseFont = false;
			this.xRLABCCompany.StylePriority.UseTextAlignment = false;
			this.xRLABCCompany.Text = "ABC Company";
			this.xRLABCCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel77
			//
			this.XrLabel77.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.datereading")});
			this.XrLabel77.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (127.1667F));
			this.XrLabel77.Name = "XrLabel77";
			this.XrLabel77.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel77.SizeF = new System.Drawing.SizeF((float) (289.0F), (float) (14.66667F));
			this.XrLabel77.StylePriority.UseTextAlignment = false;
			this.XrLabel77.Text = "XrLabel77";
			this.XrLabel77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel2
			//
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (156.5F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (89.41669F), (float) (14.66667F));
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "Close Manager";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel3
			//
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (141.8333F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (83.58329F), (float) (14.66667F));
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "Open Cashier:";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel4
			//
			this.XrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.cashier")});
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (89.41669F), (float) (141.8334F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (189.5833F), (float) (14.66666F));
			this.XrLabel4.Text = "XrLabel4";
			//
			//k
			//
			this.k.DataMember = "tblreading";
			this.k.Expression = "[thousndp] * 1000";
			this.k.Name = "k";
			//
			//fh
			//
			this.fh.DataMember = "tblreading";
			this.fh.Expression = "[fiehundredp]*500";
			this.fh.Name = "fh";
			//
			//th
			//
			this.th.DataMember = "tblreading";
			this.th.Expression = "[twohundredp] * 200";
			this.th.Name = "th";
			//
			//oh
			//
			this.oh.DataMember = "tblreading";
			this.oh.Expression = "[onehundredp]*100";
			this.oh.Name = "oh";
			//
			//ffty
			//
			this.ffty.DataMember = "tblreading";
			this.ffty.Expression = "[fiftyp] * 50";
			this.ffty.Name = "ffty";
			//
			//twnty
			//
			this.twnty.DataMember = "tblreading";
			this.twnty.Expression = "[twentyp]*20";
			this.twnty.Name = "twnty";
			//
			//tn
			//
			this.tn.DataMember = "tblreading";
			this.tn.Expression = "[tenp]*10";
			this.tn.Name = "tn";
			//
			//fve
			//
			this.fve.DataMember = "tblreading";
			this.fve.Expression = "[fivep]*5";
			this.fve.Name = "fve";
			//
			//ones
			//
			this.ones.DataMember = "tblreading";
			this.ones.Expression = "[onep]*1";
			this.ones.Name = "ones";
			//
			//tfc
			//
			this.tfc.DataMember = "tblreading";
			this.tfc.Expression = "[twentyfive]*.25";
			this.tfc.Name = "tfc";
			//
			//totcashcnt
			//
			this.totcashcnt.DataMember = "tblreading";
			this.totcashcnt.Expression = "[k] + [fh]  +  [th]  + [oh]  +  [ffty]  +  [twnty]  + [tn]  + [fve]  +  [ones]  +" + 
				"  [tfc] ";
			this.totcashcnt.Name = "totcashcnt";
			//
			//postrans
			//
			this.postrans.DataMember = "tblreading";
			this.postrans.Expression = "[begincash] + [addcash] + [payments]+[totalsales]";
			this.postrans.Name = "postrans";
			//
			//Result1
			//
			this.Result1.DataMember = "tblreading";
			this.Result1.Expression = "[totcashcnt] + [totalcheque]";
			this.Result1.Name = "Result1";
			//
			//Result2
			//
			this.Result2.DataMember = "tblreading";
			this.Result2.Expression = "[postrans] - [pickup]";
			this.Result2.Name = "Result2";
			//
			//RefNo
			//
			this.RefNo.Description = "RefNo";
			this.RefNo.Name = "RefNo";
			this.RefNo.Type = typeof(int);
			this.RefNo.ValueInfo = "0";
			//
			//totaccsales
			//
			this.totaccsales.DataMember = "tblreading";
			this.totaccsales.Expression = "[].Sum([totalsales])";
			this.totaccsales.Name = "totaccsales";
			//
			//calctotalsales
			//
			this.calctotalsales.DataMember = "tblreading";
			this.calctotalsales.Expression = "[cntreceipt]+[cnttotalrefunds]";
			this.calctotalsales.Name = "calctotalsales";
			//
			//NetSalesReceipt
			//
			this.NetSalesReceipt.DataMember = "tblreading";
			this.NetSalesReceipt.Expression = "[netSalesperPOS]/1.12";
			this.NetSalesReceipt.Name = "NetSalesReceipt";
			//
			//VAT
			//
			this.VAT.DataMember = "tblreading";
			this.VAT.Expression = "[netSalesperPOS]-[NetSalesReceipt]";
			this.VAT.Name = "VAT";
			//
			//netSalesperPOS
			//
			this.netSalesperPOS.DataMember = "tblreading";
			this.netSalesperPOS.Expression = "[totalsales]-[totaldiscount]";
			this.netSalesperPOS.Name = "netSalesperPOS";
			//
			//NetsalesforFS
			//
			this.NetsalesforFS.DataMember = "tblreading";
			this.NetsalesforFS.Expression = "[netSalesperPOS]-[VAT]";
			this.NetsalesforFS.Name = "NetsalesforFS";
			//
			//vTotalSales
			//
			this.vTotalSales.DataMember = "tblreading";
			this.vTotalSales.Expression = "[totalsales2] - [totaldiscount]";
			this.vTotalSales.Name = "vTotalSales";
			//
			//ZoutReprint
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.ReportHeader});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {this.k, this.fh, this.th, this.oh, this.ffty, this.twnty, this.tn, this.fve, this.ones, this.tfc, this.totcashcnt, this.postrans, this.Result1, this.Result2, this.totaccsales, this.calctotalsales, this.NetSalesReceipt, this.VAT, this.netSalesperPOS, this.NetsalesforFS, this.vTotalSales});
			this.DataAdapter = this.TblreadingTableAdapter;
			this.DataMember = "tblreading";
			this.DataSource = this.DsReading1;
			this.FilterString = "[cashreadid] = ?RefNo";
			this.Margins = new System.Drawing.Printing.Margins(4, 6, 5, 10);
			this.PageHeight = 1169;
			this.PageWidth = 299;
			this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.PaperName = "Roll Paper 76 x 297 mm";
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.RefNo});
			this.PrinterName = "EPSON TM-U220 Receipt";
			this.Version = "14.1";
			((System.ComponentModel.ISupportInitialize) this.DsReading1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DoorsPOS.WinApp.dsReading DsReading1;
		internal DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter TblreadingTableAdapter;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel26;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel27;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel28;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel43;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel42;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel29;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel48;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel25;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel49;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel51;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel52;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel53;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel54;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel55;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel56;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel57;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel50;
		internal DevExpress.XtraReports.UI.XRLine XrLine2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel24;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel22;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel23;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel13;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel15;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel16;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel17;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel18;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel19;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel20;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel21;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel14;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel30;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel31;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel47;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel46;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel45;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel41;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel44;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel40;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel58;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel39;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel37;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel36;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel35;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel34;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel33;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel32;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel38;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel59;
		internal DevExpress.XtraReports.UI.CalculatedField k;
		internal DevExpress.XtraReports.UI.CalculatedField fh;
		internal DevExpress.XtraReports.UI.CalculatedField th;
		internal DevExpress.XtraReports.UI.CalculatedField oh;
		internal DevExpress.XtraReports.UI.CalculatedField ffty;
		internal DevExpress.XtraReports.UI.CalculatedField twnty;
		internal DevExpress.XtraReports.UI.CalculatedField tn;
		internal DevExpress.XtraReports.UI.CalculatedField fve;
		internal DevExpress.XtraReports.UI.CalculatedField ones;
		internal DevExpress.XtraReports.UI.CalculatedField tfc;
		internal DevExpress.XtraReports.UI.CalculatedField totcashcnt;
		internal DevExpress.XtraReports.UI.CalculatedField postrans;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel70;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel68;
		internal DevExpress.XtraReports.UI.XRLine XrLine1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel67;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel66;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel65;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel64;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel63;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel62;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel61;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel60;
		internal DevExpress.XtraReports.UI.XRLine XrLine4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel74;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel73;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel72;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel71;
		internal DevExpress.XtraReports.UI.XRLine XrLine3;
		internal DevExpress.XtraReports.UI.CalculatedField Result1;
		internal DevExpress.XtraReports.UI.CalculatedField Result2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel69;
		internal DevExpress.XtraReports.UI.XRLine XrLine5;
		internal DevExpress.XtraReports.Parameters.Parameter RefNo;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel75;
		internal DevExpress.XtraReports.UI.CalculatedField totaccsales;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel76;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel77;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel78;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel79;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel80;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel82;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel81;
		internal DevExpress.XtraReports.UI.XRLabel xRLTin194;
		internal DevExpress.XtraReports.UI.XRLabel xRLABCCompany;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel95;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel94;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel93;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel92;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel91;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel90;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel88;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel87;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel86;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel85;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel84;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel83;
		internal DevExpress.XtraReports.UI.CalculatedField calctotalsales;
		internal DevExpress.XtraReports.UI.CalculatedField NetSalesReceipt;
		internal DevExpress.XtraReports.UI.CalculatedField VAT;
		internal DevExpress.XtraReports.UI.CalculatedField netSalesperPOS;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel96;
		internal DevExpress.XtraReports.UI.CalculatedField NetsalesforFS;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel89;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel103;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel102;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel101;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel100;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel99;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel98;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel97;
		internal DevExpress.XtraReports.UI.CalculatedField vTotalSales;
		internal DevExpress.XtraReports.UI.XRLine xRLine6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel105;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel104;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel106;
	}
	
}
