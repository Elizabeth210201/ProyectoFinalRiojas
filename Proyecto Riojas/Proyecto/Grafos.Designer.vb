<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grafos
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
        Me.btnAgregarArista = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminarArista = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Union = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.Nodos = New System.Windows.Forms.ComboBox()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAgregarArista
        '
        Me.btnAgregarArista.Location = New System.Drawing.Point(407, 189)
        Me.btnAgregarArista.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btnAgregarArista.Name = "btnAgregarArista"
        Me.btnAgregarArista.Size = New System.Drawing.Size(116, 87)
        Me.btnAgregarArista.TabIndex = 22
        Me.btnAgregarArista.Text = "Agregar"
        Me.btnAgregarArista.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.Location = New System.Drawing.Point(57, 188)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 87)
        Me.btnAgregar.TabIndex = 21
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnEliminarArista
        '
        Me.btnEliminarArista.Location = New System.Drawing.Point(627, 188)
        Me.btnEliminarArista.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btnEliminarArista.Name = "btnEliminarArista"
        Me.btnEliminarArista.Size = New System.Drawing.Size(116, 87)
        Me.btnEliminarArista.TabIndex = 29
        Me.btnEliminarArista.Text = "Eliminar"
        Me.btnEliminarArista.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(183, 188)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(116, 87)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Union
        '
        Me.Union.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Union.FormattingEnabled = True
        Me.Union.Location = New System.Drawing.Point(627, 134)
        Me.Union.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Union.Name = "Union"
        Me.Union.Size = New System.Drawing.Size(107, 32)
        Me.Union.TabIndex = 25
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(476, 97)
        Me.label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(173, 25)
        Me.label3.TabIndex = 26
        Me.label3.Text = "De donde a donde"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(57, 333)
        Me.lblResultado.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(126, 20)
        Me.lblResultado.TabIndex = 27
        Me.lblResultado.Text = "RESULTADO"
        '
        'Nodos
        '
        Me.Nodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Nodos.FormattingEnabled = True
        Me.Nodos.Location = New System.Drawing.Point(409, 134)
        Me.Nodos.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Nodos.Name = "Nodos"
        Me.Nodos.Size = New System.Drawing.Size(112, 32)
        Me.Nodos.TabIndex = 24
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(121, 134)
        Me.txtDato.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(131, 29)
        Me.txtDato.TabIndex = 23
        '
        'Grafos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAgregarArista)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnEliminarArista)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Union)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.Nodos)
        Me.Controls.Add(Me.txtDato)
        Me.Name = "Grafos"
        Me.Text = "Grafos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnAgregarArista As Button
    Private WithEvents btnAgregar As Button
    Private WithEvents btnEliminarArista As Button
    Private WithEvents btnEliminar As Button
    Private WithEvents Union As ComboBox
    Private WithEvents label3 As Label
    Private WithEvents lblResultado As Label
    Private WithEvents Nodos As ComboBox
    Private WithEvents txtDato As TextBox
End Class
