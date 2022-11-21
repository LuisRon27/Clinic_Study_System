Public Class FmrAbmEstudio
    Private Sub Txtid_TextChanged(sender As Object, e As EventArgs) Handles txtpacienteestudioabm.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
        FmrPaciente.Show()

    End Sub

    Private Sub cmdlocalidad_Click(sender As Object, e As EventArgs) Handles cmdbuscarpaciente.Click
        FmrPaciente.lblseñalpacienteturno.Text = "Estudio"
        FmrPaciente.Show()

    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click

        'Para Agregar Datos

        If lblseñalestudio.Text = "Agregar" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Estudio(Fecha,Estudio,MedicoSolicitante,ID_Paciente,Informe1,Importe,ObraSocial,NroAfiliado)VALUES('" & dtfechaestudioabm.Value & "','" & txtestudioestudioabm.Text & "','" & txtmedicoestudioabm.Text & "', '" & Val(txtIdPacienteestudioabm.Text) & "', '" & txtinformeestudioabm.Text & "','" & txtimporteestudioabm.Text & "','" & txtmutualestudioabm.Text & "','" & txtnroafiliadoestudioabm.Text & "')"
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            FmrPaciente.cargapaciente()
            Close()
            FmrPaciente.Show()
        End If

        'Para agregar los datos modificados 

        If lblseñalestudio.Text = "MODIFICAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Estudio SET Fecha = '" & dtfechaestudioabm.Value & "' ,Estudio = '" & txtestudioestudioabm.Text & "',MedicoSolicitante = '" & txtmedicoestudioabm.Text & "',ID_Paciente = '" & Val(txtIdPacienteestudioabm.Text) & "' ,Informe1 = '" & txtinformeestudioabm.Text & "',Importe = '" & txtimporteestudioabm.Text & "',ObraSocial = '" & txtmutualestudioabm.Text & "',NroAfiliado = '" & txtnroafiliadoestudioabm.Text & "' where ID_Estudio = " & Val(txtnroinformeestudioabm.Text) & ""
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            FmrPaciente.cargaestudio()
            Close()

        End If



    End Sub
End Class