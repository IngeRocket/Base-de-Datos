<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENDEDOR_DEVOLUCION
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_FOLIO = New System.Windows.Forms.TextBox()
        Me.LB_VENTA = New System.Windows.Forms.ListBox()
        Me.LB_CANTIDAD = New System.Windows.Forms.ListBox()
        Me.CB_MOTIVO = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_ADD_DEV = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LB_DEV_PROD = New System.Windows.Forms.ListBox()
        Me.LB_MOTIVO = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTN_ENTER = New System.Windows.Forms.Button()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LB_PRECIO = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LB_SUBTOTAL = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.L_FECHA = New System.Windows.Forms.Label()
        Me.L_VENDEDOR = New System.Windows.Forms.Label()
        Me.L_CLIENTE = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.L_TOTAL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(263, 32)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(124, 20)
        Me.BTN_BUSCAR.TabIndex = 1
        Me.BTN_BUSCAR.Text = "BUSCAR"
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "# VENTA"
        '
        'TXT_FOLIO
        '
        Me.TXT_FOLIO.Location = New System.Drawing.Point(92, 32)
        Me.TXT_FOLIO.MaxLength = 13
        Me.TXT_FOLIO.Name = "TXT_FOLIO"
        Me.TXT_FOLIO.Size = New System.Drawing.Size(165, 20)
        Me.TXT_FOLIO.TabIndex = 0
        '
        'LB_VENTA
        '
        Me.LB_VENTA.FormattingEnabled = True
        Me.LB_VENTA.Location = New System.Drawing.Point(34, 125)
        Me.LB_VENTA.Name = "LB_VENTA"
        Me.LB_VENTA.Size = New System.Drawing.Size(188, 251)
        Me.LB_VENTA.TabIndex = 2
        '
        'LB_CANTIDAD
        '
        Me.LB_CANTIDAD.FormattingEnabled = True
        Me.LB_CANTIDAD.Location = New System.Drawing.Point(228, 125)
        Me.LB_CANTIDAD.Name = "LB_CANTIDAD"
        Me.LB_CANTIDAD.Size = New System.Drawing.Size(69, 251)
        Me.LB_CANTIDAD.TabIndex = 3
        '
        'CB_MOTIVO
        '
        Me.CB_MOTIVO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MOTIVO.FormattingEnabled = True
        Me.CB_MOTIVO.Location = New System.Drawing.Point(526, 156)
        Me.CB_MOTIVO.Name = "CB_MOTIVO"
        Me.CB_MOTIVO.Size = New System.Drawing.Size(141, 21)
        Me.CB_MOTIVO.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(466, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MOTIVO:"
        '
        'BTN_ADD_DEV
        '
        Me.BTN_ADD_DEV.Location = New System.Drawing.Point(466, 201)
        Me.BTN_ADD_DEV.Name = "BTN_ADD_DEV"
        Me.BTN_ADD_DEV.Size = New System.Drawing.Size(201, 20)
        Me.BTN_ADD_DEV.TabIndex = 7
        Me.BTN_ADD_DEV.Text = "AGREGAR A DEVOLUCION"
        Me.BTN_ADD_DEV.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(685, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DEVOLUCION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DETALLE DE VENTA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "CANTIDAD"
        '
        'LB_DEV_PROD
        '
        Me.LB_DEV_PROD.FormattingEnabled = True
        Me.LB_DEV_PROD.Location = New System.Drawing.Point(685, 125)
        Me.LB_DEV_PROD.Name = "LB_DEV_PROD"
        Me.LB_DEV_PROD.Size = New System.Drawing.Size(188, 251)
        Me.LB_DEV_PROD.TabIndex = 8
        '
        'LB_MOTIVO
        '
        Me.LB_MOTIVO.FormattingEnabled = True
        Me.LB_MOTIVO.Location = New System.Drawing.Point(879, 125)
        Me.LB_MOTIVO.Name = "LB_MOTIVO"
        Me.LB_MOTIVO.Size = New System.Drawing.Size(69, 251)
        Me.LB_MOTIVO.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(879, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "MOTIVO"
        '
        'BTN_ENTER
        '
        Me.BTN_ENTER.Location = New System.Drawing.Point(533, 439)
        Me.BTN_ENTER.Name = "BTN_ENTER"
        Me.BTN_ENTER.Size = New System.Drawing.Size(445, 39)
        Me.BTN_ENTER.TabIndex = 11
        Me.BTN_ENTER.Text = "PROCESAR DEVOLUCION"
        Me.BTN_ENTER.UseVisualStyleBackColor = True
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Location = New System.Drawing.Point(533, 484)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(445, 39)
        Me.BTN_SALIR.TabIndex = 12
        Me.BTN_SALIR.Text = "CANCELAR"
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(724, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 20)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "REMOVER DE LA ORDEN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LB_PRECIO
        '
        Me.LB_PRECIO.FormattingEnabled = True
        Me.LB_PRECIO.Location = New System.Drawing.Point(303, 125)
        Me.LB_PRECIO.Name = "LB_PRECIO"
        Me.LB_PRECIO.Size = New System.Drawing.Size(69, 251)
        Me.LB_PRECIO.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(303, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "PRECIO"
        '
        'LB_SUBTOTAL
        '
        Me.LB_SUBTOTAL.FormattingEnabled = True
        Me.LB_SUBTOTAL.Location = New System.Drawing.Point(378, 125)
        Me.LB_SUBTOTAL.Name = "LB_SUBTOTAL"
        Me.LB_SUBTOTAL.Size = New System.Drawing.Size(69, 251)
        Me.LB_SUBTOTAL.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(378, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "SUBTOTAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 448)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "FECHA DE COMPRA:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(72, 472)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "VENDEDOR:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(88, 494)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "CLIENTE:"
        '
        'L_FECHA
        '
        Me.L_FECHA.AutoSize = True
        Me.L_FECHA.Location = New System.Drawing.Point(149, 448)
        Me.L_FECHA.Name = "L_FECHA"
        Me.L_FECHA.Size = New System.Drawing.Size(112, 13)
        Me.L_FECHA.TabIndex = 6
        Me.L_FECHA.Text = "FECHA DE COMPRA:"
        '
        'L_VENDEDOR
        '
        Me.L_VENDEDOR.AutoSize = True
        Me.L_VENDEDOR.Location = New System.Drawing.Point(149, 472)
        Me.L_VENDEDOR.Name = "L_VENDEDOR"
        Me.L_VENDEDOR.Size = New System.Drawing.Size(71, 13)
        Me.L_VENDEDOR.TabIndex = 6
        Me.L_VENDEDOR.Text = "VENDEDOR:"
        '
        'L_CLIENTE
        '
        Me.L_CLIENTE.AutoSize = True
        Me.L_CLIENTE.Location = New System.Drawing.Point(149, 494)
        Me.L_CLIENTE.Name = "L_CLIENTE"
        Me.L_CLIENTE.Size = New System.Drawing.Size(55, 13)
        Me.L_CLIENTE.TabIndex = 6
        Me.L_CLIENTE.Text = "CLIENTE:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(46, 514)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "PAGO DE VENTA:"
        '
        'L_TOTAL
        '
        Me.L_TOTAL.AutoSize = True
        Me.L_TOTAL.Location = New System.Drawing.Point(149, 514)
        Me.L_TOTAL.Name = "L_TOTAL"
        Me.L_TOTAL.Size = New System.Drawing.Size(45, 13)
        Me.L_TOTAL.TabIndex = 6
        Me.L_TOTAL.Text = "TOTAL:"
        '
        'VENDEDOR_DEVOLUCION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 557)
        Me.ControlBox = False
        Me.Controls.Add(Me.L_CLIENTE)
        Me.Controls.Add(Me.L_VENDEDOR)
        Me.Controls.Add(Me.L_TOTAL)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.L_FECHA)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_MOTIVO)
        Me.Controls.Add(Me.LB_MOTIVO)
        Me.Controls.Add(Me.LB_SUBTOTAL)
        Me.Controls.Add(Me.LB_PRECIO)
        Me.Controls.Add(Me.LB_CANTIDAD)
        Me.Controls.Add(Me.LB_DEV_PROD)
        Me.Controls.Add(Me.LB_VENTA)
        Me.Controls.Add(Me.TXT_FOLIO)
        Me.Controls.Add(Me.BTN_SALIR)
        Me.Controls.Add(Me.BTN_ENTER)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_ADD_DEV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Name = "VENDEDOR_DEVOLUCION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEVOLUCION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_BUSCAR As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_FOLIO As TextBox
    Friend WithEvents LB_VENTA As ListBox
    Friend WithEvents LB_CANTIDAD As ListBox
    Friend WithEvents CB_MOTIVO As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_ADD_DEV As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LB_DEV_PROD As ListBox
    Friend WithEvents LB_MOTIVO As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BTN_ENTER As Button
    Friend WithEvents BTN_SALIR As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LB_PRECIO As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LB_SUBTOTAL As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents L_FECHA As Label
    Friend WithEvents L_VENDEDOR As Label
    Friend WithEvents L_CLIENTE As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents L_TOTAL As Label
End Class
