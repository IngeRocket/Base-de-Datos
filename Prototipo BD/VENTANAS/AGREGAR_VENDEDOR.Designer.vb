<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGREGAR_VENDEDOR
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTN_VALIDA_NOMINA = New System.Windows.Forms.Button()
        Me.BTN_ADD = New System.Windows.Forms.Button()
        Me.BTN_VOLVER = New System.Windows.Forms.Button()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TXT_AP = New System.Windows.Forms.TextBox()
        Me.TXT_AM = New System.Windows.Forms.TextBox()
        Me.TXT_RFC_V = New System.Windows.Forms.TextBox()
        Me.TXT_CURP = New System.Windows.Forms.TextBox()
        Me.TXT_C1 = New System.Windows.Forms.TextBox()
        Me.TXT_C2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_NOMINA = New System.Windows.Forms.TextBox()
        Me.BTN_VALIDA_RFC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Apellido Paterno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Apellido Materno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "RFC"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "CURP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Constraseña"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(94, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Repetir Contraseña"
        '
        'BTN_VALIDA_NOMINA
        '
        Me.BTN_VALIDA_NOMINA.Location = New System.Drawing.Point(403, 260)
        Me.BTN_VALIDA_NOMINA.Name = "BTN_VALIDA_NOMINA"
        Me.BTN_VALIDA_NOMINA.Size = New System.Drawing.Size(108, 20)
        Me.BTN_VALIDA_NOMINA.TabIndex = 9
        Me.BTN_VALIDA_NOMINA.Text = "VALIDAR"
        Me.BTN_VALIDA_NOMINA.UseVisualStyleBackColor = True
        '
        'BTN_ADD
        '
        Me.BTN_ADD.Location = New System.Drawing.Point(119, 322)
        Me.BTN_ADD.Name = "BTN_ADD"
        Me.BTN_ADD.Size = New System.Drawing.Size(128, 30)
        Me.BTN_ADD.TabIndex = 10
        Me.BTN_ADD.Text = "AGREGAR"
        Me.BTN_ADD.UseVisualStyleBackColor = True
        '
        'BTN_VOLVER
        '
        Me.BTN_VOLVER.Location = New System.Drawing.Point(275, 322)
        Me.BTN_VOLVER.Name = "BTN_VOLVER"
        Me.BTN_VOLVER.Size = New System.Drawing.Size(128, 30)
        Me.BTN_VOLVER.TabIndex = 11
        Me.BTN_VOLVER.Text = "REGRESAR"
        Me.BTN_VOLVER.UseVisualStyleBackColor = True
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(208, 31)
        Me.TXT_NOMBRE.MaxLength = 30
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(175, 20)
        Me.TXT_NOMBRE.TabIndex = 0
        '
        'TXT_AP
        '
        Me.TXT_AP.Location = New System.Drawing.Point(208, 63)
        Me.TXT_AP.MaxLength = 20
        Me.TXT_AP.Name = "TXT_AP"
        Me.TXT_AP.Size = New System.Drawing.Size(175, 20)
        Me.TXT_AP.TabIndex = 1
        '
        'TXT_AM
        '
        Me.TXT_AM.Location = New System.Drawing.Point(208, 95)
        Me.TXT_AM.MaxLength = 20
        Me.TXT_AM.Name = "TXT_AM"
        Me.TXT_AM.Size = New System.Drawing.Size(175, 20)
        Me.TXT_AM.TabIndex = 2
        '
        'TXT_RFC_V
        '
        Me.TXT_RFC_V.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_RFC_V.Location = New System.Drawing.Point(208, 129)
        Me.TXT_RFC_V.MaxLength = 13
        Me.TXT_RFC_V.Name = "TXT_RFC_V"
        Me.TXT_RFC_V.Size = New System.Drawing.Size(175, 20)
        Me.TXT_RFC_V.TabIndex = 3
        '
        'TXT_CURP
        '
        Me.TXT_CURP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CURP.Location = New System.Drawing.Point(208, 163)
        Me.TXT_CURP.MaxLength = 20
        Me.TXT_CURP.Name = "TXT_CURP"
        Me.TXT_CURP.Size = New System.Drawing.Size(175, 20)
        Me.TXT_CURP.TabIndex = 5
        '
        'TXT_C1
        '
        Me.TXT_C1.Location = New System.Drawing.Point(208, 194)
        Me.TXT_C1.MaxLength = 15
        Me.TXT_C1.Name = "TXT_C1"
        Me.TXT_C1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_C1.Size = New System.Drawing.Size(175, 20)
        Me.TXT_C1.TabIndex = 6
        '
        'TXT_C2
        '
        Me.TXT_C2.Location = New System.Drawing.Point(208, 227)
        Me.TXT_C2.MaxLength = 15
        Me.TXT_C2.Name = "TXT_C2"
        Me.TXT_C2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_C2.Size = New System.Drawing.Size(175, 20)
        Me.TXT_C2.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(94, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "No. Nomina"
        '
        'TXT_NOMINA
        '
        Me.TXT_NOMINA.Location = New System.Drawing.Point(208, 260)
        Me.TXT_NOMINA.MaxLength = 15
        Me.TXT_NOMINA.Name = "TXT_NOMINA"
        Me.TXT_NOMINA.Size = New System.Drawing.Size(175, 20)
        Me.TXT_NOMINA.TabIndex = 8
        '
        'BTN_VALIDA_RFC
        '
        Me.BTN_VALIDA_RFC.Location = New System.Drawing.Point(403, 129)
        Me.BTN_VALIDA_RFC.Name = "BTN_VALIDA_RFC"
        Me.BTN_VALIDA_RFC.Size = New System.Drawing.Size(108, 20)
        Me.BTN_VALIDA_RFC.TabIndex = 4
        Me.BTN_VALIDA_RFC.Text = "VALIDAR"
        Me.BTN_VALIDA_RFC.UseVisualStyleBackColor = True
        '
        'AGREGAR_VENDEDOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 420)
        Me.ControlBox = False
        Me.Controls.Add(Me.TXT_NOMINA)
        Me.Controls.Add(Me.TXT_C2)
        Me.Controls.Add(Me.TXT_C1)
        Me.Controls.Add(Me.TXT_CURP)
        Me.Controls.Add(Me.TXT_RFC_V)
        Me.Controls.Add(Me.TXT_AM)
        Me.Controls.Add(Me.TXT_AP)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.BTN_VOLVER)
        Me.Controls.Add(Me.BTN_ADD)
        Me.Controls.Add(Me.BTN_VALIDA_RFC)
        Me.Controls.Add(Me.BTN_VALIDA_NOMINA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AGREGAR_VENDEDOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR_VENDEDOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BTN_VALIDA_NOMINA As Button
    Friend WithEvents BTN_ADD As Button
    Friend WithEvents BTN_VOLVER As Button
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents TXT_AP As TextBox
    Friend WithEvents TXT_AM As TextBox
    Friend WithEvents TXT_RFC_V As TextBox
    Friend WithEvents TXT_CURP As TextBox
    Friend WithEvents TXT_C1 As TextBox
    Friend WithEvents TXT_C2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_NOMINA As TextBox
    Friend WithEvents BTN_VALIDA_RFC As Button
End Class
