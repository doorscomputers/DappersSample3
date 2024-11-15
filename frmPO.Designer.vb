<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPO
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.leSupplier = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSupcode = New System.Windows.Forms.TextBox()
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
        Me.DGRetrieve = New System.Windows.Forms.DataGridView()
        Me.txtsum = New System.Windows.Forms.TextBox()
        Me.btnRetrieve = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPost = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
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
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedlvrydate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dedlvrydate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGRetrieve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.GroupControl1.Controls.Add(Me.leSupplier)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txtSupcode)
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
        Me.GroupControl1.Location = New System.Drawing.Point(9, 5)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(969, 109)
        Me.GroupControl1.TabIndex = 46
        Me.GroupControl1.Text = "Delivery Header"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(703, 38)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(210, 20)
        Me.ComboBoxEdit1.TabIndex = 33
        '
        'leSupplier
        '
        Me.leSupplier.EnterMoveNextControl = True
        Me.leSupplier.Location = New System.Drawing.Point(296, 28)
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
        Me.leSupplier.Size = New System.Drawing.Size(390, 26)
        Me.leSupplier.TabIndex = 1
        Me.leSupplier.ToolTip = "Click the dropdown arrow to display suppliers list or type a few characters"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(57, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "PO Date"
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
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(713, 77)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(34, 19)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "Price"
        '
        'txtSupcode
        '
        Me.txtSupcode.Location = New System.Drawing.Point(350, 44)
        Me.txtSupcode.Name = "txtSupcode"
        Me.txtSupcode.Size = New System.Drawing.Size(105, 21)
        Me.txtSupcode.TabIndex = 14
        Me.txtSupcode.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(591, 77)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(25, 19)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "Qty"
        '
        'txtStckid
        '
        Me.txtStckid.Location = New System.Drawing.Point(461, 45)
        Me.txtStckid.Name = "txtStckid"
        Me.txtStckid.Size = New System.Drawing.Size(105, 21)
        Me.txtStckid.TabIndex = 14
        Me.txtStckid.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(232, 31)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Supplier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnItemSearch
        '
        Me.btnItemSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnItemSearch.Appearance.Options.UseFont = True
        Me.btnItemSearch.Location = New System.Drawing.Point(522, 71)
        Me.btnItemSearch.Name = "btnItemSearch"
        Me.btnItemSearch.Size = New System.Drawing.Size(27, 25)
        Me.btnItemSearch.TabIndex = 2
        Me.btnItemSearch.Text = "&I..."
        Me.btnItemSearch.ToolTip = "Click this bvutton to search for items OR Press Alt+I"
        '
        'txtItem
        '
        Me.txtItem.Enabled = False
        Me.txtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtItem.Location = New System.Drawing.Point(121, 70)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(398, 26)
        Me.txtItem.TabIndex = 12
        Me.txtItem.TabStop = False
        '
        'dedlvrydate
        '
        Me.dedlvrydate.EditValue = Nothing
        Me.dedlvrydate.EnterMoveNextControl = True
        Me.dedlvrydate.Location = New System.Drawing.Point(121, 30)
        Me.dedlvrydate.Name = "dedlvrydate"
        Me.dedlvrydate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.dedlvrydate.Properties.Appearance.Options.UseFont = True
        Me.dedlvrydate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedlvrydate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dedlvrydate.Size = New System.Drawing.Size(107, 26)
        Me.dedlvrydate.TabIndex = 0
        Me.dedlvrydate.ToolTip = "Date the Goods were delivered"
        '
        'cmbType
        '
        Me.cmbType.EnterMoveNextControl = True
        Me.cmbType.Location = New System.Drawing.Point(122, 56)
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
        Me.ceQty.Location = New System.Drawing.Point(622, 70)
        Me.ceQty.Name = "ceQty"
        Me.ceQty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceQty.Properties.Appearance.Options.UseFont = True
        Me.ceQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceQty.Size = New System.Drawing.Size(64, 26)
        Me.ceQty.TabIndex = 3
        Me.ceQty.ToolTip = "Qty Delivered by the supplier"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.Location = New System.Drawing.Point(879, 73)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.ToolTip = "Add the item to the list"
        '
        'ceCost
        '
        Me.ceCost.EnterMoveNextControl = True
        Me.ceCost.Location = New System.Drawing.Point(751, 70)
        Me.ceCost.Name = "ceCost"
        Me.ceCost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceCost.Properties.Appearance.Options.UseFont = True
        Me.ceCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceCost.Properties.Mask.BeepOnError = True
        Me.ceCost.Properties.Mask.EditMask = "n2"
        Me.ceCost.Size = New System.Drawing.Size(110, 26)
        Me.ceCost.TabIndex = 4
        Me.ceCost.TabStop = False
        Me.ceCost.ToolTip = "Cost of the item delivered"
        '
        'DGRetrieve
        '
        Me.DGRetrieve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRetrieve.Location = New System.Drawing.Point(130, 115)
        Me.DGRetrieve.Name = "DGRetrieve"
        Me.DGRetrieve.ReadOnly = True
        Me.DGRetrieve.Size = New System.Drawing.Size(519, 214)
        Me.DGRetrieve.TabIndex = 45
        Me.DGRetrieve.Visible = False
        '
        'txtsum
        '
        Me.txtsum.Enabled = False
        Me.txtsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txtsum.Location = New System.Drawing.Point(789, 538)
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
        Me.btnRetrieve.Location = New System.Drawing.Point(496, 535)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(102, 32)
        Me.btnRetrieve.TabIndex = 38
        Me.btnRetrieve.Text = "&Retrieve"
        Me.btnRetrieve.ToolTip = "Retrieve a list of uncompleted delivery entry"
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.Location = New System.Drawing.Point(246, 535)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(102, 32)
        Me.btnNew.TabIndex = 39
        Me.btnNew.Text = "&New"
        Me.btnNew.ToolTip = "Click this to enter a new delivery."
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(371, 535)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 32)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "&Save"
        Me.btnSave.ToolTip = "Save the List for later modification"
        '
        'btnPost
        '
        Me.btnPost.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.btnPost.Appearance.Options.UseFont = True
        Me.btnPost.Enabled = False
        Me.btnPost.Location = New System.Drawing.Point(18, 535)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(102, 32)
        Me.btnPost.TabIndex = 41
        Me.btnPost.Text = "&Post"
        Me.btnPost.ToolTip = "Click this button to update the inventory and the Balance per supplier"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(663, 548)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(110, 19)
        Me.LabelControl12.TabIndex = 34
        Me.LabelControl12.Text = "GRAND TOTAL"
        '
        'drgrid
        '
        Me.drgrid.AllowUserToAddRows = False
        Me.drgrid.AllowUserToDeleteRows = False
        Me.drgrid.AllowUserToResizeRows = False
        Me.drgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stckid, Me.Item, Me.Qty, Me.Price, Me.Amount, Me.ExpiryDate, Me.LotNo, Me.disc, Me.dscamnt})
        Me.drgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.drgrid.Location = New System.Drawing.Point(10, 121)
        Me.drgrid.MultiSelect = False
        Me.drgrid.Name = "drgrid"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drgrid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.drgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.drgrid.Size = New System.Drawing.Size(968, 408)
        Me.drgrid.TabIndex = 37
        '
        'stckid
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stckid.DefaultCellStyle = DataGridViewCellStyle1
        Me.stckid.HeaderText = "StockID"
        Me.stckid.Name = "stckid"
        Me.stckid.Visible = False
        Me.stckid.Width = 5
        '
        'Item
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item.DefaultCellStyle = DataGridViewCellStyle2
        Me.Item.HeaderText = "Item Description"
        Me.Item.Name = "Item"
        Me.Item.Width = 400
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
        'Price
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Price.DefaultCellStyle = DataGridViewCellStyle4
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.Width = 200
        '
        'Amount
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle5
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 200
        '
        'ExpiryDate
        '
        Me.ExpiryDate.HeaderText = "Expiry Date"
        Me.ExpiryDate.Name = "ExpiryDate"
        Me.ExpiryDate.Visible = false
        '
        'LotNo
        '
        Me.LotNo.HeaderText = "Lot No"
        Me.LotNo.Name = "LotNo"
        Me.LotNo.Visible = false
        '
        'disc
        '
        Me.disc.HeaderText = "disc"
        Me.disc.Name = "disc"
        Me.disc.Visible = false
        '
        'dscamnt
        '
        Me.dscamnt.HeaderText = "dscamnt"
        Me.dscamnt.Name = "dscamnt"
        Me.dscamnt.Visible = false
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Green"
        '
        'frmPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 577)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.DGRetrieve)
        Me.Controls.Add(Me.txtsum)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.drgrid)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order Entry"
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        Me.GroupControl1.PerformLayout
        CType(Me.ComboBoxEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.leSupplier.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dedlvrydate.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dedlvrydate.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cmbType.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ceQty.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ceCost.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DGRetrieve,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.drgrid,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSupcode As System.Windows.Forms.TextBox
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
    Friend WithEvents DGRetrieve As System.Windows.Forms.DataGridView
    Friend WithEvents txtsum As System.Windows.Forms.TextBox
    Friend WithEvents btnRetrieve As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents drgrid As System.Windows.Forms.DataGridView
    Friend WithEvents stckid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpiryDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents disc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dscamnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents leSupplier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
End Class
