Public Class Frm_loginAluno

    Dim btnVoltarFoiClicado As Boolean = False

    Private Sub Btn_logar_Click(sender As Object, e As EventArgs)

        If Not ((Txt_ra.Text <> "" Or Txt_senha.Text <> "")) Then
            MsgBox("Insira seus dados")
        End If


        Dim professor = New Frm_loginProfessor()
        professor.Show()
    End Sub


    Private Sub Cb_mostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles Cb_mostrarSenha.CheckedChanged
        Txt_senha.UseSystemPasswordChar = Not Txt_senha.UseSystemPasswordChar
    End Sub

    Private Sub Lb_ra_Click(sender As Object, e As EventArgs) Handles Lb_ra.Click
        Txt_ra.Focus()
    End Sub

    Private Sub Lb_senha_Click(sender As Object, e As EventArgs) Handles Lb_senha.Click
        Txt_senha.Focus()
    End Sub

    'Private Sub Frm_loginAluno_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    Dim inicio = New Frm_inicio()
    '    inicio.Show()
    'End Sub

    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        btnVoltarFoiClicado = True
        AbreFormulario(Me, New Frm_inicio())
    End Sub

    Private Sub Frm_loginAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnVoltarFoiClicado = False
    End Sub

    Private Sub Frm_loginAluno_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not btnVoltarFoiClicado Then
            Close()
        End If
    End Sub
End Class
