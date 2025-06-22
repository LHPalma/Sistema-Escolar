<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroFaltas_FRM
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
        Me.cmbProfDiscTurma = New System.Windows.Forms.ComboBox()
        Me.nudFaltas = New System.Windows.Forms.NumericUpDown()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.cmbAluno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFaltasTotais = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDataFalta = New System.Windows.Forms.DateTimePicker()
        Me.a = New System.Windows.Forms.Label()
        Me.dgvFaltas = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        CType(Me.nudFaltas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFaltas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbProfDiscTurma
        '
        Me.cmbProfDiscTurma.FormattingEnabled = True
        Me.cmbProfDiscTurma.Location = New System.Drawing.Point(55, 128)
        Me.cmbProfDiscTurma.Name = "cmbProfDiscTurma"
        Me.cmbProfDiscTurma.Size = New System.Drawing.Size(150, 21)
        Me.cmbProfDiscTurma.TabIndex = 0
        '
        'nudFaltas
        '
        Me.nudFaltas.Location = New System.Drawing.Point(55, 222)
        Me.nudFaltas.Name = "nudFaltas"
        Me.nudFaltas.Size = New System.Drawing.Size(158, 20)
        Me.nudFaltas.TabIndex = 1
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(169, 388)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(153, 50)
        Me.btnCadastrar.TabIndex = 2
        Me.btnCadastrar.Text = "Lançar Falta"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'cmbAluno
        '
        Me.cmbAluno.FormattingEnabled = True
        Me.cmbAluno.Location = New System.Drawing.Point(55, 176)
        Me.cmbAluno.Name = "cmbAluno"
        Me.cmbAluno.Size = New System.Drawing.Size(150, 21)
        Me.cmbAluno.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Professor - Disciplina - Turma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Aluno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Faltas"
        '
        'txtFaltasTotais
        '
        Me.txtFaltasTotais.Location = New System.Drawing.Point(264, 177)
        Me.txtFaltasTotais.Name = "txtFaltasTotais"
        Me.txtFaltasTotais.ReadOnly = True
        Me.txtFaltasTotais.Size = New System.Drawing.Size(181, 20)
        Me.txtFaltasTotais.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(261, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Quantidade Total de Faltas"
        '
        'dtpDataFalta
        '
        Me.dtpDataFalta.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataFalta.Location = New System.Drawing.Point(116, 325)
        Me.dtpDataFalta.Name = "dtpDataFalta"
        Me.dtpDataFalta.Size = New System.Drawing.Size(282, 29)
        Me.dtpDataFalta.TabIndex = 9
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Location = New System.Drawing.Point(113, 309)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(64, 13)
        Me.a.TabIndex = 10
        Me.a.Text = "Dia da Falta"
        '
        'dgvFaltas
        '
        Me.dgvFaltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFaltas.Location = New System.Drawing.Point(486, 29)
        Me.dgvFaltas.Name = "dgvFaltas"
        Me.dgvFaltas.Size = New System.Drawing.Size(356, 338)
        Me.dgvFaltas.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(483, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Faltas do Aluno:"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(563, 373)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(224, 50)
        Me.btnPesquisar.TabIndex = 13
        Me.btnPesquisar.Text = "Consultar Faltas do Aluno"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'Frm_cadastroFaltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 450)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvFaltas)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.dtpDataFalta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFaltasTotais)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAluno)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.nudFaltas)
        Me.Controls.Add(Me.cmbProfDiscTurma)
        Me.Name = "Frm_cadastroFaltas"
        Me.Text = "Frm_cadastroFaltas"
        CType(Me.nudFaltas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFaltas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbProfDiscTurma As ComboBox
    Friend WithEvents nudFaltas As NumericUpDown
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents cmbAluno As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFaltasTotais As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDataFalta As DateTimePicker
    Friend WithEvents a As Label
    Friend WithEvents dgvFaltas As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPesquisar As Button
End Class
