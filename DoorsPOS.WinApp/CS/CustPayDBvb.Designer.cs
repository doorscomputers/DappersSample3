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
		public partial class CustPayDBvb
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
				DevExpress.DashboardCommon.CalculatedField CalculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustPayDBvb));
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
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn5 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension11 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn6 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension12 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn7 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension13 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn8 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension14 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn9 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension15 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn10 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension16 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn11 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension17 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn12 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension18 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn13 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension19 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn14 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension20 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn15 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension21 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension22 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure3 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension23 = new DevExpress.DashboardCommon.Dimension();
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
				this.PieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
				this.GridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
				this.GridDashboardItem2 = new DevExpress.DashboardCommon.GridDashboardItem();
				this.PivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PieDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.GridDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension12).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension13).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.GridDashboardItem2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension14).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension15).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension16).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension17).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension18).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension19).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension20).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension21).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension22).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension23).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//ChartDashboardItem1
				//
				Dimension1.DataMember = "PayDate";
				Dimension2.DataMember = "PayDate";
				Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.ChartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension1, Dimension2});
				this.ChartDashboardItem1.AxisX.TitleVisible = false;
				this.ChartDashboardItem1.ComponentName = "ChartDashboardItem1";
				Measure1.DataMember = "Amount";
				Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure1.NumericFormat.IncludeGroupSeparator = true;
				Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension3.DataMember = "PayDate";
				Dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.ChartDashboardItem1.DataItemRepository.Clear();
				this.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem2");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem3");
				this.ChartDashboardItem1.DataSource = this.DataSource1;
				this.ChartDashboardItem1.IgnoreMasterFilters = false;
				this.ChartDashboardItem1.Name = "Monthly Payments Chart";
				ChartPane1.Name = "Pane 1";
				ChartPane1.PrimaryAxisY.ShowGridLines = true;
				ChartPane1.PrimaryAxisY.TitleVisible = true;
				ChartPane1.SecondaryAxisY.ShowGridLines = false;
				ChartPane1.SecondaryAxisY.TitleVisible = true;
				SimpleSeries1.Name = "Amount (Sum)";
				SimpleSeries1.AddDataItem("Value", Measure1);
				ChartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries1});
				this.ChartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane1});
				this.ChartDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension3});
				this.ChartDashboardItem1.ShowCaption = true;
				//
				//DataSource1
				//
				CalculatedField1.Expression = "[lastname] + \',\'+[firstname]+\', \'+[middlename]";
				CalculatedField1.Name = "Customer";
				this.DataSource1.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {CalculatedField1});
				this.DataSource1.ComponentName = "DataSource1";
				this.DataSource1.DataProviderSerializable = resources.GetString("DataSource1.DataProviderSerializable");
				this.DataSource1.Filter = "";
				this.DataSource1.Name = "dsCustPay";
				//
				//PieDashboardItem1
				//
				Dimension4.DataMember = "PayDate";
				Dimension4.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.QuarterYear;
				this.PieDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension4});
				this.PieDashboardItem1.ComponentName = "PieDashboardItem1";
				Measure2.DataMember = "Amount";
				Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure2.NumericFormat.IncludeGroupSeparator = true;
				Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension5.DataMember = "PayDate";
				this.PieDashboardItem1.DataItemRepository.Clear();
				this.PieDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0");
				this.PieDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem1");
				this.PieDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem2");
				this.PieDashboardItem1.DataSource = this.DataSource1;
				this.PieDashboardItem1.IgnoreMasterFilters = false;
				this.PieDashboardItem1.Name = "Quarterly Payments Pie Chart";
				this.PieDashboardItem1.NamesRepository.Clear();
				this.PieDashboardItem1.NamesRepository.Add(Measure2, "Amount");
				this.PieDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension5});
				this.PieDashboardItem1.ShowCaption = true;
				this.PieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure2});
				//
				//GridDashboardItem1
				//
				Dimension6.DataMember = "lastname";
				GridDimensionColumn1.Name = "Lastname";
				GridDimensionColumn1.AddDataItem("Dimension", Dimension6);
				Dimension7.DataMember = "firstname";
				GridDimensionColumn2.Name = "Firstname";
				GridDimensionColumn2.AddDataItem("Dimension", Dimension7);
				Dimension8.DataMember = "middlename";
				GridDimensionColumn3.Name = "Middlename";
				GridDimensionColumn3.AddDataItem("Dimension", Dimension8);
				Dimension9.DataMember = "PayDate";
				GridDimensionColumn4.Name = "Year";
				GridDimensionColumn4.AddDataItem("Dimension", Dimension9);
				Dimension10.DataMember = "PayDate";
				Dimension10.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				GridDimensionColumn5.Name = "Month-Year";
				GridDimensionColumn5.AddDataItem("Dimension", Dimension10);
				Dimension11.DataMember = "PayDate";
				Dimension11.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
				GridDimensionColumn6.Name = "Day-Month-Year";
				GridDimensionColumn6.AddDataItem("Dimension", Dimension11);
				Dimension12.DataMember = "Amount";
				GridDimensionColumn7.Name = "Amount";
				GridDimensionColumn7.AddDataItem("Dimension", Dimension12);
				Dimension13.DataMember = "sInsert_id";
				GridDimensionColumn8.Name = "sInsert_id";
				GridDimensionColumn8.AddDataItem("Dimension", Dimension13);
				this.GridDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {GridDimensionColumn1, GridDimensionColumn2, GridDimensionColumn3, GridDimensionColumn4, GridDimensionColumn5, GridDimensionColumn6, GridDimensionColumn7, GridDimensionColumn8});
				this.GridDashboardItem1.ComponentName = "GridDashboardItem1";
				this.GridDashboardItem1.DataItemRepository.Clear();
				this.GridDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem0");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem1");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem2");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension9, "DataItem3");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension10, "DataItem4");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension12, "DataItem5");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension11, "DataItem6");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension13, "DataItem7");
				this.GridDashboardItem1.DataSource = this.DataSource1;
				this.GridDashboardItem1.FilterString = "";
				this.GridDashboardItem1.IgnoreMasterFilters = false;
				this.GridDashboardItem1.Name = "Daily Payments";
				this.GridDashboardItem1.ShowCaption = true;
				//
				//GridDashboardItem2
				//
				Dimension14.DataMember = "lastname";
				GridDimensionColumn9.Name = "Lastname";
				GridDimensionColumn9.AddDataItem("Dimension", Dimension14);
				Dimension15.DataMember = "firstname";
				GridDimensionColumn10.Name = "Firstname";
				GridDimensionColumn10.AddDataItem("Dimension", Dimension15);
				Dimension16.DataMember = "middlename";
				GridDimensionColumn11.Name = "Middlename";
				GridDimensionColumn11.AddDataItem("Dimension", Dimension16);
				Dimension17.DataMember = "PayDate";
				GridDimensionColumn12.Name = "Year";
				GridDimensionColumn12.AddDataItem("Dimension", Dimension17);
				Dimension18.DataMember = "PayDate";
				Dimension18.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				GridDimensionColumn13.Name = "Month-Year";
				GridDimensionColumn13.AddDataItem("Dimension", Dimension18);
				Dimension19.DataMember = "Amount";
				GridDimensionColumn14.Name = "Amount";
				GridDimensionColumn14.AddDataItem("Dimension", Dimension19);
				Dimension20.DataMember = "sInsert_id";
				GridDimensionColumn15.Name = "sInsert_id";
				GridDimensionColumn15.AddDataItem("Dimension", Dimension20);
				this.GridDashboardItem2.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {GridDimensionColumn9, GridDimensionColumn10, GridDimensionColumn11, GridDimensionColumn12, GridDimensionColumn13, GridDimensionColumn14, GridDimensionColumn15});
				this.GridDashboardItem2.ComponentName = "GridDashboardItem2";
				this.GridDashboardItem2.DataItemRepository.Clear();
				this.GridDashboardItem2.DataItemRepository.Add(Dimension14, "DataItem0");
				this.GridDashboardItem2.DataItemRepository.Add(Dimension15, "DataItem1");
				this.GridDashboardItem2.DataItemRepository.Add(Dimension16, "DataItem2");
				this.GridDashboardItem2.DataItemRepository.Add(Dimension17, "DataItem3");
				this.GridDashboardItem2.DataItemRepository.Add(Dimension18, "DataItem4");
				this.GridDashboardItem2.DataItemRepository.Add(Dimension19, "DataItem5");
				this.GridDashboardItem2.DataItemRepository.Add(Dimension20, "DataItem6");
				this.GridDashboardItem2.DataSource = this.DataSource1;
				this.GridDashboardItem2.FilterString = "";
				this.GridDashboardItem2.IgnoreMasterFilters = false;
				this.GridDashboardItem2.Name = "Monthly Payments";
				this.GridDashboardItem2.ShowCaption = true;
				//
				//PivotDashboardItem1
				//
				Dimension21.DataMember = "PayDate";
				Dimension22.DataMember = "PayDate";
				Dimension22.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.PivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension21, Dimension22});
				this.PivotDashboardItem1.ComponentName = "PivotDashboardItem1";
				Measure3.DataMember = "Amount";
				Dimension23.DataMember = "Customer";
				this.PivotDashboardItem1.DataItemRepository.Clear();
				this.PivotDashboardItem1.DataItemRepository.Add(Measure3, "DataItem0");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension23, "DataItem1");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension21, "DataItem4");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension22, "DataItem5");
				this.PivotDashboardItem1.DataSource = this.DataSource1;
				this.PivotDashboardItem1.FilterString = "";
				this.PivotDashboardItem1.IgnoreMasterFilters = false;
				this.PivotDashboardItem1.Name = "Monthly Total Payments per Customer";
				this.PivotDashboardItem1.NamesRepository.Clear();
				this.PivotDashboardItem1.NamesRepository.Add(Measure3, "Amount");
				this.PivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension23});
				this.PivotDashboardItem1.ShowCaption = true;
				this.PivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure3});
				//
				//CustPayDBvb
				//
				DataConnection1.Name = "DOORSCOMPUTERS\\SQLEXPRESS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.DataSource1});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.ChartDashboardItem1, this.PieDashboardItem1, this.GridDashboardItem1, this.PivotDashboardItem1, this.GridDashboardItem2});
				DashboardLayoutItem1.DashboardItem = this.ChartDashboardItem1;
				DashboardLayoutItem1.Weight = 49.397590361445786D;
				DashboardLayoutItem2.DashboardItem = this.PieDashboardItem1;
				DashboardLayoutItem2.Weight = 50.602409638554214D;
				DashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutItem2});
				DashboardLayoutGroup2.Weight = 49.901380670611438D;
				DashboardLayoutItem3.DashboardItem = this.GridDashboardItem1;
				DashboardLayoutItem3.Weight = 37.80120481927711D;
				DashboardLayoutItem4.DashboardItem = this.GridDashboardItem2;
				DashboardLayoutItem4.Weight = 33.132530120481931D;
				DashboardLayoutItem5.DashboardItem = this.PivotDashboardItem1;
				DashboardLayoutItem5.Weight = 29.066265060240966D;
				DashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem3, DashboardLayoutItem4, DashboardLayoutItem5});
				DashboardLayoutGroup3.Weight = 50.098619329388562D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutGroup2, DashboardLayoutGroup3});
				DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				this.LayoutRoot = DashboardLayoutGroup1;
				DashboardParameter1.Name = "DateFrom";
				DashboardParameter1.Type = typeof(DateTime);
				DashboardParameter1.Value = new DateTime(2014, 3, 10, 0, 0, 0, 0);
				DashboardParameter2.Name = "DateTo";
				DashboardParameter2.Type = typeof(DateTime);
				DashboardParameter2.Value = new DateTime(2099, 12, 31, 0, 0, 0, 0);
				this.Parameters.AddRange(new DevExpress.DashboardCommon.DashboardParameter[] {DashboardParameter1, DashboardParameter2});
				this.Title.Text = "Customer Payments Dashboard";
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PieDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension9).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension10).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension11).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension12).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension13).EndInit();
				((System.ComponentModel.ISupportInitialize) this.GridDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension14).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension15).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension16).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension17).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension18).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension19).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension20).EndInit();
				((System.ComponentModel.ISupportInitialize) this.GridDashboardItem2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension21).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension22).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure3).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension23).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.DataSource DataSource1;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem1;
			internal DevExpress.DashboardCommon.PieDashboardItem PieDashboardItem1;
			internal DevExpress.DashboardCommon.GridDashboardItem GridDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem1;
			internal DevExpress.DashboardCommon.GridDashboardItem GridDashboardItem2;
			
#endregion
		}
	}
}
