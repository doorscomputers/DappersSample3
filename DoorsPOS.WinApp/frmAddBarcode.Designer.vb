<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBarcode
    Inherits System.Windows.Forms.Form

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
        Dim C1ViewRelation1 As C1.C1DataExtender.C1ViewRelation = New C1.C1DataExtender.C1ViewRelation()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim C1DataView1 As C1.C1DataExtender.C1DataView
        Dim C1ViewColumn5 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn6 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn7 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1DataView2 As C1.C1DataExtender.C1DataView
        Dim C1ViewColumn1 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn2 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn3 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn4 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Me.c1DataViewSet1 = New C1.C1DataExtender.C1DataViewSet()
        Me.DsStocksBarcode = New DoorsPOS.WinApp.dsStocksBarcode()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colstckid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CardView2 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.tblBarcodesTableAdapter1 = New DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.tblBarcodesTableAdapter()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        C1DataView1 = New C1.C1DataExtender.C1DataView()
        C1DataView2 = New C1.C1DataExtender.C1DataView()
        CType(Me.c1DataViewSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsStocksBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1DataViewSet1
        '
        Me.c1DataViewSet1.DataSet = Me.DsStocksBarcode
        Me.c1DataViewSet1.DiagramXML = ""
        C1ViewRelation1.ChildView = C1DataView2
        C1ViewRelation1.ParentView = C1DataView1
        Me.c1DataViewSet1.Relations.Add(C1ViewRelation1)
        Me.c1DataViewSet1.Views.Add(C1DataView1)
        Me.c1DataViewSet1.Views.Add(C1DataView2)
        '
        'DsStocksBarcode
        '
        Me.DsStocksBarcode.DataSetName = "dsStocksBarcode"
        Me.DsStocksBarcode.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataMember = "stocks"
        Me.GridControl1.DataSource = Me.DsStocksBarcode
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.GridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GridControl1.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin
        Me.GridControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GridLevelNode1.LevelTemplate = Me.CardView1
        GridLevelNode1.RelationName = "FK_tblBarcodes_stocks"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.gridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(918, 443)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.CardView1, Me.CardView2})
        '
        'gridView1
        '
        Me.gridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.gridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colstckid, Me.colbarcode, Me.colitem_desc})
        Me.gridView1.GridControl = Me.GridControl1
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colstckid
        '
        Me.colstckid.FieldName = "stckid"
        Me.colstckid.Name = "colstckid"
        Me.colstckid.OptionsColumn.ReadOnly = True
        '
        'colbarcode
        '
        Me.colbarcode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colbarcode.AppearanceCell.Options.UseFont = True
        Me.colbarcode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colbarcode.AppearanceHeader.Options.UseFont = True
        Me.colbarcode.Caption = "Original Barcode"
        Me.colbarcode.FieldName = "barcode"
        Me.colbarcode.Name = "colbarcode"
        Me.colbarcode.Visible = True
        Me.colbarcode.VisibleIndex = 1
        '
        'colitem_desc
        '
        Me.colitem_desc.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colitem_desc.AppearanceCell.Options.UseFont = True
        Me.colitem_desc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colitem_desc.AppearanceHeader.Options.UseFont = True
        Me.colitem_desc.Caption = "Items"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.OptionsColumn.AllowEdit = False
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 0
        '
        'CardView1
        '
        Me.CardView1.Appearance.Card.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardView1.Appearance.Card.Options.UseFont = True
        Me.CardView1.Appearance.CardCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardView1.Appearance.CardCaption.Options.UseFont = True
        Me.CardView1.Appearance.CardExpandButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardView1.Appearance.CardExpandButton.Options.UseFont = True
        Me.CardView1.Appearance.FieldCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardView1.Appearance.FieldCaption.Options.UseFont = True
        Me.CardView1.Appearance.FieldValue.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardView1.Appearance.FieldValue.Options.UseFont = True
        Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.CardView1.FocusedCardTopFieldIndex = 0
        Me.CardView1.GridControl = Me.GridControl1
        Me.CardView1.Name = "CardView1"
        Me.CardView1.OptionsView.ShowQuickCustomizeButton = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Barcode"
        Me.GridColumn1.FieldName = "barcode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Date Added"
        Me.GridColumn2.FieldName = "dateadded"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'C1DataView1
        '
        C1ViewColumn5.ColumnNameSerialized = "stckid"
        C1ViewColumn6.ColumnNameSerialized = "barcode"
        C1ViewColumn7.ColumnNameSerialized = "item_desc"
        C1DataView1.ColumnDefs.Add(C1ViewColumn5)
        C1DataView1.ColumnDefs.Add(C1ViewColumn6)
        C1DataView1.ColumnDefs.Add(C1ViewColumn7)
        C1DataView1.Definition = "SELECT * FROM [stocks]"
        C1DataView1.DefinitionDiagramXML = ""
        C1DataView1.Sort = "item_desc"
        C1DataView1.ViewName = "stocks"
        '
        'C1DataView2
        '
        C1ViewColumn1.ColumnNameSerialized = "bcodeid"
        C1ViewColumn2.ColumnNameSerialized = "barcode"
        C1ViewColumn3.ColumnNameSerialized = "stckid"
        C1ViewColumn4.ColumnNameSerialized = "dateadded"
        C1DataView2.ColumnDefs.Add(C1ViewColumn1)
        C1DataView2.ColumnDefs.Add(C1ViewColumn2)
        C1DataView2.ColumnDefs.Add(C1ViewColumn3)
        C1DataView2.ColumnDefs.Add(C1ViewColumn4)
        C1DataView2.Definition = "SELECT tblBarcodes.* FROM tblBarcodes"
        C1DataView2.DefinitionDiagramXML = "<C1Diagram><Nodes><Node DesigningObjectName=""tblBarcodes""><Location X=""10"" Y=""10""" & _
    " /><Size Width=""164"" Height=""124"" /></Node></Nodes></C1Diagram>"
        C1DataView2.ViewName = "tblBarcodes"
        '
        'CardView2
        '
        Me.CardView2.FocusedCardTopFieldIndex = 0
        Me.CardView2.GridControl = Me.GridControl1
        Me.CardView2.Name = "CardView2"
        '
        'tblBarcodesTableAdapter1
        '
        Me.tblBarcodesTableAdapter1.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Appearance.Options.UseForeColor = True
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSave.Location = New System.Drawing.Point(0, 420)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(918, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save Changes to the Database"
        '
        'frmAddBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 443)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmAddBarcode"
        Me.Text = "frmAddBarcode"
        CType(Me.c1DataViewSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsStocksBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents c1DataViewSet1 As C1.C1DataExtender.C1DataViewSet
    Friend WithEvents DsStocksBarcode As DoorsPOS.WinApp.dsStocksBarcode
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colstckid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CardView2 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents tblBarcodesTableAdapter1 As DoorsPOS.WinApp.dsStocksBarcodeTableAdapters.tblBarcodesTableAdapter
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
End Class
