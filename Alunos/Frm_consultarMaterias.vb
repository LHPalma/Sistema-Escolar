Imports System.Data.SQLite

Public Class Frm_consultarMaterias




    Private Sub CarregarMaterias()

        Dim sql As String = "SELECT 
                            d.nome AS Disciplina, 
                            p.nome AS Professor, 
                            t.nome AS Turma
                         FROM tb_alunos_turmas ta
                         JOIN tb_turmas t ON ta.fk_id_turma = t.id_turma
                         JOIN tb_professores_disciplinas_turmas pdt ON pdt.fk_id_turma = t.id_turma
                         JOIN tb_disciplinas d ON pdt.fk_id_disciplina = d.id_disciplina
                         JOIN tb_professores p ON pdt.fk_id_professor = p.id_professor
                         WHERE ta.fk_id_aluno = @idAluno"

        Using conexao As New SQLiteConnection(connectionString)
            Using cmd As New SQLiteCommand(sql, conexao)

                'Id do aluno logado na sessão
                cmd.Parameters.AddWithValue("@idAluno", Sessao.idUsuario)

                Dim dt As New DataTable()

                Try
                    conexao.Open()

                    Dim da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)

                    dgvMaterias.DataSource = dt

                    dgvMaterias.Columns(0).HeaderText = "Disciplina"
                    dgvMaterias.Columns(1).HeaderText = "Professor"
                    dgvMaterias.Columns(2).HeaderText = "Turma"

                Catch ex As Exception
                    MessageBox.Show("Erro ao carregar matérias: " & ex.Message)
                End Try

            End Using
        End Using

    End Sub

    Private Sub Frm_consultarMaterias_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarregarMaterias()
    End Sub
End Class