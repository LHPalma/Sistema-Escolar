Imports System.Data.SQLite

Public Class Frm_GerenciamentoAlunos

    Dim permiteAjax As Boolean = False

    Dim conexao As New SQLiteConnection(connectionString)

    Private Sub Txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_buscar.TextChanged

        If Cmb_campo.Text = "" Or Not permiteAjax Then
            Exit Sub
        End If


        Dim sqlAjax = $"SELECT * FROM tb_alunos WHERE {Cmb_campo.Text.ToLower()} LIKE '%{Txt_buscar.Text}%';"

        ' TODO: Dar uma pesquisada no como isso funciona #nebulosidades nebulosas
        conexao.Open()
        Using cmdAjax As New SQLiteCommand(sqlAjax, conexao)
            Dim dtAjax As New DataTable()
            Dim daAjax As New SQLiteDataAdapter(cmdAjax)
            daAjax.Fill(dtAjax)

#Region "Converte os hashes para strings legíveis"
            ' Converte os hashes para strings legíveis
            dtAjax.Columns.Add("senha_hash_string", GetType(String))
            dtAjax.Columns.Add("senha_salt_string", GetType(String))

            ' Preenche as novas colunas com os valores convertidos
            For Each row As DataRow In dtAjax.Rows
                row("senha_hash_string") = BitConverter.ToString(CType(row("senha_hash"), Byte())).Replace("-", "")
                row("senha_salt_string") = BitConverter.ToString(CType(row("senha_salt"), Byte())).Replace("-", "")
            Next

            ' Remove as colunas originais
            dtAjax.Columns.Remove("senha_hash")
            dtAjax.Columns.Remove("senha_salt")
