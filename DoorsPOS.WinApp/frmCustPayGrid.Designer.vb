<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustPayGrid
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
        Me.VwCustPaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCustPay = New DoorsPOS.WinApp.dsCustPay()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPayDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCheckNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateIssued = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateDue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAccountNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBankName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOldBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewBal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfirstname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmiddlename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VwCustPaymentsTableAdapter = New DoorsPOS.WinApp.dsCustPayTableAdapters.vwCustPaymentsTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCustPaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCustPay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwCustPaymentsBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(861, 497)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwCustPaymentsBindingSource
        '
        Me.VwCustPaymentsBindingSource.DataMember = "vwCustPayments"
        Me.VwCustPaymentsBindingSource.DataSource = Me.DsCustPay
        '
        'DsCustPay
        '
        Me.DsCustPay.DataSetName = "dsCustPay"
        Me.DsCustPay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPayDate, Me.Customer, Me.colBalance, Me.colCheckNo, Me.colAccountName, Me.colDateIssued, Me.colDateDue, Me.colAccountNo, Me.colBankName, Me.colAmount, Me.colRemarks, Me.colOldBal, Me.colNewBal, Me.colfirstname, Me.collastname, Me.colmiddlename})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 2
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.Customer, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colBalance, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colPayDate
        '
        Me.colPayDate.Caption = "Date Paid"
        Me.colPayDate.FieldName = "PayDate"
        Me.colPayDate.Name = "colPayDate"
        Me.colPayDate.Visible = True
        Me.colPayDate.VisibleIndex = 0
        Me.colPayDate.Width = 87
        '
        'Customer
        '
        Me.Customer.Caption = "Customer"
        Me.Customer.FieldName = "Customer"
        Me.Customer.Name = "Customer"
        Me.Customer.UnboundExpression = "[lastname]+','+[firstname]+' '+[middlename]"
        Me.Customer.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.Customer.Visible = True
        Me.Customer.VisibleIndex = 1
        '
        'colBalance
        '
        Me.colBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colBalance.Caption = "Current Bal"
        Me.colBalance.DisplayFormat.FormatString = "N2"
        Me.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBalance.FieldName = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 4
        Me.colBalance.Width = 81
        '
        'colCheckNo
        '
        Me.colCheckNo.Caption = "Cheque No."
        Me.colCheckNo.FieldName = "CheckNo"
        Me.colCheckNo.Name = "colCheckNo"
        Me.colCheckNo.Width = 87
        '
        'colAccountName
        '
        Me.colAccountName.Caption = "Account Name"
        Me.colAccountName.FieldName = "AccountName"
        Me.colAccountName.Name = "colAccountName"
        Me.colAccountName.Width = 87
        '
        'colDateIssued
        '
        Me.colDateIssued.Caption = "Date Issued"
        Me.colDateIssued.FieldName = "DateIssued"
        Me.colDateIssued.Name = "colDateIssued"
        Me.colDateIssued.Width = 87
        '
        'colDateDue
        '
        Me.colDateDue.Caption = "Date Due"
        Me.colDateDue.FieldName = "DateDue"
        Me.colDateDue.Name = "colDateDue"
        Me.colDateDue.Width = 87
        '
        'colAccountNo
        '
        Me.colAccountNo.Caption = "Account No."
        Me.colAccountNo.FieldName = "AccountNo"
        Me.colAccountNo.Name = "colAccountNo"
        Me.colAccountNo.Visible = True
        Me.colAccountNo.VisibleIndex = 4
        Me.colAccountNo.Width = 87
        '
        'colBankName
        '
        Me.colBankName.Caption = "Bank Name"
        Me.colBankName.FieldName = "BankName"
        Me.colBankName.Name = "colBankName"
        Me.colBankName.Visible = True
        Me.colBankName.VisibleIndex = 5
        Me.colBankName.Width = 87
        '
        'colAmount
        '
        Me.colAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAmount.Caption = "Amount Pd"
        Me.colAmount.DisplayFormat.FormatString = "N2"
        Me.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 1
        Me.colAmount.Width = 87
        '
        'colRemarks
        '
        Me.colRemarks.Caption = "Cashier"
        Me.colRemarks.FieldName = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.Visible = True
        Me.colRemarks.VisibleIndex = 6
        Me.colRemarks.Width = 95
        '
        'colOldBal
        '
        Me.colOldBal.AppearanceHeader.Options.UseTextOptions = True
        Me.colOldBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colOldBal.Caption = "Old Balance"
        Me.colOldBal.DisplayFormat.FormatString = "N2"
        Me.colOldBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOldBal.FieldName = "OldBal"
        Me.colOldBal.Name = "colOldBal"
        Me.colOldBal.Visible = True
        Me.colOldBal.VisibleIndex = 2
        Me.colOldBal.Width = 87
        '
        'colNewBal
        '
        Me.colNewBal.AppearanceHeader.Options.UseTextOptions = True
        Me.colNewBal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colNewBal.Caption = "New Balance"
        Me.colNewBal.DisplayFormat.FormatString = "N2"
        Me.colNewBal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNewBal.FieldName = "NewBal"
        Me.colNewBal.Name = "colNewBal"
        Me.colNewBal.Visible = True
        Me.colNewBal.VisibleIndex = 3
        Me.colNewBal.Width = 87
        '
        'colfirstname
        '
        Me.colfirstname.FieldName = "firstname"
        Me.colfirstname.Name = "colfirstname"
        '
        'collastname
        '
        Me.collastname.FieldName = "lastname"
        Me.collastname.Name = "collastname"
        '
        'colmiddlename
        '
        Me.colmiddlename.FieldName = "middlename"
        Me.colmiddlename.Name = "colmiddlename"
        '
        'VwCustPaymentsTableAdapter
        '
        Me.VwCustPaymentsTableAdapter.ClearBeforeFill = True
        '
        'frmCustPayGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 497)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmCustPayGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer Payments Grid"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCustPaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCustPay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsCustPay As DoorsPOS.WinApp.dsCustPay
    Friend WithEvents VwCustPaymentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwCustPaymentsTableAdapter As DoorsPOS.WinApp.dsCustPayTableAdapters.vwCustPaymentsTableAdapter
    Friend WithEvents colPayDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCheckNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateIssued As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateDue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAccountNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOldBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewBal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmiddlename As DevExpress.XtraGrid.Columns.GridColumn
End Class
