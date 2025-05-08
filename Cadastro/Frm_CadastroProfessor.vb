Imports System.Data.SQLite
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Frm_CadastroProfessor
    Private Sub Btn_cadastrar_Click(sender As Object, e As EventArgs) Handles Btn_cadastrar.Click
        If (Txt_email.Text = "" Or Txt_nome.Text = "" Or Txt_senha.Text = "" Or Txt_rua.Text = "" Or Txt_numero.Text = "" Or Cmb_uf.Text = "" Or Txt_telefone.Text = "") Then
            MsgBox("Para cadastrar, preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Exit Sub
        End If


        Using conexao As New SQLiteConnection(connectionString)
            Try
                conexao.Open()

                Dim sqlVerificar As String = "SELECT COUNT(*) FROM tb_professores WHERE email = @email;"
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
                    Dim sqlInsertProfessor As String = "INSERT INTO tb_professores
                                                            (nome, email, senha_hash, senha_salt, senha_sem_hash, data_cadastro)
                                                        VALUES
                                                            (@nome, @email, @hash, @salt, @senha_sem_hash, @data_cadastro);"

                    Dim id_professor As Integer
                    Using cmdInsertProfessor As New SQLiteCommand(sqlInsertProfessor, conexao, transacao)
                        cmdInsertProfessor.Parameters.AddWithValue("@nome", Txt_nome.Text)
                        cmdInsertProfessor.Parameters.AddWithValue("@email", Txt_email.Text)
                        cmdInsertProfessor.Parameters.Add("@hash", DbType.Binary).Value = hash
                        cmdInsertProfessor.Parameters.Add("@salt", DbType.Binary).Value = salt
                        cmdInsertProfessor.Parameters.AddWithValue("@senha_sem_hash", Txt_senha.Text)
                        Dim agora As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        cmdInsertProfessor.Parameters.AddWithValue("@data_cadastro", agora)
                        cmdInsertProfessor.ExecuteNonQuery()

                        id_professor = GetUltimoIdGerado(conexao, transacao)
                    End Using

                    ' Inserir endereço
                    Dim sqlInsertEndereco As String = "INSERT INTO tb_enderecos_professores
                                            (fk_id_professor, cep, rua, numero, complemento, cidade, uf, bairro)
                                          VALUES
                                            (@fk_id_professor, @cep, @rua, @numero, @complemento, @cidade, @uf, @bairro);"


                    Using cmdInsertEndereco As New SQLiteCommand(sqlInsertEndereco, conexao, transacao)
                        cmdInsertEndereco.Parameters.AddWithValue("@fk_id_professor", id_professor)
                        Dim cepSemMascara As String = Txt_cep.Text.Replace("-", "")
                        cmdInsertEndereco.Parameters.AddWithValue("@cep", cepSemMascara)
                        cmdInsertEndereco.Parameters.AddWithValue("@rua", Txt_rua.Text)
                        cmdInsertEndereco.Parameters.AddWithValue("@numero", Txt_numero.Text)
                        cmdInsertEndereco.Parameters.AddWithValue("@complemento", Txt_complemento.Text)
                        cmdInsertEndereco.Parameters.AddWithValue("@cidade", Txt_cidade.Text)
                        cmdInsertEndereco.Parameters.AddWithValue("@uf", Cmb_uf.Text)
                        cmdInsertEndereco.Parameters.AddWithValue("@bairro", Txt_bairro.Text)
                        cmdInsertEndereco.ExecuteNonQuery()
                    End Using

                    ' Inserir telefone
                    Dim sqlInsertTelefone As String = "INSERT INTO tb_telefones_professores
                                            (fk_id_professor, numero)
                                          VALUES
                                            (@fk_id_professor, @numero);"

                    Using cmdInsertTelefone As New SQLiteCommand(sqlInsertTelefone, conexao, transacao)
                        cmdInsertTelefone.Parameters.AddWithValue("@fk_id_professor", id_professor)
                        cmdInsertTelefone.Parameters.AddWithValue("@numero", Txt_telefone.Text)
                        cmdInsertTelefone.ExecuteNonQuery()
                    End Using

                    ' Commit da transação (Valida tudo no banco de dados)
                    transacao.Commit()
                End Using

                Dim servicoDeMensagem As New ServicosDeMensagem()
                servicoDeMensagem.EnviarEmail(Txt_email.Text, Txt_nome.Text)

                ' Confirmação e próxima ação
                Dim resp As MsgBoxResult = MsgBox($"Professor {Txt_nome.Text} cadastrado com sucesso! Deseja cadastrar outro Professor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cadastrado com sucesso")
                If resp = MsgBoxResult.Yes Then
                    ' Limpar campos
                    Btn_limpar_Click(sender, e)
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

    Private Sub Btn_limpar_Click(sender As Object, e As EventArgs)
        Txt_email.Text = ""
        Txt_nome.Text = ""
        Txt_senha.Text = ""
        Txt_rua.Text = ""
        Txt_complemento.Text = ""
        Txt_numero.Text = ""
        Cmb_uf.Text = ""
        Txt_telefone.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        Txt_senha.UseSystemPasswordChar = Not Txt_senha.UseSystemPasswordChar
    End Sub

    Private Async Sub Txt_cep_Leave(sender As Object, e As EventArgs) Handles Txt_cep.Leave

        If Txt_cep.Text.Length <> 9 Then
            Exit Sub
        End If
        Dim url = $"https://viacep.com.br/ws/{Txt_cep.Text}/json/"
        Using client As New HttpClient()

            Dim response As HttpResponseMessage = Await client.GetAsync(url)
            response.EnsureSuccessStatusCode()

            Dim jsonString As String = Await response.Content.ReadAsStringAsync()
            Dim endereco As Endereco = JsonConvert.DeserializeObject(Of Endereco)(jsonString)

            If endereco.Erro Then
                MsgBox("CEP não encontrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            End If

            ' preencha os campos de endereço
            Txt_rua.Text = endereco.Logradouro
            Txt_bairro.Text = endereco.Bairro
            Txt_cidade.Text = endereco.Localidade
            Cmb_uf.Text = endereco.Uf

        End Using
    End Sub

    Private Sub Lb_cidade_Click(sender As Object, e As EventArgs) Handles Lb_cidade.Click
        Txt_cidade.Focus()
    End Sub
End Class