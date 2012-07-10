Public Class frmModuloCompras

    Private Sub btnLCompras_Click(sender As System.Object, e As System.EventArgs) Handles btnLCompras.Click
        frmListarCompras.ShowDialog()
    End Sub

    Private Sub btnNCompra_Click(sender As System.Object, e As System.EventArgs) Handles btnNCompra.Click
        frmCompras.ShowDialog()
    End Sub
End Class