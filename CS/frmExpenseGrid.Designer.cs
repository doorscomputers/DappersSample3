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
	partial class frmExpenseGrid : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmExpenseGrid_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.TblExpenseTransBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsExpenses = new DoorsPOS.WinApp.dsExpenses();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colexpdate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colexpdesc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colexpamount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colexpremarks = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsInsert_id = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TblExpenseTransTableAdapter = new DoorsPOS.WinApp.dsExpensesTableAdapters.tblExpenseTransTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.TblExpenseTransBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsExpenses).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.TblExpenseTransBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(848, 426);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//TblExpenseTransBindingSource
			//
			this.TblExpenseTransBindingSource.DataMember = "tblExpenseTrans";
			this.TblExpenseTransBindingSource.DataSource = this.DsExpenses;
			//
			//DsExpenses
			//
			this.DsExpenses.DataSetName = "dsExpenses";
			this.DsExpenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colexpdate, this.colexpdesc, this.colexpamount, this.colexpremarks, this.colsInsert_id});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "expamount", this.colexpamount, "SUM={0:0.##}")});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.OptionsView.ShowFooter = true;
			//
			//colexpdate
			//
			this.colexpdate.Caption = "Date";
			this.colexpdate.FieldName = "expdate";
			this.colexpdate.Name = "colexpdate";
			this.colexpdate.Visible = true;
			this.colexpdate.VisibleIndex = 0;
			this.colexpdate.Width = 212;
			//
			//colexpdesc
			//
			this.colexpdesc.Caption = "Type";
			this.colexpdesc.FieldName = "expdesc";
			this.colexpdesc.Name = "colexpdesc";
			this.colexpdesc.Visible = true;
			this.colexpdesc.VisibleIndex = 1;
			this.colexpdesc.Width = 212;
			//
			//colexpamount
			//
			this.colexpamount.AppearanceHeader.Options.UseTextOptions = true;
			this.colexpamount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colexpamount.Caption = "Amount";
			this.colexpamount.DisplayFormat.FormatString = "N2";
			this.colexpamount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colexpamount.FieldName = "expamount";
			this.colexpamount.Name = "colexpamount";
			this.colexpamount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "expamount", "SUM={0:N2}")});
			this.colexpamount.Visible = true;
			this.colexpamount.VisibleIndex = 2;
			this.colexpamount.Width = 103;
			//
			//colexpremarks
			//
			this.colexpremarks.AppearanceCell.Options.UseTextOptions = true;
			this.colexpremarks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colexpremarks.AppearanceHeader.Options.UseTextOptions = true;
			this.colexpremarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colexpremarks.Caption = "Remark";
			this.colexpremarks.FieldName = "expremarks";
			this.colexpremarks.Name = "colexpremarks";
			this.colexpremarks.Visible = true;
			this.colexpremarks.VisibleIndex = 3;
			this.colexpremarks.Width = 266;
			//
			//colsInsert_id
			//
			this.colsInsert_id.Caption = "Encoded By";
			this.colsInsert_id.FieldName = "sInsert_id";
			this.colsInsert_id.Name = "colsInsert_id";
			this.colsInsert_id.Visible = true;
			this.colsInsert_id.VisibleIndex = 4;
			this.colsInsert_id.Width = 269;
			//
			//TblExpenseTransTableAdapter
			//
			this.TblExpenseTransTableAdapter.ClearBeforeFill = true;
			//
			//frmExpenseGrid
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(848, 426);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmExpenseGrid";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Expenses Grid View";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.TblExpenseTransBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsExpenses).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsExpenses DsExpenses;
		internal System.Windows.Forms.BindingSource TblExpenseTransBindingSource;
		internal DoorsPOS.WinApp.dsExpensesTableAdapters.tblExpenseTransTableAdapter TblExpenseTransTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colexpdate;
		internal DevExpress.XtraGrid.Columns.GridColumn colexpamount;
		internal DevExpress.XtraGrid.Columns.GridColumn colexpremarks;
		internal DevExpress.XtraGrid.Columns.GridColumn colsInsert_id;
		internal DevExpress.XtraGrid.Columns.GridColumn colexpdesc;
	}
	
}
