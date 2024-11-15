Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Data.Filtering

Public Class frmSalesHistory

    Private Sub frmSalesHistory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmSalesHistory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub frmSalesHistory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmSalesHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = New Font("Courier New", 12)
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsFind.AlwaysVisible = True
        'TODO: This line of code loads data into the 'DsSalesArchive.vwSalesArchive' table. You can move, or remove it, as needed.
        Me.VwSalesArchiveTableAdapter.Fill(Me.DsSalesArchive.vwSalesArchive)
        'TODO: This line of code loads data into the 'DsSalesHistory.pos_det' table. You can move, or remove it, as needed.
        GridView1.Columns("pos_tme").FilterInfo = New ColumnFilterInfo()
        'Dim strFrom As String = String.Empty
        'Dim strTo As String = String.Empty
        ''strFrom = FromDate.Text + " " + "12:00:00 AM"
        ''strTo = ToDate.Text + " " + " 12:00:00 PM"
        '''GridView1.Columns("pos_date").FilterInfo = New ColumnFilterInfo("pos_date <=" & CDate(FromDate.Text))
        '''GridView1.Columns("pos_tme").FilterInfo = New ColumnFilterInfo("[pos_tme] >= '" & strFrom & "' AND [pos_tme] <= '" & strTo & "'")
        '''GridView1.Columns("pos_date").FilterInfo = New ColumnFilterInfo("[pos_date] >= '" & Convert.ToDateTime(FromDate.EditValue) & "' AND [pos_date] <= '" & Convert.ToDateTime(ToDate.EditValue) & "'")

        ''Dim filterstring As String

        ''filterstring = "[pos_tme] >= '" & strFrom & "' AND [pos_tme] <= '" & strTo & "'"

        ''Dim DateFilter As New DevExpress.XtraGrid.Columns.ColumnFilterInfo(filterstring)

        ''GridView1.Columns("pos_tme").FilterInfo = DateFilter


        'Dim FromDatee, ToDatee As DateTime

        'FromDatee = CDate(strFrom)

        'ToDatee = CDate(strTo)



        'Dim BinaryFilter As CriteriaOperator

        'Dim FilterString, FilterDisplayText As String

        'Dim DateFilter As ColumnFilterInfo



        'BinaryFilter = New GroupOperator(GroupOperatorType.And, New BinaryOperator("pos_tme", FromDatee, BinaryOperatorType.GreaterOrEqual), New BinaryOperator("pos_tme", ToDatee, BinaryOperatorType.Less))

        'FilterString = BinaryFilter.ToString()

        'FilterDisplayText = String.Format("Sold Date is between {0:d} and {1:d}", FromDatee, ToDatee)

        'DateFilter = New ColumnFilterInfo(FilterString, FilterDisplayText)

        'GridView1.Columns("pos_tme").FilterInfo = DateFilter

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        GridControl1.ShowPrintPreview()
    End Sub

    Private Sub GridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub GridControl1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GridControl1.KeyPress
        If e.KeyChar = Chr(27) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        GridView1.Columns("pos_tme").FilterInfo = New ColumnFilterInfo()
        'Dim strFrom As String = String.Empty
        'Dim strTo As String = String.Empty
        'strFrom = FromDate.Text + " " + "12:00:00 AM"
        'strTo = ToDate.Text + " " + " 12:00:00 PM"
        'GridView1.Columns("pos_date").FilterInfo = New ColumnFilterInfo("pos_date <=" & CDate(FromDate.Text))
        'GridView1.Columns("pos_tme").FilterInfo = New ColumnFilterInfo("[pos_tme] >= '" & strFrom & "' AND [pos_tme] <= '" & strTo & "'")
        'GridView1.Columns("pos_date").FilterInfo = New ColumnFilterInfo("[pos_date] >= '" & Convert.ToDateTime(FromDate.EditValue) & "' AND [pos_date] <= '" & Convert.ToDateTime(ToDate.EditValue) & "'")

        'Dim filterstring As String

        'filterstring = "[pos_tme] >= '" & strFrom & "' AND [pos_tme] <= '" & strTo & "'"

        'Dim DateFilter As New DevExpress.XtraGrid.Columns.ColumnFilterInfo(filterstring)

        'GridView1.Columns("pos_tme").FilterInfo = DateFilter


        'Dim FromDatee, ToDatee As DateTime

        'FromDatee = CDate(strFrom)

        'ToDatee = CDate(strTo)



        'Dim BinaryFilter As CriteriaOperator

        'Dim FilterString, FilterDisplayText As String

        'Dim DateFilter As ColumnFilterInfo



        'BinaryFilter = New GroupOperator(GroupOperatorType.And, New BinaryOperator("pos_tme", FromDatee, BinaryOperatorType.GreaterOrEqual), New BinaryOperator("pos_tme", ToDatee, BinaryOperatorType.Less))

        'FilterString = BinaryFilter.ToString()

        'FilterDisplayText = String.Format("Sold Date is between {0:d} and {1:d}", FromDatee, ToDatee)

        'DateFilter = New ColumnFilterInfo(FilterString, FilterDisplayText)

        'GridView1.Columns("pos_tme").FilterInfo = DateFilter


    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class