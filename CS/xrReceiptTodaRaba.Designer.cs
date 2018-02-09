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
	partial class xrReceiptTodaRaba : DevExpress.XtraReports.UI.XtraReport
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
			this.XrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.DsvwReceipt1 = new DoorsPOS.WinApp.dsvwReceipt();
			this.VwReceiptTableAdapter = new DoorsPOS.WinApp.dsvwReceiptTableAdapters.vwReceiptTableAdapter();
			this.Parameter1 = new DevExpress.XtraReports.Parameters.Parameter();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.XrLine3 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine5 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.XrLine6 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine2 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine4 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.taym = new DevExpress.XtraReports.UI.CalculatedField();
			this.CashierCaps = new DevExpress.XtraReports.UI.CalculatedField();
			this.TotalBill = new DevExpress.XtraReports.UI.CalculatedField();
			this.VAT = new DevExpress.XtraReports.UI.CalculatedField();
			this.Changess = new DevExpress.XtraReports.UI.CalculatedField();
			this.GT = new DevExpress.XtraReports.UI.CalculatedField();
			this.SubTotss = new DevExpress.XtraReports.UI.CalculatedField();
			this.nvat = new DevExpress.XtraReports.UI.CalculatedField();
			this.sumnvat = new DevExpress.XtraReports.UI.CalculatedField();
			this.XrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize) this.DsvwReceipt1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel14, this.XrLabel12, this.XrLabel11, this.XrLabel15});
			this.Detail.HeightF = (float) (16.66667F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel14
			//
			this.XrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.price", "{0:n2}")});
			this.XrLabel14.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat((float) (121.6875F), (float) (0.0F));
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel14.SizeF = new System.Drawing.SizeF((float) (45.20836F), (float) (15.0F));
			this.XrLabel14.StylePriority.UseFont = false;
			this.XrLabel14.StylePriority.UseTextAlignment = false;
			this.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//XrLabel12
			//
			this.XrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.item_desc")});
			this.XrLabel12.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999998F), (float) (0.0F));
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel12.SizeF = new System.Drawing.SizeF((float) (108.75F), (float) (15.0F));
			this.XrLabel12.StylePriority.UseFont = false;
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
			this.XrLabel12.WordWrap = false;
			//
			//XrLabel11
			//
			this.XrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.qty")});
			this.XrLabel11.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat((float) (171.2708F), (float) (0.0F));
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel11.SizeF = new System.Drawing.SizeF((float) (30.62499F), (float) (15.0F));
			this.XrLabel11.StylePriority.UseFont = false;
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//XrLabel15
			//
			this.XrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.det_amnt", "{0:n2}")});
			this.XrLabel15.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat((float) (201.8959F), (float) (0.0F));
			this.XrLabel15.Name = "XrLabel15";
			this.XrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel15.SizeF = new System.Drawing.SizeF((float) (61.45834F), (float) (15.0F));
			this.XrLabel15.StylePriority.UseFont = false;
			this.XrLabel15.StylePriority.UseTextAlignment = false;
			this.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//TopMargin
			//
			this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel1, this.XrLabel2});
			this.TopMargin.HeightF = (float) (60.37499F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F));
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (0.0F));
			this.XrLabel1.Multiline = true;
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (289.0F), (float) (37.5F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "ABC Company" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "PROP. Juan Dela Cruz" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "Sandico St. Baguio, City";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel2
			//
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (39.56248F));
			this.XrLabel2.Multiline = true;
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (289.0F), (float) (17.70834F));
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "Tin: XXX-XXX-XXX-XXX - VAT";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel34
			//
			this.XrLabel34.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (267.0209F));
			this.XrLabel34.Multiline = true;
			this.XrLabel34.Name = "XrLabel34";
			this.XrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel34.SizeF = new System.Drawing.SizeF((float) (288.9999F), (float) (17.70834F));
			this.XrLabel34.StylePriority.UseTextAlignment = false;
			this.XrLabel34.Text = "Accrt# XXX-XXXXXXXXX-XXXXXX";
			this.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (9.0F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//DsvwReceipt1
			//
			this.DsvwReceipt1.DataSetName = "dsvwReceipt";
			this.DsvwReceipt1.EnforceConstraints = false;
			this.DsvwReceipt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VwReceiptTableAdapter
			//
			this.VwReceiptTableAdapter.ClearBeforeFill = true;
			//
			//Parameter1
			//
			this.Parameter1.Description = "Parameter1";
			this.Parameter1.Name = "Parameter1";
			this.Parameter1.Type = typeof(int);
			this.Parameter1.ValueInfo = "0";
			this.Parameter1.Visible = false;
			//
			//GroupHeader1
			//
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLine3, this.XrLabel31, this.XrLabel29, this.XrLabel30, this.XrLabel27, this.XrLine5, this.XrLabel9, this.XrLabel28, this.XrLabel10, this.XrLabel7, this.XrLabel8, this.XrLabel5, this.XrLabel3});
			this.GroupHeader1.HeightF = (float) (91.375F);
			this.GroupHeader1.Name = "GroupHeader1";
			//
			//XrLine3
			//
			this.XrLine3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.XrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
			this.XrLine3.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.99995F), (float) (79.4583F));
			this.XrLine3.Name = "XrLine3";
			this.XrLine3.SizeF = new System.Drawing.SizeF((float) (254.3751F), (float) (8.416687F));
			this.XrLine3.StylePriority.UseBorderDashStyle = false;
			//
			//XrLabel31
			//
			this.XrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.mowd")});
			this.XrLabel31.LocationFloat = new DevExpress.Utils.PointFloat((float) (93.12498F), (float) (35.4167F));
			this.XrLabel31.Name = "XrLabel31";
			this.XrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel31.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (17.70834F));
			//
			//XrLabel29
			//
			this.XrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.lastname")});
			this.XrLabel29.LocationFloat = new DevExpress.Utils.PointFloat((float) (93.12498F), (float) (17.70833F));
			this.XrLabel29.Name = "XrLabel29";
			this.XrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel29.SizeF = new System.Drawing.SizeF((float) (74.79172F), (float) (17.70834F));
			//
			//XrLabel30
			//
			this.XrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.firstname")});
			this.XrLabel30.LocationFloat = new DevExpress.Utils.PointFloat((float) (199.7917F), (float) (17.70833F));
			this.XrLabel30.Name = "XrLabel30";
			this.XrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel30.SizeF = new System.Drawing.SizeF((float) (51.04178F), (float) (17.70834F));
			//
			//XrLabel27
			//
			this.XrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.CashierCaps")});
			this.XrLabel27.LocationFloat = new DevExpress.Utils.PointFloat((float) (93.12498F), (float) (0.0F));
			this.XrLabel27.Name = "XrLabel27";
			this.XrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel27.SizeF = new System.Drawing.SizeF((float) (147.2917F), (float) (17.70834F));
			//
			//XrLine5
			//
			this.XrLine5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.XrLine5.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
			this.XrLine5.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999998F), (float) (53.125F));
			this.XrLine5.Name = "XrLine5";
			this.XrLine5.SizeF = new System.Drawing.SizeF((float) (254.3751F), (float) (8.416687F));
			this.XrLine5.StylePriority.UseBorderDashStyle = false;
			//
			//XrLabel9
			//
			this.XrLabel9.Font = new System.Drawing.Font("Times New Roman", (float) (9.0F));
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (202.9168F), (float) (61.7499F));
			this.XrLabel9.Multiline = true;
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (61.45834F), (float) (17.70834F));
			this.XrLabel9.StylePriority.UseFont = false;
			this.XrLabel9.StylePriority.UseTextAlignment = false;
			this.XrLabel9.Text = "Amount";
			this.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//XrLabel28
			//
			this.XrLabel28.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.41669F), (float) (35.41667F));
			this.XrLabel28.Multiline = true;
			this.XrLabel28.Name = "XrLabel28";
			this.XrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel28.SizeF = new System.Drawing.SizeF((float) (69.16664F), (float) (17.70834F));
			this.XrLabel28.StylePriority.UseTextAlignment = false;
			this.XrLabel28.Text = "Trans Type";
			this.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel10
			//
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999998F), (float) (17.70833F));
			this.XrLabel10.Multiline = true;
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (69.58335F), (float) (17.70834F));
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "Customer:";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel7
			//
			this.XrLabel7.Font = new System.Drawing.Font("Times New Roman", (float) (9.0F));
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (11.02087F), (float) (61.54168F));
			this.XrLabel7.Multiline = true;
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (30.62499F), (float) (17.70834F));
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.StylePriority.UseTextAlignment = false;
			this.XrLabel7.Text = "Item";
			this.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrLabel8
			//
			this.XrLabel8.Font = new System.Drawing.Font("Times New Roman", (float) (9.0F));
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (122.7084F), (float) (61.54168F));
			this.XrLabel8.Multiline = true;
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (45.20833F), (float) (17.70834F));
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "Price";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//XrLabel5
			//
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999998F), (float) (0.0F));
			this.XrLabel5.Multiline = true;
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (69.58335F), (float) (17.70834F));
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "Cashier:";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel3
			//
			this.XrLabel3.Font = new System.Drawing.Font("Times New Roman", (float) (9.0F));
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (172.2917F), (float) (61.54168F));
			this.XrLabel3.Multiline = true;
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (30.62499F), (float) (17.70834F));
			this.XrLabel3.StylePriority.UseFont = false;
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "Qty";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//XrLabel13
			//
			this.XrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.taym", "{0:MMMM dd, yyyy h:mm tt}")});
			this.XrLabel13.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat((float) (68.35411F), (float) (284.7292F));
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel13.SizeF = new System.Drawing.SizeF((float) (157.7084F), (float) (17.70834F));
			this.XrLabel13.StylePriority.UseFont = false;
			//
			//XrLabel26
			//
			this.XrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.pos_date", "{0:MM/dd/yy}")});
			this.XrLabel26.LocationFloat = new DevExpress.Utils.PointFloat((float) (187.9374F), (float) (302.4376F));
			this.XrLabel26.Name = "XrLabel26";
			this.XrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel26.SizeF = new System.Drawing.SizeF((float) (80.22919F), (float) (17.70834F));
			this.XrLabel26.Visible = false;
			//
			//XrLabel25
			//
			this.XrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.postmp_hdrid", "{0:0000000000#}")});
			this.XrLabel25.LocationFloat = new DevExpress.Utils.PointFloat((float) (53.77046F), (float) (302.4376F));
			this.XrLabel25.Name = "XrLabel25";
			this.XrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel25.SizeF = new System.Drawing.SizeF((float) (134.1669F), (float) (17.70834F));
			this.XrLabel25.StylePriority.UseTextAlignment = false;
			this.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel4
			//
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (284.7292F));
			this.XrLabel4.Multiline = true;
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (67.49999F), (float) (17.70834F));
			this.XrLabel4.StylePriority.UseTextAlignment = false;
			this.XrLabel4.Text = "Date/Time:";
			this.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel6
			//
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (302.4376F));
			this.XrLabel6.Multiline = true;
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (53.77046F), (float) (17.70834F));
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "OR No.";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//GroupFooter1
			//
			this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel43, this.XrLine6, this.XrLabel21, this.XrLabel40, this.XrLabel42, this.XrLabel41, this.XrLabel39, this.XrLine1, this.XrLabel36, this.XrLabel35, this.XrLabel18, this.XrLabel17, this.XrLabel38, this.XrLabel23, this.XrLine2, this.XrLabel22, this.XrLabel20, this.XrLabel37, this.XrLabel16, this.XrLabel32, this.XrLine4, this.XrLabel24, this.XrLabel33, this.XrLabel19, this.XrLabel34, this.XrLabel13, this.XrLabel4, this.XrLabel26, this.XrLabel25, this.XrLabel6});
			this.GroupFooter1.HeightF = (float) (371.6667F);
			this.GroupFooter1.Name = "GroupFooter1";
			//
			//XrLine6
			//
			this.XrLine6.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.XrLine6.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
			this.XrLine6.LocationFloat = new DevExpress.Utils.PointFloat((float) (17.72922F), (float) (331.25F));
			this.XrLine6.Name = "XrLine6";
			this.XrLine6.SizeF = new System.Drawing.SizeF((float) (246.0416F), (float) (8.416672F));
			this.XrLine6.StylePriority.UseBorderDashStyle = false;
			//
			//XrLabel21
			//
			this.XrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.Cheyns", "{0:n2}")});
			this.XrLabel21.LocationFloat = new DevExpress.Utils.PointFloat((float) (163.3542F), (float) (231.646F));
			this.XrLabel21.Name = "XrLabel21";
			this.XrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel21.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel21.StylePriority.UseTextAlignment = false;
			this.XrLabel21.Text = "XrLabel21";
			this.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel40
			//
			this.XrLabel40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.det_amnt")});
			this.XrLabel40.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel40.LocationFloat = new DevExpress.Utils.PointFloat((float) (201.8959F), (float) (11.22917F));
			this.XrLabel40.Name = "XrLabel40";
			this.XrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel40.SizeF = new System.Drawing.SizeF((float) (61.45831F), (float) (15.0F));
			this.XrLabel40.StylePriority.UseFont = false;
			this.XrLabel40.StylePriority.UseTextAlignment = false;
			XrSummary1.FormatString = "{0:n2}";
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.XrLabel40.Summary = XrSummary1;
			this.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//XrLabel42
			//
			this.XrLabel42.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F));
			this.XrLabel42.LocationFloat = new DevExpress.Utils.PointFloat((float) (153.5628F), (float) (62.52079F));
			this.XrLabel42.Multiline = true;
			this.XrLabel42.Name = "XrLabel42";
			this.XrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel42.SizeF = new System.Drawing.SizeF((float) (97.27071F), (float) (17.70834F));
			this.XrLabel42.StylePriority.UseFont = false;
			this.XrLabel42.StylePriority.UseTextAlignment = false;
			this.XrLabel42.Text = "0.00";
			this.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrLabel42.Visible = false;
			//
			//XrLabel41
			//
			this.XrLabel41.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel41.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.81247F), (float) (131.6042F));
			this.XrLabel41.Multiline = true;
			this.XrLabel41.Name = "XrLabel41";
			this.XrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel41.SizeF = new System.Drawing.SizeF((float) (97.27071F), (float) (17.70834F));
			this.XrLabel41.StylePriority.UseFont = false;
			this.XrLabel41.StylePriority.UseTextAlignment = false;
			this.XrLabel41.Text = "NON VAT Sales:";
			this.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel39
			//
			this.XrLabel39.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.81234F), (float) (166.8959F));
			this.XrLabel39.Multiline = true;
			this.XrLabel39.Name = "XrLabel39";
			this.XrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel39.SizeF = new System.Drawing.SizeF((float) (125.4167F), (float) (23.0F));
			this.XrLabel39.StylePriority.UseTextAlignment = false;
			this.XrLabel39.Text = "GRAND TOTAL";
			this.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrLine1
			//
			this.XrLine1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.XrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
			this.XrLine1.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999998F), (float) (0.0F));
			this.XrLine1.Name = "XrLine1";
			this.XrLine1.SizeF = new System.Drawing.SizeF((float) (253.3542F), (float) (8.416672F));
			this.XrLine1.StylePriority.UseBorderDashStyle = false;
			//
			//XrLabel36
			//
			this.XrLabel36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.VAT", "{0:n2}")});
			this.XrLabel36.LocationFloat = new DevExpress.Utils.PointFloat((float) (163.3542F), (float) (111.8125F));
			this.XrLabel36.Name = "XrLabel36";
			this.XrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel36.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (17.70835F));
			this.XrLabel36.StylePriority.UseTextAlignment = false;
			this.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel35
			//
			this.XrLabel35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.TotalBill", "{0:n2}")});
			this.XrLabel35.LocationFloat = new DevExpress.Utils.PointFloat((float) (163.3542F), (float) (88.81232F));
			this.XrLabel35.Name = "XrLabel35";
			this.XrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel35.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel35.StylePriority.UseTextAlignment = false;
			this.XrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel18
			//
			this.XrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.tendered", "{0:n2}")});
			this.XrLabel18.LocationFloat = new DevExpress.Utils.PointFloat((float) (163.3542F), (float) (200.2293F));
			this.XrLabel18.Name = "XrLabel18";
			this.XrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel18.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel18.StylePriority.UseTextAlignment = false;
			this.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel17
			//
			this.XrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.totsales", "{0:n2}")});
			this.XrLabel17.LocationFloat = new DevExpress.Utils.PointFloat((float) (163.3542F), (float) (166.8959F));
			this.XrLabel17.Name = "XrLabel17";
			this.XrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel17.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel17.StylePriority.UseTextAlignment = false;
			this.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel38
			//
			this.XrLabel38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.disc_amnt", "{0:n2}")});
			this.XrLabel38.LocationFloat = new DevExpress.Utils.PointFloat((float) (163.3542F), (float) (34.22909F));
			this.XrLabel38.Name = "XrLabel38";
			this.XrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel38.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel38.StylePriority.UseTextAlignment = false;
			this.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel23
			//
			this.XrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.item_desc")});
			this.XrLabel23.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.81209F), (float) (57.22914F));
			this.XrLabel23.Name = "XrLabel23";
			this.XrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel23.SizeF = new System.Drawing.SizeF((float) (38.95837F), (float) (23.0F));
			this.XrLabel23.StylePriority.UseTextAlignment = false;
			XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
			XrSummary2.IgnoreNullValues = true;
			XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.XrLabel23.Summary = XrSummary2;
			this.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//XrLine2
			//
			this.XrLine2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.XrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
			this.XrLine2.LocationFloat = new DevExpress.Utils.PointFloat((float) (17.72922F), (float) (158.4793F));
			this.XrLine2.Name = "XrLine2";
			this.XrLine2.SizeF = new System.Drawing.SizeF((float) (245.625F), (float) (8.416656F));
			this.XrLine2.StylePriority.UseBorderDashStyle = false;
			//
			//XrLabel22
			//
			this.XrLabel22.LocationFloat = new DevExpress.Utils.PointFloat((float) (68.35411F), (float) (57.22914F));
			this.XrLabel22.Multiline = true;
			this.XrLabel22.Name = "XrLabel22";
			this.XrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel22.SizeF = new System.Drawing.SizeF((float) (58.33335F), (float) (23.0F));
			this.XrLabel22.StylePriority.UseTextAlignment = false;
			this.XrLabel22.Text = "item(s)";
			this.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrLabel20
			//
			this.XrLabel20.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.81237F), (float) (231.646F));
			this.XrLabel20.Multiline = true;
			this.XrLabel20.Name = "XrLabel20";
			this.XrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel20.SizeF = new System.Drawing.SizeF((float) (111.875F), (float) (23.0F));
			this.XrLabel20.StylePriority.UseTextAlignment = false;
			this.XrLabel20.Text = "C H A N G E:";
			this.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel37
			//
			this.XrLabel37.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.81256F), (float) (34.22915F));
			this.XrLabel37.Multiline = true;
			this.XrLabel37.Name = "XrLabel37";
			this.XrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel37.SizeF = new System.Drawing.SizeF((float) (125.4167F), (float) (23.0F));
			this.XrLabel37.StylePriority.UseTextAlignment = false;
			this.XrLabel37.Text = "Discount:";
			this.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel16
			//
			this.XrLabel16.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.81256F), (float) (11.22917F));
			this.XrLabel16.Multiline = true;
			this.XrLabel16.Name = "XrLabel16";
			this.XrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel16.SizeF = new System.Drawing.SizeF((float) (125.4167F), (float) (23.0F));
			this.XrLabel16.StylePriority.UseTextAlignment = false;
			this.XrLabel16.Text = "Sub-Total";
			this.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel32
			//
			this.XrLabel32.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel32.LocationFloat = new DevExpress.Utils.PointFloat((float) (17.72919F), (float) (339.6667F));
			this.XrLabel32.Multiline = true;
			this.XrLabel32.Name = "XrLabel32";
			this.XrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel32.SizeF = new System.Drawing.SizeF((float) (245.625F), (float) (26.04167F));
			this.XrLabel32.StylePriority.UseFont = false;
			this.XrLabel32.StylePriority.UseTextAlignment = false;
			this.XrLabel32.Text = "THANK YOU & PLEASE COME AGAIN" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "THIS SERVES AS YOUR OFFICIAL RECEIPT";
			this.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLine4
			//
			this.XrLine4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.XrLine4.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
			this.XrLine4.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.81237F), (float) (223.2293F));
			this.XrLine4.Name = "XrLine4";
			this.XrLine4.SizeF = new System.Drawing.SizeF((float) (246.0416F), (float) (8.416672F));
			this.XrLine4.StylePriority.UseBorderDashStyle = false;
			//
			//XrLabel24
			//
			this.XrLabel24.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel24.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.81209F), (float) (88.81232F));
			this.XrLabel24.Multiline = true;
			this.XrLabel24.Name = "XrLabel24";
			this.XrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel24.SizeF = new System.Drawing.SizeF((float) (83.12537F), (float) (23.0F));
			this.XrLabel24.StylePriority.UseFont = false;
			this.XrLabel24.StylePriority.UseTextAlignment = false;
			this.XrLabel24.Text = "VAT SALES:";
			this.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel33
			//
			this.XrLabel33.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel33.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.81209F), (float) (111.8125F));
			this.XrLabel33.Multiline = true;
			this.XrLabel33.Name = "XrLabel33";
			this.XrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel33.SizeF = new System.Drawing.SizeF((float) (83.12537F), (float) (17.70835F));
			this.XrLabel33.StylePriority.UseFont = false;
			this.XrLabel33.StylePriority.UseTextAlignment = false;
			this.XrLabel33.Text = "12% VAT:";
			this.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel19
			//
			this.XrLabel19.LocationFloat = new DevExpress.Utils.PointFloat((float) (14.81237F), (float) (200.2293F));
			this.XrLabel19.Multiline = true;
			this.XrLabel19.Name = "XrLabel19";
			this.XrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel19.SizeF = new System.Drawing.SizeF((float) (125.4167F), (float) (23.0F));
			this.XrLabel19.StylePriority.UseTextAlignment = false;
			this.XrLabel19.Text = "T E N D E R E D:";
			this.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//taym
			//
			this.taym.DataMember = "vwReceipt";
			this.taym.Expression = "Now()";
			this.taym.Name = "taym";
			//
			//CashierCaps
			//
			this.CashierCaps.DataMember = "vwReceipt";
			this.CashierCaps.Expression = "Upper([sInsert_id])";
			this.CashierCaps.Name = "CashierCaps";
			//
			//TotalBill
			//
			this.TotalBill.DataMember = "vwReceipt";
			this.TotalBill.Expression = "[det_amnt] /1.12";
			this.TotalBill.Name = "TotalBill";
			//
			//VAT
			//
			this.VAT.DataMember = "vwReceipt";
			this.VAT.Expression = "[TotalBill]*.12";
			this.VAT.Name = "VAT";
			//
			//Changess
			//
			this.Changess.DataMember = "vwReceipt";
			this.Changess.Expression = "[tendered] - [GT]";
			this.Changess.Name = "Changess";
			//
			//GT
			//
			this.GT.DataMember = "vwReceipt";
			this.GT.Expression = "[totsales] - [disc_amnt]";
			this.GT.Name = "GT";
			//
			//SubTotss
			//
			this.SubTotss.DataMember = "vwReceipt";
			this.SubTotss.Expression = "Sum([det_amnt])";
			this.SubTotss.Name = "SubTotss";
			//
			//nvat
			//
			this.nvat.DataMember = "vwReceipt";
			this.nvat.Expression = "Iif([vatable]=0,[det_amnt]  , 0)";
			this.nvat.Name = "nvat";
			//
			//sumnvat
			//
			this.sumnvat.DataMember = "vwReceipt";
			this.sumnvat.Name = "sumnvat";
			//
			//XrLabel43
			//
			this.XrLabel43.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwReceipt.sumnvat")});
			this.XrLabel43.LocationFloat = new DevExpress.Utils.PointFloat((float) (163.3542F), (float) (131.6042F));
			this.XrLabel43.Name = "XrLabel43";
			this.XrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel43.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (17.70834F));
			this.XrLabel43.StylePriority.UseTextAlignment = false;
			this.XrLabel43.Text = "XrLabel43";
			this.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//xrReceiptTodaRaba
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.GroupHeader1, this.GroupFooter1});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {this.taym, this.CashierCaps, this.TotalBill, this.VAT, this.Changess, this.GT, this.SubTotss, this.nvat, this.sumnvat});
			this.DataAdapter = this.VwReceiptTableAdapter;
			this.DataMember = "vwReceipt";
			this.DataSource = this.DsvwReceipt1;
			this.FilterString = "[postmp_hdrid] = ?Parameter1";
			this.Margins = new System.Drawing.Printing.Margins(4, 557, 60, 9);
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.Parameter1});
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "14.1";
			((System.ComponentModel.ISupportInitialize) this.DsvwReceipt1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DoorsPOS.WinApp.dsvwReceipt DsvwReceipt1;
		internal DoorsPOS.WinApp.dsvwReceiptTableAdapters.vwReceiptTableAdapter VwReceiptTableAdapter;
		internal DevExpress.XtraReports.Parameters.Parameter Parameter1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel15;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel14;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		internal DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel34;
		internal DevExpress.XtraReports.UI.XRLine XrLine5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel28;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel23;
		internal DevExpress.XtraReports.UI.XRLine XrLine2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel22;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel20;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel37;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel16;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel32;
		internal DevExpress.XtraReports.UI.XRLine XrLine4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel24;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel33;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel19;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel31;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel13;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel26;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel25;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel29;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel30;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel27;
		internal DevExpress.XtraReports.UI.CalculatedField taym;
		internal DevExpress.XtraReports.UI.CalculatedField CashierCaps;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel36;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel35;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel18;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel17;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel38;
		internal DevExpress.XtraReports.UI.CalculatedField TotalBill;
		internal DevExpress.XtraReports.UI.CalculatedField VAT;
		internal DevExpress.XtraReports.UI.XRLine XrLine1;
		internal DevExpress.XtraReports.UI.CalculatedField Changess;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel39;
		internal DevExpress.XtraReports.UI.CalculatedField GT;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel42;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel41;
		internal DevExpress.XtraReports.UI.CalculatedField SubTotss;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel21;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel40;
		internal DevExpress.XtraReports.UI.XRLine XrLine3;
		internal DevExpress.XtraReports.UI.XRLine XrLine6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel43;
		internal DevExpress.XtraReports.UI.CalculatedField nvat;
		internal DevExpress.XtraReports.UI.CalculatedField sumnvat;
	}
	
}
