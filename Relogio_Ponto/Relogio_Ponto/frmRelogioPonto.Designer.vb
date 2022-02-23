<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelogioPonto
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelogioPonto))
        Me.GridHorario = New System.Windows.Forms.DataGridView()
        Me.IdLog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomLog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InicAlm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FimAlm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRelogioPonto = New System.Windows.Forms.Label()
        Me.lblHorarioAtual = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.btnEntrada = New System.Windows.Forms.PictureBox()
        Me.lblEntrada = New System.Windows.Forms.Label()
        Me.btnInicAlm = New System.Windows.Forms.PictureBox()
        Me.lblInicAlm = New System.Windows.Forms.Label()
        Me.lblFimAlm = New System.Windows.Forms.Label()
        Me.btnFimAlm = New System.Windows.Forms.PictureBox()
        Me.lblSaida = New System.Windows.Forms.Label()
        Me.btnSaida = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.PictureBox()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.rbtnHomeOffice = New System.Windows.Forms.RadioButton()
        Me.rbtnPresencial = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.GridHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInicAlm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFimAlm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridHorario
        '
        Me.GridHorario.AllowUserToAddRows = False
        Me.GridHorario.AllowUserToDeleteRows = False
        Me.GridHorario.AllowUserToResizeColumns = False
        Me.GridHorario.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridHorario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridHorario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLog, Me.NomLog, Me.Data, Me.Entrada, Me.InicAlm, Me.FimAlm, Me.Saida, Me.Modo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridHorario.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridHorario.EnableHeadersVisualStyles = False
        Me.GridHorario.Location = New System.Drawing.Point(30, 529)
        Me.GridHorario.Name = "GridHorario"
        Me.GridHorario.RowHeadersWidth = 62
        Me.GridHorario.RowTemplate.Height = 33
        Me.GridHorario.Size = New System.Drawing.Size(1172, 277)
        Me.GridHorario.TabIndex = 0
        '
        'IdLog
        '
        Me.IdLog.HeaderText = "IdLog"
        Me.IdLog.MinimumWidth = 8
        Me.IdLog.Name = "IdLog"
        Me.IdLog.Visible = False
        Me.IdLog.Width = 150
        '
        'NomLog
        '
        Me.NomLog.HeaderText = "Nome"
        Me.NomLog.MinimumWidth = 8
        Me.NomLog.Name = "NomLog"
        Me.NomLog.Width = 90
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.MinimumWidth = 8
        Me.Data.Name = "Data"
        Me.Data.Width = 80
        '
        'Entrada
        '
        Me.Entrada.HeaderText = "Entrada"
        Me.Entrada.MinimumWidth = 8
        Me.Entrada.Name = "Entrada"
        Me.Entrada.Width = 110
        '
        'InicAlm
        '
        Me.InicAlm.HeaderText = "Início Almoço"
        Me.InicAlm.MinimumWidth = 8
        Me.InicAlm.Name = "InicAlm"
        Me.InicAlm.Width = 140
        '
        'FimAlm
        '
        Me.FimAlm.HeaderText = "Fim Almoço"
        Me.FimAlm.MinimumWidth = 8
        Me.FimAlm.Name = "FimAlm"
        Me.FimAlm.Width = 140
        '
        'Saida
        '
        Me.Saida.HeaderText = "Saída"
        Me.Saida.MinimumWidth = 8
        Me.Saida.Name = "Saida"
        Me.Saida.Width = 110
        '
        'Modo
        '
        Me.Modo.HeaderText = "Modo"
        Me.Modo.MinimumWidth = 8
        Me.Modo.Name = "Modo"
        Me.Modo.Width = 150
        '
        'lblRelogioPonto
        '
        Me.lblRelogioPonto.AutoSize = True
        Me.lblRelogioPonto.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRelogioPonto.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblRelogioPonto.Location = New System.Drawing.Point(461, 33)
        Me.lblRelogioPonto.Name = "lblRelogioPonto"
        Me.lblRelogioPonto.Size = New System.Drawing.Size(340, 55)
        Me.lblRelogioPonto.TabIndex = 3
        Me.lblRelogioPonto.Text = "Relógio de Ponto"
        '
        'lblHorarioAtual
        '
        Me.lblHorarioAtual.AutoSize = True
        Me.lblHorarioAtual.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHorarioAtual.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblHorarioAtual.Location = New System.Drawing.Point(513, 102)
        Me.lblHorarioAtual.Name = "lblHorarioAtual"
        Me.lblHorarioAtual.Size = New System.Drawing.Size(232, 45)
        Me.lblHorarioAtual.TabIndex = 4
        Me.lblHorarioAtual.Text = "Horário Atual"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHora.ForeColor = System.Drawing.Color.LightSlateGray
        Me.lblHora.Location = New System.Drawing.Point(553, 189)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(143, 39)
        Me.lblHora.TabIndex = 4
        Me.lblHora.Text = "00:00:00"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblData.ForeColor = System.Drawing.Color.LightSlateGray
        Me.lblData.Location = New System.Drawing.Point(535, 147)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(181, 39)
        Me.lblData.TabIndex = 4
        Me.lblData.Text = "00/00/0000"
        '
        'btnEntrada
        '
        Me.btnEntrada.Image = CType(resources.GetObject("btnEntrada.Image"), System.Drawing.Image)
        Me.btnEntrada.Location = New System.Drawing.Point(55, 362)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(84, 94)
        Me.btnEntrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEntrada.TabIndex = 5
        Me.btnEntrada.TabStop = False
        '
        'lblEntrada
        '
        Me.lblEntrada.AutoSize = True
        Me.lblEntrada.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEntrada.ForeColor = System.Drawing.Color.LightSlateGray
        Me.lblEntrada.Location = New System.Drawing.Point(40, 459)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(123, 39)
        Me.lblEntrada.TabIndex = 4
        Me.lblEntrada.Text = "Entrada"
        '
        'btnInicAlm
        '
        Me.btnInicAlm.Image = CType(resources.GetObject("btnInicAlm.Image"), System.Drawing.Image)
        Me.btnInicAlm.Location = New System.Drawing.Point(402, 362)
        Me.btnInicAlm.Name = "btnInicAlm"
        Me.btnInicAlm.Size = New System.Drawing.Size(84, 94)
        Me.btnInicAlm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnInicAlm.TabIndex = 6
        Me.btnInicAlm.TabStop = False
        '
        'lblInicAlm
        '
        Me.lblInicAlm.AutoSize = True
        Me.lblInicAlm.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInicAlm.ForeColor = System.Drawing.Color.LightSlateGray
        Me.lblInicAlm.Location = New System.Drawing.Point(351, 459)
        Me.lblInicAlm.Name = "lblInicAlm"
        Me.lblInicAlm.Size = New System.Drawing.Size(198, 39)
        Me.lblInicAlm.TabIndex = 4
        Me.lblInicAlm.Text = "Início Almoço"
        '
        'lblFimAlm
        '
        Me.lblFimAlm.AutoSize = True
        Me.lblFimAlm.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFimAlm.ForeColor = System.Drawing.Color.LightSlateGray
        Me.lblFimAlm.Location = New System.Drawing.Point(740, 459)
        Me.lblFimAlm.Name = "lblFimAlm"
        Me.lblFimAlm.Size = New System.Drawing.Size(170, 39)
        Me.lblFimAlm.TabIndex = 4
        Me.lblFimAlm.Text = "Fim Almoço"
        '
        'btnFimAlm
        '
        Me.btnFimAlm.Image = CType(resources.GetObject("btnFimAlm.Image"), System.Drawing.Image)
        Me.btnFimAlm.Location = New System.Drawing.Point(776, 362)
        Me.btnFimAlm.Name = "btnFimAlm"
        Me.btnFimAlm.Size = New System.Drawing.Size(84, 94)
        Me.btnFimAlm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnFimAlm.TabIndex = 6
        Me.btnFimAlm.TabStop = False
        '
        'lblSaida
        '
        Me.lblSaida.AutoSize = True
        Me.lblSaida.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSaida.ForeColor = System.Drawing.Color.LightSlateGray
        Me.lblSaida.Location = New System.Drawing.Point(1102, 460)
        Me.lblSaida.Name = "lblSaida"
        Me.lblSaida.Size = New System.Drawing.Size(92, 39)
        Me.lblSaida.TabIndex = 4
        Me.lblSaida.Text = "Saída"
        '
        'btnSaida
        '
        Me.btnSaida.Image = CType(resources.GetObject("btnSaida.Image"), System.Drawing.Image)
        Me.btnSaida.Location = New System.Drawing.Point(1090, 362)
        Me.btnSaida.Name = "btnSaida"
        Me.btnSaida.Size = New System.Drawing.Size(84, 94)
        Me.btnSaida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSaida.TabIndex = 5
        Me.btnSaida.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(1079, 818)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(43, 43)
        Me.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.TabStop = False
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLogout.ForeColor = System.Drawing.Color.Red
        Me.lblLogout.Location = New System.Drawing.Point(1130, 821)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(83, 31)
        Me.lblLogout.TabIndex = 4
        Me.lblLogout.Text = "Logout"
        '
        'rbtnHomeOffice
        '
        Me.rbtnHomeOffice.AutoSize = True
        Me.rbtnHomeOffice.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbtnHomeOffice.ForeColor = System.Drawing.Color.SteelBlue
        Me.rbtnHomeOffice.Location = New System.Drawing.Point(494, 264)
        Me.rbtnHomeOffice.Name = "rbtnHomeOffice"
        Me.rbtnHomeOffice.Size = New System.Drawing.Size(142, 28)
        Me.rbtnHomeOffice.TabIndex = 7
        Me.rbtnHomeOffice.TabStop = True
        Me.rbtnHomeOffice.Text = "Home Office"
        Me.rbtnHomeOffice.UseVisualStyleBackColor = True
        '
        'rbtnPresencial
        '
        Me.rbtnPresencial.AutoSize = True
        Me.rbtnPresencial.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbtnPresencial.ForeColor = System.Drawing.Color.SteelBlue
        Me.rbtnPresencial.Location = New System.Drawing.Point(647, 264)
        Me.rbtnPresencial.Name = "rbtnPresencial"
        Me.rbtnPresencial.Size = New System.Drawing.Size(118, 28)
        Me.rbtnPresencial.TabIndex = 7
        Me.rbtnPresencial.TabStop = True
        Me.rbtnPresencial.Text = "Presencial"
        Me.rbtnPresencial.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmRelogioPonto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1235, 871)
        Me.Controls.Add(Me.rbtnPresencial)
        Me.Controls.Add(Me.rbtnHomeOffice)
        Me.Controls.Add(Me.btnFimAlm)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnInicAlm)
        Me.Controls.Add(Me.btnSaida)
        Me.Controls.Add(Me.btnEntrada)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.lblFimAlm)
        Me.Controls.Add(Me.lblInicAlm)
        Me.Controls.Add(Me.lblSaida)
        Me.Controls.Add(Me.lblEntrada)
        Me.Controls.Add(Me.lblHorarioAtual)
        Me.Controls.Add(Me.lblRelogioPonto)
        Me.Controls.Add(Me.GridHorario)
        Me.Name = "frmRelogioPonto"
        Me.Text = "frmRelogioPonto"
        CType(Me.GridHorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInicAlm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFimAlm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridHorario As DataGridView
    Friend WithEvents lblRelogioPonto As Label
    Friend WithEvents lblHorarioAtual As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblData As Label
    Friend WithEvents btnEntrada As PictureBox
    Friend WithEvents lblEntrada As Label
    Friend WithEvents btnInicAlm As PictureBox
    Friend WithEvents lblInicAlm As Label
    Friend WithEvents lblFimAlm As Label
    Friend WithEvents btnFimAlm As PictureBox
    Friend WithEvents lblSaida As Label
    Friend WithEvents btnSaida As PictureBox
    Friend WithEvents btnLogout As PictureBox
    Friend WithEvents lblLogout As Label
    Friend WithEvents rbtnHomeOffice As RadioButton
    Friend WithEvents rbtnPresencial As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IdLog As DataGridViewTextBoxColumn
    Friend WithEvents NomLog As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Entrada As DataGridViewTextBoxColumn
    Friend WithEvents InicAlm As DataGridViewTextBoxColumn
    Friend WithEvents FimAlm As DataGridViewTextBoxColumn
    Friend WithEvents Saida As DataGridViewTextBoxColumn
    Friend WithEvents Modo As DataGridViewTextBoxColumn
End Class
