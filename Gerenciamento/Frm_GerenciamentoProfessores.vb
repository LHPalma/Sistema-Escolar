Imports System.Data.SQLite

Public Class Frm_GerenciamentoProfessores

    Dim btnVoltarFoiClicado As Boolean = False

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
        Txt_cpf.Text = row.Cells("cpf").Value.ToString()
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

            '3 Busca foto
            Dim sqlFoto As String = $"SELECT a.caminho
                                              FROM tb_arquivos a
                                              INNER JOIN tb_arquivos_professores aa 
                                              WHERE aa.fk_id_professor = @id_professor
                                                AND a.tipo = 'perfil';
                                         "
            Dim caminho As String
            Using cmd As New SQLiteCommand(sqlFoto, conexao)
                cmd.Parameters.AddWithValue("@id_professor", Convert.ToInt32(row.Cells("id_professor").Value))

                caminho = cmd.ExecuteScalar()
            End Using

            If caminho IsNot Nothing Then
                img_foto.Load(caminho)
            Else
                img_foto.Load(Application.StartupPath & "\icones\nova_foto.png")
            End If

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


    Private Sub Btn_editar_Click(sender As Object, e As EventArgs) Handles Btn_editar.Click

        Dim idProfessor As Integer = Convert.ToInt32(Dgv_dados.CurrentRow.Cells("id_professor").Value)
        Dim novoNome As String = txt_nome.Text
        Dim novoEmail As String = Txt_email.Text
        Dim novoCPF As String = Txt_cpf.Text

        Dim novoTelefone As String = Txt_telefone.Text

        Dim novoRua As String = Txt_rua.Text
        Dim novoNumero As String = Txt_numero.Text
        Dim novoBairro As String = Txt_bairro.Text
        Dim novaCidade As String = Txt_cidade.Text
        Dim novoUf As String = Cmb_uf.Text
        Dim novoComplemento As String = Txt_complemento.Text
        Dim novoCep As String = Txt_cep.Text


        Using conexao As New SQLiteConnection(connectionString)
            Try
                conexao.Open()
                Using transacao = conexao.BeginTransaction()
                    ' Atualiza os dados do professor
                    Dim sqlUpdateProfessor As String = "
                    UPDATE tb_professores 
                    SET
                        nome = @nome,
                        cpf = @cpf,
                        email = @email
                    WHERE id_professor = @id_professor;"

                    Using cmdUpdateProfessor As New SQLiteCommand(sqlUpdateProfessor, conexao)
                        cmdUpdateProfessor.Parameters.AddWithValue("@nome", novoNome)
                        cmdUpdateProfessor.Parameters.AddWithValue("@cpf", novoCPF)
                        cmdUpdateProfessor.Parameters.AddWithValue("@email", novoEmail)
                        cmdUpdateProfessor.Parameters.AddWithValue("@id_professor", idProfessor)
                        cmdUpdateProfessor.ExecuteNonQuery()
                    End Using

                    ' Atualiza o endereço do professor
                    Dim sqlUpdateEndereco As String = "
                    UPDATE tb_enderecos_professores
                    SET
                        rua = @rua, 
                        numero = @numero, 
                        bairro = @bairro, 
                        cidade = @cidade, 
                        uf = @uf, 
                        complemento = @complemento,
                        cep = @cep 
                    WHERE fk_id_professor = @id_professor;"


                    Using cmdUpdateEndereco As New SQLiteCommand(sqlUpdateEndereco, conexao)
                        cmdUpdateEndereco.Parameters.AddWithValue("@rua", novoRua)
                        cmdUpdateEndereco.Parameters.AddWithValue("@numero", novoNumero)
                        cmdUpdateEndereco.Parameters.AddWithValue("@bairro", novoBairro)
                        cmdUpdateEndereco.Parameters.AddWithValue("@cidade", novaCidade)
                        cmdUpdateEndereco.Parameters.AddWithValue("@uf", novoUf)
                        cmdUpdateEndereco.Parameters.AddWithValue("@complemento", novoComplemento)
                        cmdUpdateEndereco.Parameters.AddWithValue("@cep", novoCep)
                        cmdUpdateEndereco.Parameters.AddWithValue("@id_professor", idProfessor)
                        cmdUpdateEndereco.ExecuteNonQuery()
                    End Using


                    ' Atualiza o telefone do professor
                    Dim sqlUpdateTelefone As String = "
                        UPDATE tb_telefones_professores
                        SET
                            numero = @numero
                        WHERE fk_id_professor = @id_professor;"

                    Using cmdUpdateTelefone As New SQLiteCommand(sqlUpdateTelefone, conexao)
                        cmdUpdateTelefone.Parameters.AddWithValue("@numero", novoTelefone)
                        cmdUpdateTelefone.Parameters.AddWithValue("@id_professor", idProfessor)
                        cmdUpdateTelefone.ExecuteNonQuery()
                    End Using

                    transacao.Commit()

                End Using ' transaction

                MsgBox("Dados do Professor atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
            Catch ex As Exception
                MsgBox("Erro ao atualizar dados do Professor: " & ex.Message, MsgBoxStyle.Critical)

            Finally
                conexao.Close()
            End Try
        End Using


    End Sub

    Private Sub Frm_GerenciamentoProfessores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnVoltarFoiClicado = False
    End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        btnVoltarFoiClicado = True
        AbreFormulario(Me, New Frm_MenuGerenciamento())
    End Sub

    Private Sub Frm_GerenciamentoProfessores_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not btnVoltarFoiClicado Then
            Close()
        End If
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click

    End Sub

    Private Sub Btn_bloquear_Click(sender As Object, e As EventArgs) Handles Btn_bloquear.Click
        Dim idProfessor As Integer = Convert.ToInt32(Dgv_dados.CurrentRow.Cells("id_professor").Value)

        Dim sqlVerificaBloqueio As String = "SELECT ativo FROM tb_professores WHERE id_professor = @id_professor;"
        Dim ativo As Boolean = False
        Using conexao As New SQLiteConnection(connectionString)
            Try
                conexao.Open()
                Using cmdVerificaBloqueio As New SQLiteCommand(sqlVerificaBloqueio, conexao)
                    cmdVerificaBloqueio.Parameters.AddWithValue("@id_professor", idProfessor)
                    Dim resultado As Object = cmdVerificaBloqueio.ExecuteScalar()
                    If resultado IsNot Nothing Then
                        ativo = Convert.ToBoolean(resultado)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Erro ao verificar status do Professor: " & ex.Message, MsgBoxStyle.Critical)
                Return
            Finally
                conexao.Close()
            End Try
        End Using

        Dim sqlBloquear As String = $"UPDATE tb_professores SET ativo = {If(ativo, 0, 1)} WHERE id_professor = @id_professor;"
        Using conexao As New SQLiteConnection(connectionString)
            Try
                conexao.Open()
                Using cmdBloquear As New SQLiteCommand(sqlBloquear, conexao)
                    cmdBloquear.Parameters.AddWithValue("@id_professor", idProfessor)
                    cmdBloquear.ExecuteNonQuery()
                End Using
                MsgBox($"Professor {If(ativo, "bloqueado", "desbloquado")} com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
                ' Atualiza o DataGridView
                If Not permiteAjax Then
                    permiteAjax = True
                End If

                Dgv_dados.DataSource = FazAjax(conexao, "tb_professores", Cmb_campo.Text, Txt_buscar.Text)
            Catch ex As Exception
                MsgBox("Erro ao bloquear Professor: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                conexao.Close()
            End Try
        End Using
    End Sub
End Class