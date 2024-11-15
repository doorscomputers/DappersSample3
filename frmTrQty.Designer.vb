<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrQty
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
        Me.ceTrQty = New DevExpress.XtraEditors.CalcEdit()
        CType(Me.ceTrQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ceTrQty
        '
        Me.ceTrQty.Location = New System.Drawing.Point(12, 34)
        Me.ceTrQty.Name = "ceTrQty"
        Me.ceTrQty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 80.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ceTrQty.Properties.Appearance.Options.UseFont = True
        Me.ceTrQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceTrQty.Properties.DisplayFormat.FormatString = "N2"
        Me.ceTrQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ceTrQty.Size = New System.Drawing.Size(484, 136)
        Me.ceTrQty.TabIndex = 2
        '
        'frmTrQty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 205)
        Me.Controls.Add(Me.ceTrQty)
        Me.Name = "frmTrQty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Qty"
        CType(Me.ceTrQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ceTrQty As DevExpress.XtraEditors.CalcEdit
End Class
