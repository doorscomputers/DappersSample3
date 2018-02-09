<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChkPaymntGrid
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
        Me.ChkpayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsChkPay = New DoorsPOS.WinApp.dsChkPay()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldtInsert_dt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpayee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colamnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colchkno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colchkremark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcashier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChkpayTableAdapter = New DoorsPOS.WinApp.dsChkPayTableAdapters.chkpayTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkpayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsChkPay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.ChkpayBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(870, 512)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ChkpayBindingSource
        '
        Me.ChkpayBindingSource.DataMember = "chkpay"
        Me.ChkpayBindingSource.DataSource = Me.DsChkPay
        '
        'DsChkPay
        '
        Me.DsChkPay.DataSetName = "dsChkPay"
        Me.DsChkPay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldtInsert_dt, Me.colpayee, Me.colamnt, Me.colchkno, Me.colbank, Me.colchkremark, Me.colcashier})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amnt", Me.colamnt, "SUM={0:N2}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'coldtInsert_dt
        '
        Me.coldtInsert_dt.Caption = "Date"
        Me.coldtInsert_dt.FieldName = "dtInsert_dt"
        Me.coldtInsert_dt.Name = "coldtInsert_dt"
        Me.coldtInsert_dt.Visible = True
        Me.coldtInsert_dt.VisibleIndex = 0
        Me.coldtInsert_dt.Width = 151
        '
        'colpayee
        '
        Me.colpayee.Caption = "Customer"
        Me.colpayee.FieldName = "payee"
        Me.colpayee.Name = "colpayee"
        Me.colpayee.Visible = True
        Me.colpayee.VisibleIndex = 1
        Me.colpayee.Width = 151
        '
        'colamnt
        '
        Me.colamnt.AppearanceHeader.Options.UseTextOptions = True
        Me.colamnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colamnt.Caption = "Chk Amount"
        Me.colamnt.DisplayFormat.FormatString = "N2"
        Me.colamnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colamnt.FieldName = "amnt"
        Me.colamnt.Name = "colamnt"
        Me.colamnt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amnt", "SUM={0:N2}")})
        Me.colamnt.Visible = True
        Me.colamnt.VisibleIndex = 2
        Me.colamnt.Width = 106
        '
        'colchkno
        '
        Me.colchkno.AppearanceCell.Options.UseTextOptions = True
        Me.colchkno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colchkno.AppearanceHeader.Options.UseTextOptions = True
        Me.colchkno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colchkno.Caption = "Chk No"
        Me.colchkno.FieldName = "chkno"
        Me.colchkno.Name = "colchkno"
        Me.colchkno.Visible = True
        Me.colchkno.VisibleIndex = 3
        Me.colchkno.Width = 162
        '
        'colbank
        '
        Me.colbank.Caption = "Bank"
        Me.colbank.FieldName = "bank"
        Me.colbank.Name = "colbank"
        Me.colbank.Visible = True
        Me.colbank.VisibleIndex = 4
        Me.colbank.Width = 162
        '
        'colchkremark
        '
        Me.colchkremark.Caption = "Remark"
        Me.colchkremark.FieldName = "chkremark"
        Me.colchkremark.Name = "colchkremark"
        Me.colchkremark.Visible = True
        Me.colchkremark.VisibleIndex = 5
        Me.colchkremark.Width = 121
        '
        'colcashier
        '
        Me.colcashier.Caption = "Cashier"
        Me.colcashier.FieldName = "cashier"
        Me.colcashier.Name = "colcashier"
        Me.colcashier.Visible = True
        Me.colcashier.VisibleIndex = 6
        '
        'ChkpayTableAdapter
        '
        Me.ChkpayTableAdapter.ClearBeforeFill = True
        '
        'frmChkPaymntGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 512)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmChkPaymntGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cheque Payments Grid View"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkpayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsChkPay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsChkPay As DoorsPOS.WinApp.dsChkPay
    Friend WithEvents ChkpayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChkpayTableAdapter As DoorsPOS.WinApp.dsChkPayTableAdapters.chkpayTableAdapter
    Friend WithEvents coldtInsert_dt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpayee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colchkno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colchkremark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcashier As DevExpress.XtraGrid.Columns.GridColumn
End Class
