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
	partial class frmPdtoSuppliers : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmPdtoSuppliers_Load);
			this.PivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.PivotGridControl1.DoubleClick += new System.EventHandler(this.PivotGridControl1_DoubleClick);
			this.VwInvPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Dsinvpayvw = new DoorsPOS.WinApp.dsinvpayvw();
			this.fieldbank = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldchqno = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fielddrinv = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldpaydate = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldsupplier = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldpaydate1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldpaydate2 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldamnt = new DevExpress.XtraPivotGrid.PivotGridField();
			this.VwInvPaymentsTableAdapter = new DoorsPOS.WinApp.dsinvpayvwTableAdapters.vwInvPaymentsTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwInvPaymentsBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.Dsinvpayvw).BeginInit();
			this.SuspendLayout();
			//
			//PivotGridControl1
			//
			this.PivotGridControl1.DataSource = this.VwInvPaymentsBindingSource;
			this.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {this.fieldbank, this.fieldchqno, this.fielddrinv, this.fieldpaydate, this.fieldsupplier, this.fieldpaydate1, this.fieldpaydate2, this.fieldamnt});
			this.PivotGridControl1.Location = new System.Drawing.Point(0, 0);
			this.PivotGridControl1.Name = "PivotGridControl1";
			this.PivotGridControl1.Size = new System.Drawing.Size(953, 478);
			this.PivotGridControl1.TabIndex = 0;
			//
			//VwInvPaymentsBindingSource
			//
			this.VwInvPaymentsBindingSource.DataMember = "vwInvPayments";
			this.VwInvPaymentsBindingSource.DataSource = this.Dsinvpayvw;
			//
			//Dsinvpayvw
			//
			this.Dsinvpayvw.DataSetName = "dsinvpayvw";
			this.Dsinvpayvw.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//fieldbank
			//
			this.fieldbank.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldbank.AreaIndex = 2;
			this.fieldbank.Caption = "Bank";
			this.fieldbank.FieldName = "bank";
			this.fieldbank.Name = "fieldbank";
			this.fieldbank.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldbank.Width = 173;
			//
			//fieldchqno
			//
			this.fieldchqno.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldchqno.AreaIndex = 1;
			this.fieldchqno.Caption = "Cheque No.";
			this.fieldchqno.FieldName = "chqno";
			this.fieldchqno.Name = "fieldchqno";
			this.fieldchqno.Width = 152;
			//
			//fielddrinv
			//
			this.fielddrinv.AreaIndex = 1;
			this.fielddrinv.Caption = "Inv. No.";
			this.fielddrinv.FieldName = "drinv";
			this.fielddrinv.Name = "fielddrinv";
			this.fielddrinv.Width = 136;
			//
			//fieldpaydate
			//
			this.fieldpaydate.AreaIndex = 0;
			this.fieldpaydate.Caption = "Date Paid";
			this.fieldpaydate.CellFormat.FormatString = "d";
			this.fieldpaydate.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fieldpaydate.FieldName = "paydate";
			this.fieldpaydate.Name = "fieldpaydate";
			this.fieldpaydate.TotalCellFormat.FormatString = "d";
			this.fieldpaydate.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fieldpaydate.TotalValueFormat.FormatString = "d";
			this.fieldpaydate.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fieldpaydate.ValueFormat.FormatString = "d";
			this.fieldpaydate.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fieldpaydate.Width = 115;
			//
			//fieldsupplier
			//
			this.fieldsupplier.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldsupplier.AreaIndex = 0;
			this.fieldsupplier.Caption = "Supplier";
			this.fieldsupplier.FieldName = "supplier";
			this.fieldsupplier.Name = "fieldsupplier";
			this.fieldsupplier.Width = 207;
			//
			//fieldpaydate1
			//
			this.fieldpaydate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldpaydate1.AreaIndex = 0;
			this.fieldpaydate1.Caption = "Date Year";
			this.fieldpaydate1.FieldName = "paydate";
			this.fieldpaydate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldpaydate1.Name = "fieldpaydate1";
			this.fieldpaydate1.UnboundFieldName = "fieldpaydate1";
			//
			//fieldpaydate2
			//
			this.fieldpaydate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldpaydate2.AreaIndex = 1;
			this.fieldpaydate2.Caption = "Date Month";
			this.fieldpaydate2.FieldName = "paydate";
			this.fieldpaydate2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldpaydate2.Name = "fieldpaydate2";
			this.fieldpaydate2.UnboundFieldName = "fieldpaydate2";
			//
			//fieldamnt
			//
			this.fieldamnt.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldamnt.AreaIndex = 0;
			this.fieldamnt.Caption = "Amount Paid";
			this.fieldamnt.CellFormat.FormatString = "N2";
			this.fieldamnt.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldamnt.FieldName = "amnt";
			this.fieldamnt.Name = "fieldamnt";
			//
			//VwInvPaymentsTableAdapter
			//
			this.VwInvPaymentsTableAdapter.ClearBeforeFill = true;
			//
			//frmPdtoSuppliers
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(953, 478);
			this.Controls.Add(this.PivotGridControl1);
			this.Name = "frmPdtoSuppliers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Payments to Suppliers View2";
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwInvPaymentsBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.Dsinvpayvw).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraPivotGrid.PivotGridControl PivotGridControl1;
		internal DoorsPOS.WinApp.dsinvpayvw Dsinvpayvw;
		internal System.Windows.Forms.BindingSource VwInvPaymentsBindingSource;
		internal DoorsPOS.WinApp.dsinvpayvwTableAdapters.vwInvPaymentsTableAdapter VwInvPaymentsTableAdapter;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldbank;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldchqno;
		internal DevExpress.XtraPivotGrid.PivotGridField fielddrinv;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldpaydate;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldsupplier;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldpaydate1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldpaydate2;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldamnt;
	}
	
}
