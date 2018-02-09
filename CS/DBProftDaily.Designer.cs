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
		public partial class DBProftDaily
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
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBProftDaily));
				DevExpress.DashboardCommon.Dimension Dimension3 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension4 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure3 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension5 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DataAccess.DataConnection DataConnection1 = new DevExpress.DataAccess.DataConnection();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				this.ChartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.DataSource1 = new DevExpress.DashboardCommon.DataSource();
				this.PivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem2 = new DevExpress.DashboardCommon.PivotDashboardItem();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//ChartDashboardItem1
				//
				Dimension1.DataMember = "pos_date";
				Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				Dimension1.TopNOptions.Count = 31;
				Dimension1.TopNOptions.Enabled = true;
				Dimension1.TopNOptions.MeasureName = "DataItem0";
				this.ChartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension1});
				this.ChartDashboardItem1.AxisX.TitleVisible = false;
				this.ChartDashboardItem1.ComponentName = "ChartDashboardItem1";
				Measure1.DataMember = "Profit";
				Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure1.NumericFormat.IncludeGroupSeparator = true;
				Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension2.DataMember = "pos_date";
				Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.ChartDashboardItem1.DataItemRepository.Clear();
				this.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem2");
				this.ChartDashboardItem1.DataSource = this.DataSource1;
				this.ChartDashboardItem1.IgnoreMasterFilters = false;
				this.ChartDashboardItem1.Name = "Top 31 Daily Profit Chart";
				ChartPane1.Name = "Pane 1";
				ChartPane1.PrimaryAxisY.ShowGridLines = true;
				ChartPane1.PrimaryAxisY.TitleVisible = true;
				ChartPane1.SecondaryAxisY.ShowGridLines = false;
				ChartPane1.SecondaryAxisY.TitleVisible = true;
				SimpleSeries1.Name = "Profit (Sum)";
				SimpleSeries1.AddDataItem("Value", Measure1);
				ChartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries1});
				this.ChartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane1});
				this.ChartDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension2});
				this.ChartDashboardItem1.ShowCaption = true;
				//
				//DataSource1
				//
				CalculatedField1.DataType = DevExpress.DashboardCommon.CalculatedFieldType.Decimal;
				CalculatedField1.Expression = "([price] * [qty])-([cost] * [qty])";
				CalculatedField1.Name = "Profit";
				this.DataSource1.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {CalculatedField1});
				this.DataSource1.ComponentName = "DataSource1";
				this.DataSource1.DataProviderSerializable = resources.GetString("DataSource1.DataProviderSerializable");
				this.DataSource1.Name = "dsDailyProfit";
				//
				//PivotDashboardItem1
				//
				Dimension3.DataMember = "pos_date";
				Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.PivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension3});
				this.PivotDashboardItem1.ComponentName = "PivotDashboardItem1";
				Measure2.DataMember = "Profit";
				Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure2.NumericFormat.IncludeGroupSeparator = true;
				Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension4.DataMember = "pos_date";
				Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				this.PivotDashboardItem1.DataItemRepository.Clear();
				this.PivotDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem1");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem2");
				this.PivotDashboardItem1.DataSource = this.DataSource1;
				this.PivotDashboardItem1.IgnoreMasterFilters = false;
				this.PivotDashboardItem1.Name = "Pivot 1";
				this.PivotDashboardItem1.NamesRepository.Clear();
				this.PivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension4});
				this.PivotDashboardItem1.ShowCaption = true;
				this.PivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure2});
				//
				//PivotDashboardItem2
				//
				this.PivotDashboardItem2.ComponentName = "PivotDashboardItem2";
				Measure3.DataMember = "Profit";
				Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure3.NumericFormat.IncludeGroupSeparator = true;
				Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension5.DataMember = "pos_date";
				Dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				Dimension5.SortByMeasureName = "DataItem0";
				Dimension5.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.PivotDashboardItem2.DataItemRepository.Clear();
				this.PivotDashboardItem2.DataItemRepository.Add(Measure3, "DataItem0");
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension5, "DataItem1");
				this.PivotDashboardItem2.DataSource = this.DataSource1;
				this.PivotDashboardItem2.IgnoreMasterFilters = false;
				this.PivotDashboardItem2.Name = "Daily Profit (Highest to Lowest)";
				this.PivotDashboardItem2.NamesRepository.Clear();
				this.PivotDashboardItem2.NamesRepository.Add(Measure3, "Profit (Sum)");
				this.PivotDashboardItem2.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension5});
				this.PivotDashboardItem2.ShowCaption = true;
				this.PivotDashboardItem2.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure3});
				//
				//DBProftDaily
				//
				DataConnection1.Name = "DOORSCOMPUTERS\\SQLEXPRESS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.DataSource1});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.ChartDashboardItem1, this.PivotDashboardItem1, this.PivotDashboardItem2});
				DashboardLayoutItem1.DashboardItem = this.ChartDashboardItem1;
				DashboardLayoutItem1.Weight = 50.098619329388562D;
				DashboardLayoutItem2.DashboardItem = this.PivotDashboardItem1;
				DashboardLayoutItem2.Weight = 69.5852534562212D;
				DashboardLayoutItem3.DashboardItem = this.PivotDashboardItem2;
				DashboardLayoutItem3.Weight = 30.4147465437788D;
				DashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem2, DashboardLayoutItem3});
				DashboardLayoutGroup2.Weight = 49.901380670611438D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutGroup2});
				DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				this.LayoutRoot = DashboardLayoutGroup1;
				this.Title.Text = "Daily Profit";
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem2).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.DataSource DataSource1;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem2;
			
#endregion
		}
	}
}