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
	partial class frmBaltoSuplier : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmBaltoSuplier_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwBalSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsBaltoSupplier = new DoorsPOS.WinApp.dsBaltoSupplier();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colsupcode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsupplier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbalance = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwBalSupplierTableAdapter = new DoorsPOS.WinApp.dsBaltoSupplierTableAdapters.vwBalSupplierTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwBalSupplierBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsBaltoSupplier).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwBalSupplierBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(1003, 486);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwBalSupplierBindingSource
			//
			this.VwBalSupplierBindingSource.DataMember = "vwBalSupplier";
			this.VwBalSupplierBindingSource.DataSource = this.DsBaltoSupplier;
			//
			//DsBaltoSupplier
			//
			this.DsBaltoSupplier.DataSetName = "dsBaltoSupplier";
			this.DsBaltoSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colsupcode, this.colsupplier, this.coladdress, this.colbalance});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "balance", this.colbalance, "SUM={0:N2}")});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.OptionsBehavior.ReadOnly = true;
			this.GridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
			this.GridView1.OptionsView.ShowFooter = true;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colbalance, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colsupcode
			//
			this.colsupcode.FieldName = "supcode";
			this.colsupcode.Name = "colsupcode";
			this.colsupcode.OptionsColumn.ReadOnly = true;
			//
			//colsupplier
			//
			this.colsupplier.AppearanceHeader.Options.UseTextOptions = true;
			this.colsupplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.colsupplier.Caption = "Supplier";
			this.colsupplier.FieldName = "supplier";
			this.colsupplier.Name = "colsupplier";
			this.colsupplier.Visible = true;
			this.colsupplier.VisibleIndex = 0;
			this.colsupplier.Width = 275;
			//
			//coladdress
			//
			this.coladdress.AppearanceHeader.Options.UseTextOptions = true;
			this.coladdress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.coladdress.Caption = "Address";
			this.coladdress.FieldName = "address";
			this.coladdress.Name = "coladdress";
			this.coladdress.Visible = true;
			this.coladdress.VisibleIndex = 2;
			this.coladdress.Width = 651;
			//
			//colbalance
			//
			this.colbalance.AppearanceHeader.Options.UseTextOptions = true;
			this.colbalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colbalance.Caption = "Balance to Supplier";
			this.colbalance.DisplayFormat.FormatString = "N2";
			this.colbalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colbalance.FieldName = "balance";
			this.colbalance.Name = "colbalance";
			this.colbalance.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "balance", "SUM={0:N2}")});
			this.colbalance.Visible = true;
			this.colbalance.VisibleIndex = 1;
			this.colbalance.Width = 136;
			//
			//VwBalSupplierTableAdapter
			//
			this.VwBalSupplierTableAdapter.ClearBeforeFill = true;
			//
			//frmBaltoSuplier
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1003, 486);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmBaltoSuplier";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Balance to Suppliers";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwBalSupplierBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsBaltoSupplier).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsBaltoSupplier DsBaltoSupplier;
		internal System.Windows.Forms.BindingSource VwBalSupplierBindingSource;
		internal DoorsPOS.WinApp.dsBaltoSupplierTableAdapters.vwBalSupplierTableAdapter VwBalSupplierTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colsupcode;
		internal DevExpress.XtraGrid.Columns.GridColumn colsupplier;
		internal DevExpress.XtraGrid.Columns.GridColumn coladdress;
		internal DevExpress.XtraGrid.Columns.GridColumn colbalance;
	}
	
}
