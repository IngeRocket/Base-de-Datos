<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMINISTRADOR_SET_PRODUCTO
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
        Me.TXT_CANTIDAD_RE = New System.Windows.Forms.TextBox()
        Me.TXT_PUNTO_RE = New System.Windows.Forms.TextBox()
        Me.TXT_STOCK = New System.Windows.Forms.TextBox()
        Me.TXT_PRECIO = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_CATEGO = New System.Windows.Forms.ComboBox()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.CB_NuevaCategoria = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_NUEVO_NOMBRE = New System.Windows.Forms.TextBox()
        Me.BTN_SAVE = New System.Windows.Forms.Button()
        Me.BTN_CANCEL = New System.Windows.Forms.Button()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.GB1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_CANTIDAD_RE
        '
        Me.TXT_CANTIDAD_RE.Location = New System.Drawing.Point(141, 193)
        Me.TXT_CANTIDAD_RE.MaxLength = 4
        Me.TXT_CANTIDAD_RE.Name = "TXT_CANTIDAD_RE"
        Me.TXT_CANTIDAD_RE.Size = New System.Drawing.Size(78, 20)
        Me.TXT_CANTIDAD_RE.TabIndex = 18
        '
        'TXT_PUNTO_RE
        '
        Me.TXT_PUNTO_RE.Location = New System.Drawing.Point(141, 163)
        Me.TXT_PUNTO_RE.MaxLength = 4
        Me.TXT_PUNTO_RE.Name = "TXT_PUNTO_RE"
        Me.TXT_PUNTO_RE.Size = New System.Drawing.Size(78, 20)
        Me.TXT_PUNTO_RE.TabIndex = 17
        '
        'TXT_STOCK
        '
        Me.TXT_STOCK.Location = New System.Drawing.Point(141, 131)
        Me.TXT_STOCK.MaxLength = 4
        Me.TXT_STOCK.Name = "TXT_STOCK"
        Me.TXT_STOCK.Size = New System.Drawing.Size(78, 20)
        Me.TXT_STOCK.TabIndex = 16
        '
        'TXT_PRECIO
        '
        Me.TXT_PRECIO.Location = New System.Drawing.Point(141, 99)
        Me.TXT_PRECIO.MaxLength = 6
        Me.TXT_PRECIO.Name = "TXT_PRECIO"
        Me.TXT_PRECIO.Size = New System.Drawing.Size(135, 20)
        Me.TXT_PRECIO.TabIndex = 8
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(235, 37)
        Me.TXT_NOMBRE.MaxLength = 35
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(169, 20)
        Me.TXT_NOMBRE.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cantidad de Reorden"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Punto de Reorden"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Stock"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(280, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "MXN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombre Articulo"
        '
        'CB_CATEGO
        '
        Me.CB_CATEGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CATEGO.FormattingEnabled = True
        Me.CB_CATEGO.Location = New System.Drawing.Point(235, 71)
        Me.CB_CATEGO.Name = "CB_CATEGO"
        Me.CB_CATEGO.Size = New System.Drawing.Size(135, 21)
        Me.CB_CATEGO.TabIndex = 7
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(152, 111)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(221, 29)
        Me.BTN_BUSCAR.TabIndex = 19
        Me.BTN_BUSCAR.Text = "BUSCAR"
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'CB_NuevaCategoria
        '
        Me.CB_NuevaCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_NuevaCategoria.FormattingEnabled = True
        Me.CB_NuevaCategoria.Location = New System.Drawing.Point(141, 63)
        Me.CB_NuevaCategoria.Name = "CB_NuevaCategoria"
        Me.CB_NuevaCategoria.Size = New System.Drawing.Size(135, 21)
        Me.CB_NuevaCategoria.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Nombre Articulo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Categoria"
        '
        'TXT_NUEVO_NOMBRE
        '
        Me.TXT_NUEVO_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_NUEVO_NOMBRE.Location = New System.Drawing.Point(141, 29)
        Me.TXT_NUEVO_NOMBRE.MaxLength = 35
        Me.TXT_NUEVO_NOMBRE.Name = "TXT_NUEVO_NOMBRE"
        Me.TXT_NUEVO_NOMBRE.Size = New System.Drawing.Size(169, 20)
        Me.TXT_NUEVO_NOMBRE.TabIndex = 6
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Location = New System.Drawing.Point(121, 414)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(283, 30)
        Me.BTN_SAVE.TabIndex = 21
        Me.BTN_SAVE.Text = "GUARDAR CAMBIOS"
        Me.BTN_SAVE.UseVisualStyleBackColor = True
        '
        'BTN_CANCEL
        '
        Me.BTN_CANCEL.Location = New System.Drawing.Point(122, 450)
        Me.BTN_CANCEL.Name = "BTN_CANCEL"
        Me.BTN_CANCEL.Size = New System.Drawing.Size(282, 30)
        Me.BTN_CANCEL.TabIndex = 21
        Me.BTN_CANCEL.Text = "REGRESAR"
        Me.BTN_CANCEL.UseVisualStyleBackColor = True
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.TXT_CANTIDAD_RE)
        Me.GB1.Controls.Add(Me.TXT_PUNTO_RE)
        Me.GB1.Controls.Add(Me.TXT_STOCK)
        Me.GB1.Controls.Add(Me.TXT_PRECIO)
        Me.GB1.Controls.Add(Me.TXT_NUEVO_NOMBRE)
        Me.GB1.Controls.Add(Me.Label6)
        Me.GB1.Controls.Add(Me.Label5)
        Me.GB1.Controls.Add(Me.Label4)
        Me.GB1.Controls.Add(Me.Label8)
        Me.GB1.Controls.Add(Me.Label3)
        Me.GB1.Controls.Add(Me.Label10)
        Me.GB1.Controls.Add(Me.Label9)
        Me.GB1.Controls.Add(Me.CB_NuevaCategoria)
        Me.GB1.Location = New System.Drawing.Point(87, 177)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(346, 231)
        Me.GB1.TabIndex = 22
        Me.GB1.TabStop = False
        Me.GB1.Text = "DATOS ACTUALES DE PRODUCTO"
        '
        'ADMINISTRADOR_SET_PRODUCTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 503)
        Me.Controls.Add(Me.GB1)
        Me.Controls.Add(Me.BTN_CANCEL)
        Me.Controls.Add(Me.BTN_SAVE)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_CATEGO)
        Me.Name = "ADMINISTRADOR_SET_PRODUCTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDITAR PRODUCTO"
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_CANTIDAD_RE As TextBox
    Friend WithEvents TXT_PUNTO_RE As TextBox
    Friend WithEvents TXT_STOCK As TextBox
    Friend WithEvents TXT_PRECIO As TextBox
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_CATEGO As ComboBox
    Friend WithEvents BTN_BUSCAR As Button
    Friend WithEvents CB_NuevaCategoria As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_NUEVO_NOMBRE As TextBox
    Friend WithEvents BTN_SAVE As Button
    Friend WithEvents BTN_CANCEL As Button
    Friend WithEvents GB1 As GroupBox
End Class
