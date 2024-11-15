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
	partial class frmItemList : System.Windows.Forms.Form
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
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmItemList_FormClosed);
			base.Load += new System.EventHandler(frmItemList_Load);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.VwItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsvwItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsvwItems = new DoorsPOS.WinApp.dsvwItems();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colavailable = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsupplier = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcatgory = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDEPTD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colsayz = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcost = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colretail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colretail2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collastprice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collastcost = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collastwholesale = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colmaximum = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colminimum = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collastdlvry = new DevExpress.XtraGrid.Columns.GridColumn();
			this.VwItemsTableAdapter = new DoorsPOS.WinApp.dsvwItemsTableAdapters.vwItemsTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VwItemsBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwItemsBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwItems).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.VwItemsBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(1240, 599);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//VwItemsBindingSource
			//
			this.VwItemsBindingSource.DataMember = "vwItems";
			this.VwItemsBindingSource.DataSource = this.DsvwItemsBindingSource;
			//
			//DsvwItemsBindingSource
			//
			this.DsvwItemsBindingSource.DataSource = this.DsvwItems;
			this.DsvwItemsBindingSource.Position = 0;
			//
			//DsvwItems
			//
			this.DsvwItems.DataSetName = "dsvwItems";
			this.DsvwItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colbarcode, this.colitem_desc, this.colavailable, this.colsupplier, this.colcatgory, this.colDEPTD, this.colsayz, this.colcost, this.colretail, this.colretail2, this.collastprice, this.collastcost, this.collastwholesale, this.colmaximum, this.colminimum, this.collastdlvry});
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.collastdlvry, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colbarcode
			//
			this.colbarcode.Caption = "Item Code";
			this.colbarcode.FieldName = "barcode";
			this.colbarcode.Name = "colbarcode";
			this.colbarcode.Visible = true;
			this.colbarcode.VisibleIndex = 0;
			this.colbarcode.Width = 63;
			//
			//colitem_desc
			//
			this.colitem_desc.Caption = "Item Description";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 1;
			this.colitem_desc.Width = 192;
			//
			//colavailable
			//
			this.colavailable.Caption = "Available";
			this.colavailable.FieldName = "available";
			this.colavailable.Name = "colavailable";
			this.colavailable.Visible = true;
			this.colavailable.VisibleIndex = 2;
			this.colavailable.Width = 52;
			//
			//colsupplier
			//
			this.colsupplier.Caption = "Supplier";
			this.colsupplier.FieldName = "supplier";
			this.colsupplier.Name = "colsupplier";
			this.colsupplier.Visible = true;
			this.colsupplier.VisibleIndex = 3;
			this.colsupplier.Width = 104;
			//
			//colcatgory
			//
			this.colcatgory.Caption = "Category";
			this.colcatgory.FieldName = "catgory";
			this.colcatgory.Name = "colcatgory";
			this.colcatgory.Visible = true;
			this.colcatgory.VisibleIndex = 4;
			this.colcatgory.Width = 94;
			//
			//colDEPTD
			//
			this.colDEPTD.Caption = "Brand";
			this.colDEPTD.FieldName = "DEPTD";
			this.colDEPTD.Name = "colDEPTD";
			this.colDEPTD.Visible = true;
			this.colDEPTD.VisibleIndex = 5;
			this.colDEPTD.Width = 70;
			//
			//colsayz
			//
			this.colsayz.Caption = "Type";
			this.colsayz.FieldName = "sayz";
			this.colsayz.Name = "colsayz";
			this.colsayz.Visible = true;
			this.colsayz.VisibleIndex = 6;
			this.colsayz.Width = 65;
			//
			//colcost
			//
			this.colcost.Caption = "Cost";
			this.colcost.DisplayFormat.FormatString = "N2";
			this.colcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colcost.FieldName = "cost";
			this.colcost.Name = "colcost";
			this.colcost.Visible = true;
			this.colcost.VisibleIndex = 7;
			this.colcost.Width = 51;
			//
			//colretail
			//
			this.colretail.Caption = "Retail";
			this.colretail.DisplayFormat.FormatString = "N2";
			this.colretail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colretail.FieldName = "retail";
			this.colretail.Name = "colretail";
			this.colretail.Visible = true;
			this.colretail.VisibleIndex = 8;
			this.colretail.Width = 40;
			//
			//colretail2
			//
			this.colretail2.Caption = "Wholesale";
			this.colretail2.DisplayFormat.FormatString = "N2";
			this.colretail2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colretail2.FieldName = "retail2";
			this.colretail2.Name = "colretail2";
			this.colretail2.Visible = true;
			this.colretail2.VisibleIndex = 9;
			this.colretail2.Width = 56;
			//
			//collastprice
			//
			this.collastprice.Caption = "Last Price";
			this.collastprice.DisplayFormat.FormatString = "N2";
			this.collastprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.collastprice.FieldName = "lastprice";
			this.collastprice.Name = "collastprice";
			this.collastprice.Visible = true;
			this.collastprice.VisibleIndex = 10;
			this.collastprice.Width = 58;
			//
			//collastcost
			//
			this.collastcost.Caption = "Last Cost";
			this.collastcost.DisplayFormat.FormatString = "N2";
			this.collastcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.collastcost.FieldName = "lastcost";
			this.collastcost.Name = "collastcost";
			this.collastcost.Visible = true;
			this.collastcost.VisibleIndex = 11;
			this.collastcost.Width = 60;
			//
			//collastwholesale
			//
			this.collastwholesale.Caption = "Wholesale";
			this.collastwholesale.DisplayFormat.FormatString = "N2";
			this.collastwholesale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.collastwholesale.FieldName = "lastwholesale";
			this.collastwholesale.Name = "collastwholesale";
			this.collastwholesale.Visible = true;
			this.collastwholesale.VisibleIndex = 12;
			this.collastwholesale.Width = 62;
			//
			//colmaximum
			//
			this.colmaximum.Caption = "Max";
			this.colmaximum.DisplayFormat.FormatString = "N0";
			this.colmaximum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colmaximum.FieldName = "maximum";
			this.colmaximum.Name = "colmaximum";
			this.colmaximum.Visible = true;
			this.colmaximum.VisibleIndex = 14;
			this.colmaximum.Width = 29;
			//
			//colminimum
			//
			this.colminimum.Caption = "Min";
			this.colminimum.DisplayFormat.FormatString = "N0";
			this.colminimum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colminimum.FieldName = "minimum";
			this.colminimum.Name = "colminimum";
			this.colminimum.Visible = true;
			this.colminimum.VisibleIndex = 13;
			this.colminimum.Width = 27;
			//
			//collastdlvry
			//
			this.collastdlvry.Caption = "LastDlvry";
			this.collastdlvry.DisplayFormat.FormatString = "d";
			this.collastdlvry.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.collastdlvry.FieldName = "lastdlvry";
			this.collastdlvry.Name = "collastdlvry";
			this.collastdlvry.Visible = true;
			this.collastdlvry.VisibleIndex = 15;
			this.collastdlvry.Width = 43;
			//
			//VwItemsTableAdapter
			//
			this.VwItemsTableAdapter.ClearBeforeFill = true;
			//
			//frmItemList
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1240, 599);
			this.Controls.Add(this.GridControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmItemList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Item List";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VwItemsBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwItemsBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsvwItems).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal System.Windows.Forms.BindingSource DsvwItemsBindingSource;
		internal DoorsPOS.WinApp.dsvwItems DsvwItems;
		internal System.Windows.Forms.BindingSource VwItemsBindingSource;
		internal DoorsPOS.WinApp.dsvwItemsTableAdapters.vwItemsTableAdapter VwItemsTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn colbarcode;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn colavailable;
		internal DevExpress.XtraGrid.Columns.GridColumn colsupplier;
		internal DevExpress.XtraGrid.Columns.GridColumn colcatgory;
		internal DevExpress.XtraGrid.Columns.GridColumn colDEPTD;
		internal DevExpress.XtraGrid.Columns.GridColumn colsayz;
		internal DevExpress.XtraGrid.Columns.GridColumn colcost;
		internal DevExpress.XtraGrid.Columns.GridColumn colretail;
		internal DevExpress.XtraGrid.Columns.GridColumn colretail2;
		internal DevExpress.XtraGrid.Columns.GridColumn collastprice;
		internal DevExpress.XtraGrid.Columns.GridColumn collastcost;
		internal DevExpress.XtraGrid.Columns.GridColumn collastwholesale;
		internal DevExpress.XtraGrid.Columns.GridColumn colmaximum;
		internal DevExpress.XtraGrid.Columns.GridColumn colminimum;
		internal DevExpress.XtraGrid.Columns.GridColumn collastdlvry;
	}
	
}
