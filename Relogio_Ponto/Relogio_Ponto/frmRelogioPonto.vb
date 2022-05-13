Public Class frmRelogioPonto
    Dim Horas As New Horas

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Logout()
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs)
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

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs)
        InserirHorarioEntrada()
    End Sub

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
                If ImgHomeOffice.Visible Then
                    Modo = "Home Office"
                Else
                    Modo = "Presencial"
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

    Private Sub ImgPresencial_Click(sender As Object, e As EventArgs) Handles ImgPresencial.Click
        ImgHomeOffice.Visible = True
        ImgPresencial.Visible = False
    End Sub

    Private Sub ImgHomeOffice_Click(sender As Object, e As EventArgs) Handles ImgHomeOffice.Click
        ImgPresencial.Visible = True
        ImgHomeOffice.Visible = False
    End Sub

    Private Sub ImgEntrada_MouseEnter(sender As Object, e As EventArgs) Handles ImgEntrada.MouseEnter
        ImgEntradaHover.Visible = True
        ImgEntrada.Visible = False
    End Sub

    Private Sub ImgEntrada_MouseLeave(sender As Object, e As EventArgs) Handles ImgEntrada.MouseLeave
        'ImgEntrada.Visible = True
        'ImgEntradaHover.Visible = False
    End Sub

    Private Sub ImgEntradaHover_Click(sender As Object, e As EventArgs) Handles ImgEntradaHover.Click
        InserirHorarioEntrada()
    End Sub

    Private Sub ImgIniAlm_MouseEnter(sender As Object, e As EventArgs) Handles ImgIniAlm.MouseEnter
        ImgIniAlmHover.Visible = True
        ImgIniAlm.Visible = False
    End Sub

    Private Sub ImgIniAlm_MouseLeave(sender As Object, e As EventArgs) Handles ImgIniAlm.MouseLeave
        'ImgIniAlm.Visible = True
        'ImgIniAlmHover.Visible = False
    End Sub

    Private Sub ImgFimAlm_MouseEnter(sender As Object, e As EventArgs) Handles ImgFimAlm.MouseEnter
        ImgFimAlmHover.Visible = True
        ImgFimAlm.Visible = False
    End Sub

    Private Sub ImgFimAlm_MouseLeave(sender As Object, e As EventArgs) Handles ImgFimAlm.MouseLeave
        'ImgFimAlm.Visible = True
        'ImgFimAlmHover.Visible = False
    End Sub

    Private Sub ImgSaida_MouseEnter(sender As Object, e As EventArgs) Handles ImgSaida.MouseEnter
        ImgSaidaHover.Visible = True
        ImgSaida.Visible = False
    End Sub

    Private Sub ImgSaida_MouseLeave(sender As Object, e As EventArgs) Handles ImgSaida.MouseLeave
        'ImgSaida.Visible = True
        'ImgSaidaHover.Visible = False
    End Sub

    Private Sub ImgEntradaHover_MouseLeave(sender As Object, e As EventArgs) Handles ImgEntradaHover.MouseLeave
        ImgEntrada.Visible = True
        ImgEntradaHover.Visible = False
    End Sub

    Private Sub ImgIniAlmHover_MouseLeave(sender As Object, e As EventArgs) Handles ImgIniAlmHover.MouseLeave
        ImgIniAlm.Visible = True
        ImgIniAlmHover.Visible = False
    End Sub

    Private Sub ImgFimAlmHover_MouseLeave(sender As Object, e As EventArgs) Handles ImgFimAlmHover.MouseLeave
        ImgFimAlm.Visible = True
        ImgFimAlmHover.Visible = False
    End Sub

    Private Sub ImgSaidaHover_MouseLeave(sender As Object, e As EventArgs) Handles ImgSaidaHover.MouseLeave
        ImgSaida.Visible = True
        ImgSaidaHover.Visible = False
    End Sub
End Class