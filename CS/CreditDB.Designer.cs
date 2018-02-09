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
		public partial class CreditDB
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
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditDB));
				DevExpress.DashboardCommon.Dimension Dimension3 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension4 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn2 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension5 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn3 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension6 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn4 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension7 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension8 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension9 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure3 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension10 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension11 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension12 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure4 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DataAccess.DataConnection DataConnection1 = new DevExpress.DataAccess.DataConnection();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem5 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter1 = new DevExpress.DashboardCommon.DashboardParameter();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter2 = new DevExpress.DashboardCommon.DashboardParameter();
				this.ChartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.DataSource1 = new DevExpress.DashboardCommon.DataSource();
				this.GridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
				this.PieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
				this.PivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem2 = new DevExpress.DashboardCommon.PivotDashboardItem();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.GridDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PieDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension12).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure4).BeginInit();
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
				Dimension2.DataMember = "pos_date";
				Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.ChartDashboardItem1.DataItemRepository.Clear();
				this.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem2");
				this.ChartDashboardItem1.DataSource = this.DataSource1;
				this.ChartDashboardItem1.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)";
				this.ChartDashboardItem1.IgnoreMasterFilters = false;
				this.ChartDashboardItem1.Name = "Monthly Chart View Credits";
				ChartPane1.Name = "Pane 1";
				ChartPane1.PrimaryAxisY.ShowGridLines = true;
				ChartPane1.PrimaryAxisY.TitleVisible = true;
				ChartPane1.SecondaryAxisY.ShowGridLines = false;
				ChartPane1.SecondaryAxisY.TitleVisible = true;
				SimpleSeries1.Name = "det_amnt (Sum)";
				SimpleSeries1.AddDataItem("Value", Measure1);
				ChartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries1});
				this.ChartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane1});
				this.ChartDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension2});
				this.ChartDashboardItem1.ShowCaption = true;
				//
				//DataSource1
				//
				this.DataSource1.ComponentName = "DataSource1";
				this.DataSource1.DataProviderSerializable = resources.GetString("DataSource1.DataProviderSerializable");
				this.DataSource1.Name = "creditsds";
				//
				//GridDashboardItem1
				//
				Dimension3.DataMember = "pos_date";
				Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				GridDimensionColumn1.Name = "Credit Date";
				GridDimensionColumn1.AddDataItem("Dimension", Dimension3);
				Dimension4.DataMember = "item_desc";
				GridDimensionColumn2.Name = "Items";
				GridDimensionColumn2.AddDataItem("Dimension", Dimension4);
				Dimension5.DataMember = "det_amnt";
				GridDimensionColumn3.Name = "Amount";
				GridDimensionColumn3.AddDataItem("Dimension", Dimension5);
				Dimension6.DataMember = "sInsert_id";
				GridDimensionColumn4.Name = "Employee";
				GridDimensionColumn4.AddDataItem("Dimension", Dimension6);
				this.GridDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {GridDimensionColumn1, GridDimensionColumn2, GridDimensionColumn3, GridDimensionColumn4});
				this.GridDashboardItem1.ComponentName = "GridDashboardItem1";
				this.GridDashboardItem1.DataItemRepository.Clear();
				this.GridDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem0");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem1");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem2");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem3");
				this.GridDashboardItem1.DataSource = this.DataSource1;
				this.GridDashboardItem1.FilterString = "[DataItem0] Between(?DateFrom, ?DateTo)";
				this.GridDashboardItem1.IgnoreMasterFilters = false;
				this.GridDashboardItem1.Name = "Credits View Per Day";
				this.GridDashboardItem1.ShowCaption = true;
				//
				//PieDashboardItem1
				//
				Dimension7.DataMember = "pos_date";
				Dimension7.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.QuarterYear;
				this.PieDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension7});
				this.PieDashboardItem1.ComponentName = "PieDashboardItem1";
				Measure2.DataMember = "det_amnt";
				Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure2.NumericFormat.IncludeGroupSeparator = true;
				Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension8.DataMember = "pos_date";
				this.PieDashboardItem1.DataItemRepository.Clear();
				this.PieDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0");
				this.PieDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem1");
				this.PieDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem2");
				this.PieDashboardItem1.DataSource = this.DataSource1;
				this.PieDashboardItem1.IgnoreMasterFilters = false;
				this.PieDashboardItem1.Name = "Quarterly Pie Chart Credits";
				this.PieDashboardItem1.NamesRepository.Clear();
				this.PieDashboardItem1.NamesRepository.Add(Measure2, "Amount");
				this.PieDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension8});
				this.PieDashboardItem1.ShowCaption = true;
				this.PieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure2});
				//
				//PivotDashboardItem1
				//
				Dimension9.DataMember = "pos_date";
				Dimension9.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.PivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension9});
				this.PivotDashboardItem1.ComponentName = "PivotDashboardItem1";
				Measure3.DataMember = "det_amnt";
				Dimension10.DataMember = "item_desc";
				this.PivotDashboardItem1.DataItemRepository.Clear();
				this.PivotDashboardItem1.DataItemRepository.Add(Measure3, "DataItem0");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension9, "DataItem1");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension10, "DataItem2");
				this.PivotDashboardItem1.DataSource = this.DataSource1;
				this.PivotDashboardItem1.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem1.IgnoreMasterFilters = false;
				this.PivotDashboardItem1.Name = "Credits Monthly Grid View";
				this.PivotDashboardItem1.NamesRepository.Clear();
				this.PivotDashboardItem1.NamesRepository.Add(Measure3, "Amount");
				this.PivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension10});
				this.PivotDashboardItem1.ShowCaption = true;
				this.PivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure3});
				//
				//PivotDashboardItem2
				//
				this.PivotDashboardItem2.AutoExpandRowGroups = true;
				Dimension11.DataMember = "pos_date";
				Dimension11.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				Dimension11.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.PivotDashboardItem2.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension11});
				this.PivotDashboardItem2.ComponentName = "PivotDashboardItem2";
				Dimension12.DataMember = "sInsert_id";
				Dimension12.SortByMeasureName = "DataItem1";
				Dimension12.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				Measure4.DataMember = "det_amnt";
				Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure4.NumericFormat.IncludeGroupSeparator = true;
				Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				this.PivotDashboardItem2.DataItemRepository.Clear();
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension12, "DataItem0");
				this.PivotDashboardItem2.DataItemRepository.Add(Measure4, "DataItem1");
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension11, "DataItem2");
				this.PivotDashboardItem2.DataSource = this.DataSource1;
				this.PivotDashboardItem2.FilterString = "[DataItem2] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem2.IgnoreMasterFilters = false;
				this.PivotDashboardItem2.Name = "Credit per Employee";
				this.PivotDashboardItem2.NamesRepository.Clear();
				this.PivotDashboardItem2.NamesRepository.Add(Measure4, "Amount");
				this.PivotDashboardItem2.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension12});
				this.PivotDashboardItem2.ShowCaption = true;
				this.PivotDashboardItem2.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure4});
				//
				//CreditDB
				//
				DataConnection1.Name = "DOORSCOMPUTERS\\SQLEXPRESS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.DataSource1});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.ChartDashboardItem1, this.PieDashboardItem1, this.GridDashboardItem1, this.PivotDashboardItem1, this.PivotDashboardItem2});
				DashboardLayoutItem1.DashboardItem = this.ChartDashboardItem1;
				DashboardLayoutItem1.Weight = 58.525345622119815D;
				DashboardLayoutItem2.DashboardItem = this.PieDashboardItem1;
				DashboardLayoutItem2.Weight = 41.474654377880185D;
				DashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutItem2});
				DashboardLayoutGroup2.Weight = 49.901380670611438D;
				DashboardLayoutItem3.DashboardItem = this.GridDashboardItem1;
				DashboardLayoutItem3.Weight = 36.251920122887867D;
				DashboardLayoutItem4.DashboardItem = this.PivotDashboardItem1;
				DashboardLayoutItem4.Weight = 44.5468509984639D;
				DashboardLayoutItem5.DashboardItem = this.PivotDashboardItem2;
				DashboardLayoutItem5.Weight = 19.201228878648234D;
				DashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem3, DashboardLayoutItem4, DashboardLayoutItem5});
				DashboardLayoutGroup3.Weight = 50.098619329388562D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutGroup2, DashboardLayoutGroup3});
				DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				this.LayoutRoot = DashboardLayoutGroup1;
				DashboardParameter1.Name = "DateFrom";
				DashboardParameter1.Type = typeof(DateTime);
				DashboardParameter1.Value = new DateTime(2000, 2, 10, 10, 53, 0, 0);
				DashboardParameter2.Name = "DateTo";
				DashboardParameter2.Type = typeof(DateTime);
				DashboardParameter2.Value = new DateTime(2099, 2, 10, 10, 53, 0, 0);
				this.Parameters.AddRange(new DevExpress.DashboardCommon.DashboardParameter[] {DashboardParameter1, DashboardParameter2});
				this.Title.Text = "Dashboard";
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).EndInit();
				((System.ComponentModel.ISupportInitialize) this.GridDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PieDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension12).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure4).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem2).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.DataSource DataSource1;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem1;
			internal DevExpress.DashboardCommon.PieDashboardItem PieDashboardItem1;
			internal DevExpress.DashboardCommon.GridDashboardItem GridDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem2;
			
#endregion
		}
	}
}
