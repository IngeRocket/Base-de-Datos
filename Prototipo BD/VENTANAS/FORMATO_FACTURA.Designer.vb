<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMATO_FACTURA
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_BUSQUEDA = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BTN_VOLVER = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DG_DV = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LBL_NOMBRE = New System.Windows.Forms.Label()
        Me.LBL_DIR = New System.Windows.Forms.Label()
        Me.LBL_TEL = New System.Windows.Forms.Label()
        Me.LBL_CO = New System.Windows.Forms.Label()
        Me.LBL_VENDEDOR = New System.Windows.Forms.Label()
        Me.LBL_CAJA = New System.Windows.Forms.Label()
        Me.LBL_FORMA = New System.Windows.Forms.Label()
        Me.LBL_ARTI = New System.Windows.Forms.Label()
        Me.LBL_SUBT = New System.Windows.Forms.Label()
        Me.LBL_IVA = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBL_FECHA = New System.Windows.Forms.Label()
        CType(Me.DG_DV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "# VENTA"
        '
        'BTN_BUSQUEDA
        '
        Me.BTN_BUSQUEDA.Location = New System.Drawing.Point(282, 41)
        Me.BTN_BUSQUEDA.Name = "BTN_BUSQUEDA"
        Me.BTN_BUSQUEDA.Size = New System.Drawing.Size(126, 20)
        Me.BTN_BUSQUEDA.TabIndex = 1
        Me.BTN_BUSQUEDA.Text = "BUSCAR"
        Me.BTN_BUSQUEDA.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 41)
        Me.TextBox1.MaxLength = 13
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 0
        '
        'BTN_VOLVER
        '
        Me.BTN_VOLVER.Location = New System.Drawing.Point(650, 446)
        Me.BTN_VOLVER.Name = "BTN_VOLVER"
        Me.BTN_VOLVER.Size = New System.Drawing.Size(138, 33)
        Me.BTN_VOLVER.TabIndex = 2
        Me.BTN_VOLVER.Text = "REGRESAR"
        Me.BTN_VOLVER.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CLIENTE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "DIRECCION:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "TELEFONO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "CORREO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 408)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "SUBTOTAL:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 432)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "TOTAL + IVA:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(405, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "VENDEDOR:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(440, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "CAJA:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(382, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "FECHA COMPRA:"
        '
        'DG_DV
        '
        Me.DG_DV.AllowUserToAddRows = False
        Me.DG_DV.AllowUserToDeleteRows = False
        Me.DG_DV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_DV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_DV.Location = New System.Drawing.Point(78, 211)
        Me.DG_DV.MultiSelect = False
        Me.DG_DV.Name = "DG_DV"
        Me.DG_DV.ReadOnly = True
        Me.DG_DV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_DV.Size = New System.Drawing.Size(602, 173)
        Me.DG_DV.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(75, 195)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "DETALLE VENTA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(552, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "ARTICULOS:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(647, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "TIENDA: GIGANTE S.A C.V"
        '
        'LBL_NOMBRE
        '
        Me.LBL_NOMBRE.AutoSize = True
        Me.LBL_NOMBRE.Location = New System.Drawing.Point(103, 79)
        Me.LBL_NOMBRE.Name = "LBL_NOMBRE"
        Me.LBL_NOMBRE.Size = New System.Drawing.Size(39, 13)
        Me.LBL_NOMBRE.TabIndex = 6
        Me.LBL_NOMBRE.Text = "Label7"
        '
        'LBL_DIR
        '
        Me.LBL_DIR.AutoSize = True
        Me.LBL_DIR.Location = New System.Drawing.Point(103, 107)
        Me.LBL_DIR.Name = "LBL_DIR"
        Me.LBL_DIR.Size = New System.Drawing.Size(39, 13)
        Me.LBL_DIR.TabIndex = 6
        Me.LBL_DIR.Text = "Label7"
        '
        'LBL_TEL
        '
        Me.LBL_TEL.AutoSize = True
        Me.LBL_TEL.Location = New System.Drawing.Point(103, 135)
        Me.LBL_TEL.Name = "LBL_TEL"
        Me.LBL_TEL.Size = New System.Drawing.Size(39, 13)
        Me.LBL_TEL.TabIndex = 6
        Me.LBL_TEL.Text = "Label7"
        '
        'LBL_CO
        '
        Me.LBL_CO.AutoSize = True
        Me.LBL_CO.Location = New System.Drawing.Point(103, 165)
        Me.LBL_CO.Name = "LBL_CO"
        Me.LBL_CO.Size = New System.Drawing.Size(39, 13)
        Me.LBL_CO.TabIndex = 6
        Me.LBL_CO.Text = "Label7"
        '
        'LBL_VENDEDOR
        '
        Me.LBL_VENDEDOR.AutoSize = True
        Me.LBL_VENDEDOR.Location = New System.Drawing.Point(482, 79)
        Me.LBL_VENDEDOR.Name = "LBL_VENDEDOR"
        Me.LBL_VENDEDOR.Size = New System.Drawing.Size(39, 13)
        Me.LBL_VENDEDOR.TabIndex = 6
        Me.LBL_VENDEDOR.Text = "Label7"
        '
        'LBL_CAJA
        '
        Me.LBL_CAJA.AutoSize = True
        Me.LBL_CAJA.Location = New System.Drawing.Point(482, 107)
        Me.LBL_CAJA.Name = "LBL_CAJA"
        Me.LBL_CAJA.Size = New System.Drawing.Size(39, 13)
        Me.LBL_CAJA.TabIndex = 6
        Me.LBL_CAJA.Text = "Label7"
        '
        'LBL_FORMA
        '
        Me.LBL_FORMA.AutoSize = True
        Me.LBL_FORMA.Location = New System.Drawing.Point(482, 165)
        Me.LBL_FORMA.Name = "LBL_FORMA"
        Me.LBL_FORMA.Size = New System.Drawing.Size(13, 13)
        Me.LBL_FORMA.TabIndex = 6
        Me.LBL_FORMA.Text = "0"
        '
        'LBL_ARTI
        '
        Me.LBL_ARTI.AutoSize = True
        Me.LBL_ARTI.Location = New System.Drawing.Point(629, 195)
        Me.LBL_ARTI.Name = "LBL_ARTI"
        Me.LBL_ARTI.Size = New System.Drawing.Size(39, 13)
        Me.LBL_ARTI.TabIndex = 6
        Me.LBL_ARTI.Text = "Label7"
        '
        'LBL_SUBT
        '
        Me.LBL_SUBT.AutoSize = True
        Me.LBL_SUBT.Location = New System.Drawing.Point(148, 408)
        Me.LBL_SUBT.Name = "LBL_SUBT"
        Me.LBL_SUBT.Size = New System.Drawing.Size(39, 13)
        Me.LBL_SUBT.TabIndex = 6
        Me.LBL_SUBT.Text = "Label7"
        '
        'LBL_IVA
        '
        Me.LBL_IVA.AutoSize = True
        Me.LBL_IVA.Location = New System.Drawing.Point(148, 432)
        Me.LBL_IVA.Name = "LBL_IVA"
        Me.LBL_IVA.Size = New System.Drawing.Size(39, 13)
        Me.LBL_IVA.TabIndex = 6
        Me.LBL_IVA.Text = "Label7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(382, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "FORMA PAGO:"
        '
        'LBL_FECHA
        '
        Me.LBL_FECHA.AutoSize = True
        Me.LBL_FECHA.Location = New System.Drawing.Point(482, 135)
        Me.LBL_FECHA.Name = "LBL_FECHA"
        Me.LBL_FECHA.Size = New System.Drawing.Size(13, 13)
        Me.LBL_FECHA.TabIndex = 6
        Me.LBL_FECHA.Text = "0"
        '
        'FORMATO_FACTURA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBL_IVA)
        Me.Controls.Add(Me.LBL_SUBT)
        Me.Controls.Add(Me.LBL_ARTI)
        Me.Controls.Add(Me.LBL_FECHA)
        Me.Controls.Add(Me.LBL_FORMA)
        Me.Controls.Add(Me.LBL_CAJA)
        Me.Controls.Add(Me.LBL_VENDEDOR)
        Me.Controls.Add(Me.LBL_CO)
        Me.Controls.Add(Me.LBL_TEL)
        Me.Controls.Add(Me.LBL_DIR)
        Me.Controls.Add(Me.LBL_NOMBRE)
        Me.Controls.Add(Me.DG_DV)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTN_VOLVER)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BTN_BUSQUEDA)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FORMATO_FACTURA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMATO FACTURA"
        CType(Me.DG_DV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_BUSQUEDA As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BTN_VOLVER As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DG_DV As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LBL_NOMBRE As Label
    Friend WithEvents LBL_DIR As Label
    Friend WithEvents LBL_TEL As Label
    Friend WithEvents LBL_CO As Label
    Friend WithEvents LBL_VENDEDOR As Label
    Friend WithEvents LBL_CAJA As Label
    Friend WithEvents LBL_FORMA As Label
    Friend WithEvents LBL_ARTI As Label
    Friend WithEvents LBL_SUBT As Label
    Friend WithEvents LBL_IVA As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBL_FECHA As Label
End Class
