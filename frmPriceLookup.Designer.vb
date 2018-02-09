<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPriceLookup
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
        Me.colretail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colretail2 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridControl1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.LookAndFeel.SkinName = "Office 2013"
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(903, 479)
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
        Me.GridView1.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.GridView1.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView1.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.GridView1.Appearance.FilterPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FilterPanel.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Preview.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Preview.Options.UseFont = True
        Me.GridView1.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView1.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView1.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridView1.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbarcode, Me.colitem_desc, Me.colavailable, Me.colretail, Me.colretail2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colbarcode, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colbarcode
        '
        Me.colbarcode.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colbarcode.AppearanceCell.Options.UseFont = True
        Me.colbarcode.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colbarcode.AppearanceHeader.Options.UseFont = True
        Me.colbarcode.AppearanceHeader.Options.UseTextOptions = True
        Me.colbarcode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colbarcode.Caption = "Barcode"
        Me.colbarcode.FieldName = "barcode"
        Me.colbarcode.Name = "colbarcode"
        Me.colbarcode.OptionsColumn.ReadOnly = True
        Me.colbarcode.Visible = True
        Me.colbarcode.VisibleIndex = 0
        '
        'colitem_desc
        '
        Me.colitem_desc.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colitem_desc.AppearanceCell.Options.UseFont = True
        Me.colitem_desc.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colitem_desc.AppearanceHeader.Options.UseFont = True
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.OptionsColumn.ReadOnly = True
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 1
        '
        'colavailable
        '
        Me.colavailable.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colavailable.AppearanceCell.Options.UseFont = True
        Me.colavailable.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colavailable.AppearanceHeader.Options.UseFont = True
        Me.colavailable.Caption = "Available"
        Me.colavailable.FieldName = "available"
        Me.colavailable.Name = "colavailable"
        Me.colavailable.OptionsColumn.ReadOnly = True
        Me.colavailable.Visible = True
        Me.colavailable.VisibleIndex = 2
        '
        'colretail
        '
        Me.colretail.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colretail.AppearanceCell.Options.UseFont = True
        Me.colretail.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colretail.AppearanceHeader.Options.UseFont = True
        Me.colretail.AppearanceHeader.Options.UseTextOptions = True
        Me.colretail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colretail.Caption = "Retail"
        Me.colretail.DisplayFormat.FormatString = "N2"
        Me.colretail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colretail.FieldName = "retail"
        Me.colretail.Name = "colretail"
        Me.colretail.OptionsColumn.ReadOnly = True
        Me.colretail.Visible = True
        Me.colretail.VisibleIndex = 3
        '
        'colretail2
        '
        Me.colretail2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colretail2.AppearanceCell.Options.UseFont = True
        Me.colretail2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.colretail2.AppearanceHeader.Options.UseFont = True
        Me.colretail2.AppearanceHeader.Options.UseTextOptions = True
        Me.colretail2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colretail2.Caption = "Wholesale"
        Me.colretail2.DisplayFormat.FormatString = "N2"
        Me.colretail2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colretail2.FieldName = "retail2"
        Me.colretail2.Name = "colretail2"
        Me.colretail2.OptionsColumn.ReadOnly = True
        Me.colretail2.Visible = True
        Me.colretail2.VisibleIndex = 4
        '
        'VwItemsTableAdapter
        '
        Me.VwItemsTableAdapter.ClearBeforeFill = True
        '
        'frmPriceLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 479)
        Me.Controls.Add(Me.GridControl1)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "frmPriceLookup"
        Me.Text = "Price Lookup"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
    Friend WithEvents colretail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colretail2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
