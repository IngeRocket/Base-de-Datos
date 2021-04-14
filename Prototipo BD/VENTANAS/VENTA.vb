Public Class VENTA
    Dim conexion As funciones
    Dim RFC As String
    Dim FechaPersonalizada As String
    Dim BANDERA As Boolean
    Dim nombre_categoria As String
    Dim ultimaSeleccion As Integer
    Dim Iva As Decimal


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BTN_CANCEL.Click
        'finalizar transaccion
        conexion.INI_TRAN()
        Close()
    End Sub

    Private Sub VENTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Iva = System.Configuration.ConfigurationManager.AppSettings.Get("IVA")
        conexion = New funciones
        Dim Catego As DataTable
        Catego = conexion.COMBO_CATEGORIA()
        nombre_categoria = ""
        ultimaSeleccion = 0
        CB_CATEGORIA.DisplayMember = "Categoria"
        CB_CATEGORIA.DataSource = Catego
        CB_CATEGORIA.SelectedIndex = 0
        'CB_CATEGORIA.d

        Dim Forma As DataTable
        Forma = conexion.COMBO_FORMA_PAGO()
        CB_FORMA_PAGO.DisplayMember = "Forma"
        CB_FORMA_PAGO.DataSource = Forma
        CB_FORMA_PAGO.SelectedIndex = 0

        DT_FECHA_PERS.Value = DateTime.Now.ToString("yyyy/MM/dd")
        'iniciar transaccion
    End Sub

    Private Sub CONSULTAPRODUCTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTAPRODUCTOToolStripMenuItem.Click
        Dim ventana As VENDEDOR_CONSULTA_RAPIDA
        ventana = New VENDEDOR_CONSULTA_RAPIDA
        ventana.ShowDialog()

    End Sub

    Private Sub BTN_CATEGORIA_Click(sender As Object, e As EventArgs) Handles BTN_CATEGORIA.Click
        nombre_categoria = CB_CATEGORIA.Text
        VaciarDataGrid()

        DG_CONSULTA.DataSource = conexion.Consulta_Producto("", nombre_categoria, 4)
        'DG_CONSULTA.DataMember = "PRODUCTO"

    End Sub

    Private Sub VaciarDataGrid()
        DG_CONSULTA.DataSource = Nothing
        DG_CONSULTA.Rows.Clear()
        DG_CONSULTA.Columns.Clear()
        DG_CONSULTA.DataSource = Nothing
        DG_CONSULTA.Rows.Clear()
        DG_CONSULTA.Columns.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim precio As String
        Dim producto As String
        Dim indice As Integer
        indice = DG_CONSULTA.Rows.Count
        If indice > 0 Then
            'ahora va la validacion de stock
            Dim i As Integer = DG_CONSULTA.CurrentRow.Selected
            ultimaSeleccion = i
            Dim stock As Integer = DG_CONSULTA.SelectedRows.Item(0).Cells(2).Value
            'Aqui va la validacion de stock
            If stock > 0 Then
                producto = DG_CONSULTA.SelectedRows.Item(0).Cells(0).Value
                precio = DG_CONSULTA.SelectedRows.Item(0).Cells(1).Value


                LB_ARTICULO.Items.Add(producto)
                LB_PRECIO_UNI.Items.Add(precio)

                Dim SUBTOTAL As Decimal
                SUBTOTAL = Decimal.Parse(LB_SUBPRECIO.Text)
                SUBTOTAL = Decimal.Parse(precio) + SUBTOTAL
                LB_SUBPRECIO.Text = SUBTOTAL.ToString

                SUBTOTAL = (SUBTOTAL * (Iva / 100)) + SUBTOTAL
                LB_TOTAL.Text = SUBTOTAL.ToString
                'restar unidad de stock
                'MsgBox(producto + " " + precio.ToString)
                conexion.DESCONTAR(producto, nombre_categoria)
                'refresh categoria
                Rellenar()

            Else
                'jamas pasara, el trigger de reorden nunca dejara que el producto llegue a 0
                MsgBox("El producto llego al limite 0, se encuentra proximo a reorden")
            End If

        Else
            MsgBox("No puedes seleccionar articulos de esta CATEGORIA porque se encuentra vacia")
            precio = "0"
            producto = ""
        End If






    End Sub

    Private Sub LB_ARTICULO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_ARTICULO.SelectedIndexChanged
        Dim indice As Integer = LB_ARTICULO.SelectedIndex
        LB_PRECIO_UNI.SelectedIndex = indice
    End Sub

    Private Sub LB_PRECIO_UNI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_PRECIO_UNI.SelectedIndexChanged
        Dim indice As Integer = LB_PRECIO_UNI.SelectedIndex

        LB_ARTICULO.SelectedIndex = indice
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim indice As Integer
        indice = LB_ARTICULO.Items.Count
        If indice > 0 Then
            Dim val2 As Integer = LB_ARTICULO.SelectedIndex
            If val2 >= 0 Then
                'si procede a quitar el producto
                Dim I As Integer = LB_ARTICULO.SelectedIndex
                Dim PRECIOREMOVER As Decimal = Decimal.Parse(LB_PRECIO_UNI.Items(I))
                ' MsgBox(LB_PRECIO_UNI.Items(I))

                Dim producto As String = LB_ARTICULO.Items(I)
                conexion.AGREGAR(producto, PRECIOREMOVER)
                LB_ARTICULO.Items.RemoveAt(I)
                LB_PRECIO_UNI.Items.RemoveAt(I)


                Dim PRECIO As Decimal

                PRECIO = Decimal.Parse(LB_SUBPRECIO.Text)

                PRECIO = PRECIO - PRECIOREMOVER
                LB_SUBPRECIO.Text = PRECIO.ToString

                PRECIO = PRECIO - (PRECIO * (Iva / 100))
                LB_TOTAL.Text = PRECIO.ToString
                'refresh 
                Rellenar()
            Else
                MsgBox("Necesita seleccinar un articulo para remover de la lista")
            End If


        Else
            MsgBox("No hay elementos en la lista de compra para remover")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BANDERA = False
        RFC = TXT_RFC_C.Text
        conexion.Cliente_RFC(RFC, 1)
        BANDERA = System.Configuration.ConfigurationManager.AppSettings.Get("BOOL_RFC")
        If BANDERA Then
            MsgBox("RFC Cliente Localizado")

        Else
            MsgBox("Error al capturar RFC del cliente")

        End If
    End Sub

    Private Sub BTN_COMPRA_Click(sender As Object, e As EventArgs) Handles BTN_COMPRA.Click
        Dim a As Integer = LB_ARTICULO.Items.Count
        If a > 0 Then
            'si hay productos por comprar
            'rfc ya esta activo
            If CHK_FACTURA.Checked Then
                ' MsgBox("OPCION: RFC DE CLIENTE ESTA ACTIVO")
                If BANDERA Then
                    'hay rfc valido en el campo
                    If CHK_FECHA.Checked Then
                        'fecha esta activa
                        'rollback

                        'obtener el rfc de mi vendedor

                        Dim RFC_VENDEDOR As String = System.Configuration.ConfigurationManager.AppSettings.Get("RFC_V")
                        Dim caja As Integer = System.Configuration.ConfigurationManager.AppSettings.Get("Caja")
                        Dim totalPrecioIva As Decimal = Decimal.Parse(LB_TOTAL.Text)
                        Dim FormaPago As String = CB_FORMA_PAGO.Text
                        'capturar fecha personalizada
                        FechaPersonalizada = DT_FECHA_PERS.Value.ToString("yyyy/MM/dd")
                        'crear folio
                        conexion.Folio(RFC, RFC_VENDEDOR, FechaPersonalizada, caja, totalPrecioIva, FormaPago)
                        'mandar productos a sistema
                        ProcesoVenta()

                    Else
                        'MsgBox("La fecha de la venta sera con los datos del sistema")
                        Dim RFC_VENDEDOR As String = System.Configuration.ConfigurationManager.AppSettings.Get("RFC_V")
                        Dim caja As Integer = System.Configuration.ConfigurationManager.AppSettings.Get("Caja")
                        Dim totalPrecioIva As Decimal = Decimal.Parse(LB_TOTAL.Text)
                        Dim FormaPago As String = CB_FORMA_PAGO.Text


                        conexion.Folio(RFC, RFC_VENDEDOR, "", caja, totalPrecioIva, FormaPago)
                        'mandar productos a sistema
                        ProcesoVenta()
                    End If

                Else
                    MsgBox("Debes validar RFC para poner una venta a nombre del usuario")
                End If

            Else
                'no ocupa factura
                If CHK_FECHA.Checked Then
                    ' MsgBox("Opcion de Fecha personalizada esta activa")
                    'fecha esta activa

                    Dim RFC_VENDEDOR As String = System.Configuration.ConfigurationManager.AppSettings.Get("RFC_V")
                    Dim caja As Integer = System.Configuration.ConfigurationManager.AppSettings.Get("Caja")
                    Dim totalPrecioIva As Decimal = Decimal.Parse(LB_TOTAL.Text)
                    Dim FormaPago As String = CB_FORMA_PAGO.Text
                    'capturar fecha personalizada
                    FechaPersonalizada = DT_FECHA_PERS.Value.ToString("yyyy/MM/dd")
                    'crear folio

                    conexion.Folio("", RFC_VENDEDOR, FechaPersonalizada, caja, totalPrecioIva, FormaPago)
                    'mandar productos a sistema
                    ProcesoVenta()

                Else
                    'MsgBox("La fecha de la venta sera con los datos del sistema")
                    Dim RFC_VENDEDOR As String = System.Configuration.ConfigurationManager.AppSettings.Get("RFC_V")
                    Dim caja As Integer = System.Configuration.ConfigurationManager.AppSettings.Get("Caja")
                    Dim totalPrecioIva As Decimal = Decimal.Parse(LB_TOTAL.Text)
                    Dim FormaPago As String = CB_FORMA_PAGO.Text

                    'crear folio
                    conexion.Folio("", RFC_VENDEDOR, "", caja, totalPrecioIva, FormaPago)
                    'mandar productos a sistema
                    ProcesoVenta()
                End If
            End If
        Else
            MsgBox("No hay productos en la lista de venta")
        End If



    End Sub

    Private Sub ProcesoVenta()
        'capturar datos del listbox articulos
        Dim Folio As String
        Folio = System.Configuration.ConfigurationManager.AppSettings.Get("FOLIO_VENTA")

        'accion rollback
        conexion.INI_TRAN()


        'MsgBox("Venta enviada al sistema")

        Dim a As Integer
        For a = 0 To LB_ARTICULO.Items.Count - 1

            Dim producto As String = LB_ARTICULO.Items(a).ToString
            Dim precio_P As Decimal = Decimal.Parse(LB_PRECIO_UNI.Items(a))
            ' MsgBox(producto + " " + precio_P)
            conexion.Venta(Folio, producto, precio_P)
        Next a

        MsgBox("Monto a Pagar: " + LB_TOTAL.Text + " MXN Con: " + CB_FORMA_PAGO.Text)

        System.Configuration.ConfigurationManager.AppSettings.Set("FOLIO_VENTA", "")

        Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim rfcvendedor As String = System.Configuration.ConfigurationManager.AppSettings.Get("RFC_V")

        MsgBox(rfcvendedor)

    End Sub

    Private Sub Rellenar()
        VaciarDataGrid()
        'esto solo ocurre cuando estaba con informacion
        'era capaz de poder seleccionar articulos de la lista
        DG_CONSULTA.DataSource = conexion.Consulta_Producto("", nombre_categoria, 4)
        'devolver focus
        DG_CONSULTA.CurrentRow.Selected = ultimaSeleccion
    End Sub
End Class