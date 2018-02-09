<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoGrd2
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.VwBOBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsBO = New DoorsPOS.WinApp.dsBO()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colbodate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwBOTableAdapter = New DoorsPOS.WinApp.dsBOTableAdapters.vwBOTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwBOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwBOBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(858, 498)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwBOBindingSource
        '
        Me.VwBOBindingSource.DataMember = "vwBO"
        Me.VwBOBindingSource.DataSource = Me.DsBO
        '
        'DsBO
        '
        Me.DsBO.DataSetName = "dsBO"
        Me.DsBO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbodate, Me.colqty, Me.colitem_desc, Me.colsupplier, Me.colsInsert_id})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colqty, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colbodate
        '
        Me.colbodate.Caption = "Date Returned"
        Me.colbodate.FieldName = "bodate"
        Me.colbodate.Name = "colbodate"
        Me.colbodate.Visible = True
        Me.colbodate.VisibleIndex = 0
        Me.colbodate.Width = 128
        '
        'colqty
        '
        Me.colqty.AppearanceHeader.Options.UseTextOptions = True
        Me.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colqty.Caption = "Qty Returned"
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 1
        Me.colqty.Width = 125
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 3
        Me.colitem_desc.Width = 333
        '
        'colsupplier
        '
        Me.colsupplier.Caption = "Supplier"
        Me.colsupplier.FieldName = "supplier"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.Visible = True
        Me.colsupplier.VisibleIndex = 4
        Me.colsupplier.Width = 340
        '
        'colsInsert_id
        '
        Me.colsInsert_id.AppearanceCell.Options.UseTextOptions = True
        Me.colsInsert_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colsInsert_id.AppearanceHeader.Options.UseTextOptions = True
        Me.colsInsert_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colsInsert_id.Caption = "Encoder"
        Me.colsInsert_id.FieldName = "sInsert_id"
        Me.colsInsert_id.Name = "colsInsert_id"
        Me.colsInsert_id.Visible = True
        Me.colsInsert_id.VisibleIndex = 2
        Me.colsInsert_id.Width = 140
        '
        'VwBOTableAdapter
        '
        Me.VwBOTableAdapter.ClearBeforeFill = True
        '
        'frmBoGrd2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 498)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmBoGrd2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BO Grid View2"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwBOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsBO As DoorsPOS.WinApp.dsBO
    Friend WithEvents VwBOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwBOTableAdapter As DoorsPOS.WinApp.dsBOTableAdapters.vwBOTableAdapter
    Friend WithEvents colbodate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
End Class
