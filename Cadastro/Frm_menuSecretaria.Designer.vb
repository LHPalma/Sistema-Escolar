<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_menuSecretaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_menuSecretaria))
        Me.Lb_secretaria = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_turmas_disciplinas = New Guna.UI.WinForms.GunaButton()
        Me.Btn_cadastro_contas = New Guna.UI.WinForms.GunaButton()
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Lb_acesso_restrito = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_secretaria
        '
        Me.Lb_secretaria.AutoSize = True
        Me.Lb_secretaria.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_secretaria.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_secretaria.Location = New System.Drawing.Point(56, 16)
        Me.Lb_secretaria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_secretaria.Name = "Lb_secretaria"
        Me.Lb_secretaria.Size = New System.Drawing.Size(154, 32)
        Me.Lb_secretaria.TabIndex = 4
        Me.Lb_secretaria.Text = "SECRETARIA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, -6)
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
        Me.Btn_voltar.TabIndex = 38
        Me.Btn_voltar.Text = "Voltar"
        '
        'Btn_turmas_disciplinas
        '
        Me.Btn_turmas_disciplinas.AnimationHoverSpeed = 0.07!
        Me.Btn_turmas_disciplinas.AnimationSpeed = 0.03!
        Me.Btn_turmas_disciplinas.BackColor = System.Drawing.Color.Transparent
        Me.Btn_turmas_disciplinas.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_turmas_disciplinas.BorderColor = System.Drawing.Color.Black
        Me.Btn_turmas_disciplinas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_turmas_disciplinas.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_turmas_disciplinas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_turmas_disciplinas.ForeColor = System.Drawing.Color.White
        Me.Btn_turmas_disciplinas.Image = CType(resources.GetObject("Btn_turmas_disciplinas.Image"), System.Drawing.Image)
        Me.Btn_turmas_disciplinas.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_turmas_disciplinas.Location = New System.Drawing.Point(136, 174)
        Me.Btn_turmas_disciplinas.Name = "Btn_turmas_disciplinas"
        Me.Btn_turmas_disciplinas.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_turmas_disciplinas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_turmas_disciplinas.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_turmas_disciplinas.OnHoverImage = Nothing
        Me.Btn_turmas_disciplinas.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_turmas_disciplinas.Radius = 2
        Me.Btn_turmas_disciplinas.Size = New System.Drawing.Size(260, 55)
        Me.Btn_turmas_disciplinas.TabIndex = 37
        Me.Btn_turmas_disciplinas.Text = "TURMAS E DISCIPLINAS"
        '
        'Btn_cadastro_contas
        '
        Me.Btn_cadastro_contas.AnimationHoverSpeed = 0.07!
        Me.Btn_cadastro_contas.AnimationSpeed = 0.03!
        Me.Btn_cadastro_contas.BackColor = System.Drawing.Color.Transparent
        Me.Btn_cadastro_contas.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_cadastro_contas.BorderColor = System.Drawing.Color.Black
        Me.Btn_cadastro_contas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_cadastro_contas.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_cadastro_contas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cadastro_contas.ForeColor = System.Drawing.Color.White
        Me.Btn_cadastro_contas.Image = CType(resources.GetObject("Btn_cadastro_contas.Image"), System.Drawing.Image)
        Me.Btn_cadastro_contas.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_cadastro_contas.Location = New System.Drawing.Point(136, 106)
        Me.Btn_cadastro_contas.Name = "Btn_cadastro_contas"
        Me.Btn_cadastro_contas.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_cadastro_contas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_cadastro_contas.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_cadastro_contas.OnHoverImage = Nothing
        Me.Btn_cadastro_contas.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_cadastro_contas.Radius = 2
        Me.Btn_cadastro_contas.Size = New System.Drawing.Size(260, 55)
        Me.Btn_cadastro_contas.TabIndex = 36
        Me.Btn_cadastro_contas.Text = "CADASTROS DE CONTAS"
        '
        'Lb_bemvindo
        '
        Me.Lb_bemvindo.AutoSize = True
        Me.Lb_bemvindo.Font = New System.Drawing.Font("Segoe UI Semibold", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_bemvindo.Location = New System.Drawing.Point(109, 55)
        Me.Lb_bemvindo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_bemvindo.Name = "Lb_bemvindo"
        Me.Lb_bemvindo.Size = New System.Drawing.Size(315, 45)
        Me.Lb_bemvindo.TabIndex = 33
        Me.Lb_bemvindo.Text = "Área Administrativa"
        '
        'Pnl_menu
        '
        Me.Pnl_menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_menu.Controls.Add(Me.Lb_secretaria)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-5, -8)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(543, 57)
        Me.Pnl_menu.TabIndex = 35
        '
        'Lb_acesso_restrito
        '
        Me.Lb_acesso_restrito.AutoSize = True
        Me.Lb_acesso_restrito.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_acesso_restrito.Location = New System.Drawing.Point(12, 262)
        Me.Lb_acesso_restrito.Name = "Lb_acesso_restrito"
        Me.Lb_acesso_restrito.Size = New System.Drawing.Size(125, 21)
        Me.Lb_acesso_restrito.TabIndex = 34
        Me.Lb_acesso_restrito.Text = "Acesso Restrito"
        '
        'Frm_menuSecretaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Btn_turmas_disciplinas)
        Me.Controls.Add(Me.Btn_cadastro_contas)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Lb_acesso_restrito)
        Me.Name = "Frm_menuSecretaria"
        Me.Text = "Secretaria"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_secretaria As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_turmas_disciplinas As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_cadastro_contas As Guna.UI.WinForms.GunaButton
    Friend WithEvents Lb_bemvindo As Label
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Lb_acesso_restrito As Label
End Class
