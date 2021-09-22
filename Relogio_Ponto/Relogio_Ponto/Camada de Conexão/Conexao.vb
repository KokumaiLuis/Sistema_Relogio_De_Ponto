Imports System.Data.SqlClient

Public Class Conexao
    'String de Conexão com o Database, deve ser alterado de acordo com as configurações do servidor SQL
    Const ConexaoDB As String = "server=localhost\SQLEXPRESS;database=DevDB;Integrated Security = True"

    'Verifica a conexão com o servidor
    Public Sub StrConexao()
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

    'Abre a conexão com o servidor
    Public Sub Open()
        Try
            If ObjCon.State = 1 Then ObjCon.Close()
            ObjCon.Open()
        Catch ex As Exception
            MessageBox.Show("Erro ao abrir Conexão!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Fecha a conexão com o servidor
    Public Sub Close()
        Try
            If ObjCon.State = 1 Then ObjCon.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao fechar Conexão!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
