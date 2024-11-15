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
	partial class frmBuyPrcHistory : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmBuyPrcHistory_Load);
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwBuyPriceHistoryBindingSource = new System.Windows.Forms.BindingSource();
			this.DsBuyPrice = new DoorsPOS.WinApp.dsBuyPrice();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colcost = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldrdate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsupplier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DsBuyPriceBindingSource = new System.Windows.Forms.BindingSource();
			this.VwBuyPriceHistoryTableAdapter = new DoorsPOS.WinApp.dsBuyPriceTableAdapters.vwBuyPriceHistoryTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwBuyPriceHistoryBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsBuyPrice).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsBuyPriceBindingSource).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwBuyPriceHistoryBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(687, 519);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwBuyPriceHistoryBindingSource
			//
			this.VwBuyPriceHistoryBindingSource.DataMember = "vwBuyPriceHistory";
			this.VwBuyPriceHistoryBindingSource.DataSource = this.DsBuyPrice;
			//
			//DsBuyPrice
			//
			this.DsBuyPrice.DataSetName = "dsBuyPrice";
			this.DsBuyPrice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colcost, this.colitem_desc, this.coldrdate, this.colsupplier});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupCount = 1;
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colitem_desc, DevExpress.Data.ColumnSortOrder.Ascending), new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colsupplier, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colcost
			//
			this.colcost.AppearanceCell.Options.UseTextOptions = true;
			this.colcost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colcost.AppearanceHeader.Options.UseTextOptions = true;
			this.colcost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colcost.Caption = "Cost";
			this.colcost.DisplayFormat.FormatString = "N2";
			this.colcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colcost.FieldName = "cost";
			this.colcost.Name = "colcost";
			this.colcost.Visible = true;
			this.colcost.VisibleIndex = 1;
			this.colcost.Width = 104;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Description";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 0;
			//
			//coldrdate
			//
			this.coldrdate.Caption = "Purchase Date ";
			this.coldrdate.FieldName = "drdate";
			this.coldrdate.Name = "coldrdate";
			this.coldrdate.Visible = true;
			this.coldrdate.VisibleIndex = 0;
			this.coldrdate.Width = 354;
			//
			//colsupplier
			//
			this.colsupplier.AppearanceCell.Options.UseTextOptions = true;
			this.colsupplier.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colsupplier.AppearanceHeader.Options.UseTextOptions = true;
			this.colsupplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colsupplier.Caption = "Supplier";
			this.colsupplier.FieldName = "supplier";
			this.colsupplier.Name = "colsupplier";
			this.colsupplier.Visible = true;
			this.colsupplier.VisibleIndex = 2;
			this.colsupplier.Width = 606;
			//
			//DsBuyPriceBindingSource
			//
			this.DsBuyPriceBindingSource.DataSource = this.DsBuyPrice;
			this.DsBuyPriceBindingSource.Position = 0;
			//
			//VwBuyPriceHistoryTableAdapter
			//
			this.VwBuyPriceHistoryTableAdapter.ClearBeforeFill = true;
			//
			//frmBuyPrcHistory
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 519);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmBuyPrcHistory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Item Buying Price History";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwBuyPriceHistoryBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsBuyPrice).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsBuyPriceBindingSource).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsBuyPrice DsBuyPrice;
		internal System.Windows.Forms.BindingSource VwBuyPriceHistoryBindingSource;
		internal DoorsPOS.WinApp.dsBuyPriceTableAdapters.vwBuyPriceHistoryTableAdapter VwBuyPriceHistoryTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn coldrdate;
		internal DevExpress.XtraGrid.Columns.GridColumn colcost;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colsupplier;
		internal System.Windows.Forms.BindingSource DsBuyPriceBindingSource;
	}
	
}
