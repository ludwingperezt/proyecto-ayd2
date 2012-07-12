Imports negocios
Public Class frmModuloEmpleados
    Dim lnpEmpleado As negociosEmpleado = New negociosEmpleado()
    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If txtbusqueda.Text = "" Then
            MessageBox.Show("Ingrese la busqueda deseada ")
        Else
            'codigo para busqueda
            'verificar si funciona
            dgvEmpleados.DataSource = negociosEmpleado.fnDbBuscarEmpleadoNombre(txtbusqueda.Text)
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

    End Sub

    Private Sub txtbusqueda_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnbuscar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnIngresarEmpleado_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarEmpleado.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnModificarEmpleado_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarEmpleado.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnEliminarEmpleados_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarEmpleados.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvEmpleados_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvEmpleados.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtbusqueda_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseHover
        slblDescripcion.Text = "Ingrese  algun dato del Empleado a buscar ej. Pedro Juarez"
    End Sub

    Private Sub btnbuscar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseHover
        slblDescripcion.Text = "Debe  precionar el boton 'buscar' para inciar la busqueda "
    End Sub

    Private Sub btnIngresarEmpleado_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarEmpleado.MouseHover
        slblDescripcion.Text = "Ingreso de nuevos Empleados "
    End Sub

    Private Sub btnModificarEmpleado_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarEmpleado.MouseHover
        slblDescripcion.Text = "Modificación de  Empleados"
    End Sub

    Private Sub dgvEmpleados_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvEmpleados.MouseHover
        slblDescripcion.Text = "Listado de Empleados actuales"
    End Sub

    Private Sub btnEliminarEmpleados_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarEmpleados.MouseHover
        slblDescripcion.Text = "Eliminacion de Empleados"
    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        If txtbusqueda.Text = "" Then
            btnbuscar.Enabled = False
        Else
            btnbuscar.Enabled = True
        End If
    End Sub

    Private Sub cmbFiltroCriterio_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltroCriterio.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbFiltradoEstados_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltradoEstados.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbFiltroCriterio_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltroCriterio.MouseHover
        slblDescripcion.Text = "Selecciones un Criterio de Busqueda."
    End Sub

    Private Sub cmbFiltradoEstados_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltradoEstados.MouseHover
        slblDescripcion.Text = "Selecciones un Estado."
    End Sub

    Private Sub btnSalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSalir_MouseHover_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseHover
        slblDescripcion.Text = "Salir de la aplicación"
    End Sub
End Class