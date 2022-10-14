<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPais
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
        Me.dgvPais = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtIdPais = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvPais)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 443)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'dgvPais
        '
        Me.dgvPais.AllowUserToAddRows = False
        Me.dgvPais.AllowUserToDeleteRows = False
        Me.dgvPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPais.Location = New System.Drawing.Point(6, 19)
        Me.dgvPais.Name = "dgvPais"
        Me.dgvPais.ReadOnly = True
        Me.dgvPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPais.Size = New System.Drawing.Size(414, 413)
        Me.dgvPais.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.txtIdPais)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(444, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 443)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(18, 252)
        Me.txtDescripcion.MaxLength = 20
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(314, 20)
        Me.txtDescripcion.TabIndex = 34
        '
        'txtIdPais
        '
        Me.txtIdPais.Location = New System.Drawing.Point(18, 196)
        Me.txtIdPais.Name = "txtIdPais"
        Me.txtIdPais.Size = New System.Drawing.Size(117, 20)
        Me.txtIdPais.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "IdPais:"
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = Global.GestionVentas.My.Resources.Resources.close_copia
        Me.btnCerrar.Location = New System.Drawing.Point(466, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(36, 37)
        Me.btnCerrar.TabIndex = 68
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.GestionVentas.My.Resources.Resources.elimina_copia
        Me.btnEliminar.Location = New System.Drawing.Point(424, 10)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(36, 37)
        Me.btnEliminar.TabIndex = 67
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.GestionVentas.My.Resources.Resources.cancelar_copia
        Me.btnCancelar.Location = New System.Drawing.Point(382, 10)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(36, 37)
        Me.btnCancelar.TabIndex = 66
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.GestionVentas.My.Resources.Resources.GRABAR1_copia
        Me.btnGuardar.Location = New System.Drawing.Point(340, 10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(36, 37)
        Me.btnGuardar.TabIndex = 65
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = Global.GestionVentas.My.Resources.Resources.modifica_copia
        Me.btnEditar.Location = New System.Drawing.Point(298, 10)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(36, 37)
        Me.btnEditar.TabIndex = 64
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.GestionVentas.My.Resources.Resources.nuevo_copia
        Me.btnNuevo.Location = New System.Drawing.Point(256, 10)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(36, 37)
        Me.btnNuevo.TabIndex = 63
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmPais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 521)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Paises"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPais As System.Windows.Forms.DataGridView
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Private WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtIdPais As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
