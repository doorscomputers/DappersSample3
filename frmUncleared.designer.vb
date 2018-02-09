<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUncleared
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
        Me.DlvryhdrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPDC = New DoorsPOS.WinApp.dsPDC()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldrdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldrinv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldrdue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldrbal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldrpsted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dlvry_hdrTableAdapter = New DoorsPOS.WinApp.dsPDCTableAdapters.dlvry_hdrTableAdapter()
        Me.colsupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DlvryhdrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPDC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.DlvryhdrBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.gridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(953, 469)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'DlvryhdrBindingSource
        '
        Me.DlvryhdrBindingSource.DataMember = "dlvry_hdr"
        Me.DlvryhdrBindingSource.DataSource = Me.DsPDC
        '
        'DsPDC
        '
        Me.DsPDC.DataSetName = "dsPDC"
        Me.DsPDC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gridView1
        '
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldrid, Me.coldrdate, Me.coldrinv, Me.colsupplier, Me.colterms, Me.coldrdue, Me.coldrbal, Me.colpaid, Me.coldrpsted})
        Me.gridView1.GridControl = Me.GridControl1
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsView.ShowFooter = True
        '
        'coldrid
        '
        Me.coldrid.FieldName = "drid"
        Me.coldrid.Name = "coldrid"
        Me.coldrid.OptionsColumn.ReadOnly = True
        '
        'coldrdate
        '
        Me.coldrdate.Caption = "Invoice Date"
        Me.coldrdate.FieldName = "drdate"
        Me.coldrdate.Name = "coldrdate"
        Me.coldrdate.Visible = True
        Me.coldrdate.VisibleIndex = 0
        '
        'coldrinv
        '
        Me.coldrinv.Caption = "Inv No."
        Me.coldrinv.FieldName = "drinv"
        Me.coldrinv.Name = "coldrinv"
        Me.coldrinv.Visible = True
        Me.coldrinv.VisibleIndex = 1
        '
        'colterms
        '
        Me.colterms.Caption = "Term"
        Me.colterms.FieldName = "terms"
        Me.colterms.Name = "colterms"
        Me.colterms.Visible = True
        Me.colterms.VisibleIndex = 2
        '
        'coldrdue
        '
        Me.coldrdue.Caption = "Due Date"
        Me.coldrdue.FieldName = "drdue"
        Me.coldrdue.Name = "coldrdue"
        Me.coldrdue.Visible = True
        Me.coldrdue.VisibleIndex = 3
        '
        'coldrbal
        '
        Me.coldrbal.Caption = "Balance"
        Me.coldrbal.DisplayFormat.FormatString = "N2"
        Me.coldrbal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coldrbal.FieldName = "drbal"
        Me.coldrbal.Name = "coldrbal"
        Me.coldrbal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "drbal", "SUM={0:N2}")})
        Me.coldrbal.Visible = True
        Me.coldrbal.VisibleIndex = 4
        '
        'colpaid
        '
        Me.colpaid.FieldName = "paid"
        Me.colpaid.Name = "colpaid"
        '
        'coldrpsted
        '
        Me.coldrpsted.Caption = "Cleared"
        Me.coldrpsted.FieldName = "drpsted"
        Me.coldrpsted.Name = "coldrpsted"
        Me.coldrpsted.Visible = True
        Me.coldrpsted.VisibleIndex = 5
        '
        'dlvry_hdrTableAdapter
        '
        Me.dlvry_hdrTableAdapter.ClearBeforeFill = True
        '
        'colsupplier
        '
        Me.colsupplier.Caption = "Supplier"
        Me.colsupplier.FieldName = "supplier"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.Visible = True
        Me.colsupplier.VisibleIndex = 6
        '
        'frmUncleared
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 469)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmUncleared"
        Me.Text = "Not Cleared PDC"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DlvryhdrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPDC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsPDC As DoorsPOS.WinApp.dsPDC
    Friend WithEvents DlvryhdrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dlvry_hdrTableAdapter As DoorsPOS.WinApp.dsPDCTableAdapters.dlvry_hdrTableAdapter
    Friend WithEvents coldrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldrdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldrinv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldrdue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldrbal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldrpsted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupplier As DevExpress.XtraGrid.Columns.GridColumn
End Class
