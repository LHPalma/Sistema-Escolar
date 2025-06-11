Imports System.Data.SQLite

Public Class Frm_GerenciamentoProfessores

    Dim conexao As New SQLiteConnection(connectionString)
    Dim permiteAjax As Boolean = False

    Private Sub Txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles Txt_buscar.TextChanged

        If Cmb_campo.Text = "" Or Not permiteAjax Then
            Exit Sub
        End If

        Dgv_dados.DataSource = FazAjax(conexao, "tb_professores", Cmb_campo.Text, Txt_buscar.Text)

    End Sub


    Private Sub Cmb_campo_TextChanged(sender As Object, e As EventArgs) Handles Cmb_campo.TextChanged
        ' Não funciona se o filho do draculo escrever em letra minúscula: nome != Nome
        'If Cmb_campo.Items.Contains(Cmb_campo.Text) Then
        '    permiteAjax = True
        '    Txt_buscar_TextChanged(sender, e)
        'Else
        '    permiteAjax = False
        'End If

        For Each item As String In Cmb_campo.Items
            If String.Equals(item, Cmb_campo.Text, StringComparison.OrdinalIgnoreCase) Then
                permiteAjax = True
                Txt_buscar_TextChanged(Nothing, Nothing)
                Exit For
            End If
        Next
    End Sub


    Private Sub Dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_dados.CellContentClick
        Dim row As DataGridViewRow = Dgv_dados.Rows(e.RowIndex)
        txt_nome.Text = row.Cells("nome").Value.ToString()
        Txt_email.Text = row.Cells("email").Value.ToString()

        'Preenche com Endereço
        Try
            conexao.Open()
            Dim sqlEndereco As String = "SELECT * FROM tb_enderecos_professores WHERE fk_id_professor = @id_professor;"
            Using cmdEndereco As New SQLiteCommand(sqlEndereco, conexao)
                cmdEndereco.Parameters.AddWithValue("@id_professor", row.Cells("id_professor").Value.ToString())
                Using readerEndereco As SQLiteDataReader = cmdEndereco.ExecuteReader()
                    If readerEndereco.Read() Then
                        Txt_rua.Text = readerEndereco("rua").ToString()
                        Txt_numero.Text = readerEndereco("numero").ToString()
                        Txt_bairro.Text = readerEndereco("bairro").ToString()
                        Txt_cidade.Text = readerEndereco("cidade").ToString()
                        Cmb_uf.Text = readerEndereco("uf").ToString()
                        Txt_complemento.Text = readerEndereco("complemento").ToString()
                        Txt_cep.Text = readerEndereco("cep").ToString()
                    Else
                        Txt_rua.Text = ""
                        Txt_numero.Text = ""
                        Txt_bairro.Text = ""
                        Txt_cidade.Text = ""
                        Cmb_uf.Text = ""
                        Txt_complemento.Text = ""
                        Txt_cep.Text = ""
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erro ao buscar endereço do Professor: " & ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Erro")
        Finally
            conexao.Close()
        End Try

        'Preenche com Telefone
        Try
            conexao.Open()
            Dim sqlTelefone As String = "SELECT numero FROM tb_telefones_professores WHERE fk_id_professor = @id_professor;"
            Using cmdTelefone As New SQLiteCommand(sqlTelefone, conexao)
                cmdTelefone.Parameters.AddWithValue("@id_professor", row.Cells("id_professor").Value.ToString())

                Using readerTelefone As SQLiteDataReader = cmdTelefone.ExecuteReader()
                    If readerTelefone.Read() Then
                        Txt_telefone.Text = readerTelefone("numero").ToString()
                    Else
                        Txt_telefone.Text = ""
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erro ao buscar endereço e telefone do Professor: " & ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Erro")
        Finally
            conexao.Close()
        End Try

        'TODO: Campo cpf no Banco de Dados
        'Txt_cpf.Text = Dgv_dados.CurrentRow.Cells("cpf").Value.ToString()

        'TODO: 
        'Txt_telefone.Text = Dgv_dados.CurrentRow.Cells("telefone").Value.ToString()


    End Sub


    Private Sub Btn_editar_Click(sender As Object, e As EventArgs)

    End Sub
End Class