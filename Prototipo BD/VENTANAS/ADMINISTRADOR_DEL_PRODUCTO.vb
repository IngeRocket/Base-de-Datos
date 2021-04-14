Public Class ADMINISTRADOR_DEL_PRODUCTO
    Dim conexion As funciones
    Dim categoria As String
    Dim nombre As String
    Dim bandera As Boolean
    Private Sub ADMINISTRADOR_DEL_PRODUCTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones
        categoria = ""
        nombre = ""
        TXT_NOMBRE.Text = ""

        CB_CATEGO.DataSource = conexion.COMBO_CATEGORIA
        CB_CATEGO.DisplayMember = "Categoria"
        CB_CATEGO.SelectedIndex = 0

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click
        categoria = CB_CATEGO.Text
        nombre = TXT_NOMBRE.Text

        If categoria <> "" And nombre <> "" Then
            conexion.Consulta_Producto(nombre, categoria, 1)
            bandera = System.Configuration.ConfigurationManager.AppSettings.Get("BANDERA")
            If (bandera) Then
                llenar()
            Else
                vaciar()
            End If
        Else
            MessageBox.Show("Nombre de producto se encuentra vacio", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub CANCELAR_Click(sender As Object, e As EventArgs) Handles CANCELAR.Click
        Close()
    End Sub

    Private Sub BTN_BORRAR_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR.Click
        'se borrara el producto
        If bandera Then
            '
            If MessageBox.Show("Estas a punto de ELIMINAR un Producto, ¿Deseas Continuar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes Then
                conexion.PRODUCTO(LB_ARTICULO.Text, 0, 0, 0, 0, LB_CATEGO.Text, 2, "", "")

                vaciar()
                Close()

            Else
                vaciar()
            End If

            '
        Else
            MsgBox("No encontraste un producto, NO se puede continuar con la accion seleccionada")
        End If
    End Sub

    Private Function vaciar() As Boolean
        LB_ARTICULO.Text = ""
        LB_PRECIO.Text = ""
        LB_C_RE.Text = ""
        LB_P_RE.Text = ""
        LB_FECHA_ALTA.Text = ""
        LB_ARTICULO.Text = ""
        LB_CATEGO.Text = ""
        LB_STOCK.Text = ""
        Return True

    End Function
    Private Function llenar() As Boolean
        LB_ARTICULO.Text = System.Configuration.ConfigurationManager.AppSettings.Get("P_PRODUCTO")
        LB_PRECIO.Text = System.Configuration.ConfigurationManager.AppSettings.Get("P_PRECIO")
        LB_STOCK.Text = System.Configuration.ConfigurationManager.AppSettings.Get("P_STOCK")
        LB_P_RE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("P_P_RE")
        LB_C_RE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("P_C_RE")
        LB_FECHA_ALTA.Text = System.Configuration.ConfigurationManager.AppSettings.Get("P_FECHA_A")
        LB_CATEGO.Text = System.Configuration.ConfigurationManager.AppSettings.Get("P_CATEGORIA")
        Return False
    End Function
End Class