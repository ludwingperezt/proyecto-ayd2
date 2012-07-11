Imports negocios


Public Class frmModuloCompras

    Private Sub btnNCompra_Click(sender As System.Object, e As System.EventArgs) Handles btnNCompra.Click
        frmCompras.ShowDialog()
    End Sub

    Private Sub btnbuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscar.Click

    End Sub

    Private Sub cmbFiltro_MouseLeave(sender As System.Object, e As System.EventArgs) Handles cmbFiltro.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtBusqueda_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnbuscar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnbuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvListaCompras_MouseLeave(sender As System.Object, e As System.EventArgs) Handles dgvListaCompras.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnNCompra_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnNCompra.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnEliminarEmpleados_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnAnularCompra.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSalir_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnSalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbFiltro_MouseHover(sender As System.Object, e As System.EventArgs) Handles cmbFiltro.MouseHover
        slblDescripcion.Text = "Debe elegir un criterio de búsqueda"
    End Sub

    Private Sub txtBusqueda_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.MouseHover
        slblDescripcion.Text = "Ingrese el texto a buscar según el criterio seleccionado"
    End Sub

    Private Sub btnbuscar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnbuscar.MouseHover
        slblDescripcion.Text = "Haga clic para obtener resultados"
    End Sub

    Private Sub btnAnularCompra_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnAnularCompra.MouseHover
        slblDescripcion.Text = "Haga clic para anular la compra que ha seleccionado"
    End Sub

    Private Sub btnSalir_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnSalir.MouseHover
        slblDescripcion.Text = "Salir del módulo de compras"
    End Sub

    Private Sub frmModuloCompras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If chkAnuladas.Checked = True Then
            dgvListaCompras.DataSource = negociosFacturasProveedorEliminadas.fnsListarFacturasProveedorEliminadas
        End If
    End Sub

    Private Sub chkAnuladas_MouseLeave(sender As System.Object, e As System.EventArgs) Handles chkAnuladas.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvListaCompras_MouseHover(sender As System.Object, e As System.EventArgs) Handles dgvListaCompras.MouseHover
        slblDescripcion.Text = "Lista de facturas de compras"
    End Sub

    Private Sub chkAnuladas_MouseHover(sender As System.Object, e As System.EventArgs) Handles chkAnuladas.MouseHover
        slblDescripcion.Text = "Si está habilitada esta opción, se hara una búsqueda solamente entre las facturas anuladas"
    End Sub
End Class