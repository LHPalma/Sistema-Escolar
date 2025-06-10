<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_CadastroProfessor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CadastroProfessor))
        Me.Gb_professor = New System.Windows.Forms.GroupBox()
        Me.Btn_cadastrar = New Guna.UI.WinForms.GunaButton()
        Me.Txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Lb_cidade = New System.Windows.Forms.Label()
        Me.Txt_cidade = New System.Windows.Forms.TextBox()
        Me.Lb_cep = New System.Windows.Forms.Label()
        Me.Cmb_uf = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_complemento = New System.Windows.Forms.TextBox()
        Me.Txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lb_logradouro = New System.Windows.Forms.Label()
        Me.Txt_numero = New System.Windows.Forms.TextBox()
        Me.Txt_rua = New System.Windows.Forms.TextBox()
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.Lb_senha = New System.Windows.Forms.Label()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Lb_email = New System.Windows.Forms.Label()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Lb_nome = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.abrirArquivo = New System.Windows.Forms.OpenFileDialog()
        Me.Btn_limpar_campos = New Guna.UI.WinForms.GunaButton()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Lb_cadastro_professor = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Gb_professor.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gb_professor
        '
        Me.Gb_professor.Controls.Add(Me.Btn_cadastrar)
        Me.Gb_professor.Controls.Add(Me.Txt_cep)
        Me.Gb_professor.Controls.Add(Me.Lb_cidade)
        Me.Gb_professor.Controls.Add(Me.Txt_cidade)
        Me.Gb_professor.Controls.Add(Me.Lb_cep)
        Me.Gb_professor.Controls.Add(Me.Cmb_uf)
        Me.Gb_professor.Controls.Add(Me.Label6)
        Me.Gb_professor.Controls.Add(Me.Txt_complemento)
        Me.Gb_professor.Controls.Add(Me.Txt_telefone)
        Me.Gb_professor.Controls.Add(Me.Label5)
        Me.Gb_professor.Controls.Add(Me.Label4)
        Me.Gb_professor.Controls.Add(Me.Txt_bairro)
        Me.Gb_professor.Controls.Add(Me.Label3)
        Me.Gb_professor.Controls.Add(Me.Label2)
        Me.Gb_professor.Controls.Add(Me.Lb_logradouro)
        Me.Gb_professor.Controls.Add(Me.Txt_numero)
        Me.Gb_professor.Controls.Add(Me.Txt_rua)
        Me.Gb_professor.Controls.Add(Me.Txt_senha)
        Me.Gb_professor.Controls.Add(Me.Lb_senha)
        Me.Gb_professor.Controls.Add(Me.Txt_email)
        Me.Gb_professor.Controls.Add(Me.Lb_email)
        Me.Gb_professor.Controls.Add(Me.Txt_nome)
        Me.Gb_professor.Controls.Add(Me.Lb_nome)
        Me.Gb_professor.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_professor.Location = New System.Drawing.Point(11, 64)
        Me.Gb_professor.Margin = New System.Windows.Forms.Padding(2)
        Me.Gb_professor.Name = "Gb_professor"
        Me.Gb_professor.Padding = New System.Windows.Forms.Padding(2)
        Me.Gb_professor.Size = New System.Drawing.Size(438, 465)
        Me.Gb_professor.TabIndex = 0
        Me.Gb_professor.TabStop = False
        Me.Gb_professor.Text = "Insira os Dados de Professor"
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
        Me.Btn_cadastrar.Location = New System.Drawing.Point(106, 405)
        Me.Btn_cadastrar.Name = "Btn_cadastrar"
        Me.Btn_cadastrar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_cadastrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_cadastrar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_cadastrar.OnHoverImage = Nothing
        Me.Btn_cadastrar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_cadastrar.Radius = 2
        Me.Btn_cadastrar.Size = New System.Drawing.Size(198, 38)
        Me.Btn_cadastrar.TabIndex = 52
        Me.Btn_cadastrar.Text = "CADASTRAR"
        Me.Btn_cadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_cep
        '
        Me.Txt_cep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cep.Location = New System.Drawing.Point(28, 179)
        Me.Txt_cep.Mask = "00000-999"
        Me.Txt_cep.Name = "Txt_cep"
        Me.Txt_cep.Size = New System.Drawing.Size(100, 29)
        Me.Txt_cep.TabIndex = 36
        '
        'Lb_cidade
        '
        Me.Lb_cidade.AutoSize = True
        Me.Lb_cidade.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cidade.Location = New System.Drawing.Point(222, 218)
        Me.Lb_cidade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cidade.Name = "Lb_cidade"
        Me.Lb_cidade.Size = New System.Drawing.Size(43, 13)
        Me.Lb_cidade.TabIndex = 35
        Me.Lb_cidade.Text = "Cidade"
        '
        'Txt_cidade
        '
        Me.Txt_cidade.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cidade.Location = New System.Drawing.Point(224, 233)
        Me.Txt_cidade.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_cidade.Name = "Txt_cidade"
        Me.Txt_cidade.Size = New System.Drawing.Size(116, 29)
        Me.Txt_cidade.TabIndex = 34
        '
        'Lb_cep
        '
        Me.Lb_cep.AutoSize = True
        Me.Lb_cep.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cep.Location = New System.Drawing.Point(27, 163)
        Me.Lb_cep.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cep.Name = "Lb_cep"
        Me.Lb_cep.Size = New System.Drawing.Size(26, 13)
        Me.Lb_cep.TabIndex = 33
        Me.Lb_cep.Text = "CEP"
        '
        'Cmb_uf
        '
        Me.Cmb_uf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_uf.FormattingEnabled = True
        Me.Cmb_uf.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.Cmb_uf.Location = New System.Drawing.Point(359, 233)
        Me.Cmb_uf.Name = "Cmb_uf"
        Me.Cmb_uf.Size = New System.Drawing.Size(48, 29)
        Me.Cmb_uf.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(288, 164)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Complemento"
        '
        'Txt_complemento
        '
        Me.Txt_complemento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_complemento.Location = New System.Drawing.Point(289, 179)
        Me.Txt_complemento.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_complemento.Name = "Txt_complemento"
        Me.Txt_complemento.Size = New System.Drawing.Size(116, 29)
        Me.Txt_complemento.TabIndex = 27
        '
        'Txt_telefone
        '
        Me.Txt_telefone.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_telefone.Location = New System.Drawing.Point(27, 290)
        Me.Txt_telefone.Mask = "(99) 00000-0000"
        Me.Txt_telefone.Name = "Txt_telefone"
        Me.Txt_telefone.Size = New System.Drawing.Size(116, 29)
        Me.Txt_telefone.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 274)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Telefone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 218)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Bairro"
        '
        'Txt_bairro
        '
        Me.Txt_bairro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_bairro.Location = New System.Drawing.Point(94, 233)
        Me.Txt_bairro.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_bairro.Name = "Txt_bairro"
        Me.Txt_bairro.Size = New System.Drawing.Size(116, 29)
        Me.Txt_bairro.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(356, 218)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "UF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 218)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Número"
        '
        'Lb_logradouro
        '
        Me.Lb_logradouro.AutoSize = True
        Me.Lb_logradouro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_logradouro.Location = New System.Drawing.Point(136, 163)
        Me.Lb_logradouro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_logradouro.Name = "Lb_logradouro"
        Me.Lb_logradouro.Size = New System.Drawing.Size(68, 13)
        Me.Lb_logradouro.TabIndex = 19
        Me.Lb_logradouro.Text = "Logradouro"
        '
        'Txt_numero
        '
        Me.Txt_numero.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_numero.Location = New System.Drawing.Point(28, 233)
        Me.Txt_numero.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_numero.MaxLength = 5
        Me.Txt_numero.Name = "Txt_numero"
        Me.Txt_numero.Size = New System.Drawing.Size(48, 29)
        Me.Txt_numero.TabIndex = 17
        '
        'Txt_rua
        '
        Me.Txt_rua.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rua.Location = New System.Drawing.Point(138, 179)
        Me.Txt_rua.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_rua.Name = "Txt_rua"
        Me.Txt_rua.Size = New System.Drawing.Size(136, 29)
        Me.Txt_rua.TabIndex = 16
        '
        'Txt_senha
        '
        Me.Txt_senha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_senha.Location = New System.Drawing.Point(27, 360)
        Me.Txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.Size = New System.Drawing.Size(116, 29)
        Me.Txt_senha.TabIndex = 12
        Me.Txt_senha.UseSystemPasswordChar = True
        '
        'Lb_senha
        '
        Me.Lb_senha.AutoSize = True
        Me.Lb_senha.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_senha.Location = New System.Drawing.Point(25, 345)
        Me.Lb_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_senha.Name = "Lb_senha"
        Me.Lb_senha.Size = New System.Drawing.Size(39, 13)
        Me.Lb_senha.TabIndex = 9
        Me.Lb_senha.Text = "Senha"
        '
        'Txt_email
        '
        Me.Txt_email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_email.Location = New System.Drawing.Point(28, 89)
        Me.Txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(309, 29)
        Me.Txt_email.TabIndex = 13
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_email.Location = New System.Drawing.Point(28, 74)
        Me.Lb_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(34, 13)
        Me.Lb_email.TabIndex = 10
        Me.Lb_email.Text = "Email"
        '
        'Txt_nome
        '
        Me.Txt_nome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nome.Location = New System.Drawing.Point(27, 43)
        Me.Txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(309, 29)
        Me.Txt_nome.TabIndex = 14
        '
        'Lb_nome
        '
        Me.Lb_nome.AutoSize = True
        Me.Lb_nome.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_nome.Location = New System.Drawing.Point(25, 28)
        Me.Lb_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_nome.Name = "Lb_nome"
        Me.Lb_nome.Size = New System.Drawing.Size(37, 13)
        Me.Lb_nome.TabIndex = 11
        Me.Lb_nome.Text = "Nome"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.img_foto)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(454, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 205)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Insira a foto de Professor"
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(52, 43)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(2)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(112, 119)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 17
        Me.img_foto.TabStop = False
        '
        'abrirArquivo
        '
        Me.abrirArquivo.FileName = "Escolha um Arquivo"
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
        Me.Btn_limpar_campos.Location = New System.Drawing.Point(554, 469)
        Me.Btn_limpar_campos.Name = "Btn_limpar_campos"
        Me.Btn_limpar_campos.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_limpar_campos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_limpar_campos.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_limpar_campos.OnHoverImage = Nothing
        Me.Btn_limpar_campos.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_limpar_campos.Radius = 2
        Me.Btn_limpar_campos.Size = New System.Drawing.Size(116, 27)
        Me.Btn_limpar_campos.TabIndex = 53
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
        Me.Btn_voltar.Location = New System.Drawing.Point(579, 502)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 52
        Me.Btn_voltar.Text = "Voltar"
        '
        'Lb_cadastro_professor
        '
        Me.Lb_cadastro_professor.AutoSize = True
        Me.Lb_cadastro_professor.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cadastro_professor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_cadastro_professor.Location = New System.Drawing.Point(56, 14)
        Me.Lb_cadastro_professor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cadastro_professor.Name = "Lb_cadastro_professor"
        Me.Lb_cadastro_professor.Size = New System.Drawing.Size(321, 32)
        Me.Lb_cadastro_professor.TabIndex = 4
        Me.Lb_cadastro_professor.Text = "CADASTRO DE PROFESSOR"
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
        Me.Pnl_menu.Controls.Add(Me.Lb_cadastro_professor)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-4, -6)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(693, 57)
        Me.Pnl_menu.TabIndex = 54
        '
        'Frm_CadastroProfessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(682, 537)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Btn_limpar_campos)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Gb_professor)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_CadastroProfessor"
        Me.Text = "Cadastro de Professor"
        Me.Gb_professor.ResumeLayout(False)
        Me.Gb_professor.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gb_professor As GroupBox
    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Lb_senha As Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Lb_email As Label
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Lb_nome As Label
    Friend WithEvents Txt_numero As TextBox
    Friend WithEvents Txt_rua As TextBox
    Friend WithEvents Lb_logradouro As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_bairro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_telefone As MaskedTextBox
    Friend WithEvents Txt_complemento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Cmb_uf As ComboBox
    Friend WithEvents Lb_cidade As Label
    Friend WithEvents Txt_cidade As TextBox
    Friend WithEvents Lb_cep As Label
    Friend WithEvents Txt_cep As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents abrirArquivo As OpenFileDialog
    Friend WithEvents Btn_limpar_campos As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Lb_cadastro_professor As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Btn_cadastrar As Guna.UI.WinForms.GunaButton
End Class