#End Region

            dgv_dados.DataSource = dtAjax
            conexao.Close()
        End Using

    End Sub


    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Dim row As DataGridViewRow = dgv_dados.Rows(e.RowIndex)
        txt_nome.Text = row.Cells("nome").Value.ToString()
        txt_email.Text = row.Cells("email").Value.ToString()
        Txt_ra.Text = row.Cells("ra").Value.ToString()

        Try
            conexao.Open()

            Dim sqlSelectNomeTurma As String = "SELECT t.nome
                                                    FROM tb_turmas AS t 
                                                    INNER JOIN tb_alunos_turmas AS at
                                                    ON t.id_turma = at.fk_id_turma
                                                    WHERE at.fk_id_aluno = @id_aluno;"

            Using cmdSelectNomeTurma As New SQLiteCommand(sqlSelectNomeTurma, conexao)
                cmdSelectNomeTurma.Parameters.AddWithValue("@id_aluno", row.Cells("id_aluno").Value.ToString())
                Using reader As SQLiteDataReader = cmdSelectNomeTurma.ExecuteReader()
                    If reader.Read() Then
                        cb_turma.SelectedIndex = cb_turma.FindStringExact(reader("nome").ToString())
                    End If
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Erro ao buscar nome da turma: " & ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Erro")

        Finally
            conexao.Close()
        End Try

        'Preenche com endereço e telefone do aluno
        Try
            conexao.Open()
            Using transacao = conexao.BeginTransaction()

                '1. Busca Endereço (usei sem o inner join nesse pq pega todas as colunas da tabela endereço)
                Dim sqlEndereco As String = "SELECT * FROM tb_enderecos_alunos WHERE fk_id_aluno = @id_aluno;"
                Using cmdEndereco As New SQLiteCommand(sqlEndereco, conexao)
                    cmdEndereco.Parameters.AddWithValue("@id_aluno", row.Cells("id_aluno").Value.ToString())

                    Using readerEndereco As SQLiteDataReader = cmdEndereco.ExecuteReader()
                        If readerEndereco.Read() Then
                            Txt_rua.Text = readerEndereco("rua").ToString()
                            Txt_numero.Text = readerEndereco("numero").ToString()
                            Txt_bairro.Text = readerEndereco("bairro").ToString()
                            Txt_cidade.Text = readerEndereco("cidade").ToString()
                            Cmb_uf.Text = readerEndereco("uf").ToString()
                            Txt_complemento.Text = readerEndereco("complemento").ToString()
                            Txt_cep.Text = readerEndereco("cep").ToString()
                        Else
                            Txt_rua.Text = ""
                            Txt_numero.Text = ""
                            Txt_bairro.Text = ""
                            Txt_cidade.Text = ""
                            Cmb_uf.Text = ""
                            Txt_complemento.Text = ""
                            Txt_cep.Text = ""
                        End If
                    End Using
                End Using


                '2. Busca o Telefone
                Dim sqlTelefone As String = "SELECT numero FROM tb_telefones_alunos WHERE fk_id_aluno = @id_aluno;"
                Using cmdTelefone As New SQLiteCommand(sqlTelefone, conexao)
                    cmdTelefone.Parameters.AddWithValue("@id_aluno", row.Cells("id_aluno").Value.ToString())

                    Using readerTelefone As SQLiteDataReader = cmdTelefone.ExecuteReader()
                        If readerTelefone.Read() Then
                            Txt_telefone.Text = readerTelefone("numero").ToString()
                        Else
                            Txt_telefone.Text = ""
                        End If
                    End Using
                End Using

                transacao.Commit()
            End Using ' Encerra a transação

        Catch ex As Exception
            MsgBox("Erro ao buscar endereço e telefone do aluno: " & ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Erro")
        Finally
            conexao.Close()
        End Try

    End Sub

    'Sub rotina para permitir carregar apenas as turmas existentes no banco em uma combobox, para que a edição de turmas em tb_turmas seja válida
    Private Sub Frm_gerenContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conexao.Open()


            Dim sqlTurmas As String = "SELECT id_turma, nome FROM tb_turmas;"
            Dim dtTurmas As New DataTable()


            Using cmd As New SQLiteCommand(sqlTurmas, conexao)
                Using da As New SQLiteDataAdapter(cmd)
                    da.Fill(dtTurmas)
                End Using
            End Using

            'Preenche a ComboBox com os nomes das turmas
            cb_turma.DataSource = dtTurmas
            cb_turma.DisplayMember = "nome"       ' O que o usuário vai ver
            cb_turma.ValueMember = "id_turma"     ' Valor referencial usado no código


        Catch ex As Exception
            MsgBox("Erro ao carregar turmas: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conexao.Close()
        End Try
    End Sub

    Private Sub Btn_editar_Click_1(sender As Object, e As EventArgs) Handles Btn_editar.Click
        Dim idAluno As Integer
        Try
            idAluno = Convert.ToInt32(dgv_dados.CurrentRow.Cells("id_aluno").Value)
        Catch
            MsgBox("Selecione um aluno para editar.")
            Exit Sub
        End Try

        Dim resp As MsgBoxResult
        resp = MsgBox("Deseja realmente editar os dados do Aluno?", vbQuestion + vbYesNo, "ATENÇÃO")
        If resp = vbNo Then
            Exit Sub
        End If

        Dim novoNome As String = txt_nome.Text.Trim()
        Dim novoEmail As String = txt_email.Text.Trim()
        Dim novoRa As String = Txt_ra.Text.Trim()
        Dim novaTurmaId As Integer = Convert.ToInt32(cb_turma.SelectedValue)

        Try
            conexao.Open()
            Using transacao = conexao.BeginTransaction()

                AtualizarDados(idAluno, novoNome, novoEmail, novoRa, conexao, transacao)
                AtualizarRelacionamento("tb_alunos_turmas", "fk_id_aluno", "fk_id_turma", idAluno, cb_turma.SelectedValue, conexao)
                AtualizarOuInsereEndereco("tb_enderecos_alunos", "fk_id_aluno", idAluno,
                  Txt_rua.Text, Txt_numero.Text, Txt_bairro.Text, Txt_complemento.Text,
                  Txt_cidade.Text, Cmb_uf.Text, Txt_cep.Text,
                  conexao)
                AtualizaOuInsereTelefone("tb_telefones_alunos", "fk_id_aluno", idAluno, Txt_telefone.Text, conexao)

                transacao.Commit()
                MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Information)

            End Using
        Catch ex As Exception
            MsgBox("Erro ao atualizar: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conexao.Close()
        End Try

        Txt_buscar_TextChanged(Nothing, Nothing)
    End Sub

#Region "Rotinas de frontend"
    Private Sub Cmb_campo_TextChanged(sender As Object, e As EventArgs) Handles Cmb_campo.TextChanged
        'TODO:
        'LimparCampos()

        For Each item As String In Cmb_campo.Items
            If String.Equals(item, Cmb_campo.Text, StringComparison.OrdinalIgnoreCase) Then
                permiteAjax = True
                Txt_buscar_TextChanged(sender, e)
                Exit For
            End If
        Next

    End Sub

    Private Sub Btn_bloquear_Click(sender As Object, e As EventArgs) Handles Btn_bloquear.Click
        If txt_nome.Text = "" Then
            Exit Sub
        End If

        Dim sqlUpdateStatusAluno As String = "UPDATE tb_alunos
                                              SET
                                                  ativo = @status
                                              WHERE 
                                                  id_aluno = @id_aluno;"

        Try
            conexao.Open()

            Dim status = If((dgv_dados.CurrentRow.Cells("ativo").Value = 1), 0, 1)

            'TODO: Arrumar essa gambiarra
            dgv_dados.CurrentRow.Cells("ativo").Value = status


            Using cmdUpdateStatusAluno As New SQLiteCommand(sqlUpdateStatusAluno, conexao)
                cmdUpdateStatusAluno.Parameters.AddWithValue("@status", status)
                cmdUpdateStatusAluno.Parameters.AddWithValue("@id_aluno", dgv_dados.CurrentRow.Cells("id_aluno").Value)
                cmdUpdateStatusAluno.ExecuteNonQuery()
            End Using

            MsgBox($"Aluno {txt_nome.Text} {If((status = 1), "desbloqueado", "bloqueado")} com sucesso!", vbInformation + MsgBoxStyle.OkOnly, "Status atualizado!")
            Cmb_campo_TextChanged(sender, e)

        Catch ex As Exception

        Finally
            conexao.Close()
        End Try
    End Sub
#End Region
End Class