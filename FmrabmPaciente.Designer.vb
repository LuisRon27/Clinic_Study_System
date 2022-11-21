<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmrabmPaciente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrabmPaciente))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cmdagregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdsalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdlocalidad = New System.Windows.Forms.Button()
        Me.txtlocalidad = New System.Windows.Forms.TextBox()
        Me.lblseñal = New System.Windows.Forms.Label()
        Me.dtfechaingreso = New System.Windows.Forms.DateTimePicker()
        Me.dtfechanacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.Txtid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnumerodocumento = New System.Windows.Forms.TextBox()
        Me.Cmdobrasocial = New System.Windows.Forms.Button()
        Me.txtobrasocial = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtdomicilioPacienteAbm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProvinciapacienteabm = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcodigopostalAbmPaciente = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtotrotelefonoPacienteabm = New System.Windows.Forms.TextBox()
        Me.txtcelularpacienteabm = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtedadpacienteabm = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtnroAfiliadopacienteabm = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtemailpacienteabm = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cmdagregar, Me.cmdsalir, Me.ToolStripSeparator1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(753, 71)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Cmdagregar
        '
        Me.Cmdagregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdagregar.Image = Global.SistemaEstudio.My.Resources.Resources.Aceptar
        Me.Cmdagregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdagregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdagregar.Name = "Cmdagregar"
        Me.Cmdagregar.Size = New System.Drawing.Size(68, 68)
        Me.Cmdagregar.Text = "Agregar"
        Me.Cmdagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdsalir
        '
        Me.cmdsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsalir.Image = Global.SistemaEstudio.My.Resources.Resources.Cancelar
        Me.cmdsalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(68, 68)
        Me.cmdsalir.Text = "Salir"
        Me.cmdsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'cmdlocalidad
        '
        Me.cmdlocalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdlocalidad.Location = New System.Drawing.Point(210, 316)
        Me.cmdlocalidad.Name = "cmdlocalidad"
        Me.cmdlocalidad.Size = New System.Drawing.Size(93, 21)
        Me.cmdlocalidad.TabIndex = 47
        Me.cmdlocalidad.Text = "Buscar"
        Me.cmdlocalidad.UseVisualStyleBackColor = True
        '
        'txtlocalidad
        '
        Me.txtlocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtlocalidad.ForeColor = System.Drawing.Color.White
        Me.txtlocalidad.Location = New System.Drawing.Point(40, 317)
        Me.txtlocalidad.Name = "txtlocalidad"
        Me.txtlocalidad.Size = New System.Drawing.Size(164, 20)
        Me.txtlocalidad.TabIndex = 46
        '
        'lblseñal
        '
        Me.lblseñal.AutoSize = True
        Me.lblseñal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseñal.ForeColor = System.Drawing.Color.White
        Me.lblseñal.Location = New System.Drawing.Point(642, 89)
        Me.lblseñal.Name = "lblseñal"
        Me.lblseñal.Size = New System.Drawing.Size(63, 19)
        Me.lblseñal.TabIndex = 43
        Me.lblseñal.Text = "Label10"
        '
        'dtfechaingreso
        '
        Me.dtfechaingreso.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.dtfechaingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechaingreso.Location = New System.Drawing.Point(327, 580)
        Me.dtfechaingreso.Name = "dtfechaingreso"
        Me.dtfechaingreso.Size = New System.Drawing.Size(200, 20)
        Me.dtfechaingreso.TabIndex = 42
        '
        'dtfechanacimiento
        '
        Me.dtfechanacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.dtfechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechanacimiento.Location = New System.Drawing.Point(316, 509)
        Me.dtfechanacimiento.Name = "dtfechanacimiento"
        Me.dtfechanacimiento.Size = New System.Drawing.Size(200, 20)
        Me.dtfechanacimiento.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(323, 557)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 19)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Fecha Alta Sistema"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(323, 489)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 19)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Fecha Nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(241, 425)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 19)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Numero De Documento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(36, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 19)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Localidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 424)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 19)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Tipo De Documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(35, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 19)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(34, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(284, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Numero"
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txttelefono.ForeColor = System.Drawing.Color.White
        Me.txttelefono.Location = New System.Drawing.Point(40, 377)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(245, 20)
        Me.txttelefono.TabIndex = 31
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtnombre.ForeColor = System.Drawing.Color.White
        Me.txtnombre.Location = New System.Drawing.Point(38, 202)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(247, 20)
        Me.txtnombre.TabIndex = 29
        '
        'txtapellido
        '
        Me.txtapellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtapellido.ForeColor = System.Drawing.Color.White
        Me.txtapellido.Location = New System.Drawing.Point(38, 145)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(246, 20)
        Me.txtapellido.TabIndex = 28
        '
        'Txtid
        '
        Me.Txtid.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtid.ForeColor = System.Drawing.Color.White
        Me.Txtid.Location = New System.Drawing.Point(369, 90)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.Size = New System.Drawing.Size(121, 20)
        Me.Txtid.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(36, 489)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 19)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Obra Social"
        '
        'txtnumerodocumento
        '
        Me.txtnumerodocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtnumerodocumento.ForeColor = System.Drawing.Color.White
        Me.txtnumerodocumento.Location = New System.Drawing.Point(245, 447)
        Me.txtnumerodocumento.Name = "txtnumerodocumento"
        Me.txtnumerodocumento.Size = New System.Drawing.Size(196, 20)
        Me.txtnumerodocumento.TabIndex = 50
        '
        'Cmdobrasocial
        '
        Me.Cmdobrasocial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmdobrasocial.Location = New System.Drawing.Point(210, 510)
        Me.Cmdobrasocial.Name = "Cmdobrasocial"
        Me.Cmdobrasocial.Size = New System.Drawing.Size(93, 21)
        Me.Cmdobrasocial.TabIndex = 52
        Me.Cmdobrasocial.Text = "Buscar"
        Me.Cmdobrasocial.UseVisualStyleBackColor = True
        '
        'txtobrasocial
        '
        Me.txtobrasocial.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtobrasocial.ForeColor = System.Drawing.Color.White
        Me.txtobrasocial.Location = New System.Drawing.Point(40, 511)
        Me.txtobrasocial.Name = "txtobrasocial"
        Me.txtobrasocial.Size = New System.Drawing.Size(164, 20)
        Me.txtobrasocial.TabIndex = 51
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(40, 446)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(186, 21)
        Me.ComboBox1.TabIndex = 53
        '
        'txtdomicilioPacienteAbm
        '
        Me.txtdomicilioPacienteAbm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtdomicilioPacienteAbm.ForeColor = System.Drawing.Color.White
        Me.txtdomicilioPacienteAbm.Location = New System.Drawing.Point(39, 257)
        Me.txtdomicilioPacienteAbm.Name = "txtdomicilioPacienteAbm"
        Me.txtdomicilioPacienteAbm.Size = New System.Drawing.Size(246, 20)
        Me.txtdomicilioPacienteAbm.TabIndex = 90
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(36, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 19)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Domicilio"
        '
        'txtProvinciapacienteabm
        '
        Me.txtProvinciapacienteabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtProvinciapacienteabm.ForeColor = System.Drawing.Color.White
        Me.txtProvinciapacienteabm.Location = New System.Drawing.Point(455, 317)
        Me.txtProvinciapacienteabm.Name = "txtProvinciapacienteabm"
        Me.txtProvinciapacienteabm.Size = New System.Drawing.Size(206, 20)
        Me.txtProvinciapacienteabm.TabIndex = 99
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(451, 296)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 19)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "Provincia"
        '
        'txtcodigopostalAbmPaciente
        '
        Me.txtcodigopostalAbmPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtcodigopostalAbmPaciente.ForeColor = System.Drawing.Color.White
        Me.txtcodigopostalAbmPaciente.Location = New System.Drawing.Point(316, 317)
        Me.txtcodigopostalAbmPaciente.Name = "txtcodigopostalAbmPaciente"
        Me.txtcodigopostalAbmPaciente.Size = New System.Drawing.Size(125, 20)
        Me.txtcodigopostalAbmPaciente.TabIndex = 97
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(323, 296)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 19)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Codigo Postal"
        '
        'txtotrotelefonoPacienteabm
        '
        Me.txtotrotelefonoPacienteabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtotrotelefonoPacienteabm.ForeColor = System.Drawing.Color.White
        Me.txtotrotelefonoPacienteabm.Location = New System.Drawing.Point(493, 377)
        Me.txtotrotelefonoPacienteabm.Name = "txtotrotelefonoPacienteabm"
        Me.txtotrotelefonoPacienteabm.Size = New System.Drawing.Size(168, 20)
        Me.txtotrotelefonoPacienteabm.TabIndex = 103
        '
        'txtcelularpacienteabm
        '
        Me.txtcelularpacienteabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtcelularpacienteabm.ForeColor = System.Drawing.Color.White
        Me.txtcelularpacienteabm.Location = New System.Drawing.Point(306, 377)
        Me.txtcelularpacienteabm.Name = "txtcelularpacienteabm"
        Me.txtcelularpacienteabm.Size = New System.Drawing.Size(168, 20)
        Me.txtcelularpacienteabm.TabIndex = 102
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(489, 355)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 19)
        Me.Label12.TabIndex = 101
        Me.Label12.Text = "Otro Telefono"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(302, 355)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 19)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "Celular"
        '
        'txtedadpacienteabm
        '
        Me.txtedadpacienteabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtedadpacienteabm.ForeColor = System.Drawing.Color.White
        Me.txtedadpacienteabm.Location = New System.Drawing.Point(532, 509)
        Me.txtedadpacienteabm.Name = "txtedadpacienteabm"
        Me.txtedadpacienteabm.Size = New System.Drawing.Size(129, 20)
        Me.txtedadpacienteabm.TabIndex = 105
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(528, 487)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 19)
        Me.Label16.TabIndex = 104
        Me.Label16.Text = "Edad"
        '
        'txtnroAfiliadopacienteabm
        '
        Me.txtnroAfiliadopacienteabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtnroAfiliadopacienteabm.ForeColor = System.Drawing.Color.White
        Me.txtnroAfiliadopacienteabm.Location = New System.Drawing.Point(38, 583)
        Me.txtnroAfiliadopacienteabm.Name = "txtnroAfiliadopacienteabm"
        Me.txtnroAfiliadopacienteabm.Size = New System.Drawing.Size(265, 20)
        Me.txtnroAfiliadopacienteabm.TabIndex = 107
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(34, 561)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 19)
        Me.Label17.TabIndex = 106
        Me.Label17.Text = "Nro Afiliado"
        '
        'txtemailpacienteabm
        '
        Me.txtemailpacienteabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtemailpacienteabm.ForeColor = System.Drawing.Color.White
        Me.txtemailpacienteabm.Location = New System.Drawing.Point(458, 447)
        Me.txtemailpacienteabm.Name = "txtemailpacienteabm"
        Me.txtemailpacienteabm.Size = New System.Drawing.Size(203, 20)
        Me.txtemailpacienteabm.TabIndex = 109
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(454, 425)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 19)
        Me.Label18.TabIndex = 108
        Me.Label18.Text = "E-Mail"
        '
        'FmrabmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(753, 624)
        Me.Controls.Add(Me.txtemailpacienteabm)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtnroAfiliadopacienteabm)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtedadpacienteabm)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtotrotelefonoPacienteabm)
        Me.Controls.Add(Me.txtcelularpacienteabm)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtProvinciapacienteabm)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtcodigopostalAbmPaciente)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtdomicilioPacienteAbm)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Cmdobrasocial)
        Me.Controls.Add(Me.txtobrasocial)
        Me.Controls.Add(Me.txtnumerodocumento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdlocalidad)
        Me.Controls.Add(Me.txtlocalidad)
        Me.Controls.Add(Me.lblseñal)
        Me.Controls.Add(Me.dtfechaingreso)
        Me.Controls.Add(Me.dtfechanacimiento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.Txtid)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmrabmPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM - Paciente"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Cmdagregar As ToolStripButton
    Friend WithEvents cmdsalir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdlocalidad As Button
    Friend WithEvents txtlocalidad As TextBox
    Friend WithEvents lblseñal As Label
    Friend WithEvents dtfechaingreso As DateTimePicker
    Friend WithEvents dtfechanacimiento As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents Txtid As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtnumerodocumento As TextBox
    Friend WithEvents Cmdobrasocial As Button
    Friend WithEvents txtobrasocial As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtdomicilioPacienteAbm As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtProvinciapacienteabm As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtcodigopostalAbmPaciente As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtotrotelefonoPacienteabm As TextBox
    Friend WithEvents txtcelularpacienteabm As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtedadpacienteabm As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtnroAfiliadopacienteabm As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtemailpacienteabm As TextBox
    Friend WithEvents Label18 As Label
End Class
