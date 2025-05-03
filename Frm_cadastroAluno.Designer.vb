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
        Me.Lb_ra = New System.Windows.Forms.Label()
        Me.Txt_ra = New System.Windows.Forms.TextBox()
        Me.Lb_nome = New System.Windows.Forms.Label()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Lb_cpf = New System.Windows.Forms.Label()
        Me.Txt_cpf = New System.Windows.Forms.TextBox()
        Me.Lb_email = New System.Windows.Forms.Label()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Lb_senha = New System.Windows.Forms.Label()
        Me.Txt_turma = New System.Windows.Forms.TextBox()
        Me.Lb_turma = New System.Windows.Forms.Label()
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.Btn_cadastrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_limpar_campos = New System.Windows.Forms.Button()
        Me.Cb_mostrar_senha = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
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
        Me.Txt_nome.Size = New System.Drawing.Size(183, 20)
        Me.Txt_nome.TabIndex = 1
        '
        'Lb_cpf
        '
        Me.Lb_cpf.AutoSize = True
        Me.Lb_cpf.Location = New System.Drawing.Point(49, 157)
        Me.Lb_cpf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cpf.Name = "Lb_cpf"
        Me.Lb_cpf.Size = New System.Drawing.Size(27, 13)
        Me.Lb_cpf.TabIndex = 0
        Me.Lb_cpf.Text = "CPF"
        '
        'Txt_cpf
        '
        Me.Txt_cpf.Location = New System.Drawing.Point(49, 172)
        Me.Txt_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_cpf.MaxLength = 11
        Me.Txt_cpf.Name = "Txt_cpf"
        Me.Txt_cpf.Size = New System.Drawing.Size(94, 20)
        Me.Txt_cpf.TabIndex = 1
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Location = New System.Drawing.Point(46, 204)
        Me.Lb_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(32, 13)
        Me.Lb_email.TabIndex = 0
        Me.Lb_email.Text = "Email"
        '
        'Txt_email
        '
        Me.Txt_email.Location = New System.Drawing.Point(48, 219)
        Me.Txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(183, 20)
        Me.Txt_email.TabIndex = 1
        '
        'Lb_senha
        '
        Me.Lb_senha.AutoSize = True
        Me.Lb_senha.Location = New System.Drawing.Point(46, 246)
        Me.Lb_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_senha.Name = "Lb_senha"
        Me.Lb_senha.Size = New System.Drawing.Size(38, 13)
        Me.Lb_senha.TabIndex = 0
        Me.Lb_senha.Text = "Senha"
        '
        'Txt_turma
        '
        Me.Txt_turma.Location = New System.Drawing.Point(48, 128)
        Me.Txt_turma.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_turma.Name = "Txt_turma"
        Me.Txt_turma.Size = New System.Drawing.Size(94, 20)
        Me.Txt_turma.TabIndex = 1
        '
        'Lb_turma
        '
        Me.Lb_turma.AutoSize = True
        Me.Lb_turma.Location = New System.Drawing.Point(45, 113)
        Me.Lb_turma.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_turma.Name = "Lb_turma"
        Me.Lb_turma.Size = New System.Drawing.Size(37, 13)
        Me.Lb_turma.TabIndex = 0
        Me.Lb_turma.Text = "Turma"
        '
        'Txt_senha
        '
        Me.Txt_senha.Location = New System.Drawing.Point(49, 261)
        Me.Txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.Size = New System.Drawing.Size(94, 20)
        Me.Txt_senha.TabIndex = 1
        Me.Txt_senha.UseSystemPasswordChar = True
        '
        'Btn_cadastrar
        '
        Me.Btn_cadastrar.Location = New System.Drawing.Point(40, 302)
        Me.Btn_cadastrar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_cadastrar.Name = "Btn_cadastrar"
        Me.Btn_cadastrar.Size = New System.Drawing.Size(219, 43)
        Me.Btn_cadastrar.TabIndex = 2
        Me.Btn_cadastrar.Text = "CADASTRAR"
        Me.Btn_cadastrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_limpar_campos)
        Me.GroupBox1.Controls.Add(Me.Cb_mostrar_senha)
        Me.GroupBox1.Controls.Add(Me.Btn_cadastrar)
        Me.GroupBox1.Controls.Add(Me.Txt_senha)
        Me.GroupBox1.Controls.Add(Me.Txt_ra)
        Me.GroupBox1.Controls.Add(Me.Lb_turma)
        Me.GroupBox1.Controls.Add(Me.Lb_ra)
        Me.GroupBox1.Controls.Add(Me.Txt_turma)
        Me.GroupBox1.Controls.Add(Me.Lb_nome)
        Me.GroupBox1.Controls.Add(Me.Lb_senha)
        Me.GroupBox1.Controls.Add(Me.Txt_nome)
        Me.GroupBox1.Controls.Add(Me.Txt_email)
        Me.GroupBox1.Controls.Add(Me.Lb_cpf)
        Me.GroupBox1.Controls.Add(Me.Lb_email)
        Me.GroupBox1.Controls.Add(Me.Txt_cpf)
        Me.GroupBox1.Location = New System.Drawing.Point(111, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(291, 363)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insira os Dados de Aluno"
        '
        'Btn_limpar_campos
        '
        Me.Btn_limpar_campos.Location = New System.Drawing.Point(180, 150)
        Me.Btn_limpar_campos.Name = "Btn_limpar_campos"
        Me.Btn_limpar_campos.Size = New System.Drawing.Size(91, 27)
        Me.Btn_limpar_campos.TabIndex = 4
        Me.Btn_limpar_campos.Text = "Limpar Campos"
        Me.Btn_limpar_campos.UseVisualStyleBackColor = True
        '
        'Cb_mostrar_senha
        '
        Me.Cb_mostrar_senha.AutoSize = True
        Me.Cb_mostrar_senha.Location = New System.Drawing.Point(150, 264)
        Me.Cb_mostrar_senha.Name = "Cb_mostrar_senha"
        Me.Cb_mostrar_senha.Size = New System.Drawing.Size(95, 17)
        Me.Cb_mostrar_senha.TabIndex = 3
        Me.Cb_mostrar_senha.Text = "Mostrar Senha"
        Me.Cb_mostrar_senha.UseVisualStyleBackColor = True
        '
        'Frm_cadastroAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 368)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_cadastroAluno"
        Me.Text = "Cadastro de Alunos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lb_ra As Label
    Friend WithEvents Txt_ra As TextBox
    Friend WithEvents Lb_nome As Label
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Lb_cpf As Label
    Friend WithEvents Txt_cpf As TextBox
    Friend WithEvents Lb_email As Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Lb_senha As Label
    Friend WithEvents Txt_turma As TextBox
    Friend WithEvents Lb_turma As Label
    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Btn_cadastrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cb_mostrar_senha As CheckBox
    Friend WithEvents Btn_limpar_campos As Button
End Class
