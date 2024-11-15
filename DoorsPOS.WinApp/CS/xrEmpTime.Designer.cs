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
	partial class xrEmpTime : DevExpress.XtraReports.UI.XtraReport
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
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.DsLoginOut1 = new DoorsPOS.WinApp.dsLoginOut();
			this.VwEmpLoginOutTableAdapter = new DoorsPOS.WinApp.dsLoginOutTableAdapters.vwEmpLoginOutTableAdapter();
			this.Min1 = new DevExpress.XtraReports.UI.CalculatedField();
			this.Min2 = new DevExpress.XtraReports.UI.CalculatedField();
			this.NoHrs = new DevExpress.XtraReports.UI.CalculatedField();
			this.NoMin = new DevExpress.XtraReports.UI.CalculatedField();
			this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.FromDate = new DevExpress.XtraReports.Parameters.Parameter();
			this.ToDate = new DevExpress.XtraReports.Parameters.Parameter();
			this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.XrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.convrttoHr = new DevExpress.XtraReports.UI.CalculatedField();
			this.cnvrttoMin = new DevExpress.XtraReports.UI.CalculatedField();
			this.TotalHrs = new DevExpress.XtraReports.UI.CalculatedField();
			this.XrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLine2 = new DevExpress.XtraReports.UI.XRLine();
			((System.ComponentModel.ISupportInitialize) this.DsLoginOut1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel2, this.XrLabel3, this.XrLabel4, this.XrLabel5, this.XrLabel14, this.XrLabel16});
			this.Detail.HeightF = (float) (23.0F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel2
			//
			this.XrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwEmpLoginOut.empin", "{0:hh:mm tt}")});
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (0.0F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel2.Text = "XrLabel2";
			//
			//XrLabel3
			//
			this.XrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwEmpLoginOut.empbreak", "{0:hh:mm tt}")});
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (141.6667F), (float) (0.0F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (83.33334F), (float) (23.0F));
			this.XrLabel3.Text = "XrLabel3";
			//
			//XrLabel4
			//
			this.XrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwEmpLoginOut.empbreakin", "{0:hh:mm tt}")});
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (255.2083F), (float) (0.0F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel4.Text = "XrLabel4";
			//
			//XrLabel5
			//
			this.XrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwEmpLoginOut.empout", "{0:hh:mm tt}")});
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (394.7917F), (float) (0.0F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "XrLabel5";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel14
			//
			this.XrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwEmpLoginOut.NoHrs", "{0:#,#}")});
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat((float) (540.625F), (float) (0.0F));
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel14.SizeF = new System.Drawing.SizeF((float) (65.62488F), (float) (23.0F));
			this.XrLabel14.StylePriority.UseTextAlignment = false;
			this.XrLabel14.Text = "XrLabel14";
			this.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel16
			//
			this.XrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwEmpLoginOut.NoMin")});
			this.XrLabel16.LocationFloat = new DevExpress.Utils.PointFloat((float) (623.9581F), (float) (0.0F));
			this.XrLabel16.Name = "XrLabel16";
			this.XrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel16.SizeF = new System.Drawing.SizeF((float) (63.54169F), (float) (23.0F));
			this.XrLabel16.StylePriority.UseTextAlignment = false;
			this.XrLabel16.Text = "XrLabel16";
			this.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//TopMargin
			//
			this.TopMargin.HeightF = (float) (18.0F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = (float) (21.875F);
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (10.00001F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (756.0F), (float) (27.08333F));
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.Text = "No of Hours and Minutes Worked per Employee";
			//
			//XrLabel15
			//
			this.XrLabel15.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat((float) (538.5416F), (float) (112.0835F));
			this.XrLabel15.Name = "XrLabel15";
			this.XrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel15.SizeF = new System.Drawing.SizeF((float) (67.70837F), (float) (27.08333F));
			this.XrLabel15.StylePriority.UseFont = false;
			this.XrLabel15.StylePriority.UseTextAlignment = false;
			this.XrLabel15.Text = "No of Hrs";
			this.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel13
			//
			this.XrLabel13.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat((float) (606.25F), (float) (112.0834F));
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel13.SizeF = new System.Drawing.SizeF((float) (81.24988F), (float) (27.08333F));
			this.XrLabel13.StylePriority.UseFont = false;
			this.XrLabel13.StylePriority.UseTextAlignment = false;
			this.XrLabel13.Text = "No. of  Min";
			this.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel12
			//
			this.XrLabel12.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat((float) (394.7916F), (float) (112.0833F));
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel12.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (27.08333F));
			this.XrLabel12.StylePriority.UseFont = false;
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.Text = "Time Out";
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel8
			//
			this.XrLabel8.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat((float) (255.2083F), (float) (112.0833F));
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel8.SizeF = new System.Drawing.SizeF((float) (139.5833F), (float) (27.08333F));
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "Time In After Break ";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel7
			//
			this.XrLabel7.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat((float) (141.6666F), (float) (112.0833F));
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel7.SizeF = new System.Drawing.SizeF((float) (83.33334F), (float) (27.08333F));
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.Text = "Break Time";
			//
			//XrLabel6
			//
			this.XrLabel6.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (9.999911F), (float) (112.0833F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (27.08333F));
			this.XrLabel6.StylePriority.UseFont = false;
			this.XrLabel6.Text = "Log-In Time";
			//
			//XrPageInfo1
			//
			this.XrPageInfo1.Font = new System.Drawing.Font("Times New Roman", (float) (10.0F), System.Drawing.FontStyle.Bold);
			this.XrPageInfo1.Format = "{0:MM/dd/yyyy}";
			this.XrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (37.08334F));
			this.XrPageInfo1.Name = "XrPageInfo1";
			this.XrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.XrPageInfo1.SizeF = new System.Drawing.SizeF((float) (191.6667F), (float) (23.0F));
			this.XrPageInfo1.StylePriority.UseFont = false;
			//
			//DsLoginOut1
			//
			this.DsLoginOut1.DataSetName = "dsLoginOut";
			this.DsLoginOut1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VwEmpLoginOutTableAdapter
			//
			this.VwEmpLoginOutTableAdapter.ClearBeforeFill = true;
			//
			//Min1
			//
			this.Min1.DataMember = "vwEmpLoginOut";
			this.Min1.Expression = "DateDiffMinute([empin],[empbreak] )";
			this.Min1.Name = "Min1";
			//
			//Min2
			//
			this.Min2.DataMember = "vwEmpLoginOut";
			this.Min2.Expression = "DateDiffMinute([empbreakin],[empout])";
			this.Min2.Name = "Min2";
			//
			//NoHrs
			//
			this.NoHrs.DataMember = "vwEmpLoginOut";
			this.NoHrs.Expression = "([Min1] + [Min2])/60";
			this.NoHrs.Name = "NoHrs";
			//
			//NoMin
			//
			this.NoMin.DataMember = "vwEmpLoginOut";
			this.NoMin.Expression = "([Min1] + [Min2]) % 60";
			this.NoMin.Name = "NoMin";
			//
			//GroupHeader1
			//
			this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel9, this.XrLabel1, this.XrPageInfo1, this.XrLabel6, this.XrLabel7, this.XrLabel8, this.XrLabel12, this.XrLabel13, this.XrLabel15});
			this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("waiter", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.GroupHeader1.HeightF = (float) (139.1668F);
			this.GroupHeader1.Name = "GroupHeader1";
			this.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand;
			//
			//XrLabel9
			//
			this.XrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwEmpLoginOut.waiter")});
			this.XrLabel9.Font = new System.Drawing.Font("Times New Roman", (float) (14.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat((float) (10.00001F), (float) (60.08332F));
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel9.SizeF = new System.Drawing.SizeF((float) (345.2084F), (float) (23.0F));
			this.XrLabel9.StylePriority.UseFont = false;
			this.XrLabel9.Text = "XrLabel9";
			//
			//FromDate
			//
			this.FromDate.Description = "FromDate";
			this.FromDate.Name = "FromDate";
			this.FromDate.Type = typeof(DateTime);
			//
			//ToDate
			//
			this.ToDate.Description = "ToDate";
			this.ToDate.Name = "ToDate";
			this.ToDate.Type = typeof(DateTime);
			//
			//GroupFooter1
			//
			this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLine2, this.XrLine1, this.XrLabel19, this.XrLabel18, this.XrLabel17, this.XrLabel11, this.XrLabel10});
			this.GroupFooter1.HeightF = (float) (41.49999F);
			this.GroupFooter1.Name = "GroupFooter1";
			//
			//XrLabel19
			//
			this.XrLabel19.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel19.LocationFloat = new DevExpress.Utils.PointFloat((float) (319.7916F), (float) (14.41666F));
			this.XrLabel19.Name = "XrLabel19";
			this.XrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel19.SizeF = new System.Drawing.SizeF((float) (175.0F), (float) (27.08333F));
			this.XrLabel19.StylePriority.UseFont = false;
			this.XrLabel19.Text = "Total Hrs and Minutes";
			//
			//XrLabel18
			//
			this.XrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwEmpLoginOut.cnvrttoMin")});
			this.XrLabel18.LocationFloat = new DevExpress.Utils.PointFloat((float) (190.6248F), (float) (18.49998F));
			this.XrLabel18.Name = "XrLabel18";
			this.XrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel18.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel18.Text = "XrLabel18";
			this.XrLabel18.Visible = false;
			//
			//XrLabel17
			//
			this.XrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwEmpLoginOut.TotalHrs")});
			this.XrLabel17.LocationFloat = new DevExpress.Utils.PointFloat((float) (47.91667F), (float) (18.49998F));
			this.XrLabel17.Name = "XrLabel17";
			this.XrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel17.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel17.Text = "XrLabel17";
			this.XrLabel17.Visible = false;
			//
			//XrLabel11
			//
			this.XrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwEmpLoginOut.NoMin")});
			this.XrLabel11.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat((float) (623.9581F), (float) (14.41666F));
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel11.SizeF = new System.Drawing.SizeF((float) (63.54169F), (float) (23.0F));
			this.XrLabel11.StylePriority.UseFont = false;
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.XrLabel11.Summary = XrSummary1;
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel10
			//
			this.XrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwEmpLoginOut.NoHrs")});
			this.XrLabel10.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat((float) (538.5415F), (float) (14.41666F));
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel10.SizeF = new System.Drawing.SizeF((float) (67.70837F), (float) (23.0F));
			this.XrLabel10.StylePriority.UseFont = false;
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.XrLabel10.Summary = XrSummary2;
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//convrttoHr
			//
			this.convrttoHr.DataMember = "vwEmpLoginOut";
			this.convrttoHr.Expression = "[].Sum([NoMin])/60";
			this.convrttoHr.Name = "convrttoHr";
			//
			//cnvrttoMin
			//
			this.cnvrttoMin.DataMember = "vwEmpLoginOut";
			this.cnvrttoMin.Expression = "[].Sum([NoMin]) % 60";
			this.cnvrttoMin.Name = "cnvrttoMin";
			//
			//TotalHrs
			//
			this.TotalHrs.DataMember = "vwEmpLoginOut";
			this.TotalHrs.Expression = "[].Sum([NoHrs])+[convrttoHr]";
			this.TotalHrs.Name = "TotalHrs";
			//
			//XrLine1
			//
			this.XrLine1.LocationFloat = new DevExpress.Utils.PointFloat((float) (538.5415F), (float) (0.0F));
			this.XrLine1.Name = "XrLine1";
			this.XrLine1.SizeF = new System.Drawing.SizeF((float) (67.7085F), (float) (14.41666F));
			//
			//XrLine2
			//
			this.XrLine2.LocationFloat = new DevExpress.Utils.PointFloat((float) (623.9581F), (float) (0.0F));
			this.XrLine2.Name = "XrLine2";
			this.XrLine2.SizeF = new System.Drawing.SizeF((float) (63.54169F), (float) (14.41666F));
			//
			//xrEmpTime
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.GroupHeader1, this.GroupFooter1});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {this.Min1, this.Min2, this.NoHrs, this.NoMin, this.convrttoHr, this.cnvrttoMin, this.TotalHrs});
			this.DataAdapter = this.VwEmpLoginOutTableAdapter;
			this.DataMember = "vwEmpLoginOut";
			this.DataSource = this.DsLoginOut1;
			this.FilterString = "[trandate] Between(?FromDate, ?ToDate)";
			this.Margins = new System.Drawing.Printing.Margins(55, 19, 18, 22);
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.FromDate, this.ToDate});
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "13.2";
			((System.ComponentModel.ISupportInitialize) this.DsLoginOut1).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRPageInfo XrPageInfo1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel13;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel15;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel16;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel14;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DoorsPOS.WinApp.dsLoginOut DsLoginOut1;
		internal DoorsPOS.WinApp.dsLoginOutTableAdapters.vwEmpLoginOutTableAdapter VwEmpLoginOutTableAdapter;
		internal DevExpress.XtraReports.UI.CalculatedField Min1;
		internal DevExpress.XtraReports.UI.CalculatedField Min2;
		internal DevExpress.XtraReports.UI.CalculatedField NoHrs;
		internal DevExpress.XtraReports.UI.CalculatedField NoMin;
		internal DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.Parameters.Parameter FromDate;
		internal DevExpress.XtraReports.Parameters.Parameter ToDate;
		internal DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel18;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel17;
		internal DevExpress.XtraReports.UI.CalculatedField convrttoHr;
		internal DevExpress.XtraReports.UI.CalculatedField cnvrttoMin;
		internal DevExpress.XtraReports.UI.CalculatedField TotalHrs;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel19;
		internal DevExpress.XtraReports.UI.XRLine XrLine2;
		internal DevExpress.XtraReports.UI.XRLine XrLine1;
	}
	
}
