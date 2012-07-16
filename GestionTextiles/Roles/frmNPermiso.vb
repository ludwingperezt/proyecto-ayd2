Imports negocios
Public Class frmModificarPermiso
    Public Shared actualizar As Boolean
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
        frmRoles.nrRolSeleccionado = Nothing
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtNombre.Text <> "" Then
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
            'lnrNuevoRol.setPermisoHistorialVentasMes(Convert.ToByte(clbReportes.GetItemChecked(4)))
            'lnrNuevoRol.setPermisoHistorialComprasMes(Convert.ToByte(clbReportes.GetItemChecked(5)))
            'lnrNuevoRol.setPermisoHistorialCreditoPorProveedor(Convert.ToByte(clbReportes.GetItemChecked(6)))
            'lnrNuevoRol.setPermisoHistorialCreditoMes(Convert.ToByte(clbReportes.GetItemChecked(7)))
            'creando permisos de gestión de series (talonarios)
            lnrNuevoRol.setPermisoCreacionSerieFacturaVenta(Convert.ToByte(clbTalonario.GetItemChecked(0)))
            lnrNuevoRol.setPermisoModificacionSerieFacturaVenta(Convert.ToByte(clbTalonario.GetItemChecked(1)))
            lnrNuevoRol.setPermisoListarSerieFacturaVenta(Convert.ToByte(clbTalonario.GetItemChecked(2)))
            lnrNuevoRol.setPermisoEliminacionSerieFacturaVenta(Convert.ToByte(clbTalonario.GetItemChecked(3)))

            If actualizar Then
                'si es una modificaciòn
                lnrNuevoRol.setNivelAcceso(frmRoles.nrRolSeleccionado.getNivelAcceso())
                lnrNuevoRol.setIdRol(frmRoles.nrRolSeleccionado.getIdRol())
                lnrNuevoRol.setHabilitado(frmRoles.nrRolSeleccionado.getHabilitado())
                If MessageBox.Show("¿Está seguro de modificar los permisos de acceso a la aplicación?", "Precaución", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    Try
                        lnrNuevoRol.fnvdModificarRol()
                        MessageBox.Show("La operación de modificación finalizó con éxito", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmRoles.nrRolSeleccionado = Nothing
                        Me.Dispose()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Else
                'si es una insersiòn
                Try
                    lnrNuevoRol.fnvdCrearRol()
                    'slblDescripcion.Text = "La inserción del nuevo rol de permisos se llevó a cabo con éxito"
                    MessageBox.Show("La operación de insersión finalizó con éxito", "Insertar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmRoles.nrRolSeleccionado = Nothing
                    Me.Dispose()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    frmRoles.nrRolSeleccionado = Nothing
                End Try
            End If
        Else
            slblDescripcion.Text = "Ingrese el nombre del permiso"
            txtNombre.Focus()
        End If

    End Sub

    Private Sub frmModificarPermiso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If actualizar Then
            'si es una modificacion
            MessageBox.Show("La modificación de datos en esta parte del programa puede dañar la integridad de la base de datos", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lblTitulo.Text = "Modificar permiso"
            Me.Text = "Modificar permiso"
            txtNombre.Text = frmRoles.nrRolSeleccionado.getNombre()
            llenarPermisosActuales()
        Else
            lblTitulo.Text = "Nuevo Permiso"
            Me.Text = "Nuevo Permiso"
        End If
    End Sub

    Private Sub llenarPermisosActuales()
        'permisos de roles
        clbRoles.SetItemChecked(0, frmRoles.nrRolSeleccionado.getPermisoCreacionRol())
        clbRoles.SetItemChecked(1, frmRoles.nrRolSeleccionado.getPermisoModificacionRol())
        clbRoles.SetItemChecked(2, frmRoles.nrRolSeleccionado.getPermisoListarRoles())
        clbRoles.SetItemChecked(3, frmRoles.nrRolSeleccionado.getPermisoEliminacionRol())

        'permisos de manejo de empleados
        clbEmpleados.SetItemChecked(0, frmRoles.nrRolSeleccionado.getPermisoCreacionEmpleados())
        clbEmpleados.SetItemChecked(1, frmRoles.nrRolSeleccionado.getPermisoModificacionEmpleados())
        clbEmpleados.SetItemChecked(2, frmRoles.nrRolSeleccionado.getPermisoListarEmpleados())
        clbEmpleados.SetItemChecked(3, frmRoles.nrRolSeleccionado.getPermisoEliminacionEmpleados())

        'permisos de manejo de proveedores
        clbProveedores.SetItemChecked(0, frmRoles.nrRolSeleccionado.getPermisoCreacionProveedores())
        clbProveedores.SetItemChecked(1, frmRoles.nrRolSeleccionado.getPermisoModificacionProveedores())
        clbProveedores.SetItemChecked(2, frmRoles.nrRolSeleccionado.getPermisoListarProveedores())
        clbProveedores.SetItemChecked(3, frmRoles.nrRolSeleccionado.getPermisoEliminacionProveedores())
        clbProveedores.SetItemChecked(4, frmRoles.nrRolSeleccionado.getPermisoBuscarProveedores())

        'permisos de manejo de productos
        clbProductos.SetItemChecked(0, frmRoles.nrRolSeleccionado.getPermisoCreacionProductos())
        clbProductos.SetItemChecked(1, frmRoles.nrRolSeleccionado.getPermisoModificacionProductos())
        clbProductos.SetItemChecked(2, frmRoles.nrRolSeleccionado.getPermisoListarProductos())
        clbProductos.SetItemChecked(3, frmRoles.nrRolSeleccionado.getPermisoEliminacionProductos())
        clbProductos.SetItemChecked(4, frmRoles.nrRolSeleccionado.getPermisoBusquedaProductos())
        clbProductos.SetItemChecked(5, frmRoles.nrRolSeleccionado.getPermisoCargarProductos())
        clbProductos.SetItemChecked(6, frmRoles.nrRolSeleccionado.getPermisoDescargarProductos())

        'permisos de manejo de compras
        clbCompras.SetItemChecked(0, frmRoles.nrRolSeleccionado.getPermisoCompra())
        clbCompras.SetItemChecked(1, frmRoles.nrRolSeleccionado.getPermisoDevolverProductosProveedores())

        'permisos de manejo de clientes
        clbClientes.SetItemChecked(0, frmRoles.nrRolSeleccionado.getPermisoCreacionClientes())
        clbClientes.SetItemChecked(1, frmRoles.nrRolSeleccionado.getPermisoModificacionClientes())
        clbClientes.SetItemChecked(2, frmRoles.nrRolSeleccionado.getPermisoListarClientes())

        'permisos de manejo de ventas
        clbVentas.SetItemChecked(0, frmRoles.nrRolSeleccionado.getPermisoVentas())
        clbVentas.SetItemChecked(1, frmRoles.nrRolSeleccionado.getPermisoEliminarFacturasVentas())

        'permisos de manejo de tipos de cliente
        clbCliente.SetItemChecked(0, frmRoles.nrRolSeleccionado.getPermisoCreacionTiposCliente())
        clbCliente.SetItemChecked(1, frmRoles.nrRolSeleccionado.getPermisoModificacionTiposCliente())
        clbCliente.SetItemChecked(2, frmRoles.nrRolSeleccionado.getPermisoListarTiposCliente())
        clbCliente.SetItemChecked(3, frmRoles.nrRolSeleccionado.getPermisoEliminacionTiposCliente())

        'permisos de reportes
        clbReportes.SetItemChecked(0, frmRoles.nrRolSeleccionado.getPermisoCortesCaja())
        clbReportes.SetItemChecked(1, frmRoles.nrRolSeleccionado.getPermisoReporteFacturasVentaEliminadas())
        clbReportes.SetItemChecked(2, frmRoles.nrRolSeleccionado.getPermisoReporteDevolucionesProveedor())
        clbReportes.SetItemChecked(3, frmRoles.nrRolSeleccionado.getPermisoHistorialCostos())
        clbReportes.SetItemChecked(4, frmRoles.nrRolSeleccionado.getPermisoHistorialVentasMes())
        clbReportes.SetItemChecked(5, frmRoles.nrRolSeleccionado.getPermisoHistorialComprasMes())
        'clbReportes.SetItemChecked(6, frmRoles.nrRolSeleccionado.getPermisoHistorialCreditoPorProveedor())
        'clbReportes.SetItemChecked(7, frmRoles.nrRolSeleccionado.getPermisoHistorialCreditoMes())

        'creando permisos de gestión de series (talonarios)
        clbTalonario.SetItemChecked(0, frmRoles.nrRolSeleccionado.getPermisoCreacionSerieFacturaVenta())
        clbTalonario.SetItemChecked(1, frmRoles.nrRolSeleccionado.getPermisoModificacionSerieFacturaVenta())
        clbTalonario.SetItemChecked(2, frmRoles.nrRolSeleccionado.getPermisoListarSerieFacturaVenta())
        clbTalonario.SetItemChecked(3, frmRoles.nrRolSeleccionado.getPermisoEliminacionSerieFacturaVenta())
    End Sub
End Class