Public Class frmReporteFacturasEliminadasNit
    Private nit As Char
    Private Sub frmReporteFacturasEliminadasNit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        nit = txtNit.Text

        Dim rpt As New FacturasEliminadasNit     ' se instancia un objeto del reporte
        Dim consulta As New dsReportesTableAdapters.facturasEliminadasNitTableAdapter  ' se instancia el tableAdapter (este es la conexión a la BD)
        Dim ds As New dsReportes ' el dataset se debe llenar, para colocarlo como fuente del reporte
        consulta.Fill(ds.facturasEliminadasNit, nit)  ' se llena la dataTable , q en si será la fuente del reporte
        rpt.SetDataSource(ds) ' se coloca como fuente del reporte
        crvReporte.ReportSource = rpt ' el reporte es fuente del crystal report viewer
    End Sub
End Class