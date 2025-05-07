<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_loginADM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_loginADM))
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Cb_mostrarSenha = New System.Windows.Forms.CheckBox()
        Me.Lb_senha = New System.Windows.Forms.Label()
        Me.Lb_email = New System.Windows.Forms.Label()
        Me.Btn_logar = New System.Windows.Forms.Button()
        Me.loginADM = New System.Windows.Forms.GroupBox()
        Me.Btn_voltar = New System.Windows.Forms.Button()
        Me.loginADM.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_senha
        '
        Me.Txt_senha.Location = New System.Drawing.Point(29, 85)
        Me.Txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.Size = New System.Drawing.Size(191, 20)
        Me.Txt_senha.TabIndex = 8
        Me.Txt_senha.UseSystemPasswordChar = True
        '
        'Txt_email
        '
        Me.Txt_email.Location = New System.Drawing.Point(29, 41)
        Me.Txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(191, 20)
        Me.Txt_email.TabIndex = 9
        '
        'Cb_mostrarSenha
        '
        Me.Cb_mostrarSenha.AutoSize = True
        Me.Cb_mostrarSenha.Location = New System.Drawing.Point(81, 120)
        Me.Cb_mostrarSenha.Margin = New System.Windows.Forms.Padding(2)
        Me.Cb_mostrarSenha.Name = "Cb_mostrarSenha"
        Me.Cb_mostrarSenha.Size = New System.Drawing.Size(95, 17)
        Me.Cb_mostrarSenha.TabIndex = 7
        Me.Cb_mostrarSenha.Text = "Mostrar Senha"
        Me.Cb_mostrarSenha.UseVisualStyleBackColor = True
        '
        'Lb_senha
        '
        Me.Lb_senha.AutoSize = True
        Me.Lb_senha.Location = New System.Drawing.Point(27, 70)
        Me.Lb_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_senha.Name = "Lb_senha"
        Me.Lb_senha.Size = New System.Drawing.Size(38, 13)
        Me.Lb_senha.TabIndex = 5
        Me.Lb_senha.Text = "Senha"
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Location = New System.Drawing.Point(27, 26)
        Me.Lb_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(35, 13)
        Me.Lb_email.TabIndex = 7
        Me.Lb_email.Text = "E-mail"
        '
        'Btn_logar
        '
        Me.Btn_logar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Btn_logar.Location = New System.Drawing.Point(29, 140)
        Me.Btn_logar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_logar.Name = "Btn_logar"
        Me.Btn_logar.Size = New System.Drawing.Size(199, 38)
        Me.Btn_logar.TabIndex = 4
        Me.Btn_logar.Text = "Logar"
        Me.Btn_logar.UseVisualStyleBackColor = False
        '
        'loginADM
        '
        Me.loginADM.Controls.Add(Me.Txt_senha)
        Me.loginADM.Controls.Add(Me.Btn_logar)
        Me.loginADM.Controls.Add(Me.Txt_email)
        Me.loginADM.Controls.Add(Me.Lb_email)
        Me.loginADM.Controls.Add(Me.Cb_mostrarSenha)
        Me.loginADM.Controls.Add(Me.Lb_senha)
        Me.loginADM.Location = New System.Drawing.Point(131, 8)
        Me.loginADM.Margin = New System.Windows.Forms.Padding(2)
        Me.loginADM.Name = "loginADM"
        Me.loginADM.Padding = New System.Windows.Forms.Padding(2)
        Me.loginADM.Size = New System.Drawing.Size(251, 231)
        Me.loginADM.TabIndex = 10
        Me.loginADM.TabStop = False
        Me.loginADM.Text = "Insira os dados da conta"
        '
        'Btn_voltar
        '
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_voltar.Location = New System.Drawing.Point(399, 155)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 21
        Me.Btn_voltar.Text = "Voltar"
        Me.Btn_voltar.UseVisualStyleBackColor = True
        '
        'Frm_loginADM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 194)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.loginADM)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_loginADM"
        Me.Text = "Login de Administrador"
        Me.loginADM.ResumeLayout(False)
        Me.loginADM.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Cb_mostrarSenha As CheckBox
    Friend WithEvents Lb_senha As Label
    Friend WithEvents Lb_email As Label
    Friend WithEvents Btn_logar As Button
    Friend WithEvents loginADM As GroupBox
    Friend WithEvents Btn_voltar As Button
End Class
