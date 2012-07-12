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

    Private Sub btnCProveedor_Click(sender As System.Object, e As System.EventArgs)
        frmReportes.gbParametros1.Visible = True
        frmReportes.gbParametros2.Visible = False
        frmReportes.lblTitulo.Text = "Reportes de Créditos por Proveedor"
        frmReportes.ShowDialog()
    End Sub

    Private Sub btnCMes_Click(sender As System.Object, e As System.EventArgs)
        frmReportes.gbParametros1.Visible = False
        frmReportes.gbParametros2.Visible = True
        frmReportes.lblTitulo.Text = "Reportes de Créditos por Mes"
        frmReportes.ShowDialog()
    End Sub
End Class