﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListasDcirculares
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
        Me.lblContarDes = New System.Windows.Forms.Label()
        Me.lblContar = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnMostrarDatos = New System.Windows.Forms.Button()
        Me.btnContar = New System.Windows.Forms.Button()
        Me.txtInsertar = New System.Windows.Forms.TextBox()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblContarDes
        '
        Me.lblContarDes.AutoSize = True
        Me.lblContarDes.Location = New System.Drawing.Point(304, 378)
        Me.lblContarDes.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblContarDes.Name = "lblContarDes"
        Me.lblContarDes.Size = New System.Drawing.Size(37, 25)
        Me.lblContarDes.TabIndex = 25
        Me.lblContarDes.Text = "....."
        '
        'lblContar
        '
        Me.lblContar.AutoSize = True
        Me.lblContar.Location = New System.Drawing.Point(304, 275)
        Me.lblContar.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblContar.Name = "lblContar"
        Me.lblContar.Size = New System.Drawing.Size(37, 25)
        Me.lblContar.TabIndex = 24
        Me.lblContar.Text = "....."
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(537, 173)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(138, 42)
        Me.btnBorrar.TabIndex = 22
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(537, 48)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(138, 42)
        Me.btnBuscar.TabIndex = 23
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnMostrarDatos
        '
        Me.btnMostrarDatos.Location = New System.Drawing.Point(330, 173)
        Me.btnMostrarDatos.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMostrarDatos.Name = "btnMostrarDatos"
        Me.btnMostrarDatos.Size = New System.Drawing.Size(138, 42)
        Me.btnMostrarDatos.TabIndex = 21
        Me.btnMostrarDatos.Text = "Mostrar"
        Me.btnMostrarDatos.UseVisualStyleBackColor = True
        '
        'btnContar
        '
        Me.btnContar.Location = New System.Drawing.Point(126, 173)
        Me.btnContar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnContar.Name = "btnContar"
        Me.btnContar.Size = New System.Drawing.Size(138, 42)
        Me.btnContar.TabIndex = 20
        Me.btnContar.Text = "Contar"
        Me.btnContar.UseVisualStyleBackColor = True
        '
        'txtInsertar
        '
        Me.txtInsertar.Location = New System.Drawing.Point(309, 52)
        Me.txtInsertar.Margin = New System.Windows.Forms.Padding(6)
        Me.txtInsertar.Name = "txtInsertar"
        Me.txtInsertar.Size = New System.Drawing.Size(180, 29)
        Me.txtInsertar.TabIndex = 18
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(126, 48)
        Me.btnInsertar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(138, 42)
        Me.btnInsertar.TabIndex = 19
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'ListasDcirculares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblContarDes)
        Me.Controls.Add(Me.lblContar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnMostrarDatos)
        Me.Controls.Add(Me.btnContar)
        Me.Controls.Add(Me.txtInsertar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Name = "ListasDcirculares"
        Me.Text = "ListasDcirculares"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblContarDes As Label
    Private WithEvents lblContar As Label
    Private WithEvents btnBorrar As Button
    Private WithEvents btnBuscar As Button
    Private WithEvents btnMostrarDatos As Button
    Private WithEvents btnContar As Button
    Private WithEvents txtInsertar As TextBox
    Private WithEvents btnInsertar As Button
End Class