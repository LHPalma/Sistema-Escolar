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
End Module
