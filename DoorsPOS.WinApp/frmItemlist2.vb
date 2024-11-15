Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports PDSA.DataLayer.DataClasses
Imports PDSA.Validation
Imports DoorsPOS.WinApp.WaitForm_SetDescription
Imports DevExpress.XtraSplashScreen

Public Class frmItemlist2

    Private Sub frmItemlist2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmItemlist2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)

        Try


            'TODO: This line of code loads data into the 'DsBrand.dept' table. You can move, or remove it, as needed.
            Me.deptTableAdapter.Fill(Me.DsBrand.dept)

            'DevExpress.Utils.AppearanceObject.DefaultFont = New System.Drawing.Font("Arial Unicode MS", 12.0F)
            'SetGridFont(GridView2, New Font("Courier New", 12))
            'TODO: This line of code loads data into the 'CategoryDS.categories' table. You can move, or remove it, as needed.

            Me.categoriesTableAdapter1.Fill(Me.CategoryDS.categories)
            'TODO: This line of code loads data into the 'DsCategory.categories' table. You can move, or remove it, as needed.
            Me.categoriesTableAdapter.Fill(Me.DsCategory.categories)
            'TODO: This line of code loads data into the 'DsStakks.stocks' table. You can move, or remove it, as needed.
            Me.StocksTableAdapter1.Fill(Me.DsStakks.stocks)
            '+DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Courier New", 12) ' <<< NEW LINE
            GridControl1.UseEmbeddedNavigator = True
            GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True

            RepositoryItemGridLookUpEdit1.View.PopulateColumns(RepositoryItemGridLookUpEdit1.DataSource)
            RepositoryItemGridLookUpEdit1.View.Columns(RepositoryItemGridLookUpEdit1.ValueMember).Visible = False
            RepositoryItemGridLookUpEdit1.View.Columns("catgory").Caption = "Category"

            RepositoryItemGridLookUpEdit2.View.PopulateColumns(RepositoryItemGridLookUpEdit2.DataSource)
            RepositoryItemGridLookUpEdit2.View.Columns(RepositoryItemGridLookUpEdit2.ValueMember).Visible = False
            RepositoryItemGridLookUpEdit2.View.Columns("DEPTD").Caption = "Brand"

        Finally
            '++Close Wait Form
            SplashScreenManager.CloseForm(False)
        End Try

    End Sub
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs)
        ShowGridPreview(GridControl1)
    End Sub
    Sub ShowGridPreview(ByVal grid As GridControl)
        ' Check whether the GridControl can be previewed.
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The Printing' library is not found", "Error")
            Return
        End If
        ' Opens the Preview window.
        grid.ShowPrintPreview()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            C1DataViewSet1.Update()
            MessageBox.Show("Item Edit Successfully Saved")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub GridControl1_DoubleClick1(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        ShowGridPreview(GridControl1)
    End Sub

    Sub SetGridFont(view As GridView, font As Font)
        Dim ap As AppearanceObject
        For Each ap In view.Appearance
            ap.Font = font
        Next
    End Sub

    Private Sub GridView2_CellValueChanged(sender As Object, e As Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        'If e.Column.Caption <> "Retail" Or e.Column.Caption = "Cost" Then Exit Sub
        'Dim cellValue As Decimal = e.Value + _
        '  GridView2.GetRowCellValue(e.RowHandle, _
        '  GridView2.Columns("Retail"))
        'GridView2.SetRowCellValue(e.RowHandle, _
        '  GridView2.Columns("FullName"), cellValue)

        'If e.Column.Caption <> "Retail" Or e.Column.Caption = "Cost" Then Exit Sub
        'Dim cellValue As Decimal = e.Value + _
        '  GridView2.GetRowCellValue(e.RowHandle, _
        '  GridView2.Columns("Retail"))
        'GridView2.SetRowCellValue(e.RowHandle, GridView2.Columns("sLastUpdate_id"), PDSAAppConfig.CurrentLoginID)
        Dim row As System.Data.DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        'Dim CellValue As String = CStr(row(13))
        row(22) = PDSAAppConfig.CurrentLoginID
        row(23) = DateTime.Now
    End Sub

    Private Sub btnSave_DoubleClick(sender As Object, e As EventArgs) Handles btnSave.DoubleClick

    End Sub
End Class