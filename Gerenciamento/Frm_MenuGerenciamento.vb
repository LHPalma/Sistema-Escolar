Public Class Frm_MenuGerenciamento
    'Fazer me.close nos botões de voltar
    Private Sub Btn_alunos_Click(sender As Object, e As EventArgs)
        AbreFormulario(New Frm_GerenciamentoAlunos)
    End Sub

    Private Sub Btn_professores_Click(sender As Object, e As EventArgs)
        AbreFormulario(New Frm_GerenciamentoProfessores)
    End Sub

    Private Sub Btn_adm_Click(sender As Object, e As EventArgs)
        AbreFormulario(New Frm_GerenciamentoAdministradores)
    End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub AbreFormulario(formulario)
        Me.Hide()
        formulario.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Btn_disciplinas_Click(sender As Object, e As EventArgs)
        AbreFormulario(New Frm_GerenciamentoDisciplinas)
    End Sub

    Private Sub Btn_alunos_Click_1(sender As Object, e As EventArgs) Handles Btn_alunos.Click
        Dim gerenciamentoAlunos As New Frm_GerenciamentoAlunos()
        Me.Close()
        gerenciamentoAlunos.ShowDialog()
    End Sub

    Private Sub Btn_professores_Click_1(sender As Object, e As EventArgs) Handles Btn_professores.Click
        Dim gerenciamentoProfessores As New Frm_GerenciamentoProfessores()
        Me.Close()
        gerenciamentoProfessores.ShowDialog()
    End Sub

    Private Sub Btn_adm_Click_1(sender As Object, e As EventArgs) Handles Btn_adm.Click
        Dim gerenciamentoAdministradores As New Frm_GerenciamentoAdministradores()
        Me.Close()
        gerenciamentoAdministradores.ShowDialog()
    End Sub

    Private Sub Btn_disciplinas_Click_1(sender As Object, e As EventArgs) Handles Btn_disciplinas.Click
        Dim gerenciamentoDisciplinas As New Frm_GerenciamentoDisciplinas()
        Me.Close()
        gerenciamentoDisciplinas.ShowDialog()
    End Sub
End Class