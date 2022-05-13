Imports System.Data.SqlClient

Public Class TB_Horas
    Inherits Conexao

    Public Exito As Boolean
    Public DataAtual As String
    Public HoraAtual As String

    Public LId_Horas As List(Of Integer)
    Public LNom_Log As List(Of String)
    Public LData As List(Of String)
    Public LEntrada As List(Of String)
    Public LInic_Alm As List(Of String)
    Public LFim_Alm As List(Of String)
    Public LSaida As List(Of String)
    Public LModo As List(Of String)

    Public Sub RetornaHoras(ByVal VstrSQL As String)

        Me.Exito = True
        Me.HoraAtual = ""

        Try
            Open()
            Comando = New SqlCommand(VstrSQL, ObjCon)
            Dr = Comando.ExecuteReader
            If Dr.Read() = True Then
                Me.HoraAtual = Dr("HORA")
            Else
                Me.HoraAtual = ""
            End If
            Me.Exito = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Exito = False
        Finally
            Dr.Close()
            Close()
        End Try

    End Sub

    Public Sub RetornaData(ByVal VstrSQL As String)

        Me.Exito = True
        Me.DataAtual = ""

        Try
            Open()
            Comando = New SqlCommand(VstrSQL, ObjCon)
            Dr = Comando.ExecuteReader
            If Dr.Read() = True Then
                Me.DataAtual = Dr("DATA")
            Else
                Me.DataAtual = ""
            End If
            Me.Exito = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Exito = False
        Finally
            Dr.Close()
            Close()
        End Try

    End Sub

    Public Sub RetornaMarcacoes(ByVal VstrSQL As String)

        Me.Exito = False
        Me.LId_Horas = New List(Of Integer)
        Me.LNom_Log = New List(Of String)
        Me.LData = New List(Of String)
        Me.LEntrada = New List(Of String)
        Me.LInic_Alm = New List(Of String)
        Me.LFim_Alm = New List(Of String)
        Me.LSaida = New List(Of String)
        Me.LModo = New List(Of String)

        Try
            Open()
            Comando = New SqlCommand(VstrSQL, ObjCon)
            Dr = Comando.ExecuteReader
            Do While Dr.Read
                Me.LId_Horas.Add(Dr("ID_HORAS"))
                Me.LNom_Log.Add(Dr("NOME"))
                Me.LData.Add(Dr("Data"))
                Me.LEntrada.Add(Dr("Entrada"))
                Me.LInic_Alm.Add(If(IsDBNull(Dr("Inicio_Almoco")), "00:00:00", Dr("Inicio_Almoco")))
                Me.LFim_Alm.Add(If(IsDBNull(Dr("Fim_Almoco")), "00:00:00", Dr("Fim_Almoco")))
                Me.LSaida.Add(If(IsDBNull(Dr("Saida")), "00:00:00", Dr("Saida")))
                Me.LModo.Add(Dr("Modo"))
            Loop
            Me.Exito = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Exito = False
        Finally
            Dr.Close()
            Close()
        End Try

    End Sub

    Public Sub VerificaMarcacoes(ByVal VstrSQL As String)

        Me.Exito = False
        Me.LId_Horas = New List(Of Integer)

        Try
            Open()
            Comando = New SqlCommand(VstrSQL, ObjCon)
            Dr = Comando.ExecuteReader
            Do While Dr.Read
                Me.LId_Horas.Add(Dr("ID_HORAS"))
            Loop
            Me.Exito = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Exito = False
        Finally
            Dr.Close()
            Close()
        End Try

    End Sub

    Public Sub SQLCommand(ByVal VstrSQL As String)
        Me.Exito = False

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
