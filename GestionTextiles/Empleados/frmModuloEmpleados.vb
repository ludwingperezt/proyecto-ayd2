Imports negocios
Public Class frmModuloEmpleados
    Private glstEmpleados As List(Of negociosEmpleado) = New List(Of negociosEmpleado)
    Private glstEmpleadosFiltrada As List(Of negociosEmpleado) = New List(Of negociosEmpleado)
    Public Shared gnpEmpleadoSeleccionado As negociosEmpleado
    Private banderaBusqueda As Boolean = False

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If txtbusqueda.Text = "" Then
            MessageBox.Show("Ingrese la busqueda deseada ")
        Else
            'codigo para busqueda
            Dim parametro As String
            parametro = cmbFiltroCriterio.SelectedItem
            If (parametro = "Nombre") Then
                fnvdRecargarNombre()
            End If
            If (parametro = "Usuario") Then
                fnvdRecargarUsuario()
            End If
            If (parametro = "Apellido") Then
                fnvdRecargarApellido()
            End If
        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnIngresarEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarEmpleado.Click
        frmEmpleados.ShowDialog(Me)
    End Sub

    Private Sub btnModificarEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarEmpleado.Click
        If IsNothing(frmModuloEmpleados.gnpEmpleadoSeleccionado) Then
            MessageBox.Show("Debe seleccionar un empleado de la lista para poder modificar sus datos", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            frmModificarEmpleado.actualizar = True
            frmModificarEmpleado.ShowDialog(Me)
            Me.fnvdRecargar()
            txtbusqueda.Text = ""
        End If
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

    Private Sub dgvEmpleados_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub dgvEmpleados_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnRegresar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnRegresar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.MouseHover
        slblDescripcion.Text = "Regresa al Filtro Inicial."
    End Sub
    Private Sub dgvEmpleados_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick
        If banderaBusqueda Then
            frmModuloEmpleados.gnpEmpleadoSeleccionado = glstEmpleadosFiltrada(e.RowIndex)
        Else
            frmModuloEmpleados.gnpEmpleadoSeleccionado = glstEmpleados(e.RowIndex)
        End If
    End Sub
    Private Sub frmModuloEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establecer permisos
        Dim lnegPermisos As negociosRol = frmPrincipal.gnegPermisos

        If lnegPermisos.getPermisoCreacionEmpleados Then
            btnIngresarEmpleado.Enabled = True
        Else
            btnIngresarEmpleado.Enabled = False
        End If

        If lnegPermisos.getPermisoModificacionEmpleados Then
            btnModificarEmpleado.Enabled = True
        Else
            btnModificarEmpleado.Enabled = False
        End If

        If lnegPermisos.getPermisoEliminacionEmpleados Then
            btnEliminarEmpleados.Enabled = True
        Else
            btnEliminarEmpleados.Enabled = False
        End If

        If lnegPermisos.getPermisoListarEmpleados Then
            txtbusqueda.Enabled = True
            btnbuscar.Enabled = True
            cmbFiltroCriterio.Enabled = True
            cmbFiltradoEstados.Enabled = True
            dgvEmpleados.Enabled = True
            btnRegresar.Enabled = True
            Try
                fnvdRecargar()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            txtbusqueda.Enabled = False
            btnbuscar.Enabled = False
            cmbFiltroCriterio.Enabled = False
            cmbFiltradoEstados.Enabled = False
            dgvEmpleados.Enabled = False
            btnRegresar.Enabled = False
        End If
    End Sub
    Private Sub fnvdRecargarUsuario()
        Try
            dgvEmpleados.DataSource = ""
            frmModuloEmpleados.gnpEmpleadoSeleccionado = Nothing
            Me.glstEmpleadosFiltrada.Clear()
            Me.banderaBusqueda = False
            Me.glstEmpleados = negociosEmpleado.fnslListarEmpleadoUsuario(txtbusqueda.Text)
            Me.fnvCrearDataTable(Me.glstEmpleados)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvEmpleados.DataSource = Nothing
        End Try
    End Sub
    Private Sub fnvdRecargarNombre()
        Try
            dgvEmpleados.DataSource = ""
            frmModuloEmpleados.gnpEmpleadoSeleccionado = Nothing
            Me.glstEmpleadosFiltrada.Clear()
            Me.banderaBusqueda = False
            Me.glstEmpleados = negociosEmpleado.fnslListarEmpleadoNombre(txtbusqueda.Text)
            Me.fnvCrearDataTable(Me.glstEmpleados)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvEmpleados.DataSource = Nothing
        End Try
    End Sub
    Private Sub fnvdRecargarApellido()
        Try
            dgvEmpleados.DataSource = ""
            frmModuloEmpleados.gnpEmpleadoSeleccionado = Nothing
            Me.glstEmpleadosFiltrada.Clear()
            Me.banderaBusqueda = False
            Me.glstEmpleados = negociosEmpleado.fnslListarEmpleadoApellido(txtbusqueda.Text)
            Me.fnvCrearDataTable(Me.glstEmpleados)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvEmpleados.DataSource = Nothing
        End Try
    End Sub
    Private Sub fnvdRecargar()
        Try
            dgvEmpleados.DataSource = ""
            frmModuloEmpleados.gnpEmpleadoSeleccionado = Nothing
            Me.glstEmpleadosFiltrada.Clear()
            Me.banderaBusqueda = False
            Me.glstEmpleados = negociosEmpleado.fnslListarUltimosVeinteEmpleados()
            Me.fnvCrearDataTable(Me.glstEmpleados)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvEmpleados.DataSource = Nothing
        End Try
    End Sub

    Private Sub fnvCrearDataTable(ByRef lista As List(Of negociosEmpleado))
        Dim ldtTabla As DataTable = New DataTable()
        Dim ldrFila As DataRow
        Dim lnpEmpleado As negociosEmpleado
        ldtTabla.Columns.Add("Nombre")
        ldtTabla.Columns.Add("Apellido")
        ldtTabla.Columns.Add("Direccion")
        ldtTabla.Columns.Add("Telefono")
        ldtTabla.Columns.Add("Celular")
        ldtTabla.Columns.Add("Puesto")
        ldtTabla.Columns.Add("Fecha Contratacion")
        ldtTabla.Columns.Add("Salario")

        For i = 0 To lista.Count - 1 Step 1
            ldrFila = ldtTabla.NewRow()
            lnpEmpleado = lista(i)
            ldrFila(0) = lnpEmpleado.getNombreEmpleado()
            ldrFila(1) = lnpEmpleado.getApellidoEmpleado()
            ldrFila(2) = lnpEmpleado.getDireccionEmpleado()
            ldrFila(3) = lnpEmpleado.getTelefonoEmpleado()
            ldrFila(4) = lnpEmpleado.getCelularEmpleado()
            ldrFila(5) = lnpEmpleado.getPuestoEmpleado()
            ldrFila(6) = lnpEmpleado.getFechaDeContratacion()
            ldrFila(7) = lnpEmpleado.getSalarioEmpleado()
            ldtTabla.Rows.Add(ldrFila)

        Next
        Me.dgvEmpleados.DataSource = ldtTabla
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.fnvdRecargar()
    End Sub

    Private Sub gbListaEmpleados_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbListaEmpleados.Enter

    End Sub

    Private Sub dgvEmpleados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmpleados.CellContentClick
        If banderaBusqueda Then
            frmModuloEmpleados.gnpEmpleadoSeleccionado = glstEmpleadosFiltrada(e.RowIndex)
        Else
            frmModuloEmpleados.gnpEmpleadoSeleccionado = glstEmpleados(e.RowIndex)
        End If
    End Sub
End Class