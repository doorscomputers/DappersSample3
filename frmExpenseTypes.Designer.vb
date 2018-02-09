<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenseTypes
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
        Dim C1DataView1 As C1.C1DataExtender.C1DataView
        Dim C1ViewColumn3 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn4 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Me.C1DataViewSet1 = New C1.C1DataExtender.C1DataViewSet()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DsExpenseType = New DoorsPOS.WinApp.dsExpenseType()
        Me.colexpenseid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexpdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        C1DataView1 = New C1.C1DataExtender.C1DataView()
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExpenseType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DataViewSet1
        '
        Me.C1DataViewSet1.DataSet = Me.DsExpenseType
        Me.C1DataViewSet1.DiagramXML = "<C1Diagram><Nodes><Node DesigningObjectName=""tblExpenses""><Location X=""10"" Y=""10""" & _
    " /><Size Width=""164"" Height=""124"" /></Node></Nodes></C1Diagram>"
        Me.C1DataViewSet1.Views.Add(C1DataView1)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = C1DataView1
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(369, 416)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colexpenseid, Me.colexpdesc})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 434)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(230, 33)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Save Changes to the Database"
        '
        'DsExpenseType
        '
        Me.DsExpenseType.DataSetName = "dsExpenseType"
        Me.DsExpenseType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'C1DataView1
        '
        C1ViewColumn3.ColumnNameSerialized = "expenseid"
        C1ViewColumn4.ColumnNameSerialized = "expdesc"
        C1DataView1.ColumnDefs.Add(C1ViewColumn3)
        C1DataView1.ColumnDefs.Add(C1ViewColumn4)
        C1DataView1.Definition = "SELECT * FROM [tblExpenses]"
        C1DataView1.DefinitionDiagramXML = ""
        C1DataView1.ViewName = "tblExpenses"
        '
        'colexpenseid
        '
        Me.colexpenseid.FieldName = "expenseid"
        Me.colexpenseid.Name = "colexpenseid"
        '
        'colexpdesc
        '
        Me.colexpdesc.Caption = "Type"
        Me.colexpdesc.FieldName = "expdesc"
        Me.colexpdesc.Name = "colexpdesc"
        Me.colexpdesc.Visible = True
        Me.colexpdesc.VisibleIndex = 0
        '
        'frmExpenseTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 470)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmExpenseTypes"
        Me.Text = "Types of Expenses"
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExpenseType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1DataViewSet1 As C1.C1DataExtender.C1DataViewSet
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DsExpenseType As DoorsPOS.WinApp.dsExpenseType
    Friend WithEvents colexpenseid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexpdesc As DevExpress.XtraGrid.Columns.GridColumn
End Class
