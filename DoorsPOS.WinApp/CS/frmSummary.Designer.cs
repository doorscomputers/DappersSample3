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
	partial class frmSummary : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmSummary_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.TblreadingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsReading = new DoorsPOS.WinApp.dsReading();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colcashreadid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldatereading = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltotalsales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbegincash = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colpickup = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coladdcash = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltotalrefs = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colovershort = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcashier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colchangeprice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltotaldiscount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltransfer = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colpayments = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltotalcredit = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltotalcheque = new DevExpress.XtraGrid.Columns.GridColumn();
			this.tblreadingTableAdapter = new DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.TblreadingBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsReading).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.DataSource = this.TblreadingBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.gridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(906, 447);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gridView1});
			//
			//TblreadingBindingSource
			//
			this.TblreadingBindingSource.DataMember = "tblreading";
			this.TblreadingBindingSource.DataSource = this.DsReading;
			//
			//DsReading
			//
			this.DsReading.DataSetName = "dsReading";
			this.DsReading.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//gridView1
			//
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colcashreadid, this.coldatereading, this.coltotalsales, this.colbegincash, this.colpickup, this.coladdcash, this.coltotalrefs, this.colovershort, this.colcashier, this.colchangeprice, this.coltotaldiscount, this.coltransfer, this.colpayments, this.coltotalcredit, this.coltotalcheque});
			this.gridView1.GridControl = this.GridControl1;
			this.gridView1.Name = "gridView1";
			//
			//colcashreadid
			//
			this.colcashreadid.FieldName = "cashreadid";
			this.colcashreadid.Name = "colcashreadid";
			this.colcashreadid.OptionsColumn.ReadOnly = true;
			//
			//coldatereading
			//
			this.coldatereading.Caption = "Date";
			this.coldatereading.FieldName = "datereading";
			this.coldatereading.Name = "coldatereading";
			this.coldatereading.Visible = true;
			this.coldatereading.VisibleIndex = 1;
			this.coldatereading.Width = 134;
			//
			//coltotalsales
			//
			this.coltotalsales.AppearanceHeader.Options.UseTextOptions = true;
			this.coltotalsales.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coltotalsales.Caption = "Total Sales";
			this.coltotalsales.DisplayFormat.FormatString = "n2";
			this.coltotalsales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coltotalsales.FieldName = "totalsales";
			this.coltotalsales.Name = "coltotalsales";
			this.coltotalsales.Visible = true;
			this.coltotalsales.VisibleIndex = 3;
			this.coltotalsales.Width = 138;
			//
			//colbegincash
			//
			this.colbegincash.Caption = "Beginning Cash";
			this.colbegincash.DisplayFormat.FormatString = "N2";
			this.colbegincash.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colbegincash.FieldName = "begincash";
			this.colbegincash.Name = "colbegincash";
			this.colbegincash.Visible = true;
			this.colbegincash.VisibleIndex = 2;
			this.colbegincash.Width = 112;
			//
			//colpickup
			//
			this.colpickup.AppearanceHeader.Options.UseTextOptions = true;
			this.colpickup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colpickup.Caption = "Petty Cash";
			this.colpickup.DisplayFormat.FormatString = "n2";
			this.colpickup.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colpickup.FieldName = "pickup";
			this.colpickup.Name = "colpickup";
			this.colpickup.Visible = true;
			this.colpickup.VisibleIndex = 5;
			this.colpickup.Width = 138;
			//
			//coladdcash
			//
			this.coladdcash.AppearanceHeader.Options.UseTextOptions = true;
			this.coladdcash.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coladdcash.Caption = "Add Fund";
			this.coladdcash.DisplayFormat.FormatString = "n2";
			this.coladdcash.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coladdcash.FieldName = "addcash";
			this.coladdcash.Name = "coladdcash";
			this.coladdcash.Visible = true;
			this.coladdcash.VisibleIndex = 4;
			this.coladdcash.Width = 138;
			//
			//coltotalrefs
			//
			this.coltotalrefs.AppearanceHeader.Options.UseTextOptions = true;
			this.coltotalrefs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coltotalrefs.Caption = "Refunds";
			this.coltotalrefs.DisplayFormat.FormatString = "n2";
			this.coltotalrefs.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coltotalrefs.FieldName = "totalrefs";
			this.coltotalrefs.Name = "coltotalrefs";
			this.coltotalrefs.Visible = true;
			this.coltotalrefs.VisibleIndex = 6;
			this.coltotalrefs.Width = 138;
			//
			//colovershort
			//
			this.colovershort.AppearanceHeader.Options.UseTextOptions = true;
			this.colovershort.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colovershort.Caption = "Short/Over";
			this.colovershort.DisplayFormat.FormatString = "n2";
			this.colovershort.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colovershort.FieldName = "overshort";
			this.colovershort.Name = "colovershort";
			this.colovershort.Visible = true;
			this.colovershort.VisibleIndex = 7;
			this.colovershort.Width = 146;
			//
			//colcashier
			//
			this.colcashier.Caption = "Cashier";
			this.colcashier.FieldName = "cashier";
			this.colcashier.Name = "colcashier";
			this.colcashier.Visible = true;
			this.colcashier.VisibleIndex = 0;
			this.colcashier.Width = 134;
			//
			//colchangeprice
			//
			this.colchangeprice.FieldName = "changeprice";
			this.colchangeprice.Name = "colchangeprice";
			//
			//coltotaldiscount
			//
			this.coltotaldiscount.Caption = "Total Discount";
			this.coltotaldiscount.FieldName = "totaldiscount";
			this.coltotaldiscount.Name = "coltotaldiscount";
			//
			//coltransfer
			//
			this.coltransfer.FieldName = "transfer";
			this.coltransfer.Name = "coltransfer";
			//
			//colpayments
			//
			this.colpayments.Caption = "Payments";
			this.colpayments.FieldName = "payments";
			this.colpayments.Name = "colpayments";
			//
			//coltotalcredit
			//
			this.coltotalcredit.Caption = "Total Credit";
			this.coltotalcredit.FieldName = "totalcredit";
			this.coltotalcredit.Name = "coltotalcredit";
			//
			//coltotalcheque
			//
			this.coltotalcheque.FieldName = "totalcheque";
			this.coltotalcheque.Name = "coltotalcheque";
			//
			//tblreadingTableAdapter
			//
			this.tblreadingTableAdapter.ClearBeforeFill = true;
			//
			//frmSummary
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(906, 447);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmSummary";
			this.Text = "Summary";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.TblreadingBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsReading).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		internal DoorsPOS.WinApp.dsReading DsReading;
		internal System.Windows.Forms.BindingSource TblreadingBindingSource;
		internal DoorsPOS.WinApp.dsReadingTableAdapters.tblreadingTableAdapter tblreadingTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colcashreadid;
		internal DevExpress.XtraGrid.Columns.GridColumn coldatereading;
		internal DevExpress.XtraGrid.Columns.GridColumn coltotalsales;
		internal DevExpress.XtraGrid.Columns.GridColumn colbegincash;
		internal DevExpress.XtraGrid.Columns.GridColumn colpickup;
		internal DevExpress.XtraGrid.Columns.GridColumn coladdcash;
		internal DevExpress.XtraGrid.Columns.GridColumn coltotalrefs;
		internal DevExpress.XtraGrid.Columns.GridColumn colovershort;
		internal DevExpress.XtraGrid.Columns.GridColumn colcashier;
		internal DevExpress.XtraGrid.Columns.GridColumn colchangeprice;
		internal DevExpress.XtraGrid.Columns.GridColumn coltotaldiscount;
		internal DevExpress.XtraGrid.Columns.GridColumn coltransfer;
		internal DevExpress.XtraGrid.Columns.GridColumn colpayments;
		internal DevExpress.XtraGrid.Columns.GridColumn coltotalcredit;
		internal DevExpress.XtraGrid.Columns.GridColumn coltotalcheque;
	}
	
}
