Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Testa conexão com o Servidor SQL
        Dim Con As New Conexao
        Con.StrConexao()
    End Sub

    Private Sub lblCadastro_Click(sender As Object, e As EventArgs) Handles lblCadastro.Click
        frmCadastro.Show()
        Me.Hide()
    End Sub
End Class
