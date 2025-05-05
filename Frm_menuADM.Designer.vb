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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_menuADM))
        Me.Lb_bemvindo = New System.Windows.Forms.Label()
        Me.btn_gerenciar = New System.Windows.Forms.Button()
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_voltar = New System.Windows.Forms.Button()
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
        'btn_gerenciar
        '
        Me.btn_gerenciar.Location = New System.Drawing.Point(166, 171)
        Me.btn_gerenciar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gerenciar.Name = "btn_gerenciar"
        Me.btn_gerenciar.Size = New System.Drawing.Size(175, 55)
        Me.btn_gerenciar.TabIndex = 3
        Me.btn_gerenciar.Text = "GERENCIAMENTO DE CONTAS"
        Me.btn_gerenciar.UseVisualStyleBackColor = True
        '
        'btn_cadastro
        '
        Me.btn_cadastro.Location = New System.Drawing.Point(166, 87)
        Me.btn_cadastro.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(175, 55)
        Me.btn_cadastro.TabIndex = 4
        Me.btn_cadastro.Text = "CADASTRO DE CONTAS"
        Me.btn_cadastro.UseVisualStyleBackColor = True
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
        'Btn_voltar
        '
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_voltar.Location = New System.Drawing.Point(430, 253)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 27
        Me.Btn_voltar.Text = "Voltar"
        Me.Btn_voltar.UseVisualStyleBackColor = True
        '
        'Frm_menuADM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cadastro)
        Me.Controls.Add(Me.btn_gerenciar)
        Me.Controls.Add(Me.Lb_bemvindo)
        Me.Name = "Frm_menuADM"
        Me.Text = "Menu de Administrador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lb_bemvindo As Label
    Friend WithEvents btn_gerenciar As Button
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_voltar As Button
End Class
