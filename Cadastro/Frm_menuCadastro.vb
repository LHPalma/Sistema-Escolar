Public Class Frm_menuCadastro

    Dim btnVoltarFoiClicado As Boolean = False

    Private Sub Btn_aluno_Click(sender As Object, e As EventArgs)
        AbreFormulario(Me, New CadastroAluno_FRM())
    End Sub

    Private Sub Btn_professor_Click(sender As Object, e As EventArgs)
        AbreFormulario(Me, New CadastroAluno_FRM)
    End Sub

    Private Sub Btn_adm_Click(sender As Object, e As EventArgs)
        AbreFormulario(Me, New Frm_cadastroADM())
    End Sub

    Private Sub Btn_turma_Click(sender As Object, e As EventArgs)
        AbreFormulario(Me, New Frm_CadastroTurma())
    End Sub

    Private Sub Btn_disciplina_Click(sender As Object, e As EventArgs)
        AbreFormulario(Me, New Frm_CadastroDisciplina())
    End Sub

    Private Sub Btn_voltar_Click_1(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        AbreFormulario(Me, New Frm_menuSecretaria())
    End Sub

    Private Sub Btn_aluno_Click_1(sender As Object, e As EventArgs) Handles Btn_aluno.Click
        AbreFormulario(Me, New CadastroAluno_FRM())
    End Sub

    Private Sub Btn_professor_Click_1(sender As Object, e As EventArgs) Handles Btn_professor.Click
        AbreFormulario(Me, New Frm_CadastroProfessor())
    End Sub

    Private Sub Btn_adm_Click_1(sender As Object, e As EventArgs) Handles Btn_adm.Click
        AbreFormulario(Me, New Frm_cadastroADM())
    End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs)
        btnVoltarFoiClicado = True
        AbreFormulario(Me, New Frm_menuSecretaria())
    End Sub

    Private Sub Frm_menuCadastro_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not btnVoltarFoiClicado Then
            Close()
        End If
    End Sub

    Private Sub Frm_menuCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnVoltarFoiClicado = False
    End Sub
End Class