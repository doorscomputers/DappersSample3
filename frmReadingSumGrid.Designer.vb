<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReadingSumGrid
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
        Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column18 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column19 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression19 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column20 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression20 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column21 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression21 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column22 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression22 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column23 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression23 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column24 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression24 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReadingSumGrid))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colReadingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCashier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSales = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBegCash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCashEnd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOverAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemittance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPettyCash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddFund = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "ReadingSum"
        Me.GridControl1.DataSource = Me.SqlDataSource1
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(924, 505)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "DoorsPOS.WinApp.My.MySettings.doorsposConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression13.ColumnName = "ReadingId"
        Table2.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""286"" />"
        Table2.Name = "ReadingSum"
        ColumnExpression13.Table = Table2
        Column13.Expression = ColumnExpression13
        ColumnExpression14.ColumnName = "ReadingDate"
        ColumnExpression14.Table = Table2
        Column14.Expression = ColumnExpression14
        ColumnExpression15.ColumnName = "Location"
        ColumnExpression15.Table = Table2
        Column15.Expression = ColumnExpression15
        ColumnExpression16.ColumnName = "Cashier"
        ColumnExpression16.Table = Table2
        Column16.Expression = ColumnExpression16
        ColumnExpression17.ColumnName = "TotalSales"
        ColumnExpression17.Table = Table2
        Column17.Expression = ColumnExpression17
        ColumnExpression18.ColumnName = "BegCash"
        ColumnExpression18.Table = Table2
        Column18.Expression = ColumnExpression18
        ColumnExpression19.ColumnName = "CashEnd"
        ColumnExpression19.Table = Table2
        Column19.Expression = ColumnExpression19
        ColumnExpression20.ColumnName = "Short"
        ColumnExpression20.Table = Table2
        Column20.Expression = ColumnExpression20
        ColumnExpression21.ColumnName = "OverAmount"
        ColumnExpression21.Table = Table2
        Column21.Expression = ColumnExpression21
        ColumnExpression22.ColumnName = "Remittance"
        ColumnExpression22.Table = Table2
        Column22.Expression = ColumnExpression22
        ColumnExpression23.ColumnName = "AddFund"
        ColumnExpression23.Table = Table2
        Column23.Expression = ColumnExpression23
        ColumnExpression24.ColumnName = "PettyCash"
        ColumnExpression24.Table = Table2
        Column24.Expression = ColumnExpression24
        SelectQuery2.Columns.Add(Column13)
        SelectQuery2.Columns.Add(Column14)
        SelectQuery2.Columns.Add(Column15)
        SelectQuery2.Columns.Add(Column16)
        SelectQuery2.Columns.Add(Column17)
        SelectQuery2.Columns.Add(Column18)
        SelectQuery2.Columns.Add(Column19)
        SelectQuery2.Columns.Add(Column20)
        SelectQuery2.Columns.Add(Column21)
        SelectQuery2.Columns.Add(Column22)
        SelectQuery2.Columns.Add(Column23)
        SelectQuery2.Columns.Add(Column24)
        SelectQuery2.Name = "ReadingSum"
        SelectQuery2.Tables.Add(Table2)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReadingDate, Me.colLocation, Me.colCashier, Me.colTotalSales, Me.colBegCash, Me.colCashEnd, Me.colShort, Me.colOverAmount, Me.colRemittance, Me.colPettyCash, Me.colAddFund})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colReadingDate
        '
        Me.colReadingDate.FieldName = "ReadingDate"
        Me.colReadingDate.Name = "colReadingDate"
        Me.colReadingDate.Visible = True
        Me.colReadingDate.VisibleIndex = 0
        '
        'colLocation
        '
        Me.colLocation.FieldName = "Location"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.Visible = True
        Me.colLocation.VisibleIndex = 1
        '
        'colCashier
        '
        Me.colCashier.FieldName = "Cashier"
        Me.colCashier.Name = "colCashier"
        Me.colCashier.Visible = True
        Me.colCashier.VisibleIndex = 2
        '
        'colTotalSales
        '
        Me.colTotalSales.FieldName = "TotalSales"
        Me.colTotalSales.Name = "colTotalSales"
        Me.colTotalSales.Visible = True
        Me.colTotalSales.VisibleIndex = 3
        '
        'colBegCash
        '
        Me.colBegCash.FieldName = "BegCash"
        Me.colBegCash.Name = "colBegCash"
        Me.colBegCash.Visible = True
        Me.colBegCash.VisibleIndex = 4
        '
        'colCashEnd
        '
        Me.colCashEnd.FieldName = "CashEnd"
        Me.colCashEnd.Name = "colCashEnd"
        Me.colCashEnd.Visible = True
        Me.colCashEnd.VisibleIndex = 5
        '
        'colShort
        '
        Me.colShort.FieldName = "Short"
        Me.colShort.Name = "colShort"
        Me.colShort.Visible = True
        Me.colShort.VisibleIndex = 6
        '
        'colOverAmount
        '
        Me.colOverAmount.FieldName = "OverAmount"
        Me.colOverAmount.Name = "colOverAmount"
        Me.colOverAmount.Visible = True
        Me.colOverAmount.VisibleIndex = 7
        '
        'colRemittance
        '
        Me.colRemittance.FieldName = "Remittance"
        Me.colRemittance.Name = "colRemittance"
        Me.colRemittance.Visible = True
        Me.colRemittance.VisibleIndex = 8
        '
        'colPettyCash
        '
        Me.colPettyCash.FieldName = "PettyCash"
        Me.colPettyCash.Name = "colPettyCash"
        Me.colPettyCash.Visible = True
        Me.colPettyCash.VisibleIndex = 9
        '
        'colAddFund
        '
        Me.colAddFund.FieldName = "AddFund"
        Me.colAddFund.Name = "colAddFund"
        Me.colAddFund.Visible = True
        Me.colAddFund.VisibleIndex = 10
        '
        'frmReadingSumGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 529)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmReadingSumGrid"
        Me.Text = "Reading Summary Grid"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents colReadingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCashier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSales As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBegCash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCashEnd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOverAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemittance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPettyCash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddFund As DevExpress.XtraGrid.Columns.GridColumn
End Class
