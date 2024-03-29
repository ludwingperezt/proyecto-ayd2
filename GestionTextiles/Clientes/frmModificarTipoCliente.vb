﻿Imports negocios
Public Class frmModificarTipoCliente
    Private bandera As Boolean
    Friend Shared actualizar As Boolean
    Private Sub txtnombre_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtdescripcion_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtdescuento_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescuento.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtnombre_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.MouseHover
        slblDescripcion.Text = "Ingrese el nuevo nombre ej. supremo"
    End Sub

    Private Sub txtdescripcion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.MouseHover
        slblDescripcion.Text = "Ingrese la nueva descripción del tipo de cliente"
    End Sub

    Private Sub txtdescuento_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescuento.MouseHover
        slblDescripcion.Text = "Ingrese el nuevo porcentaje de descuento ej. 20"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"

    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Sale de la aplicación , verifique si almaceno los cambios"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Almacena los cambios realizados al tipo de cliente"
    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If (Not (e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then  'revisar para que solo lleve letras
            e.KeyChar = vbNullChar

        End If
    End Sub

    Private Sub txtdescuento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescuento.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then
            e.KeyChar = vbNullChar

        End If
        'If Convert.ToDouble(txtdescuento.Text) <= 100 Then
        'e.KeyChar = vbNullChar
        'MessageBox.Show("Descuento exedido  del 100% ")
        'End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        frmtipocliente.Show()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        bandera = True
        For Each ctrlIterador As Control In Me.Controls
            If TypeOf (ctrlIterador) Is Windows.Forms.TextBox Then
                If (ctrlIterador.Text = "") Then
                    ctrlIterador.BackColor = Color.Yellow
                    bandera = False
                Else
                    ctrlIterador.BackColor = Color.White
                End If
            End If
        Next
        If bandera <> False Then
            'codigo para modificar el tipo cliente
            Dim lnpNuevoTipoCliente As negociosTipoCliente = New negociosTipoCliente()
            lnpNuevoTipoCliente.setIdTipoCliente(frmtipocliente.gnpTipoClienteSeleccionado.getIdTipoCliente())
            lnpNuevoTipoCliente.setNombreTipoCliente(txtnombre.Text)
            lnpNuevoTipoCliente.setDescripcionTipoCliente(txtdescripcion.Text)
            lnpNuevoTipoCliente.setDescuentoTipoCliente(Convert.ToSingle(txtdescuento.Text))
            Try
                lnpNuevoTipoCliente.fnsModificarTipoCliente()
                MessageBox.Show("La modificacion de tipo de cliente se llevó a cabo con éxito", "Insersión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmingresoclientes.fnvdRecargar()
                frmtipocliente.fnvdRecargar()
                Me.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub frmModificarTipoCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If actualizar = True Then
            Me.txtnombre.Text = frmtipocliente.gnpTipoClienteSeleccionado.getNombreTipoCliente()
            Me.txtdescripcion.Text = frmtipocliente.gnpTipoClienteSeleccionado.getDescripcionTipoCliente()
            Me.txtdescuento.Text = frmtipocliente.gnpTipoClienteSeleccionado.getDescuentoTipoCliente()
        End If
    End Sub

    Private Sub txtdescuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescuento.TextChanged

    End Sub
End Class