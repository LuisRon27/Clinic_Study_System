Public Class fmrabmlocalidad
    Private Sub cmdsalirabmlocalidad_Click(sender As Object, e As EventArgs) Handles cmdsalirabmlocalidad.Click
        Close()

    End Sub

    Private Sub Cmdagregarabmlocalidad_Click(sender As Object, e As EventArgs) Handles Cmdagregarabmlocalidad.Click
        'Para Agregar Datos

        If lblseñallocalidad.Text = "AGREGAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Localidad(Nombre)VALUES('" & txtnombrelocalidad.Text & "')"
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            fmrLocalidad.cargalocalidad()
            Close()

        End If

        'Para agregar los datos modificados 

        If lblseñallocalidad.Text = "MODIFICAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Localidad SET Nombre = '" & txtnombrelocalidad.Text & "' where ID_Localidad = " & Val(Txtidlocalidad.Text) & ""
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try


            Close()

        End If
        'Para resfrescar la grilla 
        fmrLocalidad.cargalocalidad()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class