<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arboles
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
        Me.lblArbol = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnPostOrden = New System.Windows.Forms.Button()
        Me.btnEnOrden = New System.Windows.Forms.Button()
        Me.btnPreOrden = New System.Windows.Forms.Button()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblArbol
        '
        Me.lblArbol.AutoSize = True
        Me.lblArbol.Location = New System.Drawing.Point(341, 358)
        Me.lblArbol.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblArbol.Name = "lblArbol"
        Me.lblArbol.Size = New System.Drawing.Size(13, 20)
        Me.lblArbol.TabIndex = 42
        Me.lblArbol.Text = "."
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(362, 128)
        Me.lblResultado.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 20)
        Me.lblResultado.TabIndex = 41
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(287, 73)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 20)
        Me.label1.TabIndex = 40
        Me.label1.Text = "Dato:"
        '
        'btnPostOrden
        '
        Me.btnPostOrden.Location = New System.Drawing.Point(456, 238)
        Me.btnPostOrden.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPostOrden.Name = "btnPostOrden"
        Me.btnPostOrden.Size = New System.Drawing.Size(109, 68)
        Me.btnPostOrden.TabIndex = 37
        Me.btnPostOrden.Text = "PostOrden"
        Me.btnPostOrden.UseVisualStyleBackColor = True
        '
        'btnEnOrden
        '
        Me.btnEnOrden.Location = New System.Drawing.Point(346, 238)
        Me.btnEnOrden.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEnOrden.Name = "btnEnOrden"
        Me.btnEnOrden.Size = New System.Drawing.Size(109, 68)
        Me.btnEnOrden.TabIndex = 36
        Me.btnEnOrden.Text = "EnOrden"
        Me.btnEnOrden.UseVisualStyleBackColor = True
        '
        'btnPreOrden
        '
        Me.btnPreOrden.Location = New System.Drawing.Point(236, 238)
        Me.btnPreOrden.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPreOrden.Name = "btnPreOrden"
        Me.btnPreOrden.Size = New System.Drawing.Size(109, 68)
        Me.btnPreOrden.TabIndex = 35
        Me.btnPreOrden.Text = "PreOrden"
        Me.btnPreOrden.UseVisualStyleBackColor = True
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(346, 73)
        Me.txtDato.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(107, 26)
        Me.txtDato.TabIndex = 39
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(456, 159)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(109, 68)
        Me.btnBorrar.TabIndex = 38
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(346, 159)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(109, 68)
        Me.btnBuscar.TabIndex = 34
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(236, 159)
        Me.btnInsertar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(109, 68)
        Me.btnInsertar.TabIndex = 33
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'Arboles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblArbol)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnPostOrden)
        Me.Controls.Add(Me.btnEnOrden)
        Me.Controls.Add(Me.btnPreOrden)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Name = "Arboles"
        Me.Text = "Arboles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblArbol As Label
    Private WithEvents lblResultado As Label
    Private WithEvents label1 As Label
    Private WithEvents btnPostOrden As Button
    Private WithEvents btnEnOrden As Button
    Private WithEvents btnPreOrden As Button
    Private WithEvents txtDato As TextBox
    Private WithEvents btnBorrar As Button
    Private WithEvents btnBuscar As Button
    Private WithEvents btnInsertar As Button
End Class
