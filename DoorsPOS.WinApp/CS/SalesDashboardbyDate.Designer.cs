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
	namespace Win_Dashboards
	{
		public partial class SalesDashboardbyDate
		{
			/// <summary>
			/// Required designer variable.
			/// </summary>
			private System.ComponentModel.IContainer components = null;
			
			/// <summary>
			/// Clean up any resources being used.
			/// </summary>
			/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
			protected override void Dispose(bool disposing)
			{
				if (disposing && (components != null))
				{
					components.Dispose();
				}
				base.Dispose(disposing);
			}
			
#region Component Designer generated code
			
			/// <summary>
			/// Required method for Designer support - do not modify
			/// the contents of this method with the code editor.
			/// </summary>
			private void InitializeComponent()
			{
				DevExpress.DashboardCommon.Measure Measure1 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension1 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure3 = new DevExpress.DashboardCommon.Measure();
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDashboardbyDate));
				DevExpress.DashboardCommon.Measure Measure4 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension2 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure5 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure6 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure7 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension3 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension4 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure8 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure9 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure10 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension5 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension6 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure11 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension7 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Measure Measure12 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.GridMeasureColumn GridMeasureColumn1 = new DevExpress.DashboardCommon.GridMeasureColumn();
				DevExpress.DashboardCommon.Measure Measure13 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension8 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure14 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure15 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure16 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension9 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure17 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure18 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension10 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure19 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure20 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure21 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension11 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure22 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure23 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DataAccess.DataConnection DataConnection1 = new DevExpress.DataAccess.DataConnection();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem5 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem6 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem7 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem8 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem9 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter1 = new DevExpress.DashboardCommon.DashboardParameter();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter2 = new DevExpress.DashboardCommon.DashboardParameter();
				this.PivotDashboardItem4 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.DataSource3 = new DevExpress.DashboardCommon.DataSource();
				this.pivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem5 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem6 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.gridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
				this.pivotDashboardItem2 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.pivotDashboardItem3 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem8 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem7 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.DataSource2 = new DevExpress.DashboardCommon.DataSource();
				this.dataSource1 = new DevExpress.DashboardCommon.DataSource();
				this.DataSource4 = new DevExpress.DashboardCommon.DataSource();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure3).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource3).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure6).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure7).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure8).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure9).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem6).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure10).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure11).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.gridDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure12).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure13).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure14).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure15).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure16).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure17).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure18).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem8).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure19).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure20).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem7).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure21).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure22).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure23).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.dataSource1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource4).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//PivotDashboardItem4
				//
				this.PivotDashboardItem4.ComponentName = "PivotDashboardItem4";
				Measure1.DataMember = "totsales";
				Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure1.NumericFormat.IncludeGroupSeparator = true;
				Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension1.DataMember = "pos_date";
				Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				this.PivotDashboardItem4.DataItemRepository.Clear();
				this.PivotDashboardItem4.DataItemRepository.Add(Measure1, "DataItem0");
				this.PivotDashboardItem4.DataItemRepository.Add(Dimension1, "DataItem1");
				this.PivotDashboardItem4.DataSource = this.DataSource3;
				this.PivotDashboardItem4.IgnoreMasterFilters = false;
				this.PivotDashboardItem4.Name = "Daily Sales";
				Measure2.DataMember = "det_amnt";
				Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure2.NumericFormat.IncludeGroupSeparator = true;
				Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Measure3.DataMember = "totsales";
				this.PivotDashboardItem4.NamesRepository.Clear();
				this.PivotDashboardItem4.NamesRepository.Add(Measure2, "Amount");
				this.PivotDashboardItem4.NamesRepository.Add(Measure3, "Total Sales");
				this.PivotDashboardItem4.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension1});
				this.PivotDashboardItem4.ShowCaption = true;
				this.PivotDashboardItem4.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure1});
				//
				//DataSource3
				//
				this.DataSource3.ComponentName = "DataSource3";
				this.DataSource3.DataProviderSerializable = resources.GetString("DataSource3.DataProviderSerializable");
				this.DataSource3.Filter = "[pos_hdr.mowd] = \'CASH\'";
				this.DataSource3.Name = "poshdr";
				//
				//pivotDashboardItem1
				//
				this.pivotDashboardItem1.ComponentName = "pivotDashboardItem1";
				Measure4.DataMember = "totsales";
				Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure4.NumericFormat.IncludeGroupSeparator = true;
				Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension2.DataMember = "pos_date";
				Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				Dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.pivotDashboardItem1.DataItemRepository.Clear();
				this.pivotDashboardItem1.DataItemRepository.Add(Measure4, "DataItem1");
				this.pivotDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem0");
				this.pivotDashboardItem1.DataSource = this.DataSource3;
				this.pivotDashboardItem1.FilterString = "[DataItem0] Between(?DateFrom, ?DateTo)";
				this.pivotDashboardItem1.IgnoreMasterFilters = false;
				this.pivotDashboardItem1.Name = "Daily Sales (Highest to Lowest)";
				Measure5.DataMember = "det_amnt";
				Measure5.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
				Measure5.NumericFormat.IncludeGroupSeparator = true;
				Measure5.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Measure6.DataMember = "totsales";
				this.pivotDashboardItem1.NamesRepository.Clear();
				this.pivotDashboardItem1.NamesRepository.Add(Measure5, "Sales");
				this.pivotDashboardItem1.NamesRepository.Add(Measure6, "Total Sales");
				this.pivotDashboardItem1.NamesRepository.Add(Measure4, "Total Sales");
				this.pivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension2});
				this.pivotDashboardItem1.ShowCaption = true;
				this.pivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure4});
				//
				//PivotDashboardItem5
				//
				this.PivotDashboardItem5.AutoExpandRowGroups = true;
				this.PivotDashboardItem5.ComponentName = "PivotDashboardItem5";
				Measure7.DataMember = "totsales";
				Measure7.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure7.NumericFormat.IncludeGroupSeparator = true;
				Measure7.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension3.DataMember = "pos_date";
				Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.WeekOfMonth;
				Dimension4.DataMember = "pos_date";
				Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month;
				this.PivotDashboardItem5.DataItemRepository.Clear();
				this.PivotDashboardItem5.DataItemRepository.Add(Measure7, "DataItem2");
				this.PivotDashboardItem5.DataItemRepository.Add(Dimension3, "DataItem1");
				this.PivotDashboardItem5.DataItemRepository.Add(Dimension4, "DataItem0");
				this.PivotDashboardItem5.DataSource = this.DataSource3;
				this.PivotDashboardItem5.IgnoreMasterFilters = false;
				this.PivotDashboardItem5.Name = "Weekly Sales";
				Measure8.DataMember = "det_amnt";
				Measure8.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure8.NumericFormat.IncludeGroupSeparator = true;
				Measure8.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Measure9.DataMember = "totsales";
				this.PivotDashboardItem5.NamesRepository.Clear();
				this.PivotDashboardItem5.NamesRepository.Add(Measure8, "Amount");
				this.PivotDashboardItem5.NamesRepository.Add(Measure9, "Total Sales");
				this.PivotDashboardItem5.NamesRepository.Add(Measure7, "Total Sales");
				this.PivotDashboardItem5.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension4, Dimension3});
				this.PivotDashboardItem5.ShowCaption = true;
				this.PivotDashboardItem5.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure7});
				//
				//PivotDashboardItem6
				//
				this.PivotDashboardItem6.AutoExpandRowGroups = true;
				this.PivotDashboardItem6.ComponentName = "PivotDashboardItem6";
				Measure10.DataMember = "totsales";
				Measure10.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure10.NumericFormat.IncludeGroupSeparator = true;
				Measure10.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension5.DataMember = "pos_date";
				Dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.WeekOfMonth;
				Dimension5.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				Dimension6.DataMember = "pos_date";
				Dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				Dimension6.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.PivotDashboardItem6.DataItemRepository.Clear();
				this.PivotDashboardItem6.DataItemRepository.Add(Measure10, "DataItem2");
				this.PivotDashboardItem6.DataItemRepository.Add(Dimension5, "DataItem1");
				this.PivotDashboardItem6.DataItemRepository.Add(Dimension6, "DataItem0");
				this.PivotDashboardItem6.DataSource = this.DataSource3;
				this.PivotDashboardItem6.IgnoreMasterFilters = false;
				this.PivotDashboardItem6.Name = "Weekly Sales (Highest to Lowest)";
				Measure11.DataMember = "totsales";
				this.PivotDashboardItem6.NamesRepository.Clear();
				this.PivotDashboardItem6.NamesRepository.Add(Measure11, "Total Sales");
				this.PivotDashboardItem6.NamesRepository.Add(Measure10, "Total Sales");
				this.PivotDashboardItem6.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension6, Dimension5});
				this.PivotDashboardItem6.ShowCaption = true;
				this.PivotDashboardItem6.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure10});
				//
				//gridDashboardItem1
				//
				Dimension7.DataMember = "pos_date";
				Dimension7.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				GridDimensionColumn1.Name = "Date";
				GridDimensionColumn1.AddDataItem("Dimension", Dimension7);
				Measure12.DataMember = "totsales";
				Measure12.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure12.NumericFormat.IncludeGroupSeparator = true;
				Measure12.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				GridMeasureColumn1.Name = "Total Sales";
				GridMeasureColumn1.AddDataItem("Measure", Measure12);
				this.gridDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {GridDimensionColumn1, GridMeasureColumn1});
				this.gridDashboardItem1.ComponentName = "gridDashboardItem1";
				this.gridDashboardItem1.DataItemRepository.Clear();
				this.gridDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem0");
				this.gridDashboardItem1.DataItemRepository.Add(Measure12, "DataItem1");
				this.gridDashboardItem1.DataSource = this.DataSource3;
				this.gridDashboardItem1.FilterString = "[DataItem0] Between(?DateFrom, ?DateTo)";
				this.gridDashboardItem1.IgnoreMasterFilters = false;
				this.gridDashboardItem1.Name = "Sales Grid View per Month";
				this.gridDashboardItem1.ShowCaption = true;
				//
				//pivotDashboardItem2
				//
				this.pivotDashboardItem2.ComponentName = "pivotDashboardItem2";
				Measure13.DataMember = "totsales";
				Measure13.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure13.NumericFormat.IncludeGroupSeparator = true;
				Measure13.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension8.DataMember = "pos_date";
				Dimension8.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.pivotDashboardItem2.DataItemRepository.Clear();
				this.pivotDashboardItem2.DataItemRepository.Add(Measure13, "DataItem0");
				this.pivotDashboardItem2.DataItemRepository.Add(Dimension8, "DataItem1");
				this.pivotDashboardItem2.DataSource = this.DataSource3;
				this.pivotDashboardItem2.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)";
				this.pivotDashboardItem2.IgnoreMasterFilters = false;
				this.pivotDashboardItem2.Name = "Sales Per Month (Highest to Lowest)";
				Measure14.DataMember = "det_amnt";
				Measure14.NumericFormat.CurrencyCultureName = "en-PH";
				Measure14.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
				Measure14.NumericFormat.IncludeGroupSeparator = true;
				Measure14.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Measure15.DataMember = "totsales";
				this.pivotDashboardItem2.NamesRepository.Clear();
				this.pivotDashboardItem2.NamesRepository.Add(Measure14, "Sales");
				this.pivotDashboardItem2.NamesRepository.Add(Measure15, "Total Sales");
				this.pivotDashboardItem2.NamesRepository.Add(Measure13, "Total Sales");
				this.pivotDashboardItem2.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension8});
				this.pivotDashboardItem2.ShowCaption = true;
				this.pivotDashboardItem2.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure13});
				//
				//pivotDashboardItem3
				//
				this.pivotDashboardItem3.ComponentName = "pivotDashboardItem3";
				Measure16.DataMember = "totsales";
				Measure16.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure16.NumericFormat.IncludeGroupSeparator = true;
				Measure16.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension9.DataMember = "pos_date";
				Dimension9.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.QuarterYear;
				this.pivotDashboardItem3.DataItemRepository.Clear();
				this.pivotDashboardItem3.DataItemRepository.Add(Measure16, "DataItem0");
				this.pivotDashboardItem3.DataItemRepository.Add(Dimension9, "DataItem1");
				this.pivotDashboardItem3.DataSource = this.DataSource3;
				this.pivotDashboardItem3.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)";
				this.pivotDashboardItem3.IgnoreMasterFilters = false;
				this.pivotDashboardItem3.Name = "Sales per Qtr";
				Measure17.DataMember = "det_amnt";
				Measure17.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
				Measure17.NumericFormat.IncludeGroupSeparator = true;
				Measure17.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Measure18.DataMember = "totsales";
				this.pivotDashboardItem3.NamesRepository.Clear();
				this.pivotDashboardItem3.NamesRepository.Add(Measure17, "Sales");
				this.pivotDashboardItem3.NamesRepository.Add(Measure18, "Total Sales");
				this.pivotDashboardItem3.NamesRepository.Add(Measure16, "Total Sales");
				this.pivotDashboardItem3.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension9});
				this.pivotDashboardItem3.ShowCaption = true;
				this.pivotDashboardItem3.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure16});
				//
				//PivotDashboardItem8
				//
				this.PivotDashboardItem8.ComponentName = "PivotDashboardItem8";
				Dimension10.DataMember = "pos_date";
				Dimension10.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.QuarterYear;
				Measure19.DataMember = "totsales";
				Measure19.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure19.NumericFormat.IncludeGroupSeparator = true;
				Measure19.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				this.PivotDashboardItem8.DataItemRepository.Clear();
				this.PivotDashboardItem8.DataItemRepository.Add(Dimension10, "DataItem0");
				this.PivotDashboardItem8.DataItemRepository.Add(Measure19, "DataItem1");
				this.PivotDashboardItem8.DataSource = this.DataSource3;
				this.PivotDashboardItem8.IgnoreMasterFilters = false;
				this.PivotDashboardItem8.Name = "Sales per Qtr (Highest to Lowest)";
				Measure20.DataMember = "det_amnt";
				Measure20.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure20.NumericFormat.IncludeGroupSeparator = true;
				Measure20.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				this.PivotDashboardItem8.NamesRepository.Clear();
				this.PivotDashboardItem8.NamesRepository.Add(Measure20, "Amount");
				this.PivotDashboardItem8.NamesRepository.Add(Measure19, "Total Sales");
				this.PivotDashboardItem8.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension10});
				this.PivotDashboardItem8.ShowCaption = true;
				this.PivotDashboardItem8.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure19});
				//
				//PivotDashboardItem7
				//
				this.PivotDashboardItem7.ComponentName = "PivotDashboardItem7";
				Measure21.DataMember = "totsales";
				Measure21.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure21.NumericFormat.IncludeGroupSeparator = true;
				Measure21.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension11.DataMember = "pos_date";
				this.PivotDashboardItem7.DataItemRepository.Clear();
				this.PivotDashboardItem7.DataItemRepository.Add(Measure21, "DataItem1");
				this.PivotDashboardItem7.DataItemRepository.Add(Dimension11, "DataItem0");
				this.PivotDashboardItem7.DataSource = this.DataSource3;
				this.PivotDashboardItem7.IgnoreMasterFilters = false;
				this.PivotDashboardItem7.Name = "Sales Per Year";
				Measure22.DataMember = "det_amnt";
				Measure22.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure22.NumericFormat.IncludeGroupSeparator = true;
				Measure22.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Measure23.DataMember = "totsales";
				this.PivotDashboardItem7.NamesRepository.Clear();
				this.PivotDashboardItem7.NamesRepository.Add(Measure22, "Amount");
				this.PivotDashboardItem7.NamesRepository.Add(Measure23, "Total Sales");
				this.PivotDashboardItem7.NamesRepository.Add(Measure21, "Total Sales");
				this.PivotDashboardItem7.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension11});
				this.PivotDashboardItem7.ShowCaption = true;
				this.PivotDashboardItem7.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure21});
				//
				//DataSource2
				//
				this.DataSource2.ComponentName = "DataSource2";
				this.DataSource2.DataProviderSerializable = resources.GetString("DataSource2.DataProviderSerializable");
				this.DataSource2.Filter = "";
				this.DataSource2.Name = "dsVwSold";
				//
				//dataSource1
				//
				this.dataSource1.ComponentName = "dataSource1";
				this.dataSource1.DataProviderSerializable = resources.GetString("dataSource1.DataProviderSerializable");
				this.dataSource1.Filter = "";
				this.dataSource1.Name = "Data Source 2";
				//
				//DataSource4
				//
				this.DataSource4.ComponentName = "DataSource4";
				this.DataSource4.DataProviderSerializable = resources.GetString("DataSource4.DataProviderSerializable");
				this.DataSource4.Filter = "[pos_hdr.mowd] = \'CREDIT\'";
				this.DataSource4.Name = "Credits";
				//
				//SalesDashboardbyDate
				//
				DataConnection1.Name = "DOORSCOMPUTERS\\SQLEXPRESS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.dataSource1, this.DataSource2, this.DataSource3, this.DataSource4});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.gridDashboardItem1, this.pivotDashboardItem1, this.pivotDashboardItem2, this.pivotDashboardItem3, this.PivotDashboardItem4, this.PivotDashboardItem5, this.PivotDashboardItem6, this.PivotDashboardItem7, this.PivotDashboardItem8});
				DashboardLayoutItem1.DashboardItem = this.PivotDashboardItem4;
				DashboardLayoutItem1.Weight = 26.315789473684209D;
				DashboardLayoutItem2.DashboardItem = this.pivotDashboardItem1;
				DashboardLayoutItem2.Weight = 25.541795665634673D;
				DashboardLayoutItem3.DashboardItem = this.PivotDashboardItem5;
				DashboardLayoutItem3.Weight = 32.352941176470587D;
				DashboardLayoutItem4.DashboardItem = this.PivotDashboardItem6;
				DashboardLayoutItem4.Weight = 15.789473684210526D;
				DashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutItem2, DashboardLayoutItem3, DashboardLayoutItem4});
				DashboardLayoutGroup2.Weight = 50.0D;
				DashboardLayoutItem5.DashboardItem = this.gridDashboardItem1;
				DashboardLayoutItem5.Weight = 26.315789473684209D;
				DashboardLayoutItem6.DashboardItem = this.pivotDashboardItem2;
				DashboardLayoutItem6.Weight = 25.541795665634673D;
				DashboardLayoutItem7.DashboardItem = this.pivotDashboardItem3;
				DashboardLayoutItem7.Weight = 17.956656346749227D;
				DashboardLayoutItem8.DashboardItem = this.PivotDashboardItem8;
				DashboardLayoutItem8.Weight = 14.551083591331269D;
				DashboardLayoutItem9.DashboardItem = this.PivotDashboardItem7;
				DashboardLayoutItem9.Weight = 15.634674922600619D;
				DashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem5, DashboardLayoutItem6, DashboardLayoutItem7, DashboardLayoutItem8, DashboardLayoutItem9});
				DashboardLayoutGroup3.Weight = 50.0D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutGroup2, DashboardLayoutGroup3});
				DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				this.LayoutRoot = DashboardLayoutGroup1;
				DashboardParameter1.Name = "DateFrom";
				DashboardParameter1.Type = typeof(DateTime);
				DashboardParameter1.Value = new DateTime(2010, 12, 31, 0, 0, 0, 0);
				DashboardParameter2.Name = "DateTo";
				DashboardParameter2.Type = typeof(DateTime);
				DashboardParameter2.Value = new DateTime(2999, 1, 30, 0, 0, 0, 0);
				this.Parameters.AddRange(new DevExpress.DashboardCommon.DashboardParameter[] {DashboardParameter1, DashboardParameter2});
				this.Title.Text = "Sales";
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure3).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem4).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource3).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure4).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure5).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure6).EndInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure7).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure8).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure9).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem5).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure10).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure11).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem6).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure12).EndInit();
				((System.ComponentModel.ISupportInitialize) this.gridDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure13).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure14).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure15).EndInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem2).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure16).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure17).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure18).EndInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure19).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure20).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem8).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure21).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure22).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure23).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem7).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.dataSource1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource4).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.DataSource dataSource1;
			internal DevExpress.DashboardCommon.GridDashboardItem gridDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem2;
			internal DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem3;
			internal DevExpress.DashboardCommon.DataSource DataSource2;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem4;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem5;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem6;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem7;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem8;
			internal DevExpress.DashboardCommon.DataSource DataSource3;
			internal DevExpress.DashboardCommon.DataSource DataSource4;
			
#endregion
		}
	}
}
