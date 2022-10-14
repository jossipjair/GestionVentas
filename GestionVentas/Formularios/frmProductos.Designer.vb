<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Me.gboBusqueda = New System.Windows.Forms.GroupBox()
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gboDatos = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.gboBusqueda.SuspendLayout()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboBusqueda
        '
        Me.gboBusqueda.Controls.Add(Me.btnBuscar)
        Me.gboBusqueda.Controls.Add(Me.txtBusqueda)
        Me.gboBusqueda.Controls.Add(Me.Label1)
        Me.gboBusqueda.Controls.Add(Me.dgvBusqueda)
        Me.gboBusqueda.Location = New System.Drawing.Point(12, 12)
        Me.gboBusqueda.Name = "gboBusqueda"
        Me.gboBusqueda.Size = New System.Drawing.Size(518, 491)
        Me.gboBusqueda.TabIndex = 0
        Me.gboBusqueda.TabStop = False
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Location = New System.Drawing.Point(12, 66)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.Size = New System.Drawing.Size(491, 412)
        Me.dgvBusqueda.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Escriba:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(55, 28)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(353, 20)
        Me.txtBusqueda.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.GestionVentas.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(414, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(89, 34)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'gboDatos
        '
        Me.gboDatos.Controls.Add(Me.btnCerrar)
        Me.gboDatos.Controls.Add(Me.btnEliminar)
        Me.gboDatos.Controls.Add(Me.btnCancelar)
        Me.gboDatos.Controls.Add(Me.btnGuardar)
        Me.gboDatos.Controls.Add(Me.btnEditar)
        Me.gboDatos.Controls.Add(Me.btnNuevo)
        Me.gboDatos.Controls.Add(Me.TextBox7)
        Me.gboDatos.Controls.Add(Me.Label9)
        Me.gboDatos.Controls.Add(Me.TextBox6)
        Me.gboDatos.Controls.Add(Me.Label8)
        Me.gboDatos.Controls.Add(Me.TextBox5)
        Me.gboDatos.Controls.Add(Me.Label7)
        Me.gboDatos.Controls.Add(Me.TextBox4)
        Me.gboDatos.Controls.Add(Me.Label6)
        Me.gboDatos.Controls.Add(Me.TextBox3)
        Me.gboDatos.Controls.Add(Me.Label5)
        Me.gboDatos.Controls.Add(Me.TextBox2)
        Me.gboDatos.Controls.Add(Me.Label4)
        Me.gboDatos.Controls.Add(Me.ComboBox1)
        Me.gboDatos.Controls.Add(Me.Label3)
        Me.gboDatos.Controls.Add(Me.TextBox1)
        Me.gboDatos.Controls.Add(Me.Label2)
        Me.gboDatos.Location = New System.Drawing.Point(536, 12)
        Me.gboDatos.Name = "gboDatos"
        Me.gboDatos.Size = New System.Drawing.Size(460, 491)
        Me.gboDatos.TabIndex = 1
        Me.gboDatos.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo de Producto:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(98, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Unidad de Medida:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(11, 101)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descripción de Producto:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 154)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(443, 20)
        Me.TextBox2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nombre Comercial del Producto:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(11, 208)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(443, 20)
        Me.TextBox3.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Código de Parte:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(11, 264)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(207, 20)
        Me.TextBox4.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Código de Parte Alternativo 1: "
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(11, 318)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(204, 20)
        Me.TextBox5.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Código de Parte Alternativo 2:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(11, 372)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(201, 20)
        Me.TextBox6.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 412)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Precio:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(11, 429)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(132, 20)
        Me.TextBox7.TabIndex = 18
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = Global.GestionVentas.My.Resources.Resources.close_copia
        Me.btnCerrar.Location = New System.Drawing.Point(408, 441)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(36, 37)
        Me.btnCerrar.TabIndex = 66
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.GestionVentas.My.Resources.Resources.elimina_copia
        Me.btnEliminar.Location = New System.Drawing.Point(265, 376)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(114, 37)
        Me.btnEliminar.TabIndex = 65
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.GestionVentas.My.Resources.Resources.cancelar_copia
        Me.btnCancelar.Location = New System.Drawing.Point(265, 419)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(114, 37)
        Me.btnCancelar.TabIndex = 64
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.GestionVentas.My.Resources.Resources.GRABAR1_copia
        Me.btnGuardar.Location = New System.Drawing.Point(265, 333)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(114, 37)
        Me.btnGuardar.TabIndex = 63
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = Global.GestionVentas.My.Resources.Resources.modifica_copia
        Me.btnEditar.Location = New System.Drawing.Point(265, 290)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(114, 37)
        Me.btnEditar.TabIndex = 62
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.GestionVentas.My.Resources.Resources.nuevo_copia
        Me.btnNuevo.Location = New System.Drawing.Point(265, 247)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(114, 37)
        Me.btnNuevo.TabIndex = 61
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 512)
        Me.Controls.Add(Me.gboDatos)
        Me.Controls.Add(Me.gboBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Productos"
        Me.gboBusqueda.ResumeLayout(False)
        Me.gboBusqueda.PerformLayout()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboDatos.ResumeLayout(False)
        Me.gboDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents gboDatos As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Private WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class
