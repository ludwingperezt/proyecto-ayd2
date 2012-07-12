﻿Public Class frmModificarCliente

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

    Private Sub txtnombre_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.MouseHover
        slblDescripcion.Text = "Ingrese el nuevo nombre ej. Luis Manuel"
    End Sub

    Private Sub txtapellido_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Ingrese el nuevo apellido  ej. Estrada Hernandez"
    End Sub

    Private Sub txtdireccion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.MouseHover
        slblDescripcion.Text = "Ingrese la nueva dirección ej. 6ta calle E 4B-18 zona 9 Quetzaltenango,Guatemala"
    End Sub

    Private Sub txtnit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnit.MouseHover
        slblDescripcion.Text = "Ingrese el nuevo Nit ej. 12692646"
    End Sub

    Private Sub cmbtipocliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipocliente.MouseHover
        slblDescripcion.Text = "Seleccióne el tipo de cliente, puede gestionar los tipos de clientes dese 'Gestion tipo cliente'"
    End Sub

    Private Sub btntipocliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntipocliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btntipocliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntipocliente.MouseHover
        slblDescripcion.Text = "sección para gestionar los tipos de cliente, agregar, modificar y eliminar"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "salir de la aplicación, verifique si almaceno los datos"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Almacena las modificaciónes relizadas"
    End Sub

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


        Next
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        frmClientes.Show()
    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If (Not (e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then  'revisar para que solo sean  letras
            e.KeyChar = vbNullChar

        End If
    End Sub

    Private Sub txtapellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not (e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then  'revisar para que solo sean  letras
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
End Class