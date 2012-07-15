Imports negocios
Public Class frmEliminarFactura
    Private factura As negociosFacturaCliente
    Private cliente As negociosCliente
    Private empleadoEmisor As negociosEmpleado
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
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

    Private Sub txtTotal_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Total a pagar"
    End Sub

    Private Sub txtDescuento_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descuento total"
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cancelar facturación"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Inicia impresión de factura"
    End Sub

    Private Sub lblnumerofac_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub lbltotal_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub lbldescuentofac_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub lbldescuentofac_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descuento factura"
    End Sub

    Private Sub lbltotal_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Total a pagar"
    End Sub

    Private Sub lblnumerofac_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Numero de factura"
    End Sub

    Private Sub frmEliminarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("La modificación de datos en esta parte del programa puede dañar la integridad de la base de datos", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Try
            Me.factura = frmVentas.nfcSeleccionado
            Me.factura.fnvCargarListaDetalles()
            Me.cliente = negociosCliente.fnncObtenerClienteYTipo(Me.factura.getIdCliente())
            Me.empleadoEmisor = negociosEmpleado.fnneObtenerNombreApellidoEmpleadoPorId(Me.factura.getIdEmpleado())

            txtSerie.Text = factura.getSerie()
            txtNumero.Text = Convert.ToString(factura.getNumeroFactura())
            txtnit.Text = cliente.getNitCliente()
            txtnombre.Text = cliente.getNombreCliente()
            txtdireccion.Text = cliente.getDireccionCliente()
            txtTipoCliente.Text = cliente.getTipoCliente().getNombreTipoCliente()
            txtEmpleado.Text = empleadoEmisor.getNombreEmpleado() + " " + empleadoEmisor.getApellidoEmpleado()
            txtFecha.Text = Convert.ToString(factura.getFecha())
            txtDescuento.Text = Convert.ToString(factura.getDescuento())
            txtSubTotal.Text = Convert.ToString(factura.getSubTotal())
            txtTotal.Text = Convert.ToString(factura.getTotal())

            Dim lst As List(Of negociosDetalleFacturaCliente) = factura.getDetalleFactura()
            Me.dgvdetallefactura.DataSource = Nothing
            Dim ldtTabla As DataTable = New DataTable()
            ldtTabla.Columns.Add("Código")
            ldtTabla.Columns.Add("Nombre")
            ldtTabla.Columns.Add("Precio unitario")
            ldtTabla.Columns.Add("Cantidad")
            ldtTabla.Columns.Add("Monto")
            For i = 0 To lst.Count - 1 Step 1
                Dim ldrFila As DataRow = ldtTabla.NewRow()
                Dim fila As negociosDetalleFacturaCliente = lst(i)
                Dim producto As negociosProducto = negociosProducto.fnObtenerProductoPorId(fila.getIdProducto())
                ldrFila(0) = producto.getCodigo()
                ldrFila(1) = producto.getNombre()
                ldrFila(2) = fila.getPrecio()
                ldrFila(3) = fila.getCantidad()
                ldrFila(4) = fila.getMonto()
                ldtTabla.Rows.Add(ldrFila)
            Next
            Me.dgvdetallefactura.DataSource = ldtTabla
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If MessageBox.Show("¿Está seguro de querer eliminar la presente factura de la base de datos? Esta operación no se puede deshacer", "Precaución", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim nota As String = InputBox("Razón de la eliminación:", "Razón", "Error en la factura")
                If nota <> "" Then
                    factura.fnvEliminarFacturaDeBaseDatos(frmPrincipal.gnegEmpleado.getIdEmpleado(), nota)
                    'factura.fnvEliminarFacturaDeBaseDatos(4, nota)
                    MessageBox.Show("La factura se eliminó correctamente", "Eliminación de factura", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class