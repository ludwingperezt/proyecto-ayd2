Imports negocios
Public Class frmLogin
    Public Shared lnpNuevoUsuario As negociosEmpleado = New negociosEmpleado
    Private glstEmpleados As List(Of negociosEmpleado) = New List(Of negociosEmpleado)

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Salir de la ventana del  ingreso al sistema"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Ingresar al sistema "
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        For Each ctrlIterador As Control In Me.Controls
            If TypeOf (ctrlIterador) Is Windows.Forms.TextBox Then
                If (ctrlIterador.Text = "") Then
                    ctrlIterador.BackColor = Color.Yellow
                Else
                    ctrlIterador.BackColor = Color.White
                    ''buscar al usuario
                    'dgvUsuario.DataSource = lnpNuevoUsuario.fnDbBuscarPorNombre(txtUsuario.Text)
                    Dim cantRegistros As Integer = dgvUsuario.Rows.Count
                    If (cantRegistros > 1) Then
                        lnpNuevoUsuario.setIdRolEmpleado(Convert.ToByte(dgvUsuario.CurrentRow.Cells(1).Value))
                        lnpNuevoUsuario.setNombreEmpleado(Convert.ToString(dgvUsuario.CurrentRow.Cells(2).Value))
                        lnpNuevoUsuario.setApellidoEmpleado(Convert.ToString(dgvUsuario.CurrentRow.Cells.Item(3).Value))
                        lnpNuevoUsuario.setDireccionEmpleado(Convert.ToString(dgvUsuario.CurrentRow.Cells.Item(4).Value))
                        lnpNuevoUsuario.setTelefonoEmpleado(Convert.ToString(dgvUsuario.CurrentRow.Cells.Item(5).Value))
                        lnpNuevoUsuario.setCelularEmpleado(Convert.ToString(dgvUsuario.CurrentRow.Cells.Item(6).Value))
                        lnpNuevoUsuario.setPuestoEmpleado(Convert.ToString(dgvUsuario.CurrentRow.Cells.Item(7).Value))
                        Dim sContrasenia As String
                        sContrasenia = getString(dgvUsuario.CurrentRow.Cells.Item(11).Value)
                        If (txtcontraseña.Text = sContrasenia) Then
                        Else
                            MessageBox.Show("Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        '   txtUsuario.Text = ""
                        MessageBox.Show("El usuario no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    'verificar() ''login ludwing
                    End If
            End If
        Next
    End Sub
    Private Sub txtUsuario_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtcontraseña_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontraseña.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtUsuario_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.MouseHover
        slblDescripcion.Text = "Ingreso del nombre de usuario para tener acceso al sistema"
    End Sub

    Private Sub txtcontraseña_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontraseña.MouseHover
        slblDescripcion.Text = "Ingreso de la contraseña del usuario"
    End Sub
    Public Function getString(ByVal text As Byte()) As [String]
        Dim codificador As New System.Text.ASCIIEncoding()
        Return codificador.GetString(text)
    End Function
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub verificar()
        Try
            Dim acceso As String = auxiliar.getLogin(txtUsuario.Text, txtcontraseña.Text)
            If acceso = 0 Then
                frmPrincipal.gnegEmpleado = Nothing
                frmPrincipal.gnegPermisos = Nothing
                MessageBox.Show("La contraseña o usuario ingresados no son correctos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf acceso = 1 Then
                frmPrincipal.gnegEmpleado = auxiliar.getEmpleado(txtUsuario.Text, txtcontraseña.Text)
                If IsNothing(frmPrincipal.gnegEmpleado) = False Then
                    frmPrincipal.gnegPermisos = negociosRol.fnObtenerRolPorId(Convert.ToInt32(frmPrincipal.gnegEmpleado.getIdRolEmpleado()))
                    Me.Dispose()
                End If
            ElseIf acceso = 2 Then
                frmPrincipal.gnegEmpleado = Nothing
                frmPrincipal.gnegPermisos = Nothing
                MessageBox.Show("El usuario no tiene acceso al sistema", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class