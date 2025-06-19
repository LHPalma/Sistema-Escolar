Public Class Frm_menuTurmasDisciplinas
    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        Dim menuSecretaria As New Frm_menuSecretaria()
        Me.Close()
        menuSecretaria.ShowDialog()
    End Sub

    Private Sub Btn_turma_Click(sender As Object, e As EventArgs) Handles Btn_turma.Click
        Dim cadastroTurma As New Frm_CadastroTurma()
        Me.Close()
        cadastroTurma.ShowDialog()
    End Sub

    Private Sub Btn_disciplina_Click(sender As Object, e As EventArgs) Handles Btn_disciplina.Click
        Dim cadastroDisciplina As New Frm_CadastroDisciplina()
        Me.Close()
        cadastroDisciplina.ShowDialog()
    End Sub
End Class