Imports System.Data.SQLite

Public Class Frm_GerenciamentoProfessores

    Dim conexao As New SQLiteConnection(connectionString)
    Dim permiteAjax As Boolean = False

    Private Sub Txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_buscar.TextChanged

        If Cmb_campo.Text = "" Or Not permiteAjax Then
            Exit Sub
        End If

        Dgv_dados.DataSource = FazAjax(conexao, "tb_professores", Cmb_campo.Text, Txt_buscar.Text)

    End Sub


    Private Sub Cmb_campo_TextChanged(sender As Object, e As EventArgs) Handles Cmb_campo.TextChanged
        ' Não funciona se o filho do draculo escrever em letra minúscula: nome != Nome
        'If Cmb_campo.Items.Contains(Cmb_campo.Text) Then
        '    permiteAjax = True
        '    Txt_buscar_TextChanged(sender, e)
        'Else
        '    permiteAjax = False
        'End If

        For Each item As String In Cmb_campo.Items
            If String.Equals(item, Cmb_campo.Text, StringComparison.OrdinalIgnoreCase) Then
                permiteAjax = True
                Txt_buscar_TextChanged(Nothing, Nothing)
                Exit For
            End If
        Next
    End Sub


    Private Sub Dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_dados.CellContentClick
        txt_nome.Text = Dgv_dados.CurrentRow.Cells("nome").Value.ToString()
        txt_email.Text = Dgv_dados.CurrentRow.Cells("email").Value.ToString()

        'TODO: Campo cpf no Banco de Dados
        'Txt_cpf.Text = Dgv_dados.CurrentRow.Cells("cpf").Value.ToString()

        'TODO: 
        'Txt_telefone.Text = Dgv_dados.CurrentRow.Cells("telefone").Value.ToString()


    End Sub
End Class