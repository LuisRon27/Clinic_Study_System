<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmrAgenda
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrAgenda))
        Me.Grillaagenda = New System.Windows.Forms.DataGridView()
        Me.ID_Paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtroTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaginaWeb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonasContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoPostal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cmdagregar = New System.Windows.Forms.ToolStripButton()
        Me.CmdModificar = New System.Windows.Forms.ToolStripButton()
        Me.Cmdeliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdsalir1 = New System.Windows.Forms.ToolStripButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDomicilioAgenda = New System.Windows.Forms.TextBox()
        Me.txtlocalidadAgenda = New System.Windows.Forms.TextBox()
        Me.TxtcelularAgenda = New System.Windows.Forms.TextBox()
        Me.txttelefonoagenda = New System.Windows.Forms.TextBox()
        Me.Txtpersonacontacto = New System.Windows.Forms.TextBox()
        Me.TxtOtroTelefono = New System.Windows.Forms.TextBox()
        Me.Txtemail = New System.Windows.Forms.TextBox()
        Me.txttelefonocontacto = New System.Windows.Forms.TextBox()
        Me.TxtsitioWeb = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigopostal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.Grillaagenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grillaagenda
        '
        Me.Grillaagenda.AllowUserToAddRows = False
        Me.Grillaagenda.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Grillaagenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grillaagenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Grillaagenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grillaagenda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Grillaagenda.ColumnHeadersHeight = 35
        Me.Grillaagenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Grillaagenda.ColumnHeadersVisible = False
        Me.Grillaagenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Paciente, Me.ID_Localidad, Me.Apellido, Me.Nombre, Me.Telefono, Me.Celular, Me.OtroTelefono, Me.Email, Me.PaginaWeb, Me.PersonasContacto, Me.TelefonoContacto, Me.Direccion, Me.CodigoPostal, Me.Provincia})
        Me.Grillaagenda.EnableHeadersVisualStyles = False
        Me.Grillaagenda.GridColor = System.Drawing.Color.SteelBlue
        Me.Grillaagenda.Location = New System.Drawing.Point(0, 146)
        Me.Grillaagenda.Name = "Grillaagenda"
        Me.Grillaagenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grillaagenda.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Grillaagenda.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grillaagenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grillaagenda.Size = New System.Drawing.Size(420, 434)
        Me.Grillaagenda.TabIndex = 5
        '
        'ID_Paciente
        '
        Me.ID_Paciente.HeaderText = "Numero"
        Me.ID_Paciente.Name = "ID_Paciente"
        Me.ID_Paciente.Width = 80
        '
        'ID_Localidad
        '
        Me.ID_Localidad.HeaderText = "Localidad"
        Me.ID_Localidad.Name = "ID_Localidad"
        Me.ID_Localidad.Visible = False
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
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Visible = False
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
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.Visible = False
        '
        'PaginaWeb
        '
        Me.PaginaWeb.HeaderText = "PaginaWeb"
        Me.PaginaWeb.Name = "PaginaWeb"
        Me.PaginaWeb.Visible = False
        '
        'PersonasContacto
        '
        Me.PersonasContacto.HeaderText = "PersonaContacto"
        Me.PersonasContacto.Name = "PersonasContacto"
        Me.PersonasContacto.Visible = False
        '
        'TelefonoContacto
        '
        Me.TelefonoContacto.HeaderText = "TelefonoContacto"
        Me.TelefonoContacto.Name = "TelefonoContacto"
        Me.TelefonoContacto.Visible = False
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Visible = False
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cmdagregar, Me.CmdModificar, Me.Cmdeliminar, Me.ToolStripSeparator1, Me.cmdsalir1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(954, 71)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Cmdagregar
        '
        Me.Cmdagregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdagregar.Image = Global.SistemaEstudio.My.Resources.Resources.businesspackage_additionalpackage_box_add_insert_negoci_2335__1_
        Me.Cmdagregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdagregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdagregar.Name = "Cmdagregar"
        Me.Cmdagregar.Size = New System.Drawing.Size(68, 68)
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
        Me.CmdModificar.Size = New System.Drawing.Size(68, 68)
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
        Me.Cmdeliminar.Size = New System.Drawing.Size(68, 68)
        Me.Cmdeliminar.Text = "Eliminar"
        Me.Cmdeliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'cmdsalir1
        '
        Me.cmdsalir1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsalir1.Image = Global.SistemaEstudio.My.Resources.Resources.Exit_Page_icon_icons_com_53732
        Me.cmdsalir1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdsalir1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdsalir1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsalir1.Name = "cmdsalir1"
        Me.cmdsalir1.Size = New System.Drawing.Size(68, 68)
        Me.cmdsalir1.Text = "Salir"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(537, 406)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 19)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "E-Mail"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(527, 441)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 19)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Sitio Web"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(445, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 19)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Telefono De Contacto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(449, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 19)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Persona De Contacto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(445, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 19)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Localidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(533, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(491, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Otro Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(535, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Celular"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(521, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Domicilio"
        '
        'TxtDomicilioAgenda
        '
        Me.TxtDomicilioAgenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TxtDomicilioAgenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDomicilioAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDomicilioAgenda.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtDomicilioAgenda.Location = New System.Drawing.Point(613, 145)
        Me.TxtDomicilioAgenda.Name = "TxtDomicilioAgenda"
        Me.TxtDomicilioAgenda.Size = New System.Drawing.Size(165, 22)
        Me.TxtDomicilioAgenda.TabIndex = 54
        '
        'txtlocalidadAgenda
        '
        Me.txtlocalidadAgenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtlocalidadAgenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlocalidadAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocalidadAgenda.ForeColor = System.Drawing.SystemColors.Window
        Me.txtlocalidadAgenda.Location = New System.Drawing.Point(539, 187)
        Me.txtlocalidadAgenda.Name = "txtlocalidadAgenda"
        Me.txtlocalidadAgenda.Size = New System.Drawing.Size(165, 22)
        Me.txtlocalidadAgenda.TabIndex = 72
        '
        'TxtcelularAgenda
        '
        Me.TxtcelularAgenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TxtcelularAgenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtcelularAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtcelularAgenda.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtcelularAgenda.Location = New System.Drawing.Point(613, 258)
        Me.TxtcelularAgenda.Name = "TxtcelularAgenda"
        Me.TxtcelularAgenda.Size = New System.Drawing.Size(165, 22)
        Me.TxtcelularAgenda.TabIndex = 74
        '
        'txttelefonoagenda
        '
        Me.txttelefonoagenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txttelefonoagenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttelefonoagenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefonoagenda.ForeColor = System.Drawing.SystemColors.Window
        Me.txttelefonoagenda.Location = New System.Drawing.Point(613, 220)
        Me.txttelefonoagenda.Name = "txttelefonoagenda"
        Me.txttelefonoagenda.Size = New System.Drawing.Size(165, 22)
        Me.txttelefonoagenda.TabIndex = 73
        '
        'Txtpersonacontacto
        '
        Me.Txtpersonacontacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Txtpersonacontacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtpersonacontacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpersonacontacto.ForeColor = System.Drawing.SystemColors.Window
        Me.Txtpersonacontacto.Location = New System.Drawing.Point(613, 334)
        Me.Txtpersonacontacto.Name = "Txtpersonacontacto"
        Me.Txtpersonacontacto.Size = New System.Drawing.Size(165, 22)
        Me.Txtpersonacontacto.TabIndex = 76
        '
        'TxtOtroTelefono
        '
        Me.TxtOtroTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TxtOtroTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOtroTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOtroTelefono.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtOtroTelefono.Location = New System.Drawing.Point(613, 297)
        Me.TxtOtroTelefono.Name = "TxtOtroTelefono"
        Me.TxtOtroTelefono.Size = New System.Drawing.Size(165, 22)
        Me.TxtOtroTelefono.TabIndex = 75
        '
        'Txtemail
        '
        Me.Txtemail.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtemail.ForeColor = System.Drawing.SystemColors.Window
        Me.Txtemail.Location = New System.Drawing.Point(613, 405)
        Me.Txtemail.Name = "Txtemail"
        Me.Txtemail.Size = New System.Drawing.Size(240, 22)
        Me.Txtemail.TabIndex = 78
        '
        'txttelefonocontacto
        '
        Me.txttelefonocontacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txttelefonocontacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttelefonocontacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefonocontacto.ForeColor = System.Drawing.SystemColors.Window
        Me.txttelefonocontacto.Location = New System.Drawing.Point(613, 368)
        Me.txttelefonocontacto.Name = "txttelefonocontacto"
        Me.txttelefonocontacto.Size = New System.Drawing.Size(165, 22)
        Me.txttelefonocontacto.TabIndex = 77
        '
        'TxtsitioWeb
        '
        Me.TxtsitioWeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TxtsitioWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtsitioWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtsitioWeb.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtsitioWeb.Location = New System.Drawing.Point(613, 440)
        Me.TxtsitioWeb.Name = "TxtsitioWeb"
        Me.TxtsitioWeb.Size = New System.Drawing.Size(240, 22)
        Me.TxtsitioWeb.TabIndex = 79
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 27)
        Me.Panel1.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(155, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 22)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Contactos"
        '
        'txtcodigopostal
        '
        Me.txtcodigopostal.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtcodigopostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigopostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigopostal.ForeColor = System.Drawing.SystemColors.Window
        Me.txtcodigopostal.Location = New System.Drawing.Point(830, 187)
        Me.txtcodigopostal.Name = "txtcodigopostal"
        Me.txtcodigopostal.Size = New System.Drawing.Size(97, 22)
        Me.txtcodigopostal.TabIndex = 83
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(723, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 19)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Codigo Postal"
        '
        'FmrAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 539)
        Me.Controls.Add(Me.txtcodigopostal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtsitioWeb)
        Me.Controls.Add(Me.Txtemail)
        Me.Controls.Add(Me.txttelefonocontacto)
        Me.Controls.Add(Me.Txtpersonacontacto)
        Me.Controls.Add(Me.TxtOtroTelefono)
        Me.Controls.Add(Me.TxtcelularAgenda)
        Me.Controls.Add(Me.txttelefonoagenda)
        Me.Controls.Add(Me.txtlocalidadAgenda)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDomicilioAgenda)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Grillaagenda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmrAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FmrAgenda"
        CType(Me.Grillaagenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grillaagenda As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Cmdagregar As ToolStripButton
    Friend WithEvents CmdModificar As ToolStripButton
    Friend WithEvents Cmdeliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdsalir1 As ToolStripButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDomicilioAgenda As TextBox
    Friend WithEvents txtlocalidadAgenda As TextBox
    Friend WithEvents TxtcelularAgenda As TextBox
    Friend WithEvents txttelefonoagenda As TextBox
    Friend WithEvents Txtpersonacontacto As TextBox
    Friend WithEvents TxtOtroTelefono As TextBox
    Friend WithEvents Txtemail As TextBox
    Friend WithEvents txttelefonocontacto As TextBox
    Friend WithEvents TxtsitioWeb As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ID_Paciente As DataGridViewTextBoxColumn
    Friend WithEvents ID_Localidad As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Celular As DataGridViewTextBoxColumn
    Friend WithEvents OtroTelefono As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents PaginaWeb As DataGridViewTextBoxColumn
    Friend WithEvents PersonasContacto As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoContacto As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents CodigoPostal As DataGridViewTextBoxColumn
    Friend WithEvents Provincia As DataGridViewTextBoxColumn
    Friend WithEvents txtcodigopostal As TextBox
    Friend WithEvents Label11 As Label
End Class
