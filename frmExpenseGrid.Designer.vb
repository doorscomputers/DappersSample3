<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenseGrid
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
        Me.TblExpenseTransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExpenses = New DoorsPOS.WinApp.dsExpenses()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colexpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexpdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexpamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexpremarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsInsert_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TblExpenseTransTableAdapter = New DoorsPOS.WinApp.dsExpensesTableAdapters.tblExpenseTransTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExpenseTransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.TblExpenseTransBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(848, 426)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'TblExpenseTransBindingSource
        '
        Me.TblExpenseTransBindingSource.DataMember = "tblExpenseTrans"
        Me.TblExpenseTransBindingSource.DataSource = Me.DsExpenses
        '
        'DsExpenses
        '
        Me.DsExpenses.DataSetName = "dsExpenses"
        Me.DsExpenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colexpdate, Me.colexpdesc, Me.colexpamount, Me.colexpremarks, Me.colsInsert_id})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "expamount", Me.colexpamount, "SUM={0:0.##}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colexpdate
        '
        Me.colexpdate.Caption = "Date"
        Me.colexpdate.FieldName = "expdate"
        Me.colexpdate.Name = "colexpdate"
        Me.colexpdate.Visible = True
        Me.colexpdate.VisibleIndex = 0
        Me.colexpdate.Width = 212
        '
        'colexpdesc
        '
        Me.colexpdesc.Caption = "Type"
        Me.colexpdesc.FieldName = "expdesc"
        Me.colexpdesc.Name = "colexpdesc"
        Me.colexpdesc.Visible = True
        Me.colexpdesc.VisibleIndex = 1
        Me.colexpdesc.Width = 212
        '
        'colexpamount
        '
        Me.colexpamount.AppearanceHeader.Options.UseTextOptions = True
        Me.colexpamount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colexpamount.Caption = "Amount"
        Me.colexpamount.DisplayFormat.FormatString = "N2"
        Me.colexpamount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colexpamount.FieldName = "expamount"
        Me.colexpamount.Name = "colexpamount"
        Me.colexpamount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "expamount", "SUM={0:N2}")})
        Me.colexpamount.Visible = True
        Me.colexpamount.VisibleIndex = 2
        Me.colexpamount.Width = 103
        '
        'colexpremarks
        '
        Me.colexpremarks.AppearanceCell.Options.UseTextOptions = True
        Me.colexpremarks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colexpremarks.AppearanceHeader.Options.UseTextOptions = True
        Me.colexpremarks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colexpremarks.Caption = "Remark"
        Me.colexpremarks.FieldName = "expremarks"
        Me.colexpremarks.Name = "colexpremarks"
        Me.colexpremarks.Visible = True
        Me.colexpremarks.VisibleIndex = 3
        Me.colexpremarks.Width = 266
        '
        'colsInsert_id
        '
        Me.colsInsert_id.Caption = "Encoded By"
        Me.colsInsert_id.FieldName = "sInsert_id"
        Me.colsInsert_id.Name = "colsInsert_id"
        Me.colsInsert_id.Visible = True
        Me.colsInsert_id.VisibleIndex = 4
        Me.colsInsert_id.Width = 269
        '
        'TblExpenseTransTableAdapter
        '
        Me.TblExpenseTransTableAdapter.ClearBeforeFill = True
        '
        'frmExpenseGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 426)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmExpenseGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Expenses Grid View"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExpenseTransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsExpenses As DoorsPOS.WinApp.dsExpenses
    Friend WithEvents TblExpenseTransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblExpenseTransTableAdapter As DoorsPOS.WinApp.dsExpensesTableAdapters.tblExpenseTransTableAdapter
    Friend WithEvents colexpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexpamount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexpremarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsInsert_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexpdesc As DevExpress.XtraGrid.Columns.GridColumn
End Class
