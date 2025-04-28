Imports System.Data.SQLite

Public Class CadastroProfessor
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Dim conexao As New SQLiteConnection(connString)

        Try
            conexao.Open()
            Dim salt = GerarSalt(10)
            Dim senha_hash_salt_b64 = Convert.ToBase64String(GerarHashSenha(Txt_senha.Text, salt))
            Dim salt_b64 = Convert.ToBase64String(salt)



            If conexao.State = ConnectionState.Open Then
                Dim sql As String
                sql = $"INSERT INTO tb_professores (nome, email, senha_hash, senha_salt) VALUES (
                    '{Txt_nome.Text}',
                    '{Txt_email.Text}',
                    '{senha_hash_salt_b64}',
                    '{salt_b64}'
               );"

                Dim comando As New SQLiteCommand(sql, conexao)
                comando.ExecuteReader()
            End If

        Catch ex As Exception
            MsgBox("Erro: " & ex.ToString())
        Finally
            MsgBox($"Professor {Txt_nome.Text} cadastrado com sucesso!", vbExclamation + vbOKOnly, "Sucesso!")
            Txt_nome.Text = ""
            Txt_email.Text = ""
            Txt_senha.Text = ""

            Txt_nome.Focus()
            conexao.Close()
        End Try

    End Sub
End Class