Public Class Frm_menuTurmasDisciplinas
    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        Dim menuSecretaria As New Frm_menuSecretaria()
        Me.Hide()
        menuSecretaria.ShowDialog()
    End Sub
End Class