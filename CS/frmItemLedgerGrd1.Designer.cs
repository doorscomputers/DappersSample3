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
	partial class frmItemLedgerGrd1 : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmItemLedgerGrd1_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwItemLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsvwItemLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsvwItemLedger = new DoorsPOS.WinApp.dsvwItemLedger();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colilid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colstckid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colpostmp_hdrid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqty_sold = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqty_purchased = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqtyreturned = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colfree = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbackorder = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colmanualinv = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrevious_Stock_Balance = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRunning_Stock_Balance = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltrans_Date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltransdates = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqtytransfrd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwItemLedgerTableAdapter = new DoorsPOS.WinApp.dsvwItemLedgerTableAdapters.vwItemLedgerTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwItemLedgerBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwItemLedgerBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwItemLedger).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwItemLedgerBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(952, 438);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwItemLedgerBindingSource
			//
			this.VwItemLedgerBindingSource.DataMember = "vwItemLedger";
			this.VwItemLedgerBindingSource.DataSource = this.DsvwItemLedgerBindingSource;
			//
			//DsvwItemLedgerBindingSource
			//
			this.DsvwItemLedgerBindingSource.DataSource = this.DsvwItemLedger;
			this.DsvwItemLedgerBindingSource.Position = 0;
			//
			//DsvwItemLedger
			//
			this.DsvwItemLedger.DataSetName = "dsvwItemLedger";
			this.DsvwItemLedger.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colilid, this.colstckid, this.colitem_desc, this.colpostmp_hdrid, this.colqty_sold, this.colqty_purchased, this.colqtyreturned, this.colfree, this.colbackorder, this.colmanualinv, this.colPrevious_Stock_Balance, this.colRunning_Stock_Balance, this.coltrans_Date, this.coltransdates, this.colqtytransfrd});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupCount = 1;
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colitem_desc, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colilid
			//
			this.colilid.FieldName = "ilid";
			this.colilid.Name = "colilid";
			//
			//colstckid
			//
			this.colstckid.FieldName = "stckid";
			this.colstckid.Name = "colstckid";
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Descsription";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 0;
			//
			//colpostmp_hdrid
			//
			this.colpostmp_hdrid.FieldName = "postmp_hdrid";
			this.colpostmp_hdrid.Name = "colpostmp_hdrid";
			//
			//colqty_sold
			//
			this.colqty_sold.Caption = "Qty Sold";
			this.colqty_sold.FieldName = "qty_sold";
			this.colqty_sold.Name = "colqty_sold";
			this.colqty_sold.Visible = true;
			this.colqty_sold.VisibleIndex = 2;
			this.colqty_sold.Width = 56;
			//
			//colqty_purchased
			//
			this.colqty_purchased.Caption = "Qty Purchased";
			this.colqty_purchased.FieldName = "qty_purchased";
			this.colqty_purchased.Name = "colqty_purchased";
			this.colqty_purchased.Visible = true;
			this.colqty_purchased.VisibleIndex = 3;
			this.colqty_purchased.Width = 84;
			//
			//colqtyreturned
			//
			this.colqtyreturned.Caption = "Qty Returned";
			this.colqtyreturned.FieldName = "qtyreturned";
			this.colqtyreturned.Name = "colqtyreturned";
			this.colqtyreturned.Visible = true;
			this.colqtyreturned.VisibleIndex = 4;
			this.colqtyreturned.Width = 80;
			//
			//colfree
			//
			this.colfree.Caption = "Free Items";
			this.colfree.FieldName = "free";
			this.colfree.Name = "colfree";
			this.colfree.Visible = true;
			this.colfree.VisibleIndex = 7;
			this.colfree.Width = 80;
			//
			//colbackorder
			//
			this.colbackorder.Caption = "BO";
			this.colbackorder.FieldName = "backorder";
			this.colbackorder.Name = "colbackorder";
			this.colbackorder.Visible = true;
			this.colbackorder.VisibleIndex = 5;
			this.colbackorder.Width = 61;
			//
			//colmanualinv
			//
			this.colmanualinv.Caption = "Manual Inventory";
			this.colmanualinv.FieldName = "manualinv";
			this.colmanualinv.Name = "colmanualinv";
			this.colmanualinv.Visible = true;
			this.colmanualinv.VisibleIndex = 8;
			this.colmanualinv.Width = 363;
			//
			//colPrevious_Stock_Balance
			//
			this.colPrevious_Stock_Balance.Caption = "Previous Stock Count";
			this.colPrevious_Stock_Balance.FieldName = "Previous_Stock_Balance";
			this.colPrevious_Stock_Balance.Name = "colPrevious_Stock_Balance";
			this.colPrevious_Stock_Balance.Visible = true;
			this.colPrevious_Stock_Balance.VisibleIndex = 1;
			this.colPrevious_Stock_Balance.Width = 112;
			//
			//colRunning_Stock_Balance
			//
			this.colRunning_Stock_Balance.Caption = "Running Stock Count";
			this.colRunning_Stock_Balance.FieldName = "Running_Stock_Balance";
			this.colRunning_Stock_Balance.Name = "colRunning_Stock_Balance";
			this.colRunning_Stock_Balance.Visible = true;
			this.colRunning_Stock_Balance.VisibleIndex = 6;
			this.colRunning_Stock_Balance.Width = 112;
			//
			//coltrans_Date
			//
			this.coltrans_Date.Caption = "Transaction Date";
			this.coltrans_Date.FieldName = "trans_Date";
			this.coltrans_Date.Name = "coltrans_Date";
			this.coltrans_Date.Visible = true;
			this.coltrans_Date.VisibleIndex = 0;
			this.coltrans_Date.Width = 118;
			//
			//coltransdates
			//
			this.coltransdates.FieldName = "transdates";
			this.coltransdates.Name = "coltransdates";
			//
			//colqtytransfrd
			//
			this.colqtytransfrd.FieldName = "qtytransfrd";
			this.colqtytransfrd.Name = "colqtytransfrd";
			//
			//VwItemLedgerTableAdapter
			//
			this.VwItemLedgerTableAdapter.ClearBeforeFill = true;
			//
			//frmItemLedgerGrd1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 438);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmItemLedgerGrd1";
			this.Text = "Item Ledger Grid View";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwItemLedgerBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwItemLedgerBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwItemLedger).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal System.Windows.Forms.BindingSource DsvwItemLedgerBindingSource;
		internal DoorsPOS.WinApp.dsvwItemLedger DsvwItemLedger;
		internal System.Windows.Forms.BindingSource VwItemLedgerBindingSource;
		internal DoorsPOS.WinApp.dsvwItemLedgerTableAdapters.vwItemLedgerTableAdapter VwItemLedgerTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colilid;
		internal DevExpress.XtraGrid.Columns.GridColumn colstckid;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colpostmp_hdrid;
		internal DevExpress.XtraGrid.Columns.GridColumn colPrevious_Stock_Balance;
		internal DevExpress.XtraGrid.Columns.GridColumn colqty_sold;
		internal DevExpress.XtraGrid.Columns.GridColumn colqty_purchased;
		internal DevExpress.XtraGrid.Columns.GridColumn colqtyreturned;
		internal DevExpress.XtraGrid.Columns.GridColumn colbackorder;
		internal DevExpress.XtraGrid.Columns.GridColumn colRunning_Stock_Balance;
		internal DevExpress.XtraGrid.Columns.GridColumn coltrans_Date;
		internal DevExpress.XtraGrid.Columns.GridColumn coltransdates;
		internal DevExpress.XtraGrid.Columns.GridColumn colfree;
		internal DevExpress.XtraGrid.Columns.GridColumn colmanualinv;
		internal DevExpress.XtraGrid.Columns.GridColumn colqtytransfrd;
	}
	
}
