'TODO:
'Fazer verificação de campo UF (permitir máximo de 2Chars) e (Deixar Uppercase)
'   ******** faz um dropbox seu safado **********

'Fazer mascára para campo Telefone
'Permitir somente números no campo "numero" de endereço (não precisa, pois existem casas com numeros e letras, ex: 45A)
'cadastrar id do professor também, e colocar no banco ( Modulo.GetUltimoIdGerado(...) )

Imports System.Data.SQLite

Public Class CadastroProfessor
    Private Sub Btn_cadastrar_Click(sender As Object, e As EventArgs) Handles Btn_cadastrar.Click
        If (Txt_email.Text = "" Or Txt_nome.Text = "" Or Txt_senha.Text = "" Or Txt_rua.Text = "" Or Txt_numero.Text = "" Or Txt_uf.Text = "" Or Txt_telefone.Text = "") Then
            MsgBox("Para cadastrar, preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Exit Sub
        End If


        Using conexao As New SQLiteConnection(connectionString)
            Try
                conexao.Open()


                Dim sqlVerificar As String = "SELECT COUNT(*) FROM tb_professores WHERE email = @email"
                Using cmdVerificar As New SQLiteCommand(sqlVerificar, conexao)
                    cmdVerificar.Parameters.AddWithValue("@email", Txt_email.Text)
                    Dim count As Integer = Convert.ToInt32(cmdVerificar.ExecuteScalar())
                    If count > 0 Then
                        MsgBox("Email já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                        Txt_email.Focus()
                        Exit Sub
                    End If
                End Using

                ' Gerar salt e hash
                Dim salt As Byte() = GerarSalt(10)
                Dim hash As Byte() = GerarHashSenha(Txt_senha.Text, salt)

                ' Iniciar transação
                Using transacao = conexao.BeginTransaction()

                    ' Inserir professor
                    Dim sql1 As String = "INSERT INTO tb_professores (nome, email, senha_hash, senha_salt) VALUES (@nome, @email, @hash, @salt)"
                    Dim id_professor As Integer
                    Using cmd1 As New SQLiteCommand(sql1, conexao, transacao)
                        cmd1.Parameters.AddWithValue("@nome", Txt_nome.Text)
                        cmd1.Parameters.AddWithValue("@email", Txt_email.Text)
                        cmd1.Parameters.Add("@hash", DbType.Binary).Value = hash
                        cmd1.Parameters.Add("@salt", DbType.Binary).Value = salt
                        cmd1.ExecuteNonQuery()

                        id_professor = GetUltimoIdGerado(conexao, transacao)
                    End Using

                    ' Inserir endereço
                    Dim sql2 As String = "INSERT INTO tb_enderecos_professores (rua, numero, complemento, uf) VALUES (@rua, @numero, @complemento, @uf)"
                    Using cmd2 As New SQLiteCommand(sql2, conexao, transacao)
                        cmd2.Parameters.AddWithValue("@rua", Txt_rua.Text)
                        cmd2.Parameters.AddWithValue("@numero", Txt_numero.Text)
                        cmd2.Parameters.AddWithValue("@complemento", Txt_complemento.Text)
                        cmd2.Parameters.AddWithValue("@uf", Txt_uf.Text)
                        cmd2.ExecuteNonQuery()
                    End Using

                    ' Inserir telefone
                    Dim sql3 As String = "INSERT INTO tb_telefone_professores (numero) VALUES (@numero)"
                    Using cmd3 As New SQLiteCommand(sql3, conexao, transacao)
                        cmd3.Parameters.AddWithValue("@numero", Txt_telefone.Text)
                        cmd3.ExecuteNonQuery()
                    End Using

                    ' Commit da transação (Valida tudo no banco de dados)
                    transacao.Commit()
                End Using

                ' Confirmação e próxima ação
                Dim resp As MsgBoxResult = MsgBox($"Professor {Txt_nome.Text} cadastrado com sucesso! Deseja cadastrar outro Professor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cadastrado com sucesso")
                If resp = MsgBoxResult.Yes Then
                    ' Limpar campos
                    Btn_limpar_Click(sender, e))
                    Txt_nome.Focus()
                Else
                    Dim inicio As New Frm_inicio
                    inicio.Show()
                    Me.Hide()
                End If

            Catch ex As Exception
                MsgBox("Erro: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro ao cadastrar professor")
            End Try
        End Using ' Fim SQLiteConnection(connectionString)
    End Sub

    Private Sub Btn_limpar_Click(sender As Object, e As EventArgs) Handles Btn_limpar.Click
        Txt_email.Text = ""
        Txt_nome.Text = ""
        Txt_senha.Text = ""
        Txt_rua.Text = ""
        Txt_complemento.Text = ""
        Txt_numero.Text = ""
        Txt_uf.Text = ""
        Txt_telefone.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Txt_senha.UseSystemPasswordChar = Not Txt_senha.UseSystemPasswordChar
    End Sub
End Class
