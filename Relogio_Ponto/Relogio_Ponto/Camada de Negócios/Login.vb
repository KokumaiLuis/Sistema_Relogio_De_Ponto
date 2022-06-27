Public Class Login
    Dim Log As New TB_Login

    Private Chave As String = "SEN"
    Public exito As Boolean

    Public Lusuario As List(Of String)
    Public Lsenha As List(Of String)

    Public Usuario As String
    Public Senha As String

    'Sub para gravar novo usuário
    Public Sub Gravar(ByVal usuario As String,
                      ByVal senha As String)
        Dim VstrSQL As String = "INSERT INTO [dbo].[TB_LOGIN]
                                       ([USUARIO_LOG]
                                       ,[SENHA_LOG])
                                 VALUES
                                        ('" & usuario &
                                        "','" & Encrypt(senha.Trim) & "')"

        Me.exito = False

        Log.Insert(VstrSQL)

        Me.exito = Log.exito
    End Sub

    'Sub para fazer o select do usuário e senha
    Public Sub SelectLista(ByVal usuario As String)
        Dim VstrSQL As String = "SELECT * FROM TB_LOGIN WHERE USUARIO_LOG = '" & usuario & "'"

        Me.Usuario = ""
        Me.Senha = ""

        Log.SelectValues(VstrSQL)

        Me.Usuario = Log.Usuario
        Me.Senha = Log.Senha
        Me.exito = Log.exito

    End Sub

    'Sub para encriptar senha
    Private Function Encrypt(ByVal text As String) As String
        Dim Key As List(Of String) = New List(Of String)
        Dim Pwd As String = ""
        Dim Ascc As Integer

        For x = 1 To Len(Chave)
            Key.Add(Asc(Mid(Chave, x, 1)))
        Next x

        Dim j As Integer
        For i As Integer = 0 To text.Length - 1
            j = IIf(j + 1 >= Len(Chave), 1, j + 1)
            Ascc = Asc(text.Substring(i, 1).ToUpper) + Key(j - 1)
            If Ascc > 255 Then Ascc = Ascc - 255
            Pwd = Pwd & Chr(Ascc)
        Next i
        Return Pwd
    End Function

End Class
