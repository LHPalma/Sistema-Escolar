Imports System.Data.SQLite

Public Class Frm_loginADM

    Dim btnVoltarFoiClicado As Boolean = False

    Private Sub Frm_loginADM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_email.Focus()
        btnVoltarFoiClicado = False
    End Sub


    Private Sub Frm_loginADM_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not btnVoltarFoiClicado Then
            AbreFormulario(Me, New Frm_inicio())
        End If
    End Sub


#Region "BOTÕES"

    Private Sub Btn_logar_Click(sender As Object, e As EventArgs) Handles Btn_logar.Click
        If (Txt_email.Text = "" Or Txt_senha.Text = "") Then
            MsgBox("Insira seus dados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
            Txt_email.Focus()
            Exit Sub
        End If


        Using conexao As New SQLiteConnection(connectionString)
            Try
                conexao.Open()

                Dim usuarioValido As Boolean = VerificaSenhaUsuario("tb_administradores", "email", Txt_email.Text, Txt_senha.Text)
                If usuarioValido Then
                    MsgBox("Login realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
                    Dim painelAdm As New Frm_menuADM()
                    painelAdm.Show()
                    Me.Hide()

                Else
                    MsgBox("Email ou senha incorretos.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Falha no login")
                    Exit Sub
                End If
            Catch ex As Exception
            Finally
                conexao.Close()
            End Try
        End Using
    End Sub


    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        btnVoltarFoiClicado = True
        AbreFormulario(Me, New Frm_inicio())
    End Sub

    Private Sub Cb_mostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles Cb_mostrarSenha.CheckedChanged
        Txt_senha.UseSystemPasswordChar = Not Txt_senha.UseSystemPasswordChar
    End Sub

#End Region

End Class