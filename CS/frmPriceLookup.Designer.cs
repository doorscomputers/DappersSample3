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
	partial class frmPriceLookup : System.Windows.Forms.Form
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
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmPriceLookup_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(frmPriceLookup_KeyDown);
			base.Load += new System.EventHandler(frmPriceLookup_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.VwItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsvwItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsvwItems = new DoorsPOS.WinApp.dsvwItems();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colavailable = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colretail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colretail2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwItemsTableAdapter = new DoorsPOS.WinApp.dsvwItemsTableAdapters.vwItemsTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwItemsBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwItemsBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwItems).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwItemsBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.LookAndFeel.SkinName = "Office 2013";
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(903, 479);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwItemsBindingSource
			//
			this.VwItemsBindingSource.DataMember = "vwItems";
			this.VwItemsBindingSource.DataSource = this.DsvwItemsBindingSource;
			//
			//DsvwItemsBindingSource
			//
			this.DsvwItemsBindingSource.DataSource = this.DsvwItems;
			this.DsvwItemsBindingSource.Position = 0;
			//
			//DsvwItems
			//
			this.DsvwItems.DataSetName = "dsvwItems";
			this.DsvwItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
			this.GridView1.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
			this.GridView1.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
			this.GridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GridView1.Appearance.FilterPanel.Options.UseFont = true;
			this.GridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView1.Appearance.FocusedRow.Options.UseFont = true;
			this.GridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView1.Appearance.GroupPanel.Options.UseFont = true;
			this.GridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GridView1.Appearance.HeaderPanel.Options.UseFont = true;
			this.GridView1.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GridView1.Appearance.Preview.Options.UseFont = true;
			this.GridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView1.Appearance.SelectedRow.Options.UseFont = true;
			this.GridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView1.Appearance.ViewCaption.Options.UseFont = true;
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colbarcode, this.colitem_desc, this.colavailable, this.colretail, this.colretail2});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.Name = "GridView1";
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colbarcode, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colbarcode
			//
			this.colbarcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colbarcode.AppearanceCell.Options.UseFont = true;
			this.colbarcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colbarcode.AppearanceHeader.Options.UseFont = true;
			this.colbarcode.AppearanceHeader.Options.UseTextOptions = true;
			this.colbarcode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colbarcode.Caption = "Barcode";
			this.colbarcode.FieldName = "barcode";
			this.colbarcode.Name = "colbarcode";
			this.colbarcode.OptionsColumn.ReadOnly = true;
			this.colbarcode.Visible = true;
			this.colbarcode.VisibleIndex = 0;
			//
			//colitem_desc
			//
			this.colitem_desc.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colitem_desc.AppearanceCell.Options.UseFont = true;
			this.colitem_desc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colitem_desc.AppearanceHeader.Options.UseFont = true;
			this.colitem_desc.Caption = "Item Description";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.OptionsColumn.ReadOnly = true;
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 1;
			//
			//colavailable
			//
			this.colavailable.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colavailable.AppearanceCell.Options.UseFont = true;
			this.colavailable.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colavailable.AppearanceHeader.Options.UseFont = true;
			this.colavailable.Caption = "Available";
			this.colavailable.FieldName = "available";
			this.colavailable.Name = "colavailable";
			this.colavailable.OptionsColumn.ReadOnly = true;
			this.colavailable.Visible = true;
			this.colavailable.VisibleIndex = 2;
			//
			//colretail
			//
			this.colretail.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colretail.AppearanceCell.Options.UseFont = true;
			this.colretail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colretail.AppearanceHeader.Options.UseFont = true;
			this.colretail.AppearanceHeader.Options.UseTextOptions = true;
			this.colretail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colretail.Caption = "Retail";
			this.colretail.DisplayFormat.FormatString = "N2";
			this.colretail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colretail.FieldName = "retail";
			this.colretail.Name = "colretail";
			this.colretail.OptionsColumn.ReadOnly = true;
			this.colretail.Visible = true;
			this.colretail.VisibleIndex = 3;
			//
			//colretail2
			//
			this.colretail2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colretail2.AppearanceCell.Options.UseFont = true;
			this.colretail2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colretail2.AppearanceHeader.Options.UseFont = true;
			this.colretail2.AppearanceHeader.Options.UseTextOptions = true;
			this.colretail2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colretail2.Caption = "Wholesale";
			this.colretail2.DisplayFormat.FormatString = "N2";
			this.colretail2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colretail2.FieldName = "retail2";
			this.colretail2.Name = "colretail2";
			this.colretail2.OptionsColumn.ReadOnly = true;
			this.colretail2.Visible = true;
			this.colretail2.VisibleIndex = 4;
			//
			//VwItemsTableAdapter
			//
			this.VwItemsTableAdapter.ClearBeforeFill = true;
			//
			//frmPriceLookup
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(903, 479);
			this.Controls.Add(this.GridControl1);
			this.KeyPreview = true;
			this.MinimizeBox = false;
			this.Name = "frmPriceLookup";
			this.Text = "Price Lookup";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwItemsBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwItemsBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwItems).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal System.Windows.Forms.BindingSource DsvwItemsBindingSource;
		internal DoorsPOS.WinApp.dsvwItems DsvwItems;
		internal System.Windows.Forms.BindingSource VwItemsBindingSource;
		internal DoorsPOS.WinApp.dsvwItemsTableAdapters.vwItemsTableAdapter VwItemsTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colbarcode;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colavailable;
		internal DevExpress.XtraGrid.Columns.GridColumn colretail;
		internal DevExpress.XtraGrid.Columns.GridColumn colretail2;
	}
	
}
