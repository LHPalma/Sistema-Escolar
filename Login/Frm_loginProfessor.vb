Imports System.Text
Imports System.Data.SQLite
Public Class Frm_loginProfessor
    Private Sub Btn_logar_Click(sender As Object, e As EventArgs) Handles Btn_logar.Click

        If (Txt_email.Text = "" Or Txt_senha.Text = "") Then
            MsgBox("Insira seus dados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            Txt_email.Focus()
            Exit Sub
        End If



        Dim conexao As New SQLiteConnection(connectionString)

        Try
            conexao.Open()

            Dim usuarioValido As Boolean = VerificarUsuario("tb_professores", "email", Txt_email.Text, Txt_senha.Text)

            If usuarioValido Then
                MsgBox($"Login realizado com sucesso. Bem-vindo prof. {Txt_email.Text}!")
            Else
                MsgBox("Usuário ou senha incorretos.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Falha no login")
            End If

        Catch ex As Exception
        Finally
            conexao.Close()
        End Try


    End Sub

    Private Sub Cb_mostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles Cb_mostrarSenha.CheckedChanged
        Txt_senha.UseSystemPasswordChar = Not Txt_senha.UseSystemPasswordChar
    End Sub

    Private Sub Frm_loginProfessor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim inicio = New Frm_inicio()
        inicio.Show()
    End Sub

    Private Sub Frm_loginProfessor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
