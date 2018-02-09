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
	partial class frmIncentiveGrid : System.Windows.Forms.Form
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
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.DsIncentives1 = new DoorsPOS.WinApp.dsIncentives();
			this.grdIncentives = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colpos_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colincentive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colwaiter = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colwtid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwIncentivesTableAdapter1 = new DoorsPOS.WinApp.dsIncentivesTableAdapters.vwIncentivesTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.BindingSource1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsIncentives1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.grdIncentives).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.DataSource = this.BindingSource1;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.grdIncentives;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(980, 389);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdIncentives});
			//
			//BindingSource1
			//
			this.BindingSource1.DataMember = "vwIncentives";
			this.BindingSource1.DataSource = this.DsIncentives1;
			this.BindingSource1.Sort = "";
			//
			//DsIncentives1
			//
			this.DsIncentives1.DataSetName = "dsIncentives";
			this.DsIncentives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//grdIncentives
			//
			this.grdIncentives.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colpos_date, this.GridColumn1, this.colincentive, this.colwaiter, this.colwtid});
			this.grdIncentives.GridControl = this.GridControl1;
			this.grdIncentives.GroupCount = 1;
			this.grdIncentives.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "incentive", null, ""), new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "incentive", this.colincentive, "SUM={0:N2}")});
			this.grdIncentives.Name = "grdIncentives";
			this.grdIncentives.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
			this.grdIncentives.OptionsView.ShowFooter = true;
			this.grdIncentives.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colwaiter, DevExpress.Data.ColumnSortOrder.Descending)});
			//
			//colpos_date
			//
			this.colpos_date.Caption = "Date Sold";
			this.colpos_date.FieldName = "pos_date";
			this.colpos_date.Name = "colpos_date";
			this.colpos_date.Visible = true;
			this.colpos_date.VisibleIndex = 0;
			this.colpos_date.Width = 130;
			//
			//GridColumn1
			//
			this.GridColumn1.Caption = "Item Sold";
			this.GridColumn1.FieldName = "item_desc";
			this.GridColumn1.Name = "GridColumn1";
			this.GridColumn1.Visible = true;
			this.GridColumn1.VisibleIndex = 1;
			this.GridColumn1.Width = 324;
			//
			//colincentive
			//
			this.colincentive.Caption = "Incentive Amount";
			this.colincentive.DisplayFormat.FormatString = "N2";
			this.colincentive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colincentive.FieldName = "incentive";
			this.colincentive.GroupFormat.FormatString = "N2";
			this.colincentive.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colincentive.Name = "colincentive";
			this.colincentive.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "incentive", "SUM={0:N2}")});
			this.colincentive.Visible = true;
			this.colincentive.VisibleIndex = 2;
			this.colincentive.Width = 120;
			//
			//colwaiter
			//
			this.colwaiter.Caption = "Employee Name";
			this.colwaiter.FieldName = "waiter";
			this.colwaiter.Name = "colwaiter";
			this.colwaiter.Visible = true;
			this.colwaiter.VisibleIndex = 3;
			this.colwaiter.Width = 122;
			//
			//colwtid
			//
			this.colwtid.FieldName = "wtid";
			this.colwtid.Name = "colwtid";
			//
			//VwIncentivesTableAdapter1
			//
			this.VwIncentivesTableAdapter1.ClearBeforeFill = true;
			//
			//frmIncentiveGrid
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(980, 389);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmIncentiveGrid";
			this.Text = "Incentives Grid View";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.BindingSource1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsIncentives1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.grdIncentives).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView grdIncentives;
		internal System.Windows.Forms.BindingSource BindingSource1;
		internal DoorsPOS.WinApp.dsIncentives DsIncentives1;
		internal DevExpress.XtraGrid.Columns.GridColumn colpos_date;
		internal DevExpress.XtraGrid.Columns.GridColumn colincentive;
		internal DevExpress.XtraGrid.Columns.GridColumn colwaiter;
		internal DevExpress.XtraGrid.Columns.GridColumn colwtid;
		internal DoorsPOS.WinApp.dsIncentivesTableAdapters.vwIncentivesTableAdapter VwIncentivesTableAdapter1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
	}
	
}
