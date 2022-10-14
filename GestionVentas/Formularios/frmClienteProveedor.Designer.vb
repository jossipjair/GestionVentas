<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteProveedor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoCliente = New System.Windows.Forms.ComboBox()
        Me.dgvListaClienteProveedor = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.dgvListaClienteProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Cliente / Proveedor"
        '
        'cboTipoCliente
        '
        Me.cboTipoCliente.FormattingEnabled = True
        Me.cboTipoCliente.Items.AddRange(New Object() {"(Todos)", "CLIENTE", "PROVEEDOR"})
        Me.cboTipoCliente.Location = New System.Drawing.Point(26, 29)
        Me.cboTipoCliente.Name = "cboTipoCliente"
        Me.cboTipoCliente.Size = New System.Drawing.Size(283, 21)
        Me.cboTipoCliente.TabIndex = 1
        '
        'dgvListaClienteProveedor
        '
        Me.dgvListaClienteProveedor.AllowUserToAddRows = False
        Me.dgvListaClienteProveedor.AllowUserToDeleteRows = False
        Me.dgvListaClienteProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaClienteProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaClienteProveedor.Location = New System.Drawing.Point(12, 68)
        Me.dgvListaClienteProveedor.Name = "dgvListaClienteProveedor"
        Me.dgvListaClienteProveedor.ReadOnly = True
        Me.dgvListaClienteProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaClienteProveedor.Size = New System.Drawing.Size(1319, 501)
        Me.dgvListaClienteProveedor.TabIndex = 3
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.GestionVentas.My.Resources.Resources.nuevo_copia
        Me.btnNuevo.Location = New System.Drawing.Point(601, 7)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(165, 49)
        Me.btnNuevo.TabIndex = 56
        Me.btnNuevo.Text = "Nuevo Registro"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Image = Global.GestionVentas.My.Resources.Resources.check_copia
        Me.btnMostrar.Location = New System.Drawing.Point(1174, 13)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(157, 37)
        Me.btnMostrar.TabIndex = 2
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(823, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(872, 22)
        Me.txtBuscar.MaxLength = 40
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(296, 20)
        Me.txtBuscar.TabIndex = 58
        '
        'frmClienteProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 581)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvListaClienteProveedor)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.cboTipoCliente)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClienteProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Clientes / Proveedores"
        CType(Me.dgvListaClienteProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipoCliente As System.Windows.Forms.ComboBox
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents dgvListaClienteProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
End Class
