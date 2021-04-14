<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VENTA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DG_CONSULTA = New System.Windows.Forms.DataGridView()
        Me.BTN_CATEGORIA = New System.Windows.Forms.Button()
        Me.CB_CATEGORIA = New System.Windows.Forms.ComboBox()
        Me.LB_ARTICULO = New System.Windows.Forms.ListBox()
        Me.LB_PRECIO_UNI = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_PRECIO = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BTN_COMPRA = New System.Windows.Forms.Button()
        Me.BTN_CANCEL = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_FORMA_PAGO = New System.Windows.Forms.ComboBox()
        Me.CHK_FACTURA = New System.Windows.Forms.CheckBox()
        Me.TXT_RFC_C = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CHK_FECHA = New System.Windows.Forms.CheckBox()
        Me.EL_TOTAL_NOMBRE = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LB_TOTAL = New System.Windows.Forms.Label()
        Me.DT_FECHA_PERS = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CONSULTAPRODUCTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LB_SUBPRECIO = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DG_CONSULTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_CONSULTA
        '
        Me.DG_CONSULTA.AllowUserToAddRows = False
        Me.DG_CONSULTA.AllowUserToDeleteRows = False
        Me.DG_CONSULTA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_CONSULTA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_CONSULTA.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DG_CONSULTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_CONSULTA.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DG_CONSULTA.Location = New System.Drawing.Point(481, 84)
        Me.DG_CONSULTA.MultiSelect = False
        Me.DG_CONSULTA.Name = "DG_CONSULTA"
        Me.DG_CONSULTA.ReadOnly = True
        Me.DG_CONSULTA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_CONSULTA.Size = New System.Drawing.Size(274, 290)
        Me.DG_CONSULTA.TabIndex = 0
        '
        'BTN_CATEGORIA
        '
        Me.BTN_CATEGORIA.Location = New System.Drawing.Point(637, 44)
        Me.BTN_CATEGORIA.Name = "BTN_CATEGORIA"
        Me.BTN_CATEGORIA.Size = New System.Drawing.Size(109, 26)
        Me.BTN_CATEGORIA.TabIndex = 1
        Me.BTN_CATEGORIA.Text = "CONSULTA"
        Me.BTN_CATEGORIA.UseVisualStyleBackColor = True
        '
        'CB_CATEGORIA
        '
        Me.CB_CATEGORIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CATEGORIA.FormattingEnabled = True
        Me.CB_CATEGORIA.Location = New System.Drawing.Point(493, 48)
        Me.CB_CATEGORIA.Name = "CB_CATEGORIA"
        Me.CB_CATEGORIA.Size = New System.Drawing.Size(126, 21)
        Me.CB_CATEGORIA.TabIndex = 2
        '
        'LB_ARTICULO
        '
        Me.LB_ARTICULO.FormattingEnabled = True
        Me.LB_ARTICULO.Location = New System.Drawing.Point(35, 84)
        Me.LB_ARTICULO.Name = "LB_ARTICULO"
        Me.LB_ARTICULO.Size = New System.Drawing.Size(203, 290)
        Me.LB_ARTICULO.TabIndex = 3
        '
        'LB_PRECIO_UNI
        '
        Me.LB_PRECIO_UNI.FormattingEnabled = True
        Me.LB_PRECIO_UNI.Location = New System.Drawing.Point(244, 84)
        Me.LB_PRECIO_UNI.Name = "LB_PRECIO_UNI"
        Me.LB_PRECIO_UNI.Size = New System.Drawing.Size(90, 290)
        Me.LB_PRECIO_UNI.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ARTICULO"
        '
        'LBL_PRECIO
        '
        Me.LBL_PRECIO.AutoSize = True
        Me.LBL_PRECIO.Location = New System.Drawing.Point(238, 62)
        Me.LBL_PRECIO.Name = "LBL_PRECIO"
        Me.LBL_PRECIO.Size = New System.Drawing.Size(102, 13)
        Me.LBL_PRECIO.TabIndex = 4
        Me.LBL_PRECIO.Text = "PRECIO UNITARIO"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(531, 380)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "AGREGAR A COMPRA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(35, 380)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(299, 26)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "REMOVER ARTICULO"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BTN_COMPRA
        '
        Me.BTN_COMPRA.Location = New System.Drawing.Point(414, 448)
        Me.BTN_COMPRA.Name = "BTN_COMPRA"
        Me.BTN_COMPRA.Size = New System.Drawing.Size(341, 29)
        Me.BTN_COMPRA.TabIndex = 1
        Me.BTN_COMPRA.Text = "FINALIZAR COMPRA"
        Me.BTN_COMPRA.UseVisualStyleBackColor = True
        '
        'BTN_CANCEL
        '
        Me.BTN_CANCEL.Location = New System.Drawing.Point(414, 496)
        Me.BTN_CANCEL.Name = "BTN_CANCEL"
        Me.BTN_CANCEL.Size = New System.Drawing.Size(341, 29)
        Me.BTN_CANCEL.TabIndex = 1
        Me.BTN_CANCEL.Text = "CANCELAR LA COMPRA"
        Me.BTN_CANCEL.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(522, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "CATEGORIA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(848, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "FORMA DE PAGO"
        '
        'CB_FORMA_PAGO
        '
        Me.CB_FORMA_PAGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_FORMA_PAGO.FormattingEnabled = True
        Me.CB_FORMA_PAGO.Location = New System.Drawing.Point(826, 63)
        Me.CB_FORMA_PAGO.Name = "CB_FORMA_PAGO"
        Me.CB_FORMA_PAGO.Size = New System.Drawing.Size(141, 21)
        Me.CB_FORMA_PAGO.TabIndex = 2
        '
        'CHK_FACTURA
        '
        Me.CHK_FACTURA.AutoSize = True
        Me.CHK_FACTURA.Location = New System.Drawing.Point(854, 227)
        Me.CHK_FACTURA.Name = "CHK_FACTURA"
        Me.CHK_FACTURA.Size = New System.Drawing.Size(84, 17)
        Me.CHK_FACTURA.TabIndex = 5
        Me.CHK_FACTURA.Text = "FACTURAR"
        Me.CHK_FACTURA.UseVisualStyleBackColor = True
        '
        'TXT_RFC_C
        '
        Me.TXT_RFC_C.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_RFC_C.Location = New System.Drawing.Point(829, 250)
        Me.TXT_RFC_C.MaxLength = 13
        Me.TXT_RFC_C.Name = "TXT_RFC_C"
        Me.TXT_RFC_C.Size = New System.Drawing.Size(134, 20)
        Me.TXT_RFC_C.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(825, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 22)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "VERIFICAR RFC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CHK_FECHA
        '
        Me.CHK_FECHA.AutoSize = True
        Me.CHK_FECHA.Location = New System.Drawing.Point(795, 329)
        Me.CHK_FECHA.Name = "CHK_FECHA"
        Me.CHK_FECHA.Size = New System.Drawing.Size(203, 17)
        Me.CHK_FECHA.TabIndex = 8
        Me.CHK_FECHA.Text = "FECHA PERSONALIZADA COMPRA"
        Me.CHK_FECHA.UseVisualStyleBackColor = True
        '
        'EL_TOTAL_NOMBRE
        '
        Me.EL_TOTAL_NOMBRE.AutoSize = True
        Me.EL_TOTAL_NOMBRE.Location = New System.Drawing.Point(836, 145)
        Me.EL_TOTAL_NOMBRE.Name = "EL_TOTAL_NOMBRE"
        Me.EL_TOTAL_NOMBRE.Size = New System.Drawing.Size(121, 13)
        Me.EL_TOTAL_NOMBRE.TabIndex = 9
        Me.EL_TOTAL_NOMBRE.Text = "TOTAL A PAGAR + IVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(927, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "MXN"
        '
        'LB_TOTAL
        '
        Me.LB_TOTAL.AutoSize = True
        Me.LB_TOTAL.Location = New System.Drawing.Point(822, 169)
        Me.LB_TOTAL.Name = "LB_TOTAL"
        Me.LB_TOTAL.Size = New System.Drawing.Size(13, 13)
        Me.LB_TOTAL.TabIndex = 11
        Me.LB_TOTAL.Text = "0"
        '
        'DT_FECHA_PERS
        '
        Me.DT_FECHA_PERS.CustomFormat = "yyyy/MM/dd"
        Me.DT_FECHA_PERS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_FECHA_PERS.Location = New System.Drawing.Point(835, 367)
        Me.DT_FECHA_PERS.MaxDate = New Date(2039, 12, 31, 0, 0, 0, 0)
        Me.DT_FECHA_PERS.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DT_FECHA_PERS.Name = "DT_FECHA_PERS"
        Me.DT_FECHA_PERS.Size = New System.Drawing.Size(123, 20)
        Me.DT_FECHA_PERS.TabIndex = 12
        Me.DT_FECHA_PERS.Value = New Date(2019, 5, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(377, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SUBTOTAL"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTAPRODUCTOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1123, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CONSULTAPRODUCTOToolStripMenuItem
        '
        Me.CONSULTAPRODUCTOToolStripMenuItem.Name = "CONSULTAPRODUCTOToolStripMenuItem"
        Me.CONSULTAPRODUCTOToolStripMenuItem.Size = New System.Drawing.Size(143, 20)
        Me.CONSULTAPRODUCTOToolStripMenuItem.Text = "CONSULTA PRODUCTO"
        '
        'LB_SUBPRECIO
        '
        Me.LB_SUBPRECIO.AutoSize = True
        Me.LB_SUBPRECIO.Location = New System.Drawing.Point(340, 236)
        Me.LB_SUBPRECIO.Name = "LB_SUBPRECIO"
        Me.LB_SUBPRECIO.Size = New System.Drawing.Size(13, 13)
        Me.LB_SUBPRECIO.TabIndex = 11
        Me.LB_SUBPRECIO.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(444, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "MXN"
        '
        'VENTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.DT_FECHA_PERS)
        Me.Controls.Add(Me.EL_TOTAL_NOMBRE)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LB_SUBPRECIO)
        Me.Controls.Add(Me.LB_TOTAL)
        Me.Controls.Add(Me.CHK_FECHA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_RFC_C)
        Me.Controls.Add(Me.CHK_FACTURA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBL_PRECIO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LB_PRECIO_UNI)
        Me.Controls.Add(Me.LB_ARTICULO)
        Me.Controls.Add(Me.CB_FORMA_PAGO)
        Me.Controls.Add(Me.CB_CATEGORIA)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BTN_CANCEL)
        Me.Controls.Add(Me.BTN_COMPRA)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTN_CATEGORIA)
        Me.Controls.Add(Me.DG_CONSULTA)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VENTA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTA"
        CType(Me.DG_CONSULTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DG_CONSULTA As DataGridView
    Friend WithEvents BTN_CATEGORIA As Button
    Friend WithEvents CB_CATEGORIA As ComboBox
    Friend WithEvents LB_ARTICULO As ListBox
    Friend WithEvents LB_PRECIO_UNI As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_PRECIO As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents BTN_COMPRA As Button
    Friend WithEvents BTN_CANCEL As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CB_FORMA_PAGO As ComboBox
    Friend WithEvents CHK_FACTURA As CheckBox
    Friend WithEvents TXT_RFC_C As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CHK_FECHA As CheckBox
    Friend WithEvents EL_TOTAL_NOMBRE As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LB_TOTAL As Label
    Friend WithEvents DT_FECHA_PERS As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CONSULTAPRODUCTOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LB_SUBPRECIO As Label
    Friend WithEvents Label9 As Label
End Class
