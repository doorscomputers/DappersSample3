<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmployees1 = New DoorsPOS.WinApp.dsEmployees()
        Me.grdEmployees = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colwtid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colwaiter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.WaitersTableAdapter1 = New DoorsPOS.WinApp.dsEmployeesTableAdapters.waitersTableAdapter()
        Me.c1DataViewSet1 = New C1.C1DataExtender.C1DataViewSet()
        Me.simBtnSave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmployees1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1DataViewSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.grdEmployees
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(839, 428)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdEmployees})
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "waiters"
        Me.BindingSource1.DataSource = Me.DsEmployees1
        Me.BindingSource1.Sort = ""
        '
        'DsEmployees1
        '
        Me.DsEmployees1.DataSetName = "dsEmployees"
        Me.DsEmployees1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdEmployees
        '
        Me.grdEmployees.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colwtid, Me.colwaiter, Me.colpword})
        Me.grdEmployees.GridControl = Me.GridControl1
        Me.grdEmployees.Name = "grdEmployees"
        Me.grdEmployees.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.grdEmployees.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.grdEmployees.OptionsEditForm.EditFormColumnCount = 1
        Me.grdEmployees.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdEmployees.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[True]
        '
        'colwtid
        '
        Me.colwtid.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colwtid.AppearanceCell.Options.UseFont = True
        Me.colwtid.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colwtid.AppearanceHeader.Options.UseFont = True
        Me.colwtid.FieldName = "wtid"
        Me.colwtid.Name = "colwtid"
        Me.colwtid.OptionsColumn.ReadOnly = True
        '
        'colwaiter
        '
        Me.colwaiter.Caption = "Employee Name"
        Me.colwaiter.FieldName = "waiter"
        Me.colwaiter.Name = "colwaiter"
        Me.colwaiter.Visible = True
        Me.colwaiter.VisibleIndex = 0
        '
        'colpword
        '
        Me.colpword.Caption = "Password"
        Me.colpword.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colpword.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colpword.FieldName = "pword"
        Me.colpword.Name = "colpword"
        Me.colpword.Visible = True
        Me.colpword.VisibleIndex = 1
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        'WaitersTableAdapter1
        '
        Me.WaitersTableAdapter1.ClearBeforeFill = True
        '
        'c1DataViewSet1
        '
        Me.c1DataViewSet1.DataSet = Me.DsEmployees1
        Me.c1DataViewSet1.DiagramXML = "<C1Diagram><Nodes /></C1Diagram>"
        '
        'simBtnSave
        '
        Me.simBtnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simBtnSave.Appearance.ForeColor = System.Drawing.Color.Red
        Me.simBtnSave.Appearance.Options.UseFont = True
        Me.simBtnSave.Appearance.Options.UseForeColor = True
        Me.simBtnSave.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.simBtnSave.Location = New System.Drawing.Point(0, 434)
        Me.simBtnSave.Name = "simBtnSave"
        Me.simBtnSave.Size = New System.Drawing.Size(839, 23)
        Me.simBtnSave.TabIndex = 1
        Me.simBtnSave.Text = "&Save"
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 457)
        Me.Controls.Add(Me.simBtnSave)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmEmployee"
        Me.Text = "Employees"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmployees1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1DataViewSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdEmployees As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsEmployees1 As DoorsPOS.WinApp.dsEmployees
    Friend WithEvents colwtid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colwaiter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpword As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WaitersTableAdapter1 As DoorsPOS.WinApp.dsEmployeesTableAdapters.waitersTableAdapter
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents c1DataViewSet1 As C1.C1DataExtender.C1DataViewSet
    Friend WithEvents simBtnSave As DevExpress.XtraEditors.SimpleButton
End Class
