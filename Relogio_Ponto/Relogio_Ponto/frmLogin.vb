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

    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtUsuario.Focus()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If ValidaCampos() Then

        Else
            MessageBox.Show("Verifique os campos obrigatórios e tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function ValidaCampos() As Boolean
        If txtUsuario.Text <> "" And txtSenha.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
