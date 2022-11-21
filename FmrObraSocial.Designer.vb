<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrObraSocial
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrObraSocial))
        Me.Grillaobrasocial = New System.Windows.Forms.DataGridView()
        Me.ID_Obra_Social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cmdagregarobrasocial = New System.Windows.Forms.ToolStripButton()
        Me.CmdModificarobrasocial = New System.Windows.Forms.ToolStripButton()
        Me.Cmdeliminarobrasocial = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdsalirobrasocial = New System.Windows.Forms.ToolStripButton()
        CType(Me.Grillaobrasocial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grillaobrasocial
        '
        Me.Grillaobrasocial.AllowUserToAddRows = False
        Me.Grillaobrasocial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Grillaobrasocial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grillaobrasocial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Grillaobrasocial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grillaobrasocial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grillaobrasocial.ColumnHeadersHeight = 35
        Me.Grillaobrasocial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Grillaobrasocial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Obra_Social, Me.Nombre, Me.Activo})
        Me.Grillaobrasocial.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Grillaobrasocial.EnableHeadersVisualStyles = False
        Me.Grillaobrasocial.GridColor = System.Drawing.Color.SteelBlue
        Me.Grillaobrasocial.Location = New System.Drawing.Point(0, 85)
        Me.Grillaobrasocial.Name = "Grillaobrasocial"
        Me.Grillaobrasocial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grillaobrasocial.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Grillaobrasocial.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grillaobrasocial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grillaobrasocial.Size = New System.Drawing.Size(320, 348)
        Me.Grillaobrasocial.TabIndex = 7
        '
        'ID_Obra_Social
        '
        Me.ID_Obra_Social.HeaderText = "Numero"
        Me.ID_Obra_Social.Name = "ID_Obra_Social"
        Me.ID_Obra_Social.Width = 80
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 200
        '
        'Activo
        '
        Me.Activo.HeaderText = "Activo"
        Me.Activo.Name = "Activo"
        Me.Activo.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cmdagregarobrasocial, Me.CmdModificarobrasocial, Me.Cmdeliminarobrasocial, Me.ToolStripSeparator1, Me.cmdsalirobrasocial})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(320, 71)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Cmdagregarobrasocial
        '
        Me.Cmdagregarobrasocial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdagregarobrasocial.Image = Global.SistemaEstudio.My.Resources.Resources.businesspackage_additionalpackage_box_add_insert_negoci_2335__1_
        Me.Cmdagregarobrasocial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdagregarobrasocial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdagregarobrasocial.Name = "Cmdagregarobrasocial"
        Me.Cmdagregarobrasocial.Size = New System.Drawing.Size(68, 68)
        Me.Cmdagregarobrasocial.Text = "Agregar"
        Me.Cmdagregarobrasocial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CmdModificarobrasocial
        '
        Me.CmdModificarobrasocial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdModificarobrasocial.Image = Global.SistemaEstudio.My.Resources.Resources.documentediting_editdocuments_text_documentedi_2820
        Me.CmdModificarobrasocial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmdModificarobrasocial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdModificarobrasocial.Name = "CmdModificarobrasocial"
        Me.CmdModificarobrasocial.Size = New System.Drawing.Size(68, 68)
        Me.CmdModificarobrasocial.Text = "Modificar"
        Me.CmdModificarobrasocial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Cmdeliminarobrasocial
        '
        Me.Cmdeliminarobrasocial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdeliminarobrasocial.Image = Global.SistemaEstudio.My.Resources.Resources.iconfinder_trash_4341321_120557
        Me.Cmdeliminarobrasocial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdeliminarobrasocial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdeliminarobrasocial.Name = "Cmdeliminarobrasocial"
        Me.Cmdeliminarobrasocial.Size = New System.Drawing.Size(68, 68)
        Me.Cmdeliminarobrasocial.Text = "Eliminar"
        Me.Cmdeliminarobrasocial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'cmdsalirobrasocial
        '
        Me.cmdsalirobrasocial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsalirobrasocial.Image = Global.SistemaEstudio.My.Resources.Resources.Exit_Page_icon_icons_com_53732
        Me.cmdsalirobrasocial.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdsalirobrasocial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdsalirobrasocial.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsalirobrasocial.Name = "cmdsalirobrasocial"
        Me.cmdsalirobrasocial.Size = New System.Drawing.Size(68, 68)
        Me.cmdsalirobrasocial.Text = "Salir"
        '
        'FmrObraSocial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 433)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Grillaobrasocial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmrObraSocial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Obra Social"
        CType(Me.Grillaobrasocial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grillaobrasocial As DataGridView
    Friend WithEvents ID_Obra_Social As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Cmdagregarobrasocial As ToolStripButton
    Friend WithEvents CmdModificarobrasocial As ToolStripButton
    Friend WithEvents Cmdeliminarobrasocial As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdsalirobrasocial As ToolStripButton
End Class
