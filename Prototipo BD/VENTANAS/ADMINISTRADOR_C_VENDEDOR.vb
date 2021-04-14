Public Class ADMINISTRADOR_C_VENDEDOR
    Dim conexion As funciones
    Private Sub ADMINISTRADOR_C_VENDEDOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones
        CMB_CATEGORIA.DataSource = conexion.COMBO_CATEGORIA()
        CMB_CATEGORIA.DisplayMember = "Categoria"
        CMB_CATEGORIA.SelectedIndex = 0

        CMB_CAJA.Items.Add("TODAS LAS CAJAS")
        For index = 1 To 9
            CMB_CAJA.Items.Add(index)
        Next
        CMB_CAJA.SelectedIndex = 0

        DG_VENDEDOR.DataSource = conexion.DG_VENDEDOR()


    End Sub

    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        limpiar(True)
        Close()
    End Sub

    Private Sub BTN_CONSULTA_Click(sender As Object, e As EventArgs) Handles BTN_CONSULTA.Click
        Dim rfc As String = DG_VENDEDOR.SelectedRows.Item(0).Cells(0).Value
        Dim f1 As String = DTP_INI.Value.ToString("yyyy/MM/dd")
        Dim f2 As String = DTP_FIN.Value.ToString("yyyy/MM/dd")
        Dim Catego As String = CMB_CATEGORIA.Text
        limpiar(False)
        DG_PROD.DataSource = conexion.HISTORIAL_VENDEDOR(rfc, Catego, f1, f2, CMB_CAJA.SelectedIndex)

        Dim indice As Integer = DG_PROD.Rows.Count

        If indice = 0 Then
            MsgBox("No hay productos vendidos en esta Categoria o Rango de fechas seleccionado, o en Caja")
        Else
            Dim comision As Decimal = 0
            Dim total As Integer = 0
            Dim IVA As Decimal = 0

            For index = 0 To DG_PROD.Rows.Count - 1
                total = total + DG_PROD.Rows.Item(index).Cells(1).Value
                comision = comision + DG_PROD.Rows.Item(index).Cells(4).Value
                IVA = IVA + DG_PROD.Rows.Item(index).Cells(3).Value
            Next
            LBL_IVA.Text = IVA.ToString
            LBL_PROD.Text = total.ToString
            LBL_TOT_COMISIONES.Text = comision.ToString


        End If

    End Sub
    Private Sub limpiar(valor As Boolean)
        If valor Then
            DG_VENDEDOR.DataSource = Nothing
            DG_VENDEDOR.Rows.Clear()
            DG_VENDEDOR.Columns.Clear()
        End If

        DG_PROD.DataSource = Nothing
        DG_PROD.Rows.Clear()
        DG_PROD.Columns.Clear()
        LBL_IVA.Text = ""
        LBL_TOT_COMISIONES.Text = ""
        LBL_PROD.Text = ""

    End Sub
End Class