<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadastroProfessor
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_cidade = New System.Windows.Forms.TextBox()
        Me.Cb_tipo_teleone = New System.Windows.Forms.ComboBox()
        Me.Cmb_uf = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_cep = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_complemento = New System.Windows.Forms.TextBox()
        Me.Txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_bairro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_numero = New System.Windows.Forms.TextBox()
        Me.Txt_rua = New System.Windows.Forms.TextBox()
        Me.Btn_cadastrar = New System.Windows.Forms.Button()
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.Lb_senha = New System.Windows.Forms.Label()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Lb_email = New System.Windows.Forms.Label()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Lb_nome = New System.Windows.Forms.Label()
        Me.Btn_cadastrarAluno = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Txt_cidade)
        Me.GroupBox1.Controls.Add(Me.Cb_tipo_teleone)
        Me.GroupBox1.Controls.Add(Me.Cmb_uf)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Txt_cep)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txt_complemento)
        Me.GroupBox1.Controls.Add(Me.Txt_telefone)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_bairro)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_numero)
        Me.GroupBox1.Controls.Add(Me.Txt_rua)
        Me.GroupBox1.Controls.Add(Me.Btn_cadastrar)
        Me.GroupBox1.Controls.Add(Me.Txt_senha)
        Me.GroupBox1.Controls.Add(Me.Lb_senha)
        Me.GroupBox1.Controls.Add(Me.Txt_email)
        Me.GroupBox1.Controls.Add(Me.Lb_email)
        Me.GroupBox1.Controls.Add(Me.Txt_nome)
        Me.GroupBox1.Controls.Add(Me.Lb_nome)
        Me.GroupBox1.Location = New System.Drawing.Point(124, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(274, 438)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insira os Dados de Professor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(180, 296)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Tipo de Telefone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(185, 222)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Cidade"
        '
        'Txt_cidade
        '
        Me.Txt_cidade.Location = New System.Drawing.Point(186, 240)
        Me.Txt_cidade.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_cidade.Name = "Txt_cidade"
        Me.Txt_cidade.Size = New System.Drawing.Size(75, 20)
        Me.Txt_cidade.TabIndex = 33
        '
        'Cb_tipo_teleone
        '
        Me.Cb_tipo_teleone.FormattingEnabled = True
        Me.Cb_tipo_teleone.Items.AddRange(New Object() {"cel", "res", "com"})
        Me.Cb_tipo_teleone.Location = New System.Drawing.Point(184, 312)
        Me.Cb_tipo_teleone.Name = "Cb_tipo_teleone"
        Me.Cb_tipo_teleone.Size = New System.Drawing.Size(48, 21)
        Me.Cb_tipo_teleone.TabIndex = 32
        '
        'Cmb_uf
        '
        Me.Cmb_uf.FormattingEnabled = True
        Me.Cmb_uf.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.Cmb_uf.Location = New System.Drawing.Point(186, 175)
        Me.Cmb_uf.Name = "Cmb_uf"
        Me.Cmb_uf.Size = New System.Drawing.Size(48, 21)
        Me.Cmb_uf.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 250)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "CEP"
        '
        'Txt_cep
        '
        Me.Txt_cep.Location = New System.Drawing.Point(59, 265)
        Me.Txt_cep.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_cep.MaxLength = 8
        Me.Txt_cep.Name = "Txt_cep"
        Me.Txt_cep.Size = New System.Drawing.Size(116, 20)
        Me.Txt_cep.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 159)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Complemento"
        '
        'Txt_complemento
        '
        Me.Txt_complemento.Location = New System.Drawing.Point(59, 174)
        Me.Txt_complemento.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_complemento.Name = "Txt_complemento"
        Me.Txt_complemento.Size = New System.Drawing.Size(116, 20)
        Me.Txt_complemento.TabIndex = 27
        '
        'Txt_telefone
        '
        Me.Txt_telefone.Location = New System.Drawing.Point(59, 312)
        Me.Txt_telefone.Mask = "(99) 00000-0000"
        Me.Txt_telefone.Name = "Txt_telefone"
        Me.Txt_telefone.Size = New System.Drawing.Size(116, 20)
        Me.Txt_telefone.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 296)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Telefone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 202)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Bairro"
        '
        'Txt_bairro
        '
        Me.Txt_bairro.Location = New System.Drawing.Point(59, 217)
        Me.Txt_bairro.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_bairro.Name = "Txt_bairro"
        Me.Txt_bairro.Size = New System.Drawing.Size(116, 20)
        Me.Txt_bairro.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 159)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "UF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Número"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Rua"
        '
        'Txt_numero
        '
        Me.Txt_numero.Location = New System.Drawing.Point(186, 133)
        Me.Txt_numero.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_numero.Name = "Txt_numero"
        Me.Txt_numero.Size = New System.Drawing.Size(48, 20)
        Me.Txt_numero.TabIndex = 17
        '
        'Txt_rua
        '
        Me.Txt_rua.Location = New System.Drawing.Point(59, 133)
        Me.Txt_rua.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_rua.Name = "Txt_rua"
        Me.Txt_rua.Size = New System.Drawing.Size(116, 20)
        Me.Txt_rua.TabIndex = 16
        '
        'Btn_cadastrar
        '
        Me.Btn_cadastrar.Location = New System.Drawing.Point(49, 392)
        Me.Btn_cadastrar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_cadastrar.Name = "Btn_cadastrar"
        Me.Btn_cadastrar.Size = New System.Drawing.Size(185, 38)
        Me.Btn_cadastrar.TabIndex = 15
        Me.Btn_cadastrar.Text = "CADASTRAR"
        Me.Btn_cadastrar.UseVisualStyleBackColor = True
        '
        'Txt_senha
        '
        Me.Txt_senha.Location = New System.Drawing.Point(59, 355)
        Me.Txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.Size = New System.Drawing.Size(116, 20)
        Me.Txt_senha.TabIndex = 12
        Me.Txt_senha.UseSystemPasswordChar = True
        '
        'Lb_senha
        '
        Me.Lb_senha.AutoSize = True
        Me.Lb_senha.Location = New System.Drawing.Point(58, 340)
        Me.Lb_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_senha.Name = "Lb_senha"
        Me.Lb_senha.Size = New System.Drawing.Size(38, 13)
        Me.Lb_senha.TabIndex = 9
        Me.Lb_senha.Text = "Senha"
        '
        'Txt_email
        '
        Me.Txt_email.Location = New System.Drawing.Point(59, 89)
        Me.Txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(175, 20)
        Me.Txt_email.TabIndex = 13
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Location = New System.Drawing.Point(58, 74)
        Me.Lb_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(32, 13)
        Me.Lb_email.TabIndex = 10
        Me.Lb_email.Text = "Email"
        '
        'Txt_nome
        '
        Me.Txt_nome.Location = New System.Drawing.Point(59, 43)
        Me.Txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(175, 20)
        Me.Txt_nome.TabIndex = 14
        '
        'Lb_nome
        '
        Me.Lb_nome.AutoSize = True
        Me.Lb_nome.Location = New System.Drawing.Point(57, 28)
        Me.Lb_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_nome.Name = "Lb_nome"
        Me.Lb_nome.Size = New System.Drawing.Size(35, 13)
        Me.Lb_nome.TabIndex = 11
        Me.Lb_nome.Text = "Nome"
        '
        'Btn_cadastrarAluno
        '
        Me.Btn_cadastrarAluno.Location = New System.Drawing.Point(430, 50)
        Me.Btn_cadastrarAluno.Name = "Btn_cadastrarAluno"
        Me.Btn_cadastrarAluno.Size = New System.Drawing.Size(78, 37)
        Me.Btn_cadastrarAluno.TabIndex = 1
        Me.Btn_cadastrarAluno.Text = "Ir para cadastro de Alunos"
        Me.Btn_cadastrarAluno.UseVisualStyleBackColor = True
        '
        'CadastroProfessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 495)
        Me.Controls.Add(Me.Btn_cadastrarAluno)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CadastroProfessor"
        Me.Text = "Cadastro de Professor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_cadastrar As Button
    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Lb_senha As Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Lb_email As Label
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Lb_nome As Label
    Friend WithEvents Txt_numero As TextBox
    Friend WithEvents Txt_rua As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_bairro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_telefone As MaskedTextBox
    Friend WithEvents Txt_complemento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_cep As TextBox
    Friend WithEvents Cmb_uf As ComboBox
    Friend WithEvents Cb_tipo_teleone As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_cidade As TextBox
    Friend WithEvents Btn_cadastrarAluno As Button
End Class
