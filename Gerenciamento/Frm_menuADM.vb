Public Class Frm_menuADM
    Private Sub Btn_cadastro_Click(sender As Object, e As EventArgs) Handles Btn_cadastro.Click
        AbreFormulario(Me, New Frm_menuSecretaria())
    End Sub

    Private Sub Btn_gerenciar_Click(sender As Object, e As EventArgs) Handles Btn_gerenciar.Click
        AbreFormulario(Me, New Frm_MenuGerenciamento())
    End Sub
End Class