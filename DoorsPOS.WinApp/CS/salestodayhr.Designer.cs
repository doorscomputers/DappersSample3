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
		public partial class salestodayhr
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
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salestodayhr));
				DevExpress.DashboardCommon.Dimension Dimension3 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension4 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DataAccess.DataConnection DataConnection1 = new DevExpress.DataAccess.DataConnection();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.dataSource1 = new DevExpress.DashboardCommon.DataSource();
				this.pivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
				((System.ComponentModel.ISupportInitialize) this.chartDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.dataSource1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//chartDashboardItem1
				//
				Dimension1.DataMember = "dtInsert_dt";
				Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Day;
				this.chartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension1});
				this.chartDashboardItem1.AxisX.TitleVisible = false;
				this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
				Measure1.DataMember = "det_amnt";
				Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
				Measure1.NumericFormat.IncludeGroupSeparator = true;
				Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension2.DataMember = "dtInsert_dt";
				Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Hour;
				this.chartDashboardItem1.DataItemRepository.Clear();
				this.chartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0");
				this.chartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1");
				this.chartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem2");
				this.chartDashboardItem1.DataSource = this.dataSource1;
				this.chartDashboardItem1.IgnoreMasterFilters = false;
				this.chartDashboardItem1.Name = "Chart View";
				ChartPane1.Name = "Pane 1";
				ChartPane1.PrimaryAxisY.ShowGridLines = true;
				ChartPane1.PrimaryAxisY.TitleVisible = true;
				ChartPane1.SecondaryAxisY.ShowGridLines = false;
				ChartPane1.SecondaryAxisY.TitleVisible = true;
				SimpleSeries1.Name = "det_amnt (Sum)";
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
				this.dataSource1.Name = "Data Source 4";
				//
				//pivotDashboardItem1
				//
				Dimension3.DataMember = "dtInsert_dt";
				Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				this.pivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension3});
				this.pivotDashboardItem1.ComponentName = "pivotDashboardItem1";
				Dimension4.DataMember = "dtInsert_dt";
				Dimension4.DateTimeFormat.DateHourFormat = DevExpress.DashboardCommon.DateTimeFormat.TimeOnly;
				Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DateHour;
				Measure2.DataMember = "det_amnt";
				Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
				Measure2.NumericFormat.IncludeGroupSeparator = true;
				Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				this.pivotDashboardItem1.DataItemRepository.Clear();
				this.pivotDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem0");
				this.pivotDashboardItem1.DataItemRepository.Add(Measure2, "DataItem1");
				this.pivotDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem2");
				this.pivotDashboardItem1.DataSource = this.dataSource1;
				this.pivotDashboardItem1.IgnoreMasterFilters = false;
				this.pivotDashboardItem1.Name = "Sales Per Hour";
				this.pivotDashboardItem1.NamesRepository.Clear();
				this.pivotDashboardItem1.NamesRepository.Add(Measure2, "det_amnt (Sum)");
				this.pivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension4});
				this.pivotDashboardItem1.ShowCaption = true;
				this.pivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure2});
				//
				//salestodayhr
				//
				DataConnection1.Name = "DOORSCOMPUTERS\\SQLEXPRESS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.dataSource1});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.chartDashboardItem1, this.pivotDashboardItem1});
				DashboardLayoutItem1.DashboardItem = this.chartDashboardItem1;
				DashboardLayoutItem1.Weight = 0.5D;
				DashboardLayoutItem2.DashboardItem = this.pivotDashboardItem1;
				DashboardLayoutItem2.Weight = 0.5D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutItem2});
				this.LayoutRoot = DashboardLayoutGroup1;
				this.Title.Text = "Dashboard";
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.chartDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.dataSource1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.pivotDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
			internal DevExpress.DashboardCommon.DataSource dataSource1;
			internal DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem1;
			
#endregion
		}
	}
}