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
	partial class xrCustPay : DevExpress.XtraReports.UI.XtraReport
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
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.XrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.DsCustPayRep1 = new DoorsPOS.WinApp.dsCustPayRep();
			this.VwCustPayTableAdapter = new DoorsPOS.WinApp.dsCustPayRepTableAdapters.vwCustPayTableAdapter();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.Lname = new DevExpress.XtraReports.Parameters.Parameter();
			this.Fname = new DevExpress.XtraReports.Parameters.Parameter();
			this.Customer = new DevExpress.XtraReports.UI.CalculatedField();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.XrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize) this.DsCustPayRep1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel7, this.XrLabel6, this.XrLabel5, this.XrLabel4});
			this.Detail.HeightF = (float) (23.0F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel7
			//
			this.XrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwCustPay.NewBal", "{0:n2}")});
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (540.0F), (float) (0.0F));
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel7.StylePriority.UseTextAlignment = false;
			this.XrLabel7.Text = "XrLabel7";
			this.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel6
			//
			this.XrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwCustPay.OldBal", "{0:n2}")});
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (266.25F), (float) (0.0F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "XrLabel6";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel5
			//
			this.XrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwCustPay.Amount", "{0:n2}")});
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (418.1248F), (float) (0.0F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "XrLabel5";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel4
			//
			this.XrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwCustPay.PayDate", "{0:MM/dd/yyyy}")});
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (69.37501F), (float) (0.0F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (171.875F), (float) (23.0F));
			this.XrLabel4.Text = "XrLabel4";
			//
			//TopMargin
			//
			this.TopMargin.HeightF = (float) (20.83333F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (16.58331F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrPageInfo1, this.XrLabel2, this.XrLabel1});
			this.ReportHeader.HeightF = (float) (62.16668F);
			this.ReportHeader.Name = "ReportHeader";
			//
			//XrPageInfo1
			//
			this.XrPageInfo1.Format = "{0:MM/dd/yyyy h:mm tt}";
			this.XrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat((float) (86.04167F), (float) (38.12501F));
			this.XrPageInfo1.Name = "XrPageInfo1";
			this.XrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.XrPageInfo1.SizeF = new System.Drawing.SizeF((float) (143.75F), (float) (24.04167F));
			//
			//XrLabel2
			//
			this.XrLabel2.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F));
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (38.12501F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (76.04166F), (float) (24.04167F));
			this.XrLabel2.StylePriority.UseFont = false;
			this.XrLabel2.Text = "Printed On:";
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (10.00001F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (207.2917F), (float) (24.04167F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.Text = "Customer Payments";
			//
			//DsCustPayRep1
			//
			this.DsCustPayRep1.DataSetName = "dsCustPayRep";
			this.DsCustPayRep1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VwCustPayTableAdapter
			//
			this.VwCustPayTableAdapter.ClearBeforeFill = true;
			//
			//ReportFooter
			//
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel8});
			this.ReportFooter.HeightF = (float) (41.66667F);
			this.ReportFooter.Name = "ReportFooter";
			//
			//XrLabel8
			//
			this.XrLabel8.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F));
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (12.5F));
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (630.0F), (float) (24.04167F));
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "*** Nothing Follows ***";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//Lname
			//
			this.Lname.Description = "Last Name";
			this.Lname.Name = "Lname";
			//
			//Fname
			//
			this.Fname.Description = "First Name";
			this.Fname.Name = "Fname";
			//
			//Customer
			//
			this.Customer.Expression = "[lastname] + \',\' + [firstname]+\' \' + [middlename]";
			this.Customer.Name = "Customer";
			//
			//GroupHeader1
			//
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel12, this.XrLabel11, this.XrLabel10, this.XrLabel3, this.XrLabel9});
			this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("CustID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.GroupHeader1.HeightF = (float) (55.20834F);
			this.GroupHeader1.Name = "GroupHeader1";
			//
			//XrLabel12
			//
			this.XrLabel12.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat((float) (518.1249F), (float) (32.99999F));
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel12.SizeF = new System.Drawing.SizeF((float) (121.8751F), (float) (22.20834F));
			this.XrLabel12.StylePriority.UseFont = false;
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.Text = "Current Balance";
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel11
			//
			this.XrLabel11.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat((float) (242.9167F), (float) (32.99999F));
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel11.SizeF = new System.Drawing.SizeF((float) (123.3333F), (float) (22.20834F));
			this.XrLabel11.StylePriority.UseFont = false;
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			this.XrLabel11.Text = "Previous Balance";
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel10
			//
			this.XrLabel10.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (418.1248F), (float) (32.99999F));
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (22.20834F));
			this.XrLabel10.StylePriority.UseFont = false;
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "Amount Paid";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel3
			//
			this.XrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customer")});
			this.XrLabel3.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (323.9583F), (float) (23.0F));
			this.XrLabel3.StylePriority.UseFont = false;
			this.XrLabel3.Text = "XrLabel3";
			//
			//XrLabel9
			//
			this.XrLabel9.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (69.37501F), (float) (32.99999F));
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (89.58337F), (float) (22.20834F));
			this.XrLabel9.StylePriority.UseFont = false;
			this.XrLabel9.StylePriority.UseTextAlignment = false;
			this.XrLabel9.Text = "Date Paid";
			this.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//xrCustPay
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.ReportHeader, this.ReportFooter, this.GroupHeader1});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {this.Customer});
			this.DataAdapter = this.VwCustPayTableAdapter;
			this.DataMember = "vwCustPay";
			this.DataSource = this.DsCustPayRep1;
			this.FilterString = "StartsWith([lastname], ?Lname) And StartsWith([firstname], ?Fname)";
			this.Margins = new System.Drawing.Printing.Margins(100, 100, 21, 17);
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.Lname, this.Fname});
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "13.2";
			((System.ComponentModel.ISupportInitialize) this.DsCustPayRep1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRPageInfo XrPageInfo1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DoorsPOS.WinApp.dsCustPayRep DsCustPayRep1;
		internal DoorsPOS.WinApp.dsCustPayRepTableAdapters.vwCustPayTableAdapter VwCustPayTableAdapter;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.Parameters.Parameter Lname;
		internal DevExpress.XtraReports.Parameters.Parameter Fname;
		internal DevExpress.XtraReports.UI.CalculatedField Customer;
		internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
	}
	
}
