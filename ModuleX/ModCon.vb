Imports System.Data.OleDb
Imports System.Data.SqlClient

Module ModCon
    ''Public fso As New filesystemobject
    'Public ParamDVFrom As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public ParamDVTo As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public ParamCompanyName As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public ParamCompanyLoc As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public ParamCompanyContact As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public ParamCompanyTIN As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public _USER As New CrystalDecisions.Shared.ParameterDiscreteValue
    'Public mReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public sqlDT As New DataTable
    Public sqlDTx As New DataTable
    Public openedFileStream As System.IO.Stream

    ''Public Const cnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=False;Data Source=../database/SaleInv_DB.mdb"
    ''Public Const cnString As String = "Provider=SQLNCLI10;Server=CPAT;Database=SaleInv_DB; Trusted_Connection=yes;"
    ''Public Const cnString As String = "Provider=SQLNCLI10;Server=CPAT;Database=SaleInv_DB;Uid=sa; Pwd=angelito;"

    ''Public Const cnstring As String = "Provider=SQLOLEDB;" & _
    ''                                  "Data Source=;" & _
    ''                                 "Network=CPAT;" & _
    ''                                  "Initial Catalog=SaleInv_DB;" & _
    ''                                  "User Id=sa;" & _
    ''                                  "Password=angelito"
    ''192.168.1.104;" & _'                           

    Public CnString As String

    ''Public conn As OleDbConnection = New OleDbConnection(cnString)
    '' Public DataFileLock As New System.Threading.ReaderWriterLock

    Public sqlSTR As String
    Public Rpt_SqlStr As String
    Public pass As Boolean
    Public VAT As Double
    Public username As String
    Public xUser_ID As Integer
    Public xUser_Access As String
    Public Pending_ID As Integer
    Public Pending_QTY As Integer
    Public Pending_Item_ID As Integer
    Public dataBytes() As Byte
    Public xpass As Boolean
    Public howx As Integer
    Public xid(1) As Integer
    Public xlock As Boolean
    Public iMin As Integer
    Public tmpStr As String
    Public LOGID As Integer
    Public PreviousPage, NextPage As Integer
    Public i_Print As Integer

    Public Function checkServer() As Boolean
        'Try

        '    With FrmSERVERSETTINGS
        '        .OpenFileDialog1.FileName = Application.StartupPath & "\Config.ini"
        '        openedFileStream = .OpenFileDialog1.OpenFile()
        '    End With

        '    ReDim dataBytes(openedFileStream.Length - 1) 'Init 
        '    openedFileStream.Read(dataBytes, 0, openedFileStream.Length)
        '    openedFileStream.Close()
        '    tmpStr = System.Text.Encoding.Unicode.GetString(dataBytes)

        '    With FrmSERVERSETTINGS
        '        If Split(tmpStr, ":")(4) = "1" Then
        '            'network
        '            CnString = "Provider=SQLOLEDB;" & _
        '                       "Data Source=" & Split(tmpStr, ":")(0) & _
        '                       ";Network=" & Split(tmpStr, ":")(1) & _
        '                       ";Server=" & Split(tmpStr, ":")(1) & _
        '                       ";Initial Catalog=SaleInv_DB" & _
        '                       ";User Id=" & Split(tmpStr, ":")(2) & _
        '                       ";Password=" & Split(tmpStr, ":")(3)
        '        Else
        '            'local
        '            'MsgBox(Split(tmpStr, ":")(1))
        '            CnString = "Provider=SQLOLEDB;Server=" & Split(tmpStr, ":")(1) & _
        '                       ";Database=SaleInv_DB; Trusted_Connection=yes;"
        '        End If
        '    End With
        '    Dim sqlCon As New OleDbConnection
        '    sqlCon.ConnectionString = CnString
        '    sqlCon.Open()
        '    checkServer = True
        '    sqlCon.Close()
        'Catch ex As Exception
        '    checkServer = False
        'End Try
    End Function

    Public Function ExecuteSQLQuery11(ByVal SQLQuery As String) As DataTable
        'Try
        CnString = "Provider=SQLOLEDB;Server=DOORSCOMPUTERS\SQLEXPRESS" &
                               ";Database=doorspos; Trusted_Connection=yes;"
        Dim sqlCon As New OleDbConnection(CnString)
        Dim sqlDA As New OleDbDataAdapter(SQLQuery, sqlCon)
        Dim sqlCB As New OleDbCommandBuilder(sqlDA)
        sqlDT.Reset() ' refresh 
        sqlDA.Fill(sqlDT)
        'Catch ex As Exception
        '    'MsgBox("Error: " & ex.ToString)
        '    ' If Err.Number = 5 Then
        '    ' MsgBox("Invalid Database, Configure TCP/IP", MsgBoxStyle.Exclamation, "Sales and Inventory")
        '    ' Else
        '    MsgBox("Error : " & ex.Message)
        '    ' End If
        '    'MsgBox("Error No. " & Err.Number & " Invalid database or no database found !! Adjust settings first", MsgBoxStyle.Critical, "Sales And Inventory")
        '    'MsgBox(SQLQuery)
        'End Try
        Return sqlDT
    End Function
    Public Function ExecuteSQLQueryWorking(ByVal SQLQuery As String) As DataTable
        Dim connectionString As String = "Data Source=DOORSCOMPUTERS\SQLEXPRESS;Initial Catalog=doorspos;Integrated Security=True;"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(SQLQuery, connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(sqlDT)
                    Return sqlDT
                End Using
            End Using
        End Using
    End Function
    Public Function ExecuteSQLQuery(ByVal SQLQuery As String) As DataTable
        Dim connectionString As String = "Data Source=DOORSCOMPUTERS\SQLEXPRESS;Initial Catalog=doorspos;Integrated Security=True;"
        Dim dataTable As New DataTable()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(SQLQuery, connection)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions (log, rethrow, or show message)
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dataTable
    End Function
    Public Function ExecuteSQLQueryWithParameter(ByVal SQLQuery As String, ByVal parameters As List(Of SqlParameter)) As DataTable
        Dim connectionString As String = "Data Source=DOORSCOMPUTERS\SQLEXPRESS;Initial Catalog=doorspos;Integrated Security=True;"
        Dim dataTable As New DataTable()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(SQLQuery, connection)
                    If parameters IsNot Nothing Then
                        command.Parameters.AddRange(parameters.ToArray())
                    End If
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions (log, rethrow, or show message)
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dataTable
    End Function
    'Usage example for parameterized queries:
    '    Dim query As String = "SELECT * FROM members WHERE CustID = @CustID"
    '    Dim parameters As New List(Of SqlParameter) From {
    '    New SqlParameter("@CustID", 1)
    '}
    '    Dim result As DataTable = ExecuteSQLQuery(query, parameters)



    Public Function ExecuteSQLQueryReader(ByVal SQLQuery As String) As SqlDataReader
        Dim connectionString As String = "Data Source=DOORSCOMPUTERS\SQLEXPRESS;Initial Catalog=doorspos;Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)
        Dim command As New SqlCommand(SQLQuery, connection)
        connection.Open()
        Dim dataReader As SqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection)
        Return dataReader
    End Function

    Public Function ExecuteSQLQueryMaster(ByVal SQLQuery As String) As DataTable
        Try
            CnString = "Provider=SQLOLEDB;Server=DOORSCOMPUTERS\SQLEXPRESS" &
                                   ";Database=master; Trusted_Connection=yes;"
            Dim sqlCon As New OleDbConnection(CnString)
            Dim sqlDA As New OleDbDataAdapter(SQLQuery, sqlCon)
            Dim sqlCB As New OleDbCommandBuilder(sqlDA)
            sqlDT.Reset() ' refresh 
            sqlDA.Fill(sqlDT)
        Catch ex As Exception
            'MsgBox("Error: " & ex.ToString)
            ' If Err.Number = 5 Then
            ' MsgBox("Invalid Database, Configure TCP/IP", MsgBoxStyle.Exclamation, "Sales and Inventory")
            ' Else
            MsgBox("Error : " & ex.Message)
            ' End If
            'MsgBox("Error No. " & Err.Number & " Invalid database or no database found !! Adjust settings first", MsgBoxStyle.Critical, "Sales And Inventory")
            'MsgBox(SQLQuery)
        End Try
        Return sqlDT
    End Function
    Public Sub FILLComboBox(ByVal sql As String, ByVal cb As ComboBox)
        Dim conn As OleDbConnection = New OleDbConnection(CnString)
        cb.Items.Clear()
        Try
            conn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand(sql, conn)
            Dim rdr As OleDbDataReader = cmd.ExecuteReader
            While rdr.Read
                cb.Items.Add(rdr(0).ToString & " - " & rdr(1).ToString)
            End While
            rdr.Close()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub FILLComboBox2(ByVal sql As String, ByVal cb As ComboBox)
        Dim conn As OleDbConnection = New OleDbConnection(CnString)
        cb.Items.Clear()
        Try
            conn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand(sql, conn)
            Dim rdr As OleDbDataReader = cmd.ExecuteReader
            While rdr.Read
                cb.Items.Add(rdr(1).ToString)
            End While
            rdr.Close()
        Catch ex As Exception
            MsgBox("Error:" & ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Function str_Filter(ByVal txt As String, ByVal ascKey1 As Integer, ByVal ascKey2 As Integer, ByVal ascKey3 As Integer, ByVal N_Repeat As Integer) As String
        On Error Resume Next
        '-----function dump all strings except
        Dim Delimeter As String = ""
        Dim X As Long
        Dim intStr As String
        Dim NumberToRepeatCharacter As Integer

        'MsgBox(Chr(Asc(txt)))
        'MsgBox(Asc(txt))
        For X = 1 To Len(txt)         'asckey1                                asckey2                              asckey3
            If Asc(Mid((txt), CInt(X), 1)) >= ascKey1 And Asc(Mid((txt), CInt(X), 1)) <= ascKey2 Or Asc(Mid(txt, CInt(X), 1)) = ascKey3 Then
            Else
                Delimeter = Chr(Asc(Mid(txt, CInt(X), 1)))
                MsgBox(Delimeter)
            End If
        Next
        intStr = ""
        For X = 1 To Len(txt)
            If N_Repeat > 0 Then
                If Asc(Mid(txt, CInt(X), 1)) = ascKey3 Then
                    If NumberToRepeatCharacter >= N_Repeat Then
                        SendKeys.Send("{END}")
                        Exit For
                    End If
                    NumberToRepeatCharacter = NumberToRepeatCharacter + 1
                End If
            End If
            'If NumberToRepeatCharacter <> N_Repeat Then
            If Mid(txt, CInt(X), 1) <> Delimeter Then
                intStr = intStr & Mid(txt, CInt(X), 1)
                'NumberToRepeatCharacter = NumberToRepeatCharacter + 1
            Else
                'can be uncomment if you want
                'SendKeys.Send("{END}")
            End If
            ' Else
            ' SendKeys.Send("{END}")
            ' End If

            'NumberToRepeatCharacter = X
        Next
        'MsgBox(NumberToRepeatCharacter)
        str_Filter = intStr
    End Function


    'Public Function DataSourceConnection_Report()
    '    If Split(tmpStr, ":")(4) = "1" Then
    '        'mReport.DataSourceConnections
    '        'mReport()
    '        'mReport.DataSourceConnections(0).SetConnection(Split(tmpStr, ":")(1), "SaleInv_DB", Split(tmpStr, ":")(2), Split(tmpStr, ":")(3))
    '        mReport.DataSourceConnections(0).SetConnection(Split(tmpStr, ":")(1), "SaleInv_DB", False)
    '        'MsgBox(Split(tmpStr, ":")(2) & "  " & Split(tmpStr, ":")(3))
    '        mReport.DataSourceConnections(0).SetLogon(Split(tmpStr, ":")(2), Split(tmpStr, ":")(3))
    '    Else

    '        mReport.DataSourceConnections(0).SetConnection(Split(tmpStr, ":")(1), "SaleInv_DB", True)
    '    End If
    '    'MsgBox(mReport.DataSourceConnections(0).ServerName.ToString)
    '    Return 0
    'End Function
End Module
