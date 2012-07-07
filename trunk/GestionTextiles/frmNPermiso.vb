Public Class frmNPermiso

    Private Sub clbRoles_MouseLeave(sender As System.Object, e As System.EventArgs) Handles clbRoles.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNombre_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtNombre.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNivelAcceso_MouseLeave(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbEmpleados_MouseLeave(sender As System.Object, e As System.EventArgs) Handles clbEmpleados.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbProveedores_MouseLeave(sender As System.Object, e As System.EventArgs) Handles clbProveedores.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbProductos_MouseLeave(sender As System.Object, e As System.EventArgs) Handles clbProductos.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbCompras_MouseLeave(sender As System.Object, e As System.EventArgs) Handles clbCompras.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbClientes_MouseLeave(sender As System.Object, e As System.EventArgs) Handles clbClientes.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbVentas_MouseLeave(sender As System.Object, e As System.EventArgs) Handles clbVentas.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbCliente_MouseLeave(sender As System.Object, e As System.EventArgs) Handles clbCliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbReportes_MouseLeave(sender As System.Object, e As System.EventArgs) Handles clbReportes.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbTalonario_MouseLeave(sender As System.Object, e As System.EventArgs) Handles clbTalonario.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNombre_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtNombre.MouseHover
        slblDescripcion.Text = "Ingrese el nombre del rol"
    End Sub

    Private Sub clbRoles_MouseHover(sender As System.Object, e As System.EventArgs) Handles clbRoles.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de roles"
    End Sub

    Private Sub clbEmpleados_MouseHover(sender As System.Object, e As System.EventArgs) Handles clbEmpleados.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Empleados"
    End Sub

    Private Sub clbProveedores_MouseHover(sender As System.Object, e As System.EventArgs) Handles clbProveedores.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Proveedores"

    End Sub

    Private Sub clbProductos_MouseHover(sender As System.Object, e As System.EventArgs) Handles clbProductos.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Productos"

    End Sub

    Private Sub clbCompras_MouseHover(sender As System.Object, e As System.EventArgs) Handles clbCompras.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Compras"

    End Sub

    Private Sub clbClientes_MouseHover(sender As System.Object, e As System.EventArgs) Handles clbClientes.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Clientes"

    End Sub

    Private Sub clbVentas_MouseHover(sender As System.Object, e As System.EventArgs) Handles clbVentas.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Ventas"

    End Sub

    Private Sub clbCliente_MouseHover(sender As System.Object, e As System.EventArgs) Handles clbCliente.MouseHover
        slblDescripcion.Text = "Asigna permisos en Tipos de Cliente"

    End Sub

    Private Sub clbReportes_MouseHover(sender As System.Object, e As System.EventArgs) Handles clbReportes.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Reportes"

    End Sub

    Private Sub clbTalonario_MouseHover(sender As System.Object, e As System.EventArgs) Handles clbTalonario.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Talonarios/Series"

    End Sub

    Private Sub btnCancelar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cierra sin guardar cambios"

    End Sub

    Private Sub btnAceptar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Cierra y guarda cambios"

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()

    End Sub
End Class