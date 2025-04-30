Imports System.Data.SQLite

Public Class CadastroProfessor
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Dim conexao As New SQLiteConnection(connectionString)

        Try
            conexao.Open()
            Dim salt As Byte() = GerarSalt(10)
            Dim senha_hash = GerarHashSenha(Txt_senha.Text, salt)

            Dim salt_B64 As String = Convert.ToBase64String(salt)
            Dim senha_hash_B64 As String = Convert.ToBase64String(senha_hash)

            If conexao.State = ConnectionState.Open Then
                Dim sql As String
                sql = "INSERT INTO tb_professores
                           (nome, email, senha_hash, senha_salt)
                       VALUES
                           (@nome, @email, @hash, @salt);"


                Using comando As New SQLiteCommand(sql, conexao)
                    comando.Parameters.AddWithValue("@nome", Txt_nome.Text)
                    comando.Parameters.AddWithValue("@email", Txt_email.Text)
                    comando.Parameters.Add("@hash", DbType.Binary).Value = senha_hash
                    comando.Parameters.Add("@salt", DbType.Binary).Value = salt

                    comando.ExecuteNonQuery()
                End Using

                ' Limpar campos
                Txt_nome.Text = ""
                Txt_email.Text = ""
                Txt_senha.Text = ""
                Txt_nome.Focus()

                MsgBox($"Professor {Txt_nome.Text} cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cadastrado com sucesso")

            End If

        Catch ex As Exception
            MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro ao cadastrar professor")
        Finally
            conexao.Close()
        End Try

    End Sub
End Class