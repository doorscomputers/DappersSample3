<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPdtoSuppliers
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
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.VwInvPaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsinvpayvw = New DoorsPOS.WinApp.dsinvpayvw()
        Me.fieldbank = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldchqno = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fielddrinv = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldpaydate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsupplier = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldpaydate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldpaydate2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldamnt = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.VwInvPaymentsTableAdapter = New DoorsPOS.WinApp.dsinvpayvwTableAdapters.vwInvPaymentsTableAdapter()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwInvPaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsinvpayvw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.VwInvPaymentsBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldbank, Me.fieldchqno, Me.fielddrinv, Me.fieldpaydate, Me.fieldsupplier, Me.fieldpaydate1, Me.fieldpaydate2, Me.fieldamnt})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(953, 478)
        Me.PivotGridControl1.TabIndex = 0
        '
        'VwInvPaymentsBindingSource
        '
        Me.VwInvPaymentsBindingSource.DataMember = "vwInvPayments"
        Me.VwInvPaymentsBindingSource.DataSource = Me.Dsinvpayvw
        '
        'Dsinvpayvw
        '
        Me.Dsinvpayvw.DataSetName = "dsinvpayvw"
        Me.Dsinvpayvw.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fieldbank
        '
        Me.fieldbank.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldbank.AreaIndex = 2
        Me.fieldbank.Caption = "Bank"
        Me.fieldbank.FieldName = "bank"
        Me.fieldbank.Name = "fieldbank"
        Me.fieldbank.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldbank.Width = 173
        '
        'fieldchqno
        '
        Me.fieldchqno.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldchqno.AreaIndex = 1
        Me.fieldchqno.Caption = "Cheque No."
        Me.fieldchqno.FieldName = "chqno"
        Me.fieldchqno.Name = "fieldchqno"
        Me.fieldchqno.Width = 152
        '
        'fielddrinv
        '
        Me.fielddrinv.AreaIndex = 1
        Me.fielddrinv.Caption = "Inv. No."
        Me.fielddrinv.FieldName = "drinv"
        Me.fielddrinv.Name = "fielddrinv"
        Me.fielddrinv.Width = 136
        '
        'fieldpaydate
        '
        Me.fieldpaydate.AreaIndex = 0
        Me.fieldpaydate.Caption = "Date Paid"
        Me.fieldpaydate.CellFormat.FormatString = "d"
        Me.fieldpaydate.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldpaydate.FieldName = "paydate"
        Me.fieldpaydate.Name = "fieldpaydate"
        Me.fieldpaydate.TotalCellFormat.FormatString = "d"
        Me.fieldpaydate.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldpaydate.TotalValueFormat.FormatString = "d"
        Me.fieldpaydate.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldpaydate.ValueFormat.FormatString = "d"
        Me.fieldpaydate.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldpaydate.Width = 115
        '
        'fieldsupplier
        '
        Me.fieldsupplier.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsupplier.AreaIndex = 0
        Me.fieldsupplier.Caption = "Supplier"
        Me.fieldsupplier.FieldName = "supplier"
        Me.fieldsupplier.Name = "fieldsupplier"
        Me.fieldsupplier.Width = 207
        '
        'fieldpaydate1
        '
        Me.fieldpaydate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldpaydate1.AreaIndex = 0
        Me.fieldpaydate1.Caption = "Date Year"
        Me.fieldpaydate1.FieldName = "paydate"
        Me.fieldpaydate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
        Me.fieldpaydate1.Name = "fieldpaydate1"
        Me.fieldpaydate1.UnboundFieldName = "fieldpaydate1"
        '
        'fieldpaydate2
        '
        Me.fieldpaydate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldpaydate2.AreaIndex = 1
        Me.fieldpaydate2.Caption = "Date Month"
        Me.fieldpaydate2.FieldName = "paydate"
        Me.fieldpaydate2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
        Me.fieldpaydate2.Name = "fieldpaydate2"
        Me.fieldpaydate2.UnboundFieldName = "fieldpaydate2"
        '
        'fieldamnt
        '
        Me.fieldamnt.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldamnt.AreaIndex = 0
        Me.fieldamnt.Caption = "Amount Paid"
        Me.fieldamnt.CellFormat.FormatString = "N2"
        Me.fieldamnt.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldamnt.FieldName = "amnt"
        Me.fieldamnt.Name = "fieldamnt"
        '
        'VwInvPaymentsTableAdapter
        '
        Me.VwInvPaymentsTableAdapter.ClearBeforeFill = True
        '
        'frmPdtoSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 478)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmPdtoSuppliers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payments to Suppliers View2"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwInvPaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsinvpayvw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents Dsinvpayvw As DoorsPOS.WinApp.dsinvpayvw
    Friend WithEvents VwInvPaymentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwInvPaymentsTableAdapter As DoorsPOS.WinApp.dsinvpayvwTableAdapters.vwInvPaymentsTableAdapter
    Friend WithEvents fieldbank As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldchqno As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddrinv As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldpaydate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsupplier As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldpaydate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldpaydate2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldamnt As DevExpress.XtraPivotGrid.PivotGridField
End Class
