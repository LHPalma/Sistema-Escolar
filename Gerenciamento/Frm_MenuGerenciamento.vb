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
End Class