<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PDVVendas
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
        Me.Txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_quantidade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_preco_unitario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_subtotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Txt_cliente
        '
        Me.Txt_cliente.Location = New System.Drawing.Point(44, 90)
        Me.Txt_cliente.Name = "Txt_cliente"
        Me.Txt_cliente.Size = New System.Drawing.Size(100, 26)
        Me.Txt_cliente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Item"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(44, 202)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Qtd"
        '
        'Txt_quantidade
        '
        Me.Txt_quantidade.Location = New System.Drawing.Point(54, 307)
        Me.Txt_quantidade.Name = "Txt_quantidade"
        Me.Txt_quantidade.Size = New System.Drawing.Size(100, 26)
        Me.Txt_quantidade.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(356, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Preço unitário"
        '
        'Txt_preco_unitario
        '
        Me.Txt_preco_unitario.Location = New System.Drawing.Point(350, 227)
        Me.Txt_preco_unitario.Name = "Txt_preco_unitario"
        Me.Txt_preco_unitario.Size = New System.Drawing.Size(100, 26)
        Me.Txt_preco_unitario.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(356, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Subtotal"
        '
        'Txt_subtotal
        '
        Me.Txt_subtotal.Location = New System.Drawing.Point(350, 307)
        Me.Txt_subtotal.Name = "Txt_subtotal"
        Me.Txt_subtotal.Size = New System.Drawing.Size(100, 26)
        Me.Txt_subtotal.TabIndex = 8
        '
        'PDVVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_subtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_preco_unitario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_quantidade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_cliente)
        Me.Name = "PDVVendas"
        Me.Text = "PDVVendas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_cliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_quantidade As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_preco_unitario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_subtotal As TextBox
End Class
