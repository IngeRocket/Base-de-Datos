Public Class AGREGAR_CLIENTE
    Dim RFC As String
    Dim Valida As Boolean
    Dim conexion As funciones

    Dim nombre As Boolean
    Dim ap As Boolean
    Dim am As Boolean
    Dim correo As Boolean
    Dim direccion As Boolean
    Dim telefono As Boolean
    Dim cp As Boolean

    Private Sub AGREGAR_CLIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RFC = ""
        TXT_RFC.Text = ""
        TXT_NOMBRE.Text = ""
        TXT_AP.Text = ""
        TXT_AM.Text = ""
        TXT_DIR.Text = ""
        TXT_CP.Text = ""
        TXT_TM.Text = ""
        TXT_EMAIL.Text = "@"

        Valida = False
        conexion = New funciones
    End Sub

    Private Sub BTN_OK_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        If TXT_NOMBRE.Text = "" Then
            MsgBox("Campo NOMBRE se encuentra vacio")
            nombre = False
        Else
            nombre = True
        End If

        If TXT_AP.Text = "" Then
            MsgBox("Campo APELLIDO PATERNO se encuentra vacio")
            ap = False
        Else
            ap = True
        End If

        If TXT_AM.Text = "" Then
            MsgBox("Campo APELLIDO MATERNO se encuentra vacio")
            am = False
        Else
            am = True
        End If

        If TXT_DIR.Text = "" Then
            MsgBox("Campo DIRECCION se encuentra vacio")
            direccion = False
        Else
            direccion = True
        End If

        If TXT_CP.Text = "" Then
            MsgBox("Campo CODIGO POSTAL se encuentra vacio")
            cp = False
        Else
            cp = True
        End If

        If TXT_TM.Text = "" Then
            MsgBox("Campo TELEFONO se encuentra vacio")
            telefono = False
        Else
            telefono = True
        End If

        If TXT_EMAIL.Text = "" Then
            MsgBox("Campo CURP se encuentra vacio")
            correo = False
        Else
            correo = True
        End If

        If nombre And ap And am And direccion And cp And telefono And correo Then
            If Valida Then
                'crear cliente
                'conexion.cliente
                Dim RFC_V As String = System.Configuration.ConfigurationManager.AppSettings.Get("RFC_V")
                Dim C_nombre As String = TXT_NOMBRE.Text
                Dim C_AP As String = TXT_AP.Text
                Dim C_AM As String = TXT_AM.Text
                Dim C_Domi As String = TXT_DIR.Text
                Dim C_CP As Integer = Integer.Parse(TXT_CP.Text)
                Dim C_Correo As String = TXT_EMAIL.Text
                Dim C_tel As String = TXT_TM.Text

                conexion.Cliente(RFC_V, RFC, C_nombre, C_AP, C_AM, C_Domi, C_CP, C_Correo, C_tel, 1)
                MsgBox("Solicitud Enviada al Sistema")
                Close()


            Else
                MsgBox("No ha VALIDADO la disponibilidad del RFC")
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RFC = TXT_RFC.Text
        conexion.Cliente_RFC(RFC, 1)
        Valida = System.Configuration.ConfigurationManager.AppSettings.Get("BOOL_RFC")
        'verificar si existe, si respuesta es true valor ya esta asignado a un cliente
        If Valida Then
            Valida = False
            MsgBox("El RFC escrito YA se encuentra registrado en otro cliente")
        Else
            MsgBox("RFC DISPONIBLE")
            Valida = True
        End If
    End Sub

    Private Sub BTN_NO_Click(sender As Object, e As EventArgs) Handles BTN_NO.Click
        Vaciar()

        Close()

    End Sub

    Private Sub Vaciar()
        RFC = ""
        TXT_RFC.Text = ""
        TXT_NOMBRE.Text = ""
        TXT_AP.Text = ""
        TXT_AM.Text = ""
        TXT_DIR.Text = ""
        TXT_CP.Text = ""
        TXT_TM.Text = ""
        TXT_EMAIL.Text = "@"

        Valida = False

    End Sub

End Class