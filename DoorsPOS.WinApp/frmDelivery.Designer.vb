<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelivery
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelivery))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dedlvrydate = New DevExpress.XtraEditors.DateEdit()
        Me.ceDays = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.deDue = New DevExpress.XtraEditors.DateEdit()
        Me.drgrid = New System.Windows.Forms.DataGridView()
        Me.stckid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Free = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Retail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiryDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dscamnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.ceQty = New DevExpress.XtraEditors.CalcEdit()
        Me.ceFree = New DevExpress.XtraEditors.CalcEdit()
        Me.ceCost = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPost = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRetrieve = New DevExpress.XtraEditors.SimpleButton()
        Me.txtsum = New System.Windows.Forms.TextBox()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.btnItemSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtStckid = New System.Windows.Forms.TextBox()
        Me.txtSupplier = New DevExpress.XtraEditors.TextEdit()
        Me.btnSupSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSupcode = New System.Windows.Forms.TextBox()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cediscamnt = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtGrand = New System.Windows.Forms.TextBox()
        Me.DGRetrieve = New System.Windows.Forms.DataGridView()
        Me.txtInv = New DevExpress.XtraEditors.TextEdit()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cePrice = New DevExpress.XtraEditors.CalcEdit()
        Me.leSupplier = New DevExpress.XtraEditors.LookUpEdit()
        Me.ceAmountDisc = New DevExpress.XtraEditors.CalcEdit()
        Me.cePrcentDisc = New DevExpress.XtraEditors.CalcEdit()
        Me.deExpDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtLotNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.btnNewSupplier = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddNew = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.dgitems = New System.Windows.Forms.DataGridView()
        CType(Me.dedlvrydate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedlvrydate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceDays.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDue.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceFree.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cediscamnt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGRetrieve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cePrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceAmountDisc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cePrcentDisc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deExpDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deExpDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLotNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgitems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(103, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "&Date Delivered"
        '
        'dedlvrydate
        '
        Me.dedlvrydate.EditValue = Nothing
        Me.dedlvrydate.EnterMoveNextControl = True
        Me.dedlvrydate.Location = New System.Drawing.Point(121, 24)
        Me.dedlvrydate.Name = "dedlvrydate"
        Me.dedlvrydate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.dedlvrydate.Properties.Appearance.Options.UseFont = True
        Me.dedlvrydate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedlvrydate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedlvrydate.Size = New System.Drawing.Size(107, 26)
        Me.dedlvrydate.TabIndex = 1
        Me.dedlvrydate.ToolTip = "Date of Delivery"
        '
        'ceDays
        '
        Me.ceDays.EnterMoveNextControl = True
        Me.ceDays.Location = New System.Drawing.Point(837, 28)
        Me.ceDays.Name = "ceDays"
        Me.ceDays.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceDays.Properties.Appearance.Options.UseFont = True
        Me.ceDays.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceDays.Size = New System.Drawing.Size(45, 26)
        Me.ceDays.TabIndex = 5
        Me.ceDays.ToolTip = "No of days the Supplier granted till due date"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(240, 31)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 19)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Source"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(554, 31)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "In&voice #:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(885, 31)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 19)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Du&e Date"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(748, 31)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(83, 19)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "N&o. of Days"
        '
        'cmbType
        '
        Me.cmbType.EditValue = ""
        Me.cmbType.EnterMoveNextControl = True
        Me.cmbType.Location = New System.Drawing.Point(122, 56)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.cmbType.Properties.Appearance.Options.UseFont = True
        Me.cmbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbType.Properties.Items.AddRange(New Object() {"COD", "I.S.", "Consignment"})
        Me.cmbType.Size = New System.Drawing.Size(106, 26)
        Me.cmbType.TabIndex = 25
        Me.cmbType.TabStop = False
        Me.cmbType.ToolTip = "COD,IS or Consignment"
        Me.cmbType.Visible = False
        '
        'deDue
        '
        Me.deDue.EditValue = Nothing
        Me.deDue.Location = New System.Drawing.Point(955, 28)
        Me.deDue.Name = "deDue"
        Me.deDue.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.deDue.Properties.Appearance.Options.UseFont = True
        Me.deDue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDue.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDue.Size = New System.Drawing.Size(108, 26)
        Me.deDue.TabIndex = 6
        Me.deDue.ToolTip = "Due date of the invoice the supplier gave"
        '
        'drgrid
        '
        Me.drgrid.AllowUserToAddRows = False
        Me.drgrid.AllowUserToDeleteRows = False
        Me.drgrid.AllowUserToResizeRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.drgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.drgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stckid, Me.Item, Me.Qty, Me.Free, Me.Price, Me.Amount, Me.Retail, Me.ExpiryDate, Me.LotNo, Me.disc, Me.dscamnt})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.drgrid.DefaultCellStyle = DataGridViewCellStyle18
        Me.drgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.drgrid.Location = New System.Drawing.Point(4, 102)
        Me.drgrid.MultiSelect = False
        Me.drgrid.Name = "drgrid"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.drgrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drgrid.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.drgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.drgrid.Size = New System.Drawing.Size(1156, 496)
        Me.drgrid.TabIndex = 8
        '
        'stckid
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stckid.DefaultCellStyle = DataGridViewCellStyle12
        Me.stckid.HeaderText = "StockID"
        Me.stckid.Name = "stckid"
        Me.stckid.Visible = False
        Me.stckid.Width = 5
        '
        'Item
        '
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item.DefaultCellStyle = DataGridViewCellStyle13
        Me.Item.HeaderText = "Item Description"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 500
        '
        'Qty
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle14.Format = "N0"
        DataGridViewCellStyle14.NullValue = "0"
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle14
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 80
        '
        'Free
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle15.Format = "N0"
        DataGridViewCellStyle15.NullValue = "0"
        Me.Free.DefaultCellStyle = DataGridViewCellStyle15
        Me.Free.HeaderText = "Free"
        Me.Free.Name = "Free"
        Me.Free.Width = 80
        '
        'Price
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = "0"
        Me.Price.DefaultCellStyle = DataGridViewCellStyle16
        Me.Price.HeaderText = "Cost"
        Me.Price.Name = "Price"
        Me.Price.Width = 150
        '
        'Amount
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle17.Format = "N2"
        DataGridViewCellStyle17.NullValue = "0"
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle17
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 200
        '
        'Retail
        '
        Me.Retail.HeaderText = "Retail"
        Me.Retail.Name = "Retail"
        '
        'ExpiryDate
        '
        Me.ExpiryDate.HeaderText = "Expiry Date"
        Me.ExpiryDate.Name = "ExpiryDate"
        Me.ExpiryDate.Visible = False
        Me.ExpiryDate.Width = 5
        '
        'LotNo
        '
        Me.LotNo.HeaderText = "Lot No"
        Me.LotNo.Name = "LotNo"
        Me.LotNo.Visible = False
        Me.LotNo.Width = 5
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
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(82, 77)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(33, 19)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Item"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(801, 70)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(30, 19)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = "&Free"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(607, 74)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(25, 19)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "&Qty"
        '
        'ceQty
        '
        Me.ceQty.Location = New System.Drawing.Point(638, 67)
        Me.ceQty.Name = "ceQty"
        Me.ceQty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceQty.Properties.Appearance.Options.UseFont = True
        Me.ceQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceQty.Size = New System.Drawing.Size(104, 26)
        Me.ceQty.TabIndex = 8
        Me.ceQty.ToolTip = "Qty Delivered by the supplier "
        '
        'ceFree
        '
        Me.ceFree.EnterMoveNextControl = True
        Me.ceFree.Location = New System.Drawing.Point(837, 67)
        Me.ceFree.Name = "ceFree"
        Me.ceFree.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceFree.Properties.Appearance.Options.UseFont = True
        Me.ceFree.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceFree.Size = New System.Drawing.Size(46, 26)
        Me.ceFree.TabIndex = 99
        Me.ceFree.ToolTip = "Number of free items the supplier gave as a promo or discount"
        '
        'ceCost
        '
        Me.ceCost.Location = New System.Drawing.Point(955, 67)
        Me.ceCost.Name = "ceCost"
        Me.ceCost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceCost.Properties.Appearance.Options.UseFont = True
        Me.ceCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceCost.Properties.Mask.BeepOnError = True
        Me.ceCost.Properties.Mask.EditMask = "n2"
        Me.ceCost.Size = New System.Drawing.Size(110, 26)
        Me.ceCost.TabIndex = 9
        Me.ceCost.TabStop = False
        Me.ceCost.ToolTip = "Cost of the item delivered"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(915, 70)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(34, 19)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "Pri&ce"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.Location = New System.Drawing.Point(956, 109)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "&Add to List"
        Me.btnAdd.ToolTip = "Add the item to the list of Deliveries Below."
        '
        'btnPost
        '
        Me.btnPost.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnPost.Appearance.Options.UseFont = True
        Me.btnPost.Enabled = False
        Me.btnPost.ImageOptions.Image = CType(resources.GetObject("btnPost.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPost.Location = New System.Drawing.Point(18, 604)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(179, 32)
        Me.btnPost.TabIndex = 16
        Me.btnPost.Text = "&Update Inventory"
        Me.btnPost.ToolTip = "Click this button to update the inventory and the Balance to be paid per supplier" &
    ""
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Enabled = False
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(388, 604)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 32)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "&Save"
        Me.btnSave.ToolTip = "Save the List for later modification"
        Me.btnSave.Visible = False
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnRetrieve.Appearance.Options.UseFont = True
        Me.btnRetrieve.Enabled = False
        Me.btnRetrieve.ImageOptions.Image = CType(resources.GetObject("btnRetrieve.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRetrieve.Location = New System.Drawing.Point(525, 604)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(120, 32)
        Me.btnRetrieve.TabIndex = 17
        Me.btnRetrieve.Text = "&Retrieve"
        Me.btnRetrieve.ToolTip = "Retrieve a list of uncompleted delivery entry"
        Me.btnRetrieve.Visible = False
        '
        'txtsum
        '
        Me.txtsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txtsum.Location = New System.Drawing.Point(873, 607)
        Me.txtsum.Name = "txtsum"
        Me.txtsum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsum.Size = New System.Drawing.Size(189, 29)
        Me.txtsum.TabIndex = 20
        Me.txtsum.TabStop = False
        Me.txtsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(771, 617)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(51, 19)
        Me.LabelControl10.TabIndex = 0
        Me.LabelControl10.Text = "TOTAL"
        '
        'txtItem
        '
        Me.txtItem.Enabled = False
        Me.txtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtItem.Location = New System.Drawing.Point(121, 70)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(426, 26)
        Me.txtItem.TabIndex = 7
        Me.txtItem.TabStop = False
        '
        'btnItemSearch
        '
        Me.btnItemSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnItemSearch.Appearance.Options.UseFont = True
        Me.btnItemSearch.Location = New System.Drawing.Point(553, 72)
        Me.btnItemSearch.Name = "btnItemSearch"
        Me.btnItemSearch.Size = New System.Drawing.Size(27, 25)
        Me.btnItemSearch.TabIndex = 23
        Me.btnItemSearch.Text = "&I..."
        Me.btnItemSearch.ToolTip = "Click this bvutton to search for items OR Press Alt+I"
        '
        'txtStckid
        '
        Me.txtStckid.Location = New System.Drawing.Point(461, 45)
        Me.txtStckid.Name = "txtStckid"
        Me.txtStckid.Size = New System.Drawing.Size(105, 21)
        Me.txtStckid.TabIndex = 21
        Me.txtStckid.TabStop = False
        Me.txtStckid.Visible = False
        '
        'txtSupplier
        '
        Me.txtSupplier.EditValue = ""
        Me.txtSupplier.Enabled = False
        Me.txtSupplier.Location = New System.Drawing.Point(294, 24)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtSupplier.Properties.Appearance.Options.UseFont = True
        Me.txtSupplier.Size = New System.Drawing.Size(222, 26)
        Me.txtSupplier.TabIndex = 1
        Me.txtSupplier.TabStop = False
        Me.txtSupplier.ToolTip = "Supplier who delivered the goods"
        '
        'btnSupSearch
        '
        Me.btnSupSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnSupSearch.Appearance.Options.UseFont = True
        Me.btnSupSearch.Location = New System.Drawing.Point(537, 24)
        Me.btnSupSearch.Name = "btnSupSearch"
        Me.btnSupSearch.Size = New System.Drawing.Size(10, 26)
        Me.btnSupSearch.TabIndex = 3
        Me.btnSupSearch.TabStop = False
        Me.btnSupSearch.Text = "&U..."
        Me.btnSupSearch.ToolTip = "Click this button to search for suppliers name. Or Press Alt+R"
        '
        'txtSupcode
        '
        Me.txtSupcode.Location = New System.Drawing.Point(350, 44)
        Me.txtSupcode.Name = "txtSupcode"
        Me.txtSupcode.Size = New System.Drawing.Size(105, 21)
        Me.txtSupcode.TabIndex = 22
        Me.txtSupcode.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(571, 649)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl11.TabIndex = 0
        Me.LabelControl11.Text = "Discount"
        Me.LabelControl11.Visible = False
        '
        'cediscamnt
        '
        Me.cediscamnt.Location = New System.Drawing.Point(648, 642)
        Me.cediscamnt.Name = "cediscamnt"
        Me.cediscamnt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.cediscamnt.Properties.Appearance.Options.UseFont = True
        Me.cediscamnt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cediscamnt.Size = New System.Drawing.Size(189, 26)
        Me.cediscamnt.TabIndex = 23
        Me.cediscamnt.ToolTip = "Discount Amount given by the supplier"
        Me.cediscamnt.Visible = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(747, 661)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(110, 19)
        Me.LabelControl12.TabIndex = 0
        Me.LabelControl12.Text = "GRAND TOTAL"
        Me.LabelControl12.Visible = False
        '
        'txtGrand
        '
        Me.txtGrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txtGrand.Location = New System.Drawing.Point(873, 651)
        Me.txtGrand.Name = "txtGrand"
        Me.txtGrand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGrand.Size = New System.Drawing.Size(189, 29)
        Me.txtGrand.TabIndex = 19
        Me.txtGrand.TabStop = False
        Me.txtGrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtGrand.Visible = False
        '
        'DGRetrieve
        '
        Me.DGRetrieve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRetrieve.Location = New System.Drawing.Point(300, 77)
        Me.DGRetrieve.Name = "DGRetrieve"
        Me.DGRetrieve.ReadOnly = True
        Me.DGRetrieve.Size = New System.Drawing.Size(426, 347)
        Me.DGRetrieve.TabIndex = 24
        Me.DGRetrieve.Visible = False
        '
        'txtInv
        '
        Me.txtInv.EditValue = ""
        Me.txtInv.EnterMoveNextControl = True
        Me.txtInv.Location = New System.Drawing.Point(635, 24)
        Me.txtInv.Name = "txtInv"
        Me.txtInv.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtInv.Properties.Appearance.Options.UseFont = True
        Me.txtInv.Size = New System.Drawing.Size(107, 26)
        Me.txtInv.TabIndex = 4
        Me.txtInv.ToolTip = "Invoice number based on the Delivery Receipt"
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.ImageOptions.Image = CType(resources.GetObject("btnNew.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(246, 604)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(120, 32)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "&New"
        Me.btnNew.ToolTip = "Click this to enter a new delivery."
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cePrice)
        Me.GroupControl1.Controls.Add(Me.leSupplier)
        Me.GroupControl1.Controls.Add(Me.txtInv)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txtSupplier)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txtSupcode)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txtStckid)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.btnSupSearch)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.btnItemSearch)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtItem)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.dedlvrydate)
        Me.GroupControl1.Controls.Add(Me.deDue)
        Me.GroupControl1.Controls.Add(Me.ceDays)
        Me.GroupControl1.Controls.Add(Me.cmbType)
        Me.GroupControl1.Controls.Add(Me.ceQty)
        Me.GroupControl1.Controls.Add(Me.ceFree)
        Me.GroupControl1.Controls.Add(Me.ceCost)
        Me.GroupControl1.Controls.Add(Me.ceAmountDisc)
        Me.GroupControl1.Controls.Add(Me.cePrcentDisc)
        Me.GroupControl1.Controls.Add(Me.deExpDate)
        Me.GroupControl1.Controls.Add(Me.txtLotNo)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.btnAdd)
        Me.GroupControl1.Enabled = False
        Me.GroupControl1.Location = New System.Drawing.Point(6, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1154, 144)
        Me.GroupControl1.TabIndex = 33
        Me.GroupControl1.Text = "Deliver&y Header"
        '
        'cePrice
        '
        Me.cePrice.EnterMoveNextControl = True
        Me.cePrice.Location = New System.Drawing.Point(1071, 41)
        Me.cePrice.Name = "cePrice"
        Me.cePrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.cePrice.Properties.Appearance.Options.UseFont = True
        Me.cePrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cePrice.Size = New System.Drawing.Size(76, 26)
        Me.cePrice.TabIndex = 101
        Me.cePrice.ToolTip = "Number of free items the supplier gave as a promo or discount"
        Me.cePrice.Visible = False
        '
        'leSupplier
        '
        Me.leSupplier.Location = New System.Drawing.Point(294, 24)
        Me.leSupplier.Name = "leSupplier"
        Me.leSupplier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.leSupplier.Properties.Appearance.Options.UseFont = True
        Me.leSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSupplier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("supcode", "supcode", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("supplier", "supplier")})
        Me.leSupplier.Properties.DropDownRows = 15
        Me.leSupplier.Size = New System.Drawing.Size(253, 26)
        Me.leSupplier.TabIndex = 2
        Me.leSupplier.ToolTip = "Click the Down Arrow to See a list of Suppliers"
        '
        'ceAmountDisc
        '
        Me.ceAmountDisc.EnterMoveNextControl = True
        Me.ceAmountDisc.Location = New System.Drawing.Point(837, 106)
        Me.ceAmountDisc.Name = "ceAmountDisc"
        Me.ceAmountDisc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ceAmountDisc.Properties.Appearance.Options.UseFont = True
        Me.ceAmountDisc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceAmountDisc.Size = New System.Drawing.Size(113, 26)
        Me.ceAmountDisc.TabIndex = 16
        Me.ceAmountDisc.ToolTip = "Amount to be deducted per Item Delivered"
        Me.ceAmountDisc.Visible = False
        '
        'cePrcentDisc
        '
        Me.cePrcentDisc.EnterMoveNextControl = True
        Me.cePrcentDisc.Location = New System.Drawing.Point(598, 106)
        Me.cePrcentDisc.Name = "cePrcentDisc"
        Me.cePrcentDisc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cePrcentDisc.Properties.Appearance.Options.UseFont = True
        Me.cePrcentDisc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cePrcentDisc.Size = New System.Drawing.Size(100, 26)
        Me.cePrcentDisc.TabIndex = 15
        Me.cePrcentDisc.ToolTip = "Percent to be deducted per Item delivered"
        Me.cePrcentDisc.Visible = False
        '
        'deExpDate
        '
        Me.deExpDate.EditValue = Nothing
        Me.deExpDate.Location = New System.Drawing.Point(361, 106)
        Me.deExpDate.Name = "deExpDate"
        Me.deExpDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.deExpDate.Properties.Appearance.Options.UseFont = True
        Me.deExpDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deExpDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deExpDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic
        Me.deExpDate.Properties.Mask.EditMask = "99/99/00"
        Me.deExpDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.deExpDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.deExpDate.Size = New System.Drawing.Size(128, 26)
        Me.deExpDate.TabIndex = 100
        Me.deExpDate.ToolTip = "Expiration date of Item delivered"
        Me.deExpDate.Visible = False
        '
        'txtLotNo
        '
        Me.txtLotNo.EditValue = ""
        Me.txtLotNo.EnterMoveNextControl = True
        Me.txtLotNo.Location = New System.Drawing.Point(121, 106)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtLotNo.Properties.Appearance.Options.UseFont = True
        Me.txtLotNo.Size = New System.Drawing.Size(100, 26)
        Me.txtLotNo.TabIndex = 99
        Me.txtLotNo.ToolTip = "Lot No. of Item of Item delivered"
        Me.txtLotNo.Visible = False
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(708, 113)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(123, 19)
        Me.LabelControl16.TabIndex = 0
        Me.LabelControl16.Text = "A&mount Discount"
        Me.LabelControl16.Visible = False
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(510, 113)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(82, 19)
        Me.LabelControl15.TabIndex = 0
        Me.LabelControl15.Text = "% Disco&unt"
        Me.LabelControl15.Visible = False
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(243, 113)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(108, 19)
        Me.LabelControl14.TabIndex = 0
        Me.LabelControl14.Text = "E&xpiration Date"
        Me.LabelControl14.Visible = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(68, 113)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(47, 19)
        Me.LabelControl13.TabIndex = 0
        Me.LabelControl13.Text = "Lo&t No"
        Me.LabelControl13.Visible = False
        '
        'btnNewSupplier
        '
        Me.btnNewSupplier.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnNewSupplier.Appearance.Options.UseFont = True
        Me.btnNewSupplier.ImageOptions.Image = CType(resources.GetObject("btnNewSupplier.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNewSupplier.Location = New System.Drawing.Point(19, 652)
        Me.btnNewSupplier.Name = "btnNewSupplier"
        Me.btnNewSupplier.Size = New System.Drawing.Size(120, 32)
        Me.btnNewSupplier.TabIndex = 102
        Me.btnNewSupplier.Text = "Add Su&pplier"
        '
        'btnAddNew
        '
        Me.btnAddNew.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnAddNew.Appearance.Options.UseFont = True
        Me.btnAddNew.ImageOptions.Image = CType(resources.GetObject("btnAddNew.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddNew.Location = New System.Drawing.Point(161, 652)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(120, 32)
        Me.btnAddNew.TabIndex = 101
        Me.btnAddNew.Text = "&Add Item"
        Me.btnAddNew.ToolTip = "Click this bvutton to search for items OR Press Alt+I"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(452, 652)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 32)
        Me.SimpleButton1.TabIndex = 101
        Me.SimpleButton1.Text = "Edit Items&2"
        Me.SimpleButton1.ToolTip = "Click this bvutton to search for items OR Press Alt+I"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(310, 652)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 32)
        Me.SimpleButton2.TabIndex = 102
        Me.SimpleButton2.Text = "Edit Items&1"
        '
        'dgitems
        '
        Me.dgitems.AllowUserToAddRows = False
        Me.dgitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgitems.Location = New System.Drawing.Point(40, 99)
        Me.dgitems.Name = "dgitems"
        Me.dgitems.ReadOnly = True
        Me.dgitems.Size = New System.Drawing.Size(882, 537)
        Me.dgitems.TabIndex = 101
        Me.dgitems.Visible = False
        '
        'frmDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 713)
        Me.Controls.Add(Me.dgitems)
        Me.Controls.Add(Me.drgrid)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.btnNewSupplier)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.DGRetrieve)
        Me.Controls.Add(Me.cediscamnt)
        Me.Controls.Add(Me.txtGrand)
        Me.Controls.Add(Me.txtsum)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl10)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDelivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delivery Entry Form"
        CType(Me.dedlvrydate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dedlvrydate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceDays.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDue.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceFree.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cediscamnt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGRetrieve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cePrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceAmountDisc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cePrcentDisc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deExpDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deExpDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLotNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgitems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dedlvrydate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ceDays As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents deDue As DevExpress.XtraEditors.DateEdit
    Friend WithEvents drgrid As System.Windows.Forms.DataGridView
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ceQty As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceFree As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceCost As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRetrieve As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtsum As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents btnItemSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtStckid As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSupSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSupcode As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cediscamnt As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGrand As System.Windows.Forms.TextBox
    Friend WithEvents DGRetrieve As System.Windows.Forms.DataGridView
    Friend WithEvents txtInv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents leSupplier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents deExpDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtLotNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ceAmountDisc As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents cePrcentDisc As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnNewSupplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgitems As DataGridView
    Friend WithEvents stckid As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Free As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Retail As DataGridViewTextBoxColumn
    Friend WithEvents ExpiryDate As DataGridViewTextBoxColumn
    Friend WithEvents LotNo As DataGridViewTextBoxColumn
    Friend WithEvents disc As DataGridViewTextBoxColumn
    Friend WithEvents dscamnt As DataGridViewTextBoxColumn
    Friend WithEvents cePrice As DevExpress.XtraEditors.CalcEdit
End Class
