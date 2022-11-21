Public Class FmrabmPaciente
    Private Sub CmdModificar_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()
    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click



        'Para Agregar Datos

        If lblseñal.Text = "AGREGAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Paciente(Apellido, Nombre, Domicilio, Localidad, CodigoPostal, Provincia,Telefono, Celular, OtroTelefono, Edad, TipoDocumento, NumeroDocumento, FechaNacimiento, ObraSocial,FechaAltaSistema, NumeroAfiliado, Email)VALUES('" & txtapellido.Text & "','" & txtnombre.Text & "','" & txtdomicilioPacienteAbm.Text & "','" & txtlocalidad.Text & "','" & txtcodigopostalAbmPaciente.Text & "','" & txtProvinciapacienteabm.Text & "', '" & txttelefono.Text & "','" & txtcelularpacienteabm.Text & "','" & txtotrotelefonoPacienteabm.Text & "','" & txtedadpacienteabm.Text & "', '" & ComboBox1.Text & "',  '" & txtnumerodocumento.Text & "','" & dtfechanacimiento.Value & "','" & txtobrasocial.Text & "','" & dtfechaingreso.Value & "','" & txtnroAfiliadopacienteabm.Text & "','" & txtemailpacienteabm.Text & "')"
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try


            Close()

        End If

        'Para agregar los datos modificados 

        If lblseñal.Text = "MODIFICAR" Then


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Paciente SET Apellido = '" & txtapellido.Text & "' ,Nombre = '" & txtnombre.Text & "',Domicilio = '" & txtdomicilioPacienteAbm.Text & "' ,Localidad = '" & txtlocalidad.Text & "',CodigoPostal = '" & txtcodigopostalAbmPaciente.Text & "' ,Provincia = '" & txtProvinciapacienteabm.Text & "' ,Telefono = '" & txttelefono.Text & "' ,Celular = '" & txtcelularpacienteabm.Text & "' ,OtroTelefono = '" & txtotrotelefonoPacienteabm.Text & "' ,Edad = '" & txtedadpacienteabm.Text & "' ,TipoDocumento = '" & ComboBox1.Text & "' ,NumeroDocumento = '" & txtnumerodocumento.Text & "' ,FechaNacimiento = '" & dtfechanacimiento.Value & "',ObraSocial = '" & txtobrasocial.Text & "',FechaAltaSistema = '" & dtfechaingreso.Value & "',NumeroAfiliado = '" & txtnroAfiliadopacienteabm.Text & "' ,Email = '" & txtemailpacienteabm.Text & "'  where ID_Paciente = " & Val(Txtid.Text) & ""
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try


            Close()

        End If
        'Para resfrescar la grilla 
        FmrPaciente.cargapaciente()
    End Sub

    Private Sub FmrabmPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargacombox()
    End Sub

    Private Sub Cargacombox()
        adaptadorSql.SelectCommand = acciones
        adaptadorSql.SelectCommand.Connection = conexionSql
        acciones.CommandText = "Select * from TipoDocumento order by ID_Tipo_Documento "
        tabladedatos = New DataTable
        adaptadorSql.Fill(tabladedatos)
        With ComboBox1

            .DataSource = tabladedatos
            .DisplayMember = "Nombre"
            .ValueMember = "ID_Tipo_Documento"

        End With

        ComboBox1.Text = ""


    End Sub

    Private Sub cmdlocalidad_Click(sender As Object, e As EventArgs) Handles cmdlocalidad.Click
        fmrLocalidad.lblseñallocalidad.Text = "Paciente"
        fmrLocalidad.Show()

    End Sub

    Private Sub Cmdtipodocumento_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Cmdobrasocial_Click(sender As Object, e As EventArgs) Handles Cmdobrasocial.Click
        FmrObraSocial.Show()

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub
End Class