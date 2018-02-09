<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKellerman
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
        Me.btnButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnButton1
        '
        Me.btnButton1.Location = New System.Drawing.Point(58, 221)
        Me.btnButton1.Name = "btnButton1"
        Me.btnButton1.Size = New System.Drawing.Size(166, 28)
        Me.btnButton1.TabIndex = 0
        Me.btnButton1.Text = "Button1"
        Me.btnButton1.UseVisualStyleBackColor = True
        '
        'frmKellerman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnButton1)
        Me.Name = "frmKellerman"
        Me.Text = "frmKellerman"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnButton1 As System.Windows.Forms.Button
End Class
