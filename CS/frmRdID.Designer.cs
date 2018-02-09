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
	partial class frmRdID : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmRdID_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.TblreadingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsRdID = new DoorsPOS.WinApp.dsRdID();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colcashreadid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcashier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldatereading = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbegincash = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colstatus = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TblreadingTableAdapter = new DoorsPOS.WinApp.dsRdIDTableAdapters.tblreadingTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.TblreadingBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsRdID).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.TblreadingBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(534, 511);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//TblreadingBindingSource
			//
			this.TblreadingBindingSource.DataMember = "tblreading";
			this.TblreadingBindingSource.DataSource = this.DsRdID;
			//
			//DsRdID
			//
			this.DsRdID.DataSetName = "dsRdID";
			this.DsRdID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colcashreadid, this.colcashier, this.coldatereading, this.colbegincash, this.colstatus});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.Name = "GridView1";
			//
			//colcashreadid
			//
			this.colcashreadid.AppearanceCell.Options.UseTextOptions = true;
			this.colcashreadid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.colcashreadid.Caption = "Reading ID";
			this.colcashreadid.FieldName = "cashreadid";
			this.colcashreadid.Name = "colcashreadid";
			this.colcashreadid.OptionsColumn.ReadOnly = true;
			this.colcashreadid.Visible = true;
			this.colcashreadid.VisibleIndex = 0;
			//
			//colcashier
			//
			this.colcashier.Caption = "Cashier";
			this.colcashier.FieldName = "cashier";
			this.colcashier.Name = "colcashier";
			this.colcashier.Visible = true;
			this.colcashier.VisibleIndex = 1;
			//
			//coldatereading
			//
			this.coldatereading.Caption = "Date";
			this.coldatereading.FieldName = "datereading";
			this.coldatereading.Name = "coldatereading";
			this.coldatereading.Visible = true;
			this.coldatereading.VisibleIndex = 2;
			//
			//colbegincash
			//
			this.colbegincash.AppearanceHeader.Options.UseTextOptions = true;
			this.colbegincash.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colbegincash.Caption = "Beginning Cash";
			this.colbegincash.DisplayFormat.FormatString = "N2";
			this.colbegincash.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colbegincash.FieldName = "begincash";
			this.colbegincash.Name = "colbegincash";
			this.colbegincash.Visible = true;
			this.colbegincash.VisibleIndex = 3;
			//
			//colstatus
			//
			this.colstatus.Caption = "Status";
			this.colstatus.FieldName = "status";
			this.colstatus.Name = "colstatus";
			this.colstatus.Visible = true;
			this.colstatus.VisibleIndex = 4;
			//
			//TblreadingTableAdapter
			//
			this.TblreadingTableAdapter.ClearBeforeFill = true;
			//
			//frmRdID
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 511);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmRdID";
			this.Text = "Cashier Reading ID";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.TblreadingBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsRdID).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsRdID DsRdID;
		internal System.Windows.Forms.BindingSource TblreadingBindingSource;
		internal DoorsPOS.WinApp.dsRdIDTableAdapters.tblreadingTableAdapter TblreadingTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colcashreadid;
		internal DevExpress.XtraGrid.Columns.GridColumn colcashier;
		internal DevExpress.XtraGrid.Columns.GridColumn coldatereading;
		internal DevExpress.XtraGrid.Columns.GridColumn colbegincash;
		internal DevExpress.XtraGrid.Columns.GridColumn colstatus;
	}
	
}
