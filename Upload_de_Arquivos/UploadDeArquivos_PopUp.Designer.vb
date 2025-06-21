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
        Me.Btn_upload = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Pnl_drop = New System.Windows.Forms.Panel()
        Me.Lb_arraste = New System.Windows.Forms.Label()
        Me.Pnl_drop.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_upload
        '
        Me.Btn_upload.Location = New System.Drawing.Point(697, 403)
        Me.Btn_upload.Name = "Btn_upload"
        Me.Btn_upload.Size = New System.Drawing.Size(75, 23)
        Me.Btn_upload.TabIndex = 0
        Me.Btn_upload.Text = "UPLOAD"
        Me.Btn_upload.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Pnl_drop
        '
        Me.Pnl_drop.AllowDrop = True
        Me.Pnl_drop.Controls.Add(Me.Lb_arraste)
        Me.Pnl_drop.Location = New System.Drawing.Point(103, 84)
        Me.Pnl_drop.Name = "Pnl_drop"
        Me.Pnl_drop.Size = New System.Drawing.Size(583, 308)
        Me.Pnl_drop.TabIndex = 1
        '
        'Lb_arraste
        '
        Me.Lb_arraste.AutoSize = True
        Me.Lb_arraste.Location = New System.Drawing.Point(195, 135)
        Me.Lb_arraste.Name = "Lb_arraste"
        Me.Lb_arraste.Size = New System.Drawing.Size(136, 13)
        Me.Lb_arraste.TabIndex = 0
        Me.Lb_arraste.Text = "Arraste os arquivos para cá"
        '
        'UploadDeArquivos_PopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_upload)
        Me.Controls.Add(Me.Pnl_drop)
        Me.Name = "UploadDeArquivos_PopUp"
        Me.Text = "UploadDeArquivos_PopUp"
        Me.Pnl_drop.ResumeLayout(False)
        Me.Pnl_drop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_upload As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Pnl_drop As Panel
    Friend WithEvents Lb_arraste As Label
End Class
