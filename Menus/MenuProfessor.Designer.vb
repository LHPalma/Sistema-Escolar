<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuProfessor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuProfessor))
        Me.Btn_agendarAvaliacao = New System.Windows.Forms.Button()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        Me.Btn_lancarFalta = New System.Windows.Forms.Button()
        Me.Btn_lancarNota = New System.Windows.Forms.Button()
        Me.Btn_enviarArquivos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_agendarAvaliacao
        '
        Me.Btn_agendarAvaliacao.Location = New System.Drawing.Point(294, 110)
        Me.Btn_agendarAvaliacao.Name = "Btn_agendarAvaliacao"
        Me.Btn_agendarAvaliacao.Size = New System.Drawing.Size(191, 50)
        Me.Btn_agendarAvaliacao.TabIndex = 38
        Me.Btn_agendarAvaliacao.Text = "Agendar Avaliação"
        Me.Btn_agendarAvaliacao.UseVisualStyleBackColor = True
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
        Me.Btn_voltar.Location = New System.Drawing.Point(694, 415)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 37
        Me.Btn_voltar.Text = "Sair"
        '
        'Lb_bemvindo
        '
        Me.Lb_bemvindo.AutoSize = True
        Me.Lb_bemvindo.Font = New System.Drawing.Font("Segoe UI Semibold", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_bemvindo.Location = New System.Drawing.Point(251, 48)
        Me.Lb_bemvindo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_bemvindo.Name = "Lb_bemvindo"
        Me.Lb_bemvindo.Size = New System.Drawing.Size(304, 45)
        Me.Lb_bemvindo.TabIndex = 36
        Me.Lb_bemvindo.Text = "Menu do Professor"
        '
        'Btn_lancarFalta
        '
        Me.Btn_lancarFalta.Location = New System.Drawing.Point(294, 186)
        Me.Btn_lancarFalta.Name = "Btn_lancarFalta"
        Me.Btn_lancarFalta.Size = New System.Drawing.Size(191, 50)
        Me.Btn_lancarFalta.TabIndex = 39
        Me.Btn_lancarFalta.Text = "Lançar Faltas"
        Me.Btn_lancarFalta.UseVisualStyleBackColor = True
        '
        'Btn_lancarNota
        '
        Me.Btn_lancarNota.Location = New System.Drawing.Point(294, 259)
        Me.Btn_lancarNota.Name = "Btn_lancarNota"
        Me.Btn_lancarNota.Size = New System.Drawing.Size(191, 50)
        Me.Btn_lancarNota.TabIndex = 40
        Me.Btn_lancarNota.Text = "Lançar Notas"
        Me.Btn_lancarNota.UseVisualStyleBackColor = True
        '
        'Btn_enviarArquivos
        '
        Me.Btn_enviarArquivos.Location = New System.Drawing.Point(294, 333)
        Me.Btn_enviarArquivos.Name = "Btn_enviarArquivos"
        Me.Btn_enviarArquivos.Size = New System.Drawing.Size(191, 50)
        Me.Btn_enviarArquivos.TabIndex = 41
        Me.Btn_enviarArquivos.Text = "Enviar Arquivos"
        Me.Btn_enviarArquivos.UseVisualStyleBackColor = True
        '
        'MenuProfessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_enviarArquivos)
        Me.Controls.Add(Me.Btn_lancarNota)
        Me.Controls.Add(Me.Btn_lancarFalta)
        Me.Controls.Add(Me.Btn_agendarAvaliacao)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Name = "MenuProfessor"
        Me.Text = "MenuProfessor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_agendarAvaliacao As Button
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Lb_bemvindo As Label
    Friend WithEvents Btn_lancarFalta As Button
    Friend WithEvents Btn_lancarNota As Button
    Friend WithEvents Btn_enviarArquivos As Button
End Class
