Imports negocios

Public Class frmPrincipal
    Public Shared gnegEmpleado As negociosEmpleado = New negociosEmpleado()
    Public Shared gnegPermisos As negociosRol = New negociosRol()


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
        frmVentas.Show(Me)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProveedores.Click
        frmModuloProveedores.Show(Me)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompras.Click
        frmModuloCompras.Show(Me)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientes.Click
        frmClientes.Show(Me)

    End Sub

    Private Sub BtnEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmpleados.Click
        'frmEmpleados.Show()
        frmModuloEmpleados.Show(Me)
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        End
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
        frmRoles.Show(Me)
    End Sub

    Private Sub btnReportes_Click(sender As System.Object, e As System.EventArgs) Handles btnReportes.Click
        frmModuloReportes.Show(Me)
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
        frmModuloSeries.Show(Me)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.Click
        frmModuloProductos.seleccion = False
        frmModuloProductos.ShowDialog(Me)
    End Sub

    Private Sub btnProductos_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnProductos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductos.MouseHover
        slblDescripcion.Text = "Módulo para gestionar los productos"
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gnegPermisos = negociosRol.fnObtenerRolPorId(2)
            lblEmpleado.Text = "Bienvenido: " + gnegEmpleado.getUsuarioEmpleado() + " - " + gnegPermisos.getNombre
            ' Esto queda para el final, xq sino no podremos realizar pruebas

            If gnegPermisos.getPermisoAccesoModuloCliente() Then
                BtnClientes.Enabled = True
            Else
                BtnClientes.Enabled = False
            End If

            If gnegPermisos.getPermisoAccesoModuloCompras() Then
                BtnCompras.Enabled = True
            Else
                BtnCompras.Enabled = False
            End If

            If gnegPermisos.getPermisoAccesoModuloEmpleados() Then
                BtnEmpleados.Enabled = True
            Else
                BtnEmpleados.Enabled = False
            End If

            If gnegPermisos.getPermisoAccesoModuloVentas() Then
                BtnVentas.Enabled = True
            Else
                BtnVentas.Enabled = False
            End If

            If gnegPermisos.getPermisoAccesoModuloProductos() Then
                btnProductos.Enabled = True
            Else
                btnProductos.Enabled = False
            End If

            If gnegPermisos.getPermisoAccesoModuloProveedores() Then
                BtnProveedores.Enabled = True
            Else
                BtnProveedores.Enabled = False

            End If

            If gnegPermisos.getPermisoAccesoModuloReportes() Then
                btnReportes.Enabled = True
            Else
                btnReportes.Enabled = False
            End If

            If gnegPermisos.getPermisoAccesoModuloRol() Then
                BtnRoles.Enabled = True
            Else
                BtnRoles.Enabled = False
            End If

            If gnegPermisos.getPermisoAccesoModuloTalonario() Then
                BtnGestionTalonarios.Enabled = True
            Else
                BtnGestionTalonarios.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
End Class