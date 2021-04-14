<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENDEDOR_EDITAR
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
        Me.TXT_C2 = New System.Windows.Forms.TextBox()
        Me.TXT_C1 = New System.Windows.Forms.TextBox()
        Me.BTN_ATRAS = New System.Windows.Forms.Button()
        Me.BTN_ADD = New System.Windows.Forms.Button()
        Me.BTN_VALIDA = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LB_RFC = New System.Windows.Forms.Label()
        Me.LB_NOMBRE = New System.Windows.Forms.Label()
        Me.LB_CURP = New System.Windows.Forms.Label()
        Me.LB_NOMINA = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXT_C2
        '
        Me.TXT_C2.Location = New System.Drawing.Point(141, 150)
        Me.TXT_C2.MaxLength = 15
        Me.TXT_C2.Name = "TXT_C2"
        Me.TXT_C2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(38)
        Me.TXT_C2.Size = New System.Drawing.Size(175, 20)
        Me.TXT_C2.TabIndex = 27
        '
        'TXT_C1
        '
        Me.TXT_C1.Location = New System.Drawing.Point(141, 117)
        Me.TXT_C1.MaxLength = 15
        Me.TXT_C1.Name = "TXT_C1"
        Me.TXT_C1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(38)
        Me.TXT_C1.Size = New System.Drawing.Size(175, 20)
        Me.TXT_C1.TabIndex = 26
        '
        'BTN_ATRAS
        '
        Me.BTN_ATRAS.Location = New System.Drawing.Point(260, 253)
        Me.BTN_ATRAS.Name = "BTN_ATRAS"
        Me.BTN_ATRAS.Size = New System.Drawing.Size(128, 30)
        Me.BTN_ATRAS.TabIndex = 31
        Me.BTN_ATRAS.Text = "REGRESAR"
        Me.BTN_ATRAS.UseVisualStyleBackColor = True
        '
        'BTN_ADD
        '
        Me.BTN_ADD.Location = New System.Drawing.Point(104, 253)
        Me.BTN_ADD.Name = "BTN_ADD"
        Me.BTN_ADD.Size = New System.Drawing.Size(128, 30)
        Me.BTN_ADD.TabIndex = 30
        Me.BTN_ADD.Text = "AGREGAR"
        Me.BTN_ADD.UseVisualStyleBackColor = True
        '
        'BTN_VALIDA
        '
        Me.BTN_VALIDA.Location = New System.Drawing.Point(336, 153)
        Me.BTN_VALIDA.Name = "BTN_VALIDA"
        Me.BTN_VALIDA.Size = New System.Drawing.Size(108, 20)
        Me.BTN_VALIDA.TabIndex = 29
        Me.BTN_VALIDA.Text = "VALIDAR"
        Me.BTN_VALIDA.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "No. Nomina"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Repetir Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Constraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "CURP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "RFC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre"
        '
        'LB_RFC
        '
        Me.LB_RFC.AutoSize = True
        Me.LB_RFC.Location = New System.Drawing.Point(138, 58)
        Me.LB_RFC.Name = "LB_RFC"
        Me.LB_RFC.Size = New System.Drawing.Size(62, 13)
        Me.LB_RFC.TabIndex = 16
        Me.LB_RFC.Text = "CLAVERFC"
        '
        'LB_NOMBRE
        '
        Me.LB_NOMBRE.AutoSize = True
        Me.LB_NOMBRE.Location = New System.Drawing.Point(138, 26)
        Me.LB_NOMBRE.Name = "LB_NOMBRE"
        Me.LB_NOMBRE.Size = New System.Drawing.Size(119, 13)
        Me.LB_NOMBRE.TabIndex = 16
        Me.LB_NOMBRE.Text = "NOMBRE_COMPLETO"
        '
        'LB_CURP
        '
        Me.LB_CURP.AutoSize = True
        Me.LB_CURP.Location = New System.Drawing.Point(138, 88)
        Me.LB_CURP.Name = "LB_CURP"
        Me.LB_CURP.Size = New System.Drawing.Size(37, 13)
        Me.LB_CURP.TabIndex = 20
        Me.LB_CURP.Text = "CURP"
        '
        'LB_NOMINA
        '
        Me.LB_NOMINA.AutoSize = True
        Me.LB_NOMINA.Location = New System.Drawing.Point(138, 190)
        Me.LB_NOMINA.Name = "LB_NOMINA"
        Me.LB_NOMINA.Size = New System.Drawing.Size(63, 13)
        Me.LB_NOMINA.TabIndex = 17
        Me.LB_NOMINA.Text = "No. Nomina"
        '
        'VENDEDOR_EDITAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 323)
        Me.ControlBox = False
        Me.Controls.Add(Me.TXT_C2)
        Me.Controls.Add(Me.TXT_C1)
        Me.Controls.Add(Me.BTN_ATRAS)
        Me.Controls.Add(Me.BTN_ADD)
        Me.Controls.Add(Me.BTN_VALIDA)
        Me.Controls.Add(Me.LB_NOMINA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LB_NOMBRE)
        Me.Controls.Add(Me.LB_CURP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LB_RFC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VENDEDOR_EDITAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDITAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_C2 As TextBox
    Friend WithEvents TXT_C1 As TextBox
    Friend WithEvents BTN_ATRAS As Button
    Friend WithEvents BTN_ADD As Button
    Friend WithEvents BTN_VALIDA As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LB_RFC As Label
    Friend WithEvents LB_NOMBRE As Label
    Friend WithEvents LB_CURP As Label
    Friend WithEvents LB_NOMINA As Label
End Class
