<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferStock
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.stckid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiryDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dscamnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgitems = New System.Windows.Forms.DataGridView()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
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
        Me.GroupControl1.Location = New System.Drawing.Point(-4, -27)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(967, 109)
        Me.GroupControl1.TabIndex = 46
        Me.GroupControl1.Text = "Delivery Header"
        '
        'txtbcodes
        '
        Me.txtbcodes.Enabled = False
        Me.txtbcodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbcodes.Location = New System.Drawing.Point(748, 34)
        Me.txtbcodes.MaxLength = 22
        Me.txtbcodes.Name = "txtbcodes"
        Me.txtbcodes.Size = New System.Drawing.Size(94, 29)
        Me.txtbcodes.TabIndex = 63
        Me.txtbcodes.Visible = False
        '
        'leLocation
        '
        Me.leLocation.Location = New System.Drawing.Point(342, 37)
        Me.leLocation.Name = "leLocation"
        Me.leLocation.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leLocation.Properties.Appearance.Options.UseFont = True
        Me.leLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leLocation.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("locid", "locid", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("location", "Location", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.leLocation.Size = New System.Drawing.Size(354, 26)
        Me.leLocation.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 44)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(113, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Date Transfered"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(92, 85)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(33, 19)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Item"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(710, 85)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(34, 19)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "Price"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(601, 85)
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
        Me.LabelControl2.Location = New System.Drawing.Point(258, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(78, 19)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Transfer to"
        '
        'btnItemSearch
        '
        Me.btnItemSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnItemSearch.Appearance.Options.UseFont = True
        Me.btnItemSearch.Location = New System.Drawing.Point(532, 79)
        Me.btnItemSearch.Name = "btnItemSearch"
        Me.btnItemSearch.Size = New System.Drawing.Size(27, 25)
        Me.btnItemSearch.TabIndex = 4
        Me.btnItemSearch.Text = "&I..."
        Me.btnItemSearch.ToolTip = "Click this bvutton to search for items OR Press Alt+I"
        '
        'txtItem
        '
        Me.txtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtItem.Location = New System.Drawing.Point(131, 78)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(398, 26)
        Me.txtItem.TabIndex = 3
        Me.txtItem.TabStop = False
        '
        'dedlvrydate
        '
        Me.dedlvrydate.EditValue = Nothing
        Me.dedlvrydate.EnterMoveNextControl = True
        Me.dedlvrydate.Location = New System.Drawing.Point(131, 37)
        Me.dedlvrydate.Name = "dedlvrydate"
        Me.dedlvrydate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.dedlvrydate.Properties.Appearance.Options.UseFont = True
        Me.dedlvrydate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedlvrydate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedlvrydate.Size = New System.Drawing.Size(107, 26)
        Me.dedlvrydate.TabIndex = 1
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
        Me.ceQty.Location = New System.Drawing.Point(632, 78)
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
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.Location = New System.Drawing.Point(875, 81)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.ToolTip = "Add the item to the list"
        Me.btnAdd.Visible = False
        '
        'ceCost
        '
        Me.ceCost.EnterMoveNextControl = True
        Me.ceCost.Location = New System.Drawing.Point(748, 78)
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
        Me.txtsum.Location = New System.Drawing.Point(774, 504)
        Me.txtsum.Name = "txtsum"
        Me.txtsum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsum.Size = New System.Drawing.Size(189, 29)
        Me.txtsum.TabIndex = 43
        Me.txtsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnRetrieve.Appearance.Options.UseFont = True
        Me.btnRetrieve.Enabled = False
        Me.btnRetrieve.Location = New System.Drawing.Point(483, 501)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(102, 32)
        Me.btnRetrieve.TabIndex = 38
        Me.btnRetrieve.Text = "&Retrieve"
        Me.btnRetrieve.ToolTip = "Retrieve a list of uncompleted delivery entry"
        Me.btnRetrieve.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.Location = New System.Drawing.Point(1, 501)
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
        Me.btnSave.Location = New System.Drawing.Point(362, 501)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 32)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "&Save"
        Me.btnSave.ToolTip = "Save the List for later modification"
        Me.btnSave.Visible = False
        '
        'btnPost
        '
        Me.btnPost.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnPost.Appearance.Options.UseFont = True
        Me.btnPost.Enabled = False
        Me.btnPost.Location = New System.Drawing.Point(119, 501)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(102, 32)
        Me.btnPost.TabIndex = 41
        Me.btnPost.Text = "&Post"
        Me.btnPost.ToolTip = "Click this button to update the inventory and the Balance per supplier"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(717, 514)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl10.TabIndex = 36
        Me.LabelControl10.Text = "TOTAL"
        '
        'drgrid
        '
        Me.drgrid.AllowUserToAddRows = False
        Me.drgrid.AllowUserToDeleteRows = False
        Me.drgrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.drgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.drgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stckid, Me.Item, Me.Qty, Me.Price, Me.Amount, Me.ExpiryDate, Me.LotNo, Me.disc, Me.dscamnt})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.drgrid.DefaultCellStyle = DataGridViewCellStyle7
        Me.drgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.drgrid.Location = New System.Drawing.Point(-3, 87)
        Me.drgrid.MultiSelect = False
        Me.drgrid.Name = "drgrid"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.drgrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drgrid.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.drgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.drgrid.Size = New System.Drawing.Size(966, 408)
        Me.drgrid.TabIndex = 37
        '
        'stckid
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stckid.DefaultCellStyle = DataGridViewCellStyle2
        Me.stckid.HeaderText = "StockID"
        Me.stckid.Name = "stckid"
        Me.stckid.Visible = False
        Me.stckid.Width = 5
        '
        'Item
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item.DefaultCellStyle = DataGridViewCellStyle3
        Me.Item.HeaderText = "Item Description"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 400
        '
        'Qty
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle4
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        '
        'Price
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.Price.DefaultCellStyle = DataGridViewCellStyle5
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 200
        '
        'Amount
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle6
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 200
        '
        'ExpiryDate
        '
        Me.ExpiryDate.HeaderText = "Expiry Date"
        Me.ExpiryDate.Name = "ExpiryDate"
        '
        'LotNo
        '
        Me.LotNo.HeaderText = "Lot No"
        Me.LotNo.Name = "LotNo"
        '
        'disc
        '
        Me.disc.HeaderText = "disc"
        Me.disc.Name = "disc"
        Me.disc.Visible = False
        '
        'dscamnt
        '
        Me.dscamnt.HeaderText = "dscamnt"
        Me.dscamnt.Name = "dscamnt"
        Me.dscamnt.Visible = False
        '
        'dgitems
        '
        Me.dgitems.AllowUserToAddRows = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgitems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgitems.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgitems.Location = New System.Drawing.Point(127, 83)
        Me.dgitems.Name = "dgitems"
        Me.dgitems.ReadOnly = True
        Me.dgitems.Size = New System.Drawing.Size(726, 450)
        Me.dgitems.TabIndex = 94
        Me.dgitems.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnRemove.Appearance.Options.UseFont = True
        Me.btnRemove.Location = New System.Drawing.Point(254, 550)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(102, 32)
        Me.btnRemove.TabIndex = 40
        Me.btnRemove.Text = "&Remove Item"
        Me.btnRemove.ToolTip = "Save the List for later modification"
        '
        'frmTransferStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 537)
        Me.Controls.Add(Me.dgitems)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtsum)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.drgrid)
        Me.Name = "frmTransferStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Stock Form"
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
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
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
    Friend WithEvents leLocation As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dgitems As System.Windows.Forms.DataGridView
    Friend WithEvents txtbcodes As System.Windows.Forms.TextBox
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents stckid As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents ExpiryDate As DataGridViewTextBoxColumn
    Friend WithEvents LotNo As DataGridViewTextBoxColumn
    Friend WithEvents disc As DataGridViewTextBoxColumn
    Friend WithEvents dscamnt As DataGridViewTextBoxColumn
End Class
