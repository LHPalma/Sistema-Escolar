Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Frm_cadastroAvaliacao
    Private Sub Frm_cadastroAvaliacao_Load(sender As Object, e As EventArgs) Handles Me.Load
        Using conexao As New SQLiteConnection(connectionString)
            Dim cmd As New SQLiteCommand("SELECT id_prof_disc_turma, nome FROM vw_prof_disc_turma", conexao)
            Dim da As New SQLiteDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            With Cb_turma
                .DataSource = dt
                .DisplayMember = "nome"
                .ValueMember = "id_prof_disc_turma"
            End With
        End Using
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Using conexao As New SQLiteConnection(connectionString)
            conexao.Open()

            If Txt_nome.Text = "" Or Cb_turma.Text = "" Or Cb_tipo.Text = "" Or dtpDataAvaliacao.Text = "" Then
                MsgBox("Para cadastrar, preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                Exit Sub
            End If

            If nudPeso.Value <= 0 OrElse nudPeso.Value > 1 Then
                MessageBox.Show("O peso deve estar entre 0.01 e 1.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If dtpDataAvaliacao.Value.Date < Date.Today Then
                MessageBox.Show("A data da avaliação não pode ser anterior a hoje.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim query As String = "
                                    SELECT COUNT(*) FROM tb_avaliacoes 
                                    WHERE nome = @nome AND tipo = @tipo AND fk_id_prof_disc_turma = @fk"
            Dim cmdCheck As New SQLiteCommand(query, conexao)
            cmdCheck.Parameters.AddWithValue("@nome", Txt_nome.Text.Trim())
            cmdCheck.Parameters.AddWithValue("@tipo", Cb_tipo.Text)
            cmdCheck.Parameters.AddWithValue("@fk", Cb_turma.SelectedValue)

            Dim qtd As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
            If qtd > 0 Then
                MessageBox.Show("Já existe uma avaliação com esse nome e tipo para essa turma.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim cmd As New SQLiteCommand("
                                            INSERT INTO tb_avaliacoes (fk_id_prof_disc_turma, nome, tipo, peso, data_avaliacao)
                                            VALUES (@fk, @nome, @tipo, @peso, @data)
                                            ", conexao)

            cmd.Parameters.AddWithValue("@fk", Cb_turma.SelectedValue)
            cmd.Parameters.AddWithValue("@nome", Txt_nome.Text)
            cmd.Parameters.AddWithValue("@tipo", Cb_tipo.Text)
            cmd.Parameters.AddWithValue("@peso", nudPeso.Value)
            cmd.Parameters.AddWithValue("@data", dtpDataAvaliacao.Value.ToString("yyyy-MM-dd"))

            cmd.ExecuteNonQuery()

            MessageBox.Show("Avaliação cadastrada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Txt_nome.Text = ""
            nudPeso.Text = ""
            Cb_tipo.Text = ""
            Cb_turma.Text = ""


        End Using
    End Sub
End Class
