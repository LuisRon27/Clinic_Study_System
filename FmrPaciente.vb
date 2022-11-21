Public Class FmrPaciente
    Private Sub CmdModificar_Click(sender As Object, e As EventArgs) Handles CmdModificar.Click
        FmrabmPaciente.lblseñal.Text = "MODIFICAR"
        FmrabmPaciente.Txtid.Text = Grillapacientes.CurrentRow.Cells(0).Value
        FmrabmPaciente.txtapellido.Text = Grillapacientes.CurrentRow.Cells(1).Value
        FmrabmPaciente.txtnombre.Text = Grillapacientes.CurrentRow.Cells(2).Value
        FmrabmPaciente.txtdomicilioPacienteAbm.Text = Grillapacientes.CurrentRow.Cells(3).Value
        FmrabmPaciente.txtlocalidad.Text = Grillapacientes.CurrentRow.Cells(4).Value
        FmrabmPaciente.txtcodigopostalAbmPaciente.Text = Grillapacientes.CurrentRow.Cells(5).Value
        FmrabmPaciente.txtProvinciapacienteabm.Text = Grillapacientes.CurrentRow.Cells(6).Value
        FmrabmPaciente.txttelefono.Text = Grillapacientes.CurrentRow.Cells(7).Value
        FmrabmPaciente.txtcelularpacienteabm.Text = Grillapacientes.CurrentRow.Cells(8).Value
        FmrabmPaciente.txtotrotelefonoPacienteabm.Text = Grillapacientes.CurrentRow.Cells(9).Value
        FmrabmPaciente.txtedadpacienteabm.Text = Grillapacientes.CurrentRow.Cells(10).Value
        FmrabmPaciente.ComboBox1.Text = Grillapacientes.CurrentRow.Cells(11).Value
        FmrabmPaciente.txtnumerodocumento.Text = Grillapacientes.CurrentRow.Cells(12).Value
        FmrabmPaciente.dtfechanacimiento.Value = Grillapacientes.CurrentRow.Cells(13).Value
        FmrabmPaciente.txtobrasocial.Text = Grillapacientes.CurrentRow.Cells(14).Value
        FmrabmPaciente.dtfechaingreso.Value = Grillapacientes.CurrentRow.Cells(15).Value
        FmrabmPaciente.txtnroAfiliadopacienteabm.Text = Grillapacientes.CurrentRow.Cells(16).Value
        FmrabmPaciente.txtemailpacienteabm.Text = Grillapacientes.CurrentRow.Cells(17).Value
        FmrabmPaciente.Show()
    End Sub

    Private Sub cmdsalir1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FmrPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargapaciente



    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked


    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click
        FmrabmPaciente.lblseñal.Text = "AGREGAR"
        FmrabmPaciente.Show()
    End Sub
    Public Sub cargapaciente()

        If Grillapacientes.Rows.Count <> 0 Then
            Grillapacientes.Rows.Clear()
        End If

        'llama a la funcion de carga de registros de alumnos

        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "select * from Paciente order by ID_Paciente"


        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                Grillapacientes.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13), lectordatos(14), lectordatos(15), lectordatos(16), lectordatos(17), lectordatos(18))

            End While



        Else

        End If

        lectordatos.Close()

    End Sub


    Public Sub cargaestudio()

        If GrillaEstudio.Rows.Count <> 0 Then
            GrillaEstudio.Rows.Clear()
        End If

        'llama a la funcion de carga de registros de alumnos

        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "select * from Estudio where ID_Paciente= " & Grillapacientes.CurrentRow.Cells(0).Value & " order by ID_Estudio"


        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaEstudio.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8))

            End While



        Else

        End If

        lectordatos.Close()

    End Sub



    Private Sub Cmdeliminar_Click(sender As Object, e As EventArgs) Handles Cmdeliminar.Click
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Paciente WHERE ID_Paciente = " & Val(Grillapacientes.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga de alumno para refrescar la grilla
            cargapaciente()



        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Grillapacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grillapacientes.CellContentClick

    End Sub

    Private Sub Grillapacientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grillapacientes.CellDoubleClick

        If lblseñalpacienteturno.Text = "Estudio" Then
            FmrAbmEstudio.txtpacienteestudioabm.Text = Grillapacientes.CurrentRow.Cells(1).Value
            FmrAbmEstudio.txtIdPacienteestudioabm.Text = Grillapacientes.CurrentRow.Cells(0).Value
            FmrAbmEstudio.txtmutualestudioabm.Text = Grillapacientes.CurrentRow.Cells(14).Value
            FmrAbmEstudio.txtnroafiliadoestudioabm.Text = Grillapacientes.CurrentRow.Cells(16).Value
            Close()

        End If

        If lblseñalpacienteturno.Text = "Turno" Then

            FmrAbmTurno.txtpacienteAbmTurno.Text = Grillapacientes.CurrentRow.Cells(1).Value
            FmrAbmTurno.txttelefonoAbmTurno.Text = Grillapacientes.CurrentRow.Cells(4).Value
            FmrAbmTurno.txtobrasocialAbmTurno.Text = Grillapacientes.CurrentRow.Cells(8).Value
            FmrAbmTurno.txtnumeroafiliadoAbmTurno.Text = Grillapacientes.CurrentRow.Cells(0).Value
            Close()

        End If


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
        FmrAbmEstudio.lblseñalestudio.Text = "Agregar"
        FmrAbmEstudio.Show()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        borratemporal()
        llenatemporal()
        fmrreporte.Show()

    End Sub



    Private Sub borratemporal()

        Try
            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "delete  from Temporalimpresion"
            acciones.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub llenatemporal()


        acciones.Connection = conexionSql
        acciones.CommandType = CommandType.Text
        acciones.CommandText = "Select ID_Paciente,Apellido,Nombre,Domicilio from Paciente order by ID_Paciente"
        lectordatos = acciones.ExecuteReader

        If lectordatos.HasRows Then
            While lectordatos.Read()
                Try
                    acciones2.Connection = conexionSql
                    acciones2.CommandType = CommandType.Text
                    acciones2.CommandText = "Insert into Temporalimpresion (campo1,campo6,campo7,campo8)values(" & lectordatos(0) & ",'" & lectordatos(1) & "','" & lectordatos(2) & "','" & lectordatos(3) & "')"
                    acciones2.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try


            End While


        Else


            MsgBox("No existen datos para esta Consulta", vbOKOnly + vbInformation, "Mensaje del Sistema")


        End If


        lectordatos.Close()

    End Sub



    Private Sub cmdsalir1_Click_1(sender As Object, e As EventArgs) Handles cmdsalir1.Click
        Close()

    End Sub

    Private Sub Grillapacientes_CellContextMenuStripChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Grillapacientes.CellContextMenuStripChanged

    End Sub

    Private Sub Grillapacientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grillapacientes.CellClick
        cargaestudio()

    End Sub

    Private Sub GrillaEstudio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaEstudio.CellContentClick

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click



        FmrAbmEstudio.lblseñalestudio.Text = "MODIFICAR"

        If FmrAbmEstudio.lblseñalestudio.Text = "MODIFICAR" Then
            FmrAbmEstudio.Label1.Visible = False
            FmrAbmEstudio.txtpacienteestudioabm.Visible = False
            FmrAbmEstudio.cmdbuscarpaciente.Visible = False
            FmrAbmEstudio.txtIdPacienteestudioabm.Visible = True
            FmrAbmEstudio.Label10.Visible = True
        End If


        FmrAbmEstudio.txtnroinformeestudioabm.Text = GrillaEstudio.CurrentRow.Cells(0).Value
        FmrAbmEstudio.dtfechaestudioabm.Value = GrillaEstudio.CurrentRow.Cells(1).Value
        FmrAbmEstudio.txtIdPacienteestudioabm.Text = GrillaEstudio.CurrentRow.Cells(4).Value
        FmrAbmEstudio.txtmutualestudioabm.Text = GrillaEstudio.CurrentRow.Cells(7).Value
        FmrAbmEstudio.txtnroafiliadoestudioabm.Text = GrillaEstudio.CurrentRow.Cells(8).Value
        FmrAbmEstudio.txtimporteestudioabm.Text = GrillaEstudio.CurrentRow.Cells(6).Value
        FmrAbmEstudio.txtmedicoestudioabm.Text = GrillaEstudio.CurrentRow.Cells(3).Value
        FmrAbmEstudio.txtestudioestudioabm.Text = GrillaEstudio.CurrentRow.Cells(2).Value
        FmrAbmEstudio.txtinformeestudioabm.Text = GrillaEstudio.CurrentRow.Cells(5).Value
        FmrAbmEstudio.Show()


    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Estudio WHERE ID_Estudio = " & Val(GrillaEstudio.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga de alumno para refrescar la grilla
            cargaestudio()



        End If


    End Sub

    Private Sub ToolStripButton6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Public Sub busqueda(ByVal id As String, ByVal dgv As DataGridView)

        If Grillapacientes.Rows.Count <> 0 Then
            Grillapacientes.Rows.Clear()
        End If

        'llama a la funcion de carga de registros de alumnos

        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from Paciente Where ID_Paciente like '" & "%" + id + "%" & "' or Apellido like '" & "%" + id + "%" & "' "

        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                Grillapacientes.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13), lectordatos(14), lectordatos(15), lectordatos(16), lectordatos(17), lectordatos(18))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub


    Private Sub TxtDomicilioAgenda_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged





        If txtbuscar.Text.Contains("'") Then
            MsgBox("Este Caracter no es valido ")
            txtbuscar.Clear()
        End If

        busqueda(txtbuscar.Text, Grillapacientes)

        If txtbuscar.Text = "" Then
            cargapaciente()

        End If
    End Sub
End Class