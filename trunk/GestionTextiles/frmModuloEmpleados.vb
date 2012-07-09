Public Class frmModuloEmpleados

    

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If txtbusqueda.Text = "" Then
            MessageBox.Show("Ingrese la busqueda deseada ")
        Else
            'codigo para busqueda

        End If
    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnIngresarEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarEmpleado.Click
        frmEmpleados.ShowDialog(Me)
    End Sub

    Private Sub btnModificarEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarEmpleado.Click
        frmModificarEmpleado.ShowDialog(Me)
    End Sub

    Private Sub btnEliminarEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarEmpleados.Click
        frmDarDeBajaEmpleado.ShowDialog(Me)
    End Sub
End Class