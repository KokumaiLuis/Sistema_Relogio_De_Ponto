Imports System.Data.SqlClient

Public Class TB_Login
    Inherits Conexao

    Public exito As Boolean

    Public Lusuario As List(Of String)
    Public LSenha As List(Of String)

    Public Sub Insert(ByVal VstrSQL As String)
        Try
            Open()
            Comando = New SqlCommand(VstrSQL, ObjCon)
            Comando.ExecuteNonQuery()
            Me.exito = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.exito = False
        Finally
            Close()
        End Try
    End Sub

    Public Sub SelectValues(ByVal VstrSQL As String)
        Me.Lusuario = New List(Of String)
        Me.LSenha = New List(Of String)

        Try
            Open()
            Comando = New SqlCommand(VstrSQL, ObjCon)
            Dr = Comando.ExecuteReader
            Do While Dr.Read
                Me.Lusuario.Add("USUARIO_LOG")
                Me.LSenha.Add("USUARIO_LOG")
            Loop
            Me.exito = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.exito = False
        Finally
            Dr.Close()
            Close()
        End Try

    End Sub

End Class
