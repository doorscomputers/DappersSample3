<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchItemsforRefunds
    Inherits System.Windows.Forms.Form
    Public Sub New()
        MyBase.New()
        DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Tahoma", 12.5)
        ' Track User Flag must be set here or it won't be set in time
        ' MyBase.UserTrack = False

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        ' This is done for apparent speed
        Dim ctlSelected As Control
        ctlSelected = PDSAForms.GetActiveMDIChildControl(Me)

        'Add any initialization after the InitializeComponent() call

        'MyBase.CheckSecurityOnControls = True
    End Sub

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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnButton1 = New System.Windows.Forms.Button()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.txtItem = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.gridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1167, 381)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'gridView1
        '
        Me.gridView1.Appearance.FilterPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridView1.Appearance.FilterPanel.Options.UseFont = True
        Me.gridView1.GridControl = Me.GridControl1
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsView.ShowAutoFilterRow = True
        Me.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways
        '
        'btnButton1
        '
        Me.btnButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton1.Location = New System.Drawing.Point(1050, 0)
        Me.btnButton1.Name = "btnButton1"
        Me.btnButton1.Size = New System.Drawing.Size(105, 26)
        Me.btnButton1.TabIndex = 1
        Me.btnButton1.Text = "&Search"
        Me.btnButton1.UseVisualStyleBackColor = True
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel1.Location = New System.Drawing.Point(620, 6)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(114, 20)
        Me.lblLabel1.TabIndex = 3
        Me.lblLabel1.Text = "Item to Search"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(740, 0)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtItem.Properties.Appearance.Options.UseFont = True
        Me.txtItem.Size = New System.Drawing.Size(293, 26)
        Me.txtItem.TabIndex = 0
        '
        'frmSearchItemsforRefunds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 381)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.btnButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmSearchItemsforRefunds"
        Me.Text = "Search Items for Refunds"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnButton1 As System.Windows.Forms.Button
    Friend WithEvents lblLabel1 As System.Windows.Forms.Label
    Friend WithEvents txtItem As DevExpress.XtraEditors.TextEdit
End Class
