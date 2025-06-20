Public Class Frm_inicio
    Private Sub Btn_professor_Click(sender As Object, e As EventArgs) Handles Btn_professor.Click
        AbreFormulario(Me, New Frm_loginProfessor())
    End Sub

    Private Sub Btn_aluno_Click(sender As Object, e As EventArgs) Handles Btn_aluno.Click
        AbreFormulario(Me, New Frm_loginAluno())
    End Sub

    Private Sub Btn_adm_Click(sender As Object, e As EventArgs) Handles Btn_adm.Click
        AbreFormulario(Me, New Frm_loginADM())
    End Sub

    Private Sub Frm_inicio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Close()
    End Sub

End Class