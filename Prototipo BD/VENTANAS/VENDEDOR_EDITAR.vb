Public Class VENDEDOR_EDITAR
    Dim valida As Boolean
    Dim C1 As String
    Dim C2 As String
    Private Sub BTN_ATRAS_Click(sender As Object, e As EventArgs) Handles BTN_ATRAS.Click
        Close()
    End Sub

    Private Sub BTN_ADD_Click(sender As Object, e As EventArgs) Handles BTN_ADD.Click
        If valida Then
            MsgBox("Solicitud enviada", 64)
            Close()

        Else
            MsgBox("Valide correctamente las claves", 64)
        End If
    End Sub

    Private Sub BTN_VALIDA_Click(sender As Object, e As EventArgs) Handles BTN_VALIDA.Click
        C1 = TXT_C1.Text
        C2 = TXT_C2.Text
        If C1 = C2 And C1 <> "" And C2 <> "" Then
            valida = True
            MsgBox("Clave de sesion coinciden", 64)
        Else
            MsgBox("Las claves de sesion no coinciden", 64)
            valida = False
        End If
    End Sub

    Private Sub VENDEDOR_EDITAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        valida = False
        LB_NOMBRE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("NombreUsuario")
        LB_RFC.Text = System.Configuration.ConfigurationManager.AppSettings.Get("RFC_V")
        LB_NOMINA.Text = System.Configuration.ConfigurationManager.AppSettings.Get("NOMINA_V")
        LB_CURP.Text = System.Configuration.ConfigurationManager.AppSettings.Get("CURP_V")
    End Sub
End Class