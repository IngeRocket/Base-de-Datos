<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMINISTRADOR_TOTALES
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RB_V = New System.Windows.Forms.RadioButton()
        Me.RB_C = New System.Windows.Forms.RadioButton()
        Me.DG_PERSONA = New System.Windows.Forms.DataGridView()
        Me.BTN_VOLVER = New System.Windows.Forms.Button()
        Me.DTP_FIN = New System.Windows.Forms.DateTimePicker()
        Me.DTP_INI = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_NUMERO = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBL_SUBT = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBL_IVA = New System.Windows.Forms.Label()
        Me.DG_HISTORIA = New System.Windows.Forms.DataGridView()
        Me.BTN_LLENAR = New System.Windows.Forms.Button()
        CType(Me.DG_PERSONA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_HISTORIA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(232, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "LLENAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RB_V
        '
        Me.RB_V.AutoSize = True
        Me.RB_V.Location = New System.Drawing.Point(13, 32)
        Me.RB_V.Name = "RB_V"
        Me.RB_V.Size = New System.Drawing.Size(86, 17)
        Me.RB_V.TabIndex = 1
        Me.RB_V.TabStop = True
        Me.RB_V.Text = "VENDEDOR"
        Me.RB_V.UseVisualStyleBackColor = True
        '
        'RB_C
        '
        Me.RB_C.AutoSize = True
        Me.RB_C.Location = New System.Drawing.Point(127, 32)
        Me.RB_C.Name = "RB_C"
        Me.RB_C.Size = New System.Drawing.Size(70, 17)
        Me.RB_C.TabIndex = 1
        Me.RB_C.TabStop = True
        Me.RB_C.Text = "CLIENTE"
        Me.RB_C.UseVisualStyleBackColor = True
        '
        'DG_PERSONA
        '
        Me.DG_PERSONA.AllowUserToAddRows = False
        Me.DG_PERSONA.AllowUserToDeleteRows = False
        Me.DG_PERSONA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_PERSONA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_PERSONA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PERSONA.Location = New System.Drawing.Point(13, 92)
        Me.DG_PERSONA.MultiSelect = False
        Me.DG_PERSONA.Name = "DG_PERSONA"
        Me.DG_PERSONA.ReadOnly = True
        Me.DG_PERSONA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_PERSONA.Size = New System.Drawing.Size(327, 179)
        Me.DG_PERSONA.TabIndex = 2
        '
        'BTN_VOLVER
        '
        Me.BTN_VOLVER.Location = New System.Drawing.Point(390, 399)
        Me.BTN_VOLVER.Name = "BTN_VOLVER"
        Me.BTN_VOLVER.Size = New System.Drawing.Size(378, 39)
        Me.BTN_VOLVER.TabIndex = 3
        Me.BTN_VOLVER.Text = "REGRESAR"
        Me.BTN_VOLVER.UseVisualStyleBackColor = True
        '
        'DTP_FIN
        '
        Me.DTP_FIN.CustomFormat = "yyyy/MM/dd"
        Me.DTP_FIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FIN.Location = New System.Drawing.Point(161, 324)
        Me.DTP_FIN.MaxDate = New Date(2039, 12, 31, 0, 0, 0, 0)
        Me.DTP_FIN.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DTP_FIN.Name = "DTP_FIN"
        Me.DTP_FIN.Size = New System.Drawing.Size(133, 20)
        Me.DTP_FIN.TabIndex = 15
        Me.DTP_FIN.Value = New Date(2019, 5, 11, 0, 0, 0, 0)
        '
        'DTP_INI
        '
        Me.DTP_INI.CustomFormat = "yyyy/MM/dd"
        Me.DTP_INI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_INI.Location = New System.Drawing.Point(161, 294)
        Me.DTP_INI.MaxDate = New Date(2039, 12, 31, 0, 0, 0, 0)
        Me.DTP_INI.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DTP_INI.Name = "DTP_INI"
        Me.DTP_INI.Size = New System.Drawing.Size(133, 20)
        Me.DTP_INI.TabIndex = 14
        Me.DTP_INI.Value = New Date(2019, 5, 11, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "FECHA FIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "FECHA INCIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(505, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "# VENTAS/COMPRAS:"
        '
        'LBL_NUMERO
        '
        Me.LBL_NUMERO.AutoSize = True
        Me.LBL_NUMERO.Location = New System.Drawing.Point(635, 303)
        Me.LBL_NUMERO.Name = "LBL_NUMERO"
        Me.LBL_NUMERO.Size = New System.Drawing.Size(13, 13)
        Me.LBL_NUMERO.TabIndex = 18
        Me.LBL_NUMERO.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(559, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "SUBTOTAL:"
        '
        'LBL_SUBT
        '
        Me.LBL_SUBT.AutoSize = True
        Me.LBL_SUBT.Location = New System.Drawing.Point(635, 328)
        Me.LBL_SUBT.Name = "LBL_SUBT"
        Me.LBL_SUBT.Size = New System.Drawing.Size(13, 13)
        Me.LBL_SUBT.TabIndex = 18
        Me.LBL_SUBT.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(552, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "TOTAL + IVA:"
        '
        'LBL_IVA
        '
        Me.LBL_IVA.AutoSize = True
        Me.LBL_IVA.Location = New System.Drawing.Point(635, 353)
        Me.LBL_IVA.Name = "LBL_IVA"
        Me.LBL_IVA.Size = New System.Drawing.Size(13, 13)
        Me.LBL_IVA.TabIndex = 18
        Me.LBL_IVA.Text = "0"
        '
        'DG_HISTORIA
        '
        Me.DG_HISTORIA.AllowUserToAddRows = False
        Me.DG_HISTORIA.AllowUserToDeleteRows = False
        Me.DG_HISTORIA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_HISTORIA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_HISTORIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_HISTORIA.Location = New System.Drawing.Point(390, 92)
        Me.DG_HISTORIA.MultiSelect = False
        Me.DG_HISTORIA.Name = "DG_HISTORIA"
        Me.DG_HISTORIA.ReadOnly = True
        Me.DG_HISTORIA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_HISTORIA.Size = New System.Drawing.Size(378, 179)
        Me.DG_HISTORIA.TabIndex = 2
        '
        'BTN_LLENAR
        '
        Me.BTN_LLENAR.Location = New System.Drawing.Point(13, 357)
        Me.BTN_LLENAR.Name = "BTN_LLENAR"
        Me.BTN_LLENAR.Size = New System.Drawing.Size(327, 39)
        Me.BTN_LLENAR.TabIndex = 3
        Me.BTN_LLENAR.Text = "CONSULTAR"
        Me.BTN_LLENAR.UseVisualStyleBackColor = True
        '
        'ADMINISTRADOR_TOTALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 459)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBL_IVA)
        Me.Controls.Add(Me.LBL_SUBT)
        Me.Controls.Add(Me.LBL_NUMERO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTP_FIN)
        Me.Controls.Add(Me.DTP_INI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTN_LLENAR)
        Me.Controls.Add(Me.BTN_VOLVER)
        Me.Controls.Add(Me.DG_HISTORIA)
        Me.Controls.Add(Me.DG_PERSONA)
        Me.Controls.Add(Me.RB_C)
        Me.Controls.Add(Me.RB_V)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ADMINISTRADOR_TOTALES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORIAL DE GANANCIAS"
        CType(Me.DG_PERSONA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_HISTORIA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents RB_V As RadioButton
    Friend WithEvents RB_C As RadioButton
    Friend WithEvents DG_PERSONA As DataGridView
    Friend WithEvents BTN_VOLVER As Button
    Friend WithEvents DTP_FIN As DateTimePicker
    Friend WithEvents DTP_INI As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_NUMERO As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBL_SUBT As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBL_IVA As Label
    Friend WithEvents DG_HISTORIA As DataGridView
    Friend WithEvents BTN_LLENAR As Button
End Class
