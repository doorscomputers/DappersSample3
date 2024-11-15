'Imports DevExpress.XtraBars.Ribbon
'Imports DevExpress.XtraBars.Helpers
'Imports KellermanSoftware.NetDataAccessLayer
Imports System.Data.SqlClient
Imports System.Management
Imports DevExpress.XtraReports.UI
Imports PDSA.Validation
Imports Z.Dapper.Plus

Public Class frmMain
    Inherits PDSAFormBase

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        ' Track User Flag must be set here or it won't be set in time
        ' MyBase.UserTrack = False

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        ' This is done for apparent speed
        Dim ctlSelected As Control
        ctlSelected = PDSAForms.GetActiveMDIChildControl(Me)

        'Add any initialization after the InitializeComponent() call

        '*** NEED TO TURN THIS OFF FOR THE MAIN FORM ***
        '*** WE NEED TO WAIT UNTIL WE LOGIN FIRST ***
        MyBase.CheckSecurityOnControls = False
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents mnuMain As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWindow As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHFramework As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHAbout As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWCloseAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFSignOut As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSecurity As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSPermission As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSRoles As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSUsers As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLookups As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLException As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLUserTrack As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSUsersToRoles As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSRolesToPermissions As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSSecControls As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLUserLogin As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSPwdChange As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMWinFormMaint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSUserCategory As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPOS As System.Windows.Forms.MenuItem
    Friend WithEvents mnuNewItems As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemGrid As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem145 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem154 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem155 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem156 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem158 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem159 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem160 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem161 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem162 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem163 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem166 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem167 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem171 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBank As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCategory As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBrand As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem172 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem173 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCustomers As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem176 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemCost As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem175 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditItems As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As MenuItem
    Friend WithEvents MenuItem23 As MenuItem
    Friend WithEvents mnuReprintZReading As MenuItem
    Friend WithEvents mnuSettings As MenuItem
    Friend WithEvents mnuAdmin As MenuItem
    Friend WithEvents MenuItem2 As MenuItem
    Friend WithEvents mnuSSep2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mnuMain = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuNewItems = New System.Windows.Forms.MenuItem()
        Me.mnuEditItems = New System.Windows.Forms.MenuItem()
        Me.MenuItem176 = New System.Windows.Forms.MenuItem()
        Me.mnuItemGrid = New System.Windows.Forms.MenuItem()
        Me.mnuItemCost = New System.Windows.Forms.MenuItem()
        Me.MenuItem175 = New System.Windows.Forms.MenuItem()
        Me.MenuItem166 = New System.Windows.Forms.MenuItem()
        Me.MenuItem167 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem151 = New System.Windows.Forms.MenuItem()
        Me.MenuItem152 = New System.Windows.Forms.MenuItem()
        Me.mnuReprintZReading = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.mnuAdmin = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem95 = New System.Windows.Forms.MenuItem()
        Me.MenuItem155 = New System.Windows.Forms.MenuItem()
        Me.MenuItem156 = New System.Windows.Forms.MenuItem()
        Me.MenuItem96 = New System.Windows.Forms.MenuItem()
        Me.MenuItem97 = New System.Windows.Forms.MenuItem()
        Me.MenuItem98 = New System.Windows.Forms.MenuItem()
        Me.MenuItem99 = New System.Windows.Forms.MenuItem()
        Me.MenuItem100 = New System.Windows.Forms.MenuItem()
        Me.mnuBank = New System.Windows.Forms.MenuItem()
        Me.MenuItem158 = New System.Windows.Forms.MenuItem()
        Me.mnuBrand = New System.Windows.Forms.MenuItem()
        Me.MenuItem172 = New System.Windows.Forms.MenuItem()
        Me.MenuItem173 = New System.Windows.Forms.MenuItem()
        Me.mnuCategory = New System.Windows.Forms.MenuItem()
        Me.mnuCustomers = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.mnuSettings = New System.Windows.Forms.MenuItem()
        Me.MenuItem159 = New System.Windows.Forms.MenuItem()
        Me.MenuItem145 = New System.Windows.Forms.MenuItem()
        Me.MenuItem160 = New System.Windows.Forms.MenuItem()
        Me.MenuItem161 = New System.Windows.Forms.MenuItem()
        Me.MenuItem162 = New System.Windows.Forms.MenuItem()
        Me.MenuItem163 = New System.Windows.Forms.MenuItem()
        Me.mnuFSignOut = New System.Windows.Forms.MenuItem()
        Me.mnuFExit = New System.Windows.Forms.MenuItem()
        Me.mnuPOS = New System.Windows.Forms.MenuItem()
        Me.mnuSecurity = New System.Windows.Forms.MenuItem()
        Me.mnuSPermission = New System.Windows.Forms.MenuItem()
        Me.mnuSRoles = New System.Windows.Forms.MenuItem()
        Me.mnuSUserCategory = New System.Windows.Forms.MenuItem()
        Me.mnuSUsers = New System.Windows.Forms.MenuItem()
        Me.mnuSSep1 = New System.Windows.Forms.MenuItem()
        Me.mnuSUsersToRoles = New System.Windows.Forms.MenuItem()
        Me.mnuSRolesToPermissions = New System.Windows.Forms.MenuItem()
        Me.mnuSSep2 = New System.Windows.Forms.MenuItem()
        Me.mnuSSecControls = New System.Windows.Forms.MenuItem()
        Me.mnuSPwdChange = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuMWinFormMaint = New System.Windows.Forms.MenuItem()
        Me.mnuLookups = New System.Windows.Forms.MenuItem()
        Me.mnuLException = New System.Windows.Forms.MenuItem()
        Me.mnuLUserTrack = New System.Windows.Forms.MenuItem()
        Me.mnuLUserLogin = New System.Windows.Forms.MenuItem()
        Me.MenuItem171 = New System.Windows.Forms.MenuItem()
        Me.mnuWindow = New System.Windows.Forms.MenuItem()
        Me.MenuItem82 = New System.Windows.Forms.MenuItem()
        Me.MenuItem81 = New System.Windows.Forms.MenuItem()
        Me.MenuItem79 = New System.Windows.Forms.MenuItem()
        Me.MenuItem80 = New System.Windows.Forms.MenuItem()
        Me.mnuWCloseAll = New System.Windows.Forms.MenuItem()
        Me.MenuItem154 = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuHFramework = New System.Windows.Forms.MenuItem()
        Me.mnuHAbout = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuPOS, Me.mnuSecurity, Me.MenuItem1, Me.mnuLookups, Me.MenuItem171, Me.mnuWindow, Me.mnuHelp, Me.MenuItem2})
        '
        'mnuFile
        '
        Me.mnuFile.Enabled = False
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuNewItems, Me.mnuEditItems, Me.MenuItem176, Me.mnuItemGrid, Me.mnuItemCost, Me.MenuItem175, Me.MenuItem166, Me.MenuItem167, Me.MenuItem10, Me.MenuItem151, Me.MenuItem152, Me.mnuReprintZReading, Me.MenuItem14, Me.mnuAdmin, Me.MenuItem23, Me.MenuItem95, Me.MenuItem100, Me.mnuBank, Me.MenuItem158, Me.mnuBrand, Me.MenuItem172, Me.MenuItem173, Me.mnuCategory, Me.mnuCustomers, Me.MenuItem17, Me.mnuSettings, Me.MenuItem159, Me.MenuItem145, Me.MenuItem160, Me.MenuItem161, Me.MenuItem162, Me.MenuItem163, Me.mnuFSignOut, Me.mnuFExit})
        Me.mnuFile.Text = "&File"
        Me.mnuFile.Visible = False
        '
        'mnuNewItems
        '
        Me.mnuNewItems.Enabled = False
        Me.mnuNewItems.Index = 0
        Me.mnuNewItems.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.mnuNewItems.Text = "New Items Entry Form"
        Me.mnuNewItems.Visible = False
        '
        'mnuEditItems
        '
        Me.mnuEditItems.Index = 1
        Me.mnuEditItems.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.mnuEditItems.Text = "Edit Items"
        '
        'MenuItem176
        '
        Me.MenuItem176.Index = 2
        Me.MenuItem176.Text = "-"
        '
        'mnuItemGrid
        '
        Me.mnuItemGrid.Index = 3
        Me.mnuItemGrid.Shortcut = System.Windows.Forms.Shortcut.CtrlG
        Me.mnuItemGrid.Text = "Items Grid View"
        '
        'mnuItemCost
        '
        Me.mnuItemCost.Index = 4
        Me.mnuItemCost.Text = "Items with Cost Grid View"
        '
        'MenuItem175
        '
        Me.MenuItem175.Index = 5
        Me.MenuItem175.Text = "-"
        '
        'MenuItem166
        '
        Me.MenuItem166.Index = 6
        Me.MenuItem166.Text = "New Item Barcode Form"
        Me.MenuItem166.Visible = False
        '
        'MenuItem167
        '
        Me.MenuItem167.Index = 7
        Me.MenuItem167.Text = "Item Barcode Grid View"
        Me.MenuItem167.Visible = False
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 8
        Me.MenuItem10.Text = "-"
        '
        'MenuItem151
        '
        Me.MenuItem151.Index = 9
        Me.MenuItem151.Text = "Cashier Reading Ref. Nos."
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 10
        Me.MenuItem152.Text = "Re-Print X Reading"
        '
        'mnuReprintZReading
        '
        Me.mnuReprintZReading.Index = 11
        Me.mnuReprintZReading.Text = "Re-Print Z Reading"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 12
        Me.MenuItem14.Text = "-"
        '
        'mnuAdmin
        '
        Me.mnuAdmin.Index = 13
        Me.mnuAdmin.Text = "Admin"
        Me.mnuAdmin.Visible = False
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 14
        Me.MenuItem23.Text = "Employees"
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 15
        Me.MenuItem95.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem155, Me.MenuItem156, Me.MenuItem96, Me.MenuItem97, Me.MenuItem98, Me.MenuItem99})
        Me.MenuItem95.Text = "Employees"
        Me.MenuItem95.Visible = False
        '
        'MenuItem155
        '
        Me.MenuItem155.Index = 0
        Me.MenuItem155.Text = "Employee Add/Edit/Delete"
        '
        'MenuItem156
        '
        Me.MenuItem156.Index = 1
        Me.MenuItem156.Text = "-"
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = 2
        Me.MenuItem96.Text = "Time In"
        '
        'MenuItem97
        '
        Me.MenuItem97.Index = 3
        Me.MenuItem97.Text = "Break"
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 4
        Me.MenuItem98.Text = "Time In after Break"
        '
        'MenuItem99
        '
        Me.MenuItem99.Index = 5
        Me.MenuItem99.Text = "Time Out"
        '
        'MenuItem100
        '
        Me.MenuItem100.Index = 16
        Me.MenuItem100.Text = "-"
        '
        'mnuBank
        '
        Me.mnuBank.Index = 17
        Me.mnuBank.Text = "Bank"
        '
        'MenuItem158
        '
        Me.MenuItem158.Index = 18
        Me.MenuItem158.Text = "Supplier"
        '
        'mnuBrand
        '
        Me.mnuBrand.Index = 19
        Me.mnuBrand.Text = "Brand"
        '
        'MenuItem172
        '
        Me.MenuItem172.Index = 20
        Me.MenuItem172.Text = "Type of Expenses"
        '
        'MenuItem173
        '
        Me.MenuItem173.Index = 21
        Me.MenuItem173.Text = "Item Type/Sizes"
        '
        'mnuCategory
        '
        Me.mnuCategory.Index = 22
        Me.mnuCategory.Text = "Category"
        '
        'mnuCustomers
        '
        Me.mnuCustomers.Index = 23
        Me.mnuCustomers.Text = "Customers"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 24
        Me.MenuItem17.Text = "Location(Other Branch)"
        Me.MenuItem17.Visible = False
        '
        'mnuSettings
        '
        Me.mnuSettings.Index = 25
        Me.mnuSettings.Text = "Settings"
        '
        'MenuItem159
        '
        Me.MenuItem159.Index = 26
        Me.MenuItem159.Text = "-"
        '
        'MenuItem145
        '
        Me.MenuItem145.Index = 27
        Me.MenuItem145.Text = "Next &Counter"
        Me.MenuItem145.Visible = False
        '
        'MenuItem160
        '
        Me.MenuItem160.Index = 28
        Me.MenuItem160.Text = "-"
        '
        'MenuItem161
        '
        Me.MenuItem161.Index = 29
        Me.MenuItem161.Text = "&Backup"
        '
        'MenuItem162
        '
        Me.MenuItem162.Index = 30
        Me.MenuItem162.Text = "&Restore"
        Me.MenuItem162.Visible = False
        '
        'MenuItem163
        '
        Me.MenuItem163.Index = 31
        Me.MenuItem163.Text = "-"
        '
        'mnuFSignOut
        '
        Me.mnuFSignOut.Index = 32
        Me.mnuFSignOut.Text = "Sign &Out"
        '
        'mnuFExit
        '
        Me.mnuFExit.Index = 33
        Me.mnuFExit.Text = "E&xit"
        '
        'mnuPOS
        '
        Me.mnuPOS.Index = 1
        Me.mnuPOS.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.mnuPOS.Text = "POS"
        '
        'mnuSecurity
        '
        Me.mnuSecurity.Index = 2
        Me.mnuSecurity.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSPermission, Me.mnuSRoles, Me.mnuSUserCategory, Me.mnuSUsers, Me.mnuSSep1, Me.mnuSUsersToRoles, Me.mnuSRolesToPermissions, Me.mnuSSep2, Me.mnuSSecControls, Me.mnuSPwdChange})
        Me.mnuSecurity.Text = "Security"
        '
        'mnuSPermission
        '
        Me.mnuSPermission.Index = 0
        Me.mnuSPermission.Text = "Permission"
        Me.mnuSPermission.Visible = False
        '
        'mnuSRoles
        '
        Me.mnuSRoles.Index = 1
        Me.mnuSRoles.Text = "Roles"
        '
        'mnuSUserCategory
        '
        Me.mnuSUserCategory.Index = 2
        Me.mnuSUserCategory.Text = "User Category"
        '
        'mnuSUsers
        '
        Me.mnuSUsers.Index = 3
        Me.mnuSUsers.Text = "Users"
        '
        'mnuSSep1
        '
        Me.mnuSSep1.Index = 4
        Me.mnuSSep1.Text = "-"
        '
        'mnuSUsersToRoles
        '
        Me.mnuSUsersToRoles.Index = 5
        Me.mnuSUsersToRoles.Text = "Map Users To Roles"
        Me.mnuSUsersToRoles.Visible = False
        '
        'mnuSRolesToPermissions
        '
        Me.mnuSRolesToPermissions.Index = 6
        Me.mnuSRolesToPermissions.Text = "Map Roles To Permissions"
        Me.mnuSRolesToPermissions.Visible = False
        '
        'mnuSSep2
        '
        Me.mnuSSep2.Index = 7
        Me.mnuSSep2.Text = "-"
        '
        'mnuSSecControls
        '
        Me.mnuSSecControls.Index = 8
        Me.mnuSSecControls.Text = "Security Controls"
        '
        'mnuSPwdChange
        '
        Me.mnuSPwdChange.Index = 9
        Me.mnuSPwdChange.Text = "Change Password"
        '
        'MenuItem1
        '
        Me.MenuItem1.Enabled = False
        Me.MenuItem1.Index = 3
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMWinFormMaint})
        Me.MenuItem1.Text = "Maintenance"
        Me.MenuItem1.Visible = False
        '
        'mnuMWinFormMaint
        '
        Me.mnuMWinFormMaint.Index = 0
        Me.mnuMWinFormMaint.Text = "Win Form Creator Maint"
        '
        'mnuLookups
        '
        Me.mnuLookups.Enabled = False
        Me.mnuLookups.Index = 4
        Me.mnuLookups.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuLException, Me.mnuLUserTrack, Me.mnuLUserLogin})
        Me.mnuLookups.Text = "Lookups"
        Me.mnuLookups.Visible = False
        '
        'mnuLException
        '
        Me.mnuLException.Index = 0
        Me.mnuLException.Text = "Errors"
        Me.mnuLException.Visible = False
        '
        'mnuLUserTrack
        '
        Me.mnuLUserTrack.Index = 1
        Me.mnuLUserTrack.Text = "User Tracking"
        Me.mnuLUserTrack.Visible = False
        '
        'mnuLUserLogin
        '
        Me.mnuLUserLogin.Index = 2
        Me.mnuLUserLogin.Text = "User Logins"
        '
        'MenuItem171
        '
        Me.MenuItem171.Index = 5
        Me.MenuItem171.Text = "E&xit"
        '
        'mnuWindow
        '
        Me.mnuWindow.Enabled = False
        Me.mnuWindow.Index = 6
        Me.mnuWindow.MdiList = True
        Me.mnuWindow.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem82, Me.MenuItem81, Me.MenuItem79, Me.MenuItem80, Me.mnuWCloseAll, Me.MenuItem154})
        Me.mnuWindow.Text = "&Window"
        Me.mnuWindow.Visible = False
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 0
        Me.MenuItem82.Text = "Tile Vertical"
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 1
        Me.MenuItem81.Text = "Tile Horizontal"
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 2
        Me.MenuItem79.Text = "Cascade Open Windows"
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 3
        Me.MenuItem80.Text = "-"
        '
        'mnuWCloseAll
        '
        Me.mnuWCloseAll.Index = 4
        Me.mnuWCloseAll.Text = "&Close All"
        '
        'MenuItem154
        '
        Me.MenuItem154.Index = 5
        Me.MenuItem154.Text = "TestKellerman"
        Me.MenuItem154.Visible = False
        '
        'mnuHelp
        '
        Me.mnuHelp.Enabled = False
        Me.mnuHelp.Index = 7
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHFramework, Me.mnuHAbout})
        Me.mnuHelp.Text = "&Help"
        Me.mnuHelp.Visible = False
        '
        'mnuHFramework
        '
        Me.mnuHFramework.Index = 0
        Me.mnuHFramework.Text = "DOORS98 COMPUTERS"
        '
        'mnuHAbout
        '
        Me.mnuHAbout.Index = 1
        Me.mnuHAbout.Text = "&About..."
        Me.mnuHAbout.Visible = False
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 8
        Me.MenuItem2.Text = "Test Dapper"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1073, 600)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Menu = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "DOERS Multipurpose Cooperative TERMINAL 1 "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' PDSA Forms Tracker tracks MDI Child Forms
    ' so they can only be opened one time
    Private mFormsTracker As PDSAFormsTracker
    'Public MyHDDGen As FiveSevenNine
    Dim strFive As String
    Dim strSeven As String
    Dim strNine As String
    Private MyHDDGen As FiveSevenNine
    Private Sub PDSAFormBase_KeyDown(ByVal sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DapperPlusManager.AddLicense("814;701-DELTAFOX", "2C93C81-31A3A43-A5A3581-86BA5D7-BD2F")
        'Dim strcompname As String = Environment.MachineName
        'If strcompname <> "TERMINAL1" Then
        '    Me.Close()
        '    Exit Sub
        'End If
        'Dim mgrRet As pos_hdrManager
        'Dim col33 As pos_hdrCollection
        'mgrRet = New pos_hdrManager()

        'Dim vdate As Date = CDate("02/30/2028")
        'Dim vnow As Date = Date.Today

        'If vdate < vnow Then
        '    Me.Close()
        '    Exit Sub
        'End If
        ''tbSQL.Text = mgrRetrieve.DataObject.SQL
        'col33 = mgrRet.BuildCollection
        'If mgrRet.DataObject.RowsAffected > 60000000 Then
        '    'Note this is only for Engineer Salming
        '    MessageBox.Show("Evaluation Period is more than 30 days. Pls contact Mr. Warren Dulnuan for proper licensing option (09176553488)", "Evaluation Period Expired")
        '    Me.Close()
        '    Exit Sub
        'End If
        Dim boolPerform As Boolean = False
        'SkinHelper.InitSkinGallery(PopupMenu1)
        'SkinHelper.InitSkinPopupMenu(PopupMenu1)
        Try
            '* UnComment the following lines if you have:
            '*   - Moved all config settings to registry
            '*   - Are not using Encryption
            'PDSAAppConfig.OverrideAllConfigSettings = True
            'PDSAAppConfig.UseRegistry = True
            'PDSAAppConfig.RegistryConfigKey = "Software\ATest4"

            '* UnComment the following lines if you have:
            '*   - Moved all config settings to XML file
            '*   - Removed all settings from within the <PDSAAppConfig> element
            '*   - Are not using Encryption
            'PDSAAppConfig.OverrideAllConfigSettings = True
            'PDSAAppConfig.UseXMLFile = True
            'PDSAAppConfig.XMLConfigFile = "<Put Full Path Here>"

            '* Add the following line if you have encrypted all values
            'PDSAAppConfig.AllEncrypted = True

            '* If you are using encryption (Either all or just Connect Strings)
            '* Fill in the encryption type you have used: 
            '*    - PDSA0, PDSA1, etc.
            'PDSAAppConfig.ConnectStringsEncryptionType = ""

            '* Add the following line if you stored your Encryption Keys in the Registry
            'PDSAAppConfig.EncKeyRegKey = "Software\ATest4Keys"

            '* Add the following line if you stored your Encryption Keys in an XML File.
            '* NOTE: You must use a real path, not a URL path here.
            'PDSAAppConfig.EncKeyXMLFile = ""

            ' Load the settings into the PDSAAppConfig Class
            PDSAAppConfig.Init()
            PDSADataLayer.DBDateFormat = PDSAAppConfigBase.DBDateFormat
            PDSADataLayer.DBLanguage = PDSAAppConfigBase.DBLanguage

            ' Reset Database Driver Type and Assembly Info
            PDSA.Common.PDSAAppConfigBase.ResetDatabaseDriver(PDSAAppConfig.ConnectString)

            boolPerform = True

        Catch ex As Exception
            boolPerform = False
            MessageBox.Show(ex.Message, "Error in PDSAAppConfig")

        End Try

        If boolPerform Then
            Try
                '*********************************************************
                '* Load all Your Custom Values from WinAppConfig Section *
                '*********************************************************
                WinAppConfig.Init()

                boolPerform = True

            Catch ex As Exception
                boolPerform = False
                MessageBox.Show(ex.Message, "Error in PDSAAppConfig")

            End Try
        End If

        If Not PDSAAppConfig.ConfigFound Then
            Dim ex As ApplicationException

            ex = New ApplicationException("WARNING! Configuration not found for AppName: " & PDSAAppConfig.AppName & ". Using Default Settings.")
            PDSAException.Publish(ex)

            MessageBox.Show("WARNING! Configuration not found for AppName: " & PDSAAppConfig.AppName & ". Using Default Settings.", "Config Not Found")
        End If

        If boolPerform Then
            ' Create New Instance of Forms Tracker
            mFormsTracker = New PDSAFormsTracker
            PDSAFormsTracker.FormsTracker = mFormsTracker

            If PDSASecurityLogin.LoginToApp() Then
                ' Initialize this Form's security
                SecurityInit()

                If Not PDSABaseSecurity.UserIsInRole("User") Then
                    'mnuECopy.Enabled = False
                End If

                ' Check to see if controls need to be turned off on this form
                MyBase.SecurityCheck()

            Else
                Me.Close()
            End If
        End If

        'The Code below is to check if the user logged in is Admin then continue the code
        'This is to check the stock levels of the Company
        'Try
        '    Dim mgrlo As vwLowStocksManager
        '    Dim colsLoStock As vwLowStocksCollection
        '    mgrlo = New vwLowStocksManager()
        '    mgrlo.DataObject.WhereFilter = vwLowStocksData.WhereFilters.LoStock
        '    colsLoStock = mgrlo.BuildCollection
        '    If mgrlo.DataObject.RowsAffected > 0 Then
        '        MessageBox.Show("Warning! There are some stocks that are below or equal to Minimum Re-Order Level. Please print the report on Stocks Below Minimum")
        '    End If

        '    Dim mgrhi As vwHiStocksManager
        '    Dim colsHiStock As vwHiStocksCollection
        '    mgrhi = New vwHiStocksManager()
        '    mgrhi.DataObject.WhereFilter = vwHiStocksData.WhereFilters.HiStock
        '    colsHiStock = mgrhi.BuildCollection
        '    If mgrhi.DataObject.RowsAffected > 0 Then
        '        MessageBox.Show("Warning! There are some stocks that are Above or equal to Maximum Re-Order Level. Please print the report on Stocks Above or Equal to Maximum Level")
        '    End If

        'Catch ex As PDSAValidationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try

        'Dim LowStock As spLowStocksManager
        'Dim transGetLowStck As PDSATransaction = New PDSATransaction()
        'LowStock = New spLowStocksManager()
        'transGetLowStck.Add(LowStock.DataObject)
        'transGetLowStck.Execute()

        'Dim lowcount As Integer = 0
        'Dim hicount As Integer = 0

        'lowcount = Convert.ToInt32(LowStock.DataObject.Entity.StockCount)
        'If lowcount > 0 Then
        '    MessageBox.Show("Warning! There are some stocks that are below or equal to Minimum Re-Order Level. Print the report on Stocks Below or Equal Minimum Level")
        'End If


        'Try
        '    Dim HiStock As spHiStocksManager
        '    Dim transpGetHiStck As PDSATransaction = New PDSATransaction()
        '    HiStock = New spHiStocksManager()
        '    transpGetHiStck.Add(LowStock.DataObject)
        '    transpGetHiStck.Execute()

        '    hicount = Convert.ToInt32(HiStock.DataObject.Entity.StockCount)
        '    If hicount > 0 Then
        '        MessageBox.Show("Warning! There are some stocks that are above or equal to Maximum Re-Order Level. Print the report on Stocks Above or Equal to Maximum Level")
        '    End If

        'Catch ex As PDSAValidationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try

    End Sub

    Private Sub SecurityInit()
        ' This method is for any custom security things you wish to do

        If PDSAAppConfig.UseNTAuthentication = False And PDSAAppConfig.UsePDSASecurity Then
            ' PDSA Security Only

        ElseIf PDSAAppConfig.UseNTAuthentication And PDSAAppConfig.UsePDSASecurity Then
            ' Windows Authentication / PDSA Security

            Me.mnuSPwdChange.Visible = False
            Me.mnuFSignOut.Visible = False

        ElseIf PDSAAppConfig.UseNTAuthentication And PDSAAppConfig.UsePDSASecurity = False Then
            ' Windows Authentication / NO PDSA Security

            ' Turn off PDSA Security Menus
            Me.mnuSecurity.Visible = False
            Me.mnuFSignOut.Visible = False

        ElseIf PDSAAppConfig.UseNTAuthentication = False And PDSAAppConfig.UsePDSASecurity = False Then
            ' No Authentication

            Me.mnuSecurity.Visible = False
            Me.mnuFSignOut.Visible = False

        End If
    End Sub

#Region "Menus to call Forms"
    Private Sub mnuFExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFExit.Click
        Me.Close()
    End Sub

    Private Sub mnuWCloseAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWCloseAll.Click
        mFormsTracker.CloseAll()
    End Sub

    Private Sub mnuFSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFSignOut.Click
        mFormsTracker.CloseAll()
        If PDSAAppConfig.UsePDSASecurity Then
            If Not PDSASecurityLogin.LoginToApp() Then
                Me.Close()
            Else
                MyBase.SecurityCheck()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub mnuMWinFormMaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMWinFormMaint.Click
        Dim frm As PDSAWinFormMaint

        If mFormsTracker.IsLoaded("PDSAWinFormMaint") Then
            mFormsTracker.ActivateForm("PDSAWinFormMaint")
        Else
            frm = New PDSAWinFormMaint

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub

    Private Sub mnuSPermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSPermission.Click
        Dim frm As PDSAPermissionsMaint

        If mFormsTracker.IsLoaded("PDSAPermissionsMaint") Then
            mFormsTracker.ActivateForm("PDSAPermissionsMaint")
        Else
            frm = New PDSAPermissionsMaint

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub

    Private Sub mnuSRoles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSRoles.Click
        Dim frm As PDSARolesMaint

        If mFormsTracker.IsLoaded("PDSARolesMaint") Then
            mFormsTracker.ActivateForm("PDSARolesMaint")
        Else
            frm = New PDSARolesMaint

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub

    Private Sub mnuSPwdChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSPwdChange.Click
        Dim frm As PDSAChangePwd

        If mFormsTracker.IsLoaded("PDSAChangePwd") Then
            mFormsTracker.ActivateForm("PDSAChangePwd")
        Else
            frm = New PDSAChangePwd

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub
    Private Sub mnuSUserCategory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSUserCategory.Click
        Dim frm As PDSAUsersCategoryMaint

        If mFormsTracker.IsLoaded("PDSAUsersCategoryMaint") Then
            mFormsTracker.ActivateForm("PDSAUsersCategoryMaint")
        Else
            frm = New PDSAUsersCategoryMaint

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub

    Private Sub mnuSUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSUsers.Click
        Dim frm As PDSAUsersMaint

        If mFormsTracker.IsLoaded("PDSAUsersMaint") Then
            mFormsTracker.ActivateForm("PDSAUsersMaint")
        Else
            frm = New PDSAUsersMaint

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub

    Private Sub mnuSUsersToRoles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSUsersToRoles.Click
        Dim frm As PDSAUsersRolesMaint

        If mFormsTracker.IsLoaded("PDSAUsersRolesMaint") Then
            mFormsTracker.ActivateForm("PDSAUsersRolesMaint")
        Else
            frm = New PDSAUsersRolesMaint

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub

    Private Sub mnuSRolesToPermissions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSRolesToPermissions.Click
        Dim frm As PDSARolesPermissionsMaint

        If mFormsTracker.IsLoaded("PDSARolesPermissionsMaint") Then
            mFormsTracker.ActivateForm("PDSARolesPermissionsMaint")
        Else
            frm = New PDSARolesPermissionsMaint

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub

    Private Sub mnuLException_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLException.Click
        Dim frm As PDSAExceptionLookup

        If mFormsTracker.IsLoaded("PDSAExceptionLookup") Then
            mFormsTracker.ActivateForm("PDSAExceptionLookup")
        Else
            frm = New PDSAExceptionLookup

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub

    Private Sub mnuLUserTrack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLUserTrack.Click
        Dim frm As PDSAUserTrackLookup

        If mFormsTracker.IsLoaded("PDSAUserTrackLookup") Then
            mFormsTracker.ActivateForm("PDSAUserTrackLookup")
        Else
            frm = New PDSAUserTrackLookup

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub

    Private Sub mnuWFCreator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As PDSAWinFormMaint

        If mFormsTracker.IsLoaded("PDSAWinFormMaint") Then
            mFormsTracker.ActivateForm("PDSAWinFormMaint")
        Else
            frm = New PDSAWinFormMaint

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub

    Private Sub mnuWFWinFormControls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As PDSAWinFormControlsMaint

        If mFormsTracker.IsLoaded("PDSAWinFormControlsMaint") Then
            mFormsTracker.ActivateForm("PDSAWinFormControlsMaint")
        Else
            frm = New PDSAWinFormControlsMaint

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub

    Private Sub mnuSSecControls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSSecControls.Click
        Dim frm As PDSASecurityControlsMaint

        If mFormsTracker.IsLoaded("PDSASecurityControlsMaint") Then
            mFormsTracker.ActivateForm("PDSASecurityControlsMaint")
        Else
            frm = New PDSASecurityControlsMaint

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub

    Private Sub mnuLUserLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLUserLogin.Click
        Dim frm As PDSAUserLoginLookup

        If mFormsTracker.IsLoaded("PDSAUserLoginLookup") Then
            mFormsTracker.ActivateForm("PDSAUserLoginLookup")
        Else
            frm = New PDSAUserLoginLookup

            mFormsTracker.Add(frm, Me)

            frm.Show()
        End If
    End Sub
#End Region



    Private Sub mnuHFramework_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHFramework.Click
        'Dim prc As New Process

        'prc.StartInfo.FileName = "http://www.doors98.com"
        'prc.Start()
        MessageBox.Show("Website is under maintenance. Please Contact Warren Dulnuan for Technical Suppport and Additonal POS License.CP#:0917-655-3488")
    End Sub

    Private Sub mnuHAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHAbout.Click
        'Dim frm As New frmAbout
        'frm.Show()
    End Sub


    Private Sub MenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles mnuPOS.Click
        'If PDSAAppConfig.CurrentLoginID <> "Admin" Then
        '    Dim mgr As tblreadingManager
        '    Dim col As New tblreadingCollection

        '    Try
        '        mgr = New tblreadingManager()
        '        mgr.DataObject.WhereFilter = tblreadingData.WhereFilters.CashierStatus
        '        mgr.Entity.cashier = PDSAAppConfig.CurrentLoginID
        '        col = mgr.BuildCollection
        '        If mgr.DataObject.RowsAffected > 0 Then

        '            Dim posform As New frmPOS
        '            posform.ShowDialog()
        '            posform = Nothing

        '        Else
        '            'Dim begcash As New frmBegCash

        '            'begcash.Show()
        '            'begcash = Nothing
        '            Dim frm As frmBegCash
        '            If mFormsTracker.IsLoaded("frmBegCash") Then
        '                mFormsTracker.Close("frmBegCash")
        '                mFormsTracker.Remove("frmBegCash")
        '                frm = New frmBegCash
        '                mFormsTracker.Add(frm, Me)
        '                frm.MdiParent = Me
        '                frm.WindowState = FormWindowState.Maximized
        '                frm.ShowDialog()
        '                frm = Nothing
        '            Else
        '                frm = New frmBegCash
        '                mFormsTracker.Add(frm, Me)
        '                frm.MdiParent = Me
        '                frm.WindowState = FormWindowState.Maximized
        '                frm.ShowDialog()
        '                frm = Nothing
        '            End If
        '        End If
        '    Catch ex As PDSAValidationException
        '        MessageBox.Show(ex.Message)
        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString())
        '    End Try
        'End If



        Dim currentDate As Date = Date.Now.Date
        Dim qryLogged As String = String.Empty
        Dim loggedread As Boolean

        'qryLogged = "SELECT status FROM tblreading WHERE cashier='" & PDSAAppConfig.CurrentLoginID & "'  AND status=1 AND datereading ='" & currentDate & "'"
        'Using reader1 As SqlDataReader = ExecuteSQLQueryReader(qryLogged)
        '    While reader1.Read()
        '        loggedread = reader1.GetBoolean(0)
        '    End While
        'End Using


        'If loggedread = True Then
        '    MessageBox.Show("Cashier is not allowed to login again after cash count within the same day")
        '    Me.Close()
        '    Exit Sub
        'End If

        If PDSAAppConfig.CurrentLoginID <> "Admin" Then
            Dim mgr As tblreadingManager
            Dim col As New tblreadingCollection
            Dim posform As New frmPOS
            'posform.ShowDialog()
            posform.Show()
            posform = Nothing
            Try
                'mgr = New tblreadingManager()
                'mgr.DataObject.WhereFilter = tblreadingData.WhereFilters.CashierStatus
                'mgr.Entity.cashier = PDSAAppConfig.CurrentLoginID
                'col = mgr.BuildCollection
                'If mgr.DataObject.RowsAffected > 0 Then

                '    Dim posform As New frmPOS
                '    'posform.ShowDialog()
                '    posform.Show()
                '    posform = Nothing

                'Else
                '    'Dim begcash As New frmBegCash

                '    'begcash.ShowDialog()
                '    'begcash = Nothing
                '    Dim frm As frmBegCash
                '    If mFormsTracker.IsLoaded("frmBegCash") Then
                '        mFormsTracker.Close("frmBegCash")
                '        mFormsTracker.Remove("frmBegCash")
                '        frm = New frmBegCash
                '        mFormsTracker.Add(frm, Me)
                '        frm.MdiParent = Me
                '        frm.WindowState = FormWindowState.Maximized
                '        frm.Show()
                '        frm = Nothing
                '    Else
                '        frm = New frmBegCash
                '        mFormsTracker.Add(frm, Me)
                '        frm.MdiParent = Me
                '        frm.WindowState = FormWindowState.Maximized
                '        frm.Show()
                '        frm = Nothing
                '    End If
                'End If
            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If

    End Sub

    'Private Sub MenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem3.Click
    '    'Dim frm As New Form2

    '    'frm.Show()
    '    'frm.Dispose()
    '    'frm = Nothing
    'End Sub


    Private Sub MenuItem8_Click(sender As Object, e As EventArgs) Handles mnuNewItems.Click
        'Dim frmNI As New frmNewItems
        'frmNI.Show()
        Dim frm As frmNewItems
        frm = New frmNewItems
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmNewItems") Then
        '    mFormsTracker.Close("frmNewItems")
        '    mFormsTracker.Remove("frmNewItems")
        '    frm = New frmNewItems

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmNewItems
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem9_Click(sender As Object, e As EventArgs) Handles mnuItemGrid.Click
        'Dim formItems As New frmItemList
        'formItems.Show()
        Dim frm As frmItemlist2
        frm = New frmItemlist2
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmItemlist2") Then
        '    mFormsTracker.Close("frmItemlist2")
        '    mFormsTracker.Remove("frmItemlist2")
        '    frm = New frmItemlist2

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmItemlist2
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If

    End Sub
    'Return Items Form
    'Private Sub MenuItem19_Click(sender As Object, e As EventArgs) Handles MenuItem19.Click
    '    'Dim retform As New frmReturns
    '    'retform.Show()
    '    Dim frm As frmReturns
    '    frm = New frmReturns
    '    frm.Show()
    '    frm = Nothing
    '    'If mFormsTracker.IsLoaded("frmReturns") Then
    '    '    mFormsTracker.Close("frmReturns")
    '    '    mFormsTracker.Remove("frmReturns")
    '    '    frm = New frmReturns

    '    '    mFormsTracker.Add(frm, Me)
    '    '    frm.MdiParent = Me
    '    '    frm.WindowState = FormWindowState.Maximized
    '    '    frm.Show()
    '    '    frm = Nothing
    '    'Else
    '    '    frm = New frmReturns
    '    '    mFormsTracker.Add(frm, Me)
    '    '    frm.WindowState = FormWindowState.Maximized
    '    '    frm.MdiParent = Me
    '    '    frm.Show()
    '    '    frm = Nothing
    '    'End If
    'End Sub

    Private Sub MenuItem22_Click(sender As Object, e As EventArgs)
        'Dim pofrm As New frmPO
        'pofrm.Show()
        Dim frm As frmPO
        frm = New frmPO
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmPO") Then
        '    mFormsTracker.Close("frmPO")
        '    mFormsTracker.Remove("frmPO")
        '    frm = New frmPO

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmPO
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If

    End Sub

    'Private Sub MenuItem12_Click(sender As Object, e As EventArgs) Handles MenuItem12.Click
    '    'Dim maindboard As New frmDashboard
    '    'maindboard.Show()
    '    Dim frm As frmDashboard
    '    If mFormsTracker.IsLoaded("frmDashboard") Then
    '        mFormsTracker.Close("frmDashboard")
    '        mFormsTracker.Remove("frmDashboard")
    '        frm = New frmDashboard

    '        mFormsTracker.Add(frm, Me)
    '        frm.MdiParent = Me
    '        frm.WindowState = FormWindowState.Maximized
    '        frm.Show()
    '    Else
    '        frm = New frmDashboard
    '        mFormsTracker.Add(frm, Me)
    '        frm.MdiParent = Me
    '        frm.WindowState = FormWindowState.Maximized
    '        frm.Show()
    '    End If

    'End Sub

    Private Sub MenuItem49_Click(sender As Object, e As EventArgs)
        ' Dim frmdbsaleshr As New frmSalesTodayHr
        'frmdbsaleshr.Show()
        Dim frm As frmSalesTodayHr
        If mFormsTracker.IsLoaded("frmSalesTodayHr") Then
            mFormsTracker.Close("frmSalesTodayHr")
            mFormsTracker.Remove("frmSalesTodayHr")
            frm = New frmSalesTodayHr

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmSalesTodayHr
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem50_Click(sender As Object, e As EventArgs)
        'Dim frmPasthr As New frmPastSalesHr
        'frmPasthr.Show()
        Dim frm As frmPastSalesHr
        If mFormsTracker.IsLoaded("frmPastSalesHr") Then
            mFormsTracker.Close("frmPastSalesHr")
            mFormsTracker.Remove("frmPastSalesHr")
            frm = New frmPastSalesHr

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmPastSalesHr
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem51_Click(sender As Object, e As EventArgs)
        'Dim frmitemssold As New frmpvtSales
        'frmitemssold.Show()
        Dim frm As frmpvtSales
        frm = New frmpvtSales
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmpvtSales") Then
        '    mFormsTracker.Close("frmpvtSales")
        '    mFormsTracker.Remove("frmpvtSales")
        '    frm = New frmpvtSales

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmpvtSales
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If

    End Sub

    Private Sub MenuItem34_Click(sender As Object, e As EventArgs)

        Dim frm As frmSalesDetails
        frm = New frmSalesDetails
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmSalesDetails") Then
        '    mFormsTracker.Close("frmSalesDetails")
        '    mFormsTracker.Remove("frmSalesDetails")
        '    frm = New frmSalesDetails

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmSalesDetails
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem53_Click(sender As Object, e As EventArgs)
        'Dim frmsalesprofit As New frmSalesWithNet
        'frmsalesprofit.Show()
        Dim frm As frmSalesWithNet
        frm = New frmSalesWithNet
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmSalesWithNet") Then
        '    mFormsTracker.Close("frmSalesWithNet")
        '    mFormsTracker.Remove("frmSalesWithNet")
        '    frm = New frmSalesWithNet

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmSalesWithNet
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If

    End Sub

    Private Sub MenuItem55_Click(sender As Object, e As EventArgs)
        'Dim frmcdb As New frmCreditDB
        'frmcdb.Show()

        Dim frm As frmCreditDB
        frm = New frmCreditDB
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmCreditDB") Then
        '    mFormsTracker.Close("frmCreditDB")
        '    mFormsTracker.Remove("frmCreditDB")
        '    frm = New frmCreditDB
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmCreditDB
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me

        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If

    End Sub

    Private Sub MenuItem57_Click(sender As Object, e As EventArgs)
        Dim rep As New CustBal
        'rep.ParamCashier.Value = PDSAAppConfig.CurrentLoginID
        'rep.RequestParameters = False
        rep.PrintingSystem.ShowMarginsWarning = False
        rep.ShowPreview()
    End Sub
    Private Sub MenuItem59_Click(sender As Object, e As EventArgs)
        'Dim frmSalesDB As New frmSalesDashboard
        'frmSalesDB.Show()
        Dim frm As frmSalesDashboard
        frm = New frmSalesDashboard
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmSalesDashboard") Then
        '    mFormsTracker.Close("frmSalesDashboard")
        '    mFormsTracker.Remove("frmSalesDashboard")
        '    frm = New frmSalesDashboard

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmSalesDashboard
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If

    End Sub

    Private Sub MenuItem54_Click(sender As Object, e As EventArgs)
        'Dim frmprofit As New frmProfitDB
        'frmprofit.Show()

        Dim frm As frmProfitDB
        If mFormsTracker.IsLoaded("frmProfitDB") Then
            mFormsTracker.Close("frmProfitDB")
            mFormsTracker.Remove("frmProfitDB")
            frm = New frmProfitDB

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmProfitDB
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem15_Click(sender As Object, e As EventArgs)
        'Dim frmdbsales As New frmDashboardSalesDate
        'frmdbsales.Show()

        Dim frm As frmDashboardSalesDate
        frm = New frmDashboardSalesDate
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmDashboardSalesDate") Then
        '    mFormsTracker.Close("frmDashboardSalesDate")
        '    mFormsTracker.Remove("frmDashboardSalesDate")
        '    frm = New frmDashboardSalesDate

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmDashboardSalesDate
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem32_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmItemsSoldSummry
        'frm.Show()

        Dim frm As frmItemsSoldSummry
        If mFormsTracker.IsLoaded("frmItemsSoldSummry") Then
            mFormsTracker.Close("frmItemsSoldSummry")
            mFormsTracker.Remove("frmItemsSoldSummry")
            frm = New frmItemsSoldSummry

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmItemsSoldSummry
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem60_Click(sender As Object, e As EventArgs)
        ' Dim frm As New frmCreditGrid
        ' frm.Show()

        Dim frm As frmCreditGrid
        If mFormsTracker.IsLoaded("frmCreditGrid") Then
            mFormsTracker.Close("frmCreditGrid")
            mFormsTracker.Remove("frmCreditGrid")
            frm = New frmCreditGrid

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmCreditGrid
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem62_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmCustPayGrid
        'frm.Show()

        Dim frm As frmCustPayGrid
        If mFormsTracker.IsLoaded("frmCustPayGrid") Then
            mFormsTracker.Close("frmCustPayGrid")
            mFormsTracker.Remove("frmCustPayGrid")
            frm = New frmCustPayGrid

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmCustPayGrid
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem25_Click(sender As Object, e As EventArgs)
        'Dim frmDlvry As New frmDelivery
        'frmDlvry.Show()
        Dim frm As frmDelivery
        frm = New frmDelivery
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmDelivery") Then
        '    mFormsTracker.Close("frmDelivery")
        '    mFormsTracker.Remove("frmDelivery")
        '    frm = New frmDelivery

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmDelivery
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If

    End Sub

    Private Sub MenuItem27_Click(sender As Object, e As EventArgs)
        'Dim frmpi As New frmDrPayment
        'frmpi.Show()

        Dim frm As frmDrPayment
        frm = New frmDrPayment
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmDrPayment") Then
        '    mFormsTracker.Close("frmDrPayment")
        '    mFormsTracker.Remove("frmDrPayment")
        '    frm = New frmDrPayment

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmDrPayment
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem31_Click(sender As Object, e As EventArgs)
        'Dim frmBo As New frmBackorder
        'frmBo.Show()

        Dim frm As frmBackorder
        frm = New frmBackorder
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmBackorder") Then
        '    mFormsTracker.Close("frmBackorder")
        '    mFormsTracker.Remove("frmBackorder")
        '    frm = New frmBackorder

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmBackorder
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem29_Click(sender As Object, e As EventArgs)
        'Dim formTransfer As New frmTransferStock
        'formTransfer.Show()
        Dim frm As frmTransferStock
        frm = New frmTransferStock
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmTransferStock") Then
        '    mFormsTracker.Close("frmTransferStock")
        '    mFormsTracker.Remove("frmTransferStock")
        '    frm = New frmTransferStock

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmTransferStock
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If

    End Sub

    Private Sub MenuItem40_Click(sender As Object, e As EventArgs)
        'Dim frm As New DBDlvry
        'frm.Show()
        Dim frm As DBDlvry
        frm = New DBDlvry
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("DBDlvry") Then
        '    mFormsTracker.Close("DBDlvry")
        '    mFormsTracker.Remove("DBDlvry")
        '    frm = New DBDlvry

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New DBDlvry
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem41_Click(sender As Object, e As EventArgs)
        'Dim frm As New DBDlvryItem
        'frm.Show()

        Dim frm As DBDlvryItem
        frm = New DBDlvryItem
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("DBDlvryItem") Then
        '    mFormsTracker.Close("DBDlvryItem")
        '    mFormsTracker.Remove("DBDlvryItem")
        '    frm = New DBDlvryItem

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New DBDlvryItem
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem36_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmDeliveryGrid
        'frm.Show()


        Dim frm As frmDeliveryGrid
        frm = New frmDeliveryGrid
        frm.Show()
        frm = Nothing


        'If mFormsTracker.IsLoaded("frmDeliveryGrid") Then
        '    mFormsTracker.Close("frmDeliveryGrid")
        '    mFormsTracker.Remove("frmDeliveryGrid")
        '    frm = New frmDeliveryGrid

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmDeliveryGrid
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem46_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmItemLedgerGrd1
        'frm.Show()

        Dim frm As frmItemLedgerGrd1
        frm = New frmItemLedgerGrd1
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmItemLedgerGrd1") Then
        '    mFormsTracker.Close("frmItemLedgerGrd1")
        '    mFormsTracker.Remove("frmItemLedgerGrd1")
        '    frm = New frmItemLedgerGrd1

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmItemLedgerGrd1
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub mnuBelowMin_Click(sender As Object, e As EventArgs)
        Dim belowmin As New XrItemsBelowMinim()
        belowmin.PrintingSystem.ShowMarginsWarning = False
        belowmin.ShowPreview()
    End Sub

    Private Sub mnuAboveMax_Click(sender As Object, e As EventArgs)
        Dim abovemax As New XRItemsAboveMaxim()
        abovemax.PrintingSystem.ShowMarginsWarning = False
        abovemax.ShowPreview()
    End Sub

    Private Sub MenuItem38_Click(sender As Object, e As EventArgs)
        Dim outofstak As New XrOutofStak()
        outofstak.PrintingSystem.ShowMarginsWarning = False
        outofstak.ShowPreview()
    End Sub

    Private Sub MenuItem44_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmInvCostGrid
        'frm.Show()

        Dim frm As frmInvCostGrid
        frm = New frmInvCostGrid
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmInvCostGrid") Then
        '    mFormsTracker.Close("frmInvCostGrid")
        '    mFormsTracker.Remove("frmInvCostGrid")
        '    frm = New frmInvCostGrid

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmInvCostGrid
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem43_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmInvCostPivt
        'frm.Show()

        Dim frm As frmInvCostPivt
        frm = New frmInvCostPivt
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmInvCostPivt") Then
        '    mFormsTracker.Close("frmInvCostPivt")
        '    mFormsTracker.Remove("frmInvCostPivt")
        '    frm = New frmInvCostPivt

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmInvCostPivt
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem45_Click(sender As Object, e As EventArgs)
        ' Dim frm As New frmTransferGrd
        ' frm.Show()

        Dim frm As frmTransferGrd
        If mFormsTracker.IsLoaded("frmTransferGrd") Then
            mFormsTracker.Close("frmTransferGrd")
            mFormsTracker.Remove("frmTransferGrd")
            frm = New frmTransferGrd

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmTransferGrd
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem63_Click(sender As Object, e As EventArgs)
        ' Dim frm As New frmTransferedDB
        ' frm.Show()

        Dim frm As frmTransferedDB
        frm = New frmTransferedDB
        frm.Show()
        'frm = Nothing
        'If mFormsTracker.IsLoaded("frmTransferedDB") Then
        '    mFormsTracker.Close("frmTransferedDB")
        '    mFormsTracker.Remove("frmTransferedDB")
        '    frm = New frmTransferedDB

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmTransferedDB
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem64_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmReceiveStokcs
        'frm.Show()

        Dim frm As frmReceiveStokcs
        frm = New frmReceiveStokcs
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmReceiveStokcs") Then
        '    mFormsTracker.Close("frmReceiveStokcs")
        '    mFormsTracker.Remove("frmReceiveStokcs")
        '    frm = New frmReceiveStokcs

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmReceiveStokcs
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem66_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmManualInvGrid
        'frm.Show()

        Dim frm As frmManualInvGrid
        frm = New frmManualInvGrid
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmManualInvGrid") Then
        '    mFormsTracker.Close("frmManualInvGrid")
        '    mFormsTracker.Remove("frmManualInvGrid")
        '    frm = New frmManualInvGrid

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmManualInvGrid
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem48_Click(sender As Object, e As EventArgs)
        Dim posrep As New xrItmLedgers()
        'posrep.Parameter1.Value = mOrderId
        'posrep.RequestParameters = False
        'ceRefno.Value = mOrderId
        posrep.PrintingSystem.ShowMarginsWarning = False
        posrep.ShowPreview()
    End Sub

    Private Sub MenuItem67_Click(sender As Object, e As EventArgs)
        Dim posrep As New xrCustPay()
        posrep.PrintingSystem.ShowMarginsWarning = False
        posrep.ShowPreview()
    End Sub

    Private Sub MenuItem8_Click_1(sender As Object, e As EventArgs)
        Dim rep As New xrTransfers()
        rep.PrintingSystem.ShowMarginsWarning = False
        rep.ShowPreview()
    End Sub

    Private Sub MenuItem6_Click(sender As Object, e As EventArgs)
        ' Dim frm As New frmItemLedgerPvt
        ' frm.Show()


        Dim frm As frmItemLedgerPvt
        frm = New frmItemLedgerPvt
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmItemLedgerPvt") Then
        '    mFormsTracker.Close("frmItemLedgerPvt")
        '    mFormsTracker.Remove("frmItemLedgerPvt")
        '    frm = New frmItemLedgerPvt

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmItemLedgerPvt
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem9_Click_1(sender As Object, e As EventArgs)
        ' Dim frm As New frmSalesWithNetPvt
        ' frm.Show()

        Dim frm As frmSalesWithNetPvt
        frm = New frmSalesWithNetPvt
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmSalesWithNetPvt") Then
        '    mFormsTracker.Close("frmSalesWithNetPvt")
        '    mFormsTracker.Remove("frmSalesWithNetPvt")
        '    frm = New frmSalesWithNetPvt

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.Show()
        '    frm.WindowState = FormWindowState.Maximized
        '    frm = Nothing
        'Else
        '    frm = New frmSalesWithNetPvt
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.Show()
        '    frm.WindowState = FormWindowState.Maximized
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem71_Click(sender As Object, e As EventArgs)
        'Dim frmbc As New frmBestCustomer
        'frmbc.Show()

        Dim frm As frmBestCustomer
        If mFormsTracker.IsLoaded("frmBestCustomer") Then
            mFormsTracker.Close("frmBestCustomer")
            mFormsTracker.Remove("frmBestCustomer")
            frm = New frmBestCustomer

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmBestCustomer
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem68_Click(sender As Object, e As EventArgs)
        ' Dim stdwc As New frmSales2DayCashr
        ' stdwc.Show()

        Dim frm As frmSales2DayCashr
        frm = New frmSales2DayCashr
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmSales2DayCashr") Then
        '    mFormsTracker.Close("frmSales2DayCashr")
        '    mFormsTracker.Remove("frmSales2DayCashr")
        '    frm = New frmSales2DayCashr

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmSales2DayCashr
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem73_Click(sender As Object, e As EventArgs)
        Dim repsupbal As New xrSupplierBal()
        repsupbal.PrintingSystem.ShowMarginsWarning = False
        repsupbal.ShowPreview()
    End Sub

    Private Sub MenuItem74_Click(sender As Object, e As EventArgs)
        'Dim frmhilo As New frmHiLoSellingItems
        'frmhilo.Show()


        Dim frm As frmHiLoSellingItems
        frm = New frmHiLoSellingItems
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmHiLoSellingItems") Then
        '    mFormsTracker.Close("frmHiLoSellingItems")
        '    mFormsTracker.Remove("frmHiLoSellingItems")
        '    frm = New frmHiLoSellingItems

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmHiLoSellingItems
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem76_Click(sender As Object, e As EventArgs)
        'Dim hilodlvry As New frmHiLoDlvryItems
        'hilodlvry.Show()

        Dim frm As frmHiLoDlvryItems
        If mFormsTracker.IsLoaded("frmHiLoDlvryItems") Then
            mFormsTracker.Close("frmHiLoDlvryItems")
            mFormsTracker.Remove("frmHiLoDlvryItems")
            frm = New frmHiLoDlvryItems

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmHiLoDlvryItems
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem78_Click(sender As Object, e As EventArgs)
        'Dim custpay As New frmCustPayDB
        'custpay.Show()

        Dim frm As frmCustPayDB
        frm = New frmCustPayDB
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmCustPayDB") Then
        '    mFormsTracker.Close("frmCustPayDB")
        '    mFormsTracker.Remove("frmCustPayDB")
        '    frm = New frmCustPayDB

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmCustPayDB
        '    mFormsTracker.Add(frm, Me)
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.MdiParent = Me
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem79_Click(sender As Object, e As EventArgs) Handles MenuItem79.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub MenuItem81_Click(sender As Object, e As EventArgs) Handles MenuItem81.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)
    End Sub

    Private Sub MenuItem82_Click(sender As Object, e As EventArgs) Handles MenuItem82.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)
    End Sub
    Private Sub MenuItem84_Click(sender As Object, e As EventArgs)
        Dim frm As frmHiLoWeekly
        frm = New frmHiLoWeekly
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmHiLoWeekly") Then
        '    mFormsTracker.Close("frmHiLoWeekly")
        '    mFormsTracker.Remove("frmHiLoWeekly")
        '    frm = New frmHiLoWeekly

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmHiLoWeekly
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem85_Click(sender As Object, e As EventArgs)
        Dim frm As frmSoldQtrly
        frm = New frmSoldQtrly
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmSoldQtrly") Then
        '    mFormsTracker.Close("frmSoldQtrly")
        '    mFormsTracker.Remove("frmSoldQtrly")
        '    frm = New frmSoldQtrly

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmSoldQtrly
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem86_Click(sender As Object, e As EventArgs)
        Dim frm As frmSoldYrly
        frm = New frmSoldYrly
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmSoldYrly") Then
        '    mFormsTracker.Close("frmSoldYrly")
        '    mFormsTracker.Remove("frmSoldYrly")
        '    frm = New frmSoldYrly

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmSoldYrly
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem87_Click(sender As Object, e As EventArgs)
        Dim frm As frmItemSoldDaily

        If mFormsTracker.IsLoaded("frmItemSoldDaily") Then
            mFormsTracker.Close("frmItemSoldDaily")
            mFormsTracker.Remove("frmItemSoldDaily")
            frm = New frmItemSoldDaily

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmItemSoldDaily
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem88_Click(sender As Object, e As EventArgs)
        Dim frm As frmDailProfitDB

        If mFormsTracker.IsLoaded("frmDailProfitDB") Then
            mFormsTracker.Close("frmDailProfitDB")
            mFormsTracker.Remove("frmDailProfitDB")
            frm = New frmDailProfitDB

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmDailProfitDB
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem89_Click(sender As Object, e As EventArgs)
        Dim frm As frmWeeklyProfitDB

        If mFormsTracker.IsLoaded("frmWeeklyProfitDB") Then
            mFormsTracker.Close("frmWeeklyProfitDB")
            mFormsTracker.Remove("frmWeeklyProfitDB")
            frm = New frmWeeklyProfitDB

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmWeeklyProfitDB
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem91_Click(sender As Object, e As EventArgs)
        Dim frm As frmAnnualProfitDB

        If mFormsTracker.IsLoaded("frmAnnualProfitDB") Then
            mFormsTracker.Close("frmAnnualProfitDB")
            mFormsTracker.Remove("frmAnnualProfitDB")
            frm = New frmAnnualProfitDB

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmAnnualProfitDB
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem92_Click(sender As Object, e As EventArgs)
        Dim outofstak As New xrAvlblItems()
        outofstak.PrintingSystem.ShowMarginsWarning = False
        outofstak.ShowPreview()
    End Sub

    Private Sub MenuItem93_Click(sender As Object, e As EventArgs)
        Dim invdif As New xrInvDiffRep()
        invdif.ShowPreview()
    End Sub

    Private Sub MenuItem96_Click(sender As Object, e As EventArgs) Handles MenuItem96.Click
        Dim frm As frmLoginEmp
        frm = New frmLoginEmp
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmLoginEmp") Then
        '    mFormsTracker.Close("frmLoginEmp")
        '    mFormsTracker.Remove("frmLoginEmp")
        '    frm = New frmLoginEmp

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    ' frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmLoginEmp
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    'frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem97_Click(sender As Object, e As EventArgs) Handles MenuItem97.Click
        Dim frm As frmBreakOut
        frm = New frmBreakOut
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmBreakOut") Then
        '    mFormsTracker.Close("frmBreakOut")
        '    mFormsTracker.Remove("frmBreakOut")
        '    frm = New frmBreakOut

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    ' frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmBreakOut
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    'frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem98_Click(sender As Object, e As EventArgs) Handles MenuItem98.Click
        Dim frm As frmTimeInafterBrk
        frm = New frmTimeInafterBrk
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmTimeInafterBrk") Then
        '    mFormsTracker.Close("frmTimeInafterBrk")
        '    mFormsTracker.Remove("frmTimeInafterBrk")
        '    frm = New frmTimeInafterBrk

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    ' frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmTimeInafterBrk
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    'frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem99_Click(sender As Object, e As EventArgs) Handles MenuItem99.Click
        Dim frm As frmTimeOut
        frm = New frmTimeOut
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmTimeOut") Then
        '    mFormsTracker.Close("frmTimeOut")
        '    mFormsTracker.Remove("frmTimeOut")
        '    frm = New frmTimeOut

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    ' frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmTimeOut
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    'frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem102_Click(sender As Object, e As EventArgs)
        Dim xrtime As New xrEmpTime()
        xrtime.ShowPreview()
    End Sub

    Private Sub MenuItem103_Click(sender As Object, e As EventArgs)
        Dim frm As frmReceivedStcksGrd
        frm = New frmReceivedStcksGrd
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmReceivedStcksGrd") Then
        '    mFormsTracker.Close("frmReceivedStcksGrd")
        '    mFormsTracker.Remove("frmReceivedStcksGrd")
        '    frm = New frmReceivedStcksGrd

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmReceivedStcksGrd
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem104_Click(sender As Object, e As EventArgs)
        Dim frm As frmBuyPrcHistory
        frm = New frmBuyPrcHistory
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmBuyPrcHistory") Then
        '    mFormsTracker.Close("frmBuyPrcHistory")
        '    mFormsTracker.Remove("frmBuyPrcHistory")
        '    frm = New frmBuyPrcHistory

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmBuyPrcHistory
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem105_Click(sender As Object, e As EventArgs)
        Dim frm As frmBOGrid
        frm = New frmBOGrid
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmBOGrid") Then
        '    mFormsTracker.Close("frmBOGrid")
        '    mFormsTracker.Remove("frmBOGrid")
        '    frm = New frmBOGrid

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmBOGrid
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem3_Click(sender As Object, e As EventArgs)
        Dim xrborep As New xrBo()
        xrborep.ShowPreview()
    End Sub

    Private Sub MenuItem107_Click(sender As Object, e As EventArgs)
        Dim frm As frmBoGrd2
        frm = New frmBoGrd2
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmBoGrd2") Then
        '    mFormsTracker.Close("frmBoGrd2")
        '    mFormsTracker.Remove("frmBoGrd2")
        '    frm = New frmBoGrd2

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmBoGrd2
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem108_Click(sender As Object, e As EventArgs)
        Dim frm As frmRcivdStcksGrd2

        If mFormsTracker.IsLoaded("frmRcivdStcksGrd2") Then
            mFormsTracker.Close("frmRcivdStcksGrd2")
            mFormsTracker.Remove("frmRcivdStcksGrd2")
            frm = New frmRcivdStcksGrd2

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmRcivdStcksGrd2
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem109_Click(sender As Object, e As EventArgs)
        Dim frm As frmTransfrdGrd1
        frm = New frmTransfrdGrd1
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmTransfrdGrd1") Then
        '    mFormsTracker.Close("frmTransfrdGrd1")
        '    mFormsTracker.Remove("frmTransfrdGrd1")
        '    frm = New frmTransfrdGrd1

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmTransfrdGrd1
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem110_Click(sender As Object, e As EventArgs)
        Dim frm As frmDlvryGrid2
        frm = New frmDlvryGrid2
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmDlvryGrid2") Then
        '    mFormsTracker.Close("frmDlvryGrid2")
        '    mFormsTracker.Remove("frmDlvryGrid2")
        '    frm = New frmDlvryGrid2

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmDlvryGrid2
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem111_Click(sender As Object, e As EventArgs)
        Dim dritem As New xrDlvry()
        dritem.ShowPreview()
    End Sub

    Private Sub MenuItem2_Click_1(sender As Object, e As EventArgs)
        Dim drrsupplier As New xrDlvrySupplier()
        drrsupplier.ShowPreview()
    End Sub

    Private Sub MenuItem112_Click(sender As Object, e As EventArgs)
        ' Dim stdwc As New frmSales2DayCashr
        ' stdwc.Show()

        Dim frm As frmSalestoday
        frm = New frmSalestoday
        frm.Show()
        frm = Nothing


        'If mFormsTracker.IsLoaded("frmSalestoday") Then
        '    mFormsTracker.Close("frmSalestoday")
        '    mFormsTracker.Remove("frmSalestoday")
        '    frm = New frmSalestoday

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmSalestoday
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub mnuAmPm_Click(sender As Object, e As EventArgs)
        'Dim AmpPM As New xrAMPM()
        'AmpPM.ShowPreview()
        Dim ScPrint As New SeniorDiscountRpt()
        ScPrint.PrintingSystem.ShowMarginsWarning = False
        ScPrint.ShowPreview()
    End Sub

    Private Sub MenuItem117_Click(sender As Object, e As EventArgs)
        Dim frm As frmConvertStocks
        frm = New frmConvertStocks
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmConvertStocks") Then
        '    mFormsTracker.Close("frmConvertStocks")
        '    mFormsTracker.Remove("frmConvertStocks")
        '    frm = New frmConvertStocks

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmConvertStocks
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem120_Click(sender As Object, e As EventArgs)
        Dim frm As frmConvertGrid
        frm = New frmConvertGrid
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmConvertGrid") Then
        '    mFormsTracker.Close("frmConvertGrid")
        '    mFormsTracker.Remove("frmConvertGrid")
        '    frm = New frmConvertGrid

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmConvertGrid
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem115_Click(sender As Object, e As EventArgs)
        Dim frm As frmExpenses
        frm = New frmExpenses
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmExpenses") Then
        '    mFormsTracker.Close("frmExpenses")
        '    mFormsTracker.Remove("frmExpenses")
        '    frm = New frmExpenses

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmExpenses
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem122_Click(sender As Object, e As EventArgs)
        Dim frm As frmExpenseGrid
        frm = New frmExpenseGrid
        frm.Show()
        'frm = Nothing

        'If mFormsTracker.IsLoaded("frmExpenseGrid") Then
        '    mFormsTracker.Close("frmExpenseGrid")
        '    mFormsTracker.Remove("frmExpenseGrid")
        '    frm = New frmExpenseGrid

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmExpenseGrid
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem123_Click(sender As Object, e As EventArgs)
        Dim frm As frmPtyCashGrid
        frm = New frmPtyCashGrid
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmPtyCashGrid") Then
        '    mFormsTracker.Close("frmPtyCashGrid")
        '    mFormsTracker.Remove("frmPtyCashGrid")
        '    frm = New frmPtyCashGrid

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmPtyCashGrid
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem125_Click(sender As Object, e As EventArgs)
        Dim frm As frmAddCashGrid
        frm = New frmAddCashGrid
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmAddCashGrid") Then
        '    mFormsTracker.Close("frmAddCashGrid")
        '    mFormsTracker.Remove("frmAddCashGrid")
        '    frm = New frmAddCashGrid

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmAddCashGrid
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem126_Click(sender As Object, e As EventArgs)
        Dim frm As frmDiscountGrid
        frm = New frmDiscountGrid
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmDiscountGrid") Then
        '    mFormsTracker.Close("frmDiscountGrid")
        '    mFormsTracker.Remove("frmDiscountGrid")
        '    frm = New frmDiscountGrid

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmDiscountGrid
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem127_Click(sender As Object, e As EventArgs)
        Dim frm As frmChkPaymntGrid
        frm = New frmChkPaymntGrid
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmChkPaymntGrid") Then
        '    mFormsTracker.Close("frmChkPaymntGrid")
        '    mFormsTracker.Remove("frmChkPaymntGrid")
        '    frm = New frmChkPaymntGrid

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmChkPaymntGrid
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem128_Click(sender As Object, e As EventArgs)
        Dim frm As frmVoidGrid
        frm = New frmVoidGrid
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmVoidGrid") Then
        '    mFormsTracker.Close("frmVoidGrid")
        '    mFormsTracker.Remove("frmVoidGrid")
        '    frm = New frmVoidGrid

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmVoidGrid
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem130_Click(sender As Object, e As EventArgs)
        Dim frm As frmRefundsGrid
        frm = New frmRefundsGrid
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmRefundsGrid") Then
        '    mFormsTracker.Close("frmRefundsGrid")
        '    mFormsTracker.Remove("frmRefundsGrid")
        '    frm = New frmRefundsGrid

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmRefundsGrid
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem131_Click(sender As Object, e As EventArgs)
        Dim frm As frmChangePrceGrid
        frm = New frmChangePrceGrid
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmChangePrceGrid") Then
        '    mFormsTracker.Close("frmChangePrceGrid")
        '    mFormsTracker.Remove("frmChangePrceGrid")
        '    frm = New frmChangePrceGrid

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmChangePrceGrid
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem132_Click(sender As Object, e As EventArgs)
        Dim frm As frmSalesHistory
        frm = New frmSalesHistory
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmSalesHistory") Then
        '    mFormsTracker.Close("frmSalesHistory")
        '    mFormsTracker.Remove("frmSalesHistory")
        '    frm = New frmSalesHistory

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmSalesHistory
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem133_Click(sender As Object, e As EventArgs)
        ' Dim frm As New frmCreditGrid
        ' frm.Show()

        Dim frm As frmCreditGrid2
        If mFormsTracker.IsLoaded("frmCreditGrid2") Then
            mFormsTracker.Close("frmCreditGrid2")
            mFormsTracker.Remove("frmCreditGrid2")
            frm = New frmCreditGrid2

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmCreditGrid2
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub


    Private Sub MenuItem136_Click(sender As Object, e As EventArgs)
        Dim frm As frmCashierReadng
        frm = New frmCashierReadng
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmCashierReadng") Then
        '    mFormsTracker.Close("frmCashierReadng")
        '    mFormsTracker.Remove("frmCashierReadng")
        '    frm = New frmCashierReadng

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmCashierReadng
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem138_Click(sender As Object, e As EventArgs)
        Dim frm As frmBaltoSuplier
        frm = New frmBaltoSuplier
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmBaltoSuplier") Then
        '    mFormsTracker.Close("frmBaltoSuplier")
        '    mFormsTracker.Remove("frmBaltoSuplier")
        '    frm = New frmBaltoSuplier

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmBaltoSuplier
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem140_Click(sender As Object, e As EventArgs)
        Dim frm As frmPdToSupplier
        frm = New frmPdToSupplier
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmPdToSupplier") Then
        '    mFormsTracker.Close("frmPdToSupplier")
        '    mFormsTracker.Remove("frmPdToSupplier")
        '    frm = New frmPdToSupplier

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmPdToSupplier
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem141_Click(sender As Object, e As EventArgs)
        Dim frm As frmPaySup

        If mFormsTracker.IsLoaded("frmPaySup") Then
            mFormsTracker.Close("frmPaySup")
            mFormsTracker.Remove("frmPaySup")
            frm = New frmPaySup

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmPaySup
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem142_Click(sender As Object, e As EventArgs)
        Dim frm As frmPdtoSuppliers

        If mFormsTracker.IsLoaded("frmPdtoSuppliers") Then
            mFormsTracker.Close("frmPdtoSuppliers")
            mFormsTracker.Remove("frmPdtoSuppliers")
            frm = New frmPdtoSuppliers

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmPdtoSuppliers
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem143_Click(sender As Object, e As EventArgs)
        Dim frm As frmSalesperRef
        frm = New frmSalesperRef
        frm.Show()
        'frm = Nothing

        'If mFormsTracker.IsLoaded("frmSalesperRef") Then
        '    mFormsTracker.Close("frmSalesperRef")
        '    mFormsTracker.Remove("frmSalesperRef")
        '    frm = New frmSalesperRef

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmSalesperRef
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem144_Click(sender As Object, e As EventArgs)
        Dim frm As frmSalesPerRef2

        If mFormsTracker.IsLoaded("frmSalesPerRef2") Then
            mFormsTracker.Close("frmSalesPerRef2")
            mFormsTracker.Remove("frmSalesPerRef2")
            frm = New frmSalesPerRef2

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmSalesPerRef2
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem145_Click(sender As Object, e As EventArgs) Handles MenuItem145.Click
        ''~~~ Calling it and passing the name of the form to be displayed
        'Dim myObj As abcLockScreen = New abcLockScreen
        'myObj.LockSystemAndShow(Form2)
    End Sub

    Private Sub MenuItem146_Click(sender As Object, e As EventArgs)
        Dim frm As frmOverview

        If mFormsTracker.IsLoaded("frmOverview") Then
            mFormsTracker.Close("frmOverview")
            mFormsTracker.Remove("frmOverview")
            frm = New frmOverview

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmOverview
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem147_Click(sender As Object, e As EventArgs)
        Dim frm As frmExpensesPvt

        If mFormsTracker.IsLoaded("frmExpensesPvt") Then
            mFormsTracker.Close("frmExpensesPvt")
            mFormsTracker.Remove("frmExpensesPvt")
            frm = New frmExpensesPvt

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmExpensesPvt
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub MenuItem148_Click(sender As Object, e As EventArgs)
        Dim frm As frmCheqSales
        frm = New frmCheqSales
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmCheqSales") Then
        '    mFormsTracker.Close("frmCheqSales")
        '    mFormsTracker.Remove("frmCheqSales")
        '    frm = New frmCheqSales

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmCheqSales
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub CashRdngPrint()
        Dim posrep2 As New ZoutReprint()
        'posrep.DataSource = sqlDT
        'posrep2.cashier.Value = PDSAAppConfig.CurrentLoginID
        posrep2.RequestParameters = True
        posrep2.PrintingSystem.ShowMarginsWarning = False
        posrep2.ShowPreview()
    End Sub

    Private Sub MenuItem151_Click(sender As Object, e As EventArgs) Handles MenuItem151.Click
        'Dim posrep2 As New xrReadingID()
        ''posrep.DataSource = sqlDT
        ''posrep2.cashier.Value = PDSAAppConfig.CurrentLoginID
        'posrep2.RequestParameters = False
        'posrep2.PrintingSystem.ShowMarginsWarning = False
        'posrep2.Print()
        Dim frm As frmRdID
        frm = New frmRdID
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmRdID") Then
        '    mFormsTracker.Close("frmRdID")
        '    mFormsTracker.Remove("frmRdID")
        '    frm = New frmRdID

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmRdID
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If

    End Sub

    Private Sub MenuItem152_Click(sender As Object, e As EventArgs) Handles MenuItem152.Click
        Call CashRdngPrint()
    End Sub


    Private Sub MenuItem153_Click(sender As Object, e As EventArgs)
        Dim frm As frmUncleared
        frm = New frmUncleared
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmUncleared") Then
        '    mFormsTracker.Close("frmUncleared")
        '    mFormsTracker.Remove("frmUncleared")
        '    frm = New frmUncleared

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmUncleared
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem154_Click(sender As Object, e As EventArgs) Handles MenuItem154.Click
        'Dim frm As New frmKellerman
        'frm.Show()

        Dim frm As New frmSearchItemsforRefunds
        frm.Show()

        'Dim db As IDataHelper = DataHelper.SessionFactory()
        'db.UserName = "doorscomputers"
        'db.LicenseKey = "GN84+L7G4lvSdOQWmPv5Mmz9904PcWYC5g6EnjTPkoI="

        'Dim table As Table = db.Mapper.GetObjectMap(GetType(bank))
        'table.Fields.ban()
        'Dim frm As frmTouchPOS
        'If mFormsTracker.IsLoaded("frmTouchPOS") Then
        'mFormsTracker.Close("frmTouchPOS")
        'mFormsTracker.Remove("frmTouchPOS")
        'frm = New frmTouchPOS
        'mFormsTracker.Add(frm, Me)
        'frm.MdiParent = Me
        'frm.WindowState = FormWindowState.Maximized
        'frm.Show()
        'frm = Nothing
        'Else
        'frm = New frmTouchPOS
        'mFormsTracker.Add(frm, Me)
        'frm.MdiParent = Me
        'frm.WindowState = FormWindowState.Maximized
        'frm.Show()
        'frm = Nothing
        'End If

    End Sub

    Private Sub MenuItem155_Click(sender As Object, e As EventArgs) Handles MenuItem155.Click
        Dim frm As frmEmployee
        frm = New frmEmployee
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmEmployee") Then
        '    mFormsTracker.Close("frmEmployee")
        '    mFormsTracker.Remove("frmEmployee")
        '    frm = New frmEmployee

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmEmployee
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem158_Click(sender As Object, e As EventArgs) Handles MenuItem158.Click
        Dim frm As frmSuppliers
        frm = New frmSuppliers
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmSuppliers") Then
        '    mFormsTracker.Close("frmSuppliers")
        '    mFormsTracker.Remove("frmSuppliers")
        '    frm = New frmSuppliers

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmSuppliers
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem161_Click(sender As Object, e As EventArgs) Handles MenuItem161.Click
        'Dim backUpRestoreObj As BackupRestore = New BackupRestore
        'backUpRestoreObj.TakeBackUp()


        Try
            If (MessageBox.Show("Do you want to take back up?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                'If (sqlcon.State = ConnectionState.Closed) Then
                '    sqlcon.Open()
                'End If
                'Dim strPath As String = (Application.StartupPath + ("\\Data\\" _
                '           + (PublicVariables._decCurrentCompanyId + "\\DBOpenMiracle.mdf")))

                Dim strPath As String = "C:\Sqldata3\TodaRaba\doorspos.mdf"
                Dim saveBackupDialog As SaveFileDialog = New SaveFileDialog
                Dim strDestinationPath As String = String.Empty
                Dim strFname As String = ("doorspos" + DateTime.Now.ToString("ddMMyyyhhmmss"))
                saveBackupDialog.FileName = strFname
                If (saveBackupDialog.ShowDialog = DialogResult.OK) Then
                    strDestinationPath = saveBackupDialog.FileName
                    strDestinationPath = ("'" _
                                + (strDestinationPath + ".bak'"))
                    'Dim sccmd As SqlCommand = New SqlCommand("CompanyBackUpDb", sqlcon)
                    'sccmd.CommandType = CommandType.StoredProcedure
                    'sccmd.Parameters.Add("@path", SqlDbType.VarChar).Value = strPath
                    'sccmd.Parameters.Add("@name", SqlDbType.VarChar).Value = strDestinationPath
                    'Dim decEffect As Decimal = Convert.ToDecimal(sccmd.ExecuteNonQuery.ToString)

                    Dim sqlSTR As String = String.Empty
                    sqlSTR = "exec BackupDatabase @filename=" + strDestinationPath

                    ' MessageBox.Show(sqlSTR)
                    'sqlSTRR = "SELECT pos_hdrtmp.postmp_hdrid, pos_hdrtmp.pos_date, pos_hdrtmp.custid, pos_hdrtmp.pos_amnt, pos_hdrtmp.tendered, pos_hdrtmp.Cheyns,pos_hdrtmp.Sc, pos_hdrtmp.totsales, pos_hdrtmp.less_vat, pos_hdrtmp.nov, pos_hdrtmp.less_sc, pos_hdrtmp.vatable, pos_hdrtmp.exempt, pos_hdrtmp.vatamnt, pos_hdrtmp.tid, pos_hdrtmp.wtid, pos_dettmp.stckid, pos_dettmp.cost, pos_dettmp.price, pos_dettmp.qty, stocks.barcode, stocks.item_desc, tbls.tdesc, waiters.waiter FROM pos_hdrtmp INNER JOIN pos_dettmp ON pos_hdrtmp.postmp_hdrid = pos_dettmp.postmp_hdrid INNER JOIN stocks ON pos_dettmp.stckid = stocks.stckid INNER JOIN tbls ON pos_hdrtmp.tid = tbls.tid INNER JOIN waiters ON pos_hdrtmp.wtid = waiters.wtid"
                    ExecuteSQLQuery(sqlSTR)
                    MessageBox.Show("The backup of database  completed successfully", "DoorsPOS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(("BR 1 : " + ex.Message), "DOORSPOS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub MenuItem162_Click(sender As Object, e As EventArgs) Handles MenuItem162.Click
        Dim backUpRestoreObj As RestoreDatabases = New RestoreDatabases
        backUpRestoreObj.ResToreDatabases()
    End Sub

    Private Sub MenuItem165_Click(sender As Object, e As EventArgs)
        Dim frm As frmExpired
        If mFormsTracker.IsLoaded("frmExpired") Then
            mFormsTracker.Close("frmExpired")
            mFormsTracker.Remove("frmExpired")
            frm = New frmExpired

            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        Else
            frm = New frmExpired
            mFormsTracker.Add(frm, Me)
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
            frm = Nothing
        End If
    End Sub

    Private Sub mnuNewBarcode(sender As Object, e As EventArgs) Handles MenuItem166.Click
        Dim frm As frmBarcodes
        frm = New frmBarcodes
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmBarcodes") Then
        '    mFormsTracker.Close("frmBarcodes")
        '    mFormsTracker.Remove("frmBarcodes")
        '    frm = New frmBarcodes

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmBarcodes
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem167_Click(sender As Object, e As EventArgs) Handles MenuItem167.Click
        'Dim frm As frmBarcodeGrd

        'If mFormsTracker.IsLoaded("frmBarcodeGrd") Then
        '    mFormsTracker.Close("frmBarcodeGrd")
        '    mFormsTracker.Remove("frmBarcodeGrd")
        '    frm = New frmBarcodeGrd

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmBarcodeGrd
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
        Dim frm As frmAddBarcode
        frm = New frmAddBarcode
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmAddBarcode") Then
        '    mFormsTracker.Close("frmAddBarcode")
        '    mFormsTracker.Remove("frmAddBarcode")
        '    frm = New frmAddBarcode

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmAddBarcode
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub


    Private Sub BIRSalesReportPrint()
        Dim posrep2 As New xrBIRSalesReport()
        posrep2.RequestParameters = True
        posrep2.PrintingSystem.ShowMarginsWarning = False
        posrep2.ShowPreview()
    End Sub

    Private Sub MenuItem169_Click(sender As Object, e As EventArgs)
        Dim frm As frmSummary
        frm = New frmSummary
        frm.Show()
        frm = Nothing

        'If mFormsTracker.IsLoaded("frmSummary") Then
        '    mFormsTracker.Close("frmSummary")
        '    mFormsTracker.Remove("frmSummary")
        '    frm = New frmSummary

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmSummary
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If
    End Sub

    Private Sub MenuItem170_Click(sender As Object, e As EventArgs)
        Dim frm As frmSalesParam
        frm = New frmSalesParam
        frm.Show()
        frm = Nothing
        'If mFormsTracker.IsLoaded("frmSalesParam") Then
        '    mFormsTracker.Close("frmSalesParam")
        '    mFormsTracker.Remove("frmSalesParam")
        '    frm = New frmSalesParam

        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'Else
        '    frm = New frmSalesParam
        '    mFormsTracker.Add(frm, Me)
        '    frm.MdiParent = Me
        '    frm.WindowState = FormWindowState.Maximized
        '    frm.Show()
        '    frm = Nothing
        'End If

    End Sub

    Private Sub MenuItem171_Click(sender As Object, e As EventArgs) Handles MenuItem171.Click
        Me.Close()
    End Sub

    Private Sub MenuItem172_Click(sender As Object, e As EventArgs) Handles mnuBank.Click
        Dim frm As frmBank
        frm = New frmBank
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub mnuCategory_Click(sender As Object, e As EventArgs) Handles mnuCategory.Click
        Dim frm As frmCategory
        frm = New frmCategory
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub mnuBrand_Click(sender As Object, e As EventArgs) Handles mnuBrand.Click
        Dim frm As frmBrand
        frm = New frmBrand
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub MenuItem172_Click_1(sender As Object, e As EventArgs) Handles MenuItem172.Click
        Dim frm As frmExpenseTypes
        frm = New frmExpenseTypes
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub MenuItem173_Click(sender As Object, e As EventArgs) Handles MenuItem173.Click
        Dim frm As frmTypes
        frm = New frmTypes
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub mnuCustomers_Click(sender As Object, e As EventArgs) Handles mnuCustomers.Click
        Dim frm As frmMembers
        frm = New frmMembers
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub mnuItemCost_Click(sender As Object, e As EventArgs) Handles mnuItemCost.Click
        Dim frm As frmItemAmount
        frm = New frmItemAmount
        frm.Show()
        frm = Nothing

    End Sub

    Partial Public Class FiveSevenNine
        Private m_FIVE As Integer
        Private m_SEVEN As Integer
        Private m_NINE As Integer

        Public ReadOnly Property Five() As Integer
            Get
                Return m_FIVE
            End Get
        End Property
        Public ReadOnly Property Seven() As Integer
            Get
                Return m_SEVEN
            End Get
        End Property
        Public ReadOnly Property Nine() As Integer
            Get
                Return m_NINE
            End Get
        End Property
        Public Sub GenerateFromHDD()
            Dim drive As String = "C"
            Dim HDDNum As Integer
            Dim disk As New ManagementObject((Convert.ToString("win32_logicaldisk.deviceid=""") & drive) + ":""")
            'bind our management object
            disk.[Get]()
            'return the serial number
            HDDNum = Integer.Parse(disk("VolumeSerialNumber").ToString(), System.Globalization.NumberStyles.HexNumber)
            GenerateFromDevID(HDDNum)
        End Sub


        Public Sub GenerateFromMAC()
            Dim MACAdd As Int64 = Int64.Parse(GetMACAddress(), System.Globalization.NumberStyles.HexNumber)
            GenerateFromDevID(CInt(MACAdd And &HFFFFFFFFUI))
        End Sub

        Public Sub GenerateForNumber(Number As Integer)
            GenerateFromDevID(Number)
        End Sub
        Private Sub GenerateFromDevID(MACorHDD As Integer)
            m_FIVE = CInt(MACorHDD And &HFF)
            m_SEVEN = CInt(MACorHDD And &HFF00) >> 8
            m_NINE = CInt(MACorHDD And &HFF0000) >> 16
        End Sub

        Private Function GetMACAddress() As String
            Dim mc As New ManagementClass("Win32_NetworkAdapterConfiguration")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            Dim MACAddress As String = [String].Empty
            For Each mo As ManagementObject In moc
                If MACAddress = [String].Empty Then
                    ' only return MAC Address from first card
                    If CBool(mo("IPEnabled")) = True Then
                        MACAddress = mo("MacAddress").ToString()
                    End If
                End If
                mo.Dispose()
            Next

            MACAddress = MACAddress.Replace(":", "")
            Return MACAddress
        End Function


    End Class
    Private Sub sleep(Time As Integer)
        System.Threading.Thread.Sleep(Time)
    End Sub

    Sub GetHDDSer()

        MyHDDGen.GenerateFromHDD()

        strFive = MyHDDGen.Five.ToString()
        strSeven = MyHDDGen.Seven.ToString()
        strNine = MyHDDGen.Nine.ToString()
    End Sub

    Private Sub mnuManualInventory_Click(sender As Object, e As EventArgs)
        Dim frm As frmManualInv
        frm = New frmManualInv
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub mnuSTCredit_Click(sender As Object, e As EventArgs)
        Dim frm As frmSTCredit
        frm = New frmSTCredit
        frm.Show()
        frm = Nothing

    End Sub

    Private Sub mnuRefundToday_Click(sender As Object, e As EventArgs)
        Dim frm As frmRefundsToday
        frm = New frmRefundsToday
        frm.Show()
        frm = Nothing
    End Sub




    Private Sub mnuEditItems_Click(sender As Object, e As EventArgs) Handles mnuEditItems.Click
        Dim frm As frmEditItems
        frm = New frmEditItems
        frm.Show()
        frm = Nothing
    End Sub



    Private Sub MenuItem17_Click(sender As Object, e As EventArgs) Handles MenuItem17.Click
        Dim frm As frmLocation
        frm = New frmLocation
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub MenuItem19_Click(sender As Object, e As EventArgs)
        Dim frm As frmReadingSumGrid
        frm = New frmReadingSumGrid
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub MenuItem20_Click(sender As Object, e As EventArgs)
        Dim frm As frmReadSum
        frm = New frmReadSum
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub MenuItem23_Click(sender As Object, e As EventArgs) Handles MenuItem23.Click
        Dim frm As frmEmployee
        frm = New frmEmployee
        frm.Show()
        frm = Nothing
    End Sub


    Private Sub mnuSJ_Click(sender As Object, e As EventArgs)
        Dim Incentive As New xrSalesHistory()
        Incentive.PrintingSystem.ShowMarginsWarning = False
        Incentive.ShowPreview()
    End Sub

    Private Sub MenuItem157_Click(sender As Object, e As EventArgs)
        Dim Incentive As New xrSalesByItemSummary()
        Incentive.PrintingSystem.ShowMarginsWarning = False
        Incentive.ShowPreview()
    End Sub

    Private Sub MenuItem177_Click(sender As Object, e As EventArgs)
        Dim Incentive As New xrDailyInv()
        Incentive.PrintingSystem.ShowMarginsWarning = False
        Incentive.ShowPreview()
    End Sub

    Private Sub mnuReprintZReading_Click(sender As Object, e As EventArgs) Handles mnuReprintZReading.Click
        Dim posrep2 As New xrZReadingReprint()
        posrep2.RequestParameters = True
        posrep2.PrintingSystem.ShowMarginsWarning = False
        posrep2.ShowPreview()
    End Sub

    Private Sub mnuSettings_Click(sender As Object, e As EventArgs) Handles mnuSettings.Click
        Dim frm As frmSetting
        frm = New frmSetting
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub mnuAdmin_Click(sender As Object, e As EventArgs) Handles mnuAdmin.Click
        Dim frm As frmAdmin
        frm = New frmAdmin
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub MenuItem4_Click(sender As Object, e As EventArgs)
        Dim posrep2 As New xrSalesSummary()
        posrep2.RequestParameters = True
        posrep2.PrintingSystem.ShowMarginsWarning = False
        posrep2.ShowPreview()
    End Sub

    Private Sub MenuItem72_Click(sender As Object, e As EventArgs)
        Dim posrep12 As New xrElectronicSalesBook()
        posrep12.RequestParameters = True
        posrep12.PrintingSystem.ShowMarginsWarning = False
        posrep12.ShowPreview()
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub MenuItem2_Click_2(sender As Object, e As EventArgs) Handles MenuItem2.Click
        Dim posform As New frmTestDapper
        posform.Show()
        posform = Nothing
    End Sub
End Class