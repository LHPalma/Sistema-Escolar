<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consultarFaltas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_consultarFaltas))
        Me.dgvFaltas = New System.Windows.Forms.DataGridView()
        Me.cmbDisciplina = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalFaltas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lb_consultar_faltas = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.btnConsultar = New Guna.UI.WinForms.GunaButton()
        CType(Me.dgvFaltas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvFaltas
        '
        Me.dgvFaltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFaltas.Location = New System.Drawing.Point(292, 87)
        Me.dgvFaltas.Name = "dgvFaltas"
        Me.dgvFaltas.Size = New System.Drawing.Size(467, 367)
        Me.dgvFaltas.TabIndex = 0
        '
        'cmbDisciplina
        '
        Me.cmbDisciplina.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDisciplina.FormattingEnabled = True
        Me.cmbDisciplina.Location = New System.Drawing.Point(67, 175)
        Me.cmbDisciplina.Name = "cmbDisciplina"
        Me.cmbDisciplina.Size = New System.Drawing.Size(139, 29)
        Me.cmbDisciplina.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Selecione a disciplina:"
        '
        'txtTotalFaltas
        '
        Me.txtTotalFaltas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFaltas.Location = New System.Drawing.Point(76, 366)
        Me.txtTotalFaltas.Name = "txtTotalFaltas"
        Me.txtTotalFaltas.ReadOnly = True
        Me.txtTotalFaltas.Size = New System.Drawing.Size(108, 29)
        Me.txtTotalFaltas.TabIndex = 5
        Me.txtTotalFaltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total de Faltas na Matéria:"
        '
        'Lb_consultar_faltas
        '
        Me.Lb_consultar_faltas.AutoSize = True
        Me.Lb_consultar_faltas.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_consultar_faltas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_consultar_faltas.Location = New System.Drawing.Point(53, 14)
        Me.Lb_consultar_faltas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_consultar_faltas.Name = "Lb_consultar_faltas"
        Me.Lb_consultar_faltas.Size = New System.Drawing.Size(238, 32)
        Me.Lb_consultar_faltas.TabIndex = 4
        Me.Lb_consultar_faltas.Text = "CONSULTAR FALTAS"
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
        Me.Pnl_menu.Controls.Add(Me.Lb_consultar_faltas)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-1, -5)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(810, 57)
        Me.Pnl_menu.TabIndex = 44
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
        Me.btnConsultar.Location = New System.Drawing.Point(28, 231)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.btnConsultar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnConsultar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnConsultar.OnHoverImage = Nothing
        Me.btnConsultar.OnPressedColor = System.Drawing.Color.Black
        Me.btnConsultar.Radius = 2
        Me.btnConsultar.Size = New System.Drawing.Size(226, 55)
        Me.btnConsultar.TabIndex = 48
        Me.btnConsultar.Text = "CONSULTAR"
        '
        'Frm_consultarFaltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 487)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotalFaltas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbDisciplina)
        Me.Controls.Add(Me.dgvFaltas)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_consultarFaltas"
        Me.Text = "Consultar Faltas"
        CType(Me.dgvFaltas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvFaltas As DataGridView
    Friend WithEvents cmbDisciplina As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalFaltas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Lb_consultar_faltas As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents btnConsultar As Guna.UI.WinForms.GunaButton
End Class
