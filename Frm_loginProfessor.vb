Public Class Frm_loginProfessor



    Private Sub Btn_logar_Click(sender As Object, e As EventArgs) Handles Btn_logar.Click
        If (Txt_email.Text = "" Or Txt_senha.Text = "") Then
            MsgBox("Insira seus dados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            Txt_email.Focus()
        Else
            MsgBox("Login Realizado com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
        End If
    End Sub

    Private Sub Cb_mostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles Cb_mostrarSenha.CheckedChanged
        Txt_senha.UseSystemPasswordChar = Not Txt_senha.UseSystemPasswordChar
    End Sub

    Private Sub Frm_loginProfessor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim inicio = New Frm_inicio()
        inicio.Show()
    End Sub
End Class
