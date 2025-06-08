<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_menuTurmasDisciplinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_menuTurmasDisciplinas))
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Lb_cadastro_turmas_disciplinas = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_disciplina = New Guna.UI.WinForms.GunaButton()
        Me.Btn_turma = New Guna.UI.WinForms.GunaButton()
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        Me.Lb_acesso_restrito = New System.Windows.Forms.Label()
        Me.Pnl_menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl_menu
        '
        Me.Pnl_menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_menu.Controls.Add(Me.Lb_cadastro_turmas_disciplinas)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-5, -6)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(543, 57)
        Me.Pnl_menu.TabIndex = 41
        '
        'Lb_cadastro_turmas_disciplinas
        '
        Me.Lb_cadastro_turmas_disciplinas.AutoSize = True
        Me.Lb_cadastro_turmas_disciplinas.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cadastro_turmas_disciplinas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_cadastro_turmas_disciplinas.Location = New System.Drawing.Point(56, 14)
        Me.Lb_cadastro_turmas_disciplinas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cadastro_turmas_disciplinas.Name = "Lb_cadastro_turmas_disciplinas"
        Me.Lb_cadastro_turmas_disciplinas.Size = New System.Drawing.Size(460, 32)
        Me.Lb_cadastro_turmas_disciplinas.TabIndex = 4
        Me.Lb_cadastro_turmas_disciplinas.Text = "CADASTRO DE TURMAS E DISCIPLINAS"
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
        Me.Btn_voltar.Location = New System.Drawing.Point(430, 256)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 44
        Me.Btn_voltar.Text = "Voltar"
        '
        'Btn_disciplina
        '
        Me.Btn_disciplina.AnimationHoverSpeed = 0.07!
        Me.Btn_disciplina.AnimationSpeed = 0.03!
        Me.Btn_disciplina.BackColor = System.Drawing.Color.Transparent
        Me.Btn_disciplina.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_disciplina.BorderColor = System.Drawing.Color.Black
        Me.Btn_disciplina.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_disciplina.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_disciplina.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_disciplina.ForeColor = System.Drawing.Color.White
        Me.Btn_disciplina.Image = CType(resources.GetObject("Btn_disciplina.Image"), System.Drawing.Image)
        Me.Btn_disciplina.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_disciplina.Location = New System.Drawing.Point(136, 174)
        Me.Btn_disciplina.Name = "Btn_disciplina"
        Me.Btn_disciplina.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_disciplina.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_disciplina.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_disciplina.OnHoverImage = Nothing
        Me.Btn_disciplina.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_disciplina.Radius = 2
        Me.Btn_disciplina.Size = New System.Drawing.Size(260, 55)
        Me.Btn_disciplina.TabIndex = 43
        Me.Btn_disciplina.Text = "NOVA DISCIPLINA"
        '
        'Btn_turma
        '
        Me.Btn_turma.AnimationHoverSpeed = 0.07!
        Me.Btn_turma.AnimationSpeed = 0.03!
        Me.Btn_turma.BackColor = System.Drawing.Color.Transparent
        Me.Btn_turma.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_turma.BorderColor = System.Drawing.Color.Black
        Me.Btn_turma.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_turma.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_turma.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_turma.ForeColor = System.Drawing.Color.White
        Me.Btn_turma.Image = CType(resources.GetObject("Btn_turma.Image"), System.Drawing.Image)
        Me.Btn_turma.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_turma.Location = New System.Drawing.Point(136, 106)
        Me.Btn_turma.Name = "Btn_turma"
        Me.Btn_turma.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_turma.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_turma.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_turma.OnHoverImage = Nothing
        Me.Btn_turma.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_turma.Radius = 2
        Me.Btn_turma.Size = New System.Drawing.Size(260, 55)
        Me.Btn_turma.TabIndex = 42
        Me.Btn_turma.Text = "NOVA TURMA"
        '
        'Lb_bemvindo
        '
        Me.Lb_bemvindo.AutoSize = True
        Me.Lb_bemvindo.Font = New System.Drawing.Font("Segoe UI Semibold", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_bemvindo.Location = New System.Drawing.Point(109, 55)
        Me.Lb_bemvindo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_bemvindo.Name = "Lb_bemvindo"
        Me.Lb_bemvindo.Size = New System.Drawing.Size(315, 45)
        Me.Lb_bemvindo.TabIndex = 39
        Me.Lb_bemvindo.Text = "Área Administrativa"
        '
        'Lb_acesso_restrito
        '
        Me.Lb_acesso_restrito.AutoSize = True
        Me.Lb_acesso_restrito.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_acesso_restrito.Location = New System.Drawing.Point(12, 262)
        Me.Lb_acesso_restrito.Name = "Lb_acesso_restrito"
        Me.Lb_acesso_restrito.Size = New System.Drawing.Size(125, 21)
        Me.Lb_acesso_restrito.TabIndex = 40
        Me.Lb_acesso_restrito.Text = "Acesso Restrito"
        '
        'Frm_menuTurmasDisciplinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Btn_disciplina)
        Me.Controls.Add(Me.Btn_turma)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Controls.Add(Me.Lb_acesso_restrito)
        Me.Name = "Frm_menuTurmasDisciplinas"
        Me.Text = "Turmas e Disciplinas"
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Lb_cadastro_turmas_disciplinas As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_disciplina As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_turma As Guna.UI.WinForms.GunaButton
    Friend WithEvents Lb_bemvindo As Label
    Friend WithEvents Lb_acesso_restrito As Label
End Class
