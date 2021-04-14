Imports System.Data.SqlClient
Public Class PRINCIPAL
    Private Sub PRINCIPAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RB_V.Checked = True
        For index = 1 To 9
            ComboBox1.Items.Add(index)
        Next
        ComboBox1.SelectedIndex() = 0
        System.Configuration.ConfigurationManager.AppSettings.Set("Caja", 1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTN_REG.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Funcion As funciones = New funciones

        Dim User As String
        Dim Pass As String
        Dim Caja As Integer

        Dim nombre As String

        User = TextBox1.Text
        Pass = TextBox2.Text
        Caja = ComboBox1.SelectedIndex + 1

        System.Configuration.ConfigurationManager.AppSettings.Set("Caja", Caja)

        If (RB_V.Checked) Then
            Funcion.Login(User, Pass, 1)
            nombre = System.Configuration.ConfigurationManager.AppSettings.Get("NombreUsuario")
            If nombre <> "" Then
                MsgBox("Usuario: " + nombre + " Caja a usar: " + Caja.ToString, 64)
                Dim ventana As VENDEDOR
                ventana = New VENDEDOR
                Hide()
                ventana.ShowDialog()
                Show()
                'AQUI SE PUEDE PONER NUEVA VENTANA

            End If

        Else
            Funcion.Login(User, Pass, 0)
            nombre = System.Configuration.ConfigurationManager.AppSettings.Get("NombreUsuario")
            If nombre <> "" Then
                MsgBox("Administrador: " + nombre, 64)

                Dim ventana As ADMINISTRADOR
                ventana = New ADMINISTRADOR
                Hide()
                ventana.ShowDialog()
                Show()
                'AQUI SE PUEDE PONER NUEVA VENTANA

            End If

        End If

    End Sub
End Class
