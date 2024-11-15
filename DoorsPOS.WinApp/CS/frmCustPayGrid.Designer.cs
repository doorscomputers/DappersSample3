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
	partial class frmCustPayGrid : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmCustPayGrid_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.VwCustPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsCustPay = new DoorsPOS.WinApp.dsCustPay();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colPayDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Customer = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCheckNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDateIssued = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDateDue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAccountNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOldBal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNewBal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colfirstname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collastname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colmiddlename = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwCustPaymentsTableAdapter = new DoorsPOS.WinApp.dsCustPayTableAdapters.vwCustPaymentsTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwCustPaymentsBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsCustPay).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwCustPaymentsBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(861, 497);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwCustPaymentsBindingSource
			//
			this.VwCustPaymentsBindingSource.DataMember = "vwCustPayments";
			this.VwCustPaymentsBindingSource.DataSource = this.DsCustPay;
			//
			//DsCustPay
			//
			this.DsCustPay.DataSetName = "dsCustPay";
			this.DsCustPay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colPayDate, this.Customer, this.colBalance, this.colCheckNo, this.colAccountName, this.colDateIssued, this.colDateDue, this.colAccountNo, this.colBankName, this.colAmount, this.colRemarks, this.colOldBal, this.colNewBal, this.colfirstname, this.collastname, this.colmiddlename});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupCount = 2;
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Customer, DevExpress.Data.ColumnSortOrder.Ascending), new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBalance, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colPayDate
			//
			this.colPayDate.Caption = "Date Paid";
			this.colPayDate.FieldName = "PayDate";
			this.colPayDate.Name = "colPayDate";
			this.colPayDate.Visible = true;
			this.colPayDate.VisibleIndex = 0;
			this.colPayDate.Width = 87;
			//
			//Customer
			//
			this.Customer.Caption = "Customer";
			this.Customer.FieldName = "Customer";
			this.Customer.Name = "Customer";
			this.Customer.UnboundExpression = "[lastname]+\',\'+[firstname]+\' \'+[middlename]";
			this.Customer.UnboundType = DevExpress.Data.UnboundColumnType.String;
			this.Customer.Visible = true;
			this.Customer.VisibleIndex = 1;
			//
			//colBalance
			//
			this.colBalance.AppearanceHeader.Options.UseTextOptions = true;
			this.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colBalance.Caption = "Current Bal";
			this.colBalance.DisplayFormat.FormatString = "N2";
			this.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colBalance.FieldName = "Balance";
			this.colBalance.Name = "colBalance";
			this.colBalance.Visible = true;
			this.colBalance.VisibleIndex = 4;
			this.colBalance.Width = 81;
			//
			//colCheckNo
			//
			this.colCheckNo.Caption = "Cheque No.";
			this.colCheckNo.FieldName = "CheckNo";
			this.colCheckNo.Name = "colCheckNo";
			this.colCheckNo.Width = 87;
			//
			//colAccountName
			//
			this.colAccountName.Caption = "Account Name";
			this.colAccountName.FieldName = "AccountName";
			this.colAccountName.Name = "colAccountName";
			this.colAccountName.Width = 87;
			//
			//colDateIssued
			//
			this.colDateIssued.Caption = "Date Issued";
			this.colDateIssued.FieldName = "DateIssued";
			this.colDateIssued.Name = "colDateIssued";
			this.colDateIssued.Width = 87;
			//
			//colDateDue
			//
			this.colDateDue.Caption = "Date Due";
			this.colDateDue.FieldName = "DateDue";
			this.colDateDue.Name = "colDateDue";
			this.colDateDue.Width = 87;
			//
			//colAccountNo
			//
			this.colAccountNo.Caption = "Account No.";
			this.colAccountNo.FieldName = "AccountNo";
			this.colAccountNo.Name = "colAccountNo";
			this.colAccountNo.Visible = true;
			this.colAccountNo.VisibleIndex = 4;
			this.colAccountNo.Width = 87;
			//
			//colBankName
			//
			this.colBankName.Caption = "Bank Name";
			this.colBankName.FieldName = "BankName";
			this.colBankName.Name = "colBankName";
			this.colBankName.Visible = true;
			this.colBankName.VisibleIndex = 5;
			this.colBankName.Width = 87;
			//
			//colAmount
			//
			this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
			this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colAmount.Caption = "Amount Pd";
			this.colAmount.DisplayFormat.FormatString = "N2";
			this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colAmount.FieldName = "Amount";
			this.colAmount.Name = "colAmount";
			this.colAmount.Visible = true;
			this.colAmount.VisibleIndex = 1;
			this.colAmount.Width = 87;
			//
			//colRemarks
			//
			this.colRemarks.Caption = "Cashier";
			this.colRemarks.FieldName = "Remarks";
			this.colRemarks.Name = "colRemarks";
			this.colRemarks.Visible = true;
			this.colRemarks.VisibleIndex = 6;
			this.colRemarks.Width = 95;
			//
			//colOldBal
			//
			this.colOldBal.AppearanceHeader.Options.UseTextOptions = true;
			this.colOldBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colOldBal.Caption = "Old Balance";
			this.colOldBal.DisplayFormat.FormatString = "N2";
			this.colOldBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colOldBal.FieldName = "OldBal";
			this.colOldBal.Name = "colOldBal";
			this.colOldBal.Visible = true;
			this.colOldBal.VisibleIndex = 2;
			this.colOldBal.Width = 87;
			//
			//colNewBal
			//
			this.colNewBal.AppearanceHeader.Options.UseTextOptions = true;
			this.colNewBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colNewBal.Caption = "New Balance";
			this.colNewBal.DisplayFormat.FormatString = "N2";
			this.colNewBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colNewBal.FieldName = "NewBal";
			this.colNewBal.Name = "colNewBal";
			this.colNewBal.Visible = true;
			this.colNewBal.VisibleIndex = 3;
			this.colNewBal.Width = 87;
			//
			//colfirstname
			//
			this.colfirstname.FieldName = "firstname";
			this.colfirstname.Name = "colfirstname";
			//
			//collastname
			//
			this.collastname.FieldName = "lastname";
			this.collastname.Name = "collastname";
			//
			//colmiddlename
			//
			this.colmiddlename.FieldName = "middlename";
			this.colmiddlename.Name = "colmiddlename";
			//
			//VwCustPaymentsTableAdapter
			//
			this.VwCustPaymentsTableAdapter.ClearBeforeFill = true;
			//
			//frmCustPayGrid
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 497);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmCustPayGrid";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Customer Payments Grid";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwCustPaymentsBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsCustPay).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsCustPay DsCustPay;
		internal System.Windows.Forms.BindingSource VwCustPaymentsBindingSource;
		internal DoorsPOS.WinApp.dsCustPayTableAdapters.vwCustPaymentsTableAdapter VwCustPaymentsTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colPayDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colBalance;
		internal DevExpress.XtraGrid.Columns.GridColumn colCheckNo;
		internal DevExpress.XtraGrid.Columns.GridColumn colAccountName;
		internal DevExpress.XtraGrid.Columns.GridColumn colDateIssued;
		internal DevExpress.XtraGrid.Columns.GridColumn colDateDue;
		internal DevExpress.XtraGrid.Columns.GridColumn colAccountNo;
		internal DevExpress.XtraGrid.Columns.GridColumn colBankName;
		internal DevExpress.XtraGrid.Columns.GridColumn colAmount;
		internal DevExpress.XtraGrid.Columns.GridColumn colRemarks;
		internal DevExpress.XtraGrid.Columns.GridColumn colOldBal;
		internal DevExpress.XtraGrid.Columns.GridColumn colNewBal;
		internal DevExpress.XtraGrid.Columns.GridColumn Customer;
		internal DevExpress.XtraGrid.Columns.GridColumn colfirstname;
		internal DevExpress.XtraGrid.Columns.GridColumn collastname;
		internal DevExpress.XtraGrid.Columns.GridColumn colmiddlename;
	}
	
}
