Public Class frmPrincipal

    '' TODOS LAS FECHAS SE DEBEN GESTIONAR DESDE ESTE TIMER
    Private Sub tmrRefrescarBarra_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRefrescarBarra.Tick
        Me.slblFecha.Text = Date.Now
        frmAnular.slblFecha.Text = Date.Now
        frmVentas.slblFecha.Text = Date.Now
        frmFacturar.slblFecha.Text = Date.Now
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmVentas.ShowDialog(Me)
    End Sub
End Class