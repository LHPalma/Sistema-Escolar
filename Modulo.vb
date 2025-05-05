Imports System.Data.SQLite
Imports System.Net
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text

Module Modulo
    Const nomeBanco As String = "\database\db_escola.db"
    Public caminhoBanco As String = Application.StartupPath & "\" & nomeBanco
    Public connectionString As String = "DataSource=" & caminhoBanco & ";version=3;"


    'Dim conexao As New SQLiteConnection()
    'Dim comando As New SQLiteCommand("sql", conexao)


    Public Function ByteToString(b As Byte())
        Return Encoding.UTF8.GetString(b)
    End Function


    Function GerarSalt(tamanho As Integer) As Byte()
        Dim salt(tamanho - 1) As Byte
        Using rng As New RNGCryptoServiceProvider()
            rng.GetBytes(salt)
        End Using
        Return salt
    End Function

    Function GerarHashSenha(senha As String, salt As Byte()) As Byte()
        Using sha256 As SHA256 = SHA256.Create()
            Dim senhaBytes As Byte() = Encoding.UTF8.GetBytes(senha)
            ' Juntar senha + salt
            Dim senhaComSalt(senhaBytes.Length + salt.Length - 1) As Byte
            Buffer.BlockCopy(senhaBytes, 0, senhaComSalt, 0, senhaBytes.Length)
            Buffer.BlockCopy(salt, 0, senhaComSalt, senhaBytes.Length, salt.Length)
            ' Gerar o hash
            Return sha256.ComputeHash(senhaComSalt)
        End Using
    End Function


    Public Function VerificarUsuario(tabela As String, coluna As String, valorProcurado As String, senha As String) As Boolean
        Using conexao As New SQLiteConnection(connectionString)
            conexao.Open()
            Dim cmd As New SQLiteCommand($"SELECT senha_hash, senha_salt FROM {tabela} WHERE {coluna} = @valorProcurado", conexao)
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


    Public Sub EnviarEmail(destinatario As String, nome As String)
        Try
            Dim smtp As New SmtpClient("smtp.gmail.com") With
        {
            .Port = 587,
            .EnableSsl = True,
            .Credentials = New NetworkCredential("luizpalma.prof@gmail.com", "hzgb fqpu xuam shjq")
        }


            Dim mail As New MailMessage()
            mail.From = New MailAddress("luizpalma.prof@gmail.com", "Escola do Alisa")
            mail.To.Add(destinatario)
            mail.Subject = "Cadastro de Aluno"
            mail.Body = $"Olá {nome}, seu cadastro foi realizado com sucesso na Escola do Alisa. Você já pode acessar o sistema com seu E-mail e senha."
            mail.IsBodyHtml = False

            smtp.Send(mail)

        Catch ex As Exception
            MsgBox("Erro ao enviar e-mail", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Erro ao enviar E-mail")
        End Try
    End Sub


End Module
