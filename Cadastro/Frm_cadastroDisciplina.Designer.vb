<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CadastroDisciplina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CadastroDisciplina))
        Me.Btn_voltar = New System.Windows.Forms.Button()
        Me.Btn_limpar_campos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Num_carga_horaria = New System.Windows.Forms.NumericUpDown()
        Me.Btn_cadastrar = New System.Windows.Forms.Button()
        Me.Lb_carga_horaria = New System.Windows.Forms.Label()
        Me.Txt_descricao = New System.Windows.Forms.TextBox()
        Me.Lb_descricao = New System.Windows.Forms.Label()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Lb_nome = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Num_carga_horaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_voltar
        '
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_voltar.Location = New System.Drawing.Point(288, 289)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 31
        Me.Btn_voltar.Text = "Voltar"
        Me.Btn_voltar.UseVisualStyleBackColor = True
        '
        'Btn_limpar_campos
        '
        Me.Btn_limpar_campos.Location = New System.Drawing.Point(161, 289)
        Me.Btn_limpar_campos.Name = "Btn_limpar_campos"
        Me.Btn_limpar_campos.Size = New System.Drawing.Size(91, 27)
        Me.Btn_limpar_campos.TabIndex = 30
        Me.Btn_limpar_campos.Text = "Limpar Campos"
        Me.Btn_limpar_campos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Num_carga_horaria)
        Me.GroupBox1.Controls.Add(Me.Btn_cadastrar)
        Me.GroupBox1.Controls.Add(Me.Lb_carga_horaria)
        Me.GroupBox1.Controls.Add(Me.Txt_descricao)
        Me.GroupBox1.Controls.Add(Me.Lb_descricao)
        Me.GroupBox1.Controls.Add(Me.Txt_nome)
        Me.GroupBox1.Controls.Add(Me.Lb_nome)
        Me.GroupBox1.Location = New System.Drawing.Point(129, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(274, 260)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insira os Dados de Disciplina"
        '
        'Num_carga_horaria
        '
        Me.Num_carga_horaria.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Num_carga_horaria.Location = New System.Drawing.Point(56, 160)
        Me.Num_carga_horaria.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.Num_carga_horaria.Minimum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.Num_carga_horaria.Name = "Num_carga_horaria"
        Me.Num_carga_horaria.Size = New System.Drawing.Size(159, 20)
        Me.Num_carga_horaria.TabIndex = 12
        Me.Num_carga_horaria.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'Btn_cadastrar
        '
        Me.Btn_cadastrar.Location = New System.Drawing.Point(46, 194)
        Me.Btn_cadastrar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_cadastrar.Name = "Btn_cadastrar"
        Me.Btn_cadastrar.Size = New System.Drawing.Size(185, 38)
        Me.Btn_cadastrar.TabIndex = 4
        Me.Btn_cadastrar.Text = "CADASTRAR"
        Me.Btn_cadastrar.UseVisualStyleBackColor = True
        '
        'Lb_carga_horaria
        '
        Me.Lb_carga_horaria.AutoSize = True
        Me.Lb_carga_horaria.Location = New System.Drawing.Point(53, 144)
        Me.Lb_carga_horaria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_carga_horaria.Name = "Lb_carga_horaria"
        Me.Lb_carga_horaria.Size = New System.Drawing.Size(72, 13)
        Me.Lb_carga_horaria.TabIndex = 9
        Me.Lb_carga_horaria.Text = "Carga Horária"
        '
        'Txt_descricao
        '
        Me.Txt_descricao.Location = New System.Drawing.Point(56, 91)
        Me.Txt_descricao.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_descricao.Multiline = True
        Me.Txt_descricao.Name = "Txt_descricao"
        Me.Txt_descricao.Size = New System.Drawing.Size(159, 39)
        Me.Txt_descricao.TabIndex = 2
        '
        'Lb_descricao
        '
        Me.Lb_descricao.AutoSize = True
        Me.Lb_descricao.Location = New System.Drawing.Point(55, 76)
        Me.Lb_descricao.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_descricao.Name = "Lb_descricao"
        Me.Lb_descricao.Size = New System.Drawing.Size(55, 13)
        Me.Lb_descricao.TabIndex = 10
        Me.Lb_descricao.Text = "Descrição"
        '
        'Txt_nome
        '
        Me.Txt_nome.Location = New System.Drawing.Point(56, 45)
        Me.Txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(159, 20)
        Me.Txt_nome.TabIndex = 1
        '
        'Lb_nome
        '
        Me.Lb_nome.AutoSize = True
        Me.Lb_nome.Location = New System.Drawing.Point(54, 30)
        Me.Lb_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_nome.Name = "Lb_nome"
        Me.Lb_nome.Size = New System.Drawing.Size(35, 13)
        Me.Lb_nome.TabIndex = 11
        Me.Lb_nome.Text = "Nome"
        '
        'Frm_CadastroDisciplina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 329)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Btn_limpar_campos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_CadastroDisciplina"
        Me.Text = "Cadastro de Disciplina"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Num_carga_horaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_voltar As Button
    Friend WithEvents Btn_limpar_campos As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_cadastrar As Button
    Friend WithEvents Lb_carga_horaria As Label
    Friend WithEvents Txt_descricao As TextBox
    Friend WithEvents Lb_descricao As Label
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Lb_nome As Label
    Friend WithEvents Num_carga_horaria As NumericUpDown
End Class
