Public Class VENDEDOR_COMISION
    Dim conexion As funciones


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub VENDEDOR_COMISION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones

        DTP_ORIGEN.Value = DateTime.Now.ToString("dd/MM/yyyy")
        DTP_FIN.Value = DateTime.Now.ToString("dd/MM/yyyy")
        LBL_VENTAS.Text = "0"
        LBL_CREDITO.Text = "0"
        LB_NOMBRE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("NombreUsuario")

        CMB_CAJA.Items.Add("TODAS LAS CAJAS")
        For index = 1 To 9
            CMB_CAJA.Items.Add(index)
        Next
        CMB_CAJA.SelectedIndex = 0




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha1 As String
        Dim fecha2 As String

        fecha1 = DTP_ORIGEN.Value.ToString("yyyy/MM/dd")
        fecha2 = DTP_FIN.Value.ToString("yyyy/MM/dd")

        DG_VENTAS.DataSource = Nothing
        DG_VENTAS.Columns.Clear()
        DG_VENTAS.Rows.Clear()

        DG_VENTAS.DataSource = conexion.COMISION_PERSONAL(fecha1, fecha2, CMB_CAJA.SelectedIndex)


        Dim NUMERO As Integer = DG_VENTAS.Rows.Count

        If NUMERO > 0 Then
            LBL_VENTAS.Text = NUMERO.ToString
            Dim COMISION As Decimal = 0
            For index = 0 To NUMERO - 1
                COMISION = COMISION + DG_VENTAS.Rows.Item(index).Cells(5).Value
            Next
            LBL_CREDITO.Text = COMISION.ToString
        Else
            LBL_VENTAS.Text = NUMERO.ToString
            LBL_CREDITO.Text = "0"

            MsgBox("No hay ventas realizadas en el rango de fechas seleccionado")

        End If
    End Sub
End Class