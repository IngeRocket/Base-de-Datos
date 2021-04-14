Public Class VENDEDOR_CONSULTA_RAPIDA
    Dim nombre As String
    Dim Categoria As String
    Dim precio As String

    Dim conexion As funciones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre = TXT_NOMBRE.Text
        Categoria = CB_CATEGO.Text

        MsgBox("Nombre Categoria: " + Categoria, 64)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub VENDEDOR_CONSULTA_RAPIDA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones
        CB_CATEGO.DataSource = conexion.COMBO_CATEGORIA()
        CB_CATEGO.DisplayMember = "Categoria"
        CB_CATEGO.SelectedIndex = 0

    End Sub
End Class