<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_INVENTARIO
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
        Me.DG_REPORTE = New System.Windows.Forms.DataGridView()
        Me.CMB_CATEGO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_CONSULTA = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DG_REPORTE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_REPORTE
        '
        Me.DG_REPORTE.AllowUserToAddRows = False
        Me.DG_REPORTE.AllowUserToDeleteRows = False
        Me.DG_REPORTE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_REPORTE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_REPORTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_REPORTE.Location = New System.Drawing.Point(32, 46)
        Me.DG_REPORTE.MultiSelect = False
        Me.DG_REPORTE.Name = "DG_REPORTE"
        Me.DG_REPORTE.ReadOnly = True
        Me.DG_REPORTE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_REPORTE.Size = New System.Drawing.Size(419, 217)
        Me.DG_REPORTE.TabIndex = 0
        '
        'CMB_CATEGO
        '
        Me.CMB_CATEGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_CATEGO.FormattingEnabled = True
        Me.CMB_CATEGO.Location = New System.Drawing.Point(527, 42)
        Me.CMB_CATEGO.Name = "CMB_CATEGO"
        Me.CMB_CATEGO.Size = New System.Drawing.Size(140, 21)
        Me.CMB_CATEGO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(457, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CATEGORIA"
        '
        'BTN_CONSULTA
        '
        Me.BTN_CONSULTA.Location = New System.Drawing.Point(486, 92)
        Me.BTN_CONSULTA.Name = "BTN_CONSULTA"
        Me.BTN_CONSULTA.Size = New System.Drawing.Size(181, 28)
        Me.BTN_CONSULTA.TabIndex = 3
        Me.BTN_CONSULTA.Text = "CONSULTAR"
        Me.BTN_CONSULTA.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(486, 235)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "REGRESAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'R_INVENTARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTN_CONSULTA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMB_CATEGO)
        Me.Controls.Add(Me.DG_REPORTE)
        Me.Name = "R_INVENTARIO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTE INVENTARIO"
        CType(Me.DG_REPORTE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DG_REPORTE As DataGridView
    Friend WithEvents CMB_CATEGO As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_CONSULTA As Button
    Friend WithEvents Button2 As Button
End Class
