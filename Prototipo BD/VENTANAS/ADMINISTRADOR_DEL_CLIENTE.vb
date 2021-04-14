Public Class ADMINISTRADOR_DEL_CLIENTE
    Dim RFC As String
    Dim Existe As Boolean
    Dim conexion As funciones
    Private Sub BTN_REGRESAR_Click(sender As Object, e As EventArgs) Handles BTN_REGRESAR.Click
        Close()
    End Sub

    Private Sub ADMINISTRADOR_DEL_CLIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vaciar()

        conexion = New funciones
    End Sub

    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click
        RFC = TXT_RFC.Text
        conexion.CLIENTE_INFO(RFC)
        Existe = System.Configuration.ConfigurationManager.AppSettings.Get("BOOL_RFC")

        If Existe Then
            MsgBox("Cliente localizado")

            llenar()
        Else
            MsgBox("El RFC escrito no concuerda con ningun Cliente registrado")
        End If

    End Sub

    Private Sub llenar()
        LB_NOMBRE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_Nombre")
        LB_AP.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_AP")
        LB_AM.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_AM")
        LB_DIR.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_DIR")
        LB_CP.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_CP")
        LB_TM.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_TEL")
        LB_FN.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_NACIM")
        LB_CORREO.Text = System.Configuration.ConfigurationManager.AppSettings.Get("C_EMAIL")

    End Sub

    Private Sub vaciar()
        System.Configuration.ConfigurationManager.AppSettings.Set("C_Nombre", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_AP", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_AM", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_DIR", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_CP", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_TEL", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_NACIM", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("C_EMAIL", "")

        LB_NOMBRE.Text = ""
        LB_AP.Text = ""
        LB_AM.Text = ""
        LB_DIR.Text = ""
        LB_CP.Text = ""
        LB_TM.Text = ""
        LB_FN.Text = ""
        LB_CORREO.Text = ""

        Existe = False

    End Sub

    Private Sub BTN_DEL_Click(sender As Object, e As EventArgs) Handles BTN_DEL.Click
        If Existe Then
            'borrar

            If MessageBox.Show("Estas a punto de ELIMINAR un Cliente, ¿Deseas Continuar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes Then
                conexion.Cliente("", RFC, "", "", "", "", 0, "", "", 2)
                MsgBox("Solicitud Enviada")
                vaciar()
                Close()

            Else
                vaciar()
            End If

        Else
            MsgBox("No se ha seleccionado un RFC de Cliente valido")
        End If
    End Sub
End Class