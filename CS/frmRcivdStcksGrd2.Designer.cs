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
	partial class frmRcivdStcksGrd2 : System.Windows.Forms.Form
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
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			base.Load += new System.EventHandler(frmRcivdStcksGrd2_Load);
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwReceivedStocksBindingSource = new System.Windows.Forms.BindingSource();
			this.DsReceivedStcks = new DoorsPOS.WinApp.dsReceivedStcks();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colrdate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsInsert_id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collocation = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwReceivedStocksTableAdapter = new DoorsPOS.WinApp.dsReceivedStcksTableAdapters.vwReceivedStocksTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwReceivedStocksBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsReceivedStcks).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwReceivedStocksBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(836, 495);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwReceivedStocksBindingSource
			//
			this.VwReceivedStocksBindingSource.DataMember = "vwReceivedStocks";
			this.VwReceivedStocksBindingSource.DataSource = this.DsReceivedStcks;
			//
			//DsReceivedStcks
			//
			this.DsReceivedStcks.DataSetName = "dsReceivedStcks";
			this.DsReceivedStcks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colrdate, this.colsInsert_id, this.collocation, this.colitem_desc, this.colqty});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.collocation, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colrdate
			//
			this.colrdate.Caption = "Date Received";
			this.colrdate.FieldName = "rdate";
			this.colrdate.Name = "colrdate";
			this.colrdate.Visible = true;
			this.colrdate.VisibleIndex = 0;
			this.colrdate.Width = 115;
			//
			//colsInsert_id
			//
			this.colsInsert_id.AppearanceCell.Options.UseTextOptions = true;
			this.colsInsert_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colsInsert_id.AppearanceHeader.Options.UseTextOptions = true;
			this.colsInsert_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colsInsert_id.Caption = "Encoder";
			this.colsInsert_id.FieldName = "sInsert_id";
			this.colsInsert_id.Name = "colsInsert_id";
			this.colsInsert_id.Visible = true;
			this.colsInsert_id.VisibleIndex = 4;
			this.colsInsert_id.Width = 408;
			//
			//collocation
			//
			this.collocation.AppearanceCell.Options.UseTextOptions = true;
			this.collocation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.collocation.AppearanceHeader.Options.UseTextOptions = true;
			this.collocation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.collocation.Caption = "From Location";
			this.collocation.FieldName = "location";
			this.collocation.Name = "collocation";
			this.collocation.Visible = true;
			this.collocation.VisibleIndex = 3;
			this.collocation.Width = 205;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Description";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 1;
			this.colitem_desc.Width = 237;
			//
			//colqty
			//
			this.colqty.Caption = "Qty Received";
			this.colqty.FieldName = "qty";
			this.colqty.Name = "colqty";
			this.colqty.Visible = true;
			this.colqty.VisibleIndex = 2;
			this.colqty.Width = 101;
			//
			//VwReceivedStocksTableAdapter
			//
			this.VwReceivedStocksTableAdapter.ClearBeforeFill = true;
			//
			//frmRcivdStcksGrd2
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(836, 495);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmRcivdStcksGrd2";
			this.Text = "Received Stocks View2";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwReceivedStocksBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsReceivedStcks).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsReceivedStcks DsReceivedStcks;
		internal System.Windows.Forms.BindingSource VwReceivedStocksBindingSource;
		internal DoorsPOS.WinApp.dsReceivedStcksTableAdapters.vwReceivedStocksTableAdapter VwReceivedStocksTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colrdate;
		internal DevExpress.XtraGrid.Columns.GridColumn colsInsert_id;
		internal DevExpress.XtraGrid.Columns.GridColumn collocation;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colqty;
	}
	
}
