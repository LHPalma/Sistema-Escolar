<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consultarAvaliacoes
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.cmbDisciplina = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvAvaliacoes = New System.Windows.Forms.DataGridView()
        CType(Me.dgvAvaliacoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Avaliacoes:"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(106, 193)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(131, 40)
        Me.btnConsultar.TabIndex = 11
        Me.btnConsultar.Text = "Consultar Avaliacoes"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'cmbDisciplina
        '
        Me.cmbDisciplina.FormattingEnabled = True
        Me.cmbDisciplina.Location = New System.Drawing.Point(86, 152)
        Me.cmbDisciplina.Name = "cmbDisciplina"
        Me.cmbDisciplina.Size = New System.Drawing.Size(177, 21)
        Me.cmbDisciplina.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Selecione a disciplina:"
        '
        'dgvAvaliacoes
        '
        Me.dgvAvaliacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvaliacoes.Location = New System.Drawing.Point(353, 47)
        Me.dgvAvaliacoes.Name = "dgvAvaliacoes"
        Me.dgvAvaliacoes.Size = New System.Drawing.Size(366, 372)
        Me.dgvAvaliacoes.TabIndex = 7
        '
        'Frm_consultarAvaliacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.cmbDisciplina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvAvaliacoes)
        Me.Name = "Frm_consultarAvaliacoes"
        Me.Text = "Frm_consultarAvaliacoes"
        CType(Me.dgvAvaliacoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnConsultar As Button
    Friend WithEvents cmbDisciplina As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvAvaliacoes As DataGridView
End Class
