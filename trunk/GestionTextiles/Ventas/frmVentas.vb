Public Class frmVentas

    Private Sub tmrRefrescarBarra_Tick(sender As System.Object, e As System.EventArgs)
        slblFecha.Text = Date.Now
    End Sub

    Private Sub btnAnular_Enter(sender As System.Object, e As System.EventArgs) Handles btnAnular.Enter

    End Sub

    Private Sub btnAnular_Leave(sender As System.Object, e As System.EventArgs) Handles btnAnular.Leave

    End Sub


    Private Sub btnCotizar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Permite realizar una cotización de productos"
    End Sub

    Private Sub btnFacturar_MouseHover(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Inicia una nueva factura"
    End Sub

    Private Sub btnAnular_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnAnular.MouseHover
        slblDescripcion.Text = "Anula una factura, utilizando la serie y su correlativo"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
        frmPrincipal.Show()


    End Sub

    Private Sub btnAnular_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnAnular.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnFacturar_MouseLeave(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCotizar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub frmVentas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnAnular.Click
        frmAnular.ShowDialog(Me)

    End Sub

    Private Sub btnFacturar_Click(sender As System.Object, e As System.EventArgs)
        frmFacturar.ShowDialog(Me)
    End Sub

    Private Sub btnCotizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnFacturar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click
        frmFacturar.ShowDialog(Me)
    End Sub
End Class
