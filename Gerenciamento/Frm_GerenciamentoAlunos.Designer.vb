﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_GerenciamentoAlunos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_GerenciamentoAlunos))
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Txt_buscar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Cmb_campo = New System.Windows.Forms.ToolStripComboBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_turma = New System.Windows.Forms.ComboBox()
        Me.Lb_cidade = New System.Windows.Forms.Label()
        Me.Txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_complemento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_bairro = New System.Windows.Forms.TextBox()
        Me.Txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Lb_cpf = New System.Windows.Forms.Label()
        Me.Txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_rua = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_numero = New System.Windows.Forms.TextBox()
        Me.Cmb_uf = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_ra = New System.Windows.Forms.TextBox()
        Me.btn_gravar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_editar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_bloquear = New Guna.UI.WinForms.GunaButton()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_dados
        '
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Location = New System.Drawing.Point(45, 512)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.RowHeadersWidth = 62
        Me.dgv_dados.Size = New System.Drawing.Size(1108, 268)
        Me.dgv_dados.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.Txt_buscar, Me.ToolStripLabel2, Me.Cmb_campo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1200, 33)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(318, 28)
        Me.ToolStripLabel1.Text = "Digite um parâmetro de pesquisa"
        Me.ToolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Txt_buscar
        '
        Me.Txt_buscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Txt_buscar.Name = "Txt_buscar"
        Me.Txt_buscar.Size = New System.Drawing.Size(148, 33)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(189, 28)
        Me.ToolStripLabel2.Text = "Selecione um Campo"
        '
        'Cmb_campo
        '
        Me.Cmb_campo.Items.AddRange(New Object() {"Nome", "RA"})
        Me.Cmb_campo.Name = "Cmb_campo"
        Me.Cmb_campo.Size = New System.Drawing.Size(148, 33)
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(986, 51)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(167, 182)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 16
        Me.img_foto.TabStop = False
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(57, 82)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(736, 39)
        Me.txt_nome.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nome"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(56, 168)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(505, 39)
        Me.txt_email.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "E-mail"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(656, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 23)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Turma"
        '
        'cb_turma
        '
        Me.cb_turma.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_turma.FormattingEnabled = True
        Me.cb_turma.Location = New System.Drawing.Point(660, 258)
        Me.cb_turma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_turma.Name = "cb_turma"
        Me.cb_turma.Size = New System.Drawing.Size(186, 40)
        Me.cb_turma.TabIndex = 29
        '
        'Lb_cidade
        '
        Me.Lb_cidade.AutoSize = True
        Me.Lb_cidade.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cidade.Location = New System.Drawing.Point(656, 428)
        Me.Lb_cidade.Name = "Lb_cidade"
        Me.Lb_cidade.Size = New System.Drawing.Size(66, 23)
        Me.Lb_cidade.TabIndex = 72
        Me.Lb_cidade.Text = "Cidade"
        '
        'Txt_cidade
        '
        Me.Txt_cidade.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cidade.Location = New System.Drawing.Point(660, 451)
        Me.Txt_cidade.Name = "Txt_cidade"
        Me.Txt_cidade.Size = New System.Drawing.Size(186, 39)
        Me.Txt_cidade.TabIndex = 71
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(52, 428)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 23)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Complemento"
        '
        'Txt_complemento
        '
        Me.Txt_complemento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_complemento.Location = New System.Drawing.Point(54, 451)
        Me.Txt_complemento.Name = "Txt_complemento"
        Me.Txt_complemento.Size = New System.Drawing.Size(204, 39)
        Me.Txt_complemento.TabIndex = 69
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(352, 428)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 23)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Bairro"
        '
        'Txt_bairro
        '
        Me.Txt_bairro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_bairro.Location = New System.Drawing.Point(354, 451)
        Me.Txt_bairro.Name = "Txt_bairro"
        Me.Txt_bairro.Size = New System.Drawing.Size(204, 39)
        Me.Txt_bairro.TabIndex = 67
        '
        'Txt_telefone
        '
        Me.Txt_telefone.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_telefone.Location = New System.Drawing.Point(54, 258)
        Me.Txt_telefone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_telefone.Mask = "(99) 00000-0000"
        Me.Txt_telefone.Name = "Txt_telefone"
        Me.Txt_telefone.Size = New System.Drawing.Size(204, 39)
        Me.Txt_telefone.TabIndex = 74
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(52, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 23)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Telefone"
        '
        'Txt_cpf
        '
        Me.Txt_cpf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cpf.Location = New System.Drawing.Point(660, 168)
        Me.Txt_cpf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_cpf.Mask = "000.000.000-00"
        Me.Txt_cpf.Name = "Txt_cpf"
        Me.Txt_cpf.Size = New System.Drawing.Size(134, 39)
        Me.Txt_cpf.TabIndex = 78
        '
        'Lb_cpf
        '
        Me.Lb_cpf.AutoSize = True
        Me.Lb_cpf.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cpf.Location = New System.Drawing.Point(656, 145)
        Me.Lb_cpf.Name = "Lb_cpf"
        Me.Lb_cpf.Size = New System.Drawing.Size(40, 23)
        Me.Lb_cpf.TabIndex = 77
        Me.Lb_cpf.Text = "CPF"
        '
        'Txt_cep
        '
        Me.Txt_cep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cep.Location = New System.Drawing.Point(54, 351)
        Me.Txt_cep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_cep.Mask = "00000-999"
        Me.Txt_cep.Name = "Txt_cep"
        Me.Txt_cep.Size = New System.Drawing.Size(204, 39)
        Me.Txt_cep.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(52, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 23)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "CEP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(352, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 23)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Rua"
        '
        'Txt_rua
        '
        Me.Txt_rua.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rua.Location = New System.Drawing.Point(354, 349)
        Me.Txt_rua.Name = "Txt_rua"
        Me.Txt_rua.Size = New System.Drawing.Size(204, 39)
        Me.Txt_rua.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(656, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 23)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Número"
        '
        'Txt_numero
        '
        Me.Txt_numero.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_numero.Location = New System.Drawing.Point(660, 349)
        Me.Txt_numero.MaxLength = 5
        Me.Txt_numero.Name = "Txt_numero"
        Me.Txt_numero.Size = New System.Drawing.Size(70, 39)
        Me.Txt_numero.TabIndex = 83
        '
        'Cmb_uf
        '
        Me.Cmb_uf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_uf.FormattingEnabled = True
        Me.Cmb_uf.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.Cmb_uf.Location = New System.Drawing.Point(774, 351)
        Me.Cmb_uf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cmb_uf.Name = "Cmb_uf"
        Me.Cmb_uf.Size = New System.Drawing.Size(70, 40)
        Me.Cmb_uf.TabIndex = 86
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(770, 326)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 23)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "UF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(352, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 23)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "RA"
        '
        'Txt_ra
        '
        Me.Txt_ra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ra.Location = New System.Drawing.Point(357, 257)
        Me.Txt_ra.MaxLength = 11
        Me.Txt_ra.Name = "Txt_ra"
        Me.Txt_ra.Size = New System.Drawing.Size(204, 39)
        Me.Txt_ra.TabIndex = 23
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
        Me.btn_gravar.Location = New System.Drawing.Point(1000, 383)
        Me.btn_gravar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.btn_gravar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_gravar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_gravar.OnHoverImage = Nothing
        Me.btn_gravar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_gravar.Radius = 2
        Me.btn_gravar.Size = New System.Drawing.Size(136, 42)
        Me.btn_gravar.TabIndex = 92
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
        Me.Btn_editar.Location = New System.Drawing.Point(1000, 320)
        Me.Btn_editar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_editar.Name = "Btn_editar"
        Me.Btn_editar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_editar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_editar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_editar.OnHoverImage = Nothing
        Me.Btn_editar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_editar.Radius = 2
        Me.Btn_editar.Size = New System.Drawing.Size(136, 42)
        Me.Btn_editar.TabIndex = 91
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
        Me.Btn_voltar.Location = New System.Drawing.Point(999, 257)
        Me.Btn_voltar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(136, 42)
        Me.Btn_voltar.TabIndex = 90
        Me.Btn_voltar.Text = "Voltar"
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
        Me.Btn_bloquear.Location = New System.Drawing.Point(951, 451)
        Me.Btn_bloquear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_bloquear.Name = "Btn_bloquear"
        Me.Btn_bloquear.OnHoverBaseColor = System.Drawing.Color.DarkRed
        Me.Btn_bloquear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_bloquear.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_bloquear.OnHoverImage = Nothing
        Me.Btn_bloquear.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_bloquear.Radius = 2
        Me.Btn_bloquear.Size = New System.Drawing.Size(186, 42)
        Me.Btn_bloquear.TabIndex = 93
        Me.Btn_bloquear.Text = "BLOQUEAR"
        '
        'Frm_GerenciamentoAlunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1200, 818)
        Me.Controls.Add(Me.Btn_bloquear)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.Btn_editar)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Cmb_uf)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_numero)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Txt_rua)
        Me.Controls.Add(Me.Txt_cep)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txt_cpf)
        Me.Controls.Add(Me.Lb_cpf)
        Me.Controls.Add(Me.Txt_telefone)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Lb_cidade)
        Me.Controls.Add(Me.Txt_cidade)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txt_complemento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txt_bairro)
        Me.Controls.Add(Me.cb_turma)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_ra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv_dados)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_GerenciamentoAlunos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento e Edição de Contas de Alunos"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Txt_buscar As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Cmb_campo As ToolStripComboBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_turma As ComboBox
    Friend WithEvents Lb_cidade As Label
    Friend WithEvents Txt_cidade As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_complemento As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_bairro As TextBox
    Friend WithEvents Txt_telefone As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Txt_cpf As MaskedTextBox
    Friend WithEvents Lb_cpf As Label
    Friend WithEvents Txt_cep As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_rua As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_numero As TextBox
    Friend WithEvents Cmb_uf As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_ra As TextBox
    Friend WithEvents btn_gravar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_editar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_bloquear As Guna.UI.WinForms.GunaButton
End Class
