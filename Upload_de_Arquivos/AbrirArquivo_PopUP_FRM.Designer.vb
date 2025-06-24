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
        Me.Dgv_arquivos = New System.Windows.Forms.DataGridView()
        CType(Me.Dgv_arquivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_arquivos
        '
        Me.Dgv_arquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_arquivos.Location = New System.Drawing.Point(31, 53)
        Me.Dgv_arquivos.Name = "Dgv_arquivos"
        Me.Dgv_arquivos.Size = New System.Drawing.Size(717, 238)
        Me.Dgv_arquivos.TabIndex = 0
        '
        'AbrirArquivo_PopUP_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Dgv_arquivos)
        Me.Name = "AbrirArquivo_PopUP_FRM"
        Me.Text = "AbriArquivo_PopUP_FRM"
        CType(Me.Dgv_arquivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Dgv_arquivos As DataGridView
End Class
