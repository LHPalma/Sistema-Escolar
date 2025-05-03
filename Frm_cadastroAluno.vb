Public Class Frm_cadastroAluno
    Private Sub Btn_cadastrar_Click(sender As Object, e As EventArgs) Handles Btn_cadastrar.Click
        Try
            Dim aluno As New Aluno(Txt_nome.Text, Txt_ra.Text, Txt_cpf.Text, Txt_email.Text, Txt_senha.Text, Txt_turma.Text)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub Txt_turma_TextChanged(sender As Object, e As EventArgs) Handles Txt_turma.TextChanged

    End Sub

    Private Sub Lb_email_Click(sender As Object, e As EventArgs) Handles Lb_email.Click

    End Sub

    Private Sub Lb_turma_Click(sender As Object, e As EventArgs) Handles Lb_turma.Click

    End Sub
End Class