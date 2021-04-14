Public Class FORMATO_FACTURA
    Dim conexion As funciones
    Private Sub BTN_VOLVER_Click(sender As Object, e As EventArgs) Handles BTN_VOLVER.Click
        Close()
    End Sub

    Private Sub FORMATO_FACTURA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones
        Limpiar()
        TextBox1.Text = ""
    End Sub

    Private Sub Llenar()
        LBL_FECHA.Text = System.Configuration.ConfigurationManager.AppSettings.Get("F_FECHA")
        LBL_NOMBRE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("F_NOMBRE")
        LBL_DIR.Text = System.Configuration.ConfigurationManager.AppSettings.Get("F_DIR")
        LBL_CO.Text = System.Configuration.ConfigurationManager.AppSettings.Get("F_CORREO")
        LBL_TEL.Text = System.Configuration.ConfigurationManager.AppSettings.Get("F_TELEFONO")
        LBL_VENDEDOR.Text = System.Configuration.ConfigurationManager.AppSettings.Get("F_VENDEDOR")
        LBL_CAJA.Text = System.Configuration.ConfigurationManager.AppSettings.Get("F_CAJA")
        LBL_ARTI.Text = System.Configuration.ConfigurationManager.AppSettings.Get("F_CA_ARTI")
        LBL_SUBT.Text = System.Configuration.ConfigurationManager.AppSettings.Get("F_SUBTOTAL")
        LBL_IVA.Text = System.Configuration.ConfigurationManager.AppSettings.Get("F_TOTAL")
        LBL_FORMA.Text = System.Configuration.ConfigurationManager.AppSettings.Get("F_PAGO")
    End Sub

    Private Sub Limpiar()
        DG_DV.DataSource = Nothing
        DG_DV.Rows.Clear()
        DG_DV.Columns.Clear()

        System.Configuration.ConfigurationManager.AppSettings.Set("F_FECHA", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_NOMBRE", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_DIR", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_CORREO", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_TELEFONO", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_VENDEDOR", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_CAJA", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_CA_ARTI", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_SUBTOTAL", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_TOTAL", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_PAGO", "")
        LBL_NOMBRE.Text = ""
        LBL_DIR.Text = ""
        LBL_TEL.Text = ""
        LBL_CO.Text = ""
        LBL_VENDEDOR.Text = ""
        LBL_CAJA.Text = ""
        LBL_FORMA.Text = ""
        LBL_SUBT.Text = ""
        LBL_IVA.Text = ""
        LBL_ARTI.Text = ""
        LBL_FORMA.Text = ""
        LBL_FECHA.Text = ""

    End Sub

    Private Sub BTN_BUSQUEDA_Click(sender As Object, e As EventArgs) Handles BTN_BUSQUEDA.Click
        Dim folio As String = TextBox1.Text
        conexion.FACTURA_FORMATO(folio)

        DG_DV.DataSource = conexion.V_DETALLE(1, folio)

        Dim numero As Integer = DG_DV.Rows.Count

        If numero = 0 Then
            MsgBox("No se encontro la Orden de compra con el FOLIO ingresado")
            Limpiar()

        Else
            Llenar()
        End If


    End Sub
End Class

