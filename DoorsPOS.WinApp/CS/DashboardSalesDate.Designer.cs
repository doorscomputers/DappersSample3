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
		public partial class DashboardSalesDate
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
				DevExpress.DashboardCommon.Dimension Dimension1 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure1 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension2 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.ChartPane ChartPane1 = new DevExpress.DashboardCommon.ChartPane();
				DevExpress.DashboardCommon.SimpleSeries SimpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
				DevExpress.DashboardCommon.CalculatedField CalculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardSalesDate));
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension3 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension4 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension5 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension6 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn2 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension7 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn3 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension8 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn4 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension9 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn5 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension10 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure3 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension11 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension12 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension13 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension14 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure4 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure5 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension15 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure6 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension16 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension17 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure7 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension18 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension19 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure8 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension20 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension21 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension22 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DataAccess.DataConnection DataConnection1 = new DevExpress.DataAccess.DataConnection();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem5 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem6 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem7 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem8 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter1 = new DevExpress.DashboardCommon.DashboardParameter();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter2 = new DevExpress.DashboardCommon.DashboardParameter();
				this.ChartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.DataSource2 = new DevExpress.DashboardCommon.DataSource();
				this.PivotDashboardItem2 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.GridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
				this.PivotDashboardItem3 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem4 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem5 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem6 = new DevExpress.DashboardCommon.PivotDashboardItem();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.GridDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension12).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension13).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension14).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure5).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension15).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure6).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension16).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension17).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure7).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension18).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem6).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension19).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure8).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension20).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension21).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension22).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//ChartDashboardItem1
				//
				Dimension1.DataMember = "pos_date";
				Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.ChartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension1});
				this.ChartDashboardItem1.AxisX.TitleVisible = false;
				this.ChartDashboardItem1.ComponentName = "ChartDashboardItem1";
				Measure1.DataMember = "det_amnt";
				Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure1.NumericFormat.IncludeGroupSeparator = true;
				Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension2.DataMember = "sInsert_id";
				this.ChartDashboardItem1.DataItemRepository.Clear();
				this.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem2");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem3");
				this.ChartDashboardItem1.DataSource = this.DataSource2;
				this.ChartDashboardItem1.IgnoreMasterFilters = false;
				this.ChartDashboardItem1.Name = "Sales Chart per Month";
				ChartPane1.Name = "Pane 1";
				ChartPane1.PrimaryAxisY.ShowGridLines = true;
				ChartPane1.PrimaryAxisY.Title = "Sales Amount";
				ChartPane1.PrimaryAxisY.TitleVisible = true;
				ChartPane1.SecondaryAxisY.ShowGridLines = false;
				ChartPane1.SecondaryAxisY.TitleVisible = true;
				SimpleSeries1.Name = "Amount";
				SimpleSeries1.AddDataItem("Value", Measure1);
				ChartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries1});
				this.ChartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane1});
				this.ChartDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension2});
				this.ChartDashboardItem1.ShowCaption = true;
				//
				//DataSource2
				//
				CalculatedField1.DataType = DevExpress.DashboardCommon.CalculatedFieldType.DateTime;
				CalculatedField1.Expression = "Parameter" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10));
				CalculatedField1.Name = "Calculated Field 1";
				this.DataSource2.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {CalculatedField1});
				this.DataSource2.ComponentName = "DataSource2";
				this.DataSource2.DataProviderSerializable = resources.GetString("DataSource2.DataProviderSerializable");
				this.DataSource2.Filter = "";
				this.DataSource2.Name = "salesdatedb";
				//
				//PivotDashboardItem2
				//
				this.PivotDashboardItem2.AutoExpandRowGroups = true;
				this.PivotDashboardItem2.ComponentName = "PivotDashboardItem2";
				Measure2.DataMember = "det_amnt";
				Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure2.NumericFormat.IncludeGroupSeparator = true;
				Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension3.DataMember = "pos_date";
				Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				Dimension4.DataMember = "sInsert_id";
				this.PivotDashboardItem2.DataItemRepository.Clear();
				this.PivotDashboardItem2.DataItemRepository.Add(Measure2, "DataItem0");
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension3, "DataItem1");
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension4, "DataItem3");
				this.PivotDashboardItem2.DataSource = this.DataSource2;
				this.PivotDashboardItem2.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem2.IgnoreMasterFilters = false;
				this.PivotDashboardItem2.Name = "Daily Sales per Cashier";
				this.PivotDashboardItem2.NamesRepository.Clear();
				this.PivotDashboardItem2.NamesRepository.Add(Measure2, "Amount");
				this.PivotDashboardItem2.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension4, Dimension3});
				this.PivotDashboardItem2.ShowCaption = true;
				this.PivotDashboardItem2.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure2});
				//
				//GridDashboardItem1
				//
				Dimension5.DataMember = "pos_date";
				Dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				GridDimensionColumn1.Name = "Date Sold";
				GridDimensionColumn1.AddDataItem("Dimension", Dimension5);
				Dimension6.DataMember = "item_desc";
				GridDimensionColumn2.Name = "Items Sold";
				GridDimensionColumn2.AddDataItem("Dimension", Dimension6);
				Dimension7.DataMember = "qty";
				Dimension7.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				GridDimensionColumn3.Name = "Qty Sold";
				GridDimensionColumn3.AddDataItem("Dimension", Dimension7);
				Dimension8.DataMember = "det_amnt";
				Dimension8.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Dimension8.NumericFormat.IncludeGroupSeparator = true;
				Dimension8.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension8.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				GridDimensionColumn4.Name = "Amount";
				GridDimensionColumn4.AddDataItem("Dimension", Dimension8);
				Dimension9.DataMember = "sInsert_id";
				GridDimensionColumn5.Name = "Cashier";
				GridDimensionColumn5.AddDataItem("Dimension", Dimension9);
				this.GridDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {GridDimensionColumn1, GridDimensionColumn2, GridDimensionColumn3, GridDimensionColumn4, GridDimensionColumn5});
				this.GridDashboardItem1.ComponentName = "GridDashboardItem1";
				this.GridDashboardItem1.DataItemRepository.Clear();
				this.GridDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem1");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem2");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem0");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem3");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension9, "DataItem4");
				this.GridDashboardItem1.DataSource = this.DataSource2;
				this.GridDashboardItem1.FilterString = "[DataItem0] Between(?DateFrom, ?DateTo)";
				this.GridDashboardItem1.IgnoreMasterFilters = false;
				this.GridDashboardItem1.Name = "Daily Sales View2";
				this.GridDashboardItem1.ShowCaption = true;
				//
				//PivotDashboardItem3
				//
				this.PivotDashboardItem3.AutoExpandRowGroups = true;
				Dimension10.DataMember = "sInsert_id";
				this.PivotDashboardItem3.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension10});
				this.PivotDashboardItem3.ComponentName = "PivotDashboardItem3";
				Measure3.DataMember = "det_amnt";
				Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure3.NumericFormat.IncludeGroupSeparator = true;
				Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension11.DataMember = "pos_date";
				Dimension11.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				Dimension12.DataMember = "pos_date";
				Dimension12.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.WeekOfMonth;
				this.PivotDashboardItem3.DataItemRepository.Clear();
				this.PivotDashboardItem3.DataItemRepository.Add(Measure3, "DataItem0");
				this.PivotDashboardItem3.DataItemRepository.Add(Dimension11, "DataItem1");
				this.PivotDashboardItem3.DataItemRepository.Add(Dimension12, "DataItem2");
				this.PivotDashboardItem3.DataItemRepository.Add(Dimension10, "DataItem3");
				this.PivotDashboardItem3.DataSource = this.DataSource2;
				this.PivotDashboardItem3.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem3.IgnoreMasterFilters = false;
				this.PivotDashboardItem3.Name = "Weekly Sales";
				this.PivotDashboardItem3.NamesRepository.Clear();
				this.PivotDashboardItem3.NamesRepository.Add(Measure3, "Amount");
				this.PivotDashboardItem3.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension11, Dimension12});
				this.PivotDashboardItem3.ShowCaption = true;
				this.PivotDashboardItem3.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure3});
				//
				//PivotDashboardItem1
				//
				this.PivotDashboardItem1.AutoExpandRowGroups = true;
				Dimension13.DataMember = "pos_date";
				Dimension13.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				Dimension13.SortByMeasureName = "DataItem3";
				this.PivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension13});
				this.PivotDashboardItem1.ComponentName = "PivotDashboardItem1";
				Dimension14.DataMember = "sInsert_id";
				Measure4.DataMember = "det_amnt";
				Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure4.NumericFormat.IncludeGroupSeparator = true;
				Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				this.PivotDashboardItem1.DataItemRepository.Clear();
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension14, "DataItem1");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension13, "DataItem2");
				this.PivotDashboardItem1.DataItemRepository.Add(Measure4, "DataItem3");
				this.PivotDashboardItem1.DataSource = this.DataSource2;
				this.PivotDashboardItem1.FilterString = "[DataItem2] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem1.IgnoreMasterFilters = false;
				this.PivotDashboardItem1.Name = "Monthly Sales";
				Measure5.DataMember = "qty";
				this.PivotDashboardItem1.NamesRepository.Clear();
				this.PivotDashboardItem1.NamesRepository.Add(Measure5, "Qty Sold");
				this.PivotDashboardItem1.NamesRepository.Add(Measure4, "Amount");
				this.PivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension14});
				this.PivotDashboardItem1.ShowCaption = true;
				this.PivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure4});
				//
				//PivotDashboardItem4
				//
				Dimension15.DataMember = "pos_date";
				Dimension15.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.QuarterYear;
				this.PivotDashboardItem4.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension15});
				this.PivotDashboardItem4.ComponentName = "PivotDashboardItem4";
				Measure6.DataMember = "det_amnt";
				Measure6.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure6.NumericFormat.IncludeGroupSeparator = true;
				Measure6.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension16.DataMember = "sInsert_id";
				this.PivotDashboardItem4.DataItemRepository.Clear();
				this.PivotDashboardItem4.DataItemRepository.Add(Measure6, "DataItem0");
				this.PivotDashboardItem4.DataItemRepository.Add(Dimension16, "DataItem1");
				this.PivotDashboardItem4.DataItemRepository.Add(Dimension15, "DataItem2");
				this.PivotDashboardItem4.DataSource = this.DataSource2;
				this.PivotDashboardItem4.FilterString = "[DataItem2] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem4.IgnoreMasterFilters = false;
				this.PivotDashboardItem4.Name = "Quarterly Sales";
				this.PivotDashboardItem4.NamesRepository.Clear();
				this.PivotDashboardItem4.NamesRepository.Add(Measure6, "Amount");
				this.PivotDashboardItem4.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension16});
				this.PivotDashboardItem4.ShowCaption = true;
				this.PivotDashboardItem4.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure6});
				//
				//PivotDashboardItem5
				//
				Dimension17.DataMember = "pos_date";
				this.PivotDashboardItem5.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension17});
				this.PivotDashboardItem5.ComponentName = "PivotDashboardItem5";
				Measure7.DataMember = "det_amnt";
				Measure7.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure7.NumericFormat.IncludeGroupSeparator = true;
				Measure7.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension18.DataMember = "sInsert_id";
				this.PivotDashboardItem5.DataItemRepository.Clear();
				this.PivotDashboardItem5.DataItemRepository.Add(Measure7, "DataItem0");
				this.PivotDashboardItem5.DataItemRepository.Add(Dimension18, "DataItem1");
				this.PivotDashboardItem5.DataItemRepository.Add(Dimension17, "DataItem2");
				this.PivotDashboardItem5.DataSource = this.DataSource2;
				this.PivotDashboardItem5.IgnoreMasterFilters = false;
				this.PivotDashboardItem5.Name = "Annual Sales";
				this.PivotDashboardItem5.NamesRepository.Clear();
				this.PivotDashboardItem5.NamesRepository.Add(Measure7, "Amount");
				this.PivotDashboardItem5.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension18});
				this.PivotDashboardItem5.ShowCaption = true;
				this.PivotDashboardItem5.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure7});
				//
				//PivotDashboardItem6
				//
				this.PivotDashboardItem6.AutoExpandRowGroups = true;
				Dimension19.DataMember = "pos_date";
				Dimension19.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.PivotDashboardItem6.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension19});
				this.PivotDashboardItem6.ComponentName = "PivotDashboardItem6";
				Measure8.DataMember = "det_amnt";
				Measure8.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure8.NumericFormat.IncludeGroupSeparator = true;
				Measure8.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension20.DataMember = "sInsert_id";
				Dimension21.DataMember = "pos_date";
				Dimension21.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				Dimension22.DataMember = "stocks_item_desc";
				this.PivotDashboardItem6.DataItemRepository.Clear();
				this.PivotDashboardItem6.DataItemRepository.Add(Measure8, "DataItem0");
				this.PivotDashboardItem6.DataItemRepository.Add(Dimension20, "DataItem1");
				this.PivotDashboardItem6.DataItemRepository.Add(Dimension21, "DataItem2");
				this.PivotDashboardItem6.DataItemRepository.Add(Dimension22, "DataItem3");
				this.PivotDashboardItem6.DataItemRepository.Add(Dimension19, "DataItem4");
				this.PivotDashboardItem6.DataSource = this.DataSource2;
				this.PivotDashboardItem6.FilterString = "[DataItem2] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem6.IgnoreMasterFilters = false;
				this.PivotDashboardItem6.Name = "Cashier Sales with Items";
				this.PivotDashboardItem6.NamesRepository.Clear();
				this.PivotDashboardItem6.NamesRepository.Add(Measure8, "Amount");
				this.PivotDashboardItem6.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension20, Dimension21, Dimension22});
				this.PivotDashboardItem6.ShowCaption = true;
				this.PivotDashboardItem6.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure8});
				//
				//DashboardSalesDate
				//
				DataConnection1.Name = "DOORSCOMPUTERS\\SQLEXPRESS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.DataSource2});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.ChartDashboardItem1, this.GridDashboardItem1, this.PivotDashboardItem1, this.PivotDashboardItem2, this.PivotDashboardItem3, this.PivotDashboardItem4, this.PivotDashboardItem5, this.PivotDashboardItem6});
				DashboardLayoutItem1.DashboardItem = this.ChartDashboardItem1;
				DashboardLayoutItem1.Weight = 41.628264208909371D;
				DashboardLayoutItem2.DashboardItem = this.PivotDashboardItem2;
				DashboardLayoutItem2.Weight = 27.342549923195083D;
				DashboardLayoutItem3.DashboardItem = this.GridDashboardItem1;
				DashboardLayoutItem3.Weight = 31.029185867895546D;
				DashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutItem2, DashboardLayoutItem3});
				DashboardLayoutGroup2.Weight = 49.664429530201339D;
				DashboardLayoutItem4.DashboardItem = this.PivotDashboardItem3;
				DashboardLayoutItem4.Weight = 28.725038402457756D;
				DashboardLayoutItem5.DashboardItem = this.PivotDashboardItem1;
				DashboardLayoutItem5.Weight = 39.016897081413212D;
				DashboardLayoutItem6.DashboardItem = this.PivotDashboardItem4;
				DashboardLayoutItem6.Weight = 21.198156682027651D;
				DashboardLayoutItem7.DashboardItem = this.PivotDashboardItem5;
				DashboardLayoutItem7.Weight = 11.059907834101383D;
				DashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem4, DashboardLayoutItem5, DashboardLayoutItem6, DashboardLayoutItem7});
				DashboardLayoutGroup3.Weight = 28.187919463087248D;
				DashboardLayoutItem8.DashboardItem = this.PivotDashboardItem6;
				DashboardLayoutItem8.Weight = 22.14765100671141D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutGroup2, DashboardLayoutGroup3, DashboardLayoutItem8});
				DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				this.LayoutRoot = DashboardLayoutGroup1;
				DashboardParameter1.Name = "DateFrom";
				DashboardParameter1.Type = typeof(DateTime);
				DashboardParameter1.Value = new DateTime(2000, 2, 10, 10, 34, 0, 0);
				DashboardParameter2.Name = "DateTo";
				DashboardParameter2.Type = typeof(DateTime);
				DashboardParameter2.Value = new DateTime(2014, 2, 10, 0, 0, 0, 0);
				this.Parameters.AddRange(new DevExpress.DashboardCommon.DashboardParameter[] {DashboardParameter1, DashboardParameter2});
				this.Title.Text = "Sales per Employee";
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource2).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).EndInit();
				((System.ComponentModel.ISupportInitialize) this.GridDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension12).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension13).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension14).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure4).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure5).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension15).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure6).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension16).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem4).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension17).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure7).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension18).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem5).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension19).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure8).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension20).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension21).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension22).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem6).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.DataSource DataSource2;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem1;
			internal DevExpress.DashboardCommon.GridDashboardItem GridDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem2;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem3;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem4;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem5;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem6;
			
#endregion
		}
	}
}
