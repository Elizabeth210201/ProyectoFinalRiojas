﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 250)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Insertar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(243, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 47)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(350, 250)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 47)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "borrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(136, 316)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 47)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "preorden"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(243, 316)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 47)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "posorden"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(350, 316)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(101, 47)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = " Orden"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "dato"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 29)
        Me.TextBox1.TabIndex = 7
        '
        'Arboles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Arboles"
        Me.Text = "Arboles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
