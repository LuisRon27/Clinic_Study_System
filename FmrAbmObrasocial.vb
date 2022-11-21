Public Class FmrAbmObrasocial
    Private Sub Cmdagregarabmobrasocial_Click(sender As Object, e As EventArgs) Handles Cmdagregarabmobrasocial.Click

        'Para Agregar Datos

        If lblseñalObraSocial.Text = "AGREGAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO ObraSocial(Nombre)VALUES('" & txtnombreObraSocial.Text & "')"
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            FmrObraSocial.cargaobrasocial()
            Close()

        End If

        'Para agregar los datos modificados 

        If lblseñalObraSocial.Text = "MODIFICAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE ObraSocial SET Nombre = '" & txtnombreObraSocial.Text & "'where ID_Obra_Social = " & Val(TxtidObraSocial.Text) & ""
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try


            Close()

        End If
        'Para resfrescar la grilla 
        FmrObraSocial.cargaobrasocial()

    End Sub

    Private Sub cmdsalirabmobrasocial_Click(sender As Object, e As EventArgs) Handles cmdsalirabmobrasocial.Click
        Close()

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Close()

    End Sub

    Private Sub FmrAbmObrasocial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class