Imports System.IO

Public Class AbrirArquivo_PopUP_FRM

    Private Pasta As String

    Private Sub AbriArquivo_PopUP_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListarArquivosDoBanco()

    End Sub


    Private Sub Dgv_arquivos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_arquivos.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            Dim caminhoCompleto As String = Dgv_arquivos.Rows(e.RowIndex).Cells("colCaminho").Value.ToString()

            If File.Exists(caminhoCompleto) Then
                Try
                    Process.Start(caminhoCompleto)
                Catch ex As Exception
                    MessageBox.Show("Erro ao abrir o arquivo: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Arquivo não encontrado no caminho registrado.")
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


    'Private Sub ListarArquivosDoBanco()

    '    Using conexao As New SQLite.SQLiteConnection(connectionString)
    '        conexao.Open()

    '        Dim sqlSelectArquivos As String = "
    '            SELECT a.id_arquivo, a.nome AS nome_arquivo, a.tamanho, a.caminho, p.nome AS nome_professor 
    '            FROM tb_arquivos a 
    '            JOIN tb_arquivos_professores ap 
    '                ON ap.fk_id_arquivo = a.id_arquivo
    '            JOIN tb_professores p
    '                ON p.id_professor = ap.fk_id_professor;"

    '        Dim cmd As New SQLite.SQLiteCommand(sqlSelectArquivos, conexao)
    '        Dim reader As SQLite.SQLiteDataReader = cmd.ExecuteReader()

    '        Dgv_arquivos.Columns.Clear()
    '        Dgv_arquivos.Rows.Clear()

    '        Dgv_arquivos.Columns.Add("colNome", "Nome do Arquivo")
    '        Dgv_arquivos.Columns.Add("colTamanho", "Tamanho (KB)")
    '        Dgv_arquivos.Columns.Add("colProfessor", "Professor")
    '        Dgv_arquivos.Columns.Add("colCaminho", "Caminho Completo")

    '        While reader.Read()
    '            Dgv_arquivos.Rows.Add(
    '            reader("nome_arquivo").ToString(),
    '            Math.Round(CDbl(reader("tamanho")) / 1024.0, 2),
    '            reader("nome_professor").ToString(),
    '            reader("caminho").ToString()
    '        )
    '        End While
    '    End Using
    'End Sub


    Private Sub ListarArquivosDoBanco()

        Using conexao As New SQLite.SQLiteConnection(connectionString)
            conexao.Open()

            Dim sqlSelectArquivos As String = ""

            ' Definir a consulta com base no tipo de usuário logado

            If Sessao.tipoUsuario = Sessao.ETipoUsuario.Professor Then
                ' Professor logado → Listar arquivos enviados pelos alunos
                sqlSelectArquivos = "
                SELECT a.id_arquivo, a.nome AS nome_arquivo, a.tamanho, a.caminho, al.nome AS nome_aluno
                FROM tb_arquivos a
                JOIN tb_arquivos_alunos aa ON aa.fk_id_arquivo = a.id_arquivo
                JOIN tb_alunos al ON al.id_aluno = aa.fk_id_aluno;"

            ElseIf Sessao.tipoUsuario = Sessao.ETipoUsuario.Aluno Then
                ' Aluno logado → Listar arquivos enviados pelos professores
                sqlSelectArquivos = "
                SELECT a.id_arquivo, a.nome AS nome_arquivo, a.tamanho, a.caminho, p.nome AS nome_professor
                FROM tb_arquivos a
                JOIN tb_arquivos_professores ap ON ap.fk_id_arquivo = a.id_arquivo
                JOIN tb_professores p ON p.id_professor = ap.fk_id_professor;"

            Else
                MessageBox.Show("Tipo de usuário não reconhecido.")
                Exit Sub
            End If

            Dim cmd As New SQLite.SQLiteCommand(sqlSelectArquivos, conexao)
            Dim reader As SQLite.SQLiteDataReader = cmd.ExecuteReader()

            ' Preparar o DataGridView
            Dgv_arquivos.Columns.Clear()
            Dgv_arquivos.Rows.Clear()

            Dgv_arquivos.Columns.Add("colNome", "Nome do Arquivo")
            Dgv_arquivos.Columns.Add("colTamanho", "Tamanho (KB)")

            If Sessao.tipoUsuario = Sessao.ETipoUsuario.Professor Then
                Dgv_arquivos.Columns.Add("colEnviadoPor", "Aluno")
            ElseIf Sessao.tipoUsuario = Sessao.ETipoUsuario.Aluno Then
                Dgv_arquivos.Columns.Add("colEnviadoPor", "Professor")
            End If

            Dgv_arquivos.Columns.Add("colCaminho", "Caminho Completo")

            ' Preencher dados
            While reader.Read()
                Dim nomeRemetente As String = If(Sessao.tipoUsuario = Sessao.ETipoUsuario.Professor,
                                             reader("nome_aluno").ToString(),
                                             reader("nome_professor").ToString())

                Dgv_arquivos.Rows.Add(
                reader("nome_arquivo").ToString(),
                reader("tamanho"),
                nomeRemetente,
                reader("caminho").ToString()
            )
            End While

            ' Ocultar o caminho completo no grid
            Dgv_arquivos.Columns("colCaminho").Visible = False

        End Using
    End Sub


End Class