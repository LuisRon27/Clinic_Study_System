<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrAbmEstudio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrAbmEstudio))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cmdagregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdsalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.dtfechaestudioabm = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpacienteestudioabm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmutualestudioabm = New System.Windows.Forms.TextBox()
        Me.txtnroinformeestudioabm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnroafiliadoestudioabm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtimporteestudioabm = New System.Windows.Forms.TextBox()
        Me.txtmedicoestudioabm = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtestudioestudioabm = New System.Windows.Forms.TextBox()
        Me.cmdbuscarpaciente = New System.Windows.Forms.Button()
        Me.txtinformeestudioabm = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblseñalestudio = New System.Windows.Forms.Label()
        Me.txtIdPacienteestudioabm = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(723, 71)
        Me.ToolStrip1.TabIndex = 5
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
        'dtfechaestudioabm
        '
        Me.dtfechaestudioabm.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.dtfechaestudioabm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechaestudioabm.Location = New System.Drawing.Point(101, 105)
        Me.dtfechaestudioabm.Name = "dtfechaestudioabm"
        Me.dtfechaestudioabm.Size = New System.Drawing.Size(168, 20)
        Me.dtfechaestudioabm.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(46, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 19)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Paciente"
        '
        'txtpacienteestudioabm
        '
        Me.txtpacienteestudioabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtpacienteestudioabm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpacienteestudioabm.ForeColor = System.Drawing.Color.White
        Me.txtpacienteestudioabm.Location = New System.Drawing.Point(101, 152)
        Me.txtpacienteestudioabm.Name = "txtpacienteestudioabm"
        Me.txtpacienteestudioabm.Size = New System.Drawing.Size(293, 20)
        Me.txtpacienteestudioabm.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Mutual"
        '
        'txtmutualestudioabm
        '
        Me.txtmutualestudioabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtmutualestudioabm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmutualestudioabm.ForeColor = System.Drawing.Color.White
        Me.txtmutualestudioabm.Location = New System.Drawing.Point(101, 196)
        Me.txtmutualestudioabm.Name = "txtmutualestudioabm"
        Me.txtmutualestudioabm.Size = New System.Drawing.Size(184, 20)
        Me.txtmutualestudioabm.TabIndex = 47
        '
        'txtnroinformeestudioabm
        '
        Me.txtnroinformeestudioabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtnroinformeestudioabm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnroinformeestudioabm.ForeColor = System.Drawing.Color.White
        Me.txtnroinformeestudioabm.Location = New System.Drawing.Point(607, 105)
        Me.txtnroinformeestudioabm.Name = "txtnroinformeestudioabm"
        Me.txtnroinformeestudioabm.Size = New System.Drawing.Size(95, 20)
        Me.txtnroinformeestudioabm.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(505, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 19)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Nro. Informe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(300, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Nro. Afiliado"
        '
        'txtnroafiliadoestudioabm
        '
        Me.txtnroafiliadoestudioabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtnroafiliadoestudioabm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnroafiliadoestudioabm.ForeColor = System.Drawing.Color.White
        Me.txtnroafiliadoestudioabm.Location = New System.Drawing.Point(400, 196)
        Me.txtnroafiliadoestudioabm.Name = "txtnroafiliadoestudioabm"
        Me.txtnroafiliadoestudioabm.Size = New System.Drawing.Size(95, 20)
        Me.txtnroafiliadoestudioabm.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(33, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 19)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Importe"
        '
        'txtimporteestudioabm
        '
        Me.txtimporteestudioabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtimporteestudioabm.ForeColor = System.Drawing.Color.White
        Me.txtimporteestudioabm.Location = New System.Drawing.Point(101, 240)
        Me.txtimporteestudioabm.Name = "txtimporteestudioabm"
        Me.txtimporteestudioabm.Size = New System.Drawing.Size(246, 20)
        Me.txtimporteestudioabm.TabIndex = 53
        '
        'txtmedicoestudioabm
        '
        Me.txtmedicoestudioabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtmedicoestudioabm.ForeColor = System.Drawing.Color.White
        Me.txtmedicoestudioabm.Location = New System.Drawing.Point(101, 282)
        Me.txtmedicoestudioabm.Name = "txtmedicoestudioabm"
        Me.txtmedicoestudioabm.Size = New System.Drawing.Size(246, 20)
        Me.txtmedicoestudioabm.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(33, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Medico"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(34, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 19)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Estudio"
        '
        'txtestudioestudioabm
        '
        Me.txtestudioestudioabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtestudioestudioabm.ForeColor = System.Drawing.Color.White
        Me.txtestudioestudioabm.Location = New System.Drawing.Point(101, 317)
        Me.txtestudioestudioabm.Multiline = True
        Me.txtestudioestudioabm.Name = "txtestudioestudioabm"
        Me.txtestudioestudioabm.Size = New System.Drawing.Size(601, 60)
        Me.txtestudioestudioabm.TabIndex = 57
        '
        'cmdbuscarpaciente
        '
        Me.cmdbuscarpaciente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdbuscarpaciente.Location = New System.Drawing.Point(402, 151)
        Me.cmdbuscarpaciente.Name = "cmdbuscarpaciente"
        Me.cmdbuscarpaciente.Size = New System.Drawing.Size(93, 21)
        Me.cmdbuscarpaciente.TabIndex = 58
        Me.cmdbuscarpaciente.Text = "Buscar"
        Me.cmdbuscarpaciente.UseVisualStyleBackColor = True
        '
        'txtinformeestudioabm
        '
        Me.txtinformeestudioabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtinformeestudioabm.ForeColor = System.Drawing.Color.White
        Me.txtinformeestudioabm.Location = New System.Drawing.Point(101, 393)
        Me.txtinformeestudioabm.Multiline = True
        Me.txtinformeestudioabm.Name = "txtinformeestudioabm"
        Me.txtinformeestudioabm.Size = New System.Drawing.Size(601, 178)
        Me.txtinformeestudioabm.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(31, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 19)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Informe"
        '
        'lblseñalestudio
        '
        Me.lblseñalestudio.AutoSize = True
        Me.lblseñalestudio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseñalestudio.ForeColor = System.Drawing.Color.White
        Me.lblseñalestudio.Location = New System.Drawing.Point(365, 9)
        Me.lblseñalestudio.Name = "lblseñalestudio"
        Me.lblseñalestudio.Size = New System.Drawing.Size(63, 19)
        Me.lblseñalestudio.TabIndex = 61
        Me.lblseñalestudio.Text = "Label10"
        '
        'txtIdPacienteestudioabm
        '
        Me.txtIdPacienteestudioabm.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtIdPacienteestudioabm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdPacienteestudioabm.ForeColor = System.Drawing.Color.White
        Me.txtIdPacienteestudioabm.Location = New System.Drawing.Point(101, 152)
        Me.txtIdPacienteestudioabm.Name = "txtIdPacienteestudioabm"
        Me.txtIdPacienteestudioabm.Size = New System.Drawing.Size(87, 20)
        Me.txtIdPacienteestudioabm.TabIndex = 62
        Me.txtIdPacienteestudioabm.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 19)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Nro. Paciente"
        Me.Label10.Visible = False
        '
        'FmrAbmEstudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(723, 583)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtIdPacienteestudioabm)
        Me.Controls.Add(Me.lblseñalestudio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtinformeestudioabm)
        Me.Controls.Add(Me.cmdbuscarpaciente)
        Me.Controls.Add(Me.txtestudioestudioabm)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtmedicoestudioabm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtimporteestudioabm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnroafiliadoestudioabm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnroinformeestudioabm)
        Me.Controls.Add(Me.txtmutualestudioabm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpacienteestudioabm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtfechaestudioabm)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmrAbmEstudio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM - Estudio"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Cmdagregar As ToolStripButton
    Friend WithEvents cmdsalir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents dtfechaestudioabm As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpacienteestudioabm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmutualestudioabm As TextBox
    Friend WithEvents txtnroinformeestudioabm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnroafiliadoestudioabm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtimporteestudioabm As TextBox
    Friend WithEvents txtmedicoestudioabm As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtestudioestudioabm As TextBox
    Friend WithEvents cmdbuscarpaciente As Button
    Friend WithEvents txtinformeestudioabm As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblseñalestudio As Label
    Friend WithEvents txtIdPacienteestudioabm As TextBox
    Friend WithEvents Label10 As Label
End Class
