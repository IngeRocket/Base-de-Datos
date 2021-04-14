<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMINISTRADOR_C_CLIENTE
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
        Me.DG_PROD = New System.Windows.Forms.DataGridView()
        Me.BTN_CONSULTA = New System.Windows.Forms.Button()
        Me.BTN_BACK = New System.Windows.Forms.Button()
        Me.CMB_CATEGORIA = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTP_INI = New System.Windows.Forms.DateTimePicker()
        Me.DTP_FIN = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DG_CLIENTE = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBL_COMPRAS = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBL_PROD = New System.Windows.Forms.Label()
        CType(Me.DG_PROD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_CLIENTE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_PROD
        '
        Me.DG_PROD.AllowUserToAddRows = False
        Me.DG_PROD.AllowUserToDeleteRows = False
        Me.DG_PROD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PROD.Location = New System.Drawing.Point(358, 91)
        Me.DG_PROD.MultiSelect = False
        Me.DG_PROD.Name = "DG_PROD"
        Me.DG_PROD.ReadOnly = True
        Me.DG_PROD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_PROD.Size = New System.Drawing.Size(394, 254)
        Me.DG_PROD.TabIndex = 5
        '
        'BTN_CONSULTA
        '
        Me.BTN_CONSULTA.Location = New System.Drawing.Point(48, 351)
        Me.BTN_CONSULTA.Name = "BTN_CONSULTA"
        Me.BTN_CONSULTA.Size = New System.Drawing.Size(225, 26)
        Me.BTN_CONSULTA.TabIndex = 4
        Me.BTN_CONSULTA.Text = "CONSULTAR"
        Me.BTN_CONSULTA.UseVisualStyleBackColor = True
        '
        'BTN_BACK
        '
        Me.BTN_BACK.Location = New System.Drawing.Point(360, 395)
        Me.BTN_BACK.Name = "BTN_BACK"
        Me.BTN_BACK.Size = New System.Drawing.Size(391, 43)
        Me.BTN_BACK.TabIndex = 6
        Me.BTN_BACK.Text = "REGRESAR"
        Me.BTN_BACK.UseVisualStyleBackColor = True
        '
        'CMB_CATEGORIA
        '
        Me.CMB_CATEGORIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_CATEGORIA.FormattingEnabled = True
        Me.CMB_CATEGORIA.Location = New System.Drawing.Point(133, 227)
        Me.CMB_CATEGORIA.Name = "CMB_CATEGORIA"
        Me.CMB_CATEGORIA.Size = New System.Drawing.Size(140, 21)
        Me.CMB_CATEGORIA.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CATEGORIA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(358, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PRODUCTOS ADQUIRIDOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "FECHA INICIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "FECHA FIN"
        '
        'DTP_INI
        '
        Me.DTP_INI.CustomFormat = "yyyy/MM/dd"
        Me.DTP_INI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_INI.Location = New System.Drawing.Point(133, 271)
        Me.DTP_INI.MaxDate = New Date(2039, 12, 31, 0, 0, 0, 0)
        Me.DTP_INI.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DTP_INI.Name = "DTP_INI"
        Me.DTP_INI.Size = New System.Drawing.Size(133, 20)
        Me.DTP_INI.TabIndex = 2
        Me.DTP_INI.Value = New Date(2019, 5, 11, 0, 0, 0, 0)
        '
        'DTP_FIN
        '
        Me.DTP_FIN.CustomFormat = "yyyy/MM/dd"
        Me.DTP_FIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FIN.Location = New System.Drawing.Point(133, 301)
        Me.DTP_FIN.MaxDate = New Date(2039, 12, 31, 0, 0, 0, 0)
        Me.DTP_FIN.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DTP_FIN.Name = "DTP_FIN"
        Me.DTP_FIN.Size = New System.Drawing.Size(133, 20)
        Me.DTP_FIN.TabIndex = 3
        Me.DTP_FIN.Value = New Date(2019, 5, 11, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "CLIENTE"
        '
        'DG_CLIENTE
        '
        Me.DG_CLIENTE.AllowUserToAddRows = False
        Me.DG_CLIENTE.AllowUserToDeleteRows = False
        Me.DG_CLIENTE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_CLIENTE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_CLIENTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_CLIENTE.Location = New System.Drawing.Point(23, 91)
        Me.DG_CLIENTE.MultiSelect = False
        Me.DG_CLIENTE.Name = "DG_CLIENTE"
        Me.DG_CLIENTE.ReadOnly = True
        Me.DG_CLIENTE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_CLIENTE.Size = New System.Drawing.Size(299, 111)
        Me.DG_CLIENTE.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(355, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "GASTO EN COMPRAS:"
        '
        'LBL_COMPRAS
        '
        Me.LBL_COMPRAS.AutoSize = True
        Me.LBL_COMPRAS.Location = New System.Drawing.Point(479, 358)
        Me.LBL_COMPRAS.Name = "LBL_COMPRAS"
        Me.LBL_COMPRAS.Size = New System.Drawing.Size(13, 13)
        Me.LBL_COMPRAS.TabIndex = 7
        Me.LBL_COMPRAS.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(546, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "PRODUCTOS COMPRADOS:"
        '
        'LBL_PROD
        '
        Me.LBL_PROD.AutoSize = True
        Me.LBL_PROD.Location = New System.Drawing.Point(702, 358)
        Me.LBL_PROD.Name = "LBL_PROD"
        Me.LBL_PROD.Size = New System.Drawing.Size(13, 13)
        Me.LBL_PROD.TabIndex = 7
        Me.LBL_PROD.Text = "0"
        '
        'ADMINISTRADOR_C_CLIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBL_PROD)
        Me.Controls.Add(Me.LBL_COMPRAS)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DG_CLIENTE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTP_FIN)
        Me.Controls.Add(Me.DTP_INI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMB_CATEGORIA)
        Me.Controls.Add(Me.BTN_BACK)
        Me.Controls.Add(Me.BTN_CONSULTA)
        Me.Controls.Add(Me.DG_PROD)
        Me.Name = "ADMINISTRADOR_C_CLIENTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTAS DE CLIENTE"
        CType(Me.DG_PROD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_CLIENTE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DG_PROD As DataGridView
    Friend WithEvents BTN_CONSULTA As Button
    Friend WithEvents BTN_BACK As Button
    Friend WithEvents CMB_CATEGORIA As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DTP_INI As DateTimePicker
    Friend WithEvents DTP_FIN As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DG_CLIENTE As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents LBL_COMPRAS As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBL_PROD As Label
End Class
