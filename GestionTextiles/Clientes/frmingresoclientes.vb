Imports negocios
Public Class frmingresoclientes

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
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
            'ingreso nuevo cliente
            Dim lnpNuevoCliente As negociosCliente = New negociosCliente()
            lnpNuevoCliente.setNombreCliente(txtnombre.Text)
            lnpNuevoCliente.setNitCliente(txtnit.Text)
            lnpNuevoCliente.setDireccionCliente(txtdireccion.Text)
            Try
                lnpNuevoCliente.fnsInsertarCliente()
                MessageBox.Show("La operación de insersión de cliente se llevó a cabo con éxito", "Insersión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next
    End Sub

    Private Sub txtnombre_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtapellido_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtdireccion_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtnit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnit.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbtipocliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipocliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnnuevotipocliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntipocliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtnombre_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.MouseHover
        slblDescripcion.Text = "Se debe ingresar el nombre del cliente ej. Juan Mariano "
    End Sub

    Private Sub txtapellido_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Se debe ingresar el apellido del cliente ej. Dominguez Estrada"
    End Sub

    Private Sub txtdireccion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.MouseHover
        slblDescripcion.Text = "Se debe ingresar la dirección del cliente ej. 6ta calle E 4B-18 zona 9 Quetzaltenango,Guatemala"
    End Sub

    Private Sub txtnit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnit.MouseHover
        slblDescripcion.Text = "Se debe ingresar el nit del cliente ej. 12692658"
    End Sub

    Private Sub cmbtipocliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipocliente.MouseHover
        slblDescripcion.Text = "Se debe selecciónar el tipo de cliente, si no esta el que desea  puede agregarlo seleccionando el boton ' gestion tipo de cliente'"
    End Sub

    Private Sub btnnuevotipocliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntipocliente.MouseHover
        slblDescripcion.Text = "Ingrese  para agregar un nuevo tipo de cliente "
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Sale de la aplicación verifique si guardo los cambios"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Agrega el nuevo cliente "
    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If (Not (e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then  'revisar para que solo sean  letras
            e.KeyChar = vbNullChar

        End If
    End Sub

    Private Sub txtapellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not (e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then  'revisar para que solo lleve letras
            e.KeyChar = vbNullChar

        End If
    End Sub

    Private Sub txtdireccion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdireccion.KeyPress
        If (Not (e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar = vbBack Or e.KeyChar = " " Or e.KeyChar = "-" Or e.KeyChar = ".")) Then  'revisar si lleva numeros en los nombres de las telas
            e.KeyChar = vbNullChar
        End If
        If e.KeyChar = "." Then 'se revisa que no  se repita el caracter punto
            If txtdireccion.Text.Contains(".") Then
                e.KeyChar = ""
            End If
        End If
        If e.KeyChar = "-" Then ' se revisa que no se repita el caracter guion
            If txtdireccion.Text.Contains("-") Then
                e.KeyChar = ""
            End If
        End If
    End Sub

    Private Sub txtnit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnit.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then
            e.KeyChar = vbNullChar

        End If
    End Sub

    Private Sub btntipocliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntipocliente.Click
        frmtipocliente.Show()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        frmClientes.Show()
    End Sub

    Private Sub lbltipocliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltipocliente.Click

    End Sub
End Class