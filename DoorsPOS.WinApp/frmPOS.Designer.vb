<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOS
    Inherits System.Windows.Forms.Form
    ''''Uncomment the line above to bring the form to original windows forms
    '''''''then copy the enclose with comments asterisk code
    '******************************************************************************************
    'Inherits PDSAFormBase
    Public Sub New()
        MyBase.New()
        DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Tahoma", 8.5)
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
    ''******************************************************************************************
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.txtitem = New System.Windows.Forms.TextBox()
        Me.PosGrid = New System.Windows.Forms.DataGridView()
        Me.ProdID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discounts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Incentv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaiterID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vatabol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSQL = New DevExpress.XtraEditors.TextEdit()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.DGRetrieve = New System.Windows.Forms.DataGridView()
        Me.GridLookUpEdit2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.stckid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.barcode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.items = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbPriceMode = New System.Windows.Forms.ComboBox()
        Me.cmbPaymentType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ceRefno = New DevExpress.XtraEditors.CalcEdit()
        Me.txtTendered = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtStckid = New System.Windows.Forms.TextBox()
        Me.txtbcodes = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.btnSearchItems = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCustomers = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPriceMode = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSaves = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCreditPay = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSuspend = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRetrieve = New DevExpress.XtraEditors.SimpleButton()
        Me.btnChequePayment = New DevExpress.XtraEditors.SimpleButton()
        Me.btnType = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLookuprice = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPickup = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReprint = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblName = New DevExpress.XtraEditors.LabelControl()
        Me.lblDate = New DevExpress.XtraEditors.LabelControl()
        Me.lblTime = New DevExpress.XtraEditors.LabelControl()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDiscount = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAddCash = New DevExpress.XtraEditors.SimpleButton()
        Me.btnnew = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBcode = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRefund = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCounts = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgEmps = New System.Windows.Forms.DataGridView()
        Me.wtid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.waiter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceWtid = New DevExpress.XtraEditors.CalcEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ceQtyy = New DevExpress.XtraEditors.CalcEdit()
        Me.dgitems = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnChanePrice = New DevExpress.XtraEditors.SimpleButton()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InputCustomerNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesForTodayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiveStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeliveryReceivingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGRetrieve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceRefno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCounts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEmps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceWtid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceQtyy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgitems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSum
        '
        Me.txtSum.BackColor = System.Drawing.Color.AliceBlue
        Me.txtSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 70.0!, System.Drawing.FontStyle.Bold)
        Me.txtSum.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtSum.Location = New System.Drawing.Point(268, 41)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.ReadOnly = True
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtSum, False)
        Me.txtSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSum.Size = New System.Drawing.Size(645, 113)
        Me.txtSum.TabIndex = 19
        Me.txtSum.TabStop = False
        '
        'txtitem
        '
        Me.txtitem.Enabled = False
        Me.txtitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitem.Location = New System.Drawing.Point(346, 3)
        Me.txtitem.Name = "txtitem"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtitem, False)
        Me.txtitem.Size = New System.Drawing.Size(464, 29)
        Me.txtitem.TabIndex = 1
        '
        'PosGrid
        '
        Me.PosGrid.AllowUserToAddRows = False
        Me.PosGrid.AllowUserToDeleteRows = False
        Me.PosGrid.AllowUserToOrderColumns = True
        Me.PosGrid.AllowUserToResizeColumns = False
        Me.PosGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PosGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.PosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PosGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdID, Me.Barcode, Me.Quantity, Me.Cost, Me.Item, Me.Price, Me.Total, Me.OP, Me.discounts, Me.Incentv, Me.WaiterID, Me.Vatabol, Me.SaleDiscount})
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PosGrid.DefaultCellStyle = DataGridViewCellStyle19
        Me.PosGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.PosGrid.Enabled = False
        Me.PosGrid.Location = New System.Drawing.Point(12, 160)
        Me.PosGrid.MultiSelect = False
        Me.PosGrid.Name = "PosGrid"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PosGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PosGrid.RowsDefaultCellStyle = DataGridViewCellStyle21
        Me.PosGrid.RowTemplate.Height = 30
        Me.PosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PosGrid.Size = New System.Drawing.Size(901, 469)
        Me.PosGrid.TabIndex = 12
        '
        'ProdID
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdID.DefaultCellStyle = DataGridViewCellStyle10
        Me.ProdID.HeaderText = "ProdID"
        Me.ProdID.Name = "ProdID"
        Me.ProdID.ReadOnly = True
        Me.ProdID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProdID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ProdID.Visible = False
        '
        'Barcode
        '
        Me.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Barcode.DefaultCellStyle = DataGridViewCellStyle11
        Me.Barcode.HeaderText = "Barcode"
        Me.Barcode.MaxInputLength = 22
        Me.Barcode.Name = "Barcode"
        Me.Barcode.ReadOnly = True
        Me.Barcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Barcode.Visible = False
        '
        'Quantity
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle12
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Cost
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.Cost.DefaultCellStyle = DataGridViewCellStyle13
        Me.Cost.HeaderText = "Cost"
        Me.Cost.Name = "Cost"
        Me.Cost.ReadOnly = True
        Me.Cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cost.Visible = False
        Me.Cost.Width = 5
        '
        'Item
        '
        Me.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.NullValue = Nothing
        Me.Item.DefaultCellStyle = DataGridViewCellStyle14
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        '
        'Price
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = "0"
        Me.Price.DefaultCellStyle = DataGridViewCellStyle15
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Price.Width = 120
        '
        'Total
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle16
        Me.Total.HeaderText = "Amount"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Total.Width = 200
        '
        'OP
        '
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OP.DefaultCellStyle = DataGridViewCellStyle17
        Me.OP.HeaderText = "OP"
        Me.OP.Name = "OP"
        Me.OP.ReadOnly = True
        Me.OP.Visible = False
        Me.OP.Width = 5
        '
        'discounts
        '
        Me.discounts.HeaderText = "DetailDiscount"
        Me.discounts.Name = "discounts"
        Me.discounts.ReadOnly = True
        Me.discounts.Visible = False
        Me.discounts.Width = 5
        '
        'Incentv
        '
        Me.Incentv.HeaderText = "Incentive"
        Me.Incentv.Name = "Incentv"
        Me.Incentv.ReadOnly = True
        Me.Incentv.Visible = False
        Me.Incentv.Width = 5
        '
        'WaiterID
        '
        Me.WaiterID.HeaderText = "WaiterID"
        Me.WaiterID.Name = "WaiterID"
        Me.WaiterID.ReadOnly = True
        Me.WaiterID.Visible = False
        Me.WaiterID.Width = 5
        '
        'Vatabol
        '
        Me.Vatabol.HeaderText = "Vatable"
        Me.Vatabol.Name = "Vatabol"
        Me.Vatabol.Visible = False
        Me.Vatabol.Width = 5
        '
        'SaleDiscount
        '
        Me.SaleDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle18.Format = "N2"
        DataGridViewCellStyle18.NullValue = "0"
        Me.SaleDiscount.DefaultCellStyle = DataGridViewCellStyle18
        Me.SaleDiscount.HeaderText = "SaleDiscount"
        Me.SaleDiscount.Name = "SaleDiscount"
        Me.SaleDiscount.ReadOnly = True
        Me.SaleDiscount.Width = 180
        '
        'txtBarcode
        '
        Me.txtBarcode.Enabled = False
        Me.txtBarcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(97, 6)
        Me.txtBarcode.Name = "txtBarcode"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtBarcode, False)
        Me.txtBarcode.Size = New System.Drawing.Size(189, 26)
        Me.txtBarcode.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Item Code"
        '
        'tbSQL
        '
        Me.tbSQL.Location = New System.Drawing.Point(614, 634)
        Me.tbSQL.Name = "tbSQL"
        Me.tbSQL.Size = New System.Drawing.Size(27, 20)
        Me.tbSQL.TabIndex = 22
        Me.tbSQL.TabStop = False
        Me.tbSQL.Visible = False
        '
        'DGRetrieve
        '
        Me.DGRetrieve.AllowUserToAddRows = False
        Me.DGRetrieve.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRetrieve.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGRetrieve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGRetrieve.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGRetrieve.Location = New System.Drawing.Point(50, 34)
        Me.DGRetrieve.Name = "DGRetrieve"
        Me.DGRetrieve.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRetrieve.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGRetrieve.Size = New System.Drawing.Size(774, 427)
        Me.DGRetrieve.TabIndex = 30
        Me.DGRetrieve.Visible = False
        '
        'GridLookUpEdit2
        '
        Me.GridLookUpEdit2.EditValue = ""
        Me.GridLookUpEdit2.Enabled = False
        Me.GridLookUpEdit2.EnterMoveNextControl = True
        Me.GridLookUpEdit2.Location = New System.Drawing.Point(16, 44)
        Me.GridLookUpEdit2.Name = "GridLookUpEdit2"
        Me.GridLookUpEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.GridLookUpEdit2.Properties.Appearance.Options.UseFont = True
        Me.GridLookUpEdit2.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2.Properties.AppearanceDropDown.Options.UseFont = True
        Me.GridLookUpEdit2.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2.Properties.AppearanceFocused.Options.UseFont = True
        Me.GridLookUpEdit2.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.GridLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit2.Properties.PopupFormSize = New System.Drawing.Size(860, 600)
        Me.GridLookUpEdit2.Properties.PopupView = Me.GridLookUpEdit2View
        Me.GridLookUpEdit2.Size = New System.Drawing.Size(808, 32)
        Me.GridLookUpEdit2.TabIndex = 1
        Me.GridLookUpEdit2.ToolTip = "Press CTRL + I to move focus to Item Search"
        Me.GridLookUpEdit2.Visible = False
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2View.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.GridLookUpEdit2View.Appearance.FilterPanel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.GridLookUpEdit2View.Appearance.FilterPanel.Options.UseFont = True
        Me.GridLookUpEdit2View.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2View.Appearance.FocusedCell.Options.UseFont = True
        Me.GridLookUpEdit2View.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2View.Appearance.FocusedRow.Options.UseFont = True
        Me.GridLookUpEdit2View.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.GridLookUpEdit2View.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridLookUpEdit2View.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2View.Appearance.Row.Options.UseFont = True
        Me.GridLookUpEdit2View.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridLookUpEdit2View.Appearance.SelectedRow.Options.UseFont = True
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.stckid, Me.barcode1, Me.items, Me.GridColumn4, Me.GridColumn5, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsBehavior.AllowPartialRedrawOnScrolling = False
        Me.GridLookUpEdit2View.OptionsFind.AlwaysVisible = True
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'stckid
        '
        Me.stckid.Caption = "StockID"
        Me.stckid.FieldName = "stckid"
        Me.stckid.Name = "stckid"
        Me.stckid.Width = 96
        '
        'barcode1
        '
        Me.barcode1.AppearanceHeader.Options.UseTextOptions = True
        Me.barcode1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.barcode1.Caption = "Barcode"
        Me.barcode1.FieldName = "barcode"
        Me.barcode1.Name = "barcode1"
        Me.barcode1.Width = 197
        '
        'items
        '
        Me.items.AppearanceHeader.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.items.AppearanceHeader.Options.UseFont = True
        Me.items.Caption = "Item Description"
        Me.items.FieldName = "itemdesc"
        Me.items.Name = "items"
        Me.items.Visible = True
        Me.items.VisibleIndex = 0
        Me.items.Width = 526
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.Caption = "Selling Price"
        Me.GridColumn4.DisplayFormat.FormatString = "N2"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "retail"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 170
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 18.25!)
        Me.GridColumn5.AppearanceCell.Options.UseFont = True
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.Caption = "Wholesale"
        Me.GridColumn5.DisplayFormat.FormatString = "N2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "retail2"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 185
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "GridColumn8"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Width = 33
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "GridColumn9"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Width = 33
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "GridColumn10"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Width = 33
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "GridColumn11"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Width = 33
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "GridColumn12"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Width = 33
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "GridColumn13"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Width = 57
        '
        'cmbPriceMode
        '
        Me.cmbPriceMode.Enabled = False
        Me.cmbPriceMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPriceMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbPriceMode.FormattingEnabled = True
        Me.cmbPriceMode.Items.AddRange(New Object() {"Retail", "Wholesale", "Refund"})
        Me.cmbPriceMode.Location = New System.Drawing.Point(919, 39)
        Me.cmbPriceMode.Name = "cmbPriceMode"
        Me.cmbPriceMode.Size = New System.Drawing.Size(281, 37)
        Me.cmbPriceMode.TabIndex = 43
        Me.cmbPriceMode.Text = "Retail"
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentType.ForeColor = System.Drawing.Color.Green
        Me.cmbPaymentType.FormattingEnabled = True
        Me.cmbPaymentType.Items.AddRange(New Object() {"CASH", "CREDIT", "CHEQUE"})
        Me.cmbPaymentType.Location = New System.Drawing.Point(921, 418)
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.Size = New System.Drawing.Size(277, 37)
        Me.cmbPaymentType.TabIndex = 44
        Me.cmbPaymentType.Text = "CASH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(913, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(291, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "A m o u n t   T e n d e r e d"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1057, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "-------------------------------------------"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(913, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 29)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "CHANGE"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ceRefno
        '
        Me.ceRefno.Enabled = False
        Me.ceRefno.Location = New System.Drawing.Point(1034, 83)
        Me.ceRefno.Name = "ceRefno"
        Me.ceRefno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ceRefno.Properties.Appearance.Options.UseFont = True
        Me.ceRefno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceRefno.Size = New System.Drawing.Size(144, 26)
        Me.ceRefno.TabIndex = 49
        '
        'txtTendered
        '
        Me.txtTendered.BackColor = System.Drawing.Color.White
        Me.txtTendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTendered.ForeColor = System.Drawing.Color.Blue
        Me.txtTendered.Location = New System.Drawing.Point(919, 149)
        Me.txtTendered.Name = "txtTendered"
        Me.txtTendered.ReadOnly = True
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtTendered, False)
        Me.txtTendered.Size = New System.Drawing.Size(280, 49)
        Me.txtTendered.TabIndex = 54
        Me.txtTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.White
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.Red
        Me.lblChange.Location = New System.Drawing.Point(919, 232)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.ReadOnly = True
        Me.NetResize1.SetResizeTextBoxMultiline(Me.lblChange, False)
        Me.lblChange.Size = New System.Drawing.Size(280, 49)
        Me.lblChange.TabIndex = 55
        Me.lblChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 641)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Client"
        '
        'txtcustid
        '
        Me.txtcustid.Enabled = False
        Me.txtcustid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtcustid.Location = New System.Drawing.Point(66, 635)
        Me.txtcustid.Name = "txtcustid"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtcustid, False)
        Me.txtcustid.Size = New System.Drawing.Size(53, 26)
        Me.txtcustid.TabIndex = 58
        Me.txtcustid.Text = "1"
        '
        'txtlastname
        '
        Me.txtlastname.Enabled = False
        Me.txtlastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtlastname.Location = New System.Drawing.Point(125, 635)
        Me.txtlastname.Name = "txtlastname"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtlastname, False)
        Me.txtlastname.Size = New System.Drawing.Size(77, 26)
        Me.txtlastname.TabIndex = 58
        Me.txtlastname.Text = "CASH"
        '
        'txtfirstname
        '
        Me.txtfirstname.Enabled = False
        Me.txtfirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtfirstname.Location = New System.Drawing.Point(208, 635)
        Me.txtfirstname.Name = "txtfirstname"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtfirstname, False)
        Me.txtfirstname.Size = New System.Drawing.Size(67, 26)
        Me.txtfirstname.TabIndex = 58
        '
        'txtStckid
        '
        Me.txtStckid.Enabled = False
        Me.txtStckid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStckid.Location = New System.Drawing.Point(971, 4)
        Me.txtStckid.Name = "txtStckid"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtStckid, False)
        Me.txtStckid.Size = New System.Drawing.Size(55, 20)
        Me.txtStckid.TabIndex = 59
        Me.txtStckid.Visible = False
        '
        'txtbcodes
        '
        Me.txtbcodes.Enabled = False
        Me.txtbcodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbcodes.Location = New System.Drawing.Point(590, 7)
        Me.txtbcodes.MaxLength = 22
        Me.txtbcodes.Name = "txtbcodes"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtbcodes, False)
        Me.txtbcodes.Size = New System.Drawing.Size(94, 29)
        Me.txtbcodes.TabIndex = 61
        Me.txtbcodes.Visible = False
        '
        'txtqty
        '
        Me.txtqty.Enabled = False
        Me.txtqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(523, 7)
        Me.txtqty.MaxLength = 22
        Me.txtqty.Name = "txtqty"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtqty, False)
        Me.txtqty.Size = New System.Drawing.Size(45, 29)
        Me.txtqty.TabIndex = 61
        Me.txtqty.Visible = False
        '
        'btnSearchItems
        '
        Me.btnSearchItems.ImageOptions.Image = CType(resources.GetObject("btnSearchItems.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSearchItems.Location = New System.Drawing.Point(816, 3)
        Me.btnSearchItems.Name = "btnSearchItems"
        Me.btnSearchItems.Size = New System.Drawing.Size(97, 30)
        Me.btnSearchItems.TabIndex = 64
        Me.btnSearchItems.Text = "Find &Item"
        '
        'btnCustomers
        '
        Me.btnCustomers.ImageOptions.Image = CType(resources.GetObject("btnCustomers.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCustomers.Location = New System.Drawing.Point(291, 629)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(115, 41)
        Me.btnCustomers.TabIndex = 65
        Me.btnCustomers.Text = "Find &Customer"
        '
        'btnPriceMode
        '
        Me.btnPriceMode.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnPriceMode.Appearance.Options.UseFont = True
        Me.btnPriceMode.Location = New System.Drawing.Point(918, 3)
        Me.btnPriceMode.Name = "btnPriceMode"
        Me.btnPriceMode.Size = New System.Drawing.Size(282, 30)
        Me.btnPriceMode.TabIndex = 66
        Me.btnPriceMode.Text = "&S e l l    T y p e"
        '
        'btnSaves
        '
        Me.btnSaves.ImageOptions.Image = CType(resources.GetObject("btnSaves.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSaves.Location = New System.Drawing.Point(919, 286)
        Me.btnSaves.Name = "btnSaves"
        Me.btnSaves.Size = New System.Drawing.Size(138, 38)
        Me.btnSaves.TabIndex = 67
        Me.btnSaves.Text = "Take Payment(F12)"
        '
        'btnCreditPay
        '
        Me.btnCreditPay.ImageOptions.Image = CType(resources.GetObject("btnCreditPay.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCreditPay.Location = New System.Drawing.Point(1069, 286)
        Me.btnCreditPay.Name = "btnCreditPay"
        Me.btnCreditPay.Size = New System.Drawing.Size(131, 38)
        Me.btnCreditPay.TabIndex = 68
        Me.btnCreditPay.Text = "Pa&y Credit(F3)"
        '
        'btnSuspend
        '
        Me.btnSuspend.ImageOptions.Image = CType(resources.GetObject("btnSuspend.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSuspend.Location = New System.Drawing.Point(918, 329)
        Me.btnSuspend.Name = "btnSuspend"
        Me.btnSuspend.Size = New System.Drawing.Size(138, 38)
        Me.btnSuspend.TabIndex = 69
        Me.btnSuspend.Text = "Suspend(F5)"
        '
        'btnRetrieve
        '
        Me.btnRetrieve.ImageOptions.Image = CType(resources.GetObject("btnRetrieve.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRetrieve.Location = New System.Drawing.Point(1069, 329)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(131, 38)
        Me.btnRetrieve.TabIndex = 70
        Me.btnRetrieve.Text = "Retrieve(F6)"
        '
        'btnChequePayment
        '
        Me.btnChequePayment.Location = New System.Drawing.Point(1068, 372)
        Me.btnChequePayment.Name = "btnChequePayment"
        Me.btnChequePayment.Size = New System.Drawing.Size(131, 41)
        Me.btnChequePayment.TabIndex = 71
        Me.btnChequePayment.Text = "Retrieve Sales"
        Me.btnChequePayment.ToolTip = "Check Payment Entry Form"
        '
        'btnType
        '
        Me.btnType.ImageOptions.Image = CType(resources.GetObject("btnType.ImageOptions.Image"), System.Drawing.Image)
        Me.btnType.Location = New System.Drawing.Point(919, 372)
        Me.btnType.Name = "btnType"
        Me.btnType.Size = New System.Drawing.Size(137, 41)
        Me.btnType.TabIndex = 72
        Me.btnType.Text = "&Type of Payment"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(918, 90)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl1.TabIndex = 73
        Me.LabelControl1.Text = "Reference No."
        Me.LabelControl1.ToolTip = "Press F4 to Reprint Sales or Credit"
        '
        'btnRemove
        '
        Me.btnRemove.ImageOptions.Image = CType(resources.GetObject("btnRemove.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(919, 461)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(137, 41)
        Me.btnRemove.TabIndex = 74
        Me.btnRemove.Text = "&Remove Item"
        '
        'btnLookuprice
        '
        Me.btnLookuprice.ImageOptions.Image = CType(resources.GetObject("btnLookuprice.ImageOptions.Image"), System.Drawing.Image)
        Me.btnLookuprice.Location = New System.Drawing.Point(412, 629)
        Me.btnLookuprice.Name = "btnLookuprice"
        Me.btnLookuprice.Size = New System.Drawing.Size(129, 41)
        Me.btnLookuprice.TabIndex = 75
        Me.btnLookuprice.Text = "Price Lookup(F2)"
        '
        'btnPickup
        '
        Me.btnPickup.ImageOptions.Image = CType(resources.GetObject("btnPickup.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPickup.Location = New System.Drawing.Point(547, 629)
        Me.btnPickup.Name = "btnPickup"
        Me.btnPickup.Size = New System.Drawing.Size(94, 41)
        Me.btnPickup.TabIndex = 76
        Me.btnPickup.Text = "Pett&y Cash"
        '
        'btnReprint
        '
        Me.btnReprint.ImageOptions.Image = CType(resources.GetObject("btnReprint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnReprint.Location = New System.Drawing.Point(1068, 461)
        Me.btnReprint.Name = "btnReprint"
        Me.btnReprint.Size = New System.Drawing.Size(131, 41)
        Me.btnReprint.TabIndex = 77
        Me.btnReprint.Text = "Re-Print(F4)"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(919, 511)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(46, 36)
        Me.SimpleButton5.TabIndex = 78
        '
        'SimpleButton6
        '
        Me.SimpleButton6.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(919, 552)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(46, 36)
        Me.SimpleButton6.TabIndex = 79
        '
        'SimpleButton7
        '
        Me.SimpleButton7.ImageOptions.Image = CType(resources.GetObject("SimpleButton7.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(921, 593)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(46, 36)
        Me.SimpleButton7.TabIndex = 80
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(971, 524)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(57, 23)
        Me.LabelControl2.TabIndex = 81
        Me.LabelControl2.Text = "NAME:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(975, 565)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 23)
        Me.LabelControl3.TabIndex = 81
        Me.LabelControl3.Text = "DATE:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(977, 606)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(51, 23)
        Me.LabelControl4.TabIndex = 81
        Me.LabelControl4.Text = "TIME:"
        '
        'lblName
        '
        Me.lblName.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.lblName.Appearance.Options.UseFont = True
        Me.lblName.Location = New System.Drawing.Point(1034, 518)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(70, 29)
        Me.lblName.TabIndex = 81
        Me.lblName.Text = "NAME:"
        '
        'lblDate
        '
        Me.lblDate.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.lblDate.Appearance.Options.UseFont = True
        Me.lblDate.Location = New System.Drawing.Point(1034, 565)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(46, 23)
        Me.lblDate.TabIndex = 81
        Me.lblDate.Text = "DATE"
        '
        'lblTime
        '
        Me.lblTime.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.lblTime.Appearance.Options.UseFont = True
        Me.lblTime.Location = New System.Drawing.Point(1034, 606)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(44, 23)
        Me.lblTime.TabIndex = 81
        Me.lblTime.Text = "TIME"
        '
        'Button1
        '
        Me.Button1.ImageOptions.Image = CType(resources.GetObject("Button1.ImageOptions.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(647, 629)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 41)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Set &Quantity"
        '
        'btnDiscount
        '
        Me.btnDiscount.Location = New System.Drawing.Point(966, 629)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(105, 41)
        Me.btnDiscount.TabIndex = 83
        Me.btnDiscount.Text = "&Discount"
        '
        'btnAddCash
        '
        Me.btnAddCash.ImageOptions.Image = CType(resources.GetObject("btnAddCash.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddCash.Location = New System.Drawing.Point(758, 629)
        Me.btnAddCash.Name = "btnAddCash"
        Me.btnAddCash.Size = New System.Drawing.Size(90, 41)
        Me.btnAddCash.TabIndex = 84
        Me.btnAddCash.Text = "Add F&und"
        '
        'btnnew
        '
        Me.btnnew.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btnnew.Appearance.Options.UseFont = True
        Me.btnnew.ImageOptions.Image = CType(resources.GetObject("btnnew.ImageOptions.Image"), System.Drawing.Image)
        Me.btnnew.Location = New System.Drawing.Point(1155, 524)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(35, 35)
        Me.btnnew.TabIndex = 85
        Me.btnnew.Text = "&N e w   T r a n s a c t i o n"
        Me.btnnew.Visible = False
        '
        'btnBcode
        '
        Me.btnBcode.ImageOptions.Image = CType(resources.GetObject("btnBcode.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBcode.Location = New System.Drawing.Point(1122, 565)
        Me.btnBcode.Name = "btnBcode"
        Me.btnBcode.Size = New System.Drawing.Size(39, 29)
        Me.btnBcode.TabIndex = 86
        Me.btnBcode.Text = "&Barcode"
        Me.btnBcode.Visible = False
        '
        'btnRefund
        '
        Me.btnRefund.Location = New System.Drawing.Point(1084, 629)
        Me.btnRefund.Name = "btnRefund"
        Me.btnRefund.Size = New System.Drawing.Size(105, 41)
        Me.btnRefund.TabIndex = 83
        Me.btnRefund.Text = "Refund"
        '
        'txtCounts
        '
        Me.txtCounts.Enabled = False
        Me.txtCounts.Location = New System.Drawing.Point(12, 68)
        Me.txtCounts.Name = "txtCounts"
        Me.txtCounts.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 54.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCounts.Properties.Appearance.Options.UseFont = True
        Me.txtCounts.Size = New System.Drawing.Size(250, 88)
        ToolTipTitleItem1.Text = "ITEMS SOLD"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "TOTAL COUNT OF ITEMS SOLD"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.txtCounts.SuperTip = SuperToolTip1
        Me.txtCounts.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1066, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "ITEM COUNT"
        Me.Label1.Visible = False
        '
        'dgEmps
        '
        Me.dgEmps.AllowUserToAddRows = False
        Me.dgEmps.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEmps.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmps.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.wtid, Me.waiter})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgEmps.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgEmps.Location = New System.Drawing.Point(363, 149)
        Me.dgEmps.Name = "dgEmps"
        Me.dgEmps.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEmps.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgEmps.Size = New System.Drawing.Size(450, 465)
        Me.dgEmps.TabIndex = 90
        Me.dgEmps.Visible = False
        '
        'wtid
        '
        Me.wtid.HeaderText = "wtid"
        Me.wtid.Name = "wtid"
        Me.wtid.ReadOnly = True
        Me.wtid.Visible = False
        '
        'waiter
        '
        Me.waiter.HeaderText = "Employee Name"
        Me.waiter.Name = "waiter"
        Me.waiter.ReadOnly = True
        Me.waiter.Width = 400
        '
        'ceWtid
        '
        Me.ceWtid.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ceWtid.Location = New System.Drawing.Point(1142, 242)
        Me.ceWtid.Name = "ceWtid"
        Me.ceWtid.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceWtid.Size = New System.Drawing.Size(51, 20)
        Me.ceWtid.TabIndex = 91
        Me.ceWtid.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(692, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "QTY"
        Me.Label5.Visible = False
        '
        'ceQtyy
        '
        Me.ceQtyy.Location = New System.Drawing.Point(742, 0)
        Me.ceQtyy.Name = "ceQtyy"
        Me.ceQtyy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.ceQtyy.Properties.Appearance.Options.UseFont = True
        Me.ceQtyy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceQtyy.Size = New System.Drawing.Size(71, 32)
        Me.ceQtyy.TabIndex = 2
        Me.ceQtyy.Visible = False
        '
        'dgitems
        '
        Me.dgitems.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgitems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgitems.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgitems.Location = New System.Drawing.Point(50, 34)
        Me.dgitems.Name = "dgitems"
        Me.dgitems.ReadOnly = True
        Me.dgitems.Size = New System.Drawing.Size(882, 580)
        Me.dgitems.TabIndex = 92
        Me.dgitems.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 24)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "I T E M   C O U N T "
        '
        'btnChanePrice
        '
        Me.btnChanePrice.Location = New System.Drawing.Point(138, 667)
        Me.btnChanePrice.Name = "btnChanePrice"
        Me.btnChanePrice.Size = New System.Drawing.Size(47, 23)
        Me.btnChanePrice.TabIndex = 94
        Me.btnChanePrice.TabStop = False
        Me.btnChanePrice.Text = "&PriceChange"
        Me.btnChanePrice.Visible = False
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputCustomerNameToolStripMenuItem, Me.SalesForTodayToolStripMenuItem, Me.NewItemToolStripMenuItem, Me.EditItemToolStripMenuItem, Me.TransferStockToolStripMenuItem, Me.ReceiveStockToolStripMenuItem, Me.DeliveryReceivingToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(232, 186)
        '
        'InputCustomerNameToolStripMenuItem
        '
        Me.InputCustomerNameToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputCustomerNameToolStripMenuItem.Name = "InputCustomerNameToolStripMenuItem"
        Me.InputCustomerNameToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.InputCustomerNameToolStripMenuItem.Text = "Input &Customer Name"
        '
        'SalesForTodayToolStripMenuItem
        '
        Me.SalesForTodayToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.SalesForTodayToolStripMenuItem.Name = "SalesForTodayToolStripMenuItem"
        Me.SalesForTodayToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.SalesForTodayToolStripMenuItem.Text = "&Sales for Today"
        '
        'NewItemToolStripMenuItem
        '
        Me.NewItemToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.NewItemToolStripMenuItem.Name = "NewItemToolStripMenuItem"
        Me.NewItemToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.NewItemToolStripMenuItem.Text = "&New Item"
        '
        'EditItemToolStripMenuItem
        '
        Me.EditItemToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EditItemToolStripMenuItem.Name = "EditItemToolStripMenuItem"
        Me.EditItemToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.EditItemToolStripMenuItem.Text = "&Edit Item"
        '
        'TransferStockToolStripMenuItem
        '
        Me.TransferStockToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TransferStockToolStripMenuItem.Name = "TransferStockToolStripMenuItem"
        Me.TransferStockToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.TransferStockToolStripMenuItem.Text = "&Transfer Stock"
        '
        'ReceiveStockToolStripMenuItem
        '
        Me.ReceiveStockToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ReceiveStockToolStripMenuItem.Name = "ReceiveStockToolStripMenuItem"
        Me.ReceiveStockToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.ReceiveStockToolStripMenuItem.Text = "&Receive Stock"
        '
        'DeliveryReceivingToolStripMenuItem
        '
        Me.DeliveryReceivingToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DeliveryReceivingToolStripMenuItem.Name = "DeliveryReceivingToolStripMenuItem"
        Me.DeliveryReceivingToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.DeliveryReceivingToolStripMenuItem.Text = "Delivery Receiving"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(292, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Item"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "GridColumn3"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 6
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "GridColumn6"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 7
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "GridColumn7"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 8
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1205, 698)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgitems)
        Me.Controls.Add(Me.DGRetrieve)
        Me.Controls.Add(Me.btnChanePrice)
        Me.Controls.Add(Me.ceWtid)
        Me.Controls.Add(Me.dgEmps)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBcode)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnAddCash)
        Me.Controls.Add(Me.btnRefund)
        Me.Controls.Add(Me.btnDiscount)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.SimpleButton7)
        Me.Controls.Add(Me.SimpleButton6)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.btnReprint)
        Me.Controls.Add(Me.btnPickup)
        Me.Controls.Add(Me.btnLookuprice)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnType)
        Me.Controls.Add(Me.btnChequePayment)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.btnSuspend)
        Me.Controls.Add(Me.btnCreditPay)
        Me.Controls.Add(Me.btnSaves)
        Me.Controls.Add(Me.btnPriceMode)
        Me.Controls.Add(Me.btnCustomers)
        Me.Controls.Add(Me.btnSearchItems)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtbcodes)
        Me.Controls.Add(Me.txtStckid)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtcustid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.txtTendered)
        Me.Controls.Add(Me.ceRefno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbPaymentType)
        Me.Controls.Add(Me.cmbPriceMode)
        Me.Controls.Add(Me.GridLookUpEdit2)
        Me.Controls.Add(Me.tbSQL)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.txtitem)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ceQtyy)
        Me.Controls.Add(Me.PosGrid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCounts)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPOS"
        Me.Text = "POS TERMINAL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGRetrieve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceRefno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCounts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEmps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceWtid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceQtyy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgitems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents txtitem As System.Windows.Forms.TextBox
    Friend WithEvents PosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbSQL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents DGRetrieve As System.Windows.Forms.DataGridView
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colstckid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colitem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colretail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridLookUpEdit2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents stckid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barcode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents items As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbPriceMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ceRefno As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtTendered As System.Windows.Forms.TextBox
    Friend WithEvents lblChange As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcustid As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtStckid As System.Windows.Forms.TextBox
    Friend WithEvents txtbcodes As System.Windows.Forms.TextBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchItems As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustomers As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPriceMode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaves As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCreditPay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSuspend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRetrieve As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChequePayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLookuprice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnPickup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReprint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAddCash As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnnew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBcode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRefund As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCounts As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgEmps As System.Windows.Forms.DataGridView
    Friend WithEvents wtid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents waiter As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents ceWtid As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ceQtyy As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents dgitems As System.Windows.Forms.DataGridView
    Public WithEvents cmbPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnChanePrice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents InputCustomerNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesForTodayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransferStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceiveStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeliveryReceivingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents ProdID As DataGridViewTextBoxColumn
    Friend WithEvents Barcode As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Cost As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents OP As DataGridViewTextBoxColumn
    Friend WithEvents discounts As DataGridViewTextBoxColumn
    Friend WithEvents Incentv As DataGridViewTextBoxColumn
    Friend WithEvents WaiterID As DataGridViewTextBoxColumn
    Friend WithEvents Vatabol As DataGridViewTextBoxColumn
    Friend WithEvents SaleDiscount As DataGridViewTextBoxColumn
End Class
