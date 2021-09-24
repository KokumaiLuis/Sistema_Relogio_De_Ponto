Public Class frmCadastro

    Dim log As New Login

    Private Sub frmCadastro_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Foca na textbox
        txtUsuario.Focus()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        'Verifica se todos os campos foram preenchidos
        If ValidaCampos() Then
            'Grava cadastro no banco de dados
            GravaCadastro(txtUsuario.Text, txtSenha.Text)
        Else
            'Retorna uma mensagem para o usuário
            MessageBox.Show("Preencha todos os campos obrigatórios e tente novamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Sub valida se todos os campos estão preenchidos
    Private Function ValidaCampos() As Boolean
        If txtUsuario.Text <> "" And txtSenha.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub GravaCadastro(ByVal usuario As String,
                              ByVal senha As String)
        log.Gravar(usuario, senha)

        If log.exito Then
            MessageBox.Show("Usuário gravado com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmLogin.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class