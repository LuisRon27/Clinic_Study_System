<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrTurno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrTurno))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cmdagregar = New System.Windows.Forms.ToolStripButton()
        Me.CmdModificar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.Cmdeliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdsalir1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Cmdbuscarconsulta = New System.Windows.Forms.Button()
        Me.dtfechaconsultaturno = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrillaTurno = New System.Windows.Forms.DataGridView()
        Me.ID_Turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Minutos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdenEntregada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicoSolicitante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prestaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObraSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroAfiliado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txtobrasocialturno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnumeroafiliadoturno = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.txtpresentacionesturno = New System.Windows.Forms.TextBox()
        Me.txtmedicosolicitanteturno = New System.Windows.Forms.TextBox()
        Me.txtObservacionesTurno = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrillaTurno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cmdagregar, Me.CmdModificar, Me.cmdImprimir, Me.Cmdeliminar, Me.ToolStripSeparator1, Me.cmdsalir1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(818, 71)
        Me.ToolStrip1.TabIndex = 7
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
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = Global.SistemaEstudio.My.Resources.Resources.apps_printer_15747
        Me.cmdImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(68, 68)
        Me.cmdImprimir.Text = "Imprimir"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Cmdbuscarconsulta)
        Me.Panel1.Controls.Add(Me.dtfechaconsultaturno)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 65)
        Me.Panel1.TabIndex = 83
        '
        'Cmdbuscarconsulta
        '
        Me.Cmdbuscarconsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmdbuscarconsulta.Location = New System.Drawing.Point(329, 21)
        Me.Cmdbuscarconsulta.Name = "Cmdbuscarconsulta"
        Me.Cmdbuscarconsulta.Size = New System.Drawing.Size(93, 21)
        Me.Cmdbuscarconsulta.TabIndex = 83
        Me.Cmdbuscarconsulta.Text = "Buscar"
        Me.Cmdbuscarconsulta.UseVisualStyleBackColor = True
        '
        'dtfechaconsultaturno
        '
        Me.dtfechaconsultaturno.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.dtfechaconsultaturno.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechaconsultaturno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtfechaconsultaturno.Location = New System.Drawing.Point(150, 22)
        Me.dtfechaconsultaturno.Name = "dtfechaconsultaturno"
        Me.dtfechaconsultaturno.Size = New System.Drawing.Size(157, 20)
        Me.dtfechaconsultaturno.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 19)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Fecha De Consulta:"
        '
        'GrillaTurno
        '
        Me.GrillaTurno.AllowUserToAddRows = False
        Me.GrillaTurno.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GrillaTurno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrillaTurno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GrillaTurno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaTurno.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrillaTurno.ColumnHeadersHeight = 35
        Me.GrillaTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrillaTurno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Turno, Me.Fecha, Me.Hora, Me.Minutos, Me.Paciente, Me.Telefono, Me.OrdenEntregada, Me.MedicoSolicitante, Me.Observaciones, Me.Prestaciones, Me.ObraSocial, Me.NumeroAfiliado})
        Me.GrillaTurno.EnableHeadersVisualStyles = False
        Me.GrillaTurno.GridColor = System.Drawing.Color.SteelBlue
        Me.GrillaTurno.Location = New System.Drawing.Point(0, 173)
        Me.GrillaTurno.Name = "GrillaTurno"
        Me.GrillaTurno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaTurno.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.GrillaTurno.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.GrillaTurno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GrillaTurno.Size = New System.Drawing.Size(442, 515)
        Me.GrillaTurno.TabIndex = 82
        '
        'ID_Turno
        '
        Me.ID_Turno.HeaderText = "Numero"
        Me.ID_Turno.Name = "ID_Turno"
        Me.ID_Turno.Visible = False
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Visible = False
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        '
        'Minutos
        '
        Me.Minutos.HeaderText = "Minutos "
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Visible = False
        '
        'Paciente
        '
        Me.Paciente.HeaderText = "Paciente"
        Me.Paciente.Name = "Paciente"
        Me.Paciente.Width = 150
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Width = 150
        '
        'OrdenEntregada
        '
        Me.OrdenEntregada.HeaderText = "Orden  Entregada"
        Me.OrdenEntregada.Name = "OrdenEntregada"
        Me.OrdenEntregada.Visible = False
        '
        'MedicoSolicitante
        '
        Me.MedicoSolicitante.HeaderText = "MedicoSolicitante"
        Me.MedicoSolicitante.Name = "MedicoSolicitante"
        Me.MedicoSolicitante.Visible = False
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones "
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Visible = False
        '
        'Prestaciones
        '
        Me.Prestaciones.HeaderText = "Presentaciones"
        Me.Prestaciones.Name = "Prestaciones"
        Me.Prestaciones.Visible = False
        '
        'ObraSocial
        '
        Me.ObraSocial.HeaderText = "Obra Social"
        Me.ObraSocial.Name = "ObraSocial"
        Me.ObraSocial.Visible = False
        '
        'NumeroAfiliado
        '
        Me.NumeroAfiliado.HeaderText = "NumeroAfiliado"
        Me.NumeroAfiliado.Name = "NumeroAfiliado"
        Me.NumeroAfiliado.Visible = False
        '
        'Txtobrasocialturno
        '
        Me.Txtobrasocialturno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Txtobrasocialturno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtobrasocialturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtobrasocialturno.ForeColor = System.Drawing.SystemColors.Window
        Me.Txtobrasocialturno.Location = New System.Drawing.Point(472, 136)
        Me.Txtobrasocialturno.Name = "Txtobrasocialturno"
        Me.Txtobrasocialturno.Size = New System.Drawing.Size(334, 22)
        Me.Txtobrasocialturno.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(468, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Obra Social"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(468, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Nro. Afiliado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(468, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 19)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Medico Solicitante"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(684, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Entrego Orden"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(468, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 19)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Prestaciones"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(468, 502)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 19)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Observaciones"
        '
        'txtnumeroafiliadoturno
        '
        Me.txtnumeroafiliadoturno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtnumeroafiliadoturno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumeroafiliadoturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroafiliadoturno.ForeColor = System.Drawing.SystemColors.Window
        Me.txtnumeroafiliadoturno.Location = New System.Drawing.Point(472, 207)
        Me.txtnumeroafiliadoturno.Name = "txtnumeroafiliadoturno"
        Me.txtnumeroafiliadoturno.Size = New System.Drawing.Size(179, 22)
        Me.txtnumeroafiliadoturno.TabIndex = 91
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(688, 207)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(40, 23)
        Me.RadioButton1.TabIndex = 92
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Si"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(734, 207)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 23)
        Me.RadioButton2.TabIndex = 93
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'txtpresentacionesturno
        '
        Me.txtpresentacionesturno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtpresentacionesturno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpresentacionesturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpresentacionesturno.ForeColor = System.Drawing.SystemColors.Window
        Me.txtpresentacionesturno.Location = New System.Drawing.Point(472, 361)
        Me.txtpresentacionesturno.Multiline = True
        Me.txtpresentacionesturno.Name = "txtpresentacionesturno"
        Me.txtpresentacionesturno.Size = New System.Drawing.Size(334, 121)
        Me.txtpresentacionesturno.TabIndex = 94
        '
        'txtmedicosolicitanteturno
        '
        Me.txtmedicosolicitanteturno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtmedicosolicitanteturno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmedicosolicitanteturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmedicosolicitanteturno.ForeColor = System.Drawing.SystemColors.Window
        Me.txtmedicosolicitanteturno.Location = New System.Drawing.Point(472, 286)
        Me.txtmedicosolicitanteturno.Name = "txtmedicosolicitanteturno"
        Me.txtmedicosolicitanteturno.Size = New System.Drawing.Size(334, 22)
        Me.txtmedicosolicitanteturno.TabIndex = 95
        '
        'txtObservacionesTurno
        '
        Me.txtObservacionesTurno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtObservacionesTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacionesTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionesTurno.ForeColor = System.Drawing.SystemColors.Window
        Me.txtObservacionesTurno.Location = New System.Drawing.Point(472, 524)
        Me.txtObservacionesTurno.Multiline = True
        Me.txtObservacionesTurno.Name = "txtObservacionesTurno"
        Me.txtObservacionesTurno.Size = New System.Drawing.Size(334, 130)
        Me.txtObservacionesTurno.TabIndex = 96
        '
        'FmrTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(818, 684)
        Me.Controls.Add(Me.txtObservacionesTurno)
        Me.Controls.Add(Me.txtmedicosolicitanteturno)
        Me.Controls.Add(Me.txtpresentacionesturno)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txtnumeroafiliadoturno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtobrasocialturno)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GrillaTurno)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmrTurno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turnos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GrillaTurno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Cmdagregar As ToolStripButton
    Friend WithEvents CmdModificar As ToolStripButton
    Friend WithEvents Cmdeliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdsalir1 As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GrillaTurno As DataGridView
    Friend WithEvents dtfechaconsultaturno As DateTimePicker
    Friend WithEvents Cmdbuscarconsulta As Button
    Friend WithEvents Txtobrasocialturno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnumeroafiliadoturno As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents txtpresentacionesturno As TextBox
    Friend WithEvents cmdImprimir As ToolStripButton
    Friend WithEvents txtmedicosolicitanteturno As TextBox
    Friend WithEvents txtObservacionesTurno As TextBox
    Friend WithEvents ID_Turno As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Hora As DataGridViewTextBoxColumn
    Friend WithEvents Minutos As DataGridViewTextBoxColumn
    Friend WithEvents Paciente As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents OrdenEntregada As DataGridViewTextBoxColumn
    Friend WithEvents MedicoSolicitante As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents Prestaciones As DataGridViewTextBoxColumn
    Friend WithEvents ObraSocial As DataGridViewTextBoxColumn
    Friend WithEvents NumeroAfiliado As DataGridViewTextBoxColumn
End Class
