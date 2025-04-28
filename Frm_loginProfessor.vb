Imports System.Text
Imports System.Data.SQLite
Public Class Frm_loginProfessor
    Private Sub Btn_logar_Click(sender As Object, e As EventArgs) Handles Btn_logar.Click
        If (Txt_email.Text = "" Or Txt_senha.Text = "") Then
            MsgBox("Insira seus dados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            Txt_email.Focus()
            Exit Sub
        End If

        Dim conexao As New SQLiteConnection(connString)
        Try
            conexao.Open()

            Dim sql As String = $"SELECT email, senha_hash, senha_salt FROM tb_professores
                                  WHERE email = '{Txt_email.Text}';"

            Dim comando As New SQLiteCommand(sql, conexao)
            Dim dr As SQLiteDataReader
            dr = comando.ExecuteReader()

            If (dr.HasRows) Then
                If (dr.Read()) Then

                    Dim senha_hash_armazenado As String = dr("senha_hash").ToString()
                    Dim salt_armazenado As Byte() = dr("senha_salt")

                    Dim senha_inserida_hash As Byte() = GerarHashSenha(Txt_senha.Text, salt_armazenado)


                    If (senha_hash_armazenado = Convert.ToBase64String(senha_inserida_hash)) Then
                        MsgBox("Login Realizado com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCESSO")
                    Else
                        MsgBox("Senha incorreta")
                        MsgBox(senha_hash_armazenado)
                        MsgBox(salt_armazenado)
                        MsgBox(Convert.ToBase64String(senha_inserida_hash))
                    End If


                End If
            Else
                MsgBox("Usuário não encontrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Txt_email.Focus()
            End If


        Catch ex As Exception
            MsgBox("Erro " & ex.ToString())
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
