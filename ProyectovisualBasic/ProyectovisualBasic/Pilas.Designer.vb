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
        Me.label2.Location = New System.Drawing.Point(236, 207)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(153, 20)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Numeros Insertados"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(236, 62)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(124, 20)
        Me.label1.TabIndex = 16
        Me.label1.Text = "Insertar Numero"
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 20
        Me.listBox1.Location = New System.Drawing.Point(222, 245)
        Me.listBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(178, 144)
        Me.listBox1.TabIndex = 15
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(222, 105)
        Me.txtDato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(148, 26)
        Me.txtDato.TabIndex = 14
        '
        'btnPop
        '
        Me.btnPop.Location = New System.Drawing.Point(467, 145)
        Me.btnPop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(112, 35)
        Me.btnPop.TabIndex = 13
        Me.btnPop.Text = "Pop"
        Me.btnPop.UseVisualStyleBackColor = True
        '
        'btnPush
        '
        Me.btnPush.Location = New System.Drawing.Point(467, 101)
        Me.btnPush.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(112, 35)
        Me.btnPush.TabIndex = 12
        Me.btnPush.Text = "Push"
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'Pilas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
