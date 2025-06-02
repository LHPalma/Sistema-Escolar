Public Class Frm_menuCadastro
    'Fazer me.close nos botões de voltar
    Private Sub Btn_aluno_Click(sender As Object, e As EventArgs) Handles Btn_aluno.Click
        Dim frm As New Frm_cadastroAluno()
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Btn_professor_Click(sender As Object, e As EventArgs) Handles Btn_professor.Click
        AbreFormulario(New Frm_cadastroAluno)
    End Sub

    Private Sub Btn_adm_Click(sender As Object, e As EventArgs) Handles Btn_adm.Click
        AbreFormulario(New Frm_cadastroADM())
    End Sub


    Private Sub AbreFormulario(formulario)
        Me.Hide()
        formulario.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Btn_turma_Click(sender As Object, e As EventArgs) Handles Btn_turma.Click
        AbreFormulario(New Frm_CadastroTurma)
    End Sub

    Private Sub Btn_disciplina_Click(sender As Object, e As EventArgs) Handles Btn_disciplina.Click
        AbreFormulario(New Frm_CadastroDisciplina)
    End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        Me.Close()
    End Sub
End Class