Public Class FmrAbmTurno
    Private Sub cmdsaliragenda_Click(sender As Object, e As EventArgs) Handles cmdsaliragenda.Click
        Close()

    End Sub

    Private Sub txtnombreagenda_TextChanged(sender As Object, e As EventArgs) Handles txthoraAbmTurno.TextChanged

    End Sub

    Private Sub cmdpaciente_Click(sender As Object, e As EventArgs) Handles cmdpaciente.Click
        FmrPaciente.lblseñalpacienteturno.Text = "Turno"
        FmrPaciente.Show()

    End Sub

    Private Sub CmdagregarAgenda_Click(sender As Object, e As EventArgs) Handles CmdagregarAgenda.Click


        'Para Agregar Datos

        If lblseñalturno.Text = "AGREGAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Turno(Fecha,Hora,Minutos,Paciente,Telefono,MedicoSolicitante,Observaciones,Prestaciones,ObraSocial,NumeroAfiliado)
                                        VALUES('" & MonthCalendar1.SelectionStart & "','" & txthoraAbmTurno.Text & "','" & txtminutosAbmTurno.Text & "', '" & txtpacienteAbmTurno.Text & "', '" & txttelefonoAbmTurno.Text & "','" & txtmedicosolicitanteAbmTurno.Text & "','" & txtobservaciones.Text & "','" & txtprestacionesAbmTurno.Text & "','" & txtobrasocialAbmTurno.Text & "','" & Val(txtnumeroafiliadoAbmTurno.Text) & "')"
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            FmrTurno.CargaTurno()
            Close()

        End If


        'Para agregar los datos modificados 

        If lblseñalturno.Text = "MODIFICAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Turno SET Fecha = '" & MonthCalendar1.SelectionStart & "' ,Hora = '" & txthoraAbmTurno.Text & "',Minutos = '" & txtminutosAbmTurno.Text & "',Paciente = '" & txtpacienteAbmTurno.Text & "' ,Telefono = '" & txttelefonoAbmTurno.Text & "',MedicoSolicitante = '" & txtmedicosolicitanteAbmTurno.Text & "',Observaciones = '" & txtobservaciones.Text & "',Prestaciones = '" & txtprestacionesAbmTurno.Text & "',ObraSocial = '" & txtobrasocialAbmTurno.Text & "'  Where ID_Turno=" & Val(txtidturno.Text) & ""
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            FmrTurno.CargaTurno()
            Close()

        End If


    End Sub

    Private Sub FmrAbmTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class