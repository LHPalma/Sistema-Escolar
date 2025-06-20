Public Class Frm_menuTurmasDisciplinas

    Dim btnVoltarFoiCLicado As Boolean = False

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        btnVoltarFoiCLicado = True
        AbreFormulario(Me, New Frm_menuSecretaria())
    End Sub

    Private Sub Btn_turma_Click(sender As Object, e As EventArgs) Handles Btn_turma.Click
        AbreFormulario(Me, New Frm_CadastroTurma())
    End Sub

    Private Sub Btn_disciplina_Click(sender As Object, e As EventArgs) Handles Btn_disciplina.Click
        AbreFormulario(Me, New Frm_CadastroDisciplina())
    End Sub

    Private Sub Frm_menuTurmasDisciplinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnVoltarFoiCLicado = False
    End Sub

    Private Sub Frm_menuTurmasDisciplinas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not btnVoltarFoiClicado Then
            Me.Close()
        End If
    End Sub
End Class