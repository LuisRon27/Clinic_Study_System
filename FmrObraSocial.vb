Public Class FmrObraSocial
    Private Sub FmrObraSocial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaobrasocial()
    End Sub

    Public Sub cargaobrasocial()

        If Grillaobrasocial.Rows.Count <> 0 Then
            Grillaobrasocial.Rows.Clear()
        End If


        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from ObraSocial order by ID_Obra_Social"

        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                Grillaobrasocial.Rows.Add(lectordatos(0), lectordatos(1))

            End While

        Else

        End If

        lectordatos.Close()


    End Sub

    Private Sub Grillaobrasocial_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grillaobrasocial.CellDoubleClick
        FmrabmPaciente.txtobrasocial.Text = Grillaobrasocial.CurrentRow.Cells(1).Value
        Close()
    End Sub

    Private Sub cmdsalirobrasocial_Click(sender As Object, e As EventArgs) Handles cmdsalirobrasocial.Click
        Close()

    End Sub

    Private Sub Cmdagregarobrasocial_Click(sender As Object, e As EventArgs) Handles Cmdagregarobrasocial.Click
        FmrAbmObrasocial.lblseñalObraSocial.Text = "AGREGAR"
        FmrAbmObrasocial.Show()
    End Sub

    Private Sub CmdModificarobrasocial_Click(sender As Object, e As EventArgs) Handles CmdModificarobrasocial.Click
        FmrAbmObrasocial.lblseñalObraSocial.Text = "MODIFICAR"
        FmrAbmObrasocial.TxtidObraSocial.Text = Grillaobrasocial.CurrentRow.Cells(0).Value
        FmrAbmObrasocial.txtnombreObraSocial.Text = Grillaobrasocial.CurrentRow.Cells(1).Value
        FmrAbmObrasocial.Show()

    End Sub

    Private Sub Cmdeliminarobrasocial_Click(sender As Object, e As EventArgs) Handles Cmdeliminarobrasocial.Click
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from ObraSocial WHERE ID_Obra_Social = " & Val(Grillaobrasocial.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga de alumno para refrescar la grilla
            cargaobrasocial()



        End If

    End Sub
End Class