<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_agendamentoAvaliacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_agendamentoAvaliacao))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lb_data = New System.Windows.Forms.Label()
        Me.Cmb_data = New System.Windows.Forms.DateTimePicker()
        Me.Cmb_peso_avaliacao = New System.Windows.Forms.ComboBox()
        Me.Lb_peso = New System.Windows.Forms.Label()
        Me.Cmb_tipo_avaliacao = New System.Windows.Forms.ComboBox()
        Me.Lb_tipo = New System.Windows.Forms.Label()
        Me.Txt_nome_avaliacao = New System.Windows.Forms.TextBox()
        Me.Lb_avaliacao = New System.Windows.Forms.Label()
        Me.Cmb_nome_professor = New System.Windows.Forms.ComboBox()
        Me.Lb_nome = New System.Windows.Forms.Label()
        Me.Btn_agendar = New System.Windows.Forms.Button()
        Me.Btn_voltar = New System.Windows.Forms.Button()
        Me.Btn_limpar_campos = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lb_data)
        Me.GroupBox1.Controls.Add(Me.Cmb_data)
        Me.GroupBox1.Controls.Add(Me.Cmb_peso_avaliacao)
        Me.GroupBox1.Controls.Add(Me.Lb_peso)
        Me.GroupBox1.Controls.Add(Me.Cmb_tipo_avaliacao)
        Me.GroupBox1.Controls.Add(Me.Lb_tipo)
        Me.GroupBox1.Controls.Add(Me.Txt_nome_avaliacao)
        Me.GroupBox1.Controls.Add(Me.Lb_avaliacao)
        Me.GroupBox1.Controls.Add(Me.Cmb_nome_professor)
        Me.GroupBox1.Controls.Add(Me.Lb_nome)
        Me.GroupBox1.Controls.Add(Me.Btn_agendar)
        Me.GroupBox1.Location = New System.Drawing.Point(115, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 339)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insira os Dados da Avaliação"
        '
        'Lb_data
        '
        Me.Lb_data.AutoSize = True
        Me.Lb_data.Location = New System.Drawing.Point(46, 206)
        Me.Lb_data.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_data.Name = "Lb_data"
        Me.Lb_data.Size = New System.Drawing.Size(95, 13)
        Me.Lb_data.TabIndex = 44
        Me.Lb_data.Text = "Data da Avaliação"
        '
        'Cmb_data
        '
        Me.Cmb_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Cmb_data.Location = New System.Drawing.Point(49, 222)
        Me.Cmb_data.Name = "Cmb_data"
        Me.Cmb_data.Size = New System.Drawing.Size(160, 20)
        Me.Cmb_data.TabIndex = 43
        '
        'Cmb_peso_avaliacao
        '
        Me.Cmb_peso_avaliacao.FormattingEnabled = True
        Me.Cmb_peso_avaliacao.Items.AddRange(New Object() {"33,3%", "40%", "50%", "60%", "70%", "100%"})
        Me.Cmb_peso_avaliacao.Location = New System.Drawing.Point(150, 164)
        Me.Cmb_peso_avaliacao.Name = "Cmb_peso_avaliacao"
        Me.Cmb_peso_avaliacao.Size = New System.Drawing.Size(59, 21)
        Me.Cmb_peso_avaliacao.TabIndex = 42
        '
        'Lb_peso
        '
        Me.Lb_peso.AutoSize = True
        Me.Lb_peso.Location = New System.Drawing.Point(147, 148)
        Me.Lb_peso.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_peso.Name = "Lb_peso"
        Me.Lb_peso.Size = New System.Drawing.Size(96, 13)
        Me.Lb_peso.TabIndex = 41
        Me.Lb_peso.Text = "Peso da Avaliação"
        '
        'Cmb_tipo_avaliacao
        '
        Me.Cmb_tipo_avaliacao.FormattingEnabled = True
        Me.Cmb_tipo_avaliacao.Items.AddRange(New Object() {"N1", "N2", "N3"})
        Me.Cmb_tipo_avaliacao.Location = New System.Drawing.Point(49, 164)
        Me.Cmb_tipo_avaliacao.Name = "Cmb_tipo_avaliacao"
        Me.Cmb_tipo_avaliacao.Size = New System.Drawing.Size(66, 21)
        Me.Cmb_tipo_avaliacao.TabIndex = 40
        '
        'Lb_tipo
        '
        Me.Lb_tipo.AutoSize = True
        Me.Lb_tipo.Location = New System.Drawing.Point(46, 148)
        Me.Lb_tipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_tipo.Name = "Lb_tipo"
        Me.Lb_tipo.Size = New System.Drawing.Size(93, 13)
        Me.Lb_tipo.TabIndex = 39
        Me.Lb_tipo.Text = "Tipo de Avaliação"
        '
        'Txt_nome_avaliacao
        '
        Me.Txt_nome_avaliacao.Location = New System.Drawing.Point(49, 107)
        Me.Txt_nome_avaliacao.Name = "Txt_nome_avaliacao"
        Me.Txt_nome_avaliacao.Size = New System.Drawing.Size(160, 20)
        Me.Txt_nome_avaliacao.TabIndex = 38
        '
        'Lb_avaliacao
        '
        Me.Lb_avaliacao.AutoSize = True
        Me.Lb_avaliacao.Location = New System.Drawing.Point(46, 91)
        Me.Lb_avaliacao.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_avaliacao.Name = "Lb_avaliacao"
        Me.Lb_avaliacao.Size = New System.Drawing.Size(100, 13)
        Me.Lb_avaliacao.TabIndex = 37
        Me.Lb_avaliacao.Text = "Nome da Avaliação"
        '
        'Cmb_nome_professor
        '
        Me.Cmb_nome_professor.FormattingEnabled = True
        Me.Cmb_nome_professor.Location = New System.Drawing.Point(49, 51)
        Me.Cmb_nome_professor.Name = "Cmb_nome_professor"
        Me.Cmb_nome_professor.Size = New System.Drawing.Size(160, 21)
        Me.Cmb_nome_professor.TabIndex = 36
        '
        'Lb_nome
        '
        Me.Lb_nome.AutoSize = True
        Me.Lb_nome.Location = New System.Drawing.Point(46, 35)
        Me.Lb_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_nome.Name = "Lb_nome"
        Me.Lb_nome.Size = New System.Drawing.Size(97, 13)
        Me.Lb_nome.TabIndex = 35
        Me.Lb_nome.Text = "Nome do Professor"
        '
        'Btn_agendar
        '
        Me.Btn_agendar.Location = New System.Drawing.Point(29, 271)
        Me.Btn_agendar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_agendar.Name = "Btn_agendar"
        Me.Btn_agendar.Size = New System.Drawing.Size(219, 43)
        Me.Btn_agendar.TabIndex = 34
        Me.Btn_agendar.Text = "AGENDAR"
        Me.Btn_agendar.UseVisualStyleBackColor = True
        '
        'Btn_voltar
        '
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_voltar.Location = New System.Drawing.Point(272, 388)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 36
        Me.Btn_voltar.Text = "Voltar"
        Me.Btn_voltar.UseVisualStyleBackColor = True
        '
        'Btn_limpar_campos
        '
        Me.Btn_limpar_campos.Location = New System.Drawing.Point(144, 388)
        Me.Btn_limpar_campos.Name = "Btn_limpar_campos"
        Me.Btn_limpar_campos.Size = New System.Drawing.Size(91, 27)
        Me.Btn_limpar_campos.TabIndex = 35
        Me.Btn_limpar_campos.Text = "Limpar Campos"
        Me.Btn_limpar_campos.UseVisualStyleBackColor = True
        '
        'Frm_agendamentoAvaliacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 433)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_limpar_campos)
        Me.Name = "Frm_agendamentoAvaliacao"
        Me.Text = "Agendamento de Avaliações"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_voltar As Button
    Friend WithEvents Btn_limpar_campos As Button
    Friend WithEvents Btn_agendar As Button
    Friend WithEvents Cmb_nome_professor As ComboBox
    Friend WithEvents Lb_nome As Label
    Friend WithEvents Txt_nome_avaliacao As TextBox
    Friend WithEvents Lb_avaliacao As Label
    Friend WithEvents Cmb_tipo_avaliacao As ComboBox
    Friend WithEvents Lb_tipo As Label
    Friend WithEvents Cmb_peso_avaliacao As ComboBox
    Friend WithEvents Lb_peso As Label
    Friend WithEvents Lb_data As Label
    Friend WithEvents Cmb_data As DateTimePicker
End Class
