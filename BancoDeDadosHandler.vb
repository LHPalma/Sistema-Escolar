Imports System.Data.SQLite

Module BancoDeDadosHandler

    Const nomeBanco As String = "\database\db_escola.db"
    Public caminhoBanco As String = Application.StartupPath & "\" & nomeBanco
    Public connectionString As String = $"DataSource={caminhoBanco};version=3;"

    'Dim conexao As New SQLiteConnection()
    'Dim comando As New SQLiteCommand("sql", conexao)



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


    Public Sub AtualizarDados(idAluno As Integer, nome As String, email As String, ra As String, conexao As SQLiteConnection, transacao As SQLiteTransaction)
        Dim sqlUpdate As String = "
                                   UPDATE tb_alunos
                                   SET
                                       nome = @nome,
                                       email = @email,
                                       ra = @ra
                                   WHERE id_aluno = @id;"


        Using cmd As New SQLiteCommand(sqlUpdate, conexao, transacao)
            cmd.Parameters.AddWithValue("@nome", nome)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@ra", ra)
            cmd.Parameters.AddWithValue("@id", idAluno)
            cmd.ExecuteNonQuery()
        End Using
    End Sub


    'Função generica que serve tanto para atualizar turmas ou disciplinas do professor(que sera feito futuramente)
    'Ela usa o conceito do relacionamento entidade <--> categoria (aluno/professor <--> turma/disciplina)
    Sub AtualizarRelacionamento(tabelaRelacionamento As String, campoEntidade As String, campoCategoria As String,
                             idEntidade As Integer, idCategoria As Integer, conexao As SQLiteConnection)
        Dim existe As Boolean = BuscarExistencia(tabelaRelacionamento, campoEntidade, idEntidade, conexao)

        If existe Then
            ' Atualiza o relacionamento existente
            Dim sqlUpdate As String = $"
                                        UPDATE {tabelaRelacionamento}
                                        SET 
                                            {campoCategoria} = @idCategoria
                                        WHERE
                                            {campoEntidade} = @idEntidade;"

            Using cmdUpdate As New SQLiteCommand(sqlUpdate, conexao)
                cmdUpdate.Parameters.AddWithValue("@idCategoria", idCategoria)
                cmdUpdate.Parameters.AddWithValue("@idEntidade", idEntidade)
                cmdUpdate.ExecuteNonQuery()
            End Using
        Else
            ' Insere novo relacionamento
            Dim SqlInsert = $"INSERT INTO {tabelaRelacionamento}
                                  ({campoEntidade}, {campoCategoria})
                              VALUES 
                                  (@idEntidade, @idCategoria);"

            Using cmdInsert As New SQLiteCommand(SqlInsert, conexao)
                cmdInsert.Parameters.AddWithValue("@idEntidade", idEntidade)
                cmdInsert.Parameters.AddWithValue("@idCategoria", idCategoria)
                cmdInsert.ExecuteNonQuery()
            End Using
        End If
    End Sub


    Public Sub AtualizarOuInsereEndereco(tabelaEndereco As String,
                                         campoChaveEstrangeira As String,
                                         idEntidade As Integer,
                                         rua As String,
                                         numero As String,
                                         bairro As String,
                                         complemento As String,
                                         cidade As String,
                                         estado As String,
                                         cep As String,
                                         conexao As SQLiteConnection)

        Dim existeRegistro As Boolean = BuscarExistencia(tabelaEndereco, campoChaveEstrangeira, idEntidade, conexao)
        Dim sql As String

        If existeRegistro Then
            sql = $"
                    UPDATE {tabelaEndereco}
                    SET 
                        rua         = @rua,
                        numero      = @numero,
                        bairro      = @bairro,
                        cidade      = @cidade,
                        uf          = @uf,
                        cep         = @cep,
                        complemento = @complemento
                    WHERE {campoChaveEstrangeira} = @idEntidade;"
        Else
            sql = $"
                    INSERT INTO {tabelaEndereco}
                        (rua, numero, bairro, cidade, uf, cep, complemento, {campoChaveEstrangeira})
                    VALUES
                        (@rua, @numero, @bairro, @cidade, @uf, @cep, @complemento, @idEntidade);"

        End If

        Using cmd As New SQLiteCommand(sql, conexao)
            cmd.Parameters.AddWithValue("@rua", rua)
            cmd.Parameters.AddWithValue("@numero", numero)
            cmd.Parameters.AddWithValue("@bairro", bairro)
            cmd.Parameters.AddWithValue("@cidade", cidade)
            cmd.Parameters.AddWithValue("@uf", estado)
            cmd.Parameters.AddWithValue("@cep", cep)
            cmd.Parameters.AddWithValue("@complemento", complemento)
            cmd.Parameters.AddWithValue("@idEntidade", idEntidade)

            cmd.ExecuteNonQuery()
        End Using
    End Sub



    Sub AtualizaOuInsereTelefone(tabela As String, campoFK As String, idReferencia As Integer, novoTelefone As String, conexao As SQLiteConnection)
        Dim existeRegistro As Boolean = BuscarExistencia(tabela, campoFK, idReferencia, conexao)

        Dim sql As String
        If existeRegistro Then
            sql = $"
                    UPDATE {tabela}
                    SET
                        numero = @telefone
                    WHERE
                        {campoFK} = @idReferencia;"
        Else
            sql = $"
                    INSERT INTO {tabela}
                        ({campoFK}, numero)
                    VALUES
                        (@idReferencia, @telefone)"

        End If

        Using cmd As New SQLiteCommand(sql, conexao)
            cmd.Parameters.AddWithValue("@telefone", novoTelefone)
            cmd.Parameters.AddWithValue("@idReferencia", idReferencia)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function BuscarExistencia(tabela As String, campoFK As String, idReferencia As Integer, conexao As SQLiteConnection)
        Dim existeRegistro As Boolean
        ' Verifica se já existe seja la o que for
        Dim sqlSelect As String = $"
                                    SELECT COUNT(*)
                                    FROM {tabela} 
                                    WHERE {campoFK} = @idReferencia;"

        Using cmdCheck As New SQLiteCommand(sqlSelect, conexao)
            cmdCheck.Parameters.AddWithValue("@idReferencia", idReferencia)
            existeRegistro = Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0
        End Using

        Return existeRegistro
    End Function


    Public Function VerificaSenhaUsuario(tabela As String, coluna As String, valorProcurado As String, senha As String) As Boolean
        Using conexao As New SQLiteConnection(connectionString)
            conexao.Open()

            Dim sqlSelect = $"
                              SELECT
                                  senha_hash, senha_salt 
                              FROM {tabela} 
                              WHERE {coluna} = @valorProcurado"


            Using cmd As New SQLiteCommand(sqlSelect, conexao)
                cmd.Parameters.AddWithValue("@valorProcurado", valorProcurado)

                Using leitor As SQLiteDataReader = cmd.ExecuteReader()
                    If leitor.Read() Then
                        Dim hashSalvo As Byte() = CType(leitor("senha_hash"), Byte())
                        Dim saltSalvo As Byte() = CType(leitor("senha_salt"), Byte())

                        Dim hashTentativa As Byte() = GerarHashSenha(senha, saltSalvo)

                        Return CompararHashes(hashSalvo, hashTentativa)
                    Else
                        Return False
                    End If
                End Using
            End Using

        End Using 'Fim conexão
    End Function

    Private Function CompararHashes(hash1 As Byte(), hash2 As Byte()) As Boolean
        If hash1.Length <> hash2.Length Then
            Return False
        End If

        For i As Integer = 0 To hash1.Length - 1
            If hash1(i) <> hash2(i) Then Return False
        Next

        Return True
    End Function

    Public Function GetUltimoIdGerado(conexao As SQLiteConnection, transacao As SQLiteTransaction)
        Dim sqlGetId As String = "SELECT last_insert_rowid()"
        Using cmdGetId As New SQLiteCommand(sqlGetId, conexao, transacao)
            Return Convert.ToInt32(cmdGetId.ExecuteScalar())
        End Using
    End Function


End Module
