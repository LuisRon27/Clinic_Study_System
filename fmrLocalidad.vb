Public Class fmrLocalidad
    Private Sub fmrLocalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargalocalidad()


    End Sub

    Public Sub cargalocalidad()

        If Grillalocalidad.Rows.Count <> 0 Then
            Grillalocalidad.Rows.Clear()
        End If


        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from Localidad order by ID_Localidad"

        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                Grillalocalidad.Rows.Add(lectordatos(0), lectordatos(1))

            End While

        Else

        End If

        lectordatos.Close()


    End Sub

    Private Sub Grillalocalidad_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grillalocalidad.CellDoubleClick

        If lblseñallocalidad.Text = "Agenda" Then
            FmrAbmAgenda.txtlocalidadagendaabm.Text = Grillalocalidad.CurrentRow.Cells(1).Value

            Close()

        End If
        If lblseñallocalidad.Text = "Paciente" Then
            FmrabmPaciente.txtlocalidad.Text = Grillalocalidad.CurrentRow.Cells(1).Value
            Close()

        End If


    End Sub

    Private Sub cmdsalir1_Click(sender As Object, e As EventArgs) Handles cmdsalirlocalidad.Click
        Close()
    End Sub

    Private Sub Cmdagregarlocalidad_Click(sender As Object, e As EventArgs) Handles Cmdagregarlocalidad.Click
        fmrabmlocalidad.lblseñallocalidad.Text = "AGREGAR"
        fmrabmlocalidad.Show()

    End Sub

    Private Sub CmdModificarlocalidad_Click(sender As Object, e As EventArgs) Handles CmdModificarlocalidad.Click
        fmrabmlocalidad.lblseñallocalidad.Text = "MODIFICAR"
        fmrabmlocalidad.Txtidlocalidad.Text = Grillalocalidad.CurrentRow.Cells(0).Value
        fmrabmlocalidad.txtnombrelocalidad.Text = Grillalocalidad.CurrentRow.Cells(1).Value
        fmrabmlocalidad.Show()
    End Sub

    Private Sub Cmdeliminarlocalidad_Click(sender As Object, e As EventArgs) Handles Cmdeliminarlocalidad.Click

        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Localidad WHERE ID_Localidad = " & Val(Grillalocalidad.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga de alumno para refrescar la grilla
            cargalocalidad()



        End If



    End Sub

    Private Sub Grillalocalidad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grillalocalidad.CellContentClick

    End Sub
End Class