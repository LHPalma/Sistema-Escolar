Public Class MenuProfessor
    Dim btnVoltarFoiClicado As Boolean = False

    Private Sub MenuProfessor_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not btnVoltarFoiClicado Then
            FecharPrograma()
        End If
    End Sub


#Region "BOTÕES"

    Private Sub Btn_agendarAvaliacao_Click(sender As Object, e As EventArgs) Handles Btn_agendarAvaliacao.Click
        AbreFormulario(Me, New CadastroAvaliacao_frm())
    End Sub


    Private Sub Btn_lancarFalta_Click(sender As Object, e As EventArgs) Handles Btn_lancarFalta.Click
        ExibirPopUp(New CadastroFaltas_FRM)
    End Sub


    Private Sub Btn_lancarNota_Click(sender As Object, e As EventArgs) Handles Btn_lancarNota.Click
        ExibirPopUp(New CadastroNotas_FRM)
    End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        btnVoltarFoiClicado = True
        If MessageBox.Show("Deseja fazer LOGOFF?", "SAIR?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            AbreFormulario(Me, New Frm_inicio())
        End If
    End Sub

    Private Sub Btn_acessarArquivos_Click(sender As Object, e As EventArgs) Handles Btn_acessarArquivos.Click
        ExibirPopUp(New AbrirArquivo_PopUP_FRM())
    End Sub

    Private Sub Btn_arquivos_Click(sender As Object, e As EventArgs) Handles Btn_arquivos.Click
        ExibirPopUp(New UploadDeArquivos_PopUp())
    End Sub

#End Region
End Class