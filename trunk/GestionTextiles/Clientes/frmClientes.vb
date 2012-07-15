Imports negocios
Imports System.Xml
Public Class frmClientes
    Dim lnpNuevoCliente As negociosCliente = New negociosCliente()

    Private glstClientes As List(Of negociosCliente) = New List(Of negociosCliente)
    Private glstClientesFiltrada As List(Of negociosCliente) = New List(Of negociosCliente)
    Public Shared gnpClienteSeleccionado As negociosCliente
    Private banderaBusqueda As Boolean = False
    Private Sub txtbusqueda_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnbuscar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub DataGridView1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btningresarcliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresarcliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnmodificarclientes_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarclientes.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btneliminarcliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarcliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtbusqueda_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseHover
        slblDescripcion.Text = "Ingrese  algun dato del cliente a buscar ej. Pedro Juarez"
    End Sub

    Private Sub btnbuscar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseHover
        slblDescripcion.Text = "Debe  precionar el boton 'buscar' para inciar la busqueda "
    End Sub

    Private Sub DataGridView1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Listado de clientes actuales"
    End Sub

    Private Sub btningresarcliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresarcliente.MouseHover
        slblDescripcion.Text = "Ingreso de nuevos clientes "
    End Sub

    Private Sub btnmodificarclientes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarclientes.MouseHover
        slblDescripcion.Text = "Modificación de  clientes"
    End Sub

    Private Sub btneliminarcliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarcliente.MouseHover
        slblDescripcion.Text = "Eliminacion de clientes"
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        slblDescripcion.Text = "Salir de la aplicación"
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If txtbusqueda.Text = "" Then
            MessageBox.Show("Ingrese la busqueda deseada ")
        Else
            ''verificar porque no se puede acceder
            dgvclientes.DataSource = lnpNuevoCliente.fnDbBuscarClienteNombre(txtbusqueda.Text)
        End If
    End Sub

    Private Sub btningresarcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresarcliente.Click
        frmingresoclientes.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
        frmPrincipal.Show()
    End Sub

    Private Sub btnmodificarclientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarclientes.Click
        If IsNothing(frmClientes.gnpClienteSeleccionado) Then
            MessageBox.Show("Debe seleccionar un cliente de la lista para poder modificar sus datos", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            frmModificarCliente.actualizar = True
            frmModificarCliente.ShowDialog(Me)
            Me.fnvdRecargar()
            txtbusqueda.Text = ""
        End If
    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        If txtbusqueda.Text = "" Then
            btnbuscar.Enabled = False
        Else
            btnbuscar.Enabled = True
        End If

    End Sub


    Private Sub btnActualizar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnActualizar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.MouseHover
        slblDescripcion.Text = "Actualiza el  listado de los Cliente en sistema"
    End Sub

    Private Sub cmbCliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbCliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.MouseHover
        slblDescripcion.Text = "Seleccióne el parametro por el que desea buscar"
    End Sub

    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lnegPermisos As negociosRol = frmPrincipal.gnegPermisos

        If lnegPermisos.getPermisoCreacionClientes() Then
            btningresarcliente.Enabled = True
        Else
            btningresarcliente.Enabled = False
        End If
        If lnegPermisos.getPermisoListarClientes() Then
            cmbCliente.Enabled = True
            txtbusqueda.Enabled = True
            btnbuscar.Enabled = True
            btnActualizar.Enabled = True
            dgvclientes.Enabled = True
        Else
            cmbCliente.Enabled = False
            txtbusqueda.Enabled = False
            btnbuscar.Enabled = False
            btnActualizar.Enabled = False
            dgvclientes.Enabled = False
        End If
        If lnegPermisos.getPermisoModificacionClientes() Then
            btnmodificarclientes.Enabled = True
            btneliminarcliente.Enabled = True
        Else
            btnmodificarclientes.Enabled = False
            btneliminarcliente.Enabled = True
        End If
       

        ''
        Try
            fnvdRecargar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgvclientes_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvclientes.CellClick
        If banderaBusqueda Then
            frmClientes.gnpClienteSeleccionado = glstClientesFiltrada(e.RowIndex)
        Else
            frmClientes.gnpClienteSeleccionado = glstClientes(e.RowIndex)
        End If
    End Sub
    Private Sub fnvdRecargar()
        Try
            dgvclientes.DataSource = ""
            frmClientes.gnpClienteSeleccionado = Nothing
            Me.glstClientesFiltrada.Clear()
            Me.banderaBusqueda = False
            Me.glstClientes = negociosCliente.fnsVeinteClientes()
            Me.fnvCrearDataTable(Me.glstClientes)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvclientes.DataSource = Nothing
        End Try
    End Sub
    Private Sub fnvCrearDataTable(ByRef lista As List(Of negociosCliente))
        Dim ldtTabla As DataTable = New DataTable()
        Dim ldrFila As DataRow
        Dim lnpClientes As negociosCliente
        ldtTabla.Columns.Add("Nit")
        ldtTabla.Columns.Add("Nombre")
        ldtTabla.Columns.Add("Direccion")

        For i = 0 To lista.Count - 1 Step 1
            ldrFila = ldtTabla.NewRow()
            lnpClientes = lista(i)
            ldrFila(0) = lnpClientes.getNitCliente()
            ldrFila(1) = lnpClientes.getNombreCliente()
            ldrFila(2) = lnpClientes.getDireccionCliente()
            ldtTabla.Rows.Add(ldrFila)
        Next
        Me.dgvclientes.DataSource = ldtTabla
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            fnvdRecargar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvclientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvclientes.CellContentClick
        If banderaBusqueda Then
            frmClientes.gnpClienteSeleccionado = glstClientesFiltrada(e.RowIndex)
        Else
            frmClientes.gnpClienteSeleccionado = glstClientes(e.RowIndex)
        End If
    End Sub
End Class