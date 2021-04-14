<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONSULTA_FACTURAS
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
        Me.DG_V = New System.Windows.Forms.DataGridView()
        Me.BTN_CONSULTA = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RB_COMPRA = New System.Windows.Forms.RadioButton()
        Me.RB_DEVO = New System.Windows.Forms.RadioButton()
        Me.DTP_FI = New System.Windows.Forms.DateTimePicker()
        Me.DTP_FF = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBL_NUMERO = New System.Windows.Forms.Label()
        Me.LBL_GAN = New System.Windows.Forms.Label()
        Me.LBL_GAN_NUMERO = New System.Windows.Forms.Label()
        CType(Me.DG_V, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_V
        '
        Me.DG_V.AllowUserToAddRows = False
        Me.DG_V.AllowUserToDeleteRows = False
        Me.DG_V.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_V.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_V.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DG_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_V.Location = New System.Drawing.Point(36, 110)
        Me.DG_V.MultiSelect = False
        Me.DG_V.Name = "DG_V"
        Me.DG_V.ReadOnly = True
        Me.DG_V.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DG_V.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_V.Size = New System.Drawing.Size(729, 271)
        Me.DG_V.TabIndex = 0
        '
        'BTN_CONSULTA
        '
        Me.BTN_CONSULTA.Location = New System.Drawing.Point(595, 37)
        Me.BTN_CONSULTA.Name = "BTN_CONSULTA"
        Me.BTN_CONSULTA.Size = New System.Drawing.Size(170, 31)
        Me.BTN_CONSULTA.TabIndex = 1
        Me.BTN_CONSULTA.Text = "CONSULTAR"
        Me.BTN_CONSULTA.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(155, 438)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(508, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "REGRESAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RB_COMPRA
        '
        Me.RB_COMPRA.AutoSize = True
        Me.RB_COMPRA.Location = New System.Drawing.Point(136, 44)
        Me.RB_COMPRA.Name = "RB_COMPRA"
        Me.RB_COMPRA.Size = New System.Drawing.Size(78, 17)
        Me.RB_COMPRA.TabIndex = 2
        Me.RB_COMPRA.TabStop = True
        Me.RB_COMPRA.Text = "COMPRAS"
        Me.RB_COMPRA.UseVisualStyleBackColor = True
        '
        'RB_DEVO
        '
        Me.RB_DEVO.AutoSize = True
        Me.RB_DEVO.Location = New System.Drawing.Point(234, 44)
        Me.RB_DEVO.Name = "RB_DEVO"
        Me.RB_DEVO.Size = New System.Drawing.Size(109, 17)
        Me.RB_DEVO.TabIndex = 2
        Me.RB_DEVO.TabStop = True
        Me.RB_DEVO.Text = "DEVOLUCIONES"
        Me.RB_DEVO.UseVisualStyleBackColor = True
        '
        'DTP_FI
        '
        Me.DTP_FI.CustomFormat = "yyyy/MM/dd"
        Me.DTP_FI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FI.Location = New System.Drawing.Point(463, 42)
        Me.DTP_FI.MaxDate = New Date(2039, 12, 31, 0, 0, 0, 0)
        Me.DTP_FI.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DTP_FI.Name = "DTP_FI"
        Me.DTP_FI.Size = New System.Drawing.Size(117, 20)
        Me.DTP_FI.TabIndex = 3
        Me.DTP_FI.Value = New Date(2019, 5, 9, 0, 0, 0, 0)
        '
        'DTP_FF
        '
        Me.DTP_FF.CustomFormat = "yyyy/MM/dd"
        Me.DTP_FF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FF.Location = New System.Drawing.Point(463, 68)
        Me.DTP_FF.MaxDate = New Date(2039, 12, 31, 0, 0, 0, 0)
        Me.DTP_FF.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DTP_FF.Name = "DTP_FF"
        Me.DTP_FF.Size = New System.Drawing.Size(117, 20)
        Me.DTP_FF.TabIndex = 3
        Me.DTP_FF.Value = New Date(2019, 5, 9, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FECHA INICIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(390, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "FECHA FIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CONSULTAR:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 406)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CANTIDAD DE ELEMENTOS:"
        '
        'LBL_NUMERO
        '
        Me.LBL_NUMERO.AutoSize = True
        Me.LBL_NUMERO.Location = New System.Drawing.Point(226, 406)
        Me.LBL_NUMERO.Name = "LBL_NUMERO"
        Me.LBL_NUMERO.Size = New System.Drawing.Size(13, 13)
        Me.LBL_NUMERO.TabIndex = 5
        Me.LBL_NUMERO.Text = "0"
        '
        'LBL_GAN
        '
        Me.LBL_GAN.AutoSize = True
        Me.LBL_GAN.Location = New System.Drawing.Point(592, 406)
        Me.LBL_GAN.Name = "LBL_GAN"
        Me.LBL_GAN.Size = New System.Drawing.Size(72, 13)
        Me.LBL_GAN.TabIndex = 6
        Me.LBL_GAN.Text = "GANANCIAS:"
        '
        'LBL_GAN_NUMERO
        '
        Me.LBL_GAN_NUMERO.AutoSize = True
        Me.LBL_GAN_NUMERO.Location = New System.Drawing.Point(670, 406)
        Me.LBL_GAN_NUMERO.Name = "LBL_GAN_NUMERO"
        Me.LBL_GAN_NUMERO.Size = New System.Drawing.Size(13, 13)
        Me.LBL_GAN_NUMERO.TabIndex = 7
        Me.LBL_GAN_NUMERO.Text = "0"
        '
        'CONSULTA_FACTURAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 481)
        Me.Controls.Add(Me.LBL_GAN_NUMERO)
        Me.Controls.Add(Me.LBL_GAN)
        Me.Controls.Add(Me.LBL_NUMERO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTP_FF)
        Me.Controls.Add(Me.DTP_FI)
        Me.Controls.Add(Me.RB_DEVO)
        Me.Controls.Add(Me.RB_COMPRA)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTN_CONSULTA)
        Me.Controls.Add(Me.DG_V)
        Me.Name = "CONSULTA_FACTURAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA FACTURAS"
        CType(Me.DG_V, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DG_V As DataGridView
    Friend WithEvents BTN_CONSULTA As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RB_COMPRA As RadioButton
    Friend WithEvents RB_DEVO As RadioButton
    Friend WithEvents DTP_FI As DateTimePicker
    Friend WithEvents DTP_FF As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LBL_NUMERO As Label
    Friend WithEvents LBL_GAN As Label
    Friend WithEvents LBL_GAN_NUMERO As Label
End Class
