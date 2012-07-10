Public Class frmListarCompras

    Private Sub cmbFiltro_MouseLeave(sender As System.Object, e As System.EventArgs) Handles cmbFiltro.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtBusqueda_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvListaProveedores_MouseLeave(sender As System.Object, e As System.EventArgs) Handles dgvListaProveedores.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnEliminar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnEliminar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub
End Class