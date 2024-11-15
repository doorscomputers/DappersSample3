<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTenderChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTenderChange))
        Me.ceTendered = New DevExpress.XtraEditors.CalcEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ceChange = New DevExpress.XtraEditors.CalcEdit()
        Me.ceTotal = New DevExpress.XtraEditors.CalcEdit()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.ceTendered.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceChange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ceTendered
        '
        Me.ceTendered.Enabled = False
        Me.ceTendered.Location = New System.Drawing.Point(319, 156)
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
        Me.ceTendered.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(165, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 39)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Change"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(9, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(293, 39)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Amount Tendered"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(79, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 39)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Total Amount"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(448, 438)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(124, 48)
        Me.SimpleButton1.TabIndex = 25
        Me.SimpleButton1.Text = "CLOSE"
        '
        'ceChange
        '
        Me.ceChange.Enabled = False
        Me.ceChange.Location = New System.Drawing.Point(319, 295)
        Me.ceChange.Name = "ceChange"
        Me.ceChange.Properties.AllowMouseWheel = False
        Me.ceChange.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceChange.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ceChange.Properties.Appearance.Options.UseFont = True
        Me.ceChange.Properties.Appearance.Options.UseForeColor = True
        Me.ceChange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceChange.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.Z))
        Me.ceChange.Properties.DisplayFormat.FormatString = "N2"
        Me.ceChange.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ceChange.Properties.EditFormat.FormatString = "N2"
        Me.ceChange.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ceChange.Properties.Mask.BeepOnError = True
        Me.ceChange.Properties.Mask.EditMask = "n2"
        Me.ceChange.Size = New System.Drawing.Size(626, 114)
        Me.ceChange.TabIndex = 19
        '
        'ceTotal
        '
        Me.ceTotal.Enabled = False
        Me.ceTotal.Location = New System.Drawing.Point(319, 22)
        Me.ceTotal.Name = "ceTotal"
        Me.ceTotal.Properties.AllowMouseWheel = False
        Me.ceTotal.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceTotal.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ceTotal.Properties.Appearance.Options.UseFont = True
        Me.ceTotal.Properties.Appearance.Options.UseForeColor = True
        Me.ceTotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceTotal.Properties.CloseUpKey = New DevExpress.Utils.KeyShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.Z))
        Me.ceTotal.Properties.DisplayFormat.FormatString = "N2"
        Me.ceTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ceTotal.Properties.EditFormat.FormatString = "N2"
        Me.ceTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ceTotal.Properties.Mask.BeepOnError = True
        Me.ceTotal.Properties.Mask.EditMask = "n2"
        Me.ceTotal.Size = New System.Drawing.Size(626, 114)
        Me.ceTotal.TabIndex = 19
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(578, 446)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(29, 31)
        Me.TextBox1.TabIndex = 26
        Me.TextBox1.Text = "5"
        Me.TextBox1.Visible = False
        '
        'frmTenderChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 498)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.ceChange)
        Me.Controls.Add(Me.ceTotal)
        Me.Controls.Add(Me.ceTendered)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmTenderChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TOTAL / TENDERED / CHANGE"
        CType(Me.ceTendered.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceChange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ceTendered As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ceChange As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceTotal As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
End Class
