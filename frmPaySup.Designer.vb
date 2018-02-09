<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaySup
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
        Me.VwInvPaymentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsinvpayvw = New DoorsPOS.WinApp.dsinvpayvw()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colpayid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpaydate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colamnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colchqno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldrinv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwInvPaymentsTableAdapter1 = New DoorsPOS.WinApp.dsinvpayvwTableAdapters.vwInvPaymentsTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwInvPaymentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsinvpayvw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwInvPaymentsBindingSource1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(993, 483)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwInvPaymentsBindingSource1
        '
        Me.VwInvPaymentsBindingSource1.DataMember = "vwInvPayments"
        Me.VwInvPaymentsBindingSource1.DataSource = Me.Dsinvpayvw
        '
        'Dsinvpayvw
        '
        Me.Dsinvpayvw.DataSetName = "dsinvpayvw"
        Me.Dsinvpayvw.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colpayid, Me.colpaydate, Me.colamnt, Me.colsupplier, Me.colchqno, Me.colbank, Me.coldrinv})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colsupplier, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colchqno, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colpayid
        '
        Me.colpayid.FieldName = "payid"
        Me.colpayid.Name = "colpayid"
        '
        'colpaydate
        '
        Me.colpaydate.Caption = "Date"
        Me.colpaydate.FieldName = "paydate"
        Me.colpaydate.Name = "colpaydate"
        Me.colpaydate.Visible = True
        Me.colpaydate.VisibleIndex = 0
        '
        'colamnt
        '
        Me.colamnt.AppearanceHeader.Options.UseTextOptions = True
        Me.colamnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colamnt.Caption = "Amount Paid"
        Me.colamnt.DisplayFormat.FormatString = "N2"
        Me.colamnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colamnt.FieldName = "amnt"
        Me.colamnt.Name = "colamnt"
        Me.colamnt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amnt", "SUM={0:N2}")})
        Me.colamnt.Visible = True
        Me.colamnt.VisibleIndex = 4
        '
        'colsupplier
        '
        Me.colsupplier.Caption = "Supplier"
        Me.colsupplier.FieldName = "supplier"
        Me.colsupplier.Name = "colsupplier"
        Me.colsupplier.Visible = True
        Me.colsupplier.VisibleIndex = 0
        '
        'colchqno
        '
        Me.colchqno.AppearanceCell.Options.UseTextOptions = True
        Me.colchqno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colchqno.AppearanceHeader.Options.UseTextOptions = True
        Me.colchqno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colchqno.Caption = "Cheque No."
        Me.colchqno.FieldName = "chqno"
        Me.colchqno.Name = "colchqno"
        Me.colchqno.Visible = True
        Me.colchqno.VisibleIndex = 1
        '
        'colbank
        '
        Me.colbank.Caption = "Bank"
        Me.colbank.FieldName = "bank"
        Me.colbank.Name = "colbank"
        Me.colbank.Visible = True
        Me.colbank.VisibleIndex = 2
        '
        'coldrinv
        '
        Me.coldrinv.Caption = "Inv. No."
        Me.coldrinv.FieldName = "drinv"
        Me.coldrinv.Name = "coldrinv"
        Me.coldrinv.Visible = True
        Me.coldrinv.VisibleIndex = 3
        '
        'VwInvPaymentsTableAdapter1
        '
        Me.VwInvPaymentsTableAdapter1.ClearBeforeFill = True
        '
        'frmPaySup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 483)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmPaySup"
        Me.Text = "Payments to Suppliers"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwInvPaymentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsinvpayvw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colpayid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpaydate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colchqno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldrinv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Dsinvpayvw As DoorsPOS.WinApp.dsinvpayvw
    Friend WithEvents VwInvPaymentsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents VwInvPaymentsTableAdapter1 As DoorsPOS.WinApp.dsinvpayvwTableAdapters.vwInvPaymentsTableAdapter
    Friend WithEvents colamnt As DevExpress.XtraGrid.Columns.GridColumn
End Class
