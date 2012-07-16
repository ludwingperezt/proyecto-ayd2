Public Class frmReporteFacturasEliminadasNit
    Private nit As String
    Private Sub frmReporteFacturasEliminadasNit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        nit = txtNit.Text

        Dim rpt As New rptFacturasEliminadasNit     ' se instancia un objeto del reporte
        Dim consulta As New dsReportesTableAdapters.facturasEliminadasNitTableAdapter  ' se instancia el tableAdapter (este es la conexión a la BD)
        Dim ds As New dsReportes ' el dataset se debe llenar, para colocarlo como fuente del reporte
        consulta.Fill(ds.facturasEliminadasNit, nit)  ' se llena la dataTable , q en si será la fuente del reporte
        rpt.SetDataSource(ds) ' se coloca como fuente del reporte
        crvReporte.ReportSource = rpt ' el reporte es fuente del crystal report viewer
    End Sub

    Private Sub txtNit_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNit.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = " " Or e.KeyChar = "c" Or e.KeyChar = "C" Or e.KeyChar = "f" Or e.KeyChar = "F")) Then
            e.KeyChar = vbNullChar

        End If
    End Sub
End Class