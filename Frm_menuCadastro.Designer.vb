<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_menuCadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_menuCadastro))
        Me.Btn_professor = New System.Windows.Forms.Button()
        Me.Btn_aluno = New System.Windows.Forms.Button()
        Me.Btn_adm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        Me.Btn_voltar = New System.Windows.Forms.Button()
        Me.Btn_turma = New System.Windows.Forms.Button()
        Me.Btn_disciplina = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_professor
        '
        Me.Btn_professor.Location = New System.Drawing.Point(167, 136)
        Me.Btn_professor.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_professor.Name = "Btn_professor"
        Me.Btn_professor.Size = New System.Drawing.Size(175, 55)
        Me.Btn_professor.TabIndex = 5
        Me.Btn_professor.Text = "NOVO PROFESSOR"
        Me.Btn_professor.UseVisualStyleBackColor = True
        '
        'Btn_aluno
        '
        Me.Btn_aluno.Location = New System.Drawing.Point(167, 77)
        Me.Btn_aluno.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_aluno.Name = "Btn_aluno"
        Me.Btn_aluno.Size = New System.Drawing.Size(175, 55)
        Me.Btn_aluno.TabIndex = 6
        Me.Btn_aluno.Text = "NOVO ALUNO"
        Me.Btn_aluno.UseVisualStyleBackColor = True
        '
        'Btn_adm
        '
        Me.Btn_adm.Location = New System.Drawing.Point(167, 195)
        Me.Btn_adm.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_adm.Name = "Btn_adm"
        Me.Btn_adm.Size = New System.Drawing.Size(175, 55)
        Me.Btn_adm.TabIndex = 7
        Me.Btn_adm.Text = "NOVO ADMINISTRADOR"
        Me.Btn_adm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Acesso Restrito"
        '
        'Lb_bemvindo
        '
        Me.Lb_bemvindo.AutoSize = True
        Me.Lb_bemvindo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_bemvindo.Location = New System.Drawing.Point(96, 24)
        Me.Lb_bemvindo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_bemvindo.Name = "Lb_bemvindo"
        Me.Lb_bemvindo.Size = New System.Drawing.Size(312, 39)
        Me.Lb_bemvindo.TabIndex = 9
        Me.Lb_bemvindo.Text = "Área Administrativa"
        '
        'Btn_voltar
        '
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_voltar.Location = New System.Drawing.Point(430, 415)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 28
        Me.Btn_voltar.Text = "Voltar"
        Me.Btn_voltar.UseVisualStyleBackColor = True
        '
        'Btn_turma
        '
        Me.Btn_turma.Location = New System.Drawing.Point(167, 254)
        Me.Btn_turma.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_turma.Name = "Btn_turma"
        Me.Btn_turma.Size = New System.Drawing.Size(175, 55)
        Me.Btn_turma.TabIndex = 29
        Me.Btn_turma.Text = "NOVA TURMA"
        Me.Btn_turma.UseVisualStyleBackColor = True
        '
        'Btn_disciplina
        '
        Me.Btn_disciplina.Location = New System.Drawing.Point(167, 313)
        Me.Btn_disciplina.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_disciplina.Name = "Btn_disciplina"
        Me.Btn_disciplina.Size = New System.Drawing.Size(175, 55)
        Me.Btn_disciplina.TabIndex = 30
        Me.Btn_disciplina.Text = "NOVA DISCIPLINA"
        Me.Btn_disciplina.UseVisualStyleBackColor = True
        '
        'Frm_menuCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 454)
        Me.Controls.Add(Me.Btn_disciplina)
        Me.Controls.Add(Me.Btn_turma)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_adm)
        Me.Controls.Add(Me.Btn_aluno)
        Me.Controls.Add(Me.Btn_professor)
        Me.Name = "Frm_menuCadastro"
        Me.Text = "Cadastro de Contas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_professor As Button
    Friend WithEvents Btn_aluno As Button
    Friend WithEvents Btn_adm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Lb_bemvindo As Label
    Friend WithEvents Btn_voltar As Button
    Friend WithEvents Btn_turma As Button
    Friend WithEvents Btn_disciplina As Button
End Class
