<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cadastroAvaliacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cadastroAvaliacao))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cb_turma = New System.Windows.Forms.ComboBox()
        Me.dtpDataAvaliacao = New System.Windows.Forms.DateTimePicker()
        Me.Lb_tipo_avaliacao = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lb_nome = New System.Windows.Forms.Label()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Cb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudPeso = New System.Windows.Forms.NumericUpDown()
        Me.Gb_avaliacao = New System.Windows.Forms.GroupBox()
        Me.Lb_cadastro_disciplina = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.btnSalvar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_limpar_campos = New Guna.UI.WinForms.GunaButton()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        CType(Me.nudPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_avaliacao.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Professor - Turma - Disciplina"
        '
        'Cb_turma
        '
        Me.Cb_turma.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_turma.FormattingEnabled = True
        Me.Cb_turma.Location = New System.Drawing.Point(22, 164)
        Me.Cb_turma.Name = "Cb_turma"
        Me.Cb_turma.Size = New System.Drawing.Size(282, 29)
        Me.Cb_turma.TabIndex = 3
        '
        'dtpDataAvaliacao
        '
        Me.dtpDataAvaliacao.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataAvaliacao.Location = New System.Drawing.Point(22, 223)
        Me.dtpDataAvaliacao.Name = "dtpDataAvaliacao"
        Me.dtpDataAvaliacao.Size = New System.Drawing.Size(282, 29)
        Me.dtpDataAvaliacao.TabIndex = 7
        '
        'Lb_tipo_avaliacao
        '
        Me.Lb_tipo_avaliacao.AutoSize = True
        Me.Lb_tipo_avaliacao.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_tipo_avaliacao.Location = New System.Drawing.Point(19, 86)
        Me.Lb_tipo_avaliacao.Name = "Lb_tipo_avaliacao"
        Me.Lb_tipo_avaliacao.Size = New System.Drawing.Size(97, 13)
        Me.Lb_tipo_avaliacao.TabIndex = 10
        Me.Lb_tipo_avaliacao.Text = "Tipo de Avaliação"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(207, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Peso"
        '
        'Lb_nome
        '
        Me.Lb_nome.AutoSize = True
        Me.Lb_nome.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_nome.Location = New System.Drawing.Point(19, 24)
        Me.Lb_nome.Name = "Lb_nome"
        Me.Lb_nome.Size = New System.Drawing.Size(37, 13)
        Me.Lb_nome.TabIndex = 14
        Me.Lb_nome.Text = "Nome"
        '
        'Txt_nome
        '
        Me.Txt_nome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nome.Location = New System.Drawing.Point(22, 40)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(169, 29)
        Me.Txt_nome.TabIndex = 13
        '
        'Cb_tipo
        '
        Me.Cb_tipo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_tipo.FormattingEnabled = True
        Me.Cb_tipo.Items.AddRange(New Object() {"N1", "N2", "N3"})
        Me.Cb_tipo.Location = New System.Drawing.Point(22, 102)
        Me.Cb_tipo.Name = "Cb_tipo"
        Me.Cb_tipo.Size = New System.Drawing.Size(169, 29)
        Me.Cb_tipo.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Data da Avaliação"
        '
        'nudPeso
        '
        Me.nudPeso.DecimalPlaces = 2
        Me.nudPeso.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPeso.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudPeso.Location = New System.Drawing.Point(210, 103)
        Me.nudPeso.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPeso.Name = "nudPeso"
        Me.nudPeso.Size = New System.Drawing.Size(85, 29)
        Me.nudPeso.TabIndex = 17
        Me.nudPeso.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'Gb_avaliacao
        '
        Me.Gb_avaliacao.Controls.Add(Me.btnSalvar)
        Me.Gb_avaliacao.Controls.Add(Me.Label2)
        Me.Gb_avaliacao.Controls.Add(Me.Cb_turma)
        Me.Gb_avaliacao.Controls.Add(Me.Label1)
        Me.Gb_avaliacao.Controls.Add(Me.dtpDataAvaliacao)
        Me.Gb_avaliacao.Controls.Add(Me.nudPeso)
        Me.Gb_avaliacao.Controls.Add(Me.Lb_nome)
        Me.Gb_avaliacao.Controls.Add(Me.Label5)
        Me.Gb_avaliacao.Controls.Add(Me.Cb_tipo)
        Me.Gb_avaliacao.Controls.Add(Me.Txt_nome)
        Me.Gb_avaliacao.Controls.Add(Me.Lb_tipo_avaliacao)
        Me.Gb_avaliacao.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_avaliacao.Location = New System.Drawing.Point(12, 68)
        Me.Gb_avaliacao.Name = "Gb_avaliacao"
        Me.Gb_avaliacao.Size = New System.Drawing.Size(333, 379)
        Me.Gb_avaliacao.TabIndex = 18
        Me.Gb_avaliacao.TabStop = False
        Me.Gb_avaliacao.Text = "Insira os Dados da Avaliação"
        '
        'Lb_cadastro_disciplina
        '
        Me.Lb_cadastro_disciplina.AutoSize = True
        Me.Lb_cadastro_disciplina.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cadastro_disciplina.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_cadastro_disciplina.Location = New System.Drawing.Point(56, 14)
        Me.Lb_cadastro_disciplina.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cadastro_disciplina.Name = "Lb_cadastro_disciplina"
        Me.Lb_cadastro_disciplina.Size = New System.Drawing.Size(381, 32)
        Me.Lb_cadastro_disciplina.TabIndex = 4
        Me.Lb_cadastro_disciplina.Text = "AGENDAMENTO DE AVALIAÇÃO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Pnl_menu
        '
        Me.Pnl_menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_menu.Controls.Add(Me.Lb_cadastro_disciplina)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-3, -5)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(512, 57)
        Me.Pnl_menu.TabIndex = 57
        '
        'btnSalvar
        '
        Me.btnSalvar.AnimationHoverSpeed = 0.07!
        Me.btnSalvar.AnimationSpeed = 0.03!
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.BaseColor = System.Drawing.Color.SteelBlue
        Me.btnSalvar.BorderColor = System.Drawing.Color.Black
        Me.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSalvar.FocusedColor = System.Drawing.Color.Empty
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.Image = Nothing
        Me.btnSalvar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSalvar.Location = New System.Drawing.Point(64, 310)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.btnSalvar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSalvar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSalvar.OnHoverImage = Nothing
        Me.btnSalvar.OnPressedColor = System.Drawing.Color.Black
        Me.btnSalvar.Radius = 2
        Me.btnSalvar.Size = New System.Drawing.Size(198, 38)
        Me.btnSalvar.TabIndex = 58
        Me.btnSalvar.Text = "AGENDAR"
        Me.btnSalvar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_limpar_campos
        '
        Me.Btn_limpar_campos.AnimationHoverSpeed = 0.07!
        Me.Btn_limpar_campos.AnimationSpeed = 0.03!
        Me.Btn_limpar_campos.BackColor = System.Drawing.Color.Transparent
        Me.Btn_limpar_campos.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_limpar_campos.BorderColor = System.Drawing.Color.Black
        Me.Btn_limpar_campos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_limpar_campos.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_limpar_campos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_limpar_campos.ForeColor = System.Drawing.Color.White
        Me.Btn_limpar_campos.Image = Nothing
        Me.Btn_limpar_campos.ImageSize = New System.Drawing.Size(22, 22)
        Me.Btn_limpar_campos.Location = New System.Drawing.Point(359, 387)
        Me.Btn_limpar_campos.Name = "Btn_limpar_campos"
        Me.Btn_limpar_campos.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_limpar_campos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_limpar_campos.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_limpar_campos.OnHoverImage = Nothing
        Me.Btn_limpar_campos.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_limpar_campos.Radius = 2
        Me.Btn_limpar_campos.Size = New System.Drawing.Size(116, 27)
        Me.Btn_limpar_campos.TabIndex = 59
        Me.Btn_limpar_campos.Text = "Limpar Campos"
        '
        'Btn_voltar
        '
        Me.Btn_voltar.AnimationHoverSpeed = 0.07!
        Me.Btn_voltar.AnimationSpeed = 0.03!
        Me.Btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_voltar.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_voltar.BorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_voltar.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_voltar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_voltar.ForeColor = System.Drawing.Color.White
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageSize = New System.Drawing.Size(22, 22)
        Me.Btn_voltar.Location = New System.Drawing.Point(384, 420)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 58
        Me.Btn_voltar.Text = "Voltar"
        '
        'Frm_cadastroAvaliacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(487, 459)
        Me.Controls.Add(Me.Btn_limpar_campos)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Gb_avaliacao)
        Me.Name = "Frm_cadastroAvaliacao"
        Me.Text = "Agendamento de Avaliação"
        CType(Me.nudPeso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_avaliacao.ResumeLayout(False)
        Me.Gb_avaliacao.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Cb_turma As ComboBox
    Friend WithEvents dtpDataAvaliacao As DateTimePicker
    Friend WithEvents Lb_tipo_avaliacao As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lb_nome As Label
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Cb_tipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nudPeso As NumericUpDown
    Friend WithEvents Gb_avaliacao As GroupBox
    Friend WithEvents Lb_cadastro_disciplina As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents btnSalvar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_limpar_campos As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
End Class
