﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cadastroADM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cadastroADM))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.Lb_senha = New System.Windows.Forms.Label()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Lb_email = New System.Windows.Forms.Label()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Lb_nome = New System.Windows.Forms.Label()
        Me.Btn_voltar = New System.Windows.Forms.Button()
        Me.Btn_limpar_campos = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cadastrar)
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
        Me.GroupBox1.Size = New System.Drawing.Size(274, 260)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insira os Dados de Administrador"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Location = New System.Drawing.Point(53, 194)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(185, 38)
        Me.btn_cadastrar.TabIndex = 15
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'Txt_senha
        '
        Me.Txt_senha.Location = New System.Drawing.Point(59, 155)
        Me.Txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.Size = New System.Drawing.Size(94, 20)
        Me.Txt_senha.TabIndex = 12
        '
        'Lb_senha
        '
        Me.Lb_senha.AutoSize = True
        Me.Lb_senha.Location = New System.Drawing.Point(56, 140)
        Me.Lb_senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_senha.Name = "Lb_senha"
        Me.Lb_senha.Size = New System.Drawing.Size(38, 13)
        Me.Lb_senha.TabIndex = 9
        Me.Lb_senha.Text = "Senha"
        '
        'Txt_email
        '
        Me.Txt_email.Location = New System.Drawing.Point(59, 106)
        Me.Txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(159, 20)
        Me.Txt_email.TabIndex = 13
        '
        'Lb_email
        '
        Me.Lb_email.AutoSize = True
        Me.Lb_email.Location = New System.Drawing.Point(58, 91)
        Me.Lb_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_email.Name = "Lb_email"
        Me.Lb_email.Size = New System.Drawing.Size(32, 13)
        Me.Lb_email.TabIndex = 10
        Me.Lb_email.Text = "Email"
        '
        'Txt_nome
        '
        Me.Txt_nome.Location = New System.Drawing.Point(59, 60)
        Me.Txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(159, 20)
        Me.Txt_nome.TabIndex = 14
        '
        'Lb_nome
        '
        Me.Lb_nome.AutoSize = True
        Me.Lb_nome.Location = New System.Drawing.Point(57, 45)
        Me.Lb_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_nome.Name = "Lb_nome"
        Me.Lb_nome.Size = New System.Drawing.Size(35, 13)
        Me.Lb_nome.TabIndex = 11
        Me.Lb_nome.Text = "Nome"
        '
        'Btn_voltar
        '
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_voltar.Location = New System.Drawing.Point(282, 282)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 26
        Me.Btn_voltar.Text = "Voltar"
        Me.Btn_voltar.UseVisualStyleBackColor = True
        '
        'Btn_limpar_campos
        '
        Me.Btn_limpar_campos.Location = New System.Drawing.Point(155, 282)
        Me.Btn_limpar_campos.Name = "Btn_limpar_campos"
        Me.Btn_limpar_campos.Size = New System.Drawing.Size(91, 27)
        Me.Btn_limpar_campos.TabIndex = 25
        Me.Btn_limpar_campos.Text = "Limpar Campos"
        Me.Btn_limpar_campos.UseVisualStyleBackColor = True
        '
        'Frm_cadastroADM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 329)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Btn_limpar_campos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_cadastroADM"
        Me.Text = "Cadastro de Administrador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Lb_senha As Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Lb_email As Label
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Lb_nome As Label
    Friend WithEvents Btn_voltar As Button
    Friend WithEvents Btn_limpar_campos As Button
End Class
