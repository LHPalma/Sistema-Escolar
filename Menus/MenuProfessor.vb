Public Class MenuProfessor
    Dim btnVoltarFoiClicado As Boolean = False

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        btnVoltarFoiClicado = True
        If MessageBox.Show("Deseja fazer LOGOFF?", "SAIR?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            AbreFormulario(Me, New Frm_inicio())
        End If
    End Sub


#Region "BOTÕES"
    Private Sub MenuProfessor_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not btnVoltarFoiClicado Then
            FecharPrograma()
        End If
    End Sub

    Private Sub Btn_agendarAvaliacao_Click(sender As Object, e As EventArgs) Handles Btn_agendarAvaliacao.Click
        AbreFormulario(Me, New CadastroAvaliacao_frm())
    End Sub

    Private Sub Btn_lancarFalta_Click(sender As Object, e As EventArgs) Handles Btn_lancarFalta.Click
        AbreFormulario(Me, New CadastroFaltas_FRM())
    End Sub

    Private Sub Btn_lancarNota_Click(sender As Object, e As EventArgs) Handles Btn_lancarNota.Click
        AbreFormulario(Me, New CadastroNotas_FRM())
    End Sub

    Private Sub Btn_enviarArquivos_Click(sender As Object, e As EventArgs) Handles Btn_enviarArquivos.Click
        Dim enviarArquivosPopUp As New UploadDeArquivos_PopUp()
        enviarArquivosPopUp.ShowDialog()
    End Sub
#End Region
End Class