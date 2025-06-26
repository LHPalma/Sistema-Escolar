Public Class MenuAluno

    Private Sub Btn_consultarDisciplinas_Click(sender As Object, e As EventArgs) Handles Btn_consultarDisciplinas.Click
        'AbreFormulario(Me, New Frm_consultarDisciplinas())
        ExibirPopUp(New Frm_consultarDisciplinas())
    End Sub

    Private Sub Btn_consultarAvaliacoes_Click(sender As Object, e As EventArgs) Handles Btn_consultarAvaliacoes.Click
        'AbreFormulario(Me, New Frm_consultarAvaliacoes())
        ExibirPopUp(New Frm_consultarAvaliacoes())
    End Sub

    Private Sub Btn_consultarFaltas_Click(sender As Object, e As EventArgs) Handles Btn_consultarFaltas.Click
        'AbreFormulario(Me, New Frm_consultarFaltas())
        ExibirPopUp(New Frm_consultarFaltas())
    End Sub

    Private Sub Btn_consultarNotas_Click(sender As Object, e As EventArgs) Handles Btn_consultarNotas.Click
        'AbreFormulario(Me, New Frm_consultarFaltas())
        ExibirPopUp(New Frm_consultarNotas())
    End Sub



    Private Sub MenuAluno_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FecharPrograma()
    End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click

        If MessageBox.Show("Deseja fazer LOGOFF?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            AbreFormulario(Me, New Frm_inicio())
        End If
    End Sub

    Private Sub Btn_arquivos_Click(sender As Object, e As EventArgs) Handles Btn_arquivos.Click
        ExibirPopUp(New UploadDeArquivos_PopUp())
    End Sub

    Private Sub Btn_acessarArquivos_Click(sender As Object, e As EventArgs) Handles Btn_acessarArquivos.Click
        ExibirPopUp(New AbrirArquivo_PopUP_FRM())
    End Sub
End Class