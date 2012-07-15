Imports negocios
Public Class frmVentas
    Private lstFacturas As List(Of negociosFacturaCliente) = New List(Of negociosFacturaCliente)
    Private lstFacturasFiltradas As List(Of negociosFacturaCliente) = New List(Of negociosFacturaCliente)
    Public Shared nfcSeleccionado As negociosFacturaCliente
    Private numeroPagina As Integer = 1
    Private Sub tmrRefrescarBarra_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblFecha.Text = Date.Now
    End Sub

    Private Sub btnAnular_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Enter

    End Sub

    Private Sub btnAnular_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Leave

    End Sub


    Private Sub btnCotizar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Permite realizar una cotización de productos"
    End Sub

    Private Sub btnFacturar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Inicia una nueva factura"
    End Sub

    Private Sub btnAnular_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.MouseHover
        slblDescripcion.Text = "Anula una factura, utilizando la serie y su correlativo"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
        frmPrincipal.Show()
    End Sub

    Private Sub btnAnular_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnFacturar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCotizar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub frmVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resetLista()
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If IsNothing(frmVentas.nfcSeleccionado) = False Then
            frmAnular.ShowDialog(Me)
        Else
            MessageBox.Show("Debe seleccionar una factura o buscarla por serie y número para poder eliminarla", "No se seleccionó una factura", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
        resetLista()
    End Sub

    Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmFacturar.ShowDialog(Me)
    End Sub

    Private Sub btnCotizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnFacturar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click
        frmFacturar.ShowDialog(Me)
        resetLista()
    End Sub

    Private Sub fnvLlenarDataGridView(ByRef lst As List(Of negociosFacturaCliente))
        ''SERIE,NUMERO,FECHA,DESCUENTO,SUBTOTAL,TOTAL
        Me.dgvSeries.DataSource = Nothing
        Dim ldtTabla As DataTable = New DataTable()
        ldtTabla.Columns.Add("Serie")
        ldtTabla.Columns.Add("Número")
        ldtTabla.Columns.Add("Fecha de emisión")
        ldtTabla.Columns.Add("Descuento aplicado")
        ldtTabla.Columns.Add("Subtotal")
        ldtTabla.Columns.Add("Total")
        For i = 0 To lst.Count - 1 Step 1
            Dim ldrFila As DataRow = ldtTabla.NewRow()
            Dim fila As negociosFacturaCliente = lst(i)
            ldrFila(0) = fila.getSerie()
            ldrFila(1) = fila.getNumeroFactura()
            ldrFila(2) = fila.getFecha()
            ldrFila(3) = fila.getDescuento()
            ldrFila(4) = fila.getSubTotal()
            ldrFila(5) = fila.getTotal()
            ldtTabla.Rows.Add(ldrFila)
        Next
        Me.dgvSeries.DataSource = ldtTabla
    End Sub
    Private Sub cargarFacturas()
        Me.lstFacturas.Clear()
        Me.lstFacturasFiltradas.Clear()
        frmVentas.nfcSeleccionado = Nothing
        txtNumero.Text = ""
        txtSerie.Text = ""
        Try
            Me.lstFacturas = negociosFacturaCliente.fnlstListarFacturas(20, Me.numeroPagina)
            Me.fnvLlenarDataGridView(lstFacturas)
            If Me.lstFacturas.Count < 20 Then
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
            dgvSeries.DataSource = Nothing
        End Try

    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        resetLista()
    End Sub
    Private Sub resetLista()
        Me.numeroPagina = 1
        Me.lstFacturas.Clear()
        Me.lstFacturasFiltradas.Clear()
        frmVentas.nfcSeleccionado = Nothing
        txtNumero.Text = ""
        txtSerie.Text = ""
        Me.cargarFacturas()
    End Sub

    Private Sub procesarBusqueda(ByRef serie As String, ByRef numero As Integer)
        Me.lstFacturas.Clear()
        Me.lstFacturasFiltradas.Clear()
        frmVentas.nfcSeleccionado = Nothing
        txtNumero.Text = ""
        txtSerie.Text = ""
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False
        Try
            Me.lstFacturas = negociosFacturaCliente.fnlstBuscarFacturaSerieNumero(serie, numero)
            Me.fnvLlenarDataGridView(lstFacturas)
            'como regularmente esta busqueda va retornar un solo resultado, se selecciona el primero, de lo contrario se deja como null el objeto seleccionado
            If lstFacturas.Count > 0 Then
                frmVentas.nfcSeleccionado = lstFacturas(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtNumero.Text = "" And txtSerie.Text = "" Then
            Me.resetLista()
        ElseIf txtNumero.Text = "" Or txtSerie.Text = "" Then
            MessageBox.Show("No se puede hacer una búsqueda de facturas sin la serie y el número de factura", "Faltan parámetros de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            procesarBusqueda(txtSerie.Text, Convert.ToInt32(txtNumero.Text))
            txtNumero.Text = ""
            txtSerie.Text = ""
        End If
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If Me.numeroPagina > 1 Then
            Me.numeroPagina = Me.numeroPagina - 1
            Me.cargarFacturas()
        End If
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        Me.numeroPagina = Me.numeroPagina + 1
        Me.cargarFacturas()
    End Sub

    Private Sub dgvSeries_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSeries.CellClick
        frmVentas.nfcSeleccionado = Me.lstFacturas(e.RowIndex)
    End Sub
End Class
