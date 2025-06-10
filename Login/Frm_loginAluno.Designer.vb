<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_loginAluno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_loginAluno))
        Me.Lb_ra = New System.Windows.Forms.Label()
        Me.Lb_senha = New System.Windows.Forms.Label()
        Me.Cb_mostrarSenha = New System.Windows.Forms.CheckBox()
        Me.Txt_ra = New System.Windows.Forms.TextBox()
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.Gb_loginAluno = New System.Windows.Forms.GroupBox()
        Me.Btn_logar = New Guna.UI.WinForms.GunaButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Lb_login_aluno = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Gb_loginAluno.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_ra
        '
        Me.Lb_ra.AutoSize = True
        Me.Lb_ra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_ra.Location = New System.Drawing.Point(23, 24)
        Me.Lb_ra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_ra.Name = "Lb_ra"
        Me.Lb_ra.Size = New System.Drawing.Size(24, 13)
        Me.Lb_ra.TabIndex = 1
        Me.Lb_ra.Text = "RA:"
        '
        'Lb_senha
        '
        Me.Lb_senha.AutoSize = True
        Me.Lb_senha.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_senha.Location = New System.Drawing.Point(23, 78)
        Me.Lb_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_senha.Name = "Lb_senha"
        Me.Lb_senha.Size = New System.Drawing.Size(42, 13)
        Me.Lb_senha.TabIndex = 1
        Me.Lb_senha.Text = "Senha:"
        '
        'Cb_mostrarSenha
        '
        Me.Cb_mostrarSenha.AutoSize = True
        Me.Cb_mostrarSenha.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_mostrarSenha.Location = New System.Drawing.Point(26, 126)
        Me.Cb_mostrarSenha.Margin = New System.Windows.Forms.Padding(2)
        Me.Cb_mostrarSenha.Name = "Cb_mostrarSenha"
        Me.Cb_mostrarSenha.Size = New System.Drawing.Size(101, 17)
        Me.Cb_mostrarSenha.TabIndex = 2
        Me.Cb_mostrarSenha.Text = "Mostrar Senha"
        Me.Cb_mostrarSenha.UseVisualStyleBackColor = True
        '
        'Txt_ra
        '
        Me.Txt_ra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ra.Location = New System.Drawing.Point(26, 40)
        Me.Txt_ra.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_ra.Name = "Txt_ra"
        Me.Txt_ra.Size = New System.Drawing.Size(191, 29)
        Me.Txt_ra.TabIndex = 3
        '
        'Txt_senha
        '
        Me.Txt_senha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_senha.Location = New System.Drawing.Point(26, 93)
        Me.Txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.Size = New System.Drawing.Size(191, 29)
        Me.Txt_senha.TabIndex = 3
        Me.Txt_senha.UseSystemPasswordChar = True
        '
        'Gb_loginAluno
        '
        Me.Gb_loginAluno.Controls.Add(Me.Btn_logar)
        Me.Gb_loginAluno.Controls.Add(Me.Txt_ra)
        Me.Gb_loginAluno.Controls.Add(Me.Txt_senha)
        Me.Gb_loginAluno.Controls.Add(Me.Lb_ra)
        Me.Gb_loginAluno.Controls.Add(Me.Cb_mostrarSenha)
        Me.Gb_loginAluno.Controls.Add(Me.Lb_senha)
        Me.Gb_loginAluno.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_loginAluno.Location = New System.Drawing.Point(124, 69)
        Me.Gb_loginAluno.Margin = New System.Windows.Forms.Padding(2)
        Me.Gb_loginAluno.Name = "Gb_loginAluno"
        Me.Gb_loginAluno.Padding = New System.Windows.Forms.Padding(2)
        Me.Gb_loginAluno.Size = New System.Drawing.Size(251, 204)
        Me.Gb_loginAluno.TabIndex = 4
        Me.Gb_loginAluno.TabStop = False
        Me.Gb_loginAluno.Text = "Insira os dados da conta"
        '
        'Btn_logar
        '
        Me.Btn_logar.AnimationHoverSpeed = 0.07!
        Me.Btn_logar.AnimationSpeed = 0.03!
        Me.Btn_logar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_logar.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_logar.BorderColor = System.Drawing.Color.Black
        Me.Btn_logar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_logar.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_logar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_logar.ForeColor = System.Drawing.Color.White
        Me.Btn_logar.Image = Nothing
        Me.Btn_logar.ImageSize = New System.Drawing.Size(30, 30)
        Me.Btn_logar.Location = New System.Drawing.Point(26, 148)
        Me.Btn_logar.Name = "Btn_logar"
        Me.Btn_logar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_logar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_logar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_logar.OnHoverImage = Nothing
        Me.Btn_logar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_logar.Radius = 2
        Me.Btn_logar.Size = New System.Drawing.Size(198, 38)
        Me.Btn_logar.TabIndex = 49
        Me.Btn_logar.Text = "LOGIN"
        Me.Btn_logar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Btn_voltar.Location = New System.Drawing.Point(399, 246)
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
        'Lb_login_aluno
        '
        Me.Lb_login_aluno.AutoSize = True
        Me.Lb_login_aluno.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_login_aluno.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_login_aluno.Location = New System.Drawing.Point(56, 14)
        Me.Lb_login_aluno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_login_aluno.Name = "Lb_login_aluno"
        Me.Lb_login_aluno.Size = New System.Drawing.Size(215, 32)
        Me.Lb_login_aluno.TabIndex = 4
        Me.Lb_login_aluno.Text = "LOGIN DE ALUNO"
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
        Me.Pnl_menu.Controls.Add(Me.Lb_login_aluno)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-3, -6)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(533, 57)
        Me.Pnl_menu.TabIndex = 48
        '
        'Frm_loginAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(502, 285)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Gb_loginAluno)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_loginAluno"
        Me.Text = "Login de Aluno"
        Me.Gb_loginAluno.ResumeLayout(False)
        Me.Gb_loginAluno.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lb_ra As Label
    Friend WithEvents Lb_senha As Label
    Friend WithEvents Cb_mostrarSenha As CheckBox
    Friend WithEvents Txt_ra As TextBox
    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Gb_loginAluno As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Lb_login_aluno As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Btn_logar As Guna.UI.WinForms.GunaButton
End Class
