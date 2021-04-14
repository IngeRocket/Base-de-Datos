Public Class ADMINISTRADOR_SET_VENDEDOR

    Dim rfc As Boolean
    Dim conexion As funciones

    Dim V_RFC As String
    Dim V_Nomina As String
    Dim V_nombre As String
    Dim V_AP As String
    Dim V_AM As String
    Dim V_Curp As String
    Dim V_Contra As String

    Private Sub BTN_VOLVER_Click(sender As Object, e As EventArgs) Handles BTN_VOLVER.Click
        Close()
    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        Dim claves As Boolean = False
        Dim nombre As Boolean = False
        Dim AP_P As Boolean = False
        Dim AP_M As Boolean = False
        Dim Curp As Boolean = False

        If TXT_NOMBRE.Text <> "" Then
            V_nombre = TXT_NOMBRE.Text
            nombre = True
        Else
            MsgBox("El campo Nombre se encuentra Vacio")

        End If

        If TXT_AP.Text <> "" Then
            AP_P = True
            V_AP = TXT_AP.Text
        Else
            MsgBox("El campo Apellido Paterno se encuentra Vacio")

        End If

        If TXT_AM.Text <> "" Then
            AP_M = True
            V_AM = TXT_AM.Text
        Else
            MsgBox("El campo Apellido Materno se encuentra Vacio")

        End If

        If TXT_CURP.Text <> "" Then
            Curp = True
            V_Curp = TXT_CURP.Text
        Else
            MsgBox("El campo CURP se encuentra Vacio")

        End If

        If TXT_C1.Text = TXT_C2.Text And ((TXT_C1.Text <> "") And (TXT_C2.Text <> "")) Then
            claves = True
            V_Contra = TXT_C1.Text
        Else
            MsgBox("Claves no coinciden o se encuentran vacias")
        End If

        If nombre And AP_P And AP_M And Curp And claves Then

            conexion.VENDEDOR(LB_RFC.Text, TXT_NOMBRE.Text, TXT_AP.Text, TXT_AM.Text, TXT_C1.Text, TXT_CURP.Text, LB_NOMINA.Text, 3)
            MsgBox("Solicitud Enviada")
            Vaciado()
            Close()

        End If

    End Sub

    Private Sub ADMINISTRADOR_SET_VENDEDOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones
        Vaciado()

    End Sub

    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click
        Vaciado()
        V_RFC = TXT_RFC.Text

        conexion.Consulta_vendedor_info(V_RFC, "", 1)
        rfc = System.Configuration.ConfigurationManager.AppSettings.Get("BOOL_RFC")
        If rfc = False Then 'si es 0 si encontro el dato
            rfc = True
            Llenar()
        Else
            rfc = False     'si el resultado es true el dato no existe
        End If

    End Sub


    Private Function Vaciado() As Boolean

        System.Configuration.ConfigurationManager.AppSettings.Set("V_RFC", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("V_NOMBRE", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("V_AP", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("V_AM", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("V_CURP", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("V_PASS", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("V_PASS", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("V_NOMINA", "")

        TXT_NOMBRE.Text = ""
        TXT_AP.Text = ""
        TXT_AM.Text = ""
        TXT_CURP.Text = ""
        TXT_C1.Text = ""
        TXT_C2.Text = ""
        LB_NOMINA.Text = ""
        LB_RFC.Text = ""


        Return True
    End Function
    Private Function Llenar() As Boolean

        TXT_NOMBRE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_NOMBRE")
        TXT_AP.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_AP")
        TXT_AM.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_AM")
        TXT_CURP.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_CURP")
        TXT_C1.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_PASS")
        TXT_C2.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_PASS")
        LB_NOMINA.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_NOMINA")
        LB_RFC.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_RFC")


        Return True

    End Function
End Class