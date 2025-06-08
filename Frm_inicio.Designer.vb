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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_inicio))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_aluno = New Guna.UI.WinForms.GunaButton()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Lb_menu_principal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_professor = New Guna.UI.WinForms.GunaButton()
        Me.Btn_adm = New Guna.UI.WinForms.GunaButton()
        Me.Lb_bem_vindo = New System.Windows.Forms.Label()
        Me.Pnl_menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 257)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "E-scola" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Todos os direitos reservados ©. "
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
        Me.Btn_aluno.Location = New System.Drawing.Point(176, 93)
        Me.Btn_aluno.Name = "Btn_aluno"
        Me.Btn_aluno.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_aluno.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_aluno.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_aluno.OnHoverImage = Nothing
        Me.Btn_aluno.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_aluno.Radius = 2
        Me.Btn_aluno.Size = New System.Drawing.Size(183, 55)
        Me.Btn_aluno.TabIndex = 6
        Me.Btn_aluno.Text = "ALUNO"
        '
        'Pnl_menu
        '
        Me.Pnl_menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_menu.Controls.Add(Me.Lb_menu_principal)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-9, -5)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(548, 52)
        Me.Pnl_menu.TabIndex = 7
        '
        'Lb_menu_principal
        '
        Me.Lb_menu_principal.AutoSize = True
        Me.Lb_menu_principal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_menu_principal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_menu_principal.Location = New System.Drawing.Point(61, 14)
        Me.Lb_menu_principal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_menu_principal.Name = "Lb_menu_principal"
        Me.Lb_menu_principal.Size = New System.Drawing.Size(217, 32)
        Me.Lb_menu_principal.TabIndex = 4
        Me.Lb_menu_principal.Text = "MENU PRINCIPAL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
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
        Me.Btn_professor.Location = New System.Drawing.Point(176, 154)
        Me.Btn_professor.Name = "Btn_professor"
        Me.Btn_professor.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_professor.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_professor.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_professor.OnHoverImage = Nothing
        Me.Btn_professor.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_professor.Radius = 2
        Me.Btn_professor.Size = New System.Drawing.Size(183, 55)
        Me.Btn_professor.TabIndex = 8
        Me.Btn_professor.Text = "PROFESSOR"
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
        Me.Btn_adm.Location = New System.Drawing.Point(176, 215)
        Me.Btn_adm.Name = "Btn_adm"
        Me.Btn_adm.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_adm.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_adm.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_adm.OnHoverImage = Nothing
        Me.Btn_adm.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_adm.Radius = 2
        Me.Btn_adm.Size = New System.Drawing.Size(183, 55)
        Me.Btn_adm.TabIndex = 9
        Me.Btn_adm.Text = "ADMINISTRADOR"
        '
        'Lb_bem_vindo
        '
        Me.Lb_bem_vindo.AutoSize = True
        Me.Lb_bem_vindo.Font = New System.Drawing.Font("Segoe UI Semibold", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_bem_vindo.Location = New System.Drawing.Point(173, 47)
        Me.Lb_bem_vindo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_bem_vindo.Name = "Lb_bem_vindo"
        Me.Lb_bem_vindo.Size = New System.Drawing.Size(189, 45)
        Me.Lb_bem_vindo.TabIndex = 10
        Me.Lb_bem_vindo.Text = "Bem-Vindo"
        '
        'Frm_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.Lb_bem_vindo)
        Me.Controls.Add(Me.Btn_adm)
        Me.Controls.Add(Me.Btn_professor)
        Me.Controls.Add(Me.Btn_aluno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_inicio"
        Me.Text = "Menu Principal"
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_aluno As Guna.UI.WinForms.GunaButton
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents Lb_menu_principal As Label
    Friend WithEvents Btn_professor As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_adm As Guna.UI.WinForms.GunaButton
    Friend WithEvents Lb_bem_vindo As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
