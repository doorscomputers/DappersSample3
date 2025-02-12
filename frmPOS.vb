﻿'Imports PDSA.Data
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Media
Imports System.Runtime.InteropServices
Imports DevExpress.XtraReports.UI
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Public Class frmPOS
    Dim vincentives As Decimal = 0
    Private Const SM_CXSCREEN As Integer = 0
    Private Const SM_CYSCREEN As Integer = 1
    Private Shared HWND_TOP As IntPtr = IntPtr.Zero
    Private Const SWP_SHOWWINDOW As Integer = 64
    Private Declare Function SetWindowPos Lib "user32.dll" Alias "SetWindowPos" (ByVal hWnd As IntPtr, ByVal hWndIntertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As Integer) As Boolean
    Private Declare Function GetSystemMetrics Lib "user32.dll" Alias "GetSystemMetrics" (ByVal Which As Integer) As Integer
    Dim cItemID As String
    Dim nPrice As Decimal
    Dim nWS As Decimal
    Dim nRP As Decimal
    Dim nCost As Decimal
    Dim nProdID As Integer
    Dim nQtyWholesale As Double
    Dim cItem As String
    Dim cItemName As String

    Dim entityval As Integer

    Dim mgr As stocksManager
    Dim mgr2 As stocksManager
    Dim mgr3 As stocksManager
    Dim mgr4 As stocksManager
    Dim mgr6 As stocksManager
    Dim col1 As stocksCollection
    Dim oh As pos_hdrManager
    Dim oht As pos_hdrtmpManager
    Dim od1, od2, od3, od4, od5, od6, od7, od8, od9, od10, od11, od12, od13, od14, od15, od16 As pos_detManager
    Dim odt1, odt2, odt3, odt4, odt5, odt6, odt7, odt8, odt9, odt10, odt11, odt12, odt13, odt14, odt15, odt16 As pos_dettmpManager
    Dim malOrderDetails As New ArrayList
    Dim vBoo As Boolean
    Public Overrides Property Text As String
    Public WithEvents Tran As PDSATransaction
    Public WithEvents Tran2 As PDSATransaction
    Public WithEvents Tran3 As PDSATransaction
    Public WithEvents Tran4 As PDSATransaction
    Private mOrderId As Integer = 0
    Dim ii As Integer
    Dim grdCount As Integer
    Dim cntr As Integer
    Private mOrderHeader As New pos_hdrtmp()
    Private mOrderLine1 As New pos_dettmp()
    Public qtyy As Decimal = 1 ' qtyy is the quantity pre-set by the cashier ModifyQty
    Public Shared vpieces As Decimal = 1 'ModifyQty
    Public Shared vPriceChange As Decimal = 0
    Public Shared vdisc As Integer = 0
    Public Shared vdiscamnt As Decimal = 0
    Public Shared vtotalsales As Decimal = 0
    Public Shared Tots As Decimal = 0
    Public Shared vtendered As String = String.Empty
    Public Shared vchange As String = String.Empty
    Public origprice As Decimal = 0
    Public NuPrice As Decimal = 0
    Dim itemcnt As Integer = 0
    Public Shared passcorrect As Boolean = False

    Public vItem As String = String.Empty
    Public vStckid As Integer = 0
    Public vPrice As Decimal = 0
    Public vWPrice As Decimal = 0
    Public vbocde As String = String.Empty
    Public vAvlbl As Decimal = 0 ' ModifyQty
    Public vInnerQty As Decimal = 0 'ModifyQty
    Public vboolItemFound As Boolean = False

    Dim Vatable As Decimal = 0
    Dim NonVatable As Decimal = 0
    Dim vCellValIncent As Integer = 0
    Public Shared mOrderId2 As Integer = 0
    Public Shared vStrCustName As String = String.Empty
    Dim SeniorDiscount As Decimal = 0
    Public vPricingMode As String = "Retail"
    Public Shared vBarcodeOrItemSearch As Boolean = True
    Dim vTotalQtySold As Decimal = 0
    Dim SDClicked As Integer = 0
    Dim RDClicked As Integer = 0
    Dim refQty As Integer = 0
    Dim refAmount As Decimal = 0
    Dim refDiscount As Decimal = 0
    Dim NewPrice As Decimal = 0
    Dim Amount As Decimal = 0
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Shared hookID As IntPtr = IntPtr.Zero
    Private Shared proc As LowLevelKeyboardProc = AddressOf HookCallback
    Public vCategoryID As Integer
    Public vCategoryDiscount As Decimal
    Public vCategoryDiscountAmount As Decimal
    Public vDiscountedAmount As Decimal



    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetWindowsHookEx(idHook As Integer, lpfn As LowLevelKeyboardProc, hMod As IntPtr, dwThreadId As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function UnhookWindowsHookEx(hhk As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function CallNextHookEx(hhk As IntPtr, nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function GetModuleHandle(lpModuleName As String) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function

    Private Delegate Function LowLevelKeyboardProc(nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr

    Private Shared Function HookCallback(nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
        If nCode >= 0 Then
            Dim vkCode As Integer = Marshal.ReadInt32(lParam)
            If (wParam = CType(&H100, IntPtr) Or wParam = CType(&H104, IntPtr)) Then
                ' Check for key combinations to block
                If (vkCode = Keys.F4 AndAlso My.Computer.Keyboard.AltKeyDown) OrElse
                   (vkCode = Keys.Escape AndAlso My.Computer.Keyboard.CtrlKeyDown AndAlso My.Computer.Keyboard.AltKeyDown) OrElse
                   (vkCode = Keys.Escape AndAlso My.Computer.Keyboard.CtrlKeyDown) OrElse
                   (vkCode = Keys.LWin Or vkCode = Keys.RWin) OrElse
                   (vkCode = Keys.D AndAlso (GetAsyncKeyState(Keys.LWin) < 0 Or GetAsyncKeyState(Keys.RWin) < 0)) OrElse
                   (vkCode = Keys.Tab AndAlso My.Computer.Keyboard.AltKeyDown) Then
                    Return CType(1, IntPtr)  ' Block the key press
                End If
            End If
        End If
        Return CallNextHookEx(hookID, nCode, wParam, lParam)
    End Function

    Public Shared Sub SetHook()
        If hookID = IntPtr.Zero Then
            hookID = SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(Nothing), 0)
        End If
    End Sub

    Public Shared Sub Unhook()
        If hookID <> IntPtr.Zero Then
            UnhookWindowsHookEx(hookID)
            hookID = IntPtr.Zero
        End If
    End Sub

    Public ReadOnly Property ScreenX() As Integer
        Get
            Return GetSystemMetrics(SM_CXSCREEN)
        End Get
    End Property

    Public ReadOnly Property ScreenY() As Integer
        Get
            Return GetSystemMetrics(SM_CYSCREEN)
        End Get
    End Property

    Private Sub FullScreen()
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.None
        Me.TopMost = True
        SetWindowPos(Me.Handle, HWND_TOP, 0, 0, ScreenX, ScreenY, SWP_SHOWWINDOW)
    End Sub

    Public Sub NormalScreen()
        Me.WindowState = FormWindowState.Normal
        Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
        Me.TopMost = False
    End Sub

    Private Sub frmPOS_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtTendered.Text = vtendered
        lblChange.Text = vchange

    End Sub

    Private Sub frmPOS_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmPOS_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ''If e.KeyCode = Keys.Escape Then
        ''    e.Handled = True
        ''End If
        'If e.KeyCode = Keys.ShiftKey Then
        '    ContextMenuStrip1.Show()
        'Else
        '    Exit Sub
        'End If

        'If e.KeyCode = Keys.S AndAlso e.Control = True Then
        '    Dim frm As frmSalestoday
        '    frm = New frmSalestoday
        '    frm.Show()
        '    frm = Nothing
        '    Exit Sub
        'End If


        'If e.KeyCode = Keys.C AndAlso e.Control = True Then
        '    vStrCustName = CStr(InputBox("Enter Customer Name", "Customer Name", vStrCustName))
        '    If vStrCustName <> "" Then
        '        Dim straqlUpdateCustName As String = String.Empty
        '        straqlUpdateCustName = "UPDATE members SET lastname='" & vStrCustName & "'" & " WHERE CustId=1"
        '        ExecuteSQLQuery(straqlUpdateCustName)
        '        straqlUpdateCustName = String.Empty
        '        straqlUpdateCustName = "UPDATE members SET firstname=' ' WHERE CustId=1"
        '        ExecuteSQLQuery(straqlUpdateCustName)
        '    End If
        '    Exit Sub
        'End If

        'If e.KeyCode = Keys.Alt Then
        '    txtBarcode.Text = ""
        'End If

        'If e.KeyCode = Keys.F2 Then
        '    e.Handled = True
        '    Dim frm As New frmPriceLookup2
        '    frm.ShowDialog()
        '    'txtBarcode.Focus()
        '    'btnSearchItems.Focus()
        '    'txtitem.focus()
        '    txtitem.Text = String.Empty
        '    txtitem.Focus()
        'End If

        'If e.KeyCode = Keys.F3 Then
        '    e.Handled = True
        '    Dim frmcp As New frmCreditPayment
        '    frmcp.ShowDialog()
        '    btnnew.Focus()
        'End If



        'If e.KeyCode = Keys.F12 Then
        '    Dim vYesNo As Boolean = True
        '    Dim grdcountt As Integer = 0
        '    Dim iiiay As Integer = 0
        '    Dim I As Integer = 0
        '    Dim iCounter As Integer = 0
        '    Dim iiCounter As Integer = 0
        '    Dim vboolVAT As Integer
        '    ' compute the total for the recipt
        '    Tots = 0
        '    For I = 0 To PosGrid.Rows.Count - 1
        '        'MessageBox.Show(CStr(PosGrid.Rows.Count))
        '        Tots += CDec(PosGrid.Rows(I).Cells(6).Value)
        '    Next
        '    txtCounts.Text = CStr(PosGrid.Rows.Count)
        '    txtCounts.Text = CStr(PosGrid.Rows.Count)
        '    '+I commented this 2 lines of code below-Uncommne tif anything goes wrong
        '    'txtSum.Text = FormatNumber(Tots, 2, , TriState.False, TriState.False) 'FormatNumber(CStr(Tots))
        '    'vpTotalSales = Tots
        '    '+End of Comment Above

        '    Vatable = 0
        '    NonVatable = 0
        '    For iCounter = 0 To PosGrid.Rows.Count - 1
        '        ''MessageBox.Show(CStr(PosGrid.Rows.Count))
        '        'vboolVAT = CBool(PosGrid.Rows(iCounter).Cells(9).Value)
        '        vboolVAT = CInt(PosGrid.Rows(iCounter).Cells(11).Value)
        '        If vboolVAT = 1 Then
        '            Vatable += CDec(PosGrid.Rows(iCounter).Cells(6).Value)
        '        End If

        '    Next

        '    iiCounter = 0

        '    For iiCounter = 0 To PosGrid.Rows.Count - 1
        '        ''MessageBox.Show(CStr(PosGrid.Rows.Count))
        '        'vboolVAT = CBool(PosGrid.Rows(iiCounter).Cells(9).Value)
        '        vboolVAT = CInt(PosGrid.Rows(iiCounter).Cells(11).Value)
        '        If vboolVAT = 0 Then
        '            NonVatable += CDec(PosGrid.Rows(iiCounter).Cells(6).Value)
        '        End If

        '    Next



        '    grdcountt = PosGrid.Rows.Count
        '    Try
        '        If cmbPaymentType.Text = "CREDIT" And txtcustid.Text = "1" Then
        '            MessageBox.Show("Change the payment type to CASH before collecting the payment or change a customer name because it is currently not charge to any customer")
        '            Exit Sub
        '        End If

        '        For iiiay = 0 To grdcountt - 1
        '            If CDec(PosGrid.Rows(iiiay).Cells(5).Value) <= 0 Then

        '                ' Zero Price found
        '                MessageBox.Show("There is an Item with a Price that is Not valid or less than 0.1")
        '                vYesNo = False
        '                'Exit For
        '                Exit Sub
        '            End If

        '            'If CInt(PosGrid.Rows(iiiay).Cells(2).Value) <= 0 Then

        '            '' Zero Qty found
        '            'MessageBox.Show("There is an Item with a Qty that is Not valid or equal to 0")
        '            'vYesNo = False
        '            ''Exit For
        '            'Exit Sub
        '            'End If

        '            'If CDec(PosGrid.Rows(iiiay).Cells(6).Value) <= 0 Then

        '            '' Zero Qty found
        '            'MessageBox.Show("There is an Item with an Amount that is Not valid or equal to 0")
        '            'vYesNo = False
        '            ''Exit For
        '            'Exit Sub
        '            'End If

        '        Next


        '        If CDec(txtSum.Text) < 0 Then
        '            txtSum.Text = FormatNumber(Tots, 2, , TriState.False, TriState.False)
        '        End If

        '        ''Try to check if there is a price that is not valid(less than or equal to zero and letters maybe)
        '        'Dim IIII As Integer = 0
        '        'For IIII = 0 To PosGrid.Rows.Count - 1
        '        '    Dim number As Decimal
        '        '    Dim result As Boolean = Decimal.TryParse(CStr(CDec(PosGrid.Rows(IIII).Cells(4).Value)), number)
        '        '    If CDec(CStr(PosGrid.Rows(IIII).Cells(4).Value)) <= 0 Then
        '        '        MessageBox.Show("W A R N I N G !!!!!! Price Must be Greater than Zero")
        '        '        Exit Sub
        '        '    End If
        '        '    If result Then
        '        '        ' Console.WriteLine("Converted '{0}' to {1}.", PosGrid.Rows(IIII).Cells(4).Value, number)
        '        '    Else
        '        '        If PosGrid.Rows(IIII).Cells(4).Value Is Nothing Then PosGrid.Rows(IIII).Cells(4).Value = ""
        '        '        MessageBox.Show("W A R N I N G !!!!!! Price Must be Greater than Zero")
        '        '        MessageBox.Show(CStr(PosGrid.Rows(IIII).Cells(4).Value))
        '        '        Exit Sub
        '        '        Exit For
        '        '    End If

        '        'Next

        '        'IF no problem them take payment


        '        If vYesNo = False Then
        '            Exit Sub
        '        End If
        '        If btnSaves.Enabled = False Then
        '            Exit Sub
        '        End If
        '        TakePayment()

        '        'If PosGrid.Rows.Count >= 1 Then
        '        '    If txtTendered.Text = "0" Then
        '        '        MessageBox.Show("Sales Transaction is not yet paid!")
        '        '        btnSave.Focus()
        '        '        Exit Sub
        '        '    End If

        '        'End If
        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString())
        '    End Try
        'End If

        'If e.KeyCode = Keys.F4 Then
        '    ''~~~ Calling it and passing the name of the form to be displayed
        '    'Dim myObj As abcLockScreen = New abcLockScreen
        '    'myObj.LockSystemAndShow(Form2)

        '    vSalesNum = CInt(InputBox("Enter the sales number to be printed", "Reprint", CStr(ceRefno.Text)))
        '    Dim posrep As New xrReceiptTodaRaba()
        '    'posrep.DataSource = sqlDT
        '    posrep.Parameter1.Value = vSalesNum
        '    posrep.RequestParameters = False
        '    posrep.PrintingSystem.ShowMarginsWarning = False
        '    posrep.Print()

        'End If


        'If e.KeyCode = Keys.F5 Then
        '    'If btnnew.Enabled = False Then
        '    If PosGrid.Rows.Count > 0 Then
        '        SuspendTrans()
        '    Else
        '        'btnSearchItems.Focus()
        '        'txtitem.Focus()
        '        txtitem.Text = String.Empty

        '        txtitem.Focus()
        '        'End If
        '    End If
        'End If

        'If e.KeyCode = Keys.F6 Then
        '    If btnnew.Enabled = False Then
        '        If PosGrid.Rows.Count > 1 Then
        '            MessageBox.Show("Pls. finish the existing sales transaction before retrieving a suspended sale.")
        '            Exit Sub
        '        Else
        '            Call RetrieveTrans()
        '        End If
        '    End If
        'End If

        'If e.KeyCode = Keys.F7 Then
        '    If btnnew.Enabled = False Then
        '        cmbPriceMode.Text = "Refund"
        '        'txtBarcode.Focus()
        '        'btnSearchItems.Focus()
        '        txtitem.Focus()
        '        txtitem.Text = String.Empty
        '        txtitem.Focus()
        '    End If
        'End If

        'If e.KeyCode = Keys.F8 Then
        '    'If PosGrid.Rows.Count > 1 Then
        '    'MessageBox.Show("Pls. finish the existing sales transaction before retrieving a suspended sale.")
        '    'Exit Sub
        '    'Else
        '    'Call RetrieveTrans()
        '    'End If
        '    Call RePrint()
        'End If

        If e.KeyCode = Keys.F9 Then
            Unhook()
        End If

        'If e.KeyCode = Keys.F9 Then

        '    itemcnt = 0
        '    vdisc = 0
        '    vdiscamnt = 0
        '    vEmpID = 1
        '    txtTendered.Text = "0"
        '    Try

        '        txtSum.Text = "0"
        '        PosGrid.Rows.Clear()
        '        txtBarcode.Text = String.Empty
        '        txtitem.Text = String.Empty
        '        'txtTendered.Text = "0"
        '        'lblChange.Text = "0"
        '        ceWtid.Value = 1
        '        vtotalsales = 0
        '        vpTotalSales = 0
        '        txtcustid.Text = "1"
        '        txtqty.Text = "0"
        '        txtlastname.Text = "CASH"
        '        txtfirstname.Text = String.Empty
        '        btnSaves.Enabled = True
        '        btnPriceMode.Enabled = True
        '        btnType.Enabled = True
        '        btnSuspend.Enabled = True
        '        btnRetrieve.Enabled = True
        '        btnRemove.Enabled = True
        '        btnDiscount.Enabled = True
        '        Button1.Enabled = True ' this is the Set Quantity button
        '        btnCustomers.Enabled = True
        '        txtBarcode.Enabled = True
        '        btnSearchItems.Enabled = True
        '        btnReprint.Enabled = True
        '        txtbcodes.Text = String.Empty
        '        txtStckid.Text = String.Empty
        '        btnType.Enabled = True
        '        btnPriceMode.Enabled = True
        '        btnCustomers.Enabled = True
        '        btnSuspend.Enabled = True
        '        btnRetrieve.Enabled = True
        '        btnRemove.Enabled = True
        '        cmbPriceMode.Text = "Retail"
        '        cmbPaymentType.Text = "CASH"
        '        btnChequePayment.Enabled = True
        '        'GridLookUpEdit2.Enabled = True
        '        txtitem.Enabled = True

        '        'txtBarcode.Focus()
        '        'btnSearchItems.Focus()
        '        txtitem.Focus()
        '        txtitem.Text = String.Empty
        '        btnnew.Enabled = False
        '        txtitem.Focus()

        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString())
        '    End Try
        'End If





        'If e.KeyCode = Keys.F10 Then
        '    If btnSaves.Enabled = True And PosGrid.Rows.Count >= 1 Then
        '        MessageBox.Show("Please Complete a Pending Sales Transaction First")
        '        Exit Sub
        '    End If
        '    txtBarcode.Enabled = False
        '    btnBcode.Enabled = False
        '    btnSearchItems.Enabled = False
        '    btnPriceMode.Enabled = False
        '    btnType.Enabled = False
        '    btnSaves.Enabled = False
        '    btnSuspend.Enabled = False
        '    btnRetrieve.Enabled = False
        '    btnRemove.Enabled = False
        '    btnCreditPay.Enabled = False
        '    btnChequePayment.Enabled = False
        '    btnnew.Enabled = False
        '    btnLookuprice.Enabled = False
        '    btnPickup.Enabled = False
        '    btnAddCash.Enabled = False
        '    btnDiscount.Enabled = False
        '    Button1.Enabled = False
        '    btnCustomers.Enabled = False
        '    PosGrid.Enabled = False

        '    Dim frmread As New frmReading
        '    frmread.ShowDialog()
        '    frmread = Nothing
        '    Me.Close()
        'End If

        'If e.KeyCode = Keys.G AndAlso e.Control = True Then
        '    PosGrid.Focus()
        'End If
        ''If e.KeyCode = Keys.F1 Then
        ''    If PosGrid.Rows.Count >= 1 Then
        ''        SetQuantity()
        ''    End If

        ''End If


        'If e.KeyCode = Keys.E AndAlso e.Shift = True Then
        '    InputPassword()
        'End If

        'If e.KeyCode = Keys.I AndAlso e.Control = True Then
        '    txtitem.Focus()
        '    txtitem.Focus()
        'End If

        'If e.KeyCode = Keys.Q AndAlso e.Control = True Then
        '    Try
        '        Dim formQty As New frmQty
        '        formQty.ShowDialog()
        '        txtitem.Focus()
        '        txtitem.Text = String.Empty
        '        txtitem.Focus()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString())
        '    End Try

        'End If

    End Sub
    'Private Sub txtBarcode_GotFocus(sender As Object, e As System.EventArgs) Handles txtBarcode.GotFocus
    'GridLookUpEdit1.EditValue = vbNullString
    'End Sub

    Sub InputPassword()
        username = String.Empty
        Try
            Dim mgremp As New waitersManager()
            Dim cols As New waitersCollection
            mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword
            Dim strIncentive As String = String.Empty
            strIncentive = InputBox("Please Enter your Code")

            mgremp.Entity.pword = Trim(strIncentive)
            cols = mgremp.BuildCollection()
            If mgremp.DataObject.RowsAffected > 0 Then
                ceWtid.Value = mgremp.DataObject.Entity.wtid
                MessageBox.Show(CStr(mgremp.DataObject.Entity.waiter))
            Else
                MessageBox.Show("Not a valid Code, try again.")

            End If
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub SendItemtoGrid()
        ' get the details of the item
        'Dim R As POS.POSDS.ItemsRow = Button1.Tag
        ' next search for the barcode in the datagridview
        qtyy = vpieces

        Dim I As Integer = 0
        Dim ItemLoc As Integer = -1

        Try

            For I = 0 To PosGrid.Rows.Count - 1
                If nProdID = CInt(PosGrid.Rows(I).Cells(0).Value) Then

                    ' item found
                    ItemLoc = I
                    Exit For
                End If
            Next

            ' if item is not found, add it
            If ItemLoc = -1 Then
                If qtyy = 1 Then
                    If cmbPriceMode.Text = "Retail" Then
                        PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail, qtyy, mgr.DataObject.Entity.retail, mgr.DataObject.Entity.retail)
                        'ElseIf cmbPriceMode.Text = "Wholesale" Then
                        'PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail2, qtyy, mgr.DataObject.Entity.retail2, mgr.DataObject.Entity.retail2)
                    End If
                    'New Code
                    If cmbPriceMode.Text = "Refund" Then
                        PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail, qtyy * -1, mgr.DataObject.Entity.retail * -1)
                    End If
                    'end of new code
                Else

                    If cmbPriceMode.Text = "Retail" Then
                        PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail, qtyy, mgr.DataObject.Entity.retail * qtyy, mgr.DataObject.Entity.retail)
                        'Else
                        'PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail2, qtyy, mgr.DataObject.Entity.retail2 * qtyy, mgr.DataObject.Entity.retail2)
                    End If

                    If cmbPriceMode.Text = "Refund" Then
                        PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail, qtyy * -1, mgr.DataObject.Entity.retail * (qtyy * -1))
                        cmbPriceMode.Text = "Retail"
                        'Else
                        ' PosGrid.Rows.Add(mgr.DataObject.Entity.stckid, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.itemdesc, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail2, qtyy, mgr.DataObject.Entity.retail2 * (qtyy * -1))
                    End If


                End If


            Else
                If cmbPriceMode.Text = "Retail" Then
                    ' if item is already there increase its count
                    Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(5).Value)
                    ItemCount += 1
                    Dim NewPrice As Decimal = mgr.DataObject.Entity.retail * ItemCount
                    PosGrid.Rows(ItemLoc).Cells(5).Value = ItemCount
                    PosGrid.Rows(ItemLoc).Cells(6).Value = NewPrice
                ElseIf cmbPriceMode.Text = "Wholesale" Then
                    ' if item is already there increase its count
                    Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(5).Value)
                    ItemCount += 1
                    Dim NewPrice As Decimal = mgr.DataObject.Entity.retail2 * ItemCount
                    PosGrid.Rows(ItemLoc).Cells(5).Value = ItemCount
                    PosGrid.Rows(ItemLoc).Cells(6).Value = NewPrice
                Else
                    Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(5).Value)
                    ItemCount += 1
                    Dim NewPrice As Decimal = mgr.DataObject.Entity.retail * (ItemCount * -1)
                    PosGrid.Rows(ItemLoc).Cells(5).Value = ItemCount
                    PosGrid.Rows(ItemLoc).Cells(6).Value = NewPrice
                    cmbPriceMode.Text = "Retail"
                End If

            End If
            '' next clear textbox1 and set focus to it
            'TextBox1.Text = ""
            'TextBox1.Focus()
            ' compute the total for the recipt
            'Dim Tots As Decimal = 0
            Tots = 0
            For I = 0 To PosGrid.Rows.Count - 1
                Tots += CDec(PosGrid.Rows(I).Cells(6).Value)
            Next

            txtCounts.Text = CStr(PosGrid.Rows.Count)

            'Scroll to the last row.
            Me.PosGrid.FirstDisplayedScrollingRowIndex = Me.PosGrid.RowCount - 1

            'Select the last row.
            Me.PosGrid.Rows(Me.PosGrid.RowCount - 1).Selected = True

            'CalcEdit1.Value = Tots
            txtCounts.Text = CStr(PosGrid.Rows.Count)
            txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots))
            CheckSumifNegative()
            vpTotalSales = Tots
            'TextEdit1.Text = FormatCurrency(CStr(Tots))
            qtyy = 1
            vpieces = 1
            'itemcnt = PosGrid.Rows.Count

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub SendItemtoGrid2()
        ' get the details of the item
        'Dim R As POS.POSDS.ItemsRow = Button1.Tag
        ' next search for the barcode in the datagridview
        Dim I As Integer
        Dim ItemLoc As Integer = -1


        Try

            For I = 0 To PosGrid.Rows.Count - 1
                If nProdID = CInt(PosGrid.Rows(I).Cells(0).Value) Then

                    ' item found
                    ItemLoc = I
                    Exit For
                End If
            Next

            ' if item is not found, add it
            If ItemLoc = -1 Then
                If qtyy = 1 Then
                    PosGrid.Rows.Add(mgr4.DataObject.Entity.stckid, mgr4.DataObject.Entity.barcode, mgr4.DataObject.Entity.itemdesc, mgr4.DataObject.Entity.cost, mgr4.DataObject.Entity.retail, qtyy, mgr4.DataObject.Entity.retail, mgr4.DataObject.Entity.retail)
                Else
                    PosGrid.Rows.Add(mgr4.DataObject.Entity.stckid, mgr4.DataObject.Entity.barcode, mgr4.DataObject.Entity.itemdesc, mgr4.DataObject.Entity.cost, mgr4.DataObject.Entity.retail, qtyy, mgr4.DataObject.Entity.retail * qtyy, mgr4.DataObject.Entity.retail)
                End If
            Else
                ' if item is already there increase its count
                Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(5).Value)
                ItemCount += 1
                Dim NewPrice As Decimal = mgr.DataObject.Entity.retail * ItemCount
                PosGrid.Rows(ItemLoc).Cells(5).Value = ItemCount
                PosGrid.Rows(ItemLoc).Cells(6).Value = NewPrice
            End If


            '' next clear textbox1 and set focus to it
            'TextBox1.Text = ""
            'TextBox1.Focus()

            ' compute the total for the recipt
            'Dim Tots As Decimal = 0
            For I = 0 To PosGrid.Rows.Count - 1
                Tots += CDec(PosGrid.Rows(I).Cells(6).Value)
            Next
            txtCounts.Text = CStr(PosGrid.Rows.Count)

            'Scroll to the last row.
            Me.PosGrid.FirstDisplayedScrollingRowIndex = Me.PosGrid.RowCount - 1

            'Select the last row.
            Me.PosGrid.Rows(Me.PosGrid.RowCount - 1).Selected = True

            'CalcEdit1.Value = Tots
            txtCounts.Text = CStr(PosGrid.Rows.Count)
            txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots))
            CheckSumifNegative()
            vpTotalSales = Tots
            'TextEdit1.Text = FormatCurrency(CStr(Tots))
            qtyy = 1
            'itemcnt = PosGrid.Rows.Count
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub SendItemtoGrid3()
        Dim I As Integer = 0
        Dim ItemLoc As Integer = -1
        'Uncomment this if the ceQTy Control will be removed
        'qtyy = vpieces
        'New Code
        If cmbPriceMode.Text = "Refund" Then
            qtyy = -1
        Else
            qtyy = 1
        End If

        'End of New Code
        Try

            For I = 0 To PosGrid.Rows.Count - 1
                If nProdID = CInt(PosGrid.Rows(I).Cells(0).Value) Then

                    ' item found
                    ItemLoc = I
                    Exit For
                End If
            Next

            ' if item is not found, add it
            If ItemLoc = -1 Then

                If qtyy = 1 Or qtyy = -1 Then
                    If cmbPriceMode.Text = "Retail" Then
                        '++This is the original COde
                        'PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.retail, qtyy, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail, 0, mgr6.DataObject.Entity.incentive)
                        '++End of Original Code
                        If vCategoryDiscount > 0 Then
                            vCategoryDiscountAmount = mgr6.DataObject.Entity.retail * vCategoryDiscount
                            vDiscountedAmount = mgr6.DataObject.Entity.retail - vCategoryDiscountAmount
                            PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail, vDiscountedAmount, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.active, mgr6.DataObject.Entity.incentive, vCellValIncent, mgr6.DataObject.Entity.vat, vCategoryDiscountAmount)

                        Else
                            PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.active, mgr6.DataObject.Entity.incentive, vCellValIncent, mgr6.DataObject.Entity.vat, 0)
                        End If



                        AddTempSales()
                        'MessageBox.Show(CStr(CBool(mgr6.DataObject.Entity.active)))
                        'MessageBox.Show(CStr(vBoo))

                        ' MessageBox.Show(CStr(mgr6.DataObject.Entity.incentive))
                        'ElseIf cmbPriceMode.Text = "Whooesale" Then
                        'PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.retail2, qtyy, mgr6.DataObject.Entity.retail2, mgr6.DataObject.Entity.retail2, 0, mgr6.DataObject.Entity.incentive)
                    End If

                    If cmbPriceMode.Text = "Wholesale" Then
                        '++This is the original COde
                        'PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.retail, qtyy, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail, 0, mgr6.DataObject.Entity.incentive)
                        '++End of Original Code
                        If vCategoryDiscount > 0 Then
                            vCategoryDiscountAmount = mgr6.DataObject.Entity.retail2 * vCategoryDiscount
                            vDiscountedAmount = mgr6.DataObject.Entity.retail2 - vCategoryDiscountAmount
                            PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail2, vDiscountedAmount, mgr6.DataObject.Entity.retail2, 0, mgr6.DataObject.Entity.active, vCellValIncent, mgr6.DataObject.Entity.vat, vCategoryDiscountAmount)
                        Else
                            PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail2, mgr6.DataObject.Entity.retail2, mgr6.DataObject.Entity.retail2, 0, mgr6.DataObject.Entity.active, vCellValIncent, mgr6.DataObject.Entity.vat, 0)
                            ' MessageBox.Show(CStr(mgr6.DataObject.Entity.incentive))
                            'ElseIf cmbPriceMode.Text = "Whooesale" Then
                            'PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.retail2, qtyy, mgr6.DataObject.Entity.retail2, mgr6.DataObject.Entity.retail2, 0, mgr6.DataObject.Entity.incentive)
                        End If
                    End If



                    'New Code
                    If cmbPriceMode.Text = "Refund" Then
                        If vCategoryDiscount > 0 Then
                            vCategoryDiscountAmount = mgr6.DataObject.Entity.retail * vCategoryDiscount
                            vDiscountedAmount = mgr6.DataObject.Entity.retail - vCategoryDiscountAmount
                            PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail, ((mgr6.DataObject.Entity.retail * qtyy) - vCategoryDiscountAmount), mgr6.DataObject.Entity.retail, 0, mgr6.DataObject.Entity.active, vCellValIncent, mgr6.DataObject.Entity.vat, vCategoryDiscountAmount)
                        Else
                            PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail * qtyy, mgr6.DataObject.Entity.retail, 0, mgr6.DataObject.Entity.active, vCellValIncent, mgr6.DataObject.Entity.vat, 0)
                        End If

                        'cmbPriceMode.Text = "Retail"
                    End If
                    'end of new code


                Else
                    If cmbPriceMode.Text = "Retail" Then
                        If vCategoryDiscount > 0 Then
                            PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail * qtyy, mgr6.DataObject.Entity.retail, 0, mgr6.DataObject.Entity.active, vCellValIncent, mgr6.DataObject.Entity.vat, 0)
                        Else
                            PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail * qtyy, mgr6.DataObject.Entity.retail, 0, mgr6.DataObject.Entity.active, vCellValIncent, mgr6.DataObject.Entity.vat, 0)
                        End If
                    End If

                    If cmbPriceMode.Text = "Wholesale" Then
                        PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail2, mgr6.DataObject.Entity.retail2 * qtyy, mgr6.DataObject.Entity.retail2, 0, mgr6.DataObject.Entity.active, vCellValIncent, mgr6.DataObject.Entity.vat)
                    End If

                    If cmbPriceMode.Text = "Refund" Then
                        PosGrid.Rows.Add(mgr6.DataObject.Entity.stckid, mgr6.DataObject.Entity.barcode, qtyy, mgr6.DataObject.Entity.cost, mgr6.DataObject.Entity.itemdesc, mgr6.DataObject.Entity.retail, mgr6.DataObject.Entity.retail * qtyy, mgr6.DataObject.Entity.retail * qtyy, 0, mgr6.DataObject.Entity.active, vCellValIncent, mgr6.DataObject.Entity.vat)
                    End If
                End If
            Else
                NewPrice = 0
                If cmbPriceMode.Text = "Retail" Then
                    ' if item is already there increase its count
                    'Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(5).Value)
                    Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(2).Value)
                    ItemCount += CInt(ceQtyy.Value)
                    'New Code May 22, 2024
                    If vCategoryDiscount > 0 Then
                        vCategoryDiscountAmount = (mgr6.DataObject.Entity.retail * ItemCount) * vCategoryDiscount
                        vDiscountedAmount = (mgr6.DataObject.Entity.retail * ItemCount) - vCategoryDiscountAmount
                        NewPrice = vDiscountedAmount
                        PosGrid.Rows(ItemLoc).Cells(6).Value = NewPrice
                        PosGrid.Rows(ItemLoc).Cells(12).Value = vCategoryDiscountAmount
                    Else
                        NewPrice = mgr6.DataObject.Entity.retail * ItemCount
                        PosGrid.Rows(ItemLoc).Cells(6).Value = NewPrice
                        PosGrid.Rows(ItemLoc).Cells(12).Value = 0
                    End If
                    'End of New Code

                    Dim NewIncentv As Decimal = mgr6.DataObject.Entity.incentive * ItemCount
                    PosGrid.Rows(ItemLoc).Cells(5).Value = mgr6.DataObject.Entity.retail
                    PosGrid.Rows(ItemLoc).Cells(2).Value = ItemCount


                    'PosGrid.Rows(ItemLoc).Cells(9).Value = NewIncentv
                    UpdateSalesTempQty()
                ElseIf cmbPriceMode.Text = "Wholesale" Then
                    ' if item is already there increase its count
                    Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(2).Value)
                    ItemCount += 1
                    If vCategoryDiscount > 0 Then
                        vCategoryDiscountAmount = (mgr6.DataObject.Entity.retail2 * ItemCount) * vCategoryDiscount
                        vDiscountedAmount = (mgr6.DataObject.Entity.retail2 * ItemCount) - vCategoryDiscountAmount
                        NewPrice = vDiscountedAmount
                        PosGrid.Rows(ItemLoc).Cells(6).Value = NewPrice
                        PosGrid.Rows(ItemLoc).Cells(12).Value = vCategoryDiscountAmount
                    Else
                        'Dim NewPrice As Decimal = mgr.DataObject.Entity.retail2 * ItemCount
                        NewPrice = mgr.DataObject.Entity.retail2 * ItemCount
                        PosGrid.Rows(ItemLoc).Cells(6).Value = NewPrice
                        PosGrid.Rows(ItemLoc).Cells(12).Value = 0
                    End If


                    PosGrid.Rows(ItemLoc).Cells(2).Value = ItemCount
                    PosGrid.Rows(ItemLoc).Cells(5).Value = mgr.DataObject.Entity.retail2

                Else
                    ' if item is already there increase its count
                    'Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(5).Value)
                    Dim ItemCount As Integer = CInt(PosGrid.Rows(ItemLoc).Cells(2).Value)
                    ItemCount += -1 'CInt(ceQtyy.Value)

                    If vCategoryDiscount > 0 Then
                        vCategoryDiscountAmount = (mgr6.DataObject.Entity.retail * ItemCount) * vCategoryDiscount
                        vDiscountedAmount = (mgr6.DataObject.Entity.retail * ItemCount) - vCategoryDiscountAmount
                        NewPrice = vDiscountedAmount
                        PosGrid.Rows(ItemLoc).Cells(6).Value = NewPrice
                        PosGrid.Rows(ItemLoc).Cells(12).Value = vCategoryDiscountAmount
                    Else
                        Dim NewPrice As Decimal = mgr6.DataObject.Entity.retail * ItemCount
                        PosGrid.Rows(ItemLoc).Cells(6).Value = NewPrice
                        PosGrid.Rows(ItemLoc).Cells(12).Value = 0
                    End If

                    Dim NewIncentvv As Decimal = mgr6.DataObject.Entity.incentive * ItemCount
                    'PosGrid.Rows(ItemLoc).Cells(5).Value = ItemCount
                    PosGrid.Rows(ItemLoc).Cells(2).Value = ItemCount
                    PosGrid.Rows(ItemLoc).Cells(9).Value = NewIncentvv
                End If

            End If
            ' compute the total for the recipt
            Tots = 0
            For I = 0 To PosGrid.Rows.Count - 1
                'MessageBox.Show(CStr(PosGrid.Rows.Count))
                Tots += CDec(PosGrid.Rows(I).Cells(6).Value)
            Next
            txtCounts.Text = CStr(PosGrid.Rows.Count)
            'Scroll to the last row.
            Me.PosGrid.FirstDisplayedScrollingRowIndex = Me.PosGrid.RowCount - 1

            'Select the last row.
            Me.PosGrid.Rows(Me.PosGrid.RowCount - 1).Selected = True

            'CalcEdit1.Value = Tots
            txtCounts.Text = CStr(PosGrid.Rows.Count)
            txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots))

            CheckSumifNegative()
            'New Code 02/21/2014
            vpTotalSales = Tots
            'End of New Code 02/21/2014

            'TextEdit1.Text = FormatCurrency(CStr(Tots))
            qtyy = 1
            vpieces = 1

            If CInt(PosGrid.SelectedRows.Item(0).Cells(2).Value) <= 0 Then
                PosGrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Red
            Else
                PosGrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Black
            End If

            'If CDec(PosGrid.SelectedRows.Item(0).Cells(5).Value) <= 0 Then
            If CDec(PosGrid.SelectedRows.Item(0).Cells(5).Value) <= 0 Then
                PosGrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Red
            Else
                PosGrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Black
            End If



            txtitem.Text = String.Empty
            txtBarcode.Text = String.Empty
            ceQtyy.Value = 1
            vDiscountedAmount = 0
            vCategoryDiscount = 0
            vCategoryDiscountAmount = 0
            NewPrice = 0

            txtCounts.Text = CStr(PosGrid.Rows.Count)
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub txtitem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtitem.KeyDown

        If e.KeyCode = Keys.Enter Then

            'SearchBarcodeOnItem()
            'DgitemsKeydown()
            Exit Sub
        End If


        If e.KeyCode = Keys.Left Then
            txtBarcode.Text = String.Empty
            txtitem.Text = String.Empty
            txtBarcode.Focus()
            Exit Sub
        End If

        If e.KeyCode = Keys.F10 Then
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If
            Dim ansint As Integer = 7
            ansint = MsgBox("Make Sure your printer is turned on and with enough paper loaded.", MsgBoxStyle.YesNo, "Check Printer.")
            If ansint = 7 Then
                Exit Sub
            End If

            Unhook()


            'Dim posrepsales As New xrSalesEndDay()
            'posrepsales.RequestParameters = False
            'posrepsales.Parameter1.Value = PDSAAppConfig.CurrentLoginID
            'posrepsales.PrintingSystem.ShowMarginsWarning = False
            'posrepsales.Print()


            'Dim strFindCredits As String = "SELECT mowd FROM vwSalesbyCatToday WHERE mowd='CREDIT'"
            'ExecuteSQLQuery(strFindCredits)
            'If sqlDT.Rows.Count > 0 Then
            '    Dim posCredit As New xrCreditsToday()
            '    posCredit.RequestParameters = False
            '    posCredit.PrintingSystem.ShowMarginsWarning = False
            '    posCredit.Print()
            'End If

            'Dim strFindGetCash As String = "SELECT posdate FROM petty_cash WHERE posdate='" & Date.Today & "'"
            'ExecuteSQLQuery(strFindGetCash)
            'If sqlDT.Rows.Count > 0 Then
            '    Dim posGC As New xrPettyCash()
            '    posGC.RequestParameters = False
            '    posGC.PrintingSystem.ShowMarginsWarning = False
            '    posGC.Print()
            'End If

            'Dim strFindAC As String = "SELECT posdate FROM additnlcash WHERE posdate='" & Date.Today & "'"
            'ExecuteSQLQuery(strFindAC)
            'If sqlDT.Rows.Count > 0 Then
            '    Dim posAC As New xrAdditionalCash()
            '    posAC.RequestParameters = False
            '    posAC.PrintingSystem.ShowMarginsWarning = False
            '    posAC.Print()
            'End If


            'If btnSaves.Enabled = True And PosGrid.Rows.Count >= 1 Then
            '    MessageBox.Show("Please Complete a Pending Sales Transaction First")
            '    Exit Sub
            'End If
            txtBarcode.Enabled = False
            btnBcode.Enabled = False
            btnSearchItems.Enabled = False
            btnPriceMode.Enabled = False
            btnType.Enabled = False
            btnSaves.Enabled = False
            btnSuspend.Enabled = False
            btnRetrieve.Enabled = False
            btnRemove.Enabled = False
            btnCreditPay.Enabled = False
            btnChequePayment.Enabled = False
            btnnew.Enabled = False
            btnLookuprice.Enabled = False
            btnPickup.Enabled = False
            btnAddCash.Enabled = False
            btnDiscount.Enabled = False
            Button1.Enabled = False
            btnCustomers.Enabled = False
            PosGrid.Enabled = False

            Dim frmread As New frmReading
            frmread.ShowDialog()
            frmread = Nothing
            Me.Close()
            Exit Sub
        End If

        If e.KeyCode = Keys.F12 Then
            Dim vYesNo As Boolean = True
            Dim grdcountt As Integer = 0
            Dim iiiay As Integer = 0
            Dim I As Integer = 0
            Dim iCounter As Integer = 0
            Dim iiCounter As Integer = 0
            Dim vboolVAT As Integer
            'Dim TripleICounter As Integer = 0
            'Dim vvBoolean As Boolean
            ''New Code to determine if the stocks is vatabale or non vatable
            'For TripleICounter = 0 To PosGrid.Rows.Count - 1
            '    Dim strFindVatable As String = String.Format("Select vat From stocks where stckid={0}", PosGrid.Rows(TripleICounter).Cells(0).Value)
            '    ExecuteSQLQuery(strFindVatable)
            '    If sqlDT.Rows.Count > 0 Then
            '        vvBoolean = CBool(sqlDT.Rows(0)("vat"))
            '        PosGrid.Rows(TripleICounter).Cells(11).Value = vvBoolean
            '    End If
            'Next

            ' compute the total for the recipt
            Tots = 0
            For I = 0 To PosGrid.Rows.Count - 1
                'MessageBox.Show(CStr(PosGrid.Rows.Count))
                Tots += CDec(PosGrid.Rows(I).Cells(6).Value)
            Next
            txtCounts.Text = CStr(PosGrid.Rows.Count)
            txtCounts.Text = CStr(PosGrid.Rows.Count)
            '+I commented this 2 lines of code below-Uncommne tif anything goes wrong
            'txtSum.Text = FormatNumber(Tots, 2, , TriState.False, TriState.False) 'FormatNumber(CStr(Tots))
            'vpTotalSales = Tots
            '+End of Comment Above

            'Vatable = 0
            'NonVatable = 0
            'For iCounter = 0 To PosGrid.Rows.Count - 1
            '    ''MessageBox.Show(CStr(PosGrid.Rows.Count))
            '    'vboolVAT = CBool(PosGrid.Rows(iCounter).Cells(9).Value)
            '    vboolVAT = CInt(PosGrid.Rows(iCounter).Cells(11).Value)
            '    If vboolVAT = 1 Then
            '        Vatable += CDec(PosGrid.Rows(iCounter).Cells(6).Value)
            '    End If

            'Next

            'iiCounter = 0
            'For iiCounter = 0 To PosGrid.Rows.Count - 1
            '    ''MessageBox.Show(CStr(PosGrid.Rows.Count))
            '    'vboolVAT = CBool(PosGrid.Rows(iiCounter).Cells(9).Value)
            '    vboolVAT = CInt(PosGrid.Rows(iCounter).Cells(11).Value)
            '    If vboolVAT = 0 Then
            '        NonVatable += CDec(PosGrid.Rows(iiCounter).Cells(6).Value)
            '    End If

            'Next
            Vatable = 0
            NonVatable = 0
            For iCounter = 0 To PosGrid.Rows.Count - 1
                vboolVAT = CInt(PosGrid.Rows(iCounter).Cells(11).Value)
                If vboolVAT = 1 Then
                    Vatable += CDec(PosGrid.Rows(iCounter).Cells(6).Value)
                End If
            Next
            iiCounter = 0
            For iiCounter = 0 To PosGrid.Rows.Count - 1
                ''MessageBox.Show(CStr(PosGrid.Rows.Count))
                'vboolVAT = CBool(PosGrid.Rows(iiCounter).Cells(9).Value)
                vboolVAT = CInt(PosGrid.Rows(iiCounter).Cells(11).Value)
                If vboolVAT = 0 Then
                    NonVatable += CDec(PosGrid.Rows(iiCounter).Cells(6).Value)
                End If

            Next

            grdcountt = PosGrid.Rows.Count
            Try
                If cmbPaymentType.Text = "CREDIT" And txtcustid.Text = "1" Then
                    MessageBox.Show("Change the payment type to CASH before collecting the payment or change a customer name because it is currently not charge to any customer")
                    Exit Sub
                End If

                For iiiay = 0 To grdcountt - 1
                    If CDec(PosGrid.Rows(iiiay).Cells(5).Value) <= 0 Then

                        ' Zero Price found
                        MessageBox.Show("There is an Item with a Price that is Not valid or less than 0.1")
                        vYesNo = False
                        'Exit For
                        Exit Sub
                    End If

                    'If CInt(PosGrid.Rows(iiiay).Cells(2).Value) <= 0 Then

                    '' Zero Qty found
                    'MessageBox.Show("There is an Item with a Qty that is Not valid or equal to 0")
                    'vYesNo = False
                    ''Exit For
                    'Exit Sub
                    'End If

                    'If CDec(PosGrid.Rows(iiiay).Cells(6).Value) <= 0 Then

                    '' Zero Qty found
                    'MessageBox.Show("There is an Item with an Amount that is Not valid or equal to 0")
                    'vYesNo = False
                    ''Exit For
                    'Exit Sub
                    'End If

                Next


                If CDec(txtSum.Text) < 0 Then
                    txtSum.Text = FormatNumber(Tots, 2, , TriState.False, TriState.False)
                End If

                ''Try to check if there is a price that is not valid(less than or equal to zero and letters maybe)
                'Dim IIII As Integer = 0
                'For IIII = 0 To PosGrid.Rows.Count - 1
                '    Dim number As Decimal
                '    Dim result As Boolean = Decimal.TryParse(CStr(CDec(PosGrid.Rows(IIII).Cells(4).Value)), number)
                '    If CDec(CStr(PosGrid.Rows(IIII).Cells(4).Value)) <= 0 Then
                '        MessageBox.Show("W A R N I N G !!!!!! Price Must be Greater than Zero")
                '        Exit Sub
                '    End If
                '    If result Then
                '        ' Console.WriteLine("Converted '{0}' to {1}.", PosGrid.Rows(IIII).Cells(4).Value, number)
                '    Else
                '        If PosGrid.Rows(IIII).Cells(4).Value Is Nothing Then PosGrid.Rows(IIII).Cells(4).Value = ""
                '        MessageBox.Show("W A R N I N G !!!!!! Price Must be Greater than Zero")
                '        MessageBox.Show(CStr(PosGrid.Rows(IIII).Cells(4).Value))
                '        Exit Sub
                '        Exit For
                '    End If

                'Next

                'IF no problem them take payment


                If vYesNo = False Then
                    Exit Sub
                End If
                If btnSaves.Enabled = False Then
                    Exit Sub
                End If
                TakePayment()


                'If PosGrid.Rows.Count >= 1 Then
                '    If txtTendered.Text = "0" Then
                '        MessageBox.Show("Sales Transaction is not yet paid!")
                '        btnSave.Focus()
                '        Exit Sub
                '    End If

                'End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If

        If e.KeyCode = Keys.ShiftKey Then
            'ContextMenuStrip1.Show()
        End If

        If e.KeyCode = Keys.S AndAlso e.Control = True Then
            Dim frm As frmSalestoday
            frm = New frmSalestoday
            frm.Show()
            frm = Nothing
            Exit Sub
        End If

        If e.KeyCode = Keys.H AndAlso e.Control = True Then
            Dim frm As frmHelp
            frm = New frmHelp
            frm.Show()
            frm = Nothing
            Exit Sub
        End If

        If e.KeyCode = Keys.P AndAlso e.Control = True Then
            Try
                passcorrect = False
                If PosGrid.Rows.Count >= 1 Then
                    vPriceChange = CDec(PosGrid.SelectedRows(0).Cells(5).Value)
                    Dim formChangePrice As New frmNewPrice
                    formChangePrice.ShowDialog()
                    'If vPricingMode = "Refund" Then
                    '    vpieces = vpieces * -1
                    'End If

                    'this is the original Code below
                    'PosGrid.Rows(PosGrid.RowCount - 1).Cells(2).Value = vpieces
                    'this is the original Code above

                    PosGrid.SelectedRows(0).Cells(5).Value = vPriceChange
                    'PosGrid.Rows.Remove(PosGrid.SelectedRows(0))

                    ''Me.PosGrid.Rows(Me.PosGrid.RowCount - 1).Selected = True
                    txtitem.Text = String.Empty
                    'txtitem.Focus()


                    'Newly added code to re compute the totals
                    Dim IAyI As Integer = 0
                    Tots = 0
                    For IAyI = 0 To PosGrid.Rows.Count - 1
                        Tots += CDec(PosGrid.Rows(IAyI).Cells(6).Value)
                    Next

                    txtCounts.Text = CStr(PosGrid.Rows.Count)

                    'Scroll to the last row.
                    Me.PosGrid.FirstDisplayedScrollingRowIndex = Me.PosGrid.RowCount - 1

                    'Select the last row.
                    Me.PosGrid.Rows(Me.PosGrid.RowCount - 1).Selected = True

                    'CalcEdit1.Value = Tots
                    txtCounts.Text = CStr(PosGrid.Rows.Count)
                    txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots))
                    CheckSumifNegative()
                    vpTotalSales = Tots
                    'TextEdit1.Text = FormatCurrency(CStr(Tots))
                    qtyy = 1
                    vpieces = 1
                    'End of newly added code


                    If vBarcodeOrItemSearch = True Then
                        txtBarcode.Text = String.Empty
                        txtBarcode.Focus()
                    Else
                        txtitem.Text = String.Empty
                        txtitem.Focus()
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If

        If e.KeyCode = Keys.D AndAlso e.Control = True Then
            '++This is the Original Code
            'Dim TotsBeforeDisc As Decimal = 0
            'Tots = 0
            'SeniorDiscount = 0
            'vdiscamnt = 0
            'Dim i As Integer = 0
            'For i = 0 To PosGrid.Rows.Count - 1
            '    Tots += CDec(PosGrid.Rows(i).Cells(6).Value)
            'Next
            '' txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) 'FormatNumber(CStr


            'txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True)
            'TotsBeforeDisc = CDec(CDec(Tots / 1.12) * 0.8)
            'SeniorDiscount = CDec(CDec(Tots / 1.12) * 0.2)
            'vdiscamnt = Tots - TotsBeforeDisc
            'txtSum.Text = FormatNumber(TotsBeforeDisc, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots22))
            'If vBarcodeOrItemSearch = True Then
            '    txtBarcode.Text = String.Empty
            '    txtBarcode.Focus()
            'Else
            '    txtitem.Text = String.Empty
            '    txtitem.Focus()
            'End If
            'Exit Sub
            '++End of Original Code Comment
            'passcorrect = False
            'Dim frm As frmPasswordInput
            'frm = New frmPasswordInput
            ''frm.MdiParent = Me
            'frm.WindowState = FormWindowState.Normal
            'frm.ShowDialog()
            'frm = Nothing
            'If passcorrect = False Then
            '    Exit Sub
            'End If

            'ceWtid.Value = vEmpID
            passcorrect = True
            If passcorrect = True Then

                Dim vdetdisc As Decimal = 0 ' this is the discount computed per item that was divided from the vdiscamnt variable to the total itemcount which is vItemCount
                Dim ayayay As Integer = 0
                For ayayay = 0 To PosGrid.Rows.Count - 1
                    PosGrid.Rows(ayayay).Cells(8).Value = 0
                Next

                If btnSaves.Enabled = False Then
                    MessageBox.Show("Discount is not allowed if Sales Transaction is already paid.")
                    Exit Sub
                End If
                If PosGrid.Rows.Count < 1 Then
                    MessageBox.Show("Item List is  B l a n k")
                    Exit Sub
                End If

                'Recalculate the total on the Grid and post it on txtsum before applying any discount
                Dim I As Integer = 0
                Tots = 0
                For I = 0 To PosGrid.Rows.Count - 1
                    Tots += CDec(PosGrid.Rows(I).Cells(6).Value)
                Next

                txtCounts.Text = CStr(PosGrid.Rows.Count)
                txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) ' FormatNumber(CStr(Tots))
                CheckSumifNegative()
                vpTotalSales = Tots



                Try
                    Dim percentamnt As Decimal = 0
                    vdisc = 0
                    vdiscamnt = 0
                    vtotalsales = Tots 'CDec(txtSum.Text) My New Comments 12 21 13
                    'vpTotalSales = CDec(txtSum.Text) My New Comments 12 21 13
                    txtCounts.Text = CStr(PosGrid.Rows.Count)
                    Dim frmdisc As New frmDiscount
                    frmdisc.ShowDialog()
                    txtSum.Text = FormatNumber(vtotalsales, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(vtotalsales))
                    CheckSumifNegative()

                    If vtotalsales = 0 Then
                        txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots))
                        CheckSumifNegative()
                        vpTotalSales = Tots
                    End If


                    Dim vItemCount As Integer = 0
                    Dim ay As Integer = 0
                    For ay = 0 To PosGrid.Rows.Count - 1
                        vItemCount += CInt(PosGrid.Rows(ay).Cells(5).Value)
                    Next

                    If vdiscamnt > 0 Then
                        vdetdisc = CDec(vdiscamnt / vItemCount)
                        Dim ayay As Integer = 0
                        For ayay = 0 To PosGrid.Rows.Count - 1
                            PosGrid.Rows(ayay).Cells(8).Value = CDec(vdetdisc * CInt(PosGrid.Rows(ayay).Cells(2).Value))
                        Next
                    End If
                    txtCounts.Text = CStr(PosGrid.Rows.Count)
                    txtSum.Text = FormatNumber(vtotalsales, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(vtotalsales))
                    CheckSumifNegative()
                    txtBarcode.Text = String.Empty
                    If vBarcodeOrItemSearch = True Then
                        txtBarcode.Text = String.Empty
                        txtBarcode.Focus()
                    Else
                        txtitem.Text = String.Empty
                        txtitem.Focus()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If


        End If

        If e.KeyCode = Keys.C AndAlso e.Control = True Then
            vStrCustName = CStr(InputBox("Enter Customer Name", "Customer Name", vStrCustName))
            If vStrCustName <> "" Then
                Dim straqlUpdateCustName As String = String.Empty
                straqlUpdateCustName = "UPDATE members SET lastname='" & vStrCustName & "'" & " WHERE CustId=1"
                ExecuteSQLQuery(straqlUpdateCustName)
                straqlUpdateCustName = String.Empty
                straqlUpdateCustName = "UPDATE members SET firstname=' ' WHERE CustId=1"
                ExecuteSQLQuery(straqlUpdateCustName)
            End If
            Exit Sub
        End If

        If e.KeyCode = Keys.Alt Then
            txtBarcode.Text = ""
        End If

        If e.KeyCode = Keys.F2 Then
            e.Handled = True
            Dim frm As New frmPriceLookup2
            frm.ShowDialog()

            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If

        End If

        If e.KeyCode = Keys.F3 Then
            e.Handled = True
            Dim frmcp As New frmCreditPayment
            frmcp.ShowDialog()
            btnnew.Focus()
        End If

        If e.KeyCode = Keys.F4 Then
            ''~~~ Calling it and passing the name of the form to be displayed
            'Dim myObj As abcLockScreen = New abcLockScreen
            'myObj.LockSystemAndShow(Form2)
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If




            vSalesNum = CInt(InputBox("Enter the sales number to be printed", "Reprint", CStr(ceRefno.Text)))
            Dim posrep As New xrReceiptTodaRaba()
            'posrep.DataSource = sqlDT
            posrep.Parameter1.Value = vSalesNum
            posrep.RequestParameters = False
            posrep.PrintingSystem.ShowMarginsWarning = False
            posrep.Print()

        End If


        If e.KeyCode = Keys.F5 Then
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If
            'If btnnew.Enabled = False Then
            If PosGrid.Rows.Count > 0 Then
                SuspendTrans()
            Else
                If vBarcodeOrItemSearch = True Then
                    txtBarcode.Text = String.Empty
                    txtBarcode.Focus()
                Else
                    txtitem.Text = String.Empty
                    txtitem.Focus()
                End If
            End If
        End If

        If e.KeyCode = Keys.F6 Then
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If
            If btnnew.Enabled = False Then
                'If PosGrid.Rows.Count > 1 Then
                'MessageBox.Show("Pls. finish the existing sales transaction before retrieving a suspended sale.")
                'xit Sub
                'Else
                Call RetrieveTrans()
                'End If
            End If
        End If

        If e.KeyCode = Keys.F7 Then
            'If btnnew.Enabled = False Then
            '    cmbPriceMode.Text = "Refund"
            '    'txtBarcode.Focus()
            '    'btnSearchItems.Focus()
            '    txtitem.Focus()
            '    txtitem.Text = String.Empty
            '    txtitem.Focus()
            'End If
        End If

        If e.KeyCode = Keys.F8 Then
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If
            'If PosGrid.Rows.Count > 1 Then
            'MessageBox.Show("Pls. finish the existing sales transaction before retrieving a suspended sale.")
            'Exit Sub
            'Else
            'Call RetrieveTrans()
            'End If
            Call RePrint()
        End If



        If e.KeyCode = Keys.F9 Then
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If

            Unhook()

            'itemcnt = 0
            'vdisc = 0
            'vdiscamnt = 0
            'vEmpID = 1
            'txtTendered.Text = "0"
            'Try

            '    txtSum.Text = "0"
            '    PosGrid.Rows.Clear()
            '    txtBarcode.Text = String.Empty
            '    txtitem.Text = String.Empty
            '    'txtTendered.Text = "0"
            '    'lblChange.Text = "0"
            '    ceWtid.Value = 1
            '    vtotalsales = 0
            '    vpTotalSales = 0
            '    txtcustid.Text = "1"
            '    txtqty.Text = "0"
            '    txtlastname.Text = "CASH"
            '    txtfirstname.Text = String.Empty
            '    btnSaves.Enabled = True
            '    btnPriceMode.Enabled = True
            '    btnType.Enabled = True
            '    btnSuspend.Enabled = True
            '    btnRetrieve.Enabled = True
            '    btnRemove.Enabled = True
            '    btnDiscount.Enabled = True
            '    Button1.Enabled = True ' this is the Set Quantity button
            '    btnCustomers.Enabled = True
            '    txtBarcode.Enabled = True
            '    btnSearchItems.Enabled = True
            '    btnReprint.Enabled = True
            '    txtbcodes.Text = String.Empty
            '    txtStckid.Text = String.Empty
            '    btnType.Enabled = True
            '    btnPriceMode.Enabled = True
            '    btnCustomers.Enabled = True
            '    btnSuspend.Enabled = True
            '    btnRetrieve.Enabled = True
            '    btnRemove.Enabled = True
            '    cmbPriceMode.Text = "Retail"
            '    cmbPaymentType.Text = "CASH"
            '    btnChequePayment.Enabled = True
            '    'GridLookUpEdit2.Enabled = True
            '    txtitem.Enabled = True

            '    btnnew.Enabled = False
            '    If vBarcodeOrItemSearch = True Then
            '        txtBarcode.Text = String.Empty
            '        txtBarcode.Focus()
            '    Else
            '        txtitem.Text = String.Empty
            '        txtitem.Focus()
            '    End If

            'Catch ex As Exception
            '    MessageBox.Show(ex.ToString())
            'End Try
        End If




        If e.Alt = True And e.KeyCode = Keys.Tab Then
            e.Handled = True
        End If

        If e.Alt = True And e.KeyCode = Keys.P Then
            PriceOverride()
            e.Handled = True
        End If


        If e.Alt = True And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
        'If e.KeyCode = Keys.Left Then
        'txtitem.Focus
        '    txtitem.Text = ""
        'End If

        If e.KeyCode = Keys.Down Then
            If dgitems.Visible = True Then
                dgitems.Focus()
            Else
                If PosGrid.Rows.Count > 1 Then
                    PosGrid.Focus()
                End If
            End If

        End If
        If e.KeyCode = Keys.F1 Then
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If
            SetQuantity()
            e.Handled = True
        End If

        If e.KeyCode = Keys.Escape Then

            dgitems.Visible = False
            'txtitem.Focus()
            'txtitem.SelectAll()
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
            e.SuppressKeyPress = True
        End If


    End Sub

    Private Sub txtitem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtitem.KeyPress
        'If e.KeyChar = Chr(13) Then
        '    'LookupEditKeypress()
        '    ceQtyy.Focus()
        'End If


        If e.KeyChar = Chr(27) Then
            ' If dgitems.Rows.Count > 0 Then
            'DgitemsKeydown()
            dgitems.Visible = False
            'Else

            'End If

        End If



        'If e.KeyChar = Chr(13) Then
        '    '    'LookupEditKeypress()
        '    '    ceQtyy.Focus()
        '    SearchBarcodeOnItem()
        'End If
        'If e.KeyChar = Chr(13) Then
        '    If dgitems.Rows.Count < 1 Then
        '        Exit Sub
        '    End If
        '    Try
        '        Dim vRow As Integer = 0
        '        Dim vint As Integer = 0
        '        Dim x1 As String = String.Empty
        '        Dim x2 As String = String.Empty
        '        ' Dim x2 As Integer = 0
        '        Dim x3 As Integer = 0
        '        Dim x4 As Decimal = 0
        '        Dim x5 As Integer = 0
        '        Dim x6 As String = String.Empty
        '        vRow = 0 'dgitems.CurrentRow.Index
        '        'vint = CInt(dgitems(0, vRow).Value)
        '        'x1 = CStr(dgitems(1, vRow).Value)
        '        'x2 = CStr(dgitems(2, vRow).Value)
        '        'x3 = CDec(dgitems(12, vRow).Value)
        '        'x4 = CDec(dgitems(13, vRow).Value)
        '        vint = CInt(dgitems(0, vRow).Value)
        '        x1 = CStr(dgitems(1, vRow).Value)
        '        x2 = CStr(dgitems(2, vRow).Value)
        '        x3 = CInt(dgitems(3, vRow).Value)
        '        x4 = CDec(dgitems(4, vRow).Value)
        '        x5 = CInt(dgitems(6, vRow).Value)
        '        'x6 = CStr(dgitems(7, vRow).Value)
        '        vStckid = vint
        '        vItem = x2
        '        vAvlbl = x3
        '        vbocde = x1
        '        vPrice = x3
        '        vWPrice = x4
        '        vInnerQty = x5

        '        txtbcodes.Text = String.Empty
        '        txtStckid.Text = String.Empty
        '        txtitem.Text = vItem.ToString
        '        txtbcodes.Text = vbocde.ToString
        '        txtBarcode.Text = vbocde.ToString
        '        txtStckid.Text = vStckid.ToString
        '        ''txtBarcode.SelectAll()
        '        'If txtStckid.Text = String.Empty Then
        '        '    Exit Sub
        '        'Else
        '        '    ItemsearchExecute()
        '        'End If
        '        'txtitem.Focus()


        '        'ceQtyy.Focus()
        '        dgitems.Visible = False
        '        Call SendItemImmediately()


        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString)
        '    End Try
        '    'e.SuppressKeyPress = True
        'End If
    End Sub

    Private Sub txtitem_KeyUp(sender As Object, e As KeyEventArgs) Handles txtitem.KeyUp
        If e.KeyCode = Keys.Down Then
            If dgitems.Visible = True Then
                dgitems.Focus()
            Else
                If PosGrid.Rows.Count > 1 Then
                    PosGrid.Focus()
                End If
            End If
        End If
        If e.Alt = True And e.KeyCode = Keys.Tab Then
            e.Handled = True
        End If

        If e.Alt = True And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
    End Sub
    'Private Sub DisplayException(ByVal ex As Exception)
    '    tbException.Text = ex.ToString()

    '    MessageBox.Show("Exception Occurred. Check the Exception Tab for More Info.")
    'End Sub
    Private Sub txtItem_TextChanged(sender As Object, e As System.EventArgs) Handles txtitem.TextChanged
        'If txtItem.Text.Trim = String.Empty Then
        '    DGSearch.DataSource = ""
        '    DGSearch.Visible = False
        'End If

        'Dim i, j As Integer
        'i = 0
        'If String.IsNullOrEmpty(txtItem.Text) Then
        '    DGSearch.DataSource = ""
        '    DGSearch.Visible = False
        'End If

        'If Not String.IsNullOrEmpty(txtItem.Text) Then
        '    Try
        '        mgr3 = New stocksManager()
        '        Dim entity As stocks = New stocks

        '        mgr3.DataObject.WhereFilter = stocksData.WhereFilters.Likeitem
        '        mgr3.Entity.item = txtItem.Text.Trim()
        '        mgr3.DataObject.SelectFilter = stocksData.SelectFilters.GridBox
        '        col1 = mgr3.BuildCollection
        '        tbSQL.Text = mgr3.DataObject.SQL

        '        If mgr3.DataObject.RowsAffected > 0 Then
        '            j = mgr3.DataObject.RowsAffected
        '        End If

        '        For i = 0 To (j - 1)
        '            'lstgroups.Items.Add(mgr2.DataObject.DataSetObject.Tables(0).Rows(I)(0)) ' .Tables(0).Rows(i)(0))
        '            'DGSearch.Rows.Add(mgr3.DataObject.Entity.stckid, mgr3.DataObject.Entity.barcode, mgr3.DataObject.Entity.item)
        '            MsgBox(mgr3.DataObject.DataSetObject.Tables(0).Rows(i)(0))
        '            MsgBox(mgr3.DataObject.DataSetObject.Tables(0).Rows(i)(1))
        '            MsgBox(mgr3.DataObject.DataSetObject.Tables(0).Rows(i)(2))
        '            DGSearch.Rows.Add(mgr3.DataObject.DataSetObject.Tables(0).Rows(i)(0), mgr3.DataObject.DataSetObject.Tables(0).Rows(i)(1), mgr3.DataObject.DataSetObject.Tables(0).Rows(i)(2))
        '        Next

        '        'nProdID = mgr3.DataObject.Entity.stckid
        '        'cItem = mgr3.DataObject.Entity.item
        '        DGSearch.Top = (txtItem.Top + txtItem.Height)
        '        DGSearch.Left = txtItem.Left
        '        DGSearch.Visible = True
        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString())
        '    End Try

        'End If
        If txtitem.Text = String.Empty Then
            'MessageBox.Show("Enter an item description to seaarch.")
            'txtitem.Focus()
            dgitems.Visible = False
            Exit Sub
        Else

            Dim mgrloaditem As vwStocksManager
            Dim cols As vwStocksCollection

            Try

                mgrloaditem = New vwStocksManager()
                mgrloaditem.DataObject.SelectFilter = vwStocksData.SelectFilters.All
                mgrloaditem.DataObject.WhereFilter = vwStocksData.WhereFilters.likeitem
                mgrloaditem.Entity.itemdesc = Trim(txtitem.Text)
                mgrloaditem.DataObject.OrderByFilter = vwStocksData.OrderByFilters.itemdescript
                cols = mgrloaditem.BuildCollection()
                If mgrloaditem.DataObject.RowsAffected > 0 Then

                    dgitems.DataSource = mgrloaditem.DataObject.GetDataTable()
                    dgitems.Visible = True
                    dgitems.Columns(0).Visible = False
                    dgitems.Columns(1).Visible = False
                    dgitems.Columns(4).Visible = False
                    dgitems.Columns(6).Visible = False
                    dgitems.Columns(7).Visible = False
                    dgitems.Columns(2).Width = 500
                    dgitems.Columns(2).HeaderText = "Item Description"
                    dgitems.Columns(3).HeaderText = "Available"
                    dgitems.Columns(5).HeaderText = "Retail Price"
                    dgitems.Columns(6).HeaderText = "Whole Sale"
                    dgitems.Columns(7).HeaderText = "Packaging"
                    'dgitems.Columns(7).HeaderText = "Barcode"
                    dgitems.Columns(3).Width = 150
                    dgitems.Columns(5).Width = 150
                    'dgitems.Columns(8).Visible = False
                    'dgitems.Columns(9).Visible = False
                    'dgitems.Columns(10).Visible = False
                    With dgitems.ColumnHeadersDefaultCellStyle
                        .BackColor = Color.Navy
                        .ForeColor = Color.White
                        .Font = New Font("Tahoma", 12.0F, FontStyle.Regular)
                    End With

                    With Me.dgitems
                        .RowTemplate.Height = 26
                        .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular)
                        .RowsDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular)
                        .Columns("item_desc").DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular)
                        .Columns("retail").DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular)
                        .Columns("available").DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular)

                        .Columns("retail").DefaultCellStyle.Format = "c"
                        .Columns("retail2").DefaultCellStyle.Format = "c"
                        .Columns("retail").DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleRight
                        .Columns("retail2").DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleRight
                        .Columns("Available").DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleRight
                        ' ''.DefaultCellStyle.NullValue = "no entry"
                        ''.Columns("Packaging").DefaultCellStyle.Alignment = _
                        ''DataGridViewContentAlignment.MiddleRight()
                        '.DefaultCellStyle.WrapMode = DataGridViewTriState.False
                        '.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        '.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                    End With
                    'txtfilter.Enabled = True
                    'btnFilter.Enabled = True
                    'dgitems.Focus()
                Else

                    'MessageBox.Show("No item(s) related to the search criteria!")
                    'txtitem.Focus()
                    'txtBarcode.Focus()
                    'txtitem.SelectAll()
                End If

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If




    End Sub


    Private Sub PosGrid_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles PosGrid.CellBeginEdit
        'Dim msg As String = _
        'String.Format("Editing Cell at ({0}, {1})", _
        'e.ColumnIndex, e.RowIndex)
        'Me.Text = msg
        'origprice = CDec(PosGrid.SelectedRows.Item(0).Cells(4).Value)
    End Sub

    Private Sub PosGrid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles PosGrid.CellEndEdit
        'Dim mgrcp As tblChangedPriceManager
        'Dim dgvrowints As Integer = 0
        'Dim msgtran As PDSATransaction = New PDSATransaction()
        'String.Format("Finished Editing Cell at ({0}, {1})", _
        'e.ColumnIndex, e.RowIndex)
        'Me.Text = msg
        ' NuPrice = CDec(PosGrid.SelectedRows.Item(0).Cells(4).Value)

        'If origprice <> NuPrice Then


        '    'TryToParse(CStr(PosGrid.SelectedRows.Item(0).Cells(4).Value))


        '    Try
        '        mgrcp = New tblChangedPriceManager()

        '        dgvrowints = Convert.ToInt32(PosGrid.CurrentRow.Index.ToString)
        '        'save selected item that is removed
        '        mgrcp.Entity.stckid = Convert.ToInt32(PosGrid.Rows(ii).Cells(0).Value)
        '        mgrcp.Entity.cpdate = DateAndTime.Now()
        '        mgrcp.Entity.oldprice = origprice
        '        mgrcp.Entity.newprice = NuPrice
        '        mgrcp.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
        '        msgtran.Add(mgrcp.DataObject)
        '        msgtran.Execute()
        '        '    Dim NewTot As Decimal = 0
        '        '    Dim iii As Integer = 0
        '        '    Dim ItemCnt1 As Integer = 0
        '        '    Dim NewPrices As Decimal = 0
        '        '    NewTot = 0
        '        '    iii = 0
        '        '    'ItemCnt = PosGrid.Rows(CInt(PosGrid.SelectedRows(0).Cells(5).Value)) Then
        '        '    ItemCnt1 = CInt(PosGrid.SelectedRows.Item(0).Cells(5).Value)
        '        '    'ItemCnt = ItemCnt + 1
        '        '    PosGrid.SelectedRows.Item(0).Cells(5).Value = ItemCnt1
        '        '    Dim NewPrice As Decimal = CDec(PosGrid.SelectedRows.Item(0).Cells(4).Value) * ItemCnt1
        '        '    PosGrid.SelectedRows.Item(0).Cells(6).Value = NewPrices

        '        '    'Recompute the total
        '        '    For iii = 0 To PosGrid.Rows.Count - 1
        '        '        NewTot += CDec(PosGrid.Rows(iii).Cells(6).Value)
        '        '    Next
        '        '    'CalcEdit1.Value = Totsss
        '        '    txtSum.Text = FormatNumber(CStr(NewTot))
        '        '    vpTotalSales = NewTot
        '        '    'TextEdit1.Text = FormatCurrency(CStr(Totsss))

        '    Catch ex As PDSAValidationException
        '        MessageBox.Show(ex.Message)
        '    Catch ex As Exception
        '        MessageBox.Show(ex.ToString())
        '    End Try
        'End If
    End Sub
    Public Sub PosGrid_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles PosGrid.KeyDown
        If e.Alt = True And e.KeyCode = Keys.P Then
            PriceOverride()
            e.Handled = True
            Exit Sub
        End If
        ' Dim ItemCnt As Integer
        '' Dim ItemLocc As String
        'Dim Totsss As Decimal
        'Dim iii As Integer
        Try

            ''uSer pressed the add key to add more qty incremented by 1
            'If e.KeyCode = Keys.Add Then
            '    Totsss = 0
            '    iii = 0
            '    If cmbPriceMode.Text = "Refund" Then
            '        ItemCnt = CInt(PosGrid.SelectedRows.Item(0).Cells(2).Value)
            '        ItemCnt = ItemCnt - 1
            '        PosGrid.SelectedRows.Item(0).Cells(2).Value = ItemCnt
            '        Dim NewPrice2 As Decimal = CDec(PosGrid.SelectedRows.Item(0).Cells(5).Value) * ItemCnt
            '        PosGrid.SelectedRows.Item(0).Cells(6).Value = NewPrice2
            '    Else
            '        'ItemCnt = PosGrid.Rows(CInt(PosGrid.SelectedRows(0).Cells(5).Value)) Then
            '        ItemCnt = CInt(PosGrid.SelectedRows.Item(0).Cells(2).Value)
            '        ItemCnt = ItemCnt + 1
            '        PosGrid.SelectedRows.Item(0).Cells(2).Value = ItemCnt
            '        Dim NewPrice As Decimal = CDec(PosGrid.SelectedRows.Item(0).Cells(5).Value) * ItemCnt
            '        PosGrid.SelectedRows.Item(0).Cells(6).Value = NewPrice
            '    End If

            '    'Recompute the total
            '    For iii = 0 To PosGrid.Rows.Count - 1
            '        Totsss += CDec(PosGrid.Rows(iii).Cells(6).Value)
            '    Next
            '    'CalcEdit1.Value = Totsss
            '    txtCounts.Text = CStr(PosGrid.Rows.Count)
            '    txtSum.Text = FormatNumber(Totsss, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Totsss))
            '    CheckSumifNegative()
            '    vpTotalSales = Totsss
            '    'TextEdit1.Text = FormatCurrency(CStr(Totsss))


            'End If

            ''User pressed the minus key to subtract quantity by 1
            'If e.KeyCode = Keys.Subtract Then
            '    Totsss = 0
            '    iii = 0
            '    If cmbPriceMode.Text = "Refund" Then
            '        ItemCnt = CInt(PosGrid.SelectedRows.Item(0).Cells(2).Value)
            '        ItemCnt = ItemCnt + 1
            '        If ItemCnt = 0 Then
            '            ItemCnt = 1
            '        End If
            '        PosGrid.SelectedRows.Item(0).Cells(2).Value = ItemCnt
            '        Dim NewPrice3 As Decimal = CDec(PosGrid.SelectedRows.Item(0).Cells(5).Value) * ItemCnt
            '        PosGrid.SelectedRows.Item(0).Cells(6).Value = NewPrice3
            '    Else
            '        ItemCnt = CInt(PosGrid.SelectedRows.Item(0).Cells(2).Value)
            '        ItemCnt = ItemCnt - 1
            '        If ItemCnt = 0 Then
            '            ItemCnt = 1
            '        End If
            '        PosGrid.SelectedRows.Item(0).Cells(2).Value = ItemCnt
            '        Dim NewPrice As Decimal = CDec(PosGrid.SelectedRows.Item(0).Cells(5).Value) * ItemCnt
            '        PosGrid.SelectedRows.Item(0).Cells(6).Value = NewPrice
            '    End If
            '    'Recompute the total
            '    For iii = 0 To PosGrid.Rows.Count - 1
            '        Totsss += CDec(PosGrid.Rows(iii).Cells(6).Value)
            '    Next
            '    'CalcEdit1.Value = Totsss
            '    txtCounts.Text = CStr(PosGrid.Rows.Count)
            '    txtSum.Text = FormatNumber(Totsss, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Totsss))
            '    CheckSumifNegative()
            '    vpTotalSales = Totsss

            '    'TextEdit1.Text = FormatCurrency(CStr(Totsss))

            '    If e.KeyCode = Keys.Enter Then
            '        'txtitem.Focus()
            '    txtitem.Focus
            '    End If


            'End If

            If e.KeyCode = Keys.F1 Then
                If PosGrid.Rows.Count >= 1 Then
                    passcorrect = False
                    Dim frm As frmPasswordInput
                    frm = New frmPasswordInput
                    'frm.MdiParent = Me
                    frm.WindowState = FormWindowState.Normal
                    frm.ShowDialog()
                    frm = Nothing

                    If passcorrect = False Then
                        Exit Sub
                    End If
                    SetQuantity()
                End If

            End If



        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    'Private Sub ceQty_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Chr(13) Then
    '        If qtyy < 1 Then
    '            qtyy = 1
    '        End If
    '        qtyy = CInt(ceQty.Value)
    '        ceQty.Visible = False
    '    txtitem.Focus
    '    End If

    '    If e.KeyChar = Chr(Keys.Escape) Then
    '        If ceQty.Value < 1 Then
    '            ceQty.Value = 1
    '        End If
    '        qtyy = CInt(ceQty.Value)
    '        ceQty.Visible = False
    '    txtitem.Focus
    '    End If
    'End Sub
    'Private Sub ceQty_LostFocus(sender As Object, e As System.EventArgs)
    '    If ceQty.Value < 1 Then
    '        ceQty.Value = 1
    '    End If
    '    qtyy = CInt(ceQty.Value)
    '    ceQty.Visible = False
    'End Sub
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)
        'txtBarcode.Text = String.Empty
        Try

            If Not String.IsNullOrEmpty(txtBarcode.Text) Then
                txtBarcode.SelectAll()
            End If
            'leCust.EditValue = vbNullString
            ''leItems.EditValue = vbNullString
            txtBarcode.Text = ""
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub



    Private Sub frmPOS_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Softgroup.NetResize.License.LicenseName = "Doorscomputers"
        'Dim msg3 As MyResult = dTable.Select("stocks", "item_desc", "2")
        'Dim msg4 As MyResult = dTable.Select("stocks", "item_desc", "2")

        Softgroup.NetResize.License.LicenseUser = "rr3800@gmail.com"
        Softgroup.NetResize.License.LicenseKey = "JTAQCRATYLGO0YBIQMGFXANEA"
        Me.NetResize1.MinimumSize = New System.Drawing.Size(100, 100)

        'DevExpress.Utils.AppearanceObject.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0F)
        'txtCashier.Text = PDSAAppConfig.CurrentLoginID
        Dim strm As String
        Dim strd As String
        Dim stry As String
        strm = DateTime.Today.Month.ToString
        strd = DateTime.Today.Day.ToString
        stry = DateTime.Today.Year.ToString

        Timer1.Start()
        Me.Cursor = Cursors.WaitCursor
        Me.Text = "Inventory and Sales Monitoring System-Current User--" ' & PDSAAppConfig.CurrentLoginID
        PosGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        PosGrid.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        PosGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        PosGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        PosGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        lblName.Text = UCase(PDSAAppConfig.CurrentLoginID)
        lblDate.Text = strm + "/" + strd + "/" + stry

        Me.Cursor = Cursors.Default
        '+Latest Comments
        'Loads_frm()
        'Load_Emps()
        '+End of Latest Comment
        '++I commented btnnewfocus to automatically call New Transaction
        'btnnew.Focus()
        '++Determine if the searching is by Barcode or Item
        Dim strFindAvlbl As String = "SELECT searchtype FROM setuptbl"
        ExecuteSQLQuery(strFindAvlbl)

        If sqlDT.Rows.Count > 0 Then
            vBarcodeOrItemSearch = CBool(sqlDT.Rows(0)("searchtype"))
        End If


        Call NewTransaction()
        '++End of Comment

        'FullScreen()
        'Loads_frm()

        SetHook()

    End Sub


    Sub Loads_frm()
        ''TODO: This line of code loads data into the 'DoorsposDataSet.stocks' table. You can move, or remove it, as needed.

        'Me.StocksTableAdapter.Fill(Me.DoorsposDataSet.stocks)
        'GridLookUpEdit1.Properties.View.OptionsBehavior.AutoPopulateColumns = False
        ' Set column widths according to their contents.
        'GridLookUpEdit1.Properties.View.BestFitColumns()
        ' Specify the total dropdown width.
        'GridLookUpEdit1.Properties.PopupFormWidth = 860

        'GridLookUpEdit1.Properties.View.Columns(1).Width = 100
        ' GridLookUpEdit1.Properties.View.Columns(2).Width = 20
        'GridLookUpEdit1.Properties.View.Columns(3).Width = 30
        'Set the header  style of POS datagridview
        'GridLookUpEdit1.Properties.View.Columns(0).Width = 100
        'GridLookUpEdit1.Properties.View.Columns(1).Width = 100
        'GridLookUpEdit1.Properties.PopupFormWidth = 900

        PosGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomRight
        PosGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomRight
        Dim pbarint As Integer = 0
        Dim strm As String = ""
        Dim mgrstocks As vwStocksManager
        Dim cols As vwStocksCollection
        Try
            mgrstocks = New vwStocksManager()
            mgrstocks.DataObject.SelectFilter = vwStocksData.SelectFilters.All
            mgrstocks.DataObject.OrderByFilter = vwStocksData.OrderByFilters.itemdescript
            cols = mgrstocks.BuildCollection()
            'GridLookUpEdit2.Properties.View.OptionsBehavior.AutoPopulateColumns = False

            'GridLookUpEdit2.Properties.View.BestFitColumns()
            'GridLookUpEdit2.Properties.View.Columns(9).Width = 30
            'GridLookUpEdit2.Properties.View.Columns(10).Width = 30
            GridLookUpEdit2.Properties.PopupFormWidth = 860


            GridLookUpEdit2.Properties.DisplayMember = "itemdesc"
            GridLookUpEdit2.Properties.ValueMember = "stckid"
            'GridLookUpEdit2.EditValue = "itemdesc"
            GridLookUpEdit2.Properties.DataSource = cols
            ' ''tbSQL.Text = mgr.DataObject.SQL
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        'LoadCust()
        ''FullScreen()
    End Sub
    Sub LoadCust()
        'Dim mgrmembers As membersManager
        'Dim cols As membersCollection
        'Try
        '    mgrmembers = New membersManager
        '    mgrmembers.DataObject.SelectFilter = membersData.SelectFilters.All
        '    mgrmembers.DataObject.OrderByFilter = membersData.OrderByFilters.lastname
        '    cols = mgrmembers.BuildCollection()

        '    gleCust.Properties.View.OptionsBehavior.AutoPopulateColumns = False

        '    gleCust.Properties.View.BestFitColumns()
        '    gleCust.Properties.PopupFormWidth = 300

        '    gleCust.Properties.DisplayMember = "lastname"
        '    gleCust.Properties.ValueMember = "CustId"
        '    gleCust.EditValue = "custid"
        '    MessageBox.Show(CStr(gleCust.Properties.ValueMember))
        '    gleCust.Properties.DataSource = cols

        'Catch ex As PDSAValidationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try
    End Sub
    Sub Load_Emps()
        Dim mgrsemps As waitersManager
        Dim colsemps As waitersCollection
        Try
            mgrsemps = New waitersManager()
            mgrsemps.DataObject.SelectFilter = waitersData.SelectFilters.All
            colsemps = mgrsemps.BuildCollection()
            'mgrsemps.DataObject.OrderByFilter = vwStocksData.OrderByFilters.itemdescript
            dgEmps.DataSource = colsemps
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.Alt = True And e.KeyCode = Keys.Tab Then
            e.Handled = True
        End If

        If e.Alt = True And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If

        If e.KeyCode = Keys.H AndAlso e.Control = True Then
            Dim frm As frmHelp
            frm = New frmHelp
            frm.Show()
            frm = Nothing
            Exit Sub
        End If


        If e.KeyCode = Keys.Right Then
            txtBarcode.Text = String.Empty
            txtitem.Text = String.Empty
            txtitem.Focus()
            Exit Sub
        End If

        If e.KeyCode = Keys.Down Then

            If PosGrid.Rows.Count > 0 Then
                PosGrid.Focus()
                Me.PosGrid.Rows(0).Selected = True
                Exit Sub
            Else
                txtBarcode.Focus()
            End If

        End If

        'If e.KeyCode = Keys.F1 Then
        '    ''e.Handled = True
        '    ''Dim formQty As New frmQty
        '    ''formQty.ShowDialog()
        '    'Call OpenCustForm()

        'End If


        If e.KeyCode = Keys.Enter Then

            If txtBarcode.Text = String.Empty Then
                txtitem.Focus()
                Exit Sub
            Else
                Call BarcodePressed()
            End If

        End If

        If e.KeyCode = Keys.F10 Then
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If
            If btnSaves.Enabled = True And PosGrid.Rows.Count >= 1 Then
                MessageBox.Show("Please Complete a Pending Sales Transaction First")
                Exit Sub
            End If
            Dim ansint As Integer = 7
            ansint = MsgBox("Make Sure your printer is turned on and with enough paper loaded.", MsgBoxStyle.YesNo, "Check Printer.")
            If ansint = 7 Then
                Exit Sub
            End If
            'Dim repxrsalesbycat As New xrSalesByCat()
            ''repxrsalesbycat.Cashier.Value = PDSAAppConfig.CurrentLoginID
            'repxrsalesbycat.CashierName.Value = CStr(PDSAAppConfig.CurrentLoginID)
            'repxrsalesbycat.RequestParameters = False
            'repxrsalesbycat.PrintingSystem.ShowMarginsWarning = False
            'repxrsalesbycat.ShowPreview()

            'Dim posrepsales As New xrSalesEndDay()
            'posrepsales.RequestParameters = False
            'posrepsales.Parameter1.Value = PDSAAppConfig.CurrentLoginID
            'posrepsales.PrintingSystem.ShowMarginsWarning = False
            'posrepsales.Print()


            'Dim strFindCredits As String = "SELECT mowd FROM vwSalesbyCatToday WHERE mowd='CREDIT'"
            'ExecuteSQLQuery(strFindCredits)
            'If sqlDT.Rows.Count > 0 Then
            '    Dim posCredit As New xrCreditsToday()
            '    posCredit.RequestParameters = False
            '    posCredit.PrintingSystem.ShowMarginsWarning = False
            '    posCredit.Print()
            'End If

            'Dim strFindGetCash As String = "SELECT posdate FROM petty_cash WHERE posdate='" & Date.Today & "'"
            'ExecuteSQLQuery(strFindGetCash)
            'If sqlDT.Rows.Count > 0 Then
            '    Dim posGC As New xrPettyCash()
            '    posGC.RequestParameters = False
            '    posGC.PrintingSystem.ShowMarginsWarning = False
            '    posGC.Print()
            'End If

            'Dim strFindAC As String = "SELECT posdate FROM additnlcash WHERE posdate='" & Date.Today & "'"
            'ExecuteSQLQuery(strFindAC)
            'If sqlDT.Rows.Count > 0 Then
            '    Dim posAC As New xrAdditionalCash()
            '    posAC.RequestParameters = False
            '    posAC.PrintingSystem.ShowMarginsWarning = False
            '    posAC.Print()
            'End If


            txtBarcode.Enabled = False
            btnBcode.Enabled = False
            btnSearchItems.Enabled = False
            btnPriceMode.Enabled = False
            btnType.Enabled = False
            btnSaves.Enabled = False
            btnSuspend.Enabled = False
            btnRetrieve.Enabled = False
            btnRemove.Enabled = False
            btnCreditPay.Enabled = False
            btnChequePayment.Enabled = False
            btnnew.Enabled = False
            btnLookuprice.Enabled = False
            btnPickup.Enabled = False
            btnAddCash.Enabled = False
            btnDiscount.Enabled = False
            Button1.Enabled = False
            btnCustomers.Enabled = False
            PosGrid.Enabled = False

            Dim frmread As New frmReading
            frmread.ShowDialog()
            frmread = Nothing
            Me.Close()
            Exit Sub
        End If

        If e.KeyCode = Keys.F12 Then
            Dim vYesNo As Boolean = True
            Dim grdcountt As Integer = 0
            Dim iiiay As Integer = 0
            Dim I As Integer = 0
            Dim iCounter As Integer = 0
            Dim iiCounter As Integer = 0
            Dim vboolVAT As Integer
            ' compute the total for the receipt
            Tots = 0
            For I = 0 To PosGrid.Rows.Count - 1
                'MessageBox.Show(CStr(PosGrid.Rows.Count))
                Tots += CDec(PosGrid.Rows(I).Cells(6).Value)
            Next
            txtCounts.Text = CStr(PosGrid.Rows.Count)
            txtCounts.Text = CStr(PosGrid.Rows.Count)
            Vatable = 0
            NonVatable = 0
            For iCounter = 0 To PosGrid.Rows.Count - 1
                vboolVAT = CInt(PosGrid.Rows(iCounter).Cells(11).Value)
                If vboolVAT = 1 Then
                    Vatable += CDec(PosGrid.Rows(iCounter).Cells(6).Value)
                End If
            Next
            iiCounter = 0
            For iiCounter = 0 To PosGrid.Rows.Count - 1
                vboolVAT = CInt(PosGrid.Rows(iiCounter).Cells(11).Value)
                If vboolVAT = 0 Then
                    NonVatable += CDec(PosGrid.Rows(iiCounter).Cells(6).Value)
                End If

            Next

            grdcountt = PosGrid.Rows.Count
            Try
                If cmbPaymentType.Text = "CREDIT" And txtcustid.Text = "1" Then
                    MessageBox.Show("Change the payment type to CASH before collecting the payment or change a customer name because it is currently not charge to any customer")
                    Exit Sub
                End If

                For iiiay = 0 To grdcountt - 1
                    If CDec(PosGrid.Rows(iiiay).Cells(5).Value) <= 0 Then
                        MessageBox.Show("There is an Item with a Price that is Not valid or less than 0.1")
                        vYesNo = False
                        Exit Sub
                    End If
                Next


                If CDec(txtSum.Text) < 0 Then
                    txtSum.Text = FormatNumber(Tots, 2, , TriState.False, TriState.False)
                End If
                If vYesNo = False Then
                    Exit Sub
                End If
                If btnSaves.Enabled = False Then
                    Exit Sub
                End If
                TakePayment()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If

        If e.KeyCode = Keys.S AndAlso e.Control = True Then
            Dim frm As frmSalestoday
            frm = New frmSalestoday
            frm.Show()
            frm = Nothing
            Exit Sub
        End If

        If e.KeyCode = Keys.P AndAlso e.Control = True Then
            Try
                passcorrect = False


                If PosGrid.Rows.Count >= 1 Then
                    vPriceChange = CDec(PosGrid.SelectedRows(0).Cells(5).Value)
                    Dim formChangePrice As New frmNewPrice
                    formChangePrice.ShowDialog()
                    'If vPricingMode = "Refund" Then
                    '    vpieces = vpieces * -1
                    'End If

                    'this is the original Code below
                    'PosGrid.Rows(PosGrid.RowCount - 1).Cells(2).Value = vpieces
                    'this is the original Code above

                    PosGrid.SelectedRows(0).Cells(5).Value = vPriceChange
                    'PosGrid.Rows.Remove(PosGrid.SelectedRows(0))

                    ''Me.PosGrid.Rows(Me.PosGrid.RowCount - 1).Selected = True
                    txtitem.Text = String.Empty
                    'txtitem.Focus()


                    'Newly added code to re compute the totals
                    Dim IAyI As Integer = 0
                    Tots = 0
                    For IAyI = 0 To PosGrid.Rows.Count - 1
                        Tots += CDec(PosGrid.Rows(IAyI).Cells(6).Value)
                    Next

                    txtCounts.Text = CStr(PosGrid.Rows.Count)

                    'Scroll to the last row.
                    Me.PosGrid.FirstDisplayedScrollingRowIndex = Me.PosGrid.RowCount - 1

                    'Select the last row.
                    Me.PosGrid.Rows(Me.PosGrid.RowCount - 1).Selected = True

                    'CalcEdit1.Value = Tots
                    txtCounts.Text = CStr(PosGrid.Rows.Count)
                    txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots))
                    CheckSumifNegative()
                    vpTotalSales = Tots
                    'TextEdit1.Text = FormatCurrency(CStr(Tots))
                    qtyy = 1
                    vpieces = 1
                    'End of newly added code

                    If vBarcodeOrItemSearch = True Then
                        txtBarcode.Text = String.Empty
                        txtBarcode.Focus()
                    Else
                        txtitem.Text = String.Empty
                        txtitem.Focus()
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If

        If e.KeyCode = Keys.D AndAlso e.Control = True Then
            'Dim TotsBeforeDisc As Decimal = 0
            'Tots = 0
            'SeniorDiscount = 0
            'vdiscamnt = 0
            'Dim i As Integer = 0
            'For i = 0 To PosGrid.Rows.Count - 1
            '    Tots += CDec(PosGrid.Rows(i).Cells(6).Value)
            'Next
            '' txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) 'FormatNumber(CStr


            'txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True)
            'TotsBeforeDisc = CDec(CDec(Tots / 1.12) * 0.8)
            'SeniorDiscount = CDec(CDec(Tots / 1.12) * 0.2)
            'vdiscamnt = Tots - TotsBeforeDisc
            'txtSum.Text = FormatNumber(TotsBeforeDisc, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots22))
            'If vBarcodeOrItemSearch = True Then
            '    txtBarcode.Text = String.Empty
            '    txtBarcode.Focus()
            'Else
            '    txtitem.Text = String.Empty
            '    txtitem.Focus()
            'End If
            'txtBarcode.SelectAll()
            'Exit Sub
            SeniorDiscount = 0
            passcorrect = True
            If passcorrect = True Then

                Dim vdetdisc As Decimal = 0 ' this is the discount computed per item that was divided from the vdiscamnt variable to the total itemcount which is vItemCount
                Dim ayayay As Integer = 0
                For ayayay = 0 To PosGrid.Rows.Count - 1
                    PosGrid.Rows(ayayay).Cells(8).Value = 0
                Next

                If btnSaves.Enabled = False Then
                    MessageBox.Show("Discount is not allowed if Sales Transaction is already paid.")
                    Exit Sub
                End If
                If PosGrid.Rows.Count < 1 Then
                    MessageBox.Show("Item List is  B l a n k")
                    Exit Sub
                End If

                'Recalculate the total on the Grid and post it on txtsum before applying any discount
                Dim I As Integer = 0
                Tots = 0
                For I = 0 To PosGrid.Rows.Count - 1
                    Tots += CDec(PosGrid.Rows(I).Cells(6).Value)
                Next

                txtCounts.Text = CStr(PosGrid.Rows.Count)
                txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) ' FormatNumber(CStr(Tots))
                CheckSumifNegative()
                vpTotalSales = Tots



                Try
                    Dim percentamnt As Decimal = 0
                    vdisc = 0
                    vdiscamnt = 0
                    vtotalsales = Tots 'CDec(txtSum.Text) My New Comments 12 21 13
                    'vpTotalSales = CDec(txtSum.Text) My New Comments 12 21 13
                    txtCounts.Text = CStr(PosGrid.Rows.Count)
                    Dim frmdisc As New frmDiscount
                    frmdisc.ShowDialog()
                    txtSum.Text = FormatNumber(vtotalsales, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(vtotalsales))
                    CheckSumifNegative()

                    If vtotalsales = 0 Then
                        txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots))
                        CheckSumifNegative()
                        vpTotalSales = Tots
                    End If


                    Dim vItemCount As Integer = 0
                    Dim ay As Integer = 0
                    For ay = 0 To PosGrid.Rows.Count - 1
                        vItemCount += CInt(PosGrid.Rows(ay).Cells(5).Value)
                    Next

                    If vdiscamnt > 0 Then
                        vdetdisc = CDec(vdiscamnt / vItemCount)
                        Dim ayay As Integer = 0
                        For ayay = 0 To PosGrid.Rows.Count - 1
                            PosGrid.Rows(ayay).Cells(8).Value = CDec(vdetdisc * CInt(PosGrid.Rows(ayay).Cells(2).Value))
                        Next
                    End If
                    txtCounts.Text = CStr(PosGrid.Rows.Count)
                    txtSum.Text = FormatNumber(vtotalsales, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(vtotalsales))
                    CheckSumifNegative()
                    txtBarcode.Text = String.Empty
                    If vBarcodeOrItemSearch = True Then
                        txtBarcode.Text = String.Empty
                        txtBarcode.Focus()
                    Else
                        txtitem.Text = String.Empty
                        txtitem.Focus()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If

        End If

        If e.KeyCode = Keys.C AndAlso e.Control = True Then
            vStrCustName = CStr(InputBox("Enter Customer Name", "Customer Name", vStrCustName))
            If vStrCustName <> "" Then
                Dim straqlUpdateCustName As String = String.Empty
                straqlUpdateCustName = "UPDATE members SET lastname='" & vStrCustName & "'" & " WHERE CustId=1"
                ExecuteSQLQuery(straqlUpdateCustName)
                straqlUpdateCustName = String.Empty
                straqlUpdateCustName = "UPDATE members SET firstname=' ' WHERE CustId=1"
                ExecuteSQLQuery(straqlUpdateCustName)
            End If
            Exit Sub
        End If

        If e.KeyCode = Keys.Alt Then
            txtBarcode.Text = ""
        End If

        If e.KeyCode = Keys.F2 Then
            e.Handled = True
            Dim frm As New frmPriceLookup2
            frm.ShowDialog()
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If

        End If

        If e.KeyCode = Keys.F3 Then
            e.Handled = True
            Dim frmcp As New frmCreditPayment
            frmcp.ShowDialog()
            btnnew.Focus()
        End If

        If e.KeyCode = Keys.F4 Then
            ''~~~ Calling it and passing the name of the form to be displayed
            'Dim myObj As abcLockScreen = New abcLockScreen
            'myObj.LockSystemAndShow(Form2)

            vSalesNum = CInt(InputBox("Enter the sales number to be printed", "Reprint", CStr(ceRefno.Text)))
            Dim posrep As New xrReceiptTodaRaba()
            'posrep.DataSource = sqlDT
            posrep.Parameter1.Value = vSalesNum
            posrep.RequestParameters = False
            posrep.PrintingSystem.ShowMarginsWarning = False
            posrep.Print()

        End If


        If e.KeyCode = Keys.F5 Then
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If
            'If btnnew.Enabled = False Then
            If PosGrid.Rows.Count > 0 Then
                SuspendTrans()
            Else
                If vBarcodeOrItemSearch = True Then
                    txtBarcode.Text = String.Empty
                    txtBarcode.Focus()
                Else
                    txtitem.Text = String.Empty
                    txtitem.Focus()
                End If
            End If
        End If

        If e.KeyCode = Keys.F6 Then
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If
            If btnnew.Enabled = False Then
                'If PosGrid.Rows.Count > 1 Then
                'MessageBox.Show("Pls. finish the existing sales transaction before retrieving a suspended sale.")
                'xit Sub
                'Else
                Call RetrieveTrans()
                'End If
            End If
        End If

        If e.KeyCode = Keys.F7 Then
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If
            'If btnnew.Enabled = False Then
            '    cmbPriceMode.Text = "Refund"
            '    'txtBarcode.Focus()
            '    'btnSearchItems.Focus()
            '    txtitem.Focus()
            '    txtitem.Text = String.Empty
            '    txtitem.Focus()
            'End If
        End If

        If e.KeyCode = Keys.F8 Then
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If
            'If PosGrid.Rows.Count > 1 Then
            'MessageBox.Show("Pls. finish the existing sales transaction before retrieving a suspended sale.")
            'Exit Sub
            'Else
            'Call RetrieveTrans()
            'End If
            Call RePrint()
        End If



        If e.KeyCode = Keys.F9 Then
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If

            Unhook()

            'itemcnt = 0
            'vdisc = 0
            'vdiscamnt = 0
            'vEmpID = 1
            'txtTendered.Text = "0"
            'Try

            '    txtSum.Text = "0"
            '    PosGrid.Rows.Clear()
            '    txtBarcode.Text = String.Empty
            '    txtitem.Text = String.Empty
            '    'txtTendered.Text = "0"
            '    'lblChange.Text = "0"
            '    ceWtid.Value = 1
            '    vtotalsales = 0
            '    vpTotalSales = 0
            '    txtcustid.Text = "1"
            '    txtqty.Text = "0"
            '    txtlastname.Text = "CASH"
            '    txtfirstname.Text = String.Empty
            '    btnSaves.Enabled = True
            '    btnPriceMode.Enabled = True
            '    btnType.Enabled = True
            '    btnSuspend.Enabled = True
            '    btnRetrieve.Enabled = True
            '    btnRemove.Enabled = True
            '    btnDiscount.Enabled = True
            '    Button1.Enabled = True ' this is the Set Quantity button
            '    btnCustomers.Enabled = True
            '    txtBarcode.Enabled = True
            '    btnSearchItems.Enabled = True
            '    btnReprint.Enabled = True
            '    txtbcodes.Text = String.Empty
            '    txtStckid.Text = String.Empty
            '    btnType.Enabled = True
            '    btnPriceMode.Enabled = True
            '    btnCustomers.Enabled = True
            '    btnSuspend.Enabled = True
            '    btnRetrieve.Enabled = True
            '    btnRemove.Enabled = True
            '    cmbPriceMode.Text = "Retail"
            '    cmbPaymentType.Text = "CASH"
            '    btnChequePayment.Enabled = True
            '    'GridLookUpEdit2.Enabled = True
            '    txtitem.Enabled = True


            '    btnnew.Enabled = False
            '    If vBarcodeOrItemSearch = True Then
            '        txtBarcode.Text = String.Empty
            '        txtBarcode.Focus()
            '    Else
            '        txtitem.Text = String.Empty
            '        txtitem.Focus()
            '    End If

            'Catch ex As Exception
            '    MessageBox.Show(ex.ToString())
            'End Try
        End If




        If e.Alt = True And e.KeyCode = Keys.Tab Then
            e.Handled = True
        End If

        If e.Alt = True And e.KeyCode = Keys.P Then
            PriceOverride()
            e.Handled = True
        End If


        If e.Alt = True And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
        'If e.KeyCode = Keys.Left Then
        'txtitem.Focus
        '    txtitem.Text = ""
        'End If

        If e.KeyCode = Keys.Down Then
            If dgitems.Visible = True Then
                dgitems.Focus()
            Else
                If PosGrid.Rows.Count > 1 Then
                    PosGrid.Focus()
                End If
            End If

        End If
        If e.KeyCode = Keys.F1 Then
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If
            SetQuantity()
            e.Handled = True
        End If

        If e.KeyCode = Keys.Escape Then

            dgitems.Visible = False
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
            e.SuppressKeyPress = True
        End If





    End Sub
    Sub BarcodePressed()
        If Not String.IsNullOrEmpty(txtBarcode.Text) Then

            Try
                mgr = New stocksManager()
                mgr.DataObject.WhereFilter = stocksData.WhereFilters.barcode
                mgr.Entity.barcode = txtBarcode.Text.Trim
                'MessageBox.Show("Total Record Count is " & _
                'mgr.DataObject.RowCount().ToString())
                'tbSQL.Text = mgr.DataObject.SQL

                col1 = mgr.BuildCollection()


                If mgr.DataObject.RowsAffected > 0 Then

                    'DataGridView1.DataSource = col1 'mgr.BuildCollection()
                    nProdID = mgr.DataObject.Entity.stckid
                    nQtyWholesale = mgr.DataObject.Entity.markup3
                    nWS = mgr.DataObject.Entity.retail2
                    nRP = mgr.DataObject.Entity.retail
                    'txtitem.Text = mgr.DataObject.Entity.itemdesc
                    txtbcodes.Text = mgr.DataObject.Entity.barcode
                    txtStckid.Text = CStr(mgr.DataObject.Entity.stckid)
                    txtqty.Text = CStr(ceQtyy.Value) 'this is the original code January 2016 CStr(qtyy)
                    frmNewPrice.vItemCode = Trim(txtbcodes.Text)
                    frmNewPrice.vRetWhol = Trim(vPricingMode)
                    ceQtyy.Focus()
                    'SendItemtoGrid3()
                    Call LookupEditKeypress()
                Else
                    Try
                        ' Create a new SoundPlayer instance pointing to the sound file
                        Dim player As New SoundPlayer("C:\barcodenotfoundwav.wav")

                        ' Load the sound file into the SoundPlayer
                        player.Load()

                        ' Play the sound asynchronously
                        player.Play()

                    Catch ex As Exception
                        MessageBox.Show("An error occurred while trying to play sound: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try




                    'MessageBox.Show("B A R C O D E  N O T  F O U N D")
                    Dim frmnotfawn As New frmNotFound
                    frmnotfawn.ShowDialog()
                    txtTendered.Text = "0"
                    lblChange.Text = "0"
                    txtBarcode.Text = String.Empty
                    If vBarcodeOrItemSearch = True Then
                        txtBarcode.Text = String.Empty
                        txtBarcode.Focus()
                    Else
                        txtitem.Text = String.Empty
                        txtitem.Focus()
                    End If

                End If

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)

                ' Catch ex As Exception
                'MsgBox(ex.Message.ToString())
                ' MessageBox.Show(ex.ToString())
            End Try
            'Else
            '    Try
            '        mgr2 = New stocksManager()

            '        mgr2.DataObject.WhereFilter = stocksData.WhereFilters.Likeitem
            '        mgr2.Entity.item = txtItem.Text.Trim()
            '        col1 = mgr2.BuildCollection()

            '        If mgr2.DataObject.RowsAffected > 0 Then

            '            'DataGridView1.DataSource = col1 'mgr.BuildCollection()
            '            cItem = mgr2.DataObject.Entity.item
            '            SendItemtoGrid()

            '        End If

            '    Catch ex As Exception
            '        'ex.Message.ToString()
            '    End Try

        End If
        txtBarcode.SelectAll()

        'Call GoToQty()

    End Sub
    Sub BarcodeKeyDown()
        If Not String.IsNullOrEmpty(txtBarcode.Text) Then

            Try
                mgr = New stocksManager()
                mgr.DataObject.WhereFilter = stocksData.WhereFilters.barcode
                mgr.Entity.barcode = txtBarcode.Text.Trim
                'MessageBox.Show("Total Record Count is " & _
                'mgr.DataObject.RowCount().ToString())
                'tbSQL.Text = mgr.DataObject.SQL

                col1 = mgr.BuildCollection()


                If mgr.DataObject.RowsAffected > 0 Then

                    'DataGridView1.DataSource = col1 'mgr.BuildCollection()
                    nProdID = mgr.DataObject.Entity.stckid
                    nQtyWholesale = mgr.DataObject.Entity.markup3
                    nWS = mgr.DataObject.Entity.retail2
                    nRP = mgr.DataObject.Entity.retail
                    txtitem.Text = mgr.DataObject.Entity.itemdesc
                    txtbcodes.Text = mgr.DataObject.Entity.barcode
                    txtStckid.Text = CStr(mgr.DataObject.Entity.stckid)
                    txtqty.Text = CStr(ceQtyy.Value) 'this is the original code January 2016 CStr(qtyy)
                    ceQtyy.Focus()
                    ' SendItemtoGrid3()
                Else
                    'MessageBox.Show("B A R C O D E  N O T  F O U N D")
                    Dim frmnotfawn As New frmNotFound
                    frmnotfawn.ShowDialog()
                    txtTendered.Text = "0"
                    lblChange.Text = "0"
                    If vBarcodeOrItemSearch = True Then
                        txtBarcode.Text = String.Empty
                        txtBarcode.Focus()
                        txtBarcode.SelectAll()
                    Else
                        txtitem.Text = String.Empty
                        txtitem.Focus()
                    End If
                    Exit Sub
                End If

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)

                ' Catch ex As Exception
                'MsgBox(ex.Message.ToString())
                ' MessageBox.Show(ex.ToString())
            End Try
            'Else
            '    Try
            '        mgr2 = New stocksManager()

            '        mgr2.DataObject.WhereFilter = stocksData.WhereFilters.Likeitem
            '        mgr2.Entity.item = txtItem.Text.Trim()
            '        col1 = mgr2.BuildCollection()

            '        If mgr2.DataObject.RowsAffected > 0 Then

            '            'DataGridView1.DataSource = col1 'mgr.BuildCollection()
            '            cItem = mgr2.DataObject.Entity.item
            '            SendItemtoGrid()

            '        End If

            '    Catch ex As Exception
            '        'ex.Message.ToString()
            '    End Try

        End If
        'txtBarcode.SelectAll()
        'txtitem.Focus()
        'ceQtyy.Focus()
        '+COmment Jul 12 2016
        'Call GoToQty()

        '+End of Comment
        'New Code July 12 2016
        Call SendItemImmediately()
        '+End of New Code

    End Sub

    Sub SearchBarcodeOnItem()
        nProdID = 0
        'nStckid = 0
        If Not String.IsNullOrEmpty(txtitem.Text) Then

            Try
                mgr = New stocksManager()
                mgr.DataObject.WhereFilter = stocksData.WhereFilters.barcode
                mgr.Entity.barcode = txtitem.Text.Trim
                'MessageBox.Show("Total Record Count is " & _
                'mgr.DataObject.RowCount().ToString())
                'tbSQL.Text = mgr.DataObject.SQL

                col1 = mgr.BuildCollection()


                If mgr.DataObject.RowsAffected > 0 Then

                    'DataGridView1.DataSource = col1 'mgr.BuildCollection()
                    nProdID = mgr.DataObject.Entity.stckid
                    txtitem.Text = mgr.DataObject.Entity.itemdesc
                    txtbcodes.Text = mgr.DataObject.Entity.barcode
                    txtStckid.Text = CStr(mgr.DataObject.Entity.stckid)
                    txtqty.Text = CStr(ceQtyy.Value) 'this is the original code January 2016 CStr(qtyy)
                    frmNewPrice.vItemCode = Trim(txtbcodes.Text)
                    frmNewPrice.vRetWhol = Trim(vPricingMode)
                    'ceQtyy.Focus()
                    '+I uncommented the code below, Originally it is commented
                    'SendItemtoGrid3()
                    '+New Code
                    Try
                        If txtitem.Text = String.Empty Then
                            MessageBox.Show("Please select an Item before pressing the enter key!")
                            Exit Sub
                        End If



                        mgr6 = New stocksManager()
                        mgr6.DataObject.SelectFilter = stocksData.SelectFilters.positems
                        mgr6.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey
                        ' 'MessageBox.Show(CType(leItems.EditValue, stocks))
                        mgr6.DataObject.Entity.stckid = nProdID '+vStckid 'CInt(GridLookUpEdit2.EditValue)

                        col1 = mgr6.BuildCollection()

                        If mgr6.DataObject.RowsAffected > 0 Then

                            'DataGridView1.DataSource = col1 'mgr.BuildCollection()
                            nProdID = mgr6.DataObject.Entity.stckid
                            vincentives = mgr6.DataObject.Entity.incentive
                            Dim vBoo As Boolean
                            Dim vBoo00 As Boolean
                            vBoo00 = CBool(mgr6.DataObject.Entity.active)
                            vBoo = CBool(mgr6.DataObject.Entity.vat)
                            vboolItemFound = False
                            SendItemtoGrid3()

                        End If

                    Catch ex As PDSAValidationException
                        MessageBox.Show(ex.Message)
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString())
                    End Try
                    '+End of NEw Code



                Else
                    'If dgitems.Visible = True Then
                    'DgitemsKeydown()

                    'Else
                    'Comment on Oct 17, 2017 so that it will add on the Sales list the first item on the Grid
                    'MessageBox.Show("B A R C O D E  N O T  F O U N D")
                    Dim frmnotfawn As New frmNotFound
                    frmnotfawn.ShowDialog()
                    txtTendered.Text = "0"
                    lblChange.Text = "0"
                    dgitems.Visible = False
                    txtitem.Text = ""
                    If vBarcodeOrItemSearch = True Then
                        txtBarcode.Text = String.Empty
                        txtBarcode.Focus()
                        txtBarcode.SelectAll()
                    Else
                        txtitem.Text = String.Empty
                        txtitem.Focus()
                    End If


                    Exit Sub
                    'End of COmment Oct 2017

                    'the code below is the solution so that they will not need to press the down arrow key once they press the enter key
                    'comment on feb 2018
                    'uncomment below if the cloient insist
                    'DgitemsKeydown()
                    'txtitem.Focus()
                    'end of comment
                    'End If
                End If
            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)

                ' Catch ex As Exception
                'MsgBox(ex.Message.ToString())
                ' MessageBox.Show(ex.ToString())
            End Try
            'Else
            '    Try
            '        mgr2 = New stocksManager()

            '        mgr2.DataObject.WhereFilter = stocksData.WhereFilters.Likeitem
            '        mgr2.Entity.item = txtItem.Text.Trim()
            '        col1 = mgr2.BuildCollection()

            '        If mgr2.DataObject.RowsAffected > 0 Then

            '            'DataGridView1.DataSource = col1 'mgr.BuildCollection()
            '            cItem = mgr2.DataObject.Entity.item
            '            SendItemtoGrid()

            '        End If

            '    Catch ex As Exception
            '        'ex.Message.ToString()
            '    End Try

        End If




        'Call SendItemImmediately()

    End Sub


    Sub GoToQty()
        If dgitems.Rows.Count < 1 Then
            Exit Sub
        End If
        Try
            Dim vRow As Integer = 0
            Dim vint As Integer = 0
            Dim x1 As String = String.Empty
            Dim x2 As String = String.Empty
            ' Dim x2 As Integer = 0
            Dim x3 As Integer = 0
            Dim x4 As Decimal = 0
            Dim x5 As Integer = 0
            Dim x6 As String = String.Empty
            vRow = 0 'dgitems.CurrentRow.Index
            'vint = CInt(dgitems(0, vRow).Value)
            'x1 = CStr(dgitems(1, vRow).Value)
            'x2 = CStr(dgitems(2, vRow).Value)
            'x3 = CDec(dgitems(12, vRow).Value)
            'x4 = CDec(dgitems(13, vRow).Value)
            vint = CInt(dgitems(0, vRow).Value)
            x1 = CStr(dgitems(1, vRow).Value)
            x2 = CStr(dgitems(2, vRow).Value)
            x3 = CInt(dgitems(3, vRow).Value)
            x4 = CDec(dgitems(4, vRow).Value)
            x5 = CInt(dgitems(6, vRow).Value)
            'x6 = CStr(dgitems(7, vRow).Value)
            vStckid = vint
            vItem = x2
            vAvlbl = x3
            vbocde = x1
            vPrice = x3
            vWPrice = x4
            vInnerQty = x5

            txtbcodes.Text = String.Empty
            txtStckid.Text = String.Empty
            txtitem.Text = vItem.ToString
            txtbcodes.Text = vbocde.ToString
            txtBarcode.Text = vbocde.ToString
            txtStckid.Text = vStckid.ToString
            ''txtBarcode.SelectAll()
            'If txtStckid.Text = String.Empty Then
            '    Exit Sub
            'Else
            '    ItemsearchExecute()
            'End If
            'txtitem.Focus()


            'New Comment 11/22/2015
            'ceQtyy.Focus()
            dgitems.Visible = False
            Call SendItemImmediately()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub BCodeFocus()
        Try
            If Not String.IsNullOrEmpty(txtBarcode.Text) Then
                txtBarcode.SelectAll()
            End If
            ' leCust.EditValue = vbNullString
            ''leItems.EditValue = vbNullString
            txtBarcode.Text = ""
            txtBarcode.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub txtBarcode_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        'If e.KeyChar = Chr(13) Then
        '    txtTendered.Text = "0"
        '    lblChange.Text = "0"
        '    If txtBarcode.Text = String.Empty Then
        '        MessageBox.Show("B a r c o d e   n o t   f o u n d   o r   e m p t y !")
        '    End If
        'End If


        If e.KeyChar = Chr(42) Then
            e.Handled = True
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If
            SetQuantity()

            txtBarcode.Text = ""
            txtBarcode.Text = String.Empty
            'txtBarcode.Focus()
        End If
    End Sub


    Sub SuspendTrans()
        If PosGrid.Rows.Count < 1 Then
            MessageBox.Show("No Items to Suspend")
            Exit Sub
        End If
        Dim myAL As New ArrayList
        oht = New pos_hdrtmpManager()
        ' If MsgBox("Are you sure you want to suspend this transaction?", CType(MsgBoxStyle.Information + MsgBoxStyle.YesNo, MsgBoxStyle)) = MsgBoxResult.Yes Then
        If PosGrid.Rows.Count < 1 Then
            MessageBox.Show("Item List is  B l a n k")
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
            Exit Sub
        End If

        Try

            Tran = New PDSATransaction()
            Tran2 = New PDSATransaction()
            oht.DataObject.TransactionType = PDSATransactionType.Insert


            'oht.Entity.custid = 205
            'oht.Entity.posdate = DateTime.Today()
            '    oht.Entity.status = False

            '    oht.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            '    Tran.Add(oht.DataObject)
            '    Tran.Execute()
            '    grdCount = PosGrid.Rows.Count
            '    For ii = 0 To grdCount - 1
            '        odt1.Entity.postmphdrid = mOrderId
            '        odt1.Entity.stckid = Convert.ToInt32(PosGrid.Rows(ii).Cells(0).Value)
            '        odt1.Entity.barcode = CStr(PosGrid.Rows(ii).Cells(1).Value)
            '        odt1.Entity.itemdesc = CStr(PosGrid.Rows(ii).Cells(2).Value)
            '        odt1.Entity.cost = Convert.ToDecimal(PosGrid.Rows(ii).Cells(3).Value)
            '        odt1.Entity.price = Convert.ToDecimal(PosGrid.Rows(ii).Cells(4).Value)
            '        odt1.Entity.qty = Convert.ToInt32(PosGrid.Rows(ii).Cells(5).Value)
            '        odt1.Entity.detamnt = Convert.ToDecimal(PosGrid.Rows(ii).Cells(4).Value) * Convert.ToInt32(PosGrid.Rows(ii).Cells(5).Value)

            '        myAL.Add(odt1.DataObject.Entity)

            '        Tran2.Add(odt1.DataObject)
            '        Tran2.Execute()
            '        Tran2.RemoveAt(0)
            '    Next

            'Catch ex As PDSAValidationException
            '    MessageBox.Show(ex.Message)
            'Catch ex As Exception
            '    MessageBox.Show(ex.ToString())
            'End Try
            If txtcustid.Text = "0" Then
                txtcustid.Text = "1"
            End If
            oht.Entity.custid = Convert.ToInt32(txtcustid.Text)
            oht.Entity.posdate = Date.Now
            oht.Entity.status = False
            'gOT pUZZLED WHY I have 2 status so I commented it below , comment up if it is the right one
            'oht.Entity.status = False
            '*************
            oht.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            Tran.Add(oht.DataObject)
            'commented on june 12 2014 and brought it down
            'Catch ex As PDSAValidationException
            '    MessageBox.Show(ex.Message)
            '    Exit Sub
            'Catch ex As Exception
            '    MessageBox.Show(ex.ToString())
            '    Exit Sub
            'End Try
            'end of comment on june 12 2014 and brought it down

            grdCount = PosGrid.Rows.Count
            For ii = 0 To grdCount - 1
                odt1 = New pos_dettmpManager()
                odt1.DataObject.TransactionType = PDSATransactionType.Insert
                odt1.Entity.postmphdrid = mOrderId
                odt1.Entity.stckid = Convert.ToInt32(PosGrid.Rows(ii).Cells(0).Value)
                odt1.Entity.barcode = CStr(PosGrid.Rows(ii).Cells(1).Value)
                odt1.Entity.itemdesc = CStr(PosGrid.Rows(ii).Cells(4).Value)
                odt1.Entity.cost = Convert.ToDecimal(PosGrid.Rows(ii).Cells(3).Value)
                odt1.Entity.price = Convert.ToDecimal(PosGrid.Rows(ii).Cells(5).Value)
                odt1.Entity.ws = Convert.ToDecimal(PosGrid.Rows(ii).Cells(7).Value)
                odt1.Entity.qty = Convert.ToInt32(PosGrid.Rows(ii).Cells(2).Value)
                odt1.Entity.detamnt = Convert.ToDecimal(PosGrid.Rows(ii).Cells(5).Value) * Convert.ToInt32(PosGrid.Rows(ii).Cells(2).Value)
                odt1.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                odt1.Entity.detdisc = CShort(Convert.ToDecimal(PosGrid.Rows(ii).Cells(8).Value))
                odt1.Entity.incentiv = 0 'CDec(Convert.ToBoolean(PosGrid.Rows(ii).Cells(9).Value)))
                Tran.Add(odt1.DataObject)
            Next
            Tran.Execute()
            PosGrid.Rows.Clear()
            txtSum.Text = "0"
            txtcustid.Text = "1"
            txtlastname.Text = "CASH"
            txtfirstname.Text = ""
            cmbPaymentType.Text = "CASH"
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try
        'End If
    End Sub

    Private Sub Tran_AfterSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles Tran.AfterSubmit
        ' Get the SQL Identity generated and store into local variable
        If e.ClassName = "pos_hdrtmpData" Then
            mOrderId = DirectCast(e.DataClassTable.EntityObject, pos_hdrtmp).postmphdrid
            'If mOrderId > 6000 Then
            '    MessageBox.Show("Evaluation Period is more than 30 days. Pls contact Mr. Warren Dulnuan for proper licensing option (09176553488)", "Evaluation Period Expired")
            '    mOrderId = 0
            '    Exit Sub
            'End If
        End If
    End Sub

    Private Sub Tran_BeforeSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles Tran.BeforeSubmit
        ' Put local order id into line item objects prior to submitting INSERT statement
        'If e.ClassName = "pos_dettmpData" Then
        ' DirectCast(e.DataClassTable.EntityObject, pos_dettmp).postmphdrid = mOrderId
        'End If
        If e.ClassName = "pos_dettmpData" Then
            DirectCast(e.DataClassTable.EntityObject, pos_dettmp).postmphdrid = mOrderId
            'If mOrderId > 6000 Then
            '    MessageBox.Show("Evaluation Period is more than 30 days. Pls contact Mr. Warren Dulnuan for proper licensing option (09176553488)", "Evaluation Period Expired")
            '    mOrderId = 0
            '    Exit Sub
            'End If
        End If

    End Sub

    'Private Sub Tran2_AfterSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles Tran.AfterSubmit
    '    ' Get the SQL Identity generated and store into local variable
    '    If e.ClassName = "pos_hdrtmpData" Then
    '        mOrderId = DirectCast(e.DataClassTable.EntityObject, pos_hdrtmp).postmphdrid
    '    End If
    'End Sub

    'Private Sub Tran2_BeforeSubmit(ByVal sender As Object, ByVal e As PDSA.DataLayer.DataClasses.PDSATransactionEventArgs) Handles Tran.BeforeSubmit
    '    ' Put local order id into line item objects prior to submitting INSERT statement
    '    If e.ClassName = "pos_dettmpData" Then
    '        DirectCast(e.DataClassTable.EntityObject, pos_dettmp).postmphdrid = mOrderId
    '    End If
    'End Sub

    ' Private Sub btnRetrieve_Click(sender As System.Object, e As System.EventArgs) Handles btnRetrieve.Click
    'Dim mgrRetrieve As pos_hdrtmpManager
    'Dim col3 As pos_hdrtmpCollection

    'Try
    '    mgrRetrieve = New pos_hdrtmpManager()
    '    mgrRetrieve.DataObject.WhereFilter = pos_hdrtmpData.WhereFilters.sInsert_id
    '    mgrRetrieve.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
    '    tbSQL.Text = mgrRetrieve.DataObject.SQL
    '    col3 = mgrRetrieve.BuildCollection
    '    If mgrRetrieve.DataObject.RowsAffected > 0 Then
    '        DGRetrieve.Visible = True
    '        DGRetrieve.Focus()
    '        DGRetrieve.DataSource = col3

    '    Else
    '        MessageBox.Show("N o   S u s p e n d e d   S a l e   t o   D i s p l a y")
    '        DGRetrieve.Visible = False
    '    txtitem.Focus

    '    End If
    '    'PosGrid.Rows.Add(mgr.DataObject.Entity.s, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.item, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail,                 qtyy, mgr.DataObject.Entity.retail)


    'Catch ex As PDSAValidationException
    '    MessageBox.Show(ex.Message)

    'Catch ex As Exception
    '    MessageBox.Show(ex.ToString())
    'End Try
    'Dim mgrRetrieve As vwSuspendHdrManager
    'Dim col3 As vwSuspendHdrCollection

    'Try
    '    mgrRetrieve = New vwSuspendHdrManager()
    '    mgrRetrieve.DataObject.WhereFilter = vwSuspendHdrData.WhereFilters.cashstatus
    '    mgrRetrieve.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
    '    mgrRetrieve.Entity.status = False
    '    tbSQL.Text = mgrRetrieve.DataObject.SQL
    '    col3 = mgrRetrieve.BuildCollection()
    '    If mgrRetrieve.DataObject.RowsAffected > 0 Then
    '        DGRetrieve.Visible = True
    '        DGRetrieve.Focus()
    '        DGRetrieve.DataSource = col3

    '    Else
    '        MessageBox.Show("N o   S u s p e n d e d   S a l e   t o   D i s p l a y")
    '        DGRetrieve.Visible = False
    '    txtitem.Focus

    '    End If
    '    'PosGrid.Rows.Add(mgr.DataObject.Entity.s, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.item, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail,                 qtyy, mgr.DataObject.Entity.retail)

    'Catch ex As PDSAValidationException
    '    MessageBox.Show(ex.Message)

    'Catch ex As Exception
    '    MessageBox.Show(ex.ToString())
    'End Try
    '    If PosGrid.Rows.Count > 1 Then
    '        MessageBox.Show("Pls. Finish or Cancel the existing sales transaction first before retrieving a suspended sales transaction")
    '        Exit Sub
    '    End If
    '    Call RetrieveTrans()

    'End Sub

    Sub RetrieveTrans()
        Dim mgrRetrieve As vwSuspendedSaleManager
        Dim col3 As vwSuspendedSaleCollection

        Me.DGRetrieve.DefaultCellStyle.Font = New Font("Tahoma", 20)
        ' Me.DGRetrieve.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight
        Try
            mgrRetrieve = New vwSuspendedSaleManager()
            mgrRetrieve.DataObject.SelectFilter = vwSuspendedSaleData.SelectFilters.SuspendedItems
            mgrRetrieve.DataObject.WhereFilter = vwSuspendedSaleData.WhereFilters.cashstatus
            mgrRetrieve.DataObject.OrderByFilter = vwSuspendedSaleData.OrderByFilters.suspendid
            mgrRetrieve.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            mgrRetrieve.Entity.status = False

            'tbSQL.Text = mgrRetrieve.DataObject.SQL
            col3 = mgrRetrieve.BuildCollection()
            If mgrRetrieve.DataObject.RowsAffected > 0 Then
                DGRetrieve.Visible = True
                DGRetrieve.Focus()
                DGRetrieve.DataSource = mgrRetrieve.DataObject.GetDataTable() 'col3
                Me.DGRetrieve.AutoResizeColumns()
                Me.DGRetrieve.AutoResizeRows()
                Me.DGRetrieve.Columns(4).Visible = False
                Me.DGRetrieve.Columns(5).Visible = False
                Me.DGRetrieve.Columns(6).Visible = False
                Me.DGRetrieve.Columns(7).Visible = False
                Me.DGRetrieve.Columns(8).Visible = False
                Me.DGRetrieve.Columns(9).Visible = False
                Me.DGRetrieve.Columns(10).Visible = False
                Me.DGRetrieve.Columns(11).Visible = False
                Me.DGRetrieve.Columns("det_amnt").DefaultCellStyle.Format = "c"
                Me.DGRetrieve.Columns("det_amnt").DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight
            Else
                MessageBox.Show("N o   S u s p e n d e d   S a l e   t o   D i s p l a y")
                DGRetrieve.Visible = False
                If vBarcodeOrItemSearch = True Then
                    txtBarcode.Text = String.Empty
                    txtBarcode.Focus()
                Else
                    txtitem.Text = String.Empty
                    txtitem.Focus()
                End If
            End If
            'PosGrid.Rows.Add(mgr.DataObject.Entity.s, mgr.DataObject.Entity.barcode, mgr.DataObject.Entity.item, mgr.DataObject.Entity.cost, mgr.DataObject.Entity.retail,                 qtyy, mgr.DataObject.Entity.retail)



        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub SetDefaultCellStyles()

        Dim highlightCellStyle As New DataGridViewCellStyle
        highlightCellStyle.BackColor = Color.Red

        Dim currencyCellStyle As New DataGridViewCellStyle
        currencyCellStyle.Format = "N"
        currencyCellStyle.ForeColor = Color.Green

        With Me.DGRetrieve
            .DefaultCellStyle.BackColor = Color.Beige
            .DefaultCellStyle.Font = New Font("Tahoma", 10)
            .Rows(3).DefaultCellStyle = highlightCellStyle
            .Rows(3).DefaultCellStyle = highlightCellStyle
            .Columns("qty").DefaultCellStyle = currencyCellStyle
            .Columns("qty").DefaultCellStyle = currencyCellStyle
            .Rows(0).Visible = False
            .Rows(4).Visible = False
        End With
    End Sub

    Private Sub DGRetrieve_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DGRetrieve.KeyDown
        Dim ii As Integer
        Dim TotsRet As Decimal = 0
        'If e.KeyCode = Keys.Escape Then
        '    DGRetrieve.Visible = False
        '    txtitem.Focus()
        '    Exit Sub
        'End If
        If e.KeyCode = Keys.R AndAlso e.Control = True Then


            Dim vCellVal11 As Integer = 0
            Dim row11 As Integer = DGRetrieve.CurrentCellAddress.Y
            Dim column11 As Integer = DGRetrieve.CurrentCellAddress.X
            Dim col411 As vwSuspendedCollection

            If column11 > 1 Then
                MessageBox.Show("Please select the suspended sale on the first column or select the second column to Cancel Retrieval of Suspended Sale")
                Exit Sub
            End If

            If column11 = 0 Then ' this is the main code to be executed
                'MessageBox.Show(row.ToString + " " + column.ToString)
                vCellVal11 = CInt(DGRetrieve.CurrentCell.Value)
                Dim mgrRetriv As vwSuspendedManager
                Dim mgrHdrTmp As pos_hdrtmpManager

                Try
                    mgrRetriv = New vwSuspendedManager()
                    'mgrRetriv.DataObject.WhereFilter = vwSuspendedData.WhereFilters.SuspendId
                    'mgrRetriv.Entity.postmphdrid = vCellVal
                    'tbSQL.Text = mgrRetriv.DataObject.SQL
                    col411 = mgrRetriv.BuildCollection()
                    If mgrRetriv.DataObject.RowsAffected > 0 Then
                        'send the suspended value to POSGrid
                        'Dim mgrsend As vwSuspendedManager
                        'mgrsend = New vwSuspendedManager()
                        'mgrsend.DataObject.WhereFilter = vwSuspendedData.WhereFilters.SuspendId
                        'mgrsend.Entity.postmphdrid = vCellVal
                        'Dim col5 As vwSuspendedCollection
                        'col5 = mgrsend.BuildCollection()
                        'If mgrsend.DataObject.RowsAffected > 0 Then
                        For ii = 0 To mgrRetriv.DataObject.GetDataTable.Rows.Count - 1
                            PosGrid.Rows.Add(mgrRetriv.DataObject.GetDataTable.Rows(ii)("stckid"), CStr(mgrRetriv.DataObject.GetDataTable.Rows(ii)("barcode")), mgrRetriv.DataObject.GetDataTable.Rows(ii)("qty"), mgrRetriv.DataObject.GetDataTable.Rows(ii)("cost"), CStr(mgrRetriv.DataObject.GetDataTable.Rows(ii)("item_desc")), mgrRetriv.DataObject.GetDataTable.Rows(ii)("price"), mgrRetriv.DataObject.GetDataTable.Rows(ii)("det_amnt"), mgrRetriv.DataObject.GetDataTable.Rows(ii)("cost"), mgrRetriv.DataObject.GetDataTable.Rows(ii)("det_disc"), mgrRetriv.DataObject.GetDataTable.Rows(ii)("incentiv"), 1, 1)
                        Next
                        Dim Tots22 As Decimal = 0
                        Dim iii As Integer
                        For iii = 0 To PosGrid.Rows.Count - 1
                            Tots22 += CDec(PosGrid.Rows(iii).Cells(6).Value)
                        Next
                        txtCounts.Text = CStr(PosGrid.Rows.Count)
                        txtSum.Text = FormatNumber(Tots22, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots22))
                        CheckSumifNegative()
                        'This is a new code 02/21/2014
                        vpTotalSales = Tots22
                        Tots = Tots22
                        'End of New Code 02/21/2014
                        'End If
                        DGRetrieve.Visible = False
                    End If
                    'delete the records for the hdrtmp it will cascade delete the data on hdr_detiltmp
                    Dim delSusp As String = String.Empty
                    delSusp = "DELETE FROM pos_hdrtmp " 'WHERE postmp_hdrid=" & vCellVal
                    ExecuteSQLQuery(delSusp)
                    'mgrHdrTmp = New pos_hdrtmpManager()
                    'mgrHdrTmp.DataObject.DeleteByPK(vCellVal)

                Catch ex As PDSA.Validation.PDSAValidationException
                    MessageBox.Show(ex.Message)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try

            End If
        End If


        If e.KeyCode = Keys.Enter Then
            Dim vCellVal As Integer = 0
            Dim row As Integer = DGRetrieve.CurrentCellAddress.Y
            Dim column As Integer = DGRetrieve.CurrentCellAddress.X
            Dim col4 As vwSuspendedCollection

            If column > 1 Then
                MessageBox.Show("Please select the suspended sale on the first column or select the second column to Cancel Retrieval of Suspended Sale")
                Exit Sub
            End If

            If column = 0 Then ' this is the main code to be executed
                'MessageBox.Show(row.ToString + " " + column.ToString)
                vCellVal = CInt(DGRetrieve.CurrentCell.Value)
                Dim mgrRetriv As vwSuspendedManager
                Dim mgrHdrTmp As pos_hdrtmpManager

                Try
                    mgrRetriv = New vwSuspendedManager()
                    mgrRetriv.DataObject.WhereFilter = vwSuspendedData.WhereFilters.SuspendId
                    mgrRetriv.Entity.postmphdrid = vCellVal
                    'tbSQL.Text = mgrRetriv.DataObject.SQL
                    col4 = mgrRetriv.BuildCollection()
                    If mgrRetriv.DataObject.RowsAffected > 0 Then
                        'send the suspended value to POSGrid
                        'Dim mgrsend As vwSuspendedManager
                        'mgrsend = New vwSuspendedManager()
                        'mgrsend.DataObject.WhereFilter = vwSuspendedData.WhereFilters.SuspendId
                        'mgrsend.Entity.postmphdrid = vCellVal
                        'Dim col5 As vwSuspendedCollection
                        'col5 = mgrsend.BuildCollection()
                        'If mgrsend.DataObject.RowsAffected > 0 Then
                        For ii = 0 To mgrRetriv.DataObject.GetDataTable.Rows.Count - 1
                            PosGrid.Rows.Add(mgrRetriv.DataObject.GetDataTable.Rows(ii)("stckid"), CStr(mgrRetriv.DataObject.GetDataTable.Rows(ii)("barcode")), mgrRetriv.DataObject.GetDataTable.Rows(ii)("qty"), mgrRetriv.DataObject.GetDataTable.Rows(ii)("cost"), CStr(mgrRetriv.DataObject.GetDataTable.Rows(ii)("item_desc")), mgrRetriv.DataObject.GetDataTable.Rows(ii)("price"), mgrRetriv.DataObject.GetDataTable.Rows(ii)("det_amnt"), mgrRetriv.DataObject.GetDataTable.Rows(ii)("cost"), mgrRetriv.DataObject.GetDataTable.Rows(ii)("det_disc"), mgrRetriv.DataObject.GetDataTable.Rows(ii)("incentiv"), 1, 1)
                        Next
                        Dim Tots22 As Decimal = 0
                        Dim iii As Integer
                        For iii = 0 To PosGrid.Rows.Count - 1
                            Tots22 += CDec(PosGrid.Rows(iii).Cells(6).Value)
                        Next
                        txtCounts.Text = CStr(PosGrid.Rows.Count)
                        txtSum.Text = FormatNumber(Tots22, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots22))
                        CheckSumifNegative()
                        'This is a new code 02/21/2014
                        vpTotalSales = Tots22
                        Tots = Tots22
                        'End of New Code 02/21/2014
                        'End If
                        DGRetrieve.Visible = False
                    End If
                    'delete the records for the hdrtmp it will cascade delete the data on hdr_detiltmp
                    Dim delSusp As String = String.Empty
                    delSusp = "DELETE FROM pos_hdrtmp WHERE postmp_hdrid=" & vCellVal
                    ExecuteSQLQuery(delSusp)
                    'mgrHdrTmp = New pos_hdrtmpManager()
                    'mgrHdrTmp.DataObject.DeleteByPK(vCellVal)

                Catch ex As PDSA.Validation.PDSAValidationException
                    MessageBox.Show(ex.Message)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try

            End If





            btnBcode.PerformClick()

            If column = 1 Then
                DGRetrieve.Visible = False
                If vBarcodeOrItemSearch = True Then
                    txtBarcode.Text = String.Empty
                    txtBarcode.Focus()
                Else
                    txtitem.Text = String.Empty
                    txtitem.Focus()
                End If
            End If

            'Dim ays As Integer = 0
            'TotsRet = 0
            'For ays = 0 To PosGrid.Rows.Count - 1
            ' TotsRet += CDec(PosGrid.Rows(ays).Cells(6).Value)
            ' Next

            'txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots))
            'vpTotalSales = TotsRet
            'Tots = TotsRet
            'qtyy = 1
            'vpieces = 1

            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
        End If
    End Sub
    Sub Employees()
        Dim mgrEmpRetrieve As waitersManager
        Dim col33 As waitersCollection

        Try
            mgrEmpRetrieve = New waitersManager()
            mgrEmpRetrieve.DataObject.SelectFilter = waitersData.SelectFilters.ListBox
            'mgrEmpRetrieve.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            'mgrEmpRetrieve.Entity.status = False
            'tbSQL.Text = mgrRetrieve.DataObject.SQL
            col33 = mgrEmpRetrieve.BuildCollection()
            If mgrEmpRetrieve.DataObject.RowsAffected > 0 Then
                dgEmps.Visible = True
                dgEmps.Focus()
                dgEmps.DataSource = col33

            Else
                MessageBox.Show("No Current Cashier Names to Display")
                dgEmps.Visible = False
                'btnSearchItems.Focus()
                If vBarcodeOrItemSearch = True Then
                    txtBarcode.Text = String.Empty
                    txtBarcode.Focus()
                Else
                    txtitem.Text = String.Empty
                    txtitem.Focus()
                End If

            End If

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub TakePayments()
        MessageBox.Show("Payment Executed and Saved!")
        'txtBarcode.Focus()
        'btnSearchItems.Focus()
        ' txtitem.focus()
        If vBarcodeOrItemSearch = True Then
            txtBarcode.Text = String.Empty
            txtBarcode.Focus()
        Else
            txtitem.Text = String.Empty
            txtitem.Focus()
        End If
    End Sub
    Private Sub txtBarcode_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyUp
        If e.Alt = True And e.KeyCode = Keys.Tab Then
            e.Handled = True
        End If

        If e.Alt = True And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
    End Sub
    Private Sub leItems_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.Alt = True And e.KeyCode = Keys.Tab Then
            e.Handled = True
        End If

        If e.Alt = True And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
    End Sub

    Private Sub GridLookUpEdit2_Enter(sender As Object, e As EventArgs) Handles GridLookUpEdit2.Enter

    End Sub

    Private Sub GridLookUpEdit2_GotFocus(sender As Object, e As EventArgs) Handles GridLookUpEdit2.GotFocus

    End Sub
    'Private Sub GridLookUpEdit1_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.Alt = True And e.KeyCode = Keys.Tab Then
    '        e.Handled = True
    '    End If

    '    If e.Alt = True And e.KeyCode = Keys.F4 Then
    '        e.Handled = True
    '    End If
    '    If e.KeyCode = Keys.Left Then
    '    txtitem.Focus
    '        txtItem.Text = ""
    '    End If

    'End Sub

    'Private Sub GridLookUpEdit1_KeyPress(sender As Object, e As KeyPressEventArgs)

    '    If e.KeyChar = Chr(13) Then
    '        Try
    '            mgr6 = New stocksManager()
    '            mgr6.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey
    '            'MessageBox.Show(CType(leItems.EditValue, stocks))
    '            ' mgr6.DataObject.Entity.stckid = CInt(leCust.EditValue)

    '            col1 = mgr6.BuildCollection()

    '            If mgr6.DataObject.RowsAffected > 0 Then

    '                'DataGridView1.DataSource = col1 'mgr.BuildCollection()
    '                nProdID = mgr6.DataObject.Entity.stckid
    '                SendItemtoGrid3()

    '            End If

    '        Catch ex As PDSAValidationException
    '            MessageBox.Show(ex.Message)

    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    'Private Sub GridLookUpEdit1_KeyUp(sender As Object, e As KeyEventArgs)
    '    If e.Alt = True And e.KeyCode = Keys.Tab Then
    '        e.Handled = True
    '    End If

    '    If e.Alt = True And e.KeyCode = Keys.F4 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub GridLookUpEdit1_KeyDown1(sender As Object, e As KeyEventArgs)
    '    If e.Alt = True And e.KeyCode = Keys.Tab Then
    '        e.Handled = True
    '    End If

    '    If e.Alt = True And e.KeyCode = Keys.F4 Then
    '        e.Handled = True
    '    End If
    '    If e.KeyCode = Keys.Left Then
    '    txtitem.Focus
    '        txtItem.Text = ""
    '    End If

    'End Sub

    'Private Sub GridLookUpEdit1_KeyPress1(sender As Object, e As KeyPressEventArgs)
    '    If e.KeyChar = Chr(13) Then

    '    End If

    '    If e.KeyChar = Chr(13) Then
    '        Try
    '            mgr6 = New stocksManager()
    '            mgr6.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey
    '            ' 'MessageBox.Show(CType(leItems.EditValue, stocks))
    '            ' mgr6.DataObject.Entity.stckid = CInt(leCust.EditValue)

    '            col1 = mgr6.BuildCollection()

    '            If mgr6.DataObject.RowsAffected > 0 Then

    '                'DataGridView1.DataSource = col1 'mgr.BuildCollection()
    '                nProdID = mgr6.DataObject.Entity.stckid
    '                SendItemtoGrid3()

    '            End If

    '        Catch ex As PDSAValidationException
    '            MessageBox.Show(ex.Message)

    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    'Private Sub GridLookUpEdit1_KeyUp1(sender As Object, e As KeyEventArgs)
    '    If e.Alt = True And e.KeyCode = Keys.Tab Then
    '        e.Handled = True
    '    End If

    '    If e.Alt = True And e.KeyCode = Keys.5 Then
    '        e.Handled = True
    '    End If

    'End Sub

    'Private Sub GridLookUpEdit1_EditValueChanged_2(sender As Object, e As EventArgs) Handles GridLookUpEdit1.EditValueChanged

    'End Sub
    Private Sub GridLookUpEdit2_KeyDown(sender As Object, e As KeyEventArgs) Handles GridLookUpEdit2.KeyDown
        If e.Alt = True And e.KeyCode = Keys.Tab Then
            e.Handled = True
        End If

        If e.Alt = True And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
        If e.KeyCode = Keys.Left Then
            txtitem.Focus()
            txtitem.Text = ""
        End If
    End Sub

    Private Sub GridLookUpEdit2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GridLookUpEdit2.KeyPress

        If e.KeyChar = Chr(13) Then
            'LookupEditKeypress()
            ceQtyy.Focus()
        End If
    End Sub
    Private Sub LookupEditKeypress()

        txtqty.Text = ceQtyy.Text
        qtyy = 1 '  CInt(ceQtyy.Value)
        If vPricingMode = "Refund" Then
            qtyy = qtyy * -1
        Else
            qtyy = Math.Abs(qtyy * 1)
        End If

        'Call BarcodeSearch()

        'If vboolItemFound = True Then
        '    vboolItemFound = False
        '    Exit Sub
        'End If
        Try
            'If txtitem.Text = String.Empty Then
            '    MessageBox.Show("Please select an Item before pressing the enter key!")
            '    Exit Sub
            'End If



            mgr6 = New stocksManager()
            mgr6.DataObject.SelectFilter = stocksData.SelectFilters.positems
            mgr6.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey
            ' 'MessageBox.Show(CType(leItems.EditValue, stocks))
            mgr6.DataObject.Entity.stckid = nProdID ' vStckid 'CInt(GridLookUpEdit2.EditValue)

            col1 = mgr6.BuildCollection()

            If mgr6.DataObject.RowsAffected > 0 Then

                'DataGridView1.DataSource = col1 'mgr.BuildCollection()
                nProdID = mgr6.DataObject.Entity.stckid
                vincentives = mgr6.DataObject.Entity.incentive
                Dim vBoo As Boolean
                vBoo = CBool(mgr6.DataObject.Entity.active)
                vBoo = CBool(mgr6.DataObject.Entity.vat)

                'This is the code to send the discount to the Grid
                GetCategoryDiscount(nProdID)
                ' Now vCategoryID and vCategoryDiscount are populated
                MessageBox.Show("Category ID: " & vCategoryID & ", Category Discount: " & vCategoryDiscount.ToString("P"))

                'If mgr6.DataObject.Entity.incentive > 0 And ceWtid.Value = 1 Then
                '    'username = String.Empty
                '    'Try
                '    '    'Dim mgremp As New waitersManager()
                '    '    'Dim cols As New waitersCollection
                '    '    'mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword
                '    '    'Dim strIncentive As String = String.Empty
                '    '    'strIncentive = InputBox("Please Enter your Password.")

                '    '    'mgremp.Entity.pword = Trim(strIncentive)
                '    '    'cols = mgremp.BuildCollection()
                '    '    'If mgremp.DataObject.RowsAffected > 0 Then
                '    '    'ceWtid.Value = mgremp.DataObject.Entity.wtid
                '    '    'MessageBox.Show(CStr(mgremp.DataObject.Entity.waiter))
                '    '    'Else
                '    '    'MessageBox.Show("Not a valid password, try again.")
                '    '    'Exit Sub
                '    '    'End If
                '    'Catch ex As PDSAValidationException
                '    '    MessageBox.Show(ex.Message)
                '    'Catch ex As Exception
                '    '    MessageBox.Show(ex.ToString())
                '    'End Try
                'End If
                vboolItemFound = False
                SendItemtoGrid3()

            End If

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub BarcodeSearch()
        If Not String.IsNullOrEmpty(txtitem.Text) Then

            Try
                mgr = New stocksManager()
                mgr.DataObject.WhereFilter = stocksData.WhereFilters.barcode
                mgr.Entity.barcode = txtBarcode.Text.Trim
                'MessageBox.Show("Total Record Count is " & _
                'mgr.DataObject.RowCount().ToString())
                'tbSQL.Text = mgr.DataObject.SQL

                col1 = mgr.BuildCollection()


                If mgr.DataObject.RowsAffected > 0 Then

                    'DataGridView1.DataSource = col1 'mgr.BuildCollection()
                    nProdID = mgr.DataObject.Entity.stckid
                    'txtitem.Text = mgr.DataObject.Entity.itemdesc
                    'txtbcodes.Text = mgr.DataObject.Entity.barcode
                    'txtStckid.Text = CStr(mgr.DataObject.Entity.stckid)
                    'txtqty.Text = CStr(qtyy)
                    'SendItemtoGrid()
                    vboolItemFound = True
                    SendItemtoGrid3()

                End If

            Catch ex As PDSAValidationException
                MessageBox.Show(ex.Message)

                ' Catch ex As Exception
                'MsgBox(ex.Message.ToString())
                ' MessageBox.Show(ex.ToString())
            End Try
            'Else
            '    Try
            '        mgr2 = New stocksManager()

            '        mgr2.DataObject.WhereFilter = stocksData.WhereFilters.Likeitem
            '        mgr2.Entity.item = txtItem.Text.Trim()
            '        col1 = mgr2.BuildCollection()

            '        If mgr2.DataObject.RowsAffected > 0 Then

            '            'DataGridView1.DataSource = col1 'mgr.BuildCollection()
            '            cItem = mgr2.DataObject.Entity.item
            '            SendItemtoGrid()

            '        End If

            '    Catch ex As Exception
            '        'ex.Message.ToString()
            '    End Try

        End If
        txtitem.SelectAll()

    End Sub


    Sub ItemsearchExecute()
        Try
            mgr6 = New stocksManager()
            mgr6.DataObject.WhereFilter = stocksData.WhereFilters.PrimaryKey
            ' 'MessageBox.Show(CType(leItems.EditValue, stocks))
            mgr6.DataObject.Entity.stckid = CInt(txtStckid.Text)

            col1 = mgr6.BuildCollection()

            If mgr6.DataObject.RowsAffected > 0 Then

                'DataGridView1.DataSource = col1 'mgr.BuildCollection()
                nProdID = mgr6.DataObject.Entity.stckid
                SendItemtoGrid3()

            End If

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub GridLookUpEdit2_KeyUp(sender As Object, e As KeyEventArgs) Handles GridLookUpEdit2.KeyUp
        If e.Alt = True And e.KeyCode = Keys.Tab Then
            e.Handled = True
        End If

        If e.Alt = True And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If

    End Sub

    'Public Sub OpenCashdrawer()
    '    'Modify DrawerCode to your receipt printer open drawer code
    '    Dim DrawerCode As String = Chr(27) & Chr(112) & Chr(48) & Chr(64) & Chr(64)
    '    'Modify PrinterName to your receipt printer name
    '    Dim PrinterName As String = "EPSON TMU220"

    '    RawPrinter.PrintRaw(PrinterName, DrawerCode)
    'End Sub
    Sub TakePayment()

        payconfirm = False
        If PosGrid.Rows.Count < 1 Then
            MessageBox.Show("Sales Transaction is B l a n k.")
            Exit Sub
        End If
        Dim frmpay As New frmPayment
        frmpay.txtTotAmnt.Text = FormatNumber(txtSum.Text) 'FormatNumber(CStr(vpTotalSales)) ' FormatNumber(txtSum.Text)
        frmpay.ceTendered.Value = CDec(txtSum.Text) 'vpTotalSales 'Tots 'CDec(txtSum.Text)

        frmpay.txtChange.Text = "0"
        frmpay.ShowDialog()

        If payconfirm = True Then
            Save_Trans()
        End If

        ''txtTendered.Text = FormatNumber(CStr(frmPayment.ceTendered.Value)) 'vtendered
        ''lblChange.Text = FormatNumber(frmPayment.txtChange.Text) 'vchange
        btnnew.Focus()
    End Sub
    Public Sub Save_Trans()
        Dim vDiscountDivideByCount As Decimal = 0
        'Dim spBalUpdate As spBalanceupdateManager
        'Dim spAuditInv As spProductBalanceupdateandItemLedgerEntryManager

        ''Dim spItemLedger As spProductBalanceupdateandItemLedgerEntryManager


        If cmbPriceMode.Text = "" Then
            MessageBox.Show("Select Retail or Wholesale")
            cmbPriceMode.Focus()
            Exit Sub
        End If

        If PosGrid.Rows.Count < 0 Then
            MessageBox.Show("I t e m  L i s t  is  B l a n k")
            'btnSearchItems.Focus()

            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
            Exit Sub
        End If
        If cmbPaymentType.Text = "" Then
            MessageBox.Show("Select if the Payment type is Cash, Credit or Cheque.", "Payment Type", MessageBoxButtons.OK)
            cmbPaymentType.Focus()
            Exit Sub
        End If


        Try
            '+The code to Execute the Sequence operation
            Dim spGetReceiptNo As spGetReceiptNoManager
            Dim transpGetReceiptNo As PDSATransaction = New PDSATransaction()
            spGetReceiptNo = New spGetReceiptNoManager()
            transpGetReceiptNo.Add(spGetReceiptNo.DataObject)
            transpGetReceiptNo.Execute()
            'MessageBox.Show(spGetReceiptNo.DataObject.Entity.ReceiptNo.ToString)
            mOrderId2 = 0
            mOrderId2 = Convert.ToInt32(spGetReceiptNo.DataObject.Entity.ReceiptNo)




            Dim tran3 As PDSATransaction = New PDSATransaction()
            'Dim tran4 As PDSATransaction = New PDSATransaction()
            Tran4 = New PDSATransaction()

            Tran = New PDSATransaction()
            Tran2 = New PDSATransaction()
            'oht = New pos_hdrtmpManager()

            Dim myAL As New ArrayList
            Dim MyAl2 As New ArrayList

            'oht.DataObject.TransactionType = PDSATransactionType.Insert

            'Try
            oht = New pos_hdrtmpManager()
            oht.DataObject.TransactionType = PDSATransactionType.Insert
            If txtcustid.Text = "0" Then
                txtcustid.Text = "1"
            End If
            oht.Entity.custid = Convert.ToInt32(txtcustid.Text)
            oht.Entity.posdate = Date.Now
            oht.Entity.Receipt = mOrderId2
            oht.Entity.status = True

            'oht.Entity.totsales = Tots ' Convert.ToDecimal(txtSum.Text)
            oht.Entity.totsales = Convert.ToDecimal(txtSum.Text)
            'oht.Entity.totsales = Convert.ToDecimal(txtSum.Text)
            'vtotalsales 'vpTotalSales 'Tots
            oht.Entity.mowd = Convert.ToString(cmbPaymentType.Text)
            oht.Entity.disc = vdisc
            oht.Entity.discamnt = vdiscamnt
            oht.Entity.tendered = Convert.ToDecimal(vtendered)
            oht.Entity.Cheyns = Convert.ToDecimal(vchange)
            oht.Entity.tid = "t1"
            oht.Entity.wtid = CInt(ceWtid.Value)
            oht.Entity.trminal = 1
            oht.Entity.vatable = Vatable - vdiscamnt ' I added less vdiscamnt because vatable means less dicounts
            oht.Entity.nov = NonVatable
            oht.Entity.exempt = NonVatable
            oht.Entity.lesssc = SeniorDiscount

            Dim vlessvat As Decimal = 0
            vlessvat = CDec(Vatable / 1.12 * 0.12)
            oht.Entity.lessvat = vlessvat

            'gOT pUZZLED WHY I have 2 status so I commented it below , comment up if it is the right one
            'oht.Entity.status = False
            '*************
            oht.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            'oht.DataObject.TransactionType = PDSATransactionType.Insert

            ''Dim mOrderHeader As New pos_hdrtmp()
            ''Dim mOrderLine1 As New pos_dettmp()
            ''oh.Entity = mOrderHeader
            ''od1.Entity = mOrderLine1
            Tran.Add(oht.DataObject)
            'Tran.Execute()
            'Catch ex As PDSAValidationException
            '    MessageBox.Show(ex.Message)
            '    Exit Sub
            'Catch ex As Exception
            '    MessageBox.Show(ex.ToString())
            '    Exit Sub
            'End Try


            Dim vGridCounter As Integer = 0
            vTotalQtySold = 0
            For vGridCounter = 0 To PosGrid.Rows.Count - 1
                vTotalQtySold += CDec(PosGrid.Rows(vGridCounter).Cells(2).Value)
            Next


            vDiscountDivideByCount = vdiscamnt / vTotalQtySold

            grdCount = PosGrid.Rows.Count
            For ii = 0 To grdCount - 1
                odt1 = New pos_dettmpManager()
                odt1.DataObject.TransactionType = PDSATransactionType.Insert
                odt1.Entity.postmphdrid = mOrderId
                odt1.Entity.stckid = Convert.ToInt32(PosGrid.Rows(ii).Cells(0).Value)
                odt1.Entity.barcode = CStr(PosGrid.Rows(ii).Cells(1).Value)
                'odt1.Entity.itemdesc = CStr(PosGrid.Rows(ii).Cells(2).Value)
                odt1.Entity.cost = Convert.ToDecimal(PosGrid.Rows(ii).Cells(3).Value)
                odt1.Entity.price = Convert.ToDecimal(PosGrid.Rows(ii).Cells(5).Value)
                ' this is the orig code below, then next line is change to cells(7)
                'odt1.Entity.ws = Convert.ToDecimal(PosGrid.Rows(ii).Cells(6).Value)
                odt1.Entity.ws = Convert.ToDecimal(PosGrid.Rows(ii).Cells(7).Value)
                odt1.Entity.qty = Convert.ToDecimal(PosGrid.Rows(ii).Cells(2).Value) ' ModifyQty
                odt1.Entity.detamnt = Convert.ToDecimal(PosGrid.Rows(ii).Cells(6).Value) 'Convert.ToDecimal(PosGrid.Rows(ii).Cells(4).Value) * Convert.ToInt32(PosGrid.Rows(ii).Cells(5).Value)
                odt1.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
                'Comment May 22, 2024 .This is the code to get the discount for each item if there is an overall discount
                'If vdiscamnt > 0 Then
                '    odt1.Entity.detdisc = vDiscountDivideByCount * Convert.ToInt32(PosGrid.Rows(ii).Cells(2).Value)
                '    ' This is the percent discount (vdiscamnt / (vDiscountDivideByCount * Convert.ToInt32(PosGrid.Rows(ii).Cells(2).Value))) * 100 ' Comment Oct 12 2017 Dont Knopw why I got a code for disc here CShort(Convert.ToDecimal(PosGrid.Rows(ii).Cells(8).Value))
                'End If
                odt1.Entity.detdisc = Convert.ToDecimal(PosGrid.Rows(ii).Cells(12).Value)

                odt1.Entity.incentiv = Convert.ToDecimal(PosGrid.Rows(ii).Cells(9).Value)
                odt1.Entity.wtid = Convert.ToInt32(PosGrid.Rows(ii).Cells(10).Value)

                'myAL.Add(odt1.DataObject.Entity)
                Tran.Add(odt1.DataObject)
                'Tran2.Add(odt1.DataObject)
                'Tran2.Execute()
                'Tran2.RemoveAt(0)
            Next

            Tran.Execute()
            ceRefno.Value = mOrderId2

            'New Code Oct 24, 2023 to update first the point of the member
            'Comment or delete if anything goes wrong
            Dim PrevPointsEarned As Decimal = 0
            Dim qryPoints As String = String.Empty
            qryPoints = "SELECT pa FROM members where CustId=" & Convert.ToInt32(txtcustid.Text)
            Using reader1 As SqlDataReader = ExecuteSQLQueryReader(qryPoints)
                While reader1.Read()
                    PrevPointsEarned = reader1.GetDecimal(0)
                End While
            End Using

            Dim TotalPoints As Decimal = 0
            TotalPoints = Convert.ToDecimal(txtSum.Text) + PrevPointsEarned

            Dim strUpdateCustPoints As String = String.Empty
            strUpdateCustPoints = "UPDATE members SET pa=" & TotalPoints & " WHERE CustId=" & Convert.ToInt32(txtcustid.Text)
            ExecuteSQLQuery(strUpdateCustPoints)

            'Comment or delete if anything goes wrong above
            'End Of New code




            'Commented for TodaRaba Pharmacy (without Printer)
            'New Comment for Igorot Buying Station
            'Print only if Credit
            If MsgBox("Press Enter to Print, Press N or Click No To Cancel Printing", CType(MsgBoxStyle.Information + MsgBoxStyle.YesNo, MsgBoxStyle)) = MsgBoxResult.Yes Then
                Dim posrep As New xrReceiptTodaRaba()
                Dim posrepcredit As New xrPurchaseOrdr()
                If cmbPaymentType.Text = "CREDIT" Then

                    'AddHandler posrep.PrintingSystem.StartPrint, AddressOf Me.PrintingSystem_StartPrint
                    'posrep.DataSource = sqlDT
                    posrepcredit.Parameter1.Value = mOrderId2
                    posrepcredit.RequestParameters = False
                    posrepcredit.PrintingSystem.ShowMarginsWarning = False
                    posrepcredit.Print()


                    Dim posrepcredit2 As New xrPurchaseOrdr()
                    posrepcredit2.Parameter1.Value = mOrderId2
                    posrepcredit2.RequestParameters = False
                    posrepcredit2.PrintingSystem.ShowMarginsWarning = False
                    txtCounts.Text = "0"
                    posrepcredit2.Print()
                Else
                    posrep.Parameter1.Value = mOrderId2
                    posrep.RequestParameters = False
                    posrep.PrintingSystem.ShowMarginsWarning = False
                    txtCounts.Text = "0"
                    posrep.Print()

                End If
                ceRefno.Value = mOrderId2
            End If
            'End of Comment for TodaRaba Pharmacy (without Printer)
            'End If

            '********Commented it to display the values
            'txtSum.Text = "0"
            'ctotsalesvat.Value = 0
            'clessvat.Value = 0
            'cnosc.Value = 0
            'clesssc.Value = 0
            'camntnetvat.Value = 0
            'cvatablesales.Value = 0
            'cvatablexempt.Value = 0
            'cvatamnt.Value = 0
            'PosGrid.Rows.Clear()
            '******************* Uncomment if I want to clear values immediately
            ''btnBcode.PerformClick()
            'MessageBox.Show(CStr(mOrderId))
            'sqlSTR = "exec receiptpos @posid=" & mOrderId
            ' MessageBox.Show(sqlSTR)
            'sqlSTRR = "SELECT pos_hdrtmp.postmp_hdrid, pos_hdrtmp.pos_date, pos_hdrtmp.custid, pos_hdrtmp.pos_amnt, pos_hdrtmp.tendered, pos_hdrtmp.Cheyns,pos_hdrtmp.Sc, pos_hdrtmp.totsales, pos_hdrtmp.less_vat, pos_hdrtmp.nov, pos_hdrtmp.less_sc, pos_hdrtmp.vatable, pos_hdrtmp.exempt, pos_hdrtmp.vatamnt, pos_hdrtmp.tid, pos_hdrtmp.wtid, pos_dettmp.stckid, pos_dettmp.cost, pos_dettmp.price, pos_dettmp.qty, stocks.barcode, stocks.item_desc, tbls.tdesc, waiters.waiter FROM pos_hdrtmp INNER JOIN pos_dettmp ON pos_hdrtmp.postmp_hdrid = pos_dettmp.postmp_hdrid INNER JOIN stocks ON pos_dettmp.stckid = stocks.stckid INNER JOIN tbls ON pos_hdrtmp.tid = tbls.tid INNER JOIN waiters ON pos_hdrtmp.wtid = waiters.wtid"
            'ExecuteSQLQuery(sqlSTR)
            'Catch sqlex As SqlClient.SqlException When sqlex.Number = 1205
            '    MessageBox.Show("test")
            '    wait(1500)
            '    Save_Trans()
            '    Exit Sub

        Catch ex As PDSATransactionException
            'MessageBox.Show("Please press F12 to try again.", "Server Locked")
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Exit Sub
        End Try

        Call UpdateBalances()

        ''this is to execute the stored procedures
        ''Stored Proc 1
        'If cmbPaymentType.Text = "CREDIT" Then
        '    ceRefno.Value = mOrderId
        '    spBalUpdate = New spBalanceupdateManager()
        '    spBalUpdate.Entity.postmphdrid = mOrderId
        '    spBalUpdate.Entity.custid = CInt(txtcustid.Text)
        '    tran3.Add(spBalUpdate.DataObject)
        '    tran3.Execute()
        'End If
        ''ceRefno.Value = mOrderId
        ''Stored Proc 2
        'spAuditInv = New spProductBalanceupdateandItemLedgerEntryManager()
        'spAuditInv.Entity.postmphdrid = mOrderId
        'Tran4.Add(spAuditInv.DataObject)
        'Tran4.Execute()




        'Catch ex As PDSAValidationException
        '    MessageBox.Show(ex.Message)
        'Catch ex As PDSATransactionException
        '    MessageBox.Show(ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try
    End Sub

    Private Sub PrintingSystem_StartPrint(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.PrintDocumentEventArgs)
        e.PrintDocument.PrinterSettings.Copies = 2
    End Sub
    Private Sub UpdateBalances()
        Dim spBalUpdate As spBalanceupdateManager

        Try

            Dim tran5 As PDSATransaction = New PDSATransaction()

            If cmbPaymentType.Text = "CREDIT" Then
                ceRefno.Value = mOrderId
                spBalUpdate = New spBalanceupdateManager()
                spBalUpdate.Entity.postmphdrid = mOrderId
                spBalUpdate.Entity.custid = CInt(txtcustid.Text)
                tran5.Add(spBalUpdate.DataObject)
                tran5.Execute()
            End If

            Call UpdateBalances2()
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            'Call UpdateBalances()
            Exit Sub
        Catch ex As PDSATransactionException
            MessageBox.Show(ex.Message)
            'Call UpdateBalances()
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            'Call UpdateBalances()
            Exit Sub
        End Try

    End Sub
    Private Sub UpdateBalances2()

        Dim spAuditInv As spProductBalanceupdateandItemLedgerEntryManager
        Try
            Dim tran6 As PDSATransaction = New PDSATransaction()
            spAuditInv = New spProductBalanceupdateandItemLedgerEntryManager()
            spAuditInv.Entity.postmphdrid = mOrderId
            tran6.Add(spAuditInv.DataObject)
            tran6.Execute()

            Dim straqlUpdateCustName As String = String.Empty
            straqlUpdateCustName = "UPDATE members SET lastname='Cash' WHERE CustId=1"
            ExecuteSQLQuery(straqlUpdateCustName)
            straqlUpdateCustName = String.Empty
            straqlUpdateCustName = "UPDATE members SET firstname='Cash' WHERE CustId=1"
            ExecuteSQLQuery(straqlUpdateCustName)


            'This is the Original Code I commented on Oct 24, 2023 and copied it before printing the Receipt
            'to have an updated Points Earned Computation

            'Dim PrevPointsEarned As Decimal = 0
            'Dim qryPoints As String = String.Empty
            'qryPoints = "SELECT pa FROM members where CustId=" & Convert.ToInt32(txtcustid.Text)
            'Using reader1 As SqlDataReader = ExecuteSQLQueryReader(qryPoints)
            '    While reader1.Read()
            '        PrevPointsEarned = reader1.GetDecimal(0)
            '    End While
            'End Using

            'Dim TotalPoints As Decimal = 0
            'TotalPoints = Convert.ToDecimal(txtSum.Text) + PrevPointsEarned

            'Dim strUpdateCustPoints As String = String.Empty
            'strUpdateCustPoints = "UPDATE members SET pa=" & TotalPoints & " WHERE CustId=" & Convert.ToInt32(txtcustid.Text)
            'ExecuteSQLQuery(strUpdateCustPoints)
            'End of Comment Code Oct 24, 2023


            Dim frmpay As New frmTenderChange
            frmpay.ceTotal.Value = CDec(txtSum.Text) 'FormatNumber(CStr(vpTotalSales)) ' FormatNumber(txtSum.Text)
            frmpay.ceTendered.Value = CDec(txtTendered.Text) 'vpTotalSales 'Tots 'CDec(txtSum.Text)

            frmpay.ceChange.Value = CDec(lblChange.Text)
            frmpay.ShowDialog()


            'btnSaves.Enabled = True
            Call SaveTransButtons()
            'btnnew.Focus()
            'Automatically Call new transaction
            Call NewTransaction()


            DeleteSalesTemp2()

        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
            'Call UpdateBalances2()
            Exit Sub
        Catch ex As PDSATransactionException
            MessageBox.Show(ex.Message)
            'Call UpdateBalances2()
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            'Call UpdateBalances2()
            Exit Sub
        End Try
    End Sub


    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Public Sub LessDiscount()

        Dim computedamnt As Decimal = 0
        computedamnt = Tots - vdiscamnt
        txtCounts.Text = CStr(PosGrid.Rows.Count)
        txtSum.Text = FormatNumber(vtotalsales, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(vtotalsales))
        CheckSumifNegative()
        vpTotalSales = vtotalsales
    End Sub

    Sub NewTrans()
        Try
            If PosGrid.Rows.Count >= 1 Then
                If btnSaves.Enabled = True Then
                    MessageBox.Show("Sales Transaction is not yet paid!")
                    btnSaves.Focus()
                    Exit Sub
                End If
                txtSum.Text = "0"
                PosGrid.Rows.Clear()
                txtBarcode.Text = String.Empty
                txtitem.Text = String.Empty
                'txtTendered.Text = "0"
                'lblChange.Text = "0"
                ceWtid.Value = 1
                vtotalsales = 0
                vpTotalSales = 0
                txtcustid.Text = "1"
                txtqty.Text = "0"
                txtlastname.Text = "CASH"
                txtfirstname.Text = String.Empty
                btnSaves.Enabled = True
                btnPriceMode.Enabled = True
                btnType.Enabled = True
                btnSuspend.Enabled = True
                btnRetrieve.Enabled = True
                btnRemove.Enabled = True
                btnDiscount.Enabled = True
                Button1.Enabled = True ' this is the Set Quantity button
                btnCustomers.Enabled = True
                txtBarcode.Enabled = True
                btnSearchItems.Enabled = True
                btnReprint.Enabled = True
                txtbcodes.Text = String.Empty
                txtStckid.Text = String.Empty
                btnType.Enabled = True
                btnPriceMode.Enabled = True
                btnCustomers.Enabled = True
                btnSuspend.Enabled = True
                btnRetrieve.Enabled = True
                btnRemove.Enabled = True
                cmbPriceMode.Text = "Retail"
                cmbPaymentType.Text = "CASH"
                btnChequePayment.Enabled = True
                'GridLookUpEdit2.Enabled = True
                txtitem.Enabled = True


                'btnSearchItems.Focus()
                'txtitem.focus()
                txtitem.Text = String.Empty
                btnnew.Enabled = False
                If vBarcodeOrItemSearch = True Then
                    txtBarcode.Text = String.Empty
                    txtBarcode.Focus()
                Else
                    txtitem.Text = String.Empty
                    txtitem.Focus()
                End If
            Else
                ceWtid.Value = 1
                vtotalsales = 0
                vpTotalSales = 0
                txtBarcode.Enabled = True
                btnSearchItems.Enabled = True
                PosGrid.Enabled = True
                btnnew.Enabled = False
                btnSaves.Enabled = True
                btnType.Enabled = True
                btnPriceMode.Enabled = True
                btnCustomers.Enabled = True
                btnSuspend.Enabled = True
                btnRetrieve.Enabled = True
                btnRemove.Enabled = True
                'GridLookUpEdit2.Enabled = True
                txtitem.Enabled = True
                If vBarcodeOrItemSearch = True Then
                    txtBarcode.Text = String.Empty
                    txtBarcode.Focus()
                Else
                    txtitem.Text = String.Empty
                    txtitem.Focus()
                End If
            End If
            txtCounts.Text = "0"
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub SaveTransButtons()
        btnSaves.Enabled = False
        txtBarcode.Enabled = False
        btnSearchItems.Enabled = False
        btnPriceMode.Enabled = False
        btnType.Enabled = False
        btnSuspend.Enabled = False
        btnRetrieve.Enabled = False
        btnRemove.Enabled = False
        btnDiscount.Enabled = False
        Button1.Enabled = False ' this is the Set Quantity button
        btnCustomers.Enabled = False
        btnType.Enabled = False
        btnPriceMode.Enabled = False
        btnSuspend.Enabled = False
        btnRetrieve.Enabled = False
        btnRemove.Enabled = False
        GridLookUpEdit2.Enabled = False
        btnnew.Enabled = True
        btnnew.Focus()
    End Sub

    Sub OpenCustForm()
        Dim frmcust As New frmCustSearch
        '+I commented this so that the Cashier will select the Payment tye if it is cash or Credit-Default is Cash
        'cmbPaymentType.Text = "CREDIT"
        frmcust.ShowDialog()
        txtcustid.Text = CStr(frmcust.vCustid)
        txtlastname.Text = frmcust.vLname
        txtfirstname.Text = frmcust.vFname
        'txtBarcode.Focus()
        'btnSearchItems.Focus()
        'txtitem.Focus()
        If vBarcodeOrItemSearch = True Then
            txtBarcode.Text = String.Empty
            txtBarcode.Focus()
        Else
            txtitem.Text = String.Empty
            txtitem.Focus()
        End If
    End Sub

    Private Sub PosGrid_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles PosGrid.EditingControlShowing
        passcorrect = True
        'Dim frm As frmPasswordInput
        'frm = New frmPasswordInput
        ''frm.MdiParent = Me
        'frm.WindowState = FormWindowState.Normal
        'frm.ShowDialog()
        'frm = Nothing
        'ceWtid.Value = vEmpID

        If passcorrect = True Then
            'MessageBox.Show(CStr(ceWtid.Value))
            If (Me.PosGrid.CurrentCell.ColumnIndex = 4) Then
                If (TypeOf e.Control Is TextBox) Then
                    Dim tb As TextBox = CType(e.Control, TextBox)
                    AddHandler tb.KeyPress, AddressOf Me.tb_KeyPress
                End If
            End If
        End If
    End Sub
    Private Sub tb_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) Then
            Dim key As Keys = CType(AscW(e.KeyChar), Keys)
            If Not ((key = Keys.Back) _
                        OrElse (key = Keys.Delete)) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PosGrid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles PosGrid.CellValueChanged
        If PosGrid.Rows.Count > 0 Then
            Try

                Dim number As Decimal
                Dim result As Boolean = Decimal.TryParse(CStr(PosGrid.SelectedRows.Item(0).Cells(2).Value), number)
                Dim result2 As Boolean = Decimal.TryParse(CStr(PosGrid.SelectedRows.Item(0).Cells(5).Value), number)

                If result And result2 Then
                    'Console.WriteLine("Converted '{0}' to {1}.", CStr(PosGrid.SelectedRows.Item(0).Cells(5).Value), number)
                    If vCategoryDiscount > 0 Then
                        Dim sNewPrice As Decimal = 0
                        Dim sDiscount As Decimal = 0
                        Dim sSubTotal As Decimal = 0
                        Dim sQty As Decimal = 0
                        sQty = CDec(PosGrid.SelectedRows.Item(0).Cells(2).Value)
                        sDiscount = (CDec(CStr(PosGrid.SelectedRows.Item(0).Cells(5).Value)) * sQty) * vCategoryDiscount
                        sSubTotal = CDec(CStr(PosGrid.SelectedRows.Item(0).Cells(5).Value)) * sQty
                        sNewPrice = sSubTotal - sDiscount
                        PosGrid.SelectedRows.Item(0).Cells(6).Value = sNewPrice
                        PosGrid.SelectedRows.Item(0).Cells(12).Value = sDiscount
                    Else
                        PosGrid.SelectedRows.Item(0).Cells(6).Value = CDec(CStr(PosGrid.SelectedRows.Item(0).Cells(2).Value)) * CDec(CStr(PosGrid.SelectedRows.Item(0).Cells(5).Value))
                    End If

                    'If (dgvr.Cells(7).Value < dgvr.Cells(10).Value) Then
                    'dgvr.DefaultCellStyle.ForeColor = Color.Red
                    'End If
                    If CInt(PosGrid.SelectedRows.Item(0).Cells(2).Value) <= 0 Then
                        PosGrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Red
                    Else
                        PosGrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Black
                    End If

                    If CDec(PosGrid.SelectedRows.Item(0).Cells(5).Value) <= 0 Then
                        PosGrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Red
                    Else
                        PosGrid.SelectedRows.Item(0).DefaultCellStyle.ForeColor = Color.Black
                    End If

                    Dim Recompute As Decimal = 0
                    Dim aii As Integer = 0
                    For aii = 0 To PosGrid.Rows.Count - 1
                        Recompute += CDec(PosGrid.Rows(aii).Cells(6).Value)
                    Next
                    'CalcEdit1.Value = Totss
                    txtCounts.Text = CStr(PosGrid.Rows.Count)
                    txtSum.Text = FormatNumber(Recompute, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Recompute))
                    CheckSumifNegative()
                    vpTotalSales = Recompute

                Else
                    If CStr(PosGrid.SelectedRows.Item(0).Cells(5).Value) Is Nothing Then PosGrid.SelectedRows.Item(0).Cells(2).Value = 0
                    MessageBox.Show("W A R N I N G !!!!!! Price or Qty Must be Greater than Zero", CStr(PosGrid.SelectedRows.Item(0).Cells(5).Value))
                    PosGrid.SelectedRows.Item(0).Cells(2).Value = 0

                    Dim Recomputes As Decimal = 0
                    Dim aiii As Integer = 0
                    For aiii = 0 To PosGrid.Rows.Count - 1
                        Recomputes += CDec(PosGrid.Rows(aiii).Cells(6).Value)
                    Next
                    txtCounts.Text = CStr(PosGrid.Rows.Count)
                    txtSum.Text = FormatNumber(Recomputes, 2, , TriState.True, TriState.True) ' FormatNumber(CStr(Recomputes))
                    CheckSumifNegative()
                    vpTotalSales = Recomputes

                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If

    End Sub

    Sub RePrint()
        Try
            Dim posrep2 As New xrReprint()
            'posrep.DataSource = sqlDT
            posrep2.cashier.Value = PDSAAppConfig.CurrentLoginID
            posrep2.RequestParameters = True
            posrep2.PrintingSystem.ShowMarginsWarning = False
            posrep2.ShowPreview()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub PosGrid_DoubleClick(sender As Object, e As EventArgs) Handles PosGrid.DoubleClick
        Dim itemcount As Integer = 0
        itemcount = PosGrid.Rows.Count
        MessageBox.Show(CStr(itemcount), "Total Kinds of Items Bought")
    End Sub

    Private Sub btnSearchItems_Click(sender As Object, e As EventArgs) Handles btnSearchItems.Click
        If btnnew.Enabled = True Then
            txtTendered.Text = "0"
            lblChange.Text = "0"
            itemcnt = 0
            vdisc = 0
            vdiscamnt = 0
            NewTrans()
        End If

        Dim formitemserch As New frmItemSearch
        formitemserch.ShowDialog()
        txtitem.Text = String.Empty
        txtbcodes.Text = String.Empty
        txtStckid.Text = String.Empty
        txtitem.Text = formitemserch.vItem.ToString
        txtbcodes.Text = formitemserch.vbocde.ToString
        txtBarcode.Text = formitemserch.vbocde.ToString
        txtStckid.Text = formitemserch.vStckid.ToString
        'txtBarcode.SelectAll()
        If txtStckid.Text = String.Empty Then
            Exit Sub
        Else
            ItemsearchExecute()
        End If
        If vBarcodeOrItemSearch = True Then
            txtBarcode.Text = String.Empty
            txtBarcode.Focus()
        Else
            txtitem.Text = String.Empty
            txtitem.Focus()
        End If

    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Call OpenCustForm()
    End Sub

    Private Sub btnPriceMode_Click(sender As Object, e As EventArgs) Handles btnPriceMode.Click
        'If btnnew.Enabled = True Then
        '    MessageBox.Show("Click New Transaction First before selecting Wholesale or Retail.")
        '    btnnew.Focus()
        '    Exit Sub
        'End If
        ''Uncomment if the Client wants a password
        ''passcorrect = False
        ''Dim frm As frmPasswordInput
        ''frm = New frmPasswordInput
        '''frm.MdiParent = Me
        ''frm.WindowState = FormWindowState.Normal
        ''frm.ShowDialog()
        ''frm = Nothing

        ''If passcorrect = False Then
        ''    Exit Sub
        ''End If
        ''End Of Comment

        'If cmbPriceMode.Text = "Retail" Then
        '    cmbPriceMode.Text = "Wholesale"
        '    If vBarcodeOrItemSearch = True Then
        '        txtBarcode.Text = String.Empty
        '        txtBarcode.Focus()
        '    Else
        '        txtitem.Text = String.Empty
        '        txtitem.Focus()
        '    End If
        '    Exit Sub
        'End If


        'If cmbPriceMode.Text = "Wholesale" Then
        '    cmbPriceMode.Text = "Refund"

        '    'btnSearchItems.Focus()

        '    If vBarcodeOrItemSearch = True Then
        '        txtBarcode.Text = String.Empty
        '        txtBarcode.Focus()
        '    Else
        '        txtitem.Text = String.Empty
        '        txtitem.Focus()
        '    End If
        '    Exit Sub
        'End If

        passcorrect = False
        Dim frm As frmPasswordInput
        frm = New frmPasswordInput
        'frm.MdiParent = Me
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog()
        frm = Nothing

        If passcorrect = False Then
            Exit Sub
        End If

        If cmbPriceMode.Text = "Refund" Then
            cmbPriceMode.Text = "Retail"
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
            Exit Sub
        End If

    End Sub
    Private Sub btnCreditPay_Click(sender As Object, e As EventArgs) Handles btnCreditPay.Click
        Dim frmcp As New frmCreditPayment
        frmcp.ShowDialog()
        btnnew.Focus()
    End Sub

    Private Sub btnSaves_Click(sender As Object, e As EventArgs) Handles btnSaves.Click
        Dim vYesNo As Boolean = True
        Dim grdcountt As Integer = 0
        Dim iiiay As Integer = 0
        Dim I As Integer = 0
        Dim iCounter As Integer = 0
        Dim iiCounter As Integer = 0
        Dim vboolVAT As Integer
        ' compute the total for the recipt
        Tots = 0
        For I = 0 To PosGrid.Rows.Count - 1
            'MessageBox.Show(CStr(PosGrid.Rows.Count))
            Tots += CDec(PosGrid.Rows(I).Cells(6).Value)
        Next
        txtCounts.Text = CStr(PosGrid.Rows.Count)
        txtCounts.Text = CStr(PosGrid.Rows.Count)
        Vatable = 0
        NonVatable = 0
        For iCounter = 0 To PosGrid.Rows.Count - 1
            vboolVAT = CInt(PosGrid.Rows(iCounter).Cells(11).Value)
            If vboolVAT = 1 Then
                Vatable += CDec(PosGrid.Rows(iCounter).Cells(6).Value)
            End If
        Next
        iiCounter = 0
        For iiCounter = 0 To PosGrid.Rows.Count - 1
            ''MessageBox.Show(CStr(PosGrid.Rows.Count))
            'vboolVAT = CBool(PosGrid.Rows(iiCounter).Cells(9).Value)
            vboolVAT = CInt(PosGrid.Rows(iiCounter).Cells(11).Value)
            If vboolVAT = 0 Then
                NonVatable += CDec(PosGrid.Rows(iiCounter).Cells(6).Value)
            End If

        Next

        grdcountt = PosGrid.Rows.Count
        Try
            If cmbPaymentType.Text = "CREDIT" And txtcustid.Text = "1" Then
                MessageBox.Show("Change the payment type to CASH before collecting the payment or change a customer name because it is currently not charge to any customer")
                Exit Sub
            End If

            For iiiay = 0 To grdcountt - 1
                If CDec(PosGrid.Rows(iiiay).Cells(5).Value) <= 0 Then

                    ' Zero Price found
                    MessageBox.Show("There is an Item with a Price that is Not valid or less than 0.1")
                    vYesNo = False
                    'Exit For
                    Exit Sub
                End If
            Next

            If CDec(txtSum.Text) < 0 Then
                txtSum.Text = FormatNumber(Tots, 2, , TriState.False, TriState.False)
            End If

            If vYesNo = False Then
                Exit Sub
            End If
            If btnSaves.Enabled = False Then
                Exit Sub
            End If
            TakePayment()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnSuspend_Click(sender As Object, e As EventArgs) Handles btnSuspend.Click
        passcorrect = False
        Dim frm As frmPasswordInput
        frm = New frmPasswordInput
        'frm.MdiParent = Me
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog()
        frm = Nothing

        If passcorrect = False Then
            Exit Sub
        End If


        If PosGrid.Rows.Count > 0 Then
            Call SuspendTrans()
        Else

            MessageBox.Show("No items to Suspend")

            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
        End If
    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        'If PosGrid.Rows.Count > 1 Then
        '    MessageBox.Show("Pls. Finish or Cancel the existing sales transaction first before retrieving a suspended sales transaction")
        '    Exit Sub
        'End If
        passcorrect = False
        Dim frm As frmPasswordInput
        frm = New frmPasswordInput
        'frm.MdiParent = Me
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog()
        frm = Nothing

        If passcorrect = False Then
            Exit Sub
        End If

        Call RetrieveTrans()
    End Sub

    Private Sub btnType_Click(sender As Object, e As EventArgs) Handles btnType.Click
        passcorrect = False
        Dim frm As frmPasswordInput
        frm = New frmPasswordInput
        'frm.MdiParent = Me
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog()
        frm = Nothing

        If passcorrect = False Then
            Exit Sub
        End If
        Try
            If btnnew.Enabled = True Then
                MessageBox.Show("Click New Transaction First before selecting a payment type.")
                btnnew.Focus()
                Exit Sub
            End If

            If cmbPaymentType.Text = "CASH" Then
                cmbPaymentType.Text = "CREDIT"
                btnChequePayment.Enabled = True
                'btnSave.Focus()
                Call OpenCustForm()
                btnCustomers.Enabled = True
                If vBarcodeOrItemSearch = True Then
                    txtBarcode.Text = String.Empty
                    txtBarcode.Focus()
                Else
                    txtitem.Text = String.Empty
                    txtitem.Focus()
                End If
                Exit Sub
            End If
            If cmbPaymentType.Text = "CHEQUE" Then
                cmbPaymentType.Text = "CASH"
                'btnSave.Focus()
                btnChequePayment.Enabled = False
                btnCustomers.Enabled = True
                If vBarcodeOrItemSearch = True Then
                    txtBarcode.Text = String.Empty
                    txtBarcode.Focus()
                Else
                    txtitem.Text = String.Empty
                    txtitem.Focus()
                End If
                Exit Sub
            End If
            If cmbPaymentType.Text = "CREDIT" Then
                cmbPaymentType.Text = "CHEQUE"
                'btnSave.Focus()
                btnChequePayment.Enabled = False
                btnCustomers.Enabled = True
                If vBarcodeOrItemSearch = True Then
                    txtBarcode.Text = String.Empty
                    txtBarcode.Focus()
                Else
                    txtitem.Text = String.Empty
                    txtitem.Focus()
                End If
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub InputCustomerNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputCustomerNameToolStripMenuItem.Click
        vStrCustName = CStr(InputBox("Enter Customer Name", "Customer Name", vStrCustName))
        If vStrCustName <> "" Then
            Dim straqlUpdateCustName As String = String.Empty
            straqlUpdateCustName = "UPDATE members SET lastname='" & vStrCustName & "'" & " WHERE CustId=1"
            ExecuteSQLQuery(straqlUpdateCustName)
            straqlUpdateCustName = String.Empty
            straqlUpdateCustName = "UPDATE members SET firstname=' ' WHERE CustId=1"
            ExecuteSQLQuery(straqlUpdateCustName)
        End If
    End Sub

    Private Sub SalesForTodayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesForTodayToolStripMenuItem.Click
        Dim frm As frmSalestoday
        frm = New frmSalestoday
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub NewItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewItemToolStripMenuItem.Click
        Dim frm As frmNewItems
        frm = New frmNewItems
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub ReceiveStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveStockToolStripMenuItem.Click
        Dim frm As frmReceiveStokcs
        frm = New frmReceiveStokcs
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub TransferStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferStockToolStripMenuItem.Click
        Dim frm As frmTransferStock
        frm = New frmTransferStock
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub PosGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PosGrid.CellContentClick

    End Sub

    Private Sub DeliveryReceivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeliveryReceivingToolStripMenuItem.Click
        'frmDlvry.Show()
        Dim frm As frmDelivery
        frm = New frmDelivery
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub btnChequePayment_Click(sender As Object, e As EventArgs) Handles btnChequePayment.Click
        passcorrect = False
        Dim frm As frmPasswordInput
        frm = New frmPasswordInput
        'frm.MdiParent = Me
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog()
        frm = Nothing

        If passcorrect = False Then
            Exit Sub
        End If
        Try
            'cmbPaymentType.Text = "CHEQUE"
            ''If btnSaves.Enabled = True Then
            ''MessageBox.Show("Press F12 to Take Cheque Payment before entering the Cheque Details")
            ''    Exit Sub
            ''Else
            'MessageBox.Show("Press F12 after entering the Cheque Payment Details")
            'Dim frm As New frmCheque
            'frm.ShowDialog()
            'btnnew.Focus()
            ''End If


            If PosGrid.Rows.Count > 0 Then
                MessageBox.Show("Cannot retrieve saved sales if there is an existing items on the Item List.")
                Exit Sub
            End If

            ' Retrieve records from the SalesTemp table with the Cashier filter
            Dim connectionString As String = "Data Source=DOORSCOMPUTERS\SQLEXPRESS;Initial Catalog=doorspos;Integrated Security=True"
            Dim query As String = "SELECT [ProdId], [Barcode], [Quantity], [Cost], [Item], [Price], [Vatabol], [Incentv] FROM [dbo].[SalesTemp] WHERE [Cashier] = @currentLoginID"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    ' Set the parameter value
                    command.Parameters.AddWithValue("@currentLoginID", PDSAAppConfig.CurrentLoginID)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Retrieve the column values from the SqlDataReader
                            Dim ProdId As Integer = reader.GetInt32(0)
                            Dim Barcode As String = reader.GetString(1)
                            Dim Quantity As Double = reader.GetDouble(2)
                            Dim Cost As Decimal = reader.GetDecimal(3)
                            Dim Item As String = reader.GetString(4)
                            Dim Price As Decimal = reader.GetDecimal(5)
                            Dim Vatabol As Integer = reader.GetInt32(6)
                            Dim Incentv As Double = reader.GetDouble(7)

                            ' Add a new row to the PosGrid with the retrieved values
                            PosGrid.Rows.Add(ProdId, Barcode, Quantity, Cost, Item, Price, Price, Price, Vatabol, Incentv, Incentv, Vatabol)
                        End While
                    End Using
                End Using
            End Using
            txtBarcode.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        VoidItem()
    End Sub
    Private Sub VoidItem()
        'Uncomment if the Client wants a password
        passcorrect = False
        Dim frm As frmPasswordInput
        frm = New frmPasswordInput
        'frm.MdiParent = Me
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog()
        frm = Nothing

        If passcorrect = False Then
            Exit Sub
        End If
        'End of Comment
        If PosGrid.Rows.Count = 0 Then
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
            Exit Sub
        End If


        DeleteSalesTemp()

        Dim Totss As Decimal = 0
        Dim ii As Integer
        Dim mgrvoid As posVoidManager
        Dim voidtrans As PDSATransaction
        Dim voidsp As PDSATransaction
        Dim mgrspvoid As procpdsaTableIds_GetMaxIDManager = New procpdsaTableIds_GetMaxIDManager()
        Try

            If PosGrid.SelectedRows.Count = 0 Then
                Exit Sub
            End If
            voidsp = New PDSATransaction()
            voidtrans = New PDSATransaction()
            mgrvoid = New posVoidManager()
            mgrspvoid.Entity.sFieldName = "voidid"
            mgrspvoid.Entity.sTableName = "posVoid"


            Dim dgvrowint As Integer = 0
            dgvrowint = Convert.ToInt32(PosGrid.CurrentRow.Index.ToString)
            ii = Convert.ToInt32(PosGrid.CurrentRow.Index.ToString)
            'save selected item that is removed
            mgrvoid.Entity.voidid = mgrspvoid.Entity.RETURNVALUE + 1
            mgrvoid.Entity.stckid = Convert.ToInt32(PosGrid.SelectedRows(0).Cells(0).Value) 'Convert.ToInt32(PosGrid.Rows(ii).Cells(0).Value)
            mgrvoid.Entity.barcode = CStr(PosGrid.SelectedRows(0).Cells(1).Value)  ' CStr(PosGrid.Rows(ii).Cells(1).Value)
            mgrvoid.Entity.cost = Convert.ToDecimal(PosGrid.SelectedRows(0).Cells(3).Value) 'Convert.ToDecimal(PosGrid.Rows(ii).Cells(3).Value)
            mgrvoid.Entity.price = Convert.ToDecimal(PosGrid.SelectedRows(0).Cells(5).Value)
            mgrvoid.Entity.qty = Convert.ToInt32(PosGrid.SelectedRows(0).Cells(2).Value)
            'mgrvoid.Entity.detamnt = Convert.ToDecimal(PosGrid.Rows(ii).Cells(4).Value) * Convert.ToInt32(PosGrid.Rows(ii).Cells(5).Value)
            mgrvoid.Entity.sInsertid = PDSAAppConfig.CurrentLoginID
            voidtrans.Add(mgrvoid.DataObject)
            voidtrans.Execute()

            PosGrid.Rows.Remove(PosGrid.SelectedRows(0))
            For ii = 0 To PosGrid.Rows.Count - 1
                Totss += CDec(PosGrid.Rows(ii).Cells(6).Value)
            Next
            'CalcEdit1.Value = Totss
            txtCounts.Text = CStr(PosGrid.Rows.Count)
            txtSum.Text = FormatNumber(Totss, 2, , TriState.True, TriState.True)  'FormatNumber(CStr(Totss))
            CheckSumifNegative()
            vpTotalSales = Totss
            'TextEdit1.Text = FormatCurrency(CStr(Totss))
            btnBcode.PerformClick()
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
        Catch ex As PDSAValidationException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub btnReprint_Click(sender As Object, e As EventArgs) Handles btnReprint.Click
        'RePrint()
        ''txtBarcode.Focus()
        ''btnSearchItems.Focus()
        ''txtitem.focus()
        'txtitem.Text = String.Empty
        'txtBarcode.Focus()
        passcorrect = False
        Dim frm As frmPasswordInput
        frm = New frmPasswordInput
        'frm.MdiParent = Me
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog()
        frm = Nothing

        If passcorrect = False Then
            Exit Sub
        End If

        vSalesNum = 0
        vSalesNum = CInt(InputBox("Enter the sales number to be printed", "Reprint", CStr(ceRefno.Text)))
        Dim posrep As New xrReceiptTodaRaba()
        'posrep.DataSource = sqlDT
        posrep.Parameter1.Value = vSalesNum
        posrep.RequestParameters = False
        posrep.PrintingSystem.ShowMarginsWarning = False
        posrep.Print()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToLongTimeString()

        If cmbPriceMode.Text = "Wholesale" Or cmbPriceMode.Text = "Refund" Then
            If cmbPriceMode.ForeColor = Color.Black Then
                cmbPriceMode.ForeColor = Color.Red
            Else
                cmbPriceMode.ForeColor = Color.Black
            End If
        End If

        If cmbPaymentType.Text = "CREDIT" Or cmbPaymentType.Text = "CHEQUE" Then
            If cmbPaymentType.ForeColor = Color.Black Then
                cmbPaymentType.ForeColor = Color.Red
            Else
                cmbPaymentType.ForeColor = Color.Black
            End If

        End If

    End Sub

    Private Sub btnLookuprice_Click(sender As Object, e As EventArgs) Handles btnLookuprice.Click
        Dim frm As New frmPriceLookup2
        frm.Show()
        If vBarcodeOrItemSearch = True Then
            txtBarcode.Text = String.Empty
            txtBarcode.Focus()
        Else
            txtitem.Text = String.Empty
            txtitem.Focus()
        End If
    End Sub

    Private Sub btnPickup_Click(sender As Object, e As EventArgs) Handles btnPickup.Click
        'Uncomment If the Client wants a password
        passcorrect = False
        Dim frm3 As frmPasswordInput
        frm3 = New frmPasswordInput
        'frm.MdiParent = Me
        frm3.WindowState = FormWindowState.Normal
        frm3.ShowDialog()
        frm3 = Nothing

        If passcorrect = False Then
            Exit Sub
        End If
        'End Of Comment


        Try
            Dim frm As New frmPickup
            frm.ShowDialog()
            If btnnew.Enabled = True Then
                btnnew.Focus()
            Else
                If vBarcodeOrItemSearch = True Then
                    txtBarcode.Text = String.Empty
                    txtBarcode.Focus()
                Else
                    txtitem.Text = String.Empty
                    txtitem.Focus()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        '    Dim formQty As New frmQty
        '    formQty.ShowDialog()
        '    'txtBarcode.Focus()
        '    'btnSearchItems.Focus()
        '    txtitem.Text=String.Empty
        '    txtitem.focus()
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try
        passcorrect = False
        Dim frm As frmPasswordInput
        frm = New frmPasswordInput
        'frm.MdiParent = Me
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog()
        frm = Nothing

        If passcorrect = False Then
            Exit Sub
        End If


        SetQuantity()

    End Sub
    Friend Sub SetQuantity()
        Try
            If PosGrid.Rows.Count >= 1 Then
                Dim formQty As New frmQty
                formQty.ShowDialog()
                ''txtBarcode.Focus()
                ''btnSearchItems.Focus()
                If cmbPriceMode.Text = "Refund" Then
                    vpieces = vpieces * -1
                End If

                'this is the original Code below
                'PosGrid.Rows(PosGrid.RowCount - 1).Cells(2).Value = vpieces
                'this is the original Code above
                Dim vvvStockID As Integer = 0
                Dim connectionString As String = "Server=DOORSCOMPUTERS\SQLEXPRESS;Database=doorspos;Trusted_Connection=True;"
                Dim sql As String = "SELECT retail, retail2 FROM stocks WHERE stckid=" & CInt(PosGrid.SelectedRows(0).Cells(0).Value) & ""
                Dim CurrentLoginID As String = PDSAAppConfig.CurrentLoginID
                Dim vNewPrice As Decimal = 0
                Dim ProdId As Integer = CInt(PosGrid.SelectedRows(0).Cells(0).Value)

                vCategoryDiscount = 0
                vCategoryDiscountAmount = 0
                vCategoryID = 0
                vDiscountedAmount = 0
                GetCategoryDiscount(ProdId)
                If vCategoryDiscount > 0 Then
                    vCategoryDiscountAmount = (CDec(PosGrid.SelectedRows(0).Cells(5).Value) * vpieces) * vCategoryDiscount
                    vDiscountedAmount = (CDec(PosGrid.SelectedRows(0).Cells(5).Value) * vpieces) - vCategoryDiscountAmount
                    vNewPrice = vDiscountedAmount
                Else
                    vNewPrice = CDec(PosGrid.SelectedRows(0).Cells(5).Value) * vpieces
                End If




                Dim connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(sql, connection)

                connection.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()
                Dim retail As Double = 0
                Dim retail2 As Double = 0
                If reader.HasRows Then
                    reader.Read()
                    retail = CDbl(reader("retail"))
                    retail2 = CDbl(reader("retail2"))
                Else
                    retail = 0
                    retail2 = 0
                    MessageBox.Show("No records found. Retail: " & retail & ", Retail2: " & retail2)
                End If

                connection.Close()


                If vpieces >= nQtyWholesale Then
                    PosGrid.SelectedRows(0).Cells(2).Value = vpieces
                    PosGrid.SelectedRows(0).Cells(5).Value = retail2
                Else
                    PosGrid.SelectedRows(0).Cells(2).Value = vpieces
                    PosGrid.SelectedRows(0).Cells(5).Value = retail
                End If

                'PosGrid.Rows.Remove(PosGrid.SelectedRows(0))

                ''Me.PosGrid.Rows(Me.PosGrid.RowCount - 1).Selected = True
                txtitem.Text = String.Empty
                'txtitem.Focus()


                'Newly added code to re compute the totals
                Dim IAyI As Integer = 0
                Tots = 0
                For IAyI = 0 To PosGrid.Rows.Count - 1
                    Tots += CDec(PosGrid.Rows(IAyI).Cells(6).Value)
                Next

                txtCounts.Text = CStr(PosGrid.Rows.Count)

                'Scroll to the last row.
                Me.PosGrid.FirstDisplayedScrollingRowIndex = Me.PosGrid.RowCount - 1

                'Select the last row.
                Me.PosGrid.Rows(Me.PosGrid.RowCount - 1).Selected = True

                'CalcEdit1.Value = Tots
                txtCounts.Text = CStr(PosGrid.Rows.Count)
                txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots))
                CheckSumifNegative()
                vpTotalSales = Tots
                'End of newly added code

                'Update SalesTemp



                ' Create a SQL connection
                Dim connectionString2 As String = "Data Source=DOORSCOMPUTERS\SQLEXPRESS;Initial Catalog=doorspos;Integrated Security=True"
                Using connection2 As New SqlConnection(connectionString)
                    connection2.Open()

                    ' Create a SQL command to update the Quantity field
                    Dim query2 As String = "UPDATE [dbo].[SalesTemp] SET Quantity = @vpieces, Amount=@Amount WHERE ProdId = @ProdId AND Cashier = @CurrentLoginID"
                    Using command2 As New SqlCommand(query2, connection2)
                        ' Set the parameter values
                        command2.Parameters.AddWithValue("@vpieces", vpieces)
                        command2.Parameters.AddWithValue("@Amount", vNewPrice)
                        command2.Parameters.AddWithValue("@ProdId", ProdId)
                        command2.Parameters.AddWithValue("@CurrentLoginID", CurrentLoginID)

                        ' Execute the SQL command to update the Quantity field
                        command2.ExecuteNonQuery()
                    End Using
                End Using
                'End of Update Sales Temp
                qtyy = 1
                vpieces = 1

                If vBarcodeOrItemSearch = True Then
                    txtBarcode.Text = String.Empty
                    txtBarcode.Focus()
                Else
                    txtitem.Text = String.Empty
                    txtitem.Focus()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Sub PriceOverride()
        Try
            If PosGrid.Rows.Count >= 1 Then
                vPriceChange = CDec(PosGrid.SelectedRows(0).Cells(5).Value)
                Dim formChangePrice As New frmNewPrice
                formChangePrice.ShowDialog()
                'If cmbPriceMode.Text = "Refund" Then
                '    vpieces = vpieces * -1
                'End If

                'this is the original Code below
                'PosGrid.Rows(PosGrid.RowCount - 1).Cells(2).Value = vpieces
                'this is the original Code above

                PosGrid.SelectedRows(0).Cells(5).Value = vPriceChange
                'PosGrid.Rows.Remove(PosGrid.SelectedRows(0))

                ''Me.PosGrid.Rows(Me.PosGrid.RowCount - 1).Selected = True
                txtitem.Text = String.Empty
                'txtitem.Focus()


                'Newly added code to re compute the totals
                Dim IAyI As Integer = 0
                Tots = 0
                For IAyI = 0 To PosGrid.Rows.Count - 1
                    Tots += CDec(PosGrid.Rows(IAyI).Cells(6).Value)
                Next

                txtCounts.Text = CStr(PosGrid.Rows.Count)

                'Scroll to the last row.
                Me.PosGrid.FirstDisplayedScrollingRowIndex = Me.PosGrid.RowCount - 1

                'Select the last row.
                Me.PosGrid.Rows(Me.PosGrid.RowCount - 1).Selected = True

                'CalcEdit1.Value = Tots
                txtCounts.Text = CStr(PosGrid.Rows.Count)
                txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots))
                CheckSumifNegative()
                vpTotalSales = Tots
                'TextEdit1.Text = FormatCurrency(CStr(Tots))
                qtyy = 1
                vpieces = 1
                'End of newly added code
                If vBarcodeOrItemSearch = True Then
                    txtBarcode.Text = String.Empty
                    txtBarcode.Focus()
                Else
                    txtitem.Text = String.Empty
                    txtitem.Focus()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnAddCash_Click(sender As Object, e As EventArgs) Handles btnAddCash.Click
        'Uncomment If the Client wants a password
        passcorrect = False
        Dim frm2 As frmPasswordInput
        frm2 = New frmPasswordInput
        'frm.MdiParent = Me
        frm2.WindowState = FormWindowState.Normal
        frm2.ShowDialog()
        frm2 = Nothing

        If passcorrect = False Then
            Exit Sub
        End If
        'End Of Comment

        Try
            Dim frm As New frmAddtnlCash
            frm.ShowDialog()
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnDiscount_Click(sender As Object, e As EventArgs) Handles btnDiscount.Click
        If PosGrid.Rows.Count = 0 Or btnnew.Enabled = True Then
            MessageBox.Show("Item List is Blank!")
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
            Exit Sub
        End If



        'Recalculate the total on the Grid and post it on txtsum before applying any discount
        Dim I As Integer = 0
        Tots = 0
        For I = 0 To PosGrid.Rows.Count - 1
            Tots += CDec(PosGrid.Rows(I).Cells(6).Value)
        Next

        txtCounts.Text = CStr(PosGrid.Rows.Count)
        txtSum.Text = FormatNumber(Tots, 2, , TriState.False, TriState.True) ' FormatNumber(CStr(Tots))
        CheckSumifNegative()
        vpTotalSales = Tots



        If PosGrid.Rows.Count = 0 Or btnnew.Enabled = True Then
            MessageBox.Show("Item List is Blank!")
            txtBarcode.Focus()
            Exit Sub
        End If


        'Comment if the Client does not want a password
        passcorrect = False
        Dim frm As frmPasswordInput
        frm = New frmPasswordInput
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog()
        frm = Nothing

        If passcorrect = False Then
            Exit Sub
        End If
        'End of Comment



        'Dim ansint As Integer = 7
        'ansint = MsgBox("Click Yes for Regular Discount or No for Gov't Discount", MsgBoxStyle.YesNo, "Discount Confirmation")
        'If ansint = 6 Then
        Call RegularDiscount()
        'End If




        'Dim TotsBeforeDisc As Decimal = 0
        'Tots = 0
        'SeniorDiscount = 0
        'vdiscamnt = 0
        'Dim i As Integer = 0
        'For i = 0 To PosGrid.Rows.Count - 1
        '    Tots += CDec(PosGrid.Rows(i).Cells(6).Value)
        'Next
        '' txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True) 'FormatNumber(CStr


        'txtSum.Text = FormatNumber(Tots, 2, , TriState.True, TriState.True)
        'TotsBeforeDisc = CDec(CDec(Tots / 1.12) * 0.8)
        'SeniorDiscount = CDec(CDec(Tots / 1.12) * 0.2)
        'vdiscamnt = Tots - TotsBeforeDisc
        'txtSum.Text = FormatNumber(TotsBeforeDisc, 2, , TriState.True, TriState.True) 'FormatNumber(CStr(Tots22))
        'If vBarcodeOrItemSearch = True Then
        '    txtBarcode.Text = String.Empty
        '    txtBarcode.Focus()
        'Else
        '    txtitem.Text = String.Empty
        '    txtitem.Focus()
        'End If
        'txtBarcode.SelectAll()
        'Exit Sub


    End Sub
    Sub RegularDiscount()
        'passcorrect = True
        If passcorrect = True Then
            vdiscamnt = 0
            SeniorDiscount = 0
            Dim vdetdisc As Decimal = 0 ' this is the discount computed per item that was divided from the vdiscamnt variable to the total itemcount which is vItemCount
            Dim ayayay As Integer = 0
            For ayayay = 0 To PosGrid.Rows.Count - 1
                PosGrid.Rows(ayayay).Cells(8).Value = 0
            Next

            'If btnSaves.Enabled = False Then
            '    MessageBox.Show("Discount is not allowed if Sales Transaction is already paid.")
            '    Exit Sub
            'End If
            If PosGrid.Rows.Count < 1 Then
                MessageBox.Show("Item List is  B l a n k")
                Exit Sub
            End If

            'Recalculate the total on the Grid and post it on txtsum before applying any discount
            Dim I As Integer = 0
            Tots = 0
            For I = 0 To PosGrid.Rows.Count - 1
                Tots += CDec(PosGrid.Rows(I).Cells(6).Value)
            Next

            txtCounts.Text = CStr(PosGrid.Rows.Count)
            txtSum.Text = FormatNumber(Tots, 2, , TriState.False, TriState.True) ' FormatNumber(CStr(Tots))
            CheckSumifNegative()
            vpTotalSales = Tots



            Try
                Dim percentamnt As Decimal = 0
                vdisc = 0
                vdiscamnt = 0
                vtotalsales = Tots 'CDec(txtSum.Text) My New Comments 12 21 13
                'vpTotalSales = CDec(txtSum.Text) My New Comments 12 21 13
                txtCounts.Text = CStr(PosGrid.Rows.Count)
                Dim frmdisc As New frmDiscount
                frmdisc.ShowDialog()
                txtSum.Text = FormatNumber(vtotalsales, 2, , TriState.False, TriState.True) 'FormatNumber(CStr(vtotalsales))
                CheckSumifNegative()

                If vtotalsales = 0 Then
                    txtSum.Text = FormatNumber(Tots, 2, , TriState.False, TriState.True) 'FormatNumber(CStr(Tots))
                    CheckSumifNegative()
                    vpTotalSales = Tots
                End If


                Dim vItemCount As Integer = 0
                Dim ay As Integer = 0
                For ay = 0 To PosGrid.Rows.Count - 1
                    vItemCount += CInt(PosGrid.Rows(ay).Cells(5).Value)
                Next

                txtCounts.Text = CStr(PosGrid.Rows.Count)
                txtSum.Text = FormatNumber(vtotalsales, 2, , TriState.False, TriState.True) 'FormatNumber(CStr(vtotalsales))
                CheckSumifNegative()
                txtitem.Text = String.Empty
                txtitem.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub
    Private Sub CheckSumifNegative()
        If CDec(txtSum.Text) < 0 Then
            txtSum.ForeColor = Color.Red
        Else
            txtSum.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click

        'Try

        '    txtTendered.Text = "0"
        '    lblChange.Text = "0"
        '    itemcnt = 0
        '    vdisc = 0
        '    vdiscamnt = 0
        '    NewTrans()
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString())
        'End Try
        Call NewTransaction()
    End Sub

    Sub NewTransaction()
        Try
            itemcnt = 0
            vdisc = 0
            vdiscamnt = 0
            SeniorDiscount = 0
            vEmpID = 1
            nWS = 0
            nRP = 0
            nQtyWholesale = 100
            'txtTendered.Text = "0"
            NewTrans()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnBcode_Click(sender As Object, e As EventArgs) Handles btnBcode.Click
        Try
            If Not String.IsNullOrEmpty(txtBarcode.Text) Then
                txtBarcode.SelectAll()
            End If
            '' leCust.EditValue = vbNullString
            ''leItems.EditValue = vbNullString
            'txtBarcode.Text = ""
            'txtBarcode.Focus()
            BCodeFocus()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnRefund_Click(sender As Object, e As EventArgs) Handles btnRefund.Click
        'Uncomment If the Client wants a password
        passcorrect = False
        Dim frm As frmPasswordInput
        frm = New frmPasswordInput
        'frm.MdiParent = Me
        frm.WindowState = FormWindowState.Normal
        frm.ShowDialog()
        frm = Nothing

        If passcorrect = False Then
            Exit Sub
        End If
        'End Of Comment

        If btnnew.Enabled = False Then
            cmbPriceMode.Text = "Refund"
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
        End If
    End Sub


    Private Sub dgEmps_KeyDown(sender As Object, e As KeyEventArgs) Handles dgEmps.KeyDown

        If e.KeyCode = Keys.Enter Then
            vCellValIncent = 0
            Dim row As Integer = dgEmps.CurrentCellAddress.Y
            Dim column As Integer = dgEmps.CurrentCellAddress.X
            'Dim col4 As waitersCollection

            If column > 1 Then
                MessageBox.Show("Please select Employee Name for the Incentive Amount")
                Exit Sub
            End If

            If column = 0 Then ' this is the main code to be executed
                MessageBox.Show(row.ToString + " " + column.ToString)
                vCellValIncent = CInt(dgEmps.CurrentCell.Value)
                'Dim mgrRetrivEmp As waitersManager

                Try
                    '   mgrRetrivEmp = New waitersManager()
                    '   mgrRetrivEmp.DataObject.WhereFilter = waitersData.WhereFilters.PrimaryKey
                    '  mgrRetrivEmp.Entity.wtid = vCellVal

                    'col4 = mgrRetrivEmp.BuildCollection()
                    'If mgrRetrivEmp.DataObject.RowsAffected > 0 Then
                    'ceWtid.Value = mgrRetrivEmp.DataObject.Entity.wtid
                    ceWtid.Value = vCellValIncent
                    Me.Text = "Inventory and Sales Monitoring System" + CStr(dgEmps.CurrentCell.Value)
                    dgEmps.Visible = False
                    'End If

                Catch ex As PDSA.Validation.PDSAValidationException
                    MessageBox.Show(ex.Message)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try

            End If

            If column = 1 Then
                dgEmps.Visible = False
            End If

        End If
    End Sub

    Private Sub ceQtyy_GotFocus(sender As Object, e As EventArgs) Handles ceQtyy.GotFocus
        'ceQtyy.Value = 1
        ceQtyy.SelectAll()
    End Sub

    Private Sub ceQtyy_KeyDown(sender As Object, e As KeyEventArgs) Handles ceQtyy.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ceQtyy.Value = 0 Then
                MessageBox.Show("Qty Sold cannot be equal to Zero!")
                Exit Sub
            End If
            If cmbPriceMode.Text = "Refund" Then
                ceQtyy.Value = ceQtyy.Value * -1
            End If

            txtqty.Text = ceQtyy.Text
            qtyy = CInt(ceQtyy.Value)
            LookupEditKeypress()
            'ItemsearchExecute()

        End If
    End Sub
    Sub SendItemImmediately()
        ''If e.KeyCode = Keys.Enter Then
        'If ceQtyy.Value = 0 Then
        '    MessageBox.Show("Qty Sold cannot be equal to Zero!")
        '    Exit Sub
        'End If
        ' ''Commented this because it will make it positive because I already validated it on the send itemstogrid, that when it is refund then it will multip;y to neg 1
        ''If cmbPriceMode.Text = "Refund" Then
        ''    ceQtyy.Value = ceQtyy.Value * -1
        ''End If
        ' ''End of Comment

        txtqty.Text = ceQtyy.Text

        qtyy = 1 '  CInt(ceQtyy.Value)

        ' 'ItemsearchExecute()
        If cmbPriceMode.Text = "Refund" Then
            qtyy = qtyy * -1
        Else
            qtyy = Math.Abs(qtyy * 1)
        End If
        LookupEditKeypress()
        'End If
    End Sub


    Private Sub dgitems_KeyDown(sender As Object, e As KeyEventArgs) Handles dgitems.KeyDown

        If e.KeyCode = Keys.Enter Then
            DgitemsKeydown()
            e.SuppressKeyPress = True
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
        End If

        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Back Then

            dgitems.Visible = False
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
            e.SuppressKeyPress = True
        End If




    End Sub
    Sub DgitemsKeydown()
        If dgitems.Rows.Count < 1 Then
            Exit Sub
        End If
        Try
            Dim vRow As Integer = 0
            Dim vint As Integer = 0
            Dim x1 As String = String.Empty
            Dim x2 As String = String.Empty
            ' Dim x2 As Integer = 0
            Dim x3 As Integer = 0
            Dim x4 As Decimal = 0
            Dim x5 As Integer = 0
            Dim x6 As String = String.Empty
            vRow = dgitems.CurrentRow.Index
            'vint = CInt(dgitems(0, vRow).Value)
            'x1 = CStr(dgitems(1, vRow).Value)
            'x2 = CStr(dgitems(2, vRow).Value)
            'x3 = CDec(dgitems(12, vRow).Value)
            'x4 = CDec(dgitems(13, vRow).Value)
            vint = CInt(dgitems(0, vRow).Value)
            x1 = CStr(dgitems(1, vRow).Value)
            x2 = CStr(dgitems(2, vRow).Value)
            x3 = CInt(dgitems(3, vRow).Value)
            x4 = CDec(dgitems(4, vRow).Value)

            '+New Comment
            'x5 = CInt(dgitems(6, vRow).Value)
            '+End of New Comment


            'x6 = CStr(dgitems(7, vRow).Value)
            vStckid = vint
            vItem = x2
            vAvlbl = x3
            vbocde = x1
            vPrice = x3
            vWPrice = x4
            '+New Comment
            'vInnerQty = x5
            '+End of New Comment

            txtbcodes.Text = String.Empty
            txtStckid.Text = String.Empty
            txtitem.Text = vItem.ToString
            txtbcodes.Text = vbocde.ToString
            txtBarcode.Text = vbocde.ToString
            txtStckid.Text = vStckid.ToString
            ''txtBarcode.SelectAll()
            'If txtStckid.Text = String.Empty Then
            '    Exit Sub
            'Else
            '    ItemsearchExecute()
            'End If
            'txtitem.Focus()

            '+New Code
            BarcodeKeyDown()
            '+End of New Code

            dgitems.Visible = False
            'ceQtyy.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub



    Private Sub PosGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PosGrid.CellClick
        If e.ColumnIndex = -1 Then
            Dim ansint As Integer = 7
            ansint = MsgBox("Are you sure you want Delete the selected Row?", MsgBoxStyle.YesNo, "Delete Row Confirmation")
            If ansint = 6 Then
                VoidItem()
            End If
        End If
    End Sub

    Private Sub DGRetrieve_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGRetrieve.KeyPress

        If e.KeyChar = Chr(27) Then
            DGRetrieve.Visible = False
            If vBarcodeOrItemSearch = True Then
                txtBarcode.Text = String.Empty
                txtBarcode.Focus()
            Else
                txtitem.Text = String.Empty
                txtitem.Focus()
            End If
        End If
    End Sub

    Private Sub dgitems_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgitems.KeyPress

        If e.KeyChar = Chr(27) Then
            'DGRetrieve.Visible = False
            '' I just added this one, new modification october 17 , 2014
            'dgitems.Visible = False
            ''txtitem.Focus()
            ''+This is a new Code to Immediately send the item to the Grid by executing the new code BarcodeKeyDown
            'BarcodeKeyDown()
            ''+End of new Code

            'txtBarcode.Focus()
        End If
    End Sub

    Private Sub ceQtyy_LostFocus(sender As Object, e As EventArgs) Handles ceQtyy.LostFocus
        If cmbPriceMode.Text = "Refund" Then
            ceQtyy.Value = ceQtyy.Value * -1
        Else
            ceQtyy.Value = Math.Abs(ceQtyy.Value)
        End If
    End Sub


    Private Sub PosGrid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PosGrid.KeyPress
        'If e.KeyChar = Chr(13) Then
        '    'txtitem.Focus()
        'txtitem.Focus
        'End If
        If e.KeyChar = Chr(42) Then
            e.Handled = True
            passcorrect = False
            Dim frm As frmPasswordInput
            frm = New frmPasswordInput
            'frm.MdiParent = Me
            frm.WindowState = FormWindowState.Normal
            frm.ShowDialog()
            frm = Nothing

            If passcorrect = False Then
                Exit Sub
            End If
            SetQuantity()

            txtBarcode.Text = ""
            txtBarcode.Text = String.Empty

        End If
    End Sub

    Private Sub btnChanePrice_Click(sender As Object, e As EventArgs) Handles btnChanePrice.Click
        PriceOverride()
    End Sub

    Sub AddTempSales()
        ' Define the data for the new record
        Dim ProdId As Integer = mgr6.DataObject.Entity.stckid
        Dim Barcode As String = mgr6.DataObject.Entity.barcode
        Dim Quantity As Double = qtyy
        Dim Cost As Decimal = mgr6.DataObject.Entity.cost
        Dim Item As String = mgr6.DataObject.Entity.itemdesc
        Dim Price As Decimal = mgr6.DataObject.Entity.retail
        Dim Amount As Decimal = mgr6.DataObject.Entity.retail
        Dim OP As Decimal = mgr6.DataObject.Entity.retail
        Dim Discounts As Decimal = mgr6.DataObject.Entity.retail
        Dim Incentv As Double = vCellValIncent
        Dim WaiterID As Integer = mgr6.DataObject.Entity.vat
        Dim Cashier As String = PDSAAppConfig.CurrentLoginID
        Dim SoldDate As Date = Date.Today

        ' Create a SQL connection
        Dim connectionString As String = "Data Source=DOORSCOMPUTERS\SQLEXPRESS;Initial Catalog=doorspos;Integrated Security=True"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Create a SQL command to insert the new record
            Dim query As String = "INSERT INTO [dbo].[SalesTemp] (ProdId, Barcode, Quantity, Cost, Item, Price, Amount, OP, discounts, Incentv, WaiterID, Vatabol, Cashier, SoldDate) VALUES (@ProdId, @Barcode, @Quantity, @Cost, @Item, @Price, @Amount, @OP, @Discounts, @Incentv, @WaiterID, @Vatabol, @Cashier, @SoldDate)"
            Using command As New SqlCommand(query, connection)
                ' Set the parameter values
                command.Parameters.AddWithValue("@ProdId", ProdId)
                command.Parameters.AddWithValue("@Barcode", Barcode)
                command.Parameters.AddWithValue("@Quantity", Quantity)
                command.Parameters.AddWithValue("@Cost", Cost)
                command.Parameters.AddWithValue("@Item", Item)
                command.Parameters.AddWithValue("@Price", Price)
                command.Parameters.AddWithValue("@Amount", Amount)
                command.Parameters.AddWithValue("@OP", OP)
                command.Parameters.AddWithValue("@Discounts", Discounts)
                command.Parameters.AddWithValue("@Incentv", Incentv)
                command.Parameters.AddWithValue("@WaiterID", WaiterID)
                command.Parameters.AddWithValue("@Vatabol", 0) ' Set the value for Vatabol accordingly
                command.Parameters.AddWithValue("@Cashier", Cashier)
                command.Parameters.AddWithValue("@SoldDate", SoldDate)

                ' Execute the SQL command to insert the record
                command.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Sub UpdateSalesTempQty()
        ' Get the ProdId and CurrentLoginID
        Dim ProdId As Integer = mgr6.DataObject.Entity.stckid
        Dim CurrentLoginID As String = PDSAAppConfig.CurrentLoginID


        ' Create a SQL connection
        Dim connectionString As String = "Data Source=DOORSCOMPUTERS\SQLEXPRESS;Initial Catalog=doorspos;Integrated Security=True"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Create a SQL command to update the Quantity field
            Dim query As String = "UPDATE [dbo].[SalesTemp] SET Quantity = Quantity + 1, Amount=@Amount WHERE ProdId = @ProdId AND Cashier = @CurrentLoginID"
            Using command As New SqlCommand(query, connection)
                ' Set the parameter values
                command.Parameters.AddWithValue("@Amount", NewPrice)
                command.Parameters.AddWithValue("@ProdId", ProdId)
                command.Parameters.AddWithValue("@CurrentLoginID", CurrentLoginID)

                ' Execute the SQL command to update the Quantity field
                command.ExecuteNonQuery()
            End Using
        End Using

    End Sub
    Sub UpdateSalesTempQty2()
        ' Get the ProdId and CurrentLoginID
        Dim ProdId As Integer = mgr6.DataObject.Entity.stckid
        Dim CurrentLoginID As String = PDSAAppConfig.CurrentLoginID


        ' Create a SQL connection
        Dim connectionString As String = "Data Source=DOORSCOMPUTERS\SQLEXPRESS;Initial Catalog=doorspos;Integrated Security=True"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Create a SQL command to update the Quantity field
            Dim query As String = "UPDATE [dbo].[SalesTemp] SET Quantity = Quantity + 1, Amount=@Amount WHERE ProdId = @ProdId AND Cashier = @CurrentLoginID"
            Using command As New SqlCommand(query, connection)
                ' Set the parameter values
                command.Parameters.AddWithValue("@Amount", NewPrice)
                command.Parameters.AddWithValue("@ProdId", ProdId)
                command.Parameters.AddWithValue("@CurrentLoginID", CurrentLoginID)

                ' Execute the SQL command to update the Quantity field
                command.ExecuteNonQuery()
            End Using
        End Using

    End Sub
    Sub DeleteSalesTemp()
        ' Get the ProdId and CurrentLoginID
        Dim ProdId As Integer = Convert.ToInt32(PosGrid.SelectedRows(0).Cells(0).Value)
        Dim CurrentLoginID As String = PDSAAppConfig.CurrentLoginID

        ' Create a SQL connection
        Dim connectionString As String = "Data Source=DOORSCOMPUTERS\SQLEXPRESS;Initial Catalog=doorspos;Integrated Security=True"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Create a SQL command to delete the record
            Dim query As String = "DELETE FROM [dbo].[SalesTemp] WHERE ProdId = @ProdId AND Cashier = @CurrentLoginID"
            Using command As New SqlCommand(query, connection)
                ' Set the parameter values
                command.Parameters.AddWithValue("@ProdId", ProdId)
                command.Parameters.AddWithValue("@CurrentLoginID", CurrentLoginID)

                ' Execute the SQL command to delete the record
                command.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Sub DeleteSalesTemp2()
        ' Get the ProdId and CurrentLoginID
        Dim CurrentLoginID As String = PDSAAppConfig.CurrentLoginID

        ' Create a SQL connection
        Dim connectionString As String = "Data Source=DOORSCOMPUTERS\SQLEXPRESS;Initial Catalog=doorspos;Integrated Security=True"
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Create a SQL command to delete the record
            Dim query As String = "DELETE FROM [dbo].[SalesTemp] WHERE Cashier = @CurrentLoginID"
            Using command As New SqlCommand(query, connection)
                ' Set the parameter values
                command.Parameters.AddWithValue("@CurrentLoginID", CurrentLoginID)

                ' Execute the SQL command to delete the record
                command.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    Private Sub frmPOS_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Unhook()
    End Sub

    Public Sub GetCategoryDiscount(nProdID As Integer)
        Dim connectionString As String = "Data Source=DOORSCOMPUTERS\SQLEXPRESS;Initial Catalog=doorspos;Integrated Security=True;"

        ' Query to get categoryid from stocks table
        Dim queryCategoryID As String = "SELECT categoryid FROM stocks WHERE stckid = @stckid"

        ' Query to get discountpercent from categories table
        Dim queryDiscount As String = "SELECT discountpercent FROM categories WHERE categoryid = @categoryid"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Get categoryid from stocks table
                Using command As New SqlCommand(queryCategoryID, connection)
                    command.Parameters.AddWithValue("@stckid", nProdID)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        vCategoryID = Convert.ToInt32(result)
                    Else
                        ' Handle case where stckid is not found
                        Throw New Exception("Product ID not found in stocks table.")
                    End If
                End Using

                ' Get discountpercent from categories table
                Using command As New SqlCommand(queryDiscount, connection)
                    command.Parameters.AddWithValue("@categoryid", vCategoryID)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        Dim discountPercent As Integer = Convert.ToInt32(result)
                        vCategoryDiscount = discountPercent / 100D ' Convert to decimal percent
                    Else
                        ' Handle case where categoryid is not found
                        Throw New Exception("Category ID not found in categories table.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Class