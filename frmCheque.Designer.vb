<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheque
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
        Me.txtcheque = New DevExpress.XtraEditors.TextEdit()
        Me.txtacntname = New DevExpress.XtraEditors.TextEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.collastname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfirstname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmiddlename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.custid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtbank = New DevExpress.XtraEditors.TextEdit()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.ceamount = New DevExpress.XtraEditors.CalcEdit()
        Me.txtrefno = New System.Windows.Forms.TextBox()
        Me.depaydate = New DevExpress.XtraEditors.DateEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtremark = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.txtcheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtacntname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceamount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.depaydate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.depaydate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtremark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcheque
        '
        Me.txtcheque.EnterMoveNextControl = True
        Me.txtcheque.Location = New System.Drawing.Point(128, 153)
        Me.txtcheque.Name = "txtcheque"
        Me.txtcheque.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtcheque.Properties.Appearance.Options.UseFont = True
        Me.txtcheque.Size = New System.Drawing.Size(324, 26)
        Me.txtcheque.TabIndex = 5
        '
        'txtacntname
        '
        Me.txtacntname.EnterMoveNextControl = True
        Me.txtacntname.Location = New System.Drawing.Point(128, 85)
        Me.txtacntname.Name = "txtacntname"
        Me.txtacntname.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtacntname.Properties.Appearance.Options.UseFont = True
        Me.txtacntname.Size = New System.Drawing.Size(475, 26)
        Me.txtacntname.TabIndex = 3
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
        'colfirstname
        '
        Me.colfirstname.Caption = "First Name"
        Me.colfirstname.FieldName = "firstname"
        Me.colfirstname.Name = "colfirstname"
        Me.colfirstname.Visible = True
        Me.colfirstname.VisibleIndex = 1
        Me.colfirstname.Width = 233
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
        'custid
        '
        Me.custid.Caption = "custid"
        Me.custid.FieldName = "custid"
        Me.custid.Name = "custid"
        Me.custid.Width = 53
        '
        'txtbank
        '
        Me.txtbank.EnterMoveNextControl = True
        Me.txtbank.Location = New System.Drawing.Point(128, 120)
        Me.txtbank.Name = "txtbank"
        Me.txtbank.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtbank.Properties.Appearance.Options.UseFont = True
        Me.txtbank.Size = New System.Drawing.Size(475, 26)
        Me.txtbank.TabIndex = 4
        '
        'btncancel
        '
        Me.btncancel.Enabled = False
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btncancel.Location = New System.Drawing.Point(332, 241)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(120, 33)
        Me.btncancel.TabIndex = 35
        Me.btncancel.Text = "Cance&l"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnsave.Location = New System.Drawing.Point(181, 241)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(120, 33)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "Sa&ve"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Enabled = False
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnnew.Location = New System.Drawing.Point(30, 241)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(120, 33)
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "&New Payment"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnclose.Location = New System.Drawing.Point(483, 241)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(120, 33)
        Me.btnclose.TabIndex = 34
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'ceamount
        '
        Me.ceamount.EnterMoveNextControl = True
        Me.ceamount.Location = New System.Drawing.Point(128, 50)
        Me.ceamount.Name = "ceamount"
        Me.ceamount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceamount.Properties.Appearance.Options.UseFont = True
        Me.ceamount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceamount.Properties.Mask.BeepOnError = True
        Me.ceamount.Properties.Mask.EditMask = "n2"
        Me.ceamount.Size = New System.Drawing.Size(150, 26)
        Me.ceamount.TabIndex = 2
        '
        'txtrefno
        '
        Me.txtrefno.Enabled = False
        Me.txtrefno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtrefno.Location = New System.Drawing.Point(454, 15)
        Me.txtrefno.Name = "txtrefno"
        Me.txtrefno.Size = New System.Drawing.Size(150, 26)
        Me.txtrefno.TabIndex = 26
        '
        'depaydate
        '
        Me.depaydate.EditValue = Nothing
        Me.depaydate.EnterMoveNextControl = True
        Me.depaydate.Location = New System.Drawing.Point(128, 15)
        Me.depaydate.Name = "depaydate"
        Me.depaydate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.depaydate.Properties.Appearance.Options.UseFont = True
        Me.depaydate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.depaydate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.depaydate.Size = New System.Drawing.Size(150, 26)
        Me.depaydate.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(75, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Bank"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(3, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Account Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(26, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Cheque No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(56, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(332, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Reference No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(77, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Date"
        '
        'txtremark
        '
        Me.txtremark.EnterMoveNextControl = True
        Me.txtremark.Location = New System.Drawing.Point(128, 186)
        Me.txtremark.Name = "txtremark"
        Me.txtremark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtremark.Properties.Appearance.Options.UseFont = True
        Me.txtremark.Size = New System.Drawing.Size(475, 26)
        Me.txtremark.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label7.Location = New System.Drawing.Point(55, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Remark"
        '
        'frmCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 291)
        Me.Controls.Add(Me.txtcheque)
        Me.Controls.Add(Me.txtremark)
        Me.Controls.Add(Me.txtacntname)
        Me.Controls.Add(Me.txtbank)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.ceamount)
        Me.Controls.Add(Me.txtrefno)
        Me.Controls.Add(Me.depaydate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCheque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheque Payment Form"
        CType(Me.txtcheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtacntname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceamount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.depaydate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.depaydate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtremark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtacntname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents custid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmiddlename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtbank As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents ceamount As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtrefno As System.Windows.Forms.TextBox
    Friend WithEvents depaydate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtremark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
