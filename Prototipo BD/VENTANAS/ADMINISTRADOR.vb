Public Class ADMINISTRADOR
    Dim conexion As funciones
    Private Sub SALIDA_Click(sender As Object, e As EventArgs) Handles SALIDA.Click
        DG_PRODUCTOS.DataSource = Nothing
        DG_PRODUCTOS.Rows.Clear()
        DG_PRODUCTOS.Columns.Clear()

        Close()
    End Sub

    Private Sub ADMINISTRADOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New funciones

        DG_PRODUCTOS.DataSource = Nothing
        DG_PRODUCTOS.Rows.Clear()
        DG_PRODUCTOS.Columns.Clear()

    End Sub

    Private Sub AÑADIRPRODUCTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AÑADIRPRODUCTOToolStripMenuItem.Click
        Dim ventana As AGREGAR_PRODUCTO
        ventana = New AGREGAR_PRODUCTO
        Hide()
        ventana.ShowDialog()
        Show()

    End Sub

    Private Sub AGREGARVENDEDORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AGREGARVENDEDORToolStripMenuItem.Click
        Dim ventana As AGREGAR_VENDEDOR
        ventana = AGREGAR_VENDEDOR
        Hide()
        ventana.ShowDialog()
        Show()

    End Sub

    Private Sub BORRARCLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BORRARCLIENTEToolStripMenuItem.Click
        Dim ventana As ADMINISTRADOR_DEL_CLIENTE
        ventana = New ADMINISTRADOR_DEL_CLIENTE
        Hide()
        ventana.ShowDialog()
        Show()
    End Sub

    Private Sub ELIMINARVENDEDORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARVENDEDORToolStripMenuItem.Click
        Dim ventana As ADMINISTRADOR_DEL_VENDEDOR
        ventana = New ADMINISTRADOR_DEL_VENDEDOR
        Hide()
        ventana.ShowDialog()
        Show()
    End Sub

    Private Sub DESCONTINUADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DESCONTINUADOSToolStripMenuItem.Click
        Dim ventana As PRODUCTOS_ELIMINADOS
        ventana = New PRODUCTOS_ELIMINADOS
        Hide()
        ventana.ShowDialog()
        Show()
    End Sub

    Private Sub EDITARVENDEDORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITARVENDEDORToolStripMenuItem.Click
        Dim ventana As ADMINISTRADOR_SET_VENDEDOR
        ventana = New ADMINISTRADOR_SET_VENDEDOR
        Hide()
        ventana.ShowDialog()
        Show()
    End Sub

    Private Sub EDITARCLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITARCLIENTEToolStripMenuItem.Click
        Dim ventana As ADMINISTRADOR_SET_CLIENTE
        ventana = New ADMINISTRADOR_SET_CLIENTE
        Hide()
        ventana.ShowDialog()
        Show()
    End Sub

    Private Sub ELIMINARPRODCUTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARPRODCUTOToolStripMenuItem.Click
        Dim ventana As ADMINISTRADOR_DEL_PRODUCTO
        ventana = New ADMINISTRADOR_DEL_PRODUCTO
        Hide()
        ventana.ShowDialog()
        Show()

    End Sub

    Private Sub REORDENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REORDENToolStripMenuItem.Click
        Dim ventana As ADMINISTRADOR_SET_PRODUCTO
        ventana = New ADMINISTRADOR_SET_PRODUCTO
        Hide()
        ventana.ShowDialog()
        Show()

    End Sub

    Private Sub COMPRASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMPRASToolStripMenuItem.Click
        Dim ventana As CONSULTA_FACTURAS
        ventana = New CONSULTA_FACTURAS
        Hide()
        ventana.ShowDialog()
        Show()

    End Sub

    Private Sub VIGENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIGENTESToolStripMenuItem.Click
        Dim ventana As R_INVENTARIO = New R_INVENTARIO
        Hide()
        ventana.ShowDialog()
        Show()
    End Sub

    Private Sub CLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIENTEToolStripMenuItem.Click
        Dim ventana As ADMINISTRADOR_C_CLIENTE
        ventana = New ADMINISTRADOR_C_CLIENTE
        Hide()
        ventana.ShowDialog()
        Show()
    End Sub

    Private Sub VENDEDORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENDEDORToolStripMenuItem.Click
        Dim ventana As ADMINISTRADOR_C_VENDEDOR
        ventana = New ADMINISTRADOR_C_VENDEDOR
        Hide()
        ventana.ShowDialog()
        Show()
    End Sub

    Private Sub BTN_CONSULTAR_Click(sender As Object, e As EventArgs) Handles BTN_CONSULTAR.Click
        DG_PRODUCTOS.DataSource = Nothing
        DG_PRODUCTOS.Rows.Clear()
        DG_PRODUCTOS.Columns.Clear()


        Dim numero = 0
        If TextBox1.Text <> "" Then
            numero = Integer.Parse(TextBox1.Text)
            DG_PRODUCTOS.DataSource = conexion.DG_PRINCIPAL_ADMIN(numero)
        Else
            MsgBox("Inserta numero valido")

        End If


    End Sub

    Private Sub TOTALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TOTALESToolStripMenuItem.Click
        Dim ventana As ADMINISTRADOR_TOTALES = New ADMINISTRADOR_TOTALES
        Hide()
        ventana.ShowDialog()
        Show()
    End Sub

    Private Sub FACTURAFORMATOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FACTURAFORMATOToolStripMenuItem.Click
        Dim ventana As FORMATO_FACTURA
        ventana = New FORMATO_FACTURA
        Hide()
        ventana.ShowDialog()
        Show()
    End Sub

    Private Sub COMISIONESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMISIONESToolStripMenuItem.Click
        Dim ventana As ADMINISTRADOR_SET_PORCENTAJE
        ventana = New ADMINISTRADOR_SET_PORCENTAJE
        Hide()
        ventana.ShowDialog()
        Show()
    End Sub
End Class