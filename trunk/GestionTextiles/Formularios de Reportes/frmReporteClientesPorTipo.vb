Public Class frmReporteClientesPorTipo

    Private Sub frmReporteClientesPorTipo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ds As New dsReportes()
        Dim rpt As New rptClientesPorTipo()
        Dim ta As New dsReportesTableAdapters.rptClientesPorTipoTableAdapter()
        ta.Fill(ds.rptClientesPorTipo)
        rpt.SetDataSource(ds)
        crvReporte.ReportSource = rpt
    End Sub
End Class