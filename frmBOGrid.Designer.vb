<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBOGrid
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
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.VwBOBindingSource = New System.Windows.Forms.BindingSource()
        Me.DsBO = New DoorsPOS.WinApp.dsBO()
        Me.fieldbodate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldqty1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fielditemdesc1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsupplier1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.VwBOTableAdapter = New DoorsPOS.WinApp.dsBOTableAdapters.vwBOTableAdapter()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwBOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.VwBOBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldbodate1, Me.fieldqty1, Me.fielditemdesc1, Me.fieldsupplier1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(779, 510)
        Me.PivotGridControl1.TabIndex = 0
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
        'fieldbodate1
        '
        Me.fieldbodate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldbodate1.AreaIndex = 0
        Me.fieldbodate1.Caption = "BO Date"
        Me.fieldbodate1.FieldName = "bodate"
        Me.fieldbodate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.[Date]
        Me.fieldbodate1.Name = "fieldbodate1"
        Me.fieldbodate1.UnboundFieldName = "fieldbodate1"
        Me.fieldbodate1.Width = 164
        '
        'fieldqty1
        '
        Me.fieldqty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldqty1.AreaIndex = 0
        Me.fieldqty1.Caption = "Qty"
        Me.fieldqty1.FieldName = "qty"
        Me.fieldqty1.Name = "fieldqty1"
        '
        'fielditemdesc1
        '
        Me.fielditemdesc1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fielditemdesc1.AreaIndex = 0
        Me.fielditemdesc1.Caption = "Item Description"
        Me.fielditemdesc1.FieldName = "item_desc"
        Me.fielditemdesc1.Name = "fielditemdesc1"
        Me.fielditemdesc1.Width = 170
        '
        'fieldsupplier1
        '
        Me.fieldsupplier1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsupplier1.AreaIndex = 1
        Me.fieldsupplier1.Caption = "Supplier"
        Me.fieldsupplier1.FieldName = "supplier"
        Me.fieldsupplier1.Name = "fieldsupplier1"
        Me.fieldsupplier1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'VwBOTableAdapter
        '
        Me.VwBOTableAdapter.ClearBeforeFill = True
        '
        'frmBOGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 510)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmBOGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BO "
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwBOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DsBO As DoorsPOS.WinApp.dsBO
    Friend WithEvents VwBOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwBOTableAdapter As DoorsPOS.WinApp.dsBOTableAdapters.vwBOTableAdapter
    Friend WithEvents fieldbodate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldqty1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielditemdesc1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsupplier1 As DevExpress.XtraPivotGrid.PivotGridField
End Class
