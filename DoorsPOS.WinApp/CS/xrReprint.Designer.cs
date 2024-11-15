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
	partial class xrReprint : DevExpress.XtraReports.UI.XtraReport
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
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.SpDataSet11 = new DoorsPOS.WinApp.SpDataSet1();
			this.ReceiptposTableAdapter = new DoorsPOS.WinApp.SpDataSet1TableAdapters.receiptposTableAdapter();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.XrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine3 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine5 = new DevExpress.XtraReports.UI.XRLine();
			this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.XrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine2 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine4 = new DevExpress.XtraReports.UI.XRLine();
			this.ReferenceNo = new DevExpress.XtraReports.Parameters.Parameter();
			this.Taym = new DevExpress.XtraReports.UI.CalculatedField();
			this.FormattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
			this.cashier = new DevExpress.XtraReports.Parameters.Parameter();
			((System.ComponentModel.ISupportInitialize) this.SpDataSet11).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel11, this.XrLabel12, this.XrLabel14, this.XrLabel15});
			this.Detail.HeightF = (float) (15.625F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel11
			//
			this.XrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.qty")});
			this.XrLabel11.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (0.0F));
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel11.SizeF = new System.Drawing.SizeF((float) (30.62499F), (float) (15.0F));
			this.XrLabel11.StylePriority.UseFont = false;
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			this.XrLabel11.Text = "XrLabel11";
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//XrLabel12
			//
			this.XrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.item_desc")});
			this.XrLabel12.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat((float) (37.50003F), (float) (0.0F));
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel12.SizeF = new System.Drawing.SizeF((float) (127.4999F), (float) (15.0F));
			this.XrLabel12.StylePriority.UseFont = false;
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.Text = "XrLabel12";
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.XrLabel12.WordWrap = false;
			//
			//XrLabel14
			//
			this.XrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.price", "{0:n2}")});
			this.XrLabel14.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat((float) (164.9999F), (float) (0.0F));
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel14.SizeF = new System.Drawing.SizeF((float) (62.5F), (float) (15.0F));
			this.XrLabel14.StylePriority.UseFont = false;
			this.XrLabel14.StylePriority.UseTextAlignment = false;
			this.XrLabel14.Text = "XrLabel14";
			this.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//XrLabel15
			//
			this.XrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.det_amnt", "{0:n2}")});
			this.XrLabel15.Font = new System.Drawing.Font("Times New Roman", (float) (8.0F));
			this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat((float) (227.5F), (float) (0.0F));
			this.XrLabel15.Name = "XrLabel15";
			this.XrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel15.SizeF = new System.Drawing.SizeF((float) (61.45831F), (float) (15.0F));
			this.XrLabel15.StylePriority.UseFont = false;
			this.XrLabel15.StylePriority.UseTextAlignment = false;
			this.XrLabel15.Text = "XrLabel15";
			this.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//TopMargin
			//
			this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel1, this.XrLabel2});
			this.TopMargin.HeightF = (float) (66.25002F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel1
			//
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (10.00001F));
			this.XrLabel1.Multiline = true;
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (290.0F), (float) (37.5F));
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "Almonds Grocery & Bakeshoppe" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "Abatan Buguias, Benguet";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel2
			//
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (48.54167F));
			this.XrLabel2.Multiline = true;
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (290.0F), (float) (17.70834F));
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "Re-Print List";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (13.12501F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
			//GroupHeader1
			//
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel27, this.XrLabel13, this.XrLabel6, this.XrLabel28, this.XrLabel30, this.XrLabel29, this.XrLine3, this.XrLabel9, this.XrLabel25, this.XrLabel4, this.XrLabel26, this.XrLabel5, this.XrLabel10, this.XrLabel3, this.XrLabel7, this.XrLabel8, this.XrLabel31, this.XrLine5});
			this.GroupHeader1.HeightF = (float) (136.4583F);
			this.GroupHeader1.Name = "GroupHeader1";
			//
			//XrLabel27
			//
			this.XrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.Taym")});
			this.XrLabel27.LocationFloat = new DevExpress.Utils.PointFloat((float) (99.79163F), (float) (17.70833F));
			this.XrLabel27.Name = "XrLabel27";
			this.XrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel27.SizeF = new System.Drawing.SizeF((float) (157.2917F), (float) (17.70835F));
			this.XrLabel27.Text = "XrLabel27";
			//
			//XrLabel13
			//
			this.XrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.sInsert_id")});
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat((float) (99.79163F), (float) (35.41667F));
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel13.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (17.70835F));
			this.XrLabel13.Text = "XrLabel13";
			//
			//XrLabel6
			//
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (8.333397F), (float) (0.0F));
			this.XrLabel6.Multiline = true;
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (91.45823F), (float) (17.70834F));
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "Reference No.:";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel28
			//
			this.XrLabel28.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (70.83337F));
			this.XrLabel28.Multiline = true;
			this.XrLabel28.Name = "XrLabel28";
			this.XrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel28.SizeF = new System.Drawing.SizeF((float) (69.16664F), (float) (17.70834F));
			this.XrLabel28.StylePriority.UseTextAlignment = false;
			this.XrLabel28.Text = "Trans Type";
			this.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel30
			//
			this.XrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.firstname")});
			this.XrLabel30.FormattingRules.Add(this.FormattingRule1);
			this.XrLabel30.LocationFloat = new DevExpress.Utils.PointFloat((float) (196.6667F), (float) (53.12503F));
			this.XrLabel30.Name = "XrLabel30";
			this.XrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel30.SizeF = new System.Drawing.SizeF((float) (81.66667F), (float) (17.70834F));
			this.XrLabel30.Text = "XrLabel30";
			//
			//XrLabel29
			//
			this.XrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.lastname")});
			this.XrLabel29.LocationFloat = new DevExpress.Utils.PointFloat((float) (99.79163F), (float) (53.12503F));
			this.XrLabel29.Name = "XrLabel29";
			this.XrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel29.SizeF = new System.Drawing.SizeF((float) (96.87502F), (float) (17.70834F));
			this.XrLabel29.Text = "XrLabel29";
			//
			//XrLine3
			//
			this.XrLine3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.XrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
			this.XrLine3.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (126.4583F));
			this.XrLine3.Name = "XrLine3";
			this.XrLine3.SizeF = new System.Drawing.SizeF((float) (273.3333F), (float) (8.416687F));
			this.XrLine3.StylePriority.UseBorderDashStyle = false;
			//
			//XrLabel9
			//
			this.XrLabel9.Font = new System.Drawing.Font("Times New Roman", (float) (9.0F));
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (227.5F), (float) (108.75F));
			this.XrLabel9.Multiline = true;
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (61.45834F), (float) (17.70834F));
			this.XrLabel9.StylePriority.UseFont = false;
			this.XrLabel9.StylePriority.UseTextAlignment = false;
			this.XrLabel9.Text = "Amount";
			this.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//XrLabel25
			//
			this.XrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.postmp_hdrid")});
			this.XrLabel25.LocationFloat = new DevExpress.Utils.PointFloat((float) (99.79163F), (float) (0.0F));
			this.XrLabel25.Name = "XrLabel25";
			this.XrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel25.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (17.70834F));
			//
			//XrLabel4
			//
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (17.70833F));
			this.XrLabel4.Multiline = true;
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (69.16664F), (float) (17.70835F));
			this.XrLabel4.StylePriority.UseTextAlignment = false;
			this.XrLabel4.Text = "Date/Time:";
			this.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel26
			//
			this.XrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.pos_date", "{0:MM/dd/yy}")});
			this.XrLabel26.LocationFloat = new DevExpress.Utils.PointFloat((float) (199.7916F), (float) (0.0F));
			this.XrLabel26.Name = "XrLabel26";
			this.XrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel26.SizeF = new System.Drawing.SizeF((float) (36.04172F), (float) (17.70834F));
			this.XrLabel26.Visible = false;
			//
			//XrLabel5
			//
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (35.4167F));
			this.XrLabel5.Multiline = true;
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (69.16664F), (float) (17.70834F));
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "Cashier:";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel10
			//
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (53.12503F));
			this.XrLabel10.Multiline = true;
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (69.16664F), (float) (17.70834F));
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "Customer:";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel3
			//
			this.XrLabel3.Font = new System.Drawing.Font("Times New Roman", (float) (9.0F));
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (108.75F));
			this.XrLabel3.Multiline = true;
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (30.62499F), (float) (17.70834F));
			this.XrLabel3.StylePriority.UseFont = false;
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "Qty";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//XrLabel7
			//
			this.XrLabel7.Font = new System.Drawing.Font("Times New Roman", (float) (9.0F));
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (51.66664F), (float) (108.7499F));
			this.XrLabel7.Multiline = true;
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (78.33334F), (float) (17.70834F));
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.StylePriority.UseTextAlignment = false;
			this.XrLabel7.Text = "Item";
			this.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrLabel8
			//
			this.XrLabel8.Font = new System.Drawing.Font("Times New Roman", (float) (9.0F));
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (182.2916F), (float) (108.75F));
			this.XrLabel8.Multiline = true;
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (45.20833F), (float) (17.70834F));
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "Price";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//XrLabel31
			//
			this.XrLabel31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.mowd")});
			this.XrLabel31.LocationFloat = new DevExpress.Utils.PointFloat((float) (99.79163F), (float) (70.83337F));
			this.XrLabel31.Name = "XrLabel31";
			this.XrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel31.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (17.70834F));
			this.XrLabel31.Text = "XrLabel31";
			//
			//XrLine5
			//
			this.XrLine5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.XrLine5.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
			this.XrLine5.LocationFloat = new DevExpress.Utils.PointFloat((float) (8.333397F), (float) (88.5417F));
			this.XrLine5.Name = "XrLine5";
			this.XrLine5.SizeF = new System.Drawing.SizeF((float) (273.3333F), (float) (8.416687F));
			this.XrLine5.StylePriority.UseBorderDashStyle = false;
			//
			//GroupFooter1
			//
			this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel23, this.XrLine2, this.XrLabel24, this.XrLabel22, this.XrLabel21, this.XrLabel20, this.XrLabel18, this.XrLabel19, this.XrLabel16, this.XrLabel17, this.XrLine4});
			this.GroupFooter1.HeightF = (float) (149.375F);
			this.GroupFooter1.Name = "GroupFooter1";
			//
			//XrLabel23
			//
			this.XrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.item_desc")});
			this.XrLabel23.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00004F), (float) (94.95827F));
			this.XrLabel23.Name = "XrLabel23";
			this.XrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel23.SizeF = new System.Drawing.SizeF((float) (52.50001F), (float) (23.0F));
			this.XrLabel23.StylePriority.UseTextAlignment = false;
			XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
			XrSummary1.IgnoreNullValues = true;
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.XrLabel23.Summary = XrSummary1;
			this.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//XrLine2
			//
			this.XrLine2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.XrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
			this.XrLine2.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.00003178914F), (float) (117.9583F));
			this.XrLine2.Name = "XrLine2";
			this.XrLine2.SizeF = new System.Drawing.SizeF((float) (290.0F), (float) (8.416667F));
			this.XrLine2.StylePriority.UseBorderDashStyle = false;
			//
			//XrLabel24
			//
			this.XrLabel24.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00004F), (float) (126.375F));
			this.XrLabel24.Multiline = true;
			this.XrLabel24.Name = "XrLabel24";
			this.XrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel24.SizeF = new System.Drawing.SizeF((float) (270.0F), (float) (22.99999F));
			this.XrLabel24.StylePriority.UseTextAlignment = false;
			this.XrLabel24.Text = "Thank you! Please come again!!!";
			this.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel22
			//
			this.XrLabel22.LocationFloat = new DevExpress.Utils.PointFloat((float) (62.50003F), (float) (94.95831F));
			this.XrLabel22.Multiline = true;
			this.XrLabel22.Name = "XrLabel22";
			this.XrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel22.SizeF = new System.Drawing.SizeF((float) (52.50001F), (float) (23.0F));
			this.XrLabel22.StylePriority.UseTextAlignment = false;
			this.XrLabel22.Text = "item(s)";
			this.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrLabel21
			//
			this.XrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.Cheyns", "{0:n2}")});
			this.XrLabel21.LocationFloat = new DevExpress.Utils.PointFloat((float) (183.3333F), (float) (71.95829F));
			this.XrLabel21.Name = "XrLabel21";
			this.XrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel21.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel21.StylePriority.UseTextAlignment = false;
			this.XrLabel21.Text = "XrLabel21";
			this.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel20
			//
			this.XrLabel20.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (71.95825F));
			this.XrLabel20.Multiline = true;
			this.XrLabel20.Name = "XrLabel20";
			this.XrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel20.SizeF = new System.Drawing.SizeF((float) (125.4167F), (float) (23.00001F));
			this.XrLabel20.StylePriority.UseTextAlignment = false;
			this.XrLabel20.Text = "C H A N G E:";
			this.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel18
			//
			this.XrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.tendered", "{0:n2}")});
			this.XrLabel18.LocationFloat = new DevExpress.Utils.PointFloat((float) (183.3333F), (float) (40.54165F));
			this.XrLabel18.Name = "XrLabel18";
			this.XrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel18.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel18.StylePriority.UseTextAlignment = false;
			this.XrLabel18.Text = "XrLabel18";
			this.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel19
			//
			this.XrLabel19.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (40.54165F));
			this.XrLabel19.Multiline = true;
			this.XrLabel19.Name = "XrLabel19";
			this.XrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel19.SizeF = new System.Drawing.SizeF((float) (125.4167F), (float) (23.0F));
			this.XrLabel19.StylePriority.UseTextAlignment = false;
			this.XrLabel19.Text = "T E N D E R E D:";
			this.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel16
			//
			this.XrLabel16.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (10.00001F));
			this.XrLabel16.Multiline = true;
			this.XrLabel16.Name = "XrLabel16";
			this.XrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel16.SizeF = new System.Drawing.SizeF((float) (125.4167F), (float) (23.0F));
			this.XrLabel16.StylePriority.UseTextAlignment = false;
			this.XrLabel16.Text = "T O T A L:";
			this.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel17
			//
			this.XrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.totsales", "{0:n2}")});
			this.XrLabel17.LocationFloat = new DevExpress.Utils.PointFloat((float) (183.3333F), (float) (10.00001F));
			this.XrLabel17.Name = "XrLabel17";
			this.XrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel17.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel17.StylePriority.UseTextAlignment = false;
			this.XrLabel17.Text = "XrLabel17";
			this.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLine4
			//
			this.XrLine4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
			this.XrLine4.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
			this.XrLine4.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00004F), (float) (63.5416F));
			this.XrLine4.Name = "XrLine4";
			this.XrLine4.SizeF = new System.Drawing.SizeF((float) (270.0F), (float) (8.416664F));
			this.XrLine4.StylePriority.UseBorderDashStyle = false;
			//
			//ReferenceNo
			//
			this.ReferenceNo.Description = "ReferenceNo";
			this.ReferenceNo.Name = "ReferenceNo";
			this.ReferenceNo.Type = typeof(int);
			this.ReferenceNo.ValueInfo = "0";
			//
			//Taym
			//
			this.Taym.DataMember = "receiptpos";
			this.Taym.Expression = "Now()";
			this.Taym.Name = "Taym";
			//
			//FormattingRule1
			//
			this.FormattingRule1.Condition = "[firstname]=\'CASH\'";
			//
			//
			//
			this.FormattingRule1.Formatting.BorderColor = System.Drawing.Color.Transparent;
			this.FormattingRule1.Formatting.ForeColor = System.Drawing.Color.Transparent;
			this.FormattingRule1.Name = "FormattingRule1";
			//
			//cashier
			//
			this.cashier.Description = "Cashier";
			this.cashier.Name = "cashier";
			this.cashier.Visible = false;
			//
			//xrReprint
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.GroupHeader1, this.GroupFooter1});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {this.Taym});
			this.DataAdapter = this.ReceiptposTableAdapter;
			this.DataMember = "receiptpos";
			this.DataSource = this.SpDataSet11;
			this.DesignerOptions.ShowPrintingWarnings = false;
			this.FilterString = "[postmp_hdrid] = ?ReferenceNo And [sInsert_id] = ?cashier";
			this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {this.FormattingRule1});
			this.Margins = new System.Drawing.Printing.Margins(4, 5, 66, 13);
			this.PageHeight = 1169;
			this.PageWidth = 299;
			this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.PaperName = "Roll Paper 76 x 297 mm";
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.ReferenceNo, this.cashier});
			this.PrinterName = "EPSON TM-U220 Receipt";
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "13.2";
			((System.ComponentModel.ISupportInitialize) this.SpDataSet11).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DoorsPOS.WinApp.SpDataSet1 SpDataSet11;
		internal DoorsPOS.WinApp.SpDataSet1TableAdapters.receiptposTableAdapter ReceiptposTableAdapter;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel14;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel15;
		internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel28;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel30;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel29;
		internal DevExpress.XtraReports.UI.XRLine XrLine3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel25;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel26;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel31;
		internal DevExpress.XtraReports.UI.XRLine XrLine5;
		internal DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel23;
		internal DevExpress.XtraReports.UI.XRLine XrLine2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel24;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel22;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel21;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel20;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel18;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel19;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel16;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel17;
		internal DevExpress.XtraReports.UI.XRLine XrLine4;
		internal DevExpress.XtraReports.Parameters.Parameter ReferenceNo;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel13;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel27;
		internal DevExpress.XtraReports.UI.CalculatedField Taym;
		internal DevExpress.XtraReports.UI.FormattingRule FormattingRule1;
		internal DevExpress.XtraReports.Parameters.Parameter cashier;
	}
	
}
