<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRdID
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
        Me.TblreadingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsRdID = New DoorsPOS.WinApp.dsRdID()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcashreadid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcashier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldatereading = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbegincash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TblreadingTableAdapter = New DoorsPOS.WinApp.dsRdIDTableAdapters.tblreadingTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblreadingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRdID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.TblreadingBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(534, 511)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'TblreadingBindingSource
        '
        Me.TblreadingBindingSource.DataMember = "tblreading"
        Me.TblreadingBindingSource.DataSource = Me.DsRdID
        '
        'DsRdID
        '
        Me.DsRdID.DataSetName = "dsRdID"
        Me.DsRdID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcashreadid, Me.colcashier, Me.coldatereading, Me.colbegincash, Me.colstatus})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colcashreadid
        '
        Me.colcashreadid.AppearanceCell.Options.UseTextOptions = True
        Me.colcashreadid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colcashreadid.Caption = "Reading ID"
        Me.colcashreadid.FieldName = "cashreadid"
        Me.colcashreadid.Name = "colcashreadid"
        Me.colcashreadid.OptionsColumn.ReadOnly = True
        Me.colcashreadid.Visible = True
        Me.colcashreadid.VisibleIndex = 0
        '
        'colcashier
        '
        Me.colcashier.Caption = "Cashier"
        Me.colcashier.FieldName = "cashier"
        Me.colcashier.Name = "colcashier"
        Me.colcashier.Visible = True
        Me.colcashier.VisibleIndex = 1
        '
        'coldatereading
        '
        Me.coldatereading.Caption = "Date"
        Me.coldatereading.FieldName = "datereading"
        Me.coldatereading.Name = "coldatereading"
        Me.coldatereading.Visible = True
        Me.coldatereading.VisibleIndex = 2
        '
        'colbegincash
        '
        Me.colbegincash.AppearanceHeader.Options.UseTextOptions = True
        Me.colbegincash.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colbegincash.Caption = "Beginning Cash"
        Me.colbegincash.DisplayFormat.FormatString = "N2"
        Me.colbegincash.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colbegincash.FieldName = "begincash"
        Me.colbegincash.Name = "colbegincash"
        Me.colbegincash.Visible = True
        Me.colbegincash.VisibleIndex = 3
        '
        'colstatus
        '
        Me.colstatus.Caption = "Status"
        Me.colstatus.FieldName = "status"
        Me.colstatus.Name = "colstatus"
        Me.colstatus.Visible = True
        Me.colstatus.VisibleIndex = 4
        '
        'TblreadingTableAdapter
        '
        Me.TblreadingTableAdapter.ClearBeforeFill = True
        '
        'frmRdID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 511)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmRdID"
        Me.Text = "Cashier Reading ID"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblreadingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRdID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsRdID As DoorsPOS.WinApp.dsRdID
    Friend WithEvents TblreadingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblreadingTableAdapter As DoorsPOS.WinApp.dsRdIDTableAdapters.tblreadingTableAdapter
    Friend WithEvents colcashreadid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcashier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldatereading As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbegincash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus As DevExpress.XtraGrid.Columns.GridColumn
End Class
