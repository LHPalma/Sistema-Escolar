<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuAluno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAluno))
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        Me.Btn_consultarDisciplinas = New System.Windows.Forms.Button()
        Me.Btn_consultarAvaliacoes = New System.Windows.Forms.Button()
        Me.Btn_consultarFaltas = New System.Windows.Forms.Button()
        Me.Btn_consultarNotas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_voltar
        '
        Me.Btn_voltar.AnimationHoverSpeed = 0.07!
        Me.Btn_voltar.AnimationSpeed = 0.03!
        Me.Btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_voltar.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_voltar.BorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_voltar.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_voltar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_voltar.ForeColor = System.Drawing.Color.White
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageSize = New System.Drawing.Size(22, 22)
        Me.Btn_voltar.Location = New System.Drawing.Point(697, 411)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 34
        Me.Btn_voltar.Text = "Sair"
        '
        'Lb_bemvindo
        '
        Me.Lb_bemvindo.AutoSize = True
        Me.Lb_bemvindo.Font = New System.Drawing.Font("Segoe UI Semibold", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_bemvindo.Location = New System.Drawing.Point(274, 38)
        Me.Lb_bemvindo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_bemvindo.Name = "Lb_bemvindo"
        Me.Lb_bemvindo.Size = New System.Drawing.Size(254, 45)
        Me.Lb_bemvindo.TabIndex = 33
        Me.Lb_bemvindo.Text = "Menu do Aluno"
        '
        'Btn_consultarDisciplinas
        '
        Me.Btn_consultarDisciplinas.Location = New System.Drawing.Point(297, 134)
        Me.Btn_consultarDisciplinas.Name = "Btn_consultarDisciplinas"
        Me.Btn_consultarDisciplinas.Size = New System.Drawing.Size(191, 50)
        Me.Btn_consultarDisciplinas.TabIndex = 35
        Me.Btn_consultarDisciplinas.Text = "Consultar Disciplinas"
        Me.Btn_consultarDisciplinas.UseVisualStyleBackColor = True
        '
        'Btn_consultarAvaliacoes
        '
        Me.Btn_consultarAvaliacoes.Location = New System.Drawing.Point(297, 190)
        Me.Btn_consultarAvaliacoes.Name = "Btn_consultarAvaliacoes"
        Me.Btn_consultarAvaliacoes.Size = New System.Drawing.Size(191, 50)
        Me.Btn_consultarAvaliacoes.TabIndex = 36
        Me.Btn_consultarAvaliacoes.Text = "Consultar Avaliaçoes"
        Me.Btn_consultarAvaliacoes.UseVisualStyleBackColor = True
        '
        'Btn_consultarFaltas
        '
        Me.Btn_consultarFaltas.Location = New System.Drawing.Point(297, 302)
        Me.Btn_consultarFaltas.Name = "Btn_consultarFaltas"
        Me.Btn_consultarFaltas.Size = New System.Drawing.Size(191, 49)
        Me.Btn_consultarFaltas.TabIndex = 37
        Me.Btn_consultarFaltas.Text = "Consultar Faltas"
        Me.Btn_consultarFaltas.UseVisualStyleBackColor = True
        '
        'Btn_consultarNotas
        '
        Me.Btn_consultarNotas.Location = New System.Drawing.Point(297, 246)
        Me.Btn_consultarNotas.Name = "Btn_consultarNotas"
        Me.Btn_consultarNotas.Size = New System.Drawing.Size(191, 50)
        Me.Btn_consultarNotas.TabIndex = 38
        Me.Btn_consultarNotas.Text = "Consultar Notas"
        Me.Btn_consultarNotas.UseVisualStyleBackColor = True
        '
        'MenuAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_consultarNotas)
        Me.Controls.Add(Me.Btn_consultarFaltas)
        Me.Controls.Add(Me.Btn_consultarAvaliacoes)
        Me.Controls.Add(Me.Btn_consultarDisciplinas)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Name = "MenuAluno"
        Me.Text = "MenuAluno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Lb_bemvindo As Label
    Friend WithEvents Btn_consultarDisciplinas As Button
    Friend WithEvents Btn_consultarAvaliacoes As Button
    Friend WithEvents Btn_consultarFaltas As Button
    Friend WithEvents Btn_consultarNotas As Button
End Class
