<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrabmlocalidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmrabmlocalidad))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cmdagregarabmlocalidad = New System.Windows.Forms.ToolStripButton()
        Me.cmdsalirabmlocalidad = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblseñallocalidad = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombrelocalidad = New System.Windows.Forms.TextBox()
        Me.Txtidlocalidad = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cmdagregarabmlocalidad, Me.cmdsalirabmlocalidad, Me.ToolStripSeparator1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(491, 71)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Cmdagregarabmlocalidad
        '
        Me.Cmdagregarabmlocalidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdagregarabmlocalidad.Image = Global.SistemaEstudio.My.Resources.Resources.Aceptar
        Me.Cmdagregarabmlocalidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdagregarabmlocalidad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdagregarabmlocalidad.Name = "Cmdagregarabmlocalidad"
        Me.Cmdagregarabmlocalidad.Size = New System.Drawing.Size(68, 68)
        Me.Cmdagregarabmlocalidad.Text = "Agregar"
        Me.Cmdagregarabmlocalidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdsalirabmlocalidad
        '
        Me.cmdsalirabmlocalidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsalirabmlocalidad.Image = Global.SistemaEstudio.My.Resources.Resources.Cancelar
        Me.cmdsalirabmlocalidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdsalirabmlocalidad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsalirabmlocalidad.Name = "cmdsalirabmlocalidad"
        Me.cmdsalirabmlocalidad.Size = New System.Drawing.Size(68, 68)
        Me.cmdsalirabmlocalidad.Text = "Salir"
        Me.cmdsalirabmlocalidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'lblseñallocalidad
        '
        Me.lblseñallocalidad.AutoSize = True
        Me.lblseñallocalidad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseñallocalidad.ForeColor = System.Drawing.Color.White
        Me.lblseñallocalidad.Location = New System.Drawing.Point(370, 107)
        Me.lblseñallocalidad.Name = "lblseñallocalidad"
        Me.lblseñallocalidad.Size = New System.Drawing.Size(63, 19)
        Me.lblseñallocalidad.TabIndex = 50
        Me.lblseñallocalidad.Text = "Label10"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(70, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(70, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Numero"
        '
        'txtnombrelocalidad
        '
        Me.txtnombrelocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtnombrelocalidad.ForeColor = System.Drawing.Color.White
        Me.txtnombrelocalidad.Location = New System.Drawing.Point(155, 190)
        Me.txtnombrelocalidad.Name = "txtnombrelocalidad"
        Me.txtnombrelocalidad.Size = New System.Drawing.Size(245, 20)
        Me.txtnombrelocalidad.TabIndex = 46
        '
        'Txtidlocalidad
        '
        Me.Txtidlocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Txtidlocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtidlocalidad.ForeColor = System.Drawing.Color.White
        Me.Txtidlocalidad.Location = New System.Drawing.Point(155, 143)
        Me.Txtidlocalidad.Name = "Txtidlocalidad"
        Me.Txtidlocalidad.Size = New System.Drawing.Size(121, 20)
        Me.Txtidlocalidad.TabIndex = 44
        '
        'fmrabmlocalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(491, 327)
        Me.Controls.Add(Me.lblseñallocalidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombrelocalidad)
        Me.Controls.Add(Me.Txtidlocalidad)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmrabmlocalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM - Localidad"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Cmdagregarabmlocalidad As ToolStripButton
    Friend WithEvents cmdsalirabmlocalidad As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblseñallocalidad As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombrelocalidad As TextBox
    Friend WithEvents Txtidlocalidad As TextBox
End Class
