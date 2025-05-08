<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MenuGerenciamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_MenuGerenciamento))
        Me.Btn_voltar = New System.Windows.Forms.Button()
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_alunos = New System.Windows.Forms.Button()
        Me.Btn_professores = New System.Windows.Forms.Button()
        Me.Btn_adm = New System.Windows.Forms.Button()
        Me.Btn_disciplinas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_voltar
        '
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_voltar.Location = New System.Drawing.Point(430, 335)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 31
        Me.Btn_voltar.Text = "Voltar"
        Me.Btn_voltar.UseVisualStyleBackColor = True
        '
        'Lb_bemvindo
        '
        Me.Lb_bemvindo.AutoSize = True
        Me.Lb_bemvindo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_bemvindo.Location = New System.Drawing.Point(96, 17)
        Me.Lb_bemvindo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_bemvindo.Name = "Lb_bemvindo"
        Me.Lb_bemvindo.Size = New System.Drawing.Size(312, 39)
        Me.Lb_bemvindo.TabIndex = 30
        Me.Lb_bemvindo.Text = "Área Administrativa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 345)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Acesso Restrito"
        '
        'Btn_alunos
        '
        Me.Btn_alunos.Location = New System.Drawing.Point(167, 77)
        Me.Btn_alunos.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_alunos.Name = "Btn_alunos"
        Me.Btn_alunos.Size = New System.Drawing.Size(175, 55)
        Me.Btn_alunos.TabIndex = 32
        Me.Btn_alunos.Text = "ALUNOS"
        Me.Btn_alunos.UseVisualStyleBackColor = True
        '
        'Btn_professores
        '
        Me.Btn_professores.Location = New System.Drawing.Point(167, 136)
        Me.Btn_professores.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_professores.Name = "Btn_professores"
        Me.Btn_professores.Size = New System.Drawing.Size(175, 55)
        Me.Btn_professores.TabIndex = 33
        Me.Btn_professores.Text = "PROFESSORES"
        Me.Btn_professores.UseVisualStyleBackColor = True
        '
        'Btn_adm
        '
        Me.Btn_adm.Location = New System.Drawing.Point(167, 195)
        Me.Btn_adm.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_adm.Name = "Btn_adm"
        Me.Btn_adm.Size = New System.Drawing.Size(175, 55)
        Me.Btn_adm.TabIndex = 34
        Me.Btn_adm.Text = "ADMINISTRADORES"
        Me.Btn_adm.UseVisualStyleBackColor = True
        '
        'Btn_disciplinas
        '
        Me.Btn_disciplinas.Location = New System.Drawing.Point(167, 254)
        Me.Btn_disciplinas.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_disciplinas.Name = "Btn_disciplinas"
        Me.Btn_disciplinas.Size = New System.Drawing.Size(175, 55)
        Me.Btn_disciplinas.TabIndex = 35
        Me.Btn_disciplinas.Text = "DISCIPLINAS"
        Me.Btn_disciplinas.UseVisualStyleBackColor = True
        '
        'Frm_MenuGerenciamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 374)
        Me.Controls.Add(Me.Btn_disciplinas)
        Me.Controls.Add(Me.Btn_adm)
        Me.Controls.Add(Me.Btn_professores)
        Me.Controls.Add(Me.Btn_alunos)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_MenuGerenciamento"
        Me.Text = "Gerenciamento de Contas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_voltar As Button
    Friend WithEvents Lb_bemvindo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_alunos As Button
    Friend WithEvents Btn_professores As Button
    Friend WithEvents Btn_adm As Button
    Friend WithEvents Btn_disciplinas As Button
End Class
