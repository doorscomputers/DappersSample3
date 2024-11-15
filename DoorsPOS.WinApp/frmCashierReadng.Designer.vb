<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashierReadng
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
        Me.DsvwReading = New DoorsPOS.WinApp.dsvwReading()
        Me.VwReadingBindingSource = New System.Windows.Forms.BindingSource()
        Me.VwReadingTableAdapter = New DoorsPOS.WinApp.dsvwReadingTableAdapters.vwReadingTableAdapter()
        Me.fieldbegincash = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldcashier = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fielddatereading = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldaddcash = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldonek = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldfh = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldth = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldoh = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldffty = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldtwnty = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldtp = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldfve = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldpeso = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldbinting = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldpayments = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldtotalcheque = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldtotalsales = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldpickup = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldtotalcredit = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldovershort = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsvwReading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwReadingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.VwReadingBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fielddatereading, Me.fieldcashier, Me.fieldbegincash, Me.PivotGridField1, Me.fieldaddcash, Me.fieldpayments, Me.fieldonek, Me.fieldfh, Me.fieldth, Me.fieldoh, Me.fieldffty, Me.fieldtwnty, Me.fieldtp, Me.fieldfve, Me.fieldpeso, Me.fieldbinting, Me.fieldtotalcheque, Me.fieldtotalsales, Me.fieldpickup, Me.fieldtotalcredit, Me.fieldovershort})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(963, 522)
        Me.PivotGridControl1.TabIndex = 0
        '
        'DsvwReading
        '
        Me.DsvwReading.DataSetName = "dsvwReading"
        Me.DsvwReading.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwReadingBindingSource
        '
        Me.VwReadingBindingSource.DataMember = "vwReading"
        Me.VwReadingBindingSource.DataSource = Me.DsvwReading
        '
        'VwReadingTableAdapter
        '
        Me.VwReadingTableAdapter.ClearBeforeFill = True
        '
        'fieldbegincash
        '
        Me.fieldbegincash.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldbegincash.AreaIndex = 0
        Me.fieldbegincash.Caption = "Beg. Cash"
        Me.fieldbegincash.CellFormat.FormatString = "N2"
        Me.fieldbegincash.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldbegincash.FieldName = "begincash"
        Me.fieldbegincash.Name = "fieldbegincash"
        Me.fieldbegincash.Width = 75
        '
        'fieldcashier
        '
        Me.fieldcashier.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldcashier.AreaIndex = 0
        Me.fieldcashier.Caption = "Cashier"
        Me.fieldcashier.FieldName = "cashier"
        Me.fieldcashier.Name = "fieldcashier"
        '
        'fielddatereading
        '
        Me.fielddatereading.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fielddatereading.AreaIndex = 1
        Me.fielddatereading.Caption = "Date"
        Me.fielddatereading.CellFormat.FormatString = "d"
        Me.fielddatereading.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fielddatereading.FieldName = "datereading"
        Me.fielddatereading.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.[Date]
        Me.fielddatereading.Name = "fielddatereading"
        Me.fielddatereading.UnboundFieldName = "fielddatereading"
        Me.fielddatereading.Width = 89
        '
        'fieldaddcash
        '
        Me.fieldaddcash.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldaddcash.AreaIndex = 1
        Me.fieldaddcash.Caption = "Additional Cash"
        Me.fieldaddcash.CellFormat.FormatString = "N2"
        Me.fieldaddcash.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldaddcash.FieldName = "addcash"
        Me.fieldaddcash.Name = "fieldaddcash"
        Me.fieldaddcash.Width = 84
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField1.AreaIndex = 2
        Me.PivotGridField1.Caption = "Cash Count"
        Me.PivotGridField1.CellFormat.FormatString = "N2"
        Me.PivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField1.Name = "PivotGridField1"
        Me.PivotGridField1.UnboundExpression = "[onek] + [fh]+[th]+[oh]+[ffty]+[twnty]+[tp]+[fve]+[peso]+[binting]"
        Me.PivotGridField1.UnboundFieldName = "CashCnt"
        Me.PivotGridField1.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.PivotGridField1.Width = 99
        '
        'fieldonek
        '
        Me.fieldonek.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldonek.AreaIndex = 5
        Me.fieldonek.FieldName = "onek"
        Me.fieldonek.Name = "fieldonek"
        Me.fieldonek.Visible = False
        '
        'fieldfh
        '
        Me.fieldfh.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldfh.AreaIndex = 5
        Me.fieldfh.FieldName = "fh"
        Me.fieldfh.Name = "fieldfh"
        Me.fieldfh.Visible = False
        '
        'fieldth
        '
        Me.fieldth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldth.AreaIndex = 5
        Me.fieldth.FieldName = "th"
        Me.fieldth.Name = "fieldth"
        Me.fieldth.Visible = False
        '
        'fieldoh
        '
        Me.fieldoh.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldoh.AreaIndex = 5
        Me.fieldoh.FieldName = "oh"
        Me.fieldoh.Name = "fieldoh"
        Me.fieldoh.Visible = False
        '
        'fieldffty
        '
        Me.fieldffty.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldffty.AreaIndex = 5
        Me.fieldffty.FieldName = "ffty"
        Me.fieldffty.Name = "fieldffty"
        Me.fieldffty.Visible = False
        '
        'fieldtwnty
        '
        Me.fieldtwnty.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldtwnty.AreaIndex = 5
        Me.fieldtwnty.FieldName = "twnty"
        Me.fieldtwnty.Name = "fieldtwnty"
        Me.fieldtwnty.Visible = False
        '
        'fieldtp
        '
        Me.fieldtp.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldtp.AreaIndex = 5
        Me.fieldtp.FieldName = "tp"
        Me.fieldtp.Name = "fieldtp"
        Me.fieldtp.Visible = False
        '
        'fieldfve
        '
        Me.fieldfve.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldfve.AreaIndex = 5
        Me.fieldfve.FieldName = "fve"
        Me.fieldfve.Name = "fieldfve"
        Me.fieldfve.Visible = False
        '
        'fieldpeso
        '
        Me.fieldpeso.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldpeso.AreaIndex = 5
        Me.fieldpeso.FieldName = "peso"
        Me.fieldpeso.Name = "fieldpeso"
        Me.fieldpeso.Visible = False
        '
        'fieldbinting
        '
        Me.fieldbinting.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldbinting.AreaIndex = 5
        Me.fieldbinting.FieldName = "binting"
        Me.fieldbinting.Name = "fieldbinting"
        Me.fieldbinting.Visible = False
        '
        'fieldpayments
        '
        Me.fieldpayments.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldpayments.AreaIndex = 3
        Me.fieldpayments.Caption = "Payments"
        Me.fieldpayments.CellFormat.FormatString = "N2"
        Me.fieldpayments.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldpayments.FieldName = "payments"
        Me.fieldpayments.Name = "fieldpayments"
        Me.fieldpayments.Width = 69
        '
        'fieldtotalcheque
        '
        Me.fieldtotalcheque.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldtotalcheque.AreaIndex = 4
        Me.fieldtotalcheque.Caption = "Total Cheques"
        Me.fieldtotalcheque.CellFormat.FormatString = "N2"
        Me.fieldtotalcheque.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldtotalcheque.FieldName = "totalcheque"
        Me.fieldtotalcheque.Name = "fieldtotalcheque"
        '
        'fieldtotalsales
        '
        Me.fieldtotalsales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldtotalsales.AreaIndex = 5
        Me.fieldtotalsales.Caption = "Total Sales"
        Me.fieldtotalsales.CellFormat.FormatString = "N2"
        Me.fieldtotalsales.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldtotalsales.FieldName = "totalsales"
        Me.fieldtotalsales.Name = "fieldtotalsales"
        Me.fieldtotalsales.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldpickup
        '
        Me.fieldpickup.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldpickup.AreaIndex = 6
        Me.fieldpickup.Caption = "Total Pickup"
        Me.fieldpickup.CellFormat.FormatString = "N2"
        Me.fieldpickup.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldpickup.FieldName = "pickup"
        Me.fieldpickup.Name = "fieldpickup"
        Me.fieldpickup.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldpickup.Width = 79
        '
        'fieldtotalcredit
        '
        Me.fieldtotalcredit.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldtotalcredit.AreaIndex = 7
        Me.fieldtotalcredit.Caption = "Total Credit"
        Me.fieldtotalcredit.CellFormat.FormatString = "N2"
        Me.fieldtotalcredit.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldtotalcredit.FieldName = "totalcredit"
        Me.fieldtotalcredit.Name = "fieldtotalcredit"
        Me.fieldtotalcredit.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldtotalcredit.Width = 81
        '
        'fieldovershort
        '
        Me.fieldovershort.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldovershort.AreaIndex = 8
        Me.fieldovershort.Caption = "Over/Short Total"
        Me.fieldovershort.CellFormat.FormatString = "N2"
        Me.fieldovershort.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldovershort.FieldName = "overshort"
        Me.fieldovershort.Name = "fieldovershort"
        '
        'frmCashierReadng
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 522)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmCashierReadng"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cashier Readng "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsvwReading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwReadingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DsvwReading As DoorsPOS.WinApp.dsvwReading
    Friend WithEvents VwReadingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwReadingTableAdapter As DoorsPOS.WinApp.dsvwReadingTableAdapters.vwReadingTableAdapter
    Friend WithEvents fielddatereading As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldcashier As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldbegincash As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldaddcash As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldpayments As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldonek As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldfh As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldth As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldoh As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldffty As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldtwnty As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldtp As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldfve As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldpeso As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldbinting As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldtotalcheque As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldtotalsales As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldpickup As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldtotalcredit As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldovershort As DevExpress.XtraPivotGrid.PivotGridField
End Class
