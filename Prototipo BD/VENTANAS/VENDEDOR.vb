Public Class VENDEDOR
    Dim conexion As funciones
    Private Sub VENDEDOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LB_NOMBRE.Text = System.Configuration.ConfigurationManager.AppSettings.Get("NombreUsuario")
        LB_CAJA.Text = System.Configuration.ConfigurationManager.AppSettings.Get("Caja")

        CB_CAJA.Items.Add("Todas")
        For index = 1 To 9
            CB_CAJA.Items.Add(index)
        Next
        CB_CAJA.SelectedIndex = 0

        conexion = New funciones
        Actualizar()

    End Sub

    Private Sub CERRARSESIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARSESIONToolStripMenuItem.Click
        System.Configuration.ConfigurationManager.AppSettings.Set("RFC_V", "")
        System.Configuration.ConfigurationManager.AppSettings.Set("NombreUsuario", "")
        Close()
    End Sub

    Private Sub CREARVENTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CREARVENTAToolStripMenuItem.Click
        Hide()
        Dim ventana As VENTA
        ventana = New VENTA
        ventana.ShowDialog()
        Show()
        Actualizar()
    End Sub

    Private Sub EDITARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITARToolStripMenuItem.Click
        Hide()
        Dim ventana As VENDEDOR_EDITAR
        ventana = New VENDEDOR_EDITAR
        ventana.ShowDialog()
        Show()
        Actualizar()
    End Sub

    Private Sub ALTACLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALTACLIENTEToolStripMenuItem.Click
        Dim ventana As AGREGAR_CLIENTE
        ventana = New AGREGAR_CLIENTE
        Hide()
        ventana.ShowDialog()
        Show()
        Actualizar()
    End Sub

    Private Sub COMISIONESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMISIONESToolStripMenuItem.Click
        Dim ventana As VENDEDOR_COMISION
        ventana = New VENDEDOR_COMISION
        Hide()
        ventana.ShowDialog()
        Show()
        Actualizar()
    End Sub

    Private Sub CREARDEVOLUCIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CREARDEVOLUCIONToolStripMenuItem.Click
        Dim ventana As VENDEDOR_DEVOLUCION
        ventana = New VENDEDOR_DEVOLUCION
        Hide()
        ventana.ShowDialog()
        Show()
        Actualizar()
    End Sub

    Private Sub Actualizar()
        DG_VENTAS.DataSource = Nothing
        DG_VENTAS.Columns.Clear()
        DG_VENTAS.Rows.Clear()
        Dim indice As Integer = CB_CAJA.SelectedIndex

        DG_VENTAS.DataSource = conexion.PRINCIPAL_VENTA(indice)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Actualizar()
    End Sub

    Private Sub BORRARCUENTAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BORRARCUENTAToolStripMenuItem1.Click
        If MessageBox.Show("Estas a punto de ELIMINAR tu cuenta, Perderas todas las ventas realizadas ¿Deseas Continuar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes Then
            Dim RFC As String = System.Configuration.ConfigurationManager.AppSettings.Get("RFC_V")
            conexion.VENDEDOR(RFC, "", "", "", "", "", "", 2)
            MsgBox("Adios")
            System.Configuration.ConfigurationManager.AppSettings.Set("RFC_V", "")
            System.Configuration.ConfigurationManager.AppSettings.Set("NombreUsuario", "")
            Close()

        End If
    End Sub


End Class