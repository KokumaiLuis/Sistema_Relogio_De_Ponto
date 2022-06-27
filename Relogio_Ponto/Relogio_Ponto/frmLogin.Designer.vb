<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCadastro = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(60, 134)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(226, 27)
        Me.txtUsuario.TabIndex = 0
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUsuario.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblUsuario.Location = New System.Drawing.Point(59, 103)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(62, 20)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuário"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(60, 205)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(226, 27)
        Me.txtSenha.TabIndex = 0
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSenha.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSenha.Location = New System.Drawing.Point(59, 174)
        Me.lblSenha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(51, 20)
        Me.lblSenha.TabIndex = 1
        Me.lblSenha.Text = "Senha"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLogin.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblLogin.Location = New System.Drawing.Point(124, 34)
        Me.lblLogin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(103, 48)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Login"
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.Location = New System.Drawing.Point(125, 261)
        Me.btnEntrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(90, 27)
        Me.btnEntrar.TabIndex = 3
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(91, 338)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Não possui login ainda?"
        '
        'lblCadastro
        '
        Me.lblCadastro.AutoSize = True
        Me.lblCadastro.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblCadastro.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCadastro.Location = New System.Drawing.Point(124, 358)
        Me.lblCadastro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCadastro.Name = "lblCadastro"
        Me.lblCadastro.Size = New System.Drawing.Size(93, 20)
        Me.lblCadastro.TabIndex = 1
        Me.lblCadastro.Text = "Cadastre-se"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(342, 404)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblCadastro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents lblSenha As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents btnEntrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCadastro As Label
End Class
