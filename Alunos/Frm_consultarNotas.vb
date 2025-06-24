Imports System.Data.SQLite

Public Class Frm_consultarNotas
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        If cmbDisciplina.SelectedIndex = -1 Then
            MessageBox.Show("Selecione uma disciplina!")
            Exit Sub
        End If

        Dim sql As String = "SELECT 
                            d.nome AS Disciplina,
                            p.nome AS Professor,
                            a.nome AS Avaliacao,
                            a.tipo AS Tipo,
                            a.peso AS Peso,
                            n.nota AS Nota,
                            a.data_avaliacao AS 'Data Avaliacao'
                         FROM tb_notas n
                         JOIN tb_avaliacoes a ON n.fk_id_avaliacao = a.id_avaliacao
                         JOIN tb_professores_disciplinas_turmas pdt ON a.fk_id_prof_disc_turma = pdt.id_prof_disc_turma
                         JOIN tb_disciplinas d ON pdt.fk_id_disciplina = d.id_disciplina
                         JOIN tb_professores p ON pdt.fk_id_professor = p.id_professor
                         WHERE n.fk_id_aluno = @idAluno AND d.id_disciplina = @idDisciplina
                         ORDER BY a.tipo;"

        Using conexao As New SQLiteConnection(connectionString)
            Using cmd As New SQLiteCommand(sql, conexao)

                cmd.Parameters.AddWithValue("@idAluno", Sessao.idUsuario)
                cmd.Parameters.AddWithValue("@idDisciplina", Convert.ToInt32(cmbDisciplina.SelectedValue))

                Dim dt As New DataTable()

                Try
                    conexao.Open()

                    Dim da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)

                    dgvNotas.DataSource = dt

                    'Cabeçalhos
                    dgvNotas.Columns("Disciplina").HeaderText = "Disciplina"
                    dgvNotas.Columns("Professor").HeaderText = "Professor"
                    dgvNotas.Columns("Avaliacao").HeaderText = "Avaliação"
                    dgvNotas.Columns("Tipo").HeaderText = "Tipo"
                    dgvNotas.Columns("Peso").HeaderText = "Peso"
                    dgvNotas.Columns("Nota").HeaderText = "Nota"
                    dgvNotas.Columns("Data Avaliacao").HeaderText = "Data"

                    'Calculando a média ponderada (para as notas)
                    CalcularMedia()

                Catch ex As Exception
                    MessageBox.Show("Erro ao consultar notas: " & ex.Message)
                End Try

            End Using
        End Using
    End Sub

    Private Sub CalcularMedia()

        Dim media As Double = 0
        Dim totalPeso As Double = 0

        For Each row As DataGridViewRow In dgvNotas.Rows
            If Not row.IsNewRow Then
                Dim nota As Double = Convert.ToDouble(row.Cells("Nota").Value)
                Dim peso As Double = Convert.ToDouble(row.Cells("Peso").Value)

                media += nota * peso
                totalPeso += peso
            End If
        Next

        'Evitando a divisao por zero
        If totalPeso > 0 Then
            media /= totalPeso
        End If

        txtMedia.Text = Math.Round(media, 2).ToString()

        'Alterando cor de acordo com a nota
        If media >= 7 Then
            txtMedia.BackColor = Color.LightGreen
            txtMedia.ForeColor = Color.Black
        ElseIf media >= 5 AndAlso media < 7 Then
            txtMedia.BackColor = Color.Khaki
            txtMedia.ForeColor = Color.Black
        ElseIf media < 5 Then
            txtMedia.BackColor = Color.LightCoral
            txtMedia.ForeColor = Color.White
        End If

    End Sub

    Private Sub cmbDisciplina_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbDisciplina.SelectionChangeCommitted
        dgvNotas.DataSource = Nothing
        txtMedia.Text = ""
        txtMedia.BackColor = Color.White
        txtMedia.ForeColor = Color.White
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

    Private Sub Frm_consultarNotas_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarregarDisciplinas()
        txtMedia.BackColor = Color.White
        txtMedia.ForeColor = Color.White
    End Sub
End Class