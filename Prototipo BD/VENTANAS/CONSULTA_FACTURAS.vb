Public Class CONSULTA_FACTURAS
    Dim conexion As funciones
    Private Sub CONSULTA_FACTURAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTP_FI.Value = DateTime.Now.ToString("dd/MM/yyyy")
        DTP_FF.Value = DateTime.Now.ToString("dd/MM/yyyy")
        RB_COMPRA.Checked = True
        conexion = New funciones
        LBL_GAN.Text = ""
        LBL_GAN_NUMERO.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub DG_V_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_V.CellContentDoubleClick
        Dim index As Integer = DG_V.Rows.Count
        Dim folio As String
        If index > 0 Then
            'si hay elementos
            'revisar folio para consulta
            folio = DG_V.SelectedRows.Item(0).Cells(0).Value
            MsgBox(folio)
            System.Configuration.ConfigurationManager.AppSettings.Set("FOLIO_VENTA", folio)

            If RB_COMPRA.Checked Then
                System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_N", 1)
            Else
                System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_N", 0)
            End If

            Dim ventana As C_DETALLE = New C_DETALLE
            Hide()
            ventana.ShowDialog()
            Show()


        End If

    End Sub

    Private Sub BTN_CONSULTA_Click(sender As Object, e As EventArgs) Handles BTN_CONSULTA.Click
        If RB_COMPRA.Checked Then
            DG_V.DataSource = Nothing
            DG_V.Columns.Clear()
            DG_V.Rows.Clear()
            DG_V.DataSource = conexion.CONSULTA_FACTURA(1, DTP_FI.Value.ToString("yyyy/MM/dd"), DTP_FF.Value.ToString("yyyy/MM/dd"))
        Else
            DG_V.DataSource = Nothing
            DG_V.Columns.Clear()
            DG_V.Rows.Clear()
            LBL_GAN_NUMERO.Text = ""
            LBL_GAN.Text = ""
            DG_V.DataSource = conexion.CONSULTA_FACTURA(2, DTP_FI.Value.ToString("yyyy/MM/dd"), DTP_FF.Value.ToString("yyyy/MM/dd"))
        End If

        Dim elementos As Integer = DG_V.Rows.Count
        If elementos = 0 Then
            If RB_COMPRA.Checked Then
                MsgBox("No se encuentraron Facturas en el rango de Fechas establecido")
                LBL_GAN.Text = ""
                LBL_GAN_NUMERO.Text = ""

            Else
                MsgBox("No se encuentraron Devoluciones en el rango de Fechas establecido")
            End If
            LBL_NUMERO.Text = "0"
        Else
            If RB_COMPRA.Checked Then
                LBL_GAN.Text = "GANANCIAS:"
                Dim VALOR As Decimal
                For index = 0 To elementos - 1
                    '6 IVA
                    VALOR = VALOR + DG_V.Rows.Item(index).Cells(6).Value
                Next

                LBL_GAN_NUMERO.Text = VALOR.ToString
            End If
            LBL_NUMERO.Text = elementos.ToString
        End If
    End Sub


End Class