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
	partial class frmDlvryGrid2 : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmDlvryGrid2_Load);
			this.VwDlvryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsvwDeliveries = new DoorsPOS.WinApp.dsvwDeliveries();
			this.VwDlvryDetailsTableAdapter = new DoorsPOS.WinApp.dsvwDeliveriesTableAdapters.vwDlvryDetailsTableAdapter();
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.coldtInsert_dt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsupplier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldrid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcost = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colfreee = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldrdetamnt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsInsert_id = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize) this.VwDlvryDetailsBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwDeliveries).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//VwDlvryDetailsBindingSource
			//
			this.VwDlvryDetailsBindingSource.DataMember = "vwDlvryDetails";
			this.VwDlvryDetailsBindingSource.DataSource = this.DsvwDeliveries;
			//
			//DsvwDeliveries
			//
			this.DsvwDeliveries.DataSetName = "dsvwDeliveries";
			this.DsvwDeliveries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VwDlvryDetailsTableAdapter
			//
			this.VwDlvryDetailsTableAdapter.ClearBeforeFill = true;
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwDlvryDetailsBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(878, 510);
			this.GridControl1.TabIndex = 1;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.coldtInsert_dt, this.colsupplier, this.coldrid, this.colitem_desc, this.colcost, this.colqty, this.colfreee, this.coldrdetamnt, this.colsInsert_id});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupCount = 2;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "drdetamnt", this.coldrdetamnt, "SUM={0:N2}"), new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "item_desc", this.colitem_desc, "ITEM COUNT={0}"), new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", this.colqty, "SUM={0:N0}")});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colitem_desc, DevExpress.Data.ColumnSortOrder.Ascending), new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldtInsert_dt, DevExpress.Data.ColumnSortOrder.Ascending), new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colqty, DevExpress.Data.ColumnSortOrder.Descending)});
			//
			//coldtInsert_dt
			//
			this.coldtInsert_dt.Caption = "Date";
			this.coldtInsert_dt.FieldName = "dtInsert_dt";
			this.coldtInsert_dt.Name = "coldtInsert_dt";
			this.coldtInsert_dt.Visible = true;
			this.coldtInsert_dt.VisibleIndex = 1;
			this.coldtInsert_dt.Width = 130;
			//
			//colsupplier
			//
			this.colsupplier.Caption = "Supplier";
			this.colsupplier.FieldName = "supplier";
			this.colsupplier.Name = "colsupplier";
			this.colsupplier.Visible = true;
			this.colsupplier.VisibleIndex = 0;
			this.colsupplier.Width = 191;
			//
			//coldrid
			//
			this.coldrid.AppearanceHeader.Options.UseTextOptions = true;
			this.coldrid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coldrid.Caption = "Dr. No.";
			this.coldrid.FieldName = "drid";
			this.coldrid.Name = "coldrid";
			this.coldrid.Visible = true;
			this.coldrid.VisibleIndex = 1;
			this.coldrid.Width = 123;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Description";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 3;
			this.colitem_desc.Width = 291;
			//
			//colcost
			//
			this.colcost.AppearanceHeader.Options.UseTextOptions = true;
			this.colcost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colcost.Caption = "Cost";
			this.colcost.DisplayFormat.FormatString = "N2";
			this.colcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colcost.FieldName = "cost";
			this.colcost.Name = "colcost";
			this.colcost.Visible = true;
			this.colcost.VisibleIndex = 2;
			this.colcost.Width = 88;
			//
			//colqty
			//
			this.colqty.AppearanceHeader.Options.UseTextOptions = true;
			this.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colqty.Caption = "Qty";
			this.colqty.DisplayFormat.FormatString = "N0";
			this.colqty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colqty.FieldName = "qty";
			this.colqty.Name = "colqty";
			this.colqty.Visible = true;
			this.colqty.VisibleIndex = 3;
			this.colqty.Width = 72;
			//
			//colfreee
			//
			this.colfreee.AppearanceHeader.Options.UseTextOptions = true;
			this.colfreee.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colfreee.Caption = "Free";
			this.colfreee.DisplayFormat.FormatString = "N0";
			this.colfreee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colfreee.FieldName = "freee";
			this.colfreee.Name = "colfreee";
			this.colfreee.Visible = true;
			this.colfreee.VisibleIndex = 5;
			this.colfreee.Width = 414;
			//
			//coldrdetamnt
			//
			this.coldrdetamnt.AppearanceHeader.Options.UseTextOptions = true;
			this.coldrdetamnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coldrdetamnt.Caption = "Amount";
			this.coldrdetamnt.DisplayFormat.FormatString = "N2";
			this.coldrdetamnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coldrdetamnt.FieldName = "drdetamnt";
			this.coldrdetamnt.Name = "coldrdetamnt";
			this.coldrdetamnt.Visible = true;
			this.coldrdetamnt.VisibleIndex = 4;
			this.coldrdetamnt.Width = 178;
			//
			//colsInsert_id
			//
			this.colsInsert_id.Caption = "Employee";
			this.colsInsert_id.FieldName = "sInsert_id";
			this.colsInsert_id.Name = "colsInsert_id";
			this.colsInsert_id.Width = 302;
			//
			//frmDlvryGrid2
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 510);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmDlvryGrid2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Deliveries Per Item";
			((System.ComponentModel.ISupportInitialize) this.VwDlvryDetailsBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwDeliveries).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DoorsPOS.WinApp.dsvwDeliveries DsvwDeliveries;
		internal System.Windows.Forms.BindingSource VwDlvryDetailsBindingSource;
		internal DoorsPOS.WinApp.dsvwDeliveriesTableAdapters.vwDlvryDetailsTableAdapter VwDlvryDetailsTableAdapter;
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DevExpress.XtraGrid.Columns.GridColumn coldtInsert_dt;
		internal DevExpress.XtraGrid.Columns.GridColumn colsupplier;
		internal DevExpress.XtraGrid.Columns.GridColumn coldrid;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colcost;
		internal DevExpress.XtraGrid.Columns.GridColumn colqty;
		internal DevExpress.XtraGrid.Columns.GridColumn colfreee;
		internal DevExpress.XtraGrid.Columns.GridColumn coldrdetamnt;
		internal DevExpress.XtraGrid.Columns.GridColumn colsInsert_id;
	}
	
}
