<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cadastroADM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cadastroADM))
        Me.Gb_cadastro_adm = New System.Windows.Forms.GroupBox()
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.Lb_senha = New System.Windows.Forms.Label()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Lb_email = New System.Windows.Forms.Label()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Lb_nome = New System.Windows.Forms.Label()
        Me.Lb_cadastro_adm = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.btn_cadastrar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_limpar_campos = New Guna.UI.WinForms.GunaButton()
        Me.Gb_cadastro_adm.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb_cadastro_adm
        '
        Me.Gb_cadastro_adm.Controls.Add(Me.btn_cadastrar)
        Me.Gb_cadastro_adm.Controls.Add(Me.Txt_senha)
        Me.Gb_cadastro_adm.Controls.Add(Me.Lb_senha)
        Me.Gb_cadastro_adm.Controls.Add(Me.Txt_email)
        Me.Gb_cadastro_adm.Controls.Add(Me.Lb_email)
        Me.Gb_cadastro_adm.Controls.Add(Me.Txt_nome)
        Me.Gb_cadastro_adm.Controls.Add(Me.Lb_nome)
        Me.Gb_cadastro_adm.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_cadastro_adm.Location = New System.Drawing.Point(121, 57)
        Me.Gb_cadastro_adm.Margin = New System.Windows.Forms.Padding(2)
        Me.Gb_cadastro_adm.Name = "Gb_cadastro_adm"
        Me.Gb_cadastro_adm.Padding = New System.Windows.Forms.Padding(2)
        Me.Gb_cadastro_adm.Size = New System.Drawing.Size(274, 260)
        Me.Gb_cadastro_adm.TabIndex = 1
        Me.Gb_cadastro_adm.TabStop = False
        Me.Gb_cadastro_adm.Text = "Insira os Dados de Administrador"
        '
        'Txt_senha
        '
        Me.Txt_senha.Location = New System.Drawing.Point(36, 155)
        Me.Txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.Size = New System.Drawing.Size(191, 29)
        Me.Txt_senha.TabIndex = 12
        '
        'Lb_senha
        '
        Me.Lb_senha.AutoSize = True
        Me.Lb_senha.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_senha.Location = New System.Drawing.Point(33, 140)
        Me.Lb_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_senha.Name = "Lb_senha"
        Me.Lb_senha.Size = New System.Drawing.Size(39, 13)
        Me.Lb_senha.TabIndex = 9
        Me.Lb_senha.Text = "Senha"
        '
        'Txt_email
        '
        Me.Txt_email.Location = New System.Drawing.Point(36, 98)
        Me.Txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(191, 29)
        Me.Txt_email.TabIndex = 13
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_email.Location = New System.Drawing.Point(33, 83)
        Me.Lb_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(34, 13)
        Me.Lb_email.TabIndex = 10
        Me.Lb_email.Text = "Email"
        '
        'Txt_nome
        '
        Me.Txt_nome.Location = New System.Drawing.Point(36, 43)
        Me.Txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(191, 29)
        Me.Txt_nome.TabIndex = 14
        '
        'Lb_nome
        '
        Me.Lb_nome.AutoSize = True
        Me.Lb_nome.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_nome.Location = New System.Drawing.Point(33, 28)
        Me.Lb_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_nome.Name = "Lb_nome"
        Me.Lb_nome.Size = New System.Drawing.Size(37, 13)
        Me.Lb_nome.TabIndex = 11
        Me.Lb_nome.Text = "Nome"
        '
        'Lb_cadastro_adm
        '
        Me.Lb_cadastro_adm.AutoSize = True
        Me.Lb_cadastro_adm.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cadastro_adm.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_cadastro_adm.Location = New System.Drawing.Point(56, 14)
        Me.Lb_cadastro_adm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cadastro_adm.Name = "Lb_cadastro_adm"
        Me.Lb_cadastro_adm.Size = New System.Drawing.Size(392, 32)
        Me.Lb_cadastro_adm.TabIndex = 4
        Me.Lb_cadastro_adm.Text = "CADASTRO DE ADMINISTRADOR"
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
        Me.Pnl_menu.Controls.Add(Me.Lb_cadastro_adm)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-5, -6)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(543, 57)
        Me.Pnl_menu.TabIndex = 47
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.AnimationHoverSpeed = 0.07!
        Me.btn_cadastrar.AnimationSpeed = 0.03!
        Me.btn_cadastrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cadastrar.BaseColor = System.Drawing.Color.SteelBlue
        Me.btn_cadastrar.BorderColor = System.Drawing.Color.Black
        Me.btn_cadastrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_cadastrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_cadastrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Image = Nothing
        Me.btn_cadastrar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_cadastrar.Location = New System.Drawing.Point(36, 200)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.btn_cadastrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_cadastrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.OnHoverImage = Nothing
        Me.btn_cadastrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_cadastrar.Radius = 2
        Me.btn_cadastrar.Size = New System.Drawing.Size(198, 38)
        Me.btn_cadastrar.TabIndex = 50
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Btn_voltar.TabIndex = 50
        Me.Btn_voltar.Text = "Voltar"
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
        Me.Btn_limpar_campos.TabIndex = 51
        Me.Btn_limpar_campos.Text = "Limpar Campos"
        '
        'Frm_cadastroADM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(533, 329)
        Me.Controls.Add(Me.Btn_limpar_campos)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Gb_cadastro_adm)
        Me.Name = "Frm_cadastroADM"
        Me.Text = "Cadastro de Administrador"
        Me.Gb_cadastro_adm.ResumeLayout(False)
        Me.Gb_cadastro_adm.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gb_cadastro_adm As GroupBox
    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Lb_senha As Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Lb_email As Label
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Lb_nome As Label
    Friend WithEvents Lb_cadastro_adm As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents btn_cadastrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_limpar_campos As Guna.UI.WinForms.GunaButton
End Class
