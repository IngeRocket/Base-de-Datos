Public Class ADMINISTRADOR_DEL_VENDEDOR
    Dim conexion As funciones
    Dim tabla As DataTable
    Dim RFC As String
    Dim bandera As Boolean
    Private Sub ADMINISTRADOR_DEL_VENDEDOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones
        Vaciar()
    End Sub

    Private Sub BTN_CANCEL_Click(sender As Object, e As EventArgs) Handles BTN_CANCEL.Click
        Close()
    End Sub

    Private Sub BTN_DEL_Click(sender As Object, e As EventArgs) Handles BTN_DEL.Click

        If bandera Then

            If MessageBox.Show("Estas a punto de ELIMINAR un Vendedor, ¿Deseas Continuar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes Then
                conexion.VENDEDOR(LB_RFC.Text, "", "", "", "", "", "", 2)
                MsgBox("Solicitud Enviada")
                Vaciar()
                Close()

            Else
                Vaciar()
            End If

        Else
            MsgBox("No procede eliminacion pues no se encontro Vendedor")
        End If


    End Sub

    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click
        Vaciar()

        RFC = TXT_RFC.Text
        If RFC <> "" And RFC.Length() = 13 Then

            conexion.Consulta_vendedor_info(RFC, "", 1)
            '
            bandera = System.Configuration.ConfigurationManager.AppSettings.Get("BOOL_RFC")
            If bandera = False Then 'si es 0 si encontro el dato
                bandera = True
                Llenar()
            Else
                bandera = False     'si el resultado es true el dato no existe
            End If
            '
        End If
    End Sub

    Private Function Vaciar() As Boolean

        LB_NOMBRE.Text = ""
        LB_AP.Text = ""
        LB_AM.Text = ""
        LB_CURP.Text = ""
        LB_NOMINA.Text = ""
        LB_RFC.Text = ""
        RFC = ""

        Return True
    End Function

    Private Function Llenar() As Boolean

        LB_NOMBRE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_NOMBRE")
        LB_AP.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_AP")
        LB_AM.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_AM")
        LB_CURP.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_CURP")
        LB_NOMINA.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_NOMINA")
        LB_RFC.Text = System.Configuration.ConfigurationManager.AppSettings.Get("V_RFC")

        Return True
    End Function


End Class