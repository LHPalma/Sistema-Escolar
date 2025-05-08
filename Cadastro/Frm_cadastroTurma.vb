'Customizar o seletor de data com o DateTimerPicker. para mostrar apenas o ano.

Imports System.Data.SQLite

Public Class Frm_cadastroTurma
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Cmb_data.ValueChanged

    End Sub

    Private Sub Btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If Txt_nome.Text = "" Then
            MessageBox.Show("Preencha o campo Nome")
            Txt_nome.Focus()
            Exit Sub
        End If


        Using conexao As New SQLiteConnection(connectionString)
            Try
                conexao.Open()

                Dim sqlVerificar As String = "SELECT COUNT(*) FROM tb_turmas WHERE nome = @nome"
                Using cmdVerificar As New SQLiteCommand(sqlVerificar, conexao)
                    cmdVerificar.Parameters.AddWithValue("@nome", Txt_nome.Text)
                    Dim qtdTurmas As Integer = Integer.Parse(cmdVerificar.ExecuteScalar())
                    If qtdTurmas > 0 Then
                        MessageBox.Show("Turma já cadastrada")
                        Txt_nome.Focus()
                        Exit Sub
                    End If
                End Using

                Dim sqlInsert As String = "INSERT INTO tb_turmas (nome, descricao) VALUES (@nome, @descricao)"
                Using cmdIsert As New SQLiteCommand(sqlInsert, conexao)
                    cmdIsert.Parameters.AddWithValue("@nome", Txt_nome.Text)
                    cmdIsert.Parameters.AddWithValue("@descricao", Txt_descricao.Text)
                    cmdIsert.ExecuteNonQuery()
                End Using
                MessageBox.Show("Turma cadastrada com sucesso!")
                LimparCampos()

            Catch ex As Exception
                MsgBox("Erro ao cadastrar turma: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")

            Finally
                conexao.Close()
            End Try

        End Using
    End Sub

    Private Sub LimparCampos()
        Txt_nome.Clear()
        Txt_descricao.Clear()
        Cmb_data.Value = DateTime.Now
    End Sub
End Class