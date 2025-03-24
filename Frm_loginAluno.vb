Public Class Frm_loginAluno
    Private Sub Btn_logar_Click(sender As Object, e As EventArgs) Handles Btn_logar.Click

        If Not ((Txt_ra.Text <> "" Or Txt_senha.Text <> "")) Then
            MsgBox("Insira seus dados")
        End If


        Dim professor = New Frm_loginProfessor()
        professor.Show()
    End Sub


    Private Sub Cb_mostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles Cb_mostrarSenha.CheckedChanged
        Txt_senha.UseSystemPasswordChar = Not Txt_senha.UseSystemPasswordChar
    End Sub

    Private Sub Lb_ra_Click(sender As Object, e As EventArgs) Handles Lb_ra.Click
        Txt_ra.Focus()
    End Sub

    Private Sub Lb_senha_Click(sender As Object, e As EventArgs) Handles Lb_senha.Click
        Txt_senha.Focus()
    End Sub

    Private Sub Frm_loginAluno_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim inicio = New Frm_inicio()
        inicio.Show()
    End Sub
End Class
