<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuAluno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAluno))
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Lb_menu_principal_aluno = New System.Windows.Forms.Label()
        Me.Btn_consultarDisciplinas = New Guna.UI.WinForms.GunaButton()
        Me.Btn_consultarAvaliacoes = New Guna.UI.WinForms.GunaButton()
        Me.Btn_consultarNotas = New Guna.UI.WinForms.GunaButton()
        Me.Btn_consultarFaltas = New Guna.UI.WinForms.GunaButton()
        Me.Btn_arquivos = New Guna.UI.WinForms.GunaButton()
        Me.Btn_acessarArquivos = New Guna.UI.WinForms.GunaButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Btn_voltar.Location = New System.Drawing.Point(430, 458)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 34
        Me.Btn_voltar.Text = "Sair"
        '
        'Lb_bemvindo
        '
        Me.Lb_bemvindo.AutoSize = True
        Me.Lb_bemvindo.Font = New System.Drawing.Font("Segoe UI Semibold", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_bemvindo.Location = New System.Drawing.Point(135, 59)
        Me.Lb_bemvindo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_bemvindo.Name = "Lb_bemvindo"
        Me.Lb_bemvindo.Size = New System.Drawing.Size(254, 45)
        Me.Lb_bemvindo.TabIndex = 33
        Me.Lb_bemvindo.Text = "Menu do Aluno"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Pnl_menu
        '
        Me.Pnl_menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_menu.Controls.Add(Me.Lb_menu_principal_aluno)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-1, -5)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(538, 57)
        Me.Pnl_menu.TabIndex = 41
        '
        'Lb_menu_principal_aluno
        '
        Me.Lb_menu_principal_aluno.AutoSize = True
        Me.Lb_menu_principal_aluno.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_menu_principal_aluno.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_menu_principal_aluno.Location = New System.Drawing.Point(53, 14)
        Me.Lb_menu_principal_aluno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_menu_principal_aluno.Name = "Lb_menu_principal_aluno"
        Me.Lb_menu_principal_aluno.Size = New System.Drawing.Size(217, 32)
        Me.Lb_menu_principal_aluno.TabIndex = 4
        Me.Lb_menu_principal_aluno.Text = "MENU PRINCIPAL"
        '
        'Btn_consultarDisciplinas
        '
        Me.Btn_consultarDisciplinas.AnimationHoverSpeed = 0.07!
        Me.Btn_consultarDisciplinas.AnimationSpeed = 0.03!
        Me.Btn_consultarDisciplinas.BackColor = System.Drawing.Color.Transparent
        Me.Btn_consultarDisciplinas.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_consultarDisciplinas.BorderColor = System.Drawing.Color.Black
        Me.Btn_consultarDisciplinas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_consultarDisciplinas.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_consultarDisciplinas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_consultarDisciplinas.ForeColor = System.Drawing.Color.White
        Me.Btn_consultarDisciplinas.Image = CType(resources.GetObject("Btn_consultarDisciplinas.Image"), System.Drawing.Image)
        Me.Btn_consultarDisciplinas.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_consultarDisciplinas.Location = New System.Drawing.Point(147, 107)
        Me.Btn_consultarDisciplinas.Name = "Btn_consultarDisciplinas"
        Me.Btn_consultarDisciplinas.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_consultarDisciplinas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_consultarDisciplinas.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_consultarDisciplinas.OnHoverImage = Nothing
        Me.Btn_consultarDisciplinas.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_consultarDisciplinas.Radius = 2
        Me.Btn_consultarDisciplinas.Size = New System.Drawing.Size(226, 55)
        Me.Btn_consultarDisciplinas.TabIndex = 44
        Me.Btn_consultarDisciplinas.Text = "DISCIPLINAS"
        '
        'Btn_consultarAvaliacoes
        '
        Me.Btn_consultarAvaliacoes.AnimationHoverSpeed = 0.07!
        Me.Btn_consultarAvaliacoes.AnimationSpeed = 0.03!
        Me.Btn_consultarAvaliacoes.BackColor = System.Drawing.Color.Transparent
        Me.Btn_consultarAvaliacoes.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_consultarAvaliacoes.BorderColor = System.Drawing.Color.Black
        Me.Btn_consultarAvaliacoes.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_consultarAvaliacoes.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_consultarAvaliacoes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_consultarAvaliacoes.ForeColor = System.Drawing.Color.White
        Me.Btn_consultarAvaliacoes.Image = CType(resources.GetObject("Btn_consultarAvaliacoes.Image"), System.Drawing.Image)
        Me.Btn_consultarAvaliacoes.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_consultarAvaliacoes.Location = New System.Drawing.Point(147, 168)
        Me.Btn_consultarAvaliacoes.Name = "Btn_consultarAvaliacoes"
        Me.Btn_consultarAvaliacoes.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_consultarAvaliacoes.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_consultarAvaliacoes.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_consultarAvaliacoes.OnHoverImage = Nothing
        Me.Btn_consultarAvaliacoes.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_consultarAvaliacoes.Radius = 2
        Me.Btn_consultarAvaliacoes.Size = New System.Drawing.Size(226, 55)
        Me.Btn_consultarAvaliacoes.TabIndex = 45
        Me.Btn_consultarAvaliacoes.Text = "AVALIAÇÕES AGENDADAS"
        '
        'Btn_consultarNotas
        '
        Me.Btn_consultarNotas.AnimationHoverSpeed = 0.07!
        Me.Btn_consultarNotas.AnimationSpeed = 0.03!
        Me.Btn_consultarNotas.BackColor = System.Drawing.Color.Transparent
        Me.Btn_consultarNotas.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_consultarNotas.BorderColor = System.Drawing.Color.Black
        Me.Btn_consultarNotas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_consultarNotas.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_consultarNotas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_consultarNotas.ForeColor = System.Drawing.Color.White
        Me.Btn_consultarNotas.Image = CType(resources.GetObject("Btn_consultarNotas.Image"), System.Drawing.Image)
        Me.Btn_consultarNotas.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_consultarNotas.Location = New System.Drawing.Point(147, 229)
        Me.Btn_consultarNotas.Name = "Btn_consultarNotas"
        Me.Btn_consultarNotas.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_consultarNotas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_consultarNotas.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_consultarNotas.OnHoverImage = Nothing
        Me.Btn_consultarNotas.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_consultarNotas.Radius = 2
        Me.Btn_consultarNotas.Size = New System.Drawing.Size(226, 55)
        Me.Btn_consultarNotas.TabIndex = 46
        Me.Btn_consultarNotas.Text = "NOTAS"
        '
        'Btn_consultarFaltas
        '
        Me.Btn_consultarFaltas.AnimationHoverSpeed = 0.07!
        Me.Btn_consultarFaltas.AnimationSpeed = 0.03!
        Me.Btn_consultarFaltas.BackColor = System.Drawing.Color.Transparent
        Me.Btn_consultarFaltas.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_consultarFaltas.BorderColor = System.Drawing.Color.Black
        Me.Btn_consultarFaltas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_consultarFaltas.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_consultarFaltas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_consultarFaltas.ForeColor = System.Drawing.Color.White
        Me.Btn_consultarFaltas.Image = CType(resources.GetObject("Btn_consultarFaltas.Image"), System.Drawing.Image)
        Me.Btn_consultarFaltas.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_consultarFaltas.Location = New System.Drawing.Point(147, 290)
        Me.Btn_consultarFaltas.Name = "Btn_consultarFaltas"
        Me.Btn_consultarFaltas.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_consultarFaltas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_consultarFaltas.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_consultarFaltas.OnHoverImage = Nothing
        Me.Btn_consultarFaltas.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_consultarFaltas.Radius = 2
        Me.Btn_consultarFaltas.Size = New System.Drawing.Size(226, 55)
        Me.Btn_consultarFaltas.TabIndex = 47
        Me.Btn_consultarFaltas.Text = "FALTAS"
        '
        'Btn_arquivos
        '
        Me.Btn_arquivos.AnimationHoverSpeed = 0.07!
        Me.Btn_arquivos.AnimationSpeed = 0.03!
        Me.Btn_arquivos.BackColor = System.Drawing.Color.Transparent
        Me.Btn_arquivos.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_arquivos.BorderColor = System.Drawing.Color.Black
        Me.Btn_arquivos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_arquivos.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_arquivos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_arquivos.ForeColor = System.Drawing.Color.White
        Me.Btn_arquivos.Image = CType(resources.GetObject("Btn_arquivos.Image"), System.Drawing.Image)
        Me.Btn_arquivos.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_arquivos.Location = New System.Drawing.Point(147, 351)
        Me.Btn_arquivos.Name = "Btn_arquivos"
        Me.Btn_arquivos.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_arquivos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_arquivos.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_arquivos.OnHoverImage = Nothing
        Me.Btn_arquivos.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_arquivos.Radius = 2
        Me.Btn_arquivos.Size = New System.Drawing.Size(226, 55)
        Me.Btn_arquivos.TabIndex = 48
        Me.Btn_arquivos.Text = "ENVIAR ARQUIVOS"
        Me.Btn_arquivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_acessarArquivos
        '
        Me.Btn_acessarArquivos.AnimationHoverSpeed = 0.07!
        Me.Btn_acessarArquivos.AnimationSpeed = 0.03!
        Me.Btn_acessarArquivos.BackColor = System.Drawing.Color.Transparent
        Me.Btn_acessarArquivos.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_acessarArquivos.BorderColor = System.Drawing.Color.Black
        Me.Btn_acessarArquivos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_acessarArquivos.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_acessarArquivos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_acessarArquivos.ForeColor = System.Drawing.Color.White
        Me.Btn_acessarArquivos.Image = CType(resources.GetObject("Btn_acessarArquivos.Image"), System.Drawing.Image)
        Me.Btn_acessarArquivos.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_acessarArquivos.Location = New System.Drawing.Point(147, 412)
        Me.Btn_acessarArquivos.Name = "Btn_acessarArquivos"
        Me.Btn_acessarArquivos.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_acessarArquivos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_acessarArquivos.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_acessarArquivos.OnHoverImage = Nothing
        Me.Btn_acessarArquivos.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_acessarArquivos.Radius = 2
        Me.Btn_acessarArquivos.Size = New System.Drawing.Size(226, 55)
        Me.Btn_acessarArquivos.TabIndex = 49
        Me.Btn_acessarArquivos.Text = "  ACESSAR ARQUIVOS"
        Me.Btn_acessarArquivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(533, 497)
        Me.Controls.Add(Me.Btn_acessarArquivos)
        Me.Controls.Add(Me.Btn_arquivos)
        Me.Controls.Add(Me.Btn_consultarFaltas)
        Me.Controls.Add(Me.Btn_consultarNotas)
        Me.Controls.Add(Me.Btn_consultarAvaliacoes)
        Me.Controls.Add(Me.Btn_consultarDisciplinas)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Name = "MenuAluno"
        Me.Text = "Menu Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Lb_bemvindo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Lb_menu_principal_aluno As Label
    Friend WithEvents Btn_consultarDisciplinas As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_consultarAvaliacoes As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_consultarNotas As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_consultarFaltas As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_arquivos As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_acessarArquivos As Guna.UI.WinForms.GunaButton
End Class
