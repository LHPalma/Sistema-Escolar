Imports System.Net.Mail

Public Class Frm_menuADM

    Dim btnVoltarFoiClicado As Boolean = False

    Private Sub Btn_cadastro_Click(sender As Object, e As EventArgs) Handles Btn_cadastro.Click
        AbreFormulario(Me, New Frm_menuSecretaria())
    End Sub

    Private Sub Btn_gerenciar_Click(sender As Object, e As EventArgs) Handles Btn_gerenciar.Click
        AbreFormulario(Me, New Frm_MenuGerenciamento())
    End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        btnVoltarFoiClicado = True
        AbreFormulario(Me, New Frm_inicio())
    End Sub

    Private Sub Frm_menuADM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnVoltarFoiClicado = False
    End Sub

    Private Sub Frm_menuADM_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not btnVoltarFoiClicado Then
            Me.Close()
        End If
    End Sub
End Class