<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmrPaciente
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
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrPaciente))
        Me.Grillapacientes = New System.Windows.Forms.DataGridView()
        Me.ID_Paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoPostal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtroTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObraSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAltaSistema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroAfiliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.lblseñalpacienteturno = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cmdagregar = New System.Windows.Forms.ToolStripButton()
        Me.CmdModificar = New System.Windows.Forms.ToolStripButton()
        Me.Cmdeliminar = New System.Windows.Forms.ToolStripButton()
        Me.cmdsalir1 = New System.Windows.Forms.ToolStripButton()
        Me.GrillaEstudio = New System.Windows.Forms.DataGridView()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estudio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Informe1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mutual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroAfiliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        CType(Me.Grillapacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GrillaEstudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grillapacientes
        '
        Me.Grillapacientes.AllowUserToAddRows = False
        Me.Grillapacientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Grillapacientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grillapacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Grillapacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grillapacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.Grillapacientes.ColumnHeadersHeight = 35
        Me.Grillapacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Grillapacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Paciente, Me.Apellido, Me.Nombre, Me.Domicilio, Me.Localidad, Me.CodigoPostal, Me.Provincia, Me.Telefono, Me.Celular, Me.OtroTelefono, Me.Edad, Me.TipoDocumento, Me.NumeroDocumento, Me.FechaNacimiento, Me.ObraSocial, Me.FechaAltaSistema, Me.NumeroAfiliado, Me.Email, Me.Activo})
        Me.Grillapacientes.EnableHeadersVisualStyles = False
        Me.Grillapacientes.GridColor = System.Drawing.Color.SteelBlue
        Me.Grillapacientes.Location = New System.Drawing.Point(-3, 30)
        Me.Grillapacientes.Name = "Grillapacientes"
        Me.Grillapacientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grillapacientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle32
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.White
        Me.Grillapacientes.RowsDefaultCellStyle = DataGridViewCellStyle33
        Me.Grillapacientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grillapacientes.Size = New System.Drawing.Size(1022, 337)
        Me.Grillapacientes.TabIndex = 4
        '
        'ID_Paciente
        '
        Me.ID_Paciente.HeaderText = "Numero"
        Me.ID_Paciente.Name = "ID_Paciente"
        Me.ID_Paciente.Width = 80
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Width = 150
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 150
        '
        'Domicilio
        '
        Me.Domicilio.HeaderText = "Domicilio"
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.Width = 150
        '
        'Localidad
        '
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.Visible = False
        Me.Localidad.Width = 150
        '
        'CodigoPostal
        '
        Me.CodigoPostal.HeaderText = "Codigo Postal"
        Me.CodigoPostal.Name = "CodigoPostal"
        Me.CodigoPostal.Visible = False
        '
        'Provincia
        '
        Me.Provincia.HeaderText = "Provincia"
        Me.Provincia.Name = "Provincia"
        Me.Provincia.Visible = False
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Visible = False
        Me.Telefono.Width = 150
        '
        'Celular
        '
        Me.Celular.HeaderText = "Celular"
        Me.Celular.Name = "Celular"
        Me.Celular.Visible = False
        '
        'OtroTelefono
        '
        Me.OtroTelefono.HeaderText = "OtroTelefono"
        Me.OtroTelefono.Name = "OtroTelefono"
        Me.OtroTelefono.Visible = False
        '
        'Edad
        '
        Me.Edad.HeaderText = "Edad"
        Me.Edad.Name = "Edad"
        Me.Edad.Visible = False
        '
        'TipoDocumento
        '
        Me.TipoDocumento.HeaderText = "Tipo De Documento"
        Me.TipoDocumento.Name = "TipoDocumento"
        Me.TipoDocumento.Visible = False
        Me.TipoDocumento.Width = 150
        '
        'NumeroDocumento
        '
        Me.NumeroDocumento.HeaderText = "Numero Documento"
        Me.NumeroDocumento.Name = "NumeroDocumento"
        Me.NumeroDocumento.Width = 150
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.HeaderText = "Fecha Nacimiento"
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.Visible = False
        '
        'ObraSocial
        '
        Me.ObraSocial.HeaderText = "Obra Social"
        Me.ObraSocial.Name = "ObraSocial"
        Me.ObraSocial.Width = 150
        '
        'FechaAltaSistema
        '
        Me.FechaAltaSistema.HeaderText = "FechaAltaSistema"
        Me.FechaAltaSistema.Name = "FechaAltaSistema"
        Me.FechaAltaSistema.Visible = False
        '
        'NumeroAfiliado
        '
        Me.NumeroAfiliado.HeaderText = "Nro Afiliado"
        Me.NumeroAfiliado.Name = "NumeroAfiliado"
        Me.NumeroAfiliado.Width = 150
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.Visible = False
        '
        'Activo
        '
        Me.Activo.HeaderText = "Activo"
        Me.Activo.Name = "Activo"
        Me.Activo.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Grillapacientes)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1019, 373)
        Me.Panel1.TabIndex = 112
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton4, Me.ToolStripButton6, Me.ToolStripButton2})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(1027, 400)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(69, 286)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.SistemaEstudio.My.Resources.Resources.businesspackage_additionalpackage_box_add_insert_negoci_2335__1_
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(67, 68)
        Me.ToolStripButton1.Text = "Agregar"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.SistemaEstudio.My.Resources.Resources.documentediting_editdocuments_text_documentedi_2820
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(67, 68)
        Me.ToolStripButton4.Text = "Modificar"
        Me.ToolStripButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = Global.SistemaEstudio.My.Resources.Resources.apps_printer_15747
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(67, 68)
        Me.ToolStripButton6.Text = "Imprimir"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.SistemaEstudio.My.Resources.Resources.iconfinder_trash_4341321_120557
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(67, 68)
        Me.ToolStripButton2.Text = "Eliminar"
        Me.ToolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblseñalpacienteturno
        '
        Me.lblseñalpacienteturno.AutoSize = True
        Me.lblseñalpacienteturno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseñalpacienteturno.ForeColor = System.Drawing.Color.White
        Me.lblseñalpacienteturno.Location = New System.Drawing.Point(1025, 381)
        Me.lblseñalpacienteturno.Name = "lblseñalpacienteturno"
        Me.lblseñalpacienteturno.Size = New System.Drawing.Size(63, 19)
        Me.lblseñalpacienteturno.TabIndex = 111
        Me.lblseñalpacienteturno.Text = "Label10"
        Me.lblseñalpacienteturno.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cmdagregar, Me.CmdModificar, Me.Cmdeliminar, Me.cmdsalir1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(1027, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(69, 286)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Cmdagregar
        '
        Me.Cmdagregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdagregar.Image = Global.SistemaEstudio.My.Resources.Resources.businesspackage_additionalpackage_box_add_insert_negoci_2335__1_
        Me.Cmdagregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdagregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdagregar.Name = "Cmdagregar"
        Me.Cmdagregar.Size = New System.Drawing.Size(67, 68)
        Me.Cmdagregar.Text = "Agregar"
        Me.Cmdagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CmdModificar
        '
        Me.CmdModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdModificar.Image = Global.SistemaEstudio.My.Resources.Resources.documentediting_editdocuments_text_documentedi_2820
        Me.CmdModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmdModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdModificar.Name = "CmdModificar"
        Me.CmdModificar.Size = New System.Drawing.Size(67, 68)
        Me.CmdModificar.Text = "Modificar"
        Me.CmdModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Cmdeliminar
        '
        Me.Cmdeliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdeliminar.Image = Global.SistemaEstudio.My.Resources.Resources.iconfinder_trash_4341321_120557
        Me.Cmdeliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdeliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdeliminar.Name = "Cmdeliminar"
        Me.Cmdeliminar.Size = New System.Drawing.Size(67, 68)
        Me.Cmdeliminar.Text = "Eliminar"
        Me.Cmdeliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdsalir1
        '
        Me.cmdsalir1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsalir1.Image = Global.SistemaEstudio.My.Resources.Resources.Exit_Page_icon_icons_com_53732
        Me.cmdsalir1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdsalir1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdsalir1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsalir1.Name = "cmdsalir1"
        Me.cmdsalir1.Size = New System.Drawing.Size(67, 68)
        Me.cmdsalir1.Text = "Salir"
        '
        'GrillaEstudio
        '
        Me.GrillaEstudio.AllowUserToAddRows = False
        Me.GrillaEstudio.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GrillaEstudio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrillaEstudio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GrillaEstudio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle34.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaEstudio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle34
        Me.GrillaEstudio.ColumnHeadersHeight = 35
        Me.GrillaEstudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaEstudio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.Fecha, Me.Estudio, Me.Medico, Me.Paciente, Me.Informe1, Me.Importe, Me.Mutual, Me.NroAfiliado})
        Me.GrillaEstudio.EnableHeadersVisualStyles = False
        Me.GrillaEstudio.GridColor = System.Drawing.Color.SteelBlue
        Me.GrillaEstudio.Location = New System.Drawing.Point(0, 33)
        Me.GrillaEstudio.Name = "GrillaEstudio"
        Me.GrillaEstudio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaEstudio.RowHeadersDefaultCellStyle = DataGridViewCellStyle35
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White
        Me.GrillaEstudio.RowsDefaultCellStyle = DataGridViewCellStyle36
        Me.GrillaEstudio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GrillaEstudio.Size = New System.Drawing.Size(1019, 229)
        Me.GrillaEstudio.TabIndex = 4
        '
        'Numero
        '
        Me.Numero.HeaderText = "Numero"
        Me.Numero.Name = "Numero"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 200
        '
        'Estudio
        '
        Me.Estudio.HeaderText = "Estudio"
        Me.Estudio.Name = "Estudio"
        Me.Estudio.Width = 500
        '
        'Medico
        '
        Me.Medico.HeaderText = "Medico"
        Me.Medico.Name = "Medico"
        Me.Medico.Width = 200
        '
        'Paciente
        '
        Me.Paciente.HeaderText = "ID_Paciente"
        Me.Paciente.Name = "Paciente"
        Me.Paciente.Visible = False
        '
        'Informe1
        '
        Me.Informe1.HeaderText = "Informe1"
        Me.Informe1.Name = "Informe1"
        Me.Informe1.Visible = False
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.Visible = False
        '
        'Mutual
        '
        Me.Mutual.HeaderText = "ObraSocial"
        Me.Mutual.Name = "Mutual"
        Me.Mutual.Visible = False
        '
        'NroAfiliado
        '
        Me.NroAfiliado.HeaderText = "NroAfiliado"
        Me.NroAfiliado.Name = "NroAfiliado"
        Me.NroAfiliado.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(406, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 24)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Estudios Realizados Por Paciente"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.GrillaEstudio)
        Me.Panel2.Location = New System.Drawing.Point(0, 395)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1019, 305)
        Me.Panel2.TabIndex = 113
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.SalirToolStripMenuItem.Text = "Volver"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1095, 24)
        Me.MenuStrip1.TabIndex = 111
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'txtbuscar
        '
        Me.txtbuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtbuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtbuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.ForeColor = System.Drawing.SystemColors.Window
        Me.txtbuscar.Location = New System.Drawing.Point(424, 2)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(210, 22)
        Me.txtbuscar.TabIndex = 55
        Me.txtbuscar.Text = "Buscar..."
        '
        'FmrPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1095, 705)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblseñalpacienteturno)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmrPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo - Paciente "
        CType(Me.Grillapacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GrillaEstudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grillapacientes As DataGridView
    Friend WithEvents ID_Paciente As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As DataGridViewTextBoxColumn
    Friend WithEvents Localidad As DataGridViewTextBoxColumn
    Friend WithEvents CodigoPostal As DataGridViewTextBoxColumn
    Friend WithEvents Provincia As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Celular As DataGridViewTextBoxColumn
    Friend WithEvents OtroTelefono As DataGridViewTextBoxColumn
    Friend WithEvents Edad As DataGridViewTextBoxColumn
    Friend WithEvents TipoDocumento As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDocumento As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents ObraSocial As DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaSistema As DataGridViewTextBoxColumn
    Friend WithEvents NumeroAfiliado As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblseñalpacienteturno As Label
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents Cmdagregar As ToolStripButton
    Friend WithEvents CmdModificar As ToolStripButton
    Friend WithEvents Cmdeliminar As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GrillaEstudio As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdsalir1 As ToolStripButton
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Estudio As DataGridViewTextBoxColumn
    Friend WithEvents Medico As DataGridViewTextBoxColumn
    Friend WithEvents Paciente As DataGridViewTextBoxColumn
    Friend WithEvents Informe1 As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Mutual As DataGridViewTextBoxColumn
    Friend WithEvents NroAfiliado As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents txtbuscar As TextBox
End Class
