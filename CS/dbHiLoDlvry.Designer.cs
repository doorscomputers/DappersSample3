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
		public partial class dbHiLoDlvry
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
				DevExpress.DashboardCommon.Dimension Dimension2 = new DevExpress.DashboardCommon.Dimension();
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dbHiLoDlvry));
				DevExpress.DashboardCommon.Dimension Dimension3 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension4 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension5 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension6 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure3 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension7 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension8 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure4 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension9 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension10 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure5 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension11 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DataAccess.DataConnection DataConnection1 = new DevExpress.DataAccess.DataConnection();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup4 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem5 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter1 = new DevExpress.DashboardCommon.DashboardParameter();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter2 = new DevExpress.DashboardCommon.DashboardParameter();
				this.PivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.DataSource1 = new DevExpress.DashboardCommon.DataSource();
				this.PivotDashboardItem2 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem3 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem4 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.PivotDashboardItem5 = new DevExpress.DashboardCommon.PivotDashboardItem();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//PivotDashboardItem1
				//
				this.PivotDashboardItem1.AutoExpandRowGroups = true;
				this.PivotDashboardItem1.ComponentName = "PivotDashboardItem1";
				Measure1.DataMember = "qty";
				Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure1.NumericFormat.IncludeGroupSeparator = true;
				Measure1.NumericFormat.Precision = 0;
				Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension1.DataMember = "item_desc";
				Dimension1.SortByMeasureName = "DataItem0";
				Dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				Dimension2.DataMember = "dtInsert_dt";
				Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				this.PivotDashboardItem1.DataItemRepository.Clear();
				this.PivotDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem2");
				this.PivotDashboardItem1.DataSource = this.DataSource1;
				this.PivotDashboardItem1.FilterString = "[DataItem2] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem1.IgnoreMasterFilters = false;
				this.PivotDashboardItem1.Name = "Deliveries per Day";
				this.PivotDashboardItem1.NamesRepository.Clear();
				this.PivotDashboardItem1.NamesRepository.Add(Measure1, "Qty Delivered");
				this.PivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension1, Dimension2});
				this.PivotDashboardItem1.ShowCaption = true;
				this.PivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure1});
				//
				//DataSource1
				//
				this.DataSource1.ComponentName = "DataSource1";
				this.DataSource1.DataProviderSerializable = resources.GetString("DataSource1.DataProviderSerializable");
				this.DataSource1.Filter = "";
				this.DataSource1.Name = "dsHiLoDlvry";
				//
				//PivotDashboardItem2
				//
				this.PivotDashboardItem2.AutoExpandRowGroups = true;
				Dimension3.DataMember = "dtInsert_dt";
				Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.PivotDashboardItem2.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension3});
				this.PivotDashboardItem2.ComponentName = "PivotDashboardItem2";
				Measure2.DataMember = "qty";
				Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure2.NumericFormat.IncludeGroupSeparator = true;
				Measure2.NumericFormat.Precision = 0;
				Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension4.DataMember = "dtInsert_dt";
				Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.WeekOfMonth;
				Dimension5.DataMember = "item_desc";
				Dimension5.SortByMeasureName = "DataItem0";
				Dimension5.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.PivotDashboardItem2.DataItemRepository.Clear();
				this.PivotDashboardItem2.DataItemRepository.Add(Measure2, "DataItem0");
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension3, "DataItem1");
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension4, "DataItem2");
				this.PivotDashboardItem2.DataItemRepository.Add(Dimension5, "DataItem3");
				this.PivotDashboardItem2.DataSource = this.DataSource1;
				this.PivotDashboardItem2.FilterString = "[DataItem1] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem2.IgnoreMasterFilters = false;
				this.PivotDashboardItem2.Name = "Deliveries per Week";
				this.PivotDashboardItem2.NamesRepository.Clear();
				this.PivotDashboardItem2.NamesRepository.Add(Measure2, "Qty Delivered");
				this.PivotDashboardItem2.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension5, Dimension4});
				this.PivotDashboardItem2.ShowCaption = true;
				this.PivotDashboardItem2.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure2});
				//
				//PivotDashboardItem3
				//
				this.PivotDashboardItem3.AutoExpandRowGroups = true;
				Dimension6.DataMember = "dtInsert_dt";
				Dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.PivotDashboardItem3.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension6});
				this.PivotDashboardItem3.ComponentName = "PivotDashboardItem3";
				Measure3.DataMember = "qty";
				Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure3.NumericFormat.IncludeGroupSeparator = true;
				Measure3.NumericFormat.Precision = 0;
				Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension7.DataMember = "item_desc";
				Dimension7.SortByMeasureName = "DataItem0";
				Dimension7.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.PivotDashboardItem3.DataItemRepository.Clear();
				this.PivotDashboardItem3.DataItemRepository.Add(Measure3, "DataItem0");
				this.PivotDashboardItem3.DataItemRepository.Add(Dimension7, "DataItem1");
				this.PivotDashboardItem3.DataItemRepository.Add(Dimension6, "DataItem2");
				this.PivotDashboardItem3.DataSource = this.DataSource1;
				this.PivotDashboardItem3.FilterString = "[DataItem2] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem3.IgnoreMasterFilters = false;
				this.PivotDashboardItem3.Name = "Deliveries per Month";
				this.PivotDashboardItem3.NamesRepository.Clear();
				this.PivotDashboardItem3.NamesRepository.Add(Measure3, "Qty Delivered");
				this.PivotDashboardItem3.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension7});
				this.PivotDashboardItem3.ShowCaption = true;
				this.PivotDashboardItem3.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure3});
				//
				//PivotDashboardItem4
				//
				this.PivotDashboardItem4.AutoExpandRowGroups = true;
				Dimension8.DataMember = "dtInsert_dt";
				Dimension8.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.QuarterYear;
				this.PivotDashboardItem4.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension8});
				this.PivotDashboardItem4.ComponentName = "PivotDashboardItem4";
				Measure4.DataMember = "qty";
				Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure4.NumericFormat.IncludeGroupSeparator = true;
				Measure4.NumericFormat.Precision = 0;
				Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension9.DataMember = "item_desc";
				Dimension9.SortByMeasureName = "DataItem0";
				Dimension9.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.PivotDashboardItem4.DataItemRepository.Clear();
				this.PivotDashboardItem4.DataItemRepository.Add(Measure4, "DataItem0");
				this.PivotDashboardItem4.DataItemRepository.Add(Dimension9, "DataItem1");
				this.PivotDashboardItem4.DataItemRepository.Add(Dimension8, "DataItem2");
				this.PivotDashboardItem4.DataSource = this.DataSource1;
				this.PivotDashboardItem4.FilterString = "[DataItem2] Between(?DateFrom, ?DateTo)";
				this.PivotDashboardItem4.IgnoreMasterFilters = false;
				this.PivotDashboardItem4.Name = "Deliveries per Qtr";
				this.PivotDashboardItem4.NamesRepository.Clear();
				this.PivotDashboardItem4.NamesRepository.Add(Measure4, "Qty Delivered");
				this.PivotDashboardItem4.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension9});
				this.PivotDashboardItem4.ShowCaption = true;
				this.PivotDashboardItem4.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure4});
				//
				//PivotDashboardItem5
				//
				Dimension10.DataMember = "dtInsert_dt";
				this.PivotDashboardItem5.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension10});
				this.PivotDashboardItem5.ComponentName = "PivotDashboardItem5";
				Measure5.DataMember = "qty";
				Measure5.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure5.NumericFormat.IncludeGroupSeparator = true;
				Measure5.NumericFormat.Precision = 0;
				Measure5.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension11.DataMember = "item_desc";
				Dimension11.SortByMeasureName = "DataItem0";
				Dimension11.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.PivotDashboardItem5.DataItemRepository.Clear();
				this.PivotDashboardItem5.DataItemRepository.Add(Measure5, "DataItem0");
				this.PivotDashboardItem5.DataItemRepository.Add(Dimension11, "DataItem1");
				this.PivotDashboardItem5.DataItemRepository.Add(Dimension10, "DataItem2");
				this.PivotDashboardItem5.DataSource = this.DataSource1;
				this.PivotDashboardItem5.IgnoreMasterFilters = false;
				this.PivotDashboardItem5.Name = "Deliveries per Year";
				this.PivotDashboardItem5.NamesRepository.Clear();
				this.PivotDashboardItem5.NamesRepository.Add(Measure5, "Qty Delivered");
				this.PivotDashboardItem5.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension11});
				this.PivotDashboardItem5.ShowCaption = true;
				this.PivotDashboardItem5.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure5});
				//
				//dbHiLoDlvry
				//
				DataConnection1.Name = "DOORSCOMPUTERS\\SQLEXPRESS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.DataSource1});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.PivotDashboardItem1, this.PivotDashboardItem2, this.PivotDashboardItem3, this.PivotDashboardItem4, this.PivotDashboardItem5});
				DashboardLayoutItem1.DashboardItem = this.PivotDashboardItem1;
				DashboardLayoutItem1.Weight = 52.995391705069125D;
				DashboardLayoutItem2.DashboardItem = this.PivotDashboardItem2;
				DashboardLayoutItem2.Weight = 47.004608294930875D;
				DashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutItem2});
				DashboardLayoutGroup2.Weight = 49.901380670611438D;
				DashboardLayoutItem3.DashboardItem = this.PivotDashboardItem3;
				DashboardLayoutItem3.Weight = 53.456221198156683D;
				DashboardLayoutItem4.DashboardItem = this.PivotDashboardItem4;
				DashboardLayoutItem4.Weight = 46.543778801843317D;
				DashboardLayoutGroup4.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem3, DashboardLayoutItem4});
				DashboardLayoutGroup4.Weight = 50.0D;
				DashboardLayoutItem5.DashboardItem = this.PivotDashboardItem5;
				DashboardLayoutItem5.Weight = 50.0D;
				DashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutGroup4, DashboardLayoutItem5});
				DashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				DashboardLayoutGroup3.Weight = 50.098619329388562D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutGroup2, DashboardLayoutGroup3});
				DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				this.LayoutRoot = DashboardLayoutGroup1;
				DashboardParameter1.Name = "DateFrom";
				DashboardParameter1.Type = typeof(DateTime);
				DashboardParameter1.Value = new DateTime(2000, 2, 6, 19, 26, 0, 0);
				DashboardParameter2.Name = "DateTo";
				DashboardParameter2.Type = typeof(DateTime);
				DashboardParameter2.Value = new DateTime(2199, 2, 6, 19, 27, 0, 0);
				this.Parameters.AddRange(new DevExpress.DashboardCommon.DashboardParameter[] {DashboardParameter1, DashboardParameter2});
				this.Title.Text = "Deliveries per Item Dashboard";
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure4).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem4).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure5).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem5).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.DataSource DataSource1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem2;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem3;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem4;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem5;
			
#endregion
		}
	}
}
