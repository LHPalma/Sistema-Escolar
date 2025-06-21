Imports System.Text
Imports System.Data.SQLite
Public Class Frm_loginProfessor

    Dim btnVoltarFoiClicado As Boolean = False

    Private Sub Btn_logar_Click(sender As Object, e As EventArgs)

        If (Txt_email.Text = "" Or Txt_senha.Text = "") Then
            MsgBox("Insira seus dados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            Txt_email.Focus()
            Exit Sub
        End If



        Dim conexao As New SQLiteConnection(connectionString)

        Try
            conexao.Open()

            Dim usuarioValido = VerificaSenhaUsuario("tb_professores", "email", Txt_email.Text, Txt_senha.Text)

            If usuarioValido.SenhaValida Then
                MsgBox($"Login realizado com sucesso. Bem-vindo prof. {usuarioValido.NomeUsuario}!")

                Sessao.nomeUsuario = usuarioValido.NomeUsuario
                Sessao.tipoUsuario = Sessao.ETipoUsuario.Professor

                'AbreFormulario(Me, New Frm_menuProfessor())

            Else
                MsgBox("Usuário ou senha incorretos.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Falha no login")
                Txt_email.Focus()
                Exit Sub
            End If

        Catch ex As Exception
        Finally
            conexao.Close()
        End Try


    End Sub

    Private Sub Cb_mostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles Cb_mostrarSenha.CheckedChanged
        Txt_senha.UseSystemPasswordChar = Not Txt_senha.UseSystemPasswordChar
    End Sub

    Private Sub Frm_loginProfessor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnVoltarFoiClicado = False
    End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        btnVoltarFoiClicado = True
        AbreFormulario(Me, New Frm_inicio())
    End Sub

    Private Sub Frm_loginProfessor_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not btnVoltarFoiClicado Then
            Close()
        End If
    End Sub
End Class
