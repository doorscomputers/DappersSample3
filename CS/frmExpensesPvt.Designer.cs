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
	partial class frmExpensesPvt : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmExpensesPvt_Load);
			this.PivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.PivotGridControl1.DoubleClick += new System.EventHandler(this.PivotGridControl1_DoubleClick);
			this.DsExpenses = new DoorsPOS.WinApp.dsExpenses();
			this.TblExpenseTransBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.TblExpenseTransTableAdapter = new DoorsPOS.WinApp.dsExpensesTableAdapters.tblExpenseTransTableAdapter();
			this.fieldexpdate = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldexpdesc = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldexpamount = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldexpdate1 = new DevExpress.XtraPivotGrid.PivotGridField();
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsExpenses).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.TblExpenseTransBindingSource).BeginInit();
			this.SuspendLayout();
			//
			//PivotGridControl1
			//
			this.PivotGridControl1.DataSource = this.TblExpenseTransBindingSource;
			this.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {this.fieldexpdate1, this.fieldexpdate, this.fieldexpdesc, this.fieldexpamount});
			this.PivotGridControl1.Location = new System.Drawing.Point(0, 0);
			this.PivotGridControl1.Name = "PivotGridControl1";
			this.PivotGridControl1.Size = new System.Drawing.Size(932, 519);
			this.PivotGridControl1.TabIndex = 0;
			//
			//DsExpenses
			//
			this.DsExpenses.DataSetName = "dsExpenses";
			this.DsExpenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//TblExpenseTransBindingSource
			//
			this.TblExpenseTransBindingSource.DataMember = "tblExpenseTrans";
			this.TblExpenseTransBindingSource.DataSource = this.DsExpenses;
			//
			//TblExpenseTransTableAdapter
			//
			this.TblExpenseTransTableAdapter.ClearBeforeFill = true;
			//
			//fieldexpdate
			//
			this.fieldexpdate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldexpdate.AreaIndex = 1;
			this.fieldexpdate.Caption = "Month";
			this.fieldexpdate.FieldName = "expdate";
			this.fieldexpdate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldexpdate.Name = "fieldexpdate";
			this.fieldexpdate.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldexpdate.UnboundFieldName = "fieldexpdate";
			//
			//fieldexpdesc
			//
			this.fieldexpdesc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldexpdesc.AreaIndex = 0;
			this.fieldexpdesc.Caption = "Description";
			this.fieldexpdesc.FieldName = "expdesc";
			this.fieldexpdesc.Name = "fieldexpdesc";
			this.fieldexpdesc.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			//
			//fieldexpamount
			//
			this.fieldexpamount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldexpamount.AreaIndex = 0;
			this.fieldexpamount.Caption = "Amount";
			this.fieldexpamount.FieldName = "expamount";
			this.fieldexpamount.Name = "fieldexpamount";
			//
			//fieldexpdate1
			//
			this.fieldexpdate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldexpdate1.AreaIndex = 0;
			this.fieldexpdate1.Caption = "Year";
			this.fieldexpdate1.FieldName = "expdate";
			this.fieldexpdate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldexpdate1.Name = "fieldexpdate1";
			this.fieldexpdate1.UnboundFieldName = "fieldexpdate1";
			//
			//frmExpensesPvt
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(932, 519);
			this.Controls.Add(this.PivotGridControl1);
			this.Name = "frmExpensesPvt";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Expenses Grid View 2";
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsExpenses).EndInit();
			((System.ComponentModel.ISupportInitialize) this.TblExpenseTransBindingSource).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraPivotGrid.PivotGridControl PivotGridControl1;
		internal DoorsPOS.WinApp.dsExpenses DsExpenses;
		internal System.Windows.Forms.BindingSource TblExpenseTransBindingSource;
		internal DoorsPOS.WinApp.dsExpensesTableAdapters.tblExpenseTransTableAdapter TblExpenseTransTableAdapter;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldexpdate1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldexpdate;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldexpdesc;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldexpamount;
	}
	
}
