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
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        Me.Lb_menu_principal_professor = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Btn_agendarAvaliacao = New Guna.UI.WinForms.GunaButton()
        Me.Btn_lancarFalta = New Guna.UI.WinForms.GunaButton()
        Me.Btn_lancarNota = New Guna.UI.WinForms.GunaButton()
        Me.Btn_acessarArquivos = New Guna.UI.WinForms.GunaButton()
        Me.Btn_arquivos = New Guna.UI.WinForms.GunaButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
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
        Me.Btn_voltar.Location = New System.Drawing.Point(430, 468)
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
        Me.Lb_bemvindo.Location = New System.Drawing.Point(107, 54)
        Me.Lb_bemvindo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_bemvindo.Name = "Lb_bemvindo"
        Me.Lb_bemvindo.Size = New System.Drawing.Size(304, 45)
        Me.Lb_bemvindo.TabIndex = 36
        Me.Lb_bemvindo.Text = "Menu do Professor"
        '
        'Lb_menu_principal_professor
        '
        Me.Lb_menu_principal_professor.AutoSize = True
        Me.Lb_menu_principal_professor.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_menu_principal_professor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_menu_principal_professor.Location = New System.Drawing.Point(53, 14)
        Me.Lb_menu_principal_professor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_menu_principal_professor.Name = "Lb_menu_principal_professor"
        Me.Lb_menu_principal_professor.Size = New System.Drawing.Size(217, 32)
        Me.Lb_menu_principal_professor.TabIndex = 4
        Me.Lb_menu_principal_professor.Text = "MENU PRINCIPAL"
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
        'Pnl_menu
        '
        Me.Pnl_menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_menu.Controls.Add(Me.Lb_menu_principal_professor)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-1, -5)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(538, 57)
        Me.Pnl_menu.TabIndex = 42
        '
        'Btn_agendarAvaliacao
        '
        Me.Btn_agendarAvaliacao.AnimationHoverSpeed = 0.07!
        Me.Btn_agendarAvaliacao.AnimationSpeed = 0.03!
        Me.Btn_agendarAvaliacao.BackColor = System.Drawing.Color.Transparent
        Me.Btn_agendarAvaliacao.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_agendarAvaliacao.BorderColor = System.Drawing.Color.Black
        Me.Btn_agendarAvaliacao.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_agendarAvaliacao.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_agendarAvaliacao.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_agendarAvaliacao.ForeColor = System.Drawing.Color.White
        Me.Btn_agendarAvaliacao.Image = CType(resources.GetObject("Btn_agendarAvaliacao.Image"), System.Drawing.Image)
        Me.Btn_agendarAvaliacao.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_agendarAvaliacao.Location = New System.Drawing.Point(148, 139)
        Me.Btn_agendarAvaliacao.Name = "Btn_agendarAvaliacao"
        Me.Btn_agendarAvaliacao.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_agendarAvaliacao.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_agendarAvaliacao.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_agendarAvaliacao.OnHoverImage = Nothing
        Me.Btn_agendarAvaliacao.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_agendarAvaliacao.Radius = 2
        Me.Btn_agendarAvaliacao.Size = New System.Drawing.Size(226, 55)
        Me.Btn_agendarAvaliacao.TabIndex = 46
        Me.Btn_agendarAvaliacao.Text = "AGENDAR AVALIAÇÃO"
        '
        'Btn_lancarFalta
        '
        Me.Btn_lancarFalta.AnimationHoverSpeed = 0.07!
        Me.Btn_lancarFalta.AnimationSpeed = 0.03!
        Me.Btn_lancarFalta.BackColor = System.Drawing.Color.Transparent
        Me.Btn_lancarFalta.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_lancarFalta.BorderColor = System.Drawing.Color.Black
        Me.Btn_lancarFalta.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_lancarFalta.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_lancarFalta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_lancarFalta.ForeColor = System.Drawing.Color.White
        Me.Btn_lancarFalta.Image = CType(resources.GetObject("Btn_lancarFalta.Image"), System.Drawing.Image)
        Me.Btn_lancarFalta.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_lancarFalta.Location = New System.Drawing.Point(148, 200)
        Me.Btn_lancarFalta.Name = "Btn_lancarFalta"
        Me.Btn_lancarFalta.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_lancarFalta.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_lancarFalta.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_lancarFalta.OnHoverImage = Nothing
        Me.Btn_lancarFalta.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_lancarFalta.Radius = 2
        Me.Btn_lancarFalta.Size = New System.Drawing.Size(226, 55)
        Me.Btn_lancarFalta.TabIndex = 47
        Me.Btn_lancarFalta.Text = "LANÇAR FALTAS"
        '
        'Btn_lancarNota
        '
        Me.Btn_lancarNota.AnimationHoverSpeed = 0.07!
        Me.Btn_lancarNota.AnimationSpeed = 0.03!
        Me.Btn_lancarNota.BackColor = System.Drawing.Color.Transparent
        Me.Btn_lancarNota.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_lancarNota.BorderColor = System.Drawing.Color.Black
        Me.Btn_lancarNota.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_lancarNota.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_lancarNota.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_lancarNota.ForeColor = System.Drawing.Color.White
        Me.Btn_lancarNota.Image = CType(resources.GetObject("Btn_lancarNota.Image"), System.Drawing.Image)
        Me.Btn_lancarNota.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_lancarNota.Location = New System.Drawing.Point(148, 261)
        Me.Btn_lancarNota.Name = "Btn_lancarNota"
        Me.Btn_lancarNota.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_lancarNota.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_lancarNota.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_lancarNota.OnHoverImage = Nothing
        Me.Btn_lancarNota.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_lancarNota.Radius = 2
        Me.Btn_lancarNota.Size = New System.Drawing.Size(226, 55)
        Me.Btn_lancarNota.TabIndex = 48
        Me.Btn_lancarNota.Text = "PUBLICAR NOTAS"
        '
        'Btn_acessarArquivos
        '
        Me.Btn_acessarArquivos.AnimationHoverSpeed = 0.07!
        Me.Btn_acessarArquivos.AnimationSpeed = 0.03!
        Me.Btn_acessarArquivos.BackColor = System.Drawing.Color.Transparent
        Me.Btn_acessarArquivos.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_acessarArquivos.BorderColor = System.Drawing.Color.Black
        Me.Btn_acessarArquivos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_acessarArquivos.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_acessarArquivos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_acessarArquivos.ForeColor = System.Drawing.Color.White
        Me.Btn_acessarArquivos.Image = CType(resources.GetObject("Btn_acessarArquivos.Image"), System.Drawing.Image)
        Me.Btn_acessarArquivos.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_acessarArquivos.Location = New System.Drawing.Point(148, 383)
        Me.Btn_acessarArquivos.Name = "Btn_acessarArquivos"
        Me.Btn_acessarArquivos.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_acessarArquivos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_acessarArquivos.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_acessarArquivos.OnHoverImage = Nothing
        Me.Btn_acessarArquivos.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_acessarArquivos.Radius = 2
        Me.Btn_acessarArquivos.Size = New System.Drawing.Size(226, 55)
        Me.Btn_acessarArquivos.TabIndex = 51
        Me.Btn_acessarArquivos.Text = "  ACESSAR ARQUIVOS"
        Me.Btn_acessarArquivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_arquivos
        '
        Me.Btn_arquivos.AnimationHoverSpeed = 0.07!
        Me.Btn_arquivos.AnimationSpeed = 0.03!
        Me.Btn_arquivos.BackColor = System.Drawing.Color.Transparent
        Me.Btn_arquivos.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_arquivos.BorderColor = System.Drawing.Color.Black
        Me.Btn_arquivos.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_arquivos.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_arquivos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_arquivos.ForeColor = System.Drawing.Color.White
        Me.Btn_arquivos.Image = CType(resources.GetObject("Btn_arquivos.Image"), System.Drawing.Image)
        Me.Btn_arquivos.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_arquivos.Location = New System.Drawing.Point(148, 322)
        Me.Btn_arquivos.Name = "Btn_arquivos"
        Me.Btn_arquivos.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_arquivos.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_arquivos.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_arquivos.OnHoverImage = Nothing
        Me.Btn_arquivos.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_arquivos.Radius = 2
        Me.Btn_arquivos.Size = New System.Drawing.Size(226, 55)
        Me.Btn_arquivos.TabIndex = 50
        Me.Btn_arquivos.Text = "ENVIAR ARQUIVOS"
        Me.Btn_arquivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuProfessor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(533, 507)
        Me.Controls.Add(Me.Btn_acessarArquivos)
        Me.Controls.Add(Me.Btn_arquivos)
        Me.Controls.Add(Me.Btn_lancarNota)
        Me.Controls.Add(Me.Btn_lancarFalta)
        Me.Controls.Add(Me.Btn_agendarAvaliacao)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Name = "MenuProfessor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Lb_bemvindo As Label
    Friend WithEvents Lb_menu_principal_professor As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Btn_agendarAvaliacao As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_lancarFalta As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_lancarNota As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_acessarArquivos As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_arquivos As Guna.UI.WinForms.GunaButton
End Class
