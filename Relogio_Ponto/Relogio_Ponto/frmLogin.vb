Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Testa conexão com o Servidor SQL
        Dim Con As New Conexao
        Con.StrConexao()
    End Sub


End Class
