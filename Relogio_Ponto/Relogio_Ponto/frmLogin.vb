Public Class frmLogin

    Dim log As New Login

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Testa conexão com o Servidor SQL
        Dim Con As New Conexao
        Con.StrConexao()
    End Sub

    Private Sub lblCadastro_Click(sender As Object, e As EventArgs) Handles lblCadastro.Click
        'Abre frmCadastro
        frmCadastro.Show()
        Me.Hide()
    End Sub

    Private Sub frmLogin_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtUsuario.Focus()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        'Verifica se todos os campos foram preenchidos
        If ValidaCampos() Then
            log.SelectLista(txtUsuario.Text)
            'Verifica a existência do usuário
            If log.Lusuario.Count > 0 Then
                'Verifica a veracidade da senha
                If log.Lsenha(0) = txtSenha.Text Then
                    frmRelogioPonto.Show()
                    LimpaCampos()
                    Me.Hide()
                Else
                    MessageBox.Show("Senha incorreta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtSenha.Focus()
                End If
            Else
                MessageBox.Show("Usuário inexistente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUsuario.Focus()
            End If
        Else
            MessageBox.Show("Verifique os campos obrigatórios e tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Sub para verificar se todos os campos foram preenchidos
    Private Function ValidaCampos() As Boolean
        If txtUsuario.Text <> "" And txtSenha.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub LimpaCampos()
        txtUsuario.Clear()
        txtSenha.Clear()
    End Sub
End Class
