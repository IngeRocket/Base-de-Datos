<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMINISTRADOR
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
        Me.SALIDA = New System.Windows.Forms.Button()
        Me.DG_PRODUCTOS = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PRODUCTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AÑADIRPRODUCTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REORDENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARPRODCUTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPRASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTOSDESCONTINUADOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIGENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DESCONTINUADOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENDEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOTALESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FACTURAFORMATOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENDEDORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AGREGARVENDEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITARVENDEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ELIMINARVENDEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITARCLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BORRARCLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_CONSULTAR = New System.Windows.Forms.Button()
        Me.COMISIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DG_PRODUCTOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SALIDA
        '
        Me.SALIDA.Location = New System.Drawing.Point(235, 361)
        Me.SALIDA.Name = "SALIDA"
        Me.SALIDA.Size = New System.Drawing.Size(330, 31)
        Me.SALIDA.TabIndex = 3
        Me.SALIDA.Text = "SALIR"
        Me.SALIDA.UseVisualStyleBackColor = True
        '
        'DG_PRODUCTOS
        '
        Me.DG_PRODUCTOS.AllowUserToAddRows = False
        Me.DG_PRODUCTOS.AllowUserToDeleteRows = False
        Me.DG_PRODUCTOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_PRODUCTOS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_PRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PRODUCTOS.Location = New System.Drawing.Point(49, 94)
        Me.DG_PRODUCTOS.MultiSelect = False
        Me.DG_PRODUCTOS.Name = "DG_PRODUCTOS"
        Me.DG_PRODUCTOS.ReadOnly = True
        Me.DG_PRODUCTOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_PRODUCTOS.Size = New System.Drawing.Size(697, 238)
        Me.DG_PRODUCTOS.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PRODUCTOS PROXIMOS A REORDEN A:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PRODUCTOSToolStripMenuItem, Me.CONSULTASToolStripMenuItem, Me.VENDEDORESToolStripMenuItem, Me.CLIENTESToolStripMenuItem, Me.COMISIONESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PRODUCTOSToolStripMenuItem
        '
        Me.PRODUCTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AÑADIRPRODUCTOToolStripMenuItem, Me.REORDENToolStripMenuItem, Me.ELIMINARPRODCUTOToolStripMenuItem})
        Me.PRODUCTOSToolStripMenuItem.Name = "PRODUCTOSToolStripMenuItem"
        Me.PRODUCTOSToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.PRODUCTOSToolStripMenuItem.Text = "PRODUCTOS"
        '
        'AÑADIRPRODUCTOToolStripMenuItem
        '
        Me.AÑADIRPRODUCTOToolStripMenuItem.Name = "AÑADIRPRODUCTOToolStripMenuItem"
        Me.AÑADIRPRODUCTOToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AÑADIRPRODUCTOToolStripMenuItem.Text = "AÑADIR PRODUCTO"
        '
        'REORDENToolStripMenuItem
        '
        Me.REORDENToolStripMenuItem.Name = "REORDENToolStripMenuItem"
        Me.REORDENToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.REORDENToolStripMenuItem.Text = "EDITAR PRODUCTO"
        '
        'ELIMINARPRODCUTOToolStripMenuItem
        '
        Me.ELIMINARPRODCUTOToolStripMenuItem.Name = "ELIMINARPRODCUTOToolStripMenuItem"
        Me.ELIMINARPRODCUTOToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ELIMINARPRODCUTOToolStripMenuItem.Text = "ELIMINAR PRODCUTO"
        '
        'CONSULTASToolStripMenuItem
        '
        Me.CONSULTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMPRASToolStripMenuItem, Me.PRODUCTOSDESCONTINUADOSToolStripMenuItem, Me.VENTASToolStripMenuItem, Me.FACTURAFORMATOToolStripMenuItem})
        Me.CONSULTASToolStripMenuItem.Name = "CONSULTASToolStripMenuItem"
        Me.CONSULTASToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.CONSULTASToolStripMenuItem.Text = "CONSULTAS"
        '
        'COMPRASToolStripMenuItem
        '
        Me.COMPRASToolStripMenuItem.Name = "COMPRASToolStripMenuItem"
        Me.COMPRASToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.COMPRASToolStripMenuItem.Text = "COMPRAS/DEVOLUCIONES"
        '
        'PRODUCTOSDESCONTINUADOSToolStripMenuItem
        '
        Me.PRODUCTOSDESCONTINUADOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIGENTESToolStripMenuItem, Me.DESCONTINUADOSToolStripMenuItem})
        Me.PRODUCTOSDESCONTINUADOSToolStripMenuItem.Name = "PRODUCTOSDESCONTINUADOSToolStripMenuItem"
        Me.PRODUCTOSDESCONTINUADOSToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.PRODUCTOSDESCONTINUADOSToolStripMenuItem.Text = "INVENTARIO"
        '
        'VIGENTESToolStripMenuItem
        '
        Me.VIGENTESToolStripMenuItem.Name = "VIGENTESToolStripMenuItem"
        Me.VIGENTESToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.VIGENTESToolStripMenuItem.Text = "VIGENTES"
        '
        'DESCONTINUADOSToolStripMenuItem
        '
        Me.DESCONTINUADOSToolStripMenuItem.Name = "DESCONTINUADOSToolStripMenuItem"
        Me.DESCONTINUADOSToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.DESCONTINUADOSToolStripMenuItem.Text = "DESCONTINUADOS"
        '
        'VENTASToolStripMenuItem
        '
        Me.VENTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLIENTEToolStripMenuItem, Me.VENDEDORToolStripMenuItem, Me.TOTALESToolStripMenuItem})
        Me.VENTASToolStripMenuItem.Name = "VENTASToolStripMenuItem"
        Me.VENTASToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.VENTASToolStripMenuItem.Text = "VENTAS"
        '
        'CLIENTEToolStripMenuItem
        '
        Me.CLIENTEToolStripMenuItem.Name = "CLIENTEToolStripMenuItem"
        Me.CLIENTEToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.CLIENTEToolStripMenuItem.Text = "CLIENTE"
        '
        'VENDEDORToolStripMenuItem
        '
        Me.VENDEDORToolStripMenuItem.Name = "VENDEDORToolStripMenuItem"
        Me.VENDEDORToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.VENDEDORToolStripMenuItem.Text = "VENDEDOR"
        '
        'TOTALESToolStripMenuItem
        '
        Me.TOTALESToolStripMenuItem.Name = "TOTALESToolStripMenuItem"
        Me.TOTALESToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.TOTALESToolStripMenuItem.Text = "TOTALES"
        '
        'FACTURAFORMATOToolStripMenuItem
        '
        Me.FACTURAFORMATOToolStripMenuItem.Name = "FACTURAFORMATOToolStripMenuItem"
        Me.FACTURAFORMATOToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.FACTURAFORMATOToolStripMenuItem.Text = "FACTURA FORMATO"
        '
        'VENDEDORESToolStripMenuItem
        '
        Me.VENDEDORESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AGREGARVENDEDORToolStripMenuItem, Me.EDITARVENDEDORToolStripMenuItem, Me.ELIMINARVENDEDORToolStripMenuItem})
        Me.VENDEDORESToolStripMenuItem.Name = "VENDEDORESToolStripMenuItem"
        Me.VENDEDORESToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.VENDEDORESToolStripMenuItem.Text = "VENDEDORES"
        '
        'AGREGARVENDEDORToolStripMenuItem
        '
        Me.AGREGARVENDEDORToolStripMenuItem.Name = "AGREGARVENDEDORToolStripMenuItem"
        Me.AGREGARVENDEDORToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AGREGARVENDEDORToolStripMenuItem.Text = "AGREGAR VENDEDOR"
        '
        'EDITARVENDEDORToolStripMenuItem
        '
        Me.EDITARVENDEDORToolStripMenuItem.Name = "EDITARVENDEDORToolStripMenuItem"
        Me.EDITARVENDEDORToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.EDITARVENDEDORToolStripMenuItem.Text = "EDITAR VENDEDOR"
        '
        'ELIMINARVENDEDORToolStripMenuItem
        '
        Me.ELIMINARVENDEDORToolStripMenuItem.Name = "ELIMINARVENDEDORToolStripMenuItem"
        Me.ELIMINARVENDEDORToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ELIMINARVENDEDORToolStripMenuItem.Text = "ELIMINAR VENDEDOR"
        '
        'CLIENTESToolStripMenuItem
        '
        Me.CLIENTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EDITARCLIENTEToolStripMenuItem, Me.BORRARCLIENTEToolStripMenuItem})
        Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.CLIENTESToolStripMenuItem.Text = "CLIENTES"
        '
        'EDITARCLIENTEToolStripMenuItem
        '
        Me.EDITARCLIENTEToolStripMenuItem.Name = "EDITARCLIENTEToolStripMenuItem"
        Me.EDITARCLIENTEToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.EDITARCLIENTEToolStripMenuItem.Text = "EDITAR CLIENTE"
        '
        'BORRARCLIENTEToolStripMenuItem
        '
        Me.BORRARCLIENTEToolStripMenuItem.Name = "BORRARCLIENTEToolStripMenuItem"
        Me.BORRARCLIENTEToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BORRARCLIENTEToolStripMenuItem.Text = "ELIMINAR CLIENTE"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(482, 61)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(61, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(549, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "UNIDADES"
        '
        'BTN_CONSULTAR
        '
        Me.BTN_CONSULTAR.Location = New System.Drawing.Point(618, 56)
        Me.BTN_CONSULTAR.Name = "BTN_CONSULTAR"
        Me.BTN_CONSULTAR.Size = New System.Drawing.Size(128, 28)
        Me.BTN_CONSULTAR.TabIndex = 2
        Me.BTN_CONSULTAR.Text = "CONSULTAR"
        Me.BTN_CONSULTAR.UseVisualStyleBackColor = True
        '
        'COMISIONESToolStripMenuItem
        '
        Me.COMISIONESToolStripMenuItem.Name = "COMISIONESToolStripMenuItem"
        Me.COMISIONESToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.COMISIONESToolStripMenuItem.Text = "COMISIONES"
        '
        'ADMINISTRADOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 423)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTN_CONSULTAR)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SALIDA)
        Me.Controls.Add(Me.DG_PRODUCTOS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "ADMINISTRADOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMINISTRADOR"
        CType(Me.DG_PRODUCTOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SALIDA As Button
    Friend WithEvents DG_PRODUCTOS As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PRODUCTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AÑADIRPRODUCTOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARPRODCUTOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REORDENToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENDEDORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODUCTOSDESCONTINUADOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIGENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DESCONTINUADOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENDEDORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AGREGARVENDEDORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ELIMINARVENDEDORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDITARCLIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BORRARCLIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDITARVENDEDORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COMPRASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_CONSULTAR As Button
    Friend WithEvents TOTALESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FACTURAFORMATOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COMISIONESToolStripMenuItem As ToolStripMenuItem
End Class
