<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_loginProfessor
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
        Me.Lb_email = New System.Windows.Forms.Label()
        Me.Lb_senha = New System.Windows.Forms.Label()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.Cb_mostrarSenha = New System.Windows.Forms.CheckBox()
        Me.Btn_logar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Location = New System.Drawing.Point(80, 103)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(57, 20)
        Me.Lb_email.TabIndex = 0
        Me.Lb_email.Text = "E-mail:"
        '
        'Lb_senha
        '
        Me.Lb_senha.AutoSize = True
        Me.Lb_senha.Location = New System.Drawing.Point(77, 148)
        Me.Lb_senha.Name = "Lb_senha"
        Me.Lb_senha.Size = New System.Drawing.Size(60, 20)
        Me.Lb_senha.TabIndex = 0
        Me.Lb_senha.Text = "Senha:"
        '
        'Txt_email
        '
        Me.Txt_email.Location = New System.Drawing.Point(143, 100)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(133, 26)
        Me.Txt_email.TabIndex = 0
        '
        'Txt_senha
        '
        Me.Txt_senha.Location = New System.Drawing.Point(143, 145)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.Size = New System.Drawing.Size(133, 26)
        Me.Txt_senha.TabIndex = 1
        Me.Txt_senha.UseSystemPasswordChar = True
        '
        'Cb_mostrarSenha
        '
        Me.Cb_mostrarSenha.AutoSize = True
        Me.Cb_mostrarSenha.Location = New System.Drawing.Point(88, 195)
        Me.Cb_mostrarSenha.Name = "Cb_mostrarSenha"
        Me.Cb_mostrarSenha.Size = New System.Drawing.Size(140, 24)
        Me.Cb_mostrarSenha.TabIndex = 2
        Me.Cb_mostrarSenha.Text = "Mostrar Senha"
        Me.Cb_mostrarSenha.UseVisualStyleBackColor = True
        '
        'Btn_logar
        '
        Me.Btn_logar.Location = New System.Drawing.Point(305, 319)
        Me.Btn_logar.Name = "Btn_logar"
        Me.Btn_logar.Size = New System.Drawing.Size(197, 58)
        Me.Btn_logar.TabIndex = 3
        Me.Btn_logar.Text = "Logar"
        Me.Btn_logar.UseVisualStyleBackColor = True
        '
        'Frm_loginProfessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_logar)
        Me.Controls.Add(Me.Cb_mostrarSenha)
        Me.Controls.Add(Me.Txt_senha)
        Me.Controls.Add(Me.Txt_email)
        Me.Controls.Add(Me.Lb_senha)
        Me.Controls.Add(Me.Lb_email)
        Me.Name = "Frm_loginProfessor"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_email As Label
    Friend WithEvents Lb_senha As Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Cb_mostrarSenha As CheckBox
    Friend WithEvents Btn_logar As Button
End Class
