Public Class ADMINISTRADOR_SET_PORCENTAJE
    Dim conexion As funciones

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iva As Integer = Integer.Parse(TextBox1.Text)
        Dim comision As Integer = Integer.Parse(TextBox2.Text)

        If iva > 0 And comision > 0 Then
            conexion.UPDATE_COMISIONES(iva, comision)
            System.Configuration.ConfigurationManager.AppSettings.Set("IVA", iva)
            System.Configuration.ConfigurationManager.AppSettings.Set("COMISION", comision)
            MsgBox("Solicutud enviada al sistema")
            Close()
        Else
            MsgBox("Los valores deben de ser mayores a 0")
        End If

    End Sub

    Private Sub ADMINISTRADOR_SET_PORCENTAJE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = System.Configuration.ConfigurationManager.AppSettings.Get("IVA")
        TextBox2.Text = System.Configuration.ConfigurationManager.AppSettings.Get("COMISION")
        conexion = New funciones
    End Sub
End Class