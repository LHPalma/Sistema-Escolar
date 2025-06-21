Imports System.Data.SQLite
Imports System.Diagnostics.Eventing.Reader
Imports System.IO

Public Class UploadDeArquivos_PopUp
    Private Sub Btn_upload_Click(sender As Object, e As EventArgs) Handles Btn_upload.Click

        Dim ofd As New OpenFileDialog With {
            .Filter = "Todos os arquivos (*.*)|*.*",
            .Multiselect = True
        }

        If ofd.ShowDialog() = DialogResult.OK Then
            For Each filePath As String In ofd.FileNames
                If File.Exists(filePath) Then
                    ProcessarArquivo(filePath)
                Else
                    MessageBox.Show("Arquivo não encontrado: " & filePath)
                End If
            Next
        End If


    End Sub

#Region "Eventos de arrastar e soltar"

    Private Sub UploadDeArquivos_PopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pnl_drop.AllowDrop = True
    End Sub


    Private Sub Pnl_drop_DragEnter(sender As Object, e As DragEventArgs) Handles Pnl_drop.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


    Private Sub Pnl_drop_DragDrop(sender As Object, e As DragEventArgs) Handles Pnl_drop.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        For Each filePath As String In files
            If File.Exists(filePath) Then
                ProcessarArquivo(filePath)
            Else
                MessageBox.Show("Arquivo não encontrado: " & filePath)
            End If
        Next
    End Sub




#End Region


    Private Sub ProcessarArquivo(filePath As String)
        Try
            Dim fileName As String = Path.GetFileName(filePath)

            Dim uploadDir As String
            If Sessao.tipoUsuario = Sessao.ETipoUsuario.Professor Then
                uploadDir = Application.StartupPath & "\uploads\professor"

            ElseIf Sessao.tipoUsuario = Sessao.ETipoUsuario.Aluno Then
                uploadDir = Application.StartupPath & "\uploads\professor"

            Else
                uploadDir = Application.StartupPath & "\uploads"
                'MessageBox.Show("Tipo de usuário não reconhecido.")
                'Return

            End If


            If Not Directory.Exists(uploadDir) Then Directory.CreateDirectory(uploadDir)

            Dim destPath As String = Path.Combine(uploadDir, fileName)
            File.Copy(filePath, destPath, True)

            'SalvarArquivoNoBanco(fileName, destPath)
            MessageBox.Show("Arquivo '" & fileName & "' enviado com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro ao enviar: " & ex.Message)
        End Try
    End Sub





    Private Sub SalvarArquivoNoBanco(nomeArquivo As String, caminhoArquivo As String)
        Dim connStr As String = "Data Source=seubanco.sqlite;Version=3;"
        Using conn As New SQLiteConnection(connStr)
            conn.Open()
            Dim cmd As New SQLiteCommand("INSERT INTO arquivos (nome, caminho) VALUES (@nome, @caminho)", conn)
            cmd.Parameters.AddWithValue("@nome", nomeArquivo)
            cmd.Parameters.AddWithValue("@caminho", caminhoArquivo)
            cmd.ExecuteNonQuery()
        End Using
    End Sub


End Class