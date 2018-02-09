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
	partial class frmAddBarcode : System.Windows.Forms.Form
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
			C1.C1DataExtender.C1ViewRelation C1ViewRelation1 = new C1.C1DataExtender.C1ViewRelation();
			DevExpress.XtraGrid.GridLevelNode GridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			C1.C1DataExtender.C1DataView C1DataView1 = default(C1.C1DataExtender.C1DataView);
			C1.C1DataExtender.C1ViewColumn C1ViewColumn5 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn6 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn7 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1DataView C1DataView2 = default(C1.C1DataExtender.C1DataView);
			C1.C1DataExtender.C1ViewColumn C1ViewColumn1 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn2 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn3 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn4 = new C1.C1DataExtender.C1ViewColumn();
			this.c1DataViewSet1 = new C1.C1DataExtender.C1DataViewSet();
			base.Load += new System.EventHandler(frmAddBarcode_Load);
			this.DsStocksBarcode = new DoorsPOS.WinApp.dsStocksBarcode();
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colstckid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbarcode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colitem_desc = new DevExpress.XtraGrid.Columns.GridColumn();
			this.CardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
			this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.CardView2 = new DevExpress.XtraGrid.Views.Card.CardView();
			this.tblBarcodesTableAdapter1 = new DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.tblBarcodesTableAdapter();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			C1DataView1 = new C1.C1DataExtender.C1DataView();
			C1DataView2 = new C1.C1DataExtender.C1DataView();
			((System.ComponentModel.ISupportInitialize) this.c1DataViewSet1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsStocksBarcode).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.CardView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.CardView2).BeginInit();
			this.SuspendLayout();
			//
			//c1DataViewSet1
			//
			this.c1DataViewSet1.DataSet = this.DsStocksBarcode;
			this.c1DataViewSet1.DiagramXML = "";
			C1ViewRelation1.ChildView = C1DataView2;
			C1ViewRelation1.ParentView = C1DataView1;
			this.c1DataViewSet1.Relations.Add(C1ViewRelation1);
			this.c1DataViewSet1.Views.Add(C1DataView1);
			this.c1DataViewSet1.Views.Add(C1DataView2);
			//
			//DsStocksBarcode
			//
			this.DsStocksBarcode.DataSetName = "dsStocksBarcode";
			this.DsStocksBarcode.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.DataMember = "stocks";
			this.GridControl1.DataSource = this.DsStocksBarcode;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
			this.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
			this.GridControl1.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
			this.GridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			GridLevelNode1.LevelTemplate = this.CardView1;
			GridLevelNode1.RelationName = "FK_tblBarcodes_stocks";
			this.GridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {GridLevelNode1});
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.gridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(918, 443);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gridView1, this.CardView1, this.CardView2});
			//
			//gridView1
			//
			this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colstckid, this.colbarcode, this.colitem_desc});
			this.gridView1.GridControl = this.GridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowAutoFilterRow = true;
			//
			//colstckid
			//
			this.colstckid.FieldName = "stckid";
			this.colstckid.Name = "colstckid";
			this.colstckid.OptionsColumn.ReadOnly = true;
			//
			//colbarcode
			//
			this.colbarcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.colbarcode.AppearanceCell.Options.UseFont = true;
			this.colbarcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.colbarcode.AppearanceHeader.Options.UseFont = true;
			this.colbarcode.Caption = "Original Barcode";
			this.colbarcode.FieldName = "barcode";
			this.colbarcode.Name = "colbarcode";
			this.colbarcode.Visible = true;
			this.colbarcode.VisibleIndex = 1;
			//
			//colitem_desc
			//
			this.colitem_desc.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.colitem_desc.AppearanceCell.Options.UseFont = true;
			this.colitem_desc.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colitem_desc.AppearanceHeader.Options.UseFont = true;
			this.colitem_desc.Caption = "Items";
			this.colitem_desc.FieldName = "item_desc";
			this.colitem_desc.Name = "colitem_desc";
			this.colitem_desc.OptionsColumn.AllowEdit = false;
			this.colitem_desc.Visible = true;
			this.colitem_desc.VisibleIndex = 0;
			//
			//CardView1
			//
			this.CardView1.Appearance.Card.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CardView1.Appearance.Card.Options.UseFont = true;
			this.CardView1.Appearance.CardCaption.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CardView1.Appearance.CardCaption.Options.UseFont = true;
			this.CardView1.Appearance.CardExpandButton.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CardView1.Appearance.CardExpandButton.Options.UseFont = true;
			this.CardView1.Appearance.FieldCaption.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CardView1.Appearance.FieldCaption.Options.UseFont = true;
			this.CardView1.Appearance.FieldValue.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CardView1.Appearance.FieldValue.Options.UseFont = true;
			this.CardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.GridColumn1, this.GridColumn2});
			this.CardView1.FocusedCardTopFieldIndex = 0;
			this.CardView1.GridControl = this.GridControl1;
			this.CardView1.Name = "CardView1";
			this.CardView1.OptionsView.ShowQuickCustomizeButton = false;
			//
			//GridColumn1
			//
			this.GridColumn1.Caption = "Barcode";
			this.GridColumn1.FieldName = "barcode";
			this.GridColumn1.Name = "GridColumn1";
			this.GridColumn1.Visible = true;
			this.GridColumn1.VisibleIndex = 0;
			//
			//GridColumn2
			//
			this.GridColumn2.Caption = "Date Added";
			this.GridColumn2.FieldName = "dateadded";
			this.GridColumn2.Name = "GridColumn2";
			this.GridColumn2.Visible = true;
			this.GridColumn2.VisibleIndex = 1;
			//
			//C1DataView1
			//
			C1ViewColumn5.ColumnNameSerialized = "stckid";
			C1ViewColumn6.ColumnNameSerialized = "barcode";
			C1ViewColumn7.ColumnNameSerialized = "item_desc";
			C1DataView1.ColumnDefs.Add(C1ViewColumn5);
			C1DataView1.ColumnDefs.Add(C1ViewColumn6);
			C1DataView1.ColumnDefs.Add(C1ViewColumn7);
			C1DataView1.Definition = "SELECT * FROM [stocks]";
			C1DataView1.DefinitionDiagramXML = "";
			C1DataView1.Sort = "item_desc";
			C1DataView1.ViewName = "stocks";
			//
			//C1DataView2
			//
			C1ViewColumn1.ColumnNameSerialized = "bcodeid";
			C1ViewColumn2.ColumnNameSerialized = "barcode";
			C1ViewColumn3.ColumnNameSerialized = "stckid";
			C1ViewColumn4.ColumnNameSerialized = "dateadded";
			C1DataView2.ColumnDefs.Add(C1ViewColumn1);
			C1DataView2.ColumnDefs.Add(C1ViewColumn2);
			C1DataView2.ColumnDefs.Add(C1ViewColumn3);
			C1DataView2.ColumnDefs.Add(C1ViewColumn4);
			C1DataView2.Definition = "SELECT tblBarcodes.* FROM tblBarcodes";
			C1DataView2.DefinitionDiagramXML = "<C1Diagram><Nodes><Node DesigningObjectName=\"tblBarcodes\"><Location X=\"10\" Y=\"10\"" + 
				" /><Size Width=\"164\" Height=\"124\" /></Node></Nodes></C1Diagram>";
			C1DataView2.ViewName = "tblBarcodes";
			//
			//CardView2
			//
			this.CardView2.FocusedCardTopFieldIndex = 0;
			this.CardView2.GridControl = this.GridControl1;
			this.CardView2.Name = "CardView2";
			//
			//tblBarcodesTableAdapter1
			//
			this.tblBarcodesTableAdapter1.ClearBeforeFill = true;
			//
			//btnSave
			//
			this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btnSave.Appearance.ForeColor = System.Drawing.Color.Red;
			this.btnSave.Appearance.Options.UseFont = true;
			this.btnSave.Appearance.Options.UseForeColor = true;
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnSave.Location = new System.Drawing.Point(0, 420);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(918, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save Changes to the Database";
			//
			//frmAddBarcode
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(918, 443);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmAddBarcode";
			this.Text = "frmAddBarcode";
			((System.ComponentModel.ISupportInitialize) this.c1DataViewSet1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsStocksBarcode).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.CardView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.CardView2).EndInit();
			this.ResumeLayout(false);
			
		}
		internal C1.C1DataExtender.C1DataViewSet c1DataViewSet1;
		internal DoorsPOS.WinApp.dsStocksBarcode DsStocksBarcode;
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Card.CardView CardView1;
		internal DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		internal DevExpress.XtraGrid.Columns.GridColumn colstckid;
		internal DevExpress.XtraGrid.Columns.GridColumn colbarcode;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem_desc;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
		internal DevExpress.XtraGrid.Views.Card.CardView CardView2;
		internal DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.tblBarcodesTableAdapter tblBarcodesTableAdapter1;
		internal DevExpress.XtraEditors.SimpleButton btnSave;
	}
	
}
