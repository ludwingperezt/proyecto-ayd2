﻿Public Class frmEliminarFactura

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
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
End Class