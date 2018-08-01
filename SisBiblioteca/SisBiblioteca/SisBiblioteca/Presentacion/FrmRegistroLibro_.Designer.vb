<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroLibro_
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigoLibro = New System.Windows.Forms.TextBox()
        Me.TxtNombreLibro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GroupRegistro = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarCategoria = New System.Windows.Forms.Button()
        Me.BtnBuscarAutor = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtObservacionLibro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCategoriaLibro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtAutorLibro = New System.Windows.Forms.TextBox()
        Me.GroupPortada = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImagenPortada = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CargarPortada = New System.Windows.Forms.OpenFileDialog()
        Me.CmbEstadoLibro = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupRegistro.SuspendLayout()
        Me.GroupPortada.SuspendLayout()
        CType(Me.ImagenPortada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(787, 44)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(775, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRO LIBRO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código Libro"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCodigoLibro
        '
        Me.TxtCodigoLibro.Location = New System.Drawing.Point(9, 76)
        Me.TxtCodigoLibro.Name = "TxtCodigoLibro"
        Me.TxtCodigoLibro.Size = New System.Drawing.Size(115, 20)
        Me.TxtCodigoLibro.TabIndex = 0
        '
        'TxtNombreLibro
        '
        Me.TxtNombreLibro.Location = New System.Drawing.Point(153, 76)
        Me.TxtNombreLibro.Name = "TxtNombreLibro"
        Me.TxtNombreLibro.Size = New System.Drawing.Size(346, 20)
        Me.TxtNombreLibro.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre Libro"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(283, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FechaRegistro
        '
        Me.FechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaRegistro.Location = New System.Drawing.Point(344, 19)
        Me.FechaRegistro.Name = "FechaRegistro"
        Me.FechaRegistro.Size = New System.Drawing.Size(155, 20)
        Me.FechaRegistro.TabIndex = 0
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(491, 19)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(88, 50)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'GroupRegistro
        '
        Me.GroupRegistro.Controls.Add(Me.CmbEstadoLibro)
        Me.GroupRegistro.Controls.Add(Me.BtnBuscarCategoria)
        Me.GroupRegistro.Controls.Add(Me.BtnBuscarAutor)
        Me.GroupRegistro.Controls.Add(Me.Label9)
        Me.GroupRegistro.Controls.Add(Me.TxtObservacionLibro)
        Me.GroupRegistro.Controls.Add(Me.Label8)
        Me.GroupRegistro.Controls.Add(Me.Label7)
        Me.GroupRegistro.Controls.Add(Me.TxtCategoriaLibro)
        Me.GroupRegistro.Controls.Add(Me.Label6)
        Me.GroupRegistro.Controls.Add(Me.TxtAutorLibro)
        Me.GroupRegistro.Controls.Add(Me.Label2)
        Me.GroupRegistro.Controls.Add(Me.TxtCodigoLibro)
        Me.GroupRegistro.Controls.Add(Me.Label4)
        Me.GroupRegistro.Controls.Add(Me.FechaRegistro)
        Me.GroupRegistro.Controls.Add(Me.TxtNombreLibro)
        Me.GroupRegistro.Controls.Add(Me.Label3)
        Me.GroupRegistro.Location = New System.Drawing.Point(96, 76)
        Me.GroupRegistro.Name = "GroupRegistro"
        Me.GroupRegistro.Size = New System.Drawing.Size(514, 279)
        Me.GroupRegistro.TabIndex = 10
        Me.GroupRegistro.TabStop = False
        Me.GroupRegistro.Text = "Ingreso Libros"
        '
        'BtnBuscarCategoria
        '
        Me.BtnBuscarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarCategoria.Location = New System.Drawing.Point(306, 148)
        Me.BtnBuscarCategoria.Name = "BtnBuscarCategoria"
        Me.BtnBuscarCategoria.Size = New System.Drawing.Size(31, 20)
        Me.BtnBuscarCategoria.TabIndex = 15
        Me.BtnBuscarCategoria.UseVisualStyleBackColor = True
        '
        'BtnBuscarAutor
        '
        Me.BtnBuscarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarAutor.Location = New System.Drawing.Point(123, 148)
        Me.BtnBuscarAutor.Name = "BtnBuscarAutor"
        Me.BtnBuscarAutor.Size = New System.Drawing.Size(31, 20)
        Me.BtnBuscarAutor.TabIndex = 14
        Me.BtnBuscarAutor.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Observaciones"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtObservacionLibro
        '
        Me.TxtObservacionLibro.Location = New System.Drawing.Point(9, 200)
        Me.TxtObservacionLibro.Multiline = True
        Me.TxtObservacionLibro.Name = "TxtObservacionLibro"
        Me.TxtObservacionLibro.Size = New System.Drawing.Size(490, 55)
        Me.TxtObservacionLibro.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(365, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Estado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(199, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Categoría"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCategoriaLibro
        '
        Me.TxtCategoriaLibro.Location = New System.Drawing.Point(192, 148)
        Me.TxtCategoriaLibro.Name = "TxtCategoriaLibro"
        Me.TxtCategoriaLibro.Size = New System.Drawing.Size(115, 20)
        Me.TxtCategoriaLibro.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Autor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtAutorLibro
        '
        Me.TxtAutorLibro.Location = New System.Drawing.Point(9, 148)
        Me.TxtAutorLibro.Name = "TxtAutorLibro"
        Me.TxtAutorLibro.Size = New System.Drawing.Size(115, 20)
        Me.TxtAutorLibro.TabIndex = 0
        '
        'GroupPortada
        '
        Me.GroupPortada.Controls.Add(Me.Button2)
        Me.GroupPortada.Controls.Add(Me.Button1)
        Me.GroupPortada.Controls.Add(Me.ImagenPortada)
        Me.GroupPortada.Location = New System.Drawing.Point(632, 76)
        Me.GroupPortada.Name = "GroupPortada"
        Me.GroupPortada.Size = New System.Drawing.Size(219, 192)
        Me.GroupPortada.TabIndex = 11
        Me.GroupPortada.TabStop = False
        Me.GroupPortada.Text = "Portada Libro"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(146, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 50)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Eliminar Foto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cargar Foto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImagenPortada
        '
        Me.ImagenPortada.BackColor = System.Drawing.Color.Gray
        Me.ImagenPortada.Location = New System.Drawing.Point(17, 32)
        Me.ImagenPortada.Name = "ImagenPortada"
        Me.ImagenPortada.Size = New System.Drawing.Size(115, 142)
        Me.ImagenPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenPortada.TabIndex = 0
        Me.ImagenPortada.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnCancelar)
        Me.GroupBox4.Controls.Add(Me.BtnModificar)
        Me.GroupBox4.Controls.Add(Me.BtnGuardar)
        Me.GroupBox4.Controls.Add(Me.BtnNuevo)
        Me.GroupBox4.Controls.Add(Me.BtnSalir)
        Me.GroupBox4.Controls.Add(Me.BtnBuscar)
        Me.GroupBox4.Location = New System.Drawing.Point(47, 361)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(609, 82)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(397, 19)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(88, 50)
        Me.BtnCancelar.TabIndex = 0
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(303, 19)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(88, 50)
        Me.BtnModificar.TabIndex = 0
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(115, 19)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(88, 50)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(21, 19)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(88, 50)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(209, 19)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(88, 50)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CargarPortada
        '
        Me.CargarPortada.FileName = "OpenFileDialog1"
        '
        'CmbEstadoLibro
        '
        Me.CmbEstadoLibro.FormattingEnabled = True
        Me.CmbEstadoLibro.Location = New System.Drawing.Point(354, 147)
        Me.CmbEstadoLibro.Name = "CmbEstadoLibro"
        Me.CmbEstadoLibro.Size = New System.Drawing.Size(145, 21)
        Me.CmbEstadoLibro.TabIndex = 17
        '
        'FrmRegistroLibro_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 476)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupPortada)
        Me.Controls.Add(Me.GroupRegistro)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRegistroLibro_"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistroLibro_"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupRegistro.ResumeLayout(False)
        Me.GroupRegistro.PerformLayout()
        Me.GroupPortada.ResumeLayout(False)
        CType(Me.ImagenPortada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodigoLibro As TextBox
    Friend WithEvents TxtNombreLibro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FechaRegistro As DateTimePicker
    Friend WithEvents BtnSalir As Button
    Friend WithEvents GroupRegistro As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtAutorLibro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCategoriaLibro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtObservacionLibro As TextBox
    Friend WithEvents GroupPortada As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ImagenPortada As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents CargarPortada As OpenFileDialog
    Friend WithEvents BtnBuscarAutor As Button
    Friend WithEvents BtnBuscarCategoria As Button
    Friend WithEvents CmbEstadoLibro As ComboBox
End Class
