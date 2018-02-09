<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesParam
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
        Me.dashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
        CType(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dashboardViewer1
        '
        Me.dashboardViewer1.DashboardSource = GetType(DoorsPOS.WinApp.Win_Dashboards.SaleswithParam)
        Me.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboardViewer1.Location = New System.Drawing.Point(0, 0)
        Me.dashboardViewer1.Name = "dashboardViewer1"
        Me.dashboardViewer1.PrintingOptions.DocumentContentOptions.FilterState = DevExpress.DashboardWin.DashboardPrintingFilterState.None
        Me.dashboardViewer1.PrintingOptions.FontInfo.GdiCharSet = CType(0, Byte)
        Me.dashboardViewer1.PrintingOptions.FontInfo.Name = Nothing
        Me.dashboardViewer1.Size = New System.Drawing.Size(661, 477)
        Me.dashboardViewer1.TabIndex = 0
        '
        'frmSalesParam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 477)
        Me.Controls.Add(Me.dashboardViewer1)
        Me.Name = "frmSalesParam"
        Me.Text = "frmSalesParam"
        CType(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
End Class
