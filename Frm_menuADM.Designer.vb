<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_menuADM
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
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        Me.Btn_gerenciar = New System.Windows.Forms.Button()
        Me.Btn_cadastro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lb_bemvindo
        '
        Me.Lb_bemvindo.AutoSize = True
        Me.Lb_bemvindo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_bemvindo.Location = New System.Drawing.Point(96, 24)
        Me.Lb_bemvindo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_bemvindo.Name = "Lb_bemvindo"
        Me.Lb_bemvindo.Size = New System.Drawing.Size(312, 39)
        Me.Lb_bemvindo.TabIndex = 2
        Me.Lb_bemvindo.Text = "Área Administrativa"
        '
        'Btn_gerenciar
        '
        Me.Btn_gerenciar.Location = New System.Drawing.Point(166, 171)
        Me.Btn_gerenciar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_gerenciar.Name = "Btn_gerenciar"
        Me.Btn_gerenciar.Size = New System.Drawing.Size(175, 55)
        Me.Btn_gerenciar.TabIndex = 3
        Me.Btn_gerenciar.Text = "GERENCIAMENTO DE CONTAS"
        Me.Btn_gerenciar.UseVisualStyleBackColor = True
        '
        'Btn_cadastro
        '
        Me.Btn_cadastro.Location = New System.Drawing.Point(166, 87)
        Me.Btn_cadastro.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_cadastro.Name = "Btn_cadastro"
        Me.Btn_cadastro.Size = New System.Drawing.Size(175, 55)
        Me.Btn_cadastro.TabIndex = 4
        Me.Btn_cadastro.Text = "CADASTRO DE CONTAS"
        Me.Btn_cadastro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Acesso Restrito"
        '
        'Frm_menuADM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_cadastro)
        Me.Controls.Add(Me.Btn_gerenciar)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Name = "Frm_menuADM"
        Me.Text = "Menu de Administrador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_bemvindo As Label
    Friend WithEvents Btn_gerenciar As Button
    Friend WithEvents Btn_cadastro As Button
    Friend WithEvents Label1 As Label
End Class
