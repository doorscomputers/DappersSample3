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
	partial class xrGetCash : DevExpress.XtraReports.UI.XtraReport
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
			this.XrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.DsPtyCashprint1 = new DoorsPOS.WinApp.dsPtyCashprint();
			this.Petty_cashTableAdapter = new DoorsPOS.WinApp.dsPtyCashprintTableAdapters.petty_cashTableAdapter();
			this.Dspcash1 = new DoorsPOS.WinApp.dspcash();
			this.Petty_cashTableAdapter1 = new DoorsPOS.WinApp.dspcashTableAdapters.petty_cashTableAdapter();
			this.ptyCashID = new DevExpress.XtraReports.Parameters.Parameter();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			((System.ComponentModel.ISupportInitialize) this.DsPtyCashprint1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.Dspcash1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLine1, this.XrLabel10, this.XrLabel9, this.XrLabel8, this.XrLabel6, this.XrLabel7});
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLine1
			//
			this.XrLine1.LocationFloat = new DevExpress.Utils.PointFloat((float) (102.7083F), (float) (84.79166F));
			this.XrLine1.Name = "XrLine1";
			this.XrLine1.SizeF = new System.Drawing.SizeF((float) (169.7917F), (float) (5.208336F));
			//
			//XrLabel10
			//
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (23.54167F), (float) (67.00001F));
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (79.16666F), (float) (23.0F));
			this.XrLabel10.Text = "Received by:";
			//
			//XrLabel9
			//
			this.XrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "petty_cash.pcrem")});
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (123.5417F), (float) (22.99999F));
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (148.9583F), (float) (23.0F));
			this.XrLabel9.Text = "XrLabel9";
			//
			//XrLabel8
			//
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (23.54167F), (float) (22.99999F));
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel8.Text = "Note:";
			//
			//XrLabel6
			//
			this.XrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "petty_cash.pcamnt", "{0:c2}")});
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (123.5417F), (float) (0.0F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "XrLabel6";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel7
			//
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (23.54167F), (float) (0.0F));
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel7.Text = "Amount:";
			//
			//TopMargin
			//
			this.TopMargin.HeightF = (float) (10.0F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (8.0F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrPageInfo1, this.XrLabel4, this.XrLabel3, this.XrLabel2, this.XrLabel1});
			this.ReportHeader.HeightF = (float) (93.83334F);
			this.ReportHeader.Name = "ReportHeader";
			//
			//XrLabel3
			//
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (23.54167F), (float) (67.00001F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (79.16665F), (float) (23.0F));
			this.XrLabel3.Text = "Date/Time:";
			//
			//XrLabel2
			//
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (23.54167F), (float) (36.45833F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (79.16666F), (float) (23.0F));
			this.XrLabel2.Text = "Cashier:";
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (23.54167F), (float) (0.0F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (246.4583F), (float) (23.0F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "Cash Taken from Cashier";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//DsPtyCashprint1
			//
			this.DsPtyCashprint1.DataSetName = "dsPtyCashprint";
			this.DsPtyCashprint1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//Petty_cashTableAdapter
			//
			this.Petty_cashTableAdapter.ClearBeforeFill = true;
			//
			//Dspcash1
			//
			this.Dspcash1.DataSetName = "dspcash";
			this.Dspcash1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//Petty_cashTableAdapter1
			//
			this.Petty_cashTableAdapter1.ClearBeforeFill = true;
			//
			//ptyCashID
			//
			this.ptyCashID.Description = "PtyCashID";
			this.ptyCashID.Name = "ptyCashID";
			this.ptyCashID.Type = typeof(int);
			this.ptyCashID.ValueInfo = "0";
			this.ptyCashID.Visible = false;
			//
			//XrLabel4
			//
			this.XrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "petty_cash.cashier")});
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (102.7083F), (float) (36.45833F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (135.4166F), (float) (23.0F));
			this.XrLabel4.Text = "XrLabel4";
			//
			//XrPageInfo1
			//
			this.XrPageInfo1.Format = "{0:MMMM dd, yyyy HH:mm}";
			this.XrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat((float) (102.7083F), (float) (67.00001F));
			this.XrPageInfo1.Name = "XrPageInfo1";
			this.XrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.XrPageInfo1.SizeF = new System.Drawing.SizeF((float) (167.2917F), (float) (23.0F));
			//
			//xrGetCash
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.ReportHeader});
			this.DataAdapter = this.Petty_cashTableAdapter;
			this.DataMember = "petty_cash";
			this.DataSource = this.Dspcash1;
			this.FilterString = "[pcid] = ?ptyCashID";
			this.Margins = new System.Drawing.Printing.Margins(8, 6, 10, 8);
			this.PageHeight = 1169;
			this.PageWidth = 299;
			this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.PaperName = "Roll Paper 76 x 297 mm";
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.ptyCashID});
			this.PrinterName = "EPSON TM-U220 Receipt";
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "13.2";
			((System.ComponentModel.ISupportInitialize) this.DsPtyCashprint1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.Dspcash1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLine XrLine1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DoorsPOS.WinApp.dsPtyCashprint DsPtyCashprint1;
		internal DoorsPOS.WinApp.dsPtyCashprintTableAdapters.petty_cashTableAdapter Petty_cashTableAdapter;
		internal DoorsPOS.WinApp.dspcash Dspcash1;
		internal DoorsPOS.WinApp.dspcashTableAdapters.petty_cashTableAdapter Petty_cashTableAdapter1;
		internal DevExpress.XtraReports.Parameters.Parameter ptyCashID;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRPageInfo XrPageInfo1;
	}
	
}
