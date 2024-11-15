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
		public partial class SaleswithParam
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
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Dimension Dimension2 = new DevExpress.DashboardCommon.Dimension();
				DevExpress.DashboardCommon.GridDimensionColumn GridDimensionColumn2 = new DevExpress.DashboardCommon.GridDimensionColumn();
				DevExpress.DashboardCommon.Measure Measure1 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.GridMeasureColumn GridMeasureColumn1 = new DevExpress.DashboardCommon.GridMeasureColumn();
				DevExpress.DashboardCommon.Measure Measure2 = new DevExpress.DashboardCommon.Measure();
				DevExpress.DashboardCommon.GridMeasureColumn GridMeasureColumn2 = new DevExpress.DashboardCommon.GridMeasureColumn();
				DevExpress.DashboardCommon.DashboardLayoutGroup DashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
				DevExpress.DashboardCommon.DashboardLayoutItem DashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter1 = new DevExpress.DashboardCommon.DashboardParameter();
				DevExpress.DashboardCommon.DynamicListLookUpSettings DynamicListLookUpSettings1 = new DevExpress.DashboardCommon.DynamicListLookUpSettings();
				DevExpress.DashboardCommon.DashboardParameter DashboardParameter2 = new DevExpress.DashboardCommon.DashboardParameter();
				DevExpress.DashboardCommon.DynamicListLookUpSettings DynamicListLookUpSettings2 = new DevExpress.DashboardCommon.DynamicListLookUpSettings();
				this.GridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
				this.DataSource1 = new DevExpress.DashboardCommon.DataSource();
				this.DsSalesArchive1 = new DoorsPOS.WinApp.dsSalesArchive();
				((System.ComponentModel.ISupportInitialize) this.GridDashboardItem1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure1).BeginInit();
				((System.ComponentModel.ISupportInitialize) Measure2).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this.DsSalesArchive1).BeginInit();
				((System.ComponentModel.ISupportInitialize) this).BeginInit();
				//
				//GridDashboardItem1
				//
				Dimension1.DataMember = "dtInsert_dt";
				Dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DateHourMinute;
				GridDimensionColumn1.AddDataItem("Dimension", Dimension1);
				Dimension2.DataMember = "item_desc";
				GridDimensionColumn2.AddDataItem("Dimension", Dimension2);
				Measure1.DataMember = "qty";
				GridMeasureColumn1.AddDataItem("Measure", Measure1);
				Measure2.DataMember = "det_amnt";
				Measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
				Measure2.NumericFormat.IncludeGroupSeparator = true;
				Measure2.NumericFormat.Unit = DevExpress.DashboardCommon.DataItemNumericUnit.Ones;
				GridMeasureColumn2.AddDataItem("Measure", Measure2);
				this.GridDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {GridDimensionColumn1, GridDimensionColumn2, GridMeasureColumn1, GridMeasureColumn2});
				this.GridDashboardItem1.ComponentName = "GridDashboardItem1";
				this.GridDashboardItem1.DataItemRepository.Clear();
				this.GridDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0");
				this.GridDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem1");
				this.GridDashboardItem1.DataItemRepository.Add(Measure1, "DataItem2");
				this.GridDashboardItem1.DataItemRepository.Add(Measure2, "DataItem3");
				this.GridDashboardItem1.DataSource = this.DataSource1;
				this.GridDashboardItem1.IgnoreMasterFilters = false;
				this.GridDashboardItem1.Name = "Grid 1";
				this.GridDashboardItem1.ShowCaption = true;
				//
				//DataSource1
				//
				this.DataSource1.ComponentName = "DataSource1";
				this.DataSource1.Data = this.DsSalesArchive1;
				this.DataSource1.DataMember = "vwSalesArchive";
				this.DataSource1.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client;
				this.DataSource1.Filter = "[pos_date] >= ?FromDate And [pos_date] <= ?EndDate";
				this.DataSource1.Name = "Data Source 1";
				//
				//DsSalesArchive1
				//
				this.DsSalesArchive1.DataSetName = "dsSalesArchive";
				this.DsSalesArchive1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
				//
				//SaleswithParam
				//
				this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {this.DataSource1});
				this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {this.GridDashboardItem1});
				DashboardLayoutItem1.DashboardItem = this.GridDashboardItem1;
				DashboardLayoutItem1.Weight = 100.0D;
				DashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {DashboardLayoutItem1});
				DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
				this.LayoutRoot = DashboardLayoutGroup1;
				DynamicListLookUpSettings1.DataSourceName = "DataSource1";
				DynamicListLookUpSettings1.DisplayMember = "pos_date";
				DynamicListLookUpSettings1.ValueMember = "pos_date";
				DashboardParameter1.LookUpSettings = DynamicListLookUpSettings1;
				DashboardParameter1.Name = "EndDate";
				DashboardParameter1.Type = typeof(DateTime);
				DashboardParameter1.Value = new DateTime((long) (0));
				DynamicListLookUpSettings2.DataSourceName = "DataSource1";
				DynamicListLookUpSettings2.DisplayMember = "pos_date";
				DynamicListLookUpSettings2.ValueMember = "pos_date";
				DashboardParameter2.LookUpSettings = DynamicListLookUpSettings2;
				DashboardParameter2.Name = "FromDate";
				DashboardParameter2.Type = typeof(DateTime);
				DashboardParameter2.Value = new DateTime((long) (0));
				this.Parameters.AddRange(new DevExpress.DashboardCommon.DashboardParameter[] {DashboardParameter1, DashboardParameter2});
				this.Title.Text = "Dashboard";
				((System.ComponentModel.ISupportInitialize) Dimension1).EndInit();
				((System.ComponentModel.ISupportInitialize) Dimension2).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure1).EndInit();
				((System.ComponentModel.ISupportInitialize) Measure2).EndInit();
				((System.ComponentModel.ISupportInitialize) this.GridDashboardItem1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DataSource1).EndInit();
				((System.ComponentModel.ISupportInitialize) this.DsSalesArchive1).EndInit();
				((System.ComponentModel.ISupportInitialize) this).EndInit();
				
			}
			internal DevExpress.DashboardCommon.GridDashboardItem GridDashboardItem1;
			internal DevExpress.DashboardCommon.DataSource DataSource1;
			internal DoorsPOS.WinApp.dsSalesArchive DsSalesArchive1;
			
#endregion
		}
	}
}
