Public Class frmClientes

    
    Private Sub txtbusqueda_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnbuscar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub DataGridView1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btningresarcliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresarcliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnmodificarclientes_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarclientes.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btneliminarcliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarcliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtbusqueda_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseHover
        slblDescripcion.Text = "Ingrese  algun dato del cliente a buscar ej. Pedro Juarez"
    End Sub

    Private Sub btnbuscar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseHover
        slblDescripcion.Text = "Debe  precionar el boton 'buscar' para inciar la busqueda "
    End Sub

    Private Sub DataGridView1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.MouseHover
        slblDescripcion.Text = "Listado de clientes actuales"
    End Sub

    Private Sub btningresarcliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresarcliente.MouseHover
        slblDescripcion.Text = "Ingreso de nuevos clientes "
    End Sub

    Private Sub btnmodificarclientes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarclientes.MouseHover
        slblDescripcion.Text = "Modificación de  clientes"
    End Sub

    Private Sub btneliminarcliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarcliente.MouseHover
        slblDescripcion.Text = "Eliminacion de clientes"
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        slblDescripcion.Text = "Salir de la aplicación"
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If txtbusqueda.Text = "" Then
            MessageBox.Show("Ingrese la busqueda deseada ")
        Else
            'codigo paa busqueda

        End If
    End Sub
End Class