<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncentiveTotal
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
        Me.DsIncentivesNew = New DoorsPOS.WinApp.dsIncentivesNew()
        Me.VwIncentivesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwIncentivesTableAdapter = New DoorsPOS.WinApp.dsIncentivesNewTableAdapters.vwIncentivesTableAdapter()
        Me.fieldposdate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldincentive1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldwaiter1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldwtid1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldstckid1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fielditemdesc1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldqty1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.IncentiveAmount = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldposdate2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldincentive2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldwaiter2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldwtid2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldstckid2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fielditemdesc2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldqty2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIncentivesNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwIncentivesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataMember = "vwIncentives"
        Me.PivotGridControl1.DataSource = Me.DsIncentivesNew
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldposdate2, Me.fieldincentive2, Me.fieldwaiter2, Me.fieldwtid2, Me.fieldstckid2, Me.fielditemdesc2, Me.fieldqty2, Me.PivotGridField2})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.Size = New System.Drawing.Size(800, 450)
        Me.PivotGridControl1.TabIndex = 0
        '
        'DsIncentivesNew
        '
        Me.DsIncentivesNew.DataSetName = "dsIncentivesNew"
        Me.DsIncentivesNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwIncentivesBindingSource
        '
        Me.VwIncentivesBindingSource.DataMember = "vwIncentives"
        Me.VwIncentivesBindingSource.DataSource = Me.DsIncentivesNew
        '
        'VwIncentivesTableAdapter
        '
        Me.VwIncentivesTableAdapter.ClearBeforeFill = True
        '
        'fieldposdate1
        '
        Me.fieldposdate1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldposdate1.AreaIndex = 0
        Me.fieldposdate1.Caption = "pos_date"
        Me.fieldposdate1.FieldName = "pos_date"
        Me.fieldposdate1.Name = "fieldposdate1"
        '
        'fieldincentive1
        '
        Me.fieldincentive1.AreaIndex = 0
        Me.fieldincentive1.Caption = "incentive"
        Me.fieldincentive1.FieldName = "incentive"
        Me.fieldincentive1.Name = "fieldincentive1"
        '
        'fieldwaiter1
        '
        Me.fieldwaiter1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldwaiter1.AreaIndex = 0
        Me.fieldwaiter1.Caption = "Employee Name"
        Me.fieldwaiter1.FieldName = "waiter"
        Me.fieldwaiter1.Name = "fieldwaiter1"
        '
        'fieldwtid1
        '
        Me.fieldwtid1.AreaIndex = 1
        Me.fieldwtid1.Caption = "wtid"
        Me.fieldwtid1.FieldName = "wtid"
        Me.fieldwtid1.Name = "fieldwtid1"
        '
        'fieldstckid1
        '
        Me.fieldstckid1.AreaIndex = 2
        Me.fieldstckid1.Caption = "stckid"
        Me.fieldstckid1.FieldName = "stckid"
        Me.fieldstckid1.Name = "fieldstckid1"
        '
        'fielditemdesc1
        '
        Me.fielditemdesc1.AreaIndex = 3
        Me.fielditemdesc1.Caption = "item_desc"
        Me.fielditemdesc1.FieldName = "item_desc"
        Me.fielditemdesc1.Name = "fielditemdesc1"
        '
        'fieldqty1
        '
        Me.fieldqty1.AreaIndex = 4
        Me.fieldqty1.Caption = "qty"
        Me.fieldqty1.FieldName = "qty"
        Me.fieldqty1.Name = "fieldqty1"
        '
        'IncentiveAmount
        '
        Me.IncentiveAmount.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.IncentiveAmount.AreaIndex = 0
        Me.IncentiveAmount.Caption = "Incentive Amount"
        Me.IncentiveAmount.Name = "IncentiveAmount"
        Me.IncentiveAmount.UnboundExpression = "[incentive] * [qty]"
        '
        'PivotGridField1
        '
        Me.PivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Incentive Amount"
        Me.PivotGridField1.CellFormat.FormatString = "N2"
        Me.PivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField1.Name = "PivotGridField1"
        Me.PivotGridField1.UnboundExpression = "[incentive] * [qty]"
        '
        'fieldposdate2
        '
        Me.fieldposdate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldposdate2.AreaIndex = 0
        Me.fieldposdate2.Caption = "pos_date"
        Me.fieldposdate2.FieldName = "pos_date"
        Me.fieldposdate2.Name = "fieldposdate2"
        '
        'fieldincentive2
        '
        Me.fieldincentive2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldincentive2.AreaIndex = 0
        Me.fieldincentive2.Caption = "incentive"
        Me.fieldincentive2.FieldName = "incentive"
        Me.fieldincentive2.Name = "fieldincentive2"
        '
        'fieldwaiter2
        '
        Me.fieldwaiter2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldwaiter2.AreaIndex = 0
        Me.fieldwaiter2.Caption = "waiter"
        Me.fieldwaiter2.FieldName = "waiter"
        Me.fieldwaiter2.Name = "fieldwaiter2"
        '
        'fieldwtid2
        '
        Me.fieldwtid2.AreaIndex = 0
        Me.fieldwtid2.Caption = "wtid"
        Me.fieldwtid2.FieldName = "wtid"
        Me.fieldwtid2.Name = "fieldwtid2"
        '
        'fieldstckid2
        '
        Me.fieldstckid2.AreaIndex = 1
        Me.fieldstckid2.Caption = "stckid"
        Me.fieldstckid2.FieldName = "stckid"
        Me.fieldstckid2.Name = "fieldstckid2"
        '
        'fielditemdesc2
        '
        Me.fielditemdesc2.AreaIndex = 2
        Me.fielditemdesc2.Caption = "item_desc"
        Me.fielditemdesc2.FieldName = "item_desc"
        Me.fielditemdesc2.Name = "fielditemdesc2"
        '
        'fieldqty2
        '
        Me.fieldqty2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldqty2.AreaIndex = 1
        Me.fieldqty2.Caption = "qty"
        Me.fieldqty2.FieldName = "qty"
        Me.fieldqty2.Name = "fieldqty2"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField2.AreaIndex = 2
        Me.PivotGridField2.Caption = "Incentive Amount"
        Me.PivotGridField2.Name = "PivotGridField2"
        Me.PivotGridField2.UnboundExpression = "[incentive] * [qty]"
        Me.PivotGridField2.UnboundFieldName = "PivotGridField2"
        Me.PivotGridField2.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        '
        'frmIncentiveTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "frmIncentiveTotal"
        Me.Text = "Incentives"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIncentivesNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwIncentivesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents DsIncentivesNew As dsIncentivesNew
    Friend WithEvents VwIncentivesBindingSource As BindingSource
    Friend WithEvents VwIncentivesTableAdapter As dsIncentivesNewTableAdapters.vwIncentivesTableAdapter
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldposdate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldincentive1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldwaiter1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldwtid1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldstckid1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielditemdesc1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldqty1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents IncentiveAmount As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldposdate2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldincentive2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldwaiter2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldwtid2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldstckid2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielditemdesc2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldqty2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
End Class
