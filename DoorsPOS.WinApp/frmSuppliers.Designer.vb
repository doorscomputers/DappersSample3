<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliers
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
        Me.simBtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSupplierss = New DoorsPOS.WinApp.dsSupplierss()
        Me.grdSuppliers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LocationAdd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TelNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TinNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Faxno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.c1DataViewSet1 = New C1.C1DataExtender.C1DataViewSet()
        Me.suppliersTableAdapter = New DoorsPOS.WinApp.dsSupplierssTableAdapters.suppliersTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSupplierss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1DataViewSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'simBtnSave
        '
        Me.simBtnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simBtnSave.Appearance.ForeColor = System.Drawing.Color.Black
        Me.simBtnSave.Appearance.Options.UseFont = True
        Me.simBtnSave.Appearance.Options.UseForeColor = True
        Me.simBtnSave.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.simBtnSave.Location = New System.Drawing.Point(0, 358)
        Me.simBtnSave.Name = "simBtnSave"
        Me.simBtnSave.Size = New System.Drawing.Size(942, 37)
        Me.simBtnSave.TabIndex = 3
        Me.simBtnSave.Text = "Save Changes to the Database"
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.SuppliersBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.grdSuppliers
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(942, 358)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdSuppliers})
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "suppliers"
        Me.SuppliersBindingSource.DataSource = Me.DsSupplierss
        '
        'DsSupplierss
        '
        Me.DsSupplierss.DataSetName = "dsSupplierss"
        Me.DsSupplierss.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdSuppliers
        '
        Me.grdSuppliers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SupplierName, Me.LocationAdd, Me.TelNo, Me.CP, Me.TinNo, Me.Faxno})
        Me.grdSuppliers.GridControl = Me.GridControl1
        Me.grdSuppliers.Name = "grdSuppliers"
        Me.grdSuppliers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.grdSuppliers.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.grdSuppliers.OptionsEditForm.EditFormColumnCount = 1
        Me.grdSuppliers.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[True]
        '
        'SupplierName
        '
        Me.SupplierName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierName.AppearanceCell.Options.UseFont = True
        Me.SupplierName.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.75!)
        Me.SupplierName.AppearanceHeader.Options.UseFont = True
        Me.SupplierName.Caption = "Supplier Name"
        Me.SupplierName.FieldName = "supplier"
        Me.SupplierName.Name = "SupplierName"
        Me.SupplierName.Visible = True
        Me.SupplierName.VisibleIndex = 0
        '
        'LocationAdd
        '
        Me.LocationAdd.Caption = "Address/Location"
        Me.LocationAdd.FieldName = "address"
        Me.LocationAdd.Name = "LocationAdd"
        Me.LocationAdd.Visible = True
        Me.LocationAdd.VisibleIndex = 1
        '
        'TelNo
        '
        Me.TelNo.Caption = "Telephone No"
        Me.TelNo.FieldName = "telno"
        Me.TelNo.Name = "TelNo"
        Me.TelNo.Visible = True
        Me.TelNo.VisibleIndex = 2
        '
        'CP
        '
        Me.CP.Caption = "Cellphone No."
        Me.CP.FieldName = "phone1"
        Me.CP.Name = "CP"
        Me.CP.Visible = True
        Me.CP.VisibleIndex = 3
        '
        'TinNo
        '
        Me.TinNo.Caption = "Tin No."
        Me.TinNo.FieldName = "tinno"
        Me.TinNo.Name = "TinNo"
        Me.TinNo.Visible = True
        Me.TinNo.VisibleIndex = 4
        '
        'Faxno
        '
        Me.Faxno.Caption = "Fax No"
        Me.Faxno.FieldName = "faxno"
        Me.Faxno.Name = "Faxno"
        Me.Faxno.Visible = True
        Me.Faxno.VisibleIndex = 5
        '
        'c1DataViewSet1
        '
        Me.c1DataViewSet1.DataSet = Me.DsSupplierss
        Me.c1DataViewSet1.DiagramXML = ""
        '
        'suppliersTableAdapter
        '
        Me.suppliersTableAdapter.ClearBeforeFill = True
        '
        'frmSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 395)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.simBtnSave)
        Me.Name = "frmSuppliers"
        Me.Text = "Suppliers"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSupplierss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1DataViewSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents simBtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdSuppliers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents c1DataViewSet1 As C1.C1DataExtender.C1DataViewSet
    Friend WithEvents SupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LocationAdd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TelNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TinNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Faxno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsSupplierss As DoorsPOS.WinApp.dsSupplierss
    Friend WithEvents SuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents suppliersTableAdapter As DoorsPOS.WinApp.dsSupplierssTableAdapters.suppliersTableAdapter
End Class
