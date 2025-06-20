Imports System.Data.SQLite

Public Class Frm_GerenciamentoAdministradores

    Dim btnVoltarFoiClicado As Boolean = False

    Dim permiteAjax As Boolean = False
    Dim conexao As New SQLiteConnection(connectionString)

    Private Sub Frm_GerenciamentoAdministradores_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnVoltarFoiClicado = False
    End Sub

    Private Sub Txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_buscar.TextChanged

        If Cmb_campo.Text = "" Or Not permiteAjax Then
            Exit Sub
        End If

        Dgv_dados.DataSource = FazAjax(conexao, "tb_administradores", Cmb_campo.Text, Txt_buscar.Text)

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
        Txt_email.Text = Dgv_dados.CurrentRow.Cells("email").Value.ToString()
        Txt_nome.Text = Dgv_dados.CurrentRow.Cells("nome").Value.ToString()
    End Sub



    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        btnVoltarFoiClicado = True
        AbreFormulario(Me, New Frm_MenuGerenciamento())
    End Sub

    Private Sub Frm_GerenciamentoAdministradores_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not btnVoltarFoiClicado Then
            Close()
        End If
    End Sub


End Class