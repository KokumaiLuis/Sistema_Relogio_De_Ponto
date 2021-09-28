Public Class frmRelogioPonto
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Logout()
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Logout()
    End Sub

    Private Sub Logout()
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class