Imports System.IO

Public Class AbrirArquivo_PopUP_FRM

    Private Pasta As String

    Private Sub AbriArquivo_PopUP_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarArquivosProfessores()
    End Sub


    Private Sub ListarArquivosProfessores()
        Pasta = Application.StartupPath & "\uploads\alunos"

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

    Private Sub Dgv_arquivos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_arquivos.CellContentClick
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
End Class