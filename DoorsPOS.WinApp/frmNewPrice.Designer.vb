<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewPrice
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
        Me.cePrice = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.cePrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cePrice
        '
        Me.cePrice.Location = New System.Drawing.Point(25, 39)
        Me.cePrice.Name = "cePrice"
        Me.cePrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 80.25!)
        Me.cePrice.Properties.Appearance.Options.UseFont = True
        Me.cePrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cePrice.Properties.Mask.BeepOnError = True
        Me.cePrice.Properties.Mask.EditMask = "n"
        Me.cePrice.Properties.Precision = 8
        Me.cePrice.Size = New System.Drawing.Size(477, 136)
        Me.cePrice.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(25, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(151, 25)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Enter New Price"
        '
        'frmNewPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 213)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cePrice)
        Me.KeyPreview = True
        Me.Name = "frmNewPrice"
        Me.Text = "New Price"
        CType(Me.cePrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cePrice As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
