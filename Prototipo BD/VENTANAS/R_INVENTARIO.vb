Public Class R_INVENTARIO
    Dim conexion As funciones

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub BTN_CONSULTA_Click(sender As Object, e As EventArgs) Handles BTN_CONSULTA.Click
        VaciarGrid()
        Dim categoria As String = CMB_CATEGO.Text
        DG_REPORTE.DataSource = conexion.REP_INVENTARO(categoria)

    End Sub

    Private Sub R_INVENTARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones

        CMB_CATEGO.DataSource = conexion.COMBO_CATEGORIA
        CMB_CATEGO.DisplayMember = "Categoria"
        CMB_CATEGO.SelectedIndex = 0

        VaciarGrid()

    End Sub

    Private Sub VaciarGrid()
        DG_REPORTE.DataSource = Nothing
        DG_REPORTE.Rows.Clear()
        DG_REPORTE.Columns.Clear()
    End Sub
End Class