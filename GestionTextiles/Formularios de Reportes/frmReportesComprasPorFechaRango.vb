Public Class frmReportesComprasPorFechaRango
    Private fechaInicial As DateTime
    Private fechaFinal As DateTime
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        fechaInicial = dtpInicio.Text
        fechaFinal = dtpFin.Text
        Dim rpt As New rptComprasPorRangoFecha ' se instancia un objeto del reporte
        Dim consulta As New dsReportesTableAdapters.comprasPorFechaRangoTableAdapter ' se instancia el tableAdapter (este es la conexión a la BD)
        Dim ds As New dsReportes ' el dataset se debe llenar, para colocarlo como fuente del reporte
        consulta.Fill(ds.comprasPorFechaRango, fechaInicial, fechaFinal) ' se llena la dataTable de proveedores, q en si será la fuente del reporte
        rpt.SetDataSource(ds) ' se coloca como fuente del reporte
        crvReporte.ReportSource = rpt ' el reporte es fuente del crystal report viewer
    End Sub
End Class