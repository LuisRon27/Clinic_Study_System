Public Class fmrTipoDocumento
    Private Sub cmdsalirtipo_Click(sender As Object, e As EventArgs) Handles cmdsalirtipo.Click
        Close()
    End Sub

    Private Sub fmrTipoDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargatipodocumento()
    End Sub

    Public Sub cargatipodocumento()

        If GrillatipoDocumento.Rows.Count <> 0 Then
            GrillatipoDocumento.Rows.Clear()
        End If


        'llama a la funcion de carga de registros de alumnos

        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from TipoDocumento order by ID_Tipo_Documento"

        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillatipoDocumento.Rows.Add(lectordatos(0), lectordatos(1))
            End While

        Else

        End If

        lectordatos.Close()

    End Sub

    Private Sub Cmdagregartipo_Click(sender As Object, e As EventArgs) Handles Cmdagregartipo.Click
        FmrAbmTipoDocumento.lblseñaltipo.Text = "AGREGAR"
        FmrAbmTipoDocumento.Show()

    End Sub

    Private Sub CmdModificartipo_Click(sender As Object, e As EventArgs) Handles CmdModificartipo.Click

        FmrAbmTipoDocumento.lblseñaltipo.Text = "MODIFICAR"
        FmrAbmTipoDocumento.Txtidtipo.Text = GrillatipoDocumento.CurrentRow.Cells(0).Value
        FmrAbmTipoDocumento.txtnombretipo.Text = GrillatipoDocumento.CurrentRow.Cells(1).Value
        FmrAbmTipoDocumento.Show()


    End Sub

    Private Sub Cmdeliminartipo_Click(sender As Object, e As EventArgs) Handles Cmdeliminartipo.Click


        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from TipoDocumento WHERE ID_Tipo_Documento = " & Val(GrillatipoDocumento.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga de alumno para refrescar la grilla
            cargatipodocumento()



        End If

    End Sub
End Class