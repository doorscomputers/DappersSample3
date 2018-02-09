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
	partial class frmInvCostGrid : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmInvCostGrid_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.StocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsItemCostRetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsItemCostRetail = new DoorsPOS.WinApp.dsItemCostRetail();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colavailable = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcost = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colretail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.CostAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RetailAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.StocksTableAdapter = new DoorsPOS.WinApp.dsItemCostRetailTableAdapters.stocksTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.StocksBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemCostRetailBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemCostRetail).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.StocksBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(890, 491);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//StocksBindingSource
			//
			this.StocksBindingSource.DataMember = "stocks";
			this.StocksBindingSource.DataSource = this.DsItemCostRetailBindingSource;
			//
			//DsItemCostRetailBindingSource
			//
			this.DsItemCostRetailBindingSource.DataSource = this.DsItemCostRetail;
			this.DsItemCostRetailBindingSource.Position = 0;
			//
			//DsItemCostRetail
			//
			this.DsItemCostRetail.DataSetName = "dsItemCostRetail";
			this.DsItemCostRetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colitem_desc, this.colavailable, this.colcost, this.colretail, this.CostAmount, this.RetailAmount});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colretail, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Description";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 0;
			this.colitem_desc.Width = 326;
			//
			//colavailable
			//
			this.colavailable.AppearanceHeader.Options.UseTextOptions = true;
			this.colavailable.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colavailable.Caption = "Available";
			this.colavailable.FieldName = "available";
			this.colavailable.Name = "colavailable";
			this.colavailable.Visible = true;
			this.colavailable.VisibleIndex = 1;
			this.colavailable.Width = 67;
			//
			//colcost
			//
			this.colcost.AppearanceHeader.Options.UseTextOptions = true;
			this.colcost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colcost.Caption = "Cost";
			this.colcost.DisplayFormat.FormatString = "N2";
			this.colcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colcost.FieldName = "cost";
			this.colcost.Name = "colcost";
			this.colcost.Visible = true;
			this.colcost.VisibleIndex = 2;
			this.colcost.Width = 99;
			//
			//colretail
			//
			this.colretail.AppearanceHeader.Options.UseTextOptions = true;
			this.colretail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colretail.Caption = "Retail";
			this.colretail.DisplayFormat.FormatString = "N2";
			this.colretail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colretail.FieldName = "retail";
			this.colretail.Name = "colretail";
			this.colretail.Visible = true;
			this.colretail.VisibleIndex = 3;
			this.colretail.Width = 115;
			//
			//CostAmount
			//
			this.CostAmount.AppearanceHeader.Options.UseTextOptions = true;
			this.CostAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.CostAmount.Caption = "Cost Amount";
			this.CostAmount.DisplayFormat.FormatString = "N2";
			this.CostAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.CostAmount.FieldName = "CostAmount";
			this.CostAmount.Name = "CostAmount";
			this.CostAmount.UnboundExpression = "[available] * [cost]";
			this.CostAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.CostAmount.Visible = true;
			this.CostAmount.VisibleIndex = 4;
			this.CostAmount.Width = 217;
			//
			//RetailAmount
			//
			this.RetailAmount.AppearanceHeader.Options.UseTextOptions = true;
			this.RetailAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.RetailAmount.Caption = "Retail Amount";
			this.RetailAmount.DisplayFormat.FormatString = "N2";
			this.RetailAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.RetailAmount.FieldName = "RetailAmount";
			this.RetailAmount.Name = "RetailAmount";
			this.RetailAmount.UnboundExpression = "[available] * [retail]";
			this.RetailAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.RetailAmount.Visible = true;
			this.RetailAmount.VisibleIndex = 5;
			this.RetailAmount.Width = 242;
			//
			//StocksTableAdapter
			//
			this.StocksTableAdapter.ClearBeforeFill = true;
			//
			//frmInvCostGrid
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(890, 491);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmInvCostGrid";
			this.Text = "Inventory Cost Grid";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.StocksBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemCostRetailBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemCostRetail).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colavailable;
		internal DevExpress.XtraGrid.Columns.GridColumn colcost;
		internal DevExpress.XtraGrid.Columns.GridColumn colretail;
		internal System.Windows.Forms.BindingSource DsItemCostRetailBindingSource;
		internal DoorsPOS.WinApp.dsItemCostRetail DsItemCostRetail;
		internal System.Windows.Forms.BindingSource StocksBindingSource;
		internal DoorsPOS.WinApp.dsItemCostRetailTableAdapters.stocksTableAdapter StocksTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn CostAmount;
		internal DevExpress.XtraGrid.Columns.GridColumn RetailAmount;
	}
	
}
