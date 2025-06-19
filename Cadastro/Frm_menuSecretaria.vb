Public Class Frm_menuSecretaria
    Private Sub Btn_turmas_disciplinas_Click(sender As Object, e As EventArgs) Handles Btn_turmas_disciplinas.Click
        AbreFormulario(Me, New Frm_menuTurmasDisciplinas())
    End Sub

    Private Sub Btn_cadastro_contas_Click(sender As Object, e As EventArgs) Handles Btn_cadastro_contas.Click
        AbreFormulario(Me, New Frm_menuCadastro())
    End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        AbreFormulario(Me, New Frm_menuADM())
    End Sub
End Class