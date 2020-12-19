<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class colas
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
        Me.Numero = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.btnDesencolar = New System.Windows.Forms.Button()
        Me.btnEncolar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Numero
        '
        Me.Numero.AutoSize = True
        Me.Numero.Location = New System.Drawing.Point(177, 216)
        Me.Numero.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(81, 25)
        Me.Numero.TabIndex = 29
        Me.Numero.Text = "Numero"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(268, 210)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(6)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(180, 29)
        Me.txtNumero.TabIndex = 28
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(178, 162)
        Me.label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(81, 25)
        Me.label1.TabIndex = 27
        Me.label1.Text = "Maximo"
        '
        'txtMaximo
        '
        Me.txtMaximo.Location = New System.Drawing.Point(268, 157)
        Me.txtMaximo.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(180, 29)
        Me.txtMaximo.TabIndex = 26
        '
        'btnDesencolar
        '
        Me.btnDesencolar.Location = New System.Drawing.Point(485, 258)
        Me.btnDesencolar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDesencolar.Name = "btnDesencolar"
        Me.btnDesencolar.Size = New System.Drawing.Size(138, 42)
        Me.btnDesencolar.TabIndex = 25
        Me.btnDesencolar.Text = "Desencolar"
        Me.btnDesencolar.UseVisualStyleBackColor = True
        '
        'btnEncolar
        '
        Me.btnEncolar.Location = New System.Drawing.Point(485, 205)
        Me.btnEncolar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnEncolar.Name = "btnEncolar"
        Me.btnEncolar.Size = New System.Drawing.Size(138, 42)
        Me.btnEncolar.TabIndex = 24
        Me.btnEncolar.Text = "Encolar"
        Me.btnEncolar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(485, 151)
        Me.btnCrear.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(138, 42)
        Me.btnCrear.TabIndex = 23
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'colas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Numero)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtMaximo)
        Me.Controls.Add(Me.btnDesencolar)
        Me.Controls.Add(Me.btnEncolar)
        Me.Controls.Add(Me.btnCrear)
        Me.Name = "colas"
        Me.Text = "colas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Numero As Label
    Private WithEvents txtNumero As TextBox
    Private WithEvents label1 As Label
    Private WithEvents txtMaximo As TextBox
    Private WithEvents btnDesencolar As Button
    Private WithEvents btnEncolar As Button
    Private WithEvents btnCrear As Button
End Class
