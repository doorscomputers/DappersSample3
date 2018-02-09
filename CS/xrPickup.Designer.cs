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
	partial class xrPickup : DevExpress.XtraReports.UI.XtraReport
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
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.DsPettyCsh1 = new DoorsPOS.WinApp.dsPettyCsh();
			this.Petty_cashTableAdapter = new DoorsPOS.WinApp.dsPettyCshTableAdapters.petty_cashTableAdapter();
			this.Cshier = new DevExpress.XtraReports.Parameters.Parameter();
			this.pcDate = new DevExpress.XtraReports.Parameters.Parameter();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine1 = new DevExpress.XtraReports.UI.XRLine();
			((System.ComponentModel.ISupportInitialize) this.DsPettyCsh1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel9, this.XrLabel8});
			this.Detail.HeightF = (float) (25.0F);
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
			this.BottomMargin.HeightF = (float) (10.41667F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel7, this.XrLabel6, this.XrLabel5, this.XrLabel4, this.XrLabel3, this.XrLabel2, this.XrLabel1});
			this.ReportHeader.HeightF = (float) (115.7084F);
			this.ReportHeader.Name = "ReportHeader";
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.99999F), (float) (0.0F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (270.0F), (float) (23.0F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "Cash Taken from Cashier";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel2
			//
			this.XrLabel2.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (23.0F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (59.375F), (float) (23.0F));
			this.XrLabel2.StylePriority.UseFont = false;
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "Cashier";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel3
			//
			this.XrLabel3.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (46.0F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (59.375F), (float) (23.0F));
			this.XrLabel3.StylePriority.UseFont = false;
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "Date";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//DsPettyCsh1
			//
			this.DsPettyCsh1.DataSetName = "dsPettyCsh";
			this.DsPettyCsh1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//Petty_cashTableAdapter
			//
			this.Petty_cashTableAdapter.ClearBeforeFill = true;
			//
			//Cshier
			//
			this.Cshier.Description = "Cshier";
			this.Cshier.Name = "Cshier";
			this.Cshier.Visible = false;
			//
			//pcDate
			//
			this.pcDate.Description = "pcDate";
			this.pcDate.Name = "pcDate";
			this.pcDate.Type = typeof(DateTime);
			this.pcDate.ValueInfo = "2014-01-01";
			this.pcDate.Visible = false;
			//
			//XrLabel4
			//
			this.XrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding(this.Cshier, "Text", "")});
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (69.37501F), (float) (23.0F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (148.9583F), (float) (23.0F));
			this.XrLabel4.Text = "XrLabel4";
			//
			//XrLabel5
			//
			this.XrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding(this.pcDate, "Text", "{0:MM/dd/yyyy}")});
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (69.37501F), (float) (46.0F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (148.9583F), (float) (23.0F));
			this.XrLabel5.Text = "XrLabel5";
			//
			//XrLabel6
			//
			this.XrLabel6.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (92.70837F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (59.375F), (float) (23.0F));
			this.XrLabel6.StylePriority.UseFont = false;
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "Amount ";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel7
			//
			this.XrLabel7.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (129.1667F), (float) (92.70837F));
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (59.375F), (float) (23.0F));
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.StylePriority.UseTextAlignment = false;
			this.XrLabel7.Text = "Remark";
			this.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel8
			//
			this.XrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "petty_cash.pcamnt", "{0:n2}")});
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.99999F), (float) (0.0F));
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel8.Text = "XrLabel8";
			//
			//XrLabel9
			//
			this.XrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "petty_cash.pcrem")});
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (129.1667F), (float) (0.0F));
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (150.8333F), (float) (23.0F));
			this.XrLabel9.Text = "XrLabel9";
			//
			//PageFooter
			//
			this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLine1, this.XrLabel10});
			this.PageFooter.HeightF = (float) (54.16667F);
			this.PageFooter.Name = "PageFooter";
			//
			//XrLabel10
			//
			this.XrLabel10.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (122.9167F), (float) (23.0F));
			this.XrLabel10.StylePriority.UseFont = false;
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "Signature";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLine1
			//
			this.XrLine1.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (49.37499F));
			this.XrLine1.Name = "XrLine1";
			this.XrLine1.SizeF = new System.Drawing.SizeF((float) (257.2917F), (float) (4.166668F));
			//
			//xrPickup
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.ReportHeader, this.PageFooter});
			this.DataAdapter = this.Petty_cashTableAdapter;
			this.DataMember = "petty_cash";
			this.DataSource = this.DsPettyCsh1;
			this.FilterString = "[cashier] = ?Cshier And [posdate] = ?pcDate";
			this.Margins = new System.Drawing.Printing.Margins(3, 6, 18, 10);
			this.PageHeight = 1169;
			this.PageWidth = 299;
			this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.PaperName = "Roll Paper 76 x 297 mm";
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.Cshier, this.pcDate});
			this.PrinterName = "EPSON TM-U220 Receipt";
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "13.2";
			((System.ComponentModel.ISupportInitialize) this.DsPettyCsh1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.Parameters.Parameter pcDate;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.Parameters.Parameter Cshier;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DoorsPOS.WinApp.dsPettyCsh DsPettyCsh1;
		internal DoorsPOS.WinApp.dsPettyCshTableAdapters.petty_cashTableAdapter Petty_cashTableAdapter;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.XRLine XrLine1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
	}
	
}
