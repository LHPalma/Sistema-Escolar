<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cadastroNotas
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
        Me.cmbAvaliacao = New System.Windows.Forms.ComboBox()
        Me.cmbAluno = New System.Windows.Forms.ComboBox()
        Me.nudNota = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.dgvNotas = New System.Windows.Forms.DataGridView()
        Me.cmbAvaliacaoConsulta = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.nudNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbAvaliacao
        '
        Me.cmbAvaliacao.FormattingEnabled = True
        Me.cmbAvaliacao.Location = New System.Drawing.Point(51, 123)
        Me.cmbAvaliacao.Name = "cmbAvaliacao"
        Me.cmbAvaliacao.Size = New System.Drawing.Size(242, 21)
        Me.cmbAvaliacao.TabIndex = 0
        '
        'cmbAluno
        '
        Me.cmbAluno.FormattingEnabled = True
        Me.cmbAluno.Location = New System.Drawing.Point(51, 220)
        Me.cmbAluno.Name = "cmbAluno"
        Me.cmbAluno.Size = New System.Drawing.Size(242, 21)
        Me.cmbAluno.TabIndex = 1
        '
        'nudNota
        '
        Me.nudNota.Location = New System.Drawing.Point(51, 309)
        Me.nudNota.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNota.Name = "nudNota"
        Me.nudNota.Size = New System.Drawing.Size(226, 20)
        Me.nudNota.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Avaliação"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Aluno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nota"
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(57, 368)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(277, 59)
        Me.btnCadastrar.TabIndex = 6
        Me.btnCadastrar.Text = "CADASTRAR NOTA"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(376, 368)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(277, 59)
        Me.btnEditar.TabIndex = 7
        Me.btnEditar.Text = "EDITAR NOTA"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'dgvNotas
        '
        Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotas.Location = New System.Drawing.Point(387, 12)
        Me.dgvNotas.Name = "dgvNotas"
        Me.dgvNotas.Size = New System.Drawing.Size(370, 294)
        Me.dgvNotas.TabIndex = 8
        '
        'cmbAvaliacaoConsulta
        '
        Me.cmbAvaliacaoConsulta.FormattingEnabled = True
        Me.cmbAvaliacaoConsulta.Location = New System.Drawing.Point(515, 312)
        Me.cmbAvaliacaoConsulta.Name = "cmbAvaliacaoConsulta"
        Me.cmbAvaliacaoConsulta.Size = New System.Drawing.Size(242, 21)
        Me.cmbAvaliacaoConsulta.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(413, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Filtro por avaliação"
        '
        'Frm_cadastroNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbAvaliacaoConsulta)
        Me.Controls.Add(Me.dgvNotas)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudNota)
        Me.Controls.Add(Me.cmbAluno)
        Me.Controls.Add(Me.cmbAvaliacao)
        Me.Name = "Frm_cadastroNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_cadastroNotas"
        CType(Me.nudNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbAvaliacao As ComboBox
    Friend WithEvents cmbAluno As ComboBox
    Friend WithEvents nudNota As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents dgvNotas As DataGridView
    Friend WithEvents cmbAvaliacaoConsulta As ComboBox
    Friend WithEvents Label4 As Label
End Class
