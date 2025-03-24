<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_inicio
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
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        Me.Btn_professor = New System.Windows.Forms.Button()
        Me.Btn_aluno = New System.Windows.Forms.Button()
        Me.Btn_adm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lb_bemvindo
        '
        Me.Lb_bemvindo.AutoSize = True
        Me.Lb_bemvindo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_bemvindo.Location = New System.Drawing.Point(271, 9)
        Me.Lb_bemvindo.Name = "Lb_bemvindo"
        Me.Lb_bemvindo.Size = New System.Drawing.Size(273, 58)
        Me.Lb_bemvindo.TabIndex = 0
        Me.Lb_bemvindo.Text = "Bem-Vindo"
        '
        'Btn_professor
        '
        Me.Btn_professor.Location = New System.Drawing.Point(298, 82)
        Me.Btn_professor.Name = "Btn_professor"
        Me.Btn_professor.Size = New System.Drawing.Size(187, 85)
        Me.Btn_professor.TabIndex = 1
        Me.Btn_professor.Text = "PROFESSOR"
        Me.Btn_professor.UseVisualStyleBackColor = True
        '
        'Btn_aluno
        '
        Me.Btn_aluno.Location = New System.Drawing.Point(298, 191)
        Me.Btn_aluno.Name = "Btn_aluno"
        Me.Btn_aluno.Size = New System.Drawing.Size(187, 85)
        Me.Btn_aluno.TabIndex = 1
        Me.Btn_aluno.Text = "ALUNO"
        Me.Btn_aluno.UseVisualStyleBackColor = True
        '
        'Btn_adm
        '
        Me.Btn_adm.Location = New System.Drawing.Point(298, 299)
        Me.Btn_adm.Name = "Btn_adm"
        Me.Btn_adm.Size = New System.Drawing.Size(187, 85)
        Me.Btn_adm.TabIndex = 1
        Me.Btn_adm.Text = "ADMINISTRADOR"
        Me.Btn_adm.UseVisualStyleBackColor = True
        '
        'Frm_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_aluno)
        Me.Controls.Add(Me.Btn_adm)
        Me.Controls.Add(Me.Btn_professor)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Name = "Frm_inicio"
        Me.Text = "Frm_inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_bemvindo As Label
    Friend WithEvents Btn_professor As Button
    Friend WithEvents Btn_aluno As Button
    Friend WithEvents Btn_adm As Button
End Class
