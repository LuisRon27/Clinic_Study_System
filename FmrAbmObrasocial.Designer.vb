<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrAbmObrasocial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrAbmObrasocial))
        Me.lblseñalObraSocial = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombreObraSocial = New System.Windows.Forms.TextBox()
        Me.TxtidObraSocial = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cmdagregarabmobrasocial = New System.Windows.Forms.ToolStripButton()
        Me.cmdsalirabmobrasocial = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblseñalObraSocial
        '
        Me.lblseñalObraSocial.AutoSize = True
        Me.lblseñalObraSocial.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseñalObraSocial.ForeColor = System.Drawing.Color.White
        Me.lblseñalObraSocial.Location = New System.Drawing.Point(381, 129)
        Me.lblseñalObraSocial.Name = "lblseñalObraSocial"
        Me.lblseñalObraSocial.Size = New System.Drawing.Size(63, 19)
        Me.lblseñalObraSocial.TabIndex = 55
        Me.lblseñalObraSocial.Text = "Label10"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(81, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(81, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Numero"
        '
        'txtnombreObraSocial
        '
        Me.txtnombreObraSocial.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtnombreObraSocial.ForeColor = System.Drawing.Color.White
        Me.txtnombreObraSocial.Location = New System.Drawing.Point(166, 212)
        Me.txtnombreObraSocial.Name = "txtnombreObraSocial"
        Me.txtnombreObraSocial.Size = New System.Drawing.Size(245, 20)
        Me.txtnombreObraSocial.TabIndex = 52
        '
        'TxtidObraSocial
        '
        Me.TxtidObraSocial.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TxtidObraSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtidObraSocial.Enabled = False
        Me.TxtidObraSocial.ForeColor = System.Drawing.Color.White
        Me.TxtidObraSocial.Location = New System.Drawing.Point(166, 165)
        Me.TxtidObraSocial.Name = "TxtidObraSocial"
        Me.TxtidObraSocial.Size = New System.Drawing.Size(121, 20)
        Me.TxtidObraSocial.TabIndex = 51
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cmdagregarabmobrasocial, Me.cmdsalirabmobrasocial, Me.ToolStripSeparator1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(549, 71)
        Me.ToolStrip1.TabIndex = 56
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Cmdagregarabmobrasocial
        '
        Me.Cmdagregarabmobrasocial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdagregarabmobrasocial.Image = Global.SistemaEstudio.My.Resources.Resources.Aceptar
        Me.Cmdagregarabmobrasocial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdagregarabmobrasocial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdagregarabmobrasocial.Name = "Cmdagregarabmobrasocial"
        Me.Cmdagregarabmobrasocial.Size = New System.Drawing.Size(68, 68)
        Me.Cmdagregarabmobrasocial.Text = "Agregar"
        Me.Cmdagregarabmobrasocial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdsalirabmobrasocial
        '
        Me.cmdsalirabmobrasocial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsalirabmobrasocial.Image = Global.SistemaEstudio.My.Resources.Resources.Cancelar
        Me.cmdsalirabmobrasocial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdsalirabmobrasocial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsalirabmobrasocial.Name = "cmdsalirabmobrasocial"
        Me.cmdsalirabmobrasocial.Size = New System.Drawing.Size(68, 68)
        Me.cmdsalirabmobrasocial.Text = "Salir"
        Me.cmdsalirabmobrasocial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'FmrAbmObrasocial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(549, 356)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblseñalObraSocial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombreObraSocial)
        Me.Controls.Add(Me.TxtidObraSocial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmrAbmObrasocial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM - Obra Social"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblseñalObraSocial As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombreObraSocial As TextBox
    Friend WithEvents TxtidObraSocial As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Cmdagregarabmobrasocial As ToolStripButton
    Friend WithEvents cmdsalirabmobrasocial As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
