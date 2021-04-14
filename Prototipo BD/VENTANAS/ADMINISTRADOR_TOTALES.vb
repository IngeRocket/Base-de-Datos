Public Class ADMINISTRADOR_TOTALES
    Dim conexion As funciones
    Private Sub ADMINISTRADOR_TOTALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones
        RB_V.Checked = True
        DG_HISTORIA.DataSource = Nothing
        DG_HISTORIA.Rows.Clear()
        DG_HISTORIA.Columns.Clear()

        DG_PERSONA.DataSource = Nothing
        DG_PERSONA.Rows.Clear()
        DG_PERSONA.Columns.Clear()

    End Sub

    Private Sub BTN_VOLVER_Click(sender As Object, e As EventArgs) Handles BTN_VOLVER.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LBL_IVA.Text = ""
        LBL_NUMERO.Text = ""
        LBL_SUBT.Text = ""

        DG_HISTORIA.DataSource = Nothing
        DG_HISTORIA.Rows.Clear()
        DG_HISTORIA.Columns.Clear()

        DG_PERSONA.DataSource = Nothing
        DG_PERSONA.Rows.Clear()
        DG_PERSONA.Columns.Clear()

        If RB_V.Checked Then
            DG_PERSONA.DataSource = conexion.DG_VENDEDOR()
        Else
            DG_PERSONA.DataSource = conexion.DG_CLIENTES()
        End If

    End Sub

    Private Sub BTN_LLENAR_Click(sender As Object, e As EventArgs) Handles BTN_LLENAR.Click
        Dim RFC As String = DG_PERSONA.SelectedRows.Item(0).Cells(0).Value
        Dim f1 As String = DTP_INI.Value.ToString("yyyy/MM/dd")
        Dim f2 As String = DTP_FIN.Value.ToString("yyyy/MM/dd")
        Dim opcion As Integer = 1
        If RB_V.Checked Then
            opcion = 0
        End If
        DG_HISTORIA.DataSource() = Nothing
        DG_HISTORIA.Rows.Clear()
        DG_HISTORIA.Columns.Clear()

        DG_HISTORIA.DataSource = conexion.DG_TOTALES(RFC, f1, f2, opcion)

        Dim validacion As Integer = DG_HISTORIA.Rows.Count
        If validacion = 0 Then
            MsgBox("No se encontraron registros de venta")
            LBL_IVA.Text = ""
            LBL_NUMERO.Text = ""
            LBL_SUBT.Text = ""

        Else
            Dim numero As Integer = DG_HISTORIA.Rows.Count

            Dim iva As Decimal = 0
            Dim SUBTOTAL As Decimal = 0
            For index = 0 To numero - 1
                iva = iva + DG_HISTORIA.Rows.Item(index).Cells(4).Value
                SUBTOTAL = SUBTOTAL + DG_HISTORIA.Rows.Item(index).Cells(3).Value
            Next
            LBL_NUMERO.Text = numero.ToString
            LBL_IVA.Text = iva.ToString
            LBL_SUBT.Text = SUBTOTAL.ToString
        End If





    End Sub
End Class