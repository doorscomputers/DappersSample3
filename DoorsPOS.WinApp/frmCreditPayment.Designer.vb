<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreditPayment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.depaydate = New DevExpress.XtraEditors.DateEdit()
        Me.txtrefno = New System.Windows.Forms.TextBox()
        Me.ceamount = New DevExpress.XtraEditors.CalcEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.txtlast = New System.Windows.Forms.TextBox()
        Me.txtfirst = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.MemberBalanceBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsMemberBalance = New DoorsPOS.WinApp.dsMemberBalance()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.collastname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfirstname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmiddlename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.custid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MemberBalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsBalance = New DoorsPOS.WinApp.dsBalance()
        Me.MemberBalanceTableAdapter = New DoorsPOS.WinApp.dsBalanceTableAdapters.MemberBalanceTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cebalance = New DevExpress.XtraEditors.CalcEdit()
        Me.txtacntname = New DevExpress.XtraEditors.TextEdit()
        Me.txtbank = New DevExpress.XtraEditors.TextEdit()
        Me.txtcheque = New DevExpress.XtraEditors.TextEdit()
        Me.MemberBalanceTableAdapter1 = New DoorsPOS.WinApp.dsMemberBalanceTableAdapters.MemberBalanceTableAdapter()
        CType(Me.depaydate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.depaydate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceamount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBalanceBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMemberBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cebalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtacntname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(83, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Reference No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(62, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(32, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cheque No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(9, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Account Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(81, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Bank"
        '
        'depaydate
        '
        Me.depaydate.EditValue = Nothing
        Me.depaydate.EnterMoveNextControl = True
        Me.depaydate.Location = New System.Drawing.Point(134, 77)
        Me.depaydate.Name = "depaydate"
        Me.depaydate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.depaydate.Properties.Appearance.Options.UseFont = True
        Me.depaydate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.depaydate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.depaydate.Size = New System.Drawing.Size(150, 26)
        Me.depaydate.TabIndex = 2
        '
        'txtrefno
        '
        Me.txtrefno.Enabled = False
        Me.txtrefno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtrefno.Location = New System.Drawing.Point(134, 112)
        Me.txtrefno.Name = "txtrefno"
        Me.txtrefno.Size = New System.Drawing.Size(150, 26)
        Me.txtrefno.TabIndex = 2
        '
        'ceamount
        '
        Me.ceamount.EnterMoveNextControl = True
        Me.ceamount.Location = New System.Drawing.Point(134, 147)
        Me.ceamount.Name = "ceamount"
        Me.ceamount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceamount.Properties.Appearance.Options.UseFont = True
        Me.ceamount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceamount.Properties.Mask.BeepOnError = True
        Me.ceamount.Properties.Mask.EditMask = "n2"
        Me.ceamount.Size = New System.Drawing.Size(150, 26)
        Me.ceamount.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label7.Location = New System.Drawing.Point(46, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Customer"
        '
        'txtcustid
        '
        Me.txtcustid.Enabled = False
        Me.txtcustid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtcustid.Location = New System.Drawing.Point(134, 36)
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.Size = New System.Drawing.Size(85, 26)
        Me.txtcustid.TabIndex = 10
        '
        'txtlast
        '
        Me.txtlast.Enabled = False
        Me.txtlast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtlast.Location = New System.Drawing.Point(234, 36)
        Me.txtlast.Name = "txtlast"
        Me.txtlast.Size = New System.Drawing.Size(199, 26)
        Me.txtlast.TabIndex = 11
        '
        'txtfirst
        '
        Me.txtfirst.Enabled = False
        Me.txtfirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtfirst.Location = New System.Drawing.Point(450, 36)
        Me.txtfirst.Name = "txtfirst"
        Me.txtfirst.Size = New System.Drawing.Size(199, 26)
        Me.txtfirst.TabIndex = 12
        '
        'btnsearch
        '
        Me.btnsearch.Enabled = False
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnsearch.Location = New System.Drawing.Point(666, 36)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(120, 26)
        Me.btnsearch.TabIndex = 1
        Me.btnsearch.Text = "&Search Customer"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnclose.Location = New System.Drawing.Point(666, 296)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(120, 33)
        Me.btnclose.TabIndex = 8
        Me.btnclose.Text = "&Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnnew.Location = New System.Drawing.Point(36, 296)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(120, 33)
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "&New Payment"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Enabled = False
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btnsave.Location = New System.Drawing.Point(188, 296)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(120, 33)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "Sa&ve"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Enabled = False
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.btncancel.Location = New System.Drawing.Point(348, 296)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(120, 33)
        Me.btncancel.TabIndex = 9
        Me.btncancel.Text = "Cance&l"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'gridControl1
        '
        Me.gridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.gridControl1.DataSource = Me.MemberBalanceBindingSource1
        Me.gridControl1.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.gridControl1.Enabled = False
        Me.gridControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.gridControl1.Location = New System.Drawing.Point(16, 32)
        Me.gridControl1.MainView = Me.GridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.Size = New System.Drawing.Size(774, 258)
        Me.gridControl1.TabIndex = 13
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.gridControl1.Visible = False
        '
        'MemberBalanceBindingSource1
        '
        Me.MemberBalanceBindingSource1.DataMember = "MemberBalance"
        Me.MemberBalanceBindingSource1.DataSource = Me.DsMemberBalance
        '
        'DsMemberBalance
        '
        Me.DsMemberBalance.DataSetName = "dsMemberBalance"
        Me.DsMemberBalance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collastname, Me.colfirstname, Me.colmiddlename, Me.colbalance, Me.custid})
        Me.GridView1.GridControl = Me.gridControl1
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
        'MemberBalanceBindingSource
        '
        Me.MemberBalanceBindingSource.DataMember = "MemberBalance"
        Me.MemberBalanceBindingSource.DataSource = Me.DsBalance
        '
        'DsBalance
        '
        Me.DsBalance.DataSetName = "dsBalance"
        Me.DsBalance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberBalanceTableAdapter
        '
        Me.MemberBalanceTableAdapter.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label8.Location = New System.Drawing.Point(130, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label9.Location = New System.Drawing.Point(230, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Last Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label10.Location = New System.Drawing.Point(447, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "First Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label11.Location = New System.Drawing.Point(363, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Balance"
        '
        'cebalance
        '
        Me.cebalance.Enabled = False
        Me.cebalance.Location = New System.Drawing.Point(451, 77)
        Me.cebalance.Name = "cebalance"
        Me.cebalance.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.cebalance.Properties.Appearance.Options.UseFont = True
        Me.cebalance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cebalance.Size = New System.Drawing.Size(150, 26)
        Me.cebalance.TabIndex = 3
        '
        'txtacntname
        '
        Me.txtacntname.EnterMoveNextControl = True
        Me.txtacntname.Location = New System.Drawing.Point(134, 182)
        Me.txtacntname.Name = "txtacntname"
        Me.txtacntname.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtacntname.Properties.Appearance.Options.UseFont = True
        Me.txtacntname.Size = New System.Drawing.Size(299, 26)
        Me.txtacntname.TabIndex = 4
        '
        'txtbank
        '
        Me.txtbank.EnterMoveNextControl = True
        Me.txtbank.Location = New System.Drawing.Point(134, 216)
        Me.txtbank.Name = "txtbank"
        Me.txtbank.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtbank.Properties.Appearance.Options.UseFont = True
        Me.txtbank.Size = New System.Drawing.Size(299, 26)
        Me.txtbank.TabIndex = 5
        '
        'txtcheque
        '
        Me.txtcheque.EnterMoveNextControl = True
        Me.txtcheque.Location = New System.Drawing.Point(134, 250)
        Me.txtcheque.Name = "txtcheque"
        Me.txtcheque.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtcheque.Properties.Appearance.Options.UseFont = True
        Me.txtcheque.Size = New System.Drawing.Size(299, 26)
        Me.txtcheque.TabIndex = 6
        '
        'MemberBalanceTableAdapter1
        '
        Me.MemberBalanceTableAdapter1.ClearBeforeFill = True
        '
        'frmCreditPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 347)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.txtcheque)
        Me.Controls.Add(Me.txtbank)
        Me.Controls.Add(Me.txtacntname)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.cebalance)
        Me.Controls.Add(Me.ceamount)
        Me.Controls.Add(Me.txtfirst)
        Me.Controls.Add(Me.txtlast)
        Me.Controls.Add(Me.txtcustid)
        Me.Controls.Add(Me.txtrefno)
        Me.Controls.Add(Me.depaydate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCreditPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credit Payment Form"
        CType(Me.depaydate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.depaydate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceamount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBalanceBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMemberBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cebalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtacntname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents depaydate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtrefno As System.Windows.Forms.TextBox
    Friend WithEvents ceamount As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcustid As System.Windows.Forms.TextBox
    Friend WithEvents txtlast As System.Windows.Forms.TextBox
    Friend WithEvents txtfirst As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsBalance As DoorsPOS.WinApp.dsBalance
    Friend WithEvents MemberBalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MemberBalanceTableAdapter As DoorsPOS.WinApp.dsBalanceTableAdapters.MemberBalanceTableAdapter
    Friend WithEvents collastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmiddlename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents custid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cebalance As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtacntname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtbank As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DsMemberBalance As DoorsPOS.WinApp.dsMemberBalance
    Friend WithEvents MemberBalanceBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MemberBalanceTableAdapter1 As DoorsPOS.WinApp.dsMemberBalanceTableAdapters.MemberBalanceTableAdapter
End Class
