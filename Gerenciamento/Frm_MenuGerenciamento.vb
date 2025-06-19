Public Class Frm_MenuGerenciamento
    'Fazer me.close nos botões de voltar
    Private Sub Btn_alunos_Click(sender As Object, e As EventArgs)
        AbreFormulario(Me, New Frm_GerenciamentoAlunos())
    End Sub

    Private Sub Btn_professores_Click(sender As Object, e As EventArgs)
        AbreFormulario(Me, New Frm_GerenciamentoProfessores())
    End Sub

    Private Sub Btn_adm_Click(sender As Object, e As EventArgs)
        AbreFormulario(Me, New Frm_GerenciamentoAdministradores)
    End Sub



    Private Sub Btn_disciplinas_Click(sender As Object, e As EventArgs)
        AbreFormulario(Me, New Frm_GerenciamentoDisciplinas)
    End Sub

    Private Sub Btn_alunos_Click_1(sender As Object, e As EventArgs) Handles Btn_alunos.Click
        Dim gerenciamentoAlunos As New Frm_GerenciamentoAlunos()
        Me.Close()
        gerenciamentoAlunos.ShowDialog()
    End Sub

    Private Sub Btn_professores_Click_1(sender As Object, e As EventArgs) Handles Btn_professores.Click
        AbreFormulario(Me, New Frm_GerenciamentoProfessores())
    End Sub

    Private Sub Btn_adm_Click_1(sender As Object, e As EventArgs) Handles Btn_adm.Click
        AbreFormulario(Me, New Frm_GerenciamentoAdministradores())
    End Sub

    Private Sub Btn_disciplinas_Click_1(sender As Object, e As EventArgs) Handles Btn_disciplinas.Click
        AbreFormulario(Me, New Frm_GerenciamentoDisciplinas())
    End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        AbreFormulario(Me, New Frm_menuADM())
    End Sub
End Class