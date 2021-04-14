Public Class C_DETALLE
    Dim conexion As funciones
    Private Sub BTN_REGRESO_Click(sender As Object, e As EventArgs) Handles BTN_REGRESO.Click
        System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_N", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("FOLIO_VENTA", "")
        DG_G.DataSource = Nothing
        DG_G.Rows.Clear()
        DG_G.Columns.Clear()
        Close()

    End Sub

    Private Sub C_DETALLEvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones
        DG_G.DataSource = Nothing
        DG_G.Rows.Clear()
        DG_G.Columns.Clear()


        Dim B_COMPRA As Boolean = System.Configuration.ConfigurationManager.AppSettings.Get("BOOL_N")
        Dim folio As String = System.Configuration.ConfigurationManager.AppSettings.Get("FOLIO_VENTA")
        If B_COMPRA Then
            'compra
            DG_G.DataSource = conexion.V_DETALLE(1, folio)
        Else
            'devolucion
            DG_G.DataSource = conexion.V_DETALLE(2, folio)
        End If
    End Sub
End Class