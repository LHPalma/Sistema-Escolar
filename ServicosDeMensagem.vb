Imports System.Net
Imports System.Net.Mail

Public Class ServicosDeMensagem
    Public Sub EnviarEmail(destinatario As String, nome As String)
        Try
            Dim smtp As New SmtpClient("smtp.gmail.com") With {
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
End Class
