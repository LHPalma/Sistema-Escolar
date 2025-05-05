Imports System.Data.SQLite

Public Class Frm_gerenContas

    Dim permiteAjax As Boolean = False

    Dim conexao As New SQLiteConnection(connectionString)

    Private Sub Txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_buscar.TextChanged

        If Cmb_campo.Text = "" Or Not permiteAjax Then
            Exit Sub
        End If


        Dim sqlAjax = $"SELECT * FROM tb_alunos WHERE {Cmb_campo.Text.ToLower()} LIKE '%{Txt_buscar.Text}%';"

        ' TODO: Dar uma pesquisada no como isso funciona #nebulosidades nebulosas
        Using cmdAjax As New SQLiteCommand(sqlAjax, conexao)
            conexao.Open()
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

            conexao.Close()
            dgv_dados.DataSource = dtAjax
        End Using

    End Sub


    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Dim row As DataGridViewRow = dgv_dados.Rows(e.RowIndex)
        txt_nome.Text = row.Cells("nome").Value.ToString()
        txt_email.Text = row.Cells("email").Value.ToString()
        txt_ra.Text = row.Cells("ra").Value.ToString()

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


    End Sub


    Private Sub Cmb_campo_TextChanged(sender As Object, e As EventArgs) Handles Cmb_campo.TextChanged
        ' Não funciona se o filho do draculo escrever em letra minúscula: nome != Nome
        'If Cmb_campo.Items.Contains(Cmb_campo.Text) Then
        '    permiteAjax = True
        '    Txt_buscar_TextChanged(sender, e)
        'Else
        '    permiteAjax = False
        'End If

        For Each item As String In Cmb_campo.Items
            If String.Equals(item, Cmb_campo.Text, StringComparison.OrdinalIgnoreCase) Then
                permiteAjax = True
                Txt_buscar_TextChanged(sender, e)
                Exit For
            End If
        Next

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

    'Para editar os dados de aluno no db
    Private Sub Btn_editar_Click_1(sender As Object, e As EventArgs) Handles Btn_editar.Click
        ' Recupera o ID do aluno selecionado
        Dim idAluno As Integer
        Try
            idAluno = Convert.ToInt32(dgv_dados.CurrentRow.Cells("id_aluno").Value)
        Catch
            MsgBox("Selecione um aluno para editar.")
            Exit Sub
        End Try

        ' Dados atualizados
        Dim novoNome As String = txt_nome.Text.Trim()
        Dim novoEmail As String = txt_email.Text.Trim()
        Dim novoRa As String = txt_ra.Text.Trim()
        Dim novaTurmaId As Integer = Convert.ToInt32(cb_turma.SelectedValue)

        Try
            conexao.Open()

            Using transacao = conexao.BeginTransaction()



                ' Atualizar os dados do aluno
                Dim sqlUpdateAluno As String = "UPDATE tb_alunos SET nome = @nome, email = @email, ra = @ra WHERE id_aluno = @id;"
                Using cmdAluno As New SQLiteCommand(sqlUpdateAluno, conexao)
                    cmdAluno.Parameters.AddWithValue("@nome", novoNome)
                    cmdAluno.Parameters.AddWithValue("@email", novoEmail)
                    cmdAluno.Parameters.AddWithValue("@ra", novoRa)
                    cmdAluno.Parameters.AddWithValue("@id", idAluno)
                    cmdAluno.ExecuteNonQuery()
                End Using

                ' Atualizar a turma do aluno
                Dim sqlUpdateTurma As String = "UPDATE tb_alunos_turmas SET fk_id_turma = @novaTurma WHERE fk_id_aluno = @idAluno;"
                Using cmdTurma As New SQLiteCommand(sqlUpdateTurma, conexao)
                    cmdTurma.Parameters.AddWithValue("@novaTurma", novaTurmaId)
                    cmdTurma.Parameters.AddWithValue("@idAluno", idAluno)
                    cmdTurma.ExecuteNonQuery()
                End Using

                transacao.Commit()

                MsgBox("Aluno atualizado com sucesso!", MsgBoxStyle.Information, "Sucesso")


            End Using 'Fim da transação

        Catch ex As Exception
            MsgBox("Erro ao atualizar aluno: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        Finally
            conexao.Close()
        End Try

        ' Atualizar a grid após edição
        Txt_buscar_TextChanged(Nothing, Nothing)
    End Sub

End Class