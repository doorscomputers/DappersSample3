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
		public partial class DashboardPdSup
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
				DevExpress.DashboardCommon.ChartPane ChartPane1 = new DevExpress.DashboardCommon.ChartPane();
				DevExpress.DashboardCommon.SimpleSeries SimpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPdSup));
				DevExpress.DashboardCommon.Dimension Dimension3 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension4 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure3 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure4 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Dimension Dimension5 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension6 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.ChartPane ChartPane2 = new DevExpress.DashboardCommon.ChartPane();
				DevExpress.DashboardCommon.SimpleSeries SimpleSeries2 = new DevExpress.DashboardCommon.SimpleSeries();
				DevExpress.DashboardCommon.Dimension Dimension7 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Dimension Dimension8 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.Measure Measure5 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.Measure Measure6 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DataAccess.DataConnection DataConnection1 = new DevExpress.DataAccess.DataConnection();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				this.ChartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.DataSource2 = new DevExpress.DashboardCommon.DataSource();
				this.PieDashboardItem1 = new DevExpress.DashboardCommon.PieDashboardItem();
				this.ChartDashboardItem2 = new DevExpress.DashboardCommon.ChartDashboardItem();
				this.PivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
				this.DsInvPay1 = new DoorsPOS.WinApp.dsInvPay();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PieDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure3).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure4).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure5).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure6).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DsInvPay1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//ChartDashboardItem1
				//
				this.ChartDashboardItem1.AxisX.TitleVisible = false;
				this.ChartDashboardItem1.ComponentName = "ChartDashboardItem1";
				Measure1.DataMember = "amnt";
				Measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure1.NumericFormat.IncludeGroupSeparator = true;
				Measure1.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension1.DataMember = "supplier";
				Dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				Dimension2.DataMember = "paydate";
				Dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.ChartDashboardItem1.DataItemRepository.Clear();
				this.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem2");
				this.ChartDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem1");
				this.ChartDashboardItem1.DataSource = this.DataSource2;
				this.ChartDashboardItem1.IgnoreMasterFilters = false;
				this.ChartDashboardItem1.Name = "Monthly Payments";
				ChartPane1.Name = "Pane 1";
				ChartPane1.PrimaryAxisY.ShowGridLines = true;
				ChartPane1.PrimaryAxisY.Title = "Total Amount";
				ChartPane1.PrimaryAxisY.TitleVisible = true;
				ChartPane1.SecondaryAxisY.ShowGridLines = false;
				ChartPane1.SecondaryAxisY.TitleVisible = true;
				SimpleSeries1.Name = "amntpaid (Sum)";
				SimpleSeries1.AddDataItem("Value", Measure1);
				ChartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries1});
				this.ChartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane1});
				this.ChartDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension2, Dimension1});
				this.ChartDashboardItem1.ShowCaption = true;
				//
				//DataSource2
				//
				this.DataSource2.ComponentName = "DataSource2";
				this.DataSource2.DataProviderSerializable = resources.GetString("DataSource2.DataProviderSerializable");
				this.DataSource2.Name = "DataSource20";
				//
				//PieDashboardItem1
				//
				Dimension3.DataMember = "supplier";
				this.PieDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension3});
				this.PieDashboardItem1.ComponentName = "PieDashboardItem1";
				Measure2.DataMember = "amnt";
				Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure2.NumericFormat.IncludeGroupSeparator = true;
				Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension4.DataMember = "paydate";
				this.PieDashboardItem1.DataItemRepository.Clear();
				this.PieDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem0");
				this.PieDashboardItem1.DataItemRepository.Add(Measure2, "DataItem1");
				this.PieDashboardItem1.DataItemRepository.Add(Dimension4, "DataItem2");
				this.PieDashboardItem1.DataSource = this.DataSource2;
				this.PieDashboardItem1.IgnoreMasterFilters = false;
				this.PieDashboardItem1.Name = "Annual ";
				Measure3.DataMember = "amntpaid";
				Measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure3.NumericFormat.IncludeGroupSeparator = true;
				Measure3.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				this.PieDashboardItem1.NamesRepository.Clear();
				this.PieDashboardItem1.NamesRepository.Add(Measure3, "Total Amount Paid");
				this.PieDashboardItem1.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension4});
				this.PieDashboardItem1.ShowCaption = true;
				this.PieDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure2});
				//
				//ChartDashboardItem2
				//
				this.ChartDashboardItem2.AxisX.TitleVisible = false;
				this.ChartDashboardItem2.ComponentName = "ChartDashboardItem2";
				Measure4.DataMember = "amnt";
				Measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure4.NumericFormat.IncludeGroupSeparator = true;
				Measure4.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				Dimension5.DataMember = "paydate";
				Dimension6.DataMember = "supplier";
				Dimension6.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
				this.ChartDashboardItem2.DataItemRepository.Clear();
				this.ChartDashboardItem2.DataItemRepository.Add(Measure4, "DataItem0");
				this.ChartDashboardItem2.DataItemRepository.Add(Dimension5, "DataItem1");
				this.ChartDashboardItem2.DataItemRepository.Add(Dimension6, "DataItem2");
				this.ChartDashboardItem2.DataSource = this.DataSource2;
				this.ChartDashboardItem2.IgnoreMasterFilters = false;
				this.ChartDashboardItem2.Name = "Annual Payments";
				ChartPane2.Name = "Pane 1";
				ChartPane2.PrimaryAxisY.ShowGridLines = true;
				ChartPane2.PrimaryAxisY.Title = "Total Amount";
				ChartPane2.PrimaryAxisY.TitleVisible = true;
				ChartPane2.SecondaryAxisY.ShowGridLines = false;
				ChartPane2.SecondaryAxisY.TitleVisible = true;
				SimpleSeries2.Name = "amntpaid (Sum)";
				SimpleSeries2.AddDataItem("Value", Measure4);
				ChartPane2.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {SimpleSeries2});
				this.ChartDashboardItem2.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {ChartPane2});
				this.ChartDashboardItem2.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension5, Dimension6});
				this.ChartDashboardItem2.ShowCaption = true;
				//
				//PivotDashboardItem1
				//
				Dimension7.DataMember = "paydate";
				Dimension7.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
				this.PivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension7});
				this.PivotDashboardItem1.ComponentName = "PivotDashboardItem1";
				Dimension8.DataMember = "supplier";
				Measure5.DataMember = "amnt";
				Measure5.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure5.NumericFormat.IncludeGroupSeparator = true;
				Measure5.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				this.PivotDashboardItem1.DataItemRepository.Clear();
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem0");
				this.PivotDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem1");
				this.PivotDashboardItem1.DataItemRepository.Add(Measure5, "DataItem2");
				this.PivotDashboardItem1.DataSource = this.DataSource2;
				this.PivotDashboardItem1.IgnoreMasterFilters = false;
				this.PivotDashboardItem1.Name = "Payment Summary";
				Measure6.DataMember = "amntpaid";
				Measure6.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure6.NumericFormat.IncludeGroupSeparator = true;
				Measure6.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				this.PivotDashboardItem1.NamesRepository.Clear();
				this.PivotDashboardItem1.NamesRepository.Add(Measure6, "Amount Paid");
				this.PivotDashboardItem1.NamesRepository.Add(Measure5, "Total Amount");
				this.PivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {Dimension8});
				this.PivotDashboardItem1.ShowCaption = true;
				this.PivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {Measure5});
				//
				//DsInvPay1
				//
				this.DsInvPay1.DataSetName = "dsInvPay";
				this.DsInvPay1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
				//
				//DashboardPdSup
				//
				DataConnection1.Name = "DOORSCOMPUTERS\\SQLEXPRESS_doorsposConnection";
				DataConnection1.ParametersSerializable = resources.GetString("DataConnection1.ParametersSerializable");
				DataConnection1.ProviderKey = "MSSqlServer";
				this.DataConnections.Add(DataConnection1);
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.DataSource2});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.ChartDashboardItem1, this.ChartDashboardItem2, this.PieDashboardItem1, this.PivotDashboardItem1});
				DashboardLayoutItem1.DashboardItem = this.ChartDashboardItem1;
				DashboardLayoutItem1.Weight = 0.25D;
				DashboardLayoutItem2.DashboardItem = this.PieDashboardItem1;
				DashboardLayoutItem2.Weight = 0.25D;
				DashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1, DashboardLayoutItem2});
				DashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				DashboardLayoutGroup2.Weight = 0.25D;
				DashboardLayoutItem3.DashboardItem = this.ChartDashboardItem2;
				DashboardLayoutItem3.Weight = 0.25D;
				DashboardLayoutItem4.DashboardItem = this.PivotDashboardItem1;
				DashboardLayoutItem4.Weight = 0.25D;
				DashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem3, DashboardLayoutItem4});
				DashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				DashboardLayoutGroup3.Weight = 0.25D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutGroup2, DashboardLayoutGroup3});
				this.LayoutRoot = DashboardLayoutGroup1;
				this.Title.Text = "Monthly and Annual Payments to Suppliers";
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension3).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension4).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure3).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PieDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure4).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension5).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension6).EndInit();
				((System.ComponentModel.ISupportInitialize) this.ChartDashboardItem2).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension7).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension8).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure5).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure6).EndInit();
				((System.ComponentModel.ISupportInitialize) this.PivotDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DsInvPay1).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DoorsPOS.WinApp.dsInvPay DsInvPay1;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem1;
			internal DevExpress.DashboardCommon.DataSource DataSource2;
			internal DevExpress.DashboardCommon.ChartDashboardItem ChartDashboardItem2;
			internal DevExpress.DashboardCommon.PieDashboardItem PieDashboardItem1;
			internal DevExpress.DashboardCommon.PivotDashboardItem PivotDashboardItem1;
			
#endregion
		}
	}
}
