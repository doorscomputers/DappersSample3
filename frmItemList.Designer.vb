<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemList
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
        Me.components = New System.ComponentModel.Container()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.VwItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsvwItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsvwItems = New DoorsPOS.WinApp.dsvwItems()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colbarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colavailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcatgory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPTD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsayz = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colretail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colretail2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastwholesale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmaximum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colminimum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastdlvry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwItemsTableAdapter = New DoorsPOS.WinApp.dsvwItemsTableAdapters.vwItemsTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsvwItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsvwItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwItemsBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1240, 599)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwItemsBindingSource
        '
        Me.VwItemsBindingSource.DataMember = "vwItems"
        Me.VwItemsBindingSource.DataSource = Me.DsvwItemsBindingSource
        '
        'DsvwItemsBindingSource
        '
        Me.DsvwItemsBindingSource.DataSource = Me.DsvwItems
        Me.DsvwItemsBindingSource.Position = 0
        '
        'DsvwItems
        '
        Me.DsvwItems.DataSetName = "dsvwItems"
        Me.DsvwItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbarcode, Me.colitem_desc, Me.colavailable, Me.colsupplier, Me.colcatgory, Me.colDEPTD, Me.colsayz, Me.colcost, Me.colretail, Me.colretail2, Me.collastprice, Me.collastcost, Me.collastwholesale, Me.colmaximum, Me.colminimum, Me.collastdlvry})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.collastdlvry, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colbarcode
        '
        Me.colbarcode.Caption = "Item Code"
        Me.colbarcode.FieldName = "barcode"
        Me.colbarcode.Name = "colbarcode"
        Me.colbarcode.Visible = True
        Me.colbarcode.VisibleIndex = 0
        Me.colbarcode.Width = 63
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 1
        Me.colitem_desc.Width = 192
        '
        'colavailable
        '
        Me.colavailable.Caption = "Available"
        Me.colavailable.FieldName = "available"
        Me.colavailable.Name = "colavailable"
        Me.colavailable.Visible = True
        Me.colavailable.VisibleIndex = 2
        Me.colavailable.Width = 52
        '
        'colsupplier
        '
        Me.colsupplier.Caption = "Supplier"
        Me.colsupplier.FieldName = "supplier"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.Visible = True
        Me.colsupplier.VisibleIndex = 3
        Me.colsupplier.Width = 104
        '
        'colcatgory
        '
        Me.colcatgory.Caption = "Category"
        Me.colcatgory.FieldName = "catgory"
        Me.colcatgory.Name = "colcatgory"
        Me.colcatgory.Visible = True
        Me.colcatgory.VisibleIndex = 4
        Me.colcatgory.Width = 94
        '
        'colDEPTD
        '
        Me.colDEPTD.Caption = "Brand"
        Me.colDEPTD.FieldName = "DEPTD"
        Me.colDEPTD.Name = "colDEPTD"
        Me.colDEPTD.Visible = True
        Me.colDEPTD.VisibleIndex = 5
        Me.colDEPTD.Width = 70
        '
        'colsayz
        '
        Me.colsayz.Caption = "Type"
        Me.colsayz.FieldName = "sayz"
        Me.colsayz.Name = "colsayz"
        Me.colsayz.Visible = True
        Me.colsayz.VisibleIndex = 6
        Me.colsayz.Width = 65
        '
        'colcost
        '
        Me.colcost.Caption = "Cost"
        Me.colcost.DisplayFormat.FormatString = "N2"
        Me.colcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcost.FieldName = "cost"
        Me.colcost.Name = "colcost"
        Me.colcost.Visible = True
        Me.colcost.VisibleIndex = 7
        Me.colcost.Width = 51
        '
        'colretail
        '
        Me.colretail.Caption = "Retail"
        Me.colretail.DisplayFormat.FormatString = "N2"
        Me.colretail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colretail.FieldName = "retail"
        Me.colretail.Name = "colretail"
        Me.colretail.Visible = True
        Me.colretail.VisibleIndex = 8
        Me.colretail.Width = 40
        '
        'colretail2
        '
        Me.colretail2.Caption = "Wholesale"
        Me.colretail2.DisplayFormat.FormatString = "N2"
        Me.colretail2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colretail2.FieldName = "retail2"
        Me.colretail2.Name = "colretail2"
        Me.colretail2.Visible = True
        Me.colretail2.VisibleIndex = 9
        Me.colretail2.Width = 56
        '
        'collastprice
        '
        Me.collastprice.Caption = "Last Price"
        Me.collastprice.DisplayFormat.FormatString = "N2"
        Me.collastprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collastprice.FieldName = "lastprice"
        Me.collastprice.Name = "collastprice"
        Me.collastprice.Visible = True
        Me.collastprice.VisibleIndex = 10
        Me.collastprice.Width = 58
        '
        'collastcost
        '
        Me.collastcost.Caption = "Last Cost"
        Me.collastcost.DisplayFormat.FormatString = "N2"
        Me.collastcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collastcost.FieldName = "lastcost"
        Me.collastcost.Name = "collastcost"
        Me.collastcost.Visible = True
        Me.collastcost.VisibleIndex = 11
        Me.collastcost.Width = 60
        '
        'collastwholesale
        '
        Me.collastwholesale.Caption = "Wholesale"
        Me.collastwholesale.DisplayFormat.FormatString = "N2"
        Me.collastwholesale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collastwholesale.FieldName = "lastwholesale"
        Me.collastwholesale.Name = "collastwholesale"
        Me.collastwholesale.Visible = True
        Me.collastwholesale.VisibleIndex = 12
        Me.collastwholesale.Width = 62
        '
        'colmaximum
        '
        Me.colmaximum.Caption = "Max"
        Me.colmaximum.DisplayFormat.FormatString = "N0"
        Me.colmaximum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colmaximum.FieldName = "maximum"
        Me.colmaximum.Name = "colmaximum"
        Me.colmaximum.Visible = True
        Me.colmaximum.VisibleIndex = 14
        Me.colmaximum.Width = 29
        '
        'colminimum
        '
        Me.colminimum.Caption = "Min"
        Me.colminimum.DisplayFormat.FormatString = "N0"
        Me.colminimum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colminimum.FieldName = "minimum"
        Me.colminimum.Name = "colminimum"
        Me.colminimum.Visible = True
        Me.colminimum.VisibleIndex = 13
        Me.colminimum.Width = 27
        '
        'collastdlvry
        '
        Me.collastdlvry.Caption = "LastDlvry"
        Me.collastdlvry.DisplayFormat.FormatString = "d"
        Me.collastdlvry.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.collastdlvry.FieldName = "lastdlvry"
        Me.collastdlvry.Name = "collastdlvry"
        Me.collastdlvry.Visible = True
        Me.collastdlvry.VisibleIndex = 15
        Me.collastdlvry.Width = 43
        '
        'VwItemsTableAdapter
        '
        Me.VwItemsTableAdapter.ClearBeforeFill = True
        '
        'frmItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 599)
        Me.Controls.Add(Me.GridControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItemList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item List"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsvwItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsvwItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsvwItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsvwItems As DoorsPOS.WinApp.dsvwItems
    Friend WithEvents VwItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwItemsTableAdapter As DoorsPOS.WinApp.dsvwItemsTableAdapters.vwItemsTableAdapter
    Friend WithEvents colbarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colavailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcatgory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPTD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsayz As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colretail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colretail2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastwholesale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmaximum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colminimum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastdlvry As DevExpress.XtraGrid.Columns.GridColumn
End Class
