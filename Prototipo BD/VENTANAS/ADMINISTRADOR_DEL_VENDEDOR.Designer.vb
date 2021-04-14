<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMINISTRADOR_DEL_VENDEDOR
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
        Me.TXT_RFC = New System.Windows.Forms.TextBox()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LB_NOMBRE = New System.Windows.Forms.Label()
        Me.LB_AP = New System.Windows.Forms.Label()
        Me.LB_AM = New System.Windows.Forms.Label()
        Me.LB_CURP = New System.Windows.Forms.Label()
        Me.LB_NOMINA = New System.Windows.Forms.Label()
        Me.BTN_DEL = New System.Windows.Forms.Button()
        Me.BTN_CANCEL = New System.Windows.Forms.Button()
        Me.LB_RFC = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_RFC
        '
        Me.TXT_RFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_RFC.Location = New System.Drawing.Point(113, 35)
        Me.TXT_RFC.MaxLength = 13
        Me.TXT_RFC.Name = "TXT_RFC"
        Me.TXT_RFC.Size = New System.Drawing.Size(175, 20)
        Me.TXT_RFC.TabIndex = 0
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(304, 35)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(108, 20)
        Me.BTN_BUSCAR.TabIndex = 1
        Me.BTN_BUSCAR.Text = "BUSCAR"
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "No. Nomina"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "CURP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "RFC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Apellido Materno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Apellido Paterno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nombre"
        '
        'LB_NOMBRE
        '
        Me.LB_NOMBRE.AutoSize = True
        Me.LB_NOMBRE.Location = New System.Drawing.Point(108, 30)
        Me.LB_NOMBRE.Name = "LB_NOMBRE"
        Me.LB_NOMBRE.Size = New System.Drawing.Size(44, 13)
        Me.LB_NOMBRE.TabIndex = 25
        Me.LB_NOMBRE.Text = "Nombre"
        '
        'LB_AP
        '
        Me.LB_AP.AutoSize = True
        Me.LB_AP.Location = New System.Drawing.Point(108, 62)
        Me.LB_AP.Name = "LB_AP"
        Me.LB_AP.Size = New System.Drawing.Size(44, 13)
        Me.LB_AP.TabIndex = 25
        Me.LB_AP.Text = "Nombre"
        '
        'LB_AM
        '
        Me.LB_AM.AutoSize = True
        Me.LB_AM.Location = New System.Drawing.Point(108, 94)
        Me.LB_AM.Name = "LB_AM"
        Me.LB_AM.Size = New System.Drawing.Size(44, 13)
        Me.LB_AM.TabIndex = 25
        Me.LB_AM.Text = "Nombre"
        '
        'LB_CURP
        '
        Me.LB_CURP.AutoSize = True
        Me.LB_CURP.Location = New System.Drawing.Point(108, 124)
        Me.LB_CURP.Name = "LB_CURP"
        Me.LB_CURP.Size = New System.Drawing.Size(44, 13)
        Me.LB_CURP.TabIndex = 25
        Me.LB_CURP.Text = "Nombre"
        '
        'LB_NOMINA
        '
        Me.LB_NOMINA.AutoSize = True
        Me.LB_NOMINA.Location = New System.Drawing.Point(108, 152)
        Me.LB_NOMINA.Name = "LB_NOMINA"
        Me.LB_NOMINA.Size = New System.Drawing.Size(44, 13)
        Me.LB_NOMINA.TabIndex = 25
        Me.LB_NOMINA.Text = "Nombre"
        '
        'BTN_DEL
        '
        Me.BTN_DEL.Location = New System.Drawing.Point(89, 302)
        Me.BTN_DEL.Name = "BTN_DEL"
        Me.BTN_DEL.Size = New System.Drawing.Size(134, 35)
        Me.BTN_DEL.TabIndex = 2
        Me.BTN_DEL.Text = "ELIMINAR VENDEDOR"
        Me.BTN_DEL.UseVisualStyleBackColor = True
        '
        'BTN_CANCEL
        '
        Me.BTN_CANCEL.Location = New System.Drawing.Point(233, 302)
        Me.BTN_CANCEL.Name = "BTN_CANCEL"
        Me.BTN_CANCEL.Size = New System.Drawing.Size(134, 35)
        Me.BTN_CANCEL.TabIndex = 3
        Me.BTN_CANCEL.Text = "CANCELAR"
        Me.BTN_CANCEL.UseVisualStyleBackColor = True
        '
        'LB_RFC
        '
        Me.LB_RFC.AutoSize = True
        Me.LB_RFC.Location = New System.Drawing.Point(108, 180)
        Me.LB_RFC.Name = "LB_RFC"
        Me.LB_RFC.Size = New System.Drawing.Size(47, 13)
        Me.LB_RFC.TabIndex = 25
        Me.LB_RFC.Text = "LB_RFC"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "RFC"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LB_RFC)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LB_NOMINA)
        Me.GroupBox1.Controls.Add(Me.LB_CURP)
        Me.GroupBox1.Controls.Add(Me.LB_AM)
        Me.GroupBox1.Controls.Add(Me.LB_AP)
        Me.GroupBox1.Controls.Add(Me.LB_NOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(100, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 214)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL VENDEDOR A ELIMINAR"
        '
        'ADMINISTRADOR_DEL_VENDEDOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_CANCEL)
        Me.Controls.Add(Me.BTN_DEL)
        Me.Controls.Add(Me.TXT_RFC)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Controls.Add(Me.Label4)
        Me.Name = "ADMINISTRADOR_DEL_VENDEDOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ELIMINAR VENDEDOR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_RFC As TextBox
    Friend WithEvents BTN_BUSCAR As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LB_NOMBRE As Label
    Friend WithEvents LB_AP As Label
    Friend WithEvents LB_AM As Label
    Friend WithEvents LB_CURP As Label
    Friend WithEvents LB_NOMINA As Label
    Friend WithEvents BTN_DEL As Button
    Friend WithEvents BTN_CANCEL As Button
    Friend WithEvents LB_RFC As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
