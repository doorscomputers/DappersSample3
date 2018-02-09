<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIssueChk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIssueChk))
        Me.bankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsBank1 = New DoorsPOS.WinApp.dsBank()
        Me.BankTableAdapter1 = New DoorsPOS.WinApp.dsBankTableAdapters.bankTableAdapter()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.btmClose = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deDate = New DevExpress.XtraEditors.DateEdit()
        Me.ceBegCash = New DevExpress.XtraEditors.CalcEdit()
        Me.ceChequeNo = New DevExpress.XtraEditors.CalcEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPayee = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.bankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBank1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceBegCash.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceChequeNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPayee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bankBindingSource
        '
        Me.bankBindingSource.DataMember = "bank"
        Me.bankBindingSource.DataSource = Me.DsBank1
        Me.bankBindingSource.Sort = ""
        '
        'DsBank1
        '
        Me.DsBank1.DataSetName = "dsBank"
        Me.DsBank1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BankTableAdapter1
        '
        Me.BankTableAdapter1.ClearBeforeFill = True
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.EnterMoveNextControl = True
        Me.LookUpEdit1.Location = New System.Drawing.Point(121, 12)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpEdit1.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.DataSource = Me.DsBank1
        Me.LookUpEdit1.Properties.DisplayMember = "bank.accountno"
        Me.LookUpEdit1.Properties.ValueMember = "bank.bankid"
        Me.LookUpEdit1.Size = New System.Drawing.Size(498, 26)
        Me.LookUpEdit1.TabIndex = 0
        '
        'btmClose
        '
        Me.btmClose.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmClose.Appearance.Options.UseFont = True
        Me.btmClose.ImageOptions.Image = CType(resources.GetObject("btmClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btmClose.Location = New System.Drawing.Point(517, 254)
        Me.btmClose.Name = "btmClose"
        Me.btmClose.Size = New System.Drawing.Size(102, 35)
        Me.btmClose.TabIndex = 9
        Me.btmClose.Text = "E&xit"
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(376, 254)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 35)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Remarks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Payee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Cheque No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Cheque Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Date"
        '
        'deDate
        '
        Me.deDate.EditValue = Nothing
        Me.deDate.EnterMoveNextControl = True
        Me.deDate.Location = New System.Drawing.Point(121, 59)
        Me.deDate.Name = "deDate"
        Me.deDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deDate.Properties.Appearance.Options.UseFont = True
        Me.deDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDate.Size = New System.Drawing.Size(181, 26)
        Me.deDate.TabIndex = 1
        '
        'ceBegCash
        '
        Me.ceBegCash.EnterMoveNextControl = True
        Me.ceBegCash.Location = New System.Drawing.Point(329, 83)
        Me.ceBegCash.Name = "ceBegCash"
        Me.ceBegCash.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceBegCash.Properties.Appearance.Options.UseFont = True
        Me.ceBegCash.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceBegCash.Size = New System.Drawing.Size(290, 46)
        Me.ceBegCash.TabIndex = 3
        '
        'ceChequeNo
        '
        Me.ceChequeNo.EnterMoveNextControl = True
        Me.ceChequeNo.Location = New System.Drawing.Point(121, 103)
        Me.ceChequeNo.Name = "ceChequeNo"
        Me.ceChequeNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceChequeNo.Properties.Appearance.Options.UseFont = True
        Me.ceChequeNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceChequeNo.Size = New System.Drawing.Size(181, 26)
        Me.ceChequeNo.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(324, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Amount"
        '
        'txtPayee
        '
        Me.txtPayee.EnterMoveNextControl = True
        Me.txtPayee.Location = New System.Drawing.Point(121, 153)
        Me.txtPayee.Name = "txtPayee"
        Me.txtPayee.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayee.Properties.Appearance.Options.UseFont = True
        Me.txtPayee.Size = New System.Drawing.Size(498, 26)
        Me.txtPayee.TabIndex = 4
        '
        'txtRemarks
        '
        Me.txtRemarks.EnterMoveNextControl = True
        Me.txtRemarks.Location = New System.Drawing.Point(121, 197)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(498, 26)
        Me.txtRemarks.TabIndex = 5
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(15, 254)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(161, 35)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "&Clear Information"
        '
        'frmIssueChk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 299)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtPayee)
        Me.Controls.Add(Me.ceBegCash)
        Me.Controls.Add(Me.ceChequeNo)
        Me.Controls.Add(Me.deDate)
        Me.Controls.Add(Me.btmClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LookUpEdit1)
        Me.Name = "frmIssueChk"
        Me.Text = "Check Issuance"
        CType(Me.bankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBank1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceBegCash.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceChequeNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPayee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bankBindingSource As BindingSource
    Friend WithEvents DsBank1 As dsBank
    Friend WithEvents BankTableAdapter1 As dsBankTableAdapters.bankTableAdapter
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btmClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents deDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ceBegCash As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceChequeNo As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPayee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
