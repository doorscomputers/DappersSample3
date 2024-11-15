<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRefund
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
        Me.LayoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.ceAvlbl = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cePcs = New DevExpress.XtraEditors.CalcEdit()
        Me.ceInner = New DevExpress.XtraEditors.CalcEdit()
        Me.txtstckid2 = New System.Windows.Forms.TextBox()
        Me.btnItemsearch2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtitem2 = New System.Windows.Forms.TextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStckId = New System.Windows.Forms.TextBox()
        Me.btnItemSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.ceQty = New DevExpress.XtraEditors.CalcEdit()
        Me.deBoDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.leSupplier = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.ceAvlbl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cePcs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceInner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deBoDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deBoDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(596, 409)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(95, 29)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "C&lose"
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(278, 409)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 29)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "&Cancel"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(167, 409)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 29)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "&Save"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(54, 409)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(95, 29)
        Me.btnNew.TabIndex = 16
        Me.btnNew.Text = "&New"
        '
        'ceAvlbl
        '
        Me.ceAvlbl.Location = New System.Drawing.Point(536, 244)
        Me.ceAvlbl.Name = "ceAvlbl"
        Me.ceAvlbl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceAvlbl.Size = New System.Drawing.Size(100, 20)
        Me.ceAvlbl.TabIndex = 29
        Me.ceAvlbl.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(16, 242)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl2.TabIndex = 28
        Me.LabelControl2.Text = "Inner Qty:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.leSupplier)
        Me.GroupControl1.Controls.Add(Me.ComboBoxEdit1)
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
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Enabled = False
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(679, 378)
        Me.GroupControl1.TabIndex = 20
        '
        'cePcs
        '
        Me.cePcs.Enabled = False
        Me.cePcs.Location = New System.Drawing.Point(126, 320)
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
        Me.ceInner.Location = New System.Drawing.Point(126, 235)
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
        Me.txtstckid2.Location = New System.Drawing.Point(536, 202)
        Me.txtstckid2.Name = "txtstckid2"
        Me.txtstckid2.Size = New System.Drawing.Size(100, 21)
        Me.txtstckid2.TabIndex = 25
        Me.txtstckid2.Visible = False
        '
        'btnItemsearch2
        '
        Me.btnItemsearch2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnItemsearch2.Appearance.Options.UseFont = True
        Me.btnItemsearch2.Location = New System.Drawing.Point(485, 194)
        Me.btnItemsearch2.Name = "btnItemsearch2"
        Me.btnItemsearch2.Size = New System.Drawing.Size(27, 25)
        Me.btnItemsearch2.TabIndex = 24
        Me.btnItemsearch2.Text = "&I..."
        Me.btnItemsearch2.ToolTip = "Click this bvutton to search for items OR Press Alt+I"
        '
        'txtitem2
        '
        Me.txtitem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitem2.Location = New System.Drawing.Point(126, 193)
        Me.txtitem2.Name = "txtitem2"
        Me.txtitem2.Size = New System.Drawing.Size(389, 26)
        Me.txtitem2.TabIndex = 23
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(22, 200)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl1.TabIndex = 22
        Me.LabelControl1.Text = "I t e m 2:"
        '
        'txtStckId
        '
        Me.txtStckId.Location = New System.Drawing.Point(536, 154)
        Me.txtStckId.Name = "txtStckId"
        Me.txtStckId.Size = New System.Drawing.Size(100, 21)
        Me.txtStckId.TabIndex = 21
        Me.txtStckId.Visible = False
        '
        'btnItemSearch
        '
        Me.btnItemSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnItemSearch.Appearance.Options.UseFont = True
        Me.btnItemSearch.Location = New System.Drawing.Point(485, 153)
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
        Me.txtItem.Location = New System.Drawing.Point(126, 154)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(389, 26)
        Me.txtItem.TabIndex = 19
        Me.txtItem.TabStop = False
        '
        'ceQty
        '
        Me.ceQty.EnterMoveNextControl = True
        Me.ceQty.Location = New System.Drawing.Point(126, 277)
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
        Me.deBoDate.Location = New System.Drawing.Point(126, 25)
        Me.deBoDate.Name = "deBoDate"
        Me.deBoDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.deBoDate.Properties.Appearance.Options.UseFont = True
        Me.deBoDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deBoDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deBoDate.Size = New System.Drawing.Size(152, 26)
        Me.deBoDate.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(43, 327)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(49, 19)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Pieces:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(24, 284)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(66, 19)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "Quantity:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(22, 159)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "I t e m 1:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(48, 32)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 19)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "Date:"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(126, 70)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"RETAIL", "WHOLESALE"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(152, 26)
        Me.ComboBoxEdit1.TabIndex = 30
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(5, 73)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(116, 19)
        Me.LabelControl7.TabIndex = 13
        Me.LabelControl7.Text = "Retail/Wholesale"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(22, 111)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl8.TabIndex = 13
        Me.LabelControl8.Text = "Customer"
        '
        'leSupplier
        '
        Me.leSupplier.Location = New System.Drawing.Point(126, 108)
        Me.leSupplier.Name = "leSupplier"
        Me.leSupplier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leSupplier.Properties.Appearance.Options.UseFont = True
        Me.leSupplier.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leSupplier.Properties.AppearanceDropDown.Options.UseFont = True
        Me.leSupplier.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leSupplier.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.leSupplier.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leSupplier.Properties.AppearanceFocused.Options.UseFont = True
        Me.leSupplier.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.leSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSupplier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("supcode", "supcode", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("supplier", "supplier")})
        Me.leSupplier.Properties.DropDownRows = 15
        Me.leSupplier.Properties.NullText = ""
        Me.leSupplier.Size = New System.Drawing.Size(389, 26)
        Me.leSupplier.TabIndex = 31
        Me.leSupplier.ToolTip = "Click the dropdown arrow to display suppliers list or type a few characters"
        '
        'frmRefund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmRefund"
        Me.Text = "Refund Credit"
        CType(Me.ceAvlbl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cePcs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceInner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deBoDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deBoDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ceAvlbl As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cePcs As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceInner As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtstckid2 As TextBox
    Friend WithEvents btnItemsearch2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtitem2 As TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStckId As TextBox
    Friend WithEvents btnItemSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtItem As TextBox
    Friend WithEvents ceQty As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents deBoDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSupplier As DevExpress.XtraEditors.LookUpEdit
End Class
