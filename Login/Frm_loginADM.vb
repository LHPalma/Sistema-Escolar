﻿Imports System.Data.SQLite

Public Class Frm_loginADM
    Private Sub Cb_mostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles Cb_mostrarSenha.CheckedChanged
        Txt_senha.UseSystemPasswordChar = Not Txt_senha.UseSystemPasswordChar
    End Sub

    Private Sub Btn_logar_Click(sender As Object, e As EventArgs)
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

    Private Sub Frm_loginADM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim inicio = New Frm_inicio()
        inicio.Show()
    End Sub

    Private Sub Gb_loginADM_Enter(sender As Object, e As EventArgs) Handles Gb_loginADM.Enter

    End Sub
End Class