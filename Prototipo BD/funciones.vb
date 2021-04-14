Imports System.Data.SqlClient
Imports System.Transactions
Imports System.Configuration
Imports System.Data

Public Class funciones
    Private conectate As SqlConnection
    Private transaction As SqlTransaction

    Public Sub Abrir()
        Try
            conectate = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("MyHp").ConnectionString)

            conectate.Open()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Cerrar()

        Try
            conectate.Close()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub Login(usu As String, contra As String, opcion As Integer)

        Abrir()


        Try
            Dim L As SqlCommand
            L = New SqlCommand("SP_LOGIN", conectate)
            L.CommandType = CommandType.StoredProcedure
            L.Parameters.AddWithValue("@Usu", usu)
            L.Parameters.AddWithValue("@Pass", contra)
            L.Parameters.AddWithValue("@opcion", opcion)
            Dim R As SqlDataReader = L.ExecuteReader

            If R.HasRows = True Then

                If opcion = 1 Then
                    While R.Read
                        System.Configuration.ConfigurationManager.AppSettings.Set("NombreUsuario", Trim(R(0)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("CURP_V", Trim(R(1)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("NOMINA_V", Trim(R(2)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("IVA", Trim(R(3)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("COMISION", Trim(R(4)))
                    End While
                    System.Configuration.ConfigurationManager.AppSettings.Set("RFC_V", usu)

                Else
                    While R.Read
                        System.Configuration.ConfigurationManager.AppSettings.Set("NombreUsuario", Trim(R(0)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("IVA", Trim(R(1)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("COMISION", Trim(R(2)))
                    End While

                End If

            Else
                MessageBox.Show("No hay datos que concuerden con los parametros enviados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                System.Configuration.ConfigurationManager.AppSettings.Set("NombreUsuario", "")
            End If
        Catch e As Exception
            MsgBox(e.Message)

        End Try


        Cerrar()

    End Sub

    Public Function COMBO_FORMA_PAGO() As DataTable
        Dim tabla As DataTable = New DataTable

        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_FORMA_PAGO", conectate)
            comando.CommandType = CommandType.StoredProcedure

            Dim lector As SqlDataReader = comando.ExecuteReader
            tabla.Load(lector)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()
        Return tabla
    End Function

    Public Function COMBO_CATEGORIA() As DataTable
        Dim tabla As DataTable = New DataTable

        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_CATEGORIAS", conectate)
            comando.CommandType = CommandType.StoredProcedure

            Dim lector As SqlDataReader = comando.ExecuteReader
            tabla.Load(lector)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()
        Return tabla
    End Function

    Public Function Productos_Eliminados() As DataTable
        Dim tabla As DataTable = New DataTable
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_Productos_Descontinuados", conectate)
            comando.CommandType = CommandType.StoredProcedure

            Dim l As SqlDataReader = comando.ExecuteReader


            If l.HasRows Then
                tabla.Load(l)
            Else
                MessageBox.Show("No hay datos de productos eliminados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()



        Return tabla

    End Function

    Public Function Consulta_vendedor_info(RFC As String, Nomina As String, opcion As Integer) As DataTable

        System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_N", "1")
        System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_RFC", "1")
        Dim tabla As DataTable = New DataTable
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_CONSULTA_VENDEDOR", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@RFC", RFC)
            comando.Parameters.AddWithValue("@nomina", Nomina)
            comando.Parameters.AddWithValue("@opcion", opcion)


            Dim resultado As SqlDataReader = comando.ExecuteReader

            If resultado.HasRows Then
                If opcion = 1 Then
                    While resultado.Read

                        System.Configuration.ConfigurationManager.AppSettings.Set("V_NOMBRE", Trim(resultado(0)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("V_AP", Trim(resultado(1)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("V_AM", Trim(resultado(2)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("V_CURP", Trim(resultado(3)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("V_PASS", Trim(resultado(4)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("V_NOMINA", Trim(resultado(5)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("V_RFC", Trim(resultado(6)))
                    End While
                    MessageBox.Show("Vendedor localizado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_RFC", "0")
                End If



                If opcion = 4 Then
                    'ya existe el rfc que busco
                    MessageBox.Show("El RFC NO esta disponible", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_RFC", "0")
                End If

                If opcion = 5 Then
                    'ya existe el 
                    MessageBox.Show("El Numero de Nomina NO esta disponible", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_N", "0")
                End If

                tabla.Load(resultado)

            Else

                If opcion = 5 Then
                    MessageBox.Show("Numero de Nomina disponible", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If opcion = 4 Then
                        MessageBox.Show("RFC Disponible", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No hay resultados de busqueda", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()




        Return tabla
    End Function

    Public Function VENDEDOR(RFC As String, Nombre As String, AP As String, AM As String, Contra As String, Curp As String, Nomina As String, opcion As Integer) As DataTable
        Dim tabla As DataTable = New DataTable

        Abrir()

        Try
            Dim comando As SqlCommand = New SqlCommand("SP_ADD_DEL_VENDEDOR", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@V_RFC", RFC)
            comando.Parameters.AddWithValue("@nombre", Nombre)
            comando.Parameters.AddWithValue("@V_AP", AP)
            comando.Parameters.AddWithValue("@V_AM", AM)
            comando.Parameters.AddWithValue("@CURP", Curp)
            comando.Parameters.AddWithValue("@contra", Contra)
            comando.Parameters.AddWithValue("@No_Nomina", Nomina)
            comando.Parameters.AddWithValue("@opcion", opcion)
            Dim l As SqlDataReader = comando.ExecuteReader

            If opcion = 1 Then
                MsgBox("Vendedor agregado a sistema")
            End If


        Catch ex As Exception

        End Try

        Cerrar()


        Return tabla
    End Function

    Public Function PRODUCTO(nombre As String, precio As Decimal, stock As Integer, C_RE As Integer, P_RE As Integer, categoria As String, opcion As Integer, N_Orig As String, C_Orig As String) As DataTable
        Dim tabla As DataTable = New DataTable

        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_ADD_DEL_PRODUCTO", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@precio", precio)
            comando.Parameters.AddWithValue("@Cantidad_Stock", stock)
            comando.Parameters.AddWithValue("@CANTIDAD_RE", C_RE)
            comando.Parameters.AddWithValue("@Punto_RE", P_RE)
            comando.Parameters.AddWithValue("@Categoria", categoria)
            comando.Parameters.AddWithValue("@opcion", opcion)
            comando.Parameters.AddWithValue("@N_Orig", N_Orig)
            comando.Parameters.AddWithValue("@C_Orig", C_Orig)

            Dim Ejecutor As SqlDataReader = comando.ExecuteReader

            If opcion = 1 Then
                MsgBox("Producto agregado al sistema")
            End If

            If opcion = 2 Then
                MsgBox("Producto ELIMINADO del sistema")
            End If

            If opcion = 3 Then
                MsgBox("Producto Modificado con exito al sistema")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Cerrar()


        Return tabla
    End Function

    Public Function Consulta_Producto(nombre As String, categoria As String, opcion As Integer) As DataTable
        Dim tabla As DataTable = New DataTable
        System.Configuration.ConfigurationManager.AppSettings.Set("BANDERA", 0)
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_CONSULTA_PRODUCTO", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@categoria", categoria)
            comando.Parameters.AddWithValue("@opcion", opcion)

            Dim l As SqlDataReader = comando.ExecuteReader

            If l.HasRows Then
                If opcion = 1 Then
                    While l.Read

                        System.Configuration.ConfigurationManager.AppSettings.Set("P_PRODUCTO", Trim(l(0)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("P_STOCK", Trim(l(1)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("P_PRECIO", Trim(l(2)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("P_CATEGORIA", Trim(l(3)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("P_P_RE", Trim(l(4)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("P_C_RE", Trim(l(5)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("P_FECHA_RE", Trim(l(6)))
                        System.Configuration.ConfigurationManager.AppSettings.Set("P_FECHA_A", Trim(l(7)))
                    End While

                    System.Configuration.ConfigurationManager.AppSettings.Set("BANDERA", 1)

                    MsgBox("Producto Encontrado")

                End If

                If opcion = 2 Or opcion = 3 Then
                    tabla.Load(l)

                    MsgBox("Producto Encontrado")
                End If

                If opcion = 4 Or opcion = 5 Then
                    tabla.Load(l)
                End If

            Else
                If opcion = 1 Then
                    MsgBox("Producto NO Encontrado")
                End If

                If opcion = 4 Or opcion = 5 Then
                    MsgBox("No hay productos en esta Categoria")
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Cerrar()


        Return tabla
    End Function

    Public Function Cliente_RFC(RFC As String, opcion As Integer) As DataTable
        System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_RFC", 0)
        Dim tabla As DataTable = New DataTable
        Abrir()

        Try
            Dim comando As SqlCommand = New SqlCommand("SP_VALIDAR_RFC", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@RFC", RFC)
            comando.Parameters.AddWithValue("@opcion", opcion)

            Dim l As SqlDataReader = comando.ExecuteReader

            If l.HasRows Then
                If opcion = 1 Then
                    System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_RFC", 1)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()

        Return tabla
    End Function

    Public Function Folio(RFC_C As String, RFC_V As String, Fecha As String, Caja As Integer, Total As Decimal, Formapago As String) As DataTable
        Dim tabla As DataTable = New DataTable
        Abrir()

        Try
            Dim comando As SqlCommand = New SqlCommand("SP_FOLIO", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@RFC_C", RFC_C)
            comando.Parameters.AddWithValue("@RFC_V", RFC_V)
            comando.Parameters.AddWithValue("@Fecha", Fecha)
            comando.Parameters.AddWithValue("@Caja", Caja)
            comando.Parameters.AddWithValue("@Total", Total)
            comando.Parameters.AddWithValue("@FormaPago", Formapago)

            Dim L As SqlDataReader = comando.ExecuteReader

            If L.HasRows Then
                While L.Read
                    System.Configuration.ConfigurationManager.AppSettings.Set("FOLIO_VENTA", Trim(L(0)))
                End While
            Else
                MsgBox("Error al crear folio de venta")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Cerrar()

        Return tabla
    End Function

    Public Function Venta(folio As String, producto As String, precio As Decimal) As Boolean
        'Dim tabla As DataTable = New DataTable
        Abrir()

        Try

            Dim comando As SqlCommand = New SqlCommand("SP_ENVIO_PRODUCTO", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@FolioVenta", folio)
            comando.Parameters.AddWithValue("@producto", producto)
            comando.Parameters.AddWithValue("@precio", precio)

            Dim l As SqlDataReader = comando.ExecuteReader

        Catch ex As Exception
            MsgBox("Error al subir producto a nota de venta")

        End Try

        Cerrar()

        Return False
    End Function

    Public Function Cliente(RFC_V As String, RFC_C As String, nombre As String, ap As String, am As String, domi As String, cp As Integer, correo As String, tel As String, opcion As Integer) As Boolean
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_ADD_DEL_CLIENTE", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@RFC_V", RFC_V)
            comando.Parameters.AddWithValue("@RFC_C", RFC_C)
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@C_AP", ap)
            comando.Parameters.AddWithValue("@C_AM", am)
            comando.Parameters.AddWithValue("@opcion", opcion)
            comando.Parameters.AddWithValue("@telefono", tel)
            comando.Parameters.AddWithValue("@correo", correo)
            comando.Parameters.AddWithValue("@domicilio", domi)
            comando.Parameters.AddWithValue("@CP", cp)

            Dim l As SqlDataReader = comando.ExecuteReader



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Cerrar()
        Return False
    End Function

    Public Function CLIENTE_INFO(RFC As String) As Boolean
        System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_RFC", 0)
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_CLIENTE_INFO", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@RFC", RFC)


            Dim l As SqlDataReader = comando.ExecuteReader

            If l.HasRows Then
                System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_RFC", 1)

                While l.Read
                    System.Configuration.ConfigurationManager.AppSettings.Set("C_Nombre", Trim(l(0)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("C_AP", Trim(l(1)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("C_AM", Trim(l(2)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("C_DIR", Trim(l(3)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("C_CP", Trim(l(4)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("C_TEL", Trim(l(5)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("C_EMAIL", Trim(l(6)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("C_NACIM", Trim(l(7)))
                End While
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Cerrar()


        Return False

    End Function

    Public Function COMBO_MOTIVO() As DataTable

        Dim tabla As DataTable = New DataTable
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_COMBO_MOTIVO", conectate)
            comando.CommandType = CommandType.StoredProcedure

            Dim l As SqlDataReader = comando.ExecuteReader

            If l.HasRows Then

                tabla.Load(l)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()


        Return tabla
    End Function

    Public Sub FOLIO_DEVOLUCION(folio As String)
        Abrir()
        Try
            'crear folio de devolucion
            'retorna numero de folio de devolucion
            Dim comando As SqlCommand = New SqlCommand("SP_FOLIO_DEVOLUCION", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@Folio", folio)
            Dim l As SqlDataReader = comando.ExecuteReader
            If l.HasRows Then

                While l.Read 'SEGUN ES SI TINE MAS DE UN REGISTRO
                    System.Configuration.ConfigurationManager.AppSettings.Set("FOLIO_DEVOLUCION", Trim(l(0)))
                End While

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()

    End Sub

    Public Function PRODUCTOS_VENTA(VENTA As String) As DataTable
        System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_N", 0)
        Dim tabla As DataTable = New DataTable
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_VENTA_PRODUCTO", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@Folio", VENTA)


            Dim l As SqlDataReader = comando.ExecuteReader
            If l.HasRows Then
                'retorna tabla con todos los articulos de una venta
                tabla.Load(l)
                System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_N", 1)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()


        Return tabla

    End Function

    Public Sub CONSULTA_FOLIO(folio As String)

        System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_N", 0)
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_CONSULTA_FOLIO", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@Folio", folio)


            Dim l As SqlDataReader = comando.ExecuteReader
            If l.HasRows Then
                'retorna tabla con todos los articulos de una venta
                While l.Read
                    System.Configuration.ConfigurationManager.AppSettings.Set("D_F", Trim(l(0)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("D_T", Trim(l(1)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("D_V", Trim(l(2)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("D_C", Trim(l(3)))
                End While
                System.Configuration.ConfigurationManager.AppSettings.Set("BOOL_N", 1)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()
    End Sub

    Public Sub DEVOLUCION_PRODUCTO(folio As Integer, producto As String, motivo As String)
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_DEVOLUCION_PRODUCTO", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@clave", folio)
            comando.Parameters.AddWithValue("@producto", producto)
            comando.Parameters.AddWithValue("@motivo", motivo)

            Dim l As SqlDataReader = comando.ExecuteReader

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Cerrar()

    End Sub

    Public Function CONSULTA_FACTURA(opcion As Integer, fecha1 As String, fecha2 As String) As DataTable
        Dim tabla As DataTable = New DataTable

        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_V_FACTURAS", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@opcion", opcion)
            comando.Parameters.AddWithValue("@fecha1", fecha1)
            comando.Parameters.AddWithValue("@fecha2", fecha2)

            Dim l As SqlDataReader = comando.ExecuteReader
            If l.HasRows Then
                tabla.Load(l)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()


        Return tabla
    End Function

    Public Function V_DETALLE(opcion As Integer, folio As String) As DataTable
        Dim tabla As DataTable = New DataTable

        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_V_FACTURAS_D", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@opcion", opcion)
            comando.Parameters.AddWithValue("@folio", folio)
            Dim l As SqlDataReader = comando.ExecuteReader

            If l.HasRows Then
                tabla.Load(l)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()

        Return tabla

    End Function

    Public Function REP_INVENTARO(categoria As String) As DataTable
        Dim TABLA As DataTable = New DataTable

        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_REPORTE_INVENTARIO", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@Categoria", categoria)

            Dim l As SqlDataReader = comando.ExecuteReader
            If l.HasRows Then
                TABLA.Load(l)
            Else
                MsgBox("Categoria sin productos")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()

        Return TABLA
    End Function

    Public Function COMISION_PERSONAL(fecha1 As String, fecha2 As String, Caja As Integer) As DataTable
        Dim tabla As DataTable = New DataTable
        ' Dim RFC As String = System.Configuration.ConfigurationManager.AppSettings.Get("RFC_V")
        Dim NOMBRE As String = System.Configuration.ConfigurationManager.AppSettings.Get("NombreUsuario")
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_VENDEDOR_COMISION", conectate)
            comando.CommandType = CommandType.StoredProcedure
            '  comando.Parameters.AddWithValue("@RFC_V", RFC)
            comando.Parameters.AddWithValue("@FECHA1", fecha1)
            comando.Parameters.AddWithValue("@FECHA2", fecha2)
            comando.Parameters.AddWithValue("@nombre", NOMBRE)
            comando.Parameters.AddWithValue("@CAJA", Caja)

            Dim l As SqlDataReader = comando.ExecuteReader

            If l.HasRows Then
                tabla.Load(l)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()


        Return tabla
    End Function

    Public Function PRINCIPAL_VENTA(caja As Integer) As DataTable
        Dim tabla As DataTable = New DataTable
        Dim nombre As String = System.Configuration.ConfigurationManager.AppSettings.Get("NombreUsuario")
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_VENDEDOR_VENTA", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@nombre", nombre)
            comando.Parameters.AddWithValue("@CAJA", caja)

            Dim l As SqlDataReader = comando.ExecuteReader

            If l.HasRows Then
                tabla.Load(l)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()
        Return tabla
    End Function

    Public Function DG_CLIENTES() As DataTable
        Dim tabla As DataTable = New DataTable
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_DG_CLIENTES", conectate)
            comando.CommandType = CommandType.StoredProcedure

            Dim L As SqlDataReader = comando.ExecuteReader

            If L.HasRows Then
                tabla.Load(L)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()
        Return tabla
    End Function

    Public Function HISTORIAL_CLIENTE(RFC As String, F1 As String, F2 As String, Catego As String) As DataTable
        Dim tabla As DataTable = New DataTable

        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_V_CLIENTE", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@RFC_C", RFC)
            comando.Parameters.AddWithValue("@CATEGORIA", Catego)
            comando.Parameters.AddWithValue("@FECHA1", F1)
            comando.Parameters.AddWithValue("@FECHA2", F2)

            Dim l As SqlDataReader = comando.ExecuteReader
            If l.HasRows Then
                tabla.Load(l)
            End If
        Catch ex As Exception

        End Try
        Cerrar()

        Return tabla
    End Function

    Public Function HISTORIAL_VENDEDOR(rfc As String, catego As String, f1 As String, f2 As String, caja As Integer) As DataTable
        Dim tabla As DataTable = New DataTable
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_V_VENDEDOR", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@RFC_V", rfc)
            comando.Parameters.AddWithValue("@CATEGORIA", catego)
            comando.Parameters.AddWithValue("@FECHA1", f1)
            comando.Parameters.AddWithValue("@FECHA2", f2)
            comando.Parameters.AddWithValue("@CAJA", caja)

            Dim l As SqlDataReader = comando.ExecuteReader
            If l.HasRows Then
                tabla.Load(l)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()
        Return tabla
    End Function

    Public Function DG_VENDEDOR() As DataTable
        Dim tabla As DataTable = New DataTable
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_DG_VENDEDOR", conectate)
            comando.CommandType = CommandType.StoredProcedure

            Dim l As SqlDataReader = comando.ExecuteReader
            If l.HasRows Then
                tabla.Load(l)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()

        Return tabla
    End Function

    Public Function DG_PRINCIPAL_ADMIN(cantidad As Integer) As DataTable
        Dim tabla As DataTable = New DataTable
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_ADMIN_PRINCIPAL", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@cantidad", cantidad)

            Dim l As SqlDataReader = comando.ExecuteReader

            If l.HasRows Then
                tabla.Load(l)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Cerrar()

        Return tabla
    End Function

    Public Function DG_TOTALES(RFC As String, F1 As String, F2 As String, OP As Integer) As DataTable
        Dim tabla As DataTable = New DataTable
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_VENTA_USUARIO", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@RFC", RFC)
            comando.Parameters.AddWithValue("@FECHA1", F1)
            comando.Parameters.AddWithValue("@FECHA2", F2)
            comando.Parameters.AddWithValue("@opcion", OP)
            Dim l As SqlDataReader = comando.ExecuteReader
            If l.HasRows Then
                tabla.Load(l)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()
        Return tabla
    End Function

    Public Sub DESCONTAR(nombre As String, categoria As String)
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_DESCONTAR_UNIDAD", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@producto", nombre)
            comando.Parameters.AddWithValue("@categoria", categoria)

            Dim L As SqlDataReader = comando.ExecuteReader

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Cerrar()

    End Sub

    Public Sub INI_TRAN()
        Abrir()

        Try
            Dim comando As SqlCommand = New SqlCommand("SP_ROLLBACK", conectate)
            comando.CommandType = CommandType.StoredProcedure
            Dim l As SqlDataReader = comando.ExecuteReader

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()

    End Sub

    Public Sub AGREGAR(nombre As String, precio As Decimal)
        Abrir()

        Try
            Dim comando As SqlCommand = New SqlCommand("SP_AGREGAR_UNIDAD", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@producto", nombre)
            comando.Parameters.AddWithValue("@precio_origen", precio)
            Dim l As SqlDataReader = comando.ExecuteReader

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()
    End Sub

    Public Sub FACTURA_FORMATO(folio As String)
        System.Configuration.ConfigurationManager.AppSettings.Set("F_FECHA", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_NOMBRE", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_DIR", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_CORREO", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_TELEFONO", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_VENDEDOR", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_CAJA", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_CA_ARTI", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_SUBTOTAL", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_TOTAL", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("F_PAGO", "")
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_FORMATO_FACTURA", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@NoVenta", folio)

            Dim l As SqlDataReader = comando.ExecuteReader
            If l.HasRows Then
                'leer
                While l.Read

                    System.Configuration.ConfigurationManager.AppSettings.Set("F_FECHA", Trim(l(0)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("F_CA_ARTI", Trim(l(1)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("F_SUBTOTAL", Trim(l(2)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("F_TOTAL", Trim(l(3)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("F_VENDEDOR", Trim(l(4)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("F_CAJA", Trim(l(5)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("F_PAGO", Trim(l(6)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("F_NOMBRE", Trim(l(7)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("F_TELEFONO", Trim(l(8)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("F_DIR", Trim(l(9)))
                    System.Configuration.ConfigurationManager.AppSettings.Set("F_CORREO", Trim(l(10)))

                End While

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()


    End Sub

    Public Sub UPDATE_COMISIONES(iva As Integer, comision As Integer)
        Abrir()
        Try
            Dim comando As SqlCommand = New SqlCommand("SP_UPDATE_COMISIONES", conectate)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@IVA", iva)
            comando.Parameters.AddWithValue("@COMISION", comision)
            Dim L As SqlDataReader = comando.ExecuteReader

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Cerrar()

    End Sub
End Class
