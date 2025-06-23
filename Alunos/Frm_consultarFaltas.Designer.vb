<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consultarFaltas
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
        Me.dgvFaltas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbDisciplina = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtTotalFaltas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvFaltas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFaltas
        '
        Me.dgvFaltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFaltas.Location = New System.Drawing.Point(204, 54)
        Me.dgvFaltas.Name = "dgvFaltas"
        Me.dgvFaltas.Size = New System.Drawing.Size(467, 384)
        Me.dgvFaltas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Faltas:"
        '
        'cmbDisciplina
        '
        Me.cmbDisciplina.FormattingEnabled = True
        Me.cmbDisciplina.Location = New System.Drawing.Point(39, 145)
        Me.cmbDisciplina.Name = "cmbDisciplina"
        Me.cmbDisciplina.Size = New System.Drawing.Size(111, 21)
        Me.cmbDisciplina.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Selecione a disciplina:"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(27, 183)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(137, 30)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar Faltas"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtTotalFaltas
        '
        Me.txtTotalFaltas.Location = New System.Drawing.Point(42, 266)
        Me.txtTotalFaltas.Name = "txtTotalFaltas"
        Me.txtTotalFaltas.ReadOnly = True
        Me.txtTotalFaltas.Size = New System.Drawing.Size(108, 20)
        Me.txtTotalFaltas.TabIndex = 5
        Me.txtTotalFaltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total de Faltas na Matéria:"
        '
        'Frm_consultarFaltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotalFaltas)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbDisciplina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvFaltas)
        Me.Name = "Frm_consultarFaltas"
        Me.Text = "Frm_consultarFaltas"
        CType(Me.dgvFaltas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvFaltas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbDisciplina As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConsultar As Button
    Friend WithEvents txtTotalFaltas As TextBox
    Friend WithEvents Label3 As Label
End Class
