Imports System.Runtime.InteropServices.DllImportAttribute
Public Class frmLogin

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    'Creacion de variable y importacion de DLL de windows para mover un panel sin borde
    Private Const WM_SYSCOMMAND As Integer = &H112&
    Private Const MOUSE_MOVE As Integer = &HF012&
    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ReleaseCapture")> _
    Private Shared Sub ReleaseCapture()
    End Sub
    '
    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="SendMessage")> _
    Private Shared Sub SendMessage( _
            ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, _
            ByVal wParam As Integer, ByVal lParam As Integer _
            )
    End Sub
    Private Sub Form1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
    End Sub

    Private Sub Panel1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
    End Sub
    'Cerrar ventana Loguin
    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub
    'Minimizar ventana Login
    Private Sub btnMinimizar_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    'Creando efecto en cada TextBox del Formulario de Login
    Private Sub txtUsuario_MouseEnter_1(sender As System.Object, e As System.EventArgs) Handles txtUsuario.MouseEnter
        If (txtUsuario.Text = "Usuario") Then
            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub txtUsuario_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtUsuario.MouseLeave
        If (txtUsuario.Text = "") Then
            txtUsuario.Text = "Usuario"
            txtUsuario.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtContraseña_MouseEnter(sender As System.Object, e As System.EventArgs) Handles txtContraseña.MouseEnter
        If (txtContraseña.Text = "Contraseña") Then
            txtContraseña.Text = ""
            txtContraseña.ForeColor = Color.LightGray
            txtContraseña.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtContraseña_Leave(sender As System.Object, e As System.EventArgs) Handles txtContraseña.Leave
        If (txtContraseña.Text = "") Then
            txtContraseña.Text = "Contraseña"
            txtContraseña.ForeColor = Color.DimGray
            txtContraseña.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub LinkRegisto_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkRegisto.LinkClicked
        Dim F1 As New frmRegistro
        frmRegistro.Show()
        Me.Hide()
    End Sub


    Private Sub btnAcceder_Click(sender As System.Object, e As System.EventArgs) Handles btnAcceder.Click

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
