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
	partial class frmCashierReadng : System.Windows.Forms.Form
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
			this.PivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			base.Load += new System.EventHandler(frmCashierReadng_Load);
			this.PivotGridControl1.DoubleClick += new System.EventHandler(this.PivotGridControl1_DoubleClick);
			this.DsvwReading = new DoorsPOS.WinApp.dsvwReading();
			this.VwReadingBindingSource = new System.Windows.Forms.BindingSource();
			this.VwReadingTableAdapter = new DoorsPOS.WinApp.dsvwReadingTableAdapters.vwReadingTableAdapter();
			this.fieldbegincash = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldcashier = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fielddatereading = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldaddcash = new DevExpress.XtraPivotGrid.PivotGridField();
			this.PivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldonek = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldfh = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldth = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldoh = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldffty = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldtwnty = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldtp = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldfve = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldpeso = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldbinting = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldpayments = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldtotalcheque = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldtotalsales = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldpickup = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldtotalcredit = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldovershort = new DevExpress.XtraPivotGrid.PivotGridField();
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwReading).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwReadingBindingSource).BeginInit();
			this.SuspendLayout();
			//
			//PivotGridControl1
			//
			this.PivotGridControl1.DataSource = this.VwReadingBindingSource;
			this.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {this.fielddatereading, this.fieldcashier, this.fieldbegincash, this.PivotGridField1, this.fieldaddcash, this.fieldpayments, this.fieldonek, this.fieldfh, this.fieldth, this.fieldoh, this.fieldffty, this.fieldtwnty, this.fieldtp, this.fieldfve, this.fieldpeso, this.fieldbinting, this.fieldtotalcheque, this.fieldtotalsales, this.fieldpickup, this.fieldtotalcredit, this.fieldovershort});
			this.PivotGridControl1.Location = new System.Drawing.Point(0, 0);
			this.PivotGridControl1.Name = "PivotGridControl1";
			this.PivotGridControl1.Size = new System.Drawing.Size(963, 522);
			this.PivotGridControl1.TabIndex = 0;
			//
			//DsvwReading
			//
			this.DsvwReading.DataSetName = "dsvwReading";
			this.DsvwReading.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VwReadingBindingSource
			//
			this.VwReadingBindingSource.DataMember = "vwReading";
			this.VwReadingBindingSource.DataSource = this.DsvwReading;
			//
			//VwReadingTableAdapter
			//
			this.VwReadingTableAdapter.ClearBeforeFill = true;
			//
			//fieldbegincash
			//
			this.fieldbegincash.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldbegincash.AreaIndex = 0;
			this.fieldbegincash.Caption = "Beg. Cash";
			this.fieldbegincash.CellFormat.FormatString = "N2";
			this.fieldbegincash.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldbegincash.FieldName = "begincash";
			this.fieldbegincash.Name = "fieldbegincash";
			this.fieldbegincash.Width = 75;
			//
			//fieldcashier
			//
			this.fieldcashier.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldcashier.AreaIndex = 0;
			this.fieldcashier.Caption = "Cashier";
			this.fieldcashier.FieldName = "cashier";
			this.fieldcashier.Name = "fieldcashier";
			//
			//fielddatereading
			//
			this.fielddatereading.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fielddatereading.AreaIndex = 1;
			this.fielddatereading.Caption = "Date";
			this.fielddatereading.CellFormat.FormatString = "d";
			this.fielddatereading.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fielddatereading.FieldName = "datereading";
			this.fielddatereading.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
			this.fielddatereading.Name = "fielddatereading";
			this.fielddatereading.UnboundFieldName = "fielddatereading";
			this.fielddatereading.Width = 89;
			//
			//fieldaddcash
			//
			this.fieldaddcash.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldaddcash.AreaIndex = 1;
			this.fieldaddcash.Caption = "Additional Cash";
			this.fieldaddcash.CellFormat.FormatString = "N2";
			this.fieldaddcash.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldaddcash.FieldName = "addcash";
			this.fieldaddcash.Name = "fieldaddcash";
			this.fieldaddcash.Width = 84;
			//
			//PivotGridField1
			//
			this.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.PivotGridField1.AreaIndex = 2;
			this.PivotGridField1.Caption = "Cash Count";
			this.PivotGridField1.CellFormat.FormatString = "N2";
			this.PivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.PivotGridField1.Name = "PivotGridField1";
			this.PivotGridField1.UnboundExpression = "[onek] + [fh]+[th]+[oh]+[ffty]+[twnty]+[tp]+[fve]+[peso]+[binting]";
			this.PivotGridField1.UnboundFieldName = "CashCnt";
			this.PivotGridField1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.PivotGridField1.Width = 99;
			//
			//fieldonek
			//
			this.fieldonek.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldonek.AreaIndex = 5;
			this.fieldonek.FieldName = "onek";
			this.fieldonek.Name = "fieldonek";
			this.fieldonek.Visible = false;
			//
			//fieldfh
			//
			this.fieldfh.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldfh.AreaIndex = 5;
			this.fieldfh.FieldName = "fh";
			this.fieldfh.Name = "fieldfh";
			this.fieldfh.Visible = false;
			//
			//fieldth
			//
			this.fieldth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldth.AreaIndex = 5;
			this.fieldth.FieldName = "th";
			this.fieldth.Name = "fieldth";
			this.fieldth.Visible = false;
			//
			//fieldoh
			//
			this.fieldoh.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldoh.AreaIndex = 5;
			this.fieldoh.FieldName = "oh";
			this.fieldoh.Name = "fieldoh";
			this.fieldoh.Visible = false;
			//
			//fieldffty
			//
			this.fieldffty.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldffty.AreaIndex = 5;
			this.fieldffty.FieldName = "ffty";
			this.fieldffty.Name = "fieldffty";
			this.fieldffty.Visible = false;
			//
			//fieldtwnty
			//
			this.fieldtwnty.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldtwnty.AreaIndex = 5;
			this.fieldtwnty.FieldName = "twnty";
			this.fieldtwnty.Name = "fieldtwnty";
			this.fieldtwnty.Visible = false;
			//
			//fieldtp
			//
			this.fieldtp.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldtp.AreaIndex = 5;
			this.fieldtp.FieldName = "tp";
			this.fieldtp.Name = "fieldtp";
			this.fieldtp.Visible = false;
			//
			//fieldfve
			//
			this.fieldfve.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldfve.AreaIndex = 5;
			this.fieldfve.FieldName = "fve";
			this.fieldfve.Name = "fieldfve";
			this.fieldfve.Visible = false;
			//
			//fieldpeso
			//
			this.fieldpeso.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldpeso.AreaIndex = 5;
			this.fieldpeso.FieldName = "peso";
			this.fieldpeso.Name = "fieldpeso";
			this.fieldpeso.Visible = false;
			//
			//fieldbinting
			//
			this.fieldbinting.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldbinting.AreaIndex = 5;
			this.fieldbinting.FieldName = "binting";
			this.fieldbinting.Name = "fieldbinting";
			this.fieldbinting.Visible = false;
			//
			//fieldpayments
			//
			this.fieldpayments.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldpayments.AreaIndex = 3;
			this.fieldpayments.Caption = "Payments";
			this.fieldpayments.CellFormat.FormatString = "N2";
			this.fieldpayments.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldpayments.FieldName = "payments";
			this.fieldpayments.Name = "fieldpayments";
			this.fieldpayments.Width = 69;
			//
			//fieldtotalcheque
			//
			this.fieldtotalcheque.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldtotalcheque.AreaIndex = 4;
			this.fieldtotalcheque.Caption = "Total Cheques";
			this.fieldtotalcheque.CellFormat.FormatString = "N2";
			this.fieldtotalcheque.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldtotalcheque.FieldName = "totalcheque";
			this.fieldtotalcheque.Name = "fieldtotalcheque";
			//
			//fieldtotalsales
			//
			this.fieldtotalsales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldtotalsales.AreaIndex = 5;
			this.fieldtotalsales.Caption = "Total Sales";
			this.fieldtotalsales.CellFormat.FormatString = "N2";
			this.fieldtotalsales.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldtotalsales.FieldName = "totalsales";
			this.fieldtotalsales.Name = "fieldtotalsales";
			this.fieldtotalsales.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			//
			//fieldpickup
			//
			this.fieldpickup.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldpickup.AreaIndex = 6;
			this.fieldpickup.Caption = "Total Pickup";
			this.fieldpickup.CellFormat.FormatString = "N2";
			this.fieldpickup.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldpickup.FieldName = "pickup";
			this.fieldpickup.Name = "fieldpickup";
			this.fieldpickup.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldpickup.Width = 79;
			//
			//fieldtotalcredit
			//
			this.fieldtotalcredit.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldtotalcredit.AreaIndex = 7;
			this.fieldtotalcredit.Caption = "Total Credit";
			this.fieldtotalcredit.CellFormat.FormatString = "N2";
			this.fieldtotalcredit.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldtotalcredit.FieldName = "totalcredit";
			this.fieldtotalcredit.Name = "fieldtotalcredit";
			this.fieldtotalcredit.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldtotalcredit.Width = 81;
			//
			//fieldovershort
			//
			this.fieldovershort.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldovershort.AreaIndex = 8;
			this.fieldovershort.Caption = "Over/Short Total";
			this.fieldovershort.CellFormat.FormatString = "N2";
			this.fieldovershort.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldovershort.FieldName = "overshort";
			this.fieldovershort.Name = "fieldovershort";
			//
			//frmCashierReadng
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(963, 522);
			this.Controls.Add(this.PivotGridControl1);
			this.Name = "frmCashierReadng";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cashier Readng ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwReading).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwReadingBindingSource).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraPivotGrid.PivotGridControl PivotGridControl1;
		internal DoorsPOS.WinApp.dsvwReading DsvwReading;
		internal System.Windows.Forms.BindingSource VwReadingBindingSource;
		internal DoorsPOS.WinApp.dsvwReadingTableAdapters.vwReadingTableAdapter VwReadingTableAdapter;
		internal DevExpress.XtraPivotGrid.PivotGridField fielddatereading;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldcashier;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldbegincash;
		internal DevExpress.XtraPivotGrid.PivotGridField PivotGridField1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldaddcash;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldpayments;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldonek;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldfh;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldth;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldoh;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldffty;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldtwnty;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldtp;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldfve;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldpeso;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldbinting;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldtotalcheque;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldtotalsales;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldpickup;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldtotalcredit;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldovershort;
	}
	
}
