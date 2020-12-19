<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListasDEnlazadas
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
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.bntBorrarUltimo = New System.Windows.Forms.Button()
        Me.bntBorrarPrimero = New System.Windows.Forms.Button()
        Me.btnRecorrerAdelante = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblDato = New System.Windows.Forms.Label()
        Me.txtDatos = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(100, 541)
        Me.label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(75, 25)
        Me.label2.TabIndex = 30
        Me.label2.Text = "LISTA:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(65, 22)
        Me.label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(197, 25)
        Me.label1.TabIndex = 29
        Me.label1.Text = "INGRESA EL DATO:"
        '
        'bntBorrarUltimo
        '
        Me.bntBorrarUltimo.Location = New System.Drawing.Point(461, 232)
        Me.bntBorrarUltimo.Margin = New System.Windows.Forms.Padding(6)
        Me.bntBorrarUltimo.Name = "bntBorrarUltimo"
        Me.bntBorrarUltimo.Size = New System.Drawing.Size(194, 46)
        Me.bntBorrarUltimo.TabIndex = 27
        Me.bntBorrarUltimo.Text = "Borrar ultimo"
        Me.bntBorrarUltimo.UseVisualStyleBackColor = True
        '
        'bntBorrarPrimero
        '
        Me.bntBorrarPrimero.Location = New System.Drawing.Point(166, 232)
        Me.bntBorrarPrimero.Margin = New System.Windows.Forms.Padding(6)
        Me.bntBorrarPrimero.Name = "bntBorrarPrimero"
        Me.bntBorrarPrimero.Size = New System.Drawing.Size(194, 46)
        Me.bntBorrarPrimero.TabIndex = 26
        Me.bntBorrarPrimero.Text = "Borrar primero"
        Me.bntBorrarPrimero.UseVisualStyleBackColor = True
        '
        'btnRecorrerAdelante
        '
        Me.btnRecorrerAdelante.Location = New System.Drawing.Point(166, 144)
        Me.btnRecorrerAdelante.Margin = New System.Windows.Forms.Padding(6)
        Me.btnRecorrerAdelante.Name = "btnRecorrerAdelante"
        Me.btnRecorrerAdelante.Size = New System.Drawing.Size(194, 46)
        Me.btnRecorrerAdelante.TabIndex = 23
        Me.btnRecorrerAdelante.Text = "Recorrer"
        Me.btnRecorrerAdelante.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(461, 144)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(194, 46)
        Me.btnAtras.TabIndex = 24
        Me.btnAtras.Text = "Recorrer inverso"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(305, 332)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(194, 46)
        Me.btnBorrar.TabIndex = 28
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblDato
        '
        Me.lblDato.AutoSize = True
        Me.lblDato.Location = New System.Drawing.Point(311, 541)
        Me.lblDato.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDato.Name = "lblDato"
        Me.lblDato.Size = New System.Drawing.Size(17, 25)
        Me.lblDato.TabIndex = 25
        Me.lblDato.Text = "."
        '
        'txtDatos
        '
        Me.txtDatos.Location = New System.Drawing.Point(316, 22)
        Me.txtDatos.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(180, 29)
        Me.txtDatos.TabIndex = 21
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(562, 11)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(174, 46)
        Me.btnIngresar.TabIndex = 22
        Me.btnIngresar.Text = "Ingresar al Inicio"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'ListasDEnlazadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 610)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.bntBorrarUltimo)
        Me.Controls.Add(Me.bntBorrarPrimero)
        Me.Controls.Add(Me.btnRecorrerAdelante)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.lblDato)
        Me.Controls.Add(Me.txtDatos)
        Me.Controls.Add(Me.btnIngresar)
        Me.Name = "ListasDEnlazadas"
        Me.Text = "ListasDEnlazadas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents bntBorrarUltimo As Button
    Private WithEvents bntBorrarPrimero As Button
    Private WithEvents btnRecorrerAdelante As Button
    Private WithEvents btnAtras As Button
    Private WithEvents btnBorrar As Button
    Private WithEvents lblDato As Label
    Private WithEvents txtDatos As TextBox
    Private WithEvents btnIngresar As Button
End Class
