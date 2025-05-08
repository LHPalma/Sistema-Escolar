<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GerenciamentoDisciplinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_GerenciamentoDisciplinas))
        Me.Btn_voltar = New System.Windows.Forms.Button()
        Me.Btn_limpar_campos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_cadastrar = New System.Windows.Forms.Button()
        Me.Lb_nome_turma = New System.Windows.Forms.Label()
        Me.Lb_disciplina = New System.Windows.Forms.Label()
        Me.Lb_nome = New System.Windows.Forms.Label()
        Me.Cmb_nome_professor = New System.Windows.Forms.ComboBox()
        Me.Cmb_nome_disciplina = New System.Windows.Forms.ComboBox()
        Me.Cmb_nome_turma = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_voltar
        '
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_voltar.Location = New System.Drawing.Point(285, 285)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 34
        Me.Btn_voltar.Text = "Voltar"
        Me.Btn_voltar.UseVisualStyleBackColor = True
        '
        'Btn_limpar_campos
        '
        Me.Btn_limpar_campos.Location = New System.Drawing.Point(158, 285)
        Me.Btn_limpar_campos.Name = "Btn_limpar_campos"
        Me.Btn_limpar_campos.Size = New System.Drawing.Size(91, 27)
        Me.Btn_limpar_campos.TabIndex = 33
        Me.Btn_limpar_campos.Text = "Limpar Campos"
        Me.Btn_limpar_campos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmb_nome_turma)
        Me.GroupBox1.Controls.Add(Me.Cmb_nome_disciplina)
        Me.GroupBox1.Controls.Add(Me.Cmb_nome_professor)
        Me.GroupBox1.Controls.Add(Me.Btn_cadastrar)
        Me.GroupBox1.Controls.Add(Me.Lb_nome_turma)
        Me.GroupBox1.Controls.Add(Me.Lb_disciplina)
        Me.GroupBox1.Controls.Add(Me.Lb_nome)
        Me.GroupBox1.Location = New System.Drawing.Point(129, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(274, 260)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insira os Dados de Disciplina"
        '
        'Btn_cadastrar
        '
        Me.Btn_cadastrar.Location = New System.Drawing.Point(46, 195)
        Me.Btn_cadastrar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_cadastrar.Name = "Btn_cadastrar"
        Me.Btn_cadastrar.Size = New System.Drawing.Size(185, 38)
        Me.Btn_cadastrar.TabIndex = 4
        Me.Btn_cadastrar.Text = "CADASTRAR"
        Me.Btn_cadastrar.UseVisualStyleBackColor = True
        '
        'Lb_nome_turma
        '
        Me.Lb_nome_turma.AutoSize = True
        Me.Lb_nome_turma.Location = New System.Drawing.Point(55, 130)
        Me.Lb_nome_turma.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_nome_turma.Name = "Lb_nome_turma"
        Me.Lb_nome_turma.Size = New System.Drawing.Size(83, 13)
        Me.Lb_nome_turma.TabIndex = 9
        Me.Lb_nome_turma.Text = "Nome da Turma"
        '
        'Lb_disciplina
        '
        Me.Lb_disciplina.AutoSize = True
        Me.Lb_disciplina.Location = New System.Drawing.Point(55, 83)
        Me.Lb_disciplina.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_disciplina.Name = "Lb_disciplina"
        Me.Lb_disciplina.Size = New System.Drawing.Size(98, 13)
        Me.Lb_disciplina.TabIndex = 10
        Me.Lb_disciplina.Text = "Nome da Disciplina"
        '
        'Lb_nome
        '
        Me.Lb_nome.AutoSize = True
        Me.Lb_nome.Location = New System.Drawing.Point(55, 37)
        Me.Lb_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_nome.Name = "Lb_nome"
        Me.Lb_nome.Size = New System.Drawing.Size(97, 13)
        Me.Lb_nome.TabIndex = 11
        Me.Lb_nome.Text = "Nome do Professor"
        '
        'Cmb_nome_professor
        '
        Me.Cmb_nome_professor.FormattingEnabled = True
        Me.Cmb_nome_professor.Location = New System.Drawing.Point(56, 53)
        Me.Cmb_nome_professor.Name = "Cmb_nome_professor"
        Me.Cmb_nome_professor.Size = New System.Drawing.Size(157, 21)
        Me.Cmb_nome_professor.TabIndex = 13
        '
        'Cmb_nome_disciplina
        '
        Me.Cmb_nome_disciplina.FormattingEnabled = True
        Me.Cmb_nome_disciplina.Location = New System.Drawing.Point(56, 99)
        Me.Cmb_nome_disciplina.Name = "Cmb_nome_disciplina"
        Me.Cmb_nome_disciplina.Size = New System.Drawing.Size(157, 21)
        Me.Cmb_nome_disciplina.TabIndex = 14
        '
        'Cmb_nome_turma
        '
        Me.Cmb_nome_turma.FormattingEnabled = True
        Me.Cmb_nome_turma.Location = New System.Drawing.Point(57, 146)
        Me.Cmb_nome_turma.Name = "Cmb_nome_turma"
        Me.Cmb_nome_turma.Size = New System.Drawing.Size(157, 21)
        Me.Cmb_nome_turma.TabIndex = 15
        '
        'Frm_GerenciamentoDisciplinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 329)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Btn_limpar_campos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_GerenciamentoDisciplinas"
        Me.Text = "Gerenciamento e Edição de Disciplinas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_voltar As Button
    Friend WithEvents Btn_limpar_campos As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_cadastrar As Button
    Friend WithEvents Lb_nome_turma As Label
    Friend WithEvents Lb_disciplina As Label
    Friend WithEvents Lb_nome As Label
    Friend WithEvents Cmb_nome_disciplina As ComboBox
    Friend WithEvents Cmb_nome_professor As ComboBox
    Friend WithEvents Cmb_nome_turma As ComboBox
End Class
