Public Class frmPrincipal

    '' TODOS LAS FECHAS SE DEBEN GESTIONAR DESDE ESTE TIMER
    Private Sub tmrRefrescarBarra_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRefrescarBarra.Tick
        Me.slblFecha.Text = Date.Now
        frmAnular.slblFecha.Text = Date.Now
        frmVentas.slblFecha.Text = Date.Now
        frmFacturar.slblFecha.Text = Date.Now
        frmClientes.slblFecha.Text = Date.Now
        frmingresoclientes.slblFecha.Text = Date.Now
        frmingresotipocliente.slblFecha.Text = Date.Now
        frmLogin.slblFecha.Text = Date.Now
        frmModificarCliente.slblFecha.Text = Date.Now
        frmModificarTipoCliente.slblFecha.Text = Date.Now
        ''frmReporteCorteCaja.slblFecha.Text = Date.Now
        frmtipocliente.slblFecha.Text = Date.Now
        frmModuloReportes.slblFecha.Text = Date.Now

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVentas.Click
        frmVentas.ShowDialog(Me)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProveedores.Click
        frmModuloProveedores.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompras.Click
        frmModuloCompras.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientes.Click
        frmClientes.Show()

    End Sub

    Private Sub BtnEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmpleados.Click
        'frmEmpleados.Show()
        frmModuloEmpleados.ShowDialog()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub BtnVentas_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVentas.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub BtnCompras_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompras.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub BtnClientes_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientes.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub BtnProveedores_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProveedores.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub BtnEmpleados_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmpleados.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub BtnSalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub BtnVentas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVentas.MouseHover
        slblDescripcion.Text = "Módulo encargado de la gestion de ventas como la facturación y la anulación de facturas. "
    End Sub

    Private Sub BtnCompras_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompras.MouseHover
        slblDescripcion.Text = "Módulo encargado de gestionar las compras de la empresa. "
    End Sub

    Private Sub BtnClientes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientes.MouseHover
        slblDescripcion.Text = "Módulo encargado de gestionar el manejo de los clientes como agregar, modificar ,eliminar y manejar los tipos de clientes"
    End Sub

    Private Sub BtnProveedores_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProveedores.MouseHover
        slblDescripcion.Text = "Módulo encargado de gestionar el manejo de los proveedores como agregar, modificar y eliminar"
    End Sub

    Private Sub BtnEmpleados_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmpleados.MouseHover
        slblDescripcion.Text = "Módulo encargado de gestionar el manejo de los empleados como agregar, modificar y eliminar"
    End Sub

    Private Sub BtnSalir_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.MouseHover
        slblDescripcion.Text = "Sale de la aplicación"
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRoles.Click
        frmRoles.ShowDialog()
    End Sub

    Private Sub btnReportes_Click(sender As System.Object, e As System.EventArgs) Handles btnReportes.Click
        frmModuloReportes.ShowDialog()
    End Sub

    Private Sub BtnLogin_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub BtnRoles_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRoles.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub BtnGestionTalonarios_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGestionTalonarios.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnReportes_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportes.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub BtnLogin_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.MouseHover
        slblDescripcion.Text = "Ingreso de usuario y contraseña para acceder al sistema"
    End Sub

    Private Sub BtnRoles_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRoles.MouseHover
        slblDescripcion.Text = "Módulo encargado de gestionar los persmisos de acceso  de los usuarios"
    End Sub

    Private Sub BtnGestionTalonarios_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGestionTalonarios.MouseHover
        slblDescripcion.Text = "Módulo encargado de gestionar la numeración y series de las facturas"
    End Sub

    Private Sub btnReportes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportes.MouseHover
        slblDescripcion.Text = "Módulo encargado de generar y mostrar los resportes "
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        frmLogin.ShowDialog()
    End Sub

    Private Sub BtnGestionTalonarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGestionTalonarios.Click
        frmModuloSeries.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.Click
        frmModuloProductos.ShowDialog()
    End Sub

    Private Sub btnProductos_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnProductos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.MouseHover
        slblDescripcion.Text = "Módulo para gestionar los productos"
    End Sub
End Class