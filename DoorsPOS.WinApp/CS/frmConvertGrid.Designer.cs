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
	partial class frmConvertGrid : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmConvertGrid_Load);
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwItemConvertBindingSource = new System.Windows.Forms.BindingSource();
			this.DsConvert = new DoorsPOS.WinApp.dsConvert();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colilid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltrans_Date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqtyconvertd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrevious_Stock_Balance = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRunning_Stock_Balance = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colstckid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwItemConvertTableAdapter = new DoorsPOS.WinApp.dsConvertTableAdapters.vwItemConvertTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwItemConvertBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsConvert).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwItemConvertBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(935, 486);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwItemConvertBindingSource
			//
			this.VwItemConvertBindingSource.DataMember = "vwItemConvert";
			this.VwItemConvertBindingSource.DataSource = this.DsConvert;
			//
			//DsConvert
			//
			this.DsConvert.DataSetName = "dsConvert";
			this.DsConvert.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colilid, this.coltrans_Date, this.colitem_desc, this.colqtyconvertd, this.colPrevious_Stock_Balance, this.colRunning_Stock_Balance, this.colstckid});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupCount = 1;
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colitem_desc, DevExpress.Data.ColumnSortOrder.Ascending), new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltrans_Date, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colilid
			//
			this.colilid.Caption = "Trans No.";
			this.colilid.FieldName = "ilid";
			this.colilid.Name = "colilid";
			this.colilid.Visible = true;
			this.colilid.VisibleIndex = 0;
			this.colilid.Width = 83;
			//
			//coltrans_Date
			//
			this.coltrans_Date.Caption = "Date Converted";
			this.coltrans_Date.FieldName = "trans_Date";
			this.coltrans_Date.Name = "coltrans_Date";
			this.coltrans_Date.Visible = true;
			this.coltrans_Date.VisibleIndex = 1;
			this.coltrans_Date.Width = 108;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Description";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 2;
			this.colitem_desc.Width = 277;
			//
			//colqtyconvertd
			//
			this.colqtyconvertd.Caption = "Qty Converted";
			this.colqtyconvertd.FieldName = "qtyconvertd";
			this.colqtyconvertd.Name = "colqtyconvertd";
			this.colqtyconvertd.Visible = true;
			this.colqtyconvertd.VisibleIndex = 2;
			this.colqtyconvertd.Width = 137;
			//
			//colPrevious_Stock_Balance
			//
			this.colPrevious_Stock_Balance.Caption = "Previous Stock Balance";
			this.colPrevious_Stock_Balance.FieldName = "Previous_Stock_Balance";
			this.colPrevious_Stock_Balance.Name = "colPrevious_Stock_Balance";
			this.colPrevious_Stock_Balance.Visible = true;
			this.colPrevious_Stock_Balance.VisibleIndex = 3;
			this.colPrevious_Stock_Balance.Width = 220;
			//
			//colRunning_Stock_Balance
			//
			this.colRunning_Stock_Balance.Caption = "Running Stock Balance";
			this.colRunning_Stock_Balance.FieldName = "Running_Stock_Balance";
			this.colRunning_Stock_Balance.Name = "colRunning_Stock_Balance";
			this.colRunning_Stock_Balance.Visible = true;
			this.colRunning_Stock_Balance.VisibleIndex = 4;
			this.colRunning_Stock_Balance.Width = 237;
			//
			//colstckid
			//
			this.colstckid.FieldName = "stckid";
			this.colstckid.Name = "colstckid";
			//
			//VwItemConvertTableAdapter
			//
			this.VwItemConvertTableAdapter.ClearBeforeFill = true;
			//
			//frmConvertGrid
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(935, 486);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmConvertGrid";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Items Converted to Pieces";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwItemConvertBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsConvert).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsConvert DsConvert;
		internal System.Windows.Forms.BindingSource VwItemConvertBindingSource;
		internal DoorsPOS.WinApp.dsConvertTableAdapters.vwItemConvertTableAdapter VwItemConvertTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colilid;
		internal DevExpress.XtraGrid.Columns.GridColumn coltrans_Date;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colqtyconvertd;
		internal DevExpress.XtraGrid.Columns.GridColumn colPrevious_Stock_Balance;
		internal DevExpress.XtraGrid.Columns.GridColumn colRunning_Stock_Balance;
		internal DevExpress.XtraGrid.Columns.GridColumn colstckid;
	}
	
}
