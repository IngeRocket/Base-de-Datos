Public Class PRODUCTOS_ELIMINADOS
    Dim conexion As funciones
    Private Sub PRODUCTOS_ELIMINADOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DG_PROD.DataSource = Nothing
        DG_PROD.Rows.Clear()
        DG_PROD.Columns.Clear()

        conexion = New funciones
        DG_PROD.DataSource = conexion.Productos_Eliminados()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class