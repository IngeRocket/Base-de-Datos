<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class C_DETALLE
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
        Me.BTN_REGRESO = New System.Windows.Forms.Button()
        Me.DG_G = New System.Windows.Forms.DataGridView()
        CType(Me.DG_G, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_REGRESO
        '
        Me.BTN_REGRESO.Location = New System.Drawing.Point(38, 336)
        Me.BTN_REGRESO.Name = "BTN_REGRESO"
        Me.BTN_REGRESO.Size = New System.Drawing.Size(444, 35)
        Me.BTN_REGRESO.TabIndex = 0
        Me.BTN_REGRESO.Text = "REGRESAR"
        Me.BTN_REGRESO.UseVisualStyleBackColor = True
        '
        'DG_G
        '
        Me.DG_G.AllowUserToAddRows = False
        Me.DG_G.AllowUserToDeleteRows = False
        Me.DG_G.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_G.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_G.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_G.Location = New System.Drawing.Point(38, 50)
        Me.DG_G.MultiSelect = False
        Me.DG_G.Name = "DG_G"
        Me.DG_G.ReadOnly = True
        Me.DG_G.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_G.Size = New System.Drawing.Size(444, 263)
        Me.DG_G.TabIndex = 1
        '
        'C_DETALLE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.DG_G)
        Me.Controls.Add(Me.BTN_REGRESO)
        Me.Name = "C_DETALLE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETALLE"
        CType(Me.DG_G, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_REGRESO As Button
    Friend WithEvents DG_G As DataGridView
End Class
