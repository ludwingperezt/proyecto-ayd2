Public Class frmAnular

   
    Private Sub txtSerie_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtSerie.MouseHover
        slblDescripcion.Text = "Se debe ingresar la serie de la factura. Ej: A"
    End Sub

    Private Sub txtNumero_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtNumero.MouseHover
        slblDescripcion.Text = "Se debe ingresar el numero de la factura. Ej: 00034"
    End Sub

    Private Sub txtNumero_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtNumero.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtSerie_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtSerie.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

    End Sub

    Private Sub txtSerie_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSerie.TextChanged

    End Sub
End Class