<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENDEDOR
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
        Me.LB_CAJA = New System.Windows.Forms.Label()
        Me.LB_NOMBRE = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CREARVENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DEVOLUCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CREARDEVOLUCIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALTACLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CERRARSESIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMISIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BORRARCUENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BORRARCUENTAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DG_VENTAS = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CB_CAJA = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DG_VENTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 389)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(651, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Caja En Uso:"
        '
        'LB_CAJA
        '
        Me.LB_CAJA.AutoSize = True
        Me.LB_CAJA.Location = New System.Drawing.Point(720, 389)
        Me.LB_CAJA.Name = "LB_CAJA"
        Me.LB_CAJA.Size = New System.Drawing.Size(13, 13)
        Me.LB_CAJA.TabIndex = 0
        Me.LB_CAJA.Text = "L"
        '
        'LB_NOMBRE
        '
        Me.LB_NOMBRE.AutoSize = True
        Me.LB_NOMBRE.Location = New System.Drawing.Point(82, 389)
        Me.LB_NOMBRE.Name = "LB_NOMBRE"
        Me.LB_NOMBRE.Size = New System.Drawing.Size(44, 13)
        Me.LB_NOMBRE.TabIndex = 0
        Me.LB_NOMBRE.Text = "Nombre"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VENTASToolStripMenuItem, Me.DEVOLUCIONESToolStripMenuItem, Me.CLIENTEToolStripMenuItem, Me.CUENTAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VENTASToolStripMenuItem
        '
        Me.VENTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CREARVENTAToolStripMenuItem})
        Me.VENTASToolStripMenuItem.Name = "VENTASToolStripMenuItem"
        Me.VENTASToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.VENTASToolStripMenuItem.Text = "VENTAS"
        '
        'CREARVENTAToolStripMenuItem
        '
        Me.CREARVENTAToolStripMenuItem.Name = "CREARVENTAToolStripMenuItem"
        Me.CREARVENTAToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.CREARVENTAToolStripMenuItem.Text = "CREAR VENTA"
        '
        'DEVOLUCIONESToolStripMenuItem
        '
        Me.DEVOLUCIONESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CREARDEVOLUCIONToolStripMenuItem})
        Me.DEVOLUCIONESToolStripMenuItem.Name = "DEVOLUCIONESToolStripMenuItem"
        Me.DEVOLUCIONESToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.DEVOLUCIONESToolStripMenuItem.Text = "DEVOLUCIONES"
        '
        'CREARDEVOLUCIONToolStripMenuItem
        '
        Me.CREARDEVOLUCIONToolStripMenuItem.Name = "CREARDEVOLUCIONToolStripMenuItem"
        Me.CREARDEVOLUCIONToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CREARDEVOLUCIONToolStripMenuItem.Text = "CREAR DEVOLUCION"
        '
        'CLIENTEToolStripMenuItem
        '
        Me.CLIENTEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ALTACLIENTEToolStripMenuItem})
        Me.CLIENTEToolStripMenuItem.Name = "CLIENTEToolStripMenuItem"
        Me.CLIENTEToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CLIENTEToolStripMenuItem.Text = "CLIENTE"
        '
        'ALTACLIENTEToolStripMenuItem
        '
        Me.ALTACLIENTEToolStripMenuItem.Name = "ALTACLIENTEToolStripMenuItem"
        Me.ALTACLIENTEToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ALTACLIENTEToolStripMenuItem.Text = "ALTA CLIENTE"
        '
        'CUENTAToolStripMenuItem
        '
        Me.CUENTAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EDITARToolStripMenuItem, Me.CERRARSESIONToolStripMenuItem, Me.COMISIONESToolStripMenuItem, Me.BORRARCUENTAToolStripMenuItem})
        Me.CUENTAToolStripMenuItem.Name = "CUENTAToolStripMenuItem"
        Me.CUENTAToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CUENTAToolStripMenuItem.Text = "CUENTA"
        '
        'EDITARToolStripMenuItem
        '
        Me.EDITARToolStripMenuItem.Name = "EDITARToolStripMenuItem"
        Me.EDITARToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.EDITARToolStripMenuItem.Text = "CAMBIAR CONTRASEÑA"
        '
        'CERRARSESIONToolStripMenuItem
        '
        Me.CERRARSESIONToolStripMenuItem.Name = "CERRARSESIONToolStripMenuItem"
        Me.CERRARSESIONToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CERRARSESIONToolStripMenuItem.Text = "CERRAR SESION"
        '
        'COMISIONESToolStripMenuItem
        '
        Me.COMISIONESToolStripMenuItem.Name = "COMISIONESToolStripMenuItem"
        Me.COMISIONESToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.COMISIONESToolStripMenuItem.Text = "COMISIONES"
        '
        'BORRARCUENTAToolStripMenuItem
        '
        Me.BORRARCUENTAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BORRARCUENTAToolStripMenuItem1})
        Me.BORRARCUENTAToolStripMenuItem.Name = "BORRARCUENTAToolStripMenuItem"
        Me.BORRARCUENTAToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.BORRARCUENTAToolStripMenuItem.Text = "CUENTA"
        '
        'BORRARCUENTAToolStripMenuItem1
        '
        Me.BORRARCUENTAToolStripMenuItem1.Name = "BORRARCUENTAToolStripMenuItem1"
        Me.BORRARCUENTAToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.BORRARCUENTAToolStripMenuItem1.Text = "BORRAR CUENTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "HISTORIAL DE VENTAS"
        '
        'DG_VENTAS
        '
        Me.DG_VENTAS.AllowUserToAddRows = False
        Me.DG_VENTAS.AllowUserToDeleteRows = False
        Me.DG_VENTAS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DG_VENTAS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_VENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_VENTAS.Location = New System.Drawing.Point(39, 83)
        Me.DG_VENTAS.MultiSelect = False
        Me.DG_VENTAS.Name = "DG_VENTAS"
        Me.DG_VENTAS.ReadOnly = True
        Me.DG_VENTAS.Size = New System.Drawing.Size(695, 272)
        Me.DG_VENTAS.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(615, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 27)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CB_CAJA
        '
        Me.CB_CAJA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CAJA.FormattingEnabled = True
        Me.CB_CAJA.Location = New System.Drawing.Point(490, 52)
        Me.CB_CAJA.Name = "CB_CAJA"
        Me.CB_CAJA.Size = New System.Drawing.Size(109, 21)
        Me.CB_CAJA.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(443, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "# Caja:"
        '
        'VENDEDOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.CB_CAJA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DG_VENTAS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LB_CAJA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LB_NOMBRE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VENDEDOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENDEDOR"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DG_VENTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LB_CAJA As Label
    Friend WithEvents LB_NOMBRE As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CREARVENTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DEVOLUCIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CREARDEVOLUCIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUENTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDITARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BORRARCUENTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CERRARSESIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COMISIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents DG_VENTAS As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents CB_CAJA As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BORRARCUENTAToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CLIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ALTACLIENTEToolStripMenuItem As ToolStripMenuItem
End Class
