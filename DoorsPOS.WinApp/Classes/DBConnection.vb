
Imports System.Data.SqlClient
Imports System.Threading
Public Class DBConnection
    Protected sqlcon As SqlConnection

    'protected SqlConnection sqlconTest;
    Private strServer As String = "DOORSCOMPUTERS\\sqlexpress"

    Private path1 As String = String.Empty

    Public Sub New()
        MyBase.New()
        '-------------Single User----------------------//
        Try
            strServer = "DOORSCOMPUTERS\\sqlexpress"

            ChangeConnectionForServer()
            ChangeConnectionForServerMaster()

        Catch ex As Exception
            'Catche any other exception
        Finally

        End Try

    End Sub

    ''' <summary>
    ''' SQL Express may take time to start up due to AutoClose Behaviour of SQLEXPRESS
    ''' 
    ''' </summary>
    Private Sub Reconnect()
        Try
            Thread.Sleep(30000)
            If (sqlcon.State = ConnectionState.Closed) Then
                sqlcon.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Your SQL Server is starting up... Please close and re-open the application")
        End Try
    End Sub

    ''' <summary>
    ''' Cheanges the connection string to support SQLServer version instead of SQLExpress
    ''' </summary>
    Private Sub ChangeConnectionForServer()
        'sqlcon = New SqlConnection(("Data Source=" _
        '                + (strServer + (";AttachDbFilename=" _
        '                + (path1 + ";Integrated Security=True;Connect Timeout=120;")))))
        sqlcon = New SqlConnection("Data Source=DOORSCOMPUTERS\SqlExpress;Initial Catalog=doorspos;Integrated Security=True;")
    End Sub
    Private Sub ChangeConnectionForServerMaster()
        'sqlcon = New SqlConnection(("Data Source=" _
        '                + (strServer + (";AttachDbFilename=" _
        '                + (path1 + ";Integrated Security=True;Connect Timeout=120;")))))
        sqlcon = New SqlConnection("Data Source=DOORSCOMPUTERS\SqlExpress;Initial Catalog=master;Integrated Security=True;")
    End Sub
End Class


