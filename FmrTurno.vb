Public Class FmrTurno
    Private Sub FmrTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaTurno()
    End Sub

    Public Sub CargaTurno()
        If GrillaTurno.Rows.Count <> 0 Then
            GrillaTurno.Rows.Clear()
        End If

        'llama a la funcion de carga de registros de alumnos

        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from Turno order by ID_Turno"

        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaTurno.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11))

            End While

        Else

        End If

        lectordatos.Close()

    End Sub


    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdsalir1_Click(sender As Object, e As EventArgs) Handles cmdsalir1.Click
        Close()

    End Sub

    Private Sub GrillaTurno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaTurno.CellContentClick

    End Sub

    Private Sub GrillaTurno_CellErrorTextNeeded(sender As Object, e As DataGridViewCellErrorTextNeededEventArgs) Handles GrillaTurno.CellErrorTextNeeded

    End Sub

    Private Sub GrillaTurno_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaTurno.CellClick
        Txtobrasocialturno.Text = GrillaTurno.CurrentRow.Cells(10).Value
        txtnumeroafiliadoturno.Text = GrillaTurno.CurrentRow.Cells(11).Value
        txtmedicosolicitanteturno.Text = GrillaTurno.CurrentRow.Cells(7).Value
        txtpresentacionesturno.Text = GrillaTurno.CurrentRow.Cells(9).Value
        txtObservacionesTurno.Text = GrillaTurno.CurrentRow.Cells(8).Value
    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click
        FmrAbmTurno.lblseñalturno.Text = "AGREGAR"
        FmrAbmTurno.Show()

    End Sub

    Private Sub CmdModificar_Click(sender As Object, e As EventArgs) Handles CmdModificar.Click

        FmrAbmTurno.lblseñalturno.Text = "MODIFICAR"
        FmrAbmTurno.txtidturno.Text = GrillaTurno.CurrentRow.Cells(0).Value
        FmrAbmTurno.MonthCalendar1.SelectionStart = GrillaTurno.CurrentRow.Cells(1).Value
        FmrAbmTurno.txthoraAbmTurno.Text = GrillaTurno.CurrentRow.Cells(2).Value
        FmrAbmTurno.txtminutosAbmTurno.Text = GrillaTurno.CurrentRow.Cells(3).Value
        FmrAbmTurno.txtpacienteAbmTurno.Text = GrillaTurno.CurrentRow.Cells(4).Value
        FmrAbmTurno.txttelefonoAbmTurno.Text = GrillaTurno.CurrentRow.Cells(5).Value
        FmrAbmTurno.txtmedicosolicitanteAbmTurno.Text = GrillaTurno.CurrentRow.Cells(7).Value
        FmrAbmTurno.txtobservaciones.Text = GrillaTurno.CurrentRow.Cells(8).Value
        FmrAbmTurno.txtprestacionesAbmTurno.Text = GrillaTurno.CurrentRow.Cells(9).Value
        FmrAbmTurno.txtobrasocialAbmTurno.Text = GrillaTurno.CurrentRow.Cells(10).Value
        FmrAbmTurno.txtnumeroafiliadoAbmTurno.Text = GrillaTurno.CurrentRow.Cells(11).Value
        FmrAbmTurno.Show()

    End Sub

    Private Sub Cmdeliminar_Click(sender As Object, e As EventArgs) Handles Cmdeliminar.Click

        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Turno WHERE ID_Turno = " & Val(GrillaTurno.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga de alumno para refrescar la grilla
            CargaTurno()



        End If

    End Sub

    Private Sub Cmdbuscarconsulta_Click(sender As Object, e As EventArgs) Handles Cmdbuscarconsulta.Click


        If GrillaTurno.Rows.Count <> 0 Then
            GrillaTurno.Rows.Clear()
        End If

        'llama a la funcion de carga de registros de alumnos

        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from Turno Where Fecha = '" & dtfechaconsultaturno.Text & "'"

        lectordatos = acciones.ExecuteReader




        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaTurno.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11))

            End While

        Else

            MessageBox.Show("No Existe Turnos en esta fecha Solicitada ", "Mensaje del sistema")

        End If

        lectordatos.Close()




    End Sub
End Class