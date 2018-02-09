<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTypes
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
        Dim C1ViewColumn1 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn2 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsizeid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsayz = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.C1DataViewSet1 = New C1.C1DataExtender.C1DataViewSet()
        Me.DsSize = New DoorsPOS.WinApp.dsSize()
        C1DataView1 = New C1.C1DataExtender.C1DataView()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DataView1
        '
        C1ViewColumn1.ColumnNameSerialized = "sizeid"
        C1ViewColumn2.ColumnNameSerialized = "sayz"
        C1DataView1.ColumnDefs.Add(C1ViewColumn1)
        C1DataView1.ColumnDefs.Add(C1ViewColumn2)
        C1DataView1.Definition = "SELECT * FROM [wsize]"
        C1DataView1.DefinitionDiagramXML = ""
        C1DataView1.ViewName = "wsize"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = C1DataView1
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(333, 428)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsizeid, Me.colsayz})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colsizeid
        '
        Me.colsizeid.FieldName = "sizeid"
        Me.colsizeid.Name = "colsizeid"
        '
        'colsayz
        '
        Me.colsayz.Caption = "Type or SIze"
        Me.colsayz.FieldName = "sayz"
        Me.colsayz.Name = "colsayz"
        Me.colsayz.Visible = True
        Me.colsayz.VisibleIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleButton1.Location = New System.Drawing.Point(0, 446)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(357, 38)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Save Changes to the Database"
        '
        'C1DataViewSet1
        '
        Me.C1DataViewSet1.DataSet = Me.DsSize
        Me.C1DataViewSet1.DiagramXML = "<C1Diagram><Nodes><Node DesigningObjectName=""wsize""><Location X=""10"" Y=""10"" /><Si" & _
    "ze Width=""164"" Height=""124"" /></Node></Nodes></C1Diagram>"
        Me.C1DataViewSet1.Views.Add(C1DataView1)
        '
        'DsSize
        '
        Me.DsSize.DataSetName = "dsSize"
        Me.DsSize.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 484)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmTypes"
        Me.Text = "Item Types or Sizes"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colsizeid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsayz As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents C1DataViewSet1 As C1.C1DataExtender.C1DataViewSet
    Friend WithEvents DsSize As DoorsPOS.WinApp.dsSize
End Class
