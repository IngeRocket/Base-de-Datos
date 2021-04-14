Public Class ADMINISTRADOR_SET_CLIENTE
    Dim conexion As funciones
    Dim valida As Boolean
    Dim rfc As String
    Private Sub BTN_NO_Click(sender As Object, e As EventArgs) Handles BTN_NO.Click
        vaciar()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rfc = TXT_RFC.Text
        conexion.CLIENTE_INFO(rfc)
        valida = System.Configuration.ConfigurationManager.AppSettings.Get("BOOL_RFC")
        If valida Then
            MsgBox("Cliente Localizado")
            llenar()

        Else
            MsgBox("El RFC escrito no corresponde a ningun cliente que este registrado")
            vaciar()
        End If
    End Sub

    Private Sub ADMINISTRADOR_SET_CLIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones
        TXT_RFC.Text = ""
        vaciar()
    End Sub


    Private Sub llenar()
        TXT_NOMBRE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_Nombre")
        TXT_AP.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_AP")
        TXT_AM.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_AM")
        TXT_DIR.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_DIR")
        TXT_CP.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_CP")
        TXT_TM.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_TEL")
        TXT_EMAIL.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_EMAIL")
        LB_NACIM.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_NACIM")
    End Sub

    Private Sub vaciar()
        System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_RFC", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_Nombre", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_DIR", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_CP", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_AP", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_AM", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_TEL", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_EMAIL", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_NACIM", "")

        TXT_NOMBRE.Text = ""
        TXT_AP.Text = ""
        TXT_AM.Text = ""
        TXT_DIR.Text = ""
        TXT_CP.Text = ""
        TXT_TM.Text = ""
        TXT_EMAIL.Text = "@"
        LB_NACIM.Text = ""

    End Sub

    Private Sub BTN_OK_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        If valida Then
            Dim nombre As String = TXT_NOMBRE.Text
            Dim ap As String = TXT_AP.Text
            Dim am As String = TXT_AM.Text
            Dim dir As String = TXT_DIR.Text
            Dim cp As Integer = Integer.Parse(TXT_CP.Text)
            Dim correo As String = TXT_EMAIL.Text
            Dim telefono As String = TXT_TM.Text
            '3 update
            conexion.Cliente("", rfc, nombre, ap, am, dir, cp, correo, telefono, 3)
            MsgBox("Solicitud enviada al Sistema")
            vaciar()
            Close()
        Else
            MsgBox("No ha realizado con exito la busqueda por RFC de Cliente")
            vaciar()
        End If
    End Sub
End Class