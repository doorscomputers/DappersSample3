<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPickup
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
        Me.txtremark = New DevExpress.XtraEditors.TextEdit()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.ceamount = New DevExpress.XtraEditors.CalcEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.custid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmiddlename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfirstname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.collastname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtrefno = New System.Windows.Forms.TextBox()
        Me.depaydate = New DevExpress.XtraEditors.DateEdit()
        CType(Me.txtremark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceamount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.depaydate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.depaydate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtremark
        '
        Me.txtremark.EnterMoveNextControl = True
        Me.txtremark.Location = New System.Drawing.Point(150, 82)
        Me.txtremark.Name = "txtremark"
        Me.txtremark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtremark.Properties.Appearance.Options.UseFont = True
        Me.txtremark.Size = New System.Drawing.Size(475, 26)
        Me.txtremark.TabIndex = 55
        '
        'btncancel
        '
        Me.btncancel.Enabled = False
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btncancel.Location = New System.Drawing.Point(331, 139)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(120, 33)
        Me.btncancel.TabIndex = 63
        Me.btncancel.Text = "Cance&l"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnsave.Location = New System.Drawing.Point(180, 139)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(120, 33)
        Me.btnsave.TabIndex = 56
        Me.btnsave.Text = "Sa&ve"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Enabled = False
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnnew.Location = New System.Drawing.Point(29, 139)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(120, 33)
        Me.btnnew.TabIndex = 52
        Me.btnnew.Text = "&Get Cash"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnclose.Location = New System.Drawing.Point(504, 139)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(120, 33)
        Me.btnclose.TabIndex = 62
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'ceamount
        '
        Me.ceamount.EnterMoveNextControl = True
        Me.ceamount.Location = New System.Drawing.Point(150, 47)
        Me.ceamount.Name = "ceamount"
        Me.ceamount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceamount.Properties.Appearance.Options.UseFont = True
        Me.ceamount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceamount.Size = New System.Drawing.Size(150, 26)
        Me.ceamount.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(82, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Remark"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(2, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Amount Picked Up"
        '
        'custid
        '
        Me.custid.Caption = "custid"
        Me.custid.FieldName = "custid"
        Me.custid.Name = "custid"
        Me.custid.Width = 53
        '
        'colbalance
        '
        Me.colbalance.Caption = "Blalance"
        Me.colbalance.DisplayFormat.FormatString = "N2"
        Me.colbalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colbalance.FieldName = "balance"
        Me.colbalance.Name = "colbalance"
        Me.colbalance.Visible = True
        Me.colbalance.VisibleIndex = 3
        Me.colbalance.Width = 264
        '
        'colmiddlename
        '
        Me.colmiddlename.Caption = "Middle Name"
        Me.colmiddlename.FieldName = "middlename"
        Me.colmiddlename.Name = "colmiddlename"
        Me.colmiddlename.Visible = True
        Me.colmiddlename.VisibleIndex = 2
        Me.colmiddlename.Width = 249
        '
        'colfirstname
        '
        Me.colfirstname.Caption = "First Name"
        Me.colfirstname.FieldName = "firstname"
        Me.colfirstname.Name = "colfirstname"
        Me.colfirstname.Visible = True
        Me.colfirstname.VisibleIndex = 1
        Me.colfirstname.Width = 233
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(353, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Reference No."
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collastname, Me.colfirstname, Me.colmiddlename, Me.colbalance, Me.custid})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colbalance, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'collastname
        '
        Me.collastname.Caption = "Last Name"
        Me.collastname.FieldName = "lastname"
        Me.collastname.Name = "collastname"
        Me.collastname.Visible = True
        Me.collastname.VisibleIndex = 0
        Me.collastname.Width = 302
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(104, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Date"
        '
        'txtrefno
        '
        Me.txtrefno.Enabled = False
        Me.txtrefno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtrefno.Location = New System.Drawing.Point(475, 12)
        Me.txtrefno.Name = "txtrefno"
        Me.txtrefno.Size = New System.Drawing.Size(150, 26)
        Me.txtrefno.TabIndex = 61
        '
        'depaydate
        '
        Me.depaydate.EditValue = Nothing
        Me.depaydate.EnterMoveNextControl = True
        Me.depaydate.Location = New System.Drawing.Point(150, 12)
        Me.depaydate.Name = "depaydate"
        Me.depaydate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.depaydate.Properties.Appearance.Options.UseFont = True
        Me.depaydate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.depaydate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.depaydate.Size = New System.Drawing.Size(150, 26)
        Me.depaydate.TabIndex = 53
        '
        'frmPickup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 188)
        Me.Controls.Add(Me.txtremark)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.ceamount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtrefno)
        Me.Controls.Add(Me.depaydate)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPickup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Petty Cash Entry Form"
        CType(Me.txtremark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceamount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.depaydate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.depaydate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtremark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents ceamount As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents custid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmiddlename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents collastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtrefno As System.Windows.Forms.TextBox
    Friend WithEvents depaydate As DevExpress.XtraEditors.DateEdit
End Class
