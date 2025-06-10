'TODO:
'Limitar tamanho de caracteres do campo RA para {tamanho de um RA}
'Já foi feito através da classe: Validações de RA (se é numero) e E-mail (se tem @) -> crie a classe Email e faça as validações por lá
'Bloquear a escrita da combobox de turma (DEVE-SE APENAS ESCOLHER OQ JÁ TEM CADASTRADO)
'Acrescentar no código os campos novos que foram adicionados de endereço e telefone

Imports System.Data.SQLite
Imports System.Net.Http
Imports Newtonsoft.Json


Public Class Frm_cadastroAluno

    Private Sub Btn_cadastrar_Click(sender As Object, e As EventArgs)

        If (Txt_email.Text = "" Or Txt_nome.Text = "" Or Txt_senha.Text = "" Or Txt_ra.Text = "" Or Cmb_Turma.Text = "" Or Txt_cpf.Text = "") Then
            MsgBox("Para cadastrar, preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Exit Sub
        End If

        Using conexao As New SQLiteConnection(connectionString)
            Try
                conexao.Open()

                'Cria o objeto e já faz as validações
                Dim aluno As New Aluno(Txt_nome.Text, Txt_ra.Text, Txt_cpf.Text, Txt_email.Text, Txt_senha.Text, Cmb_Turma.Text)

                If ExisteAluno(aluno.RA, conexao) Then
                    Exit Sub
                End If

                'Iniciando Transação
                Using transacao = conexao.BeginTransaction()
                    InserirAluno(aluno, conexao, transacao)
                    Dim id_aluno = GetUltimoIdGerado(conexao, transacao)
                    InsereEnderecoAluno(id_aluno, conexao, transacao)
                    InsereTelefoneAluno(id_aluno, conexao, transacao)
                    InsereTurma(id_aluno, conexao, transacao)

                    'Validando transação
                    transacao.Commit()
                    Dim servicoDeMensagem As New ServicosDeMensagem()
                    servicoDeMensagem.EnviarEmail(Txt_email.Text, Txt_nome.Text)
                    CadastrarDenovo(Txt_nome.Text)
                End Using 'Fim transação

            Catch ex As Exception
                MsgBox(ex.ToString())

            Finally
                conexao.Close()
            End Try
        End Using ' Fim SQLiteConnection(connectionString)
    End Sub

#Region "Rotinas de Banco de Dados"
    Private Function ExisteAluno(ra As String, conexao As SQLiteConnection) As Boolean
        Dim sqlVerificar As String = "SELECT COUNT(*) FROM tb_alunos WHERE ra = @ra"
        Using cmdVerificar As New SQLiteCommand(sqlVerificar, conexao)
            cmdVerificar.Parameters.AddWithValue("@ra", ra)
            Dim count As Integer = Convert.ToInt32(cmdVerificar.ExecuteScalar())
            If count > 0 Then
                MsgBox("RA já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Txt_ra.Focus()
                Return True
            End If
        End Using

        Return False
    End Function

    Private Sub InserirAluno(aluno As Aluno, conexao As SQLiteConnection, transacao As SQLiteTransaction)
        'Gerando salt e hash
        Dim senha_salt As Byte() = GerarSalt(10)
        Dim senha_hash As Byte() = GerarHashSenha(Txt_senha.Text, senha_salt)

        Dim sqlInsert As String = "INSERT INTO tb_alunos
                                                   (ra, nome, email, senha_hash, senha_salt, senha_sem_hash, data_cadastro)
                                               VALUES
                                                   (@ra, @nome, @email, @hash, @salt, @senha_sem_hash, @data_cadastro)"

        Using cmdInsert As New SQLiteCommand(sqlInsert, conexao, transacao)
            cmdInsert.Parameters.AddWithValue("@ra", aluno.RA)
            cmdInsert.Parameters.AddWithValue("@nome", aluno.Nome)
            cmdInsert.Parameters.AddWithValue("@email", aluno.Email)
            cmdInsert.Parameters.Add("@hash", DbType.Binary).Value = senha_hash
            cmdInsert.Parameters.Add("@salt", DbType.Binary).Value = senha_salt
            cmdInsert.Parameters.AddWithValue("@senha_sem_hash", aluno.Senha)
            Dim agora As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            cmdInsert.Parameters.AddWithValue("@data_cadastro", agora)

            cmdInsert.ExecuteNonQuery()

        End Using
    End Sub

    Private Sub InsereEnderecoAluno(id_aluno As Integer, conexao As SQLiteConnection, transacao As SQLiteTransaction)
        Dim sqlInsertEndereco As String = "INSERT INTO tb_enderecos_alunos
                                                           (fk_id_aluno, cep, rua, numero, complemento, cidade, bairro, uf)
                                                       VALUES
                                                           (@fk_id_aluno, @cep, @rua, @numero, @complemento, @cidade, @bairro, @uf);"

        Using cmdInsertEndereco As New SQLiteCommand(sqlInsertEndereco, conexao, transacao)
            cmdInsertEndereco.Parameters.AddWithValue("@fk_id_aluno", id_aluno)
            cmdInsertEndereco.Parameters.AddWithValue("@cep", Txt_cep.Text)
            cmdInsertEndereco.Parameters.AddWithValue("@rua", Txt_rua.Text)
            cmdInsertEndereco.Parameters.AddWithValue("@numero", Txt_numero.Text)
            cmdInsertEndereco.Parameters.AddWithValue("@complemento", Txt_complemento.Text)
            cmdInsertEndereco.Parameters.AddWithValue("@cidade", Txt_cidade.Text)
            cmdInsertEndereco.Parameters.AddWithValue("@bairro", Txt_bairro.Text)
            cmdInsertEndereco.Parameters.AddWithValue("@uf", Cmb_uf.Text)
            cmdInsertEndereco.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub InsereTelefoneAluno(id_aluno As Integer, conexao As SQLiteConnection, transacao As SQLiteTransaction)
        Dim sqlInsertTelefone As String = "INSERT INTO tb_telefones_alunos
                                                           (fk_id_aluno, numero)
                                                       VALUES
                                                           (@fk_id_aluno, @numero);"

        Using cmdInsertTelefone As New SQLiteCommand(sqlInsertTelefone, conexao, transacao)
            cmdInsertTelefone.Parameters.AddWithValue("@fk_id_aluno", id_aluno)
            cmdInsertTelefone.Parameters.AddWithValue("@numero", Txt_telefone.Text)
            cmdInsertTelefone.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub InsereTurma(id_aluno As Long, conexao As SQLiteConnection, transacao As SQLiteTransaction)
        Dim sqlInsertTurma As String = "INSERT INTO tb_turmas_alunos
                                                           (fk_id_aluno, fk_id_turma)
                                                       VALUES
                                                           (@fk_id_aluno, @fk_id_turma);"

        Using cmdInsertTurma As New SQLiteCommand(sqlInsertTurma, conexao, transacao)
            cmdInsertTurma.Parameters.AddWithValue("@fk_id_aluno", id_aluno)
            Dim id_turma As Long = GetIdTurma(Cmb_Turma.Text, conexao, transacao)
            cmdInsertTurma.Parameters.AddWithValue("@fk_id_turma", id_turma)
            cmdInsertTurma.ExecuteNonQuery()
        End Using
    End Sub

    Private Function GetIdTurma(nome_turma As String, conexao As SQLiteConnection, transacao As SQLiteTransaction) As Long
        Dim sqlSelectTurma As String = "SELECT id_turma
                                        FROM tb_turmas
                                        WHERE nome = @nome_turma"

        Using cmdSelectTurma As New SQLiteCommand(sqlSelectTurma, conexao, transacao)
            cmdSelectTurma.Parameters.AddWithValue("@nome_turma", nome_turma)
            Dim id_turma As Long = Convert.ToInt64(cmdSelectTurma.ExecuteScalar())
            Return id_turma
        End Using
    End Function
#End Region

    Private Sub CadastrarDenovo(nomeAluno As String)
        Dim resp = MsgBox($"Aluno {nomeAluno} cadastrado com sucesso! Deseja cadastrar outro Aluno?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cadastrado com sucesso")
        If resp = MsgBoxResult.Yes Then
            LimparCampos()
            Txt_ra.Focus()
        Else
            Dim inicio As New Frm_inicio
            inicio.Show()
            Me.Hide()
        End If
    End Sub



#Region "Rotinas de FrontEnd"
    Private Sub Cb_mostrar_senha_CheckedChanged(sender As Object, e As EventArgs)
        Txt_senha.UseSystemPasswordChar = Not Txt_senha.UseSystemPasswordChar
    End Sub

    Private Sub Btn_limpar_campos_Click(sender As Object, e As EventArgs)
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
        Txt_email.Text = ""
        Txt_nome.Text = ""
        Txt_senha.Text = ""
        Txt_ra.Text = ""
        Txt_cpf.Text = ""
        Cmb_Turma.Text = ""
    End Sub

    Private Sub Frm_cadastroAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conexao As New SQLiteConnection(connectionString)
            Dim sqlSelectTurma As String = "SELECT nome FROM tb_turmas;"
            Dim cmdSelectTurmas As New SQLiteCommand(sqlSelectTurma, conexao)

            Try
                conexao.Open()
                Dim reader As SQLiteDataReader = cmdSelectTurmas.ExecuteReader()
                While reader.Read()
                    Cmb_Turma.Items.Add(reader("nome").ToString())
                End While
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                conexao.Close()
            End Try

        End Using
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

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Dim diretorio As String
        Try
            With abrirArquivo
                .Title = "Selecione uma Imagem"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Txt_senha_TextChanged(sender As Object, e As EventArgs) Handles Txt_senha.TextChanged

    End Sub

    Private Sub Lb_senha_Click(sender As Object, e As EventArgs) Handles Lb_senha.Click

    End Sub

    Private Sub Txt_cpf_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles Txt_cpf.MaskInputRejected

    End Sub

    Private Sub Lb_cpf_Click(sender As Object, e As EventArgs) Handles Lb_cpf.Click

    End Sub

#End Region
End Class