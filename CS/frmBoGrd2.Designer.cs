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
	partial class frmBoGrd2 : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmBoGrd2_Load);
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwBOBindingSource = new System.Windows.Forms.BindingSource();
			this.DsBO = new DoorsPOS.WinApp.dsBO();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colbodate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsupplier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsInsert_id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwBOTableAdapter = new DoorsPOS.WinApp.dsBOTableAdapters.vwBOTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwBOBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsBO).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwBOBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(858, 498);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwBOBindingSource
			//
			this.VwBOBindingSource.DataMember = "vwBO";
			this.VwBOBindingSource.DataSource = this.DsBO;
			//
			//DsBO
			//
			this.DsBO.DataSetName = "dsBO";
			this.DsBO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colbodate, this.colqty, this.colitem_desc, this.colsupplier, this.colsInsert_id});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colqty, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colbodate
			//
			this.colbodate.Caption = "Date Returned";
			this.colbodate.FieldName = "bodate";
			this.colbodate.Name = "colbodate";
			this.colbodate.Visible = true;
			this.colbodate.VisibleIndex = 0;
			this.colbodate.Width = 128;
			//
			//colqty
			//
			this.colqty.AppearanceHeader.Options.UseTextOptions = true;
			this.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colqty.Caption = "Qty Returned";
			this.colqty.FieldName = "qty";
			this.colqty.Name = "colqty";
			this.colqty.Visible = true;
			this.colqty.VisibleIndex = 1;
			this.colqty.Width = 125;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Description";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 3;
			this.colitem_desc.Width = 333;
			//
			//colsupplier
			//
			this.colsupplier.Caption = "Supplier";
			this.colsupplier.FieldName = "supplier";
			this.colsupplier.Name = "colsupplier";
			this.colsupplier.Visible = true;
			this.colsupplier.VisibleIndex = 4;
			this.colsupplier.Width = 340;
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
			this.colsInsert_id.VisibleIndex = 2;
			this.colsInsert_id.Width = 140;
			//
			//VwBOTableAdapter
			//
			this.VwBOTableAdapter.ClearBeforeFill = true;
			//
			//frmBoGrd2
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(858, 498);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmBoGrd2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "BO Grid View2";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwBOBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsBO).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsBO DsBO;
		internal System.Windows.Forms.BindingSource VwBOBindingSource;
		internal DoorsPOS.WinApp.dsBOTableAdapters.vwBOTableAdapter VwBOTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colbodate;
		internal DevExpress.XtraGrid.Columns.GridColumn colqty;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colsupplier;
		internal DevExpress.XtraGrid.Columns.GridColumn colsInsert_id;
	}
	
}
