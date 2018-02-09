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
	partial class frmDiscountGrid : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmDiscountGrid_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.PoshdrBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsDiscount = new DoorsPOS.WinApp.dsDiscount();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.coldtInsert_dt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldisc_amnt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsInsert_id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Pos_hdrTableAdapter = new DoorsPOS.WinApp.dsDiscountTableAdapters.pos_hdrTableAdapter();
			this.colpostmp_hdrid = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PoshdrBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsDiscount).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.PoshdrBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(634, 509);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//PoshdrBindingSource
			//
			this.PoshdrBindingSource.DataMember = "pos_hdr";
			this.PoshdrBindingSource.DataSource = this.DsDiscount;
			//
			//DsDiscount
			//
			this.DsDiscount.DataSetName = "dsDiscount";
			this.DsDiscount.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colpostmp_hdrid, this.coldtInsert_dt, this.coldisc_amnt, this.colsInsert_id});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "disc_amnt", this.coldisc_amnt, "")});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.OptionsView.ShowFooter = true;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldtInsert_dt, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//coldtInsert_dt
			//
			this.coldtInsert_dt.Caption = "Date";
			this.coldtInsert_dt.FieldName = "dtInsert_dt";
			this.coldtInsert_dt.Name = "coldtInsert_dt";
			this.coldtInsert_dt.Visible = true;
			this.coldtInsert_dt.VisibleIndex = 0;
			this.coldtInsert_dt.Width = 175;
			//
			//coldisc_amnt
			//
			this.coldisc_amnt.AppearanceHeader.Options.UseTextOptions = true;
			this.coldisc_amnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coldisc_amnt.Caption = "Discount Amount";
			this.coldisc_amnt.DisplayFormat.FormatString = "N2";
			this.coldisc_amnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coldisc_amnt.FieldName = "disc_amnt";
			this.coldisc_amnt.Name = "coldisc_amnt";
			this.coldisc_amnt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "disc_amnt", "SUM={0:N2}")});
			this.coldisc_amnt.Visible = true;
			this.coldisc_amnt.VisibleIndex = 2;
			this.coldisc_amnt.Width = 129;
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
			this.colsInsert_id.VisibleIndex = 3;
			this.colsInsert_id.Width = 558;
			//
			//Pos_hdrTableAdapter
			//
			this.Pos_hdrTableAdapter.ClearBeforeFill = true;
			//
			//colpostmp_hdrid
			//
			this.colpostmp_hdrid.Caption = "Reference No.";
			this.colpostmp_hdrid.FieldName = "postmp_hdrid";
			this.colpostmp_hdrid.Name = "colpostmp_hdrid";
			this.colpostmp_hdrid.Visible = true;
			this.colpostmp_hdrid.VisibleIndex = 1;
			//
			//frmDiscountGrid
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 509);
			this.Controls.Add(this.GridControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDiscountGrid";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Discounts Grid View";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PoshdrBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsDiscount).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsDiscount DsDiscount;
		internal System.Windows.Forms.BindingSource PoshdrBindingSource;
		internal DoorsPOS.WinApp.dsDiscountTableAdapters.pos_hdrTableAdapter Pos_hdrTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn coldtInsert_dt;
		internal DevExpress.XtraGrid.Columns.GridColumn coldisc_amnt;
		internal DevExpress.XtraGrid.Columns.GridColumn colsInsert_id;
		internal DevExpress.XtraGrid.Columns.GridColumn colpostmp_hdrid;
	}
	
}
