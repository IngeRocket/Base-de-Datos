Public Class AGREGAR_VENDEDOR


    Dim nomina As Boolean
    Dim rfc As Boolean
    Dim conexion As funciones

    'variables de campos
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

    Private Sub BTN_VALIDA_RFC_Click(sender As Object, e As EventArgs) Handles BTN_VALIDA_RFC.Click
        V_RFC = TXT_RFC_V.Text
        conexion.Consulta_vendedor_info(V_RFC, "", 4)
        rfc = System.Configuration.ConfigurationManager.AppSettings.Get("BOOL_RFC")
    End Sub

    Private Sub AGREGAR_VENDEDOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nomina = False
        rfc = False
        conexion = New funciones
        TXT_NOMBRE.Text = ""
        TXT_AP.Text = ""
        TXT_AM.Text = ""
        TXT_CURP.Text = ""
        TXT_RFC_V.Text = ""
        TXT_C1.Text = ""
        TXT_C2.Text = ""
        TXT_NOMINA.Text = ""

    End Sub

    Private Sub BTN_VALIDA_NOMINA_Click(sender As Object, e As EventArgs) Handles BTN_VALIDA_NOMINA.Click
        V_Nomina = TXT_NOMINA.Text
        conexion.Consulta_vendedor_info("", V_Nomina, 5)
        nomina = System.Configuration.ConfigurationManager.AppSettings.Get("BOOL_N")
    End Sub

    Private Sub BTN_ADD_Click(sender As Object, e As EventArgs) Handles BTN_ADD.Click
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
            nombre = False
        End If

        If TXT_AP.Text <> "" Then
            AP_P = True
            V_AP = TXT_AP.Text
        Else
            MsgBox("El campo Apellido Paterno se encuentra Vacio")
            AP_P = False
        End If

        If TXT_AM.Text <> "" Then
            AP_M = True
            V_AM = TXT_AM.Text
        Else
            MsgBox("El campo Apellido Materno se encuentra Vacio")
            AP_M = False
        End If

        If TXT_CURP.Text <> "" Then
            Curp = True
            V_Curp = TXT_CURP.Text
        Else
            MsgBox("El campo CURP se encuentra Vacio")
            Curp = False
        End If

        If TXT_C1.Text = TXT_C2.Text And ((TXT_C1.Text <> "") And (TXT_C2.Text <> "")) Then
            claves = True
            V_Contra = TXT_C1.Text
        Else
            MsgBox("Claves no coinciden o se encuentran vacias")
            claves = False
        End If

        If nomina Then
            'siguiente
            If rfc Then
                'siguiente
                If claves And nombre And AP_P And AP_M And Curp Then

                    conexion.VENDEDOR(V_RFC, V_nombre, V_AP, V_AM, V_Contra, V_Curp, V_Nomina, 1)
                    MsgBox("Solicitud enviada")
                    Close()

                End If
            Else
                MsgBox("No ha validado disponibilidad de RFC")

            End If
        Else
            MsgBox("No ha Validado disponibilidad de Nomina")
        End If
    End Sub
End Class