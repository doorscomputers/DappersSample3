<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim C1DataView1 As C1.C1DataExtender.C1DataView
        Dim C1ViewColumn1 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn2 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Me.simBtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.Waiters2Dataset = New DoorsPOS.WinApp.waiters2Dataset()
        Me.Waiter2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Waiter2TableAdapter = New DoorsPOS.WinApp.waiters2DatasetTableAdapters.waiter2TableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        C1DataView1 = New C1.C1DataExtender.C1DataView()
        CType(Me.Waiters2Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Waiter2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DataView1
        '
        C1ViewColumn1.ColumnNameSerialized = "name"
        C1ViewColumn2.ColumnNameSerialized = "password"
        C1DataView1.ColumnDefs.Add(C1ViewColumn1)
        C1DataView1.ColumnDefs.Add(C1ViewColumn2)
        C1DataView1.Definition = "SELECT * FROM [waiter2]"
        C1DataView1.DefinitionDiagramXML = ""
        C1DataView1.ViewName = "waiter2"
        '
        'simBtnSave
        '
        Me.simBtnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simBtnSave.Appearance.ForeColor = System.Drawing.Color.Red
        Me.simBtnSave.Appearance.Options.UseFont = True
        Me.simBtnSave.Appearance.Options.UseForeColor = True
        Me.simBtnSave.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.simBtnSave.Location = New System.Drawing.Point(0, 427)
        Me.simBtnSave.Name = "simBtnSave"
        Me.simBtnSave.Size = New System.Drawing.Size(800, 23)
        Me.simBtnSave.TabIndex = 3
        Me.simBtnSave.Text = "&Save"
        '
        'Waiters2Dataset
        '
        Me.Waiters2Dataset.DataSetName = "waiters2Dataset"
        Me.Waiters2Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Waiter2BindingSource
        '
        Me.Waiter2BindingSource.DataMember = "waiter2"
        Me.Waiter2BindingSource.DataSource = Me.Waiters2Dataset
        '
        'Waiter2TableAdapter
        '
        Me.Waiter2TableAdapter.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.Waiter2BindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(800, 427)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colname, Me.colpassword})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[True]
        '
        'colname
        '
        Me.colname.Caption = "Admin Name"
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 0
        '
        'colpassword
        '
        Me.colpassword.Caption = "Password"
        Me.colpassword.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colpassword.FieldName = "password"
        Me.colpassword.Name = "colpassword"
        Me.colpassword.Visible = True
        Me.colpassword.VisibleIndex = 1
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.simBtnSave)
        Me.Name = "frmAdmin"
        Me.Text = "Admin"
        CType(Me.Waiters2Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Waiter2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents simBtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Waiters2Dataset As waiters2Dataset
    Friend WithEvents Waiter2BindingSource As BindingSource
    Friend WithEvents Waiter2TableAdapter As waiters2DatasetTableAdapters.waiter2TableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpassword As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
