Imports System.Runtime.InteropServices.DllImportAttribute
Public Class frmRegistro
    Dim U As New Usuario
    Dim L As New Logica
    'Creacion de variable y importacion de DLL de windows para mover un panel sin borde

    Private Const WM_SYSCOMMAND As Integer = &H112&
    Private Const MOUSE_MOVE As Integer = &HF012&
    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ReleaseCapture")> _
    Private Shared Sub ReleaseCapture()
    End Sub

    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="SendMessage")> _
    Private Shared Sub SendMessage( _
            ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, _
            ByVal wParam As Integer, ByVal lParam As Integer _
            )
    End Sub
    Private Sub pnlRegistro_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles pnlRegistro.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
    End Sub
    Private Sub Panel4_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
    End Sub
   
    'Llamada a Formulario Login
    Private Sub linkLoguearme_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLoguearme.LinkClicked
        Dim F2 As New frmlogin
        frmlogin.Show()
        Me.Hide()

    End Sub
    'Creando efecto que al pasar el mause se elimine lo que esta escrito en cada TextBox del Formulario de Registro
  
    Private Sub btnRegistro_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistro.Click
        U.Cedula = txtCedulaRegistro.Text
        U.Nombre = txtNombreRegistro.Text
        U.Apellido = txtApellidoRegistro.Text
        U.nomUsuario = txtUsuarioRegistro.Text
        U.Contraseña = txtContraseñaRegistro.Text
        U.Telefono = txtTelefonoRegistro.Text
        U.Email = txtEmailRegistro.Text
        U.Direccion = txtDirecionRegistro.Text
        MsgBox(L.AgregarUsuario(U))
    End Sub


    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pnlRegistro_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlRegistro.Paint

    End Sub
End Class