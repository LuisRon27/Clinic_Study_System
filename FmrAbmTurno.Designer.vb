<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrAbmTurno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrAbmTurno))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CmdagregarAgenda = New System.Windows.Forms.ToolStripButton()
        Me.cmdsaliragenda = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txthoraAbmTurno = New System.Windows.Forms.TextBox()
        Me.txtminutosAbmTurno = New System.Windows.Forms.TextBox()
        Me.txtpacienteAbmTurno = New System.Windows.Forms.TextBox()
        Me.cmdpaciente = New System.Windows.Forms.Button()
        Me.txtobrasocialAbmTurno = New System.Windows.Forms.TextBox()
        Me.txtnumeroafiliadoAbmTurno = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.txttelefonoAbmTurno = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprestacionesAbmTurno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtmedicosolicitanteAbmTurno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.lblseñalturno = New System.Windows.Forms.Label()
        Me.txtidturno = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(824, 71)
        Me.ToolStrip1.TabIndex = 6
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(283, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 19)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Hora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(441, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Paciente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(282, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 19)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(535, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 19)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Obra Social"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(341, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 19)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(282, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 19)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Nro. Afiliado"
        '
        'txthoraAbmTurno
        '
        Me.txthoraAbmTurno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txthoraAbmTurno.ForeColor = System.Drawing.Color.White
        Me.txthoraAbmTurno.Location = New System.Drawing.Point(287, 115)
        Me.txthoraAbmTurno.Name = "txthoraAbmTurno"
        Me.txthoraAbmTurno.Size = New System.Drawing.Size(48, 20)
        Me.txthoraAbmTurno.TabIndex = 93
        '
        'txtminutosAbmTurno
        '
        Me.txtminutosAbmTurno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtminutosAbmTurno.ForeColor = System.Drawing.Color.White
        Me.txtminutosAbmTurno.Location = New System.Drawing.Point(361, 115)
        Me.txtminutosAbmTurno.Name = "txtminutosAbmTurno"
        Me.txtminutosAbmTurno.Size = New System.Drawing.Size(48, 20)
        Me.txtminutosAbmTurno.TabIndex = 94
        '
        'txtpacienteAbmTurno
        '
        Me.txtpacienteAbmTurno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtpacienteAbmTurno.ForeColor = System.Drawing.Color.White
        Me.txtpacienteAbmTurno.Location = New System.Drawing.Point(445, 115)
        Me.txtpacienteAbmTurno.Name = "txtpacienteAbmTurno"
        Me.txtpacienteAbmTurno.Size = New System.Drawing.Size(233, 20)
        Me.txtpacienteAbmTurno.TabIndex = 95
        '
        'cmdpaciente
        '
        Me.cmdpaciente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdpaciente.Location = New System.Drawing.Point(695, 114)
        Me.cmdpaciente.Name = "cmdpaciente"
        Me.cmdpaciente.Size = New System.Drawing.Size(93, 21)
        Me.cmdpaciente.TabIndex = 96
        Me.cmdpaciente.Text = "Buscar"
        Me.cmdpaciente.UseVisualStyleBackColor = True
        '
        'txtobrasocialAbmTurno
        '
        Me.txtobrasocialAbmTurno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtobrasocialAbmTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtobrasocialAbmTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobrasocialAbmTurno.ForeColor = System.Drawing.SystemColors.Window
        Me.txtobrasocialAbmTurno.Location = New System.Drawing.Point(539, 184)
        Me.txtobrasocialAbmTurno.Name = "txtobrasocialAbmTurno"
        Me.txtobrasocialAbmTurno.Size = New System.Drawing.Size(249, 22)
        Me.txtobrasocialAbmTurno.TabIndex = 98
        '
        'txtnumeroafiliadoAbmTurno
        '
        Me.txtnumeroafiliadoAbmTurno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtnumeroafiliadoAbmTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumeroafiliadoAbmTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroafiliadoAbmTurno.ForeColor = System.Drawing.SystemColors.Window
        Me.txtnumeroafiliadoAbmTurno.Location = New System.Drawing.Point(286, 239)
        Me.txtnumeroafiliadoAbmTurno.Name = "txtnumeroafiliadoAbmTurno"
        Me.txtnumeroafiliadoAbmTurno.Size = New System.Drawing.Size(327, 22)
        Me.txtnumeroafiliadoAbmTurno.TabIndex = 99
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(645, 217)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 51)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrego Orden"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(72, 22)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 23)
        Me.RadioButton2.TabIndex = 103
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(26, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(40, 23)
        Me.RadioButton1.TabIndex = 102
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Si"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txttelefonoAbmTurno
        '
        Me.txttelefonoAbmTurno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txttelefonoAbmTurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttelefonoAbmTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefonoAbmTurno.ForeColor = System.Drawing.SystemColors.Window
        Me.txttelefonoAbmTurno.Location = New System.Drawing.Point(284, 184)
        Me.txttelefonoAbmTurno.Name = "txttelefonoAbmTurno"
        Me.txttelefonoAbmTurno.Size = New System.Drawing.Size(249, 22)
        Me.txttelefonoAbmTurno.TabIndex = 101
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Location = New System.Drawing.Point(12, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 208)
        Me.Panel1.TabIndex = 102
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(30, 22)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(25, 305)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Prestaciones"
        '
        'txtprestacionesAbmTurno
        '
        Me.txtprestacionesAbmTurno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtprestacionesAbmTurno.ForeColor = System.Drawing.Color.White
        Me.txtprestacionesAbmTurno.Location = New System.Drawing.Point(29, 327)
        Me.txtprestacionesAbmTurno.Multiline = True
        Me.txtprestacionesAbmTurno.Name = "txtprestacionesAbmTurno"
        Me.txtprestacionesAbmTurno.Size = New System.Drawing.Size(760, 97)
        Me.txtprestacionesAbmTurno.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(25, 443)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 19)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Medico Solicitante"
        '
        'txtmedicosolicitanteAbmTurno
        '
        Me.txtmedicosolicitanteAbmTurno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtmedicosolicitanteAbmTurno.ForeColor = System.Drawing.Color.White
        Me.txtmedicosolicitanteAbmTurno.Location = New System.Drawing.Point(29, 465)
        Me.txtmedicosolicitanteAbmTurno.Name = "txtmedicosolicitanteAbmTurno"
        Me.txtmedicosolicitanteAbmTurno.Size = New System.Drawing.Size(280, 20)
        Me.txtmedicosolicitanteAbmTurno.TabIndex = 106
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(25, 509)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 19)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Observaciones"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtobservaciones.ForeColor = System.Drawing.Color.White
        Me.txtobservaciones.Location = New System.Drawing.Point(29, 531)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(760, 97)
        Me.txtobservaciones.TabIndex = 108
        '
        'lblseñalturno
        '
        Me.lblseñalturno.AutoSize = True
        Me.lblseñalturno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseñalturno.ForeColor = System.Drawing.Color.White
        Me.lblseñalturno.Location = New System.Drawing.Point(404, 9)
        Me.lblseñalturno.Name = "lblseñalturno"
        Me.lblseñalturno.Size = New System.Drawing.Size(63, 19)
        Me.lblseñalturno.TabIndex = 109
        Me.lblseñalturno.Text = "Label10"
        '
        'txtidturno
        '
        Me.txtidturno.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtidturno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtidturno.Enabled = False
        Me.txtidturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidturno.ForeColor = System.Drawing.SystemColors.Window
        Me.txtidturno.Location = New System.Drawing.Point(391, 31)
        Me.txtidturno.Name = "txtidturno"
        Me.txtidturno.Size = New System.Drawing.Size(87, 22)
        Me.txtidturno.TabIndex = 110
        Me.txtidturno.Visible = False
        '
        'FmrAbmTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 655)
        Me.Controls.Add(Me.txtidturno)
        Me.Controls.Add(Me.lblseñalturno)
        Me.Controls.Add(Me.txtobservaciones)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtmedicosolicitanteAbmTurno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtprestacionesAbmTurno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txttelefonoAbmTurno)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtnumeroafiliadoAbmTurno)
        Me.Controls.Add(Me.txtobrasocialAbmTurno)
        Me.Controls.Add(Me.cmdpaciente)
        Me.Controls.Add(Me.txtpacienteAbmTurno)
        Me.Controls.Add(Me.txtminutosAbmTurno)
        Me.Controls.Add(Me.txthoraAbmTurno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmrAbmTurno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM - Turno"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents CmdagregarAgenda As ToolStripButton
    Friend WithEvents cmdsaliragenda As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txthoraAbmTurno As TextBox
    Friend WithEvents txtminutosAbmTurno As TextBox
    Friend WithEvents txtpacienteAbmTurno As TextBox
    Friend WithEvents cmdpaciente As Button
    Friend WithEvents txtobrasocialAbmTurno As TextBox
    Friend WithEvents txtnumeroafiliadoAbmTurno As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txttelefonoAbmTurno As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label3 As Label
    Friend WithEvents txtprestacionesAbmTurno As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtmedicosolicitanteAbmTurno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtobservaciones As TextBox
    Friend WithEvents lblseñalturno As Label
    Friend WithEvents txtidturno As TextBox
End Class
