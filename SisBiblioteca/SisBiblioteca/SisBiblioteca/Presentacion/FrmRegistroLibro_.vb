

Public Class FrmRegistroLibro_

    Dim ClaseLibro As New flibro
    Dim dts As New vlibro


    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CargarPortada.ShowDialog()
        ImagenPortada.Image = Image.FromFile(CargarPortada.FileName)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ImagenPortada.Image = Nothing

    End Sub

    Private Sub FrmRegistroLibro__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Desactivar()
        ClaseLibro.LlenarEstadoLibro(CmbEstadoLibro)
        CmbEstadoLibro.Text = Nothing

    End Sub

    Private Sub Desactivar()
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
        BtnModificar.Enabled = False

        GroupRegistro.Enabled = False
        GroupPortada.Enabled = False

    End Sub

    Private Sub ActivarBtnNuevo()
        GroupPortada.Enabled = True
        GroupRegistro.Enabled = True

        BtnNuevo.Enabled = False
        BtnBuscar.Enabled = False
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        BtnSalir.Enabled = True



    End Sub
    Private Sub ActivarCancelar()
        GroupPortada.Enabled = False
        GroupRegistro.Enabled = False
        BtnNuevo.Enabled = True
        BtnBuscar.Enabled = True
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
        BtnSalir.Enabled = True
        LimpiarTexto()
    End Sub
    Private Sub LimpiarTexto()
        TxtCodigoLibro.Clear()
        TxtAutorLibro.Clear()
        TxtCategoriaLibro.Clear()
        CmbEstadoLibro.Text = Nothing
        TxtNombreLibro.Clear()
        TxtObservacionLibro.Clear()
        ImagenPortada.Image = Nothing

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        ActivarBtnNuevo()

        TxtCodigoLibro.Focus()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        ActivarCancelar()
        BtnNuevo.Focus()

    End Sub

    Private Sub TxtCodigoLibro_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigoLibro.TextChanged

    End Sub

    Private Sub TxtCodigoLibro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoLibro.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            TxtNombreLibro.Focus()

        End If

    End Sub

    Private Sub TxtAutorLibro_TextChanged(sender As Object, e As EventArgs) Handles TxtAutorLibro.TextChanged

    End Sub

    Private Sub TxtAutorLibro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAutorLibro.KeyPress
        e.Handled = True


    End Sub

    Private Sub TxtNombreLibro_TextChanged(sender As Object, e As EventArgs) Handles TxtNombreLibro.TextChanged

    End Sub

    Private Sub TxtNombreLibro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombreLibro.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            BtnBuscarAutor.Focus()
        End If

    End Sub

    Private Sub BtnBuscarAutor_Click(sender As Object, e As EventArgs) Handles BtnBuscarAutor.Click
        frmBuscarAutor.ShowDialog()

        If MdVariableControlCalidad.LoteConteoKPIS <> Nothing Then

            TxtLoteConteo.Text = MdVariableControlCalidad.LoteConteoKPIS
            TxtRuedaConteo.Text = MdVariableControlCalidad.RuedaConteoKPIS
            TxtProveedorConteo.Text = MdVariableControlCalidad.ProveedorKPIS
            TxtProcedenciaConteo.Text = MdVariableControlCalidad.FincaKPIS
            BtnProducto.Focus()


        Else
            BtnBuscarLote.Focus()

        End If



        MsgBox(dts.GIDCODIGOAUTOR)
    End Sub

    Private Sub BtnBuscarCategoria_Click(sender As Object, e As EventArgs) Handles BtnBuscarCategoria.Click
        frmBuscarCategoria.ShowDialog()

    End Sub

    Private Sub TxtCategoriaLibro_TextChanged(sender As Object, e As EventArgs) Handles TxtCategoriaLibro.TextChanged

    End Sub

    Private Sub TxtCategoriaLibro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCategoriaLibro.KeyPress
        e.Handled = True

    End Sub

    Private Sub BtnBuscarEstadoLibro_Click(sender As Object, e As EventArgs)
        frmBuscarEstadoLibro.ShowDialog()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'validar que las cajas de texto no esten vacias
        If Me.ValidateChildren = True And TxtCodigoLibro.Text <> "" And TxtNombreLibro.Text <> "" And FechaRegistro.Text <> "" And TxtCategoriaLibro.Text <> "" And TxtAutorLibro.Text <> "" And CmbEstadoLibro.Text <> "" And TxtObservacionLibro.Text <> "" Then
            Try
                Dim dts As New vlibro
                Dim func As New flibro

                dts.GCODIGO = TxtCodigoLibro.Text
                dts.GNOMBRE = TxtNombreLibro.Text
                dts.GFECHALIBRO = FechaRegistro.Text
                'dts.GCANTIDAD = txtcantidad.Text

                'dts.GIDCATEGORIA = txtidcategoria.Text
                'dts.GIDAUTOR = txtidautor.Text
                dts.GIDESTADO = CmbEstadoLibro.SelectedValue
                'dts.GIDUBICACION = txtidubicacion.Text
                'dts.GIDEDITORIAL = txtideditorial.Text
                'dts.GDISPONIBLES = txtdisponibles.Text
                dts.GDESCRIPCION = TxtObservacionLibro.Text
                'dts.GPAGINAS = txtpaginas.Text


                'creo una variable de respaldo de memoria
                Dim ms As New IO.MemoryStream()

                'creo una condicional para verificar que la imagen no este vacia
                If Not ImagenPortada.Image Is Nothing Then
                    ImagenPortada.Image.Save(ms, ImagenPortada.Image.RawFormat)
                Else
                    ImagenPortada.Image = My.Resources.file
                    ImagenPortada.Image.Save(ms, ImagenPortada.Image.RawFormat)
                End If
                'envio parametros de memoria al picturebox
                dts.GIMAGEN = ms.GetBuffer

                'resivo parametros de funcion insertar
                If func.insertar(dts) Then
                    MessageBox.Show("Libro registrado correctamente", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'mostrar()
                    'limpiar()
                Else
                    MessageBox.Show("el Libro no fue registrado intente de nuevo", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'mostrar()
                    'limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub
End Class