<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GerenciamentoDisciplinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_GerenciamentoDisciplinas))
        Me.Gb_disciplina = New System.Windows.Forms.GroupBox()
        Me.Cmb_nome_turma = New System.Windows.Forms.ComboBox()
        Me.Cmb_nome_disciplina = New System.Windows.Forms.ComboBox()
        Me.Cmb_nome_professor = New System.Windows.Forms.ComboBox()
        Me.Lb_nome_turma = New System.Windows.Forms.Label()
        Me.Lb_disciplina = New System.Windows.Forms.Label()
        Me.Lb_nome = New System.Windows.Forms.Label()
        Me.Lb_gerenciamento_edicao_disciplinas = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Btn_limpar_campos = New Guna.UI.WinForms.GunaButton()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_cadastrar = New Guna.UI.WinForms.GunaButton()
        Me.Gb_disciplina.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb_disciplina
        '
        Me.Gb_disciplina.Controls.Add(Me.Btn_cadastrar)
        Me.Gb_disciplina.Controls.Add(Me.Cmb_nome_turma)
        Me.Gb_disciplina.Controls.Add(Me.Cmb_nome_disciplina)
        Me.Gb_disciplina.Controls.Add(Me.Cmb_nome_professor)
        Me.Gb_disciplina.Controls.Add(Me.Lb_nome_turma)
        Me.Gb_disciplina.Controls.Add(Me.Lb_disciplina)
        Me.Gb_disciplina.Controls.Add(Me.Lb_nome)
        Me.Gb_disciplina.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_disciplina.Location = New System.Drawing.Point(126, 58)
        Me.Gb_disciplina.Margin = New System.Windows.Forms.Padding(2)
        Me.Gb_disciplina.Name = "Gb_disciplina"
        Me.Gb_disciplina.Padding = New System.Windows.Forms.Padding(2)
        Me.Gb_disciplina.Size = New System.Drawing.Size(274, 260)
        Me.Gb_disciplina.TabIndex = 32
        Me.Gb_disciplina.TabStop = False
        Me.Gb_disciplina.Text = "Insira os Dados de Disciplina"
        '
        'Cmb_nome_turma
        '
        Me.Cmb_nome_turma.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_nome_turma.FormattingEnabled = True
        Me.Cmb_nome_turma.Location = New System.Drawing.Point(57, 156)
        Me.Cmb_nome_turma.Name = "Cmb_nome_turma"
        Me.Cmb_nome_turma.Size = New System.Drawing.Size(157, 29)
        Me.Cmb_nome_turma.TabIndex = 15
        '
        'Cmb_nome_disciplina
        '
        Me.Cmb_nome_disciplina.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_nome_disciplina.FormattingEnabled = True
        Me.Cmb_nome_disciplina.Location = New System.Drawing.Point(56, 99)
        Me.Cmb_nome_disciplina.Name = "Cmb_nome_disciplina"
        Me.Cmb_nome_disciplina.Size = New System.Drawing.Size(157, 29)
        Me.Cmb_nome_disciplina.TabIndex = 14
        '
        'Cmb_nome_professor
        '
        Me.Cmb_nome_professor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_nome_professor.FormattingEnabled = True
        Me.Cmb_nome_professor.Location = New System.Drawing.Point(56, 45)
        Me.Cmb_nome_professor.Name = "Cmb_nome_professor"
        Me.Cmb_nome_professor.Size = New System.Drawing.Size(157, 29)
        Me.Cmb_nome_professor.TabIndex = 13
        '
        'Lb_nome_turma
        '
        Me.Lb_nome_turma.AutoSize = True
        Me.Lb_nome_turma.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_nome_turma.Location = New System.Drawing.Point(55, 140)
        Me.Lb_nome_turma.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_nome_turma.Name = "Lb_nome_turma"
        Me.Lb_nome_turma.Size = New System.Drawing.Size(88, 13)
        Me.Lb_nome_turma.TabIndex = 9
        Me.Lb_nome_turma.Text = "Nome da Turma"
        '
        'Lb_disciplina
        '
        Me.Lb_disciplina.AutoSize = True
        Me.Lb_disciplina.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_disciplina.Location = New System.Drawing.Point(55, 83)
        Me.Lb_disciplina.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_disciplina.Name = "Lb_disciplina"
        Me.Lb_disciplina.Size = New System.Drawing.Size(106, 13)
        Me.Lb_disciplina.TabIndex = 10
        Me.Lb_disciplina.Text = "Nome da Disciplina"
        '
        'Lb_nome
        '
        Me.Lb_nome.AutoSize = True
        Me.Lb_nome.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_nome.Location = New System.Drawing.Point(55, 29)
        Me.Lb_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_nome.Name = "Lb_nome"
        Me.Lb_nome.Size = New System.Drawing.Size(105, 13)
        Me.Lb_nome.TabIndex = 11
        Me.Lb_nome.Text = "Nome do Professor"
        '
        'Lb_gerenciamento_edicao_disciplinas
        '
        Me.Lb_gerenciamento_edicao_disciplinas.AutoSize = True
        Me.Lb_gerenciamento_edicao_disciplinas.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_gerenciamento_edicao_disciplinas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_gerenciamento_edicao_disciplinas.Location = New System.Drawing.Point(56, 14)
        Me.Lb_gerenciamento_edicao_disciplinas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_gerenciamento_edicao_disciplinas.Name = "Lb_gerenciamento_edicao_disciplinas"
        Me.Lb_gerenciamento_edicao_disciplinas.Size = New System.Drawing.Size(409, 32)
        Me.Lb_gerenciamento_edicao_disciplinas.TabIndex = 4
        Me.Lb_gerenciamento_edicao_disciplinas.Text = "GERENCIAMENTO DE DISCIPLINAS"
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
        Me.Pnl_menu.Controls.Add(Me.Lb_gerenciamento_edicao_disciplinas)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-2, -5)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(546, 57)
        Me.Pnl_menu.TabIndex = 57
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
        Me.Btn_limpar_campos.Location = New System.Drawing.Point(405, 257)
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
        Me.Btn_voltar.Location = New System.Drawing.Point(430, 290)
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
        'Btn_cadastrar
        '
        Me.Btn_cadastrar.AnimationHoverSpeed = 0.07!
        Me.Btn_cadastrar.AnimationSpeed = 0.03!
        Me.Btn_cadastrar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_cadastrar.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_cadastrar.BorderColor = System.Drawing.Color.Black
        Me.Btn_cadastrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_cadastrar.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_cadastrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.Btn_cadastrar.Image = Nothing
        Me.Btn_cadastrar.ImageSize = New System.Drawing.Size(30, 30)
        Me.Btn_cadastrar.Location = New System.Drawing.Point(37, 199)
        Me.Btn_cadastrar.Name = "Btn_cadastrar"
        Me.Btn_cadastrar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_cadastrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_cadastrar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_cadastrar.OnHoverImage = Nothing
        Me.Btn_cadastrar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_cadastrar.Radius = 2
        Me.Btn_cadastrar.Size = New System.Drawing.Size(198, 38)
        Me.Btn_cadastrar.TabIndex = 60
        Me.Btn_cadastrar.Text = "CADASTRAR"
        Me.Btn_cadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_GerenciamentoDisciplinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 329)
        Me.Controls.Add(Me.Btn_limpar_campos)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Gb_disciplina)
        Me.Name = "Frm_GerenciamentoDisciplinas"
        Me.Text = "Gerenciamento e Edição de Disciplinas"
        Me.Gb_disciplina.ResumeLayout(False)
        Me.Gb_disciplina.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gb_disciplina As GroupBox
    Friend WithEvents Lb_nome_turma As Label
    Friend WithEvents Lb_disciplina As Label
    Friend WithEvents Lb_nome As Label
    Friend WithEvents Cmb_nome_disciplina As ComboBox
    Friend WithEvents Cmb_nome_professor As ComboBox
    Friend WithEvents Cmb_nome_turma As ComboBox
    Friend WithEvents Lb_gerenciamento_edicao_disciplinas As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Btn_limpar_campos As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_cadastrar As Guna.UI.WinForms.GunaButton
End Class
