Public Class frmModuloReportes

    Private Sub btnCorte_Click(sender As System.Object, e As System.EventArgs) Handles btnCorte.Click
        'frmReportes.ShowDialog()
        frmReporteCorteCaja.Show()
    End Sub

    Private Sub btnReporteFacturasasEliminadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteFacturasasEliminadas.Click
        frmReporteFacturasEliminadas.Show()
    End Sub
End Class