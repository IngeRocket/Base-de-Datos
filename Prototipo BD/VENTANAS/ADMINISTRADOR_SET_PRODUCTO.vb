Public Class ADMINISTRADOR_SET_PRODUCTO
    Dim NOMBRE_ORIG As String
    Dim CATEGO_ORIG As String
    Dim conexion As funciones
    Dim encontrado As Boolean
    Private Sub ADMINISTRADOR_SET_PRODUCTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones
        CB_CATEGO.DataSource = conexion.COMBO_CATEGORIA()
        CB_CATEGO.DisplayMember = "Categoria"
        CB_CATEGO.SelectedIndex = 0
        CB_NuevaCategoria.DataSource = conexion.COMBO_CATEGORIA()
        CB_NuevaCategoria.DisplayMember = "Categoria"
        CB_NuevaCategoria.SelectedIndex = 0
        NOMBRE_ORIG = ""
        CATEGO_ORIG = ""
    End Sub

    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click

        NOMBRE_ORIG = TXT_NOMBRE.Text
        CATEGO_ORIG = CB_CATEGO.Text
        conexion.Consulta_Producto(NOMBRE_ORIG, CATEGO_ORIG, 1)
        encontrado = System.Configuration.ConfigurationManager.AppSettings.Get("BANDERA")
        If encontrado Then
            CB_NuevaCategoria.SelectedIndex = CB_CATEGO.SelectedIndex
            Llenar()
        Else
            vaciar()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTN_CANCEL.Click
        Close()
    End Sub

    Private Function vaciar() As Boolean
        System.Configuration.ConfigurationManager.AppSettings.Set("P_PRODUCTO", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("P_PRECIO", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("P_STOCK", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("P_C_RE", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("P_P_RE", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("P_CATEGORIA", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("P_FECHA_RE", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("P_FECHA_A", "")
        TXT_NUEVO_NOMBRE.Text = ""
        TXT_PRECIO.Text = ""
        TXT_STOCK.Text = ""
        TXT_PUNTO_RE.Text = ""
        TXT_CANTIDAD_RE.Text = ""

        Return True
    End Function

    Private Function Llenar() As Boolean
        TXT_NUEVO_NOMBRE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("P_PRODUCTO")
        TXT_PRECIO.Text = System.Configuration.ConfigurationManager.AppSettings.Get("P_PRECIO")
        TXT_STOCK.Text = System.Configuration.ConfigurationManager.AppSettings.Get("P_STOCK")
        TXT_PUNTO_RE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("P_P_RE")
        TXT_CANTIDAD_RE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("P_C_RE")
        Return True
    End Function

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        If encontrado Then
            Dim F_nombre As String = TXT_NUEVO_NOMBRE.Text
            Dim F_precio As Decimal = Decimal.Parse(TXT_PRECIO.Text)
            Dim F_categoria As String = CB_NuevaCategoria.Text
            Dim F_STOCK As Integer = Integer.Parse(TXT_STOCK.Text)
            Dim F_P_RE As Integer = Integer.Parse(TXT_PUNTO_RE.Text)
            Dim f_C_RE As Integer = Integer.Parse(TXT_CANTIDAD_RE.Text)


            conexion.PRODUCTO(F_nombre, F_precio, F_STOCK, f_C_RE, F_P_RE, F_categoria, 3, NOMBRE_ORIG, CATEGO_ORIG)
            Close()
        Else
            MsgBox("No se localizo producto para editar informacion")
        End If
    End Sub
End Class