<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemlist2
    Inherits System.Windows.Forms.Form
    Public Sub New()
        MyBase.New()
        DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Tahoma", 12.5)
        ' Track User Flag must be set here or it won't be set in time
        ' MyBase.UserTrack = False

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        ' This is done for apparent speed
        Dim ctlSelected As Control
        ctlSelected = PDSAForms.GetActiveMDIChildControl(Me)

        'Add any initialization after the InitializeComponent() call

        'MyBase.CheckSecurityOnControls = True
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim C1DataView1 As C1.C1DataExtender.C1DataView
        Dim C1ViewColumn53 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn54 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn55 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn56 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn57 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn58 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn59 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn60 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn61 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn62 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn63 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn64 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn65 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn66 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn67 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn68 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn69 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn70 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn71 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn72 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn73 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn74 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn75 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn76 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn77 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn78 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemlist2))
        Me.C1DataViewSet1 = New C1.C1DataExtender.C1DataViewSet()
        Me.DsStakks = New DoorsPOS.WinApp.dsStakks()
        Me.StocksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StocksTableAdapter1 = New DoorsPOS.WinApp.dsStakksTableAdapters.stocksTableAdapter()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colstckid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.barcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpackaging = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colavailable1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcost1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmarkup1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ComputedRetail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colretail1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.wsale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ComputedMarkup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colminimum1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmaximum1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Wholesale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastprice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastdlvry1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastwholesale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.CategoriesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryDS = New DoorsPOS.WinApp.categoryDS()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsBrand = New DoorsPOS.WinApp.dsBrand()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsLastUpdate_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtLastUpdate_dt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvat1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colincentive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.DsCategory = New DoorsPOS.WinApp.dsCategory()
        Me.DsCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.categoriesTableAdapter = New DoorsPOS.WinApp.dsCategoryTableAdapters.categoriesTableAdapter()
        Me.categoriesTableAdapter1 = New DoorsPOS.WinApp.categoryDSTableAdapters.categoriesTableAdapter()
        Me.deptTableAdapter = New DoorsPOS.WinApp.dsBrandTableAdapters.deptTableAdapter()
        Me.colincentive1 = New DevExpress.XtraGrid.Columns.GridColumn()
        C1DataView1 = New C1.C1DataExtender.C1DataView()
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsStakks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DataView1
        '
        C1DataView1.AllowNew = False
        C1ViewColumn53.ColumnNameSerialized = "stckid"
        C1ViewColumn54.ColumnNameSerialized = "barcode"
        C1ViewColumn55.ColumnNameSerialized = "item_desc"
        C1ViewColumn56.ColumnNameSerialized = "available"
        C1ViewColumn57.ColumnNameSerialized = "cost"
        C1ViewColumn58.ColumnNameSerialized = "retail"
        C1ViewColumn59.ColumnNameSerialized = "wsale"
        C1ViewColumn60.ColumnNameSerialized = "markup"
        C1ViewColumn61.ColumnNameSerialized = "markup2"
        C1ViewColumn62.ColumnNameSerialized = "retail2"
        C1ViewColumn63.ColumnNameSerialized = "minimum"
        C1ViewColumn64.ColumnNameSerialized = "lastprice"
        C1ViewColumn65.ColumnNameSerialized = "lastdlvry"
        C1ViewColumn66.ColumnNameSerialized = "maximum"
        C1ViewColumn67.ColumnNameSerialized = "sInsert_id"
        C1ViewColumn68.ColumnNameSerialized = "lastcost"
        C1ViewColumn69.ColumnNameSerialized = "lastwholesale"
        C1ViewColumn70.ColumnNameSerialized = "packaging"
        C1ViewColumn71.ColumnNameSerialized = "incentive"
        C1ViewColumn72.ColumnNameSerialized = "vat"
        C1ViewColumn73.ColumnNameSerialized = "active"
        C1ViewColumn74.ColumnNameSerialized = "categoryid"
        C1ViewColumn75.ColumnNameSerialized = "dept"
        C1ViewColumn76.ColumnNameSerialized = "sLastUpdate_id"
        C1ViewColumn77.ColumnNameSerialized = "dtLastUpdate_dt"
        C1ViewColumn78.ColumnNameSerialized = "supcode"
        C1DataView1.ColumnDefs.Add(C1ViewColumn53)
        C1DataView1.ColumnDefs.Add(C1ViewColumn54)
        C1DataView1.ColumnDefs.Add(C1ViewColumn55)
        C1DataView1.ColumnDefs.Add(C1ViewColumn56)
        C1DataView1.ColumnDefs.Add(C1ViewColumn57)
        C1DataView1.ColumnDefs.Add(C1ViewColumn58)
        C1DataView1.ColumnDefs.Add(C1ViewColumn59)
        C1DataView1.ColumnDefs.Add(C1ViewColumn60)
        C1DataView1.ColumnDefs.Add(C1ViewColumn61)
        C1DataView1.ColumnDefs.Add(C1ViewColumn62)
        C1DataView1.ColumnDefs.Add(C1ViewColumn63)
        C1DataView1.ColumnDefs.Add(C1ViewColumn64)
        C1DataView1.ColumnDefs.Add(C1ViewColumn65)
        C1DataView1.ColumnDefs.Add(C1ViewColumn66)
        C1DataView1.ColumnDefs.Add(C1ViewColumn67)
        C1DataView1.ColumnDefs.Add(C1ViewColumn68)
        C1DataView1.ColumnDefs.Add(C1ViewColumn69)
        C1DataView1.ColumnDefs.Add(C1ViewColumn70)
        C1DataView1.ColumnDefs.Add(C1ViewColumn71)
        C1DataView1.ColumnDefs.Add(C1ViewColumn72)
        C1DataView1.ColumnDefs.Add(C1ViewColumn73)
        C1DataView1.ColumnDefs.Add(C1ViewColumn74)
        C1DataView1.ColumnDefs.Add(C1ViewColumn75)
        C1DataView1.ColumnDefs.Add(C1ViewColumn76)
        C1DataView1.ColumnDefs.Add(C1ViewColumn77)
        C1DataView1.ColumnDefs.Add(C1ViewColumn78)
        C1DataView1.Definition = resources.GetString("C1DataView1.Definition")
        C1DataView1.DefinitionDiagramXML = "<C1Diagram><Nodes /></C1Diagram>"
        C1DataView1.ViewName = "stocks"
        '
        'C1DataViewSet1
        '
        Me.C1DataViewSet1.DataSet = Me.DsStakks
        Me.C1DataViewSet1.DiagramXML = "<C1Diagram><Nodes><Node DesigningObjectName=""stocks""><Location X=""10"" Y=""10"" /><S" &
    "ize Width=""164"" Height=""124"" /></Node></Nodes></C1Diagram>"
        Me.C1DataViewSet1.Views.Add(C1DataView1)
        '
        'DsStakks
        '
        Me.DsStakks.DataSetName = "dsStakks"
        Me.DsStakks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StocksBindingSource1
        '
        Me.StocksBindingSource1.DataMember = "stocks"
        Me.StocksBindingSource1.DataSource = Me.DsStakks
        '
        'StocksTableAdapter1
        '
        Me.StocksTableAdapter1.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Appearance.Options.UseForeColor = True
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(1354, 45)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Click to &Submit Changes to the Database"
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.StocksBindingSource1
        Me.GridControl1.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(0, 55)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemGridLookUpEdit2, Me.RepositoryItemComboBox1})
        Me.GridControl1.Size = New System.Drawing.Size(1354, 564)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.GridView2.Appearance.DetailTip.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView2.Appearance.DetailTip.Options.UseFont = True
        Me.GridView2.Appearance.FilterPanel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView2.Appearance.FilterPanel.Options.UseFont = True
        Me.GridView2.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView2.Appearance.FocusedCell.Options.UseFont = True
        Me.GridView2.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView2.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView2.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView2.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView2.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colstckid1, Me.barcode, Me.ItemDescription, Me.colpackaging, Me.colavailable1, Me.colcost1, Me.colmarkup1, Me.ComputedRetail, Me.colretail1, Me.wsale, Me.ComputedMarkup, Me.colminimum1, Me.colmaximum1, Me.Wholesale, Me.collastprice1, Me.collastdlvry1, Me.collastwholesale, Me.Category, Me.Brand, Me.colsLastUpdate_id, Me.coldtLastUpdate_dt, Me.colvat1, Me.colincentive1, Me.colincentive})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView2.OptionsBehavior.ImmediateUpdateRowPosition = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowRowSizing = True
        Me.GridView2.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.[Nothing]
        Me.GridView2.OptionsEditForm.EditFormColumnCount = 2
        Me.GridView2.OptionsEditForm.FormCaptionFormat = "Edit Item"
        Me.GridView2.OptionsEditForm.PopupEditFormWidth = 1000
        Me.GridView2.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsFind.AlwaysVisible = True
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colstckid1
        '
        Me.colstckid1.FieldName = "stckid"
        Me.colstckid1.Name = "colstckid1"
        Me.colstckid1.OptionsColumn.ReadOnly = True
        Me.colstckid1.OptionsEditForm.UseEditorColRowSpan = False
        Me.colstckid1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        '
        'barcode
        '
        Me.barcode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.barcode.AppearanceCell.Options.UseFont = True
        Me.barcode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.barcode.AppearanceHeader.Options.UseFont = True
        Me.barcode.Caption = "Barcode"
        Me.barcode.FieldName = "barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.Visible = True
        Me.barcode.VisibleIndex = 0
        Me.barcode.Width = 101
        '
        'ItemDescription
        '
        Me.ItemDescription.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ItemDescription.AppearanceCell.Options.UseFont = True
        Me.ItemDescription.AppearanceCell.Options.UseTextOptions = True
        Me.ItemDescription.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ItemDescription.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ItemDescription.AppearanceHeader.Options.UseFont = True
        Me.ItemDescription.Caption = "Item Description"
        Me.ItemDescription.FieldName = "item_desc"
        Me.ItemDescription.Name = "ItemDescription"
        Me.ItemDescription.Visible = True
        Me.ItemDescription.VisibleIndex = 1
        Me.ItemDescription.Width = 264
        '
        'colpackaging
        '
        Me.colpackaging.Caption = "Packaging"
        Me.colpackaging.FieldName = "packaging"
        Me.colpackaging.Name = "colpackaging"
        Me.colpackaging.Width = 73
        '
        'colavailable1
        '
        Me.colavailable1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colavailable1.AppearanceCell.Options.UseFont = True
        Me.colavailable1.AppearanceHeader.Options.UseTextOptions = True
        Me.colavailable1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colavailable1.Caption = "Available"
        Me.colavailable1.FieldName = "available"
        Me.colavailable1.Name = "colavailable1"
        Me.colavailable1.OptionsColumn.AllowEdit = False
        Me.colavailable1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colavailable1.Visible = True
        Me.colavailable1.VisibleIndex = 2
        Me.colavailable1.Width = 80
        '
        'colcost1
        '
        Me.colcost1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colcost1.AppearanceCell.Options.UseFont = True
        Me.colcost1.AppearanceHeader.Options.UseTextOptions = True
        Me.colcost1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colcost1.Caption = "Cost"
        Me.colcost1.DisplayFormat.FormatString = "N2"
        Me.colcost1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcost1.FieldName = "cost"
        Me.colcost1.Name = "colcost1"
        Me.colcost1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cost", "SUM={0:N2}")})
        Me.colcost1.Visible = True
        Me.colcost1.VisibleIndex = 3
        Me.colcost1.Width = 70
        '
        'colmarkup1
        '
        Me.colmarkup1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colmarkup1.AppearanceCell.Options.UseFont = True
        Me.colmarkup1.AppearanceHeader.Options.UseTextOptions = True
        Me.colmarkup1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colmarkup1.Caption = "Markup"
        Me.colmarkup1.FieldName = "markup"
        Me.colmarkup1.Name = "colmarkup1"
        Me.colmarkup1.Visible = True
        Me.colmarkup1.VisibleIndex = 4
        Me.colmarkup1.Width = 82
        '
        'ComputedRetail
        '
        Me.ComputedRetail.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComputedRetail.AppearanceCell.Options.UseFont = True
        Me.ComputedRetail.AppearanceCell.Options.UseTextOptions = True
        Me.ComputedRetail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ComputedRetail.Caption = "Computed Retail"
        Me.ComputedRetail.DisplayFormat.FormatString = "N2"
        Me.ComputedRetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ComputedRetail.FieldName = "ComputedRetail"
        Me.ComputedRetail.Name = "ComputedRetail"
        Me.ComputedRetail.UnboundExpression = "Round([cost] + [cost] * ([markup] / 100), 2)"
        Me.ComputedRetail.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ComputedRetail.Width = 218
        '
        'colretail1
        '
        Me.colretail1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colretail1.AppearanceCell.Options.UseFont = True
        Me.colretail1.AppearanceHeader.Options.UseTextOptions = True
        Me.colretail1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colretail1.Caption = "Retail"
        Me.colretail1.DisplayFormat.FormatString = "N2"
        Me.colretail1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colretail1.FieldName = "retail"
        Me.colretail1.Name = "colretail1"
        Me.colretail1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "retail", "SUM={0:N2}")})
        Me.colretail1.Visible = True
        Me.colretail1.VisibleIndex = 5
        Me.colretail1.Width = 78
        '
        'wsale
        '
        Me.wsale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.wsale.AppearanceCell.Options.UseFont = True
        Me.wsale.AppearanceHeader.Options.UseTextOptions = True
        Me.wsale.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.wsale.Caption = "Retail2"
        Me.wsale.DisplayFormat.FormatString = "N2"
        Me.wsale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.wsale.FieldName = "wsale"
        Me.wsale.Name = "wsale"
        Me.wsale.Width = 95
        '
        'ComputedMarkup
        '
        Me.ComputedMarkup.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComputedMarkup.AppearanceCell.Options.UseFont = True
        Me.ComputedMarkup.Caption = "Computed Markup"
        Me.ComputedMarkup.DisplayFormat.FormatString = "N2"
        Me.ComputedMarkup.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ComputedMarkup.FieldName = "ComputedMarkup"
        Me.ComputedMarkup.Name = "ComputedMarkup"
        Me.ComputedMarkup.UnboundExpression = "([wsale] - [cost]) * 100 / [cost]"
        Me.ComputedMarkup.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.ComputedMarkup.Width = 100
        '
        'colminimum1
        '
        Me.colminimum1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colminimum1.AppearanceCell.Options.UseFont = True
        Me.colminimum1.Caption = "Minimum"
        Me.colminimum1.FieldName = "minimum"
        Me.colminimum1.Name = "colminimum1"
        Me.colminimum1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colminimum1.Width = 46
        '
        'colmaximum1
        '
        Me.colmaximum1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colmaximum1.AppearanceCell.Options.UseFont = True
        Me.colmaximum1.Caption = "Maximum"
        Me.colmaximum1.FieldName = "maximum"
        Me.colmaximum1.Name = "colmaximum1"
        Me.colmaximum1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colmaximum1.Width = 49
        '
        'Wholesale
        '
        Me.Wholesale.Caption = "Wholesale"
        Me.Wholesale.FieldName = "retail2"
        Me.Wholesale.Name = "Wholesale"
        Me.Wholesale.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.Wholesale.Visible = True
        Me.Wholesale.VisibleIndex = 6
        Me.Wholesale.Width = 96
        '
        'collastprice1
        '
        Me.collastprice1.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.collastprice1.AppearanceCell.Options.UseFont = True
        Me.collastprice1.Caption = "Last Price"
        Me.collastprice1.FieldName = "lastprice"
        Me.collastprice1.Name = "collastprice1"
        Me.collastprice1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        '
        'collastdlvry1
        '
        Me.collastdlvry1.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.collastdlvry1.AppearanceCell.Options.UseFont = True
        Me.collastdlvry1.Caption = "Lst Delivery"
        Me.collastdlvry1.FieldName = "lastdlvry"
        Me.collastdlvry1.Name = "collastdlvry1"
        Me.collastdlvry1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        '
        'collastwholesale
        '
        Me.collastwholesale.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.collastwholesale.AppearanceCell.Options.UseFont = True
        Me.collastwholesale.Caption = "Packaging"
        Me.collastwholesale.FieldName = "lastwholesale"
        Me.collastwholesale.Name = "collastwholesale"
        Me.collastwholesale.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        '
        'Category
        '
        Me.Category.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Category.AppearanceCell.Options.UseFont = True
        Me.Category.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Category.AppearanceHeader.Options.UseFont = True
        Me.Category.Caption = "Category"
        Me.Category.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.Category.FieldName = "categoryid"
        Me.Category.Name = "Category"
        Me.Category.OptionsEditForm.Caption = "Category"
        Me.Category.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.Category.Visible = True
        Me.Category.VisibleIndex = 7
        Me.Category.Width = 89
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemGridLookUpEdit1.Appearance.Options.UseFont = True
        Me.RepositoryItemGridLookUpEdit1.AppearanceDisabled.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepositoryItemGridLookUpEdit1.AppearanceDisabled.Options.UseFont = True
        Me.RepositoryItemGridLookUpEdit1.AppearanceDropDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RepositoryItemGridLookUpEdit1.AppearanceDropDown.Options.UseFont = True
        Me.RepositoryItemGridLookUpEdit1.AppearanceFocused.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RepositoryItemGridLookUpEdit1.AppearanceFocused.Options.UseFont = True
        Me.RepositoryItemGridLookUpEdit1.AppearanceReadOnly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RepositoryItemGridLookUpEdit1.AppearanceReadOnly.Options.UseFont = True
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.CategoriesBindingSource1
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "catgory"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "categoryid"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'CategoriesBindingSource1
        '
        Me.CategoriesBindingSource1.DataMember = "categories"
        Me.CategoriesBindingSource1.DataSource = Me.CategoryDS
        '
        'CategoryDS
        '
        Me.CategoryDS.DataSetName = "categoryDS"
        Me.CategoryDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemGridLookUpEdit1View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemGridLookUpEdit1View.OptionsBehavior.AutoPopulateColumns = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace
        Me.RepositoryItemGridLookUpEdit1View.OptionsEditForm.EditFormColumnCount = 1
        Me.RepositoryItemGridLookUpEdit1View.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemGridLookUpEdit1View.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemGridLookUpEdit1View.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemGridLookUpEdit1View.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Brand
        '
        Me.Brand.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Brand.AppearanceCell.Options.UseFont = True
        Me.Brand.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Brand.AppearanceHeader.Options.UseFont = True
        Me.Brand.Caption = "Brand"
        Me.Brand.ColumnEdit = Me.RepositoryItemGridLookUpEdit2
        Me.Brand.FieldName = "dept"
        Me.Brand.Name = "Brand"
        Me.Brand.OptionsEditForm.Caption = "Brand"
        Me.Brand.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.Brand.Visible = True
        Me.Brand.VisibleIndex = 8
        Me.Brand.Width = 79
        '
        'RepositoryItemGridLookUpEdit2
        '
        Me.RepositoryItemGridLookUpEdit2.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit2.DataSource = Me.DeptBindingSource
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "DEPTD"
        Me.RepositoryItemGridLookUpEdit2.Name = "RepositoryItemGridLookUpEdit2"
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "deptid"
        Me.RepositoryItemGridLookUpEdit2.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'DeptBindingSource
        '
        Me.DeptBindingSource.DataMember = "dept"
        Me.DeptBindingSource.DataSource = Me.DsBrand
        '
        'DsBrand
        '
        Me.DsBrand.DataSetName = "dsBrand"
        Me.DsBrand.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'colsLastUpdate_id
        '
        Me.colsLastUpdate_id.Caption = "Updated By"
        Me.colsLastUpdate_id.FieldName = "sLastUpdate_id"
        Me.colsLastUpdate_id.Name = "colsLastUpdate_id"
        Me.colsLastUpdate_id.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.colsLastUpdate_id.Visible = True
        Me.colsLastUpdate_id.VisibleIndex = 11
        Me.colsLastUpdate_id.Width = 84
        '
        'coldtLastUpdate_dt
        '
        Me.coldtLastUpdate_dt.Caption = "Updated On"
        Me.coldtLastUpdate_dt.FieldName = "dtLastUpdate_dt"
        Me.coldtLastUpdate_dt.Name = "coldtLastUpdate_dt"
        Me.coldtLastUpdate_dt.Visible = True
        Me.coldtLastUpdate_dt.VisibleIndex = 12
        Me.coldtLastUpdate_dt.Width = 84
        '
        'colvat1
        '
        Me.colvat1.Caption = "With Incentive?"
        Me.colvat1.FieldName = "vat"
        Me.colvat1.Name = "colvat1"
        Me.colvat1.Width = 97
        '
        'colincentive
        '
        Me.colincentive.Caption = "VAT?"
        Me.colincentive.FieldName = "active"
        Me.colincentive.Name = "colincentive"
        Me.colincentive.Visible = True
        Me.colincentive.VisibleIndex = 10
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'DsCategory
        '
        Me.DsCategory.DataSetName = "dsCategory"
        Me.DsCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsCategoryBindingSource
        '
        Me.DsCategoryBindingSource.DataSource = Me.DsCategory
        Me.DsCategoryBindingSource.Position = 0
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "categories"
        Me.CategoriesBindingSource.DataSource = Me.DsCategoryBindingSource
        '
        'categoriesTableAdapter
        '
        Me.categoriesTableAdapter.ClearBeforeFill = True
        '
        'categoriesTableAdapter1
        '
        Me.categoriesTableAdapter1.ClearBeforeFill = True
        '
        'deptTableAdapter
        '
        Me.deptTableAdapter.ClearBeforeFill = True
        '
        'colincentive1
        '
        Me.colincentive1.Caption = "Incentive Amount"
        Me.colincentive1.FieldName = "incentive"
        Me.colincentive1.Name = "colincentive1"
        Me.colincentive1.Visible = True
        Me.colincentive1.VisibleIndex = 9
        '
        'frmItemlist2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 633)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmItemlist2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Item List"
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsStakks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBrand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1DataViewSet1 As C1.C1DataExtender.C1DataViewSet
    Friend WithEvents DsStakks As DoorsPOS.WinApp.dsStakks
    Friend WithEvents StocksBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StocksTableAdapter1 As DoorsPOS.WinApp.dsStakksTableAdapters.stocksTableAdapter
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colstckid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colavailable1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcost1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colretail1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmarkup1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents wsale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colminimum1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastprice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastdlvry1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmaximum1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastwholesale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComputedRetail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComputedMarkup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents DsCategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCategory As DoorsPOS.WinApp.dsCategory
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents categoriesTableAdapter As DoorsPOS.WinApp.dsCategoryTableAdapters.categoriesTableAdapter
    Friend WithEvents CategoryDS As DoorsPOS.WinApp.categoryDS
    Friend WithEvents CategoriesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents categoriesTableAdapter1 As DoorsPOS.WinApp.categoryDSTableAdapters.categoriesTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsBrand As DoorsPOS.WinApp.dsBrand
    Friend WithEvents DeptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents deptTableAdapter As DoorsPOS.WinApp.dsBrandTableAdapters.deptTableAdapter
    Friend WithEvents Wholesale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpackaging As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsLastUpdate_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtLastUpdate_dt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvat1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents colincentive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colincentive1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
