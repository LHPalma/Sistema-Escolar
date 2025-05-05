<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_gerenContas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_gerenContas))
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.img_editar = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_gravar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_buscar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_campo = New System.Windows.Forms.ToolStripComboBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_disc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.Txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Lb_cpf = New System.Windows.Forms.Label()
        Me.Cmb_Turma = New System.Windows.Forms.ComboBox()
        Me.Txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_numero = New System.Windows.Forms.TextBox()
        Me.Txt_rua = New System.Windows.Forms.TextBox()
        Me.Lb_cidade = New System.Windows.Forms.Label()
        Me.Txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_complemento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_bairro = New System.Windows.Forms.TextBox()
        Me.Cmb_uf = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Btn_voltar = New System.Windows.Forms.Button()
        Me.Btn_limpar_campos = New System.Windows.Forms.Button()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_dados
        '
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Location = New System.Drawing.Point(31, 329)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.Size = New System.Drawing.Size(738, 174)
        Me.dgv_dados.TabIndex = 0
        '
        'img_editar
        '
        Me.img_editar.Location = New System.Drawing.Point(575, 50)
        Me.img_editar.Margin = New System.Windows.Forms.Padding(2)
        Me.img_editar.Name = "img_editar"
        Me.img_editar.Size = New System.Drawing.Size(50, 25)
        Me.img_editar.TabIndex = 18
        Me.img_editar.Text = "Editar"
        Me.img_editar.UseVisualStyleBackColor = True
        Me.img_editar.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_gravar, Me.ToolStripLabel1, Me.txt_buscar, Me.ToolStripLabel2, Me.cmb_campo, Me.ToolStripLabel3, Me.ToolStripComboBox1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 31)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_gravar
        '
        Me.btn_gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gravar.Image = CType(resources.GetObject("btn_gravar.Image"), System.Drawing.Image)
        Me.btn_gravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(28, 28)
        Me.btn_gravar.Text = "ToolStripButton1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(191, 28)
        Me.ToolStripLabel1.Text = "Digite um parâmetro de pesquisa"
        '
        'txt_buscar
        '
        Me.txt_buscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(68, 31)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(123, 28)
        Me.ToolStripLabel2.Text = "Selecione um Campo"
        '
        'cmb_campo
        '
        Me.cmb_campo.Name = "cmb_campo"
        Me.cmb_campo.Size = New System.Drawing.Size(82, 31)
        '
        'img_foto
        '
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(657, 38)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(2)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(112, 119)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 16
        Me.img_foto.TabStop = False
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(38, 53)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(492, 20)
        Me.txt_nome.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nome"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(37, 109)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(338, 20)
        Me.txt_email.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "E-mail"
        '
        'txt_ra
        '
        Me.txt_ra.Location = New System.Drawing.Point(238, 167)
        Me.txt_ra.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ra.Name = "txt_ra"
        Me.txt_ra.Size = New System.Drawing.Size(137, 20)
        Me.txt_ra.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(235, 152)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "RA"
        '
        'txt_disc
        '
        Me.txt_disc.Location = New System.Drawing.Point(38, 167)
        Me.txt_disc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_disc.Name = "txt_disc"
        Me.txt_disc.Size = New System.Drawing.Size(137, 20)
        Me.txt_disc.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 152)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Disciplina"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(437, 152)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Turma"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(146, 28)
        Me.ToolStripLabel3.Text = "Selecione o tipo de perfil"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Aluno", "Professor", "Administrador"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 31)
        '
        'Txt_cpf
        '
        Me.Txt_cpf.Location = New System.Drawing.Point(440, 109)
        Me.Txt_cpf.Mask = "000.000.000-00"
        Me.Txt_cpf.Name = "Txt_cpf"
        Me.Txt_cpf.Size = New System.Drawing.Size(91, 20)
        Me.Txt_cpf.TabIndex = 53
        '
        'Lb_cpf
        '
        Me.Lb_cpf.AutoSize = True
        Me.Lb_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cpf.Location = New System.Drawing.Point(437, 94)
        Me.Lb_cpf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cpf.Name = "Lb_cpf"
        Me.Lb_cpf.Size = New System.Drawing.Size(30, 13)
        Me.Lb_cpf.TabIndex = 52
        Me.Lb_cpf.Text = "CPF"
        '
        'Cmb_Turma
        '
        Me.Cmb_Turma.FormattingEnabled = True
        Me.Cmb_Turma.Location = New System.Drawing.Point(440, 168)
        Me.Cmb_Turma.Name = "Cmb_Turma"
        Me.Cmb_Turma.Size = New System.Drawing.Size(127, 21)
        Me.Cmb_Turma.TabIndex = 54
        '
        'Txt_cep
        '
        Me.Txt_cep.Location = New System.Drawing.Point(38, 225)
        Me.Txt_cep.Mask = "00000-999"
        Me.Txt_cep.Name = "Txt_cep"
        Me.Txt_cep.Size = New System.Drawing.Size(137, 20)
        Me.Txt_cep.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 209)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "CEP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(435, 210)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Número"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(237, 210)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Rua"
        '
        'Txt_numero
        '
        Me.Txt_numero.Location = New System.Drawing.Point(438, 225)
        Me.Txt_numero.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_numero.MaxLength = 5
        Me.Txt_numero.Name = "Txt_numero"
        Me.Txt_numero.Size = New System.Drawing.Size(48, 20)
        Me.Txt_numero.TabIndex = 58
        '
        'Txt_rua
        '
        Me.Txt_rua.Location = New System.Drawing.Point(238, 225)
        Me.Txt_rua.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_rua.Name = "Txt_rua"
        Me.Txt_rua.Size = New System.Drawing.Size(137, 20)
        Me.Txt_rua.TabIndex = 57
        '
        'Lb_cidade
        '
        Me.Lb_cidade.AutoSize = True
        Me.Lb_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cidade.Location = New System.Drawing.Point(437, 271)
        Me.Lb_cidade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cidade.Name = "Lb_cidade"
        Me.Lb_cidade.Size = New System.Drawing.Size(46, 13)
        Me.Lb_cidade.TabIndex = 66
        Me.Lb_cidade.Text = "Cidade"
        '
        'Txt_cidade
        '
        Me.Txt_cidade.Location = New System.Drawing.Point(438, 286)
        Me.Txt_cidade.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_cidade.Name = "Txt_cidade"
        Me.Txt_cidade.Size = New System.Drawing.Size(129, 20)
        Me.Txt_cidade.TabIndex = 65
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, 271)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Complemento"
        '
        'Txt_complemento
        '
        Me.Txt_complemento.Location = New System.Drawing.Point(38, 286)
        Me.Txt_complemento.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_complemento.Name = "Txt_complemento"
        Me.Txt_complemento.Size = New System.Drawing.Size(137, 20)
        Me.Txt_complemento.TabIndex = 63
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(237, 271)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Bairro"
        '
        'Txt_bairro
        '
        Me.Txt_bairro.Location = New System.Drawing.Point(238, 286)
        Me.Txt_bairro.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_bairro.Name = "Txt_bairro"
        Me.Txt_bairro.Size = New System.Drawing.Size(137, 20)
        Me.Txt_bairro.TabIndex = 61
        '
        'Cmb_uf
        '
        Me.Cmb_uf.FormattingEnabled = True
        Me.Cmb_uf.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.Cmb_uf.Location = New System.Drawing.Point(519, 225)
        Me.Cmb_uf.Name = "Cmb_uf"
        Me.Cmb_uf.Size = New System.Drawing.Size(48, 21)
        Me.Cmb_uf.TabIndex = 68
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(516, 209)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 13)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "UF"
        '
        'Txt_telefone
        '
        Me.Txt_telefone.Location = New System.Drawing.Point(630, 286)
        Me.Txt_telefone.Mask = "(99) 00000-0000"
        Me.Txt_telefone.Name = "Txt_telefone"
        Me.Txt_telefone.Size = New System.Drawing.Size(128, 20)
        Me.Txt_telefone.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(628, 270)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Telefone"
        '
        'Btn_voltar
        '
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_voltar.Location = New System.Drawing.Point(669, 168)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 72
        Me.Btn_voltar.Text = "Voltar"
        Me.Btn_voltar.UseVisualStyleBackColor = True
        '
        'Btn_limpar_campos
        '
        Me.Btn_limpar_campos.Location = New System.Drawing.Point(669, 210)
        Me.Btn_limpar_campos.Name = "Btn_limpar_campos"
        Me.Btn_limpar_campos.Size = New System.Drawing.Size(91, 27)
        Me.Btn_limpar_campos.TabIndex = 71
        Me.Btn_limpar_campos.Text = "Limpar Campos"
        Me.Btn_limpar_campos.UseVisualStyleBackColor = True
        '
        'Frm_gerenContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 532)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Btn_limpar_campos)
        Me.Controls.Add(Me.Txt_telefone)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Cmb_uf)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Lb_cidade)
        Me.Controls.Add(Me.Txt_cidade)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txt_complemento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txt_bairro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Txt_numero)
        Me.Controls.Add(Me.Txt_rua)
        Me.Controls.Add(Me.Txt_cep)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Cmb_Turma)
        Me.Controls.Add(Me.Txt_cpf)
        Me.Controls.Add(Me.Lb_cpf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_disc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_ra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.img_editar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv_dados)
        Me.Name = "Frm_gerenContas"
        Me.Text = "Gerenciamento e Edição de Contas"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents img_editar As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_gravar As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_buscar As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_campo As ToolStripComboBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ra As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_disc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents Txt_cpf As MaskedTextBox
    Friend WithEvents Lb_cpf As Label
    Friend WithEvents Cmb_Turma As ComboBox
    Friend WithEvents Txt_cep As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_numero As TextBox
    Friend WithEvents Txt_rua As TextBox
    Friend WithEvents Lb_cidade As Label
    Friend WithEvents Txt_cidade As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_complemento As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_bairro As TextBox
    Friend WithEvents Cmb_uf As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Txt_telefone As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Btn_voltar As Button
    Friend WithEvents Btn_limpar_campos As Button
End Class
