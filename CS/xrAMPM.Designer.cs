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
	partial class xrAMPM : DevExpress.XtraReports.UI.XtraReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xrAMPM));
			DevExpress.XtraReports.UI.XRSummary XrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.SpDataSet11 = new DoorsPOS.WinApp.SpDataSet1();
			this.ReceiptposTableAdapter = new DoorsPOS.WinApp.SpDataSet1TableAdapters.receiptposTableAdapter();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.AmPm = new DevExpress.XtraReports.UI.CalculatedField();
			this.calcHour = new DevExpress.XtraReports.UI.CalculatedField();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.XrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize) this.SpDataSet11).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel1, this.XrLabel2, this.XrLabel3, this.XrLabel4});
			this.Detail.HeightF = (float) (23.0F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel1
			//
			this.XrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.det_amnt", "{0:n2}")});
			this.XrLabel1.Font = new System.Drawing.Font("Courier New", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (232.0F), (float) (0.0F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (57.29167F), (float) (23.0F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "XrLabel1";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel2
			//
			this.XrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.item_desc")});
			this.XrLabel2.Font = new System.Drawing.Font("Courier New", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (60.00001F), (float) (0.0F));
			this.XrLabel2.Multiline = true;
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (129.2917F), (float) (23.0F));
			this.XrLabel2.StylePriority.UseFont = false;
			this.XrLabel2.Text = "XrLabel2";
			//
			//XrLabel3
			//
			this.XrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.qty", "{0:n}")});
			this.XrLabel3.Font = new System.Drawing.Font("Courier New", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (189.2917F), (float) (0.0F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (42.70833F), (float) (23.0F));
			this.XrLabel3.StylePriority.UseFont = false;
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "XrLabel3";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel4
			//
			this.XrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.pos_tme", "{0:HH:mm}")});
			this.XrLabel4.Font = new System.Drawing.Font("Courier New", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (2.70834F), (float) (0.0F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (57.29166F), (float) (23.0F));
			this.XrLabel4.StylePriority.UseFont = false;
			this.XrLabel4.Text = "XrLabel4";
			//
			//TopMargin
			//
			this.TopMargin.HeightF = (float) (13.54167F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (20.74998F);
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
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel11, this.XrLabel8});
			this.ReportHeader.HeightF = (float) (44.31249F);
			this.ReportHeader.Name = "ReportHeader";
			//
			//XrLabel11
			//
			this.XrLabel11.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (3.604158F));
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel11.SizeF = new System.Drawing.SizeF((float) (179.2917F), (float) (17.70833F));
			this.XrLabel11.StylePriority.UseFont = false;
			this.XrLabel11.Text = "Items Sold Report (AM/PM)";
			//
			//XrLabel8
			//
			this.XrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "dtprinted", "{0:MM/dd/yyyy}")});
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (21.31249F));
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (150.0F), (float) (23.0F));
			this.XrLabel8.Text = "XrLabel8";
			//
			//AmPm
			//
			this.AmPm.DataMember = "receiptpos";
			this.AmPm.Expression = resources.GetString("AmPm.Expression");
			this.AmPm.Name = "AmPm";
			//
			//calcHour
			//
			this.calcHour.DataMember = "receiptpos";
			this.calcHour.Expression = "GetHour([pos_tme])";
			this.calcHour.Name = "calcHour";
			//
			//GroupHeader1
			//
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel10, this.XrLabel6});
			this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("pos_date", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.GroupHeader1.HeightF = (float) (23.0F);
			this.GroupHeader1.Name = "GroupHeader1";
			//
			//XrLabel10
			//
			this.XrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.pos_date", "{0:MM/dd/yyyy}")});
			this.XrLabel10.Font = new System.Drawing.Font("Courier New", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (87.5F), (float) (23.0F));
			this.XrLabel10.StylePriority.UseFont = false;
			this.XrLabel10.Text = "XrLabel10";
			//
			//XrLabel6
			//
			this.XrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.AmPM")});
			this.XrLabel6.Font = new System.Drawing.Font("Courier New", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (97.50001F), (float) (0.0F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (62.5F), (float) (23.0F));
			this.XrLabel6.StylePriority.UseFont = false;
			this.XrLabel6.Text = "XrLabel6";
			//
			//GroupFooter1
			//
			this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel5, this.XrLabel9});
			this.GroupFooter1.HeightF = (float) (23.00001F);
			this.GroupFooter1.Name = "GroupFooter1";
			//
			//XrLabel5
			//
			this.XrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.det_amnt")});
			this.XrLabel5.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (189.2917F), (float) (0.000005722046F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (102.7083F), (float) (23.0F));
			this.XrLabel5.StylePriority.UseFont = false;
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			XrSummary1.FormatString = "{0:n2}";
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.XrLabel5.Summary = XrSummary1;
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel9
			//
			this.XrLabel9.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (4.166667F));
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (90.20832F), (float) (18.83334F));
			this.XrLabel9.StylePriority.UseFont = false;
			this.XrLabel9.Text = "TOTAL:";
			//
			//ReportFooter
			//
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel12, this.XrLabel13});
			this.ReportFooter.HeightF = (float) (28.83335F);
			this.ReportFooter.Name = "ReportFooter";
			//
			//XrLabel12
			//
			this.XrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "receiptpos.det_amnt")});
			this.XrLabel12.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat((float) (189.2917F), (float) (5.83334F));
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel12.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel12.StylePriority.UseFont = false;
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			XrSummary2.FormatString = "{0:n2}";
			XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.XrLabel12.Summary = XrSummary2;
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel13
			//
			this.XrLabel13.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (10.00001F));
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel13.SizeF = new System.Drawing.SizeF((float) (119.7917F), (float) (18.83334F));
			this.XrLabel13.StylePriority.UseFont = false;
			this.XrLabel13.Text = "GRAND TOTAL:";
			//
			//xrAMPM
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.ReportHeader, this.GroupHeader1, this.GroupFooter1, this.ReportFooter});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {this.AmPm, this.calcHour});
			this.DataAdapter = this.ReceiptposTableAdapter;
			this.DataMember = "receiptpos";
			this.DataSource = this.SpDataSet11;
			this.Margins = new System.Drawing.Printing.Margins(2, 5, 14, 21);
			this.PageHeight = 1169;
			this.PageWidth = 299;
			this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.PaperName = "Roll Paper 76 x 297 mm";
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
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.CalculatedField AmPm;
		internal DevExpress.XtraReports.UI.CalculatedField calcHour;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel13;
	}
	
}
