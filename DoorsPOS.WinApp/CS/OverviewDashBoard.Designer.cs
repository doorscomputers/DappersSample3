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
		public partial class OverviewDashBoard
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
				DevExpress.DashboardCommon.ChartPane ChartPane1 = new DevExpress.DashboardCommon.ChartPane();
				DevExpress.DashboardCommon.SimpleSeries SimpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverviewDashBoard));
				DevExpress.DashboardCommon.Dimension Dimension2 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.ChartPane ChartPane2 = new DevExpress.DashboardCommon.ChartPane();
				DevExpress.DashboardCommon.SimpleSeries SimpleSeries2 = new DevExpress.DashboardCommon.SimpleSeries();
				DevExpress.DashboardCommon.Measure Measure3 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension3 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.ChartPane ChartPane3 = new DevExpress.DashboardCommon.ChartPane();
				DevExpress.DashboardCommon.SimpleSeries SimpleSeries3 = new DevExpress.DashboardCommon.SimpleSeries();
				DevExpress.DashboardCommon.Dimension Dimension4 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension5 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure4 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.ChartPane ChartPane4 = new DevExpress.DashboardCommon.ChartPane();
				DevExpress.DashboardCommon.SimpleSeries SimpleSeries4 = new DevExpress.DashboardCommon.SimpleSeries();
				DevExpress.DataAccess.DataConnection DataConnection1 = new DevExpress.DataAccess.DataConnection();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				this.ChartDashboardItem2 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.DataSource2 = new DevExpress.DashboardCommon.DataSource();
				this.ChartDashboardItem3 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.DataSource3 = new DevExpress.DashboardCommon.DataSource();
				this.ChartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.DataSource1 = new DevExpress.DashboardCommon.DataSource();
				this.ChartDashboardItem4 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.Dsinvpayvw1 = new DoorsPOS.WinApp.dsinvpayvw();
				this.DataSource5 = new DevExpress.DashboardCommon.DataSource();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource3).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure4).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.Dsinvpayvw1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource5).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//ChartDashboardItem2
				//
				this.ChartDashboardItem2.AxisX.TitleVisible = false;
				this.ChartDashboardItem2.ComponentName = "ChartDashboardItem2";
				Dimension1.DataMember = "drdate";
				Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				Measure1.DataMember = "dramnt";
				Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure1.NumericFormat.IncludeGroupSeparator = true;
				Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				this.ChartDashboardItem2.DataItemRepository.Clear();
				this.ChartDashboardItem2.DataItemRepository.Add(Dimension1, "DataItem0");
				this.ChartDashboardItem2.DataItemRepository.Add(Measure1, "DataItem1");
				this.ChartDashboardItem2.DataSource = this.DataSource2;
				this.ChartDashboardItem2.IgnoreMasterFilters = false;
				this.ChartDashboardItem2.InteractivityOptions.IsDrillDownEnabled = true;
				this.ChartDashboardItem2.Name = "Monthly Purchases";
				ChartPane1.Name = "Pane 1";
				ChartPane1.PrimaryAxisY.ShowGridLines = true;
				ChartPane1.PrimaryAxisY.Title = "Amount";
				ChartPane1.PrimaryAxisY.TitleVisible = true;
				ChartPane1.SecondaryAxisY.ShowGridLines = false;
				ChartPane1.SecondaryAxisY.TitleVisible = true;
				SimpleSeries1.Name = "dramnt (Sum)";
				SimpleSeries1.AddDataItem("Value", Measure1);
				ChartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries1});
				this.ChartDashboardItem2.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane1});
				this.ChartDashboardItem2.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension1});
				this.ChartDashboardItem2.ShowCaption = true;
				//
				//DataSource2
				//
				this.DataSource2.ComponentName = "DataSource2";
				this.DataSource2.DataProviderSerializable = resources.GetString("DataSource2.DataProviderSerializable");
				this.DataSource2.Name = "dstotalpurchases";
				//
				//ChartDashboardItem3
				//
				this.ChartDashboardItem3.AxisX.TitleVisible = false;
				this.ChartDashboardItem3.ComponentName = "ChartDashboardItem3";
				Dimension2.DataMember = "expdate";
				Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				Measure2.DataMember = "expamount";
				Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
				Measure2.NumericFormat.IncludeGroupSeparator = true;
				Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				this.ChartDashboardItem3.DataItemRepository.Clear();
				this.ChartDashboardItem3.DataItemRepository.Add(Dimension2, "DataItem0");
				this.ChartDashboardItem3.DataItemRepository.Add(Measure2, "DataItem1");
				this.ChartDashboardItem3.DataSource = this.DataSource3;
				this.ChartDashboardItem3.IgnoreMasterFilters = false;
				this.ChartDashboardItem3.Name = "Monthly Expenses";
				ChartPane2.Name = "Pane 1";
				ChartPane2.PrimaryAxisY.ShowGridLines = true;
				ChartPane2.PrimaryAxisY.Title = "Amount";
				ChartPane2.PrimaryAxisY.TitleVisible = true;
				ChartPane2.SecondaryAxisY.ShowGridLines = false;
				ChartPane2.SecondaryAxisY.TitleVisible = true;
				SimpleSeries2.Name = "expamount (Sum)";
				SimpleSeries2.AddDataItem("Value", Measure2);
				ChartPane2.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries2});
				this.ChartDashboardItem3.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane2});
				this.ChartDashboardItem3.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension2});
				this.ChartDashboardItem3.ShowCaption = true;
				//
				//DataSource3
				//
				this.DataSource3.ComponentName = "DataSource3";
				this.DataSource3.DataProviderSerializable = resources.GetString("DataSource3.DataProviderSerializable");
				this.DataSource3.Name = "dstotalexpenses";
				//
				//ChartDashboardItem1
				//
				this.ChartDashboardItem1.AxisX.TitleVisible = false;
				this.ChartDashboardItem1.ComponentName = "ChartDashboardItem1";
				Measure3.DataMember = "totsales";
				Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure3.NumericFormat.IncludeGroupSeparator = true;
				Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension3.DataMember = "pos_date";
				Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				Dimension3.SortByMeasureName = "DataItem0";
				Dimension3.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.ChartDashboardItem1.DataItemRepository.Clear();
				this.ChartDashboardItem1.DataItemRepository.Add(Measure3, "DataItem0");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem1");
				this.ChartDashboardItem1.DataSource = this.DataSource1;
				this.ChartDashboardItem1.IgnoreMasterFilters = false;
				this.ChartDashboardItem1.Name = "Monthly Sales";
				ChartPane3.Name = "Pane 1";
				ChartPane3.PrimaryAxisY.ShowGridLines = true;
				ChartPane3.PrimaryAxisY.Title = "Amount";
				ChartPane3.PrimaryAxisY.TitleVisible = true;
				ChartPane3.SecondaryAxisY.ShowGridLines = false;
				ChartPane3.SecondaryAxisY.TitleVisible = true;
				SimpleSeries3.Name = "totsales (Sum)";
				SimpleSeries3.AddDataItem("Value", Measure3);
				ChartPane3.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries3});
				this.ChartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane3});
				this.ChartDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension3});
				this.ChartDashboardItem1.ShowCaption = true;
				//
				//DataSource1
				//
				this.DataSource1.ComponentName = "DataSource1";
				this.DataSource1.DataProviderSerializable = resources.GetString("DataSource1.DataProviderSerializable");
				this.DataSource1.Name = "dstotalsales";
				//
				//ChartDashboardItem4
				//
				Dimension4.DataMember = "supplier";
				this.ChartDashboardItem4.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension4});
				this.ChartDashboardItem4.AxisX.TitleVisible = false;
				this.ChartDashboardItem4.ComponentName = "ChartDashboardItem4";
				Dimension5.DataMember = "paydate";
				Dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				Dimension5.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				Measure4.DataMember = "amnt";
				Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure4.NumericFormat.IncludeGroupSeparator = true;
				Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				this.ChartDashboardItem4.DataItemRepository.Clear();
				this.ChartDashboardItem4.DataItemRepository.Add(Dimension4, "DataItem2");
				this.ChartDashboardItem4.DataItemRepository.Add(Dimension5, "DataItem1");
				this.ChartDashboardItem4.DataItemRepository.Add(Measure4, "DataItem0");
				this.ChartDashboardItem4.DataSource = this.DataSource5;
				this.ChartDashboardItem4.IgnoreMasterFilters = false;
				this.ChartDashboardItem4.Name = "Monthly Payment to Suppliers";
				ChartPane4.Name = "Pane 1";
				ChartPane4.PrimaryAxisY.ShowGridLines = true;
				ChartPane4.PrimaryAxisY.Title = "Amount";
				ChartPane4.PrimaryAxisY.TitleVisible = true;
				ChartPane4.SecondaryAxisY.ShowGridLines = false;
				ChartPane4.SecondaryAxisY.TitleVisible = true;
				SimpleSeries4.Name = "amnt (Sum)";
				SimpleSeries4.AddDataItem("Value", Measure4);
				ChartPane4.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries4});
				this.ChartDashboardItem4.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane4});
				this.ChartDashboardItem4.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension5});
				this.ChartDashboardItem4.ShowCaption = true;
				//
				//Dsinvpayvw1
				//
				this.Dsinvpayvw1.DataSetName = "dsinvpayvw";
				this.Dsinvpayvw1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
				//
				//DataSource5
				//
				this.DataSource5.ComponentName = "DataSource5";
				this.DataSource5.DataProviderSerializable = resources.GetString("DataSource5.DataProviderSerializable");
				this.DataSource5.Name = "dsInvpd";
				//
				//OverviewDashBoard
				//
				DataConnection1.Name = "DOORSCOMPUTERS\\SQLEXPRESS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.DataSource1, this.DataSource2, this.DataSource3, this.DataSource5});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.ChartDashboardItem1, this.ChartDashboardItem2, this.ChartDashboardItem3, this.ChartDashboardItem4});
				DashboardLayoutItem1.DashboardItem = this.ChartDashboardItem2;
				DashboardLayoutItem1.Weight = 49.558638083228246D;
				DashboardLayoutItem2.DashboardItem = this.ChartDashboardItem3;
				DashboardLayoutItem2.Weight = 50.441361916771754D;
				DashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutItem2});
				DashboardLayoutGroup2.Weight = 49.90439770554493D;
				DashboardLayoutItem3.DashboardItem = this.ChartDashboardItem4;
				DashboardLayoutItem3.Weight = 49.936948297604033D;
				DashboardLayoutItem4.DashboardItem = this.ChartDashboardItem1;
				DashboardLayoutItem4.Weight = 50.063051702395967D;
				DashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem3, DashboardLayoutItem4});
				DashboardLayoutGroup3.Weight = 50.09560229445507D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutGroup2, DashboardLayoutGroup3});
				DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				this.LayoutRoot = DashboardLayoutGroup1;
				this.Title.Text = "Overview";
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem3).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource3).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure4).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem4).EndInit();
				((System.ComponentModel.ISupportInitialize) this.Dsinvpayvw1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource5).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.DataSource DataSource1;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem1;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem2;
			internal DevExpress.DashboardCommon.DataSource DataSource2;
			internal DevExpress.DashboardCommon.DataSource DataSource3;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem3;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem4;
			internal DevExpress.DashboardCommon.DataSource DataSource5;
			internal DoorsPOS.WinApp.dsinvpayvw Dsinvpayvw1;
			
#endregion
		}
	}
}
