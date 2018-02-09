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
	partial class frmSalesperRef : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmSalesperRef_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwSalesRefBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Dssalesref1 = new DoorsPOS.WinApp.dssalesref1();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colpostmp_hdrid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colpos_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcost = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldet_amnt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwSalesRefTableAdapter = new DoorsPOS.WinApp.dssalesref1TableAdapters.vwSalesRefTableAdapter();
			this.colsInsert_id = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwSalesRefBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.Dssalesref1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwSalesRefBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(983, 517);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwSalesRefBindingSource
			//
			this.VwSalesRefBindingSource.DataMember = "vwSalesRef";
			this.VwSalesRefBindingSource.DataSource = this.Dssalesref1;
			//
			//Dssalesref1
			//
			this.Dssalesref1.DataSetName = "dssalesref1";
			this.Dssalesref1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colpostmp_hdrid, this.colpos_date, this.colitem_desc, this.colcost, this.colprice, this.coldet_amnt, this.colsInsert_id});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupCount = 2;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", this.coldet_amnt, "")});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colpos_date, DevExpress.Data.ColumnSortOrder.Ascending), new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colpostmp_hdrid, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colpostmp_hdrid
			//
			this.colpostmp_hdrid.Caption = "Reference No.";
			this.colpostmp_hdrid.FieldName = "postmp_hdrid";
			this.colpostmp_hdrid.Name = "colpostmp_hdrid";
			this.colpostmp_hdrid.Visible = true;
			this.colpostmp_hdrid.VisibleIndex = 2;
			//
			//colpos_date
			//
			this.colpos_date.Caption = "Date";
			this.colpos_date.FieldName = "pos_date";
			this.colpos_date.Name = "colpos_date";
			this.colpos_date.Visible = true;
			this.colpos_date.VisibleIndex = 0;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Description";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 0;
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
			this.colcost.VisibleIndex = 1;
			//
			//colprice
			//
			this.colprice.AppearanceHeader.Options.UseTextOptions = true;
			this.colprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colprice.Caption = "Price";
			this.colprice.DisplayFormat.FormatString = "N2";
			this.colprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colprice.FieldName = "price";
			this.colprice.Name = "colprice";
			this.colprice.Visible = true;
			this.colprice.VisibleIndex = 2;
			//
			//coldet_amnt
			//
			this.coldet_amnt.AppearanceHeader.Options.UseTextOptions = true;
			this.coldet_amnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coldet_amnt.Caption = "Amount";
			this.coldet_amnt.DisplayFormat.FormatString = "N2";
			this.coldet_amnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coldet_amnt.FieldName = "det_amnt";
			this.coldet_amnt.Name = "coldet_amnt";
			this.coldet_amnt.Visible = true;
			this.coldet_amnt.VisibleIndex = 3;
			//
			//VwSalesRefTableAdapter
			//
			this.VwSalesRefTableAdapter.ClearBeforeFill = true;
			//
			//colsInsert_id
			//
			this.colsInsert_id.AppearanceCell.Options.UseTextOptions = true;
			this.colsInsert_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colsInsert_id.AppearanceHeader.Options.UseTextOptions = true;
			this.colsInsert_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colsInsert_id.Caption = "Cashier";
			this.colsInsert_id.FieldName = "sInsert_id";
			this.colsInsert_id.Name = "colsInsert_id";
			this.colsInsert_id.Visible = true;
			this.colsInsert_id.VisibleIndex = 4;
			//
			//frmSalesperRef
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(983, 517);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmSalesperRef";
			this.Text = "Sales Today Grouped by Reference No.";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwSalesRefBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.Dssalesref1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dssalesref1 Dssalesref1;
		internal System.Windows.Forms.BindingSource VwSalesRefBindingSource;
		internal DoorsPOS.WinApp.dssalesref1TableAdapters.vwSalesRefTableAdapter VwSalesRefTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colpostmp_hdrid;
		internal DevExpress.XtraGrid.Columns.GridColumn colpos_date;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colcost;
		internal DevExpress.XtraGrid.Columns.GridColumn colprice;
		internal DevExpress.XtraGrid.Columns.GridColumn coldet_amnt;
		internal DevExpress.XtraGrid.Columns.GridColumn colsInsert_id;
	}
	
}
