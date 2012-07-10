Imports System.Xml
Public Class frmtipocliente

    Private Sub txtbusqueda_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtbusqueda_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseHover
        slblDescripcion.Text = "Ingrese una descripción para buscar el tipo de cliente ej. 'especial'"
    End Sub

    Private Sub dgvtiposcliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvtiposcliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvtiposcliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvtiposcliente.MouseHover
        slblDescripcion.Text = "Listado de los tipos de cliente existentes "
    End Sub

    Private Sub btnbuscar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnbuscar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseHover
        slblDescripcion.Text = "Realiza la busqueda dentro de los tipos de cliente existentes"
    End Sub

    Private Sub btningresar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnmodificartipocliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificartipocliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btneliminartipocliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminartipocliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    
    Private Sub btnsalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btningresar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.MouseHover
        slblDescripcion.Text = "Ingresa un nuevo tipo de cliente"
    End Sub

    Private Sub btnmodificartipocliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificartipocliente.MouseHover
        slblDescripcion.Text = "Modifica un tipo de cliente existente"
    End Sub

    Private Sub btneliminartipocliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminartipocliente.MouseHover
        slblDescripcion.Text = "Elimnina un tipo de cliente existente"
    End Sub

    Private Sub btnsalir_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.MouseHover
        slblDescripcion.Text = "Salir de la aplicación"
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If txtbusqueda.Text = "" Then
            MessageBox.Show("Ingrese una descripción para realizar la busqueda")
        Else
            ' codigo para realizar la busqueda
        End If
    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        frmingresotipocliente.Show()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Dispose()
        frmingresoclientes.Show()
    End Sub

    Private Sub btnmodificartipocliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificartipocliente.Click
        frmModificarTipoCliente.Show()
    End Sub
End Class