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
        Me.Btn_cadastrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Lb_cidade = New System.Windows.Forms.Label()
        Me.Txt_cidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_complemento = New System.Windows.Forms.TextBox()
        Me.Txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_numero = New System.Windows.Forms.TextBox()
        Me.Txt_rua = New System.Windows.Forms.TextBox()
        Me.Cmb_uf = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cmb_Turma = New System.Windows.Forms.ComboBox()
        Me.Cb_mostrar_senha = New System.Windows.Forms.CheckBox()
        Me.Btn_limpar_campos = New System.Windows.Forms.Button()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_voltar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_ra
        '
        Me.Lb_ra.AutoSize = True
        Me.Lb_ra.Location = New System.Drawing.Point(45, 27)
        Me.Lb_ra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_ra.Name = "Lb_ra"
        Me.Lb_ra.Size = New System.Drawing.Size(22, 13)
        Me.Lb_ra.TabIndex = 0
        Me.Lb_ra.Text = "RA"
        '
        'Txt_ra
        '
        Me.Txt_ra.Location = New System.Drawing.Point(49, 42)
        Me.Txt_ra.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_ra.Name = "Txt_ra"
        Me.Txt_ra.Size = New System.Drawing.Size(94, 20)
        Me.Txt_ra.TabIndex = 1
        '
        'Lb_nome
        '
        Me.Lb_nome.AutoSize = True
        Me.Lb_nome.Location = New System.Drawing.Point(46, 71)
        Me.Lb_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_nome.Name = "Lb_nome"
        Me.Lb_nome.Size = New System.Drawing.Size(35, 13)
        Me.Lb_nome.TabIndex = 0
        Me.Lb_nome.Text = "Nome"
        '
        'Txt_nome
        '
        Me.Txt_nome.Location = New System.Drawing.Point(48, 86)
        Me.Txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(195, 20)
        Me.Txt_nome.TabIndex = 1
        '
        'Lb_cpf
        '
        Me.Lb_cpf.AutoSize = True
        Me.Lb_cpf.Location = New System.Drawing.Point(149, 27)
        Me.Lb_cpf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cpf.Name = "Lb_cpf"
        Me.Lb_cpf.Size = New System.Drawing.Size(27, 13)
        Me.Lb_cpf.TabIndex = 0
        Me.Lb_cpf.Text = "CPF"
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Location = New System.Drawing.Point(46, 118)
        Me.Lb_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(32, 13)
        Me.Lb_email.TabIndex = 0
        Me.Lb_email.Text = "Email"
        '
        'Txt_email
        '
        Me.Txt_email.Location = New System.Drawing.Point(48, 133)
        Me.Txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(195, 20)
        Me.Txt_email.TabIndex = 1
        '
        'Lb_senha
        '
        Me.Lb_senha.AutoSize = True
        Me.Lb_senha.Location = New System.Drawing.Point(47, 477)
        Me.Lb_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_senha.Name = "Lb_senha"
        Me.Lb_senha.Size = New System.Drawing.Size(38, 13)
        Me.Lb_senha.TabIndex = 0
        Me.Lb_senha.Text = "Senha"
        '
        'Lb_turma
        '
        Me.Lb_turma.AutoSize = True
        Me.Lb_turma.Location = New System.Drawing.Point(45, 161)
        Me.Lb_turma.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_turma.Name = "Lb_turma"
        Me.Lb_turma.Size = New System.Drawing.Size(37, 13)
        Me.Lb_turma.TabIndex = 0
        Me.Lb_turma.Text = "Turma"
        '
        'Txt_senha
        '
        Me.Txt_senha.Location = New System.Drawing.Point(48, 493)
        Me.Txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.Size = New System.Drawing.Size(117, 20)
        Me.Txt_senha.TabIndex = 1
        Me.Txt_senha.UseSystemPasswordChar = True
        '
        'Btn_cadastrar
        '
        Me.Btn_cadastrar.Location = New System.Drawing.Point(39, 533)
        Me.Btn_cadastrar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_cadastrar.Name = "Btn_cadastrar"
        Me.Btn_cadastrar.Size = New System.Drawing.Size(219, 43)
        Me.Btn_cadastrar.TabIndex = 2
        Me.Btn_cadastrar.Text = "CADASTRAR"
        Me.Btn_cadastrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_cpf)
        Me.GroupBox1.Controls.Add(Me.Txt_cep)
        Me.GroupBox1.Controls.Add(Me.Lb_cidade)
        Me.GroupBox1.Controls.Add(Me.Txt_cidade)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txt_complemento)
        Me.GroupBox1.Controls.Add(Me.Txt_telefone)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_bairro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_numero)
        Me.GroupBox1.Controls.Add(Me.Txt_rua)
        Me.GroupBox1.Controls.Add(Me.Cmb_uf)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Cmb_Turma)
        Me.GroupBox1.Controls.Add(Me.Cb_mostrar_senha)
        Me.GroupBox1.Controls.Add(Me.Btn_cadastrar)
        Me.GroupBox1.Controls.Add(Me.Txt_senha)
        Me.GroupBox1.Controls.Add(Me.Txt_ra)
        Me.GroupBox1.Controls.Add(Me.Lb_turma)
        Me.GroupBox1.Controls.Add(Me.Lb_ra)
        Me.GroupBox1.Controls.Add(Me.Lb_nome)
        Me.GroupBox1.Controls.Add(Me.Lb_senha)
        Me.GroupBox1.Controls.Add(Me.Txt_nome)
        Me.GroupBox1.Controls.Add(Me.Txt_email)
        Me.GroupBox1.Controls.Add(Me.Lb_cpf)
        Me.GroupBox1.Controls.Add(Me.Lb_email)
        Me.GroupBox1.Location = New System.Drawing.Point(111, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(291, 592)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insira os Dados de Aluno"
        '
        'Txt_cpf
        '
        Me.Txt_cpf.Location = New System.Drawing.Point(152, 42)
        Me.Txt_cpf.Mask = "000.000.000-00"
        Me.Txt_cpf.Name = "Txt_cpf"
        Me.Txt_cpf.Size = New System.Drawing.Size(91, 20)
        Me.Txt_cpf.TabIndex = 51
        '
        'Txt_cep
        '
        Me.Txt_cep.Location = New System.Drawing.Point(48, 224)
        Me.Txt_cep.Mask = "00000-999"
        Me.Txt_cep.Name = "Txt_cep"
        Me.Txt_cep.Size = New System.Drawing.Size(128, 20)
        Me.Txt_cep.TabIndex = 50
        '
        'Lb_cidade
        '
        Me.Lb_cidade.AutoSize = True
        Me.Lb_cidade.Location = New System.Drawing.Point(47, 383)
        Me.Lb_cidade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cidade.Name = "Lb_cidade"
        Me.Lb_cidade.Size = New System.Drawing.Size(40, 13)
        Me.Lb_cidade.TabIndex = 49
        Me.Lb_cidade.Text = "Cidade"
        '
        'Txt_cidade
        '
        Me.Txt_cidade.Location = New System.Drawing.Point(48, 401)
        Me.Txt_cidade.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_cidade.Name = "Txt_cidade"
        Me.Txt_cidade.Size = New System.Drawing.Size(128, 20)
        Me.Txt_cidade.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 208)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "CEP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 296)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Complemento"
        '
        'Txt_complemento
        '
        Me.Txt_complemento.Location = New System.Drawing.Point(48, 311)
        Me.Txt_complemento.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_complemento.Name = "Txt_complemento"
        Me.Txt_complemento.Size = New System.Drawing.Size(128, 20)
        Me.Txt_complemento.TabIndex = 45
        '
        'Txt_telefone
        '
        Me.Txt_telefone.Location = New System.Drawing.Point(48, 445)
        Me.Txt_telefone.Mask = "(99) 00000-0000"
        Me.Txt_telefone.Name = "Txt_telefone"
        Me.Txt_telefone.Size = New System.Drawing.Size(128, 20)
        Me.Txt_telefone.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 429)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Telefone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 339)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Bairro"
        '
        'Txt_bairro
        '
        Me.Txt_bairro.Location = New System.Drawing.Point(48, 354)
        Me.Txt_bairro.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_bairro.Name = "Txt_bairro"
        Me.Txt_bairro.Size = New System.Drawing.Size(128, 20)
        Me.Txt_bairro.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 247)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Número"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 247)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Rua"
        '
        'Txt_numero
        '
        Me.Txt_numero.Location = New System.Drawing.Point(195, 262)
        Me.Txt_numero.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_numero.MaxLength = 5
        Me.Txt_numero.Name = "Txt_numero"
        Me.Txt_numero.Size = New System.Drawing.Size(48, 20)
        Me.Txt_numero.TabIndex = 38
        '
        'Txt_rua
        '
        Me.Txt_rua.Location = New System.Drawing.Point(48, 262)
        Me.Txt_rua.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_rua.Name = "Txt_rua"
        Me.Txt_rua.Size = New System.Drawing.Size(128, 20)
        Me.Txt_rua.TabIndex = 37
        '
        'Cmb_uf
        '
        Me.Cmb_uf.FormattingEnabled = True
        Me.Cmb_uf.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.Cmb_uf.Location = New System.Drawing.Point(195, 311)
        Me.Cmb_uf.Name = "Cmb_uf"
        Me.Cmb_uf.Size = New System.Drawing.Size(48, 21)
        Me.Cmb_uf.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 295)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "UF"
        '
        'Cmb_Turma
        '
        Me.Cmb_Turma.FormattingEnabled = True
        Me.Cmb_Turma.Location = New System.Drawing.Point(49, 178)
        Me.Cmb_Turma.Name = "Cmb_Turma"
        Me.Cmb_Turma.Size = New System.Drawing.Size(127, 21)
        Me.Cmb_Turma.TabIndex = 5
        '
        'Cb_mostrar_senha
        '
        Me.Cb_mostrar_senha.AutoSize = True
        Me.Cb_mostrar_senha.Location = New System.Drawing.Point(172, 495)
        Me.Cb_mostrar_senha.Name = "Cb_mostrar_senha"
        Me.Cb_mostrar_senha.Size = New System.Drawing.Size(95, 17)
        Me.Cb_mostrar_senha.TabIndex = 3
        Me.Cb_mostrar_senha.Text = "Mostrar Senha"
        Me.Cb_mostrar_senha.UseVisualStyleBackColor = True
        '
        'Btn_limpar_campos
        '
        Me.Btn_limpar_campos.Location = New System.Drawing.Point(417, 549)
        Me.Btn_limpar_campos.Name = "Btn_limpar_campos"
        Me.Btn_limpar_campos.Size = New System.Drawing.Size(91, 27)
        Me.Btn_limpar_campos.TabIndex = 4
        Me.Btn_limpar_campos.Text = "Limpar Campos"
        Me.Btn_limpar_campos.UseVisualStyleBackColor = True
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
        Me.GroupBox2.Location = New System.Drawing.Point(448, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(186, 205)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Insira a foto de Aluno"
        '
        'Btn_voltar
        '
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_voltar.Location = New System.Drawing.Point(543, 549)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 19
        Me.Btn_voltar.Text = "Voltar"
        Me.Btn_voltar.UseVisualStyleBackColor = True
        '
        'Frm_cadastroAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 611)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_limpar_campos)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_cadastroAluno"
        Me.Text = "Cadastro de Alunos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
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
    Friend WithEvents Btn_cadastrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cb_mostrar_senha As CheckBox
    Friend WithEvents Btn_limpar_campos As Button
    Friend WithEvents Cmb_Turma As ComboBox
    Friend WithEvents Cmb_uf As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_cep As MaskedTextBox
    Friend WithEvents Lb_cidade As Label
    Friend WithEvents Txt_cidade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_complemento As TextBox
    Friend WithEvents Txt_telefone As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_bairro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_numero As TextBox
    Friend WithEvents Txt_rua As TextBox
    Friend WithEvents Txt_cpf As MaskedTextBox
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_voltar As Button
End Class
