Public Class frmRoles

    Private Sub btnNCompra_Click(sender As System.Object, e As System.EventArgs) Handles btnNPermiso.Click
        frmModificarPermiso.ShowDialog()

    End Sub

    Private Sub btnNPermiso_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnNPermiso.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAsignarPermiso_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnAsignarPermiso.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnNPermiso_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnNPermiso.MouseHover
        slblDescripcion.Text = "Nueva configuración de permisos"
    End Sub

    Private Sub btnAsignarPermiso_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnAsignarPermiso.MouseHover
        slblDescripcion.Text = "Asignar permisos a un usuario"
    End Sub
End Class