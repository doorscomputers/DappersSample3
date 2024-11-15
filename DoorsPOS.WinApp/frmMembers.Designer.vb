<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembers
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
        Dim C1DataView1 As C1.C1DataExtender.C1DataView
        Dim C1ViewColumn1 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn2 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn3 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn4 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn5 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn6 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn7 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn8 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn9 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn10 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn11 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn12 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn13 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn14 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn15 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn16 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn17 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Dim C1ViewColumn18 As C1.C1DataExtender.C1ViewColumn = New C1.C1DataExtender.C1ViewColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCustID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collastname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfirstname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmiddlename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladdress3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcontact_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.C1DataViewSet1 = New C1.C1DataExtender.C1DataViewSet()
        Me.DsMembers = New DoorsPOS.WinApp.dsMembers()
        C1DataView1 = New C1.C1DataExtender.C1DataView()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DataView1
        '
        C1ViewColumn1.ColumnNameSerialized = "CustID"
        C1ViewColumn2.ColumnNameSerialized = "lastname"
        C1ViewColumn3.ColumnNameSerialized = "firstname"
        C1ViewColumn4.ColumnNameSerialized = "middlename"
        C1ViewColumn5.ColumnNameSerialized = "address1"
        C1ViewColumn6.ColumnNameSerialized = "address2"
        C1ViewColumn7.ColumnNameSerialized = "address3"
        C1ViewColumn8.ColumnNameSerialized = "contact_no"
        C1ViewColumn9.ColumnNameSerialized = "id_num"
        C1ViewColumn10.ColumnNameSerialized = "point_div"
        C1ViewColumn11.ColumnNameSerialized = "poynts"
        C1ViewColumn12.ColumnNameSerialized = "pa"
        C1ViewColumn13.ColumnNameSerialized = "Balance"
        C1ViewColumn14.ColumnNameSerialized = "sInsert_id"
        C1ViewColumn15.ColumnNameSerialized = "dtInsert_dt"
        C1ViewColumn16.ColumnNameSerialized = "sLastUpdate_id"
        C1ViewColumn17.ColumnNameSerialized = "dtLastUpdate_dt"
        C1ViewColumn18.ColumnNameSerialized = "iConcurrency_id"
        C1DataView1.ColumnDefs.Add(C1ViewColumn1)
        C1DataView1.ColumnDefs.Add(C1ViewColumn2)
        C1DataView1.ColumnDefs.Add(C1ViewColumn3)
        C1DataView1.ColumnDefs.Add(C1ViewColumn4)
        C1DataView1.ColumnDefs.Add(C1ViewColumn5)
        C1DataView1.ColumnDefs.Add(C1ViewColumn6)
        C1DataView1.ColumnDefs.Add(C1ViewColumn7)
        C1DataView1.ColumnDefs.Add(C1ViewColumn8)
        C1DataView1.ColumnDefs.Add(C1ViewColumn9)
        C1DataView1.ColumnDefs.Add(C1ViewColumn10)
        C1DataView1.ColumnDefs.Add(C1ViewColumn11)
        C1DataView1.ColumnDefs.Add(C1ViewColumn12)
        C1DataView1.ColumnDefs.Add(C1ViewColumn13)
        C1DataView1.ColumnDefs.Add(C1ViewColumn14)
        C1DataView1.ColumnDefs.Add(C1ViewColumn15)
        C1DataView1.ColumnDefs.Add(C1ViewColumn16)
        C1DataView1.ColumnDefs.Add(C1ViewColumn17)
        C1DataView1.ColumnDefs.Add(C1ViewColumn18)
        C1DataView1.Definition = "SELECT * FROM [members]"
        C1DataView1.DefinitionDiagramXML = ""
        C1DataView1.ViewName = "members"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = C1DataView1
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(955, 490)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustID, Me.collastname, Me.colfirstname, Me.colmiddlename, Me.coladdress1, Me.coladdress2, Me.coladdress3, Me.colcontact_no, Me.colBalance})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.GridView1.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCustID
        '
        Me.colCustID.FieldName = "CustID"
        Me.colCustID.Name = "colCustID"
        '
        'collastname
        '
        Me.collastname.Caption = "Last Name"
        Me.collastname.FieldName = "lastname"
        Me.collastname.Name = "collastname"
        Me.collastname.Visible = True
        Me.collastname.VisibleIndex = 0
        '
        'colfirstname
        '
        Me.colfirstname.Caption = "First Name"
        Me.colfirstname.FieldName = "firstname"
        Me.colfirstname.Name = "colfirstname"
        Me.colfirstname.Visible = True
        Me.colfirstname.VisibleIndex = 1
        '
        'colmiddlename
        '
        Me.colmiddlename.Caption = "Middle Name"
        Me.colmiddlename.FieldName = "middlename"
        Me.colmiddlename.Name = "colmiddlename"
        Me.colmiddlename.Visible = True
        Me.colmiddlename.VisibleIndex = 2
        '
        'coladdress1
        '
        Me.coladdress1.Caption = "Address1"
        Me.coladdress1.FieldName = "address1"
        Me.coladdress1.Name = "coladdress1"
        Me.coladdress1.Visible = True
        Me.coladdress1.VisibleIndex = 3
        '
        'coladdress2
        '
        Me.coladdress2.Caption = "Address2"
        Me.coladdress2.FieldName = "address2"
        Me.coladdress2.Name = "coladdress2"
        Me.coladdress2.Visible = True
        Me.coladdress2.VisibleIndex = 4
        '
        'coladdress3
        '
        Me.coladdress3.Caption = "Address3"
        Me.coladdress3.FieldName = "address3"
        Me.coladdress3.Name = "coladdress3"
        Me.coladdress3.Visible = True
        Me.coladdress3.VisibleIndex = 5
        '
        'colcontact_no
        '
        Me.colcontact_no.Caption = "Contact Number"
        Me.colcontact_no.FieldName = "contact_no"
        Me.colcontact_no.Name = "colcontact_no"
        Me.colcontact_no.Visible = True
        Me.colcontact_no.VisibleIndex = 6
        '
        'colBalance
        '
        Me.colBalance.Caption = "Balance"
        Me.colBalance.DisplayFormat.FormatString = "N2"
        Me.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBalance.FieldName = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Balance", "SUM={0:N2}")})
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 7
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleButton1.Location = New System.Drawing.Point(0, 508)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(972, 38)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Save Changes to the Database"
        '
        'C1DataViewSet1
        '
        Me.C1DataViewSet1.DataSet = Me.DsMembers
        Me.C1DataViewSet1.DiagramXML = "<C1Diagram><Nodes><Node DesigningObjectName=""members""><Location X=""10"" Y=""10"" /><" & _
    "Size Width=""164"" Height=""124"" /></Node></Nodes></C1Diagram>"
        Me.C1DataViewSet1.Views.Add(C1DataView1)
        '
        'DsMembers
        '
        Me.DsMembers.DataSetName = "dsMembers"
        Me.DsMembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 546)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmMembers"
        Me.Text = "Members"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DataViewSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents C1DataViewSet1 As C1.C1DataExtender.C1DataViewSet
    Friend WithEvents DsMembers As DoorsPOS.WinApp.dsMembers
    Friend WithEvents colCustID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmiddlename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladdress3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcontact_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
End Class
