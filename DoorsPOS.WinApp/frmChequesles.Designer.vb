<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheqSales
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
        Me.PoshdrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCheques = New DoorsPOS.WinApp.dsCheques()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colpostmp_hdrid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpos_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmowd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltotsales = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Pos_hdrTableAdapter = New DoorsPOS.WinApp.dsChequesTableAdapters.pos_hdrTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PoshdrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PoshdrBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(943, 499)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PoshdrBindingSource
        '
        Me.PoshdrBindingSource.DataMember = "pos_hdr"
        Me.PoshdrBindingSource.DataSource = Me.DsCheques
        '
        'DsCheques
        '
        Me.DsCheques.DataSetName = "dsCheques"
        Me.DsCheques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colpostmp_hdrid, Me.colpos_date, Me.colmowd, Me.coltotsales})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colpostmp_hdrid
        '
        Me.colpostmp_hdrid.AppearanceCell.Options.UseTextOptions = True
        Me.colpostmp_hdrid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colpostmp_hdrid.Caption = "Reference No."
        Me.colpostmp_hdrid.FieldName = "postmp_hdrid"
        Me.colpostmp_hdrid.Name = "colpostmp_hdrid"
        Me.colpostmp_hdrid.Visible = True
        Me.colpostmp_hdrid.VisibleIndex = 0
        '
        'colpos_date
        '
        Me.colpos_date.Caption = "Date"
        Me.colpos_date.FieldName = "pos_date"
        Me.colpos_date.Name = "colpos_date"
        Me.colpos_date.Visible = True
        Me.colpos_date.VisibleIndex = 1
        '
        'colmowd
        '
        Me.colmowd.Caption = "Type of Payment"
        Me.colmowd.FieldName = "mowd"
        Me.colmowd.Name = "colmowd"
        Me.colmowd.Visible = True
        Me.colmowd.VisibleIndex = 2
        '
        'coltotsales
        '
        Me.coltotsales.AppearanceHeader.Options.UseTextOptions = True
        Me.coltotsales.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.coltotsales.Caption = "Amount"
        Me.coltotsales.DisplayFormat.FormatString = "N2"
        Me.coltotsales.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coltotsales.FieldName = "totsales"
        Me.coltotsales.Name = "coltotsales"
        Me.coltotsales.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "totsales", "SUM={0:N2}")})
        Me.coltotsales.Visible = True
        Me.coltotsales.VisibleIndex = 3
        '
        'Pos_hdrTableAdapter
        '
        Me.Pos_hdrTableAdapter.ClearBeforeFill = True
        '
        'frmCheqSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 499)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmCheqSales"
        Me.Text = "Cheque Sales"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PoshdrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsCheques As DoorsPOS.WinApp.dsCheques
    Friend WithEvents PoshdrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pos_hdrTableAdapter As DoorsPOS.WinApp.dsChequesTableAdapters.pos_hdrTableAdapter
    Friend WithEvents colpostmp_hdrid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpos_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmowd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltotsales As DevExpress.XtraGrid.Columns.GridColumn
End Class
