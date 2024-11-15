Public Class RestoreDatabases
    Inherits DBConnectionMaster
    Public Sub ResToreDatabases()
        sqlcon.Open()
        Dim opDialog As OpenFileDialog = New OpenFileDialog

        opDialog.Filter = "BackUp Files (*.bak)|*.bak"
        opDialog.Title = "Select your .bak file for restore the database OpenMiracle"
        Dim path As String = ""
        '     path = "c:\sqlData3"

        If opDialog.ShowDialog = DialogResult.OK Then
            Dim filePath As String = opDialog.FileName
            Dim fileName As String = filePath

            Dim sqlSTR As String = String.Empty
            'sqlSTR = "exec RestoreDB @file=" + fileName
            sqlSTR = "exec RestoreDB @file=" + "'" + fileName + "'"
            ExecuteSQLQueryMaster(sqlSTR)
        End If

    End Sub

End Class
