Imports System.Data.SQLite
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
                uploadDir = Application.StartupPath & "\uploads\professores"

            ElseIf Sessao.tipoUsuario = Sessao.ETipoUsuario.Aluno Then
                uploadDir = Application.StartupPath & "\uploads\alunos"

            Else
                uploadDir = Application.StartupPath & "\uploads\professores"
                'debug
                Sessao.nomeUsuario = "Rodrigo Amorim"
                Sessao.tipoUsuario = Sessao.ETipoUsuario.Professor
                'MessageBox.Show("Tipo de usuário não reconhecido.")
                'Return

            End If


            If Not Directory.Exists(uploadDir) Then Directory.CreateDirectory(uploadDir)

            Dim destPath As String = Path.Combine(uploadDir, fileName)
            File.Copy(filePath, destPath, True)
            Dim relativePath As String = destPath.Replace(Application.StartupPath & "\", "")
            SalvarArquivoNoBanco(fileName, relativePath)
            MessageBox.Show("Arquivo '" & fileName & "' enviado com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro ao enviar: " & ex.Message)
        End Try
    End Sub



    Private Sub SalvarArquivoNoBanco(nomeArquivo As String, caminhoArquivo As String)

        Using conexao As New SQLiteConnection(connectionString)
            Try
                conexao.Open()
                Using transacao = conexao.BeginTransaction()


                    Dim sqlInsert As String = $"
                        INSERT INTO tb_arquivos
                            (caminho, nome, tipo, tamanho)
                        VALUES
                            (@caminho, @nome, @tipo, @tamanho);
                    "

                    Using cmdInsert As New SQLiteCommand(sqlInsert, conexao)

                        cmdInsert.Parameters.AddWithValue("@caminho", caminhoArquivo)
                        cmdInsert.Parameters.AddWithValue("@nome", nomeArquivo)
                        cmdInsert.Parameters.AddWithValue("@tipo", Path.GetExtension(nomeArquivo))
                        cmdInsert.Parameters.AddWithValue("@tamanho", New FileInfo(caminhoArquivo).Length)


                        Dim linhasAfetadas As Integer = cmdInsert.ExecuteNonQuery()
                        If linhasAfetadas > 0 Then
                            MessageBox.Show("Arquivo salvo no banco de dados com sucesso!")
                        Else
                            MessageBox.Show("Erro ao salvar o arquivo no banco de dados.")
                        End If
                    End Using


                    Dim sqlInsertTbAssocitiva As String = ""
                    Select Case Sessao.tipoUsuario
                        Case Sessao.ETipoUsuario.Aluno
                            sqlInsertTbAssocitiva = $"
                            INSERT INTO tb_arquivos_alunos 
                                 (fk_id_arquivo, fk_id_aluno)
                            VALUES
                                ((SELECT id_arquivo FROM tb_arquivos WHERE nome = @nome), (SELECT id_aluno FROM tb_alunos WHERE nome = @nomeAluno));
                        "
                        Case Sessao.ETipoUsuario.Professor
                            sqlInsertTbAssocitiva = $"
                            INSERT INTO tb_arquivos_professores 
                                (fk_id_arquivo, fk_id_professor)
                            VALUES
                                ((SELECT id_arquivo FROM tb_arquivos WHERE nome = @nomeArquivo), (SELECT id_professor FROM tb_professores WHERE nome = @nomeProfessor));
                        "
                    End Select

                    Using cmdInsertTabelaAssocitiva As New SQLiteCommand(sqlInsertTbAssocitiva, conexao)

                        Select Case Sessao.tipoUsuario
                            Case Sessao.ETipoUsuario.Aluno
                                cmdInsertTabelaAssocitiva.Parameters.AddWithValue("@nomeAluno", Sessao.nomeUsuario)
                                cmdInsertTabelaAssocitiva.Parameters.AddWithValue("@nome", nomeArquivo)

                            Case Sessao.ETipoUsuario.Professor
                                cmdInsertTabelaAssocitiva.Parameters.AddWithValue("@nomeProfessor", Sessao.nomeUsuario)
                                cmdInsertTabelaAssocitiva.Parameters.AddWithValue("@nomeArquivo", nomeArquivo)
                        End Select
                        Dim qtd = cmdInsertTabelaAssocitiva.ExecuteNonQuery()

                    End Using ' cmdInsertTabelaAssocitiva


                    transacao.Commit()


                End Using ' SQLiteTransaction2

            Catch ex As Exception
                MsgBox("Erro ao salvar o arquivo no banco de dados: " & ex.Message, MsgBoxStyle.Critical, "Erro")

            Finally
                If conexao.State = ConnectionState.Open Then
                    conexao.Close()
                End If

            End Try

        End Using ' SQLiteConnection

    End Sub
End Class