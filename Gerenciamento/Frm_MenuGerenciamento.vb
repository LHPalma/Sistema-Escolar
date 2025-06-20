Imports System.Text

Public Class Frm_MenuGerenciamento

    Dim btnVoltarFoiClicado As Boolean = False

#Region "BOTÕES"

    Private Sub Btn_alunos_Click(sender As Object, e As EventArgs) Handles Btn_alunos.Click
        AbreFormulario(Me, New Frm_GerenciamentoAlunos())
    End Sub


    Private Sub Btn_professores_Click(sender As Object, e As EventArgs) Handles Btn_professores.Click
        AbreFormulario(Me, New Frm_GerenciamentoProfessores())
    End Sub


    Private Sub Btn_adm_Click(sender As Object, e As EventArgs) Handles Btn_adm.Click
        AbreFormulario(Me, New Frm_GerenciamentoAdministradores)
    End Sub


    Private Sub Btn_disciplinas_Click(sender As Object, e As EventArgs) Handles Btn_disciplinas.Click
        AbreFormulario(Me, New Frm_GerenciamentoDisciplinas)
    End Sub


    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        btnVoltarFoiClicado = True
        AbreFormulario(Me, New Frm_menuADM())
    End Sub

#End Region


    Private Sub Frm_MenuGerenciamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnVoltarFoiClicado = False
    End Sub

    Private Sub Frm_MenuGerenciamento_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not btnVoltarFoiClicado Then
            Close()
        End If
    End Sub
End Class