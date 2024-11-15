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
	partial class CustBal : DevExpress.XtraReports.UI.XtraReport
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
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.XrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.XrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.XrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.DsAcntReceivable1 = new DoorsPOS.WinApp.dsAcntReceivable();
			this.VwAcntReceivableTableAdapter = new DoorsPOS.WinApp.dsAcntReceivableTableAdapters.vwAcntReceivableTableAdapter();
			this.XrTable2 = new DevExpress.XtraReports.UI.XRTable();
			this.XrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
			this.XrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			((System.ComponentModel.ISupportInitialize) this.XrTable1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsAcntReceivable1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.XrTable2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel3, this.XrLabel2, this.XrLabel1, this.XrTable1});
			this.Detail.HeightF = (float) (25.00001F);
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("lastname", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), new DevExpress.XtraReports.UI.GroupField("firstname", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), new DevExpress.XtraReports.UI.GroupField("middlename", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel3
			//
			this.XrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwAcntReceivable.Balance", "{0:n2}")});
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat((float) (529.7917F), (float) (0.0F));
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel3.SizeF = new System.Drawing.SizeF((float) (110.2083F), (float) (23.0F));
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "XrLabel3";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel2
			//
			this.XrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwAcntReceivable.contact_no")});
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat((float) (448.5417F), (float) (2.000014F));
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel2.SizeF = new System.Drawing.SizeF((float) (81.25003F), (float) (23.0F));
			this.XrLabel2.Text = "XrLabel2";
			//
			//XrLabel1
			//
			this.XrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwAcntReceivable.address1")});
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat((float) (348.5417F), (float) (0.0F));
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel1.SizeF = new System.Drawing.SizeF((float) (100.0F), (float) (23.0F));
			this.XrLabel1.Text = "XrLabel1";
			//
			//XrTable1
			//
			this.XrTable1.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (0.0F));
			this.XrTable1.Name = "XrTable1";
			this.XrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {this.XrTableRow1});
			this.XrTable1.SizeF = new System.Drawing.SizeF((float) (348.5417F), (float) (25.0F));
			//
			//XrTableRow1
			//
			this.XrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {this.XrTableCell1, this.XrTableCell2, this.XrTableCell3});
			this.XrTableRow1.Name = "XrTableRow1";
			this.XrTableRow1.Weight = 1.0D;
			//
			//XrTableCell1
			//
			this.XrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwAcntReceivable.lastname")});
			this.XrTableCell1.Name = "XrTableCell1";
			this.XrTableCell1.Text = "XrTableCell1";
			this.XrTableCell1.Weight = 0.9546219102875525D;
			//
			//XrTableCell2
			//
			this.XrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwAcntReceivable.firstname")});
			this.XrTableCell2.Name = "XrTableCell2";
			this.XrTableCell2.Text = "XrTableCell2";
			this.XrTableCell2.Weight = 0.83193299878545168D;
			//
			//XrTableCell3
			//
			this.XrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwAcntReceivable.middlename")});
			this.XrTableCell3.Name = "XrTableCell3";
			this.XrTableCell3.Text = "XrTableCell3";
			this.XrTableCell3.Weight = 1.0252097762933297D;
			//
			//TopMargin
			//
			this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrPageInfo1, this.XrLabel4});
			this.TopMargin.HeightF = (float) (67.08333F);
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrPageInfo1
			//
			this.XrPageInfo1.Format = "{0:M/d/yy h:mm tt}";
			this.XrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (44.08332F));
			this.XrPageInfo1.Name = "XrPageInfo1";
			this.XrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.XrPageInfo1.SizeF = new System.Drawing.SizeF((float) (173.9583F), (float) (23.0F));
			//
			//XrLabel4
			//
			this.XrLabel4.Font = new System.Drawing.Font("Times New Roman", (float) (14.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (0.0F));
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel4.SizeF = new System.Drawing.SizeF((float) (640.0F), (float) (22.29167F));
			this.XrLabel4.StylePriority.UseFont = false;
			this.XrLabel4.StylePriority.UseTextAlignment = false;
			this.XrLabel4.Text = "List of Customers with Balance";
			this.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//BottomMargin
			//
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, (float) (100.0F));
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//DsAcntReceivable1
			//
			this.DsAcntReceivable1.DataSetName = "dsAcntReceivable";
			this.DsAcntReceivable1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VwAcntReceivableTableAdapter
			//
			this.VwAcntReceivableTableAdapter.ClearBeforeFill = true;
			//
			//XrTable2
			//
			this.XrTable2.LocationFloat = new DevExpress.Utils.PointFloat((float) (0.0F), (float) (0.0F));
			this.XrTable2.Name = "XrTable2";
			this.XrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {this.XrTableRow2});
			this.XrTable2.SizeF = new System.Drawing.SizeF((float) (639.9999F), (float) (25.0F));
			//
			//XrTableRow2
			//
			this.XrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {this.XrTableCell4, this.XrTableCell5, this.XrTableCell6, this.XrTableCell7, this.XrTableCell8, this.XrTableCell9});
			this.XrTableRow2.Name = "XrTableRow2";
			this.XrTableRow2.Weight = 1.0D;
			//
			//XrTableCell4
			//
			this.XrTableCell4.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrTableCell4.Name = "XrTableCell4";
			this.XrTableCell4.StylePriority.UseFont = false;
			this.XrTableCell4.Text = "Last Name";
			this.XrTableCell4.Weight = 1.1833334350585938D;
			//
			//XrTableCell5
			//
			this.XrTableCell5.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrTableCell5.Name = "XrTableCell5";
			this.XrTableCell5.StylePriority.UseFont = false;
			this.XrTableCell5.Text = "First Name";
			this.XrTableCell5.Weight = 1.0312503051757811D;
			//
			//XrTableCell6
			//
			this.XrTableCell6.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrTableCell6.Name = "XrTableCell6";
			this.XrTableCell6.StylePriority.UseFont = false;
			this.XrTableCell6.Text = "Middle Name";
			this.XrTableCell6.Weight = 1.27083251953125D;
			//
			//XrTableCell7
			//
			this.XrTableCell7.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrTableCell7.Name = "XrTableCell7";
			this.XrTableCell7.StylePriority.UseFont = false;
			this.XrTableCell7.Text = "Address";
			this.XrTableCell7.Weight = 1.0000009155273437D;
			//
			//XrTableCell8
			//
			this.XrTableCell8.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrTableCell8.Name = "XrTableCell8";
			this.XrTableCell8.StylePriority.UseFont = false;
			this.XrTableCell8.Text = "Contact No." + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(9));
			this.XrTableCell8.Weight = 0.81249982644339191D;
			//
			//XrTableCell9
			//
			this.XrTableCell9.Font = new System.Drawing.Font("Times New Roman", (float) (9.75F), System.Drawing.FontStyle.Bold);
			this.XrTableCell9.Name = "XrTableCell9";
			this.XrTableCell9.StylePriority.UseFont = false;
			this.XrTableCell9.StylePriority.UseTextAlignment = false;
			this.XrTableCell9.Text = "Balance";
			this.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.XrTableCell9.Weight = 1.10208205757391D;
			//
			//PageHeader
			//
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrTable2});
			this.PageHeader.HeightF = (float) (25.0F);
			this.PageHeader.Name = "PageHeader";
			//
			//XrLabel5
			//
			this.XrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "vwAcntReceivable.Balance")});
			this.XrLabel5.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F));
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat((float) (510.4167F), (float) (10.00001F));
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel5.SizeF = new System.Drawing.SizeF((float) (129.5833F), (float) (22.29167F));
			this.XrLabel5.StylePriority.UseFont = false;
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Page;
			this.XrLabel5.Summary = XrSummary1;
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLabel6
			//
			this.XrLabel6.Font = new System.Drawing.Font("Times New Roman", (float) (14.0F), System.Drawing.FontStyle.Bold);
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat((float) (94.79173F), (float) (10.00001F));
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, (float) (100.0F));
			this.XrLabel6.SizeF = new System.Drawing.SizeF((float) (415.6249F), (float) (22.29167F));
			this.XrLabel6.StylePriority.UseFont = false;
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "TOTAL";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			//
			//XrLine1
			//
			this.XrLine1.LocationFloat = new DevExpress.Utils.PointFloat((float) (510.4167F), (float) (0.0F));
			this.XrLine1.Name = "XrLine1";
			this.XrLine1.SizeF = new System.Drawing.SizeF((float) (139.5833F), (float) (4.166667F));
			//
			//ReportFooter
			//
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel5, this.XrLabel6, this.XrLine1});
			this.ReportFooter.Name = "ReportFooter";
			//
			//CustBal
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.PageHeader, this.ReportFooter});
			this.DataAdapter = this.VwAcntReceivableTableAdapter;
			this.DataMember = "vwAcntReceivable";
			this.DataSource = this.DsAcntReceivable1;
			this.Margins = new System.Drawing.Printing.Margins(100, 100, 67, 100);
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.Version = "13.2";
			((System.ComponentModel.ISupportInitialize) this.XrTable1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsAcntReceivable1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.XrTable2).EndInit();
			((System.ComponentModel.ISupportInitialize) this).EndInit();
			
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRTable XrTable1;
		internal DevExpress.XtraReports.UI.XRTableRow XrTableRow1;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell1;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell2;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell3;
		internal DevExpress.XtraReports.UI.XRPageInfo XrPageInfo1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLine XrLine1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DoorsPOS.WinApp.dsAcntReceivable DsAcntReceivable1;
		internal DoorsPOS.WinApp.dsAcntReceivableTableAdapters.vwAcntReceivableTableAdapter VwAcntReceivableTableAdapter;
		internal DevExpress.XtraReports.UI.XRTable XrTable2;
		internal DevExpress.XtraReports.UI.XRTableRow XrTableRow2;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell4;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell5;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell6;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell7;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell8;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell9;
		internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
	}
	
}
