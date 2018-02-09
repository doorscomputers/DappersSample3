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
		public partial class DBTransfer
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
				DevExpress.DashboardCommon.Dimension Dimension3 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure1 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.ChartPane ChartPane1 = new DevExpress.DashboardCommon.ChartPane();
				DevExpress.DashboardCommon.SimpleSeries SimpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBTransfer));
				DevExpress.DashboardCommon.Dimension Dimension4 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension5 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn2 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension6 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn3 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension7 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn4 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension8 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension9 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension10 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension11 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension12 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension13 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension14 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure3 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension15 = new DevExpress.DashboardCommon.Dimension();
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
				this.ChartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.DataSource1 = new DevExpress.DashboardCommon.DataSource();
				this.GridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
				this.PivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem2 = new DevExpress.DashboardCommon.PivotDashboardItem();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.GridDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension12).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension13).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension14).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension15).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//ChartDashboardItem1
				//
				Dimension1.DataMember = "item_desc";
				Dimension1.TopNOptions.Count = 50;
				Dimension1.TopNOptions.Enabled = true;
				Dimension1.TopNOptions.MeasureName = "DataItem1";
				Dimension2.DataMember = "location";
				Dimension3.DataMember = "dtInsert_dt";
				Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.ChartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension1, Dimension2, Dimension3});
				this.ChartDashboardItem1.AxisX.TitleVisible = false;
				this.ChartDashboardItem1.ComponentName = "ChartDashboardItem1";
				Measure1.DataMember = "qty";
				this.ChartDashboardItem1.DataItemRepository.Clear();
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0");
				this.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem1");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem2");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem3");
				this.ChartDashboardItem1.DataSource = this.DataSource1;
				this.ChartDashboardItem1.IgnoreMasterFilters = false;
				this.ChartDashboardItem1.Name = "Top 50 Transfers";
				ChartPane1.Name = "Pane 1";
				ChartPane1.PrimaryAxisY.ShowGridLines = true;
				ChartPane1.PrimaryAxisY.TitleVisible = true;
				ChartPane1.SecondaryAxisY.ShowGridLines = false;
				ChartPane1.SecondaryAxisY.TitleVisible = true;
				SimpleSeries1.Name = "Qty Transferred";
				SimpleSeries1.AddDataItem("Value", Measure1);
				ChartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries1});
				this.ChartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane1});
				this.ChartDashboardItem1.ShowCaption = true;
				//
				//DataSource1
				//
				this.DataSource1.ComponentName = "DataSource1";
				this.DataSource1.DataProviderSerializable = resources.GetString("DataSource1.DataProviderSerializable");
				this.DataSource1.Filter = "";
				this.DataSource1.Name = "dsTransfer";
				//
				//GridDashboardItem1
				//
				Dimension4.DataMember = "dtInsert_dt";
				Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				GridDimensionColumn1.Name = "Date Transferred";
				GridDimensionColumn1.AddDataItem("Dimension", Dimension4);
				Dimension5.DataMember = "item_desc";
				GridDimensionColumn2.Name = "Item Transferred";
				GridDimensionColumn2.AddDataItem("Dimension", Dimension5);
				Dimension6.DataMember = "qty";
				GridDimensionColumn3.Name = "Qty";
				GridDimensionColumn3.AddDataItem("Dimension", Dimension6);
				Dimension7.DataMember = "location";
				GridDimensionColumn4.Name = "Transferred to";
				GridDimensionColumn4.AddDataItem("Dimension", Dimension7);
				this.GridDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {GridDimensionColumn1, GridDimensionColumn2, GridDimensionColumn3, GridDimensionColumn4});
				this.GridDashboardItem1.ComponentName = "GridDashboardItem1";
				this.GridDashboardItem1.DataItemRepository.Clear();
				this.GridDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem0");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem1");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem2");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem3");
				this.GridDashboardItem1.DataSource = this.DataSource1;
				this.GridDashboardItem1.FilterString = "[DataItem2] Between(?DateFrom, ?DateTo)";
				this.GridDashboardItem1.IgnoreMasterFilters = false;
				this.GridDashboardItem1.Name = "Grid View per Day Transfer";
				this.GridDashboardItem1.ShowCaption = true;
				//
				//PivotDashboardItem1
				//
				this.PivotDashboardItem1.AutoExpandRowGroups = true;
				Dimension8.DataMember = "dtInsert_dt";
				Dimension8.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.PivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension8});
				this.PivotDashboardItem1.ComponentName = "PivotDashboardItem1";
				Dimension9.DataMember = "item_desc";
				Measure2.DataMember = "qty";
				Dimension10.DataMember = "location";
				Dimension10.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				Dimension11.DataMember = "dtInsert_dt";
				Dimension11.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				this.PivotDashboardItem1.DataItemRepository.Clear();
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension9, "DataItem0");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem1");
				this.PivotDashboardItem1.DataItemRepository.Add(Measure2, "DataItem2");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension10, "DataItem3");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension11, "DataItem4");
				this.PivotDashboardItem1.DataSource = this.DataSource1;
				this.PivotDashboardItem1.FilterString = "[DataItem4] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem1.IgnoreMasterFilters = false;
				this.PivotDashboardItem1.Name = "Transferred Total per Item";
				this.PivotDashboardItem1.NamesRepository.Clear();
				this.PivotDashboardItem1.NamesRepository.Add(Measure2, "qty (Sum)");
				this.PivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension9, Dimension10, Dimension11});
				this.PivotDashboardItem1.ShowCaption = true;
				this.PivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure2});
				//
				//PivotDashboardItem2
				//
				this.PivotDashboardItem2.AutoExpandRowGroups = true;
				Dimension12.DataMember = "dtInsert_dt";
				Dimension12.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.PivotDashboardItem2.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension12});
				this.PivotDashboardItem2.ComponentName = "PivotDashboardItem2";
				Dimension13.DataMember = "location";
				Dimension14.DataMember = "item_desc";
				Measure3.DataMember = "qty";
				Dimension15.DataMember = "dtInsert_dt";
				Dimension15.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				this.PivotDashboardItem2.DataItemRepository.Clear();
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension13, "DataItem0");
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension14, "DataItem1");
				this.PivotDashboardItem2.DataItemRepository.Add(Measure3, "DataItem2");
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension15, "DataItem3");
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension12, "DataItem4");
				this.PivotDashboardItem2.DataSource = this.DataSource1;
				this.PivotDashboardItem2.FilterString = "[DataItem3] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem2.IgnoreMasterFilters = false;
				this.PivotDashboardItem2.Name = "Transferred Total per Location";
				this.PivotDashboardItem2.NamesRepository.Clear();
				this.PivotDashboardItem2.NamesRepository.Add(Measure3, "Qty");
				this.PivotDashboardItem2.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension13, Dimension14, Dimension15});
				this.PivotDashboardItem2.ShowCaption = true;
				this.PivotDashboardItem2.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure3});
				//
				//DBTransfer
				//
				DataConnection1.Name = "DOORSCOMPUTERS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.DataSource1});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.ChartDashboardItem1, this.GridDashboardItem1, this.PivotDashboardItem1, this.PivotDashboardItem2});
				DashboardLayoutItem1.DashboardItem = this.ChartDashboardItem1;
				DashboardLayoutItem1.Weight = 49.769585253456221D;
				DashboardLayoutItem2.DashboardItem = this.GridDashboardItem1;
				DashboardLayoutItem2.Weight = 50.230414746543779D;
				DashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutItem2});
				DashboardLayoutGroup2.Weight = 49.901380670611438D;
				DashboardLayoutItem3.DashboardItem = this.PivotDashboardItem1;
				DashboardLayoutItem3.Weight = 49.923195084485407D;
				DashboardLayoutItem4.DashboardItem = this.PivotDashboardItem2;
				DashboardLayoutItem4.Weight = 50.076804915514593D;
				DashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem3, DashboardLayoutItem4});
				DashboardLayoutGroup3.Weight = 50.098619329388562D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutGroup2, DashboardLayoutGroup3});
				DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				this.LayoutRoot = DashboardLayoutGroup1;
				DashboardParameter1.Name = "DateFrom";
				DashboardParameter1.Type = typeof(DateTime);
				DashboardParameter1.Value = new DateTime(2014, 2, 4, 8, 54, 17, 0);
				DashboardParameter2.Name = "DateTo";
				DashboardParameter2.Type = typeof(DateTime);
				DashboardParameter2.Value = new DateTime(2014, 2, 4, 8, 54, 11, 0);
				this.Parameters.AddRange(new DevExpress.DashboardCommon.DashboardParameter[] {DashboardParameter1, DashboardParameter2});
				this.Title.Text = "Dashboard";
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).EndInit();
				((System.ComponentModel.ISupportInitialize) this.GridDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension12).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension13).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension14).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension15).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem2).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.DataSource DataSource1;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem1;
			internal DevExpress.DashboardCommon.GridDashboardItem GridDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem2;
			
#endregion
		}
	}
}
