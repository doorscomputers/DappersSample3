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
		public partial class ProfitDB
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
				DevExpress.DashboardCommon.CalculatedField CalculatedField2 = new DevExpress.DashboardCommon.CalculatedField();
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfitDB));
				DevExpress.DashboardCommon.Dimension Dimension3 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension4 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.ChartPane ChartPane2 = new DevExpress.DashboardCommon.ChartPane();
				DevExpress.DashboardCommon.SimpleSeries SimpleSeries2 = new DevExpress.DashboardCommon.SimpleSeries();
				DevExpress.DashboardCommon.Dimension Dimension5 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure3 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension6 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.ChartPane ChartPane3 = new DevExpress.DashboardCommon.ChartPane();
				DevExpress.DashboardCommon.SimpleSeries SimpleSeries3 = new DevExpress.DashboardCommon.SimpleSeries();
				DevExpress.DashboardCommon.Dimension Dimension7 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure4 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension8 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure5 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension9 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension10 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension11 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure6 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension12 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension13 = new DevExpress.DashboardCommon.Dimension();
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
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter1 = new DevExpress.DashboardCommon.DashboardParameter();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter2 = new DevExpress.DashboardCommon.DashboardParameter();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter3 = new DevExpress.DashboardCommon.DashboardParameter();
				this.ChartDashboardItem2 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.Profit = new DevExpress.DashboardCommon.DataSource();
				this.ChartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.ChartDashboardItem3 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.PivotDashboardItem2 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem3 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.Profit).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure6).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension12).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension13).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//ChartDashboardItem2
				//
				Dimension1.DataMember = "pos_date";
				Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.ChartDashboardItem2.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension1});
				this.ChartDashboardItem2.AxisX.TitleVisible = false;
				this.ChartDashboardItem2.ComponentName = "ChartDashboardItem2";
				Measure1.DataMember = "Profit";
				Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure1.NumericFormat.IncludeGroupSeparator = true;
				Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension2.DataMember = "pos_date";
				Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.ChartDashboardItem2.DataItemRepository.Clear();
				this.ChartDashboardItem2.DataItemRepository.Add(Measure1, "DataItem0");
				this.ChartDashboardItem2.DataItemRepository.Add(Dimension1, "DataItem1");
				this.ChartDashboardItem2.DataItemRepository.Add(Dimension2, "DataItem2");
				this.ChartDashboardItem2.DataSource = this.Profit;
				this.ChartDashboardItem2.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)";
				this.ChartDashboardItem2.IgnoreMasterFilters = false;
				this.ChartDashboardItem2.Name = "Monthly Profit Chart";
				ChartPane1.Name = "Pane 1";
				ChartPane1.PrimaryAxisY.ShowGridLines = true;
				ChartPane1.PrimaryAxisY.TitleVisible = true;
				ChartPane1.SecondaryAxisY.ShowGridLines = false;
				ChartPane1.SecondaryAxisY.TitleVisible = true;
				SimpleSeries1.Name = "Profit (Sum)";
				SimpleSeries1.AddDataItem("Value", Measure1);
				ChartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries1});
				this.ChartDashboardItem2.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane1});
				this.ChartDashboardItem2.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension2});
				this.ChartDashboardItem2.ShowCaption = true;
				//
				//Profit
				//
				CalculatedField1.DataType = DevExpress.DashboardCommon.CalculatedFieldType.Decimal;
				CalculatedField1.Expression = "[qty] * [cost]";
				CalculatedField1.Name = "CostAmnt";
				CalculatedField2.DataType = DevExpress.DashboardCommon.CalculatedFieldType.Decimal;
				CalculatedField2.Expression = "[det_amnt] - ([cost] * [qty])";
				CalculatedField2.Name = "Profit";
				this.Profit.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {CalculatedField1, CalculatedField2});
				this.Profit.ComponentName = "Profit";
				this.Profit.DataProviderSerializable = resources.GetString("Profit.DataProviderSerializable");
				this.Profit.Name = "Profit";
				//
				//ChartDashboardItem1
				//
				Dimension3.DataMember = "pos_date";
				Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.QuarterYear;
				this.ChartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension3});
				this.ChartDashboardItem1.AxisX.TitleVisible = false;
				this.ChartDashboardItem1.ComponentName = "ChartDashboardItem1";
				Measure2.DataMember = "Profit";
				Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure2.NumericFormat.IncludeGroupSeparator = true;
				Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension4.DataMember = "pos_date";
				Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.ChartDashboardItem1.DataItemRepository.Clear();
				this.ChartDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem1");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem2");
				this.ChartDashboardItem1.DataSource = this.Profit;
				this.ChartDashboardItem1.FilterString = "[DataItem2] Between(?DateFrom, ?DateTo)";
				this.ChartDashboardItem1.IgnoreMasterFilters = false;
				this.ChartDashboardItem1.Name = "Quarterly Profit Chart";
				ChartPane2.Name = "Pane 1";
				ChartPane2.PrimaryAxisY.ShowGridLines = true;
				ChartPane2.PrimaryAxisY.TitleVisible = true;
				ChartPane2.SecondaryAxisY.ShowGridLines = false;
				ChartPane2.SecondaryAxisY.TitleVisible = true;
				SimpleSeries2.Name = "Profit (Sum)";
				SimpleSeries2.AddDataItem("Value", Measure2);
				ChartPane2.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries2});
				this.ChartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane2});
				this.ChartDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension4});
				this.ChartDashboardItem1.ShowCaption = true;
				//
				//ChartDashboardItem3
				//
				Dimension5.DataMember = "pos_date";
				this.ChartDashboardItem3.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension5});
				this.ChartDashboardItem3.AxisX.TitleVisible = false;
				this.ChartDashboardItem3.ComponentName = "ChartDashboardItem3";
				Measure3.DataMember = "Profit";
				Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure3.NumericFormat.IncludeGroupSeparator = true;
				Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension6.DataMember = "pos_date";
				this.ChartDashboardItem3.DataItemRepository.Clear();
				this.ChartDashboardItem3.DataItemRepository.Add(Measure3, "DataItem0");
				this.ChartDashboardItem3.DataItemRepository.Add(Dimension5, "DataItem1");
				this.ChartDashboardItem3.DataItemRepository.Add(Dimension6, "DataItem2");
				this.ChartDashboardItem3.DataSource = this.Profit;
				this.ChartDashboardItem3.FilterString = "[DataItem1] Between(2014, ?YrEnd)";
				this.ChartDashboardItem3.IgnoreMasterFilters = false;
				this.ChartDashboardItem3.Name = "Annual Profit";
				ChartPane3.Name = "Pane 1";
				ChartPane3.PrimaryAxisY.ShowGridLines = true;
				ChartPane3.PrimaryAxisY.TitleVisible = true;
				ChartPane3.SecondaryAxisY.ShowGridLines = false;
				ChartPane3.SecondaryAxisY.TitleVisible = true;
				SimpleSeries3.Name = "Profit (Sum)";
				SimpleSeries3.AddDataItem("Value", Measure3);
				ChartPane3.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries3});
				this.ChartDashboardItem3.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane3});
				this.ChartDashboardItem3.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension6});
				this.ChartDashboardItem3.ShowCaption = true;
				//
				//PivotDashboardItem2
				//
				this.PivotDashboardItem2.AutoExpandRowGroups = true;
				this.PivotDashboardItem2.ComponentName = "PivotDashboardItem2";
				Dimension7.DataMember = "pos_date";
				Dimension7.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				Measure4.DataMember = "Profit";
				Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure4.NumericFormat.IncludeGroupSeparator = true;
				Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension8.DataMember = "catgory";
				Dimension8.SortByMeasureName = "DataItem2";
				Dimension8.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.PivotDashboardItem2.DataItemRepository.Clear();
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension7, "DataItem1");
				this.PivotDashboardItem2.DataItemRepository.Add(Measure4, "DataItem2");
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension8, "DataItem0");
				this.PivotDashboardItem2.DataSource = this.Profit;
				this.PivotDashboardItem2.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem2.IgnoreMasterFilters = false;
				this.PivotDashboardItem2.Name = "Monthly Profit";
				this.PivotDashboardItem2.NamesRepository.Clear();
				this.PivotDashboardItem2.NamesRepository.Add(Measure4, "Profit (Sum)");
				this.PivotDashboardItem2.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension7, Dimension8});
				this.PivotDashboardItem2.ShowCaption = true;
				this.PivotDashboardItem2.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure4});
				//
				//PivotDashboardItem3
				//
				this.PivotDashboardItem3.AutoExpandRowGroups = true;
				this.PivotDashboardItem3.ComponentName = "PivotDashboardItem3";
				Measure5.DataMember = "Profit";
				Measure5.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure5.NumericFormat.IncludeGroupSeparator = true;
				Measure5.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension9.DataMember = "pos_date";
				Dimension9.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				Dimension9.SortByMeasureName = "DataItem0";
				Dimension9.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				Dimension10.DataMember = "catgory";
				Dimension10.SortByMeasureName = "DataItem0";
				Dimension10.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.PivotDashboardItem3.DataItemRepository.Clear();
				this.PivotDashboardItem3.DataItemRepository.Add(Measure5, "DataItem0");
				this.PivotDashboardItem3.DataItemRepository.Add(Dimension9, "DataItem1");
				this.PivotDashboardItem3.DataItemRepository.Add(Dimension10, "DataItem2");
				this.PivotDashboardItem3.DataSource = this.Profit;
				this.PivotDashboardItem3.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem3.IgnoreMasterFilters = false;
				this.PivotDashboardItem3.Name = "Profit (Highest to Lowest)";
				this.PivotDashboardItem3.NamesRepository.Clear();
				this.PivotDashboardItem3.NamesRepository.Add(Measure5, "Profit (Sum)");
				this.PivotDashboardItem3.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension9, Dimension10});
				this.PivotDashboardItem3.ShowCaption = true;
				this.PivotDashboardItem3.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure5});
				//
				//PivotDashboardItem1
				//
				this.PivotDashboardItem1.AutoExpandRowGroups = true;
				Dimension11.DataMember = "pos_date";
				Dimension11.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.PivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension11});
				this.PivotDashboardItem1.ComponentName = "PivotDashboardItem1";
				Measure6.DataMember = "Profit";
				Measure6.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure6.NumericFormat.IncludeGroupSeparator = true;
				Measure6.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension12.DataMember = "item_desc";
				Dimension13.DataMember = "pos_date";
				Dimension13.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				this.PivotDashboardItem1.DataItemRepository.Clear();
				this.PivotDashboardItem1.DataItemRepository.Add(Measure6, "DataItem0");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension12, "DataItem1");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension11, "DataItem2");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension13, "DataItem3");
				this.PivotDashboardItem1.DataSource = this.Profit;
				this.PivotDashboardItem1.FilterString = "[DataItem3] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem1.IgnoreMasterFilters = false;
				this.PivotDashboardItem1.Name = "Profit per Item (Monthly View)";
				this.PivotDashboardItem1.NamesRepository.Clear();
				this.PivotDashboardItem1.NamesRepository.Add(Measure6, "Profit (Sum)");
				this.PivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension12, Dimension13});
				this.PivotDashboardItem1.ShowCaption = true;
				this.PivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure6});
				//
				//ProfitDB
				//
				DataConnection1.Name = "DOORSCOMPUTERS\\SQLEXPRESS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.Profit});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.ChartDashboardItem1, this.ChartDashboardItem2, this.PivotDashboardItem1, this.PivotDashboardItem2, this.ChartDashboardItem3, this.PivotDashboardItem3});
				DashboardLayoutItem1.DashboardItem = this.ChartDashboardItem2;
				DashboardLayoutItem1.Weight = 52.227342549923193D;
				DashboardLayoutItem2.DashboardItem = this.ChartDashboardItem1;
				DashboardLayoutItem2.Weight = 23.80952380952381D;
				DashboardLayoutItem3.DashboardItem = this.ChartDashboardItem3;
				DashboardLayoutItem3.Weight = 23.963133640552996D;
				DashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutItem2, DashboardLayoutItem3});
				DashboardLayoutGroup2.Weight = 50.69033530571992D;
				DashboardLayoutItem4.DashboardItem = this.PivotDashboardItem2;
				DashboardLayoutItem4.Weight = 29.3394777265745D;
				DashboardLayoutItem5.DashboardItem = this.PivotDashboardItem3;
				DashboardLayoutItem5.Weight = 27.1889400921659D;
				DashboardLayoutItem6.DashboardItem = this.PivotDashboardItem1;
				DashboardLayoutItem6.Weight = 43.4715821812596D;
				DashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem4, DashboardLayoutItem5, DashboardLayoutItem6});
				DashboardLayoutGroup3.Weight = 49.30966469428008D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutGroup2, DashboardLayoutGroup3});
				DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				this.LayoutRoot = DashboardLayoutGroup1;
				DashboardParameter1.Name = "DateFrom";
				DashboardParameter1.Type = typeof(DateTime);
				DashboardParameter1.Value = new DateTime(2000, 2, 7, 21, 12, 0, 0);
				DashboardParameter2.Name = "DateTo";
				DashboardParameter2.Type = typeof(DateTime);
				DashboardParameter2.Value = new DateTime(2999, 2, 7, 21, 12, 0, 0);
				DashboardParameter3.Name = "YrEnd";
				DashboardParameter3.Type = typeof(int);
				DashboardParameter3.Value = 2099;
				this.Parameters.AddRange(new DevExpress.DashboardCommon.DashboardParameter[] {DashboardParameter1, DashboardParameter2, DashboardParameter3});
				this.Title.Text = "Profit Overview";
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.Profit).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure4).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem2).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure5).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure6).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension12).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension13).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.DataSource Profit;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem1;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem2;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem2;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem3;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem3;
			
#endregion
		}
	}
}
