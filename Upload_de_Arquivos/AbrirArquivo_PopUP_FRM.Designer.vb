<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbrirArquivo_PopUP_FRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AbrirArquivo_PopUP_FRM))
        Me.Dgv_arquivos = New System.Windows.Forms.DataGridView()
        Me.Lb_abrir = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        CType(Me.Dgv_arquivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_arquivos
        '
        Me.Dgv_arquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_arquivos.Location = New System.Drawing.Point(46, 93)
        Me.Dgv_arquivos.Name = "Dgv_arquivos"
        Me.Dgv_arquivos.Size = New System.Drawing.Size(706, 351)
        Me.Dgv_arquivos.TabIndex = 0
        '
        'Lb_abrir
        '
        Me.Lb_abrir.AutoSize = True
        Me.Lb_abrir.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_abrir.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_abrir.Location = New System.Drawing.Point(61, 14)
        Me.Lb_abrir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_abrir.Name = "Lb_abrir"
        Me.Lb_abrir.Size = New System.Drawing.Size(203, 32)
        Me.Lb_abrir.TabIndex = 4
        Me.Lb_abrir.Text = "ABRIR ARQUIVO"
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
        'Pnl_menu
        '
        Me.Pnl_menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_menu.Controls.Add(Me.Lb_abrir)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-8, -5)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(820, 52)
        Me.Pnl_menu.TabIndex = 103
        '
        'AbrirArquivo_PopUP_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 487)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Dgv_arquivos)
        Me.Name = "AbrirArquivo_PopUP_FRM"
        Me.Text = "Abrir Arquivo"
        CType(Me.Dgv_arquivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Dgv_arquivos As DataGridView
    Friend WithEvents Lb_abrir As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
End Class
