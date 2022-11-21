<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrAbmAgenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrAbmAgenda))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CmdagregarAgenda = New System.Windows.Forms.ToolStripButton()
        Me.cmdsaliragenda = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblseñalcontacto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtidagendaabm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtapellidoAgenda = New System.Windows.Forms.TextBox()
        Me.txtnombreagenda = New System.Windows.Forms.TextBox()
        Me.txtdomicilioagendaabm = New System.Windows.Forms.TextBox()
        Me.cmdlocalidad = New System.Windows.Forms.Button()
        Me.txtlocalidadagendaabm = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtcodigopostalagendaabm = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtprovinciaagendaabm = New System.Windows.Forms.TextBox()
        Me.txtcelularagendaabm = New System.Windows.Forms.TextBox()
        Me.txttelefonoagendaabm = New System.Windows.Forms.TextBox()
        Me.txtotrotelefonoagendaabm = New System.Windows.Forms.TextBox()
        Me.txtemailagendaabm = New System.Windows.Forms.TextBox()
        Me.txtsitiowebagendaabm = New System.Windows.Forms.TextBox()
        Me.txtpersonacontactoagendaabm = New System.Windows.Forms.TextBox()
        Me.txttelefonocontactoagendaabm = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdagregarAgenda, Me.cmdsaliragenda, Me.ToolStripSeparator1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(711, 71)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CmdagregarAgenda
        '
        Me.CmdagregarAgenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdagregarAgenda.Image = Global.SistemaEstudio.My.Resources.Resources.Aceptar
        Me.CmdagregarAgenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmdagregarAgenda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdagregarAgenda.Name = "CmdagregarAgenda"
        Me.CmdagregarAgenda.Size = New System.Drawing.Size(68, 68)
        Me.CmdagregarAgenda.Text = "Agregar"
        Me.CmdagregarAgenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdsaliragenda
        '
        Me.cmdsaliragenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsaliragenda.Image = Global.SistemaEstudio.My.Resources.Resources.Cancelar
        Me.cmdsaliragenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdsaliragenda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsaliragenda.Name = "cmdsaliragenda"
        Me.cmdsaliragenda.Size = New System.Drawing.Size(68, 68)
        Me.cmdsaliragenda.Text = "Salir"
        Me.cmdsaliragenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(44, 484)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 19)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "E-Mail"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(320, 484)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 19)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Sitio Web"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(320, 562)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 19)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Telefono De Contacto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(44, 562)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 19)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Persona De Contacto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(43, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 19)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Localidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(44, 417)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(458, 417)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Otro Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(256, 417)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Celular"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Domicilio"
        '
        'lblseñalcontacto
        '
        Me.lblseñalcontacto.AutoSize = True
        Me.lblseñalcontacto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseñalcontacto.ForeColor = System.Drawing.Color.White
        Me.lblseñalcontacto.Location = New System.Drawing.Point(592, 164)
        Me.lblseñalcontacto.Name = "lblseñalcontacto"
        Me.lblseñalcontacto.Size = New System.Drawing.Size(63, 19)
        Me.lblseñalcontacto.TabIndex = 81
        Me.lblseñalcontacto.Text = "Label10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(281, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Numero"
        '
        'Txtidagendaabm
        '
        Me.Txtidagendaabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Txtidagendaabm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtidagendaabm.ForeColor = System.Drawing.Color.White
        Me.Txtidagendaabm.Location = New System.Drawing.Point(366, 104)
        Me.Txtidagendaabm.Name = "Txtidagendaabm"
        Me.Txtidagendaabm.Size = New System.Drawing.Size(121, 20)
        Me.Txtidagendaabm.TabIndex = 82
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(44, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 19)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Nombre"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(43, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 19)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Apellido"
        '
        'txtapellidoAgenda
        '
        Me.txtapellidoAgenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtapellidoAgenda.ForeColor = System.Drawing.Color.White
        Me.txtapellidoAgenda.Location = New System.Drawing.Point(47, 165)
        Me.txtapellidoAgenda.Name = "txtapellidoAgenda"
        Me.txtapellidoAgenda.Size = New System.Drawing.Size(245, 20)
        Me.txtapellidoAgenda.TabIndex = 86
        '
        'txtnombreagenda
        '
        Me.txtnombreagenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtnombreagenda.ForeColor = System.Drawing.Color.White
        Me.txtnombreagenda.Location = New System.Drawing.Point(47, 230)
        Me.txtnombreagenda.Name = "txtnombreagenda"
        Me.txtnombreagenda.Size = New System.Drawing.Size(245, 20)
        Me.txtnombreagenda.TabIndex = 87
        '
        'txtdomicilioagendaabm
        '
        Me.txtdomicilioagendaabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtdomicilioagendaabm.ForeColor = System.Drawing.Color.White
        Me.txtdomicilioagendaabm.Location = New System.Drawing.Point(47, 298)
        Me.txtdomicilioagendaabm.Name = "txtdomicilioagendaabm"
        Me.txtdomicilioagendaabm.Size = New System.Drawing.Size(245, 20)
        Me.txtdomicilioagendaabm.TabIndex = 88
        '
        'cmdlocalidad
        '
        Me.cmdlocalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdlocalidad.Location = New System.Drawing.Point(222, 365)
        Me.cmdlocalidad.Name = "cmdlocalidad"
        Me.cmdlocalidad.Size = New System.Drawing.Size(93, 21)
        Me.cmdlocalidad.TabIndex = 89
        Me.cmdlocalidad.Text = "Buscar"
        Me.cmdlocalidad.UseVisualStyleBackColor = True
        '
        'txtlocalidadagendaabm
        '
        Me.txtlocalidadagendaabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtlocalidadagendaabm.ForeColor = System.Drawing.Color.White
        Me.txtlocalidadagendaabm.Location = New System.Drawing.Point(48, 366)
        Me.txtlocalidadagendaabm.Name = "txtlocalidadagendaabm"
        Me.txtlocalidadagendaabm.Size = New System.Drawing.Size(168, 20)
        Me.txtlocalidadagendaabm.TabIndex = 90
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(331, 344)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 19)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Codigo Postal"
        '
        'txtcodigopostalagendaabm
        '
        Me.txtcodigopostalagendaabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtcodigopostalagendaabm.ForeColor = System.Drawing.Color.White
        Me.txtcodigopostalagendaabm.Location = New System.Drawing.Point(328, 366)
        Me.txtcodigopostalagendaabm.Name = "txtcodigopostalagendaabm"
        Me.txtcodigopostalagendaabm.Size = New System.Drawing.Size(113, 20)
        Me.txtcodigopostalagendaabm.TabIndex = 92
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(461, 344)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 19)
        Me.Label14.TabIndex = 93
        Me.Label14.Text = "Provincia"
        '
        'txtprovinciaagendaabm
        '
        Me.txtprovinciaagendaabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtprovinciaagendaabm.ForeColor = System.Drawing.Color.White
        Me.txtprovinciaagendaabm.Location = New System.Drawing.Point(462, 365)
        Me.txtprovinciaagendaabm.Name = "txtprovinciaagendaabm"
        Me.txtprovinciaagendaabm.Size = New System.Drawing.Size(168, 20)
        Me.txtprovinciaagendaabm.TabIndex = 95
        '
        'txtcelularagendaabm
        '
        Me.txtcelularagendaabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtcelularagendaabm.ForeColor = System.Drawing.Color.White
        Me.txtcelularagendaabm.Location = New System.Drawing.Point(255, 439)
        Me.txtcelularagendaabm.Name = "txtcelularagendaabm"
        Me.txtcelularagendaabm.Size = New System.Drawing.Size(168, 20)
        Me.txtcelularagendaabm.TabIndex = 96
        '
        'txttelefonoagendaabm
        '
        Me.txttelefonoagendaabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txttelefonoagendaabm.ForeColor = System.Drawing.Color.White
        Me.txttelefonoagendaabm.Location = New System.Drawing.Point(48, 439)
        Me.txttelefonoagendaabm.Name = "txttelefonoagendaabm"
        Me.txttelefonoagendaabm.Size = New System.Drawing.Size(168, 20)
        Me.txttelefonoagendaabm.TabIndex = 97
        '
        'txtotrotelefonoagendaabm
        '
        Me.txtotrotelefonoagendaabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtotrotelefonoagendaabm.ForeColor = System.Drawing.Color.White
        Me.txtotrotelefonoagendaabm.Location = New System.Drawing.Point(462, 439)
        Me.txtotrotelefonoagendaabm.Name = "txtotrotelefonoagendaabm"
        Me.txtotrotelefonoagendaabm.Size = New System.Drawing.Size(168, 20)
        Me.txtotrotelefonoagendaabm.TabIndex = 98
        '
        'txtemailagendaabm
        '
        Me.txtemailagendaabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtemailagendaabm.ForeColor = System.Drawing.Color.White
        Me.txtemailagendaabm.Location = New System.Drawing.Point(48, 506)
        Me.txtemailagendaabm.Name = "txtemailagendaabm"
        Me.txtemailagendaabm.Size = New System.Drawing.Size(245, 20)
        Me.txtemailagendaabm.TabIndex = 99
        '
        'txtsitiowebagendaabm
        '
        Me.txtsitiowebagendaabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtsitiowebagendaabm.ForeColor = System.Drawing.Color.White
        Me.txtsitiowebagendaabm.Location = New System.Drawing.Point(324, 506)
        Me.txtsitiowebagendaabm.Name = "txtsitiowebagendaabm"
        Me.txtsitiowebagendaabm.Size = New System.Drawing.Size(245, 20)
        Me.txtsitiowebagendaabm.TabIndex = 100
        '
        'txtpersonacontactoagendaabm
        '
        Me.txtpersonacontactoagendaabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtpersonacontactoagendaabm.ForeColor = System.Drawing.Color.White
        Me.txtpersonacontactoagendaabm.Location = New System.Drawing.Point(47, 584)
        Me.txtpersonacontactoagendaabm.Name = "txtpersonacontactoagendaabm"
        Me.txtpersonacontactoagendaabm.Size = New System.Drawing.Size(245, 20)
        Me.txtpersonacontactoagendaabm.TabIndex = 101
        '
        'txttelefonocontactoagendaabm
        '
        Me.txttelefonocontactoagendaabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txttelefonocontactoagendaabm.ForeColor = System.Drawing.Color.White
        Me.txttelefonocontactoagendaabm.Location = New System.Drawing.Point(324, 584)
        Me.txttelefonocontactoagendaabm.Name = "txttelefonocontactoagendaabm"
        Me.txttelefonocontactoagendaabm.Size = New System.Drawing.Size(245, 20)
        Me.txttelefonocontactoagendaabm.TabIndex = 102
        '
        'FmrAbmAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(711, 623)
        Me.Controls.Add(Me.txttelefonocontactoagendaabm)
        Me.Controls.Add(Me.txtpersonacontactoagendaabm)
        Me.Controls.Add(Me.txtsitiowebagendaabm)
        Me.Controls.Add(Me.txtemailagendaabm)
        Me.Controls.Add(Me.txtotrotelefonoagendaabm)
        Me.Controls.Add(Me.txttelefonoagendaabm)
        Me.Controls.Add(Me.txtcelularagendaabm)
        Me.Controls.Add(Me.txtprovinciaagendaabm)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtcodigopostalagendaabm)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtlocalidadagendaabm)
        Me.Controls.Add(Me.cmdlocalidad)
        Me.Controls.Add(Me.txtdomicilioagendaabm)
        Me.Controls.Add(Me.txtnombreagenda)
        Me.Controls.Add(Me.txtapellidoAgenda)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtidagendaabm)
        Me.Controls.Add(Me.lblseñalcontacto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmrAbmAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM - Agenda "
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents CmdagregarAgenda As ToolStripButton
    Friend WithEvents cmdsaliragenda As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblseñalcontacto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtidagendaabm As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtapellidoAgenda As TextBox
    Friend WithEvents txtnombreagenda As TextBox
    Friend WithEvents txtdomicilioagendaabm As TextBox
    Friend WithEvents cmdlocalidad As Button
    Friend WithEvents txtlocalidadagendaabm As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtcodigopostalagendaabm As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtprovinciaagendaabm As TextBox
    Friend WithEvents txtcelularagendaabm As TextBox
    Friend WithEvents txttelefonoagendaabm As TextBox
    Friend WithEvents txtotrotelefonoagendaabm As TextBox
    Friend WithEvents txtemailagendaabm As TextBox
    Friend WithEvents txtsitiowebagendaabm As TextBox
    Friend WithEvents txtpersonacontactoagendaabm As TextBox
    Friend WithEvents txttelefonocontactoagendaabm As TextBox
End Class
