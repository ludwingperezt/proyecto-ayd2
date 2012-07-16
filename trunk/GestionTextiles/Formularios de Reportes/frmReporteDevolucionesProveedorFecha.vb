Public Class frmReporteDevolucionesProveedorFecha
    Private fechaInicial As DateTime
    Private fechafinal As DateTime
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        fechaInicial = dtpInicio.Text
        fechafinal = dtpFin.Text

        Dim rpt As New DevolucionesProveedorFechaFinal    ' se instancia un objeto del reporte
        Dim consulta As New dsReportesTableAdapters.devolucionesProvFechaTableAdapter  ' se instancia el tableAdapter (este es la conexión a la BD)
        Dim ds As New dsReportes ' el dataset se debe llenar, para colocarlo como fuente del reporte
        consulta.Fill(ds.devolucionesProvFecha, fechaInicial, fechafinal) ' se llena la dataTable, q en si será la fuente del reporte
        rpt.SetDataSource(ds) ' se coloca como fuente del reporte
        crvReporte.ReportSource = rpt ' el reporte es fuente del crystal report viewer
    End Sub

    Private Sub frmReporteDevolucionesProveedorFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class