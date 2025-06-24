<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consultarNotas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_consultarNotas))
        Me.dgvNotas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDisciplina = New System.Windows.Forms.ComboBox()
        Me.txtMedia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lb_consultar_notas = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.btnConsultar = New Guna.UI.WinForms.GunaButton()
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvNotas
        '
        Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotas.Location = New System.Drawing.Point(374, 87)
        Me.dgvNotas.Name = "dgvNotas"
        Me.dgvNotas.Size = New System.Drawing.Size(389, 372)
        Me.dgvNotas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selecione a disciplina:"
        '
        'cmbDisciplina
        '
        Me.cmbDisciplina.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDisciplina.FormattingEnabled = True
        Me.cmbDisciplina.Location = New System.Drawing.Point(80, 174)
        Me.cmbDisciplina.Name = "cmbDisciplina"
        Me.cmbDisciplina.Size = New System.Drawing.Size(177, 29)
        Me.cmbDisciplina.TabIndex = 2
        '
        'txtMedia
        '
        Me.txtMedia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedia.Location = New System.Drawing.Point(80, 342)
        Me.txtMedia.Name = "txtMedia"
        Me.txtMedia.ReadOnly = True
        Me.txtMedia.Size = New System.Drawing.Size(177, 29)
        Me.txtMedia.TabIndex = 3
        Me.txtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Média:"
        '
        'Lb_consultar_notas
        '
        Me.Lb_consultar_notas.AutoSize = True
        Me.Lb_consultar_notas.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_consultar_notas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_consultar_notas.Location = New System.Drawing.Point(53, 14)
        Me.Lb_consultar_notas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_consultar_notas.Name = "Lb_consultar_notas"
        Me.Lb_consultar_notas.Size = New System.Drawing.Size(236, 32)
        Me.Lb_consultar_notas.TabIndex = 4
        Me.Lb_consultar_notas.Text = "CONSULTAR NOTAS"
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
        Me.Pnl_menu.Controls.Add(Me.Lb_consultar_notas)
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
        Me.btnConsultar.Location = New System.Drawing.Point(58, 224)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.btnConsultar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnConsultar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnConsultar.OnHoverImage = Nothing
        Me.btnConsultar.OnPressedColor = System.Drawing.Color.Black
        Me.btnConsultar.Radius = 2
        Me.btnConsultar.Size = New System.Drawing.Size(226, 55)
        Me.btnConsultar.TabIndex = 47
        Me.btnConsultar.Text = "CONSULTAR"
        '
        'Frm_consultarNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 487)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMedia)
        Me.Controls.Add(Me.cmbDisciplina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvNotas)
        Me.Name = "Frm_consultarNotas"
        Me.Text = "Consultar Notas"
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvNotas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbDisciplina As ComboBox
    Friend WithEvents txtMedia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Lb_consultar_notas As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
    Friend WithEvents btnConsultar As Guna.UI.WinForms.GunaButton
End Class
