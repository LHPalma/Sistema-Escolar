<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_loginProfessor
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
        Me.Lb_email = New System.Windows.Forms.Label()
        Me.Lb_senha = New System.Windows.Forms.Label()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.Cb_mostrarSenha = New System.Windows.Forms.CheckBox()
        Me.Btn_logar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Location = New System.Drawing.Point(26, 32)
        Me.Lb_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(38, 13)
        Me.Lb_email.TabIndex = 0
        Me.Lb_email.Text = "E-mail:"
        '
        'Lb_senha
        '
        Me.Lb_senha.AutoSize = True
        Me.Lb_senha.Location = New System.Drawing.Point(24, 81)
        Me.Lb_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_senha.Name = "Lb_senha"
        Me.Lb_senha.Size = New System.Drawing.Size(41, 13)
        Me.Lb_senha.TabIndex = 0
        Me.Lb_senha.Text = "Senha:"
        '
        'Txt_email
        '
        Me.Txt_email.Location = New System.Drawing.Point(25, 48)
        Me.Txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(200, 20)
        Me.Txt_email.TabIndex = 0
        '
        'Txt_senha
        '
        Me.Txt_senha.Location = New System.Drawing.Point(25, 96)
        Me.Txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.Size = New System.Drawing.Size(200, 20)
        Me.Txt_senha.TabIndex = 1
        Me.Txt_senha.UseSystemPasswordChar = True
        '
        'Cb_mostrarSenha
        '
        Me.Cb_mostrarSenha.AutoSize = True
        Me.Cb_mostrarSenha.Location = New System.Drawing.Point(71, 120)
        Me.Cb_mostrarSenha.Margin = New System.Windows.Forms.Padding(2)
        Me.Cb_mostrarSenha.Name = "Cb_mostrarSenha"
        Me.Cb_mostrarSenha.Size = New System.Drawing.Size(95, 17)
        Me.Cb_mostrarSenha.TabIndex = 2
        Me.Cb_mostrarSenha.Text = "Mostrar Senha"
        Me.Cb_mostrarSenha.UseVisualStyleBackColor = True
        '
        'Btn_logar
        '
        Me.Btn_logar.Location = New System.Drawing.Point(25, 144)
        Me.Btn_logar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_logar.Name = "Btn_logar"
        Me.Btn_logar.Size = New System.Drawing.Size(199, 38)
        Me.Btn_logar.TabIndex = 3
        Me.Btn_logar.Text = "Logar"
        Me.Btn_logar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_logar)
        Me.GroupBox1.Controls.Add(Me.Cb_mostrarSenha)
        Me.GroupBox1.Controls.Add(Me.Txt_email)
        Me.GroupBox1.Controls.Add(Me.Txt_senha)
        Me.GroupBox1.Controls.Add(Me.Lb_email)
        Me.GroupBox1.Controls.Add(Me.Lb_senha)
        Me.GroupBox1.Location = New System.Drawing.Point(134, 3)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(251, 190)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insira os dados da conta"
        '
        'Frm_loginProfessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 194)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_loginProfessor"
        Me.Text = "Login de Professor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lb_email As Label
    Friend WithEvents Lb_senha As Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Cb_mostrarSenha As CheckBox
    Friend WithEvents Btn_logar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
