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
	partial class frmCreditGrid2 : System.Windows.Forms.Form
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
			this.VwCreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsCreditsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsCredits = new DoorsPOS.WinApp.dsCredits();
			this.VwCreditTableAdapter = new DoorsPOS.WinApp.dsCreditsTableAdapters.vwCreditTableAdapter();
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colpos_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Customer = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colqty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldet_amnt = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize) this.VwCreditBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsCreditsBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsCredits).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//VwCreditBindingSource
			//
			this.VwCreditBindingSource.DataMember = "vwCredit";
			this.VwCreditBindingSource.DataSource = this.DsCreditsBindingSource;
			//
			//DsCreditsBindingSource
			//
			this.DsCreditsBindingSource.DataSource = this.DsCredits;
			this.DsCreditsBindingSource.Position = 0;
			//
			//DsCredits
			//
			this.DsCredits.DataSetName = "dsCredits";
			this.DsCredits.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VwCreditTableAdapter
			//
			this.VwCreditTableAdapter.ClearBeforeFill = true;
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwCreditBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(965, 499);
			this.GridControl1.TabIndex = 1;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colpos_date, this.Customer, this.colitem_desc, this.colprice, this.colqty, this.coldet_amnt});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupCount = 2;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "det_amnt", this.coldet_amnt, "SUM={0:N2}")});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Customer, DevExpress.Data.ColumnSortOrder.Ascending), new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colpos_date, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colpos_date
			//
			this.colpos_date.Caption = "Credit Date";
			this.colpos_date.DisplayFormat.FormatString = "G";
			this.colpos_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colpos_date.FieldName = "pos_date";
			this.colpos_date.Name = "colpos_date";
			this.colpos_date.Visible = true;
			this.colpos_date.VisibleIndex = 4;
			//
			//Customer
			//
			this.Customer.Caption = "Customer";
			this.Customer.FieldName = "Customer";
			this.Customer.Name = "Customer";
			this.Customer.UnboundExpression = "[lastname]+\',\'+[firstname]+\' \'+[middlename]";
			this.Customer.UnboundType = DevExpress.Data.UnboundColumnType.String;
			this.Customer.Visible = true;
			this.Customer.VisibleIndex = 5;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Description";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 0;
			this.colitem_desc.Width = 83;
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
			//
			//colqty
			//
			this.colqty.AppearanceHeader.Options.UseTextOptions = true;
			this.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colqty.Caption = "Credit Qty";
			this.colqty.DisplayFormat.FormatString = "N0";
			this.colqty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colqty.FieldName = "qty";
			this.colqty.Name = "colqty";
			this.colqty.Visible = true;
			this.colqty.VisibleIndex = 2;
			//
			//coldet_amnt
			//
			this.coldet_amnt.Caption = "Amount";
			this.coldet_amnt.DisplayFormat.FormatString = "N2";
			this.coldet_amnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coldet_amnt.FieldName = "det_amnt";
			this.coldet_amnt.Name = "coldet_amnt";
			this.coldet_amnt.Visible = true;
			this.coldet_amnt.VisibleIndex = 3;
			//
			//frmCreditGrid2
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(965, 499);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmCreditGrid2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Credits Grid View 2";
			((System.ComponentModel.ISupportInitialize) this.VwCreditBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsCreditsBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsCredits).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.BindingSource VwCreditBindingSource;
		internal System.Windows.Forms.BindingSource DsCreditsBindingSource;
		internal DoorsPOS.WinApp.dsCredits DsCredits;
		internal DoorsPOS.WinApp.dsCreditsTableAdapters.vwCreditTableAdapter VwCreditTableAdapter;
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DevExpress.XtraGrid.Columns.GridColumn colpos_date;
		internal DevExpress.XtraGrid.Columns.GridColumn Customer;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colprice;
		internal DevExpress.XtraGrid.Columns.GridColumn colqty;
		internal DevExpress.XtraGrid.Columns.GridColumn coldet_amnt;
	}
	
}
