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
	partial class frmBarcodeGrd : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmBarcodeGrd_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.DsStocksBarcode = new DoorsPOS.WinApp.dsStocksBarcode();
			this.StocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.stocksTableAdapter = new DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.stocksTableAdapter();
			this.colstckid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TblBarcodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.TblBarcodesTableAdapter = new DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.tblBarcodesTableAdapter();
			this.TableAdapterManager = new DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.TableAdapterManager();
			this.CardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
			this.GridControl2 = new DevExpress.XtraGrid.GridControl();
			this.binFKtblBarcodesstocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.CardView2 = new DevExpress.XtraGrid.Views.Card.CardView();
			this.colbcodeid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbarcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colstckid1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldateadded = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsStocksBarcode).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.StocksBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.TblBarcodesBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.CardView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.binFKtblBarcodesstocksBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.CardView2).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.DataMember = "stocks";
			this.GridControl1.DataSource = this.DsStocksBarcode;
			this.GridControl1.Location = new System.Drawing.Point(12, 12);
			this.GridControl1.MainView = this.gridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(723, 215);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gridView1, this.CardView1});
			//
			//gridView1
			//
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colstckid, this.colbarcode, this.colitem_desc});
			this.gridView1.GridControl = this.GridControl1;
			this.gridView1.Name = "gridView1";
			//
			//DsStocksBarcode
			//
			this.DsStocksBarcode.DataSetName = "dsStocksBarcode";
			this.DsStocksBarcode.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//StocksBindingSource
			//
			this.StocksBindingSource.DataMember = "stocks";
			this.StocksBindingSource.DataSource = this.DsStocksBarcode;
			//
			//stocksTableAdapter
			//
			this.stocksTableAdapter.ClearBeforeFill = true;
			//
			//colstckid
			//
			this.colstckid.FieldName = "stckid";
			this.colstckid.Name = "colstckid";
			this.colstckid.OptionsColumn.ReadOnly = true;
			this.colstckid.Visible = true;
			this.colstckid.VisibleIndex = 0;
			//
			//colbarcode
			//
			this.colbarcode.FieldName = "barcode";
			this.colbarcode.Name = "colbarcode";
			this.colbarcode.Visible = true;
			this.colbarcode.VisibleIndex = 1;
			//
			//colitem_desc
			//
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 2;
			//
			//TblBarcodesBindingSource
			//
			this.TblBarcodesBindingSource.DataMember = "tblBarcodes";
			this.TblBarcodesBindingSource.DataSource = this.DsStocksBarcode;
			//
			//TblBarcodesTableAdapter
			//
			this.TblBarcodesTableAdapter.ClearBeforeFill = true;
			//
			//TableAdapterManager
			//
			this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.TableAdapterManager.stocksTableAdapter = this.stocksTableAdapter;
			this.TableAdapterManager.tblBarcodesTableAdapter = this.TblBarcodesTableAdapter;
			this.TableAdapterManager.UpdateOrder = DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			//
			//CardView1
			//
			this.CardView1.FocusedCardTopFieldIndex = 0;
			this.CardView1.GridControl = this.GridControl1;
			this.CardView1.Name = "CardView1";
			//
			//GridControl2
			//
			this.GridControl2.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl2.DataSource = this.binFKtblBarcodesstocksBindingSource;
			this.GridControl2.Location = new System.Drawing.Point(12, 234);
			this.GridControl2.MainView = this.CardView2;
			this.GridControl2.Name = "GridControl2";
			this.GridControl2.Size = new System.Drawing.Size(752, 200);
			this.GridControl2.TabIndex = 1;
			this.GridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.CardView2});
			//
			//binFKtblBarcodesstocksBindingSource
			//
			this.binFKtblBarcodesstocksBindingSource.DataMember = "FK_tblBarcodes_stocks";
			this.binFKtblBarcodesstocksBindingSource.DataSource = this.StocksBindingSource;
			//
			//CardView2
			//
			this.CardView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colbcodeid, this.colbarcode1, this.colstckid1, this.coldateadded});
			this.CardView2.FocusedCardTopFieldIndex = 0;
			this.CardView2.GridControl = this.GridControl2;
			this.CardView2.Name = "CardView2";
			this.CardView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
			//
			//colbcodeid
			//
			this.colbcodeid.FieldName = "bcodeid";
			this.colbcodeid.Name = "colbcodeid";
			this.colbcodeid.OptionsColumn.ReadOnly = true;
			this.colbcodeid.Visible = true;
			this.colbcodeid.VisibleIndex = 0;
			//
			//colbarcode1
			//
			this.colbarcode1.FieldName = "barcode";
			this.colbarcode1.Name = "colbarcode1";
			this.colbarcode1.Visible = true;
			this.colbarcode1.VisibleIndex = 1;
			//
			//colstckid1
			//
			this.colstckid1.FieldName = "stckid";
			this.colstckid1.Name = "colstckid1";
			this.colstckid1.Visible = true;
			this.colstckid1.VisibleIndex = 2;
			//
			//coldateadded
			//
			this.coldateadded.FieldName = "dateadded";
			this.coldateadded.Name = "coldateadded";
			this.coldateadded.Visible = true;
			this.coldateadded.VisibleIndex = 3;
			//
			//frmBarcodeGrd
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 446);
			this.Controls.Add(this.GridControl2);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmBarcodeGrd";
			this.Text = "frmBarcodeGrd";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsStocksBarcode).EndInit();
			((System.ComponentModel.ISupportInitialize) this.StocksBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.TblBarcodesBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.CardView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.binFKtblBarcodesstocksBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.CardView2).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		internal DoorsPOS.WinApp.dsStocksBarcode DsStocksBarcode;
		internal System.Windows.Forms.BindingSource StocksBindingSource;
		internal DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.stocksTableAdapter stocksTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colstckid;
		internal DevExpress.XtraGrid.Columns.GridColumn colbarcode;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal System.Windows.Forms.BindingSource TblBarcodesBindingSource;
		internal DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.tblBarcodesTableAdapter TblBarcodesTableAdapter;
		internal DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.TableAdapterManager TableAdapterManager;
		internal DevExpress.XtraGrid.Views.Card.CardView CardView1;
		internal DevExpress.XtraGrid.GridControl GridControl2;
		internal System.Windows.Forms.BindingSource binFKtblBarcodesstocksBindingSource;
		internal DevExpress.XtraGrid.Views.Card.CardView CardView2;
		internal DevExpress.XtraGrid.Columns.GridColumn colbcodeid;
		internal DevExpress.XtraGrid.Columns.GridColumn colbarcode1;
		internal DevExpress.XtraGrid.Columns.GridColumn colstckid1;
		internal DevExpress.XtraGrid.Columns.GridColumn coldateadded;
	}
	
}
