Module mdlMain
    Public USER_ID As String
    Public EMPLOYEE_ID As String
    Public EMPLOYEE_NAME As String
    Public POSITION_ID As String
    Public DEPARTMENT As String
    Public POSID As String

    Sub Main()
        Dim blnLoginCorrect As Boolean
        Dim frmSplash As New frmSplash

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            frmSplash.Show()
            frmSplash.Refresh()

            Dim frmLogin As New frmLogin
            blnLoginCorrect = frmLogin.Login()
            frmLogin.Dispose()
            If blnLoginCorrect Then

                Dim frmMainMenu As New frmMainMenu
                frmMainMenu.CustomizeMainMenu()
                frmSplash.Dispose()
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                frmMainMenu.ShowDialog()
            Else
                Application.Exit()
            End If
        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub
End Module
