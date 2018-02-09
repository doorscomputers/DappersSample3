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
	partial class frmItemLedgerPvt : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmItemLedgerPvt_Load);
			this.PivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.PivotGridControl1.DoubleClick += new System.EventHandler(this.PivotGridControl1_DoubleClick);
			this.VwItemLedger2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.DsLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsLedger = new DoorsPOS.WinApp.dsLedger();
			this.fielditemdesc1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldqtysold1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldqtypurchased1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldqtyreturned1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldbackorder1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldtransDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldfree1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldmanualinv1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldqtytransfrd1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldqtyreceived1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldtransDate = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldqtyconvertd = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldtransDate2 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.VwItemLedger2TableAdapter = new DoorsPOS.WinApp.dsLedgerTableAdapters.vwItemLedger2TableAdapter();
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwItemLedger2BindingSource1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsLedgerBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsLedger).BeginInit();
			this.SuspendLayout();
			//
			//PivotGridControl1
			//
			this.PivotGridControl1.DataSource = this.VwItemLedger2BindingSource1;
			this.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {this.fielditemdesc1, this.fieldqtysold1, this.fieldqtypurchased1, this.fieldqtyreturned1, this.fieldbackorder1, this.fieldtransDate1, this.fieldfree1, this.fieldmanualinv1, this.fieldqtytransfrd1, this.fieldqtyreceived1, this.fieldtransDate, this.fieldqtyconvertd, this.fieldtransDate2});
			this.PivotGridControl1.Location = new System.Drawing.Point(0, 0);
			this.PivotGridControl1.Name = "PivotGridControl1";
			this.PivotGridControl1.Size = new System.Drawing.Size(873, 477);
			this.PivotGridControl1.TabIndex = 0;
			//
			//VwItemLedger2BindingSource1
			//
			this.VwItemLedger2BindingSource1.DataMember = "vwItemLedger2";
			this.VwItemLedger2BindingSource1.DataSource = this.DsLedgerBindingSource;
			//
			//DsLedgerBindingSource
			//
			this.DsLedgerBindingSource.DataSource = this.DsLedger;
			this.DsLedgerBindingSource.Position = 0;
			//
			//DsLedger
			//
			this.DsLedger.DataSetName = "dsLedger";
			this.DsLedger.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//fielditemdesc1
			//
			this.fielditemdesc1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fielditemdesc1.AreaIndex = 0;
			this.fielditemdesc1.Caption = "Item Description";
			this.fielditemdesc1.FieldName = "item_desc";
			this.fielditemdesc1.Name = "fielditemdesc1";
			this.fielditemdesc1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			//
			//fieldqtysold1
			//
			this.fieldqtysold1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldqtysold1.AreaIndex = 1;
			this.fieldqtysold1.Caption = "Qty Sold";
			this.fieldqtysold1.FieldName = "qty_sold";
			this.fieldqtysold1.Name = "fieldqtysold1";
			this.fieldqtysold1.Width = 65;
			//
			//fieldqtypurchased1
			//
			this.fieldqtypurchased1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldqtypurchased1.AreaIndex = 0;
			this.fieldqtypurchased1.Caption = "Qty Purchased";
			this.fieldqtypurchased1.FieldName = "qty_purchased";
			this.fieldqtypurchased1.Name = "fieldqtypurchased1";
			this.fieldqtypurchased1.Width = 83;
			//
			//fieldqtyreturned1
			//
			this.fieldqtyreturned1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldqtyreturned1.AreaIndex = 2;
			this.fieldqtyreturned1.Caption = "Qty Returned";
			this.fieldqtyreturned1.FieldName = "qtyreturned";
			this.fieldqtyreturned1.Name = "fieldqtyreturned1";
			this.fieldqtyreturned1.Width = 72;
			//
			//fieldbackorder1
			//
			this.fieldbackorder1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldbackorder1.AreaIndex = 3;
			this.fieldbackorder1.Caption = "Backorder";
			this.fieldbackorder1.FieldName = "backorder";
			this.fieldbackorder1.Name = "fieldbackorder1";
			this.fieldbackorder1.Width = 65;
			//
			//fieldtransDate1
			//
			this.fieldtransDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldtransDate1.AreaIndex = 0;
			this.fieldtransDate1.Caption = "Year";
			this.fieldtransDate1.FieldName = "trans_Date";
			this.fieldtransDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldtransDate1.Name = "fieldtransDate1";
			this.fieldtransDate1.UnboundFieldName = "fieldtransDate1";
			//
			//fieldfree1
			//
			this.fieldfree1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldfree1.AreaIndex = 6;
			this.fieldfree1.Caption = "Free";
			this.fieldfree1.FieldName = "free";
			this.fieldfree1.Name = "fieldfree1";
			this.fieldfree1.Width = 42;
			//
			//fieldmanualinv1
			//
			this.fieldmanualinv1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldmanualinv1.AreaIndex = 7;
			this.fieldmanualinv1.Caption = "Manual Inv";
			this.fieldmanualinv1.FieldName = "manualinv";
			this.fieldmanualinv1.Name = "fieldmanualinv1";
			this.fieldmanualinv1.Width = 65;
			//
			//fieldqtytransfrd1
			//
			this.fieldqtytransfrd1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldqtytransfrd1.AreaIndex = 4;
			this.fieldqtytransfrd1.Caption = "Qty Transfrd";
			this.fieldqtytransfrd1.FieldName = "qtytransfrd";
			this.fieldqtytransfrd1.Name = "fieldqtytransfrd1";
			this.fieldqtytransfrd1.Width = 73;
			//
			//fieldqtyreceived1
			//
			this.fieldqtyreceived1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldqtyreceived1.AreaIndex = 5;
			this.fieldqtyreceived1.Caption = "Qty Received";
			this.fieldqtyreceived1.FieldName = "qtyreceived";
			this.fieldqtyreceived1.Name = "fieldqtyreceived1";
			this.fieldqtyreceived1.Width = 67;
			//
			//fieldtransDate
			//
			this.fieldtransDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldtransDate.AreaIndex = 1;
			this.fieldtransDate.Caption = "Month";
			this.fieldtransDate.FieldName = "trans_Date";
			this.fieldtransDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldtransDate.Name = "fieldtransDate";
			this.fieldtransDate.UnboundFieldName = "fieldtransDate";
			//
			//fieldqtyconvertd
			//
			this.fieldqtyconvertd.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldqtyconvertd.AreaIndex = 8;
			this.fieldqtyconvertd.Caption = "Qty Converted";
			this.fieldqtyconvertd.FieldName = "qtyconvertd";
			this.fieldqtyconvertd.Name = "fieldqtyconvertd";
			//
			//fieldtransDate2
			//
			this.fieldtransDate2.AreaIndex = 0;
			this.fieldtransDate2.Caption = "Day";
			this.fieldtransDate2.CellFormat.FormatString = "d";
			this.fieldtransDate2.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fieldtransDate2.FieldName = "trans_Date";
			this.fieldtransDate2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateDay;
			this.fieldtransDate2.Name = "fieldtransDate2";
			this.fieldtransDate2.UnboundFieldName = "fieldtransDate2";
			//
			//VwItemLedger2TableAdapter
			//
			this.VwItemLedger2TableAdapter.ClearBeforeFill = true;
			//
			//frmItemLedgerPvt
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 477);
			this.Controls.Add(this.PivotGridControl1);
			this.Name = "frmItemLedgerPvt";
			this.Text = "Item Ledger";
			((System.ComponentModel.ISupportInitialize) this.PivotGridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwItemLedger2BindingSource1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsLedgerBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsLedger).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraPivotGrid.PivotGridControl PivotGridControl1;
		internal System.Windows.Forms.BindingSource DsLedgerBindingSource;
		internal DoorsPOS.WinApp.dsLedger DsLedger;
		internal DoorsPOS.WinApp.dsLedgerTableAdapters.vwItemLedger2TableAdapter VwItemLedger2TableAdapter;
		internal System.Windows.Forms.BindingSource VwItemLedger2BindingSource1;
		internal DevExpress.XtraPivotGrid.PivotGridField fielditemdesc1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldqtysold1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldqtypurchased1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldqtyreturned1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldbackorder1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldtransDate1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldfree1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldmanualinv1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldqtytransfrd1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldqtyreceived1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldtransDate;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldtransDate2;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldqtyconvertd;
	}
	
}
