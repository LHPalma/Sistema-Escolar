Imports System.Data.SQLite

Public Class Frm_CadastroDisciplina
    Private Sub Btn_cadastrar_Click(sender As Object, e As EventArgs)
        If (Txt_nome.Text = "" Or Num_carga_horaria.Value = vbEmpty) Then
            MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
            Txt_nome.Focus()
            Exit Sub
        End If

        Using conexao As New SQLiteConnection(connectionString)
            Try
                conexao.Open()
                Dim existeDisciplina As Boolean = BuscarExistencia("tb_disciplinas", "nome", Txt_nome.Text, conexao)
                If (existeDisciplina) Then
                    MsgBox("Disciplina já cadastrada", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                    Txt_nome.Focus()
                    Exit Sub
                End If

                Dim sqlInsert As String = "INSERT INTO tb_disciplinas
                                                (nome, descricao, carga_horaria) 
                                            VALUES
                                                (@nome, @descricao, @carga_horaria);"

                Using cmdInsert As New SQLiteCommand(sqlInsert, conexao)
                    cmdInsert.Parameters.AddWithValue("@nome", Txt_nome.Text)
                    cmdInsert.Parameters.AddWithValue("@descricao", Txt_descricao.Text)
                    cmdInsert.Parameters.AddWithValue("@carga_horaria", Num_carga_horaria.Value)
                    cmdInsert.ExecuteNonQuery()
                End Using
                MsgBox("Disciplina cadastrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
                LimparCampos()

            Catch ex As Exception
                MsgBox("Erro ao cadastrar disciplina: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")

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
        Txt_nome.Clear()
        Txt_descricao.Clear()
        Num_carga_horaria.Value = 16
    End Sub

    Private Sub Txt_nome_Leave(sender As Object, e As EventArgs) Handles Txt_nome.Leave
        Txt_nome.Text = ParaLetraMaiuscula(Txt_nome.Text)
    End Sub
#End Region
End Class