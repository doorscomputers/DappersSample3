Imports PDSA.WinForms.Forms
Imports System.Windows.Forms
Imports PDSA.WinForms.Security
Imports System.Windows.Forms.Form
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
'Imports DevExpress.XtraBars.Ribbon
'Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars
Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
'Imports KellermanSoftware.NetDataAccessLayer
Imports System.Management

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
   Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
   Friend WithEvents mnuECopy As System.Windows.Forms.MenuItem
   Friend WithEvents mnuECut As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEPaste As System.Windows.Forms.MenuItem
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
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAmPm As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBelowMin As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAboveMax As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem101 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem102 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem103 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem104 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem106 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem105 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem107 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem108 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem109 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem110 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem111 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem112 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem116 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem117 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem118 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem115 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem114 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem113 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem119 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem120 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem121 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem122 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem124 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem123 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem125 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem126 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem127 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem128 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem129 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem130 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem131 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem132 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem133 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem135 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem134 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem137 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem136 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem139 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem138 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem140 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem141 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem142 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem144 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem143 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem145 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem146 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem147 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem148 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem149 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem150 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem153 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem154 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem155 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem156 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem158 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem159 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem160 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem161 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem162 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem163 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem164 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem165 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem166 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem167 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem168 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem169 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem170 As System.Windows.Forms.MenuItem
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
    Friend WithEvents MenuItem174 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuManualInventory As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSTCredit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRefundToday As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRpPatronage As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBankTrans As System.Windows.Forms.MenuItem
    Friend WithEvents mnuIssueCheck As System.Windows.Forms.MenuItem
    Friend WithEvents mnuChkClearing As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCancelChk As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDepWith As System.Windows.Forms.MenuItem
    Friend WithEvents mnuIncentive As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditItems As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As MenuItem
    Friend WithEvents MenuItem19 As MenuItem
    Friend WithEvents MenuItem20 As MenuItem
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
        Me.mnuPOS = New System.Windows.Forms.MenuItem()
        Me.MenuItem151 = New System.Windows.Forms.MenuItem()
        Me.MenuItem152 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
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
        Me.MenuItem159 = New System.Windows.Forms.MenuItem()
        Me.MenuItem145 = New System.Windows.Forms.MenuItem()
        Me.MenuItem160 = New System.Windows.Forms.MenuItem()
        Me.MenuItem161 = New System.Windows.Forms.MenuItem()
        Me.MenuItem162 = New System.Windows.Forms.MenuItem()
        Me.MenuItem163 = New System.Windows.Forms.MenuItem()
        Me.mnuFSignOut = New System.Windows.Forms.MenuItem()
        Me.mnuFExit = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem174 = New System.Windows.Forms.MenuItem()
        Me.mnuManualInventory = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem64 = New System.Windows.Forms.MenuItem()
        Me.MenuItem58 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem116 = New System.Windows.Forms.MenuItem()
        Me.MenuItem117 = New System.Windows.Forms.MenuItem()
        Me.MenuItem118 = New System.Windows.Forms.MenuItem()
        Me.MenuItem115 = New System.Windows.Forms.MenuItem()
        Me.MenuItem149 = New System.Windows.Forms.MenuItem()
        Me.MenuItem150 = New System.Windows.Forms.MenuItem()
        Me.mnuBankTrans = New System.Windows.Forms.MenuItem()
        Me.mnuIssueCheck = New System.Windows.Forms.MenuItem()
        Me.mnuChkClearing = New System.Windows.Forms.MenuItem()
        Me.mnuCancelChk = New System.Windows.Forms.MenuItem()
        Me.mnuDepWith = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem168 = New System.Windows.Forms.MenuItem()
        Me.mnuAmPm = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem92 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.mnuBelowMin = New System.Windows.Forms.MenuItem()
        Me.mnuAboveMax = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem111 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem165 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem73 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem72 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.mnuRpPatronage = New System.Windows.Forms.MenuItem()
        Me.MenuItem57 = New System.Windows.Forms.MenuItem()
        Me.MenuItem60 = New System.Windows.Forms.MenuItem()
        Me.MenuItem133 = New System.Windows.Forms.MenuItem()
        Me.MenuItem62 = New System.Windows.Forms.MenuItem()
        Me.MenuItem67 = New System.Windows.Forms.MenuItem()
        Me.MenuItem94 = New System.Windows.Forms.MenuItem()
        Me.MenuItem93 = New System.Windows.Forms.MenuItem()
        Me.MenuItem101 = New System.Windows.Forms.MenuItem()
        Me.MenuItem102 = New System.Windows.Forms.MenuItem()
        Me.MenuItem135 = New System.Windows.Forms.MenuItem()
        Me.MenuItem134 = New System.Windows.Forms.MenuItem()
        Me.mnuIncentive = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem169 = New System.Windows.Forms.MenuItem()
        Me.MenuItem144 = New System.Windows.Forms.MenuItem()
        Me.MenuItem170 = New System.Windows.Forms.MenuItem()
        Me.MenuItem132 = New System.Windows.Forms.MenuItem()
        Me.MenuItem51 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.MenuItem69 = New System.Windows.Forms.MenuItem()
        Me.MenuItem143 = New System.Windows.Forms.MenuItem()
        Me.MenuItem112 = New System.Windows.Forms.MenuItem()
        Me.mnuSTCredit = New System.Windows.Forms.MenuItem()
        Me.mnuRefundToday = New System.Windows.Forms.MenuItem()
        Me.MenuItem68 = New System.Windows.Forms.MenuItem()
        Me.MenuItem52 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem110 = New System.Windows.Forms.MenuItem()
        Me.MenuItem104 = New System.Windows.Forms.MenuItem()
        Me.MenuItem141 = New System.Windows.Forms.MenuItem()
        Me.MenuItem142 = New System.Windows.Forms.MenuItem()
        Me.MenuItem153 = New System.Windows.Forms.MenuItem()
        Me.MenuItem139 = New System.Windows.Forms.MenuItem()
        Me.MenuItem138 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem109 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem61 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem65 = New System.Windows.Forms.MenuItem()
        Me.MenuItem66 = New System.Windows.Forms.MenuItem()
        Me.MenuItem77 = New System.Windows.Forms.MenuItem()
        Me.MenuItem103 = New System.Windows.Forms.MenuItem()
        Me.MenuItem108 = New System.Windows.Forms.MenuItem()
        Me.MenuItem106 = New System.Windows.Forms.MenuItem()
        Me.MenuItem105 = New System.Windows.Forms.MenuItem()
        Me.MenuItem107 = New System.Windows.Forms.MenuItem()
        Me.MenuItem119 = New System.Windows.Forms.MenuItem()
        Me.MenuItem120 = New System.Windows.Forms.MenuItem()
        Me.MenuItem121 = New System.Windows.Forms.MenuItem()
        Me.MenuItem122 = New System.Windows.Forms.MenuItem()
        Me.MenuItem147 = New System.Windows.Forms.MenuItem()
        Me.MenuItem124 = New System.Windows.Forms.MenuItem()
        Me.MenuItem129 = New System.Windows.Forms.MenuItem()
        Me.MenuItem123 = New System.Windows.Forms.MenuItem()
        Me.MenuItem125 = New System.Windows.Forms.MenuItem()
        Me.MenuItem126 = New System.Windows.Forms.MenuItem()
        Me.MenuItem128 = New System.Windows.Forms.MenuItem()
        Me.MenuItem130 = New System.Windows.Forms.MenuItem()
        Me.MenuItem131 = New System.Windows.Forms.MenuItem()
        Me.MenuItem127 = New System.Windows.Forms.MenuItem()
        Me.MenuItem148 = New System.Windows.Forms.MenuItem()
        Me.MenuItem137 = New System.Windows.Forms.MenuItem()
        Me.MenuItem136 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem146 = New System.Windows.Forms.MenuItem()
        Me.MenuItem87 = New System.Windows.Forms.MenuItem()
        Me.MenuItem84 = New System.Windows.Forms.MenuItem()
        Me.MenuItem74 = New System.Windows.Forms.MenuItem()
        Me.MenuItem85 = New System.Windows.Forms.MenuItem()
        Me.MenuItem86 = New System.Windows.Forms.MenuItem()
        Me.MenuItem75 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem59 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem114 = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem113 = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.MenuItem83 = New System.Windows.Forms.MenuItem()
        Me.MenuItem88 = New System.Windows.Forms.MenuItem()
        Me.MenuItem89 = New System.Windows.Forms.MenuItem()
        Me.MenuItem54 = New System.Windows.Forms.MenuItem()
        Me.MenuItem90 = New System.Windows.Forms.MenuItem()
        Me.MenuItem91 = New System.Windows.Forms.MenuItem()
        Me.MenuItem56 = New System.Windows.Forms.MenuItem()
        Me.MenuItem78 = New System.Windows.Forms.MenuItem()
        Me.MenuItem55 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem76 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem140 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem63 = New System.Windows.Forms.MenuItem()
        Me.MenuItem70 = New System.Windows.Forms.MenuItem()
        Me.MenuItem71 = New System.Windows.Forms.MenuItem()
        Me.mnuEdit = New System.Windows.Forms.MenuItem()
        Me.mnuECut = New System.Windows.Forms.MenuItem()
        Me.mnuECopy = New System.Windows.Forms.MenuItem()
        Me.mnuEPaste = New System.Windows.Forms.MenuItem()
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
        Me.MenuItem164 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.MenuItem24, Me.mnuBankTrans, Me.MenuItem16, Me.MenuItem33, Me.MenuItem13, Me.mnuEdit, Me.mnuSecurity, Me.MenuItem1, Me.mnuLookups, Me.MenuItem171, Me.mnuWindow, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuNewItems, Me.mnuEditItems, Me.MenuItem176, Me.mnuItemGrid, Me.mnuItemCost, Me.MenuItem175, Me.MenuItem166, Me.MenuItem167, Me.MenuItem10, Me.mnuPOS, Me.MenuItem151, Me.MenuItem152, Me.MenuItem14, Me.MenuItem95, Me.MenuItem100, Me.mnuBank, Me.MenuItem158, Me.mnuBrand, Me.MenuItem172, Me.MenuItem173, Me.mnuCategory, Me.mnuCustomers, Me.MenuItem17, Me.MenuItem159, Me.MenuItem145, Me.MenuItem160, Me.MenuItem161, Me.MenuItem162, Me.MenuItem163, Me.mnuFSignOut, Me.mnuFExit})
        Me.mnuFile.Text = "&File"
        '
        'mnuNewItems
        '
        Me.mnuNewItems.Index = 0
        Me.mnuNewItems.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.mnuNewItems.Text = "New Items Entry Form"
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
        '
        'MenuItem167
        '
        Me.MenuItem167.Index = 7
        Me.MenuItem167.Text = "Item Barcode Grid View"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 8
        Me.MenuItem10.Text = "-"
        '
        'mnuPOS
        '
        Me.mnuPOS.Index = 9
        Me.mnuPOS.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.mnuPOS.Text = "POS"
        '
        'MenuItem151
        '
        Me.MenuItem151.Index = 10
        Me.MenuItem151.Text = "Cashier Reading Ref. Nos."
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 11
        Me.MenuItem152.Text = "Print Cashier Reading"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 12
        Me.MenuItem14.Text = "-"
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 13
        Me.MenuItem95.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem155, Me.MenuItem156, Me.MenuItem96, Me.MenuItem97, Me.MenuItem98, Me.MenuItem99})
        Me.MenuItem95.Text = "Employees"
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
        Me.MenuItem100.Index = 14
        Me.MenuItem100.Text = "-"
        '
        'mnuBank
        '
        Me.mnuBank.Index = 15
        Me.mnuBank.Text = "Bank"
        '
        'MenuItem158
        '
        Me.MenuItem158.Index = 16
        Me.MenuItem158.Text = "Supplier"
        '
        'mnuBrand
        '
        Me.mnuBrand.Index = 17
        Me.mnuBrand.Text = "Brand"
        '
        'MenuItem172
        '
        Me.MenuItem172.Index = 18
        Me.MenuItem172.Text = "Type of Expenses"
        '
        'MenuItem173
        '
        Me.MenuItem173.Index = 19
        Me.MenuItem173.Text = "Item Type/Sizes"
        '
        'mnuCategory
        '
        Me.mnuCategory.Index = 20
        Me.mnuCategory.Text = "Category"
        '
        'mnuCustomers
        '
        Me.mnuCustomers.Index = 21
        Me.mnuCustomers.Text = "Customers"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 22
        Me.MenuItem17.Text = "Location(Other Branch)"
        '
        'MenuItem159
        '
        Me.MenuItem159.Index = 23
        Me.MenuItem159.Text = "-"
        '
        'MenuItem145
        '
        Me.MenuItem145.Index = 24
        Me.MenuItem145.Text = "Next &Counter"
        Me.MenuItem145.Visible = False
        '
        'MenuItem160
        '
        Me.MenuItem160.Index = 25
        Me.MenuItem160.Text = "-"
        '
        'MenuItem161
        '
        Me.MenuItem161.Index = 26
        Me.MenuItem161.Text = "&Backup"
        '
        'MenuItem162
        '
        Me.MenuItem162.Index = 27
        Me.MenuItem162.Text = "&Restore"
        '
        'MenuItem163
        '
        Me.MenuItem163.Index = 28
        Me.MenuItem163.Text = "-"
        '
        'mnuFSignOut
        '
        Me.mnuFSignOut.Index = 29
        Me.mnuFSignOut.Text = "Sign &Out"
        '
        'mnuFExit
        '
        Me.mnuFExit.Index = 30
        Me.mnuFExit.Text = "E&xit"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 1
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem174, Me.mnuManualInventory, Me.MenuItem28, Me.MenuItem22, Me.MenuItem11, Me.MenuItem29, Me.MenuItem30, Me.MenuItem64, Me.MenuItem58, Me.MenuItem31, Me.MenuItem116, Me.MenuItem117, Me.MenuItem118, Me.MenuItem115, Me.MenuItem149, Me.MenuItem150, Me.MenuItem20})
        Me.MenuItem24.Text = "Transaction Forms"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 0
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.MenuItem25.Text = "Delivery Entry Form"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 1
        Me.MenuItem26.Text = "-"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 2
        Me.MenuItem27.Text = "Invoice Payment Form"
        '
        'MenuItem174
        '
        Me.MenuItem174.Index = 3
        Me.MenuItem174.Text = "-"
        '
        'mnuManualInventory
        '
        Me.mnuManualInventory.Index = 4
        Me.mnuManualInventory.Text = "Manual Inventory Entry Form"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 5
        Me.MenuItem28.Text = "-"
        Me.MenuItem28.Visible = False
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 6
        Me.MenuItem22.Text = "Purchase Order Form"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 7
        Me.MenuItem11.Text = "-"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 8
        Me.MenuItem29.Shortcut = System.Windows.Forms.Shortcut.CtrlT
        Me.MenuItem29.Text = "Transfer Stocks Form"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 9
        Me.MenuItem30.Text = "-"
        Me.MenuItem30.Visible = False
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 10
        Me.MenuItem64.Shortcut = System.Windows.Forms.Shortcut.CtrlR
        Me.MenuItem64.Text = "Receive Stocks Form"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 11
        Me.MenuItem58.Text = "-"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 12
        Me.MenuItem31.Text = "BO Form"
        '
        'MenuItem116
        '
        Me.MenuItem116.Index = 13
        Me.MenuItem116.Text = "-"
        '
        'MenuItem117
        '
        Me.MenuItem117.Index = 14
        Me.MenuItem117.Text = "Convert Items to Pcs"
        Me.MenuItem117.Visible = False
        '
        'MenuItem118
        '
        Me.MenuItem118.Index = 15
        Me.MenuItem118.Text = "-"
        '
        'MenuItem115
        '
        Me.MenuItem115.Index = 16
        Me.MenuItem115.Text = "Expenses"
        '
        'MenuItem149
        '
        Me.MenuItem149.Index = 17
        Me.MenuItem149.Text = "-"
        '
        'MenuItem150
        '
        Me.MenuItem150.Index = 18
        Me.MenuItem150.Text = "Re-Print Cashier Reading"
        '
        'mnuBankTrans
        '
        Me.mnuBankTrans.Index = 2
        Me.mnuBankTrans.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuIssueCheck, Me.mnuChkClearing, Me.mnuCancelChk, Me.mnuDepWith})
        Me.mnuBankTrans.Text = "Bank Transactions"
        '
        'mnuIssueCheck
        '
        Me.mnuIssueCheck.Index = 0
        Me.mnuIssueCheck.Text = "Issue Check"
        '
        'mnuChkClearing
        '
        Me.mnuChkClearing.Index = 1
        Me.mnuChkClearing.Text = "Check Clearing"
        '
        'mnuCancelChk
        '
        Me.mnuCancelChk.Index = 2
        Me.mnuCancelChk.Text = "Cancel Check"
        '
        'mnuDepWith
        '
        Me.mnuDepWith.Index = 3
        Me.mnuDepWith.Text = "Deposits/Withdrawals"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem168, Me.mnuAmPm, Me.MenuItem18, Me.MenuItem92, Me.MenuItem38, Me.mnuBelowMin, Me.mnuAboveMax, Me.MenuItem48, Me.MenuItem21, Me.MenuItem111, Me.MenuItem2, Me.MenuItem165, Me.MenuItem7, Me.MenuItem73, Me.MenuItem5, Me.MenuItem4, Me.MenuItem72, Me.MenuItem8, Me.MenuItem12, Me.MenuItem3, Me.MenuItem47, Me.mnuRpPatronage, Me.MenuItem57, Me.MenuItem60, Me.MenuItem133, Me.MenuItem62, Me.MenuItem67, Me.MenuItem94, Me.MenuItem93, Me.MenuItem101, Me.MenuItem102, Me.MenuItem135, Me.MenuItem134, Me.mnuIncentive, Me.MenuItem19})
        Me.MenuItem16.Text = "&Reports"
        '
        'MenuItem168
        '
        Me.MenuItem168.Index = 0
        Me.MenuItem168.Text = "Summary Report"
        '
        'mnuAmPm
        '
        Me.mnuAmPm.Index = 1
        Me.mnuAmPm.Text = "Sales Today(AM-PM)"
        Me.mnuAmPm.Visible = False
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.Text = "-"
        '
        'MenuItem92
        '
        Me.MenuItem92.Index = 3
        Me.MenuItem92.Text = "Items on Stock"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 4
        Me.MenuItem38.Text = "Out of Stock Items"
        '
        'mnuBelowMin
        '
        Me.mnuBelowMin.Index = 5
        Me.mnuBelowMin.Text = "Stocks Below Minimum"
        '
        'mnuAboveMax
        '
        Me.mnuAboveMax.Index = 6
        Me.mnuAboveMax.Text = "Stocks Above Maximum"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 7
        Me.MenuItem48.Text = "Item Ledger"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 8
        Me.MenuItem21.Text = "-"
        '
        'MenuItem111
        '
        Me.MenuItem111.Index = 9
        Me.MenuItem111.Text = "Deliveries per Item"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 10
        Me.MenuItem2.Text = "Deliveries per Supplier"
        '
        'MenuItem165
        '
        Me.MenuItem165.Index = 11
        Me.MenuItem165.Text = "Expiration Dates"
        Me.MenuItem165.Visible = False
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 12
        Me.MenuItem7.Text = "-"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 13
        Me.MenuItem73.Text = "Balance to Suppliers"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 14
        Me.MenuItem5.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 15
        Me.MenuItem4.Text = "Payments to Suppliers"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 16
        Me.MenuItem72.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 17
        Me.MenuItem8.Text = "Transferred Stocks"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 18
        Me.MenuItem12.Text = "-"
        Me.MenuItem12.Visible = False
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 19
        Me.MenuItem3.Text = "Items Returned to Suppliers"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 20
        Me.MenuItem47.Text = "-"
        '
        'mnuRpPatronage
        '
        Me.mnuRpPatronage.Index = 21
        Me.mnuRpPatronage.Text = "Patronage Refund Ledger"
        Me.mnuRpPatronage.Visible = False
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 22
        Me.MenuItem57.Text = "Customers with Balance"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 23
        Me.MenuItem60.Text = "Credits Grouped by Customer(View1)"
        '
        'MenuItem133
        '
        Me.MenuItem133.Index = 24
        Me.MenuItem133.Text = "Credits Grouped by Customer(View2)"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 25
        Me.MenuItem62.Text = "Customer Payments(Grid)"
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 26
        Me.MenuItem67.Text = "Customer Payments(Print)"
        '
        'MenuItem94
        '
        Me.MenuItem94.Index = 27
        Me.MenuItem94.Text = "-"
        '
        'MenuItem93
        '
        Me.MenuItem93.Index = 28
        Me.MenuItem93.Text = "Manual Inventory Difference Report"
        '
        'MenuItem101
        '
        Me.MenuItem101.Index = 29
        Me.MenuItem101.Text = "-"
        '
        'MenuItem102
        '
        Me.MenuItem102.Index = 30
        Me.MenuItem102.Text = "Employee Time In and Time Out"
        Me.MenuItem102.Visible = False
        '
        'MenuItem135
        '
        Me.MenuItem135.Index = 31
        Me.MenuItem135.Text = "-"
        '
        'MenuItem134
        '
        Me.MenuItem134.Index = 32
        Me.MenuItem134.Text = "Cashier Reading Re-Print"
        '
        'mnuIncentive
        '
        Me.mnuIncentive.Index = 33
        Me.mnuIncentive.Text = "Incentives"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 4
        Me.MenuItem33.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem169, Me.MenuItem144, Me.MenuItem170, Me.MenuItem132, Me.MenuItem51, Me.MenuItem34, Me.MenuItem9, Me.MenuItem53, Me.MenuItem69, Me.MenuItem143, Me.MenuItem112, Me.mnuSTCredit, Me.mnuRefundToday, Me.MenuItem68, Me.MenuItem52, Me.MenuItem36, Me.MenuItem110, Me.MenuItem104, Me.MenuItem141, Me.MenuItem142, Me.MenuItem153, Me.MenuItem139, Me.MenuItem138, Me.MenuItem35, Me.MenuItem109, Me.MenuItem45, Me.MenuItem37, Me.MenuItem46, Me.MenuItem6, Me.MenuItem61, Me.MenuItem44, Me.MenuItem43, Me.MenuItem65, Me.MenuItem66, Me.MenuItem77, Me.MenuItem103, Me.MenuItem108, Me.MenuItem106, Me.MenuItem105, Me.MenuItem107, Me.MenuItem119, Me.MenuItem120, Me.MenuItem121, Me.MenuItem122, Me.MenuItem147, Me.MenuItem124, Me.MenuItem129, Me.MenuItem137, Me.MenuItem136})
        Me.MenuItem33.Text = "Grid Reports"
        '
        'MenuItem169
        '
        Me.MenuItem169.Index = 0
        Me.MenuItem169.Text = "Summary Grid View"
        Me.MenuItem169.Visible = False
        '
        'MenuItem144
        '
        Me.MenuItem144.Index = 1
        Me.MenuItem144.Text = "Past Sales per Reference No."
        Me.MenuItem144.Visible = False
        '
        'MenuItem170
        '
        Me.MenuItem170.Index = 2
        Me.MenuItem170.Text = "Sales with Date Parameters"
        Me.MenuItem170.Visible = False
        '
        'MenuItem132
        '
        Me.MenuItem132.Index = 3
        Me.MenuItem132.Text = "Sales History"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 4
        Me.MenuItem51.Text = "Items Sold Grouped by Item"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 5
        Me.MenuItem34.Text = "Items Sold Grouped by Date"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 6
        Me.MenuItem9.Text = "Sales With Profit Figure View1"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 7
        Me.MenuItem53.Text = "Sales With Profit Figure View2"
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = 8
        Me.MenuItem69.Text = "-"
        '
        'MenuItem143
        '
        Me.MenuItem143.Index = 9
        Me.MenuItem143.Text = "Sales Today per Reference No."
        '
        'MenuItem112
        '
        Me.MenuItem112.Index = 10
        Me.MenuItem112.Text = "Cash Sales Today"
        '
        'mnuSTCredit
        '
        Me.mnuSTCredit.Index = 11
        Me.mnuSTCredit.Text = "Credits Today"
        '
        'mnuRefundToday
        '
        Me.mnuRefundToday.Index = 12
        Me.mnuRefundToday.Text = "Refunds Today"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 13
        Me.MenuItem68.Text = "Sales Today by Cashier"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 14
        Me.MenuItem52.Text = "-"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 15
        Me.MenuItem36.Text = "Deliveries per Supplier"
        '
        'MenuItem110
        '
        Me.MenuItem110.Index = 16
        Me.MenuItem110.Text = "Deliveries per Item"
        '
        'MenuItem104
        '
        Me.MenuItem104.Index = 17
        Me.MenuItem104.Text = "Items Buying Price History"
        '
        'MenuItem141
        '
        Me.MenuItem141.Index = 18
        Me.MenuItem141.Text = "Payments to Suppliers View1"
        '
        'MenuItem142
        '
        Me.MenuItem142.Index = 19
        Me.MenuItem142.Text = "Payments to Suppliers View2"
        '
        'MenuItem153
        '
        Me.MenuItem153.Index = 20
        Me.MenuItem153.Text = "Not Cleared PDC"
        '
        'MenuItem139
        '
        Me.MenuItem139.Index = 21
        Me.MenuItem139.Text = "-"
        '
        'MenuItem138
        '
        Me.MenuItem138.Index = 22
        Me.MenuItem138.Text = "Balance to Suppliers"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 23
        Me.MenuItem35.Text = "-"
        Me.MenuItem35.Visible = False
        '
        'MenuItem109
        '
        Me.MenuItem109.Index = 24
        Me.MenuItem109.Text = "Transferred Stocks View1"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 25
        Me.MenuItem45.Text = "Transferred Stocks View2"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 26
        Me.MenuItem37.Text = "-"
        Me.MenuItem37.Visible = False
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 27
        Me.MenuItem46.Text = "Items Transactions Summary View1"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 28
        Me.MenuItem6.Text = "Items Transactions Summary View2"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 29
        Me.MenuItem61.Text = "-"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 30
        Me.MenuItem44.Text = "Inventory w/ Cost/Retail Amount"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 31
        Me.MenuItem43.Text = "Inventory w/ Cost/Retail Total"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 32
        Me.MenuItem65.Text = "-"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 33
        Me.MenuItem66.Text = "Manual Inventory"
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 34
        Me.MenuItem77.Text = "-"
        Me.MenuItem77.Visible = False
        '
        'MenuItem103
        '
        Me.MenuItem103.Index = 35
        Me.MenuItem103.Text = "Received Stocks View1"
        '
        'MenuItem108
        '
        Me.MenuItem108.Index = 36
        Me.MenuItem108.Text = "Received Stocks View2"
        '
        'MenuItem106
        '
        Me.MenuItem106.Index = 37
        Me.MenuItem106.Text = "-"
        '
        'MenuItem105
        '
        Me.MenuItem105.Index = 38
        Me.MenuItem105.Text = "Back Orders View1"
        '
        'MenuItem107
        '
        Me.MenuItem107.Index = 39
        Me.MenuItem107.Text = "Back Orders View2"
        '
        'MenuItem119
        '
        Me.MenuItem119.Index = 40
        Me.MenuItem119.Text = "-"
        '
        'MenuItem120
        '
        Me.MenuItem120.Index = 41
        Me.MenuItem120.Text = "Items Converted to Pcs"
        Me.MenuItem120.Visible = False
        '
        'MenuItem121
        '
        Me.MenuItem121.Index = 42
        Me.MenuItem121.Text = "-"
        '
        'MenuItem122
        '
        Me.MenuItem122.Index = 43
        Me.MenuItem122.Text = "Expenses Grid View"
        '
        'MenuItem147
        '
        Me.MenuItem147.Index = 44
        Me.MenuItem147.Text = "Expenses View"
        '
        'MenuItem124
        '
        Me.MenuItem124.Index = 45
        Me.MenuItem124.Text = "-"
        '
        'MenuItem129
        '
        Me.MenuItem129.Index = 46
        Me.MenuItem129.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem123, Me.MenuItem125, Me.MenuItem126, Me.MenuItem128, Me.MenuItem130, Me.MenuItem131, Me.MenuItem127, Me.MenuItem148})
        Me.MenuItem129.Text = "Other Grid Views"
        '
        'MenuItem123
        '
        Me.MenuItem123.Index = 0
        Me.MenuItem123.Text = "Paetty Cash"
        '
        'MenuItem125
        '
        Me.MenuItem125.Index = 1
        Me.MenuItem125.Text = "Additonal Fund"
        '
        'MenuItem126
        '
        Me.MenuItem126.Index = 2
        Me.MenuItem126.Text = "Discounts"
        '
        'MenuItem128
        '
        Me.MenuItem128.Index = 3
        Me.MenuItem128.Text = "Void Items"
        '
        'MenuItem130
        '
        Me.MenuItem130.Index = 4
        Me.MenuItem130.Text = "Refunds"
        '
        'MenuItem131
        '
        Me.MenuItem131.Index = 5
        Me.MenuItem131.Text = "Changed Price"
        '
        'MenuItem127
        '
        Me.MenuItem127.Index = 6
        Me.MenuItem127.Text = "Cheque Payments"
        '
        'MenuItem148
        '
        Me.MenuItem148.Index = 7
        Me.MenuItem148.Text = "Cheque Payment Sales"
        '
        'MenuItem137
        '
        Me.MenuItem137.Index = 47
        Me.MenuItem137.Text = "-"
        '
        'MenuItem136
        '
        Me.MenuItem136.Index = 48
        Me.MenuItem136.Text = "Cashier Reading View"
        Me.MenuItem136.Visible = False
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 5
        Me.MenuItem13.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem146, Me.MenuItem87, Me.MenuItem84, Me.MenuItem74, Me.MenuItem85, Me.MenuItem86, Me.MenuItem75, Me.MenuItem32, Me.MenuItem59, Me.MenuItem15, Me.MenuItem114, Me.MenuItem49, Me.MenuItem113, Me.MenuItem50, Me.MenuItem83, Me.MenuItem88, Me.MenuItem89, Me.MenuItem54, Me.MenuItem90, Me.MenuItem91, Me.MenuItem56, Me.MenuItem78, Me.MenuItem55, Me.MenuItem39, Me.MenuItem76, Me.MenuItem40, Me.MenuItem41, Me.MenuItem140, Me.MenuItem42, Me.MenuItem63, Me.MenuItem70, Me.MenuItem71})
        Me.MenuItem13.Text = "Dashboard View"
        '
        'MenuItem146
        '
        Me.MenuItem146.Index = 0
        Me.MenuItem146.Text = "Overview of Business Activity"
        '
        'MenuItem87
        '
        Me.MenuItem87.Index = 1
        Me.MenuItem87.Text = "Items Sold Daily (Highest to Lowest)"
        Me.MenuItem87.Visible = False
        '
        'MenuItem84
        '
        Me.MenuItem84.Index = 2
        Me.MenuItem84.Text = "Items Sold Weekly (Highest to Lowest)"
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 3
        Me.MenuItem74.Text = "Items Sold Monthly (Highest to Lowest)"
        '
        'MenuItem85
        '
        Me.MenuItem85.Index = 4
        Me.MenuItem85.Text = "Items Sold Quarterly (Highest to Lowest)"
        '
        'MenuItem86
        '
        Me.MenuItem86.Index = 5
        Me.MenuItem86.Text = "Items Sold Yearly (Highest to Lowest)"
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 6
        Me.MenuItem75.Text = "-"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 7
        Me.MenuItem32.Text = "Sales by Date (Items Sold per Category)"
        Me.MenuItem32.Visible = False
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 8
        Me.MenuItem59.Text = "Sales by Date (Amount Summary)"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 9
        Me.MenuItem15.Text = "Sales by Employee"
        Me.MenuItem15.Visible = False
        '
        'MenuItem114
        '
        Me.MenuItem114.Index = 10
        Me.MenuItem114.Text = "-"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 11
        Me.MenuItem49.Text = "Sales Today per Hour"
        '
        'MenuItem113
        '
        Me.MenuItem113.Index = 12
        Me.MenuItem113.Text = "-"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 13
        Me.MenuItem50.Text = "Past Sales Per Hour"
        '
        'MenuItem83
        '
        Me.MenuItem83.Index = 14
        Me.MenuItem83.Text = "-"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 15
        Me.MenuItem88.Text = "Sales Profit Daily"
        '
        'MenuItem89
        '
        Me.MenuItem89.Index = 16
        Me.MenuItem89.Text = "Sales Profit Weekly"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 17
        Me.MenuItem54.Text = "Sales Profit Monthly"
        '
        'MenuItem90
        '
        Me.MenuItem90.Index = 18
        Me.MenuItem90.Text = "Sales Profit Quarterly"
        Me.MenuItem90.Visible = False
        '
        'MenuItem91
        '
        Me.MenuItem91.Index = 19
        Me.MenuItem91.Text = "Sales Profit Annually"
        Me.MenuItem91.Visible = False
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 20
        Me.MenuItem56.Text = "-"
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 21
        Me.MenuItem78.Text = "Payments by Customers"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 22
        Me.MenuItem55.Text = "Credits by Customers"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 23
        Me.MenuItem39.Text = "-"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 24
        Me.MenuItem76.Text = "Highest-Lowest and Lowest-Highest Dlvrd Items"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 25
        Me.MenuItem40.Text = "Delivery by Date(Amount Summary per Supplier)"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 26
        Me.MenuItem41.Text = "Delivery by Item(Items Delivered Summary)"
        '
        'MenuItem140
        '
        Me.MenuItem140.Index = 27
        Me.MenuItem140.Text = "Payments to Suppliers"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 28
        Me.MenuItem42.Text = "-"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 29
        Me.MenuItem63.Text = "Transferred Items Summary"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 30
        Me.MenuItem70.Text = "-"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 31
        Me.MenuItem71.Text = "Best Customers"
        Me.MenuItem71.Visible = False
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 6
        Me.mnuEdit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuECut, Me.mnuECopy, Me.mnuEPaste})
        Me.mnuEdit.Text = "&Edit"
        Me.mnuEdit.Visible = False
        '
        'mnuECut
        '
        Me.mnuECut.Index = 0
        Me.mnuECut.Text = "Cu&t"
        '
        'mnuECopy
        '
        Me.mnuECopy.Index = 1
        Me.mnuECopy.Text = "&Copy"
        '
        'mnuEPaste
        '
        Me.mnuEPaste.Index = 2
        Me.mnuEPaste.Text = "&Paste"
        '
        'mnuSecurity
        '
        Me.mnuSecurity.Index = 7
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
        Me.MenuItem1.Index = 8
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
        Me.mnuLookups.Index = 9
        Me.mnuLookups.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuLException, Me.mnuLUserTrack, Me.mnuLUserLogin})
        Me.mnuLookups.Text = "Lookups"
        '
        'mnuLException
        '
        Me.mnuLException.Index = 0
        Me.mnuLException.Text = "Errors"
        '
        'mnuLUserTrack
        '
        Me.mnuLUserTrack.Index = 1
        Me.mnuLUserTrack.Text = "User Tracking"
        '
        'mnuLUserLogin
        '
        Me.mnuLUserLogin.Index = 2
        Me.mnuLUserLogin.Text = "User Logins"
        '
        'MenuItem171
        '
        Me.MenuItem171.Index = 10
        Me.MenuItem171.Text = "E&xit"
        '
        'mnuWindow
        '
        Me.mnuWindow.Index = 11
        Me.mnuWindow.MdiList = True
        Me.mnuWindow.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem82, Me.MenuItem81, Me.MenuItem79, Me.MenuItem80, Me.mnuWCloseAll, Me.MenuItem154})
        Me.mnuWindow.Text = "&Window"
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
        Me.mnuHelp.Index = 12
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHFramework, Me.mnuHAbout, Me.MenuItem164})
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
        'MenuItem164
        '
        Me.MenuItem164.Index = 2
        Me.MenuItem164.Text = "kellerman"
        Me.MenuItem164.Visible = False
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 34
        Me.MenuItem19.Text = "Reading Summary"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 19
        Me.MenuItem20.Text = "Reading Summary"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1073, 660)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Menu = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Farmacia Solonio Sales and Inventory Monitoring System -Main"
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
        'Dim mgrRet As pos_hdrManager
        'Dim col33 As pos_hdrCollection
        'mgrRet = New pos_hdrManager()

        'Dim vDate As Date = CDate("11/30/2079")
        'Dim vNow As Date = Date.Today

        'If vDate < vNow Then
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


        'Dim mgrRet As pos_hdrManager
        'Dim col33 As pos_hdrCollection
        'mgrRet = New pos_hdrManager()

        'Dim vDate As Date = CDate("11/29/2017")
        'Dim vNow As Date = Date.Today

        'If vDate < vNow Then
        '    Me.Close()
        '    Exit Sub
        'End If
        ''tbSQL.Text = mgrRetrieve.DataObject.SQL
        'col33 = mgrRet.BuildCollection
        'If mgrRet.DataObject.RowsAffected > 1000000 Then
        '    'Note this is only for Engineer Salming
        '    MessageBox.Show("Evaluation Period is more than 180 days. Pls contact Mr. Satur Cadsi for proper licensing option (0917 655 3488)", "Evaluation Period Expired")
        '    Me.Close()
        '    Exit Sub
        'End If

        'MyHDDGen = New FiveSevenNine()
        'Call GetHDDSer()
        'If strFive <> "168" Then
        '    Me.Close()
        '    Exit Sub
        'End If

        'If strSeven <> "134" Then
        '    Me.Close()
        '    Exit Sub
        'End If

        'If strNine <> "96" Then
        '    Me.Close()
        '    Exit Sub
        'End If

        '' ''Below is for Bro Satur

        'MyHDDGen = New FiveSevenNine()
        'Call GetHDDSer()
        'If strFive <> "209" Then
        '    Me.Close()
        '    Exit Sub
        'End If

        'If strSeven <> "112" Then
        '    Me.Close()
        '    Exit Sub
        'End If

        'If strNine <> "7" Then
        '    Me.Close()
        '    Exit Sub
        'End If

        '' ''End of Comment for Bro Satur 


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
                    mnuECopy.Enabled = False
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

        Dim LowStock As spLowStocksManager
        Dim transGetLowStck As PDSATransaction = New PDSATransaction()
        LowStock = New spLowStocksManager()
        transGetLowStck.Add(LowStock.DataObject)
        transGetLowStck.Execute()

        Dim lowcount As Integer = 0
        Dim hicount As Integer = 0

        lowcount = Convert.ToInt32(LowStock.DataObject.Entity.StockCount)
        If lowcount > 0 Then
            MessageBox.Show("Warning! There are some stocks that are below or equal to Minimum Re-Order Level. Print the report on Stocks Below or Equal Minimum Level")
        End If


        Try
            Dim HiStock As spHiStocksManager
            Dim transpGetHiStck As PDSATransaction = New PDSATransaction()
            HiStock = New spHiStocksManager()
            transpGetHiStck.Add(LowStock.DataObject)
            transpGetHiStck.Execute()

            hicount = Convert.ToInt32(HiStock.DataObject.Entity.StockCount)
            If hicount > 0 Then
                MessageBox.Show("Warning! There are some stocks that are above or equal to Maximum Re-Order Level. Print the report on Stocks Above or Equal to Maximum Level")
            End If

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

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

