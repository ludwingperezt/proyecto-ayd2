Imports negocios
Public Class frmModuloProductos
    Private glstProductos As List(Of negociosProducto) = New List(Of negociosProducto)
    Private glstProductosFiltrada As List(Of negociosProducto) = New List(Of negociosProducto)
    Public Shared gnpProductoSeleccionado As negociosProducto
    Private numeroPagina As Integer = 1

    Private banderaBusqueda As Boolean = False
    Private Sub txtbusqueda_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnbuscar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvEmpleados_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvEmpleados.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnIngresarProducto_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarProducto.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnModificarProducto_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProducto.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnEliminarProducto_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProducto.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtbusqueda_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseHover
        slblDescripcion.Text = "Ingrese  algun dato del Producto a buscar ej. "
    End Sub

    Private Sub btnbuscar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseHover
        slblDescripcion.Text = "Debe  precionar el boton 'buscar' para inciar la busqueda "
    End Sub

    Private Sub dgvEmpleados_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvEmpleados.MouseHover
        slblDescripcion.Text = "Listado de Productos actuales"
    End Sub

    Private Sub btnIngresarProducto_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarProducto.MouseHover
        slblDescripcion.Text = "Ingreso de nuevos Productos "
    End Sub

    Private Sub btnModificarProducto_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProducto.MouseHover
        slblDescripcion.Text = "Modificación de  Productos"
    End Sub

    Private Sub btnEliminarProducto_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProducto.MouseHover
        slblDescripcion.Text = "Eliminacion de Productos"
    End Sub

    Private Sub btnSalir_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Salir de la aplicación"
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If txtbusqueda.Text = "" Then
            Me.fnvdRecargar()
        Else
            'codigo para busqueda
            Me.banderaBusqueda = True
            Me.fnvBuscar(txtbusqueda.Text)
        End If
    End Sub

    Private Sub btnIngresarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarProducto.Click
        frmIngresoProductos.ShowDialog(Me)
        Me.fnvdRecargar()
    End Sub

    Private Sub btnModificarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProducto.Click
        If IsNothing(frmModuloProductos.gnpProductoSeleccionado) Then
            MessageBox.Show("Debe seleccionar un producto de la lista para poder modificar sus datos", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            frmModificarProductos.ShowDialog(Me)
            Me.fnvdRecargar()
        End If

    End Sub

    Private Sub btnEliminarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProducto.Click
        If IsNothing(frmModuloProductos.gnpProductoSeleccionado) Then
            MessageBox.Show("Debe seleccionar un producto de la lista para poder eliminarlo", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If MessageBox.Show("¿Está seguro de querer eliminar el producto " + frmModuloProductos.gnpProductoSeleccionado.getNombre() + "de la base de datos? Esta operación no se puede deshacer", "Precaución", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    frmModuloProductos.gnpProductoSeleccionado.fnvdEliminarProducto()
                    MessageBox.Show("La operación finalizó con éxito", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Me.fnvdRecargar()
            End If
        End If
    End Sub

    Private Sub frmModuloProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.fnvdRecargar()
    End Sub
    Private Sub fnvCrearDataTable(ByRef lst As List(Of negociosProducto))
        Dim ldtTabla As DataTable = New DataTable()
        ldtTabla.Columns.Add("Codigo")
        ldtTabla.Columns.Add("Nombre")
        ldtTabla.Columns.Add("Cantidad")
        ldtTabla.Columns.Add("Precio compra")
        ldtTabla.Columns.Add("Precio venta")
        ldtTabla.Columns.Add("Color")
        For i = 0 To lst.Count - 1 Step 1
            Dim ldrFila As DataRow = ldtTabla.NewRow()
            Dim lnpProductoLocal As negociosProducto = lst(i)
            ldrFila(0) = lnpProductoLocal.getCodigo()
            ldrFila(1) = lnpProductoLocal.getNombre()
            ldrFila(2) = lnpProductoLocal.getStock()
            ldrFila(3) = lnpProductoLocal.getPrecioCompra()
            ldrFila(4) = lnpProductoLocal.getPrecioVenta()
            ldrFila(5) = lnpProductoLocal.getColor()
            ldtTabla.Rows.Add(ldrFila)
        Next
        Me.dgvEmpleados.DataSource = ldtTabla
    End Sub

    Private Sub dgvEmpleados_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick
        If banderaBusqueda Then
            frmModuloProductos.gnpProductoSeleccionado = glstProductosFiltrada(e.RowIndex)
        Else
            frmModuloProductos.gnpProductoSeleccionado = glstProductos(e.RowIndex)
        End If

    End Sub

    Private Sub fnvdRecargar()
        Try
            frmModuloProductos.gnpProductoSeleccionado = Nothing
            Me.glstProductosFiltrada.Clear()
            Me.banderaBusqueda = False
            Me.glstProductos = negociosProducto.fnPaginacionProductos(25, Me.numeroPagina)
            Me.fnvCrearDataTable(Me.glstProductos)
            If Me.glstProductos.Count < 25 Then
                btnSiguiente.Enabled = False
            Else
                btnSiguiente.Enabled = True
            End If
            If Me.numeroPagina = 1 Then
                btnAnterior.Enabled = False
            Else
                btnAnterior.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvEmpleados.DataSource = Nothing
        End Try
    End Sub
    Private Sub fnvBuscar(ByRef txt As String)
        If chNombre.Checked = True And chCodigo.Checked = False Then 'busqueda solo por nombre
            Me.glstProductosFiltrada = negociosProducto.fnFiltrarProductosPorNombre(txt)
            Me.cargarResultadosBusqueda()
        ElseIf chNombre.Checked = False And chCodigo.Checked = True Then 'busqueda solo por codigo
            Me.glstProductosFiltrada = negociosProducto.fnFiltrarProductosPorCodigo(txt)
            Me.cargarResultadosBusqueda()
        ElseIf chNombre.Checked = True And chCodigo.Checked = False Then 'busqueda exacta por ambos criterios
            Me.glstProductosFiltrada = negociosProducto.fnBuscarProductosPorCodigoNombre(txt)
            Me.cargarResultadosBusqueda()
        Else ''si no se seleccionò un criterio, se carga todo de nuevo
            Me.fnvdRecargar()
        End If
    End Sub

    Private Sub cargarResultadosBusqueda()
        Me.fnvCrearDataTable(Me.glstProductosFiltrada)
        If Me.glstProductosFiltrada.Count = 0 Then
            MessageBox.Show("No se encontraron coincidencias en la búsqueda para el criterio utilizado", "No hay resultados que mostrar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        If txtbusqueda.Text = "" Then
            btnbuscar.Enabled = False
        Else
            btnbuscar.Enabled = True
        End If
    End Sub

    Private Sub btnSeleccionarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarProducto.Click
        If IsNothing(frmModuloProductos.gnpProductoSeleccionado) Then
            MessageBox.Show("No puede usar esta opción si no ha hecho clic en algun elemento de la lista", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.fnvdRecargar()
    End Sub

    Private Sub btnRegresar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSeleccionarProducto_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarProducto.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSalir_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnRegresar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.MouseHover
        slblDescripcion.Text = "Regresa al Filtro Inicial."
    End Sub

    Private Sub btnSeleccionarProducto_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarProducto.MouseHover
        slblDescripcion.Text = "Confirma el Producto que Selecciono de la Lista."
    End Sub

    Private Sub btnSalir_MouseHover_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseHover
        slblDescripcion.Text = "Salir de la aplicación"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If Me.numeroPagina > 1 Then
            Me.numeroPagina = Me.numeroPagina - 1
            Me.fnvdRecargar()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        Me.numeroPagina = Me.numeroPagina + 1
        Me.fnvdRecargar()
    End Sub
End Class