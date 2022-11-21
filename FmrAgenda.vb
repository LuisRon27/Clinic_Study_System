Public Class FmrAgenda
    Private Sub cmdsalir1_Click(sender As Object, e As EventArgs) Handles cmdsalir1.Click
        Close()
    End Sub

    Private Sub FmrAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaAgenda()


    End Sub

    Public Sub CargaAgenda()
        If Grillaagenda.Rows.Count <> 0 Then
            Grillaagenda.Rows.Clear()
        End If

        'llama a la funcion de carga de registros de alumnos

        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from Agenda order by ID_Contacto"

        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                Grillaagenda.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub

    Private Sub Grillaagenda_AutoSizeChanged(sender As Object, e As EventArgs) Handles Grillaagenda.AutoSizeChanged





    End Sub

    Private Sub Grillaagenda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grillaagenda.CellContentClick

    End Sub

    Private Sub Grillaagenda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grillaagenda.CellClick
        TxtDomicilioAgenda.Text = Grillaagenda.CurrentRow.Cells(11).Value
        txtlocalidadAgenda.Text = Grillaagenda.CurrentRow.Cells(1).Value
        txttelefonoagenda.Text = Grillaagenda.CurrentRow.Cells(4).Value
        TxtcelularAgenda.Text = Grillaagenda.CurrentRow.Cells(5).Value
        TxtOtroTelefono.Text = Grillaagenda.CurrentRow.Cells(6).Value
        Txtpersonacontacto.Text = Grillaagenda.CurrentRow.Cells(9).Value
        txttelefonocontacto.Text = Grillaagenda.CurrentRow.Cells(10).Value
        Txtemail.Text = Grillaagenda.CurrentRow.Cells(7).Value
        TxtsitioWeb.Text = Grillaagenda.CurrentRow.Cells(8).Value
        txtcodigopostal.Text = Grillaagenda.CurrentRow.Cells(12).Value
    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click
        FmrAbmAgenda.lblseñalcontacto.Text = "AGREGAR"
        FmrAbmAgenda.Show()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub CmdModificar_Click(sender As Object, e As EventArgs) Handles CmdModificar.Click

        FmrAbmAgenda.lblseñalcontacto.Text = "MODIFICAR"
        FmrAbmAgenda.Txtidagendaabm.Text = Grillaagenda.CurrentRow.Cells(0).Value
        FmrAbmAgenda.txtlocalidadagendaabm.Text = Grillaagenda.CurrentRow.Cells(1).Value
        FmrAbmAgenda.txtapellidoAgenda.Text = Grillaagenda.CurrentRow.Cells(2).Value
        FmrAbmAgenda.txtnombreagenda.Text = Grillaagenda.CurrentRow.Cells(3).Value
        FmrAbmAgenda.txttelefonoagendaabm.Text = Grillaagenda.CurrentRow.Cells(4).Value
        FmrAbmAgenda.txtcelularagendaabm.Text = Grillaagenda.CurrentRow.Cells(5).Value
        FmrAbmAgenda.txtotrotelefonoagendaabm.Text = Grillaagenda.CurrentRow.Cells(6).Value
        FmrAbmAgenda.txtemailagendaabm.Text = Grillaagenda.CurrentRow.Cells(7).Value
        FmrAbmAgenda.txtsitiowebagendaabm.Text = Grillaagenda.CurrentRow.Cells(8).Value
        FmrAbmAgenda.txtpersonacontactoagendaabm.Text = Grillaagenda.CurrentRow.Cells(9).Value
        FmrAbmAgenda.txttelefonocontactoagendaabm.Text = Grillaagenda.CurrentRow.Cells(10).Value
        FmrAbmAgenda.txtdomicilioagendaabm.Text = Grillaagenda.CurrentRow.Cells(11).Value
        FmrAbmAgenda.txtcodigopostalagendaabm.Text = Grillaagenda.CurrentRow.Cells(12).Value
        FmrAbmAgenda.txtprovinciaagendaabm.Text = Grillaagenda.CurrentRow.Cells(13).Value

        FmrAbmAgenda.Show()


    End Sub

    Private Sub Cmdeliminar_Click(sender As Object, e As EventArgs) Handles Cmdeliminar.Click

        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Agenda WHERE ID_Contacto = " & Val(Grillaagenda.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga de alumno para refrescar la grilla
            CargaAgenda()



        End If

    End Sub
End Class