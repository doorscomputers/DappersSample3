﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiveStokcs
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dscamnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiryDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stckid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtbcodes = New System.Windows.Forms.TextBox()
        Me.leLocation = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStckid = New System.Windows.Forms.TextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnItemSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.dedlvrydate = New DevExpress.XtraEditors.DateEdit()
        Me.cmbType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ceQty = New DevExpress.XtraEditors.CalcEdit()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.ceCost = New DevExpress.XtraEditors.CalcEdit()
        Me.txtsum = New System.Windows.Forms.TextBox()
        Me.btnRetrieve = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPost = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.drgrid = New System.Windows.Forms.DataGridView()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.dgitems = New System.Windows.Forms.DataGridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedlvrydate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedlvrydate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgitems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dscamnt
        '
        Me.dscamnt.HeaderText = "dscamnt"
        Me.dscamnt.Name = "dscamnt"
        Me.dscamnt.Visible = False
        '
        'LotNo
        '
        Me.LotNo.HeaderText = "Lot No"
        Me.LotNo.Name = "LotNo"
        Me.LotNo.Visible = False
        '
        'ExpiryDate
        '
        Me.ExpiryDate.HeaderText = "Expiry Date"
        Me.ExpiryDate.Name = "ExpiryDate"
        Me.ExpiryDate.Visible = False
        '
        'Amount
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle1
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 200
        '
        'Price
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Price.DefaultCellStyle = DataGridViewCellStyle2
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.Width = 200
        '
        'Qty
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle3
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        '
        'Item
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item.DefaultCellStyle = DataGridViewCellStyle4
        Me.Item.HeaderText = "Item Description"
        Me.Item.Name = "Item"
        Me.Item.Width = 400
        '
        'stckid
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stckid.DefaultCellStyle = DataGridViewCellStyle5
        Me.stckid.HeaderText = "StockID"
        Me.stckid.Name = "stckid"
        Me.stckid.Visible = False
        Me.stckid.Width = 5
        '
        'disc
        '
        Me.disc.HeaderText = "disc"
        Me.disc.Name = "disc"
        Me.disc.Visible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtbcodes)
        Me.GroupControl1.Controls.Add(Me.leLocation)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txtStckid)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.btnItemSearch)
        Me.GroupControl1.Controls.Add(Me.txtItem)
        Me.GroupControl1.Controls.Add(Me.dedlvrydate)
        Me.GroupControl1.Controls.Add(Me.cmbType)
        Me.GroupControl1.Controls.Add(Me.ceQty)
        Me.GroupControl1.Controls.Add(Me.btnAdd)
        Me.GroupControl1.Controls.Add(Me.ceCost)
        Me.GroupControl1.Enabled = False
        Me.GroupControl1.Location = New System.Drawing.Point(2, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(967, 109)
        Me.GroupControl1.TabIndex = 54
        '
        'txtbcodes
        '
        Me.txtbcodes.Enabled = False
        Me.txtbcodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbcodes.Location = New System.Drawing.Point(788, 31)
        Me.txtbcodes.MaxLength = 22
        Me.txtbcodes.Name = "txtbcodes"
        Me.txtbcodes.Size = New System.Drawing.Size(94, 29)
        Me.txtbcodes.TabIndex = 62
        Me.txtbcodes.Visible = False
        '
        'leLocation
        '
        Me.leLocation.Location = New System.Drawing.Point(374, 24)
        Me.leLocation.Name = "leLocation"
        Me.leLocation.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leLocation.Properties.Appearance.Options.UseFont = True
        Me.leLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leLocation.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("locid", "locid", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("location", "Location", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.leLocation.Size = New System.Drawing.Size(354, 26)
        Me.leLocation.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(26, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Date Received"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(92, 78)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(33, 19)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Item"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(710, 78)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(34, 19)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "Price"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(601, 78)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(25, 19)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "Qty"
        '
        'txtStckid
        '
        Me.txtStckid.Location = New System.Drawing.Point(20, 64)
        Me.txtStckid.Name = "txtStckid"
        Me.txtStckid.Size = New System.Drawing.Size(105, 21)
        Me.txtStckid.TabIndex = 14
        Me.txtStckid.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(263, 31)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(104, 19)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Received From"
        '
        'btnItemSearch
        '
        Me.btnItemSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnItemSearch.Appearance.Options.UseFont = True
        Me.btnItemSearch.Location = New System.Drawing.Point(562, 72)
        Me.btnItemSearch.Name = "btnItemSearch"
        Me.btnItemSearch.Size = New System.Drawing.Size(27, 25)
        Me.btnItemSearch.TabIndex = 3
        Me.btnItemSearch.Text = "&I..."
        Me.btnItemSearch.ToolTip = "Click this bvutton to search for items OR Press Alt+I"
        '
        'txtItem
        '
        Me.txtItem.Enabled = False
        Me.txtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtItem.Location = New System.Drawing.Point(131, 71)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(425, 26)
        Me.txtItem.TabIndex = 2
        Me.txtItem.TabStop = False
        '
        'dedlvrydate
        '
        Me.dedlvrydate.EditValue = Nothing
        Me.dedlvrydate.EnterMoveNextControl = True
        Me.dedlvrydate.Location = New System.Drawing.Point(131, 24)
        Me.dedlvrydate.Name = "dedlvrydate"
        Me.dedlvrydate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.dedlvrydate.Properties.Appearance.Options.UseFont = True
        Me.dedlvrydate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedlvrydate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedlvrydate.Size = New System.Drawing.Size(121, 26)
        Me.dedlvrydate.TabIndex = 0
        Me.dedlvrydate.ToolTip = "Date the Goods were delivered"
        '
        'cmbType
        '
        Me.cmbType.EnterMoveNextControl = True
        Me.cmbType.Location = New System.Drawing.Point(132, 64)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.cmbType.Properties.Appearance.Options.UseFont = True
        Me.cmbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbType.Properties.Items.AddRange(New Object() {"COD", "I.S.", "Consignment"})
        Me.cmbType.Size = New System.Drawing.Size(106, 26)
        Me.cmbType.TabIndex = 32
        Me.cmbType.ToolTip = "COD,IS or Consignment"
        Me.cmbType.Visible = False
        '
        'ceQty
        '
        Me.ceQty.EnterMoveNextControl = True
        Me.ceQty.Location = New System.Drawing.Point(632, 71)
        Me.ceQty.Name = "ceQty"
        Me.ceQty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceQty.Properties.Appearance.Options.UseFont = True
        Me.ceQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceQty.Size = New System.Drawing.Size(64, 26)
        Me.ceQty.TabIndex = 4
        Me.ceQty.ToolTip = "Qty Delivered by the supplier"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.Location = New System.Drawing.Point(875, 74)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.ToolTip = "Add the item to the list"
        '
        'ceCost
        '
        Me.ceCost.EnterMoveNextControl = True
        Me.ceCost.Location = New System.Drawing.Point(748, 71)
        Me.ceCost.Name = "ceCost"
        Me.ceCost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceCost.Properties.Appearance.Options.UseFont = True
        Me.ceCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceCost.Properties.Mask.BeepOnError = True
        Me.ceCost.Properties.Mask.EditMask = "n2"
        Me.ceCost.Size = New System.Drawing.Size(110, 26)
        Me.ceCost.TabIndex = 5
        Me.ceCost.TabStop = False
        Me.ceCost.ToolTip = "Cost of the item delivered"
        '
        'txtsum
        '
        Me.txtsum.Enabled = False
        Me.txtsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txtsum.Location = New System.Drawing.Point(780, 534)
        Me.txtsum.Name = "txtsum"
        Me.txtsum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsum.Size = New System.Drawing.Size(189, 29)
        Me.txtsum.TabIndex = 53
        Me.txtsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnRetrieve.Appearance.Options.UseFont = True
        Me.btnRetrieve.Enabled = False
        Me.btnRetrieve.Location = New System.Drawing.Point(489, 531)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(102, 32)
        Me.btnRetrieve.TabIndex = 49
        Me.btnRetrieve.Text = "&Retrieve"
        Me.btnRetrieve.ToolTip = "Retrieve a list of uncompleted delivery entry"
        Me.btnRetrieve.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.Location = New System.Drawing.Point(7, 531)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(102, 32)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New"
        Me.btnNew.ToolTip = "Click this to enter a new delivery."
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(364, 531)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 32)
        Me.btnSave.TabIndex = 51
        Me.btnSave.Text = "&Save"
        Me.btnSave.ToolTip = "Save the List for later modification"
        Me.btnSave.Visible = False
        '
        'btnPost
        '
        Me.btnPost.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnPost.Appearance.Options.UseFont = True
        Me.btnPost.Enabled = False
        Me.btnPost.Location = New System.Drawing.Point(125, 531)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(102, 32)
        Me.btnPost.TabIndex = 52
        Me.btnPost.Text = "&Post"
        Me.btnPost.ToolTip = "Click this button to update the inventory and the Balance per supplier"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(723, 544)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl10.TabIndex = 47
        Me.LabelControl10.Text = "TOTAL"
        '
        'drgrid
        '
        Me.drgrid.AllowUserToAddRows = False
        Me.drgrid.AllowUserToDeleteRows = False
        Me.drgrid.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.drgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.drgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stckid, Me.Item, Me.Qty, Me.Price, Me.Amount, Me.ExpiryDate, Me.LotNo, Me.disc, Me.dscamnt})
        Me.drgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.drgrid.Location = New System.Drawing.Point(3, 117)
        Me.drgrid.MultiSelect = False
        Me.drgrid.Name = "drgrid"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drgrid.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.drgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.drgrid.Size = New System.Drawing.Size(966, 408)
        Me.drgrid.TabIndex = 48
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'dgitems
        '
        Me.dgitems.AllowUserToAddRows = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgitems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgitems.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgitems.Location = New System.Drawing.Point(133, 102)
        Me.dgitems.Name = "dgitems"
        Me.dgitems.ReadOnly = True
        Me.dgitems.Size = New System.Drawing.Size(726, 461)
        Me.dgitems.TabIndex = 93
        Me.dgitems.Visible = False
        '
        'frmReceiveStokcs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 575)
        Me.Controls.Add(Me.dgitems)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtsum)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.drgrid)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReceiveStokcs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receive Stocks Form"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedlvrydate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedlvrydate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgitems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents dscamnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpiryDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stckid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents disc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents leLocation As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStckid As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnItemSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents dedlvrydate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ceQty As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ceCost As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtsum As System.Windows.Forms.TextBox
    Friend WithEvents btnRetrieve As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents drgrid As System.Windows.Forms.DataGridView
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents dgitems As System.Windows.Forms.DataGridView
    Friend WithEvents txtbcodes As System.Windows.Forms.TextBox
End Class
