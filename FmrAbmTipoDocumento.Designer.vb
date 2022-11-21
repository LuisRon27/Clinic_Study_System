<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrAbmTipoDocumento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrAbmTipoDocumento))
        Me.lblseñaltipo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombretipo = New System.Windows.Forms.TextBox()
        Me.Txtidtipo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CmdagregarABMtipo = New System.Windows.Forms.ToolStripButton()
        Me.cmdsalirABMtipo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblseñaltipo
        '
        Me.lblseñaltipo.AutoSize = True
        Me.lblseñaltipo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseñaltipo.ForeColor = System.Drawing.Color.White
        Me.lblseñaltipo.Location = New System.Drawing.Point(378, 131)
        Me.lblseñaltipo.Name = "lblseñaltipo"
        Me.lblseñaltipo.Size = New System.Drawing.Size(63, 19)
        Me.lblseñaltipo.TabIndex = 60
        Me.lblseñaltipo.Text = "Label10"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(78, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(78, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Numero"
        '
        'txtnombretipo
        '
        Me.txtnombretipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtnombretipo.ForeColor = System.Drawing.Color.White
        Me.txtnombretipo.Location = New System.Drawing.Point(163, 214)
        Me.txtnombretipo.Name = "txtnombretipo"
        Me.txtnombretipo.Size = New System.Drawing.Size(245, 20)
        Me.txtnombretipo.TabIndex = 57
        '
        'Txtidtipo
        '
        Me.Txtidtipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Txtidtipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtidtipo.ForeColor = System.Drawing.Color.White
        Me.Txtidtipo.Location = New System.Drawing.Point(163, 167)
        Me.Txtidtipo.Name = "Txtidtipo"
        Me.Txtidtipo.Size = New System.Drawing.Size(121, 20)
        Me.Txtidtipo.TabIndex = 56
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdagregarABMtipo, Me.cmdsalirABMtipo, Me.ToolStripSeparator1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(529, 71)
        Me.ToolStrip1.TabIndex = 61
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CmdagregarABMtipo
        '
        Me.CmdagregarABMtipo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdagregarABMtipo.Image = Global.SistemaEstudio.My.Resources.Resources.Aceptar
        Me.CmdagregarABMtipo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmdagregarABMtipo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdagregarABMtipo.Name = "CmdagregarABMtipo"
        Me.CmdagregarABMtipo.Size = New System.Drawing.Size(68, 68)
        Me.CmdagregarABMtipo.Text = "Agregar"
        Me.CmdagregarABMtipo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdsalirABMtipo
        '
        Me.cmdsalirABMtipo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsalirABMtipo.Image = Global.SistemaEstudio.My.Resources.Resources.Cancelar
        Me.cmdsalirABMtipo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdsalirABMtipo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsalirABMtipo.Name = "cmdsalirABMtipo"
        Me.cmdsalirABMtipo.Size = New System.Drawing.Size(68, 68)
        Me.cmdsalirABMtipo.Text = "Salir"
        Me.cmdsalirABMtipo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'FmrAbmTipoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(529, 335)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblseñaltipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombretipo)
        Me.Controls.Add(Me.Txtidtipo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmrAbmTipoDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM - Tipo De Documento"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblseñaltipo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombretipo As TextBox
    Friend WithEvents Txtidtipo As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents CmdagregarABMtipo As ToolStripButton
    Friend WithEvents cmdsalirABMtipo As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
