'Customizar o seletor de data com o DateTimerPicker. para mostrar apenas o ano.

Imports System.Data.SQLite

Public Class Frm_CadastroTurma
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

                Dim existeTurma As Boolean = BuscarExistencia("tb_turmas", "nome", Txt_nome.Text, conexao)

                If (existeTurma) Then
                    MessageBox.Show("Turma já cadastrada")
                    Txt_nome.Focus()
                    Exit Sub
                End If

                Dim sqlInsert As String = "INSERT INTO tb_turmas
                                               (nome, descricao, ano_letivo) 
                                           VALUES
                                               (@nome, @descricao, @ano_letivo);"

                Using cmdIsert As New SQLiteCommand(sqlInsert, conexao)
                    cmdIsert.Parameters.AddWithValue("@nome", Txt_nome.Text)
                    cmdIsert.Parameters.AddWithValue("@descricao", Txt_descricao.Text)
                    cmdIsert.Parameters.AddWithValue("@ano_letivo", Cmb_data.Value.Year)
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



#Region "Rotinas de front-end"
    Private Sub Btn_limpar_campos_Click(sender As Object, e As EventArgs) Handles Btn_limpar_campos.Click
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
        Txt_nome.Clear()
        Txt_descricao.Clear()
        Cmb_data.Value = DateTime.Now
    End Sub

    Private Sub Txt_nome_Leave(sender As Object, e As EventArgs) Handles Txt_nome.Leave
        Txt_nome.Text = ParaLetraMaiuscula(Txt_nome.Text)
    End Sub

#End Region
End Class