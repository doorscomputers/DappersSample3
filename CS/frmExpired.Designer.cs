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
	partial class frmExpired : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmExpired_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.SpExpirationDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsspExpiration = new DoorsPOS.WinApp.dsspExpiration();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.coldrdate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldrinv = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsupplier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colstckid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collotno = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colexpdate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.spExpirationDateTableAdapter = new DoorsPOS.WinApp.dsspExpirationTableAdapters.spExpirationDateTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.SpExpirationDateBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsspExpiration).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.DataSource = this.SpExpirationDateBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.gridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(805, 428);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gridView1});
			//
			//SpExpirationDateBindingSource
			//
			this.SpExpirationDateBindingSource.DataMember = "spExpirationDate";
			this.SpExpirationDateBindingSource.DataSource = this.DsspExpiration;
			//
			//DsspExpiration
			//
			this.DsspExpiration.DataSetName = "dsspExpiration";
			this.DsspExpiration.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//gridView1
			//
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.coldrdate, this.coldrinv, this.colsupplier, this.colstckid, this.colqty, this.collotno, this.colexpdate, this.colitem_desc});
			this.gridView1.GridControl = this.GridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowAutoFilterRow = true;
			this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colqty, DevExpress.Data.ColumnSortOrder.Descending)});
			//
			//coldrdate
			//
			this.coldrdate.Caption = "Date Delivered";
			this.coldrdate.FieldName = "drdate";
			this.coldrdate.Name = "coldrdate";
			this.coldrdate.Visible = true;
			this.coldrdate.VisibleIndex = 2;
			//
			//coldrinv
			//
			this.coldrinv.Caption = "Invoice Number";
			this.coldrinv.FieldName = "drinv";
			this.coldrinv.Name = "coldrinv";
			this.coldrinv.Visible = true;
			this.coldrinv.VisibleIndex = 3;
			//
			//colsupplier
			//
			this.colsupplier.Caption = "Supplier";
			this.colsupplier.FieldName = "supplier";
			this.colsupplier.Name = "colsupplier";
			this.colsupplier.Visible = true;
			this.colsupplier.VisibleIndex = 4;
			//
			//colstckid
			//
			this.colstckid.FieldName = "stckid";
			this.colstckid.Name = "colstckid";
			//
			//colqty
			//
			this.colqty.Caption = "Qty Delivered";
			this.colqty.FieldName = "qty";
			this.colqty.Name = "colqty";
			//
			//collotno
			//
			this.collotno.Caption = "Lot No.";
			this.collotno.FieldName = "lotno";
			this.collotno.Name = "collotno";
			this.collotno.Visible = true;
			this.collotno.VisibleIndex = 5;
			//
			//colexpdate
			//
			this.colexpdate.Caption = "Expiration Date";
			this.colexpdate.FieldName = "expdate";
			this.colexpdate.Name = "colexpdate";
			this.colexpdate.Visible = true;
			this.colexpdate.VisibleIndex = 0;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Description";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 1;
			//
			//spExpirationDateTableAdapter
			//
			this.spExpirationDateTableAdapter.ClearBeforeFill = true;
			//
			//frmExpired
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 428);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmExpired";
			this.Text = "Expired";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.SpExpirationDateBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsspExpiration).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		internal DevExpress.XtraGrid.Columns.GridColumn coldrdate;
		internal DevExpress.XtraGrid.Columns.GridColumn coldrinv;
		internal DevExpress.XtraGrid.Columns.GridColumn colsupplier;
		internal DevExpress.XtraGrid.Columns.GridColumn colstckid;
		internal DevExpress.XtraGrid.Columns.GridColumn colqty;
		internal DevExpress.XtraGrid.Columns.GridColumn collotno;
		internal DevExpress.XtraGrid.Columns.GridColumn colexpdate;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DoorsPOS.WinApp.dsspExpiration DsspExpiration;
		internal System.Windows.Forms.BindingSource SpExpirationDateBindingSource;
		internal DoorsPOS.WinApp.dsspExpirationTableAdapters.spExpirationDateTableAdapter spExpirationDateTableAdapter;
	}
	
}
