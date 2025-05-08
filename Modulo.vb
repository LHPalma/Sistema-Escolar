Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text

Module Modulo



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

End Module
