<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadDeArquivos_PopUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UploadDeArquivos_PopUp))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Pnl_drop = New System.Windows.Forms.Panel()
        Me.Lb_arraste = New System.Windows.Forms.Label()
        Me.Btn_upload = New Guna.UI.WinForms.GunaButton()
        Me.Lb_upload = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pnl_menu = New System.Windows.Forms.Panel()
        Me.Pnl_drop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Pnl_drop
        '
        Me.Pnl_drop.AllowDrop = True
        Me.Pnl_drop.Controls.Add(Me.Lb_arraste)
        Me.Pnl_drop.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pnl_drop.Location = New System.Drawing.Point(105, 101)
        Me.Pnl_drop.Name = "Pnl_drop"
        Me.Pnl_drop.Size = New System.Drawing.Size(583, 308)
        Me.Pnl_drop.TabIndex = 1
        '
        'Lb_arraste
        '
        Me.Lb_arraste.AutoSize = True
        Me.Lb_arraste.Location = New System.Drawing.Point(195, 135)
        Me.Lb_arraste.Name = "Lb_arraste"
        Me.Lb_arraste.Size = New System.Drawing.Size(214, 21)
        Me.Lb_arraste.TabIndex = 0
        Me.Lb_arraste.Text = "Arraste os arquivos para cá"
        '
        'Btn_upload
        '
        Me.Btn_upload.AnimationHoverSpeed = 0.07!
        Me.Btn_upload.AnimationSpeed = 0.03!
        Me.Btn_upload.BackColor = System.Drawing.Color.Transparent
        Me.Btn_upload.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_upload.BorderColor = System.Drawing.Color.Black
        Me.Btn_upload.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_upload.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_upload.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_upload.ForeColor = System.Drawing.Color.White
        Me.Btn_upload.Image = CType(resources.GetObject("Btn_upload.Image"), System.Drawing.Image)
        Me.Btn_upload.ImageSize = New System.Drawing.Size(22, 22)
        Me.Btn_upload.Location = New System.Drawing.Point(697, 448)
        Me.Btn_upload.Name = "Btn_upload"
        Me.Btn_upload.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_upload.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_upload.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_upload.OnHoverImage = Nothing
        Me.Btn_upload.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_upload.Radius = 2
        Me.Btn_upload.Size = New System.Drawing.Size(91, 27)
        Me.Btn_upload.TabIndex = 101
        Me.Btn_upload.Text = "UPLOAD"
        Me.Btn_upload.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lb_upload
        '
        Me.Lb_upload.AutoSize = True
        Me.Lb_upload.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_upload.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lb_upload.Location = New System.Drawing.Point(61, 14)
        Me.Lb_upload.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_upload.Name = "Lb_upload"
        Me.Lb_upload.Size = New System.Drawing.Size(278, 32)
        Me.Lb_upload.TabIndex = 4
        Me.Lb_upload.Text = "UPLOAD DE ARQUIVOS"
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
        Me.Pnl_menu.Controls.Add(Me.Lb_upload)
        Me.Pnl_menu.Controls.Add(Me.PictureBox1)
        Me.Pnl_menu.Location = New System.Drawing.Point(-8, -5)
        Me.Pnl_menu.Name = "Pnl_menu"
        Me.Pnl_menu.Size = New System.Drawing.Size(820, 52)
        Me.Pnl_menu.TabIndex = 102
        '
        'UploadDeArquivos_PopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 487)
        Me.Controls.Add(Me.Pnl_menu)
        Me.Controls.Add(Me.Btn_upload)
        Me.Controls.Add(Me.Pnl_drop)
        Me.Name = "UploadDeArquivos_PopUp"
        Me.Text = "Upload de Arquivos"
        Me.Pnl_drop.ResumeLayout(False)
        Me.Pnl_drop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_menu.ResumeLayout(False)
        Me.Pnl_menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Pnl_drop As Panel
    Friend WithEvents Lb_arraste As Label
    Friend WithEvents Btn_upload As Guna.UI.WinForms.GunaButton
    Friend WithEvents Lb_upload As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pnl_menu As Panel
End Class
