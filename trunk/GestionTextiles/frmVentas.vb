Public Class frmVentas

    Private Sub tmrRefrescarBarra_Tick(sender As System.Object, e As System.EventArgs)
        slblFecha.Text = Date.Now
    End Sub

    Private Sub btnAnular_Enter(sender As System.Object, e As System.EventArgs) Handles btnAnular.Enter

    End Sub

    Private Sub btnAnular_Leave(sender As System.Object, e As System.EventArgs) Handles btnAnular.Leave

    End Sub


    Private Sub btnCotizar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnCotizar.MouseHover
        slblDescripcion.Text = "Permite realizar una cotización de productos"
    End Sub

    Private Sub btnFacturar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnFacturar.MouseHover
        slblDescripcion.Text = "Inicia una nueva factura"
    End Sub

    Private Sub btnAnular_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnAnular.MouseHover
        slblDescripcion.Text = "Anula una factura, utilizando la serie y su correlativo"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        frmPrincipal.Show()


    End Sub

    Private Sub btnAnular_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnAnular.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnFacturar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnFacturar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCotizar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnCotizar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub frmVentas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAnular_Click(sender As System.Object, e As System.EventArgs) Handles btnAnular.Click
        frmAnular.ShowDialog(Me)

    End Sub

    Private Sub btnFacturar_Click(sender As System.Object, e As System.EventArgs) Handles btnFacturar.Click
        frmFacturar.ShowDialog(Me)
    End Sub
End Class
