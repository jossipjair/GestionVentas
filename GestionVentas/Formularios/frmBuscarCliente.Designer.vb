<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCliente
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
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboParBusqueda = New System.Windows.Forms.ComboBox()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.AllowUserToAddRows = False
        Me.dgvBusqueda.AllowUserToDeleteRows = False
        Me.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Location = New System.Drawing.Point(12, 76)
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.ReadOnly = True
        Me.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBusqueda.Size = New System.Drawing.Size(453, 274)
        Me.dgvBusqueda.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.GestionVentas.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(390, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 35)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar por"
        '
        'cboParBusqueda
        '
        Me.cboParBusqueda.FormattingEnabled = True
        Me.cboParBusqueda.Items.AddRange(New Object() {"RUC / DNI", "NOMBRE COMERCIAL", "APELLIDO PATERNO"})
        Me.cboParBusqueda.Location = New System.Drawing.Point(16, 30)
        Me.cboParBusqueda.Name = "cboParBusqueda"
        Me.cboParBusqueda.Size = New System.Drawing.Size(146, 21)
        Me.cboParBusqueda.TabIndex = 3
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Location = New System.Drawing.Point(168, 30)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(216, 20)
        Me.txtBusqueda.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Escriba"
        '
        'frmBuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 362)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.cboParBusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Cliente"
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboParBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
