<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADMINISTRADOR_DEL_PRODUCTO
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
        Me.BTN_BORRAR = New System.Windows.Forms.Button()
        Me.CANCELAR = New System.Windows.Forms.Button()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_CATEGO = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LB_ARTICULO = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LB_PRECIO = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LB_C_RE = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LB_P_RE = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LB_FECHA_ALTA = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LB_STOCK = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LB_CATEGO = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_BORRAR
        '
        Me.BTN_BORRAR.Location = New System.Drawing.Point(133, 283)
        Me.BTN_BORRAR.Name = "BTN_BORRAR"
        Me.BTN_BORRAR.Size = New System.Drawing.Size(195, 35)
        Me.BTN_BORRAR.TabIndex = 0
        Me.BTN_BORRAR.Text = "BORRAR"
        Me.BTN_BORRAR.UseVisualStyleBackColor = True
        '
        'CANCELAR
        '
        Me.CANCELAR.Location = New System.Drawing.Point(133, 323)
        Me.CANCELAR.Name = "CANCELAR"
        Me.CANCELAR.Size = New System.Drawing.Size(195, 35)
        Me.CANCELAR.TabIndex = 0
        Me.CANCELAR.Text = "CANCELAR"
        Me.CANCELAR.UseVisualStyleBackColor = True
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(309, 28)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(106, 25)
        Me.BTN_BUSCAR.TabIndex = 1
        Me.BTN_BUSCAR.Text = "BUSCAR"
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(149, 15)
        Me.TXT_NOMBRE.MaxLength = 35
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(146, 20)
        Me.TXT_NOMBRE.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PRODUCTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CATEGORIA"
        '
        'CB_CATEGO
        '
        Me.CB_CATEGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CATEGO.FormattingEnabled = True
        Me.CB_CATEGO.Location = New System.Drawing.Point(149, 45)
        Me.CB_CATEGO.Name = "CB_CATEGO"
        Me.CB_CATEGO.Size = New System.Drawing.Size(146, 21)
        Me.CB_CATEGO.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ARTICULO:"
        '
        'LB_ARTICULO
        '
        Me.LB_ARTICULO.AutoSize = True
        Me.LB_ARTICULO.Location = New System.Drawing.Point(244, 91)
        Me.LB_ARTICULO.Name = "LB_ARTICULO"
        Me.LB_ARTICULO.Size = New System.Drawing.Size(69, 13)
        Me.LB_ARTICULO.TabIndex = 3
        Me.LB_ARTICULO.Text = "CATEGORIA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "PRECIO:"
        '
        'LB_PRECIO
        '
        Me.LB_PRECIO.AutoSize = True
        Me.LB_PRECIO.Location = New System.Drawing.Point(245, 164)
        Me.LB_PRECIO.Name = "LB_PRECIO"
        Me.LB_PRECIO.Size = New System.Drawing.Size(69, 13)
        Me.LB_PRECIO.TabIndex = 3
        Me.LB_PRECIO.Text = "CATEGORIA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "CANTIDAD REORDEN:"
        '
        'LB_C_RE
        '
        Me.LB_C_RE.AutoSize = True
        Me.LB_C_RE.Location = New System.Drawing.Point(245, 189)
        Me.LB_C_RE.Name = "LB_C_RE"
        Me.LB_C_RE.Size = New System.Drawing.Size(69, 13)
        Me.LB_C_RE.TabIndex = 3
        Me.LB_C_RE.Text = "CATEGORIA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(137, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "PUNTO REORDEN:"
        '
        'LB_P_RE
        '
        Me.LB_P_RE.AutoSize = True
        Me.LB_P_RE.Location = New System.Drawing.Point(244, 215)
        Me.LB_P_RE.Name = "LB_P_RE"
        Me.LB_P_RE.Size = New System.Drawing.Size(69, 13)
        Me.LB_P_RE.TabIndex = 3
        Me.LB_P_RE.Text = "CATEGORIA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(123, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "ALTA DE PRODUCTO:"
        '
        'LB_FECHA_ALTA
        '
        Me.LB_FECHA_ALTA.AutoSize = True
        Me.LB_FECHA_ALTA.Location = New System.Drawing.Point(244, 242)
        Me.LB_FECHA_ALTA.Name = "LB_FECHA_ALTA"
        Me.LB_FECHA_ALTA.Size = New System.Drawing.Size(69, 13)
        Me.LB_FECHA_ALTA.TabIndex = 3
        Me.LB_FECHA_ALTA.Text = "CATEGORIA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PIEZAS STOCK:"
        '
        'LB_STOCK
        '
        Me.LB_STOCK.AutoSize = True
        Me.LB_STOCK.Location = New System.Drawing.Point(244, 139)
        Me.LB_STOCK.Name = "LB_STOCK"
        Me.LB_STOCK.Size = New System.Drawing.Size(69, 13)
        Me.LB_STOCK.TabIndex = 3
        Me.LB_STOCK.Text = "CATEGORIA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(170, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "CATEGORIA:"
        '
        'LB_CATEGO
        '
        Me.LB_CATEGO.AutoSize = True
        Me.LB_CATEGO.Location = New System.Drawing.Point(244, 115)
        Me.LB_CATEGO.Name = "LB_CATEGO"
        Me.LB_CATEGO.Size = New System.Drawing.Size(69, 13)
        Me.LB_CATEGO.TabIndex = 3
        Me.LB_CATEGO.Text = "CATEGORIA"
        '
        'ADMINISTRADOR_DEL_PRODUCTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 387)
        Me.ControlBox = False
        Me.Controls.Add(Me.CB_CATEGO)
        Me.Controls.Add(Me.LB_FECHA_ALTA)
        Me.Controls.Add(Me.LB_P_RE)
        Me.Controls.Add(Me.LB_C_RE)
        Me.Controls.Add(Me.LB_PRECIO)
        Me.Controls.Add(Me.LB_STOCK)
        Me.Controls.Add(Me.LB_CATEGO)
        Me.Controls.Add(Me.LB_ARTICULO)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Controls.Add(Me.CANCELAR)
        Me.Controls.Add(Me.BTN_BORRAR)
        Me.Name = "ADMINISTRADOR_DEL_PRODUCTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ELIMINAR PRODUCTO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_BORRAR As Button
    Friend WithEvents CANCELAR As Button
    Friend WithEvents BTN_BUSCAR As Button
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_CATEGO As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LB_ARTICULO As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LB_PRECIO As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LB_C_RE As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LB_P_RE As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LB_FECHA_ALTA As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LB_STOCK As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LB_CATEGO As Label
End Class
