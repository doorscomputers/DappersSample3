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
		public partial class Itemssoldsummry
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
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Itemssoldsummry));
				DevExpress.DashboardCommon.Dimension Dimension3 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension4 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure3 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure4 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension5 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension6 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure5 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension7 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure6 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension8 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DataAccess.DataConnection DataConnection1 = new DevExpress.DataAccess.DataConnection();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter1 = new DevExpress.DashboardCommon.DashboardParameter();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter2 = new DevExpress.DashboardCommon.DashboardParameter();
				this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.dataSource1 = new DevExpress.DashboardCommon.DataSource();
				this.pieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
				this.pivotDashboardItem2 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.pivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
				((System.ComponentModel.ISupportInitialize) this.chartDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.dataSource1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.pieDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure6).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//chartDashboardItem1
				//
				Dimension1.DataMember = "catgory";
				Dimension1.SortByMeasureName = "DataItem1";
				Dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.chartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension1});
				this.chartDashboardItem1.AxisX.TitleVisible = false;
				this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
				Measure1.DataMember = "qty";
				Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure1.NumericFormat.IncludeGroupSeparator = true;
				Measure1.NumericFormat.Precision = 0;
				Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension2.DataMember = "pos_date";
				Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.QuarterYear;
				Dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.chartDashboardItem1.DataItemRepository.Clear();
				this.chartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0");
				this.chartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem1");
				this.chartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem2");
				this.chartDashboardItem1.DataSource = this.dataSource1;
				this.chartDashboardItem1.IgnoreMasterFilters = false;
				this.chartDashboardItem1.InteractivityOptions.IsDrillDownEnabled = true;
				this.chartDashboardItem1.Name = "Chart Grouped by Category";
				ChartPane1.Name = "Pane 1";
				ChartPane1.PrimaryAxisY.ShowGridLines = true;
				ChartPane1.PrimaryAxisY.Title = "Qty Sold Total";
				ChartPane1.PrimaryAxisY.TitleVisible = true;
				ChartPane1.SecondaryAxisY.ShowGridLines = false;
				ChartPane1.SecondaryAxisY.TitleVisible = true;
				SimpleSeries1.Name = "qty (Sum)";
				SimpleSeries1.AddDataItem("Value", Measure1);
				ChartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries1});
				this.chartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane1});
				this.chartDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension2});
				this.chartDashboardItem1.ShowCaption = true;
				//
				//dataSource1
				//
				this.dataSource1.ComponentName = "dataSource1";
				this.dataSource1.DataProviderSerializable = resources.GetString("dataSource1.DataProviderSerializable");
				this.dataSource1.Filter = "";
				this.dataSource1.Name = "Data Source 3";
				//
				//pieDashboardItem1
				//
				Dimension3.DataMember = "catgory";
				this.pieDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension3});
				this.pieDashboardItem1.ComponentName = "pieDashboardItem1";
				Measure2.DataMember = "qty";
				this.pieDashboardItem1.DataItemRepository.Clear();
				this.pieDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0");
				this.pieDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem2");
				this.pieDashboardItem1.DataSource = this.dataSource1;
				this.pieDashboardItem1.IgnoreMasterFilters = false;
				this.pieDashboardItem1.Name = "Chart Grouped by Month-Year";
				this.pieDashboardItem1.NamesRepository.Clear();
				this.pieDashboardItem1.NamesRepository.Add(Measure2, "Qty Sold Total");
				this.pieDashboardItem1.ShowCaption = true;
				this.pieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure2});
				//
				//pivotDashboardItem2
				//
				this.pivotDashboardItem2.AutoExpandRowGroups = true;
				this.pivotDashboardItem2.ComponentName = "pivotDashboardItem2";
				Dimension4.DataMember = "catgory";
				Dimension4.SortByMeasureName = "DataItem1";
				Dimension4.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				Measure3.DataMember = "qty";
				Measure4.DataMember = "det_amnt";
				Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure4.NumericFormat.IncludeGroupSeparator = true;
				Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension5.DataMember = "pos_date";
				Dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.pivotDashboardItem2.DataItemRepository.Clear();
				this.pivotDashboardItem2.DataItemRepository.Add(Dimension4, "DataItem0");
				this.pivotDashboardItem2.DataItemRepository.Add(Measure3, "DataItem1");
				this.pivotDashboardItem2.DataItemRepository.Add(Measure4, "DataItem3");
				this.pivotDashboardItem2.DataItemRepository.Add(Dimension5, "DataItem2");
				this.pivotDashboardItem2.DataSource = this.dataSource1;
				this.pivotDashboardItem2.FilterString = "[DataItem2] Between(?From, ?To)";
				this.pivotDashboardItem2.IgnoreMasterFilters = false;
				this.pivotDashboardItem2.Name = "Sold Items Monthly (View 1)";
				this.pivotDashboardItem2.NamesRepository.Clear();
				this.pivotDashboardItem2.NamesRepository.Add(Measure3, "Qty Sold");
				this.pivotDashboardItem2.NamesRepository.Add(Measure4, "Amount");
				this.pivotDashboardItem2.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension5, Dimension4});
				this.pivotDashboardItem2.ShowCaption = true;
				this.pivotDashboardItem2.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure3, Measure4});
				//
				//pivotDashboardItem1
				//
				this.pivotDashboardItem1.AutoExpandRowGroups = true;
				Dimension6.DataMember = "pos_date";
				Dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.pivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension6});
				this.pivotDashboardItem1.ComponentName = "pivotDashboardItem1";
				Measure5.DataMember = "qty";
				Dimension7.DataMember = "catgory";
				Dimension7.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				Measure6.DataMember = "det_amnt";
				Measure6.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure6.NumericFormat.IncludeGroupSeparator = true;
				Measure6.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension8.DataMember = "item_desc";
				Dimension8.SortByMeasureName = "DataItem1";
				Dimension8.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.pivotDashboardItem1.DataItemRepository.Clear();
				this.pivotDashboardItem1.DataItemRepository.Add(Measure5, "DataItem1");
				this.pivotDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem0");
				this.pivotDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem2");
				this.pivotDashboardItem1.DataItemRepository.Add(Measure6, "DataItem3");
				this.pivotDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem4");
				this.pivotDashboardItem1.DataSource = this.dataSource1;
				this.pivotDashboardItem1.IgnoreMasterFilters = false;
				this.pivotDashboardItem1.Name = "Sold Items Monthly (View2)";
				this.pivotDashboardItem1.NamesRepository.Clear();
				this.pivotDashboardItem1.NamesRepository.Add(Measure5, "Qty Sold");
				this.pivotDashboardItem1.NamesRepository.Add(Measure6, "Amount");
				this.pivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension7, Dimension8});
				this.pivotDashboardItem1.ShowCaption = true;
				this.pivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure5, Measure6});
				//
				//Itemssoldsummry
				//
				DataConnection1.Name = "DOORSCOMPUTERS\\SQLEXPRESS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.dataSource1});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.chartDashboardItem1, this.pieDashboardItem1, this.pivotDashboardItem1, this.pivotDashboardItem2});
				DashboardLayoutItem1.DashboardItem = this.pieDashboardItem1;
				DashboardLayoutItem1.Weight = 49.923195084485407D;
				DashboardLayoutItem2.DashboardItem = this.chartDashboardItem1;
				DashboardLayoutItem2.Weight = 50.076804915514593D;
				DashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutItem2});
				DashboardLayoutGroup2.Weight = 43.589743589743591D;
				DashboardLayoutItem3.DashboardItem = this.pivotDashboardItem2;
				DashboardLayoutItem3.Weight = 48.387096774193552D;
				DashboardLayoutItem4.DashboardItem = this.pivotDashboardItem1;
				DashboardLayoutItem4.Weight = 51.612903225806448D;
				DashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem3, DashboardLayoutItem4});
				DashboardLayoutGroup3.Weight = 56.410256410256409D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutGroup2, DashboardLayoutGroup3});
				DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				this.LayoutRoot = DashboardLayoutGroup1;
				DashboardParameter1.Name = "From";
				DashboardParameter1.Type = typeof(DateTime);
				DashboardParameter1.Value = new DateTime(2013, 12, 2, 0, 0, 0, 0);
				DashboardParameter2.Name = "To";
				DashboardParameter2.Type = typeof(DateTime);
				DashboardParameter2.Value = new DateTime(9999, 12, 2, 0, 0, 0, 0);
				this.Parameters.AddRange(new DevExpress.DashboardCommon.DashboardParameter[] {DashboardParameter1, DashboardParameter2});
				this.Title.Text = "Sales per Item Category Dashboard";
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.chartDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.dataSource1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.pieDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure3).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure4).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).EndInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure5).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure6).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).EndInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
			internal DevExpress.DashboardCommon.DataSource dataSource1;
			internal DevExpress.DashboardCommon.PieDashboardItem pieDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem2;
			
#endregion
		}
	}
}
