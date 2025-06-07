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
        Me.Lb_secretaria = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Lb_acesso_restrito = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_aluno = New Guna.UI.WinForms.GunaButton()
        Me.Btn_professor = New Guna.UI.WinForms.GunaButton()
        Me.Btn_adm = New Guna.UI.WinForms.GunaButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_secretaria
        '
        Me.Lb_secretaria.AutoSize = True
        Me.Lb_secretaria.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_secretaria.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_secretaria.Location = New System.Drawing.Point(53, 14)
        Me.Lb_secretaria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_secretaria.Name = "Lb_secretaria"
        Me.Lb_secretaria.Size = New System.Drawing.Size(281, 32)
        Me.Lb_secretaria.TabIndex = 4
        Me.Lb_secretaria.Text = "CADASTRO DE CONTAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
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
        Me.Btn_voltar.Location = New System.Drawing.Point(430, 256)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 41
        Me.Btn_voltar.Text = "Voltar"
        '
        'Pnl_menu
        '
        Me.Pnl_menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_menu.Controls.Add(Me.Lb_secretaria)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-1, -6)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(538, 57)
        Me.Pnl_menu.TabIndex = 40
        '
        'Lb_acesso_restrito
        '
        Me.Lb_acesso_restrito.AutoSize = True
        Me.Lb_acesso_restrito.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_acesso_restrito.Location = New System.Drawing.Point(12, 262)
        Me.Lb_acesso_restrito.Name = "Lb_acesso_restrito"
        Me.Lb_acesso_restrito.Size = New System.Drawing.Size(125, 21)
        Me.Lb_acesso_restrito.TabIndex = 39
        Me.Lb_acesso_restrito.Text = "Acesso Restrito"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 45)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Área Administrativa"
        '
        'Btn_aluno
        '
        Me.Btn_aluno.AnimationHoverSpeed = 0.07!
        Me.Btn_aluno.AnimationSpeed = 0.03!
        Me.Btn_aluno.BackColor = System.Drawing.Color.Transparent
        Me.Btn_aluno.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_aluno.BorderColor = System.Drawing.Color.Black
        Me.Btn_aluno.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_aluno.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_aluno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_aluno.ForeColor = System.Drawing.Color.White
        Me.Btn_aluno.Image = CType(resources.GetObject("Btn_aluno.Image"), System.Drawing.Image)
        Me.Btn_aluno.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_aluno.Location = New System.Drawing.Point(143, 102)
        Me.Btn_aluno.Name = "Btn_aluno"
        Me.Btn_aluno.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_aluno.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_aluno.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_aluno.OnHoverImage = Nothing
        Me.Btn_aluno.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_aluno.Radius = 2
        Me.Btn_aluno.Size = New System.Drawing.Size(226, 55)
        Me.Btn_aluno.TabIndex = 43
        Me.Btn_aluno.Text = "NOVO ALUNO"
        '
        'Btn_professor
        '
        Me.Btn_professor.AnimationHoverSpeed = 0.07!
        Me.Btn_professor.AnimationSpeed = 0.03!
        Me.Btn_professor.BackColor = System.Drawing.Color.Transparent
        Me.Btn_professor.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_professor.BorderColor = System.Drawing.Color.Black
        Me.Btn_professor.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_professor.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_professor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_professor.ForeColor = System.Drawing.Color.White
        Me.Btn_professor.Image = CType(resources.GetObject("Btn_professor.Image"), System.Drawing.Image)
        Me.Btn_professor.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_professor.Location = New System.Drawing.Point(143, 163)
        Me.Btn_professor.Name = "Btn_professor"
        Me.Btn_professor.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_professor.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_professor.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_professor.OnHoverImage = Nothing
        Me.Btn_professor.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_professor.Radius = 2
        Me.Btn_professor.Size = New System.Drawing.Size(226, 55)
        Me.Btn_professor.TabIndex = 44
        Me.Btn_professor.Text = "NOVO PROFESSOR"
        '
        'Btn_adm
        '
        Me.Btn_adm.AnimationHoverSpeed = 0.07!
        Me.Btn_adm.AnimationSpeed = 0.03!
        Me.Btn_adm.BackColor = System.Drawing.Color.Transparent
        Me.Btn_adm.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_adm.BorderColor = System.Drawing.Color.Black
        Me.Btn_adm.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_adm.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_adm.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_adm.ForeColor = System.Drawing.Color.White
        Me.Btn_adm.Image = CType(resources.GetObject("Btn_adm.Image"), System.Drawing.Image)
        Me.Btn_adm.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_adm.Location = New System.Drawing.Point(143, 224)
        Me.Btn_adm.Name = "Btn_adm"
        Me.Btn_adm.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_adm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_adm.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_adm.OnHoverImage = Nothing
        Me.Btn_adm.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_adm.Radius = 2
        Me.Btn_adm.Size = New System.Drawing.Size(226, 55)
        Me.Btn_adm.TabIndex = 45
        Me.Btn_adm.Text = "NOVO ADMINISTRADOR"
        '
        'Frm_menuCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.Btn_adm)
        Me.Controls.Add(Me.Btn_professor)
        Me.Controls.Add(Me.Btn_aluno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Lb_acesso_restrito)
        Me.Name = "Frm_menuCadastro"
        Me.Text = "Cadastro de Contas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lb_secretaria As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Lb_acesso_restrito As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_aluno As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_professor As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_adm As Guna.UI.WinForms.GunaButton
End Class
