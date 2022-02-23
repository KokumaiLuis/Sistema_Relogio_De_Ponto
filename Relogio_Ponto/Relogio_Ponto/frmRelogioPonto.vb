Public Class frmRelogioPonto
    Dim Horas As New Horas

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

    Private Sub frmRelogioPonto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Con As New Conexao
        Con.StrConexao()

        CarregaData()
        CarregaHoras()

        CarregaGridHoras()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CarregaHoras()
    End Sub

    Private Sub CarregaHoras()
        Horas.RetornaHoras()

        If Horas.Exito Then
            lblHora.Text = Horas.Horas.ToString()
        End If
    End Sub

    Private Sub CarregaData()
        Horas.RetornaData()

        If Horas.Exito Then
            lblData.Text = Horas.Data.ToString()
        End If
    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        If VerificaModo() Then
            InserirHorarioEntrada()
        End If
    End Sub

    Private Function VerificaModo()
        If Not (rbtnHomeOffice.Checked Or rbtnPresencial.Checked) Then
            MessageBox.Show("Antes de lançar um horário, selecione o modo", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub CarregaGridHoras()
        With GridHorario
            .Rows.Clear()

            Horas.RetornaMarcacoes(Id_log)

            If Horas.LId_Horas.Count > 0 Then
                For x = 0 To Horas.LId_Horas.Count - 1
                    .Rows.Add(Horas.LId_Horas(x), Horas.LNom_Log(x), Horas.LData(x), Horas.LEntrada(x), Horas.LInic_Alm(x), Horas.LFim_Alm(x), Horas.LSaida(x), Horas.LModo(x))
                Next
            End If
        End With
    End Sub

    Private Sub InserirHorarioEntrada()

        Dim Data As String = lblData.Text.Substring(6, 4) & "-" & lblData.Text.Substring(3, 2) & "-" & lblData.Text.Substring(0, 2)

        Horas.VerificaMarcacoes(Id_log, Data)

        If Horas.Exito Then
            If Horas.LId_Horas.Count = 0 Then
                Dim Hora As String = lblHora.Text
                Dim Modo As String = ""
                If rbtnHomeOffice.Checked Then
                    Modo = rbtnHomeOffice.Text
                Else
                    Modo = rbtnPresencial.Text
                End If

                Horas.InsertHoraEntrada(Id_log, Data, Hora, Modo)

                If Horas.Exito Then
                    MessageBox.Show("Horário de entrada lançado com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                CarregaGridHoras()
            Else
                MessageBox.Show("Horário de entrada já lançado para o dia de hoje.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub
End Class