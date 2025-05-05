<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_loginAluno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_loginAluno))
        Me.Btn_logar = New System.Windows.Forms.Button()
        Me.Lb_ra = New System.Windows.Forms.Label()
        Me.Lb_senha = New System.Windows.Forms.Label()
        Me.Cb_mostrarSenha = New System.Windows.Forms.CheckBox()
        Me.Txt_ra = New System.Windows.Forms.TextBox()
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Btn_voltar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_logar
        '
        Me.Btn_logar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Btn_logar.Location = New System.Drawing.Point(23, 144)
        Me.Btn_logar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_logar.Name = "Btn_logar"
        Me.Btn_logar.Size = New System.Drawing.Size(199, 38)
        Me.Btn_logar.TabIndex = 0
        Me.Btn_logar.Text = "Logar"
        Me.Btn_logar.UseVisualStyleBackColor = False
        '
        'Lb_ra
        '
        Me.Lb_ra.AutoSize = True
        Me.Lb_ra.Location = New System.Drawing.Point(29, 23)
        Me.Lb_ra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_ra.Name = "Lb_ra"
        Me.Lb_ra.Size = New System.Drawing.Size(25, 13)
        Me.Lb_ra.TabIndex = 1
        Me.Lb_ra.Text = "RA:"
        '
        'Lb_senha
        '
        Me.Lb_senha.AutoSize = True
        Me.Lb_senha.Location = New System.Drawing.Point(29, 71)
        Me.Lb_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_senha.Name = "Lb_senha"
        Me.Lb_senha.Size = New System.Drawing.Size(41, 13)
        Me.Lb_senha.TabIndex = 1
        Me.Lb_senha.Text = "Senha:"
        '
        'Cb_mostrarSenha
        '
        Me.Cb_mostrarSenha.AutoSize = True
        Me.Cb_mostrarSenha.Location = New System.Drawing.Point(71, 119)
        Me.Cb_mostrarSenha.Margin = New System.Windows.Forms.Padding(2)
        Me.Cb_mostrarSenha.Name = "Cb_mostrarSenha"
        Me.Cb_mostrarSenha.Size = New System.Drawing.Size(95, 17)
        Me.Cb_mostrarSenha.TabIndex = 2
        Me.Cb_mostrarSenha.Text = "Mostrar Senha"
        Me.Cb_mostrarSenha.UseVisualStyleBackColor = True
        '
        'Txt_ra
        '
        Me.Txt_ra.Location = New System.Drawing.Point(32, 38)
        Me.Txt_ra.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_ra.Name = "Txt_ra"
        Me.Txt_ra.Size = New System.Drawing.Size(170, 20)
        Me.Txt_ra.TabIndex = 3
        '
        'Txt_senha
        '
        Me.Txt_senha.Location = New System.Drawing.Point(32, 86)
        Me.Txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.Size = New System.Drawing.Size(170, 20)
        Me.Txt_senha.TabIndex = 3
        Me.Txt_senha.UseSystemPasswordChar = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_ra)
        Me.GroupBox1.Controls.Add(Me.Txt_senha)
        Me.GroupBox1.Controls.Add(Me.Btn_logar)
        Me.GroupBox1.Controls.Add(Me.Lb_ra)
        Me.GroupBox1.Controls.Add(Me.Cb_mostrarSenha)
        Me.GroupBox1.Controls.Add(Me.Lb_senha)
        Me.GroupBox1.Location = New System.Drawing.Point(137, 3)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(251, 231)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insira os dados da conta"
        '
        'Btn_voltar
        '
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_voltar.Location = New System.Drawing.Point(399, 153)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 20
        Me.Btn_voltar.Text = "Voltar"
        Me.Btn_voltar.UseVisualStyleBackColor = True
        '
        'Frm_loginAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 194)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_loginAluno"
        Me.Text = "Login de Aluno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_logar As Button
    Friend WithEvents Lb_ra As Label
    Friend WithEvents Lb_senha As Label
    Friend WithEvents Cb_mostrarSenha As CheckBox
    Friend WithEvents Txt_ra As TextBox
    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Btn_voltar As Button
End Class
