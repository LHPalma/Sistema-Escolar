Imports System.Data.SQLite

Public Class Frm_cadastroADM
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs)
        If (Txt_nome.Text = "" Or
            Txt_email.Text = "" Or
            Txt_senha.Text = "") Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Exit Sub
        End If

        Using conexao As New SQLiteConnection(connectionString)
            conexao.Open()
            Dim sqlVerificar As String = "SELECT COUNT(*) FROM tb_administradores WHERE email = @email"
            Using cmdVerificar As New SQLiteCommand(sqlVerificar, conexao)
                cmdVerificar.Parameters.AddWithValue("@email", Txt_email.Text)
                Dim cont As Integer = Integer.Parse(cmdVerificar.ExecuteScalar().ToString())
                If (cont > 0) Then
                    MsgBox("Email já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                    Exit Sub
                End If
            End Using

            Dim salt As Byte() = GerarSalt(10)
            Dim senha_hash As Byte() = GerarHashSenha(Txt_senha.Text, salt)


            Using transacao = conexao.BeginTransaction()

                Dim sqlInsert As String = "INSERT INTO tb_administradores (nome, email, senha_hash, senha_salt, senha_sem_hash) VALUES (@nome, @email, @senha_hash, @senha_salt, @senha_sem_hash)"
                Using cmdInsert As New SQLiteCommand(sqlInsert, conexao)


                    cmdInsert.Parameters.AddWithValue("@nome", Txt_nome.Text)
                    cmdInsert.Parameters.AddWithValue("@email", Txt_email.Text)
                    cmdInsert.Parameters.Add("@senha_hash", DbType.Binary).Value = senha_hash
                    cmdInsert.Parameters.Add("@senha_salt", DbType.Binary).Value = salt
                    cmdInsert.Parameters.AddWithValue("@senha_sem_hash", Txt_senha.Text)
                    cmdInsert.ExecuteNonQuery()
                End Using

                transacao.Commit()
            End Using
            conexao.Close()
        End Using ' fim conexao

        MsgBox($"Administrador {Txt_nome.Text} cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
        LimparCampos()
        Txt_nome.Focus()
    End Sub
    Private Sub LimparCampos()
        Txt_nome.Clear()
        Txt_email.Clear()
        Txt_senha.Clear()
    End Sub

    Private Sub Btn_logar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click

    End Sub

    Private Sub Lb_email_Click(sender As Object, e As EventArgs) Handles Lb_email.Click

    End Sub
End Class