Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles

Public Class Frm_GerenciamentoDisciplinas
    Private Sub Frm_GerenciamentoDisciplinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using conexao As New SQLiteConnection(connectionString)
            Try
                conexao.Open()
                PreencherComboBox("nome", "tb_professores", conexao, Cmb_nome_professor)
                PreencherComboBox("nome", "tb_disciplinas", conexao, Cmb_nome_disciplina)
                PreencherComboBox("nome", "tb_turmas", conexao, Cmb_nome_turma)

            Catch ex As Exception
                MsgBox("Erro ao carregar professores: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")

            Finally
                conexao.Close()
            End Try

        End Using

    End Sub


    Private Sub Btn_cadastrar_Click(sender As Object, e As EventArgs)
        If Cmb_nome_professor.Text = "" Or Cmb_nome_disciplina.Text = "" Or Cmb_nome_turma.Text = "" Then
            MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Cmb_nome_professor.Focus()
            Exit Sub
        End If


        Using conexao As New SQLiteConnection(connectionString)
            Try
                conexao.Open()
                Dim id_professor As Integer = ObterId("id_professor", "tb_professores", "nome", Cmb_nome_professor.Text, conexao)
                Dim id_disciplina As Integer = ObterId("id_disciplina", "tb_disciplinas", "nome", Cmb_nome_disciplina.Text, conexao)
                Dim id_turma As Integer = ObterId("id_turma", "tb_turmas", "nome", Cmb_nome_turma.Text, conexao)

                Dim sqlInsert As String = "INSERT INTO tb_professores_disciplinas_turmas
                                                (fk_id_professor, fk_id_disciplina, fk_id_turma) 
                                            VALUES
                                                (@fk_id_professor, @fk_id_disciplina, @fk_id_turma);"

                Using cmdInsert As New SQLiteCommand(sqlInsert, conexao)
                    cmdInsert.Parameters.AddWithValue("@fk_id_professor", id_professor)
                    cmdInsert.Parameters.AddWithValue("@fk_id_disciplina", id_disciplina)
                    cmdInsert.Parameters.AddWithValue("@fk_id_turma", id_turma)
                    cmdInsert.ExecuteNonQuery()
                End Using
                MsgBox($"Disciplina {Cmb_nome_disciplina.Text} foi associada ao professor(a) {Cmb_nome_professor.Text} e a turma {Cmb_nome_turma.Text} com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
                LimparCampos()
            Catch ex As Exception
                MsgBox($"Erro ao associar disciplina {ex.Message}", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")

            Finally
                conexao.Close()

            End Try

        End Using

    End Sub

#Region "Rotinas de front-end"
    Private Sub Btn_limpar_campos_Click(sender As Object, e As EventArgs)
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
        Cmb_nome_professor.Text = ""
        Cmb_nome_disciplina.Text = ""
        Cmb_nome_turma.Text = ""
    End Sub



#End Region
End Class