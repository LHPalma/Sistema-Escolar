﻿Public Class Frm_menuCadastro
    'Fazer me.close nos botões de voltar
    Private Sub Btn_aluno_Click(sender As Object, e As EventArgs)
        Dim frm As New Frm_cadastroAluno()
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Btn_professor_Click(sender As Object, e As EventArgs)
        AbreFormulario(New Frm_cadastroAluno)
    End Sub

    Private Sub Btn_adm_Click(sender As Object, e As EventArgs)
        AbreFormulario(New Frm_cadastroADM())
    End Sub


    Private Sub AbreFormulario(formulario)
        Me.Hide()
        formulario.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Btn_turma_Click(sender As Object, e As EventArgs)
        AbreFormulario(New Frm_CadastroTurma)
    End Sub

    Private Sub Btn_disciplina_Click(sender As Object, e As EventArgs)
        AbreFormulario(New Frm_CadastroDisciplina)
    End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Btn_voltar_Click_1(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        Me.Hide()
        Dim menuSecretaria As New Frm_menuSecretaria()
        menuSecretaria.ShowDialog()
    End Sub

    Private Sub Btn_aluno_Click_1(sender As Object, e As EventArgs) Handles Btn_aluno.Click
        Dim cadastrarAluno As New Frm_cadastroAluno()
        Me.Hide()
        cadastrarAluno.ShowDialog()
    End Sub

    Private Sub Btn_professor_Click_1(sender As Object, e As EventArgs) Handles Btn_professor.Click
        Dim cadastroPorfessor As New Frm_CadastroProfessor()
        Me.Close()
        cadastroPorfessor.ShowDialog()
    End Sub
End Class