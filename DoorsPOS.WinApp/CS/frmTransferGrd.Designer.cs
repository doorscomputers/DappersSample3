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
	partial class frmTransferGrd : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmTransferGrd_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwTransferedBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsTransfered = new DoorsPOS.WinApp.dsTransfered();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.coltdate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colstckid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldtInsert_dt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collocation = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltdetamnt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsInsert_id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwTransferedTableAdapter = new DoorsPOS.WinApp.dsTransferedTableAdapters.vwTransferedTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwTransferedBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsTransfered).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwTransferedBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(888, 500);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwTransferedBindingSource
			//
			this.VwTransferedBindingSource.DataMember = "vwTransfered";
			this.VwTransferedBindingSource.DataSource = this.DsTransfered;
			//
			//DsTransfered
			//
			this.DsTransfered.DataSetName = "dsTransfered";
			this.DsTransfered.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.coltdate, this.colstckid, this.coldtInsert_dt, this.collocation, this.colitem_desc, this.colprice, this.colqty, this.coltdetamnt, this.colsInsert_id});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupCount = 1;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", this.colqty, "")});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colitem_desc, DevExpress.Data.ColumnSortOrder.Ascending), new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldtInsert_dt, DevExpress.Data.ColumnSortOrder.Descending)});
			//
			//coltdate
			//
			this.coltdate.FieldName = "tdate";
			this.coltdate.Name = "coltdate";
			//
			//colstckid
			//
			this.colstckid.FieldName = "stckid";
			this.colstckid.Name = "colstckid";
			//
			//coldtInsert_dt
			//
			this.coldtInsert_dt.Caption = "Date Transferred";
			this.coldtInsert_dt.FieldName = "dtInsert_dt";
			this.coldtInsert_dt.Name = "coldtInsert_dt";
			this.coldtInsert_dt.Visible = true;
			this.coldtInsert_dt.VisibleIndex = 0;
			//
			//collocation
			//
			this.collocation.Caption = "Location";
			this.collocation.FieldName = "location";
			this.collocation.Name = "collocation";
			this.collocation.Visible = true;
			this.collocation.VisibleIndex = 2;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Items Transferred";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 1;
			//
			//colprice
			//
			this.colprice.FieldName = "price";
			this.colprice.Name = "colprice";
			//
			//colqty
			//
			this.colqty.Caption = "Qty";
			this.colqty.FieldName = "qty";
			this.colqty.Name = "colqty";
			this.colqty.Visible = true;
			this.colqty.VisibleIndex = 1;
			//
			//coltdetamnt
			//
			this.coltdetamnt.FieldName = "tdetamnt";
			this.coltdetamnt.Name = "coltdetamnt";
			//
			//colsInsert_id
			//
			this.colsInsert_id.Caption = "UserName";
			this.colsInsert_id.FieldName = "sInsert_id";
			this.colsInsert_id.Name = "colsInsert_id";
			this.colsInsert_id.Visible = true;
			this.colsInsert_id.VisibleIndex = 3;
			//
			//VwTransferedTableAdapter
			//
			this.VwTransferedTableAdapter.ClearBeforeFill = true;
			//
			//frmTransferGrd
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 500);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmTransferGrd";
			this.Text = "Transferred Stocks";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwTransferedBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsTransfered).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsTransfered DsTransfered;
		internal System.Windows.Forms.BindingSource VwTransferedBindingSource;
		internal DoorsPOS.WinApp.dsTransferedTableAdapters.vwTransferedTableAdapter VwTransferedTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn coltdate;
		internal DevExpress.XtraGrid.Columns.GridColumn colstckid;
		internal DevExpress.XtraGrid.Columns.GridColumn coldtInsert_dt;
		internal DevExpress.XtraGrid.Columns.GridColumn collocation;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colprice;
		internal DevExpress.XtraGrid.Columns.GridColumn colqty;
		internal DevExpress.XtraGrid.Columns.GridColumn coltdetamnt;
		internal DevExpress.XtraGrid.Columns.GridColumn colsInsert_id;
	}
	
}
