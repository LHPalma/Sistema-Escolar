<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroNotas_FRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroNotas_FRM))
        Me.cmbAvaliacao = New System.Windows.Forms.ComboBox()
        Me.cmbAluno = New System.Windows.Forms.ComboBox()
        Me.nudNota = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvNotas = New System.Windows.Forms.DataGridView()
        Me.cmbAvaliacaoConsulta = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lb_lancar_notas = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.btnCadastrar = New Guna.UI.WinForms.GunaButton()
        Me.btnEditar = New Guna.UI.WinForms.GunaButton()
        CType(Me.nudNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbAvaliacao
        '
        Me.cmbAvaliacao.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAvaliacao.FormattingEnabled = True
        Me.cmbAvaliacao.Location = New System.Drawing.Point(62, 97)
        Me.cmbAvaliacao.Name = "cmbAvaliacao"
        Me.cmbAvaliacao.Size = New System.Drawing.Size(242, 29)
        Me.cmbAvaliacao.TabIndex = 0
        '
        'cmbAluno
        '
        Me.cmbAluno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAluno.FormattingEnabled = True
        Me.cmbAluno.Location = New System.Drawing.Point(62, 194)
        Me.cmbAluno.Name = "cmbAluno"
        Me.cmbAluno.Size = New System.Drawing.Size(242, 29)
        Me.cmbAluno.TabIndex = 1
        '
        'nudNota
        '
        Me.nudNota.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNota.Location = New System.Drawing.Point(62, 283)
        Me.nudNota.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNota.Name = "nudNota"
        Me.nudNota.Size = New System.Drawing.Size(242, 29)
        Me.nudNota.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Avaliação"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Aluno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nota"
        '
        'dgvNotas
        '
        Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotas.Location = New System.Drawing.Point(390, 65)
        Me.dgvNotas.Name = "dgvNotas"
        Me.dgvNotas.Size = New System.Drawing.Size(370, 294)
        Me.dgvNotas.TabIndex = 8
        '
        'cmbAvaliacaoConsulta
        '
        Me.cmbAvaliacaoConsulta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAvaliacaoConsulta.FormattingEnabled = True
        Me.cmbAvaliacaoConsulta.Location = New System.Drawing.Point(518, 365)
        Me.cmbAvaliacaoConsulta.Name = "cmbAvaliacaoConsulta"
        Me.cmbAvaliacaoConsulta.Size = New System.Drawing.Size(242, 29)
        Me.cmbAvaliacaoConsulta.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(407, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Filtro por avaliação"
        '
        'Lb_lancar_notas
        '
        Me.Lb_lancar_notas.AutoSize = True
        Me.Lb_lancar_notas.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_lancar_notas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_lancar_notas.Location = New System.Drawing.Point(53, 14)
        Me.Lb_lancar_notas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_lancar_notas.Name = "Lb_lancar_notas"
        Me.Lb_lancar_notas.Size = New System.Drawing.Size(304, 32)
        Me.Lb_lancar_notas.TabIndex = 4
        Me.Lb_lancar_notas.Text = "LANÇAMENTO DE NOTAS"
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
        Me.Pnl_menu.Controls.Add(Me.Lb_lancar_notas)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-1, -5)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(810, 57)
        Me.Pnl_menu.TabIndex = 46
        '
        'btnCadastrar
        '
        Me.btnCadastrar.AnimationHoverSpeed = 0.07!
        Me.btnCadastrar.AnimationSpeed = 0.03!
        Me.btnCadastrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCadastrar.BaseColor = System.Drawing.Color.SteelBlue
        Me.btnCadastrar.BorderColor = System.Drawing.Color.Black
        Me.btnCadastrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCadastrar.FocusedColor = System.Drawing.Color.Empty
        Me.btnCadastrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.ForeColor = System.Drawing.Color.White
        Me.btnCadastrar.Image = CType(resources.GetObject("btnCadastrar.Image"), System.Drawing.Image)
        Me.btnCadastrar.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnCadastrar.Location = New System.Drawing.Point(70, 339)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.btnCadastrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCadastrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCadastrar.OnHoverImage = Nothing
        Me.btnCadastrar.OnPressedColor = System.Drawing.Color.Black
        Me.btnCadastrar.Radius = 2
        Me.btnCadastrar.Size = New System.Drawing.Size(226, 55)
        Me.btnCadastrar.TabIndex = 49
        Me.btnCadastrar.Text = "LANÇAR NOTA"
        '
        'btnEditar
        '
        Me.btnEditar.AnimationHoverSpeed = 0.07!
        Me.btnEditar.AnimationSpeed = 0.03!
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BaseColor = System.Drawing.Color.SteelBlue
        Me.btnEditar.BorderColor = System.Drawing.Color.Black
        Me.btnEditar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEditar.FocusedColor = System.Drawing.Color.Empty
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = Nothing
        Me.btnEditar.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnEditar.Location = New System.Drawing.Point(465, 420)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.btnEditar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEditar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEditar.OnHoverImage = Nothing
        Me.btnEditar.OnPressedColor = System.Drawing.Color.Black
        Me.btnEditar.Radius = 2
        Me.btnEditar.Size = New System.Drawing.Size(226, 55)
        Me.btnEditar.TabIndex = 50
        Me.btnEditar.Text = "EDITAR NOTA"
        Me.btnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CadastroNotas_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 487)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbAvaliacaoConsulta)
        Me.Controls.Add(Me.dgvNotas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudNota)
        Me.Controls.Add(Me.cmbAluno)
        Me.Controls.Add(Me.cmbAvaliacao)
        Me.Name = "CadastroNotas_FRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lançamento de Notas"
        CType(Me.nudNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbAvaliacao As ComboBox
    Friend WithEvents cmbAluno As ComboBox
    Friend WithEvents nudNota As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvNotas As DataGridView
    Friend WithEvents cmbAvaliacaoConsulta As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Lb_lancar_notas As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents btnCadastrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnEditar As Guna.UI.WinForms.GunaButton
End Class
