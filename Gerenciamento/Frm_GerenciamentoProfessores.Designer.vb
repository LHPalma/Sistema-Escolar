<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GerenciamentoProfessores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_GerenciamentoProfessores))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Txt_buscar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Cmb_campo = New System.Windows.Forms.ToolStripComboBox()
        Me.Dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.Txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Lb_cpf = New System.Windows.Forms.Label()
        Me.Txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_disc = New System.Windows.Forms.TextBox()
        Me.Txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_complemento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_rua = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_bairro = New System.Windows.Forms.TextBox()
        Me.Cmb_uf = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_numero = New System.Windows.Forms.TextBox()
        Me.Lb_cidade = New System.Windows.Forms.Label()
        Me.Txt_cidade = New System.Windows.Forms.TextBox()
        Me.Btn_bloquear = New Guna.UI.WinForms.GunaButton()
        Me.btn_gravar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_editar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.Txt_buscar, Me.ToolStripLabel2, Me.Cmb_campo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 27)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(215, 24)
        Me.ToolStripLabel1.Text = "Digite um parâmetro de pesquisa"
        Me.ToolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Txt_buscar
        '
        Me.Txt_buscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Txt_buscar.Name = "Txt_buscar"
        Me.Txt_buscar.Size = New System.Drawing.Size(100, 27)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(123, 24)
        Me.ToolStripLabel2.Text = "Selecione um Campo"
        '
        'Cmb_campo
        '
        Me.Cmb_campo.Items.AddRange(New Object() {"Nome", "RA"})
        Me.Cmb_campo.Name = "Cmb_campo"
        Me.Cmb_campo.Size = New System.Drawing.Size(100, 27)
        '
        'Dgv_dados
        '
        Me.Dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_dados.Location = New System.Drawing.Point(32, 333)
        Me.Dgv_dados.Name = "Dgv_dados"
        Me.Dgv_dados.Size = New System.Drawing.Size(739, 174)
        Me.Dgv_dados.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "E-mail"
        '
        'Txt_email
        '
        Me.Txt_email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_email.Location = New System.Drawing.Point(41, 109)
        Me.Txt_email.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(338, 29)
        Me.Txt_email.TabIndex = 23
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(42, 53)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(492, 29)
        Me.txt_nome.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nome"
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(659, 33)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(112, 119)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 77
        Me.img_foto.TabStop = False
        '
        'Txt_cpf
        '
        Me.Txt_cpf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cpf.Location = New System.Drawing.Point(443, 109)
        Me.Txt_cpf.Mask = "000.000.000-00"
        Me.Txt_cpf.Name = "Txt_cpf"
        Me.Txt_cpf.Size = New System.Drawing.Size(91, 29)
        Me.Txt_cpf.TabIndex = 83
        '
        'Lb_cpf
        '
        Me.Lb_cpf.AutoSize = True
        Me.Lb_cpf.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cpf.Location = New System.Drawing.Point(440, 94)
        Me.Lb_cpf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cpf.Name = "Lb_cpf"
        Me.Lb_cpf.Size = New System.Drawing.Size(27, 13)
        Me.Lb_cpf.TabIndex = 82
        Me.Lb_cpf.Text = "CPF"
        '
        'Txt_telefone
        '
        Me.Txt_telefone.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_telefone.Location = New System.Drawing.Point(40, 168)
        Me.Txt_telefone.Mask = "(99) 00000-0000"
        Me.Txt_telefone.Name = "Txt_telefone"
        Me.Txt_telefone.Size = New System.Drawing.Size(139, 29)
        Me.Txt_telefone.TabIndex = 81
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(39, 152)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Telefone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(239, 153)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Disciplina"
        '
        'txt_disc
        '
        Me.txt_disc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disc.Location = New System.Drawing.Point(242, 168)
        Me.txt_disc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_disc.Name = "txt_disc"
        Me.txt_disc.Size = New System.Drawing.Size(137, 29)
        Me.txt_disc.TabIndex = 84
        '
        'Txt_cep
        '
        Me.Txt_cep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cep.Location = New System.Drawing.Point(42, 228)
        Me.Txt_cep.Mask = "00000-999"
        Me.Txt_cep.Name = "Txt_cep"
        Me.Txt_cep.Size = New System.Drawing.Size(137, 29)
        Me.Txt_cep.TabIndex = 89
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 212)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "CEP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 278)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Complemento"
        '
        'Txt_complemento
        '
        Me.Txt_complemento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_complemento.Location = New System.Drawing.Point(42, 293)
        Me.Txt_complemento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_complemento.Name = "Txt_complemento"
        Me.Txt_complemento.Size = New System.Drawing.Size(137, 29)
        Me.Txt_complemento.TabIndex = 86
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(241, 213)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Rua"
        '
        'Txt_rua
        '
        Me.Txt_rua.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rua.Location = New System.Drawing.Point(242, 228)
        Me.Txt_rua.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_rua.Name = "Txt_rua"
        Me.Txt_rua.Size = New System.Drawing.Size(137, 29)
        Me.Txt_rua.TabIndex = 92
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(241, 279)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Bairro"
        '
        'Txt_bairro
        '
        Me.Txt_bairro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_bairro.Location = New System.Drawing.Point(242, 294)
        Me.Txt_bairro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_bairro.Name = "Txt_bairro"
        Me.Txt_bairro.Size = New System.Drawing.Size(137, 29)
        Me.Txt_bairro.TabIndex = 90
        '
        'Cmb_uf
        '
        Me.Cmb_uf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_uf.FormattingEnabled = True
        Me.Cmb_uf.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.Cmb_uf.Location = New System.Drawing.Point(514, 228)
        Me.Cmb_uf.Name = "Cmb_uf"
        Me.Cmb_uf.Size = New System.Drawing.Size(48, 29)
        Me.Cmb_uf.TabIndex = 99
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(511, 212)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "UF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(435, 212)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Número"
        '
        'Txt_numero
        '
        Me.Txt_numero.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_numero.Location = New System.Drawing.Point(438, 227)
        Me.Txt_numero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_numero.MaxLength = 5
        Me.Txt_numero.Name = "Txt_numero"
        Me.Txt_numero.Size = New System.Drawing.Size(48, 29)
        Me.Txt_numero.TabIndex = 96
        '
        'Lb_cidade
        '
        Me.Lb_cidade.AutoSize = True
        Me.Lb_cidade.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cidade.Location = New System.Drawing.Point(437, 279)
        Me.Lb_cidade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cidade.Name = "Lb_cidade"
        Me.Lb_cidade.Size = New System.Drawing.Size(43, 13)
        Me.Lb_cidade.TabIndex = 95
        Me.Lb_cidade.Text = "Cidade"
        '
        'Txt_cidade
        '
        Me.Txt_cidade.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cidade.Location = New System.Drawing.Point(438, 294)
        Me.Txt_cidade.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_cidade.Name = "Txt_cidade"
        Me.Txt_cidade.Size = New System.Drawing.Size(124, 29)
        Me.Txt_cidade.TabIndex = 94
        '
        'Btn_bloquear
        '
        Me.Btn_bloquear.AnimationHoverSpeed = 0.07!
        Me.Btn_bloquear.AnimationSpeed = 0.03!
        Me.Btn_bloquear.BackColor = System.Drawing.Color.Transparent
        Me.Btn_bloquear.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_bloquear.BorderColor = System.Drawing.Color.Black
        Me.Btn_bloquear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_bloquear.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_bloquear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_bloquear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_bloquear.Image = CType(resources.GetObject("Btn_bloquear.Image"), System.Drawing.Image)
        Me.Btn_bloquear.ImageSize = New System.Drawing.Size(22, 22)
        Me.Btn_bloquear.Location = New System.Drawing.Point(636, 292)
        Me.Btn_bloquear.Name = "Btn_bloquear"
        Me.Btn_bloquear.OnHoverBaseColor = System.Drawing.Color.DarkRed
        Me.Btn_bloquear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_bloquear.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_bloquear.OnHoverImage = Nothing
        Me.Btn_bloquear.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_bloquear.Radius = 2
        Me.Btn_bloquear.Size = New System.Drawing.Size(124, 27)
        Me.Btn_bloquear.TabIndex = 103
        Me.Btn_bloquear.Text = "BLOQUEAR"
        '
        'btn_gravar
        '
        Me.btn_gravar.AnimationHoverSpeed = 0.07!
        Me.btn_gravar.AnimationSpeed = 0.03!
        Me.btn_gravar.BackColor = System.Drawing.Color.Transparent
        Me.btn_gravar.BaseColor = System.Drawing.Color.SteelBlue
        Me.btn_gravar.BorderColor = System.Drawing.Color.Black
        Me.btn_gravar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_gravar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_gravar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.ForeColor = System.Drawing.Color.White
        Me.btn_gravar.Image = CType(resources.GetObject("btn_gravar.Image"), System.Drawing.Image)
        Me.btn_gravar.ImageSize = New System.Drawing.Size(22, 22)
        Me.btn_gravar.Location = New System.Drawing.Point(669, 248)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.btn_gravar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_gravar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_gravar.OnHoverImage = Nothing
        Me.btn_gravar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_gravar.Radius = 2
        Me.btn_gravar.Size = New System.Drawing.Size(91, 27)
        Me.btn_gravar.TabIndex = 102
        Me.btn_gravar.Text = "SALVAR"
        Me.btn_gravar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Btn_editar
        '
        Me.Btn_editar.AnimationHoverSpeed = 0.07!
        Me.Btn_editar.AnimationSpeed = 0.03!
        Me.Btn_editar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_editar.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_editar.BorderColor = System.Drawing.Color.Black
        Me.Btn_editar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_editar.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_editar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_editar.ForeColor = System.Drawing.Color.White
        Me.Btn_editar.Image = CType(resources.GetObject("Btn_editar.Image"), System.Drawing.Image)
        Me.Btn_editar.ImageSize = New System.Drawing.Size(22, 22)
        Me.Btn_editar.Location = New System.Drawing.Point(669, 207)
        Me.Btn_editar.Name = "Btn_editar"
        Me.Btn_editar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_editar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_editar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_editar.OnHoverImage = Nothing
        Me.Btn_editar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_editar.Radius = 2
        Me.Btn_editar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_editar.TabIndex = 101
        Me.Btn_editar.Text = "EDITAR"
        Me.Btn_editar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.Btn_voltar.Location = New System.Drawing.Point(668, 166)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 100
        Me.Btn_voltar.Text = "Voltar"
        '
        'Frm_GerenciamentoProfessores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 532)
        Me.Controls.Add(Me.Btn_bloquear)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.Btn_editar)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Cmb_uf)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_numero)
        Me.Controls.Add(Me.Lb_cidade)
        Me.Controls.Add(Me.Txt_cidade)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Txt_rua)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txt_bairro)
        Me.Controls.Add(Me.Txt_cep)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txt_complemento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_disc)
        Me.Controls.Add(Me.Txt_cpf)
        Me.Controls.Add(Me.Lb_cpf)
        Me.Controls.Add(Me.Txt_telefone)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_email)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Dgv_dados)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Frm_GerenciamentoProfessores"
        Me.Text = "Gerenciamento e Edição de Contas de Professores"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Txt_buscar As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Cmb_campo As ToolStripComboBox
    Friend WithEvents Dgv_dados As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents Txt_cpf As MaskedTextBox
    Friend WithEvents Lb_cpf As Label
    Friend WithEvents Txt_telefone As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_disc As TextBox
    Friend WithEvents Txt_cep As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_complemento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_rua As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_bairro As TextBox
    Friend WithEvents Cmb_uf As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_numero As TextBox
    Friend WithEvents Lb_cidade As Label
    Friend WithEvents Txt_cidade As TextBox
    Friend WithEvents Btn_bloquear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_gravar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_editar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
End Class
