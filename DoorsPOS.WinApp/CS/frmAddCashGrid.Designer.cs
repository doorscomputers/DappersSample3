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
	partial class frmAddCashGrid : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmAddCashGrid_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.AdditnlcashBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsAddCash = new DoorsPOS.WinApp.dsAddCash();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colposdate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colacamnt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colacremarks = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcashier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.AdditnlcashTableAdapter = new DoorsPOS.WinApp.dsAddCashTableAdapters.additnlcashTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.AdditnlcashBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsAddCash).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.DataSource = this.AdditnlcashBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(882, 494);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//AdditnlcashBindingSource
			//
			this.AdditnlcashBindingSource.DataMember = "additnlcash";
			this.AdditnlcashBindingSource.DataSource = this.DsAddCash;
			//
			//DsAddCash
			//
			this.DsAddCash.DataSetName = "dsAddCash";
			this.DsAddCash.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colposdate, this.colacamnt, this.colacremarks, this.colcashier});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "acamnt", this.colacamnt, "SUM={0:N2}")});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.OptionsView.ShowFooter = true;
			//
			//colposdate
			//
			this.colposdate.Caption = "Date";
			this.colposdate.FieldName = "posdate";
			this.colposdate.Name = "colposdate";
			this.colposdate.Visible = true;
			this.colposdate.VisibleIndex = 0;
			this.colposdate.Width = 160;
			//
			//colacamnt
			//
			this.colacamnt.AppearanceHeader.Options.UseTextOptions = true;
			this.colacamnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colacamnt.Caption = "Amount";
			this.colacamnt.DisplayFormat.FormatString = "N2";
			this.colacamnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colacamnt.FieldName = "acamnt";
			this.colacamnt.Name = "colacamnt";
			this.colacamnt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "acamnt", "SUM={0:N2}")});
			this.colacamnt.Visible = true;
			this.colacamnt.VisibleIndex = 2;
			this.colacamnt.Width = 176;
			//
			//colacremarks
			//
			this.colacremarks.Caption = "Remark";
			this.colacremarks.FieldName = "acremarks";
			this.colacremarks.Name = "colacremarks";
			this.colacremarks.Visible = true;
			this.colacremarks.VisibleIndex = 1;
			this.colacremarks.Width = 299;
			//
			//colcashier
			//
			this.colcashier.AppearanceCell.Options.UseTextOptions = true;
			this.colcashier.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colcashier.AppearanceHeader.Options.UseTextOptions = true;
			this.colcashier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colcashier.Caption = "Cashier";
			this.colcashier.FieldName = "cashier";
			this.colcashier.Name = "colcashier";
			this.colcashier.Visible = true;
			this.colcashier.VisibleIndex = 3;
			//
			//AdditnlcashTableAdapter
			//
			this.AdditnlcashTableAdapter.ClearBeforeFill = true;
			//
			//frmAddCashGrid
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 494);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmAddCashGrid";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Addtional Cash Received by Cashiers";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.AdditnlcashBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsAddCash).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsAddCash DsAddCash;
		internal System.Windows.Forms.BindingSource AdditnlcashBindingSource;
		internal DoorsPOS.WinApp.dsAddCashTableAdapters.additnlcashTableAdapter AdditnlcashTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colposdate;
		internal DevExpress.XtraGrid.Columns.GridColumn colacamnt;
		internal DevExpress.XtraGrid.Columns.GridColumn colacremarks;
		internal DevExpress.XtraGrid.Columns.GridColumn colcashier;
	}
	
}
