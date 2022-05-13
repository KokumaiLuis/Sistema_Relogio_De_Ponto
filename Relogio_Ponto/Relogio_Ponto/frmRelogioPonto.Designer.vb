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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImgHomeOffice = New System.Windows.Forms.PictureBox()
        Me.ImgPresencial = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImgIniAlm = New System.Windows.Forms.PictureBox()
        Me.ImgFimAlm = New System.Windows.Forms.PictureBox()
        Me.ImgSaida = New System.Windows.Forms.PictureBox()
        Me.ImgEntrada = New System.Windows.Forms.PictureBox()
        Me.ImgEntradaHover = New System.Windows.Forms.PictureBox()
        Me.ImgIniAlmHover = New System.Windows.Forms.PictureBox()
        Me.ImgFimAlmHover = New System.Windows.Forms.PictureBox()
        Me.ImgSaidaHover = New System.Windows.Forms.PictureBox()
        CType(Me.GridHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgHomeOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgPresencial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgIniAlm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgFimAlm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSaida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgEntradaHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgIniAlmHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgFimAlmHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSaidaHover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridHorario
        '
        Me.GridHorario.AllowUserToAddRows = False
        Me.GridHorario.AllowUserToDeleteRows = False
        Me.GridHorario.AllowUserToResizeColumns = False
        Me.GridHorario.AllowUserToResizeRows = False
        Me.GridHorario.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridHorario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GridHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridHorario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLog, Me.NomLog, Me.Data, Me.Entrada, Me.InicAlm, Me.FimAlm, Me.Saida, Me.Modo})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridHorario.DefaultCellStyle = DataGridViewCellStyle6
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
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblHora.Location = New System.Drawing.Point(555, 147)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(135, 39)
        Me.lblHora.TabIndex = 4
        Me.lblHora.Text = "00:00:00"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblData.Location = New System.Drawing.Point(532, 105)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(181, 39)
        Me.lblData.TabIndex = 4
        Me.lblData.Text = "00/00/0000"
        '
        'btnLogout
        '
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(1173, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(50, 52)
        Me.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(402, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(431, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ImgHomeOffice
        '
        Me.ImgHomeOffice.Image = CType(resources.GetObject("ImgHomeOffice.Image"), System.Drawing.Image)
        Me.ImgHomeOffice.Location = New System.Drawing.Point(545, 207)
        Me.ImgHomeOffice.Name = "ImgHomeOffice"
        Me.ImgHomeOffice.Size = New System.Drawing.Size(156, 88)
        Me.ImgHomeOffice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgHomeOffice.TabIndex = 9
        Me.ImgHomeOffice.TabStop = False
        '
        'ImgPresencial
        '
        Me.ImgPresencial.Image = CType(resources.GetObject("ImgPresencial.Image"), System.Drawing.Image)
        Me.ImgPresencial.Location = New System.Drawing.Point(545, 207)
        Me.ImgPresencial.Name = "ImgPresencial"
        Me.ImgPresencial.Size = New System.Drawing.Size(156, 88)
        Me.ImgPresencial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgPresencial.TabIndex = 10
        Me.ImgPresencial.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(458, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 30)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Presencial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(674, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 30)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Home Office"
        '
        'ImgIniAlm
        '
        Me.ImgIniAlm.Image = CType(resources.GetObject("ImgIniAlm.Image"), System.Drawing.Image)
        Me.ImgIniAlm.Location = New System.Drawing.Point(346, 310)
        Me.ImgIniAlm.Name = "ImgIniAlm"
        Me.ImgIniAlm.Size = New System.Drawing.Size(227, 198)
        Me.ImgIniAlm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgIniAlm.TabIndex = 14
        Me.ImgIniAlm.TabStop = False
        '
        'ImgFimAlm
        '
        Me.ImgFimAlm.Image = CType(resources.GetObject("ImgFimAlm.Image"), System.Drawing.Image)
        Me.ImgFimAlm.Location = New System.Drawing.Point(674, 310)
        Me.ImgFimAlm.Name = "ImgFimAlm"
        Me.ImgFimAlm.Size = New System.Drawing.Size(227, 198)
        Me.ImgFimAlm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgFimAlm.TabIndex = 15
        Me.ImgFimAlm.TabStop = False
        '
        'ImgSaida
        '
        Me.ImgSaida.Image = CType(resources.GetObject("ImgSaida.Image"), System.Drawing.Image)
        Me.ImgSaida.Location = New System.Drawing.Point(975, 310)
        Me.ImgSaida.Name = "ImgSaida"
        Me.ImgSaida.Size = New System.Drawing.Size(227, 198)
        Me.ImgSaida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgSaida.TabIndex = 16
        Me.ImgSaida.TabStop = False
        '
        'ImgEntrada
        '
        Me.ImgEntrada.Image = CType(resources.GetObject("ImgEntrada.Image"), System.Drawing.Image)
        Me.ImgEntrada.Location = New System.Drawing.Point(30, 310)
        Me.ImgEntrada.Name = "ImgEntrada"
        Me.ImgEntrada.Size = New System.Drawing.Size(227, 198)
        Me.ImgEntrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgEntrada.TabIndex = 18
        Me.ImgEntrada.TabStop = False
        '
        'ImgEntradaHover
        '
        Me.ImgEntradaHover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgEntradaHover.Image = CType(resources.GetObject("ImgEntradaHover.Image"), System.Drawing.Image)
        Me.ImgEntradaHover.Location = New System.Drawing.Point(30, 310)
        Me.ImgEntradaHover.Name = "ImgEntradaHover"
        Me.ImgEntradaHover.Size = New System.Drawing.Size(227, 198)
        Me.ImgEntradaHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgEntradaHover.TabIndex = 19
        Me.ImgEntradaHover.TabStop = False
        Me.ImgEntradaHover.Visible = False
        '
        'ImgIniAlmHover
        '
        Me.ImgIniAlmHover.Image = CType(resources.GetObject("ImgIniAlmHover.Image"), System.Drawing.Image)
        Me.ImgIniAlmHover.Location = New System.Drawing.Point(346, 310)
        Me.ImgIniAlmHover.Name = "ImgIniAlmHover"
        Me.ImgIniAlmHover.Size = New System.Drawing.Size(227, 198)
        Me.ImgIniAlmHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgIniAlmHover.TabIndex = 20
        Me.ImgIniAlmHover.TabStop = False
        Me.ImgIniAlmHover.Visible = False
        '
        'ImgFimAlmHover
        '
        Me.ImgFimAlmHover.Image = CType(resources.GetObject("ImgFimAlmHover.Image"), System.Drawing.Image)
        Me.ImgFimAlmHover.Location = New System.Drawing.Point(674, 310)
        Me.ImgFimAlmHover.Name = "ImgFimAlmHover"
        Me.ImgFimAlmHover.Size = New System.Drawing.Size(227, 198)
        Me.ImgFimAlmHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgFimAlmHover.TabIndex = 21
        Me.ImgFimAlmHover.TabStop = False
        Me.ImgFimAlmHover.Visible = False
        '
        'ImgSaidaHover
        '
        Me.ImgSaidaHover.Image = CType(resources.GetObject("ImgSaidaHover.Image"), System.Drawing.Image)
        Me.ImgSaidaHover.Location = New System.Drawing.Point(975, 310)
        Me.ImgSaidaHover.Name = "ImgSaidaHover"
        Me.ImgSaidaHover.Size = New System.Drawing.Size(227, 198)
        Me.ImgSaidaHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgSaidaHover.TabIndex = 22
        Me.ImgSaidaHover.TabStop = False
        Me.ImgSaidaHover.Visible = False
        '
        'frmRelogioPonto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1235, 871)
        Me.Controls.Add(Me.ImgSaidaHover)
        Me.Controls.Add(Me.ImgFimAlmHover)
        Me.Controls.Add(Me.ImgIniAlmHover)
        Me.Controls.Add(Me.ImgEntradaHover)
        Me.Controls.Add(Me.ImgEntrada)
        Me.Controls.Add(Me.ImgSaida)
        Me.Controls.Add(Me.ImgFimAlm)
        Me.Controls.Add(Me.ImgIniAlm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImgPresencial)
        Me.Controls.Add(Me.ImgHomeOffice)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.GridHorario)
        Me.Name = "frmRelogioPonto"
        Me.Text = "frmRelogioPonto"
        CType(Me.GridHorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgHomeOffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgPresencial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgIniAlm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgFimAlm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSaida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgEntradaHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgIniAlmHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgFimAlmHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSaidaHover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridHorario As DataGridView
    Friend WithEvents lblHora As Label
    Friend WithEvents lblData As Label
    Friend WithEvents btnLogout As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IdLog As DataGridViewTextBoxColumn
    Friend WithEvents NomLog As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Entrada As DataGridViewTextBoxColumn
    Friend WithEvents InicAlm As DataGridViewTextBoxColumn
    Friend WithEvents FimAlm As DataGridViewTextBoxColumn
    Friend WithEvents Saida As DataGridViewTextBoxColumn
    Friend WithEvents Modo As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImgHomeOffice As PictureBox
    Friend WithEvents ImgPresencial As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ImgIniAlm As PictureBox
    Friend WithEvents ImgFimAlm As PictureBox
    Friend WithEvents ImgSaida As PictureBox
    Friend WithEvents ImgEntrada As PictureBox
    Friend WithEvents ImgEntradaHover As PictureBox
    Friend WithEvents ImgIniAlmHover As PictureBox
    Friend WithEvents ImgFimAlmHover As PictureBox
    Friend WithEvents ImgSaidaHover As PictureBox
End Class
