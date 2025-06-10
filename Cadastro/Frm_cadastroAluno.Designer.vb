<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cadastroAluno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cadastroAluno))
        Me.Lb_ra = New System.Windows.Forms.Label()
        Me.Txt_ra = New System.Windows.Forms.TextBox()
        Me.Lb_nome = New System.Windows.Forms.Label()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Lb_cpf = New System.Windows.Forms.Label()
        Me.Lb_email = New System.Windows.Forms.Label()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Lb_senha = New System.Windows.Forms.Label()
        Me.Lb_turma = New System.Windows.Forms.Label()
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.Gb_aluno = New System.Windows.Forms.GroupBox()
        Me.Btn_cadastrar = New Guna.UI.WinForms.GunaButton()
        Me.Txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Lb_cidade = New System.Windows.Forms.Label()
        Me.Txt_cidade = New System.Windows.Forms.TextBox()
        Me.Lb_cep = New System.Windows.Forms.Label()
        Me.Lb_complemento = New System.Windows.Forms.Label()
        Me.Txt_complemento = New System.Windows.Forms.TextBox()
        Me.Txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.Lb_telefone = New System.Windows.Forms.Label()
        Me.Lb_bairro = New System.Windows.Forms.Label()
        Me.Txt_bairro = New System.Windows.Forms.TextBox()
        Me.Lb_numero = New System.Windows.Forms.Label()
        Me.Lb_logradouro = New System.Windows.Forms.Label()
        Me.Txt_numero = New System.Windows.Forms.TextBox()
        Me.Txt_rua = New System.Windows.Forms.TextBox()
        Me.Cmb_uf = New System.Windows.Forms.ComboBox()
        Me.Lb_uf = New System.Windows.Forms.Label()
        Me.Cmb_Turma = New System.Windows.Forms.ComboBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.abrirArquivo = New System.Windows.Forms.OpenFileDialog()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Lb_cadastro_alunos = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_limpar_campos = New Guna.UI.WinForms.GunaButton()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Gb_aluno.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Pnl_menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lb_ra
        '
        Me.Lb_ra.AutoSize = True
        Me.Lb_ra.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_ra.Location = New System.Drawing.Point(346, 76)
        Me.Lb_ra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_ra.Name = "Lb_ra"
        Me.Lb_ra.Size = New System.Drawing.Size(21, 13)
        Me.Lb_ra.TabIndex = 0
        Me.Lb_ra.Text = "RA"
        '
        'Txt_ra
        '
        Me.Txt_ra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ra.Location = New System.Drawing.Point(350, 91)
        Me.Txt_ra.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_ra.Name = "Txt_ra"
        Me.Txt_ra.Size = New System.Drawing.Size(90, 29)
        Me.Txt_ra.TabIndex = 1
        '
        'Lb_nome
        '
        Me.Lb_nome.AutoSize = True
        Me.Lb_nome.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_nome.Location = New System.Drawing.Point(20, 29)
        Me.Lb_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_nome.Name = "Lb_nome"
        Me.Lb_nome.Size = New System.Drawing.Size(37, 13)
        Me.Lb_nome.TabIndex = 0
        Me.Lb_nome.Text = "Nome"
        '
        'Txt_nome
        '
        Me.Txt_nome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nome.Location = New System.Drawing.Point(22, 44)
        Me.Txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(309, 29)
        Me.Txt_nome.TabIndex = 1
        '
        'Lb_cpf
        '
        Me.Lb_cpf.AutoSize = True
        Me.Lb_cpf.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cpf.Location = New System.Drawing.Point(346, 29)
        Me.Lb_cpf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cpf.Name = "Lb_cpf"
        Me.Lb_cpf.Size = New System.Drawing.Size(26, 13)
        Me.Lb_cpf.TabIndex = 0
        Me.Lb_cpf.Text = "CPF"
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_email.Location = New System.Drawing.Point(21, 76)
        Me.Lb_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(34, 13)
        Me.Lb_email.TabIndex = 0
        Me.Lb_email.Text = "Email"
        '
        'Txt_email
        '
        Me.Txt_email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_email.Location = New System.Drawing.Point(23, 91)
        Me.Txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(200, 29)
        Me.Txt_email.TabIndex = 1
        '
        'Lb_senha
        '
        Me.Lb_senha.AutoSize = True
        Me.Lb_senha.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_senha.Location = New System.Drawing.Point(20, 370)
        Me.Lb_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_senha.Name = "Lb_senha"
        Me.Lb_senha.Size = New System.Drawing.Size(39, 13)
        Me.Lb_senha.TabIndex = 0
        Me.Lb_senha.Text = "Senha"
        '
        'Lb_turma
        '
        Me.Lb_turma.AutoSize = True
        Me.Lb_turma.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_turma.Location = New System.Drawing.Point(234, 76)
        Me.Lb_turma.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_turma.Name = "Lb_turma"
        Me.Lb_turma.Size = New System.Drawing.Size(39, 13)
        Me.Lb_turma.TabIndex = 0
        Me.Lb_turma.Text = "Turma"
        '
        'Txt_senha
        '
        Me.Txt_senha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_senha.Location = New System.Drawing.Point(23, 385)
        Me.Txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.Size = New System.Drawing.Size(117, 29)
        Me.Txt_senha.TabIndex = 1
        Me.Txt_senha.UseSystemPasswordChar = True
        '
        'Gb_aluno
        '
        Me.Gb_aluno.Controls.Add(Me.Btn_cadastrar)
        Me.Gb_aluno.Controls.Add(Me.Txt_cpf)
        Me.Gb_aluno.Controls.Add(Me.Txt_cep)
        Me.Gb_aluno.Controls.Add(Me.Lb_cidade)
        Me.Gb_aluno.Controls.Add(Me.Txt_cidade)
        Me.Gb_aluno.Controls.Add(Me.Lb_cep)
        Me.Gb_aluno.Controls.Add(Me.Lb_complemento)
        Me.Gb_aluno.Controls.Add(Me.Txt_complemento)
        Me.Gb_aluno.Controls.Add(Me.Txt_telefone)
        Me.Gb_aluno.Controls.Add(Me.Lb_telefone)
        Me.Gb_aluno.Controls.Add(Me.Lb_bairro)
        Me.Gb_aluno.Controls.Add(Me.Txt_bairro)
        Me.Gb_aluno.Controls.Add(Me.Lb_numero)
        Me.Gb_aluno.Controls.Add(Me.Lb_logradouro)
        Me.Gb_aluno.Controls.Add(Me.Txt_numero)
        Me.Gb_aluno.Controls.Add(Me.Txt_rua)
        Me.Gb_aluno.Controls.Add(Me.Cmb_uf)
        Me.Gb_aluno.Controls.Add(Me.Lb_uf)
        Me.Gb_aluno.Controls.Add(Me.Cmb_Turma)
        Me.Gb_aluno.Controls.Add(Me.Txt_senha)
        Me.Gb_aluno.Controls.Add(Me.Txt_ra)
        Me.Gb_aluno.Controls.Add(Me.Lb_turma)
        Me.Gb_aluno.Controls.Add(Me.Lb_ra)
        Me.Gb_aluno.Controls.Add(Me.Lb_nome)
        Me.Gb_aluno.Controls.Add(Me.Lb_senha)
        Me.Gb_aluno.Controls.Add(Me.Txt_nome)
        Me.Gb_aluno.Controls.Add(Me.Txt_email)
        Me.Gb_aluno.Controls.Add(Me.Lb_cpf)
        Me.Gb_aluno.Controls.Add(Me.Lb_email)
        Me.Gb_aluno.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_aluno.Location = New System.Drawing.Point(11, 63)
        Me.Gb_aluno.Margin = New System.Windows.Forms.Padding(2)
        Me.Gb_aluno.Name = "Gb_aluno"
        Me.Gb_aluno.Padding = New System.Windows.Forms.Padding(2)
        Me.Gb_aluno.Size = New System.Drawing.Size(468, 491)
        Me.Gb_aluno.TabIndex = 3
        Me.Gb_aluno.TabStop = False
        Me.Gb_aluno.Text = "Insira os Dados de Aluno"
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
        Me.Btn_cadastrar.Location = New System.Drawing.Point(136, 432)
        Me.Btn_cadastrar.Name = "Btn_cadastrar"
        Me.Btn_cadastrar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_cadastrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_cadastrar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_cadastrar.OnHoverImage = Nothing
        Me.Btn_cadastrar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_cadastrar.Radius = 2
        Me.Btn_cadastrar.Size = New System.Drawing.Size(198, 38)
        Me.Btn_cadastrar.TabIndex = 51
        Me.Btn_cadastrar.Text = "CADASTRAR"
        Me.Btn_cadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_cpf
        '
        Me.Txt_cpf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cpf.Location = New System.Drawing.Point(349, 44)
        Me.Txt_cpf.Mask = "000.000.000-00"
        Me.Txt_cpf.Name = "Txt_cpf"
        Me.Txt_cpf.Size = New System.Drawing.Size(91, 29)
        Me.Txt_cpf.TabIndex = 51
        '
        'Txt_cep
        '
        Me.Txt_cep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cep.Location = New System.Drawing.Point(23, 180)
        Me.Txt_cep.Mask = "00000-999"
        Me.Txt_cep.Name = "Txt_cep"
        Me.Txt_cep.Size = New System.Drawing.Size(128, 29)
        Me.Txt_cep.TabIndex = 50
        '
        'Lb_cidade
        '
        Me.Lb_cidade.AutoSize = True
        Me.Lb_cidade.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cidade.Location = New System.Drawing.Point(244, 225)
        Me.Lb_cidade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cidade.Name = "Lb_cidade"
        Me.Lb_cidade.Size = New System.Drawing.Size(43, 13)
        Me.Lb_cidade.TabIndex = 49
        Me.Lb_cidade.Text = "Cidade"
        '
        'Txt_cidade
        '
        Me.Txt_cidade.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cidade.Location = New System.Drawing.Point(245, 241)
        Me.Txt_cidade.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_cidade.Name = "Txt_cidade"
        Me.Txt_cidade.Size = New System.Drawing.Size(128, 29)
        Me.Txt_cidade.TabIndex = 48
        '
        'Lb_cep
        '
        Me.Lb_cep.AutoSize = True
        Me.Lb_cep.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cep.Location = New System.Drawing.Point(22, 164)
        Me.Lb_cep.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cep.Name = "Lb_cep"
        Me.Lb_cep.Size = New System.Drawing.Size(26, 13)
        Me.Lb_cep.TabIndex = 47
        Me.Lb_cep.Text = "CEP"
        '
        'Lb_complemento
        '
        Me.Lb_complemento.AutoSize = True
        Me.Lb_complemento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_complemento.Location = New System.Drawing.Point(318, 164)
        Me.Lb_complemento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_complemento.Name = "Lb_complemento"
        Me.Lb_complemento.Size = New System.Drawing.Size(79, 13)
        Me.Lb_complemento.TabIndex = 46
        Me.Lb_complemento.Text = "Complemento"
        '
        'Txt_complemento
        '
        Me.Txt_complemento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_complemento.Location = New System.Drawing.Point(319, 179)
        Me.Txt_complemento.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_complemento.Name = "Txt_complemento"
        Me.Txt_complemento.Size = New System.Drawing.Size(128, 29)
        Me.Txt_complemento.TabIndex = 45
        '
        'Txt_telefone
        '
        Me.Txt_telefone.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_telefone.Location = New System.Drawing.Point(22, 302)
        Me.Txt_telefone.Mask = "(99) 00000-0000"
        Me.Txt_telefone.Name = "Txt_telefone"
        Me.Txt_telefone.Size = New System.Drawing.Size(128, 29)
        Me.Txt_telefone.TabIndex = 44
        '
        'Lb_telefone
        '
        Me.Lb_telefone.AutoSize = True
        Me.Lb_telefone.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_telefone.Location = New System.Drawing.Point(19, 286)
        Me.Lb_telefone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_telefone.Name = "Lb_telefone"
        Me.Lb_telefone.Size = New System.Drawing.Size(51, 13)
        Me.Lb_telefone.TabIndex = 43
        Me.Lb_telefone.Text = "Telefone"
        '
        'Lb_bairro
        '
        Me.Lb_bairro.AutoSize = True
        Me.Lb_bairro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_bairro.Location = New System.Drawing.Point(93, 227)
        Me.Lb_bairro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_bairro.Name = "Lb_bairro"
        Me.Lb_bairro.Size = New System.Drawing.Size(37, 13)
        Me.Lb_bairro.TabIndex = 42
        Me.Lb_bairro.Text = "Bairro"
        '
        'Txt_bairro
        '
        Me.Txt_bairro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_bairro.Location = New System.Drawing.Point(96, 242)
        Me.Txt_bairro.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_bairro.Name = "Txt_bairro"
        Me.Txt_bairro.Size = New System.Drawing.Size(128, 29)
        Me.Txt_bairro.TabIndex = 41
        '
        'Lb_numero
        '
        Me.Lb_numero.AutoSize = True
        Me.Lb_numero.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_numero.Location = New System.Drawing.Point(19, 227)
        Me.Lb_numero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_numero.Name = "Lb_numero"
        Me.Lb_numero.Size = New System.Drawing.Size(48, 13)
        Me.Lb_numero.TabIndex = 40
        Me.Lb_numero.Text = "Número"
        '
        'Lb_logradouro
        '
        Me.Lb_logradouro.AutoSize = True
        Me.Lb_logradouro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_logradouro.Location = New System.Drawing.Point(173, 164)
        Me.Lb_logradouro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_logradouro.Name = "Lb_logradouro"
        Me.Lb_logradouro.Size = New System.Drawing.Size(68, 13)
        Me.Lb_logradouro.TabIndex = 39
        Me.Lb_logradouro.Text = "Logradouro"
        '
        'Txt_numero
        '
        Me.Txt_numero.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_numero.Location = New System.Drawing.Point(22, 242)
        Me.Txt_numero.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_numero.MaxLength = 5
        Me.Txt_numero.Name = "Txt_numero"
        Me.Txt_numero.Size = New System.Drawing.Size(48, 29)
        Me.Txt_numero.TabIndex = 38
        '
        'Txt_rua
        '
        Me.Txt_rua.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rua.Location = New System.Drawing.Point(174, 179)
        Me.Txt_rua.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_rua.Name = "Txt_rua"
        Me.Txt_rua.Size = New System.Drawing.Size(128, 29)
        Me.Txt_rua.TabIndex = 37
        '
        'Cmb_uf
        '
        Me.Cmb_uf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_uf.FormattingEnabled = True
        Me.Cmb_uf.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.Cmb_uf.Location = New System.Drawing.Point(398, 241)
        Me.Cmb_uf.Name = "Cmb_uf"
        Me.Cmb_uf.Size = New System.Drawing.Size(48, 29)
        Me.Cmb_uf.TabIndex = 33
        '
        'Lb_uf
        '
        Me.Lb_uf.AutoSize = True
        Me.Lb_uf.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_uf.Location = New System.Drawing.Point(395, 225)
        Me.Lb_uf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_uf.Name = "Lb_uf"
        Me.Lb_uf.Size = New System.Drawing.Size(21, 13)
        Me.Lb_uf.TabIndex = 32
        Me.Lb_uf.Text = "UF"
        '
        'Cmb_Turma
        '
        Me.Cmb_Turma.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Turma.FormattingEnabled = True
        Me.Cmb_Turma.Location = New System.Drawing.Point(238, 91)
        Me.Cmb_Turma.Name = "Cmb_Turma"
        Me.Cmb_Turma.Size = New System.Drawing.Size(93, 29)
        Me.Cmb_Turma.TabIndex = 5
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(38, 44)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(2)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(112, 119)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 17
        Me.img_foto.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.img_foto)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(484, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(186, 205)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Insira a foto de Aluno"
        '
        'abrirArquivo
        '
        Me.abrirArquivo.FileName = "Escolha um Arquivo"
        '
        'Pnl_menu
        '
        Me.Pnl_menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_menu.Controls.Add(Me.Lb_cadastro_alunos)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-4, -6)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(693, 57)
        Me.Pnl_menu.TabIndex = 48
        '
        'Lb_cadastro_alunos
        '
        Me.Lb_cadastro_alunos.AutoSize = True
        Me.Lb_cadastro_alunos.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cadastro_alunos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_cadastro_alunos.Location = New System.Drawing.Point(56, 14)
        Me.Lb_cadastro_alunos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cadastro_alunos.Name = "Lb_cadastro_alunos"
        Me.Lb_cadastro_alunos.Size = New System.Drawing.Size(283, 32)
        Me.Lb_cadastro_alunos.TabIndex = 4
        Me.Lb_cadastro_alunos.Text = "CADASTRO DE ALUNOS"
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
        Me.Btn_limpar_campos.Location = New System.Drawing.Point(554, 494)
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
        Me.Btn_voltar.Location = New System.Drawing.Point(579, 527)
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
        'Frm_cadastroAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(682, 563)
        Me.Controls.Add(Me.Btn_limpar_campos)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Gb_aluno)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_cadastroAluno"
        Me.Text = "Cadastro de Alunos"
        Me.Gb_aluno.ResumeLayout(False)
        Me.Gb_aluno.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lb_ra As Label
    Friend WithEvents Txt_ra As TextBox
    Friend WithEvents Lb_nome As Label
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Lb_cpf As Label
    Friend WithEvents Lb_email As Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Lb_senha As Label
    Friend WithEvents Lb_turma As Label
    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Gb_aluno As GroupBox
    Friend WithEvents Cmb_Turma As ComboBox
    Friend WithEvents Cmb_uf As ComboBox
    Friend WithEvents Lb_uf As Label
    Friend WithEvents Txt_cep As MaskedTextBox
    Friend WithEvents Lb_cidade As Label
    Friend WithEvents Txt_cidade As TextBox
    Friend WithEvents Lb_cep As Label
    Friend WithEvents Lb_complemento As Label
    Friend WithEvents Txt_complemento As TextBox
    Friend WithEvents Txt_telefone As MaskedTextBox
    Friend WithEvents Lb_telefone As Label
    Friend WithEvents Lb_bairro As Label
    Friend WithEvents Txt_bairro As TextBox
    Friend WithEvents Lb_numero As Label
    Friend WithEvents Lb_logradouro As Label
    Friend WithEvents Txt_numero As TextBox
    Friend WithEvents Txt_rua As TextBox
    Friend WithEvents Txt_cpf As MaskedTextBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents abrirArquivo As OpenFileDialog
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Lb_cadastro_alunos As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_cadastrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_limpar_campos As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
End Class
