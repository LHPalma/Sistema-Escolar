<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroFaltas_FRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroFaltas_FRM))
        Me.cmbProfDiscTurma = New System.Windows.Forms.ComboBox()
        Me.nudFaltas = New System.Windows.Forms.NumericUpDown()
        Me.cmbAluno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFaltasTotais = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDataFalta = New System.Windows.Forms.DateTimePicker()
        Me.a = New System.Windows.Forms.Label()
        Me.dgvFaltas = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lb_lancar_faltas = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.btnCadastrar = New Guna.UI.WinForms.GunaButton()
        Me.btnPesquisar = New Guna.UI.WinForms.GunaButton()
        CType(Me.nudFaltas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFaltas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbProfDiscTurma
        '
        Me.cmbProfDiscTurma.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProfDiscTurma.FormattingEnabled = True
        Me.cmbProfDiscTurma.Location = New System.Drawing.Point(26, 98)
        Me.cmbProfDiscTurma.Name = "cmbProfDiscTurma"
        Me.cmbProfDiscTurma.Size = New System.Drawing.Size(158, 29)
        Me.cmbProfDiscTurma.TabIndex = 0
        '
        'nudFaltas
        '
        Me.nudFaltas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudFaltas.Location = New System.Drawing.Point(26, 230)
        Me.nudFaltas.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudFaltas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFaltas.Name = "nudFaltas"
        Me.nudFaltas.Size = New System.Drawing.Size(158, 29)
        Me.nudFaltas.TabIndex = 2
        Me.nudFaltas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbAluno
        '
        Me.cmbAluno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAluno.FormattingEnabled = True
        Me.cmbAluno.Location = New System.Drawing.Point(26, 165)
        Me.cmbAluno.Name = "cmbAluno"
        Me.cmbAluno.Size = New System.Drawing.Size(158, 29)
        Me.cmbAluno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Professor - Disciplina - Turma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Aluno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Faltas"
        '
        'txtFaltasTotais
        '
        Me.txtFaltasTotais.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaltasTotais.Location = New System.Drawing.Point(239, 165)
        Me.txtFaltasTotais.Name = "txtFaltasTotais"
        Me.txtFaltasTotais.ReadOnly = True
        Me.txtFaltasTotais.Size = New System.Drawing.Size(158, 29)
        Me.txtFaltasTotais.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(236, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Quantidade Total de Faltas"
        '
        'dtpDataFalta
        '
        Me.dtpDataFalta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataFalta.Location = New System.Drawing.Point(26, 298)
        Me.dtpDataFalta.Name = "dtpDataFalta"
        Me.dtpDataFalta.Size = New System.Drawing.Size(371, 29)
        Me.dtpDataFalta.TabIndex = 3
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.Location = New System.Drawing.Point(23, 282)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(89, 13)
        Me.a.TabIndex = 10
        Me.a.Text = "Dia da Ausência"
        '
        'dgvFaltas
        '
        Me.dgvFaltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFaltas.Location = New System.Drawing.Point(432, 81)
        Me.dgvFaltas.Name = "dgvFaltas"
        Me.dgvFaltas.Size = New System.Drawing.Size(356, 338)
        Me.dgvFaltas.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(429, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Faltas do Aluno:"
        '
        'Lb_lancar_faltas
        '
        Me.Lb_lancar_faltas.AutoSize = True
        Me.Lb_lancar_faltas.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_lancar_faltas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_lancar_faltas.Location = New System.Drawing.Point(53, 14)
        Me.Lb_lancar_faltas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_lancar_faltas.Name = "Lb_lancar_faltas"
        Me.Lb_lancar_faltas.Size = New System.Drawing.Size(305, 32)
        Me.Lb_lancar_faltas.TabIndex = 4
        Me.Lb_lancar_faltas.Text = "CONTROLE DE PRESENÇA"
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
        Me.Pnl_menu.Controls.Add(Me.Lb_lancar_faltas)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-1, -5)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(810, 57)
        Me.Pnl_menu.TabIndex = 45
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
        Me.btnCadastrar.Location = New System.Drawing.Point(85, 364)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.btnCadastrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCadastrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCadastrar.OnHoverImage = Nothing
        Me.btnCadastrar.OnPressedColor = System.Drawing.Color.Black
        Me.btnCadastrar.Radius = 2
        Me.btnCadastrar.Size = New System.Drawing.Size(226, 55)
        Me.btnCadastrar.TabIndex = 4
        Me.btnCadastrar.Text = "LANÇAR FALTA"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.AnimationHoverSpeed = 0.07!
        Me.btnPesquisar.AnimationSpeed = 0.03!
        Me.btnPesquisar.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisar.BaseColor = System.Drawing.Color.SteelBlue
        Me.btnPesquisar.BorderColor = System.Drawing.Color.Black
        Me.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPesquisar.FocusedColor = System.Drawing.Color.Empty
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisar.ForeColor = System.Drawing.Color.White
        Me.btnPesquisar.Image = Nothing
        Me.btnPesquisar.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnPesquisar.Location = New System.Drawing.Point(500, 425)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.btnPesquisar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPesquisar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPesquisar.OnHoverImage = Nothing
        Me.btnPesquisar.OnPressedColor = System.Drawing.Color.Black
        Me.btnPesquisar.Radius = 2
        Me.btnPesquisar.Size = New System.Drawing.Size(226, 55)
        Me.btnPesquisar.TabIndex = 5
        Me.btnPesquisar.Text = "CONSULTAR FALTAS DO ALUNO"
        '
        'CadastroFaltas_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 487)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvFaltas)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.dtpDataFalta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFaltasTotais)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAluno)
        Me.Controls.Add(Me.nudFaltas)
        Me.Controls.Add(Me.cmbProfDiscTurma)
        Me.Name = "CadastroFaltas_FRM"
        Me.Text = "Controle de Presença"
        CType(Me.nudFaltas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFaltas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbProfDiscTurma As ComboBox
    Friend WithEvents nudFaltas As NumericUpDown
    Friend WithEvents cmbAluno As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFaltasTotais As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDataFalta As DateTimePicker
    Friend WithEvents a As Label
    Friend WithEvents dgvFaltas As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Lb_lancar_faltas As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents btnCadastrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnPesquisar As Guna.UI.WinForms.GunaButton
End Class
