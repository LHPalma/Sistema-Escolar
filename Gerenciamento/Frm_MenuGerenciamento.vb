Public Class Frm_MenuGerenciamento
    Private Sub Btn_alunos_Click(sender As Object, e As EventArgs) Handles Btn_alunos.Click
        Dim gerenciamentoAlunos As New Frm_GerenciamentoAlunos()
        gerenciamentoAlunos.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Btn_professores_Click(sender As Object, e As EventArgs) Handles Btn_professores.Click
        Dim gerenciamentoProfessores As New Frm_GerenciamentoProfessores()
        gerenciamentoProfessores.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Btn_adm_Click(sender As Object, e As EventArgs) Handles Btn_adm.Click
        Dim gerenciamentoAdministradores As New Frm_GerenciamentoAdministradores()
        gerenciamentoAdministradores.ShowDialog()
        Me.Close()
    End Sub
End Class