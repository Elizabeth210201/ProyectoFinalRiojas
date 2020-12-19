<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listascirculares
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
        Me.txtLista = New System.Windows.Forms.TextBox()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLista
        '
        Me.txtLista.Location = New System.Drawing.Point(166, 176)
        Me.txtLista.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLista.Multiline = True
        Me.txtLista.Name = "txtLista"
        Me.txtLista.Size = New System.Drawing.Size(275, 340)
        Me.txtLista.TabIndex = 16
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(166, 19)
        Me.txtDato.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(275, 29)
        Me.txtDato.TabIndex = 13
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(491, 65)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(143, 48)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(491, 8)
        Me.btnInsertar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(143, 48)
        Me.btnInsertar.TabIndex = 14
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'Listascirculares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 559)
        Me.Controls.Add(Me.txtLista)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Name = "Listascirculares"
        Me.Text = "Listascirculares"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtLista As TextBox
    Private WithEvents txtDato As TextBox
    Private WithEvents btnEliminar As Button
    Private WithEvents btnInsertar As Button
End Class
