Imports System.Data.SQLite

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


    Private Sub Btn_cadastrar_Click(sender As Object, e As EventArgs) Handles Btn_cadastrar.Click
        If Cmb_nome_professor.Text = "" Or Cmb_nome_disciplina.Text = "" Or Cmb_nome_turma.Text = "" Then
            MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Cmb_nome_professor.Focus()
            Exit Sub
        End If
    End Sub


#Region "Rotinas de front-end"
    Private Sub Btn_limpar_campos_Click(sender As Object, e As EventArgs) Handles Btn_limpar_campos.Click
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
        Cmb_nome_professor.Text = ""
        Cmb_nome_disciplina.Text = ""
        Cmb_nome_turma.Text = ""
    End Sub



#End Region
End Class