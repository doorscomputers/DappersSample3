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
	partial class frmpvtSales : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmpvtSales_Load);
			this.C1DataViewSet1 = new C1.C1DataExtender.C1DataViewSet();
			this.DsItemsSold = new DoorsPOS.WinApp.dsItemsSold();
			this.VwSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.VwSalesTableAdapter = new DoorsPOS.WinApp.dsItemsSoldTableAdapters.vwSalesTableAdapter();
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.coldtInsert_dt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldet_amnt = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize) this.C1DataViewSet1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemsSold).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwSalesBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//C1DataViewSet1
			//
			this.C1DataViewSet1.DataSet = this.DsItemsSold;
			this.C1DataViewSet1.DiagramXML = "";
			//
			//DsItemsSold
			//
			this.DsItemsSold.DataSetName = "dsItemsSold";
			this.DsItemsSold.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VwSalesBindingSource
			//
			this.VwSalesBindingSource.DataMember = "vwSales";
			this.VwSalesBindingSource.DataSource = this.DsItemsSold;
			//
			//VwSalesTableAdapter
			//
			this.VwSalesTableAdapter.ClearBeforeFill = true;
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwSalesBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(1071, 488);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.coldtInsert_dt, this.colitem_desc, this.colprice, this.colqty, this.coldet_amnt});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupCount = 1;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qty", this.colqty, "(SUM={0:#}) "), new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", this.coldet_amnt, "(SUM={0:#.##}) ")});
			this.GridView1.Name = "GridView1";
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colitem_desc, DevExpress.Data.ColumnSortOrder.Ascending), new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldtInsert_dt, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//coldtInsert_dt
			//
			this.coldtInsert_dt.Caption = "Date Sold";
			this.coldtInsert_dt.FieldName = "dtInsert_dt";
			this.coldtInsert_dt.Name = "coldtInsert_dt";
			this.coldtInsert_dt.Visible = true;
			this.coldtInsert_dt.VisibleIndex = 0;
			this.coldtInsert_dt.Width = 153;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Items Sold";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 1;
			this.colitem_desc.Width = 364;
			//
			//colprice
			//
			this.colprice.AppearanceHeader.Options.UseTextOptions = true;
			this.colprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colprice.Caption = "Price";
			this.colprice.DisplayFormat.FormatString = "N2";
			this.colprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colprice.FieldName = "price";
			this.colprice.Name = "colprice";
			this.colprice.Visible = true;
			this.colprice.VisibleIndex = 1;
			this.colprice.Width = 193;
			//
			//colqty
			//
			this.colqty.AppearanceHeader.Options.UseTextOptions = true;
			this.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colqty.Caption = "Qty Sold";
			this.colqty.FieldName = "qty";
			this.colqty.Name = "colqty";
			this.colqty.Visible = true;
			this.colqty.VisibleIndex = 2;
			this.colqty.Width = 108;
			//
			//coldet_amnt
			//
			this.coldet_amnt.AppearanceHeader.Options.UseTextOptions = true;
			this.coldet_amnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coldet_amnt.Caption = "Amount";
			this.coldet_amnt.DisplayFormat.FormatString = "N2";
			this.coldet_amnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coldet_amnt.FieldName = "det_amnt";
			this.coldet_amnt.Name = "coldet_amnt";
			this.coldet_amnt.Visible = true;
			this.coldet_amnt.VisibleIndex = 3;
			this.coldet_amnt.Width = 248;
			//
			//frmpvtSales
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1071, 488);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmpvtSales";
			this.Text = "Items Sold";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize) this.C1DataViewSet1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsItemsSold).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwSalesBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal C1.C1DataExtender.C1DataViewSet C1DataViewSet1;
		internal DoorsPOS.WinApp.dsItemsSold DsItemsSold;
		internal System.Windows.Forms.BindingSource VwSalesBindingSource;
		internal DoorsPOS.WinApp.dsItemsSoldTableAdapters.vwSalesTableAdapter VwSalesTableAdapter;
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DevExpress.XtraGrid.Columns.GridColumn coldtInsert_dt;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colprice;
		internal DevExpress.XtraGrid.Columns.GridColumn colqty;
		internal DevExpress.XtraGrid.Columns.GridColumn coldet_amnt;
	}
	
}
