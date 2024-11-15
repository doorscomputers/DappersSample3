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
		public partial class salestodaydb
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
				DevExpress.DashboardCommon.Dimension Dimension3 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.ChartPane ChartPane1 = new DevExpress.DashboardCommon.ChartPane();
				DevExpress.DashboardCommon.SimpleSeries SimpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension4 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension5 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure3 = new DevExpress.DashboardCommon.Measure();
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salestodaydb));
				DevExpress.DataAccess.DataConnection DataConnection1 = new DevExpress.DataAccess.DataConnection();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				this.ChartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.PivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.DataSource1 = new DevExpress.DashboardCommon.DataSource();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure3).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//ChartDashboardItem1
				//
				Dimension1.DataMember = "dtInsert_dt";
				Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Hour;
				this.ChartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension1});
				this.ChartDashboardItem1.AxisX.TitleVisible = false;
				this.ChartDashboardItem1.ComponentName = "ChartDashboardItem1";
				Measure1.DataMember = "totsales";
				Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure1.NumericFormat.IncludeGroupSeparator = true;
				Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension2.DataMember = "sInsert_id";
				Dimension3.DataMember = "dtInsert_dt";
				Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Hour;
				this.ChartDashboardItem1.DataItemRepository.Clear();
				this.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem3");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem2");
				this.ChartDashboardItem1.DataSource = this.DataSource1;
				this.ChartDashboardItem1.IgnoreMasterFilters = false;
				this.ChartDashboardItem1.Name = "Chart View";
				ChartPane1.Name = "Pane 1";
				ChartPane1.PrimaryAxisY.ShowGridLines = true;
				ChartPane1.PrimaryAxisY.Title = "Amount";
				ChartPane1.PrimaryAxisY.TitleVisible = true;
				ChartPane1.SecondaryAxisY.ShowGridLines = false;
				ChartPane1.SecondaryAxisY.TitleVisible = true;
				SimpleSeries1.Name = "Amount (Sum)";
				SimpleSeries1.AddDataItem("Value", Measure1);
				ChartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries1});
				this.ChartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane1});
				this.ChartDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension3, Dimension2});
				this.ChartDashboardItem1.ShowCaption = true;
				//
				//PivotDashboardItem1
				//
				this.PivotDashboardItem1.ComponentName = "PivotDashboardItem1";
				Measure2.DataMember = "totsales";
				Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure2.NumericFormat.IncludeGroupSeparator = true;
				Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension4.DataMember = "dtInsert_dt";
				Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DateHour;
				Dimension4.SortByMeasureName = "DataItem0";
				Dimension4.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				Dimension5.DataMember = "sInsert_id";
				this.PivotDashboardItem1.DataItemRepository.Clear();
				this.PivotDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem1");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem2");
				this.PivotDashboardItem1.DataSource = this.DataSource1;
				this.PivotDashboardItem1.IgnoreMasterFilters = false;
				this.PivotDashboardItem1.Name = "Grid View Sorted (Highest to Lowest)";
				Measure3.DataMember = "Amount";
				Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
				Measure3.NumericFormat.IncludeGroupSeparator = true;
				Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				this.PivotDashboardItem1.NamesRepository.Clear();
				this.PivotDashboardItem1.NamesRepository.Add(Measure3, "Amount");
				this.PivotDashboardItem1.NamesRepository.Add(Measure2, "Amount");
				this.PivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension4, Dimension5});
				this.PivotDashboardItem1.ShowCaption = true;
				this.PivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure2});
				//
				//DataSource1
				//
				this.DataSource1.ComponentName = "DataSource1";
				this.DataSource1.DataProviderSerializable = resources.GetString("DataSource1.DataProviderSerializable");
				this.DataSource1.Name = "dbsalestoday";
				//
				//salestodaydb
				//
				DataConnection1.Name = "DOORSCOMPUTERS\\SQLEXPRESS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.DataSource1});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.ChartDashboardItem1, this.PivotDashboardItem1});
				DashboardLayoutItem1.DashboardItem = this.ChartDashboardItem1;
				DashboardLayoutItem1.Weight = 100.0D;
				DashboardLayoutItem2.DashboardItem = this.PivotDashboardItem1;
				DashboardLayoutItem2.Weight = 100.0D;
				DashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutItem2});
				DashboardLayoutGroup2.Weight = 100.0D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutGroup2});
				DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				this.LayoutRoot = DashboardLayoutGroup1;
				this.Title.Text = "Sales per Hour";
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure3).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem1;
			internal DevExpress.DashboardCommon.DataSource DataSource1;
			
#endregion
		}
	}
}
