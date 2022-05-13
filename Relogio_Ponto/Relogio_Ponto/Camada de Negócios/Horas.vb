Public Class Horas
    Dim Hr As New TB_Horas

    Public Exito As Boolean
    Public Horas As String
    Public Data As String

    Public LId_Horas As List(Of Integer)
    Public LNom_Log As List(Of String)
    Public LData As List(Of String)
    Public LEntrada As List(Of String)
    Public LInic_Alm As List(Of String)
    Public LFim_Alm As List(Of String)
    Public LSaida As List(Of String)
    Public LModo As List(Of String)

    Public Sub RetornaHoras()
        Dim VstrSQL As String = "select convert(varchar(10), GETDATE(), 108) as HORA"

        Me.Exito = False
        Me.Horas = ""

        Hr.RetornaHoras(VstrSQL)

        Me.Horas = Hr.HoraAtual
        Me.Exito = Hr.Exito

    End Sub

    Public Sub RetornaData()
        Dim VstrSQL As String = "SELECT CONVERT(varchar(10), getdate(), 103) as DATA"

        Me.Exito = False
        Me.Data = ""

        Hr.RetornaData(VstrSQL)

        Me.Data = Hr.DataAtual
        Me.Exito = Hr.Exito

    End Sub

    Public Sub RetornaMarcacoes(ByVal IdLog As Integer)
        Dim VstrSQL As String = "SELECT A.ID_HORAS, B.USUARIO_LOG AS NOME, A.DATA, A.ENTRADA, A.INICIO_ALMOCO, A.FIM_ALMOCO, A.SAIDA, A.MODO 
                                 FROM TB_HORAS A INNER JOIN TB_LOGIN B ON A.ID_LOG = B.ID_LOG WHERE A.ID_LOG = " & IdLog

        Me.Exito = False
        Me.LId_Horas = New List(Of Integer)
        Me.LNom_Log = New List(Of String)
        Me.LData = New List(Of String)
        Me.LEntrada = New List(Of String)
        Me.LInic_Alm = New List(Of String)
        Me.LFim_Alm = New List(Of String)
        Me.LSaida = New List(Of String)
        Me.LModo = New List(Of String)

        Hr.RetornaMarcacoes(VstrSQL)

        Me.Exito = Hr.Exito
        Me.LId_Horas = Hr.LId_Horas
        Me.LNom_Log = Hr.LNom_Log
        Me.LData = Hr.LData
        Me.LEntrada = Hr.LEntrada
        Me.LInic_Alm = Hr.LInic_Alm
        Me.LFim_Alm = Hr.LFim_Alm
        Me.LSaida = Hr.LSaida
        Me.LModo = Hr.LModo

    End Sub

    Public Sub VerificaMarcacoes(ByVal IdLog As Integer,
                                ByVal Data As String)
        Dim VstrSQL As String = "SELECT ID_HORAS FROM TB_HORAS WHERE ID_LOG = " & IdLog & " AND DATA = '" & Data & "'"

        Me.Exito = False
        Me.LId_Horas = New List(Of Integer)

        Hr.VerificaMarcacoes(VstrSQL)

        Me.Exito = Hr.Exito
        Me.LId_Horas = Hr.LId_Horas

    End Sub

    Public Sub InsertHoraEntrada(ByVal Idlog As Integer,
                                 ByVal Data As String,
                                 ByVal HoraEntrada As String,
                                 ByVal Modo As String)
        Dim VstrSQL As String = "INSERT INTO TB_HORAS(ID_LOG, DATA, ENTRADA, MODO)
                                 VALUES(" & Idlog & ", '" & Data & "', '" & HoraEntrada & "', '" & Modo & "')"

        Me.Exito = False

        Hr.SQLCommand(VstrSQL)

        Me.Exito = Hr.Exito

    End Sub

    Public Sub InsertHoraAlmoco(ByVal IdHoras As Integer,
                                 ByVal HoraAlmoco As String)
        Dim VstrSQL As String = "UPDATE TB_HORAS SET INICIO_ALMOCO = '" & HoraAlmoco & "' WHERE ID_HORAS = " & IdHoras

        Me.Exito = False

        Hr.SQLCommand(VstrSQL)

        Me.Exito = Hr.Exito

    End Sub

End Class
