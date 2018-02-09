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
	partial class xrPay : DevExpress.XtraReports.UI.XtraReport
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
			this.DsCustPays1 = new DoorsPOS.WinApp.dsCustPays();
			this.VwCustPayTableAdapter = new DoorsPOS.WinApp.dsCustPaysTableAdapters.vwCustPayTableAdapter();
			this.Cashier = new DevExpress.XtraReports.Parameters.Parameter();
			this.PayDay = new DevExpress.XtraReports.Parameters.Parameter();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.CalculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			((System.ComponentModel.ISupportInitialize) this.DsCustPays1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel9, this.XrLabel8, this.XrLabel7, this.XrLabel6, this.XrLabel5, this.XrLabel4, this.XrLabel2, this.XrLabel3});
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//TopMargin
			//
			this.TopMargin.HeightF = (float) (11.54167F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (14.58333F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//DsCustPays1
			//
			this.DsCustPays1.DataSetName = "dsCustPays";
			this.DsCustPays1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VwCustPayTableAdapter
			//
			this.VwCustPayTableAdapter.ClearBeforeFill = true;
			//
			//Cashier
			//
			this.Cashier.Description = "Cashier";
			this.Cashier.Name = "Cashier";
			this.Cashier.Visible = false;
			//
			//PayDay
			//
			this.PayDay.Description = "PayDay";
			this.PayDay.Name = "PayDay";
			this.PayDay.Type = typeof(DateTime);
			this.PayDay.Visible = false;
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F));
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (265.0F), (float) (23.0F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "Payment";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrPageInfo1, this.XrLabel1});
			this.ReportHeader.HeightF = (float) (60.5F);
			this.ReportHeader.Name = "ReportHeader";
			//
			//XrLabel2
			//
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (88.45833F), (float) (23.0F));
			this.XrLabel2.Text = "Name";
			//
			//CalculatedField1
			//
			this.CalculatedField1.DataMember = "vwCustPay";
			this.CalculatedField1.Expression = "[lastname]+\',\'+[firstname]";
			this.CalculatedField1.Name = "CalculatedField1";
			//
			//XrLabel3
			//
			this.XrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwCustPay.CalculatedField1")});
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45839F), (float) (0.0F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (176.5417F), (float) (23.0F));
			this.XrLabel3.Text = "XrLabel3";
			//
			//XrLabel4
			//
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00007F), (float) (45.99997F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (88.45833F), (float) (23.0F));
			this.XrLabel4.Text = "Amount Paid";
			//
			//XrLabel5
			//
			this.XrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwCustPay.Amount", "{0:n2}")});
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45839F), (float) (45.99997F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (176.5416F), (float) (23.0F));
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "XrLabel5";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel6
			//
			this.XrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwCustPay.OldBal", "{0:n2}")});
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45839F), (float) (22.99999F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (176.5416F), (float) (23.0F));
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "XrLabel6";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel7
			//
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (22.99999F));
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (88.45833F), (float) (23.0F));
			this.XrLabel7.Text = "Old Bal.";
			//
			//XrLabel8
			//
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00007F), (float) (68.99999F));
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (88.45833F), (float) (23.0F));
			this.XrLabel8.Text = "New Balance";
			//
			//XrLabel9
			//
			this.XrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwCustPay.NewBal", "{0:n2}")});
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (98.45839F), (float) (68.99996F));
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (176.5416F), (float) (23.0F));
			this.XrLabel9.StylePriority.UseTextAlignment = false;
			this.XrLabel9.Text = "XrLabel9";
			this.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrPageInfo1
			//
			this.XrPageInfo1.Format = "{0:dddd, MMMM dd, yyyy h:mm tt}";
			this.XrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (37.5F));
			this.XrPageInfo1.Name = "XrPageInfo1";
			this.XrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (96.0F));
			this.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.XrPageInfo1.SizeF = new System.Drawing.SizeF((float) (265.0F), (float) (23.0F));
			//
			//xrPay
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.ReportHeader});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {this.CalculatedField1});
			this.DataAdapter = this.VwCustPayTableAdapter;
			this.DataMember = "vwCustPay";
			this.DataSource = this.DsCustPays1;
			this.FilterString = "[sInsert_id] = ?Cashier And [PayDate] = ?PayDay";
			this.Margins = new System.Drawing.Printing.Margins(6, 8, 12, 15);
			this.PageHeight = 1169;
			this.PageWidth = 299;
			this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.PaperName = "Roll Paper 76 x 297 mm";
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.Cashier, this.PayDay});
			this.PrinterName = "EPSON TM-U220 Receipt";
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "13.2";
			((System.ComponentModel.ISupportInitialize) this.DsCustPays1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DoorsPOS.WinApp.dsCustPays DsCustPays1;
		internal DoorsPOS.WinApp.dsCustPaysTableAdapters.vwCustPayTableAdapter VwCustPayTableAdapter;
		internal DevExpress.XtraReports.Parameters.Parameter Cashier;
		internal DevExpress.XtraReports.Parameters.Parameter PayDay;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRPageInfo XrPageInfo1;
		internal DevExpress.XtraReports.UI.CalculatedField CalculatedField1;
	}
	
}