#Region "Cut/Copy/Paste Code"
    Private Sub mnuECut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuECut.Click
        Dim ctlSelected As Control

        Try
            ctlSelected = PDSAForms.GetActiveMDIChildControl(Me)
            If Not (ctlSelected Is Nothing) Then
                PDSAForms.CutSelection(ctlSelected)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text & ".mnuECut_Click")

        End Try
    End Sub

    Private Sub mnuECopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuECopy.Click
        Dim ctlSelected As Control

        ctlSelected = PDSAForms.GetActiveMDIChildControl(Me)
        If Not (ctlSelected Is Nothing) Then
            PDSAForms.CopySelection(ctlSelected)
        End If
    End Sub

    Private Sub mnuEPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEPaste.Click
        Dim ctlSelected As Control

        Try
            ctlSelected = PDSAForms.GetActiveMDIChildControl(Me)
            If Not (ctlSelected Is Nothing) Then
                PDSAForms.PasteSelection(ctlSelected)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text & ".mnuEPaste_Click")

        End Try
    End Sub

    Private Sub mnuEdit_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEdit.Select
        If PDSAForms.GetActiveMDIChildControl(Me) Is Nothing Then
            mnuECopy.Enabled = ControlSetEnabledProperty("mnuECopy", False)
            mnuECut.Enabled = ControlSetEnabledProperty("mnuECut", False)
            mnuEPaste.Enabled = ControlSetEnabledProperty("mnuEPaste", False)
        Else
            mnuECopy.Enabled = ControlSetEnabledProperty("mnuECopy", True)
            mnuECut.Enabled = ControlSetEnabledProperty("mnuECut", True)
            mnuEPaste.Enabled = ControlSetEnabledProperty("mnuEPaste", True)
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



        If PDSAAppConfig.CurrentLoginID <> "Admin" Then
            Dim mgr As tblreadingManager
            Dim col As New tblreadingCollection

            Try
                mgr = New tblreadingManager()
                mgr.DataObject.WhereFilter = tblreadingData.WhereFilters.CashierStatus
                mgr.Entity.cashier = PDSAAppConfig.CurrentLoginID
                col = mgr.BuildCollection
                If mgr.DataObject.RowsAffected > 0 Then

                    Dim posform As New frmPOS
                    'posform.ShowDialog()
                    posform.Show()
                    posform = Nothing

                Else
                    'Dim begcash As New frmBegCash

                    'begcash.ShowDialog()
                    'begcash = Nothing
                    Dim frm As frmBegCash
                    If mFormsTracker.IsLoaded("frmBegCash") Then
                        mFormsTracker.Close("frmBegCash")
                        mFormsTracker.Remove("frmBegCash")
                        frm = New frmBegCash
                        mFormsTracker.Add(frm, Me)
                        frm.MdiParent = Me
                        frm.WindowState = FormWindowState.Maximized
                        frm.Show()
                        frm = Nothing
                    Else
                        frm = New frmBegCash
                        mFormsTracker.Add(frm, Me)
                        frm.MdiParent = Me
                        frm.WindowState = FormWindowState.Maximized
                        frm.Show()
                        frm = Nothing
                    End If
                End If
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

    Private Sub MenuItem22_Click(sender As Object, e As EventArgs) Handles MenuItem22.Click
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

    Private Sub MenuItem49_Click(sender As Object, e As EventArgs) Handles MenuItem49.Click
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

    Private Sub MenuItem50_Click(sender As Object, e As EventArgs) Handles MenuItem50.Click
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

    Private Sub MenuItem51_Click(sender As Object, e As EventArgs) Handles MenuItem51.Click
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

    Private Sub MenuItem34_Click(sender As Object, e As EventArgs) Handles MenuItem34.Click

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

    Private Sub MenuItem53_Click(sender As Object, e As EventArgs) Handles MenuItem53.Click
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

    Private Sub MenuItem55_Click(sender As Object, e As EventArgs) Handles MenuItem55.Click
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

    Private Sub MenuItem57_Click(sender As Object, e As EventArgs) Handles MenuItem57.Click
        Dim rep As New CustBal
        'rep.ParamCashier.Value = PDSAAppConfig.CurrentLoginID
        'rep.RequestParameters = False
        rep.PrintingSystem.ShowMarginsWarning = False
        rep.ShowPreview()
    End Sub
    Private Sub MenuItem59_Click(sender As Object, e As EventArgs) Handles MenuItem59.Click
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

    Private Sub MenuItem54_Click(sender As Object, e As EventArgs) Handles MenuItem54.Click
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

    Private Sub MenuItem15_Click(sender As Object, e As EventArgs) Handles MenuItem15.Click
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

    Private Sub MenuItem32_Click(sender As Object, e As EventArgs) Handles MenuItem32.Click
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

    Private Sub MenuItem60_Click(sender As Object, e As EventArgs) Handles MenuItem60.Click
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

    Private Sub MenuItem62_Click(sender As Object, e As EventArgs) Handles MenuItem62.Click
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

    Private Sub MenuItem25_Click(sender As Object, e As EventArgs) Handles MenuItem25.Click
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

    Private Sub MenuItem27_Click(sender As Object, e As EventArgs) Handles MenuItem27.Click
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

    Private Sub MenuItem31_Click(sender As Object, e As EventArgs) Handles MenuItem31.Click
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

    Private Sub MenuItem29_Click(sender As Object, e As EventArgs) Handles MenuItem29.Click
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

    Private Sub MenuItem40_Click(sender As Object, e As EventArgs) Handles MenuItem40.Click
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

    Private Sub MenuItem41_Click(sender As Object, e As EventArgs) Handles MenuItem41.Click
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

    Private Sub MenuItem36_Click(sender As Object, e As EventArgs) Handles MenuItem36.Click
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

    Private Sub MenuItem46_Click(sender As Object, e As EventArgs) Handles MenuItem46.Click
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

    Private Sub mnuBelowMin_Click(sender As Object, e As EventArgs) Handles mnuBelowMin.Click
        Dim belowmin As New XrItemsBelowMinim()
        belowmin.PrintingSystem.ShowMarginsWarning = False
        belowmin.ShowPreview()
    End Sub

    Private Sub mnuAboveMax_Click(sender As Object, e As EventArgs) Handles mnuAboveMax.Click
        Dim abovemax As New XRItemsAboveMaxim()
        abovemax.PrintingSystem.ShowMarginsWarning = False
        abovemax.ShowPreview()
    End Sub

    Private Sub MenuItem38_Click(sender As Object, e As EventArgs) Handles MenuItem38.Click
        Dim outofstak As New XrOutofStak()
        outofstak.PrintingSystem.ShowMarginsWarning = False
        outofstak.ShowPreview()
    End Sub

    Private Sub MenuItem44_Click(sender As Object, e As EventArgs) Handles MenuItem44.Click
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

    Private Sub MenuItem43_Click(sender As Object, e As EventArgs) Handles MenuItem43.Click
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

    Private Sub MenuItem45_Click(sender As Object, e As EventArgs) Handles MenuItem45.Click
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

    Private Sub MenuItem63_Click(sender As Object, e As EventArgs) Handles MenuItem63.Click
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

    Private Sub MenuItem64_Click(sender As Object, e As EventArgs) Handles MenuItem64.Click
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

    Private Sub MenuItem66_Click(sender As Object, e As EventArgs) Handles MenuItem66.Click
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

    Private Sub MenuItem48_Click(sender As Object, e As EventArgs) Handles MenuItem48.Click
        Dim posrep As New xrItmLedgers()
        'posrep.Parameter1.Value = mOrderId
        'posrep.RequestParameters = False
        'ceRefno.Value = mOrderId
        posrep.PrintingSystem.ShowMarginsWarning = False
        posrep.ShowPreview()
    End Sub

    Private Sub MenuItem67_Click(sender As Object, e As EventArgs) Handles MenuItem67.Click
        Dim posrep As New xrCustPay()
        posrep.PrintingSystem.ShowMarginsWarning = False
        posrep.ShowPreview()
    End Sub

    Private Sub MenuItem8_Click_1(sender As Object, e As EventArgs) Handles MenuItem8.Click
        Dim rep As New xrTransfers()
        rep.PrintingSystem.ShowMarginsWarning = False
        rep.ShowPreview()
    End Sub

    Private Sub MenuItem6_Click(sender As Object, e As EventArgs) Handles MenuItem6.Click
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

    Private Sub MenuItem9_Click_1(sender As Object, e As EventArgs) Handles MenuItem9.Click
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

    Private Sub MenuItem71_Click(sender As Object, e As EventArgs) Handles MenuItem71.Click
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

    Private Sub MenuItem68_Click(sender As Object, e As EventArgs) Handles MenuItem68.Click
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

    Private Sub MenuItem73_Click(sender As Object, e As EventArgs) Handles MenuItem73.Click
        Dim repsupbal As New xrSupplierBal()
        repsupbal.PrintingSystem.ShowMarginsWarning = False
        repsupbal.ShowPreview()
    End Sub

    Private Sub MenuItem74_Click(sender As Object, e As EventArgs) Handles MenuItem74.Click
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

    Private Sub MenuItem76_Click(sender As Object, e As EventArgs) Handles MenuItem76.Click
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

    Private Sub MenuItem78_Click(sender As Object, e As EventArgs) Handles MenuItem78.Click
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
    Private Sub MenuItem84_Click(sender As Object, e As EventArgs) Handles MenuItem84.Click
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

    Private Sub MenuItem85_Click(sender As Object, e As EventArgs) Handles MenuItem85.Click
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

    Private Sub MenuItem86_Click(sender As Object, e As EventArgs) Handles MenuItem86.Click
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

    Private Sub MenuItem87_Click(sender As Object, e As EventArgs) Handles MenuItem87.Click
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

    Private Sub MenuItem88_Click(sender As Object, e As EventArgs) Handles MenuItem88.Click
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

    Private Sub MenuItem89_Click(sender As Object, e As EventArgs) Handles MenuItem89.Click
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

    Private Sub MenuItem91_Click(sender As Object, e As EventArgs) Handles MenuItem91.Click
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

    Private Sub MenuItem92_Click(sender As Object, e As EventArgs) Handles MenuItem92.Click
        Dim outofstak As New xrAvlblItems()
        outofstak.PrintingSystem.ShowMarginsWarning = False
        outofstak.ShowPreview()
    End Sub

    Private Sub MenuItem93_Click(sender As Object, e As EventArgs) Handles MenuItem93.Click
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

    Private Sub MenuItem102_Click(sender As Object, e As EventArgs) Handles MenuItem102.Click
        Dim xrtime As New xrEmpTime()
        xrtime.ShowPreview()
    End Sub

    Private Sub MenuItem103_Click(sender As Object, e As EventArgs) Handles MenuItem103.Click
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

    Private Sub MenuItem104_Click(sender As Object, e As EventArgs) Handles MenuItem104.Click
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

    Private Sub MenuItem105_Click(sender As Object, e As EventArgs) Handles MenuItem105.Click
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

    Private Sub MenuItem3_Click(sender As Object, e As EventArgs) Handles MenuItem3.Click
        Dim xrborep As New xrBo()
        xrborep.ShowPreview()
    End Sub

    Private Sub MenuItem107_Click(sender As Object, e As EventArgs) Handles MenuItem107.Click
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

    Private Sub MenuItem108_Click(sender As Object, e As EventArgs) Handles MenuItem108.Click
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

    Private Sub MenuItem109_Click(sender As Object, e As EventArgs) Handles MenuItem109.Click
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

    Private Sub MenuItem110_Click(sender As Object, e As EventArgs) Handles MenuItem110.Click
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

    Private Sub MenuItem111_Click(sender As Object, e As EventArgs) Handles MenuItem111.Click
        Dim dritem As New xrDlvry()
        dritem.ShowPreview()
    End Sub

    Private Sub MenuItem2_Click_1(sender As Object, e As EventArgs) Handles MenuItem2.Click
        Dim drrsupplier As New xrDlvrySupplier()
        drrsupplier.ShowPreview()
    End Sub

    Private Sub MenuItem112_Click(sender As Object, e As EventArgs) Handles MenuItem112.Click
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

    Private Sub mnuAmPm_Click(sender As Object, e As EventArgs) Handles mnuAmPm.Click
        'Dim AmpPM As New xrAMPM()
        'AmpPM.ShowPreview()
    End Sub

    Private Sub MenuItem117_Click(sender As Object, e As EventArgs) Handles MenuItem117.Click
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

    Private Sub MenuItem120_Click(sender As Object, e As EventArgs) Handles MenuItem120.Click
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

    Private Sub MenuItem115_Click(sender As Object, e As EventArgs) Handles MenuItem115.Click
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

    Private Sub MenuItem122_Click(sender As Object, e As EventArgs) Handles MenuItem122.Click
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

    Private Sub MenuItem123_Click(sender As Object, e As EventArgs) Handles MenuItem123.Click
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

    Private Sub MenuItem125_Click(sender As Object, e As EventArgs) Handles MenuItem125.Click
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

    Private Sub MenuItem126_Click(sender As Object, e As EventArgs) Handles MenuItem126.Click
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

    Private Sub MenuItem127_Click(sender As Object, e As EventArgs) Handles MenuItem127.Click
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

    Private Sub MenuItem128_Click(sender As Object, e As EventArgs) Handles MenuItem128.Click
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

    Private Sub MenuItem130_Click(sender As Object, e As EventArgs) Handles MenuItem130.Click
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

    Private Sub MenuItem131_Click(sender As Object, e As EventArgs) Handles MenuItem131.Click
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

    Private Sub MenuItem132_Click(sender As Object, e As EventArgs) Handles MenuItem132.Click
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

    Private Sub MenuItem133_Click(sender As Object, e As EventArgs) Handles MenuItem133.Click
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

    Private Sub MenuItem134_Click(sender As Object, e As EventArgs) Handles MenuItem134.Click
        Dim posrep2 As New ZoutReprint()
        'posrep.DataSource = sqlDT
        'posrep2.cashier.Value = PDSAAppConfig.CurrentLoginID
        posrep2.RequestParameters = True
        posrep2.PrintingSystem.ShowMarginsWarning = False
        posrep2.ShowPreview()

    End Sub

    Private Sub MenuItem136_Click(sender As Object, e As EventArgs) Handles MenuItem136.Click
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

    Private Sub MenuItem138_Click(sender As Object, e As EventArgs) Handles MenuItem138.Click
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

    Private Sub MenuItem140_Click(sender As Object, e As EventArgs) Handles MenuItem140.Click
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

    Private Sub MenuItem141_Click(sender As Object, e As EventArgs) Handles MenuItem141.Click
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

    Private Sub MenuItem142_Click(sender As Object, e As EventArgs) Handles MenuItem142.Click
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

    Private Sub MenuItem143_Click(sender As Object, e As EventArgs) Handles MenuItem143.Click
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

    Private Sub MenuItem144_Click(sender As Object, e As EventArgs) Handles MenuItem144.Click
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

    Private Sub MenuItem146_Click(sender As Object, e As EventArgs) Handles MenuItem146.Click
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

    Private Sub MenuItem147_Click(sender As Object, e As EventArgs) Handles MenuItem147.Click
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

    Private Sub MenuItem148_Click(sender As Object, e As EventArgs) Handles MenuItem148.Click
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

    Private Sub MenuItem150_Click(sender As Object, e As EventArgs) Handles MenuItem150.Click
        'Dim posrep2 As New ZoutReprint()
        ''posrep.DataSource = sqlDT
        ''posrep2.cashier.Value = PDSAAppConfig.CurrentLoginID
        'posrep2.RequestParameters = True
        'posrep2.PrintingSystem.ShowMarginsWarning = False
        'posrep2.ShowPreview()
        Call CashRdngPrint()
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


    Private Sub MenuItem153_Click(sender As Object, e As EventArgs) Handles MenuItem153.Click
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

    Private Sub MenuItem165_Click(sender As Object, e As EventArgs) Handles MenuItem165.Click
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

    Private Sub MenuItem168_Click(sender As Object, e As EventArgs) Handles MenuItem168.Click
        Call BIRSalesReportPrint()
    End Sub
    Private Sub BIRSalesReportPrint()
        Dim posrep2 As New xrBIRSalesReport()
        posrep2.RequestParameters = True
        posrep2.PrintingSystem.ShowMarginsWarning = False
        posrep2.ShowPreview()
    End Sub

    Private Sub MenuItem169_Click(sender As Object, e As EventArgs) Handles MenuItem169.Click
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

    Private Sub MenuItem170_Click(sender As Object, e As EventArgs) Handles MenuItem170.Click
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

    Private Sub mnuManualInventory_Click(sender As Object, e As EventArgs) Handles mnuManualInventory.Click
        Dim frm As frmManualInv
        frm = New frmManualInv
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub mnuSTCredit_Click(sender As Object, e As EventArgs) Handles mnuSTCredit.Click
        Dim frm As frmSTCredit
        frm = New frmSTCredit
        frm.Show()
        frm = Nothing

    End Sub

    Private Sub mnuRefundToday_Click(sender As Object, e As EventArgs) Handles mnuRefundToday.Click
        Dim frm As frmRefundsToday
        frm = New frmRefundsToday
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub mnuRpPatronage_Click(sender As Object, e As EventArgs) Handles mnuRpPatronage.Click
        Dim outofstak As New xrAvlblItems()
        outofstak.PrintingSystem.ShowMarginsWarning = False
        outofstak.ShowPreview()
    End Sub

    Private Sub mnuIssueCheck_Click(sender As Object, e As EventArgs) Handles mnuIssueCheck.Click
        Dim frm As frmChkIssue
        frm = New frmChkIssue
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub mnuCancelChk_Click(sender As Object, e As EventArgs) Handles mnuCancelChk.Click
        Dim frm As frmCancelCheck
        frm = New frmCancelCheck
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub mnuIncentive_Click(sender As Object, e As EventArgs) Handles mnuIncentive.Click
        Dim frm As frmIncentiveGrid
        frm = New frmIncentiveGrid
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

    Private Sub MenuItem19_Click(sender As Object, e As EventArgs) Handles MenuItem19.Click
        Dim frm As frmReadingSumGrid
        frm = New frmReadingSumGrid
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub MenuItem20_Click(sender As Object, e As EventArgs) Handles MenuItem20.Click
        Dim frm As frmReadSum
        frm = New frmReadSum
        frm.Show()
        frm = Nothing
    End Sub
End Class