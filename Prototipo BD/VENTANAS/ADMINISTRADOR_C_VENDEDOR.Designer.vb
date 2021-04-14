<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMINISTRADOR_C_VENDEDOR
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
        Me.DG_VENDEDOR = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTP_FIN = New System.Windows.Forms.DateTimePicker()
        Me.DTP_INI = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMB_CATEGORIA = New System.Windows.Forms.ComboBox()
        Me.BTN_BACK = New System.Windows.Forms.Button()
        Me.BTN_CONSULTA = New System.Windows.Forms.Button()
        Me.DG_PROD = New System.Windows.Forms.DataGridView()
        Me.CMB_CAJA = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBL_PROD = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBL_TOT_COMISIONES = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBL_IVA = New System.Windows.Forms.Label()
        CType(Me.DG_VENDEDOR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_PROD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_VENDEDOR
        '
        Me.DG_VENDEDOR.AllowUserToAddRows = False
        Me.DG_VENDEDOR.AllowUserToDeleteRows = False
        Me.DG_VENDEDOR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_VENDEDOR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_VENDEDOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_VENDEDOR.Location = New System.Drawing.Point(36, 81)
        Me.DG_VENDEDOR.MultiSelect = False
        Me.DG_VENDEDOR.Name = "DG_VENDEDOR"
        Me.DG_VENDEDOR.ReadOnly = True
        Me.DG_VENDEDOR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_VENDEDOR.Size = New System.Drawing.Size(299, 111)
        Me.DG_VENDEDOR.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "VENDEDOR"
        '
        'DTP_FIN
        '
        Me.DTP_FIN.CustomFormat = "yyyy/MM/dd"
        Me.DTP_FIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FIN.Location = New System.Drawing.Point(146, 307)
        Me.DTP_FIN.MaxDate = New Date(2039, 12, 31, 0, 0, 0, 0)
        Me.DTP_FIN.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DTP_FIN.Name = "DTP_FIN"
        Me.DTP_FIN.Size = New System.Drawing.Size(133, 20)
        Me.DTP_FIN.TabIndex = 10
        Me.DTP_FIN.Value = New Date(2019, 5, 11, 0, 0, 0, 0)
        '
        'DTP_INI
        '
        Me.DTP_INI.CustomFormat = "yyyy/MM/dd"
        Me.DTP_INI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_INI.Location = New System.Drawing.Point(146, 277)
        Me.DTP_INI.MaxDate = New Date(2039, 12, 31, 0, 0, 0, 0)
        Me.DTP_INI.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DTP_INI.Name = "DTP_INI"
        Me.DTP_INI.Size = New System.Drawing.Size(133, 20)
        Me.DTP_INI.TabIndex = 9
        Me.DTP_INI.Value = New Date(2019, 5, 11, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "PRODUCTOS VENDIDOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "FECHA FIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "FECHA INCIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "CATEGORIA"
        '
        'CMB_CATEGORIA
        '
        Me.CMB_CATEGORIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_CATEGORIA.FormattingEnabled = True
        Me.CMB_CATEGORIA.Location = New System.Drawing.Point(146, 219)
        Me.CMB_CATEGORIA.Name = "CMB_CATEGORIA"
        Me.CMB_CATEGORIA.Size = New System.Drawing.Size(140, 21)
        Me.CMB_CATEGORIA.TabIndex = 8
        '
        'BTN_BACK
        '
        Me.BTN_BACK.Location = New System.Drawing.Point(371, 439)
        Me.BTN_BACK.Name = "BTN_BACK"
        Me.BTN_BACK.Size = New System.Drawing.Size(394, 33)
        Me.BTN_BACK.TabIndex = 18
        Me.BTN_BACK.Text = "REGRESAR"
        Me.BTN_BACK.UseVisualStyleBackColor = True
        '
        'BTN_CONSULTA
        '
        Me.BTN_CONSULTA.Location = New System.Drawing.Point(61, 341)
        Me.BTN_CONSULTA.Name = "BTN_CONSULTA"
        Me.BTN_CONSULTA.Size = New System.Drawing.Size(225, 26)
        Me.BTN_CONSULTA.TabIndex = 15
        Me.BTN_CONSULTA.Text = "CONSULTAR"
        Me.BTN_CONSULTA.UseVisualStyleBackColor = True
        '
        'DG_PROD
        '
        Me.DG_PROD.AllowUserToAddRows = False
        Me.DG_PROD.AllowUserToDeleteRows = False
        Me.DG_PROD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_PROD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_PROD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PROD.Location = New System.Drawing.Point(371, 81)
        Me.DG_PROD.MultiSelect = False
        Me.DG_PROD.Name = "DG_PROD"
        Me.DG_PROD.ReadOnly = True
        Me.DG_PROD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_PROD.Size = New System.Drawing.Size(394, 254)
        Me.DG_PROD.TabIndex = 17
        '
        'CMB_CAJA
        '
        Me.CMB_CAJA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_CAJA.FormattingEnabled = True
        Me.CMB_CAJA.Location = New System.Drawing.Point(146, 248)
        Me.CMB_CAJA.Name = "CMB_CAJA"
        Me.CMB_CAJA.Size = New System.Drawing.Size(140, 21)
        Me.CMB_CAJA.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "CAJA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(379, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "PRODUCTOS VENDIDOS"
        '
        'LBL_PROD
        '
        Me.LBL_PROD.AutoSize = True
        Me.LBL_PROD.Location = New System.Drawing.Point(519, 354)
        Me.LBL_PROD.Name = "LBL_PROD"
        Me.LBL_PROD.Size = New System.Drawing.Size(13, 13)
        Me.LBL_PROD.TabIndex = 19
        Me.LBL_PROD.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(439, 406)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "COMISIONES"
        '
        'LBL_TOT_COMISIONES
        '
        Me.LBL_TOT_COMISIONES.AutoSize = True
        Me.LBL_TOT_COMISIONES.Location = New System.Drawing.Point(519, 406)
        Me.LBL_TOT_COMISIONES.Name = "LBL_TOT_COMISIONES"
        Me.LBL_TOT_COMISIONES.Size = New System.Drawing.Size(13, 13)
        Me.LBL_TOT_COMISIONES.TabIndex = 19
        Me.LBL_TOT_COMISIONES.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(336, 381)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "TOTAL VENDIDO EN CATEGORIA"
        '
        'LBL_IVA
        '
        Me.LBL_IVA.AutoSize = True
        Me.LBL_IVA.Location = New System.Drawing.Point(519, 381)
        Me.LBL_IVA.Name = "LBL_IVA"
        Me.LBL_IVA.Size = New System.Drawing.Size(13, 13)
        Me.LBL_IVA.TabIndex = 19
        Me.LBL_IVA.Text = "0"
        '
        'ADMINISTRADOR_C_VENDEDOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBL_TOT_COMISIONES)
        Me.Controls.Add(Me.LBL_IVA)
        Me.Controls.Add(Me.LBL_PROD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DG_VENDEDOR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTP_FIN)
        Me.Controls.Add(Me.DTP_INI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CMB_CAJA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMB_CATEGORIA)
        Me.Controls.Add(Me.BTN_BACK)
        Me.Controls.Add(Me.BTN_CONSULTA)
        Me.Controls.Add(Me.DG_PROD)
        Me.Name = "ADMINISTRADOR_C_VENDEDOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTAS DE VENDEDOR"
        CType(Me.DG_VENDEDOR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_PROD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DG_VENDEDOR As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents DTP_FIN As DateTimePicker
    Friend WithEvents DTP_INI As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CMB_CATEGORIA As ComboBox
    Friend WithEvents BTN_BACK As Button
    Friend WithEvents BTN_CONSULTA As Button
    Friend WithEvents DG_PROD As DataGridView
    Friend WithEvents CMB_CAJA As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBL_PROD As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LBL_TOT_COMISIONES As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LBL_IVA As Label
End Class
