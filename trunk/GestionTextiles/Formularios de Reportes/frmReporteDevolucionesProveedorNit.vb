Public Class frmReporteDevolucionesProveedorNit
    Private nit As Char
    Private Sub frmReporteDevolucionesProveedorNit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nit = txtNit.Text
        Dim rpt As New DevolucionProveedoresNitFinal    ' se instancia un objeto del reporte
        Dim consulta As New dsReportesTableAdapters.devolucionesProvNitTableAdapter  ' se instancia el tableAdapter (este es la conexión a la BD)
        Dim ds As New dsReportes ' el dataset se debe llenar, para colocarlo como fuente del reporte
        consulta.Fill(ds.devolucionesProvNit, nit)  ' se llena la dataTable , q en si será la fuente del reporte
        rpt.SetDataSource(ds) ' se coloca como fuente del reporte
        crvReporte.ReportSource = rpt ' el reporte es fuente del crystal report viewer
    End Sub

    Private Sub txtNit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNit.KeyPress
        If txtNit.TextLength = 0 And e.KeyChar = "c" Or e.KeyChar = "C" Then
            txtNit.Text = "CF"


        End If
        'verificamos que se ingresen letras o numeros
        If txtNit.TextLength >= 8 Then 'la ultima posicion del nit puede ser letra 
            If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then
                e.KeyChar = vbNullChar

            End If
        Else

            If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then
                e.KeyChar = vbNullChar

            End If
        End If
    End Sub
End Class