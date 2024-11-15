<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenses
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
        Me.ceAmount = New DevExpress.XtraEditors.CalcEdit()
        Me.leexpenses = New DevExpress.XtraEditors.LookUpEdit()
        Me.deexpDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ceAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leexpenses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deexpDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deexpDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ceAmount
        '
        Me.ceAmount.EnterMoveNextControl = True
        Me.ceAmount.Location = New System.Drawing.Point(121, 107)
        Me.ceAmount.Name = "ceAmount"
        Me.ceAmount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceAmount.Properties.Appearance.Options.UseFont = True
        Me.ceAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceAmount.Properties.DisplayFormat.FormatString = "N2"
        Me.ceAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ceAmount.Properties.EditFormat.FormatString = "N2"
        Me.ceAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ceAmount.Size = New System.Drawing.Size(113, 26)
        Me.ceAmount.TabIndex = 2
        '
        'leexpenses
        '
        Me.leexpenses.EnterMoveNextControl = True
        Me.leexpenses.Location = New System.Drawing.Point(121, 66)
        Me.leexpenses.Name = "leexpenses"
        Me.leexpenses.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leexpenses.Properties.Appearance.Options.UseFont = True
        Me.leexpenses.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leexpenses.Properties.AppearanceDropDown.Options.UseFont = True
        Me.leexpenses.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leexpenses.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.leexpenses.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leexpenses.Properties.AppearanceFocused.Options.UseFont = True
        Me.leexpenses.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.leexpenses.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leexpenses.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("expenseid", "expenseid", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("expdesc", "Kind")})
        Me.leexpenses.Properties.DropDownRows = 15
        Me.leexpenses.Properties.NullText = ""
        Me.leexpenses.Size = New System.Drawing.Size(318, 26)
        Me.leexpenses.TabIndex = 1
        Me.leexpenses.ToolTip = "Click the dropdown arrow to display suppliers list or type a few characters"
        '
        'deexpDate
        '
        Me.deexpDate.EditValue = Nothing
        Me.deexpDate.EnterMoveNextControl = True
        Me.deexpDate.Location = New System.Drawing.Point(121, 25)
        Me.deexpDate.Name = "deexpDate"
        Me.deexpDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.deexpDate.Properties.Appearance.Options.UseFont = True
        Me.deexpDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deexpDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deexpDate.Size = New System.Drawing.Size(113, 26)
        Me.deexpDate.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl6.Location = New System.Drawing.Point(52, 114)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "Amount:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl2.Location = New System.Drawing.Point(11, 73)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(104, 19)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "Expense Type:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(77, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 19)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Date:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtRemarks)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.ceAmount)
        Me.GroupControl1.Controls.Add(Me.leexpenses)
        Me.GroupControl1.Controls.Add(Me.deexpDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Enabled = False
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(547, 197)
        Me.GroupControl1.TabIndex = 15
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(121, 148)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(407, 26)
        Me.txtRemarks.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl3.Location = New System.Drawing.Point(52, 155)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 19)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Remark:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(464, 224)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(95, 29)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "C&lose"
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(237, 224)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 29)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "&Cancel"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(126, 224)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 29)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "&Save"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(13, 224)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(95, 29)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New"
        '
        'frmExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 270)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "frmExpenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Expenses Entry Form"
        CType(Me.ceAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leexpenses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deexpDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deexpDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ceAmount As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents leexpenses As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents deexpDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
