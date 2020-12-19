<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstructuraDeDatos
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.BtnGrafos = New System.Windows.Forms.Button()
        Me.btnArboles = New System.Windows.Forms.Button()
        Me.btnColas = New System.Windows.Forms.Button()
        Me.btnPilas = New System.Windows.Forms.Button()
        Me.btnLiDC = New System.Windows.Forms.Button()
        Me.btnLiDE = New System.Windows.Forms.Button()
        Me.btnLiC = New System.Windows.Forms.Button()
        Me.btnLiS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(253, -82)
        Me.label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(284, 25)
        Me.label1.TabIndex = 17
        Me.label1.Text = "SELECCIONA UNA OPCION: "
        '
        'BtnGrafos
        '
        Me.BtnGrafos.Location = New System.Drawing.Point(490, 465)
        Me.BtnGrafos.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnGrafos.Name = "BtnGrafos"
        Me.BtnGrafos.Size = New System.Drawing.Size(193, 124)
        Me.BtnGrafos.TabIndex = 16
        Me.BtnGrafos.Text = "Grafos "
        Me.BtnGrafos.UseVisualStyleBackColor = True
        '
        'btnArboles
        '
        Me.btnArboles.Location = New System.Drawing.Point(490, 331)
        Me.btnArboles.Margin = New System.Windows.Forms.Padding(6)
        Me.btnArboles.Name = "btnArboles"
        Me.btnArboles.Size = New System.Drawing.Size(193, 124)
        Me.btnArboles.TabIndex = 15
        Me.btnArboles.Text = "Arboles"
        Me.btnArboles.UseVisualStyleBackColor = True
        '
        'btnColas
        '
        Me.btnColas.Location = New System.Drawing.Point(490, 196)
        Me.btnColas.Margin = New System.Windows.Forms.Padding(6)
        Me.btnColas.Name = "btnColas"
        Me.btnColas.Size = New System.Drawing.Size(193, 124)
        Me.btnColas.TabIndex = 14
        Me.btnColas.Text = "Colas"
        Me.btnColas.UseVisualStyleBackColor = True
        '
        'btnPilas
        '
        Me.btnPilas.Location = New System.Drawing.Point(490, 61)
        Me.btnPilas.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPilas.Name = "btnPilas"
        Me.btnPilas.Size = New System.Drawing.Size(193, 124)
        Me.btnPilas.TabIndex = 13
        Me.btnPilas.Text = "Pilas"
        Me.btnPilas.UseVisualStyleBackColor = True
        '
        'btnLiDC
        '
        Me.btnLiDC.Location = New System.Drawing.Point(118, 480)
        Me.btnLiDC.Margin = New System.Windows.Forms.Padding(6)
        Me.btnLiDC.Name = "btnLiDC"
        Me.btnLiDC.Size = New System.Drawing.Size(193, 124)
        Me.btnLiDC.TabIndex = 12
        Me.btnLiDC.Text = "Listas Dobles Circulares"
        Me.btnLiDC.UseVisualStyleBackColor = True
        '
        'btnLiDE
        '
        Me.btnLiDE.Location = New System.Drawing.Point(118, 345)
        Me.btnLiDE.Margin = New System.Windows.Forms.Padding(6)
        Me.btnLiDE.Name = "btnLiDE"
        Me.btnLiDE.Size = New System.Drawing.Size(193, 124)
        Me.btnLiDE.TabIndex = 11
        Me.btnLiDE.Text = "Listas Dobles Enlazadas"
        Me.btnLiDE.UseVisualStyleBackColor = True
        '
        'btnLiC
        '
        Me.btnLiC.Location = New System.Drawing.Point(118, 196)
        Me.btnLiC.Margin = New System.Windows.Forms.Padding(6)
        Me.btnLiC.Name = "btnLiC"
        Me.btnLiC.Size = New System.Drawing.Size(193, 124)
        Me.btnLiC.TabIndex = 10
        Me.btnLiC.Text = "Listas Circulares"
        Me.btnLiC.UseVisualStyleBackColor = True
        '
        'btnLiS
        '
        Me.btnLiS.Location = New System.Drawing.Point(118, 61)
        Me.btnLiS.Margin = New System.Windows.Forms.Padding(6)
        Me.btnLiS.Name = "btnLiS"
        Me.btnLiS.Size = New System.Drawing.Size(193, 124)
        Me.btnLiS.TabIndex = 9
        Me.btnLiS.Text = "Listas Simples"
        Me.btnLiS.UseVisualStyleBackColor = True
        '
        'EstructuraDeDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 625)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.BtnGrafos)
        Me.Controls.Add(Me.btnArboles)
        Me.Controls.Add(Me.btnColas)
        Me.Controls.Add(Me.btnPilas)
        Me.Controls.Add(Me.btnLiDC)
        Me.Controls.Add(Me.btnLiDE)
        Me.Controls.Add(Me.btnLiC)
        Me.Controls.Add(Me.btnLiS)
        Me.Name = "EstructuraDeDatos"
        Me.Text = "EstructuraDeDatos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents BtnGrafos As Button
    Private WithEvents btnArboles As Button
    Private WithEvents btnColas As Button
    Private WithEvents btnPilas As Button
    Private WithEvents btnLiDC As Button
    Private WithEvents btnLiDE As Button
    Private WithEvents btnLiC As Button
    Private WithEvents btnLiS As Button
End Class
