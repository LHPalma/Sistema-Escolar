Imports System.IO

Public Class AbrirArquivo_PopUP_FRM

    Private Pasta As String

    Private Sub AbriArquivo_PopUP_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ListarArquivosProfessores()

        ListarArquivosDoBanco()

    End Sub


    Private Sub ListarArquivosProfessores()
        Pasta = Application.StartupPath & "\uploads\alunos"

        'DEBUG
        'If Sessao.tipoUsuario = Sessao.ETipoUsuario.Aluno Then
        '    Pasta = Application.StartupPath & "\uploads\professores"
        'ElseIf Sessao.tipoUsuario = Sessao.ETipoUsuario.Professor Then
        '    Pasta = Application.StartupPath & "\uploads\alunos"
        'End If

        If Not Directory.Exists(Pasta) Then
            MessageBox.Show($"A pasta não foi encontrada.{vbNewLine}Contate o administrador!")
            Exit Sub
        End If

        ' Preparar DataGridView
        Dgv_arquivos.Columns.Clear()
        Dgv_arquivos.Rows.Clear()

        Dgv_arquivos.Columns.Add("colNome", "Nome do Arquivo")
        Dgv_arquivos.Columns.Add("colTamanho", "Tamanho (KB)")
        Dgv_arquivos.Columns.Add("colData", "Data de Modificação")

        ' Preencher dados
        Dim arquivos() As String = Directory.GetFiles(Pasta)
        For Each caminhoArquivo In arquivos
            Dim info As New FileInfo(caminhoArquivo)
            Dgv_arquivos.Rows.Add(
            info.Name,
            Math.Round(info.Length / 1024.0, 2), ' tamanho em KB
            info.LastWriteTime.ToString("dd/MM/yyyy HH:mm")
        )
        Next
    End Sub


    Private Sub Dgv_arquivos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_arquivos.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim nomeArquivo As String = Dgv_arquivos.Rows(e.RowIndex).Cells("colNome").Value.ToString()
            Dim caminhoCompleto As String = Path.Combine(Application.StartupPath, Pasta, nomeArquivo)

            If File.Exists(caminhoCompleto) Then
                Try
                    Process.Start(caminhoCompleto)
                Catch ex As Exception
                    MessageBox.Show("Erro ao abrir o arquivo: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Arquivo não encontrado.")
            End If
        End If
    End Sub

    Private Sub Dgv_arquivos_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgv_arquivos.CellMouseMove
        If e.RowIndex >= 0 Then
            Dgv_arquivos.Cursor = Cursors.Hand
        Else
            Dgv_arquivos.Cursor = Cursors.Default
        End If
    End Sub


    Private Sub ListarArquivosDoBanco()

        Using conexao As New SQLite.SQLiteConnection(connectionString)
            conexao.Open()

            Dim sql As String = "
                SELECT a.id_arquivo, a.nome AS nome_arquivo, a.tamanho, a.caminho, p.nome AS nome_professor " &
                "FROM tb_arquivos a " &
                            "JOIN tb_arquivos_professores ap ON ap.fk_id_arquivo = a.id_arquivo " &
                            "JOIN tb_professores p ON p.id_professor = ap.fk_id_professor"

            Dim cmd As New SQLite.SQLiteCommand(sql, conexao)
            Dim reader As SQLite.SQLiteDataReader = cmd.ExecuteReader()

            Dgv_arquivos.Columns.Clear()
            Dgv_arquivos.Rows.Clear()

            Dgv_arquivos.Columns.Add("colNome", "Nome do Arquivo")
            Dgv_arquivos.Columns.Add("colTamanho", "Tamanho (KB)")
            Dgv_arquivos.Columns.Add("colProfessor", "Professor")
            Dgv_arquivos.Columns.Add("colCaminho", "Caminho Completo")

            While reader.Read()
                Dgv_arquivos.Rows.Add(
                reader("nome_arquivo").ToString(),
                Math.Round(CDbl(reader("tamanho")) / 1024.0, 2),
                reader("nome_professor").ToString(),
                reader("caminho").ToString()
            )
            End While
        End Using
    End Sub


End Class