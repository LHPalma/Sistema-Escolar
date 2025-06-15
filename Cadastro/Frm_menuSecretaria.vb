Public Class Frm_menuSecretaria
    Private Sub Btn_turmas_disciplinas_Click(sender As Object, e As EventArgs) Handles Btn_turmas_disciplinas.Click
        Dim frmTurmasDisciplinas As New Frm_menuTurmasDisciplinas()
        Me.Hide()
        frmTurmasDisciplinas.ShowDialog()
    End Sub

    Private Sub Btn_cadastro_contas_Click(sender As Object, e As EventArgs) Handles Btn_cadastro_contas.Click
        Dim menuCadastro As New Frm_menuCadastro()
        Me.Hide()
        menuCadastro.ShowDialog()
    End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        Dim loginAdemiro As New Frm_loginADM()
        Me.Hide()
        loginAdemiro.ShowDialog()
    End Sub
End Class