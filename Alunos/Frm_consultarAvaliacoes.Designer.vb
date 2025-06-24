<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consultarAvaliacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_consultarAvaliacoes))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDisciplina = New System.Windows.Forms.ComboBox()
        Me.Lb_selecione = New System.Windows.Forms.Label()
        Me.dgvAvaliacoes = New System.Windows.Forms.DataGridView()
        Me.Lb_consultar_avaliacoes = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.btnConsultar = New Guna.UI.WinForms.GunaButton()
        CType(Me.dgvAvaliacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Avaliacoes:"
        '
        'cmbDisciplina
        '
        Me.cmbDisciplina.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDisciplina.FormattingEnabled = True
        Me.cmbDisciplina.Location = New System.Drawing.Point(91, 213)
        Me.cmbDisciplina.Name = "cmbDisciplina"
        Me.cmbDisciplina.Size = New System.Drawing.Size(177, 29)
        Me.cmbDisciplina.TabIndex = 9
        '
        'Lb_selecione
        '
        Me.Lb_selecione.AutoSize = True
        Me.Lb_selecione.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_selecione.Location = New System.Drawing.Point(88, 197)
        Me.Lb_selecione.Name = "Lb_selecione"
        Me.Lb_selecione.Size = New System.Drawing.Size(120, 13)
        Me.Lb_selecione.TabIndex = 8
        Me.Lb_selecione.Text = "Selecione a disciplina:"
        '
        'dgvAvaliacoes
        '
        Me.dgvAvaliacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvaliacoes.Location = New System.Drawing.Point(399, 83)
        Me.dgvAvaliacoes.Name = "dgvAvaliacoes"
        Me.dgvAvaliacoes.Size = New System.Drawing.Size(366, 372)
        Me.dgvAvaliacoes.TabIndex = 7
        '
        'Lb_consultar_avaliacoes
        '
        Me.Lb_consultar_avaliacoes.AutoSize = True
        Me.Lb_consultar_avaliacoes.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_consultar_avaliacoes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_consultar_avaliacoes.Location = New System.Drawing.Point(53, 14)
        Me.Lb_consultar_avaliacoes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_consultar_avaliacoes.Name = "Lb_consultar_avaliacoes"
        Me.Lb_consultar_avaliacoes.Size = New System.Drawing.Size(302, 32)
        Me.Lb_consultar_avaliacoes.TabIndex = 4
        Me.Lb_consultar_avaliacoes.Text = "CONSULTAR AVALIAÇÕES"
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
        Me.Pnl_menu.Controls.Add(Me.Lb_consultar_avaliacoes)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-1, -5)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(810, 57)
        Me.Pnl_menu.TabIndex = 43
        '
        'btnConsultar
        '
        Me.btnConsultar.AnimationHoverSpeed = 0.07!
        Me.btnConsultar.AnimationSpeed = 0.03!
        Me.btnConsultar.BackColor = System.Drawing.Color.Transparent
        Me.btnConsultar.BaseColor = System.Drawing.Color.SteelBlue
        Me.btnConsultar.BorderColor = System.Drawing.Color.Black
        Me.btnConsultar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnConsultar.FocusedColor = System.Drawing.Color.Empty
        Me.btnConsultar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnConsultar.Location = New System.Drawing.Point(69, 267)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.btnConsultar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnConsultar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnConsultar.OnHoverImage = Nothing
        Me.btnConsultar.OnPressedColor = System.Drawing.Color.Black
        Me.btnConsultar.Radius = 2
        Me.btnConsultar.Size = New System.Drawing.Size(226, 55)
        Me.btnConsultar.TabIndex = 46
        Me.btnConsultar.Text = "CONSULTAR"
        '
        'Frm_consultarAvaliacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 487)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbDisciplina)
        Me.Controls.Add(Me.Lb_selecione)
        Me.Controls.Add(Me.dgvAvaliacoes)
        Me.Name = "Frm_consultarAvaliacoes"
        Me.Text = "Consultar Avaliações"
        CType(Me.dgvAvaliacoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents cmbDisciplina As ComboBox
    Friend WithEvents Lb_selecione As Label
    Friend WithEvents dgvAvaliacoes As DataGridView
    Friend WithEvents Lb_consultar_avaliacoes As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents btnConsultar As Guna.UI.WinForms.GunaButton
End Class
