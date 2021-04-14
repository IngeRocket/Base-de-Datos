<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGREGAR_PRODUCTO
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
        Me.BTN_ADD = New System.Windows.Forms.Button()
        Me.BTN_VOLVER = New System.Windows.Forms.Button()
        Me.CB_CATEGO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TXT_PRECIO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_STOCK = New System.Windows.Forms.TextBox()
        Me.TXT_PUNTO_RE = New System.Windows.Forms.TextBox()
        Me.TXT_CANTIDAD_RE = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTN_ADD
        '
        Me.BTN_ADD.Location = New System.Drawing.Point(87, 248)
        Me.BTN_ADD.Name = "BTN_ADD"
        Me.BTN_ADD.Size = New System.Drawing.Size(122, 31)
        Me.BTN_ADD.TabIndex = 6
        Me.BTN_ADD.Text = "AGREGAR"
        Me.BTN_ADD.UseVisualStyleBackColor = True
        '
        'BTN_VOLVER
        '
        Me.BTN_VOLVER.Location = New System.Drawing.Point(225, 248)
        Me.BTN_VOLVER.Name = "BTN_VOLVER"
        Me.BTN_VOLVER.Size = New System.Drawing.Size(122, 31)
        Me.BTN_VOLVER.TabIndex = 7
        Me.BTN_VOLVER.Text = "REGRESAR"
        Me.BTN_VOLVER.UseVisualStyleBackColor = True
        '
        'CB_CATEGO
        '
        Me.CB_CATEGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CATEGO.FormattingEnabled = True
        Me.CB_CATEGO.Location = New System.Drawing.Point(198, 71)
        Me.CB_CATEGO.Name = "CB_CATEGO"
        Me.CB_CATEGO.Size = New System.Drawing.Size(135, 21)
        Me.CB_CATEGO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre Articulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Punto de Reorden"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Cantidad de Reorden"
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(198, 37)
        Me.TXT_NOMBRE.MaxLength = 35
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(169, 20)
        Me.TXT_NOMBRE.TabIndex = 0
        '
        'TXT_PRECIO
        '
        Me.TXT_PRECIO.Location = New System.Drawing.Point(198, 105)
        Me.TXT_PRECIO.MaxLength = 6
        Me.TXT_PRECIO.Name = "TXT_PRECIO"
        Me.TXT_PRECIO.Size = New System.Drawing.Size(135, 20)
        Me.TXT_PRECIO.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(339, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "MXN"
        '
        'TXT_STOCK
        '
        Me.TXT_STOCK.Location = New System.Drawing.Point(198, 137)
        Me.TXT_STOCK.MaxLength = 4
        Me.TXT_STOCK.Name = "TXT_STOCK"
        Me.TXT_STOCK.Size = New System.Drawing.Size(78, 20)
        Me.TXT_STOCK.TabIndex = 3
        '
        'TXT_PUNTO_RE
        '
        Me.TXT_PUNTO_RE.Location = New System.Drawing.Point(198, 169)
        Me.TXT_PUNTO_RE.MaxLength = 4
        Me.TXT_PUNTO_RE.Name = "TXT_PUNTO_RE"
        Me.TXT_PUNTO_RE.Size = New System.Drawing.Size(78, 20)
        Me.TXT_PUNTO_RE.TabIndex = 4
        '
        'TXT_CANTIDAD_RE
        '
        Me.TXT_CANTIDAD_RE.Location = New System.Drawing.Point(198, 199)
        Me.TXT_CANTIDAD_RE.MaxLength = 4
        Me.TXT_CANTIDAD_RE.Name = "TXT_CANTIDAD_RE"
        Me.TXT_CANTIDAD_RE.Size = New System.Drawing.Size(78, 20)
        Me.TXT_CANTIDAD_RE.TabIndex = 5
        '
        'AGREGAR_PRODUCTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.TXT_CANTIDAD_RE)
        Me.Controls.Add(Me.TXT_PUNTO_RE)
        Me.Controls.Add(Me.TXT_STOCK)
        Me.Controls.Add(Me.TXT_PRECIO)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_CATEGO)
        Me.Controls.Add(Me.BTN_VOLVER)
        Me.Controls.Add(Me.BTN_ADD)
        Me.Name = "AGREGAR_PRODUCTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR PRODUCTO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_ADD As Button
    Friend WithEvents BTN_VOLVER As Button
    Friend WithEvents CB_CATEGO As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents TXT_PRECIO As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_STOCK As TextBox
    Friend WithEvents TXT_PUNTO_RE As TextBox
    Friend WithEvents TXT_CANTIDAD_RE As TextBox
End Class
