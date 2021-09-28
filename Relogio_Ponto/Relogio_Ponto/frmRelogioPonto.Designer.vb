<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelogioPonto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelogioPonto))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblRelogioPonto = New System.Windows.Forms.Label()
        Me.lblHorarioAtual = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(96, 142)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1038, 233)
        Me.DataGridView1.TabIndex = 0
        '
        'lblRelogioPonto
        '
        Me.lblRelogioPonto.AutoSize = True
        Me.lblRelogioPonto.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRelogioPonto.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblRelogioPonto.Location = New System.Drawing.Point(462, 41)
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
        Me.lblHorarioAtual.Location = New System.Drawing.Point(499, 390)
        Me.lblHorarioAtual.Name = "lblHorarioAtual"
        Me.lblHorarioAtual.Size = New System.Drawing.Size(232, 45)
        Me.lblHorarioAtual.TabIndex = 4
        Me.lblHorarioAtual.Text = "Horário Atual"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHora.ForeColor = System.Drawing.Color.LightSlateGray
        Me.lblHora.Location = New System.Drawing.Point(535, 490)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(168, 45)
        Me.lblHora.TabIndex = 4
        Me.lblHora.Text = "00:00:00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label1.Location = New System.Drawing.Point(510, 443)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "00/00/0000"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(247, 573)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Location = New System.Drawing.Point(224, 670)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Entrada"
        '
        'frmRelogioPonto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1235, 765)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHorarioAtual)
        Me.Controls.Add(Me.lblRelogioPonto)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmRelogioPonto"
        Me.Text = "frmRelogioPonto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblRelogioPonto As Label
    Friend WithEvents lblHorarioAtual As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
