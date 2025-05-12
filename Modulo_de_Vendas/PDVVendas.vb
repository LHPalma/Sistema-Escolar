Public Class PDVVendas


    Private Sub CalculaSubtotal()
        If Txt_quantidade.Text = "" Or Txt_preco_unitario.Text = "" Then
            Exit Sub
        End If
        Txt_subtotal.Text = Convert.ToDouble(Txt_preco_unitario.Text) * Convert.ToInt32(Txt_quantidade.Text)
    End Sub

    Private Sub Txt_quantidade_TextChanged(sender As Object, e As EventArgs) Handles Txt_quantidade.TextChanged
        CalculaSubtotal()
    End Sub

    Private Sub Txt_preco_unitario_TextChanged(sender As Object, e As EventArgs) Handles Txt_preco_unitario.TextChanged
        CalculaSubtotal()
    End Sub
End Class