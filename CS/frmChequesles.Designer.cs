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
	partial class frmCheqSales : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmCashSales_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.Click += new System.EventHandler(this.GridControl1_Click);
			this.PoshdrBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsCheques = new DoorsPOS.WinApp.dsCheques();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colpostmp_hdrid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colpos_date = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colmowd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coltotsales = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Pos_hdrTableAdapter = new DoorsPOS.WinApp.dsChequesTableAdapters.pos_hdrTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PoshdrBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsCheques).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.PoshdrBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(943, 499);
			this.GridControl1.TabIndex = 1;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//PoshdrBindingSource
			//
			this.PoshdrBindingSource.DataMember = "pos_hdr";
			this.PoshdrBindingSource.DataSource = this.DsCheques;
			//
			//DsCheques
			//
			this.DsCheques.DataSetName = "dsCheques";
			this.DsCheques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colpostmp_hdrid, this.colpos_date, this.colmowd, this.coltotsales});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.OptionsView.ShowFooter = true;
			//
			//colpostmp_hdrid
			//
			this.colpostmp_hdrid.AppearanceCell.Options.UseTextOptions = true;
			this.colpostmp_hdrid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.colpostmp_hdrid.Caption = "Reference No.";
			this.colpostmp_hdrid.FieldName = "postmp_hdrid";
			this.colpostmp_hdrid.Name = "colpostmp_hdrid";
			this.colpostmp_hdrid.Visible = true;
			this.colpostmp_hdrid.VisibleIndex = 0;
			//
			//colpos_date
			//
			this.colpos_date.Caption = "Date";
			this.colpos_date.FieldName = "pos_date";
			this.colpos_date.Name = "colpos_date";
			this.colpos_date.Visible = true;
			this.colpos_date.VisibleIndex = 1;
			//
			//colmowd
			//
			this.colmowd.Caption = "Type of Payment";
			this.colmowd.FieldName = "mowd";
			this.colmowd.Name = "colmowd";
			this.colmowd.Visible = true;
			this.colmowd.VisibleIndex = 2;
			//
			//coltotsales
			//
			this.coltotsales.AppearanceHeader.Options.UseTextOptions = true;
			this.coltotsales.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.coltotsales.Caption = "Amount";
			this.coltotsales.DisplayFormat.FormatString = "N2";
			this.coltotsales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.coltotsales.FieldName = "totsales";
			this.coltotsales.Name = "coltotsales";
			this.coltotsales.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "totsales", "SUM={0:N2}")});
			this.coltotsales.Visible = true;
			this.coltotsales.VisibleIndex = 3;
			//
			//Pos_hdrTableAdapter
			//
			this.Pos_hdrTableAdapter.ClearBeforeFill = true;
			//
			//frmCheqSales
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(943, 499);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmCheqSales";
			this.Text = "Cheque Sales";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PoshdrBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsCheques).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsCheques DsCheques;
		internal System.Windows.Forms.BindingSource PoshdrBindingSource;
		internal DoorsPOS.WinApp.dsChequesTableAdapters.pos_hdrTableAdapter Pos_hdrTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colpostmp_hdrid;
		internal DevExpress.XtraGrid.Columns.GridColumn colpos_date;
		internal DevExpress.XtraGrid.Columns.GridColumn colmowd;
		internal DevExpress.XtraGrid.Columns.GridColumn coltotsales;
	}
	
}
