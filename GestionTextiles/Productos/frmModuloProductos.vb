Imports negocios
Public Class frmModuloProductos
    Private glstProductos As List(Of negociosProducto)
    Private glstProductosFiltrada As List(Of negociosProducto)
    Public Shared gnpProductoSeleccionado As negociosProducto
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

    Private Sub btnSalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseLeave
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

    Private Sub btnSalir_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseHover
        slblDescripcion.Text = "Salir de la aplicación"
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If txtbusqueda.Text = "" Then
            Me.fnvdRecargar()
        Else
            'codigo para busqueda
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
        Try
            Me.fnvdRecargar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


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
        frmModuloProductos.gnpProductoSeleccionado = glstProductos(e.RowIndex)
    End Sub

    Private Sub dgvEmpleados_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvEmpleados.CellMouseClick

    End Sub
    Private Sub fnvdRecargar()
        frmModuloProductos.gnpProductoSeleccionado = Nothing
        Me.glstProductos = negociosProducto.fnlstListarProductos()
        Me.fnvCrearDataTable(Me.glstProductos)
    End Sub
    Private Sub fnvBuscar(ByRef txt As String)
        Me.glstProductosFiltrada = New List(Of negociosProducto)
        For Each i As negociosProducto In Me.glstProductos
            If i.getCodigo() = txt Or i.getNombre() = txt Or i.getColor() = txt Then
                Me.glstProductosFiltrada.Add(i)
            End If
        Next
        Me.fnvCrearDataTable(Me.glstProductosFiltrada)
        Me.glstProductosFiltrada = Nothing
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.fnvdRecargar()
    End Sub
End Class