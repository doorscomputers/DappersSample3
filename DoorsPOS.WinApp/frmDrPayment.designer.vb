﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrPayment
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgPayment = New System.Windows.Forms.DataGridView()
        Me.drid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drbal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ledrs = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.ceAmount = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.txtChkNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtSupcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtbankid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.deDatePaid = New DevExpress.XtraEditors.DateEdit()
        Me.deChkDate = New DevExpress.XtraEditors.DateEdit()
        Me.ceAmntPd = New DevExpress.XtraEditors.CalcEdit()
        Me.leBank = New DevExpress.XtraEditors.LookUpEdit()
        Me.leSupplier = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.pd = New DevExpress.XtraEditors.CalcEdit()
        Me.cm = New DevExpress.XtraEditors.CalcEdit()
        Me.txtTotInv = New DevExpress.XtraEditors.CalcEdit()
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ledrs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChkNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbankid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDatePaid.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDatePaid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deChkDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deChkDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceAmntPd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leBank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.pd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotInv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPayment
        '
        Me.dgPayment.AllowUserToAddRows = False
        Me.dgPayment.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPayment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.drid, Me.drinv, Me.drbal})
        Me.dgPayment.Location = New System.Drawing.Point(1, 257)
        Me.dgPayment.MultiSelect = False
        Me.dgPayment.Name = "dgPayment"
        Me.dgPayment.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPayment.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgPayment.Size = New System.Drawing.Size(761, 204)
        Me.dgPayment.TabIndex = 5
        '
        'drid
        '
        Me.drid.HeaderText = "drid"
        Me.drid.Name = "drid"
        Me.drid.ReadOnly = True
        Me.drid.Visible = False
        '
        'drinv
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drinv.DefaultCellStyle = DataGridViewCellStyle2
        Me.drinv.HeaderText = "Invoice #"
        Me.drinv.Name = "drinv"
        Me.drinv.ReadOnly = True
        Me.drinv.Width = 150
        '
        'drbal
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.drbal.DefaultCellStyle = DataGridViewCellStyle3
        Me.drbal.HeaderText = "Balance"
        Me.drbal.Name = "drbal"
        Me.drbal.ReadOnly = True
        Me.drbal.Width = 150
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(8, 40)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(81, 19)
        Me.LabelControl8.TabIndex = 31
        Me.LabelControl8.Text = "Invoice No."
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.ledrs)
        Me.GroupControl1.Controls.Add(Me.btnAdd)
        Me.GroupControl1.Controls.Add(Me.ceAmount)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Enabled = False
        Me.GroupControl1.Location = New System.Drawing.Point(1, 175)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(760, 76)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Payment Invoices and Amount"
        '
        'ledrs
        '
        Me.ledrs.EnterMoveNextControl = True
        Me.ledrs.Location = New System.Drawing.Point(93, 33)
        Me.ledrs.Name = "ledrs"
        Me.ledrs.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ledrs.Properties.Appearance.Options.UseFont = True
        Me.ledrs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ledrs.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("drinv", "Invoice#"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("drdate", "Inv. Date"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("drdue", "Due Date"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("drbal", "Balance")})
        Me.ledrs.Size = New System.Drawing.Size(339, 26)
        Me.ledrs.TabIndex = 6
        Me.ledrs.ToolTip = "Select the Invoice # to be paid here."
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.Location = New System.Drawing.Point(676, 33)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 26)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.ToolTip = "Click Add to Add the Invoice and Paid AMount on the List"
        '
        'ceAmount
        '
        Me.ceAmount.Enabled = False
        Me.ceAmount.EnterMoveNextControl = True
        Me.ceAmount.Location = New System.Drawing.Point(536, 33)
        Me.ceAmount.Name = "ceAmount"
        Me.ceAmount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceAmount.Properties.Appearance.Options.UseFont = True
        Me.ceAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceAmount.Properties.EditFormat.FormatString = "N2"
        Me.ceAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ceAmount.Properties.Mask.BeepOnError = True
        Me.ceAmount.Properties.Mask.EditMask = "n2"
        Me.ceAmount.Size = New System.Drawing.Size(132, 26)
        Me.ceAmount.TabIndex = 8
        Me.ceAmount.ToolTip = "Type Amount Paid for the Invoice at the Left"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(438, 40)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(92, 19)
        Me.LabelControl9.TabIndex = 30
        Me.LabelControl9.Text = "Amount Paid"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(484, 532)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(92, 19)
        Me.LabelControl10.TabIndex = 1
        Me.LabelControl10.Text = "Total Invoice"
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.Location = New System.Drawing.Point(4, 467)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(92, 31)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "&New"
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(109, 467)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(92, 31)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(214, 467)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 31)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Cancel"
        '
        'txtChkNo
        '
        Me.txtChkNo.EnterMoveNextControl = True
        Me.txtChkNo.Location = New System.Drawing.Point(98, 72)
        Me.txtChkNo.Name = "txtChkNo"
        Me.txtChkNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtChkNo.Properties.Appearance.Options.UseFont = True
        Me.txtChkNo.Size = New System.Drawing.Size(187, 26)
        Me.txtChkNo.TabIndex = 3
        '
        'txtSupcode
        '
        Me.txtSupcode.EnterMoveNextControl = True
        Me.txtSupcode.Location = New System.Drawing.Point(171, 65)
        Me.txtSupcode.Name = "txtSupcode"
        Me.txtSupcode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtSupcode.Properties.Appearance.Options.UseFont = True
        Me.txtSupcode.Properties.MaxLength = 50
        Me.txtSupcode.Size = New System.Drawing.Size(185, 26)
        Me.txtSupcode.TabIndex = 0
        Me.txtSupcode.Visible = False
        '
        'txtbankid
        '
        Me.txtbankid.EnterMoveNextControl = True
        Me.txtbankid.Location = New System.Drawing.Point(541, 65)
        Me.txtbankid.Name = "txtbankid"
        Me.txtbankid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtbankid.Properties.Appearance.Options.UseFont = True
        Me.txtbankid.Properties.MaxLength = 50
        Me.txtbankid.Size = New System.Drawing.Size(185, 26)
        Me.txtbankid.TabIndex = 0
        Me.txtbankid.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(23, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Date Paid"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(541, 40)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(90, 19)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Cheque Date"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(7, 79)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(83, 19)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Cheque No."
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(331, 79)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(34, 19)
        Me.LabelControl7.TabIndex = 1
        Me.LabelControl7.Text = "Bank"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(32, 118)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl6.TabIndex = 1
        Me.LabelControl6.Text = "Supplier"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(233, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(133, 19)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Total Amount Paid"
        '
        'deDatePaid
        '
        Me.deDatePaid.EditValue = Nothing
        Me.deDatePaid.EnterMoveNextControl = True
        Me.deDatePaid.Location = New System.Drawing.Point(98, 33)
        Me.deDatePaid.Name = "deDatePaid"
        Me.deDatePaid.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.deDatePaid.Properties.Appearance.Options.UseFont = True
        Me.deDatePaid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDatePaid.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDatePaid.Size = New System.Drawing.Size(119, 26)
        Me.deDatePaid.TabIndex = 0
        '
        'deChkDate
        '
        Me.deChkDate.EditValue = Nothing
        Me.deChkDate.EnterMoveNextControl = True
        Me.deChkDate.Location = New System.Drawing.Point(637, 33)
        Me.deChkDate.Name = "deChkDate"
        Me.deChkDate.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.deChkDate.Properties.Appearance.Options.UseFont = True
        Me.deChkDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deChkDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deChkDate.Size = New System.Drawing.Size(119, 26)
        Me.deChkDate.TabIndex = 2
        '
        'ceAmntPd
        '
        Me.ceAmntPd.EnterMoveNextControl = True
        Me.ceAmntPd.Location = New System.Drawing.Point(372, 33)
        Me.ceAmntPd.Name = "ceAmntPd"
        Me.ceAmntPd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceAmntPd.Properties.Appearance.Options.UseFont = True
        Me.ceAmntPd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceAmntPd.Properties.DisplayFormat.FormatString = "N2"
        Me.ceAmntPd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ceAmntPd.Properties.Mask.BeepOnError = True
        Me.ceAmntPd.Properties.Mask.EditMask = "n2"
        Me.ceAmntPd.Size = New System.Drawing.Size(149, 26)
        Me.ceAmntPd.TabIndex = 1
        '
        'leBank
        '
        Me.leBank.EnterMoveNextControl = True
        Me.leBank.Location = New System.Drawing.Point(372, 72)
        Me.leBank.Name = "leBank"
        Me.leBank.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leBank.Properties.Appearance.Options.UseFont = True
        Me.leBank.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leBank.Properties.AppearanceDropDown.Options.UseFont = True
        Me.leBank.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leBank.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.leBank.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leBank.Properties.AppearanceFocused.Options.UseFont = True
        Me.leBank.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.leBank.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leBank.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bankid", "bankid", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bank", "Bank"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("accountno", "Account No.")})
        Me.leBank.Properties.DropDownRows = 8
        Me.leBank.Properties.NullText = ""
        Me.leBank.Size = New System.Drawing.Size(384, 26)
        Me.leBank.TabIndex = 4
        Me.leBank.ToolTip = "Select the Bank name by lclicking the dropdown arrow or by typing some characters" &
    ""
        '
        'leSupplier
        '
        Me.leSupplier.Location = New System.Drawing.Point(98, 111)
        Me.leSupplier.Name = "leSupplier"
        Me.leSupplier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leSupplier.Properties.Appearance.Options.UseFont = True
        Me.leSupplier.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leSupplier.Properties.AppearanceDropDown.Options.UseFont = True
        Me.leSupplier.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leSupplier.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.leSupplier.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leSupplier.Properties.AppearanceFocused.Options.UseFont = True
        Me.leSupplier.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.leSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSupplier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("supcode", "supcode", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("supplier", "supplier")})
        Me.leSupplier.Properties.DropDownRows = 15
        Me.leSupplier.Properties.NullText = ""
        Me.leSupplier.Size = New System.Drawing.Size(654, 26)
        Me.leSupplier.TabIndex = 5
        Me.leSupplier.ToolTip = "Click the dropdown arrow to display suppliers list or type a few characters"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.deDatePaid)
        Me.GroupControl2.Controls.Add(Me.txtChkNo)
        Me.GroupControl2.Controls.Add(Me.txtSupcode)
        Me.GroupControl2.Controls.Add(Me.txtbankid)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.leSupplier)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.leBank)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.ceAmntPd)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.deChkDate)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Location = New System.Drawing.Point(-1, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(761, 167)
        Me.GroupControl2.TabIndex = 10
        Me.GroupControl2.Text = "Payment Header"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(458, 474)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(118, 19)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Percent Discount"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(406, 503)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(170, 19)
        Me.LabelControl11.TabIndex = 11
        Me.LabelControl11.Text = "CM or Discount Amount"
        '
        'pd
        '
        Me.pd.EnterMoveNextControl = True
        Me.pd.Location = New System.Drawing.Point(587, 467)
        Me.pd.Name = "pd"
        Me.pd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.pd.Properties.Appearance.Options.UseFont = True
        Me.pd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pd.Properties.EditFormat.FormatString = "N2"
        Me.pd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pd.Properties.Mask.BeepOnError = True
        Me.pd.Properties.Mask.EditMask = "n2"
        Me.pd.Size = New System.Drawing.Size(160, 26)
        Me.pd.TabIndex = 12
        Me.pd.ToolTip = "Type Amount Paid for the Invoice at the Left"
        '
        'cm
        '
        Me.cm.EnterMoveNextControl = True
        Me.cm.Location = New System.Drawing.Point(587, 496)
        Me.cm.Name = "cm"
        Me.cm.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.cm.Properties.Appearance.Options.UseFont = True
        Me.cm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cm.Properties.EditFormat.FormatString = "N2"
        Me.cm.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.cm.Properties.Mask.BeepOnError = True
        Me.cm.Properties.Mask.EditMask = "n2"
        Me.cm.Size = New System.Drawing.Size(160, 26)
        Me.cm.TabIndex = 13
        Me.cm.ToolTip = "Type Amount Paid for the Invoice at the Left"
        '
        'txtTotInv
        '
        Me.txtTotInv.EnterMoveNextControl = True
        Me.txtTotInv.Location = New System.Drawing.Point(587, 525)
        Me.txtTotInv.Name = "txtTotInv"
        Me.txtTotInv.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtTotInv.Properties.Appearance.Options.UseFont = True
        Me.txtTotInv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTotInv.Properties.EditFormat.FormatString = "N2"
        Me.txtTotInv.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotInv.Properties.Mask.BeepOnError = True
        Me.txtTotInv.Properties.Mask.EditMask = "n2"
        Me.txtTotInv.Size = New System.Drawing.Size(160, 26)
        Me.txtTotInv.TabIndex = 14
        Me.txtTotInv.ToolTip = "Type Amount Paid for the Invoice at the Left"
        '
        'frmDrPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 563)
        Me.Controls.Add(Me.txtTotInv)
        Me.Controls.Add(Me.cm)
        Me.Controls.Add(Me.pd)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.dgPayment)
        Me.Controls.Add(Me.LabelControl10)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDrPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Payment"
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.ledrs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChkNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbankid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDatePaid.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDatePaid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deChkDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deChkDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceAmntPd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leBank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.pd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotInv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgPayment As System.Windows.Forms.DataGridView
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ceAmount As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ledrs As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtChkNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSupcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtbankid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deDatePaid As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deChkDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ceAmntPd As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents leBank As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents leSupplier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents drid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents drinv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents drbal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pd As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents cm As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtTotInv As DevExpress.XtraEditors.CalcEdit
End Class