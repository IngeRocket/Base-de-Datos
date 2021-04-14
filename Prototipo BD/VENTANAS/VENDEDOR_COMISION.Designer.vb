<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VENDEDOR_COMISION
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
        Me.DTP_ORIGEN = New System.Windows.Forms.DateTimePicker()
        Me.DTP_FIN = New System.Windows.Forms.DateTimePicker()
        Me.DG_VENTAS = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_CREDITO = New System.Windows.Forms.Label()
        Me.LBL_VENTAS = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LB_NOMBRE = New System.Windows.Forms.Label()
        Me.CMB_CAJA = New System.Windows.Forms.ComboBox()
        CType(Me.DG_VENTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTP_ORIGEN
        '
        Me.DTP_ORIGEN.CustomFormat = "yyyy/MM/dd"
        Me.DTP_ORIGEN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_ORIGEN.Location = New System.Drawing.Point(117, 42)
        Me.DTP_ORIGEN.MaxDate = New Date(2039, 12, 31, 0, 0, 0, 0)
        Me.DTP_ORIGEN.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DTP_ORIGEN.Name = "DTP_ORIGEN"
        Me.DTP_ORIGEN.Size = New System.Drawing.Size(107, 20)
        Me.DTP_ORIGEN.TabIndex = 0
        Me.DTP_ORIGEN.Value = New Date(2019, 5, 1, 0, 0, 0, 0)
        '
        'DTP_FIN
        '
        Me.DTP_FIN.CustomFormat = "yyyy/MM/dd"
        Me.DTP_FIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FIN.Location = New System.Drawing.Point(424, 42)
        Me.DTP_FIN.MaxDate = New Date(2039, 12, 31, 0, 0, 0, 0)
        Me.DTP_FIN.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DTP_FIN.Name = "DTP_FIN"
        Me.DTP_FIN.Size = New System.Drawing.Size(107, 20)
        Me.DTP_FIN.TabIndex = 1
        Me.DTP_FIN.Value = New Date(2019, 5, 1, 0, 0, 0, 0)
        '
        'DG_VENTAS
        '
        Me.DG_VENTAS.AllowUserToAddRows = False
        Me.DG_VENTAS.AllowUserToDeleteRows = False
        Me.DG_VENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_VENTAS.Location = New System.Drawing.Point(40, 68)
        Me.DG_VENTAS.MultiSelect = False
        Me.DG_VENTAS.Name = "DG_VENTAS"
        Me.DG_VENTAS.ReadOnly = True
        Me.DG_VENTAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_VENTAS.Size = New System.Drawing.Size(560, 248)
        Me.DG_VENTAS.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(646, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TOTAL EN COMISIONES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(620, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "# VENTAS EN RANGO DE FECHAS"
        '
        'LBL_CREDITO
        '
        Me.LBL_CREDITO.AutoSize = True
        Me.LBL_CREDITO.Location = New System.Drawing.Point(646, 233)
        Me.LBL_CREDITO.Name = "LBL_CREDITO"
        Me.LBL_CREDITO.Size = New System.Drawing.Size(31, 13)
        Me.LBL_CREDITO.TabIndex = 2
        Me.LBL_CREDITO.Text = "1000"
        '
        'LBL_VENTAS
        '
        Me.LBL_VENTAS.AutoSize = True
        Me.LBL_VENTAS.Location = New System.Drawing.Point(696, 302)
        Me.LBL_VENTAS.Name = "LBL_VENTAS"
        Me.LBL_VENTAS.Size = New System.Drawing.Size(31, 13)
        Me.LBL_VENTAS.TabIndex = 2
        Me.LBL_VENTAS.Text = "1000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(745, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "MXN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "INICIO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(394, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "FIN"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(623, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(508, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(284, 31)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "REGRESAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "VENDEDOR:"
        '
        'LB_NOMBRE
        '
        Me.LB_NOMBRE.AutoSize = True
        Me.LB_NOMBRE.Location = New System.Drawing.Point(89, 376)
        Me.LB_NOMBRE.Name = "LB_NOMBRE"
        Me.LB_NOMBRE.Size = New System.Drawing.Size(54, 13)
        Me.LB_NOMBRE.TabIndex = 3
        Me.LB_NOMBRE.Text = "NOMBRE"
        '
        'CMB_CAJA
        '
        Me.CMB_CAJA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_CAJA.FormattingEnabled = True
        Me.CMB_CAJA.Location = New System.Drawing.Point(624, 73)
        Me.CMB_CAJA.Name = "CMB_CAJA"
        Me.CMB_CAJA.Size = New System.Drawing.Size(167, 21)
        Me.CMB_CAJA.TabIndex = 2
        '
        'VENDEDOR_COMISION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 419)
        Me.ControlBox = False
        Me.Controls.Add(Me.CMB_CAJA)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LB_NOMBRE)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBL_VENTAS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LBL_CREDITO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DG_VENTAS)
        Me.Controls.Add(Me.DTP_FIN)
        Me.Controls.Add(Me.DTP_ORIGEN)
        Me.Name = "VENDEDOR_COMISION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENDEDOR_COMISION"
        CType(Me.DG_VENTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTP_ORIGEN As DateTimePicker
    Friend WithEvents DTP_FIN As DateTimePicker
    Friend WithEvents DG_VENTAS As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LBL_CREDITO As Label
    Friend WithEvents LBL_VENTAS As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents LB_NOMBRE As Label
    Friend WithEvents CMB_CAJA As ComboBox
End Class
