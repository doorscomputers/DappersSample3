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
	partial class xrReadingID : DevExpress.XtraReports.UI.XtraReport
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
			this.DsRdngRefNo1 = new DoorsPOS.WinApp.dsRdngRefNo();
			this.TblreadingTableAdapter = new DoorsPOS.WinApp.dsRdngRefNoTableAdapters.tblreadingTableAdapter();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize) this.DsRdngRefNo1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel5, this.XrLabel4});
			this.Detail.HeightF = (float) (34.375F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//TopMargin
			//
			this.TopMargin.HeightF = (float) (12.5F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (11.45833F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel7, this.XrLabel6, this.XrLabel3, this.XrLabel2, this.XrLabel1});
			this.ReportHeader.HeightF = (float) (103.125F);
			this.ReportHeader.Name = "ReportHeader";
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (255.0F), (float) (23.0F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "Cashier Reading Reference Nos.";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel2
			//
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (70.12501F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel2.Text = "Name";
			//
			//XrLabel3
			//
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (165.0F), (float) (70.12501F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "Reference No.";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//DsRdngRefNo1
			//
			this.DsRdngRefNo1.DataSetName = "dsRdngRefNo";
			this.DsRdngRefNo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//TblreadingTableAdapter
			//
			this.TblreadingTableAdapter.ClearBeforeFill = true;
			//
			//XrLabel4
			//
			this.XrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.cashier")});
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel4.Text = "XrLabel4";
			//
			//XrLabel5
			//
			this.XrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.cashreadid")});
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (165.0F), (float) (0.0F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "XrLabel5";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel6
			//
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (37.83334F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (39.58333F), (float) (23.0F));
			this.XrLabel6.Text = "Date";
			//
			//XrLabel7
			//
			this.XrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "tblreading.datereading", "{0:MM/dd/yyyy}")});
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (49.58334F), (float) (37.83334F));
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (215.4167F), (float) (23.0F));
			this.XrLabel7.Text = "XrLabel7";
			//
			//xrReadingID
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.ReportHeader});
			this.DataAdapter = this.TblreadingTableAdapter;
			this.DataMember = "tblreading";
			this.DataSource = this.DsRdngRefNo1;
			this.FilterString = "[status] = False";
			this.Margins = new System.Drawing.Printing.Margins(12, 12, 12, 11);
			this.PageHeight = 1169;
			this.PageWidth = 299;
			this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.PaperName = "Roll Paper 76 x 297 mm";
			this.PrinterName = "EPSON TM-U220 Receipt";
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "13.2";
			((System.ComponentModel.ISupportInitialize) this.DsRdngRefNo1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DoorsPOS.WinApp.dsRdngRefNo DsRdngRefNo1;
		internal DoorsPOS.WinApp.dsRdngRefNoTableAdapters.tblreadingTableAdapter TblreadingTableAdapter;
	}
	
}
