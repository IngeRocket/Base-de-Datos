Public Class AGREGAR_PRODUCTO
    Dim nombre As Boolean
    Dim precio As Boolean
    Dim stock As Boolean
    Dim P_RE As Boolean
    Dim C_RE As Boolean

    Dim conexion As funciones

    Private Sub AGREGAR_PRODUCTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones
        Dim Catego As DataTable
        Catego = conexion.COMBO_CATEGORIA()
        CB_CATEGO.DisplayMember = "Categoria"
        CB_CATEGO.DataSource = Catego
        CB_CATEGO.SelectedIndex = 0

        Vaciar()


    End Sub

    Private Sub BTN_VOLVER_Click(sender As Object, e As EventArgs) Handles BTN_VOLVER.Click
        Close()
    End Sub

    Private Sub BTN_ADD_Click(sender As Object, e As EventArgs) Handles BTN_ADD.Click
        If TXT_NOMBRE.Text <> "" Then
            nombre = True
        Else
            MsgBox("Campo nombre Vacio")
            nombre = False
        End If
        If TXT_PRECIO.Text <> "" Then
            precio = True
        Else
            MsgBox("Campo precio Vacio")
            precio = False
        End If
        If TXT_STOCK.Text <> "" Then
            stock = True
        Else
            MsgBox("Campo stock Vacio")
            stock = False
        End If
        If TXT_PUNTO_RE.Text <> "" Then
            If (Integer.Parse(TXT_PUNTO_RE.Text) > 0) Then
                P_RE = True
            Else
                MsgBox("El Campo Punto de Reorden contiene un valor es menor a 0, inserte un valor mayor a 0")
                P_RE = False
            End If
        Else
            MsgBox("El Campo Punto de Reorden se encuentra vacio, inserte un valor mayor a 0")
            P_RE = False
        End If

        If TXT_CANTIDAD_RE.Text <> "" Then
            If (Integer.Parse(TXT_PUNTO_RE.Text) > 0) Then
                C_RE = True
            Else
                MsgBox("El Campo Punto de Reorden contiene un valor menor a 0, inserte un valor mayor a 0")
                C_RE = False
            End If
        Else
            MsgBox("Campo Cantidad de Reorden se encuentra vacio o su valor es menor a 0, inserte un valor mayor a 0")
            C_RE = False
        End If

        If nombre And precio And stock And P_RE And C_RE Then
            Dim P_producto As String = TXT_NOMBRE.Text
            Dim P_PRECIO As Decimal = Decimal.Parse(TXT_PRECIO.Text)
            Dim P_Stock As Integer = Integer.Parse(TXT_STOCK.Text)
            Dim P_Catego As String = CB_CATEGO.Text
            Dim P_P_RE As Integer = Integer.Parse(TXT_PUNTO_RE.Text)
            Dim P_C_RE As Integer = Integer.Parse(TXT_CANTIDAD_RE.Text)

            conexion.PRODUCTO(P_producto, P_PRECIO, P_Stock, P_C_RE, P_P_RE, P_Catego, 1, "", "")
            Vaciar()
            'Close()
        End If



    End Sub

    Public Function Vaciar() As Boolean
        nombre = False
        precio = False
        stock = False
        P_RE = False
        C_RE = False

        TXT_NOMBRE.Text = ""
        TXT_CANTIDAD_RE.Text = ""
        TXT_PRECIO.Text = ""
        TXT_PUNTO_RE.Text = ""
        TXT_STOCK.Text = ""

        Return True

    End Function
End Class