<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpired
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
        Me.SpExpirationDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspExpiration = New DoorsPOS.WinApp.dsspExpiration()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldrdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldrinv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstckid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collotno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colitem_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.spExpirationDateTableAdapter = New DoorsPOS.WinApp.dsspExpirationTableAdapters.spExpirationDateTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpExpirationDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspExpiration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.SpExpirationDateBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.gridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(805, 428)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'SpExpirationDateBindingSource
        '
        Me.SpExpirationDateBindingSource.DataMember = "spExpirationDate"
        Me.SpExpirationDateBindingSource.DataSource = Me.DsspExpiration
        '
        'DsspExpiration
        '
        Me.DsspExpiration.DataSetName = "dsspExpiration"
        Me.DsspExpiration.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gridView1
        '
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldrdate, Me.coldrinv, Me.colsupplier, Me.colstckid, Me.colqty, Me.collotno, Me.colexpdate, Me.colitem_desc})
        Me.gridView1.GridControl = Me.GridControl1
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsView.ShowAutoFilterRow = True
        Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colqty, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'coldrdate
        '
        Me.coldrdate.Caption = "Date Delivered"
        Me.coldrdate.FieldName = "drdate"
        Me.coldrdate.Name = "coldrdate"
        Me.coldrdate.Visible = True
        Me.coldrdate.VisibleIndex = 2
        '
        'coldrinv
        '
        Me.coldrinv.Caption = "Invoice Number"
        Me.coldrinv.FieldName = "drinv"
        Me.coldrinv.Name = "coldrinv"
        Me.coldrinv.Visible = True
        Me.coldrinv.VisibleIndex = 3
        '
        'colsupplier
        '
        Me.colsupplier.Caption = "Supplier"
        Me.colsupplier.FieldName = "supplier"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.Visible = True
        Me.colsupplier.VisibleIndex = 4
        '
        'colstckid
        '
        Me.colstckid.FieldName = "stckid"
        Me.colstckid.Name = "colstckid"
        '
        'colqty
        '
        Me.colqty.Caption = "Qty Delivered"
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        '
        'collotno
        '
        Me.collotno.Caption = "Lot No."
        Me.collotno.FieldName = "lotno"
        Me.collotno.Name = "collotno"
        Me.collotno.Visible = True
        Me.collotno.VisibleIndex = 5
        '
        'colexpdate
        '
        Me.colexpdate.Caption = "Expiration Date"
        Me.colexpdate.FieldName = "expdate"
        Me.colexpdate.Name = "colexpdate"
        Me.colexpdate.Visible = True
        Me.colexpdate.VisibleIndex = 0
        '
        'colitem_desc
        '
        Me.colitem_desc.Caption = "Item Description"
        Me.colitem_desc.FieldName = "item_desc"
        Me.colitem_desc.Name = "colitem_desc"
        Me.colitem_desc.Visible = True
        Me.colitem_desc.VisibleIndex = 1
        '
        'spExpirationDateTableAdapter
        '
        Me.spExpirationDateTableAdapter.ClearBeforeFill = True
        '
        'frmExpired
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 428)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmExpired"
        Me.Text = "Expired"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpExpirationDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspExpiration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldrdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldrinv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstckid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collotno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsspExpiration As DoorsPOS.WinApp.dsspExpiration
    Friend WithEvents SpExpirationDateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents spExpirationDateTableAdapter As DoorsPOS.WinApp.dsspExpirationTableAdapters.spExpirationDateTableAdapter
End Class
