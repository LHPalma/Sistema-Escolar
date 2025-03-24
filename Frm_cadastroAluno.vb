Public Class Frm_cadastroAluno
    Private Sub Btn_cadastrar_Click(sender As Object, e As EventArgs) Handles Btn_cadastrar.Click
        Try
            Dim aluno As New Aluno(Txt_nome.Text, Txt_ra.Text, Txt_cpf.Text, Txt_email.Text, Txt_senha.Text, Txt_turma.Text)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
End Class