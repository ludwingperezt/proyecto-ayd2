Imports System.Xml
Imports negocios
Public Class frmFacturar
    Private serieActual As negociosSerie
    Public Shared productoSeleccionado As negociosProducto
    Private clienteActual As negociosCliente
    Private factura As negociosFacturaCliente = New negociosFacturaCliente()

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        factura.fnsCancelarFactura()
        Me.Dispose()
    End Sub

    Private Sub cmbserie_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtnit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnit.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtnombre_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtdireccion_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub TextBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub TextBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub DataGridView1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvdetallefactura.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtTotal_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtDescuento_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbserie_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Se debe seleccionar la serie  "
    End Sub

    Private Sub txtnumero_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Número de la factura"
    End Sub

    Private Sub txtnit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnit.MouseHover
        slblDescripcion.Text = "Se debe ingresar el nit del cliente. Ej: 1269264-5"
    End Sub

    Private Sub txtnombre_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.MouseHover
        slblDescripcion.Text = "Nombre del cliente"
    End Sub

    Private Sub txtdireccion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.MouseHover
        slblDescripcion.Text = "Dirección del cliente"
    End Sub

    Private Sub txtCodigo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Se debe ingresar el codigo de tela  Ej: 7486"
    End Sub

    Private Sub txtTela_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "tipo de tela "
    End Sub

    Private Sub txtCantidad_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Se debe ingresar la cantidad de yardas de tela  Ej. 5"
    End Sub

    Private Sub btnagregar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Ingreso de la tela selecciónada"
    End Sub

    Private Sub DataGridView1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvdetallefactura.MouseHover
        slblDescripcion.Text = "Descripcion de los productos a facturar"
    End Sub

    Private Sub txtTotal_MouseHover(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Total a pagar"
    End Sub

    Private Sub txtDescuento_MouseHover(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Descuento total"
    End Sub

    Private Sub btnCancelar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cancelar facturación"
    End Sub

    Private Sub btnAceptar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Inicia impresión de factura"
    End Sub

    Private Sub lblnumerofac_MouseLeave(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub lbltotal_MouseLeave(sender As System.Object, e As System.EventArgs) Handles lbltotal.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub lbldescuentofac_MouseLeave(sender As System.Object, e As System.EventArgs) Handles lbldescuentofac.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub lbldescuentofac_MouseHover(sender As System.Object, e As System.EventArgs) Handles lbldescuentofac.MouseHover
        slblDescripcion.Text = "Descuento factura"
    End Sub

    Private Sub lbltotal_MouseHover(sender As System.Object, e As System.EventArgs) Handles lbltotal.MouseHover
        slblDescripcion.Text = "Total a pagar"
    End Sub

    Private Sub lblnumerofac_MouseHover(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Numero de factura"
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        For Each ctrlIterador As Control In Me.Controls
            If TypeOf (ctrlIterador) Is Windows.Forms.TextBox Then
                If (ctrlIterador.Text = "") Then
                    ctrlIterador.BackColor = Color.Yellow
                Else
                    ctrlIterador.BackColor = Color.White
                End If
            End If
            '' Validación de combobox
            If TypeOf (ctrlIterador) Is Windows.Forms.ComboBox Then
                If (ctrlIterador.Text = "") Then
                    ctrlIterador.BackColor = Color.Yellow
                Else
                    ctrlIterador.BackColor = Color.White
                End If
            End If
        Next
        Try
            If IsNothing(Me.clienteActual) Then

            End If
            Me.factura.setIdEmpleado(frmPrincipal.gnegEmpleado.getIdEmpleado())
            MessageBox.Show(Me.factura.fnInsertarFacturaCliente(), "Insersión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Aqui se muestra el reporte de la factura en sì
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodigo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "." Or e.KeyChar = vbBack)) Then
            e.KeyChar = vbNullChar
        End If
        If e.KeyChar = "." Then
            If txtCantidad.Text.Contains(".") Then
                e.KeyChar = ""
            End If
        End If

    End Sub
    Private Sub txtnit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnit.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then
            e.KeyChar = vbNullChar

        End If
    End Sub

    Private Sub cmbserie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        frmModuloProductos.seleccion = True
        frmModuloProductos.ShowDialog(Me)
        frmModuloProductos.Dispose()
        If IsNothing(frmFacturar.productoSeleccionado) = False Then
            txtTela.Text = frmFacturar.productoSeleccionado.getNombre()
        End If

        ' ahora se procede a obtener el objeto estático que está en el frmModuloProductos...
    End Sub

    Private Sub frmFacturar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'usar en el futuro, la funcion para obtener la serie segun el idTerminal
        Try
            cmbtipocliente.DataSource = negociosTipoCliente.fnDbListarTiposClientes()
            cmbtipocliente.DisplayMember = "NOMBRE"
            cmbtipocliente.ValueMember = "IDTIPOCLIENTE"
            Me.dgvdetallefactura.DataSource = Nothing
            Me.serieActual = negociosSerie.fnObtenerSerieActiva()
            If IsNothing(Me.serieActual) Then
                MessageBox.Show("Debe ingresar un nuevo talonario de facturas", "No hay talonario de facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Dispose()
            Else
                txtSerie.Text = Me.serieActual.getSerie()
                lblEmpleado.Text = frmPrincipal.gnegEmpleado.getNombreEmpleado() + " " + frmPrincipal.gnegEmpleado.getApellidoEmpleado()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub btntipocliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntipocliente.Click
        frmtipocliente.Show()
    End Sub

    Private Sub txtnit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnit.Leave
        'If negociosCliente.fnBuscarClientePorNit(txtnit.Text) Then
        '    Me.clienteActual = 
        'End If
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        Dim lnfcDetalleTemporal As negociosDetalleFacturaCliente = New negociosDetalleFacturaCliente()
        If txtDescuento.Text = "" Then
            txtDescuento.Text = "0.00"
        End If
        Me.factura.setDescuento(Convert.ToDouble(txtDescuento.Text))
        If IsNothing(frmFacturar.productoSeleccionado) = False And txtCantidad.Text <> "" Then
            Try
                If negociosProducto.fnboVerificarCantidadExistenteProducto(frmFacturar.productoSeleccionado.getIdProducto(), Convert.ToDouble(txtCantidad.Text)) Then

                    lnfcDetalleTemporal.fnvSetDatosDetalle(frmFacturar.productoSeleccionado.getIdProducto, frmFacturar.productoSeleccionado.getPrecioVenta(), Convert.ToDouble(txtCantidad.Text), frmFacturar.productoSeleccionado.getNombre(), frmFacturar.productoSeleccionado.getCodigo())

                    frmFacturar.productoSeleccionado.fnvdDisminuirExistenciaProducto(lnfcDetalleTemporal.getCantidad())
                    Me.factura.fnvdAgregarProducto(lnfcDetalleTemporal)

                    Me.lbltotal.Text = Convert.ToString(Me.factura.getTotal())
                    Me.lblDescuento.Text = Convert.ToString(Me.factura.getSubTotal())
                    'agregar al dgv
                    
                    Me.fnvdLlenarDataGridView(Me.factura.getDetalleFactura())
                Else
                    MessageBox.Show("La existencia del producto no es suficiente para cubrir el pedido", "Producto insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtCantidad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.Leave

    End Sub

    Private Sub fnvdLlenarDataGridView(ByRef lst As List(Of negociosDetalleFacturaCliente))
        Me.txtTela.Text = ""
        Me.txtCantidad.Text = ""
        frmFacturar.productoSeleccionado = Nothing
        Dim ldtTabla As DataTable = New DataTable()
        ldtTabla.Columns.Add("Código")
        ldtTabla.Columns.Add("Tela")
        ldtTabla.Columns.Add("Cantidad")
        ldtTabla.Columns.Add("Precio")
        ldtTabla.Columns.Add("Monto")

        For i = 0 To lst.Count - 1 Step 1
            Dim ldrFila As DataRow = ldtTabla.NewRow()
            Dim objLocal As negociosDetalleFacturaCliente = lst(i)
            ldrFila(0) = objLocal.getCodigoProducto()
            ldrFila(1) = objLocal.getNombreProducto()
            ldrFila(2) = objLocal.getCantidad()
            ldrFila(3) = objLocal.getPrecio()
            ldrFila(4) = objLocal.getMonto()
            ldtTabla.Rows.Add(ldrFila)
        Next
        Me.dgvdetallefactura.DataSource = ldtTabla
    End Sub
End Class