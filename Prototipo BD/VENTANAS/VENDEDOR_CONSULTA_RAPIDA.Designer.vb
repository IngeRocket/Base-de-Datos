<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENDEDOR_CONSULTA_RAPIDA
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.CB_CATEGO = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(364, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(132, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(314, 29)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "CERRAR VENTANA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRODUCTO"
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(96, 41)
        Me.TXT_NOMBRE.MaxLength = 35
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(196, 20)
        Me.TXT_NOMBRE.TabIndex = 2
        '
        'CB_CATEGO
        '
        Me.CB_CATEGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CATEGO.FormattingEnabled = True
        Me.CB_CATEGO.Location = New System.Drawing.Point(341, 40)
        Me.CB_CATEGO.Name = "CB_CATEGO"
        Me.CB_CATEGO.Size = New System.Drawing.Size(174, 21)
        Me.CB_CATEGO.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(394, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CATEGORIA"
        '
        'VENDEDOR_CONSULTA_RAPIDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 188)
        Me.ControlBox = False
        Me.Controls.Add(Me.CB_CATEGO)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "VENDEDOR_CONSULTA_RAPIDA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENDEDOR_CONSULTA_RAPIDA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents CB_CATEGO As ComboBox
    Friend WithEvents Label2 As Label
End Class
