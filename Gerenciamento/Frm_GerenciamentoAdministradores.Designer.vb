<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GerenciamentoAdministradores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_GerenciamentoAdministradores))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Txt_buscar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Cmb_campo = New System.Windows.Forms.ToolStripComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Btn_voltar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_editar = New Guna.UI.WinForms.GunaButton()
        Me.Btn_gravar = New Guna.UI.WinForms.GunaButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.Txt_buscar, Me.ToolStripLabel2, Me.Cmb_campo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 27)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(215, 24)
        Me.ToolStripLabel1.Text = "Digite um parâmetro de pesquisa"
        Me.ToolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Txt_buscar
        '
        Me.Txt_buscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Txt_buscar.Name = "Txt_buscar"
        Me.Txt_buscar.Size = New System.Drawing.Size(100, 27)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(123, 24)
        Me.ToolStripLabel2.Text = "Selecione um Campo"
        '
        'Cmb_campo
        '
        Me.Cmb_campo.Items.AddRange(New Object() {"Nome", "RA"})
        Me.Cmb_campo.Name = "Cmb_campo"
        Me.Cmb_campo.Size = New System.Drawing.Size(100, 27)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "E-mail"
        '
        'Txt_email
        '
        Me.Txt_email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_email.Location = New System.Drawing.Point(32, 105)
        Me.Txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(338, 29)
        Me.Txt_email.TabIndex = 83
        '
        'Txt_nome
        '
        Me.Txt_nome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nome.Location = New System.Drawing.Point(33, 49)
        Me.Txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(492, 29)
        Me.Txt_nome.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Nome"
        '
        'Dgv_dados
        '
        Me.Dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_dados.Location = New System.Drawing.Point(33, 172)
        Me.Dgv_dados.Name = "Dgv_dados"
        Me.Dgv_dados.Size = New System.Drawing.Size(739, 174)
        Me.Dgv_dados.TabIndex = 80
        '
        'Btn_voltar
        '
        Me.Btn_voltar.AnimationHoverSpeed = 0.07!
        Me.Btn_voltar.AnimationSpeed = 0.03!
        Me.Btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_voltar.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_voltar.BorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_voltar.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_voltar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_voltar.ForeColor = System.Drawing.Color.White
        Me.Btn_voltar.Image = CType(resources.GetObject("Btn_voltar.Image"), System.Drawing.Image)
        Me.Btn_voltar.ImageSize = New System.Drawing.Size(22, 22)
        Me.Btn_voltar.Location = New System.Drawing.Point(680, 49)
        Me.Btn_voltar.Name = "Btn_voltar"
        Me.Btn_voltar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_voltar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_voltar.OnHoverImage = Nothing
        Me.Btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_voltar.Radius = 2
        Me.Btn_voltar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_voltar.TabIndex = 87
        Me.Btn_voltar.Text = "Voltar"
        '
        'Btn_editar
        '
        Me.Btn_editar.AnimationHoverSpeed = 0.07!
        Me.Btn_editar.AnimationSpeed = 0.03!
        Me.Btn_editar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_editar.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_editar.BorderColor = System.Drawing.Color.Black
        Me.Btn_editar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_editar.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_editar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_editar.ForeColor = System.Drawing.Color.White
        Me.Btn_editar.Image = CType(resources.GetObject("Btn_editar.Image"), System.Drawing.Image)
        Me.Btn_editar.ImageSize = New System.Drawing.Size(22, 22)
        Me.Btn_editar.Location = New System.Drawing.Point(681, 90)
        Me.Btn_editar.Name = "Btn_editar"
        Me.Btn_editar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_editar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_editar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_editar.OnHoverImage = Nothing
        Me.Btn_editar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_editar.Radius = 2
        Me.Btn_editar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_editar.TabIndex = 88
        Me.Btn_editar.Text = "EDITAR"
        Me.Btn_editar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Btn_gravar
        '
        Me.Btn_gravar.AnimationHoverSpeed = 0.07!
        Me.Btn_gravar.AnimationSpeed = 0.03!
        Me.Btn_gravar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_gravar.BaseColor = System.Drawing.Color.SteelBlue
        Me.Btn_gravar.BorderColor = System.Drawing.Color.Black
        Me.Btn_gravar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_gravar.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_gravar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_gravar.ForeColor = System.Drawing.Color.White
        Me.Btn_gravar.Image = CType(resources.GetObject("Btn_gravar.Image"), System.Drawing.Image)
        Me.Btn_gravar.ImageSize = New System.Drawing.Size(22, 22)
        Me.Btn_gravar.Location = New System.Drawing.Point(681, 131)
        Me.Btn_gravar.Name = "Btn_gravar"
        Me.Btn_gravar.OnHoverBaseColor = System.Drawing.SystemColors.Highlight
        Me.Btn_gravar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_gravar.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_gravar.OnHoverImage = Nothing
        Me.Btn_gravar.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_gravar.Radius = 2
        Me.Btn_gravar.Size = New System.Drawing.Size(91, 27)
        Me.Btn_gravar.TabIndex = 89
        Me.Btn_gravar.Text = "SALVAR"
        Me.Btn_gravar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Frm_GerenciamentoAdministradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 374)
        Me.Controls.Add(Me.Btn_gravar)
        Me.Controls.Add(Me.Btn_editar)
        Me.Controls.Add(Me.Btn_voltar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_email)
        Me.Controls.Add(Me.Txt_nome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Dgv_dados)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Frm_GerenciamentoAdministradores"
        Me.Text = "Gerenciamento e Edição de Contas de Administradores"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Txt_buscar As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Cmb_campo As ToolStripComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Dgv_dados As DataGridView
    Friend WithEvents Btn_voltar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_editar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_gravar As Guna.UI.WinForms.GunaButton
End Class
