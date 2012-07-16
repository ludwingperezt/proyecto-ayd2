Public Class frmReporteFacturasEliminadasFecha
    Private fechaInicial As DateTime
    Private fechaFinal As DateTime
    Private Sub frmReporteFacturasEliminadasFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fechaInicial = dtpInicio.Text
        fechaFinal = dtpFin.Text

        Dim rpt As New FacturasEliminadasPorFechaFinal    ' se instancia un objeto del reporte
        Dim consulta As New dsReportesTableAdapters.facturasEliminadasFechaTableAdapter  ' se instancia el tableAdapter (este es la conexión a la BD)
        Dim ds As New dsReportes ' el dataset se debe llenar, para colocarlo como fuente del reporte
        consulta.Fill(ds.facturasEliminadasFecha, fechaInicial, fechaFinal)  ' se llena la dataTable , q en si será la fuente del reporte
        rpt.SetDataSource(ds) ' se coloca como fuente del reporte
        crvReporte.ReportSource = rpt ' el reporte es fuente del crystal report viewer
    End Sub
End Class