<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MenuGerenciamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_MenuGerenciamento))
        Me.Lb_gerenciamento = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Lb_acesso_restrito = New System.Windows.Forms.Label()
        Me.Btn_adm = New Guna.UI.WinForms.GunaButton()
        Me.Btn_professores = New Guna.UI.WinForms.GunaButton()
        Me.Btn_alunos = New Guna.UI.WinForms.GunaButton()
        Me.Btn_disciplinas = New Guna.UI.WinForms.GunaButton()
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_gerenciamento
        '
        Me.Lb_gerenciamento.AutoSize = True
        Me.Lb_gerenciamento.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_gerenciamento.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_gerenciamento.Location = New System.Drawing.Point(56, 14)
        Me.Lb_gerenciamento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_gerenciamento.Name = "Lb_gerenciamento"
        Me.Lb_gerenciamento.Size = New System.Drawing.Size(218, 32)
        Me.Lb_gerenciamento.TabIndex = 4
        Me.Lb_gerenciamento.Text = "GERENCIAMENTO"
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
        Me.Pnl_menu.Controls.Add(Me.Lb_gerenciamento)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-5, -6)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(543, 57)
        Me.Pnl_menu.TabIndex = 46
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
        Me.Btn_voltar.Location = New System.Drawing.Point(430, 338)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 47
        Me.Btn_voltar.Text = "Voltar"
        '
        'Lb_acesso_restrito
        '
        Me.Lb_acesso_restrito.AutoSize = True
        Me.Lb_acesso_restrito.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_acesso_restrito.Location = New System.Drawing.Point(12, 344)
        Me.Lb_acesso_restrito.Name = "Lb_acesso_restrito"
        Me.Lb_acesso_restrito.Size = New System.Drawing.Size(125, 21)
        Me.Lb_acesso_restrito.TabIndex = 45
        Me.Lb_acesso_restrito.Text = "Acesso Restrito"
        '
        'Btn_adm
        '
        Me.Btn_adm.AnimationHoverSpeed = 0.07!
        Me.Btn_adm.AnimationSpeed = 0.03!
        Me.Btn_adm.BackColor = System.Drawing.Color.Transparent
        Me.Btn_adm.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_adm.BorderColor = System.Drawing.Color.Black
        Me.Btn_adm.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_adm.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_adm.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_adm.ForeColor = System.Drawing.Color.White
        Me.Btn_adm.Image = CType(resources.GetObject("Btn_adm.Image"), System.Drawing.Image)
        Me.Btn_adm.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_adm.Location = New System.Drawing.Point(153, 227)
        Me.Btn_adm.Name = "Btn_adm"
        Me.Btn_adm.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_adm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_adm.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_adm.OnHoverImage = Nothing
        Me.Btn_adm.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_adm.Radius = 2
        Me.Btn_adm.Size = New System.Drawing.Size(226, 55)
        Me.Btn_adm.TabIndex = 50
        Me.Btn_adm.Text = "ADMINISTRADORES"
        '
        'Btn_professores
        '
        Me.Btn_professores.AnimationHoverSpeed = 0.07!
        Me.Btn_professores.AnimationSpeed = 0.03!
        Me.Btn_professores.BackColor = System.Drawing.Color.Transparent
        Me.Btn_professores.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_professores.BorderColor = System.Drawing.Color.Black
        Me.Btn_professores.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_professores.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_professores.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_professores.ForeColor = System.Drawing.Color.White
        Me.Btn_professores.Image = CType(resources.GetObject("Btn_professores.Image"), System.Drawing.Image)
        Me.Btn_professores.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_professores.Location = New System.Drawing.Point(153, 166)
        Me.Btn_professores.Name = "Btn_professores"
        Me.Btn_professores.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_professores.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_professores.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_professores.OnHoverImage = Nothing
        Me.Btn_professores.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_professores.Radius = 2
        Me.Btn_professores.Size = New System.Drawing.Size(226, 55)
        Me.Btn_professores.TabIndex = 49
        Me.Btn_professores.Text = "PROFESSORES"
        '
        'Btn_alunos
        '
        Me.Btn_alunos.AnimationHoverSpeed = 0.07!
        Me.Btn_alunos.AnimationSpeed = 0.03!
        Me.Btn_alunos.BackColor = System.Drawing.Color.Transparent
        Me.Btn_alunos.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_alunos.BorderColor = System.Drawing.Color.Black
        Me.Btn_alunos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_alunos.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_alunos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_alunos.ForeColor = System.Drawing.Color.White
        Me.Btn_alunos.Image = CType(resources.GetObject("Btn_alunos.Image"), System.Drawing.Image)
        Me.Btn_alunos.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_alunos.Location = New System.Drawing.Point(153, 105)
        Me.Btn_alunos.Name = "Btn_alunos"
        Me.Btn_alunos.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_alunos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_alunos.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_alunos.OnHoverImage = Nothing
        Me.Btn_alunos.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_alunos.Radius = 2
        Me.Btn_alunos.Size = New System.Drawing.Size(226, 55)
        Me.Btn_alunos.TabIndex = 48
        Me.Btn_alunos.Text = "ALUNOS"
        '
        'Btn_disciplinas
        '
        Me.Btn_disciplinas.AnimationHoverSpeed = 0.07!
        Me.Btn_disciplinas.AnimationSpeed = 0.03!
        Me.Btn_disciplinas.BackColor = System.Drawing.Color.Transparent
        Me.Btn_disciplinas.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_disciplinas.BorderColor = System.Drawing.Color.Black
        Me.Btn_disciplinas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_disciplinas.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_disciplinas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_disciplinas.ForeColor = System.Drawing.Color.White
        Me.Btn_disciplinas.Image = CType(resources.GetObject("Btn_disciplinas.Image"), System.Drawing.Image)
        Me.Btn_disciplinas.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_disciplinas.Location = New System.Drawing.Point(153, 288)
        Me.Btn_disciplinas.Name = "Btn_disciplinas"
        Me.Btn_disciplinas.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_disciplinas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_disciplinas.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_disciplinas.OnHoverImage = Nothing
        Me.Btn_disciplinas.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_disciplinas.Radius = 2
        Me.Btn_disciplinas.Size = New System.Drawing.Size(226, 55)
        Me.Btn_disciplinas.TabIndex = 51
        Me.Btn_disciplinas.Text = "DISCIPLINAS"
        '
        'Lb_bemvindo
        '
        Me.Lb_bemvindo.AutoSize = True
        Me.Lb_bemvindo.Font = New System.Drawing.Font("Segoe UI Semibold", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_bemvindo.Location = New System.Drawing.Point(103, 54)
        Me.Lb_bemvindo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_bemvindo.Name = "Lb_bemvindo"
        Me.Lb_bemvindo.Size = New System.Drawing.Size(315, 45)
        Me.Lb_bemvindo.TabIndex = 52
        Me.Lb_bemvindo.Text = "Área Administrativa"
        '
        'Frm_MenuGerenciamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(533, 374)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Controls.Add(Me.Btn_disciplinas)
        Me.Controls.Add(Me.Btn_adm)
        Me.Controls.Add(Me.Btn_professores)
        Me.Controls.Add(Me.Btn_alunos)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Lb_acesso_restrito)
        Me.Name = "Frm_MenuGerenciamento"
        Me.Text = "Gerenciamento"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb_gerenciamento As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Lb_acesso_restrito As Label
    Friend WithEvents Btn_adm As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_professores As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_alunos As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_disciplinas As Guna.UI.WinForms.GunaButton
    Friend WithEvents Lb_bemvindo As Label
End Class
