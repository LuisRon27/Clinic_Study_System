<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrTipoDocumento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmrTipoDocumento))
        Me.GrillatipoDocumento = New System.Windows.Forms.DataGridView()
        Me.ID_Obra_Social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cmdagregartipo = New System.Windows.Forms.ToolStripButton()
        Me.CmdModificartipo = New System.Windows.Forms.ToolStripButton()
        Me.Cmdeliminartipo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdsalirtipo = New System.Windows.Forms.ToolStripButton()
        CType(Me.GrillatipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrillatipoDocumento
        '
        Me.GrillatipoDocumento.AllowUserToAddRows = False
        Me.GrillatipoDocumento.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GrillatipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrillatipoDocumento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GrillatipoDocumento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillatipoDocumento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrillatipoDocumento.ColumnHeadersHeight = 35
        Me.GrillatipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillatipoDocumento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Obra_Social, Me.Nombre, Me.Activo})
        Me.GrillatipoDocumento.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrillatipoDocumento.EnableHeadersVisualStyles = False
        Me.GrillatipoDocumento.GridColor = System.Drawing.Color.SteelBlue
        Me.GrillatipoDocumento.Location = New System.Drawing.Point(0, 102)
        Me.GrillatipoDocumento.Name = "GrillatipoDocumento"
        Me.GrillatipoDocumento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillatipoDocumento.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.GrillatipoDocumento.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.GrillatipoDocumento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GrillatipoDocumento.Size = New System.Drawing.Size(322, 348)
        Me.GrillatipoDocumento.TabIndex = 8
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cmdagregartipo, Me.CmdModificartipo, Me.Cmdeliminartipo, Me.ToolStripSeparator1, Me.cmdsalirtipo})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(322, 71)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Cmdagregartipo
        '
        Me.Cmdagregartipo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdagregartipo.Image = Global.SistemaEstudio.My.Resources.Resources.businesspackage_additionalpackage_box_add_insert_negoci_2335__1_
        Me.Cmdagregartipo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdagregartipo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdagregartipo.Name = "Cmdagregartipo"
        Me.Cmdagregartipo.Size = New System.Drawing.Size(68, 68)
        Me.Cmdagregartipo.Text = "Agregar"
        Me.Cmdagregartipo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CmdModificartipo
        '
        Me.CmdModificartipo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdModificartipo.Image = Global.SistemaEstudio.My.Resources.Resources.documentediting_editdocuments_text_documentedi_2820
        Me.CmdModificartipo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmdModificartipo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdModificartipo.Name = "CmdModificartipo"
        Me.CmdModificartipo.Size = New System.Drawing.Size(68, 68)
        Me.CmdModificartipo.Text = "Modificar"
        Me.CmdModificartipo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Cmdeliminartipo
        '
        Me.Cmdeliminartipo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdeliminartipo.Image = Global.SistemaEstudio.My.Resources.Resources.iconfinder_trash_4341321_120557
        Me.Cmdeliminartipo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdeliminartipo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdeliminartipo.Name = "Cmdeliminartipo"
        Me.Cmdeliminartipo.Size = New System.Drawing.Size(68, 68)
        Me.Cmdeliminartipo.Text = "Eliminar"
        Me.Cmdeliminartipo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'cmdsalirtipo
        '
        Me.cmdsalirtipo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsalirtipo.Image = Global.SistemaEstudio.My.Resources.Resources.Exit_Page_icon_icons_com_53732
        Me.cmdsalirtipo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdsalirtipo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdsalirtipo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsalirtipo.Name = "cmdsalirtipo"
        Me.cmdsalirtipo.Size = New System.Drawing.Size(68, 68)
        Me.cmdsalirtipo.Text = "Salir"
        '
        'fmrTipoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(322, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GrillatipoDocumento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmrTipoDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Documento"
        CType(Me.GrillatipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrillatipoDocumento As DataGridView
    Friend WithEvents ID_Obra_Social As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Cmdagregartipo As ToolStripButton
    Friend WithEvents CmdModificartipo As ToolStripButton
    Friend WithEvents Cmdeliminartipo As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdsalirtipo As ToolStripButton
End Class
