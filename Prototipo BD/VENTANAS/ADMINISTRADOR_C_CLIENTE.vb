Public Class ADMINISTRADOR_C_CLIENTE
    Dim conexion As funciones
    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        Close()
    End Sub

    Private Sub ADMINISTRADOR_C_CLIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones
        DTP_INI.Value = Date.Now.ToString("yyyy/MM/dd")
        DTP_FIN.Value = Date.Now.ToString("yyyy/MM/dd")
        CMB_CATEGORIA.DataSource = conexion.COMBO_CATEGORIA()
        CMB_CATEGORIA.DisplayMember = "Categoria"
        CMB_CATEGORIA.SelectedIndex = 0
        Limpiar(True)
        DG_CLIENTE.DataSource = conexion.DG_CLIENTES()


    End Sub

    Private Sub Limpiar(opcion As Boolean)
        DG_PROD.DataSource = Nothing
        DG_PROD.Rows.Clear()
        DG_PROD.Columns.Clear()
        If opcion Then
            DG_CLIENTE.DataSource = Nothing
            DG_CLIENTE.Rows.Clear()
            DG_CLIENTE.Columns.Clear()
        End If
        LBL_COMPRAS.Text = ""
        LBL_PROD.Text = ""

    End Sub

    Private Sub BTN_CONSULTA_Click(sender As Object, e As EventArgs) Handles BTN_CONSULTA.Click
        Dim indice As Integer = DG_CLIENTE.Rows.Count
        Limpiar(False)

        If indice = 0 Then
            MsgBox("No hay clientes")
        Else
            Dim rfc As String = DG_CLIENTE.SelectedRows.Item(0).Cells(0).Value
            Dim f1 As String = DTP_INI.Value.ToString("yyyy/MM/dd")
            Dim f2 As String = DTP_FIN.Value.ToString("yyyy/MM/dd")
            DG_PROD.DataSource = conexion.HISTORIAL_CLIENTE(rfc, f1, f2, CMB_CATEGORIA.Text)

            Dim prod As Integer = DG_PROD.Rows.Count
            If prod = 0 Then
                MsgBox("No hay compras de esta Categoria o en el rango de Fechas establecido")
            Else
                Dim productos As Integer
                Dim gastos As Decimal

                For index = 0 To DG_PROD.Rows.Count - 1
                    gastos = gastos + DG_PROD.Rows.Item(index).Cells(4).Value
                    productos = productos + DG_PROD.Rows.Item(index).Cells(2).Value
                Next

                LBL_COMPRAS.Text = gastos.ToString
                LBL_PROD.Text = productos.ToString


            End If

        End If
    End Sub
End Class