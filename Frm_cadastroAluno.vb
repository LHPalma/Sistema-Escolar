'TODO:
'Limitar tamanho de caracteres do campo RA para {tamanho de um RA}
'Já foi feito através da classe: Validações de RA (se é numero) e E-mail (se tem @)
'Definir turmas, como vão ser registradas no banco de dados, se vai ser pela cb ou se pode digitar o que quiser

Imports System.Data.SQLite

Public Class Frm_cadastroAluno
    Private Sub Btn_cadastrar_Click(sender As Object, e As EventArgs) Handles Btn_cadastrar.Click

        If (Txt_email.Text = "" Or Txt_nome.Text = "" Or Txt_senha.Text = "" Or Txt_ra.Text = "" Or Cmb_Turma.Text = "" Or Txt_cpf.Text = "") Then
            MsgBox("Para cadastrar, preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Exit Sub
        End If

        Using conexao As New SQLiteConnection(connectionString)
            Try
                conexao.Open()

                'Cria o objeto e já faz as validações
                Dim aluno As New Aluno(Txt_nome.Text, Txt_ra.Text, Txt_cpf.Text, Txt_email.Text, Cmb_Turma.Text, Txt_senha.Text)

                Dim sqlVerificar As String = "SELECT COUNT(*) FROM tb_alunos WHERE ra = @ra"
                Using cmdVerificar As New SQLiteCommand(sqlVerificar, conexao)
                    cmdVerificar.Parameters.AddWithValue("@ra", aluno.RA)
                    Dim count As Integer = Convert.ToInt32(cmdVerificar.ExecuteScalar())
                    If count > 0 Then
                        MsgBox("RA já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                        Txt_ra.Focus()
                        Exit Sub
                    End If
                End Using

                'Gerando salt e hash
                Dim salt As Byte() = GerarSalt(10)
                Dim hash As Byte() = GerarHashSenha(Txt_senha.Text, salt)

                'Iniciando Transação
                Using transacao = conexao.BeginTransaction()

                    'Inserindo Alunonha_hash, senha_salt) VALUES (@ra, @nome, @
                    Dim sqlInsert As String = "INSERT INTO tb_alunos (ra, nome, email, senha_hash, senha_salt, senha_sem_hash, data_cadastro) VALUES (@ra, @nome, @email, @hash, @salt, @senha_sem_hash, @data_cadastro)"
                    Dim id_aluno As Integer
                    Using cmdInsert As New SQLiteCommand(sqlInsert, conexao, transacao)
                        cmdInsert.Parameters.AddWithValue("@ra", aluno.RA)
                        cmdInsert.Parameters.AddWithValue("@nome", aluno.Nome)
                        cmdInsert.Parameters.AddWithValue("@email", aluno.Email)
                        cmdInsert.Parameters.Add("@hash", DbType.Binary).Value = hash
                        cmdInsert.Parameters.Add("@salt", DbType.Binary).Value = salt
                        cmdInsert.Parameters.AddWithValue("@senha_sem_hash", aluno.Senha)
                        Dim agora As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        cmdInsert.Parameters.AddWithValue("@data_cadastro", agora)

                        cmdInsert.ExecuteNonQuery()

                        id_aluno = GetUltimoIdGerado(conexao, transacao)
                    End Using

                    'Validando transação
                    transacao.Commit()

                    ' Confirmação e próxima ação
                    Dim resp As MsgBoxResult = MsgBox($"Aluno {aluno.Nome} cadastrado com sucesso! Deseja cadastrar outro Aluno?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cadastrado com sucesso")
                    If resp = MsgBoxResult.Yes Then
                        ' Limpar campos
                        Btn_limpar_campos_Click(sender, e)
                        Txt_ra.Focus()
                    Else
                        Dim inicio As New Frm_inicio
                        inicio.Show()
                        Me.Hide()
                    End If
                End Using

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End Using ' Fim SQLiteConnection(connectionString)
    End Sub

    Private Sub Cb_mostrar_senha_CheckedChanged(sender As Object, e As EventArgs) Handles Cb_mostrar_senha.CheckedChanged
        Txt_senha.UseSystemPasswordChar = Not Txt_senha.UseSystemPasswordChar
    End Sub

    Private Sub Btn_limpar_campos_Click(sender As Object, e As EventArgs) Handles Btn_limpar_campos.Click
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
End Class