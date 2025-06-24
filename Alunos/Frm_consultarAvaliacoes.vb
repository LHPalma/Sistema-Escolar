Imports System.Data.SQLite

Public Class Frm_consultarAvaliacoes

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        If cmbDisciplina.SelectedIndex = -1 Then
            MessageBox.Show("Selecione uma disciplina para consultar!")
            Exit Sub
        End If

        Dim sql As String = "SELECT 
                            d.nome AS Disciplina,
                            p.nome AS Professor,
                            a.nome AS Avaliacao,
                            a.tipo AS Tipo,
                            a.peso AS Peso,
                            a.data_avaliacao AS 'Data Avaliacao'
                         FROM tb_avaliacoes a
                         JOIN tb_professores_disciplinas_turmas pdt ON a.fk_id_prof_disc_turma = pdt.id_prof_disc_turma
                         JOIN tb_disciplinas d ON pdt.fk_id_disciplina = d.id_disciplina
                         JOIN tb_professores p ON pdt.fk_id_professor = p.id_professor
                         JOIN tb_alunos_turmas ta ON pdt.fk_id_turma = ta.fk_id_turma
                         WHERE ta.fk_id_aluno = @idAluno
                           AND d.id_disciplina = @idDisciplina
                         ORDER BY a.data_avaliacao;"

        Using conexao As New SQLiteConnection(connectionString)
            Using cmd As New SQLiteCommand(sql, conexao)

                cmd.Parameters.AddWithValue("@idAluno", Sessao.idUsuario)
                cmd.Parameters.AddWithValue("@idDisciplina", Convert.ToInt32(cmbDisciplina.SelectedValue))

                Dim dt As New DataTable()

                Try
                    conexao.Open()

                    Dim da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)

                    dgvAvaliacoes.DataSource = dt

                    dgvAvaliacoes.Columns("Disciplina").HeaderText = "Disciplina"
                    dgvAvaliacoes.Columns("Professor").HeaderText = "Professor"
                    dgvAvaliacoes.Columns("Avaliacao").HeaderText = "Avaliação"
                    dgvAvaliacoes.Columns("Tipo").HeaderText = "Tipo"
                    dgvAvaliacoes.Columns("Peso").HeaderText = "Peso"
                    dgvAvaliacoes.Columns("Data Avaliacao").HeaderText = "Data Avaliação"

                Catch ex As Exception
                    MessageBox.Show("Erro ao consultar avaliações: " & ex.Message)
                End Try

            End Using
        End Using

    End Sub

    Private Sub Frm_consultarAvaliacoes_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarregarDisciplinas()
    End Sub

    Private Sub CarregarDisciplinas()

        Dim sql As String = "SELECT 
                            d.id_disciplina,
                            d.nome AS disciplina
                         FROM tb_alunos_turmas ta
                         JOIN tb_professores_disciplinas_turmas pdt ON pdt.fk_id_turma = ta.fk_id_turma
                         JOIN tb_disciplinas d ON pdt.fk_id_disciplina = d.id_disciplina
                         WHERE ta.fk_id_aluno = @idAluno"

        Using conexao As New SQLiteConnection(connectionString)
            Using cmd As New SQLiteCommand(sql, conexao)

                cmd.Parameters.AddWithValue("@idAluno", Sessao.idUsuario)

                Dim dt As New DataTable()

                Try
                    conexao.Open()

                    Dim da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)

                    cmbDisciplina.DataSource = dt
                    cmbDisciplina.DisplayMember = "disciplina"
                    cmbDisciplina.ValueMember = "id_disciplina"
                    cmbDisciplina.SelectedIndex = -1

                Catch ex As Exception
                    MessageBox.Show("Erro ao carregar disciplinas: " & ex.Message)
                End Try

            End Using
        End Using
    End Sub

    Private Sub cmbDisciplina_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbDisciplina.SelectionChangeCommitted
        dgvAvaliacoes.DataSource = Nothing
    End Sub

End Class