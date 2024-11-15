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
	partial class frmSales2DayCashr : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmSales2DayCashr_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwSalesTodayCshrBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsSale2dayCashrBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsSale2dayCashr = new DoorsPOS.WinApp.dsSale2dayCashr();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colpos_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsInsert_id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltotsales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwSalesTodayCshrTableAdapter = new DoorsPOS.WinApp.dsSale2dayCashrTableAdapters.vwSalesTodayCshrTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwSalesTodayCshrBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsSale2dayCashrBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsSale2dayCashr).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwSalesTodayCshrBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(831, 440);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwSalesTodayCshrBindingSource
			//
			this.VwSalesTodayCshrBindingSource.DataMember = "vwSalesTodayCshr";
			this.VwSalesTodayCshrBindingSource.DataSource = this.DsSale2dayCashrBindingSource;
			//
			//DsSale2dayCashrBindingSource
			//
			this.DsSale2dayCashrBindingSource.DataSource = this.DsSale2dayCashr;
			this.DsSale2dayCashrBindingSource.Position = 0;
			//
			//DsSale2dayCashr
			//
			this.DsSale2dayCashr.DataSetName = "dsSale2dayCashr";
			this.DsSale2dayCashr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colpos_date, this.colsInsert_id, this.coltotsales});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupCount = 1;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "totsales", this.coltotsales, "SUM={0:0.##}")});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colsInsert_id, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colpos_date
			//
			this.colpos_date.Caption = "Date ";
			this.colpos_date.FieldName = "pos_date";
			this.colpos_date.Name = "colpos_date";
			this.colpos_date.Visible = true;
			this.colpos_date.VisibleIndex = 0;
			//
			//colsInsert_id
			//
			this.colsInsert_id.Caption = "Cashier";
			this.colsInsert_id.FieldName = "sInsert_id";
			this.colsInsert_id.Name = "colsInsert_id";
			this.colsInsert_id.Visible = true;
			this.colsInsert_id.VisibleIndex = 1;
			//
			//coltotsales
			//
			this.coltotsales.Caption = "Sales";
			this.coltotsales.DisplayFormat.FormatString = "N2";
			this.coltotsales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coltotsales.FieldName = "totsales";
			this.coltotsales.Name = "coltotsales";
			this.coltotsales.Visible = true;
			this.coltotsales.VisibleIndex = 1;
			//
			//VwSalesTodayCshrTableAdapter
			//
			this.VwSalesTodayCshrTableAdapter.ClearBeforeFill = true;
			//
			//frmSales2DayCashr
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 440);
			this.Controls.Add(this.GridControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSales2DayCashr";
			this.Text = "Sales Today per Cashier";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwSalesTodayCshrBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsSale2dayCashrBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsSale2dayCashr).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal System.Windows.Forms.BindingSource DsSale2dayCashrBindingSource;
		internal DoorsPOS.WinApp.dsSale2dayCashr DsSale2dayCashr;
		internal System.Windows.Forms.BindingSource VwSalesTodayCshrBindingSource;
		internal DoorsPOS.WinApp.dsSale2dayCashrTableAdapters.vwSalesTodayCshrTableAdapter VwSalesTodayCshrTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colpos_date;
		internal DevExpress.XtraGrid.Columns.GridColumn colsInsert_id;
		internal DevExpress.XtraGrid.Columns.GridColumn coltotsales;
	}
	
}
