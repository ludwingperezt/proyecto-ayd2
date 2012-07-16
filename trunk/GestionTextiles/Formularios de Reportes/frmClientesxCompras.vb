Public Class frmClientesxCompras

    Private Sub frmClientesxCompras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ds As New dsReportes()
        Dim rpt As New rptClientesxCompras()
        Dim ta As New dsReportesTableAdapters.CLIENTESXCOMPRASTableAdapter
        ta.Fill(ds.CLIENTESXCOMPRAS)
        rpt.SetDataSource(ds)
        crvReporte.ReportSource = rpt
    End Sub
End Class