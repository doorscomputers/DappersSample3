<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.ceTendered = New DevExpress.XtraEditors.CalcEdit()
        Me.txtTotAmnt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ceTendered.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtChange
        '
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtChange.Location = New System.Drawing.Point(326, 314)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(626, 116)
        Me.txtChange.TabIndex = 2
        Me.txtChange.TabStop = False
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ceTendered
        '
        Me.ceTendered.Location = New System.Drawing.Point(326, 169)
        Me.ceTendered.Name = "ceTendered"
        Me.ceTendered.Properties.AllowMouseWheel = False
        Me.ceTendered.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceTendered.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.ceTendered.Properties.Appearance.Options.UseFont = True
        Me.ceTendered.Properties.Appearance.Options.UseForeColor = True
        Me.ceTendered.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceTendered.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.Z))
        Me.ceTendered.Properties.DisplayFormat.FormatString = "N2"
        Me.ceTendered.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ceTendered.Properties.EditFormat.FormatString = "N2"
        Me.ceTendered.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ceTendered.Properties.Mask.BeepOnError = True
        Me.ceTendered.Properties.Mask.EditMask = "n2"
        Me.ceTendered.Size = New System.Drawing.Size(626, 114)
        Me.ceTendered.TabIndex = 0
        '
        'txtTotAmnt
        '
        Me.txtTotAmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotAmnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotAmnt.Location = New System.Drawing.Point(326, 25)
        Me.txtTotAmnt.Name = "txtTotAmnt"
        Me.txtTotAmnt.ReadOnly = True
        Me.txtTotAmnt.Size = New System.Drawing.Size(626, 116)
        Me.txtTotAmnt.TabIndex = 1
        Me.txtTotAmnt.TabStop = False
        Me.txtTotAmnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(172, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 39)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Change"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(16, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(293, 39)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Amount Tendered"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(86, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 39)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Amount"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 446)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(86, 47)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "100 (F1)"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(104, 446)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(86, 47)
        Me.SimpleButton2.TabIndex = 10
        Me.SimpleButton2.Text = "200 (F2)"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.Location = New System.Drawing.Point(196, 446)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(86, 47)
        Me.SimpleButton3.TabIndex = 11
        Me.SimpleButton3.Text = "300 (F3)"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Location = New System.Drawing.Point(288, 446)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(86, 47)
        Me.SimpleButton4.TabIndex = 12
        Me.SimpleButton4.Text = "400 (F4)"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.Location = New System.Drawing.Point(380, 446)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(86, 47)
        Me.SimpleButton5.TabIndex = 13
        Me.SimpleButton5.Text = "500 (F5)"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.Location = New System.Drawing.Point(472, 446)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(115, 47)
        Me.SimpleButton6.TabIndex = 14
        Me.SimpleButton6.Text = "600 (F6)"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.SimpleButton7.Appearance.Options.UseFont = True
        Me.SimpleButton7.Location = New System.Drawing.Point(593, 446)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(86, 47)
        Me.SimpleButton7.TabIndex = 15
        Me.SimpleButton7.Text = "700 (F7)"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.SimpleButton8.Appearance.Options.UseFont = True
        Me.SimpleButton8.Location = New System.Drawing.Point(685, 446)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(86, 47)
        Me.SimpleButton8.TabIndex = 16
        Me.SimpleButton8.Text = "800 (F8)"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.SimpleButton9.Appearance.Options.UseFont = True
        Me.SimpleButton9.Location = New System.Drawing.Point(777, 446)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(86, 47)
        Me.SimpleButton9.TabIndex = 17
        Me.SimpleButton9.Text = "900 (F9)"
        '
        'SimpleButton10
        '
        Me.SimpleButton10.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.SimpleButton10.Appearance.Options.UseFont = True
        Me.SimpleButton10.Location = New System.Drawing.Point(869, 446)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(126, 47)
        Me.SimpleButton10.TabIndex = 18
        Me.SimpleButton10.Text = "1,000 (F10)"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 513)
        Me.Controls.Add(Me.SimpleButton10)
        Me.Controls.Add(Me.SimpleButton9)
        Me.Controls.Add(Me.SimpleButton8)
        Me.Controls.Add(Me.SimpleButton7)
        Me.Controls.Add(Me.SimpleButton6)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.ceTendered)
        Me.Controls.Add(Me.txtTotAmnt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COLLECT PAYMENT"
        Me.TopMost = True
        CType(Me.ceTendered.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents ceTendered As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtTotAmnt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
End Class
