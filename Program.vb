Imports System.Threading

Module Program
    Private mutex As Mutex

    Public Sub Main()
        Dim mutexCreated As Boolean
        mutex = New Mutex(True, "UniqueAppNameMutex", mutexCreated)

        If mutexCreated Then
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New frmMain()) ' Replace frmMain with your startup form's name.

            ' Ensure to release the mutex
            mutex.ReleaseMutex()
        Else
            MessageBox.Show("An instance of the application is already running.")
            Return
        End If
    End Sub
End Module
