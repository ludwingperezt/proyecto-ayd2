Public Class frmModuloReportes

    Private Sub btnCorte_Click(sender As System.Object, e As System.EventArgs) Handles btnCorte.Click
        'frmReportes.ShowDialog()
        frmReporteCorteCaja.Show()
    End Sub

    Private Sub btnReporteFacturasasEliminadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteFacturasasEliminadas.Click
        frmReporteFacturasEliminadas.Show()
    End Sub

    Private Sub btnReporteDevolucionesProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteDevolucionesProveedor.Click
        frmReporteDevolucionesProveedor.Show()
    End Sub

    Private Sub btnCorte_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorte.MouseLeave, btnFactura.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnReporteFacturasasEliminadas_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteFacturasasEliminadas.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnReporteDevolucionesProveedor_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteDevolucionesProveedor.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCorte_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorte.MouseHover, btnFactura.MouseHover
        slblDescripcion.Text = "Muestra el Reporte de Cierre de caja "
    End Sub

    Private Sub btnReporteFacturasasEliminadas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteFacturasasEliminadas.MouseHover
        slblDescripcion.Text = "Muestra el Reporte de facturas eliminadas por fecha y/o cliente"
    End Sub

    Private Sub btnReporteDevolucionesProveedor_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteDevolucionesProveedor.MouseHover
        slblDescripcion.Text = "Muestra el Reporte de devoluciónes realizadas por los proveedores"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReportePrueba.ShowDialog(Me)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnDevolucionesProveedorFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolucionesProveedorFecha.Click
        frmReporteDevolucionesProveedorFecha.Show()
    End Sub

    Private Sub btnDevolucionesProveedorNit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolucionesProveedorNit.Click
        frmReporteDevolucionesProveedorNit.Show()
    End Sub

    Private Sub btnFacturasEliminadasFecha_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturasEliminadasFecha.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnFacturasEliminadasNit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturasEliminadasNit.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnFacturasEliminadasFecha_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturasEliminadasFecha.MouseHover
        slblDescripcion.Text = "Muetra el reporte de las facturas eliminadas por fecha"
    End Sub

    Private Sub btnFacturasEliminadasNit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturasEliminadasNit.MouseHover
        slblDescripcion.Text = "Muestra el reporte de las facturas eliminadas por nit del cliente"
    End Sub

    Private Sub btnDevolucionesProveedorFecha_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolucionesProveedorFecha.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnDevolucionesProveedorNit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolucionesProveedorNit.MouseLeave, btnProv.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnDevolucionesProveedorFecha_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolucionesProveedorFecha.MouseHover
        slblDescripcion.Text = "Muestra el reporte de las devoluciones al proveedor por fecha"
    End Sub

    Private Sub btnDevolucionesProveedorNit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolucionesProveedorNit.MouseHover, btnProv.MouseHover
        slblDescripcion.Text = "Muestra el reporte de las devoluciones al proveedor por Nit"
    End Sub

    Private Sub btnFactura_Click(sender As System.Object, e As System.EventArgs)
        frmReportes.ShowDialog(Me)
    End Sub

    Private Sub btnFacturasEliminadasNit_Click(sender As System.Object, e As System.EventArgs) Handles btnFacturasEliminadasNit.Click
        frmReporteFacturasEliminadasNit.ShowDialog(Me)
    End Sub

    Private Sub btnCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompras.Click
        frmReportesComprasPorFechaRango.ShowDialog(Me)
    End Sub

    Private Sub btnCostos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCostos.Click
        frmReporteCostosRangoFecha.ShowDialog(Me)
    End Sub

    Private Sub btnVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVentas.Click
        frmReporteVentasPorFechaRango.ShowDialog(Me)
    End Sub

    Private Sub btnFactura_Click_1(sender As System.Object, e As System.EventArgs) Handles btnFactura.Click
        frmPreFacturaRep.ShowDialog(Me)
    End Sub

    Private Sub btnProv_Click(sender As System.Object, e As System.EventArgs) Handles btnProv.Click
        frmReportePrueba.ShowDialog()
    End Sub
End Class