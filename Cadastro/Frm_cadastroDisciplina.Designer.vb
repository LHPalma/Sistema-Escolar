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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Num_carga_horaria = New System.Windows.Forms.NumericUpDown()
        Me.Lb_carga_horaria = New System.Windows.Forms.Label()
        Me.Txt_descricao = New System.Windows.Forms.TextBox()
        Me.Lb_descricao = New System.Windows.Forms.Label()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Lb_nome = New System.Windows.Forms.Label()
        Me.Btn_limpar_campos = New Guna.UI.WinForms.GunaButton()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Lb_cadastro_disciplina = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Btn_cadastrar = New Guna.UI.WinForms.GunaButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Num_carga_horaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_cadastrar)
        Me.GroupBox1.Controls.Add(Me.Num_carga_horaria)
        Me.GroupBox1.Controls.Add(Me.Lb_carga_horaria)
        Me.GroupBox1.Controls.Add(Me.Txt_descricao)
        Me.GroupBox1.Controls.Add(Me.Lb_descricao)
        Me.GroupBox1.Controls.Add(Me.Txt_nome)
        Me.GroupBox1.Controls.Add(Me.Lb_nome)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(132, 58)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(249, 260)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insira os Dados de Disciplina"
        '
        'Num_carga_horaria
        '
        Me.Num_carga_horaria.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_carga_horaria.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Num_carga_horaria.Location = New System.Drawing.Point(44, 160)
        Me.Num_carga_horaria.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.Num_carga_horaria.Minimum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.Num_carga_horaria.Name = "Num_carga_horaria"
        Me.Num_carga_horaria.Size = New System.Drawing.Size(159, 29)
        Me.Num_carga_horaria.TabIndex = 12
        Me.Num_carga_horaria.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'Lb_carga_horaria
        '
        Me.Lb_carga_horaria.AutoSize = True
        Me.Lb_carga_horaria.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_carga_horaria.Location = New System.Drawing.Point(41, 144)
        Me.Lb_carga_horaria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_carga_horaria.Name = "Lb_carga_horaria"
        Me.Lb_carga_horaria.Size = New System.Drawing.Size(78, 13)
        Me.Lb_carga_horaria.TabIndex = 9
        Me.Lb_carga_horaria.Text = "Carga Horária"
        '
        'Txt_descricao
        '
        Me.Txt_descricao.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_descricao.Location = New System.Drawing.Point(44, 91)
        Me.Txt_descricao.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_descricao.Multiline = True
        Me.Txt_descricao.Name = "Txt_descricao"
        Me.Txt_descricao.Size = New System.Drawing.Size(159, 39)
        Me.Txt_descricao.TabIndex = 2
        '
        'Lb_descricao
        '
        Me.Lb_descricao.AutoSize = True
        Me.Lb_descricao.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_descricao.Location = New System.Drawing.Point(43, 76)
        Me.Lb_descricao.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_descricao.Name = "Lb_descricao"
        Me.Lb_descricao.Size = New System.Drawing.Size(56, 13)
        Me.Lb_descricao.TabIndex = 10
        Me.Lb_descricao.Text = "Descrição"
        '
        'Txt_nome
        '
        Me.Txt_nome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nome.Location = New System.Drawing.Point(44, 45)
        Me.Txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(159, 29)
        Me.Txt_nome.TabIndex = 1
        '
        'Lb_nome
        '
        Me.Lb_nome.AutoSize = True
        Me.Lb_nome.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_nome.Location = New System.Drawing.Point(42, 30)
        Me.Lb_nome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_nome.Name = "Lb_nome"
        Me.Lb_nome.Size = New System.Drawing.Size(37, 13)
        Me.Lb_nome.TabIndex = 11
        Me.Lb_nome.Text = "Nome"
        '
        'Btn_limpar_campos
        '
        Me.Btn_limpar_campos.AnimationHoverSpeed = 0.07!
        Me.Btn_limpar_campos.AnimationSpeed = 0.03!
        Me.Btn_limpar_campos.BackColor = System.Drawing.Color.Transparent
        Me.Btn_limpar_campos.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_limpar_campos.BorderColor = System.Drawing.Color.Black
        Me.Btn_limpar_campos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_limpar_campos.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_limpar_campos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_limpar_campos.ForeColor = System.Drawing.Color.White
        Me.Btn_limpar_campos.Image = Nothing
        Me.Btn_limpar_campos.ImageSize = New System.Drawing.Size(22, 22)
        Me.Btn_limpar_campos.Location = New System.Drawing.Point(405, 257)
        Me.Btn_limpar_campos.Name = "Btn_limpar_campos"
        Me.Btn_limpar_campos.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_limpar_campos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_limpar_campos.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_limpar_campos.OnHoverImage = Nothing
        Me.Btn_limpar_campos.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_limpar_campos.Radius = 2
        Me.Btn_limpar_campos.Size = New System.Drawing.Size(116, 27)
        Me.Btn_limpar_campos.TabIndex = 55
        Me.Btn_limpar_campos.Text = "Limpar Campos"
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
        Me.Btn_voltar.Location = New System.Drawing.Point(430, 290)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 54
        Me.Btn_voltar.Text = "Voltar"
        '
        'Lb_cadastro_disciplina
        '
        Me.Lb_cadastro_disciplina.AutoSize = True
        Me.Lb_cadastro_disciplina.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_cadastro_disciplina.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_cadastro_disciplina.Location = New System.Drawing.Point(56, 14)
        Me.Lb_cadastro_disciplina.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_cadastro_disciplina.Name = "Lb_cadastro_disciplina"
        Me.Lb_cadastro_disciplina.Size = New System.Drawing.Size(320, 32)
        Me.Lb_cadastro_disciplina.TabIndex = 4
        Me.Lb_cadastro_disciplina.Text = "CADASTRO DE DISCIPLINA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Pnl_menu
        '
        Me.Pnl_menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_menu.Controls.Add(Me.Lb_cadastro_disciplina)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-2, -5)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(546, 57)
        Me.Pnl_menu.TabIndex = 56
        '
        'Btn_cadastrar
        '
        Me.Btn_cadastrar.AnimationHoverSpeed = 0.07!
        Me.Btn_cadastrar.AnimationSpeed = 0.03!
        Me.Btn_cadastrar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_cadastrar.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_cadastrar.BorderColor = System.Drawing.Color.Black
        Me.Btn_cadastrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_cadastrar.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_cadastrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.Btn_cadastrar.Image = Nothing
        Me.Btn_cadastrar.ImageSize = New System.Drawing.Size(30, 30)
        Me.Btn_cadastrar.Location = New System.Drawing.Point(25, 204)
        Me.Btn_cadastrar.Name = "Btn_cadastrar"
        Me.Btn_cadastrar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_cadastrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_cadastrar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_cadastrar.OnHoverImage = Nothing
        Me.Btn_cadastrar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_cadastrar.Radius = 2
        Me.Btn_cadastrar.Size = New System.Drawing.Size(198, 38)
        Me.Btn_cadastrar.TabIndex = 57
        Me.Btn_cadastrar.Text = "CADASTRAR"
        Me.Btn_cadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_CadastroDisciplina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 329)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Btn_limpar_campos)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_CadastroDisciplina"
        Me.Text = "Cadastro de Disciplina"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Num_carga_horaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lb_carga_horaria As Label
    Friend WithEvents Txt_descricao As TextBox
    Friend WithEvents Lb_descricao As Label
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Lb_nome As Label
    Friend WithEvents Num_carga_horaria As NumericUpDown
    Friend WithEvents Btn_limpar_campos As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Lb_cadastro_disciplina As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Btn_cadastrar As Guna.UI.WinForms.GunaButton
End Class
