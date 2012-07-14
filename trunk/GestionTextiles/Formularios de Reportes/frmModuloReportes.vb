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

    Private Sub btnCorte_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorte.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnReporteFacturasasEliminadas_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteFacturasasEliminadas.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnReporteDevolucionesProveedor_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteDevolucionesProveedor.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCorte_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorte.MouseHover
        slblDescripcion.Text = "Muestra el Reporte de Cierre de caja "
    End Sub

    Private Sub btnReporteFacturasasEliminadas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteFacturasasEliminadas.MouseHover
        slblDescripcion.Text = "Muestra el Reporte de facturas eliminadas por fecha y/o cliente"
    End Sub

    Private Sub btnReporteDevolucionesProveedor_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteDevolucionesProveedor.MouseHover
        slblDescripcion.Text = "Muestra el Reporte de devoluciónes realizadas por los proveedores"
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        frmReportePrueba.ShowDialog(Me)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class