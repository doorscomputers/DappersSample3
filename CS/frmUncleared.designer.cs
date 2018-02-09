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
	partial class frmUncleared : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmUncleared_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.DlvryhdrBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsPDC = new DoorsPOS.WinApp.dsPDC();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.coldrid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldrdate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldrinv = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colterms = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldrdue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldrbal = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colpaid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldrpsted = new DevExpress.XtraGrid.Columns.GridColumn();
			this.dlvry_hdrTableAdapter = new DoorsPOS.WinApp.dsPDCTableAdapters.dlvry_hdrTableAdapter();
			this.colsupplier = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DlvryhdrBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsPDC).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.DlvryhdrBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.gridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(953, 469);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gridView1});
			//
			//DlvryhdrBindingSource
			//
			this.DlvryhdrBindingSource.DataMember = "dlvry_hdr";
			this.DlvryhdrBindingSource.DataSource = this.DsPDC;
			//
			//DsPDC
			//
			this.DsPDC.DataSetName = "dsPDC";
			this.DsPDC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//gridView1
			//
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.coldrid, this.coldrdate, this.coldrinv, this.colsupplier, this.colterms, this.coldrdue, this.coldrbal, this.colpaid, this.coldrpsted});
			this.gridView1.GridControl = this.GridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowFooter = true;
			//
			//coldrid
			//
			this.coldrid.FieldName = "drid";
			this.coldrid.Name = "coldrid";
			this.coldrid.OptionsColumn.ReadOnly = true;
			//
			//coldrdate
			//
			this.coldrdate.Caption = "Invoice Date";
			this.coldrdate.FieldName = "drdate";
			this.coldrdate.Name = "coldrdate";
			this.coldrdate.Visible = true;
			this.coldrdate.VisibleIndex = 0;
			//
			//coldrinv
			//
			this.coldrinv.Caption = "Inv No.";
			this.coldrinv.FieldName = "drinv";
			this.coldrinv.Name = "coldrinv";
			this.coldrinv.Visible = true;
			this.coldrinv.VisibleIndex = 1;
			//
			//colterms
			//
			this.colterms.Caption = "Term";
			this.colterms.FieldName = "terms";
			this.colterms.Name = "colterms";
			this.colterms.Visible = true;
			this.colterms.VisibleIndex = 2;
			//
			//coldrdue
			//
			this.coldrdue.Caption = "Due Date";
			this.coldrdue.FieldName = "drdue";
			this.coldrdue.Name = "coldrdue";
			this.coldrdue.Visible = true;
			this.coldrdue.VisibleIndex = 3;
			//
			//coldrbal
			//
			this.coldrbal.Caption = "Balance";
			this.coldrbal.DisplayFormat.FormatString = "N2";
			this.coldrbal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coldrbal.FieldName = "drbal";
			this.coldrbal.Name = "coldrbal";
			this.coldrbal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "drbal", "SUM={0:N2}")});
			this.coldrbal.Visible = true;
			this.coldrbal.VisibleIndex = 4;
			//
			//colpaid
			//
			this.colpaid.FieldName = "paid";
			this.colpaid.Name = "colpaid";
			//
			//coldrpsted
			//
			this.coldrpsted.Caption = "Cleared";
			this.coldrpsted.FieldName = "drpsted";
			this.coldrpsted.Name = "coldrpsted";
			this.coldrpsted.Visible = true;
			this.coldrpsted.VisibleIndex = 5;
			//
			//dlvry_hdrTableAdapter
			//
			this.dlvry_hdrTableAdapter.ClearBeforeFill = true;
			//
			//colsupplier
			//
			this.colsupplier.Caption = "Supplier";
			this.colsupplier.FieldName = "supplier";
			this.colsupplier.Name = "colsupplier";
			this.colsupplier.Visible = true;
			this.colsupplier.VisibleIndex = 6;
			//
			//frmUncleared
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(953, 469);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmUncleared";
			this.Text = "Not Cleared PDC";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DlvryhdrBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsPDC).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		internal DoorsPOS.WinApp.dsPDC DsPDC;
		internal System.Windows.Forms.BindingSource DlvryhdrBindingSource;
		internal DoorsPOS.WinApp.dsPDCTableAdapters.dlvry_hdrTableAdapter dlvry_hdrTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn coldrid;
		internal DevExpress.XtraGrid.Columns.GridColumn coldrdate;
		internal DevExpress.XtraGrid.Columns.GridColumn coldrinv;
		internal DevExpress.XtraGrid.Columns.GridColumn colterms;
		internal DevExpress.XtraGrid.Columns.GridColumn coldrdue;
		internal DevExpress.XtraGrid.Columns.GridColumn coldrbal;
		internal DevExpress.XtraGrid.Columns.GridColumn colpaid;
		internal DevExpress.XtraGrid.Columns.GridColumn coldrpsted;
		internal DevExpress.XtraGrid.Columns.GridColumn colsupplier;
	}
	
}
