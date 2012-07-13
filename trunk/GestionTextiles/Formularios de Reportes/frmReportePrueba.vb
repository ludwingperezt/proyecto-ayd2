Public Class frmReportePrueba

    Private Sub frmReportePrueba_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New rptProveedores ' se instancia un objeto del reporte
        Dim taProveedores As New dsReportesTableAdapters.PROVEEDORESTableAdapter ' se instancia el tableAdapter (este es la conexión a la BD)
        Dim ds As New dsReportes ' el dataset se debe llenar, para colocarlo como fuente del reporte
        taProveedores.Fill(ds.PROVEEDORES) ' se llena la dataTable de proveedores, q en si será la fuente del reporte
        rpt.SetDataSource(ds) ' se coloca como fuente del reporte
        crvReporte.ReportSource = rpt ' el reporte es fuente del crystal report viewer

    End Sub
End Class