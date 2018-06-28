Public Class frmVista

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmVista_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class