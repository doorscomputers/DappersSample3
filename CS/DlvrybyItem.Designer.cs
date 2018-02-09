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
		public partial class DlvrybyItem
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
				DevExpress.DashboardCommon.Dimension Dimension2 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure1 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension3 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.ChartPane ChartPane1 = new DevExpress.DashboardCommon.ChartPane();
				DevExpress.DashboardCommon.SimpleSeries SimpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlvrybyItem));
				DevExpress.DashboardCommon.Dimension Dimension4 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension5 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension6 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension7 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn2 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension8 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn3 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension9 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn4 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension10 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure3 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure4 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension11 = new DevExpress.DashboardCommon.Dimension();
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
				this.gridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
				this.pivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
				((System.ComponentModel.ISupportInitialize) this.chartDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.dataSource1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.pieDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.gridDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//chartDashboardItem1
				//
				Dimension1.DataMember = "dtInsert_dt";
				Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				Dimension2.DataMember = "item_desc";
				Dimension2.SortByMeasureName = "DataItem0";
				Dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				Dimension2.TopNOptions.Count = 30;
				Dimension2.TopNOptions.Enabled = true;
				Dimension2.TopNOptions.MeasureName = "DataItem0";
				this.chartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension1, Dimension2});
				this.chartDashboardItem1.AxisX.TitleVisible = false;
				this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
				Measure1.DataMember = "qty";
				Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure1.NumericFormat.IncludeGroupSeparator = true;
				Measure1.NumericFormat.Precision = 0;
				Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension3.DataMember = "dtInsert_dt";
				this.chartDashboardItem1.DataItemRepository.Clear();
				this.chartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0");
				this.chartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem1");
				this.chartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem2");
				this.chartDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem3");
				this.chartDashboardItem1.DataSource = this.dataSource1;
				this.chartDashboardItem1.IgnoreMasterFilters = false;
				this.chartDashboardItem1.Name = "Top 30 Items Delivered";
				ChartPane1.Name = "Pane 1";
				ChartPane1.PrimaryAxisY.ShowGridLines = true;
				ChartPane1.PrimaryAxisY.Title = "Amount";
				ChartPane1.PrimaryAxisY.TitleVisible = true;
				ChartPane1.SecondaryAxisY.ShowGridLines = false;
				ChartPane1.SecondaryAxisY.TitleVisible = true;
				SimpleSeries1.Name = "qty (Sum)";
				SimpleSeries1.AddDataItem("Value", Measure1);
				ChartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries1});
				this.chartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane1});
				this.chartDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension3});
				this.chartDashboardItem1.ShowCaption = true;
				//
				//dataSource1
				//
				this.dataSource1.ComponentName = "dataSource1";
				this.dataSource1.DataProviderSerializable = resources.GetString("dataSource1.DataProviderSerializable");
				this.dataSource1.Filter = "[vwDlvryDetails.dtInsert_dt] Between(?Parameter1, ?Parameter2)";
				this.dataSource1.Name = "dsDlvrybyItem";
				//
				//pieDashboardItem1
				//
				Dimension4.DataMember = "catgory";
				this.pieDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension4});
				this.pieDashboardItem1.ComponentName = "pieDashboardItem1";
				Measure2.DataMember = "qty";
				Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure2.NumericFormat.IncludeGroupSeparator = true;
				Measure2.NumericFormat.Precision = 0;
				Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension5.DataMember = "dtInsert_dt";
				Dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.QuarterYear;
				Dimension5.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.pieDashboardItem1.DataItemRepository.Clear();
				this.pieDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0");
				this.pieDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem1");
				this.pieDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem2");
				this.pieDashboardItem1.DataSource = this.dataSource1;
				this.pieDashboardItem1.IgnoreMasterFilters = false;
				this.pieDashboardItem1.Name = "Pies Chart (Item Category per Quarter)";
				this.pieDashboardItem1.NamesRepository.Clear();
				this.pieDashboardItem1.NamesRepository.Add(Measure2, "Amount");
				this.pieDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension5});
				this.pieDashboardItem1.ShowCaption = true;
				this.pieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure2});
				//
				//gridDashboardItem1
				//
				Dimension6.DataMember = "dtInsert_dt";
				Dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				GridDimensionColumn1.Name = "Date";
				GridDimensionColumn1.AddDataItem("Dimension", Dimension6);
				Dimension7.DataMember = "item_desc";
				GridDimensionColumn2.Name = "Items Received";
				GridDimensionColumn2.AddDataItem("Dimension", Dimension7);
				Dimension8.DataMember = "qty";
				Dimension8.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Dimension8.NumericFormat.IncludeGroupSeparator = true;
				Dimension8.NumericFormat.Precision = 0;
				Dimension8.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				GridDimensionColumn3.Name = "Qty";
				GridDimensionColumn3.AddDataItem("Dimension", Dimension8);
				Dimension9.DataMember = "drdetamnt";
				Dimension9.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Dimension9.NumericFormat.IncludeGroupSeparator = true;
				Dimension9.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				GridDimensionColumn4.Name = "Amount";
				GridDimensionColumn4.AddDataItem("Dimension", Dimension9);
				this.gridDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {GridDimensionColumn1, GridDimensionColumn2, GridDimensionColumn3, GridDimensionColumn4});
				this.gridDashboardItem1.ComponentName = "gridDashboardItem1";
				this.gridDashboardItem1.DataItemRepository.Clear();
				this.gridDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem0");
				this.gridDashboardItem1.DataItemRepository.Add(Dimension9, "DataItem1");
				this.gridDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem2");
				this.gridDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem3");
				this.gridDashboardItem1.DataSource = this.dataSource1;
				this.gridDashboardItem1.IgnoreMasterFilters = false;
				this.gridDashboardItem1.Name = "Grid View Deliveries Per Day";
				this.gridDashboardItem1.ShowCaption = true;
				//
				//pivotDashboardItem1
				//
				Dimension10.DataMember = "dtInsert_dt";
				Dimension10.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.pivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension10});
				this.pivotDashboardItem1.ComponentName = "pivotDashboardItem1";
				Measure3.DataMember = "qty";
				Measure4.DataMember = "drdetamnt";
				Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure4.NumericFormat.IncludeGroupSeparator = true;
				Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension11.DataMember = "item_desc";
				this.pivotDashboardItem1.DataItemRepository.Clear();
				this.pivotDashboardItem1.DataItemRepository.Add(Measure3, "DataItem0");
				this.pivotDashboardItem1.DataItemRepository.Add(Measure4, "DataItem1");
				this.pivotDashboardItem1.DataItemRepository.Add(Dimension11, "DataItem2");
				this.pivotDashboardItem1.DataItemRepository.Add(Dimension10, "DataItem3");
				this.pivotDashboardItem1.DataSource = this.dataSource1;
				this.pivotDashboardItem1.IgnoreMasterFilters = false;
				this.pivotDashboardItem1.Name = "Grid View Deliveries per Month";
				this.pivotDashboardItem1.NamesRepository.Clear();
				this.pivotDashboardItem1.NamesRepository.Add(Measure3, "Qty Delivered");
				this.pivotDashboardItem1.NamesRepository.Add(Measure4, "Amount");
				this.pivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension11});
				this.pivotDashboardItem1.ShowCaption = true;
				this.pivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure3, Measure4});
				//
				//DlvrybyItem
				//
				DataConnection1.Name = "DOORSCOMPUTERS\\SQLEXPRESS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.dataSource1});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.chartDashboardItem1, this.pieDashboardItem1, this.gridDashboardItem1, this.pivotDashboardItem1});
				DashboardLayoutItem1.DashboardItem = this.chartDashboardItem1;
				DashboardLayoutItem1.Weight = 49.769585253456221D;
				DashboardLayoutItem2.DashboardItem = this.pieDashboardItem1;
				DashboardLayoutItem2.Weight = 50.230414746543779D;
				DashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutItem2});
				DashboardLayoutGroup2.Weight = 49.901380670611438D;
				DashboardLayoutItem3.DashboardItem = this.gridDashboardItem1;
				DashboardLayoutItem3.Weight = 49.769585253456221D;
				DashboardLayoutItem4.DashboardItem = this.pivotDashboardItem1;
				DashboardLayoutItem4.Weight = 50.230414746543779D;
				DashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem3, DashboardLayoutItem4});
				DashboardLayoutGroup3.Weight = 50.098619329388562D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutGroup2, DashboardLayoutGroup3});
				DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				this.LayoutRoot = DashboardLayoutGroup1;
				DashboardParameter1.Name = "Parameter1";
				DashboardParameter1.Type = typeof(DateTime);
				DashboardParameter1.Value = new DateTime(2013, 12, 1, 0, 0, 0, 0);
				DashboardParameter2.Name = "Parameter2";
				DashboardParameter2.Type = typeof(DateTime);
				DashboardParameter2.Value = new DateTime(2014, 2, 4, 0, 0, 0, 0);
				this.Parameters.AddRange(new DevExpress.DashboardCommon.DashboardParameter[] {DashboardParameter1, DashboardParameter2});
				this.Title.Text = "Deliveries per Item";
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) this.chartDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.dataSource1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).EndInit();
				((System.ComponentModel.ISupportInitialize) this.pieDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).EndInit();
				((System.ComponentModel.ISupportInitialize) this.gridDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure3).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure4).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).EndInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
			internal DevExpress.DashboardCommon.DataSource dataSource1;
			internal DevExpress.DashboardCommon.PieDashboardItem pieDashboardItem1;
			internal DevExpress.DashboardCommon.GridDashboardItem gridDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem1;
			
#endregion
		}
	}
}
