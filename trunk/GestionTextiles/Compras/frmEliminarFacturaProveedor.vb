Imports negocios

Public Class frmEliminarFacturaProveedor
    Dim provTemp As negociosProveedores

    Private Sub frmEliminarFacturaProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            provTemp = negociosProveedores.fnnpBuscarProveedorPorId(frmModuloCompras.gnpComprasSeleccionado.getIdProveedor())
            Me.txtSerie.Text = frmModuloCompras.gnpComprasSeleccionado.getSerie()
            Me.txtCorrelativo.Text = frmModuloCompras.gnpComprasSeleccionado.getNumero().ToString()
            Me.txtNit.Text = provTemp.getNit()
            Me.txtDireccion.Text = provTemp.getDireccion()
            Me.txtNombre.Text = provTemp.getNombre()
            fnvCrearDataTable(frmModuloCompras.gnpComprasSeleccionado.getListaDetallesFacturaProveedor())
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub fnvCrearDataTable(ByRef lista As List(Of negociosDetallesFacturasProveedores))
        Dim ldtTabla As DataTable = New DataTable()
        Dim ldrFila As DataRow
        Dim npDetalleFacturaProveedor As negociosDetallesFacturasProveedores = New negociosDetallesFacturasProveedores()
        Dim npProductoEnDetalle As negociosProducto = New negociosProducto()

        ldtTabla.Columns.Add("Codigo")
        ldtTabla.Columns.Add("Nombre")
        ldtTabla.Columns.Add("Color")
        ldtTabla.Columns.Add("Costo")
        ldtTabla.Columns.Add("Cantidad")

        For i = 0 To lista.Count - 1 Step 1
            ldrFila = ldtTabla.NewRow()

            npDetalleFacturaProveedor = lista(i)
            npProductoEnDetalle = negociosProducto.fnObtenerProductoPorId(npDetalleFacturaProveedor.getIdProducto())

            ldrFila(0) = npProductoEnDetalle.getCodigo()
            ldrFila(1) = npProductoEnDetalle.getNombre()
            ldrFila(2) = npProductoEnDetalle.getColor()
            ldrFila(3) = npDetalleFacturaProveedor.getCosto().ToString()
            ldrFila(4) = npDetalleFacturaProveedor.getCantidad()
            ldtTabla.Rows.Add(ldrFila)

        Next

        Me.dgvDetalleFactura.DataSource = ldtTabla

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim sAnotacion, sMensaje As String
        sAnotacion = InputBox("Razones de la eliminacion de la factura: ", "Anotaciones")
        Try
            If MessageBox.Show("¿Está seguro que desa desactivar al proveedor: " + provTemp.getEmpresa() + ", de la base de datos?", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                sMensaje = frmModuloCompras.gnpComprasSeleccionado.fnsEliminarFacturaProveedor(sAnotacion)
                MessageBox.Show(sMensaje, "Factura Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class