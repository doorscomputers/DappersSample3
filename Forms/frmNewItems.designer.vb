<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewItems
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
        Me.txtBarcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtItem = New DevExpress.XtraEditors.TextEdit()
        Me.leSuppliers = New DevExpress.XtraEditors.LookUpEdit()
        Me.leCategories = New DevExpress.XtraEditors.LookUpEdit()
        Me.ceCost = New DevExpress.XtraEditors.CalcEdit()
        Me.ceWholesale = New DevExpress.XtraEditors.CalcEdit()
        Me.ceMin = New DevExpress.XtraEditors.CalcEdit()
        Me.ceMax = New DevExpress.XtraEditors.CalcEdit()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.compretail = New DevExpress.XtraEditors.TextEdit()
        Me.compmup2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.compmup1 = New DevExpress.XtraEditors.CalcEdit()
        Me.compwholesale = New DevExpress.XtraEditors.CalcEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.leType = New DevExpress.XtraEditors.LookUpEdit()
        Me.ceRetail = New DevExpress.XtraEditors.CalcEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.leBrand = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSuppliers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leCategories.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceWholesale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compretail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compmup2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compmup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compwholesale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceRetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBarcode
        '
        Me.txtBarcode.EnterMoveNextControl = True
        Me.txtBarcode.Location = New System.Drawing.Point(202, 13)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtBarcode.Properties.Appearance.Options.UseFont = True
        Me.txtBarcode.Size = New System.Drawing.Size(217, 26)
        Me.txtBarcode.TabIndex = 0
        '
        'txtItem
        '
        Me.txtItem.EnterMoveNextControl = True
        Me.txtItem.Location = New System.Drawing.Point(202, 49)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtItem.Properties.Appearance.Options.UseFont = True
        Me.txtItem.Size = New System.Drawing.Size(441, 26)
        Me.txtItem.TabIndex = 1
        '
        'leSuppliers
        '
        Me.leSuppliers.EditValue = ""
        Me.leSuppliers.Enabled = False
        Me.leSuppliers.EnterMoveNextControl = True
        Me.leSuppliers.Location = New System.Drawing.Point(202, 85)
        Me.leSuppliers.Margin = New System.Windows.Forms.Padding(2)
        Me.leSuppliers.Name = "leSuppliers"
        Me.leSuppliers.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leSuppliers.Properties.Appearance.Options.UseFont = True
        Me.leSuppliers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSuppliers.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("supcode", "supcode", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("supplier", "Supplier")})
        Me.leSuppliers.Size = New System.Drawing.Size(441, 26)
        Me.leSuppliers.TabIndex = 2
        '
        'leCategories
        '
        Me.leCategories.EditValue = ""
        Me.leCategories.Enabled = False
        Me.leCategories.EnterMoveNextControl = True
        Me.leCategories.Location = New System.Drawing.Point(202, 121)
        Me.leCategories.Margin = New System.Windows.Forms.Padding(2)
        Me.leCategories.Name = "leCategories"
        Me.leCategories.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leCategories.Properties.Appearance.Options.UseFont = True
        Me.leCategories.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leCategories.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("categoryid", "categoryid", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("catgory", "Category")})
        Me.leCategories.Properties.DropDownRows = 15
        Me.leCategories.Size = New System.Drawing.Size(441, 26)
        Me.leCategories.TabIndex = 3
        '
        'ceCost
        '
        Me.ceCost.EnterMoveNextControl = True
        Me.ceCost.Location = New System.Drawing.Point(202, 230)
        Me.ceCost.Margin = New System.Windows.Forms.Padding(2)
        Me.ceCost.Name = "ceCost"
        Me.ceCost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceCost.Properties.Appearance.Options.UseFont = True
        Me.ceCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceCost.Size = New System.Drawing.Size(91, 26)
        Me.ceCost.TabIndex = 6
        '
        'ceWholesale
        '
        Me.ceWholesale.EnterMoveNextControl = True
        Me.ceWholesale.Location = New System.Drawing.Point(202, 301)
        Me.ceWholesale.Margin = New System.Windows.Forms.Padding(2)
        Me.ceWholesale.Name = "ceWholesale"
        Me.ceWholesale.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceWholesale.Properties.Appearance.Options.UseFont = True
        Me.ceWholesale.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceWholesale.Size = New System.Drawing.Size(91, 26)
        Me.ceWholesale.TabIndex = 8
        '
        'ceMin
        '
        Me.ceMin.EnterMoveNextControl = True
        Me.ceMin.Location = New System.Drawing.Point(202, 336)
        Me.ceMin.Margin = New System.Windows.Forms.Padding(2)
        Me.ceMin.Name = "ceMin"
        Me.ceMin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceMin.Properties.Appearance.Options.UseFont = True
        Me.ceMin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceMin.Size = New System.Drawing.Size(91, 26)
        Me.ceMin.TabIndex = 9
        '
        'ceMax
        '
        Me.ceMax.EnterMoveNextControl = True
        Me.ceMax.Location = New System.Drawing.Point(202, 372)
        Me.ceMax.Margin = New System.Windows.Forms.Padding(2)
        Me.ceMax.Name = "ceMax"
        Me.ceMax.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceMax.Properties.Appearance.Options.UseFont = True
        Me.ceMax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceMax.Size = New System.Drawing.Size(91, 26)
        Me.ceMax.TabIndex = 10
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.Location = New System.Drawing.Point(9, 420)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(81, 39)
        Me.btnNew.TabIndex = 12
        Me.btnNew.Text = "&New"
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(115, 420)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 39)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(221, 420)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 39)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "&Cancel"
        '
        'btnClose
        '
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(559, 420)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(81, 39)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "C&lose"
        '
        'compretail
        '
        Me.compretail.Enabled = False
        Me.compretail.Location = New System.Drawing.Point(186, 58)
        Me.compretail.Name = "compretail"
        Me.compretail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.compretail.Properties.Appearance.Options.UseFont = True
        Me.compretail.Size = New System.Drawing.Size(105, 26)
        Me.compretail.TabIndex = 1
        '
        'compmup2
        '
        Me.compmup2.Enabled = False
        Me.compmup2.Location = New System.Drawing.Point(186, 95)
        Me.compmup2.Name = "compmup2"
        Me.compmup2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.compmup2.Properties.Appearance.Options.UseFont = True
        Me.compmup2.Size = New System.Drawing.Size(105, 26)
        Me.compmup2.TabIndex = 2
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl17.Location = New System.Drawing.Point(54, 23)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(116, 19)
        Me.LabelControl17.TabIndex = 4
        Me.LabelControl17.Text = "Markup1 (Input)"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl18.Location = New System.Drawing.Point(24, 61)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(146, 19)
        Me.LabelControl18.TabIndex = 5
        Me.LabelControl18.Text = "Retail(Computed)"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl20.Location = New System.Drawing.Point(76, 137)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(94, 19)
        Me.LabelControl20.TabIndex = 7
        Me.LabelControl20.Text = "Retail (Input)"
        '
        'compmup1
        '
        Me.compmup1.EnterMoveNextControl = True
        Me.compmup1.Location = New System.Drawing.Point(186, 23)
        Me.compmup1.Margin = New System.Windows.Forms.Padding(2)
        Me.compmup1.Name = "compmup1"
        Me.compmup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.compmup1.Properties.Appearance.Options.UseFont = True
        Me.compmup1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.compmup1.Size = New System.Drawing.Size(105, 26)
        Me.compmup1.TabIndex = 0
        '
        'compwholesale
        '
        Me.compwholesale.EnterMoveNextControl = True
        Me.compwholesale.Location = New System.Drawing.Point(186, 130)
        Me.compwholesale.Margin = New System.Windows.Forms.Padding(2)
        Me.compwholesale.Name = "compwholesale"
        Me.compwholesale.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.compwholesale.Properties.Appearance.Options.UseFont = True
        Me.compwholesale.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.compwholesale.Size = New System.Drawing.Size(105, 26)
        Me.compwholesale.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl19)
        Me.GroupControl1.Controls.Add(Me.compwholesale)
        Me.GroupControl1.Controls.Add(Me.compmup1)
        Me.GroupControl1.Controls.Add(Me.LabelControl20)
        Me.GroupControl1.Controls.Add(Me.LabelControl18)
        Me.GroupControl1.Controls.Add(Me.LabelControl17)
        Me.GroupControl1.Controls.Add(Me.compmup2)
        Me.GroupControl1.Controls.Add(Me.compretail)
        Me.GroupControl1.Location = New System.Drawing.Point(309, 229)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(333, 173)
        Me.GroupControl1.TabIndex = 26
        Me.GroupControl1.Text = "Markup and Retail Computations"
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl19.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl19.Location = New System.Drawing.Point(5, 102)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(168, 19)
        Me.LabelControl19.TabIndex = 6
        Me.LabelControl19.Text = "Markup2(Computed)"
        '
        'leType
        '
        Me.leType.EditValue = ""
        Me.leType.Enabled = False
        Me.leType.EnterMoveNextControl = True
        Me.leType.Location = New System.Drawing.Point(202, 193)
        Me.leType.Margin = New System.Windows.Forms.Padding(2)
        Me.leType.Name = "leType"
        Me.leType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leType.Properties.Appearance.Options.UseFont = True
        Me.leType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sizeid", "sizeid", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sayz", "Type")})
        Me.leType.Size = New System.Drawing.Size(441, 26)
        Me.leType.TabIndex = 5
        '
        'ceRetail
        '
        Me.ceRetail.EnterMoveNextControl = True
        Me.ceRetail.Location = New System.Drawing.Point(202, 266)
        Me.ceRetail.Margin = New System.Windows.Forms.Padding(2)
        Me.ceRetail.Name = "ceRetail"
        Me.ceRetail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceRetail.Properties.Appearance.Options.UseFont = True
        Me.ceRetail.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceRetail.Size = New System.Drawing.Size(91, 26)
        Me.ceRetail.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(109, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Item Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(62, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Item Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(124, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Supplier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(118, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(140, 163)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Brand"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(149, 199)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label7.Location = New System.Drawing.Point(150, 236)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Cost"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label8.Location = New System.Drawing.Point(142, 272)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Retail"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label9.Location = New System.Drawing.Point(102, 307)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Whole sale"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label10.Location = New System.Drawing.Point(117, 342)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Minimum"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label11.Location = New System.Drawing.Point(113, 378)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 20)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Maximum"
        '
        'leBrand
        '
        Me.leBrand.EditValue = ""
        Me.leBrand.Enabled = False
        Me.leBrand.EnterMoveNextControl = True
        Me.leBrand.Location = New System.Drawing.Point(203, 157)
        Me.leBrand.Name = "leBrand"
        Me.leBrand.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leBrand.Properties.Appearance.Options.UseFont = True
        Me.leBrand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leBrand.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("deptid", "deptid", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DEPTD", "DEPTD")})
        Me.leBrand.Size = New System.Drawing.Size(440, 26)
        Me.leBrand.TabIndex = 4
        '
        'frmNewItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 469)
        Me.Controls.Add(Me.leBrand)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.leType)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.ceMax)
        Me.Controls.Add(Me.ceMin)
        Me.Controls.Add(Me.ceWholesale)
        Me.Controls.Add(Me.ceRetail)
        Me.Controls.Add(Me.ceCost)
        Me.Controls.Add(Me.leCategories)
        Me.Controls.Add(Me.leSuppliers)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.txtBarcode)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Items Entry Form"
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSuppliers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leCategories.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceWholesale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceMin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compretail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compmup2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compmup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compwholesale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceRetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBarcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents leSuppliers As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents leCategories As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ceCost As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceWholesale As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceMin As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceMax As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents compretail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents compmup2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents compmup1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents compwholesale As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ceRetail As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents leBrand As DevExpress.XtraEditors.LookUpEdit
End Class
