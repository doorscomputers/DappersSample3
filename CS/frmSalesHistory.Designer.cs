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
	partial class frmSalesHistory : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmSalesHistory_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwSalesArchiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsSalesArchive = new DoorsPOS.WinApp.dsSalesArchive();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colpostmp_hdrid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colpos_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcost = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldet_amnt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsInsert_id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwSalesArchiveTableAdapter = new DoorsPOS.WinApp.dsSalesArchiveTableAdapters.vwSalesArchiveTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwSalesArchiveBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsSalesArchive).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.DataSource = this.VwSalesArchiveBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(1019, 591);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwSalesArchiveBindingSource
			//
			this.VwSalesArchiveBindingSource.DataMember = "vwSalesArchive";
			this.VwSalesArchiveBindingSource.DataSource = this.DsSalesArchive;
			//
			//DsSalesArchive
			//
			this.DsSalesArchive.DataSetName = "dsSalesArchive";
			this.DsSalesArchive.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.ActiveFilterString = "[pos_date] >= #2014-05-23# And [pos_date] < #2014-05-24#";
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colpostmp_hdrid, this.colpos_date, this.colitem_desc, this.colcost, this.colprice, this.colqty, this.coldet_amnt, this.colsInsert_id});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", this.coldet_amnt, "SUM={0:N2}"), new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", this.colqty, "SUM={0:0.##}")});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.OptionsView.ShowAutoFilterRow = true;
			this.GridView1.OptionsView.ShowFooter = true;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colitem_desc, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colpostmp_hdrid
			//
			this.colpostmp_hdrid.Caption = "Reference No.";
			this.colpostmp_hdrid.FieldName = "postmp_hdrid";
			this.colpostmp_hdrid.Name = "colpostmp_hdrid";
			this.colpostmp_hdrid.Visible = true;
			this.colpostmp_hdrid.VisibleIndex = 0;
			this.colpostmp_hdrid.Width = 72;
			//
			//colpos_date
			//
			this.colpos_date.Caption = "Date Sold";
			this.colpos_date.DisplayFormat.FormatString = "G";
			this.colpos_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colpos_date.FieldName = "pos_date";
			this.colpos_date.Name = "colpos_date";
			this.colpos_date.Visible = true;
			this.colpos_date.VisibleIndex = 1;
			this.colpos_date.Width = 105;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Sold";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "item_desc", "{0}")});
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 2;
			this.colitem_desc.Width = 115;
			//
			//colcost
			//
			this.colcost.AppearanceCell.Options.UseTextOptions = true;
			this.colcost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colcost.AppearanceHeader.Options.UseTextOptions = true;
			this.colcost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colcost.Caption = "Cost";
			this.colcost.DisplayFormat.FormatString = "N2";
			this.colcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colcost.FieldName = "cost";
			this.colcost.Name = "colcost";
			this.colcost.Visible = true;
			this.colcost.VisibleIndex = 3;
			this.colcost.Width = 67;
			//
			//colprice
			//
			this.colprice.AppearanceCell.Options.UseTextOptions = true;
			this.colprice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colprice.AppearanceHeader.Options.UseTextOptions = true;
			this.colprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colprice.Caption = "Price";
			this.colprice.DisplayFormat.FormatString = "N2";
			this.colprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colprice.FieldName = "price";
			this.colprice.Name = "colprice";
			this.colprice.Visible = true;
			this.colprice.VisibleIndex = 4;
			this.colprice.Width = 50;
			//
			//colqty
			//
			this.colqty.Caption = "Qty Sold";
			this.colqty.FieldName = "qty";
			this.colqty.Name = "colqty";
			this.colqty.Visible = true;
			this.colqty.VisibleIndex = 5;
			this.colqty.Width = 52;
			//
			//coldet_amnt
			//
			this.coldet_amnt.AppearanceCell.Options.UseTextOptions = true;
			this.coldet_amnt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coldet_amnt.AppearanceHeader.Options.UseTextOptions = true;
			this.coldet_amnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coldet_amnt.Caption = "Amount";
			this.coldet_amnt.DisplayFormat.FormatString = "N2";
			this.coldet_amnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coldet_amnt.FieldName = "det_amnt";
			this.coldet_amnt.Name = "coldet_amnt";
			this.coldet_amnt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", "SUM={0:N2}")});
			this.coldet_amnt.Visible = true;
			this.coldet_amnt.VisibleIndex = 6;
			this.coldet_amnt.Width = 114;
			//
			//colsInsert_id
			//
			this.colsInsert_id.AppearanceCell.Options.UseTextOptions = true;
			this.colsInsert_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colsInsert_id.AppearanceHeader.Options.UseTextOptions = true;
			this.colsInsert_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colsInsert_id.Caption = "Cashier";
			this.colsInsert_id.FieldName = "sInsert_id";
			this.colsInsert_id.Name = "colsInsert_id";
			this.colsInsert_id.Visible = true;
			this.colsInsert_id.VisibleIndex = 7;
			this.colsInsert_id.Width = 104;
			//
			//VwSalesArchiveTableAdapter
			//
			this.VwSalesArchiveTableAdapter.ClearBeforeFill = true;
			//
			//frmSalesHistory
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 591);
			this.Controls.Add(this.GridControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSalesHistory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Sales History";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwSalesArchiveBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsSalesArchive).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsSalesArchive DsSalesArchive;
		internal System.Windows.Forms.BindingSource VwSalesArchiveBindingSource;
		internal DoorsPOS.WinApp.dsSalesArchiveTableAdapters.vwSalesArchiveTableAdapter VwSalesArchiveTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colpostmp_hdrid;
		internal DevExpress.XtraGrid.Columns.GridColumn colpos_date;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colcost;
		internal DevExpress.XtraGrid.Columns.GridColumn colprice;
		internal DevExpress.XtraGrid.Columns.GridColumn colqty;
		internal DevExpress.XtraGrid.Columns.GridColumn coldet_amnt;
		internal DevExpress.XtraGrid.Columns.GridColumn colsInsert_id;
	}
	
}
