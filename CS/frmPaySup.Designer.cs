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
	partial class frmPaySup : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmPaySup_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwInvPaymentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.Dsinvpayvw = new DoorsPOS.WinApp.dsinvpayvw();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colpayid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colpaydate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colamnt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsupplier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colchqno = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbank = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldrinv = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwInvPaymentsTableAdapter1 = new DoorsPOS.WinApp.dsinvpayvwTableAdapters.vwInvPaymentsTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwInvPaymentsBindingSource1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.Dsinvpayvw).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwInvPaymentsBindingSource1;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(993, 483);
			this.GridControl1.TabIndex = 1;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwInvPaymentsBindingSource1
			//
			this.VwInvPaymentsBindingSource1.DataMember = "vwInvPayments";
			this.VwInvPaymentsBindingSource1.DataSource = this.Dsinvpayvw;
			//
			//Dsinvpayvw
			//
			this.Dsinvpayvw.DataSetName = "dsinvpayvw";
			this.Dsinvpayvw.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colpayid, this.colpaydate, this.colamnt, this.colsupplier, this.colchqno, this.colbank, this.coldrinv});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupCount = 1;
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.OptionsView.ShowFooter = true;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colsupplier, DevExpress.Data.ColumnSortOrder.Ascending), new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colchqno, DevExpress.Data.ColumnSortOrder.Descending)});
			//
			//colpayid
			//
			this.colpayid.FieldName = "payid";
			this.colpayid.Name = "colpayid";
			//
			//colpaydate
			//
			this.colpaydate.Caption = "Date";
			this.colpaydate.FieldName = "paydate";
			this.colpaydate.Name = "colpaydate";
			this.colpaydate.Visible = true;
			this.colpaydate.VisibleIndex = 0;
			//
			//colamnt
			//
			this.colamnt.AppearanceHeader.Options.UseTextOptions = true;
			this.colamnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colamnt.Caption = "Amount Paid";
			this.colamnt.DisplayFormat.FormatString = "N2";
			this.colamnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colamnt.FieldName = "amnt";
			this.colamnt.Name = "colamnt";
			this.colamnt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amnt", "SUM={0:N2}")});
			this.colamnt.Visible = true;
			this.colamnt.VisibleIndex = 4;
			//
			//colsupplier
			//
			this.colsupplier.Caption = "Supplier";
			this.colsupplier.FieldName = "supplier";
			this.colsupplier.Name = "colsupplier";
			this.colsupplier.Visible = true;
			this.colsupplier.VisibleIndex = 0;
			//
			//colchqno
			//
			this.colchqno.AppearanceCell.Options.UseTextOptions = true;
			this.colchqno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colchqno.AppearanceHeader.Options.UseTextOptions = true;
			this.colchqno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colchqno.Caption = "Cheque No.";
			this.colchqno.FieldName = "chqno";
			this.colchqno.Name = "colchqno";
			this.colchqno.Visible = true;
			this.colchqno.VisibleIndex = 1;
			//
			//colbank
			//
			this.colbank.Caption = "Bank";
			this.colbank.FieldName = "bank";
			this.colbank.Name = "colbank";
			this.colbank.Visible = true;
			this.colbank.VisibleIndex = 2;
			//
			//coldrinv
			//
			this.coldrinv.Caption = "Inv. No.";
			this.coldrinv.FieldName = "drinv";
			this.coldrinv.Name = "coldrinv";
			this.coldrinv.Visible = true;
			this.coldrinv.VisibleIndex = 3;
			//
			//VwInvPaymentsTableAdapter1
			//
			this.VwInvPaymentsTableAdapter1.ClearBeforeFill = true;
			//
			//frmPaySup
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 483);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmPaySup";
			this.Text = "Payments to Suppliers";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwInvPaymentsBindingSource1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.Dsinvpayvw).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DevExpress.XtraGrid.Columns.GridColumn colpayid;
		internal DevExpress.XtraGrid.Columns.GridColumn colpaydate;
		internal DevExpress.XtraGrid.Columns.GridColumn colsupplier;
		internal DevExpress.XtraGrid.Columns.GridColumn colchqno;
		internal DevExpress.XtraGrid.Columns.GridColumn colbank;
		internal DevExpress.XtraGrid.Columns.GridColumn coldrinv;
		internal DoorsPOS.WinApp.dsinvpayvw Dsinvpayvw;
		internal System.Windows.Forms.BindingSource VwInvPaymentsBindingSource1;
		internal DoorsPOS.WinApp.dsinvpayvwTableAdapters.vwInvPaymentsTableAdapter VwInvPaymentsTableAdapter1;
		internal DevExpress.XtraGrid.Columns.GridColumn colamnt;
	}
	
}
