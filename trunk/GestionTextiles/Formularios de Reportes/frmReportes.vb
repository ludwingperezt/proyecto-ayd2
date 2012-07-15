Public Class frmReportes
    Private lsSerie As String = ""
    Private liCorrelativo As Integer = 0
    ''' <summary>
    ''' Permite setear los parámetros del formulario de factura
    ''' </summary>
    ''' <param name="lsSerie">Es la serie de la factura</param>
    ''' <param name="liCorrela">Es el correlativo</param>
    ''' <remarks></remarks>
    Public Sub setDatos(lsSerie As String, liCorrela As Integer)
        Me.lsSerie = lsSerie
        Me.liCorrelativo = liCorrela
    End Sub
    Private Sub frmReportes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New rptFactura ' se instancia un objeto del reporte
        Dim taEncabezado As New dsReportesTableAdapters.ReporteFacturaEncabezadoTableAdapter ' se instancia el tableAdapter (este es la conexión a la BD)
        Dim taDetalle As New dsReportesTableAdapters.ReporteFacturaDetallesTableAdapter
        Dim ds As New dsReportes ' el dataset se debe llenar, para colocarlo como fuente del reporte
        taEncabezado.Fill(ds.ReporteFacturaEncabezado, lsSerie, liCorrelativo) ' se llena la dataTable de proveedores, q en si será la fuente del reporte
        taDetalle.Fill(ds.ReporteFacturaDetalles, lsSerie, liCorrelativo) ' se llena la dataTable de proveedores, q en si será la fuente del reporte
        rpt.SetDataSource(ds) ' se coloca como fuente del reporte
        crvReporte.ReportSource = rpt ' el reporte es fuente del crystal report viewer
    End Sub

End Class