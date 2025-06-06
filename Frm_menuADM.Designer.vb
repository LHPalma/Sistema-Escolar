<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_menuADM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_menuADM))
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        Me.Lb_acesso_restrito = New System.Windows.Forms.Label()
        Me.Lb_menu_adm = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Btn_cadastro = New Guna.UI.WinForms.GunaButton()
        Me.Btn_gerenciar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lb_bemvindo
        '
        Me.Lb_bemvindo.AutoSize = True
        Me.Lb_bemvindo.Font = New System.Drawing.Font("Segoe UI Semibold", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_bemvindo.Location = New System.Drawing.Point(112, 52)
        Me.Lb_bemvindo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_bemvindo.Name = "Lb_bemvindo"
        Me.Lb_bemvindo.Size = New System.Drawing.Size(315, 45)
        Me.Lb_bemvindo.TabIndex = 2
        Me.Lb_bemvindo.Text = "Área Administrativa"
        '
        'Lb_acesso_restrito
        '
        Me.Lb_acesso_restrito.AutoSize = True
        Me.Lb_acesso_restrito.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_acesso_restrito.Location = New System.Drawing.Point(12, 263)
        Me.Lb_acesso_restrito.Name = "Lb_acesso_restrito"
        Me.Lb_acesso_restrito.Size = New System.Drawing.Size(125, 21)
        Me.Lb_acesso_restrito.TabIndex = 5
        Me.Lb_acesso_restrito.Text = "Acesso Restrito"
        '
        'Lb_menu_adm
        '
        Me.Lb_menu_adm.AutoSize = True
        Me.Lb_menu_adm.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_menu_adm.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_menu_adm.Location = New System.Drawing.Point(56, 20)
        Me.Lb_menu_adm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_menu_adm.Name = "Lb_menu_adm"
        Me.Lb_menu_adm.Size = New System.Drawing.Size(336, 32)
        Me.Lb_menu_adm.TabIndex = 4
        Me.Lb_menu_adm.Text = "MENU DE ADMINISTRADOR"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Pnl_menu
        '
        Me.Pnl_menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_menu.Controls.Add(Me.Lb_menu_adm)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-2, -11)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(543, 59)
        Me.Pnl_menu.TabIndex = 29
        '
        'Btn_cadastro
        '
        Me.Btn_cadastro.AnimationHoverSpeed = 0.07!
        Me.Btn_cadastro.AnimationSpeed = 0.03!
        Me.Btn_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.Btn_cadastro.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_cadastro.BorderColor = System.Drawing.Color.Black
        Me.Btn_cadastro.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_cadastro.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_cadastro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cadastro.ForeColor = System.Drawing.Color.White
        Me.Btn_cadastro.Image = CType(resources.GetObject("Btn_cadastro.Image"), System.Drawing.Image)
        Me.Btn_cadastro.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_cadastro.Location = New System.Drawing.Point(139, 103)
        Me.Btn_cadastro.Name = "Btn_cadastro"
        Me.Btn_cadastro.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_cadastro.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_cadastro.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_cadastro.OnHoverImage = Nothing
        Me.Btn_cadastro.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_cadastro.Radius = 2
        Me.Btn_cadastro.Size = New System.Drawing.Size(260, 55)
        Me.Btn_cadastro.TabIndex = 30
        Me.Btn_cadastro.Text = "CADASTROS"
        '
        'Btn_gerenciar
        '
        Me.Btn_gerenciar.AnimationHoverSpeed = 0.07!
        Me.Btn_gerenciar.AnimationSpeed = 0.03!
        Me.Btn_gerenciar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_gerenciar.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_gerenciar.BorderColor = System.Drawing.Color.Black
        Me.Btn_gerenciar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_gerenciar.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_gerenciar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_gerenciar.ForeColor = System.Drawing.Color.White
        Me.Btn_gerenciar.Image = CType(resources.GetObject("Btn_gerenciar.Image"), System.Drawing.Image)
        Me.Btn_gerenciar.ImageSize = New System.Drawing.Size(40, 40)
        Me.Btn_gerenciar.Location = New System.Drawing.Point(139, 171)
        Me.Btn_gerenciar.Name = "Btn_gerenciar"
        Me.Btn_gerenciar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_gerenciar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_gerenciar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_gerenciar.OnHoverImage = Nothing
        Me.Btn_gerenciar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_gerenciar.Radius = 2
        Me.Btn_gerenciar.Size = New System.Drawing.Size(260, 55)
        Me.Btn_gerenciar.TabIndex = 31
        Me.Btn_gerenciar.Text = "GERENCIAMENTO"
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
        Me.Btn_voltar.Location = New System.Drawing.Point(430, 257)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 32
        Me.Btn_voltar.Text = "Voltar"
        '
        'Frm_menuADM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Btn_gerenciar)
        Me.Controls.Add(Me.Btn_cadastro)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Lb_acesso_restrito)
        Me.Name = "Frm_menuADM"
        Me.Text = "Menu de Administrador"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_bemvindo As Label
    Friend WithEvents Lb_acesso_restrito As Label
    Friend WithEvents Lb_menu_adm As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Btn_cadastro As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_gerenciar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
End Class
