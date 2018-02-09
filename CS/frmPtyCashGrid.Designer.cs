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
	partial class frmPtyCashGrid : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmPtyCashGrid_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick);
			this.PettycashBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsPetyCash = new DoorsPOS.WinApp.dsPetyCash();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colposdate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colpcrem = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colpcamnt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcashier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Petty_cashTableAdapter = new DoorsPOS.WinApp.dsPetyCashTableAdapters.petty_cashTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PettycashBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsPetyCash).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.DataSource = this.PettycashBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(765, 480);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//PettycashBindingSource
			//
			this.PettycashBindingSource.DataMember = "petty_cash";
			this.PettycashBindingSource.DataSource = this.DsPetyCash;
			//
			//DsPetyCash
			//
			this.DsPetyCash.DataSetName = "dsPetyCash";
			this.DsPetyCash.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colposdate, this.colpcrem, this.colpcamnt, this.colcashier});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "pcamnt", this.colpcamnt, "SUM={0:N2}")});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.OptionsView.ShowFooter = true;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colpcrem, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colposdate
			//
			this.colposdate.Caption = "Date";
			this.colposdate.FieldName = "posdate";
			this.colposdate.Name = "colposdate";
			this.colposdate.Visible = true;
			this.colposdate.VisibleIndex = 0;
			//
			//colpcrem
			//
			this.colpcrem.Caption = "Remark";
			this.colpcrem.FieldName = "pcrem";
			this.colpcrem.Name = "colpcrem";
			this.colpcrem.Visible = true;
			this.colpcrem.VisibleIndex = 1;
			//
			//colpcamnt
			//
			this.colpcamnt.AppearanceHeader.Options.UseTextOptions = true;
			this.colpcamnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colpcamnt.Caption = "Amount";
			this.colpcamnt.DisplayFormat.FormatString = "N2";
			this.colpcamnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colpcamnt.FieldName = "pcamnt";
			this.colpcamnt.Name = "colpcamnt";
			this.colpcamnt.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "pcamnt", "SUM={0:N2}")});
			this.colpcamnt.Visible = true;
			this.colpcamnt.VisibleIndex = 2;
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
			//Petty_cashTableAdapter
			//
			this.Petty_cashTableAdapter.ClearBeforeFill = true;
			//
			//frmPtyCashGrid
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 480);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmPtyCashGrid";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cash Taken from the Counter Grid View";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PettycashBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsPetyCash).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsPetyCash DsPetyCash;
		internal System.Windows.Forms.BindingSource PettycashBindingSource;
		internal DoorsPOS.WinApp.dsPetyCashTableAdapters.petty_cashTableAdapter Petty_cashTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colposdate;
		internal DevExpress.XtraGrid.Columns.GridColumn colpcrem;
		internal DevExpress.XtraGrid.Columns.GridColumn colpcamnt;
		internal DevExpress.XtraGrid.Columns.GridColumn colcashier;
	}
	
}
