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
	partial class xrCustPayReceipt : DevExpress.XtraReports.UI.XtraReport
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
			this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.DsCustPayReceipt1 = new DoorsPOS.WinApp.dsCustPayReceipt();
			this.PaymentTableAdapter = new DoorsPOS.WinApp.dsCustPayReceiptTableAdapters.paymentTableAdapter();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.LF = new DevExpress.XtraReports.UI.CalculatedField();
			this.cID = new DevExpress.XtraReports.Parameters.Parameter();
			this.CurDate = new DevExpress.XtraReports.Parameters.Parameter();
			this.XrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize) this.DsCustPayReceipt1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel13, this.XrLabel12, this.XrLabel11});
			this.Detail.HeightF = (float) (29.58336F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel13
			//
			this.XrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "payment.NewBal", "{0:n2}")});
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat((float) (207.9167F), (float) (0.0F));
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel13.SizeF = new System.Drawing.SizeF((float) (71.0833F), (float) (23.0F));
			this.XrLabel13.StylePriority.UseTextAlignment = false;
			this.XrLabel13.Text = "XrLabel13";
			this.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel12
			//
			this.XrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "payment.OldBal", "{0:n2}")});
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat((float) (107.2917F), (float) (0.0F));
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel12.SizeF = new System.Drawing.SizeF((float) (82.29165F), (float) (23.0F));
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.Text = "XrLabel12";
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel11
			//
			this.XrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "payment.Amount", "{0:n2}")});
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel11.SizeF = new System.Drawing.SizeF((float) (83.58329F), (float) (23.0F));
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			this.XrLabel11.Text = "XrLabel11";
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//TopMargin
			//
			this.TopMargin.HeightF = (float) (8.333333F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel14});
			this.BottomMargin.HeightF = (float) (52.79166F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//DsCustPayReceipt1
			//
			this.DsCustPayReceipt1.DataSetName = "dsCustPayReceipt";
			this.DsCustPayReceipt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//PaymentTableAdapter
			//
			this.PaymentTableAdapter.ClearBeforeFill = true;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel5, this.XrLabel10, this.XrLabel9, this.XrLabel8, this.XrLabel7, this.XrLabel6, this.XrLabel4, this.XrLabel3, this.XrLabel2, this.XrLabel1});
			this.ReportHeader.HeightF = (float) (127.0833F);
			this.ReportHeader.Name = "ReportHeader";
			//
			//XrLabel5
			//
			this.XrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "payment.DateIssued", "{0:MM/dd/yyyy}")});
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (93.5833F), (float) (46.0F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (185.4167F), (float) (23.0F));
			this.XrLabel5.Text = "XrLabel5";
			//
			//XrLabel10
			//
			this.XrLabel10.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (207.9167F), (float) (104.0833F));
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (71.08329F), (float) (23.0F));
			this.XrLabel10.StylePriority.UseFont = false;
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "New Bal";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel9
			//
			this.XrLabel9.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (107.2917F), (float) (104.0833F));
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (82.29163F), (float) (23.0F));
			this.XrLabel9.StylePriority.UseFont = false;
			this.XrLabel9.StylePriority.UseTextAlignment = false;
			this.XrLabel9.Text = "Old Bal";
			this.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel8
			//
			this.XrLabel8.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (104.0833F));
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (83.58329F), (float) (23.0F));
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "Amount Pd";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel7
			//
			this.XrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "payment.LF")});
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (93.5833F), (float) (69.00002F));
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (185.4167F), (float) (23.0F));
			this.XrLabel7.Text = "XrLabel7";
			//
			//XrLabel6
			//
			this.XrLabel6.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (69.00002F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (83.58329F), (float) (23.0F));
			this.XrLabel6.StylePriority.UseFont = false;
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "Customer";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel4
			//
			this.XrLabel4.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (46.0F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (83.58329F), (float) (23.0F));
			this.XrLabel4.StylePriority.UseFont = false;
			this.XrLabel4.StylePriority.UseTextAlignment = false;
			this.XrLabel4.Text = "Date";
			this.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel3
			//
			this.XrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "payment.sInsert_id")});
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (93.5833F), (float) (23.0F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (185.4167F), (float) (23.0F));
			this.XrLabel3.Text = "XrLabel3";
			//
			//XrLabel2
			//
			this.XrLabel2.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (23.0F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (83.58329F), (float) (23.0F));
			this.XrLabel2.StylePriority.UseFont = false;
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "Cashier";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (269.0F), (float) (23.0F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "Customer Payment Receipt";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//LF
			//
			this.LF.DataMember = "payment";
			this.LF.Expression = "trim([firstname])+\',\'+trim([lastname])+\',\'+trim([middlename])";
			this.LF.Name = "LF";
			//
			//cID
			//
			this.cID.Description = "CustID";
			this.cID.Name = "cID";
			this.cID.Type = typeof(int);
			this.cID.ValueInfo = "0";
			//
			//CurDate
			//
			this.CurDate.Description = "Current Date";
			this.CurDate.Name = "CurDate";
			this.CurDate.Type = typeof(DateTime);
			//
			//XrLabel14
			//
			this.XrLabel14.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (19.79167F));
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel14.SizeF = new System.Drawing.SizeF((float) (269.0F), (float) (23.0F));
			this.XrLabel14.StylePriority.UseFont = false;
			this.XrLabel14.StylePriority.UseTextAlignment = false;
			this.XrLabel14.Text = "Signature:____________________________";
			this.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//xrCustPayReceipt
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.ReportHeader});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {this.LF});
			this.DataAdapter = this.PaymentTableAdapter;
			this.DataMember = "payment";
			this.DataSource = this.DsCustPayReceipt1;
			this.FilterString = "[CustID] = ?cID And [DateIssued] = ?CurDate";
			this.Margins = new System.Drawing.Printing.Margins(5, 5, 8, 53);
			this.PageHeight = 1169;
			this.PageWidth = 299;
			this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.PaperName = "Roll Paper 76 x 297 mm";
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.cID, this.CurDate});
			this.PrinterName = "EPSON TM-U220 Receipt";
			this.RequestParameters = false;
			this.Version = "14.1";
			((System.ComponentModel.ISupportInitialize) this.DsCustPayReceipt1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DoorsPOS.WinApp.dsCustPayReceipt DsCustPayReceipt1;
		internal DoorsPOS.WinApp.dsCustPayReceiptTableAdapters.paymentTableAdapter PaymentTableAdapter;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel13;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.CalculatedField LF;
		internal DevExpress.XtraReports.Parameters.Parameter cID;
		internal DevExpress.XtraReports.Parameters.Parameter CurDate;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel14;
	}
	
}
