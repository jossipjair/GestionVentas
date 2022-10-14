<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoMovimiento
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
        Me.dgvTipoMovimiento = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDscMovimiento = New System.Windows.Forms.TextBox()
        Me.txtIdMovimiento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTipoMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvTipoMovimiento)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 443)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'dgvTipoMovimiento
        '
        Me.dgvTipoMovimiento.AllowUserToAddRows = False
        Me.dgvTipoMovimiento.AllowUserToDeleteRows = False
        Me.dgvTipoMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipoMovimiento.Location = New System.Drawing.Point(6, 19)
        Me.dgvTipoMovimiento.Name = "dgvTipoMovimiento"
        Me.dgvTipoMovimiento.ReadOnly = True
        Me.dgvTipoMovimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTipoMovimiento.Size = New System.Drawing.Size(414, 413)
        Me.dgvTipoMovimiento.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDscMovimiento)
        Me.GroupBox2.Controls.Add(Me.txtIdMovimiento)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(444, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 443)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        '
        'txtDscMovimiento
        '
        Me.txtDscMovimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDscMovimiento.Location = New System.Drawing.Point(9, 237)
        Me.txtDscMovimiento.MaxLength = 50
        Me.txtDscMovimiento.Name = "txtDscMovimiento"
        Me.txtDscMovimiento.Size = New System.Drawing.Size(323, 20)
        Me.txtDscMovimiento.TabIndex = 34
        '
        'txtIdMovimiento
        '
        Me.txtIdMovimiento.Location = New System.Drawing.Point(9, 184)
        Me.txtIdMovimiento.Name = "txtIdMovimiento"
        Me.txtIdMovimiento.Size = New System.Drawing.Size(117, 20)
        Me.txtIdMovimiento.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "IdTipoMovimiento"
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
        'frmTipoMovimiento
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
        Me.Name = "frmTipoMovimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Tipo de Movimientos de Almacen"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvTipoMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTipoMovimiento As System.Windows.Forms.DataGridView
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Private WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDscMovimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtIdMovimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
