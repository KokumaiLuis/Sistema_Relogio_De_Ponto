Imports System.Data.SqlClient

Public Class TB_Login
    Inherits Conexao

    Public exito As Boolean

    Public Sub Insert(ByVal VstrSQL As String)
        Try
            Open()
            Comando = New SqlCommand(VstrSQL, ObjCon)
            Comando.ExecuteNonQuery()
            Me.Exito = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Exito = False
        Finally
            Close()
        End Try
    End Sub

End Class
