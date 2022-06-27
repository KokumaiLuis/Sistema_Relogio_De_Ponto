Public Class frmCadastro

    Dim log As New Login

    Private Sub frmCadastro_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Foca na textbox
        txtUsuario.Focus()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        'Verifica se todos os campos foram preenchidos
        If ValidaCampos() Then
            'Verifica se o nome digitado já existe
            log.SelectLista(txtUsuario.Text)
            If log.Usuario <> "" Then
                MessageBox.Show("O nome de usuário digitado já existe, favor inserir outro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUsuario.Focus()
            Else
                'Grava cadastro no banco de dados
                GravaCadastro(txtUsuario.Text, txtSenha.Text)
            End If
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
            LimpaCampos()
            frmLogin.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpaCampos()
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub LimpaCampos()
        txtUsuario.Clear()
        txtSenha.Clear()
    End Sub
End Class