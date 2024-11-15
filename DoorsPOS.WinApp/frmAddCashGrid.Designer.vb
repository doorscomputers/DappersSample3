<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCashGrid
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
        Me.AdditnlcashBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAddCash = New DoorsPOS.WinApp.dsAddCash()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colposdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colacamnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colacremarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcashier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AdditnlcashTableAdapter = New DoorsPOS.WinApp.dsAddCashTableAdapters.additnlcashTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdditnlcashBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAddCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.AdditnlcashBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(882, 494)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AdditnlcashBindingSource
        '
        Me.AdditnlcashBindingSource.DataMember = "additnlcash"
        Me.AdditnlcashBindingSource.DataSource = Me.DsAddCash
        '
        'DsAddCash
        '
        Me.DsAddCash.DataSetName = "dsAddCash"
        Me.DsAddCash.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colposdate, Me.colacamnt, Me.colacremarks, Me.colcashier})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "acamnt", Me.colacamnt, "SUM={0:N2}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colposdate
        '
        Me.colposdate.Caption = "Date"
        Me.colposdate.FieldName = "posdate"
        Me.colposdate.Name = "colposdate"
        Me.colposdate.Visible = True
        Me.colposdate.VisibleIndex = 0
        Me.colposdate.Width = 160
        '
        'colacamnt
        '
        Me.colacamnt.AppearanceHeader.Options.UseTextOptions = True
        Me.colacamnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colacamnt.Caption = "Amount"
        Me.colacamnt.DisplayFormat.FormatString = "N2"
        Me.colacamnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colacamnt.FieldName = "acamnt"
        Me.colacamnt.Name = "colacamnt"
        Me.colacamnt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "acamnt", "SUM={0:N2}")})
        Me.colacamnt.Visible = True
        Me.colacamnt.VisibleIndex = 2
        Me.colacamnt.Width = 176
        '
        'colacremarks
        '
        Me.colacremarks.Caption = "Remark"
        Me.colacremarks.FieldName = "acremarks"
        Me.colacremarks.Name = "colacremarks"
        Me.colacremarks.Visible = True
        Me.colacremarks.VisibleIndex = 1
        Me.colacremarks.Width = 299
        '
        'colcashier
        '
        Me.colcashier.AppearanceCell.Options.UseTextOptions = True
        Me.colcashier.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colcashier.AppearanceHeader.Options.UseTextOptions = True
        Me.colcashier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colcashier.Caption = "Cashier"
        Me.colcashier.FieldName = "cashier"
        Me.colcashier.Name = "colcashier"
        Me.colcashier.Visible = True
        Me.colcashier.VisibleIndex = 3
        '
        'AdditnlcashTableAdapter
        '
        Me.AdditnlcashTableAdapter.ClearBeforeFill = True
        '
        'frmAddCashGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 494)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmAddCashGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Addtional Cash Received by Cashiers"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdditnlcashBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAddCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsAddCash As DoorsPOS.WinApp.dsAddCash
    Friend WithEvents AdditnlcashBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdditnlcashTableAdapter As DoorsPOS.WinApp.dsAddCashTableAdapters.additnlcashTableAdapter
    Friend WithEvents colposdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colacamnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colacremarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcashier As DevExpress.XtraGrid.Columns.GridColumn
End Class
