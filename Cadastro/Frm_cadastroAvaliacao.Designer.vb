<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cadastroAvaliacao
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cb_turma = New System.Windows.Forms.ComboBox()
        Me.dtpDataAvaliacao = New System.Windows.Forms.DateTimePicker()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Cb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudPeso = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudPeso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Professor - Turma - Disciplina"
        '
        'Cb_turma
        '
        Me.Cb_turma.FormattingEnabled = True
        Me.Cb_turma.Location = New System.Drawing.Point(124, 129)
        Me.Cb_turma.Name = "Cb_turma"
        Me.Cb_turma.Size = New System.Drawing.Size(570, 21)
        Me.Cb_turma.TabIndex = 3
        '
        'dtpDataAvaliacao
        '
        Me.dtpDataAvaliacao.Location = New System.Drawing.Point(124, 207)
        Me.dtpDataAvaliacao.Name = "dtpDataAvaliacao"
        Me.dtpDataAvaliacao.Size = New System.Drawing.Size(570, 20)
        Me.dtpDataAvaliacao.TabIndex = 7
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(293, 311)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(160, 49)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "CADASTRAR AVALIACAO"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tipo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(541, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Peso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(121, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nome"
        '
        'Txt_nome
        '
        Me.Txt_nome.Location = New System.Drawing.Point(124, 64)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(151, 20)
        Me.Txt_nome.TabIndex = 13
        '
        'Cb_tipo
        '
        Me.Cb_tipo.FormattingEnabled = True
        Me.Cb_tipo.Items.AddRange(New Object() {"N1", "N2", "N3"})
        Me.Cb_tipo.Location = New System.Drawing.Point(335, 64)
        Me.Cb_tipo.Name = "Cb_tipo"
        Me.Cb_tipo.Size = New System.Drawing.Size(169, 21)
        Me.Cb_tipo.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Data da Avaliação"
        '
        'nudPeso
        '
        Me.nudPeso.DecimalPlaces = 2
        Me.nudPeso.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudPeso.Location = New System.Drawing.Point(545, 68)
        Me.nudPeso.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPeso.Name = "nudPeso"
        Me.nudPeso.Size = New System.Drawing.Size(157, 20)
        Me.nudPeso.TabIndex = 17
        Me.nudPeso.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'Frm_cadastroAvaliacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.nudPeso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cb_tipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_nome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.dtpDataAvaliacao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cb_turma)
        Me.Name = "Frm_cadastroAvaliacao"
        Me.Text = "Frm_cadastroAvaliacao"
        CType(Me.nudPeso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Cb_turma As ComboBox
    Friend WithEvents dtpDataAvaliacao As DateTimePicker
    Friend WithEvents btnSalvar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Cb_tipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nudPeso As NumericUpDown
End Class
