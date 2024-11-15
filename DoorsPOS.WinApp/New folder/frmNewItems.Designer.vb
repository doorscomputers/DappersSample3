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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtItem = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.leSuppliers = New DevExpress.XtraEditors.LookUpEdit()
        Me.leCategories = New DevExpress.XtraEditors.LookUpEdit()
        Me.ceCost = New DevExpress.XtraEditors.CalcEdit()
        Me.ceWholesale = New DevExpress.XtraEditors.CalcEdit()
        Me.ceMin = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.ceMax = New DevExpress.XtraEditors.CalcEdit()
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.leBrand = New DevExpress.XtraEditors.LookUpEdit()
        Me.compretail = New DevExpress.XtraEditors.TextEdit()
        Me.compmup2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.compmup1 = New DevExpress.XtraEditors.CalcEdit()
        Me.compws = New DevExpress.XtraEditors.CalcEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.leType = New DevExpress.XtraEditors.LookUpEdit()
        Me.ceRetail = New DevExpress.XtraEditors.CalcEdit()
        CType(Me.txtBarcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSuppliers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leCategories.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceWholesale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceMin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compretail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compmup2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compmup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compws.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceRetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBarcode
        '
        Me.txtBarcode.EnterMoveNextControl = True
        Me.txtBarcode.Location = New System.Drawing.Point(164, 18)
        Me.txtBarcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtBarcode.Properties.Appearance.Options.UseFont = True
        Me.txtBarcode.Size = New System.Drawing.Size(204, 26)
        Me.txtBarcode.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl1.Location = New System.Drawing.Point(83, 25)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Item Code"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl2.Location = New System.Drawing.Point(40, 62)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(117, 19)
        Me.LabelControl2.TabIndex = 14
        Me.LabelControl2.Text = "Item Description"
        '
        'txtItem
        '
        Me.txtItem.EnterMoveNextControl = True
        Me.txtItem.Location = New System.Drawing.Point(164, 55)
        Me.txtItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.txtItem.Properties.Appearance.Options.UseFont = True
        Me.txtItem.Size = New System.Drawing.Size(383, 26)
        Me.txtItem.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl3.Location = New System.Drawing.Point(99, 99)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Supplier"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl4.Location = New System.Drawing.Point(94, 136)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl4.TabIndex = 16
        Me.LabelControl4.Text = "Category"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl5.Location = New System.Drawing.Point(126, 252)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(31, 19)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Cost"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl6.Location = New System.Drawing.Point(118, 291)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(39, 19)
        Me.LabelControl6.TabIndex = 20
        Me.LabelControl6.Text = "Retail"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl9.Location = New System.Drawing.Point(86, 330)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl9.TabIndex = 21
        Me.LabelControl9.Text = "Wholesale"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl10.Location = New System.Drawing.Point(91, 370)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(66, 19)
        Me.LabelControl10.TabIndex = 22
        Me.LabelControl10.Text = "Minimum"
        '
        'leSuppliers
        '
        Me.leSuppliers.EnterMoveNextControl = True
        Me.leSuppliers.Location = New System.Drawing.Point(164, 92)
        Me.leSuppliers.Name = "leSuppliers"
        Me.leSuppliers.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leSuppliers.Properties.Appearance.Options.UseFont = True
        Me.leSuppliers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSuppliers.Size = New System.Drawing.Size(383, 26)
        Me.leSuppliers.TabIndex = 2
        '
        'leCategories
        '
        Me.leCategories.EnterMoveNextControl = True
        Me.leCategories.Location = New System.Drawing.Point(164, 129)
        Me.leCategories.Name = "leCategories"
        Me.leCategories.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leCategories.Properties.Appearance.Options.UseFont = True
        Me.leCategories.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leCategories.Size = New System.Drawing.Size(383, 26)
        Me.leCategories.TabIndex = 3
        '
        'ceCost
        '
        Me.ceCost.EnterMoveNextControl = True
        Me.ceCost.Location = New System.Drawing.Point(164, 245)
        Me.ceCost.Name = "ceCost"
        Me.ceCost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceCost.Properties.Appearance.Options.UseFont = True
        Me.ceCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceCost.Size = New System.Drawing.Size(100, 26)
        Me.ceCost.TabIndex = 6
        '
        'ceWholesale
        '
        Me.ceWholesale.EnterMoveNextControl = True
        Me.ceWholesale.Location = New System.Drawing.Point(164, 323)
        Me.ceWholesale.Name = "ceWholesale"
        Me.ceWholesale.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceWholesale.Properties.Appearance.Options.UseFont = True
        Me.ceWholesale.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceWholesale.Size = New System.Drawing.Size(100, 26)
        Me.ceWholesale.TabIndex = 8
        '
        'ceMin
        '
        Me.ceMin.EnterMoveNextControl = True
        Me.ceMin.Location = New System.Drawing.Point(164, 363)
        Me.ceMin.Name = "ceMin"
        Me.ceMin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceMin.Properties.Appearance.Options.UseFont = True
        Me.ceMin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceMin.Size = New System.Drawing.Size(100, 26)
        Me.ceMin.TabIndex = 9
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl15.Location = New System.Drawing.Point(88, 405)
        Me.LabelControl15.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(69, 19)
        Me.LabelControl15.TabIndex = 23
        Me.LabelControl15.Text = "Maximum"
        '
        'ceMax
        '
        Me.ceMax.EnterMoveNextControl = True
        Me.ceMax.Location = New System.Drawing.Point(164, 398)
        Me.ceMax.Name = "ceMax"
        Me.ceMax.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceMax.Properties.Appearance.Options.UseFont = True
        Me.ceMax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceMax.Size = New System.Drawing.Size(100, 26)
        Me.ceMax.TabIndex = 10
        '
        'btnNew
        '
        Me.btnNew.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnNew.Appearance.Options.UseFont = True
        Me.btnNew.Location = New System.Drawing.Point(12, 459)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(84, 30)
        Me.btnNew.TabIndex = 12
        Me.btnNew.Text = "&New"
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(122, 459)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 30)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(232, 459)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 30)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "&Cancel"
        '
        'btnClose
        '
        Me.btnClose.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnClose.Appearance.Options.UseFont = True
        Me.btnClose.Location = New System.Drawing.Point(463, 459)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(84, 30)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "C&lose"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl11.Location = New System.Drawing.Point(116, 173)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(41, 19)
        Me.LabelControl11.TabIndex = 17
        Me.LabelControl11.Text = "Brand"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl16.Location = New System.Drawing.Point(122, 210)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(35, 19)
        Me.LabelControl16.TabIndex = 18
        Me.LabelControl16.Text = "Type"
        '
        'leBrand
        '
        Me.leBrand.EnterMoveNextControl = True
        Me.leBrand.Location = New System.Drawing.Point(165, 166)
        Me.leBrand.Name = "leBrand"
        Me.leBrand.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leBrand.Properties.Appearance.Options.UseFont = True
        Me.leBrand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leBrand.Size = New System.Drawing.Size(383, 26)
        Me.leBrand.TabIndex = 4
        '
        'compretail
        '
        Me.compretail.Location = New System.Drawing.Point(159, 65)
        Me.compretail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.compretail.Name = "compretail"
        Me.compretail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.compretail.Properties.Appearance.Options.UseFont = True
        Me.compretail.Size = New System.Drawing.Size(100, 26)
        Me.compretail.TabIndex = 1
        '
        'compmup2
        '
        Me.compmup2.Location = New System.Drawing.Point(160, 105)
        Me.compmup2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.compmup2.Name = "compmup2"
        Me.compmup2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.compmup2.Properties.Appearance.Options.UseFont = True
        Me.compmup2.Size = New System.Drawing.Size(99, 26)
        Me.compmup2.TabIndex = 2
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl17.Location = New System.Drawing.Point(91, 35)
        Me.LabelControl17.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl17.TabIndex = 4
        Me.LabelControl17.Text = "Markup1"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl18.Location = New System.Drawing.Point(28, 72)
        Me.LabelControl18.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(124, 19)
        Me.LabelControl18.TabIndex = 5
        Me.LabelControl18.Text = "Retail(Computed)"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl20.Location = New System.Drawing.Point(81, 146)
        Me.LabelControl20.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl20.TabIndex = 7
        Me.LabelControl20.Text = "Wholesale"
        '
        'compmup1
        '
        Me.compmup1.EnterMoveNextControl = True
        Me.compmup1.Location = New System.Drawing.Point(159, 28)
        Me.compmup1.Name = "compmup1"
        Me.compmup1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.compmup1.Properties.Appearance.Options.UseFont = True
        Me.compmup1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.compmup1.Size = New System.Drawing.Size(100, 26)
        Me.compmup1.TabIndex = 0
        '
        'compws
        '
        Me.compws.EnterMoveNextControl = True
        Me.compws.Location = New System.Drawing.Point(159, 139)
        Me.compws.Name = "compws"
        Me.compws.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.compws.Properties.Appearance.Options.UseFont = True
        Me.compws.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.compws.Size = New System.Drawing.Size(100, 26)
        Me.compws.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl19)
        Me.GroupControl1.Controls.Add(Me.compws)
        Me.GroupControl1.Controls.Add(Me.compmup1)
        Me.GroupControl1.Controls.Add(Me.LabelControl20)
        Me.GroupControl1.Controls.Add(Me.LabelControl18)
        Me.GroupControl1.Controls.Add(Me.LabelControl17)
        Me.GroupControl1.Controls.Add(Me.compmup2)
        Me.GroupControl1.Controls.Add(Me.compretail)
        Me.GroupControl1.Location = New System.Drawing.Point(273, 243)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(274, 181)
        Me.GroupControl1.TabIndex = 26
        Me.GroupControl1.Text = "Markup and Retail Computations"
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.LabelControl19.Location = New System.Drawing.Point(10, 112)
        Me.LabelControl19.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(146, 19)
        Me.LabelControl19.TabIndex = 6
        Me.LabelControl19.Text = "Markup2(Computed)"
        '
        'leType
        '
        Me.leType.EnterMoveNextControl = True
        Me.leType.Location = New System.Drawing.Point(165, 203)
        Me.leType.Name = "leType"
        Me.leType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.leType.Properties.Appearance.Options.UseFont = True
        Me.leType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leType.Size = New System.Drawing.Size(383, 26)
        Me.leType.TabIndex = 5
        '
        'ceRetail
        '
        Me.ceRetail.EnterMoveNextControl = True
        Me.ceRetail.Location = New System.Drawing.Point(164, 284)
        Me.ceRetail.Name = "ceRetail"
        Me.ceRetail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.ceRetail.Properties.Appearance.Options.UseFont = True
        Me.ceRetail.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ceRetail.Size = New System.Drawing.Size(100, 26)
        Me.ceRetail.TabIndex = 7
        '
        'frmNewItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 500)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.leType)
        Me.Controls.Add(Me.leBrand)
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
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.txtBarcode)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
        CType(Me.leBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compretail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compmup2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compmup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compws.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceRetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBarcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtItem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSuppliers As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents leCategories As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ceCost As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceWholesale As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents ceMin As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ceMax As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leBrand As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents compretail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents compmup2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents compmup1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents compws As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ceRetail As DevExpress.XtraEditors.CalcEdit
End Class
