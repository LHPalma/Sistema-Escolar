Imports System.Data.SQLite

Public Class CadastroFaltas_FRM
    Private Sub CarregarProfDiscTurma()

        Dim sql As String = "SELECT id_prof_disc_turma, nome FROM vw_prof_disc_turma"

        Using conexao As New SQLiteConnection(connectionString)
            Using cmd As New SQLiteCommand(sql, conexao)
                Dim dt As New DataTable()

                Try
                    conexao.Open()
                    Dim da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)

                    cmbProfDiscTurma.DataSource = dt
                    cmbProfDiscTurma.DisplayMember = "nome"
                    cmbProfDiscTurma.ValueMember = "id_prof_disc_turma"
                    cmbProfDiscTurma.SelectedIndex = -1

                Catch ex As Exception
                    MessageBox.Show("Erro ao carregar dados: " & ex.Message)
                End Try

            End Using
        End Using

    End Sub

    Private Sub CarregarAlunos(idProfDiscTurma As Integer)

        Dim sql As String = "SELECT a.id_aluno, a.nome
                          FROM tb_alunos a
                          JOIN tb_alunos_turmas ta ON a.id_aluno = ta.fk_id_aluno
                          JOIN tb_professores_disciplinas_turmas pdt ON ta.fk_id_turma = pdt.fk_id_turma
                          WHERE pdt.id_prof_disc_turma = @id"

        Using conexao As New SQLiteConnection(connectionString)
            Using cmd As New SQLiteCommand(sql, conexao)
                cmd.Parameters.AddWithValue("@id", idProfDiscTurma)

                Dim dt As New DataTable()
                Dim da As New SQLiteDataAdapter(cmd)
                da.Fill(dt)

                cmbAluno.DataSource = dt
                cmbAluno.DisplayMember = "nome"
                cmbAluno.ValueMember = "id_aluno"
                cmbAluno.SelectedIndex = -1

            End Using
        End Using

    End Sub

    Private Sub SalvarFalta(idProfDiscTurma As Integer, idAluno As Integer, quantidade As Integer)

        Using conexao As New SQLiteConnection(connectionString)
            conexao.Open()

            Dim sqlInsert As String = "INSERT INTO tb_faltas (fk_id_prof_disc_turma, fk_id_aluno, data_falta, quantidade) 
                                           VALUES (@idProfDiscTurma, @idAluno, @dataFalta, @quantidade)"

            Using cmdInsert As New SQLiteCommand(sqlInsert, conexao)
                cmdInsert.Parameters.AddWithValue("@idProfDiscTurma", idProfDiscTurma)
                cmdInsert.Parameters.AddWithValue("@idAluno", idAluno)
                cmdInsert.Parameters.AddWithValue("@dataFalta", dtpDataFalta.Value.ToString("yyyy-MM-dd"))
                cmdInsert.Parameters.AddWithValue("@quantidade", nudFaltas.Value)

                cmdInsert.ExecuteNonQuery()
            End Using

            MessageBox.Show("Falta lançada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimparCampos()
        End Using

    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click

        If cmbProfDiscTurma.SelectedIndex = -1 Or cmbAluno.SelectedIndex = -1 Then
            MessageBox.Show("Selecione todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If nudFaltas.Value <= 0 Then
            MessageBox.Show("Insira uma quantia válida de faltas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpDataFalta.Value.Date < Date.Today Then
            MessageBox.Show("A data da falta não pode ser anterior a hoje.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idProfDiscTurma As Integer = Convert.ToInt32(cmbProfDiscTurma.SelectedValue)
        Dim idAluno As Integer = Convert.ToInt32(cmbAluno.SelectedValue)
        Dim quantidade As Integer = Convert.ToInt32(nudFaltas.Value)

        SalvarFalta(idProfDiscTurma, idAluno, quantidade)

    End Sub
    Private Sub Frm_cadastroFaltas_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarregarProfDiscTurma()
    End Sub

    Private Sub cmbProfDiscTurma_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbProfDiscTurma.SelectionChangeCommitted
        If cmbProfDiscTurma.SelectedIndex <> -1 Then
            Dim idProfDiscTurma As Integer = Convert.ToInt32(cmbProfDiscTurma.SelectedValue)
            CarregarAlunos(idProfDiscTurma)
            txtFaltasTotais.Text = "Selecione um Aluno"
            dgvFaltas.DataSource = Nothing
        End If
    End Sub

    Private Sub cmbAluno_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbAluno.SelectionChangeCommitted

        dgvFaltas.DataSource = Nothing

        Dim sqlFaltasTotais As String = "SELECT SUM(quantidade) 
                                     FROM tb_faltas 
                                     WHERE fk_id_prof_disc_turma = @idProfDiscTurma 
                                       AND fk_id_aluno = @idAluno"

        Using conexao As New SQLiteConnection(connectionString)

            Try
                conexao.Open()

                Dim idProfDiscTurma As Integer = Convert.ToInt32(cmbProfDiscTurma.SelectedValue)
                Dim idAluno As Integer = Convert.ToInt32(cmbAluno.SelectedValue)

                Using cmd As New SQLiteCommand(sqlFaltasTotais, conexao)
                    cmd.Parameters.AddWithValue("@idProfDiscTurma", idProfDiscTurma)
                    cmd.Parameters.AddWithValue("@idAluno", idAluno)

                    Dim resultado As Object = cmd.ExecuteScalar()

                    If resultado IsNot DBNull.Value AndAlso resultado IsNot Nothing Then
                        txtFaltasTotais.Text = resultado.ToString()
                    Else
                        txtFaltasTotais.Text = "0"
                    End If

                End Using

            Catch ex As Exception
                MessageBox.Show("Erro ao calcular faltas totais: " & ex.Message)
            End Try

        End Using
    End Sub

    Private Sub CarregarConsultaFaltas(idProfDiscTurma As Integer, idAluno As Integer)

        Dim sql As String = "SELECT 
                            a.nome AS Aluno,
                            f.quantidade AS Faltas,
                            f.data_falta AS 'Data da Falta',
                            f.data_registro AS 'Data de Registro'
                          FROM tb_faltas f
                          JOIN tb_alunos a ON f.fk_id_aluno = a.id_aluno
                          WHERE f.fk_id_prof_disc_turma = @idProfDiscTurma 
                            AND f.fk_id_aluno = @idAluno"

        Using conexao As New SQLiteConnection(connectionString)
            Using cmd As New SQLiteCommand(sql, conexao)
                cmd.Parameters.AddWithValue("@idProfDiscTurma", idProfDiscTurma)
                cmd.Parameters.AddWithValue("@idAluno", idAluno)

                Dim dt As New DataTable()

                Try
                    conexao.Open()
                    Dim da As New SQLiteDataAdapter(cmd)
                    da.Fill(dt)

                    dgvFaltas.DataSource = dt

                    EstilizarDataGridView()

                Catch ex As Exception
                    MessageBox.Show("Erro ao carregar faltas: " & ex.Message)
                End Try

            End Using
        End Using

    End Sub


    Private Sub EstilizarDataGridView()

        With dgvFaltas
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowHeadersVisible = False

            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.SteelBlue
            .DefaultCellStyle.SelectionForeColor = Color.White
        End With

    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click

        If cmbProfDiscTurma.SelectedIndex = -1 Then
            MessageBox.Show("Selecione a relação Professor - Disciplina - Turma!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cmbAluno.SelectedIndex = -1 Then
            MessageBox.Show("Selecione o Aluno que deseja consultar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idProfDiscTurma As Integer = Convert.ToInt32(cmbProfDiscTurma.SelectedValue)
        Dim idAluno As Integer = Convert.ToInt32(cmbAluno.SelectedValue)
        CarregarConsultaFaltas(idProfDiscTurma, idAluno)

    End Sub

    Private Sub LimparCampos()
        dgvFaltas.DataSource = Nothing
        txtFaltasTotais.Text = ""
        cmbAluno.SelectedIndex = -1
        cmbProfDiscTurma.SelectedIndex = -1
        nudFaltas.Value = 1
    End Sub

    Private Sub nudFaltas_ValueChanged(sender As Object, e As EventArgs) Handles nudFaltas.ValueChanged

    End Sub
End Class