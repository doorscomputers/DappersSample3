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
	partial class frmChkPaymntGrid : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmChkPaymntGrid_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.ChkpayBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsChkPay = new DoorsPOS.WinApp.dsChkPay();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.coldtInsert_dt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colpayee = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colamnt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colchkno = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbank = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colchkremark = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcashier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ChkpayTableAdapter = new DoorsPOS.WinApp.dsChkPayTableAdapters.chkpayTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ChkpayBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsChkPay).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.DataSource = this.ChkpayBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(870, 512);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//ChkpayBindingSource
			//
			this.ChkpayBindingSource.DataMember = "chkpay";
			this.ChkpayBindingSource.DataSource = this.DsChkPay;
			//
			//DsChkPay
			//
			this.DsChkPay.DataSetName = "dsChkPay";
			this.DsChkPay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.coldtInsert_dt, this.colpayee, this.colamnt, this.colchkno, this.colbank, this.colchkremark, this.colcashier});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amnt", this.colamnt, "SUM={0:N2}")});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.OptionsBehavior.ReadOnly = true;
			this.GridView1.OptionsView.ShowFooter = true;
			//
			//coldtInsert_dt
			//
			this.coldtInsert_dt.Caption = "Date";
			this.coldtInsert_dt.FieldName = "dtInsert_dt";
			this.coldtInsert_dt.Name = "coldtInsert_dt";
			this.coldtInsert_dt.Visible = true;
			this.coldtInsert_dt.VisibleIndex = 0;
			this.coldtInsert_dt.Width = 151;
			//
			//colpayee
			//
			this.colpayee.Caption = "Customer";
			this.colpayee.FieldName = "payee";
			this.colpayee.Name = "colpayee";
			this.colpayee.Visible = true;
			this.colpayee.VisibleIndex = 1;
			this.colpayee.Width = 151;
			//
			//colamnt
			//
			this.colamnt.AppearanceHeader.Options.UseTextOptions = true;
			this.colamnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colamnt.Caption = "Chk Amount";
			this.colamnt.DisplayFormat.FormatString = "N2";
			this.colamnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colamnt.FieldName = "amnt";
			this.colamnt.Name = "colamnt";
			this.colamnt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amnt", "SUM={0:N2}")});
			this.colamnt.Visible = true;
			this.colamnt.VisibleIndex = 2;
			this.colamnt.Width = 106;
			//
			//colchkno
			//
			this.colchkno.AppearanceCell.Options.UseTextOptions = true;
			this.colchkno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colchkno.AppearanceHeader.Options.UseTextOptions = true;
			this.colchkno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colchkno.Caption = "Chk No";
			this.colchkno.FieldName = "chkno";
			this.colchkno.Name = "colchkno";
			this.colchkno.Visible = true;
			this.colchkno.VisibleIndex = 3;
			this.colchkno.Width = 162;
			//
			//colbank
			//
			this.colbank.Caption = "Bank";
			this.colbank.FieldName = "bank";
			this.colbank.Name = "colbank";
			this.colbank.Visible = true;
			this.colbank.VisibleIndex = 4;
			this.colbank.Width = 162;
			//
			//colchkremark
			//
			this.colchkremark.Caption = "Remark";
			this.colchkremark.FieldName = "chkremark";
			this.colchkremark.Name = "colchkremark";
			this.colchkremark.Visible = true;
			this.colchkremark.VisibleIndex = 5;
			this.colchkremark.Width = 121;
			//
			//colcashier
			//
			this.colcashier.Caption = "Cashier";
			this.colcashier.FieldName = "cashier";
			this.colcashier.Name = "colcashier";
			this.colcashier.Visible = true;
			this.colcashier.VisibleIndex = 6;
			//
			//ChkpayTableAdapter
			//
			this.ChkpayTableAdapter.ClearBeforeFill = true;
			//
			//frmChkPaymntGrid
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 512);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmChkPaymntGrid";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cheque Payments Grid View";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ChkpayBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsChkPay).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsChkPay DsChkPay;
		internal System.Windows.Forms.BindingSource ChkpayBindingSource;
		internal DoorsPOS.WinApp.dsChkPayTableAdapters.chkpayTableAdapter ChkpayTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn coldtInsert_dt;
		internal DevExpress.XtraGrid.Columns.GridColumn colpayee;
		internal DevExpress.XtraGrid.Columns.GridColumn colamnt;
		internal DevExpress.XtraGrid.Columns.GridColumn colchkno;
		internal DevExpress.XtraGrid.Columns.GridColumn colbank;
		internal DevExpress.XtraGrid.Columns.GridColumn colchkremark;
		internal DevExpress.XtraGrid.Columns.GridColumn colcashier;
	}
	
}
