<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpensesPvt
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
        Me.DsExpenses = New DoorsPOS.WinApp.dsExpenses()
        Me.TblExpenseTransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblExpenseTransTableAdapter = New DoorsPOS.WinApp.dsExpensesTableAdapters.tblExpenseTransTableAdapter()
        Me.fieldexpdate = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldexpdesc = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldexpamount = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldexpdate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblExpenseTransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataSource = Me.TblExpenseTransBindingSource
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldexpdate1, Me.fieldexpdate, Me.fieldexpdesc, Me.fieldexpamount})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(932, 519)
        Me.PivotGridControl1.TabIndex = 0
        '
        'DsExpenses
        '
        Me.DsExpenses.DataSetName = "dsExpenses"
        Me.DsExpenses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblExpenseTransBindingSource
        '
        Me.TblExpenseTransBindingSource.DataMember = "tblExpenseTrans"
        Me.TblExpenseTransBindingSource.DataSource = Me.DsExpenses
        '
        'TblExpenseTransTableAdapter
        '
        Me.TblExpenseTransTableAdapter.ClearBeforeFill = True
        '
        'fieldexpdate
        '
        Me.fieldexpdate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldexpdate.AreaIndex = 1
        Me.fieldexpdate.Caption = "Month"
        Me.fieldexpdate.FieldName = "expdate"
        Me.fieldexpdate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
        Me.fieldexpdate.Name = "fieldexpdate"
        Me.fieldexpdate.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldexpdate.UnboundFieldName = "fieldexpdate"
        '
        'fieldexpdesc
        '
        Me.fieldexpdesc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldexpdesc.AreaIndex = 0
        Me.fieldexpdesc.Caption = "Description"
        Me.fieldexpdesc.FieldName = "expdesc"
        Me.fieldexpdesc.Name = "fieldexpdesc"
        Me.fieldexpdesc.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        '
        'fieldexpamount
        '
        Me.fieldexpamount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldexpamount.AreaIndex = 0
        Me.fieldexpamount.Caption = "Amount"
        Me.fieldexpamount.FieldName = "expamount"
        Me.fieldexpamount.Name = "fieldexpamount"
        '
        'fieldexpdate1
        '
        Me.fieldexpdate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldexpdate1.AreaIndex = 0
        Me.fieldexpdate1.Caption = "Year"
        Me.fieldexpdate1.FieldName = "expdate"
        Me.fieldexpdate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
        Me.fieldexpdate1.Name = "fieldexpdate1"
        Me.fieldexpdate1.UnboundFieldName = "fieldexpdate1"
        '
        'frmExpensesPvt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 519)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmExpensesPvt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Expenses Grid View 2"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblExpenseTransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DsExpenses As DoorsPOS.WinApp.dsExpenses
    Friend WithEvents TblExpenseTransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblExpenseTransTableAdapter As DoorsPOS.WinApp.dsExpensesTableAdapters.tblExpenseTransTableAdapter
    Friend WithEvents fieldexpdate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldexpdate As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldexpdesc As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldexpamount As DevExpress.XtraPivotGrid.PivotGridField
End Class
