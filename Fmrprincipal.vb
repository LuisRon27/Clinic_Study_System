Public Class Fmrprincipal


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub cmdpaciente_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Fmrprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Abro la cadena de conexion para poder llegar a la base de datos

        Try
            conexionSql.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_Estudio;Data Source=LAPTOP-68VR45A9\SQLEXPRESS;Multipleactiveresultsets=true"

            conexionSql.Open()

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try


    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FmrObraSocial.Show()

    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Dim result2 As Integer = MessageBox.Show("¿Esta seguro que desea Cerrar Sesion?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result2 = DialogResult.Yes Then

            End

        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        FmrPaciente.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles horafecha.Tick

        lblhora.Text = DateTime.Now.ToLongTimeString
        lblfecha.Text = DateTime.Now.ToLongDateString

    End Sub

    Private Sub CiudadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadesToolStripMenuItem.Click
        fmrLocalidad.Show()

    End Sub

    Private Sub TipoDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TipoDocumentoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TipoDocumentoToolStripMenuItem.Click
        fmrTipoDocumento.Show()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        FmrAgenda.Show()

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        FmrTurno.Show()

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        FmrPaciente.Show()
    End Sub
End Class
