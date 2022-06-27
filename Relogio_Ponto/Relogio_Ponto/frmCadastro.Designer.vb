<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCadastro = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCadastro
        '
        Me.lblCadastro.AutoSize = True
        Me.lblCadastro.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCadastro.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblCadastro.Location = New System.Drawing.Point(42, 21)
        Me.lblCadastro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCadastro.Name = "lblCadastro"
        Me.lblCadastro.Size = New System.Drawing.Size(454, 48)
        Me.lblCadastro.TabIndex = 5
        Me.lblCadastro.Text = "Cadastro de Novo Usuário"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUsuario.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblUsuario.Location = New System.Drawing.Point(94, 109)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(70, 20)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "Usuário*"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(163, 106)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(226, 27)
        Me.txtUsuario.TabIndex = 3
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(163, 150)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(226, 27)
        Me.txtSenha.TabIndex = 3
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSenha.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSenha.Location = New System.Drawing.Point(94, 153)
        Me.lblSenha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(59, 20)
        Me.lblSenha.TabIndex = 4
        Me.lblSenha.Text = "Senha*"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(263, 215)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 27)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGravar
        '
        Me.btnGravar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGravar.ForeColor = System.Drawing.Color.White
        Me.btnGravar.Location = New System.Drawing.Point(156, 215)
        Me.btnGravar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(90, 27)
        Me.btnGravar.TabIndex = 6
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = False
        '
        'frmCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(503, 268)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblCadastro)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "frmCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCadastro As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents lblSenha As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGravar As Button
End Class
