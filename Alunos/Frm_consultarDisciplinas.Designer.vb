<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consultarDisciplinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_consultarDisciplinas))
        Me.dgvMaterias = New System.Windows.Forms.DataGridView()
        Me.Lb_consultar_materias = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMaterias
        '
        Me.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterias.Location = New System.Drawing.Point(139, 71)
        Me.dgvMaterias.Name = "dgvMaterias"
        Me.dgvMaterias.Size = New System.Drawing.Size(489, 389)
        Me.dgvMaterias.TabIndex = 0
        '
        'Lb_consultar_materias
        '
        Me.Lb_consultar_materias.AutoSize = True
        Me.Lb_consultar_materias.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_consultar_materias.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_consultar_materias.Location = New System.Drawing.Point(53, 14)
        Me.Lb_consultar_materias.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_consultar_materias.Name = "Lb_consultar_materias"
        Me.Lb_consultar_materias.Size = New System.Drawing.Size(304, 32)
        Me.Lb_consultar_materias.TabIndex = 4
        Me.Lb_consultar_materias.Text = "CONSULTAR DISCIPLINAS"
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
        Me.Pnl_menu.Controls.Add(Me.Lb_consultar_materias)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-1, -5)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(810, 57)
        Me.Pnl_menu.TabIndex = 44
        '
        'Frm_consultarDisciplinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 487)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.dgvMaterias)
        Me.Name = "Frm_consultarDisciplinas"
        Me.Text = "Consultar Disciplinas"
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvMaterias As DataGridView
    Friend WithEvents Lb_consultar_materias As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
End Class
