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
	partial class Zout : DevExpress.XtraReports.UI.XtraReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zout));
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.XrLabel63 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel60 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel57 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel55 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine2 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
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
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.DsReading1 = new DoorsPOS.WinApp.dsReading();
			this.TblreadingTableAdapter = new DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.totalcashcnt = new DevExpress.XtraReports.UI.CalculatedField();
			this.ParamCashier = new DevExpress.XtraReports.Parameters.Parameter();
			this.totalcash = new DevExpress.XtraReports.UI.CalculatedField();
			this.postrans = new DevExpress.XtraReports.UI.CalculatedField();
			this.k = new DevExpress.XtraReports.UI.CalculatedField();
			this.th = new DevExpress.XtraReports.UI.CalculatedField();
			this.totcashcnt = new DevExpress.XtraReports.UI.CalculatedField();
			this.fh = new DevExpress.XtraReports.UI.CalculatedField();
			this.oh = new DevExpress.XtraReports.UI.CalculatedField();
			this.ffty = new DevExpress.XtraReports.UI.CalculatedField();
			this.twnty = new DevExpress.XtraReports.UI.CalculatedField();
			this.tn = new DevExpress.XtraReports.UI.CalculatedField();
			this.fve = new DevExpress.XtraReports.UI.CalculatedField();
			this.ones = new DevExpress.XtraReports.UI.CalculatedField();
			this.tfc = new DevExpress.XtraReports.UI.CalculatedField();
			this.totaccsales = new DevExpress.XtraReports.UI.CalculatedField();
			((System.ComponentModel.ISupportInitialize) this.DsReading1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel63, this.XrLabel62, this.XrLabel61, this.XrLabel47, this.XrLabel60, this.XrLabel59, this.XrLabel58, this.XrLabel57, this.XrLabel56, this.XrLabel55, this.XrLabel54, this.XrLabel53, this.XrLabel52, this.XrLabel51, this.XrLabel50, this.XrLabel49, this.XrLabel48, this.XrLabel29, this.XrLabel46, this.XrLabel45, this.XrLabel41, this.XrLabel44, this.XrLabel42, this.XrLabel43, this.XrLabel40, this.XrLabel39, this.XrLabel38, this.XrLabel37, this.XrLabel36, this.XrLabel35, this.XrLabel34, this.XrLabel33, this.XrLabel32, this.XrLabel31, this.XrLabel30, this.XrLine2, this.XrLine1, this.XrLabel28, this.XrLabel27, this.XrLabel26, this.XrLabel25, this.XrLabel24, this.XrLabel23, this.XrLabel22, this.XrLabel21, this.XrLabel20, this.XrLabel19, this.XrLabel18, this.XrLabel17, this.XrLabel16, this.XrLabel15, this.XrLabel14, this.XrLabel13, this.XrLabel12, this.XrLabel11, this.XrLabel10, this.XrLabel9, this.XrLabel8, this.XrLabel7, this.XrLabel6, this.XrLabel5});
			this.Detail.HeightF = (float) (655.7083F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel63
			//
			this.XrLabel63.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalrefs", "{0:n2}")});
			this.XrLabel63.LocationFloat = new DevExpress.Utils.PointFloat((float) (150.5416F), (float) (440.6665F));
			this.XrLabel63.Name = "XrLabel63";
			this.XrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel63.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel63.StylePriority.UseTextAlignment = false;
			this.XrLabel63.Text = "XrLabel63";
			this.XrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel62
			//
			this.XrLabel62.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel62.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00001F), (float) (440.6665F));
			this.XrLabel62.Name = "XrLabel62";
			this.XrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel62.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel62.StylePriority.UseFont = false;
			this.XrLabel62.StylePriority.UseTextAlignment = false;
			this.XrLabel62.Text = "Total Refunds";
			this.XrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel61
			//
			this.XrLabel61.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totaccsales", "{0:n2}")});
			this.XrLabel61.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel61.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00004F), (float) (617.5833F));
			this.XrLabel61.Name = "XrLabel61";
			this.XrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel61.SizeF = new System.Drawing.SizeF((float) (244.0833F), (float) (23.0F));
			this.XrLabel61.StylePriority.UseFont = false;
			this.XrLabel61.StylePriority.UseTextAlignment = false;
			this.XrLabel61.Text = "XrLabel61";
			this.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel47
			//
			this.XrLabel47.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel47.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00004F), (float) (601.875F));
			this.XrLabel47.Name = "XrLabel47";
			this.XrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel47.SizeF = new System.Drawing.SizeF((float) (244.0833F), (float) (15.70837F));
			this.XrLabel47.StylePriority.UseFont = false;
			this.XrLabel47.StylePriority.UseTextAlignment = false;
			this.XrLabel47.Text = "TOTAL ACCUMULATED SALES";
			this.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel60
			//
			this.XrLabel60.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel60.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00001F), (float) (537.2082F));
			this.XrLabel60.Name = "XrLabel60";
			this.XrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel60.SizeF = new System.Drawing.SizeF((float) (261.0F), (float) (15.70834F));
			this.XrLabel60.StylePriority.UseFont = false;
			this.XrLabel60.StylePriority.UseTextAlignment = false;
			this.XrLabel60.Text = "TotCashCount+SumCheques - (Total COH - Pickup)";
			this.XrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel59
			//
			this.XrLabel59.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel59.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00001F), (float) (497.875F));
			this.XrLabel59.Name = "XrLabel59";
			this.XrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel59.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel59.StylePriority.UseFont = false;
			this.XrLabel59.StylePriority.UseTextAlignment = false;
			this.XrLabel59.Text = "Total Credit";
			this.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel58
			//
			this.XrLabel58.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalcredit", "{0:n2}")});
			this.XrLabel58.LocationFloat = new DevExpress.Utils.PointFloat((float) (150.5416F), (float) (497.875F));
			this.XrLabel58.Name = "XrLabel58";
			this.XrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel58.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel58.StylePriority.UseTextAlignment = false;
			this.XrLabel58.Text = "XrLabel58";
			this.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel57
			//
			this.XrLabel57.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.tfc", "{0:n2}")});
			this.XrLabel57.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (186.0835F));
			this.XrLabel57.Name = "XrLabel57";
			this.XrLabel57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel57.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel57.StylePriority.UseTextAlignment = false;
			this.XrLabel57.Text = "XrLabel57";
			this.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel56
			//
			this.XrLabel56.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.ones", "{0:n2}")});
			this.XrLabel56.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (170.3751F));
			this.XrLabel56.Name = "XrLabel56";
			this.XrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel56.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel56.StylePriority.UseTextAlignment = false;
			this.XrLabel56.Text = "XrLabel56";
			this.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel55
			//
			this.XrLabel55.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.fve", "{0:n2}")});
			this.XrLabel55.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (154.6668F));
			this.XrLabel55.Name = "XrLabel55";
			this.XrLabel55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel55.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel55.StylePriority.UseTextAlignment = false;
			this.XrLabel55.Text = "XrLabel55";
			this.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel54
			//
			this.XrLabel54.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.tn", "{0:n2}")});
			this.XrLabel54.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (138.0001F));
			this.XrLabel54.Name = "XrLabel54";
			this.XrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel54.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel54.StylePriority.UseTextAlignment = false;
			this.XrLabel54.Text = "XrLabel54";
			this.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel53
			//
			this.XrLabel53.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.twnty", "{0:n2}")});
			this.XrLabel53.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (122.2918F));
			this.XrLabel53.Name = "XrLabel53";
			this.XrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel53.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel53.StylePriority.UseTextAlignment = false;
			this.XrLabel53.Text = "XrLabel53";
			this.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel52
			//
			this.XrLabel52.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.ffty", "{0:n2}")});
			this.XrLabel52.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (106.5834F));
			this.XrLabel52.Name = "XrLabel52";
			this.XrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel52.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel52.StylePriority.UseTextAlignment = false;
			this.XrLabel52.Text = "XrLabel52";
			this.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel51
			//
			this.XrLabel51.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.oh", "{0:n2}")});
			this.XrLabel51.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (90.87505F));
			this.XrLabel51.Name = "XrLabel51";
			this.XrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel51.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel51.StylePriority.UseTextAlignment = false;
			this.XrLabel51.Text = "XrLabel51";
			this.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel50
			//
			this.XrLabel50.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.fh", "{0:n2}")});
			this.XrLabel50.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (59.45837F));
			this.XrLabel50.Name = "XrLabel50";
			this.XrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel50.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel50.StylePriority.UseTextAlignment = false;
			this.XrLabel50.Text = "XrLabel50";
			this.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel49
			//
			this.XrLabel49.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totcashcnt", "{0:n2}")});
			this.XrLabel49.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel49.LocationFloat = new DevExpress.Utils.PointFloat((float) (126.5417F), (float) (233.5F));
			this.XrLabel49.Name = "XrLabel49";
			this.XrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel49.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (18.66661F));
			this.XrLabel49.StylePriority.UseFont = false;
			this.XrLabel49.StylePriority.UseTextAlignment = false;
			this.XrLabel49.Text = "XrLabel49";
			this.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel48
			//
			this.XrLabel48.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.th", "{0:n2}")});
			this.XrLabel48.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (75.16672F));
			this.XrLabel48.Name = "XrLabel48";
			this.XrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel48.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel48.StylePriority.UseTextAlignment = false;
			this.XrLabel48.Text = "XrLabel48";
			this.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel29
			//
			this.XrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.k", "{0:n2}")});
			this.XrLabel29.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (43.75F));
			this.XrLabel29.Name = "XrLabel29";
			this.XrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel29.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70835F));
			this.XrLabel29.StylePriority.UseTextAlignment = false;
			this.XrLabel29.Text = "XrLabel29";
			this.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel46
			//
			this.XrLabel46.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel46.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999974F), (float) (408.3749F));
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
			this.XrLabel45.LocationFloat = new DevExpress.Utils.PointFloat((float) (150.5416F), (float) (408.3749F));
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
			this.XrLabel41.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (381.2917F));
			this.XrLabel41.Name = "XrLabel41";
			this.XrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel41.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel41.StylePriority.UseTextAlignment = false;
			this.XrLabel41.Text = "XrLabel41";
			this.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel44
			//
			this.XrLabel44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.addcash", "{0:n2}")});
			this.XrLabel44.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (327.3854F));
			this.XrLabel44.Name = "XrLabel44";
			this.XrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel44.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel44.StylePriority.UseTextAlignment = false;
			this.XrLabel44.Text = "XrLabel44";
			this.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel42
			//
			this.XrLabel42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.totalcheque", "{0:n2}")});
			this.XrLabel42.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (201.7918F));
			this.XrLabel42.Name = "XrLabel42";
			this.XrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel42.SizeF = new System.Drawing.SizeF((float) (74.45831F), (float) (15.70834F));
			this.XrLabel42.Text = "XrLabel42";
			//
			//XrLabel43
			//
			this.XrLabel43.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel43.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (201.7918F));
			this.XrLabel43.Name = "XrLabel43";
			this.XrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel43.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel43.StylePriority.UseFont = false;
			this.XrLabel43.StylePriority.UseTextAlignment = false;
			this.XrLabel43.Text = "Sum Cheques";
			this.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel40
			//
			this.XrLabel40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.pickup", "{0:n2}")});
			this.XrLabel40.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (467.8332F));
			this.XrLabel40.Name = "XrLabel40";
			this.XrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel40.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel40.StylePriority.UseTextAlignment = false;
			this.XrLabel40.Text = "XrLabel40";
			this.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel39
			//
			this.XrLabel39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.payments", "{0:n2}")});
			this.XrLabel39.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (355.25F));
			this.XrLabel39.Name = "XrLabel39";
			this.XrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel39.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel39.StylePriority.UseTextAlignment = false;
			this.XrLabel39.Text = "XrLabel39";
			this.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel38
			//
			this.XrLabel38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.overshort", "{0:n2}")});
			this.XrLabel38.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel38.LocationFloat = new DevExpress.Utils.PointFloat((float) (150.5416F), (float) (564.3749F));
			this.XrLabel38.Name = "XrLabel38";
			this.XrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel38.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel38.StylePriority.UseFont = false;
			this.XrLabel38.StylePriority.UseTextAlignment = false;
			this.XrLabel38.Text = "XrLabel38";
			this.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel37
			//
			this.XrLabel37.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel37.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00004F), (float) (564.3749F));
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
			this.XrLabel36.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00001F), (float) (381.2917F));
			this.XrLabel36.Name = "XrLabel36";
			this.XrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel36.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel36.StylePriority.UseFont = false;
			this.XrLabel36.StylePriority.UseTextAlignment = false;
			this.XrLabel36.Text = "Sales";
			this.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel35
			//
			this.XrLabel35.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel35.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00001F), (float) (355.25F));
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
			this.XrLabel34.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00004F), (float) (467.8332F));
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
			this.XrLabel33.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00001F), (float) (327.3854F));
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
			this.XrLabel32.LocationFloat = new DevExpress.Utils.PointFloat((float) (20.00001F), (float) (300.0417F));
			this.XrLabel32.Name = "XrLabel32";
			this.XrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel32.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel32.StylePriority.UseFont = false;
			this.XrLabel32.StylePriority.UseTextAlignment = false;
			this.XrLabel32.Text = "Beg. Cash";
			this.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel31
			//
			this.XrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.begincash", "{0:n2}")});
			this.XrLabel31.LocationFloat = new DevExpress.Utils.PointFloat((float) (152.0834F), (float) (300.0417F));
			this.XrLabel31.Name = "XrLabel31";
			this.XrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel31.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (15.70835F));
			this.XrLabel31.StylePriority.UseTextAlignment = false;
			this.XrLabel31.Text = "XrLabel31";
			this.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel30
			//
			this.XrLabel30.Font = new System.Drawing.Font("Times New Roman", (float) (11.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel30.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (266.8333F));
			this.XrLabel30.Name = "XrLabel30";
			this.XrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel30.SizeF = new System.Drawing.SizeF((float) (254.0833F), (float) (17.79169F));
			this.XrLabel30.StylePriority.UseFont = false;
			this.XrLabel30.StylePriority.UseTextAlignment = false;
			this.XrLabel30.Text = "POS TRANSACTIONS";
			this.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLine2
			//
			this.XrLine2.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.00003178914F), (float) (252.1666F));
			this.XrLine2.Name = "XrLine2";
			this.XrLine2.SizeF = new System.Drawing.SizeF((float) (281.0F), (float) (14.66666F));
			//
			//XrLine1
			//
			this.XrLine1.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (242.7083F));
			this.XrLine1.Name = "XrLine1";
			this.XrLine1.SizeF = new System.Drawing.SizeF((float) (2.0F), (float) (2.0F));
			//
			//XrLabel28
			//
			this.XrLabel28.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel28.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (217.5002F));
			this.XrLabel28.Name = "XrLabel28";
			this.XrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel28.SizeF = new System.Drawing.SizeF((float) (169.2917F), (float) (15.99983F));
			this.XrLabel28.StylePriority.UseFont = false;
			this.XrLabel28.StylePriority.UseTextAlignment = false;
			this.XrLabel28.Text = "TOTAL CASH COUNT";
			this.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel27
			//
			this.XrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.twohundredp", "{0:#,#}")});
			this.XrLabel27.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45832F), (float) (75.16672F));
			this.XrLabel27.Name = "XrLabel27";
			this.XrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel27.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel27.StylePriority.UseTextAlignment = false;
			this.XrLabel27.Text = "XrLabel27";
			this.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel26
			//
			this.XrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.twentyp", "{0:#,#}")});
			this.XrLabel26.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45832F), (float) (122.2918F));
			this.XrLabel26.Name = "XrLabel26";
			this.XrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel26.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel26.StylePriority.UseTextAlignment = false;
			this.XrLabel26.Text = "XrLabel26";
			this.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel25
			//
			this.XrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.twentyfive", "{0:#,#}")});
			this.XrLabel25.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45832F), (float) (186.0835F));
			this.XrLabel25.Name = "XrLabel25";
			this.XrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel25.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel25.StylePriority.UseTextAlignment = false;
			this.XrLabel25.Text = "XrLabel25";
			this.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel24
			//
			this.XrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.thousndp", "{0:#,#}")});
			this.XrLabel24.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45832F), (float) (43.75F));
			this.XrLabel24.Name = "XrLabel24";
			this.XrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel24.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel24.StylePriority.UseTextAlignment = false;
			this.XrLabel24.Text = "XrLabel24";
			this.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel23
			//
			this.XrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.tenp", "{0:#,#}")});
			this.XrLabel23.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45832F), (float) (138.0001F));
			this.XrLabel23.Name = "XrLabel23";
			this.XrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel23.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel23.StylePriority.UseTextAlignment = false;
			this.XrLabel23.Text = "XrLabel23";
			this.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel22
			//
			this.XrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.fiftyp", "{0:#,#}")});
			this.XrLabel22.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45832F), (float) (106.5834F));
			this.XrLabel22.Name = "XrLabel22";
			this.XrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel22.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel22.StylePriority.UseTextAlignment = false;
			this.XrLabel22.Text = "XrLabel22";
			this.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel21
			//
			this.XrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.fivep", "{0:#,#}")});
			this.XrLabel21.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45832F), (float) (154.6668F));
			this.XrLabel21.Name = "XrLabel21";
			this.XrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel21.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel21.StylePriority.UseTextAlignment = false;
			this.XrLabel21.Text = "XrLabel21";
			this.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel20
			//
			this.XrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.fiehundredp", "{0:#,#}")});
			this.XrLabel20.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45832F), (float) (59.45837F));
			this.XrLabel20.Name = "XrLabel20";
			this.XrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel20.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel20.StylePriority.UseTextAlignment = false;
			this.XrLabel20.Text = "XrLabel20";
			this.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel19
			//
			this.XrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.onep", "{0:#,#}")});
			this.XrLabel19.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45832F), (float) (170.3751F));
			this.XrLabel19.Name = "XrLabel19";
			this.XrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel19.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel19.StylePriority.UseTextAlignment = false;
			this.XrLabel19.Text = "XrLabel19";
			this.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel18
			//
			this.XrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.onehundredp", "{0:#,#}")});
			this.XrLabel18.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45832F), (float) (90.87507F));
			this.XrLabel18.Name = "XrLabel18";
			this.XrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel18.SizeF = new System.Drawing.SizeF((float) (39.58334F), (float) (15.70835F));
			this.XrLabel18.StylePriority.UseTextAlignment = false;
			this.XrLabel18.Text = "XrLabel18";
			this.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel17
			//
			this.XrLabel17.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel17.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (186.0835F));
			this.XrLabel17.Name = "XrLabel17";
			this.XrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel17.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel17.StylePriority.UseFont = false;
			this.XrLabel17.StylePriority.UseTextAlignment = false;
			this.XrLabel17.Text = "25 Cents";
			this.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel16
			//
			this.XrLabel16.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel16.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (170.3751F));
			this.XrLabel16.Name = "XrLabel16";
			this.XrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel16.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel16.StylePriority.UseFont = false;
			this.XrLabel16.StylePriority.UseTextAlignment = false;
			this.XrLabel16.Text = "One";
			this.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel15
			//
			this.XrLabel15.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (154.6668F));
			this.XrLabel15.Name = "XrLabel15";
			this.XrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel15.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel15.StylePriority.UseFont = false;
			this.XrLabel15.StylePriority.UseTextAlignment = false;
			this.XrLabel15.Text = "Five";
			this.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel14
			//
			this.XrLabel14.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (122.2918F));
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel14.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel14.StylePriority.UseFont = false;
			this.XrLabel14.StylePriority.UseTextAlignment = false;
			this.XrLabel14.Text = "Twenty";
			this.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel13
			//
			this.XrLabel13.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (138.0001F));
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel13.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel13.StylePriority.UseFont = false;
			this.XrLabel13.StylePriority.UseTextAlignment = false;
			this.XrLabel13.Text = "Ten";
			this.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel12
			//
			this.XrLabel12.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (106.5834F));
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel12.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel12.StylePriority.UseFont = false;
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.Text = "Fifty";
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel11
			//
			this.XrLabel11.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (90.87505F));
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel11.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel11.StylePriority.UseFont = false;
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			this.XrLabel11.Text = "One Hundred";
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel10
			//
			this.XrLabel10.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (75.1667F));
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel10.StylePriority.UseFont = false;
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "Two Hundred";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel9
			//
			this.XrLabel9.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (59.45835F));
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (15.70835F));
			this.XrLabel9.StylePriority.UseFont = false;
			this.XrLabel9.StylePriority.UseTextAlignment = false;
			this.XrLabel9.Text = "Five Hundred";
			this.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel8
			//
			this.XrLabel8.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (44.79167F));
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (14.66667F));
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "One Thousand";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel7
			//
			this.XrLabel7.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45832F), (float) (21.87502F));
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (14.66667F));
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.StylePriority.UseTextAlignment = false;
			this.XrLabel7.Text = "No. of Pcs.";
			this.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel6
			//
			this.XrLabel6.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (20.83333F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (98.45832F), (float) (14.66667F));
			this.XrLabel6.StylePriority.UseFont = false;
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "Denomination";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel5
			//
			this.XrLabel5.Font = new System.Drawing.Font("Times New Roman", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (0.0F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (158.875F), (float) (14.66667F));
			this.XrLabel5.StylePriority.UseFont = false;
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "Cash Count";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//TopMargin
			//
			this.TopMargin.HeightF = (float) (7.0F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (13.0F);
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
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel4, this.XrLabel3, this.XrLabel2, this.XrPageInfo1, this.XrLabel1});
			this.ReportHeader.HeightF = (float) (50.0F);
			this.ReportHeader.Name = "ReportHeader";
			//
			//XrLabel4
			//
			this.XrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.cashier")});
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (60.95832F), (float) (29.33334F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (189.5833F), (float) (14.66666F));
			this.XrLabel4.Text = "XrLabel4";
			//
			//XrLabel3
			//
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (29.33334F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (54.70832F), (float) (14.66667F));
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "Cashier:";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel2
			//
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (14.66667F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (43.24999F), (float) (14.66667F));
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "Date:";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrPageInfo1
			//
			this.XrPageInfo1.Format = "{0:M/d/yyyy h:mm:ss tt}";
			this.XrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat((float) (60.95832F), (float) (14.66667F));
			this.XrPageInfo1.Name = "XrPageInfo1";
			this.XrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.XrPageInfo1.SizeF = new System.Drawing.SizeF((float) (189.5833F), (float) (14.66667F));
			//
			//XrLabel1
			//
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (0.0F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (281.0F), (float) (14.66667F));
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "Cashier Reading";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//totalcashcnt
			//
			this.totalcashcnt.Expression = resources.GetString("totalcashcnt.Expression");
			this.totalcashcnt.Name = "totalcashcnt";
			//
			//ParamCashier
			//
			this.ParamCashier.Description = "ParamCashier";
			this.ParamCashier.Name = "ParamCashier";
			this.ParamCashier.Visible = false;
			//
			//totalcash
			//
			this.totalcash.DataMember = "tblreading";
			this.totalcash.Expression = resources.GetString("totalcash.Expression");
			this.totalcash.Name = "totalcash";
			//
			//postrans
			//
			this.postrans.DataMember = "tblreading";
			this.postrans.Expression = "[begincash] + [addcash] + [payments]+[totalsales]";
			this.postrans.Name = "postrans";
			//
			//k
			//
			this.k.DataMember = "tblreading";
			this.k.Expression = "[thousndp] * 1000";
			this.k.Name = "k";
			//
			//th
			//
			this.th.DataMember = "tblreading";
			this.th.Expression = "[twohundredp] * 200";
			this.th.Name = "th";
			//
			//totcashcnt
			//
			this.totcashcnt.DataMember = "tblreading";
			this.totcashcnt.Expression = "[k] + [fh]  +  [th]  + [oh]  +  [ffty]  +  [twnty]  + [tn]  + [fve]  +  [ones]  +" + 
				"  [tfc] ";
			this.totcashcnt.Name = "totcashcnt";
			//
			//fh
			//
			this.fh.DataMember = "tblreading";
			this.fh.Expression = "[fiehundredp]*500";
			this.fh.Name = "fh";
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
			//totaccsales
			//
			this.totaccsales.DataMember = "tblreading";
			this.totaccsales.Expression = "[].Sum([totalsales])";
			this.totaccsales.Name = "totaccsales";
			//
			//Zout
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.ReportHeader});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {this.totalcashcnt, this.totalcash, this.postrans, this.k, this.th, this.totcashcnt, this.fh, this.oh, this.ffty, this.twnty, this.tn, this.fve, this.ones, this.tfc, this.totaccsales});
			this.DataAdapter = this.TblreadingTableAdapter;
			this.DataMember = "tblreading";
			this.DataSource = this.DsReading1;
			this.FilterString = "[cashier] = ?ParamCashier And [status] = False";
			this.Margins = new System.Drawing.Printing.Margins(3, 5, 7, 13);
			this.PageHeight = 1169;
			this.PageWidth = 299;
			this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.PaperName = "Roll Paper 76 x 297 mm";
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.ParamCashier});
			this.PrinterName = "EPSON TM-U220 Receipt";
			this.RequestParameters = false;
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "14.1";
			((System.ComponentModel.ISupportInitialize) this.DsReading1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel28;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel27;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel26;
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
		internal DoorsPOS.WinApp.dsReading DsReading1;
		internal DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter TblreadingTableAdapter;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRPageInfo XrPageInfo1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLine XrLine1;
		internal DevExpress.XtraReports.UI.CalculatedField totalcashcnt;
		internal DevExpress.XtraReports.UI.XRLine XrLine2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel41;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel44;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel42;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel43;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel40;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel39;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel38;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel37;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel36;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel35;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel34;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel33;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel32;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel31;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel30;
		internal DevExpress.XtraReports.Parameters.Parameter ParamCashier;
		internal DevExpress.XtraReports.UI.CalculatedField totalcash;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel46;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel45;
		internal DevExpress.XtraReports.UI.CalculatedField postrans;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel48;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel29;
		internal DevExpress.XtraReports.UI.CalculatedField k;
		internal DevExpress.XtraReports.UI.CalculatedField th;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel49;
		internal DevExpress.XtraReports.UI.CalculatedField totcashcnt;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel50;
		internal DevExpress.XtraReports.UI.CalculatedField fh;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel56;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel55;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel54;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel53;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel52;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel51;
		internal DevExpress.XtraReports.UI.CalculatedField oh;
		internal DevExpress.XtraReports.UI.CalculatedField ffty;
		internal DevExpress.XtraReports.UI.CalculatedField twnty;
		internal DevExpress.XtraReports.UI.CalculatedField tn;
		internal DevExpress.XtraReports.UI.CalculatedField fve;
		internal DevExpress.XtraReports.UI.CalculatedField ones;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel57;
		internal DevExpress.XtraReports.UI.CalculatedField tfc;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel59;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel58;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel60;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel61;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel47;
		internal DevExpress.XtraReports.UI.CalculatedField totaccsales;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel63;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel62;
	}
	
}
