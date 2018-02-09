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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class frmSalestoday : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmSalestoday_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwSales2dayItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsSalesTodayBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsSalesToday = new DoorsPOS.WinApp.dsSalesToday();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.coldtInsert_dt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsInsert_id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwSales2dayItemsTableAdapter = new DoorsPOS.WinApp.dsSalesTodayTableAdapters.vwSales2dayItemsTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwSales2dayItemsBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsSalesTodayBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsSalesToday).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.DataSource = this.VwSales2dayItemsBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(832, 509);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwSales2dayItemsBindingSource
			//
			this.VwSales2dayItemsBindingSource.DataMember = "vwSales2dayItems";
			this.VwSales2dayItemsBindingSource.DataSource = this.DsSalesTodayBindingSource;
			//
			//DsSalesTodayBindingSource
			//
			this.DsSalesTodayBindingSource.DataSource = this.DsSalesToday;
			this.DsSalesTodayBindingSource.Position = 0;
			//
			//DsSalesToday
			//
			this.DsSalesToday.DataSetName = "dsSalesToday";
			this.DsSalesToday.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.ActiveFilterString = "IsOutlookIntervalToday([dtInsert_dt])";
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.coldtInsert_dt, this.colitem_desc, this.colqty, this.colprice, this.GridColumn1, this.colsInsert_id});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", this.colqty, ""), new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GridColumn1", this.GridColumn1, "SUM={0:0.##}")});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.OptionsView.ShowFooter = true;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldtInsert_dt, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//coldtInsert_dt
			//
			this.coldtInsert_dt.Caption = "Date";
			this.coldtInsert_dt.DisplayFormat.FormatString = "G";
			this.coldtInsert_dt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.coldtInsert_dt.FieldName = "dtInsert_dt";
			this.coldtInsert_dt.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Date;
			this.coldtInsert_dt.Name = "coldtInsert_dt";
			this.coldtInsert_dt.Visible = true;
			this.coldtInsert_dt.VisibleIndex = 0;
			this.coldtInsert_dt.Width = 189;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Items Sold";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 2;
			this.colitem_desc.Width = 389;
			//
			//colqty
			//
			this.colqty.AppearanceHeader.Options.UseTextOptions = true;
			this.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colqty.Caption = "Qty Sold";
			this.colqty.FieldName = "qty";
			this.colqty.Name = "colqty";
			this.colqty.Visible = true;
			this.colqty.VisibleIndex = 1;
			this.colqty.Width = 121;
			//
			//colprice
			//
			this.colprice.AppearanceHeader.Options.UseTextOptions = true;
			this.colprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colprice.Caption = "Price";
			this.colprice.FieldName = "price";
			this.colprice.Name = "colprice";
			this.colprice.Width = 119;
			//
			//GridColumn1
			//
			this.GridColumn1.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.GridColumn1.Caption = "Amount";
			this.GridColumn1.DisplayFormat.FormatString = "n2";
			this.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.GridColumn1.FieldName = "GridColumn1";
			this.GridColumn1.Name = "GridColumn1";
			this.GridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GridColumn1", "SUM={0:n2}")});
			this.GridColumn1.UnboundExpression = "[price] * [qty]";
			this.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.GridColumn1.Visible = true;
			this.GridColumn1.VisibleIndex = 3;
			this.GridColumn1.Width = 113;
			//
			//colsInsert_id
			//
			this.colsInsert_id.Caption = "Cashier";
			this.colsInsert_id.FieldName = "sInsert_id";
			this.colsInsert_id.Name = "colsInsert_id";
			this.colsInsert_id.Width = 115;
			//
			//VwSales2dayItemsTableAdapter
			//
			this.VwSales2dayItemsTableAdapter.ClearBeforeFill = true;
			//
			//frmSalestoday
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 509);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmSalestoday";
			this.Text = "Sales Today";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwSales2dayItemsBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsSalesTodayBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsSalesToday).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal System.Windows.Forms.BindingSource DsSalesTodayBindingSource;
		internal DoorsPOS.WinApp.dsSalesToday DsSalesToday;
		internal System.Windows.Forms.BindingSource VwSales2dayItemsBindingSource;
		internal DoorsPOS.WinApp.dsSalesTodayTableAdapters.vwSales2dayItemsTableAdapter VwSales2dayItemsTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn coldtInsert_dt;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colqty;
		internal DevExpress.XtraGrid.Columns.GridColumn colprice;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn colsInsert_id;
	}
	
}
