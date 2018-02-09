<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReadSum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReadSum))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.deDate = New DevExpress.XtraEditors.DateEdit()
        Me.cmbBranch = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbCashier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ceTotalSales = New DevExpress.XtraEditors.CalcEdit()
        Me.ceBegCash = New DevExpress.XtraEditors.CalcEdit()
        Me.ceCashEnd = New DevExpress.XtraEditors.CalcEdit()
        Me.ceShort = New DevExpress.XtraEditors.CalcEdit()
        Me.ceOver = New DevExpress.XtraEditors.CalcEdit()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btmClose = New DevExpress.XtraEditors.SimpleButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cepc = New DevExpress.XtraEditors.CalcEdit()
        Me.ceaf = New DevExpress.XtraEditors.CalcEdit()
        Me.ceri = New DevExpress.XtraEditors.CalcEdit()
        CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBranch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCashier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceTotalSales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceBegCash.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCashEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceShort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceOver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cepc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceaf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Branch"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cashier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Sales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Beg. Cash"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cash End"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Short"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 354)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Over"
        '
        'deDate
        '
        Me.deDate.EditValue = Nothing
        Me.deDate.EnterMoveNextControl = True
        Me.deDate.Location = New System.Drawing.Point(111, 25)
        Me.deDate.Name = "deDate"
        Me.deDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deDate.Properties.Appearance.Options.UseFont = True
        Me.deDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDate.Size = New System.Drawing.Size(181, 26)
        Me.deDate.TabIndex = 1
        '
        'cmbBranch
        '
        Me.cmbBranch.EnterMoveNextControl = True
        Me.cmbBranch.Location = New System.Drawing.Point(111, 72)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBranch.Properties.Appearance.Options.UseFont = True
        Me.cmbBranch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbBranch.Size = New System.Drawing.Size(237, 26)
        Me.cmbBranch.TabIndex = 2
        '
        'cmbCashier
        '
        Me.cmbCashier.EnterMoveNextControl = True
        Me.cmbCashier.Location = New System.Drawing.Point(111, 119)
        Me.cmbCashier.Name = "cmbCashier"
        Me.cmbCashier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCashier.Properties.Appearance.Options.UseFont = True
        Me.cmbCashier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCashier.Size = New System.Drawing.Size(237, 26)
        Me.cmbCashier.TabIndex = 3
        '
        'ceTotalSales
        '
        Me.ceTotalSales.EnterMoveNextControl = True
        Me.ceTotalSales.Location = New System.Drawing.Point(111, 166)
        Me.ceTotalSales.Name = "ceTotalSales"
        Me.ceTotalSales.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceTotalSales.Properties.Appearance.Options.UseFont = True
        Me.ceTotalSales.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceTotalSales.Size = New System.Drawing.Size(181, 26)
        Me.ceTotalSales.TabIndex = 4
        '
        'ceBegCash
        '
        Me.ceBegCash.EnterMoveNextControl = True
        Me.ceBegCash.Location = New System.Drawing.Point(111, 213)
        Me.ceBegCash.Name = "ceBegCash"
        Me.ceBegCash.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceBegCash.Properties.Appearance.Options.UseFont = True
        Me.ceBegCash.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceBegCash.Size = New System.Drawing.Size(181, 26)
        Me.ceBegCash.TabIndex = 5
        '
        'ceCashEnd
        '
        Me.ceCashEnd.EnterMoveNextControl = True
        Me.ceCashEnd.Location = New System.Drawing.Point(111, 259)
        Me.ceCashEnd.Name = "ceCashEnd"
        Me.ceCashEnd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceCashEnd.Properties.Appearance.Options.UseFont = True
        Me.ceCashEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceCashEnd.Size = New System.Drawing.Size(181, 26)
        Me.ceCashEnd.TabIndex = 6
        '
        'ceShort
        '
        Me.ceShort.EnterMoveNextControl = True
        Me.ceShort.Location = New System.Drawing.Point(111, 305)
        Me.ceShort.Name = "ceShort"
        Me.ceShort.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceShort.Properties.Appearance.Options.UseFont = True
        Me.ceShort.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceShort.Size = New System.Drawing.Size(181, 26)
        Me.ceShort.TabIndex = 7
        '
        'ceOver
        '
        Me.ceOver.EnterMoveNextControl = True
        Me.ceOver.Location = New System.Drawing.Point(111, 351)
        Me.ceOver.Name = "ceOver"
        Me.ceOver.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceOver.Properties.Appearance.Options.UseFont = True
        Me.ceOver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceOver.Size = New System.Drawing.Size(181, 26)
        Me.ceOver.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(63, 540)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 35)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "&Save"
        '
        'btmClose
        '
        Me.btmClose.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btmClose.Appearance.Options.UseFont = True
        Me.btmClose.ImageOptions.Image = CType(resources.GetObject("btmClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btmClose.Location = New System.Drawing.Point(204, 540)
        Me.btmClose.Name = "btmClose"
        Me.btmClose.Size = New System.Drawing.Size(102, 35)
        Me.btmClose.TabIndex = 13
        Me.btmClose.Text = "&Close"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 400)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Petty Cash"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 446)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Add Fund"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 492)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Remittance"
        '
        'cepc
        '
        Me.cepc.Location = New System.Drawing.Point(111, 397)
        Me.cepc.Name = "cepc"
        Me.cepc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cepc.Properties.Appearance.Options.UseFont = True
        Me.cepc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cepc.Size = New System.Drawing.Size(181, 26)
        Me.cepc.TabIndex = 14
        '
        'ceaf
        '
        Me.ceaf.Location = New System.Drawing.Point(111, 443)
        Me.ceaf.Name = "ceaf"
        Me.ceaf.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceaf.Properties.Appearance.Options.UseFont = True
        Me.ceaf.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceaf.Size = New System.Drawing.Size(181, 26)
        Me.ceaf.TabIndex = 15
        '
        'ceri
        '
        Me.ceri.Location = New System.Drawing.Point(111, 489)
        Me.ceri.Name = "ceri"
        Me.ceri.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceri.Properties.Appearance.Options.UseFont = True
        Me.ceri.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceri.Size = New System.Drawing.Size(181, 26)
        Me.ceri.TabIndex = 16
        '
        'frmReadSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 602)
        Me.Controls.Add(Me.ceri)
        Me.Controls.Add(Me.ceaf)
        Me.Controls.Add(Me.cepc)
        Me.Controls.Add(Me.btmClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ceOver)
        Me.Controls.Add(Me.ceShort)
        Me.Controls.Add(Me.ceCashEnd)
        Me.Controls.Add(Me.ceBegCash)
        Me.Controls.Add(Me.ceTotalSales)
        Me.Controls.Add(Me.cmbCashier)
        Me.Controls.Add(Me.cmbBranch)
        Me.Controls.Add(Me.deDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmReadSum"
        Me.Text = "Reading Summary Entry Form"
        CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBranch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCashier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceTotalSales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceBegCash.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCashEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceShort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceOver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cepc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceaf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents deDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbBranch As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbCashier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ceTotalSales As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceBegCash As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceCashEnd As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceShort As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceOver As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btmClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cepc As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceaf As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceri As DevExpress.XtraEditors.CalcEdit
End Class
