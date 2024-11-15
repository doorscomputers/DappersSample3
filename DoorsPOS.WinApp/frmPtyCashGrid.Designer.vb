<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPtyCashGrid
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
        Me.PettycashBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPetyCash = New DoorsPOS.WinApp.dsPetyCash()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colposdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpcrem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpcamnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcashier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Petty_cashTableAdapter = New DoorsPOS.WinApp.dsPetyCashTableAdapters.petty_cashTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PettycashBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPetyCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.PettycashBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(765, 480)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PettycashBindingSource
        '
        Me.PettycashBindingSource.DataMember = "petty_cash"
        Me.PettycashBindingSource.DataSource = Me.DsPetyCash
        '
        'DsPetyCash
        '
        Me.DsPetyCash.DataSetName = "dsPetyCash"
        Me.DsPetyCash.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colposdate, Me.colpcrem, Me.colpcamnt, Me.colcashier})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "pcamnt", Me.colpcamnt, "SUM={0:N2}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colpcrem, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colposdate
        '
        Me.colposdate.Caption = "Date"
        Me.colposdate.FieldName = "posdate"
        Me.colposdate.Name = "colposdate"
        Me.colposdate.Visible = True
        Me.colposdate.VisibleIndex = 0
        '
        'colpcrem
        '
        Me.colpcrem.Caption = "Remark"
        Me.colpcrem.FieldName = "pcrem"
        Me.colpcrem.Name = "colpcrem"
        Me.colpcrem.Visible = True
        Me.colpcrem.VisibleIndex = 1
        '
        'colpcamnt
        '
        Me.colpcamnt.AppearanceHeader.Options.UseTextOptions = True
        Me.colpcamnt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colpcamnt.Caption = "Amount"
        Me.colpcamnt.DisplayFormat.FormatString = "N2"
        Me.colpcamnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colpcamnt.FieldName = "pcamnt"
        Me.colpcamnt.Name = "colpcamnt"
        Me.colpcamnt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "pcamnt", "SUM={0:N2}")})
        Me.colpcamnt.Visible = True
        Me.colpcamnt.VisibleIndex = 2
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
        'Petty_cashTableAdapter
        '
        Me.Petty_cashTableAdapter.ClearBeforeFill = True
        '
        'frmPtyCashGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 480)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmPtyCashGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Petty Cash"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PettycashBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPetyCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsPetyCash As DoorsPOS.WinApp.dsPetyCash
    Friend WithEvents PettycashBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Petty_cashTableAdapter As DoorsPOS.WinApp.dsPetyCashTableAdapters.petty_cashTableAdapter
    Friend WithEvents colposdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpcrem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpcamnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcashier As DevExpress.XtraGrid.Columns.GridColumn
End Class
