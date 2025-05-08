Imports System.Data.SQLite

Module BancoDeDadosHandler
    Public Function FazAjax(conexao, tabela, campo, valorProcurado)
        Dim dtAjax As New DataTable()
        Try
            conexao.Open()
            Dim sqlAjax As String = $"SELECT *
                                      FROM {tabela}
                                      WHERE {campo.ToLower()} LIKE '%{valorProcurado}%';"

            Using cmdAjax As New SQLiteCommand(sqlAjax, conexao)
                Dim daAjax As New SQLiteDataAdapter(cmdAjax)
                daAjax.Fill(dtAjax)

#Region "Converte os hashes para strings legíveis"
                ' Converte os hashes para strings legíveis
                dtAjax.Columns.Add("senha_hash_string", GetType(String))
                dtAjax.Columns.Add("senha_salt_string", GetType(String))

                ' Preenche as novas colunas com os valores convertidos
                For Each row As DataRow In dtAjax.Rows
                    row("senha_hash_string") = BitConverter.ToString(CType(row("senha_hash"), Byte())).Replace("-", "")
                    row("senha_salt_string") = BitConverter.ToString(CType(row("senha_salt"), Byte())).Replace("-", "")
                Next

                ' Remove as colunas originais
                dtAjax.Columns.Remove("senha_hash")
                dtAjax.Columns.Remove("senha_salt")
#End Region

            End Using

        Catch ex As Exception

        Finally
            conexao.Close()
        End Try

        Return dtAjax
    End Function


    Public Sub AtualizarDados(idAlunoOuProfessor As Integer, nome As String, email As String, ra As String, conexao As SQLiteConnection, transacao As SQLiteTransaction)
        Dim sql As String = "UPDATE tb_alunos SET nome = @nome, email = @email, ra = @ra WHERE id_aluno = @id;"
        Using cmd As New SQLiteCommand(sql, conexao, transacao)
            cmd.Parameters.AddWithValue("@nome", nome)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@ra", ra)
            cmd.Parameters.AddWithValue("@id", idAlunoOuProfessor)
            cmd.ExecuteNonQuery()
        End Using
    End Sub


    'Função generica que serve tanto para atualizar turmas ou disciplinas do professor(que sera feito futuramente)
    'Ela usa o conceito do relacionamento entidade <--> categoria (aluno/professor <--> turma/disciplina
    Sub AtualizarRelacionamento(tabelaRelacionamento As String, campoEntidade As String, campoCategoria As String,
                             idEntidade As Integer, idCategoria As Integer, conexao As SQLiteConnection)
        Dim existe As Boolean = BuscarExistencia(tabelaRelacionamento, campoEntidade, idEntidade, conexao)

        If existe Then
            ' Atualiza o relacionamento existente
            Dim cmdUpdate As New SQLiteCommand($"UPDATE {tabelaRelacionamento} SET {campoCategoria} = @idCategoria WHERE {campoEntidade} = @idEntidade", conexao)
            cmdUpdate.Parameters.AddWithValue("@idCategoria", idCategoria)
            cmdUpdate.Parameters.AddWithValue("@idEntidade", idEntidade)
            cmdUpdate.ExecuteNonQuery()
        Else
            ' Insere novo relacionamento
            Dim cmdInsert As New SQLiteCommand($"INSERT INTO {tabelaRelacionamento} ({campoEntidade}, {campoCategoria}) VALUES (@idEntidade, @idCategoria)", conexao)
            cmdInsert.Parameters.AddWithValue("@idEntidade", idEntidade)
            cmdInsert.Parameters.AddWithValue("@idCategoria", idCategoria)
            cmdInsert.ExecuteNonQuery()
        End If
    End Sub


    Public Sub AtualizarOuInsereEndereco(tabelaEndereco As String, campoChaveEstrangeira As String,
                  idEntidade As Integer,
                  rua As String, numero As String, bairro As String, complemento As String,
                  cidade As String, estado As String, cep As String,
                  conexao As SQLiteConnection)

        Dim existe As Boolean = BuscarExistencia(tabelaEndereco, campoChaveEstrangeira, idEntidade, conexao)
        Dim sql As String
        Dim cmd As SQLiteCommand

        If existe Then
            sql = $"
                    UPDATE {tabelaEndereco}
                    SET rua = @rua, numero = @numero, bairro = @bairro, cidade = @cidade,
                        uf = @uf, cep = @cep, complemento = @complemento
                    WHERE {campoChaveEstrangeira} = @idEntidade"
        Else
            sql = $"
                    INSERT INTO {tabelaEndereco}
                    (rua, numero, bairro, cidade, uf, cep, complemento, {campoChaveEstrangeira})
                    VALUES (@rua, @numero, @bairro, @cidade, @uf, @cep, @complemento, @idEntidade)"

        End If

        cmd = New SQLiteCommand(sql, conexao)

        ' Adiciona os parâmetros
        cmd.Parameters.AddWithValue("@rua", rua)
        cmd.Parameters.AddWithValue("@numero", numero)
        cmd.Parameters.AddWithValue("@bairro", bairro)
        cmd.Parameters.AddWithValue("@cidade", cidade)
        cmd.Parameters.AddWithValue("@uf", estado)
        cmd.Parameters.AddWithValue("@cep", cep)
        cmd.Parameters.AddWithValue("@complemento", complemento)
        cmd.Parameters.AddWithValue("@idEntidade", idEntidade)

        ' Executa
        cmd.ExecuteNonQuery()
    End Sub



    Sub AtualizaOuInsereTelefone(tabela As String, campoFK As String, idReferencia As Integer, novoTelefone As String, conexao As SQLiteConnection)
        Dim existe As Boolean = BuscarExistencia(tabela, campoFK, idReferencia, conexao)

        Dim sql As String
        If existe Then
            sql = ($"UPDATE {tabela} SET numero = @telefone WHERE {campoFK} = @idReferencia")
        Else
            sql = ($"INSERT INTO {tabela} ({campoFK}, numero) VALUES (@idReferencia, @telefone)")
        End If
        Dim cmd As New SQLiteCommand(sql, conexao)
        cmd.Parameters.AddWithValue("@telefone", novoTelefone)
        cmd.Parameters.AddWithValue("@idReferencia", idReferencia)
        cmd.ExecuteNonQuery()
    End Sub

    Public Function BuscarExistencia(tabela As String, campoFK As String, idReferencia As Integer, conexao As SQLiteConnection)
        ' Verifica se já existe seja la o que for
        Dim cmdCheck As New SQLiteCommand($"SELECT COUNT(*) FROM {tabela} WHERE {campoFK} = @idReferencia", conexao)
        cmdCheck.Parameters.AddWithValue("@idReferencia", idReferencia)
        Dim existe As Boolean = Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0
        Return existe
    End Function
End Module
