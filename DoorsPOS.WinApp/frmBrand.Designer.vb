<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrand
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
        Dim C1ViewColumn3 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldeptid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPTD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.C1DataViewSet1 = New C1.C1DataExtender.C1DataViewSet()
        Me.DsBrands = New DoorsPOS.WinApp.dsBrands()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        C1DataView1 = New C1.C1DataExtender.C1DataView()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBrands, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DataView1
        '
        C1ViewColumn1.ColumnNameSerialized = "deptid"
        C1ViewColumn2.ColumnNameSerialized = "DEPT"
        C1ViewColumn3.ColumnNameSerialized = "DEPTD"
        C1DataView1.ColumnDefs.Add(C1ViewColumn1)
        C1DataView1.ColumnDefs.Add(C1ViewColumn2)
        C1DataView1.ColumnDefs.Add(C1ViewColumn3)
        C1DataView1.Definition = "SELECT * FROM [dept]"
        C1DataView1.DefinitionDiagramXML = ""
        C1DataView1.ViewName = "dept"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = C1DataView1
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(400, 418)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldeptid, Me.colDEPT, Me.colDEPTD})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'coldeptid
        '
        Me.coldeptid.FieldName = "deptid"
        Me.coldeptid.Name = "coldeptid"
        '
        'colDEPT
        '
        Me.colDEPT.FieldName = "DEPT"
        Me.colDEPT.Name = "colDEPT"
        '
        'colDEPTD
        '
        Me.colDEPTD.Caption = "Brand"
        Me.colDEPTD.FieldName = "DEPTD"
        Me.colDEPTD.Name = "colDEPTD"
        Me.colDEPTD.Visible = True
        Me.colDEPTD.VisibleIndex = 0
        '
        'C1DataViewSet1
        '
        Me.C1DataViewSet1.DataSet = Me.DsBrands
        Me.C1DataViewSet1.DiagramXML = "<C1Diagram><Nodes><Node DesigningObjectName=""dept""><Location X=""10"" Y=""10"" /><Siz" & _
    "e Width=""164"" Height=""124"" /></Node></Nodes></C1Diagram>"
        Me.C1DataViewSet1.Views.Add(C1DataView1)
        '
        'DsBrands
        '
        Me.DsBrands.DataSetName = "dsBrands"
        Me.DsBrands.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleButton1.Location = New System.Drawing.Point(0, 448)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(426, 35)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Save Changes to the Database"
        '
        'frmBrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 483)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmBrand"
        Me.Text = "Brand"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBrands, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents C1DataViewSet1 As C1.C1DataExtender.C1DataViewSet
    Friend WithEvents coldeptid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPTD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsBrands As DoorsPOS.WinApp.dsBrands
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
