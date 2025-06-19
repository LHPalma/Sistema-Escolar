Public Class Frm_menuTurmasDisciplinas
    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        AbreFormulario(Me, New Frm_menuSecretaria())
    End Sub

    Private Sub Btn_turma_Click(sender As Object, e As EventArgs) Handles Btn_turma.Click
        AbreFormulario(Me, New Frm_CadastroTurma())
    End Sub

    Private Sub Btn_disciplina_Click(sender As Object, e As EventArgs) Handles Btn_disciplina.Click
        AbreFormulario(Me, New Frm_CadastroDisciplina())
    End Sub
End Class