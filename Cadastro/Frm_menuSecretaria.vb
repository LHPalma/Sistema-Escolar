Public Class Frm_menuSecretaria

    Dim btnVoltarFoiClicado As Boolean = False

    Private Sub Frm_menuSecretaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnVoltarFoiClicado = False
    End Sub

    Private Sub Btn_turmas_disciplinas_Click(sender As Object, e As EventArgs) Handles Btn_turmas_disciplinas.Click
        AbreFormulario(Me, New Frm_menuTurmasDisciplinas())
    End Sub

    Private Sub Btn_cadastro_contas_Click(sender As Object, e As EventArgs) Handles Btn_cadastro_contas.Click
        AbreFormulario(Me, New Frm_menuCadastro())
    End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        btnVoltarFoiClicado = True
        AbreFormulario(Me, New Frm_menuADM())
    End Sub

    Private Sub Frm_menuSecretaria_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not btnVoltarFoiClicado Then
            Me.Close()
        End If
    End Sub

End Class