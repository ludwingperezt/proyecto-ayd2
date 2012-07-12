Imports negocios
Public Class frmClientes
    Dim lnpNuevoCliente As negociosCliente = New negociosCliente()
    Private Sub txtbusqueda_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnbuscar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub DataGridView1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvclientes.MouseLeave
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

    Private Sub DataGridView1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvclientes.MouseHover
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
            ''verificar porque no se puede acceder
            dgvclientes.DataSource = lnpNuevoCliente.fnDbBuscarClienteNombre(txtbusqueda.Text)
        End If
    End Sub

    Private Sub btningresarcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresarcliente.Click
        frmingresoclientes.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        frmPrincipal.Show()
    End Sub

    Private Sub btnmodificarclientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarclientes.Click
        frmModificarCliente.Show()
    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        If txtbusqueda.Text = "" Then
            btnbuscar.Enabled = False
        Else
            btnbuscar.Enabled = True
        End If

    End Sub


    Private Sub btnActualizar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnActualizar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.MouseHover
        slblDescripcion.Text = "Actualiza el  listado de los Cliente en sistema"
    End Sub

    Private Sub dgvclientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvclientes.CellContentClick

    End Sub

    Private Sub cmbCliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbCliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.MouseHover
        slblDescripcion.Text = "Seleccióne el parametro por el que desea buscar"
    End Sub
End Class