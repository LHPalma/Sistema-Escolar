Imports System.Data.SQLite

Public Class Frm_consultarFaltas
    Private Sub Frm_consultarFaltas_Load(sender As Object, e As EventArgs) Handles Me.Load
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
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If cmbDisciplina.SelectedIndex = -1 Then
            MessageBox.Show("Selecione uma disciplina!")
            Exit Sub
        End If

        Dim sql As String = "SELECT 
                            d.nome AS Disciplina,
                            p.nome AS Professor,
                            f.data_falta AS 'Data da Falta',
                            f.quantidade AS Quantidade
                         FROM tb_faltas f
                         JOIN tb_professores_disciplinas_turmas pdt ON f.fk_id_prof_disc_turma = pdt.id_prof_disc_turma
                         JOIN tb_disciplinas d ON pdt.fk_id_disciplina = d.id_disciplina
                         JOIN tb_professores p ON pdt.fk_id_professor = p.id_professor
                         WHERE f.fk_id_aluno = @idAluno AND d.id_disciplina = @idDisciplina
                         ORDER BY f.data_falta DESC"

        Using conexao As New SQLiteConnection(connectionString)
            Using cmd As New SQLiteCommand(sql, conexao)

                cmd.Parameters.AddWithValue("@idAluno", Sessao.idUsuario)
                cmd.Parameters.AddWithValue("@idDisciplina", Convert.ToInt32(cmbDisciplina.SelectedValue))

                Dim dt As New DataTable()

                Try
                    conexao.Open()

                    Dim da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)

                    dgvFaltas.DataSource = dt


                    dgvFaltas.Columns(0).HeaderText = "Disciplina"
                    dgvFaltas.Columns(1).HeaderText = "Professor"
                    dgvFaltas.Columns(2).HeaderText = "Data da Falta"
                    dgvFaltas.Columns(3).HeaderText = "Quantidade"

                Catch ex As Exception
                    MessageBox.Show("Erro ao consultar faltas: " & ex.Message)
                End Try

                'Somaa a coluna "Quantidade" do dgvFaltas
                Dim totalFaltas As Integer = 0

                For Each row As DataGridViewRow In dgvFaltas.Rows
                    If Not row.IsNewRow Then
                        totalFaltas += Convert.ToInt32(row.Cells("Quantidade").Value)
                    End If
                Next

                'Exibe na TextBox
                txtTotalFaltas.Text = totalFaltas.ToString()

                'Alterando a cor por quantidade de Faltas, mt poggers
                If totalFaltas <= 10 Then
                    txtTotalFaltas.BackColor = Color.LightGreen
                    txtTotalFaltas.ForeColor = Color.Black
                ElseIf totalFaltas > 10 AndAlso totalFaltas <= 20 Then
                    txtTotalFaltas.BackColor = Color.Khaki
                    txtTotalFaltas.ForeColor = Color.Black
                ElseIf totalFaltas > 20 Then
                    txtTotalFaltas.BackColor = Color.LightCoral
                    txtTotalFaltas.ForeColor = Color.White
                End If

            End Using
        End Using
    End Sub

    Private Sub cmbDisciplina_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbDisciplina.SelectionChangeCommitted
        dgvFaltas.DataSource = Nothing
        txtTotalFaltas.Text = ""
    End Sub

    Private Sub cmbDisciplina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDisciplina.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class