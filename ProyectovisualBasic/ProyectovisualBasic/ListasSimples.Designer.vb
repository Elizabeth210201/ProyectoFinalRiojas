<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListasSimples
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
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(158, 399)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(484, 26)
        Me.textBox1.TabIndex = 21
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(524, 290)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(100, 57)
        Me.btnBorrar.TabIndex = 20
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(524, 224)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 57)
        Me.btnBuscar.TabIndex = 19
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(524, 157)
        Me.btn3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(100, 57)
        Me.btn3.TabIndex = 18
        Me.btn3.Text = "Mostrar"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(524, 91)
        Me.btn2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(100, 57)
        Me.btn2.TabIndex = 17
        Me.btn2.Text = "Contar"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(185, 39)
        Me.txtDato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(262, 26)
        Me.txtDato.TabIndex = 16
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(524, 25)
        Me.btn1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(100, 57)
        Me.btn1.TabIndex = 15
        Me.btn1.Text = "Insertar"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'ListasSimples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.btn1)
        Me.Name = "ListasSimples"
        Me.Text = "ListasSimples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBox1 As TextBox
    Private WithEvents btnBorrar As Button
    Private WithEvents btnBuscar As Button
    Private WithEvents btn3 As Button
    Private WithEvents btn2 As Button
    Private WithEvents txtDato As TextBox
    Private WithEvents btn1 As Button
End Class
