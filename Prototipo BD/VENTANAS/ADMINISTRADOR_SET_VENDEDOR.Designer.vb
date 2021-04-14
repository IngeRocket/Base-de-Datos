<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMINISTRADOR_SET_VENDEDOR
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
        Me.TXT_CURP = New System.Windows.Forms.TextBox()
        Me.TXT_RFC = New System.Windows.Forms.TextBox()
        Me.TXT_AM = New System.Windows.Forms.TextBox()
        Me.TXT_AP = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.BTN_VOLVER = New System.Windows.Forms.Button()
        Me.BTN_EDIT = New System.Windows.Forms.Button()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LB_NOMINA = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LB_RFC = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_C2
        '
        Me.TXT_C2.Location = New System.Drawing.Point(134, 221)
        Me.TXT_C2.MaxLength = 15
        Me.TXT_C2.Name = "TXT_C2"
        Me.TXT_C2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(37)
        Me.TXT_C2.Size = New System.Drawing.Size(175, 20)
        Me.TXT_C2.TabIndex = 7
        '
        'TXT_C1
        '
        Me.TXT_C1.Location = New System.Drawing.Point(134, 188)
        Me.TXT_C1.MaxLength = 15
        Me.TXT_C1.Name = "TXT_C1"
        Me.TXT_C1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(37)
        Me.TXT_C1.Size = New System.Drawing.Size(175, 20)
        Me.TXT_C1.TabIndex = 6
        '
        'TXT_CURP
        '
        Me.TXT_CURP.Location = New System.Drawing.Point(134, 157)
        Me.TXT_CURP.MaxLength = 20
        Me.TXT_CURP.Name = "TXT_CURP"
        Me.TXT_CURP.Size = New System.Drawing.Size(175, 20)
        Me.TXT_CURP.TabIndex = 5
        '
        'TXT_RFC
        '
        Me.TXT_RFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_RFC.Location = New System.Drawing.Point(130, 25)
        Me.TXT_RFC.MaxLength = 13
        Me.TXT_RFC.Name = "TXT_RFC"
        Me.TXT_RFC.Size = New System.Drawing.Size(175, 20)
        Me.TXT_RFC.TabIndex = 0
        '
        'TXT_AM
        '
        Me.TXT_AM.Location = New System.Drawing.Point(134, 126)
        Me.TXT_AM.MaxLength = 15
        Me.TXT_AM.Name = "TXT_AM"
        Me.TXT_AM.Size = New System.Drawing.Size(175, 20)
        Me.TXT_AM.TabIndex = 4
        '
        'TXT_AP
        '
        Me.TXT_AP.Location = New System.Drawing.Point(134, 94)
        Me.TXT_AP.MaxLength = 15
        Me.TXT_AP.Name = "TXT_AP"
        Me.TXT_AP.Size = New System.Drawing.Size(175, 20)
        Me.TXT_AP.TabIndex = 3
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(134, 62)
        Me.TXT_NOMBRE.MaxLength = 30
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(175, 20)
        Me.TXT_NOMBRE.TabIndex = 2
        '
        'BTN_VOLVER
        '
        Me.BTN_VOLVER.Location = New System.Drawing.Point(259, 382)
        Me.BTN_VOLVER.Name = "BTN_VOLVER"
        Me.BTN_VOLVER.Size = New System.Drawing.Size(128, 30)
        Me.BTN_VOLVER.TabIndex = 11
        Me.BTN_VOLVER.Text = "REGRESAR"
        Me.BTN_VOLVER.UseVisualStyleBackColor = True
        '
        'BTN_EDIT
        '
        Me.BTN_EDIT.Location = New System.Drawing.Point(103, 382)
        Me.BTN_EDIT.Name = "BTN_EDIT"
        Me.BTN_EDIT.Size = New System.Drawing.Size(128, 30)
        Me.BTN_EDIT.TabIndex = 10
        Me.BTN_EDIT.Text = "GUARDAR CAMBIOS"
        Me.BTN_EDIT.UseVisualStyleBackColor = True
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(325, 25)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(108, 20)
        Me.BTN_BUSCAR.TabIndex = 1
        Me.BTN_BUSCAR.Text = "BUSCAR"
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "No. Nomina"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Repetir Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Constraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "CURP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "RFC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Apellido Materno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Apellido Paterno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre"
        '
        'LB_NOMINA
        '
        Me.LB_NOMINA.AutoSize = True
        Me.LB_NOMINA.Location = New System.Drawing.Point(131, 261)
        Me.LB_NOMINA.Name = "LB_NOMINA"
        Me.LB_NOMINA.Size = New System.Drawing.Size(50, 13)
        Me.LB_NOMINA.TabIndex = 21
        Me.LB_NOMINA.Text = "NOMINA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LB_RFC)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.LB_NOMINA)
        Me.GroupBox1.Controls.Add(Me.TXT_C2)
        Me.GroupBox1.Controls.Add(Me.TXT_C1)
        Me.GroupBox1.Controls.Add(Me.TXT_CURP)
        Me.GroupBox1.Controls.Add(Me.TXT_AM)
        Me.GroupBox1.Controls.Add(Me.TXT_AP)
        Me.GroupBox1.Controls.Add(Me.TXT_NOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 290)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS ACTUALES VENDEDOR"
        '
        'LB_RFC
        '
        Me.LB_RFC.AutoSize = True
        Me.LB_RFC.Location = New System.Drawing.Point(131, 37)
        Me.LB_RFC.Name = "LB_RFC"
        Me.LB_RFC.Size = New System.Drawing.Size(28, 13)
        Me.LB_RFC.TabIndex = 23
        Me.LB_RFC.Text = "RFC"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "RFC"
        '
        'ADMINISTRADOR_SET_VENDEDOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 424)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXT_RFC)
        Me.Controls.Add(Me.BTN_VOLVER)
        Me.Controls.Add(Me.BTN_EDIT)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Controls.Add(Me.Label4)
        Me.Name = "ADMINISTRADOR_SET_VENDEDOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDITAR VENDEDOR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_C2 As TextBox
    Friend WithEvents TXT_C1 As TextBox
    Friend WithEvents TXT_CURP As TextBox
    Friend WithEvents TXT_RFC As TextBox
    Friend WithEvents TXT_AM As TextBox
    Friend WithEvents TXT_AP As TextBox
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents BTN_VOLVER As Button
    Friend WithEvents BTN_EDIT As Button
    Friend WithEvents BTN_BUSCAR As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LB_NOMINA As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LB_RFC As Label
    Friend WithEvents Label10 As Label
End Class
