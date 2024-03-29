﻿Imports negocios

Public Class frmCompras
    Public Shared lnpNuevoProveedor As negociosProveedores = New negociosProveedores()
    Private glstProveedor As List(Of negociosProveedores) = New List(Of negociosProveedores)
    Dim lbooBanderaPunto As Boolean = False
    Private glstProveedorFiltrada As List(Of negociosProveedores) = New List(Of negociosProveedores)
    Public Shared gnpProveedorSeleccionado As negociosProveedores
    Private banderaBusqueda As Boolean = False
    Public Shared productoSeleccionado As negociosProducto
    Private DetalleFacturaProveedor As negociosDetallesFacturasProveedores = New negociosDetallesFacturasProveedores()
    Private idProveedore As Integer
    Dim EncabezadoFactura As negociosFacturasProveedores
    Dim ldtTabla1 As DataTable = New DataTable()
    Dim ldrFila1 As DataRow
    Dim lnpDetalleFactura As negociosDetallesFacturasProveedores
    Dim total As Decimal
    Public Shared encabezado As negociosFacturasProveedores
    Dim pasoCantidad As Integer
    Dim pasoIdProducto As Integer
    Dim pasoCosto As Decimal
    Dim idFactura As Integer


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        frmModuloProductos.btnSalir.Visible = False

        frmModuloProductos.seleccion = 1
        frmModuloProductos.ShowDialog()
        frmModuloProductos.Dispose()
        txtTela.Text = productoSeleccionado.getNombre()
        txtCantidad.Focus()
        ' ahora se procede a obtener el objeto estático que está en el frmModuloProductos...
    End Sub
    Private Sub insertarEncabezadoFactura()
        Try
            EncabezadoFactura = New negociosFacturasProveedores()
            EncabezadoFactura.setIdEmpleado(frmPrincipal.gnegEmpleado.getIdEmpleado())
            EncabezadoFactura.setIdProveedor(idProveedore)
            EncabezadoFactura.setSerie(txtSerie.Text)
            EncabezadoFactura.setNumero(Convert.ToInt32(txtCorrelativo.Text))
            EncabezadoFactura.setTotal(Convert.ToDecimal(lblTotal.Text))
            EncabezadoFactura.setFecha(DateTimePicker1.Value)
            EncabezadoFactura.fnsInsertarFacturaProveedor()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub insertarDetalleFactura()
        Try
            DetalleFacturaProveedor.setCantidad(pasoCantidad)
            DetalleFacturaProveedor.setIdProducto(pasoIdProducto)
            DetalleFacturaProveedor.setCosto(pasoCosto)
            DetalleFacturaProveedor.setIdFacturaProveedor(idFactura)
            DetalleFacturaProveedor.fnsInsertarDetalleFacturaProveedor()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cargarDataTableDetalle()
        ldrFila1 = ldtTabla1.NewRow()
        ldrFila1(0) = productoSeleccionado.getIdProducto()
        ldrFila1(1) = productoSeleccionado.getNombre()
        ldrFila1(2) = txtCosto.Text
        ldrFila1(3) = txtCantidad.Text
        ldtTabla1.Rows.Add(ldrFila1)
        dgvDetalleFactura.DataSource = ldtTabla1
        dgvDetalleFactura.Columns(0).Visible = False
        total = 0
        For i As Integer = 0 To dgvDetalleFactura.RowCount - 1
            total = total + Convert.ToDouble(dgvDetalleFactura.Item(2, i).Value)
        Next
        txtTela.Text = ""
        txtCantidad.Text = ""
        txtCosto.Text = ""
        lblTotal.Text = Convert.ToString(total)
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCesta.Click
        Dim bandera As Boolean
        bandera = 0
        For Each ctrlIterador As Control In Me.Controls
            If TypeOf (ctrlIterador) Is Windows.Forms.TextBox Then
                If (ctrlIterador.Text = "") Then
                    ctrlIterador.BackColor = Color.Yellow
                Else
                    ctrlIterador.BackColor = Color.White
                    bandera = 1
                End If
            End If
        Next
            Dim idProducto As Integer
            Dim cantidad As Integer
            Dim costo As Double
            Dim idFacturas As Integer
            encabezado = New negociosFacturasProveedores()
            Dim ldtTabla As DataTable = New DataTable()
        Try
            idFacturas = encabezado.fnslListarFacturaSerieNumero()
            insertarEncabezadoFactura()
            Dim i As Int32 = 0
            For i = 0 To ldtTabla1.Rows.Count - 1
                ldrFila1 = ldtTabla1.Rows(i)
                pasoIdProducto = Convert.ToInt32(ldrFila1(0))
                pasoCantidad = Convert.ToInt32(ldrFila1(3))
                pasoCosto = Convert.ToDecimal(ldrFila1(2))
                idFactura = idFacturas
                insertarDetalleFactura()
            Next
            MessageBox.Show("La operación de compra se llevó a cabo con éxito", "Insersión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
            frmModuloCompras.fnvdRecargar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
            e.KeyChar = vbNullChar

        End If

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtTela_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not (e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then  'revisar si lleva numeros en los nombres de las telas
            e.KeyChar = vbNullChar

        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress

        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
            e.KeyChar = vbNullChar
        End If

    End Sub
    Private Sub txtnit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNit.KeyPress
        If txtNit.Text.Trim.ToLower.StartsWith("c") Then
            txtNombre.Enabled = True
            txtDireccion.Enabled = True
        Else
            txtNombre.Enabled = False
            txtDireccion.Enabled = False
        End If
    End Sub

    Private Sub txtSerie_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtCorrelativo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCorrelativo.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub DateTimePicker1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub lblEmpleado_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEmpleado.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNit.Leave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNombre_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtDireccion_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtTela_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTela.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtCantidad_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnBuscar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnagregar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvDetalleFactura_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDetalleFactura.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCesta.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtSerie_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.MouseHover
        slblDescripcion.Text = "Ingrese el número de serie, no más de 4 caracteres"
    End Sub

    Private Sub DateTimePicker1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.MouseHover
        slblDescripcion.Text = "Seleccione la fecha de la factura"
    End Sub

    Private Sub lblEmpleado_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEmpleado.MouseHover
        slblDescripcion.Text = "Se muestra el nombre del empleado logueado"
    End Sub

    Private Sub txtNit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNit.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNit.MouseHover
        slblDescripcion.Text = "Ingrese el nit, sin guión"
    End Sub

    Private Sub txtNombre_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseHover
        slblDescripcion.Text = "Nombre del proveedor"
    End Sub

    Private Sub txtDireccion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseHover
        slblDescripcion.Text = "Dirección del proveedor"
    End Sub

    Private Sub txtTela_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTela.MouseHover
        slblDescripcion.Text = "Producto comprado"
    End Sub

    Private Sub txtCantidad_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.MouseHover
        slblDescripcion.Text = "Cantidad de tela"
    End Sub

    Private Sub btnagregar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.MouseHover
        slblDescripcion.Text = "Agregar el producto al detalle de compra"
    End Sub

    Private Sub dgvDetalleFactura_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDetalleFactura.MouseHover
        slblDescripcion.Text = "Detalle de compras"
    End Sub

    Private Sub lblTotal_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub lblTotal_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.MouseHover
        slblDescripcion.Text = "El total de la factura de compra"
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cierra la ventana si guardar"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCesta.MouseHover
        slblDescripcion.Text = "Cierra la ventana y guarda la factura"
    End Sub

    Private Sub frmCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblEmpleado.Text = frmPrincipal.gnegEmpleado.getNombreEmpleado()
        ldtTabla1.Columns.Add("Id Producto")
        ldtTabla1.Columns.Add("Nombre")
        ldtTabla1.Columns.Add("Costo")
        ldtTabla1.Columns.Add("Cantidad")

    End Sub

    Private Sub txtNit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNit.TextChanged
        fnvdRecargar()

    End Sub
    Private Sub fnvdRecargar()
        Try
            frmEmpleados.gnpRolSeleccionado = Nothing
            Me.glstProveedorFiltrada.Clear()
            Me.banderaBusqueda = False
            Me.glstProveedor = negociosProveedores.fnslBuscarProveedorPorNit(txtNit.Text)
            Me.fnvCrearDataTable(Me.glstProveedor)
            btnBuscar.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub fnvCrearDataTable(ByRef lista As List(Of negociosProveedores))
        Dim ldtTabla As DataTable = New DataTable()
        Dim ldrFila As DataRow
        Dim lnpProveedor As negociosProveedores
        ldtTabla.Columns.Add("Nit")
        ldtTabla.Columns.Add("Nombre")
        ldtTabla.Columns.Add("Direccion")
        For i = 0 To lista.Count - 1 Step 1
            ldrFila = ldtTabla.NewRow()
            lnpProveedor = lista(i)
            ldrFila(0) = lnpProveedor.getNit()
            ldrFila(1) = lnpProveedor.getNombre()
            ldrFila(2) = lnpProveedor.getDireccion()
            ldtTabla.Rows.Add(ldrFila)
            txtNombre.Text = lnpProveedor.getNombre()
            txtDireccion.Text = lnpProveedor.getDireccion()
            idProveedore = lnpProveedor.getId()
        Next
        If (txtDireccion.Text <> "") Then
            gpProducto.Enabled = True
        End If
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub lbEtiquetaTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbEtiquetaTotal.Click

    End Sub

    Private Sub lblTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub btnagregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        cargarDataTableDetalle()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ldtTabla1.Rows.RemoveAt(Me.dgvDetalleFactura.CurrentRow.Index)
    End Sub

    Private Sub dgvDetalleFactura_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalleFactura.CellClick
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub txtCorrelativo_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtCorrelativo.MouseHover
        slblDescripcion.Text = "Ingrese el correlativo de la factura"
    End Sub

    Private Sub txtCosto_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtCosto.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtCosto_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtCosto.MouseHover
        slblDescripcion.Text = "Ingrese el costo unitario del producto"
    End Sub

    Private Sub btnBuscar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnBuscar.MouseHover
        slblDescripcion.Text = "Realiza la búsqueda"
    End Sub

    Private Sub vtVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtSerie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.TextChanged
        txtCorrelativo.Enabled = True
    End Sub

    Private Sub txtCorrelativo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCorrelativo.TextChanged
        txtNit.Enabled = True
    End Sub
End Class