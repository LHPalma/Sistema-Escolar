<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_loginADM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_loginADM))
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Cb_mostrarSenha = New System.Windows.Forms.CheckBox()
        Me.Lb_senha = New System.Windows.Forms.Label()
        Me.Lb_email = New System.Windows.Forms.Label()
        Me.Gb_loginADM = New System.Windows.Forms.GroupBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Lb_login_adm = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_logar = New Guna.UI.WinForms.GunaButton()
        Me.Gb_loginADM.SuspendLayout()
        Me.Pnl_menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_senha
        '
        Me.Txt_senha.Location = New System.Drawing.Point(29, 94)
        Me.Txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.Size = New System.Drawing.Size(191, 29)
        Me.Txt_senha.TabIndex = 8
        Me.Txt_senha.UseSystemPasswordChar = True
        '
        'Txt_email
        '
        Me.Txt_email.Location = New System.Drawing.Point(29, 41)
        Me.Txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(191, 29)
        Me.Txt_email.TabIndex = 9
        '
        'Cb_mostrarSenha
        '
        Me.Cb_mostrarSenha.AutoSize = True
        Me.Cb_mostrarSenha.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_mostrarSenha.Location = New System.Drawing.Point(29, 127)
        Me.Cb_mostrarSenha.Margin = New System.Windows.Forms.Padding(2)
        Me.Cb_mostrarSenha.Name = "Cb_mostrarSenha"
        Me.Cb_mostrarSenha.Size = New System.Drawing.Size(101, 17)
        Me.Cb_mostrarSenha.TabIndex = 7
        Me.Cb_mostrarSenha.Text = "Mostrar Senha"
        Me.Cb_mostrarSenha.UseVisualStyleBackColor = True
        '
        'Lb_senha
        '
        Me.Lb_senha.AutoSize = True
        Me.Lb_senha.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_senha.Location = New System.Drawing.Point(26, 79)
        Me.Lb_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_senha.Name = "Lb_senha"
        Me.Lb_senha.Size = New System.Drawing.Size(39, 13)
        Me.Lb_senha.TabIndex = 5
        Me.Lb_senha.Text = "Senha"
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_email.Location = New System.Drawing.Point(27, 26)
        Me.Lb_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(38, 13)
        Me.Lb_email.TabIndex = 7
        Me.Lb_email.Text = "E-mail"
        '
        'Gb_loginADM
        '
        Me.Gb_loginADM.Controls.Add(Me.Btn_logar)
        Me.Gb_loginADM.Controls.Add(Me.Txt_senha)
        Me.Gb_loginADM.Controls.Add(Me.Txt_email)
        Me.Gb_loginADM.Controls.Add(Me.Lb_email)
        Me.Gb_loginADM.Controls.Add(Me.Cb_mostrarSenha)
        Me.Gb_loginADM.Controls.Add(Me.Lb_senha)
        Me.Gb_loginADM.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_loginADM.Location = New System.Drawing.Point(125, 67)
        Me.Gb_loginADM.Margin = New System.Windows.Forms.Padding(2)
        Me.Gb_loginADM.Name = "Gb_loginADM"
        Me.Gb_loginADM.Padding = New System.Windows.Forms.Padding(2)
        Me.Gb_loginADM.Size = New System.Drawing.Size(251, 206)
        Me.Gb_loginADM.TabIndex = 10
        Me.Gb_loginADM.TabStop = False
        Me.Gb_loginADM.Text = "Insira os dados da conta"
        '
        'Pnl_menu
        '
        Me.Pnl_menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_menu.Controls.Add(Me.Lb_login_adm)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-3, -6)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(533, 57)
        Me.Pnl_menu.TabIndex = 45
        '
        'Lb_login_adm
        '
        Me.Lb_login_adm.AutoSize = True
        Me.Lb_login_adm.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_login_adm.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_login_adm.Location = New System.Drawing.Point(56, 14)
        Me.Lb_login_adm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_login_adm.Name = "Lb_login_adm"
        Me.Lb_login_adm.Size = New System.Drawing.Size(337, 32)
        Me.Lb_login_adm.TabIndex = 4
        Me.Lb_login_adm.Text = "LOGIN DE ADMINISTRADOR"
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
        Me.Btn_voltar.Location = New System.Drawing.Point(399, 246)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 46
        Me.Btn_voltar.Text = "Voltar"
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
        Me.Btn_logar.Location = New System.Drawing.Point(29, 149)
        Me.Btn_logar.Name = "Btn_logar"
        Me.Btn_logar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_logar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_logar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_logar.OnHoverImage = Nothing
        Me.Btn_logar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_logar.Radius = 2
        Me.Btn_logar.Size = New System.Drawing.Size(198, 38)
        Me.Btn_logar.TabIndex = 47
        Me.Btn_logar.Text = "LOGIN"
        Me.Btn_logar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_loginADM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 285)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Gb_loginADM)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_loginADM"
        Me.Text = "Login de Administrador"
        Me.Gb_loginADM.ResumeLayout(False)
        Me.Gb_loginADM.PerformLayout()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Cb_mostrarSenha As CheckBox
    Friend WithEvents Lb_senha As Label
    Friend WithEvents Lb_email As Label
    Friend WithEvents Gb_loginADM As GroupBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Lb_login_adm As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_logar As Guna.UI.WinForms.GunaButton
End Class
