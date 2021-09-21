Imports System.Data.SqlClient

Public Class Conexao

    Private Arquivo As New Arquivo

    Const ConexaoDB As String = "server=localhost\SQLEXPRESS;database=GRAFADM;Integrated Security = True"

    Public Sub StrConexao()
        Dim StringConexao As String = Arquivo.LerLinha(Application.StartupPath & "\StringCon.ini", 0)
        Try
            ObjCon = New SqlConnection(ConexaoDB)
            ObjCon.Open()
        Catch ex As Exception
            MessageBox.Show("Falha de Conexão!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        Finally
            ObjCon.Close()
        End Try
    End Sub

    Public Sub Open()
        Try
            If ObjCon.State = 1 Then ObjCon.Close()
            ObjCon.Open()
        Catch ex As Exception
            MessageBox.Show("Erro ao abrir Conexão!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Close()
        Try
            If ObjCon.State = 1 Then ObjCon.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao fechar Conexão!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
