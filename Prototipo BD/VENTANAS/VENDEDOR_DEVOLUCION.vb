Public Class VENDEDOR_DEVOLUCION
    Dim conexion As funciones
    Dim tabla As DataTable
    Dim folio1 As String
    Private Sub VENDEDOR_DEVOLUCION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones
        CB_MOTIVO.DataSource = conexion.COMBO_MOTIVO()
        CB_MOTIVO.DisplayMember = "MOTIVO"
        CB_MOTIVO.SelectedIndex = 0
        tabla = New DataTable
        Vaciar_Lista(True)
        folio1 = ""
    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click
        Close()

    End Sub

    Private Sub Vaciar_Lista(DATOS As Boolean)


        LB_VENTA.DataSource = Nothing

        LB_CANTIDAD.DataSource = Nothing

        LB_PRECIO.DataSource = Nothing

        LB_SUBTOTAL.DataSource = Nothing



        LB_CANTIDAD.Items.Clear()
        LB_VENTA.Items.Clear()
        LB_PRECIO.Items.Clear()
        LB_SUBTOTAL.Items.Clear()
        LB_MOTIVO.Items.Clear()
        LB_DEV_PROD.Items.Clear()



        If DATOS Then
            L_VENDEDOR.Text = ""
            L_CLIENTE.Text = ""
            L_FECHA.Text = ""
            L_TOTAL.Text = ""
        End If
    End Sub

    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click
        Vaciar_Lista(True)

        folio1 = TXT_FOLIO.Text
        If folio1 <> "" Then
            conexion.CONSULTA_FOLIO(folio1)
            Dim validar As Boolean = System.Configuration.ConfigurationManager.AppSettings.Get("BOOL_N")

            If validar Then
                MsgBox("Ficha de Compra Localizada")
                L_FECHA.Text = System.Configuration.ConfigurationManager.AppSettings.Get("D_F")
                L_CLIENTE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("D_C")
                L_VENDEDOR.Text = System.Configuration.ConfigurationManager.AppSettings.Get("D_V")
                L_TOTAL.Text = System.Configuration.ConfigurationManager.AppSettings.Get("D_T")
                tabla = conexion.PRODUCTOS_VENTA(folio1)
                LB_VENTA.DataSource = tabla
                LB_VENTA.DisplayMember = "Articulo"
                LB_CANTIDAD.DataSource = tabla
                LB_CANTIDAD.DisplayMember = "Cantidad"
                LB_PRECIO.DataSource = tabla
                LB_PRECIO.DisplayMember = "Precio"
                LB_SUBTOTAL.DataSource = tabla
                LB_SUBTOTAL.DisplayMember = "SubTotal"

                If LB_VENTA.Items.Count = 0 Then
                    MsgBox("Todos los articulos de esta venta fueron regresados")

                End If
            Else
                MsgBox("El FOLIO no corresponde a ninguna Venta")
            End If


        Else
            MsgBox("Campo FOLIO vacio")

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'remover de lista
        Dim index As Integer

        index = LB_DEV_PROD.Items.Count
        If index > 0 Then
            index = LB_DEV_PROD.SelectedIndex
            If index = -1 Then
                MsgBox("Seleccione articulo de la lista a remover")
            Else
                Dim producto As String = LB_DEV_PROD.SelectedItem

                LB_DEV_PROD.Items.RemoveAt(index)
                LB_MOTIVO.Items.RemoveAt(index)

                For index2 = 0 To LB_VENTA.Items.Count - 1
                    If LB_VENTA.SelectedValue(0).ToString = producto Then
                        'regresar articulo

                        LB_CANTIDAD.SelectedValue(1) = (LB_CANTIDAD.SelectedValue(1)) + 1

                        LB_CANTIDAD.DataSource = Nothing
                        LB_CANTIDAD.DataSource = tabla
                        LB_CANTIDAD.DisplayMember = "Cantidad"


                        index2 = LB_VENTA.Items.Count
                    End If

                Next

            End If

        Else
            MsgBox("No hay Articulos en la lista para ser removidos")
        End If


    End Sub

    Private Sub BTN_ADD_DEV_Click(sender As Object, e As EventArgs) Handles BTN_ADD_DEV.Click
        Dim index As Integer = -1

        index = LB_VENTA.Items.Count

        If index > 0 Then
            'si hay datos en la lista
            index = LB_VENTA.SelectedIndex

            If index <> -1 Then
                'seleccion valida
                index = LB_CANTIDAD.SelectedValue(1)
                If index > 0 Then
                    'hay mas de un producto para hacer posible devolucion
                    Dim articulo As String = LB_VENTA.SelectedValue(0).ToString
                    Dim motivo As String = CB_MOTIVO.Text

                    LB_DEV_PROD.Items.Add(articulo)
                    LB_MOTIVO.Items.Add(motivo)


                    LB_CANTIDAD.SelectedValue(1) = (LB_CANTIDAD.SelectedValue(1)) - 1

                    LB_CANTIDAD.DataSource = Nothing
                    LB_CANTIDAD.DataSource = tabla
                    LB_CANTIDAD.DisplayMember = "Cantidad"
                Else
                    MsgBox("No pudes devolver mas cantidades de este articulo")
                End If
            End If

        End If


    End Sub

    Private Sub LB_DEV_PROD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_DEV_PROD.SelectedIndexChanged
        Dim index As Integer = LB_DEV_PROD.SelectedIndex
        LB_MOTIVO.SelectedIndex = index

    End Sub

    Private Sub LB_MOTIVO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_MOTIVO.SelectedIndexChanged
        Dim index As Integer = LB_MOTIVO.SelectedIndex
        LB_DEV_PROD.SelectedIndex = index
    End Sub

    Private Sub BTN_ENTER_Click(sender As Object, e As EventArgs) Handles BTN_ENTER.Click
        Dim index = LB_DEV_PROD.Items.Count

        If index > 0 Then
            'crear folio de devolucion de articulos
            conexion.FOLIO_DEVOLUCION(folio1)
            Dim FOLIO As Integer = System.Configuration.ConfigurationManager.AppSettings.Get("FOLIO_DEVOLUCION")
            'cargar informacion
            For index2 = 0 To LB_DEV_PROD.Items.Count - 1
                Dim producto As String = LB_DEV_PROD.Items(index2).ToString
                Dim motivo As String = LB_MOTIVO.Items(index2).ToString
                MsgBox(producto + " " + motivo)
                conexion.DEVOLUCION_PRODUCTO(FOLIO, producto, motivo)
            Next

            System.Configuration.ConfigurationManager.AppSettings.Set("FOLIO_DEVOLUCION", "")
            System.Configuration.ConfigurationManager.AppSettings.Set("D_C", "")
            System.Configuration.ConfigurationManager.AppSettings.Set("D_V", "")
            System.Configuration.ConfigurationManager.AppSettings.Set("D_T", "")
            System.Configuration.ConfigurationManager.AppSettings.Set("D_F", "")
            Vaciar_Lista(True)
            MsgBox("Solicitud enviada al sistema")
            Close()

        Else
            MsgBox("No se puede realizar una DEVOLUCION porque no hay productos por regresar en la lista")
        End If
    End Sub
End Class