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
        Me.btn_professor = New System.Windows.Forms.Button()
        Me.btn_aluno = New System.Windows.Forms.Button()
        Me.btn_adm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_professor
        '
        Me.btn_professor.Location = New System.Drawing.Point(167, 136)
        Me.btn_professor.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_professor.Name = "btn_professor"
        Me.btn_professor.Size = New System.Drawing.Size(175, 55)
        Me.btn_professor.TabIndex = 5
        Me.btn_professor.Text = "NOVO PROFESSOR"
        Me.btn_professor.UseVisualStyleBackColor = True
        '
        'btn_aluno
        '
        Me.btn_aluno.Location = New System.Drawing.Point(167, 77)
        Me.btn_aluno.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_aluno.Name = "btn_aluno"
        Me.btn_aluno.Size = New System.Drawing.Size(175, 55)
        Me.btn_aluno.TabIndex = 6
        Me.btn_aluno.Text = "NOVO ALUNO"
        Me.btn_aluno.UseVisualStyleBackColor = True
        '
        'btn_adm
        '
        Me.btn_adm.Location = New System.Drawing.Point(167, 195)
        Me.btn_adm.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_adm.Name = "btn_adm"
        Me.btn_adm.Size = New System.Drawing.Size(175, 55)
        Me.btn_adm.TabIndex = 7
        Me.btn_adm.Text = "NOVO ADMINISTRADOR"
        Me.btn_adm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 263)
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
        'Frm_menuCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_adm)
        Me.Controls.Add(Me.btn_aluno)
        Me.Controls.Add(Me.btn_professor)
        Me.Name = "Frm_menuCadastro"
        Me.Text = "Cadastro de Contas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_professor As Button
    Friend WithEvents btn_aluno As Button
    Friend WithEvents btn_adm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Lb_bemvindo As Label
End Class
