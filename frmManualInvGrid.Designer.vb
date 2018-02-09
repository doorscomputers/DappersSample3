<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManualInvGrid
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
        Me.InvntoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsInitInv = New DoorsPOS.WinApp.dsInitInv()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colmidate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InvntoryTableAdapter = New DoorsPOS.WinApp.dsInitInvTableAdapters.InvntoryTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvntoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInitInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.InvntoryBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(882, 505)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'InvntoryBindingSource
        '
        Me.InvntoryBindingSource.DataMember = "Invntory"
        Me.InvntoryBindingSource.DataSource = Me.DsInitInv
        '
        'DsInitInv
        '
        Me.DsInitInv.DataSetName = "dsInitInv"
        Me.DsInitInv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colmidate, Me.colitem_desc, Me.colqty, Me.colsInsert_id})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colitem_desc, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colmidate, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colmidate
        '
        Me.colmidate.Caption = "Date Entered"
        Me.colmidate.FieldName = "midate"
        Me.colmidate.Name = "colmidate"
        Me.colmidate.Visible = True
        Me.colmidate.VisibleIndex = 0
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 3
        '
        'colqty
        '
        Me.colqty.AppearanceHeader.Options.UseTextOptions = True
        Me.colqty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colqty.Caption = "Qty"
        Me.colqty.DisplayFormat.FormatString = "N2"
        Me.colqty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 1
        '
        'colsInsert_id
        '
        Me.colsInsert_id.AppearanceCell.Options.UseTextOptions = True
        Me.colsInsert_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsInsert_id.AppearanceHeader.Options.UseTextOptions = True
        Me.colsInsert_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsInsert_id.Caption = "User Name"
        Me.colsInsert_id.FieldName = "sInsert_id"
        Me.colsInsert_id.Name = "colsInsert_id"
        Me.colsInsert_id.Visible = True
        Me.colsInsert_id.VisibleIndex = 2
        '
        'InvntoryTableAdapter
        '
        Me.InvntoryTableAdapter.ClearBeforeFill = True
        '
        'frmManualInvGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 505)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmManualInvGrid"
        Me.Text = "Inventory (Manual Count Transactions)"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvntoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInitInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsInitInv As DoorsPOS.WinApp.dsInitInv
    Friend WithEvents InvntoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvntoryTableAdapter As DoorsPOS.WinApp.dsInitInvTableAdapters.InvntoryTableAdapter
    Friend WithEvents colmidate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
End Class
