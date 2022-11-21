Public Class FmrAbmTipoDocumento
    Private Sub CmdagregarABMtipo_Click(sender As Object, e As EventArgs) Handles CmdagregarABMtipo.Click


        'Para Agregar Datos

        If lblseñaltipo.Text = "AGREGAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO TipoDocumento(Nombre)VALUES('" & txtnombretipo.Text & "')"
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            fmrTipoDocumento.cargatipodocumento()
            Close()

        End If

        'Para agregar los datos modificados 

        If lblseñaltipo.Text = "MODIFICAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE TipoDocumento SET Nombre = '" & txtnombretipo.Text & "' where ID_Tipo_Documento = " & Val(Txtidtipo.Text) & ""
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try


            Close()

        End If
        'Para resfrescar la grilla 
        fmrTipoDocumento.cargatipodocumento()

    End Sub

    Private Sub cmdsalirABMtipo_Click(sender As Object, e As EventArgs) Handles cmdsalirABMtipo.Click
        Close()

    End Sub
End Class