Public Class FmrAbmAgenda
    Private Sub cmdsaliragenda_Click(sender As Object, e As EventArgs) Handles cmdsaliragenda.Click
        Close()
    End Sub

    Private Sub cmdlocalidad_Click(sender As Object, e As EventArgs) Handles cmdlocalidad.Click
        fmrLocalidad.lblseñallocalidad.Text = "Agenda"
        fmrLocalidad.Show()

    End Sub

    Private Sub CmdagregarAgenda_Click(sender As Object, e As EventArgs) Handles CmdagregarAgenda.Click

        'Para Agregar Datos

        If lblseñalcontacto.Text = "AGREGAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Agenda(ID_Localidad,Apellido,Nombre,Telefono,Celular,OtroTelefono,Email,PaginaWeb,PersonaContacto,TelefonoContacto,Direccion,CodigoPostal,Provincia)
                                        VALUES('" & txtlocalidadagendaabm.Text & "','" & txtapellidoAgenda.Text & "','" & txtnombreagenda.Text & "', '" & txttelefonoagendaabm.Text & "', '" & txtcelularagendaabm.Text & "','" & txtotrotelefonoagendaabm.Text & "','" & txtemailagendaabm.Text & "','" & txtsitiowebagendaabm.Text & "','" & txtpersonacontactoagendaabm.Text & "','" & txttelefonocontactoagendaabm.Text & "','" & txtdomicilioagendaabm.Text & "','" & txtcodigopostalagendaabm.Text & "','" & txtprovinciaagendaabm.Text & "')"
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            FmrAgenda.CargaAgenda()
            Close()

        End If
        'Para agregar los datos modificados 

        If lblseñalcontacto.Text = "MODIFICAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Agenda SET ID_Localidad = '" & txtlocalidadagendaabm.Text & "', Apellido = '" & txtapellidoAgenda.Text & "' ,Nombre = '" & txtnombreagenda.Text & "',Telefono = '" & txttelefonoagendaabm.Text & "' ,Celular = '" & txtcelularagendaabm.Text & "',OtroTelefono = '" & txtotrotelefonoagendaabm.Text & "',Email = '" & txtemailagendaabm.Text & "',PaginaWeb = '" & txtsitiowebagendaabm.Text & "',PersonaContacto = '" & txtpersonacontactoagendaabm.Text & "',TelefonoContacto = '" & txttelefonocontactoagendaabm.Text & "',Direccion = '" & txtdomicilioagendaabm.Text & "',CodigoPostal = '" & txtcodigopostalagendaabm.Text & "',Provincia = '" & txtprovinciaagendaabm.Text & "' where ID_Contacto = " & Val(Txtidagendaabm.Text) & ""
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            FmrAgenda.CargaAgenda()
            Close()

        End If


    End Sub
End Class