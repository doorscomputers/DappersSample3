<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvertStocks
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
        Me.txtStckId = New System.Windows.Forms.TextBox()
        Me.btnItemSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.ceQty = New DevExpress.XtraEditors.CalcEdit()
        Me.deBoDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cePcs = New DevExpress.XtraEditors.CalcEdit()
        Me.ceInner = New DevExpress.XtraEditors.CalcEdit()
        Me.txtstckid2 = New System.Windows.Forms.TextBox()
        Me.btnItemsearch2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtitem2 = New System.Windows.Forms.TextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter()
        Me.ceAvlbl = New DevExpress.XtraEditors.CalcEdit()
        CType(Me.ceQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deBoDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deBoDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cePcs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceInner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceAvlbl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStckId
        '
        Me.txtStckId.Location = New System.Drawing.Point(538, 73)
        Me.txtStckId.Name = "txtStckId"
        Me.txtStckId.Size = New System.Drawing.Size(100, 20)
        Me.txtStckId.TabIndex = 21
        Me.txtStckId.Visible = False
        '
        'btnItemSearch
        '
        Me.btnItemSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnItemSearch.Appearance.Options.UseFont = True
        Me.btnItemSearch.Location = New System.Drawing.Point(487, 72)
        Me.btnItemSearch.Name = "btnItemSearch"
        Me.btnItemSearch.Size = New System.Drawing.Size(27, 25)
        Me.btnItemSearch.TabIndex = 3
        Me.btnItemSearch.Text = "&I..."
        Me.btnItemSearch.ToolTip = "Click this bvutton to search for items OR Press Alt+I"
        '
        'txtItem
        '
        Me.txtItem.Enabled = False
        Me.txtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtItem.Location = New System.Drawing.Point(94, 73)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(389, 26)
        Me.txtItem.TabIndex = 19
        Me.txtItem.TabStop = False
        '
        'ceQty
        '
        Me.ceQty.EnterMoveNextControl = True
        Me.ceQty.Location = New System.Drawing.Point(94, 196)
        Me.ceQty.Name = "ceQty"
        Me.ceQty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceQty.Properties.Appearance.Options.UseFont = True
        Me.ceQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceQty.Size = New System.Drawing.Size(113, 26)
        Me.ceQty.TabIndex = 4
        '
        'deBoDate
        '
        Me.deBoDate.EditValue = Nothing
        Me.deBoDate.EnterMoveNextControl = True
        Me.deBoDate.Location = New System.Drawing.Point(92, 25)
        Me.deBoDate.Name = "deBoDate"
        Me.deBoDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.deBoDate.Properties.Appearance.Options.UseFont = True
        Me.deBoDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deBoDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deBoDate.Size = New System.Drawing.Size(152, 26)
        Me.deBoDate.TabIndex = 1
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl7.Location = New System.Drawing.Point(214, 203)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(204, 19)
        Me.LabelControl7.TabIndex = 8
        Me.LabelControl7.Text = "* Qty to be Converted to Pcs"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl6.Location = New System.Drawing.Point(26, 203)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(66, 19)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "Quantity:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl5.Location = New System.Drawing.Point(24, 78)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "I t e m 1:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl4.Location = New System.Drawing.Point(48, 32)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 19)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "Date:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.ceAvlbl)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.cePcs)
        Me.GroupControl1.Controls.Add(Me.ceInner)
        Me.GroupControl1.Controls.Add(Me.txtstckid2)
        Me.GroupControl1.Controls.Add(Me.btnItemsearch2)
        Me.GroupControl1.Controls.Add(Me.txtitem2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtStckId)
        Me.GroupControl1.Controls.Add(Me.btnItemSearch)
        Me.GroupControl1.Controls.Add(Me.txtItem)
        Me.GroupControl1.Controls.Add(Me.ceQty)
        Me.GroupControl1.Controls.Add(Me.deBoDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Enabled = False
        Me.GroupControl1.Location = New System.Drawing.Point(12, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(650, 284)
        Me.GroupControl1.TabIndex = 15
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl2.Location = New System.Drawing.Point(18, 161)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl2.TabIndex = 28
        Me.LabelControl2.Text = "Inner Qty:"
        '
        'cePcs
        '
        Me.cePcs.Enabled = False
        Me.cePcs.Location = New System.Drawing.Point(94, 239)
        Me.cePcs.Name = "cePcs"
        Me.cePcs.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.cePcs.Properties.Appearance.Options.UseFont = True
        Me.cePcs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cePcs.Size = New System.Drawing.Size(113, 26)
        Me.cePcs.TabIndex = 27
        Me.cePcs.TabStop = False
        '
        'ceInner
        '
        Me.ceInner.Enabled = False
        Me.ceInner.Location = New System.Drawing.Point(94, 154)
        Me.ceInner.Name = "ceInner"
        Me.ceInner.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceInner.Properties.Appearance.Options.UseFont = True
        Me.ceInner.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceInner.Size = New System.Drawing.Size(113, 26)
        Me.ceInner.TabIndex = 26
        Me.ceInner.TabStop = False
        '
        'txtstckid2
        '
        Me.txtstckid2.Location = New System.Drawing.Point(538, 121)
        Me.txtstckid2.Name = "txtstckid2"
        Me.txtstckid2.Size = New System.Drawing.Size(100, 20)
        Me.txtstckid2.TabIndex = 25
        Me.txtstckid2.Visible = False
        '
        'btnItemsearch2
        '
        Me.btnItemsearch2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnItemsearch2.Appearance.Options.UseFont = True
        Me.btnItemsearch2.Location = New System.Drawing.Point(487, 113)
        Me.btnItemsearch2.Name = "btnItemsearch2"
        Me.btnItemsearch2.Size = New System.Drawing.Size(27, 25)
        Me.btnItemsearch2.TabIndex = 24
        Me.btnItemsearch2.Text = "&I..."
        Me.btnItemsearch2.ToolTip = "Click this bvutton to search for items OR Press Alt+I"
        '
        'txtitem2
        '
        Me.txtitem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitem2.Location = New System.Drawing.Point(94, 112)
        Me.txtitem2.Name = "txtitem2"
        Me.txtitem2.Size = New System.Drawing.Size(389, 26)
        Me.txtitem2.TabIndex = 23
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(24, 119)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl1.TabIndex = 22
        Me.LabelControl1.Text = "I t e m 2:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl3.Location = New System.Drawing.Point(45, 246)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Pieces:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(562, 305)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(95, 29)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "C&lose"
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(244, 305)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 29)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "&Cancel"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(133, 305)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 29)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "&Save"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(20, 305)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(95, 29)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "&New"
        '
        'ceAvlbl
        '
        Me.ceAvlbl.Location = New System.Drawing.Point(538, 163)
        Me.ceAvlbl.Name = "ceAvlbl"
        Me.ceAvlbl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceAvlbl.Size = New System.Drawing.Size(100, 20)
        Me.ceAvlbl.TabIndex = 29
        Me.ceAvlbl.Visible = False
        '
        'frmConvertStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 348)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConvertStocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Convert Stocks to Pieces Entry Form"
        CType(Me.ceQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deBoDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deBoDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cePcs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceInner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceAvlbl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtStckId As System.Windows.Forms.TextBox
    Friend WithEvents btnItemSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents ceQty As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents deBoDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtstckid2 As System.Windows.Forms.TextBox
    Friend WithEvents btnItemsearch2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtitem2 As System.Windows.Forms.TextBox
    Friend WithEvents cePcs As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceInner As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ceAvlbl As DevExpress.XtraEditors.CalcEdit
End Class
