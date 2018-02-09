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
	partial class frmItemlist2 : System.Windows.Forms.Form
	{
		public frmItemlist2()
		{
			DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Tahoma", (float) (12.5F));
			// Track User Flag must be set here or it won't be set in time
			// MyBase.UserTrack = False
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			// This is done for apparent speed
			Control ctlSelected;
			ctlSelected = PDSAForms.GetActiveMDIChildControl(this);
			
			//Add any initialization after the InitializeComponent() call
			
			//MyBase.CheckSecurityOnControls = True
		}
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
			C1.C1DataExtender.C1DataView C1DataView1 = default(C1.C1DataExtender.C1DataView);
			C1.C1DataExtender.C1ViewColumn C1ViewColumn24 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn25 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn26 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn27 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn28 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn29 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn30 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn31 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn32 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn33 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn34 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn35 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn36 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn37 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn38 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn39 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn40 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn41 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn42 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn43 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn44 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn45 = new C1.C1DataExtender.C1ViewColumn();
			C1.C1DataExtender.C1ViewColumn C1ViewColumn46 = new C1.C1DataExtender.C1ViewColumn();
			this.C1DataViewSet1 = new C1.C1DataExtender.C1DataViewSet();
			base.Load += new System.EventHandler(frmItemlist2_Load);
			this.DsStakks = new DoorsPOS.WinApp.dsStakks();
			this.StocksBindingSource1 = new System.Windows.Forms.BindingSource();
			this.StocksTableAdapter1 = new DoorsPOS.WinApp.dsStakksTableAdapters.stocksTableAdapter();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave.Click += new System.EventHandler(this.SimpleButton1_Click);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridControl1.DoubleClick += new System.EventHandler(this.GridControl1_DoubleClick1);
			this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colstckid1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.barcode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colavailable1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colcost1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colmarkup1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ComputedRetail = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colretail1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.wsale = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ComputedMarkup = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colminimum1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colmaximum1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Incentive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Wholesale = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collastprice1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collastdlvry1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.collastwholesale = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Category = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RepositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
			this.CategoriesBindingSource1 = new System.Windows.Forms.BindingSource();
			this.CategoryDS = new DoorsPOS.WinApp.categoryDS();
			this.RepositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Brand = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RepositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
			this.DeptBindingSource = new System.Windows.Forms.BindingSource();
			this.DsBrand = new DoorsPOS.WinApp.dsBrand();
			this.RepositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.DsCategory = new DoorsPOS.WinApp.dsCategory();
			this.DsCategoryBindingSource = new System.Windows.Forms.BindingSource();
			this.CategoriesBindingSource = new System.Windows.Forms.BindingSource();
			this.categoriesTableAdapter = new DoorsPOS.WinApp.dsCategoryTableAdapters.categoriesTableAdapter();
			this.categoriesTableAdapter1 = new DoorsPOS.WinApp.categoryDSTableAdapters.categoriesTableAdapter();
			this.deptTableAdapter = new DoorsPOS.WinApp.dsBrandTableAdapters.deptTableAdapter();
			C1DataView1 = new C1.C1DataExtender.C1DataView();
			((System.ComponentModel.ISupportInitialize) this.C1DataViewSet1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsStakks).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.StocksBindingSource1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemGridLookUpEdit1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.CategoriesBindingSource1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.CategoryDS).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemGridLookUpEdit1View).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemGridLookUpEdit2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DeptBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsBrand).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemGridLookUpEdit2View).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsCategory).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsCategoryBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.CategoriesBindingSource).BeginInit();
			this.SuspendLayout();
			//
			//C1DataView1
			//
			C1DataView1.AllowDelete = false;
			C1DataView1.AllowNew = false;
			C1ViewColumn24.ColumnNameSerialized = "stckid";
			C1ViewColumn25.ColumnNameSerialized = "barcode";
			C1ViewColumn26.ColumnNameSerialized = "item_desc";
			C1ViewColumn27.ColumnNameSerialized = "available";
			C1ViewColumn28.ColumnNameSerialized = "cost";
			C1ViewColumn29.ColumnNameSerialized = "retail";
			C1ViewColumn30.ColumnNameSerialized = "wsale";
			C1ViewColumn31.ColumnNameSerialized = "markup";
			C1ViewColumn32.ColumnNameSerialized = "markup2";
			C1ViewColumn33.ColumnNameSerialized = "retail2";
			C1ViewColumn34.ColumnNameSerialized = "minimum";
			C1ViewColumn35.ColumnNameSerialized = "lastprice";
			C1ViewColumn36.ColumnNameSerialized = "lastdlvry";
			C1ViewColumn37.ColumnNameSerialized = "maximum";
			C1ViewColumn38.ColumnNameSerialized = "sInsert_id";
			C1ViewColumn39.ColumnNameSerialized = "lastcost";
			C1ViewColumn40.ColumnNameSerialized = "lastwholesale";
			C1ViewColumn41.ColumnNameSerialized = "packaging";
			C1ViewColumn42.ColumnNameSerialized = "incentive";
			C1ViewColumn43.ColumnNameSerialized = "vat";
			C1ViewColumn44.ColumnNameSerialized = "active";
			C1ViewColumn45.ColumnNameSerialized = "categoryid";
			C1ViewColumn46.ColumnNameSerialized = "dept";
			C1DataView1.ColumnDefs.Add(C1ViewColumn24);
			C1DataView1.ColumnDefs.Add(C1ViewColumn25);
			C1DataView1.ColumnDefs.Add(C1ViewColumn26);
			C1DataView1.ColumnDefs.Add(C1ViewColumn27);
			C1DataView1.ColumnDefs.Add(C1ViewColumn28);
			C1DataView1.ColumnDefs.Add(C1ViewColumn29);
			C1DataView1.ColumnDefs.Add(C1ViewColumn30);
			C1DataView1.ColumnDefs.Add(C1ViewColumn31);
			C1DataView1.ColumnDefs.Add(C1ViewColumn32);
			C1DataView1.ColumnDefs.Add(C1ViewColumn33);
			C1DataView1.ColumnDefs.Add(C1ViewColumn34);
			C1DataView1.ColumnDefs.Add(C1ViewColumn35);
			C1DataView1.ColumnDefs.Add(C1ViewColumn36);
			C1DataView1.ColumnDefs.Add(C1ViewColumn37);
			C1DataView1.ColumnDefs.Add(C1ViewColumn38);
			C1DataView1.ColumnDefs.Add(C1ViewColumn39);
			C1DataView1.ColumnDefs.Add(C1ViewColumn40);
			C1DataView1.ColumnDefs.Add(C1ViewColumn41);
			C1DataView1.ColumnDefs.Add(C1ViewColumn42);
			C1DataView1.ColumnDefs.Add(C1ViewColumn43);
			C1DataView1.ColumnDefs.Add(C1ViewColumn44);
			C1DataView1.ColumnDefs.Add(C1ViewColumn45);
			C1DataView1.ColumnDefs.Add(C1ViewColumn46);
			C1DataView1.Definition = "SELECT * FROM [stocks]";
			C1DataView1.DefinitionDiagramXML = "";
			C1DataView1.ViewName = "stocks";
			//
			//C1DataViewSet1
			//
			this.C1DataViewSet1.DataSet = this.DsStakks;
			this.C1DataViewSet1.DiagramXML = "<C1Diagram><Nodes><Node DesigningObjectName=\"stocks\"><Location X=\"10\" Y=\"10\" /><S" + 
				"ize Width=\"164\" Height=\"124\" /></Node></Nodes></C1Diagram>";
			this.C1DataViewSet1.Views.Add(C1DataView1);
			//
			//DsStakks
			//
			this.DsStakks.DataSetName = "dsStakks";
			this.DsStakks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//StocksBindingSource1
			//
			this.StocksBindingSource1.DataMember = "stocks";
			this.StocksBindingSource1.DataSource = this.DsStakks;
			//
			//StocksTableAdapter1
			//
			this.StocksTableAdapter1.ClearBeforeFill = true;
			//
			//btnSave
			//
			this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btnSave.Appearance.ForeColor = System.Drawing.Color.Red;
			this.btnSave.Appearance.Options.UseFont = true;
			this.btnSave.Appearance.Options.UseForeColor = true;
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSave.Location = new System.Drawing.Point(0, 0);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(1354, 45);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Click to &Submit Changes to the Database";
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.DataSource = this.StocksBindingSource1;
			this.GridControl1.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
			this.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
			this.GridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GridControl1.Location = new System.Drawing.Point(0, 55);
			this.GridControl1.MainView = this.GridView2;
			this.GridControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.RepositoryItemGridLookUpEdit1, this.RepositoryItemGridLookUpEdit2});
			this.GridControl1.Size = new System.Drawing.Size(1354, 564);
			this.GridControl1.TabIndex = 2;
			this.GridControl1.UseEmbeddedNavigator = true;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView2});
			//
			//GridView2
			//
			this.GridView2.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView2.Appearance.ColumnFilterButton.Options.UseFont = true;
			this.GridView2.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView2.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
			this.GridView2.Appearance.DetailTip.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView2.Appearance.DetailTip.Options.UseFont = true;
			this.GridView2.Appearance.FilterPanel.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView2.Appearance.FilterPanel.Options.UseFont = true;
			this.GridView2.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView2.Appearance.FocusedCell.Options.UseFont = true;
			this.GridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView2.Appearance.FocusedRow.Options.UseFont = true;
			this.GridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView2.Appearance.FooterPanel.Options.UseFont = true;
			this.GridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView2.Appearance.HeaderPanel.Options.UseFont = true;
			this.GridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView2.Appearance.Row.Options.UseFont = true;
			this.GridView2.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridView2.Appearance.ViewCaption.Options.UseFont = true;
			this.GridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colstckid1, this.barcode, this.ItemDescription, this.colavailable1, this.colcost1, this.colmarkup1, this.ComputedRetail, this.colretail1, this.wsale, this.ComputedMarkup, this.colminimum1, this.colmaximum1, this.Incentive, this.Wholesale, this.collastprice1, this.collastdlvry1, this.collastwholesale, this.Category, this.Brand});
			this.GridView2.GridControl = this.GridControl1;
			this.GridView2.Name = "GridView2";
			this.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
			this.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
			this.GridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
			this.GridView2.OptionsBehavior.ImmediateUpdateRowPosition = false;
			this.GridView2.OptionsCustomization.AllowGroup = false;
			this.GridView2.OptionsCustomization.AllowRowSizing = true;
			this.GridView2.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
			this.GridView2.OptionsEditForm.EditFormColumnCount = 2;
			this.GridView2.OptionsEditForm.FormCaptionFormat = "Edit Item";
			this.GridView2.OptionsEditForm.PopupEditFormWidth = 1000;
			this.GridView2.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
			this.GridView2.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
			this.GridView2.OptionsFind.AlwaysVisible = true;
			this.GridView2.OptionsView.ShowAutoFilterRow = true;
			this.GridView2.OptionsView.ShowFooter = true;
			this.GridView2.OptionsView.ShowGroupPanel = false;
			//
			//colstckid1
			//
			this.colstckid1.FieldName = "stckid";
			this.colstckid1.Name = "colstckid1";
			this.colstckid1.OptionsColumn.ReadOnly = true;
			this.colstckid1.OptionsEditForm.UseEditorColRowSpan = false;
			this.colstckid1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
			//
			//barcode
			//
			this.barcode.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.barcode.AppearanceCell.Options.UseFont = true;
			this.barcode.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.barcode.AppearanceHeader.Options.UseFont = true;
			this.barcode.Caption = "Barcode";
			this.barcode.FieldName = "barcode";
			this.barcode.Name = "barcode";
			this.barcode.Visible = true;
			this.barcode.VisibleIndex = 0;
			this.barcode.Width = 81;
			//
			//ItemDescription
			//
			this.ItemDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.ItemDescription.AppearanceCell.Options.UseFont = true;
			this.ItemDescription.AppearanceCell.Options.UseTextOptions = true;
			this.ItemDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.ItemDescription.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.ItemDescription.AppearanceHeader.Options.UseFont = true;
			this.ItemDescription.Caption = "Item Description";
			this.ItemDescription.FieldName = "item_desc";
			this.ItemDescription.Name = "ItemDescription";
			this.ItemDescription.Visible = true;
			this.ItemDescription.VisibleIndex = 1;
			this.ItemDescription.Width = 243;
			//
			//colavailable1
			//
			this.colavailable1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colavailable1.AppearanceCell.Options.UseFont = true;
			this.colavailable1.AppearanceHeader.Options.UseTextOptions = true;
			this.colavailable1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colavailable1.Caption = "Available";
			this.colavailable1.FieldName = "available";
			this.colavailable1.Name = "colavailable1";
			this.colavailable1.OptionsColumn.AllowEdit = false;
			this.colavailable1.OptionsColumn.ReadOnly = true;
			this.colavailable1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
			this.colavailable1.Visible = true;
			this.colavailable1.VisibleIndex = 2;
			this.colavailable1.Width = 46;
			//
			//colcost1
			//
			this.colcost1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colcost1.AppearanceCell.Options.UseFont = true;
			this.colcost1.AppearanceHeader.Options.UseTextOptions = true;
			this.colcost1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colcost1.Caption = "Cost";
			this.colcost1.DisplayFormat.FormatString = "N2";
			this.colcost1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colcost1.FieldName = "cost";
			this.colcost1.Name = "colcost1";
			this.colcost1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cost", "SUM={0:N2}")});
			this.colcost1.Visible = true;
			this.colcost1.VisibleIndex = 3;
			this.colcost1.Width = 57;
			//
			//colmarkup1
			//
			this.colmarkup1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colmarkup1.AppearanceCell.Options.UseFont = true;
			this.colmarkup1.AppearanceHeader.Options.UseTextOptions = true;
			this.colmarkup1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colmarkup1.Caption = "Markup";
			this.colmarkup1.FieldName = "markup";
			this.colmarkup1.Name = "colmarkup1";
			this.colmarkup1.Visible = true;
			this.colmarkup1.VisibleIndex = 4;
			this.colmarkup1.Width = 46;
			//
			//ComputedRetail
			//
			this.ComputedRetail.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			this.ComputedRetail.AppearanceCell.Options.UseFont = true;
			this.ComputedRetail.Caption = "Computed Retail";
			this.ComputedRetail.DisplayFormat.FormatString = "N2";
			this.ComputedRetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ComputedRetail.FieldName = "ComputedRetail";
			this.ComputedRetail.Name = "ComputedRetail";
			this.ComputedRetail.UnboundExpression = "[cost]+ ([cost] * ([markup] / 100))";
			this.ComputedRetail.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.ComputedRetail.Visible = true;
			this.ComputedRetail.VisibleIndex = 9;
			this.ComputedRetail.Width = 52;
			//
			//colretail1
			//
			this.colretail1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colretail1.AppearanceCell.Options.UseFont = true;
			this.colretail1.AppearanceHeader.Options.UseTextOptions = true;
			this.colretail1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.colretail1.Caption = "Retail";
			this.colretail1.DisplayFormat.FormatString = "N2";
			this.colretail1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colretail1.FieldName = "retail";
			this.colretail1.Name = "colretail1";
			this.colretail1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "retail", "SUM={0:N2}")});
			this.colretail1.Visible = true;
			this.colretail1.VisibleIndex = 5;
			//
			//wsale
			//
			this.wsale.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.wsale.AppearanceCell.Options.UseFont = true;
			this.wsale.AppearanceHeader.Options.UseTextOptions = true;
			this.wsale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.wsale.Caption = "Retail2";
			this.wsale.DisplayFormat.FormatString = "N2";
			this.wsale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.wsale.FieldName = "wsale";
			this.wsale.Name = "wsale";
			this.wsale.Visible = true;
			this.wsale.VisibleIndex = 6;
			this.wsale.Width = 61;
			//
			//ComputedMarkup
			//
			this.ComputedMarkup.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			this.ComputedMarkup.AppearanceCell.Options.UseFont = true;
			this.ComputedMarkup.Caption = "Computed Markup";
			this.ComputedMarkup.DisplayFormat.FormatString = "N2";
			this.ComputedMarkup.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ComputedMarkup.FieldName = "ComputedMarkup";
			this.ComputedMarkup.Name = "ComputedMarkup";
			this.ComputedMarkup.UnboundExpression = "((([wsale] - [cost]) * 100) /[cost])";
			this.ComputedMarkup.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.ComputedMarkup.Visible = true;
			this.ComputedMarkup.VisibleIndex = 10;
			this.ComputedMarkup.Width = 63;
			//
			//colminimum1
			//
			this.colminimum1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colminimum1.AppearanceCell.Options.UseFont = true;
			this.colminimum1.Caption = "Minimum";
			this.colminimum1.FieldName = "minimum";
			this.colminimum1.Name = "colminimum1";
			this.colminimum1.Visible = true;
			this.colminimum1.VisibleIndex = 7;
			this.colminimum1.Width = 37;
			//
			//colmaximum1
			//
			this.colmaximum1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.colmaximum1.AppearanceCell.Options.UseFont = true;
			this.colmaximum1.Caption = "Maximum";
			this.colmaximum1.FieldName = "maximum";
			this.colmaximum1.Name = "colmaximum1";
			this.colmaximum1.Visible = true;
			this.colmaximum1.VisibleIndex = 8;
			this.colmaximum1.Width = 39;
			//
			//Incentive
			//
			this.Incentive.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			this.Incentive.AppearanceCell.Options.UseFont = true;
			this.Incentive.Caption = "Incentive";
			this.Incentive.DisplayFormat.FormatString = "N2";
			this.Incentive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.Incentive.FieldName = "incentive";
			this.Incentive.Name = "Incentive";
			this.Incentive.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
			this.Incentive.Visible = true;
			this.Incentive.VisibleIndex = 11;
			this.Incentive.Width = 59;
			//
			//Wholesale
			//
			this.Wholesale.Caption = "Wholesale";
			this.Wholesale.FieldName = "retail2";
			this.Wholesale.Name = "Wholesale";
			this.Wholesale.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
			this.Wholesale.Visible = true;
			this.Wholesale.VisibleIndex = 14;
			this.Wholesale.Width = 84;
			//
			//collastprice1
			//
			this.collastprice1.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			this.collastprice1.AppearanceCell.Options.UseFont = true;
			this.collastprice1.Caption = "Last Price";
			this.collastprice1.FieldName = "lastprice";
			this.collastprice1.Name = "collastprice1";
			this.collastprice1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
			//
			//collastdlvry1
			//
			this.collastdlvry1.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			this.collastdlvry1.AppearanceCell.Options.UseFont = true;
			this.collastdlvry1.Caption = "Lst Delivery";
			this.collastdlvry1.FieldName = "lastdlvry";
			this.collastdlvry1.Name = "collastdlvry1";
			this.collastdlvry1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
			//
			//collastwholesale
			//
			this.collastwholesale.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			this.collastwholesale.AppearanceCell.Options.UseFont = true;
			this.collastwholesale.Caption = "Packaging";
			this.collastwholesale.FieldName = "lastwholesale";
			this.collastwholesale.Name = "collastwholesale";
			this.collastwholesale.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
			//
			//Category
			//
			this.Category.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			this.Category.AppearanceCell.Options.UseFont = true;
			this.Category.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			this.Category.AppearanceHeader.Options.UseFont = true;
			this.Category.Caption = "Category";
			this.Category.ColumnEdit = this.RepositoryItemGridLookUpEdit1;
			this.Category.FieldName = "categoryid";
			this.Category.Name = "Category";
			this.Category.OptionsEditForm.Caption = "Category";
			this.Category.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
			this.Category.Visible = true;
			this.Category.VisibleIndex = 12;
			this.Category.Width = 59;
			//
			//RepositoryItemGridLookUpEdit1
			//
			this.RepositoryItemGridLookUpEdit1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RepositoryItemGridLookUpEdit1.Appearance.Options.UseFont = true;
			this.RepositoryItemGridLookUpEdit1.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RepositoryItemGridLookUpEdit1.AppearanceDisabled.Options.UseFont = true;
			this.RepositoryItemGridLookUpEdit1.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			this.RepositoryItemGridLookUpEdit1.AppearanceDropDown.Options.UseFont = true;
			this.RepositoryItemGridLookUpEdit1.AppearanceFocused.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			this.RepositoryItemGridLookUpEdit1.AppearanceFocused.Options.UseFont = true;
			this.RepositoryItemGridLookUpEdit1.AppearanceReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			this.RepositoryItemGridLookUpEdit1.AppearanceReadOnly.Options.UseFont = true;
			this.RepositoryItemGridLookUpEdit1.AutoHeight = false;
			this.RepositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.RepositoryItemGridLookUpEdit1.DataSource = this.CategoriesBindingSource1;
			this.RepositoryItemGridLookUpEdit1.DisplayMember = "catgory";
			this.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1";
			this.RepositoryItemGridLookUpEdit1.ValueMember = "categoryid";
			this.RepositoryItemGridLookUpEdit1.View = this.RepositoryItemGridLookUpEdit1View;
			//
			//CategoriesBindingSource1
			//
			this.CategoriesBindingSource1.DataMember = "categories";
			this.CategoriesBindingSource1.DataSource = this.CategoryDS;
			//
			//CategoryDS
			//
			this.CategoryDS.DataSetName = "categoryDS";
			this.CategoryDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//RepositoryItemGridLookUpEdit1View
			//
			this.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View";
			this.RepositoryItemGridLookUpEdit1View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
			this.RepositoryItemGridLookUpEdit1View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
			this.RepositoryItemGridLookUpEdit1View.OptionsBehavior.AutoPopulateColumns = false;
			this.RepositoryItemGridLookUpEdit1View.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
			this.RepositoryItemGridLookUpEdit1View.OptionsEditForm.EditFormColumnCount = 1;
			this.RepositoryItemGridLookUpEdit1View.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
			this.RepositoryItemGridLookUpEdit1View.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
			this.RepositoryItemGridLookUpEdit1View.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
			this.RepositoryItemGridLookUpEdit1View.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
			this.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			//
			//Brand
			//
			this.Brand.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			this.Brand.AppearanceCell.Options.UseFont = true;
			this.Brand.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.Brand.AppearanceHeader.Options.UseFont = true;
			this.Brand.Caption = "Brand";
			this.Brand.ColumnEdit = this.RepositoryItemGridLookUpEdit2;
			this.Brand.FieldName = "dept";
			this.Brand.Name = "Brand";
			this.Brand.OptionsEditForm.Caption = "Brand";
			this.Brand.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
			this.Brand.Visible = true;
			this.Brand.VisibleIndex = 13;
			this.Brand.Width = 59;
			//
			//RepositoryItemGridLookUpEdit2
			//
			this.RepositoryItemGridLookUpEdit2.AutoHeight = false;
			this.RepositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.RepositoryItemGridLookUpEdit2.DataSource = this.DeptBindingSource;
			this.RepositoryItemGridLookUpEdit2.DisplayMember = "DEPTD";
			this.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2";
			this.RepositoryItemGridLookUpEdit2.ValueMember = "deptid";
			this.RepositoryItemGridLookUpEdit2.View = this.RepositoryItemGridLookUpEdit2View;
			//
			//DeptBindingSource
			//
			this.DeptBindingSource.DataMember = "dept";
			this.DeptBindingSource.DataSource = this.DsBrand;
			//
			//DsBrand
			//
			this.DsBrand.DataSetName = "dsBrand";
			this.DsBrand.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//RepositoryItemGridLookUpEdit2View
			//
			this.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View";
			this.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
			//
			//DsCategory
			//
			this.DsCategory.DataSetName = "dsCategory";
			this.DsCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//DsCategoryBindingSource
			//
			this.DsCategoryBindingSource.DataSource = this.DsCategory;
			this.DsCategoryBindingSource.Position = 0;
			//
			//CategoriesBindingSource
			//
			this.CategoriesBindingSource.DataMember = "categories";
			this.CategoriesBindingSource.DataSource = this.DsCategoryBindingSource;
			//
			//categoriesTableAdapter
			//
			this.categoriesTableAdapter.ClearBeforeFill = true;
			//
			//categoriesTableAdapter1
			//
			this.categoriesTableAdapter1.ClearBeforeFill = true;
			//
			//deptTableAdapter
			//
			this.deptTableAdapter.ClearBeforeFill = true;
			//
			//frmItemlist2
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (20.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1354, 633);
			this.Controls.Add(this.GridControl1);
			this.Controls.Add(this.btnSave);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmItemlist2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Item List";
			((System.ComponentModel.ISupportInitialize) this.C1DataViewSet1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsStakks).EndInit();
			((System.ComponentModel.ISupportInitialize) this.StocksBindingSource1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemGridLookUpEdit1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.CategoriesBindingSource1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.CategoryDS).EndInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemGridLookUpEdit1View).EndInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemGridLookUpEdit2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DeptBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsBrand).EndInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemGridLookUpEdit2View).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsCategory).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsCategoryBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.CategoriesBindingSource).EndInit();
			this.ResumeLayout(false);
			
		}
		internal C1.C1DataExtender.C1DataViewSet C1DataViewSet1;
		internal DoorsPOS.WinApp.dsStakks DsStakks;
		internal System.Windows.Forms.BindingSource StocksBindingSource1;
		internal DoorsPOS.WinApp.dsStakksTableAdapters.stocksTableAdapter StocksTableAdapter1;
		internal DevExpress.XtraEditors.SimpleButton btnSave;
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView2;
		internal DevExpress.XtraGrid.Columns.GridColumn colstckid1;
		internal DevExpress.XtraGrid.Columns.GridColumn barcode;
		internal DevExpress.XtraGrid.Columns.GridColumn ItemDescription;
		internal DevExpress.XtraGrid.Columns.GridColumn colavailable1;
		internal DevExpress.XtraGrid.Columns.GridColumn colcost1;
		internal DevExpress.XtraGrid.Columns.GridColumn colretail1;
		internal DevExpress.XtraGrid.Columns.GridColumn Category;
		internal DevExpress.XtraGrid.Columns.GridColumn colmarkup1;
		internal DevExpress.XtraGrid.Columns.GridColumn wsale;
		internal DevExpress.XtraGrid.Columns.GridColumn colminimum1;
		internal DevExpress.XtraGrid.Columns.GridColumn collastprice1;
		internal DevExpress.XtraGrid.Columns.GridColumn collastdlvry1;
		internal DevExpress.XtraGrid.Columns.GridColumn colmaximum1;
		internal DevExpress.XtraGrid.Columns.GridColumn collastwholesale;
		internal DevExpress.XtraGrid.Columns.GridColumn Brand;
		internal DevExpress.XtraGrid.Columns.GridColumn ComputedRetail;
		internal DevExpress.XtraGrid.Columns.GridColumn ComputedMarkup;
		internal DevExpress.XtraGrid.Columns.GridColumn Incentive;
		internal DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RepositoryItemGridLookUpEdit1;
		internal System.Windows.Forms.BindingSource DsCategoryBindingSource;
		internal DoorsPOS.WinApp.dsCategory DsCategory;
		internal DevExpress.XtraGrid.Views.Grid.GridView RepositoryItemGridLookUpEdit1View;
		internal System.Windows.Forms.BindingSource CategoriesBindingSource;
		internal DoorsPOS.WinApp.dsCategoryTableAdapters.categoriesTableAdapter categoriesTableAdapter;
		internal DoorsPOS.WinApp.categoryDS CategoryDS;
		internal System.Windows.Forms.BindingSource CategoriesBindingSource1;
		internal DoorsPOS.WinApp.categoryDSTableAdapters.categoriesTableAdapter categoriesTableAdapter1;
		internal DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit RepositoryItemGridLookUpEdit2;
		internal DevExpress.XtraGrid.Views.Grid.GridView RepositoryItemGridLookUpEdit2View;
		internal DoorsPOS.WinApp.dsBrand DsBrand;
		internal System.Windows.Forms.BindingSource DeptBindingSource;
		internal DoorsPOS.WinApp.dsBrandTableAdapters.deptTableAdapter deptTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn Wholesale;
	}
	
}
