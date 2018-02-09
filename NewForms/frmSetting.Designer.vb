<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SetuptblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Setupdataset = New DoorsPOS.WinApp.setupdataset()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsearchtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprintimmediate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SetuptblTableAdapter1 = New DoorsPOS.WinApp.setupdatasetTableAdapters.setuptblTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SetuptblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Setupdataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleButton1.Location = New System.Drawing.Point(0, 427)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(800, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Save"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SetuptblBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(800, 427)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SetuptblBindingSource
        '
        Me.SetuptblBindingSource.DataMember = "setuptbl"
        Me.SetuptblBindingSource.DataSource = Me.Setupdataset
        '
        'Setupdataset
        '
        Me.Setupdataset.DataSetName = "setupdataset"
        Me.Setupdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsearchtype, Me.colprintimmediate})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[True]
        '
        'colsearchtype
        '
        Me.colsearchtype.Caption = "Check for Barcode/Uncheck for Item Desc Searching"
        Me.colsearchtype.FieldName = "searchtype"
        Me.colsearchtype.Name = "colsearchtype"
        Me.colsearchtype.Visible = True
        Me.colsearchtype.VisibleIndex = 0
        '
        'colprintimmediate
        '
        Me.colprintimmediate.Caption = "Print Immediately"
        Me.colprintimmediate.FieldName = "printimmediate"
        Me.colprintimmediate.Name = "colprintimmediate"
        '
        'SetuptblTableAdapter1
        '
        Me.SetuptblTableAdapter1.ClearBeforeFill = True
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "frmSetting"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SetuptblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Setupdataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colsearchtype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprintimmediate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Setupdataset As setupdataset
    Friend WithEvents SetuptblBindingSource As BindingSource
    Friend WithEvents SetuptblTableAdapter1 As setupdatasetTableAdapters.setuptblTableAdapter
End Class
