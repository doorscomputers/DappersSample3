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
	partial class frmChangePrceGrid : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmChangePrceGrid_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwChangePriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsChangePrice = new DoorsPOS.WinApp.dsChangePrice();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.coldtInsert_dt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colws = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldet_amnt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwChangePriceTableAdapter = new DoorsPOS.WinApp.dsChangePriceTableAdapters.vwChangePriceTableAdapter();
			this.colsInsert_id = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwChangePriceBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsChangePrice).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwChangePriceBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(859, 522);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwChangePriceBindingSource
			//
			this.VwChangePriceBindingSource.DataMember = "vwChangePrice";
			this.VwChangePriceBindingSource.DataSource = this.DsChangePrice;
			//
			//DsChangePrice
			//
			this.DsChangePrice.DataSetName = "dsChangePrice";
			this.DsChangePrice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.coldtInsert_dt, this.colbarcode, this.colitem_desc, this.colprice, this.colws, this.colqty, this.coldet_amnt, this.colsInsert_id});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			//
			//coldtInsert_dt
			//
			this.coldtInsert_dt.Caption = "Date Sold";
			this.coldtInsert_dt.FieldName = "dtInsert_dt";
			this.coldtInsert_dt.Name = "coldtInsert_dt";
			this.coldtInsert_dt.Visible = true;
			this.coldtInsert_dt.VisibleIndex = 0;
			this.coldtInsert_dt.Width = 119;
			//
			//colbarcode
			//
			this.colbarcode.Caption = "ItemCode";
			this.colbarcode.FieldName = "barcode";
			this.colbarcode.Name = "colbarcode";
			this.colbarcode.Visible = true;
			this.colbarcode.VisibleIndex = 1;
			this.colbarcode.Width = 90;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Description";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 2;
			this.colitem_desc.Width = 213;
			//
			//colprice
			//
			this.colprice.Caption = "Original Price";
			this.colprice.DisplayFormat.FormatString = "N2";
			this.colprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colprice.FieldName = "price";
			this.colprice.Name = "colprice";
			this.colprice.Visible = true;
			this.colprice.VisibleIndex = 3;
			this.colprice.Width = 82;
			//
			//colws
			//
			this.colws.Caption = "New Price";
			this.colws.DisplayFormat.FormatString = "N2";
			this.colws.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colws.FieldName = "ws";
			this.colws.Name = "colws";
			this.colws.Visible = true;
			this.colws.VisibleIndex = 4;
			this.colws.Width = 68;
			//
			//colqty
			//
			this.colqty.Caption = "Qty Sold";
			this.colqty.FieldName = "qty";
			this.colqty.Name = "colqty";
			this.colqty.Visible = true;
			this.colqty.VisibleIndex = 5;
			this.colqty.Width = 55;
			//
			//coldet_amnt
			//
			this.coldet_amnt.Caption = "Amount";
			this.coldet_amnt.FieldName = "det_amnt";
			this.coldet_amnt.Name = "coldet_amnt";
			this.coldet_amnt.Visible = true;
			this.coldet_amnt.VisibleIndex = 6;
			this.coldet_amnt.Width = 214;
			//
			//VwChangePriceTableAdapter
			//
			this.VwChangePriceTableAdapter.ClearBeforeFill = true;
			//
			//colsInsert_id
			//
			this.colsInsert_id.Caption = "Cashier";
			this.colsInsert_id.FieldName = "sInsert_id";
			this.colsInsert_id.Name = "colsInsert_id";
			this.colsInsert_id.Visible = true;
			this.colsInsert_id.VisibleIndex = 7;
			//
			//frmChangePrceGrid
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 522);
			this.Controls.Add(this.GridControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChangePrceGrid";
			this.Text = "Changed Price Sold Items";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwChangePriceBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsChangePrice).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsChangePrice DsChangePrice;
		internal System.Windows.Forms.BindingSource VwChangePriceBindingSource;
		internal DoorsPOS.WinApp.dsChangePriceTableAdapters.vwChangePriceTableAdapter VwChangePriceTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colbarcode;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colprice;
		internal DevExpress.XtraGrid.Columns.GridColumn colws;
		internal DevExpress.XtraGrid.Columns.GridColumn colqty;
		internal DevExpress.XtraGrid.Columns.GridColumn coldet_amnt;
		internal DevExpress.XtraGrid.Columns.GridColumn coldtInsert_dt;
		internal DevExpress.XtraGrid.Columns.GridColumn colsInsert_id;
	}
	
}
