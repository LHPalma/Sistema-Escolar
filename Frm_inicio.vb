Public Class Frm_inicio
    Private Sub Btn_professor_Click(sender As Object, e As EventArgs) Handles Btn_professor.Click
        Dim professor As New Frm_loginProfessor()
        professor.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_aluno_Click(sender As Object, e As EventArgs) Handles Btn_aluno.Click
        Dim aluno As New Frm_loginAluno()
        aluno.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_adm_Click(sender As Object, e As EventArgs) Handles Btn_adm.Click
        Dim adm As New Frm_loginADM()
        adm.Show()
        Me.Hide()
    End Sub
End Class