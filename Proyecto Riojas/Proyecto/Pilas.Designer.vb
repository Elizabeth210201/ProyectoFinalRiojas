<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pilas
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
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.txtDato = New System.Windows.Forms.TextBox()
        Me.btnPop = New System.Windows.Forms.Button()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(203, 265)
        Me.label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(187, 25)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Numeros Insertados"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(203, 91)
        Me.label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(151, 25)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Insertar Numero"
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 24
        Me.listBox1.Location = New System.Drawing.Point(186, 311)
        Me.listBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(217, 172)
        Me.listBox1.TabIndex = 15
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(186, 143)
        Me.txtDato.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(180, 29)
        Me.txtDato.TabIndex = 14
        '
        'btnPop
        '
        Me.btnPop.Location = New System.Drawing.Point(485, 191)
        Me.btnPop.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(138, 42)
        Me.btnPop.TabIndex = 13
        Me.btnPop.Text = "Pop"
        Me.btnPop.UseVisualStyleBackColor = True
        '
        'btnPush
        '
        Me.btnPush.Location = New System.Drawing.Point(485, 138)
        Me.btnPush.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(138, 42)
        Me.btnPush.TabIndex = 12
        Me.btnPush.Text = "Push"
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'Pilas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 574)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.txtDato)
        Me.Controls.Add(Me.btnPop)
        Me.Controls.Add(Me.btnPush)
        Me.Name = "Pilas"
        Me.Text = "Pilas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents listBox1 As ListBox
    Private WithEvents txtDato As TextBox
    Private WithEvents btnPop As Button
    Private WithEvents btnPush As Button
End Class
