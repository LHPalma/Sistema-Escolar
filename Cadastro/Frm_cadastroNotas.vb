Imports System.Data.SQLite

Public Class Frm_cadastroNotas
    Private Function NotaExiste(idAvaliacao As Integer, idAluno As Integer, conexao As SQLiteConnection) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tb_notas WHERE fk_id_avaliacao = @avaliacao AND fk_id_aluno = @aluno"
        Using cmd As New SQLiteCommand(sql, conexao)
            cmd.Parameters.AddWithValue("@avaliacao", idAvaliacao)
            cmd.Parameters.AddWithValue("@aluno", idAluno)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click

        If cmbAvaliacao.SelectedIndex = -1 Then
            MessageBox.Show("Selecione uma avaliação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cmbAluno.SelectedIndex = -1 Then
            MessageBox.Show("Selecione um aluno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idAvaliacao As Integer = Convert.ToInt32(cmbAvaliacao.SelectedValue)
        Dim idAluno As Integer = Convert.ToInt32(cmbAluno.SelectedValue)
        Dim nota As Decimal = nudNota.Value

        Using conexao As New SQLiteConnection(connectionString)
            conexao.Open()

            If NotaExiste(idAvaliacao, idAluno, conexao) Then
                MessageBox.Show("Já existe uma nota cadastrada para este aluno nesta avaliação.", "Nota existente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim sql As String = "INSERT INTO tb_notas (fk_id_avaliacao, fk_id_aluno, nota, data_cadastro) 
                             VALUES (@avaliacao, @aluno, @nota, DATETIME('now', 'localtime'))"

            Using cmd As New SQLiteCommand(sql, conexao)
                cmd.Parameters.AddWithValue("@avaliacao", idAvaliacao)
                cmd.Parameters.AddWithValue("@aluno", idAluno)
                cmd.Parameters.AddWithValue("@nota", nota)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Nota cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimparCampos()
            End Using
        End Using
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'Validações
        If cmbAvaliacao.SelectedIndex = -1 Then
            MessageBox.Show("Selecione uma avaliação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cmbAluno.SelectedIndex = -1 Then
            MessageBox.Show("Selecione um aluno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idAvaliacao As Integer = Convert.ToInt32(cmbAvaliacao.SelectedValue)
        Dim idAluno As Integer = Convert.ToInt32(cmbAluno.SelectedValue)
        Dim novaNota As Decimal = nudNota.Value

        Using conexao As New SQLiteConnection(connectionString)
            conexao.Open()

            If Not NotaExiste(idAvaliacao, idAluno, conexao) Then
                MessageBox.Show("Não existe uma nota cadastrada para este aluno nesta avaliação.", "Nota não encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim sql As String = "UPDATE tb_notas 
                             SET nota = @nota, data_cadastro = DATETIME('now', 'localtime')
                             WHERE fk_id_avaliacao = @avaliacao AND fk_id_aluno = @aluno"

            Using cmd As New SQLiteCommand(sql, conexao)
                cmd.Parameters.AddWithValue("@nota", novaNota)
                cmd.Parameters.AddWithValue("@avaliacao", idAvaliacao)
                cmd.Parameters.AddWithValue("@aluno", idAluno)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Nota atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimparCampos()
            End Using
        End Using
    End Sub

    Private Sub LimparCampos()
        cmbAvaliacao.SelectedIndex = -1
        cmbAluno.SelectedIndex = -1
        nudNota.Value = 0
    End Sub

    Private Sub Frm_cadastroNotas_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarregarAvaliacoes()
        CarregarAvaliacoesConsulta()
        EstilizarDataGrid()
    End Sub

    Private Sub CarregarAvaliacoes()

        Dim sql As String = "SELECT id_avaliacao, 
                                 nome_professor || ' - ' || nome_disciplina || ' - ' || nome_turma || ' - ' || tipo || ' - ' || data_avaliacao AS descricao
                          FROM vw_avaliacoes"

        Using conexao As New SQLiteConnection(connectionString)
            Using cmd As New SQLiteCommand(sql, conexao)
                Dim dt As New DataTable()

                Try
                    conexao.Open()
                    Dim da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)

                    cmbAvaliacao.DataSource = dt
                    cmbAvaliacao.DisplayMember = "descricao"
                    cmbAvaliacao.ValueMember = "id_avaliacao"
                    cmbAvaliacao.SelectedIndex = -1

                Catch ex As Exception
                    MessageBox.Show("Erro ao carregar avaliações: " & ex.Message)
                End Try

            End Using
        End Using

    End Sub

    Private Sub CarregarAlunosDaAvaliacao(idAvaliacao As Integer)


        Dim idTurma As Integer = -1

        Dim sqlBuscaTurma As String = "SELECT pdt.fk_id_turma 
                                    FROM tb_avaliacoes a
                                    JOIN tb_professores_disciplinas_turmas pdt ON a.fk_id_prof_disc_turma = pdt.id_prof_disc_turma
                                    WHERE a.id_avaliacao = @id_avaliacao"

        Using conexao As New SQLiteConnection(connectionString)
            conexao.Open()

            Using cmdBusca As New SQLiteCommand(sqlBuscaTurma, conexao)
                cmdBusca.Parameters.AddWithValue("@id_avaliacao", idAvaliacao)

                Dim resultado = cmdBusca.ExecuteScalar()

                If resultado IsNot Nothing Then
                    idTurma = Convert.ToInt32(resultado)
                Else
                    MessageBox.Show("Turma não encontrada para esta avaliação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using


            Dim sqlAlunos As String = "SELECT a.id_aluno, a.nome 
                                   FROM tb_alunos a
                                   JOIN tb_alunos_turmas ta ON a.id_aluno = ta.fk_id_aluno
                                   WHERE ta.fk_id_turma = @id_turma"

            Using cmdAlunos As New SQLiteCommand(sqlAlunos, conexao)
                cmdAlunos.Parameters.AddWithValue("@id_turma", idTurma)

                Dim dt As New DataTable()
                Dim da As New SQLiteDataAdapter(cmdAlunos)
                da.Fill(dt)

                cmbAluno.DataSource = dt
                cmbAluno.DisplayMember = "nome"
                cmbAluno.ValueMember = "id_aluno"
                cmbAluno.SelectedIndex = -1
            End Using

        End Using

    End Sub

    Private Sub cmbAvaliacao_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbAvaliacao.SelectionChangeCommitted
        If cmbAvaliacao.SelectedIndex <> -1 Then
            Dim idAvaliacao As Integer = Convert.ToInt32(cmbAvaliacao.SelectedValue)
            CarregarAlunosDaAvaliacao(idAvaliacao)
        End If
    End Sub

    Private Sub CarregarNota(idAvaliacao As Integer, idAluno As Integer)

        Dim sql As String = "SELECT nota FROM tb_notas 
                          WHERE fk_id_avaliacao = @avaliacao AND fk_id_aluno = @aluno"

        Using conexao As New SQLiteConnection(connectionString)
            Using cmd As New SQLiteCommand(sql, conexao)
                cmd.Parameters.AddWithValue("@avaliacao", idAvaliacao)
                cmd.Parameters.AddWithValue("@aluno", idAluno)

                Try
                    conexao.Open()
                    Dim resultado = cmd.ExecuteScalar()

                    If resultado IsNot Nothing Then
                        nudNota.Value = Convert.ToDecimal(resultado)
                    Else
                        nudNota.Value = 0
                    End If

                Catch ex As Exception
                    MessageBox.Show("Erro ao buscar nota: " & ex.Message)
                End Try

            End Using
        End Using

    End Sub

    Private Sub cmbAluno_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbAluno.SelectionChangeCommitted
        If cmbAvaliacao.SelectedIndex <> -1 And cmbAluno.SelectedIndex <> -1 Then
            Dim idAvaliacao As Integer = Convert.ToInt32(cmbAvaliacao.SelectedValue)
            Dim idAluno As Integer = Convert.ToInt32(cmbAluno.SelectedValue)
            CarregarNota(idAvaliacao, idAluno)
        End If
    End Sub

    Private Sub CarregarNotasPorAvaliacao(idAvaliacao As Integer)

        Dim sql As String = "SELECT a.nome AS aluno, n.nota, av.tipo, av.nome AS avaliacao
                          FROM tb_notas n
                          JOIN tb_alunos a ON n.fk_id_aluno = a.id_aluno
                          JOIN tb_avaliacoes av ON n.fk_id_avaliacao = av.id_avaliacao
                          WHERE av.id_avaliacao = @avaliacao"

        Using conexao As New SQLiteConnection(connectionString)
            Using cmd As New SQLiteCommand(sql, conexao)
                cmd.Parameters.AddWithValue("@avaliacao", idAvaliacao)

                Dim dt As New DataTable()

                Try
                    conexao.Open()
                    Dim da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)

                    dgvNotas.DataSource = dt

                Catch ex As Exception
                    MessageBox.Show("Erro ao buscar notas: " & ex.Message)
                End Try

            End Using
        End Using

    End Sub

    Private Sub cmbAvaliacaoConsulta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbAvaliacaoConsulta.SelectionChangeCommitted
        If cmbAvaliacaoConsulta.SelectedIndex <> -1 Then
            Dim idAvaliacao As Integer = Convert.ToInt32(cmbAvaliacaoConsulta.SelectedValue)
            CarregarNotasPorAvaliacao(idAvaliacao)
        End If
    End Sub
    Private Sub EstilizarDataGrid()

        With dgvNotas
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowHeadersVisible = False
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.DodgerBlue
            .DefaultCellStyle.SelectionForeColor = Color.White
        End With

    End Sub

    Private Sub CarregarAvaliacoesConsulta()

        Dim sql As String = "SELECT id_avaliacao, 
                                 nome_professor || ' - ' || nome_disciplina || ' - ' || nome_turma || ' - ' || tipo || ' - ' || data_avaliacao AS descricao
                          FROM vw_avaliacoes"

        Using conexao As New SQLiteConnection(connectionString)
            Using cmd As New SQLiteCommand(sql, conexao)
                Dim dt As New DataTable()

                Try
                    conexao.Open()
                    Dim da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)

                    cmbAvaliacaoConsulta.DataSource = dt
                    cmbAvaliacaoConsulta.DisplayMember = "descricao"
                    cmbAvaliacaoConsulta.ValueMember = "id_avaliacao"
                    cmbAvaliacaoConsulta.SelectedIndex = -1

                Catch ex As Exception
                    MessageBox.Show("Erro ao carregar avaliações: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using
        End Using

    End Sub


End Class