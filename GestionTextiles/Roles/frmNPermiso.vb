Imports negocios
Public Class frmNPermiso

    Private Sub clbRoles_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbRoles.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNombre_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNivelAcceso_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbEmpleados_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbEmpleados.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbProveedores_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbProveedores.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbProductos_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbProductos.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbCompras_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbCompras.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbClientes_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbClientes.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbVentas_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbVentas.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbCliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbCliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbReportes_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbReportes.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub clbTalonario_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbTalonario.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNombre_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseHover
        slblDescripcion.Text = "Ingrese el nombre del rol"
    End Sub

    Private Sub clbRoles_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbRoles.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de roles"
    End Sub

    Private Sub clbEmpleados_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbEmpleados.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Empleados"
    End Sub

    Private Sub clbProveedores_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbProveedores.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Proveedores"

    End Sub

    Private Sub clbProductos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbProductos.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Productos"

    End Sub

    Private Sub clbCompras_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbCompras.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Compras"

    End Sub

    Private Sub clbClientes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbClientes.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Clientes"

    End Sub

    Private Sub clbVentas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbVentas.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Ventas"

    End Sub

    Private Sub clbCliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbCliente.MouseHover
        slblDescripcion.Text = "Asigna permisos en Tipos de Cliente"

    End Sub

    Private Sub clbReportes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbReportes.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Reportes"

    End Sub

    Private Sub clbTalonario_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbTalonario.MouseHover
        slblDescripcion.Text = "Asigna permisos en el módulo de Talonarios/Series"

    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cierra sin guardar cambios"

    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Cierra y guarda cambios"

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim lnrNuevoRol As negociosRol = New negociosRol()
        lnrNuevoRol.setNombre(txtNombre.Text)
        'creando permisos de roles
        lnrNuevoRol.setPermisoCreacionRol(Convert.ToByte(clbRoles.GetItemChecked(0)))
        lnrNuevoRol.setPermisoModificacionRol(Convert.ToByte(clbRoles.GetItemChecked(1)))
        lnrNuevoRol.setPermisoListarRoles(Convert.ToByte(clbRoles.GetItemChecked(2)))
        lnrNuevoRol.setPermisoEliminacionRol(Convert.ToByte(clbRoles.GetItemChecked(3)))
        'creando permisos de manejo de empleados
        lnrNuevoRol.setPermisoCreacionEmpleado(Convert.ToByte(clbEmpleados.GetItemChecked(0)))
        lnrNuevoRol.setPermisoModificacionEmpleados(Convert.ToByte(clbEmpleados.GetItemChecked(1)))
        lnrNuevoRol.setPermisoListarEmpleados(Convert.ToByte(clbEmpleados.GetItemChecked(2)))
        lnrNuevoRol.setPermisoEliminacionEmpleados(Convert.ToByte(clbEmpleados.GetItemChecked(3)))
        'creando permisos de manejo de proveedores
        lnrNuevoRol.setPermisoCreacionProveedores(Convert.ToByte(clbProveedores.GetItemChecked(0)))
        lnrNuevoRol.setPermisoModificacionProveedores(Convert.ToByte(clbProveedores.GetItemChecked(1)))
        lnrNuevoRol.setPermisoListarProveedores(Convert.ToByte(clbProveedores.GetItemChecked(2)))
        lnrNuevoRol.setPermisoEliminacionProveedores(Convert.ToByte(clbProveedores.GetItemChecked(3)))
        lnrNuevoRol.setPermisoBuscarProveedores(Convert.ToByte(clbProveedores.GetItemChecked(4)))
        'creando permisos de manejo de productos
        lnrNuevoRol.setPermisoCreacionProductos(Convert.ToByte(clbProductos.GetItemChecked(0)))
        lnrNuevoRol.setPermisoModificacionProductos(Convert.ToByte(clbProductos.GetItemChecked(1)))
        lnrNuevoRol.setPermisoListarProductos(Convert.ToByte(clbProductos.GetItemChecked(2)))
        lnrNuevoRol.setPermisoEliminacionProductos(Convert.ToByte(clbProductos.GetItemChecked(3)))
        lnrNuevoRol.setPermisoBuscarProductos(Convert.ToByte(clbProductos.GetItemChecked(4)))
        lnrNuevoRol.setPermisoCargarProductos(Convert.ToByte(clbProductos.GetItemChecked(5)))
        lnrNuevoRol.setPermisoDescargarProductos(Convert.ToByte(clbProductos.GetItemChecked(6)))
        'creando permisos de manejo de compras
        lnrNuevoRol.setPermisoCompra(Convert.ToByte(clbCompras.GetItemChecked(0)))
        lnrNuevoRol.setPermisoDevolverProductosProveedores(Convert.ToByte(clbCompras.GetItemChecked(1)))
        'creando permisos de manejo de clientes
        lnrNuevoRol.setPermisoCreacionClientes(Convert.ToByte(clbClientes.GetItemChecked(0)))
        lnrNuevoRol.setPermisoModificacionClientes(Convert.ToByte(clbClientes.GetItemChecked(1)))
        lnrNuevoRol.setPermisoListarClientes(Convert.ToByte(clbClientes.GetItemChecked(2)))
        'creando permisos de manejo de ventas
        lnrNuevoRol.setPermisoVentas(Convert.ToByte(clbVentas.GetItemChecked(0)))
        lnrNuevoRol.setPermisoEliminarFacturasVentas(Convert.ToByte(clbVentas.GetItemChecked(1)))
        'creando permisos de manejo de tipos de cliente
        lnrNuevoRol.setPermisoCreacionTiposCliente(Convert.ToByte(clbCliente.GetItemChecked(0)))
        lnrNuevoRol.setPermisoModificacionTiposCliente(Convert.ToByte(clbCliente.GetItemChecked(1)))
        lnrNuevoRol.setPermisoListarTiposCliente(Convert.ToByte(clbCliente.GetItemChecked(2)))
        lnrNuevoRol.setPermisoEliminacionTiposCliente(Convert.ToByte(clbCliente.GetItemChecked(3)))
        'creando permisos de reportes
        lnrNuevoRol.setPermisoCorteCaja(Convert.ToByte(clbReportes.GetItemChecked(0)))
        lnrNuevoRol.setPermisoReporteFacturasVentaEliminadas(Convert.ToByte(clbReportes.GetItemChecked(1)))
        lnrNuevoRol.setPermisoReporteDevolucionesProveedor(Convert.ToByte(clbReportes.GetItemChecked(2)))
        lnrNuevoRol.setPermisoHistorialCostos(Convert.ToByte(clbReportes.GetItemChecked(3)))
        lnrNuevoRol.setPermisoHistorialVentasMes(Convert.ToByte(clbReportes.GetItemChecked(4)))
        lnrNuevoRol.setPermisoHistorialComprasMes(Convert.ToByte(clbReportes.GetItemChecked(5)))
        lnrNuevoRol.setPermisoHistorialCreditoPorProveedor(Convert.ToByte(clbReportes.GetItemChecked(6)))
        lnrNuevoRol.setPermisoHistorialCreditoMes(Convert.ToByte(clbReportes.GetItemChecked(7)))
        'creando permisos de gestión de series (talonarios)
        lnrNuevoRol.setPermisoCreacionSerieFacturaVenta(Convert.ToByte(clbTalonario.GetItemChecked(0)))
        lnrNuevoRol.setPermisoModificacionSerieFacturaVenta(Convert.ToByte(clbTalonario.GetItemChecked(1)))
        lnrNuevoRol.setPermisoListarSerieFacturaVenta(Convert.ToByte(clbTalonario.GetItemChecked(2)))
        lnrNuevoRol.setPermisoEliminacionSerieFacturaVenta(Convert.ToByte(clbTalonario.GetItemChecked(3)))

        Try
            lnrNuevoRol.fnvdCrearRol()
            slblDescripcion.Text = "La inserción del nuevo rol se llevó a cabo con éxito"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class