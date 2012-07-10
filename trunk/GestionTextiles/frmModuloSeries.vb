Public Class frmModuloSeries

    Private Sub btnNSerie_Click(sender As System.Object, e As System.EventArgs) Handles btnNSerie.Click
        frmSerie.ShowDialog()

    End Sub

    Private Sub btnLProveedores_Click(sender As System.Object, e As System.EventArgs) Handles btnLProveedores.Click
        frmListarSeries.ShowDialog()
    End Sub

    Private Sub btnNSerie_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnNSerie.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnLProveedores_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnLProveedores.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSalir_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnSalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnNSerie_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnNSerie.MouseHover
        slblDescripcion.Text = "Permite el ingreso de una nueva Serie"
    End Sub

    Private Sub btnLProveedores_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnLProveedores.MouseHover
        slblDescripcion.Text = "Muestra el listado de las series "
    End Sub

    Private Sub btnSalir_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnSalir.MouseHover
        slblDescripcion.Text = "Cierra el módulo de series"
    End Sub
End Class