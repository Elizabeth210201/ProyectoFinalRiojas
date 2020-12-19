<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetodosOrdenamiento
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
        Me.CHBQuickSort = New System.Windows.Forms.CheckBox()
        Me.CHBMonticulosMax = New System.Windows.Forms.CheckBox()
        Me.CHBMonticulosMin = New System.Windows.Forms.CheckBox()
        Me.CHBShellSort = New System.Windows.Forms.CheckBox()
        Me.CHBRadix = New System.Windows.Forms.CheckBox()
        Me.CHBArbolBinario = New System.Windows.Forms.CheckBox()
        Me.CHBMezclaNatural = New System.Windows.Forms.CheckBox()
        Me.CHBMezclaDirecta = New System.Windows.Forms.CheckBox()
        Me.CHBCuentas = New System.Windows.Forms.CheckBox()
        Me.CHBBucketSort = New System.Windows.Forms.CheckBox()
        Me.CHBInsercion = New System.Windows.Forms.CheckBox()
        Me.CHBBurbujaBid = New System.Windows.Forms.CheckBox()
        Me.CHBBurbuja = New System.Windows.Forms.CheckBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lstOrdenado = New System.Windows.Forms.ListBox()
        Me.lstDesordenado = New System.Windows.Forms.ListBox()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblTamaño = New System.Windows.Forms.Label()
        Me.txtTamaño = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CHBQuickSort
        '
        Me.CHBQuickSort.AutoSize = True
        Me.CHBQuickSort.Location = New System.Drawing.Point(757, 562)
        Me.CHBQuickSort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHBQuickSort.Name = "CHBQuickSort"
        Me.CHBQuickSort.Size = New System.Drawing.Size(133, 24)
        Me.CHBQuickSort.TabIndex = 59
        Me.CHBQuickSort.Text = "QUICK SORT"
        Me.CHBQuickSort.UseVisualStyleBackColor = True
        '
        'CHBMonticulosMax
        '
        Me.CHBMonticulosMax.AutoSize = True
        Me.CHBMonticulosMax.Location = New System.Drawing.Point(793, 526)
        Me.CHBMonticulosMax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHBMonticulosMax.Name = "CHBMonticulosMax"
        Me.CHBMonticulosMax.Size = New System.Drawing.Size(209, 24)
        Me.CHBMonticulosMax.TabIndex = 58
        Me.CHBMonticulosMax.Text = "MONTICULOS MAXIMO"
        Me.CHBMonticulosMax.UseVisualStyleBackColor = True
        '
        'CHBMonticulosMin
        '
        Me.CHBMonticulosMin.AutoSize = True
        Me.CHBMonticulosMin.Location = New System.Drawing.Point(758, 491)
        Me.CHBMonticulosMin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHBMonticulosMin.Name = "CHBMonticulosMin"
        Me.CHBMonticulosMin.Size = New System.Drawing.Size(203, 24)
        Me.CHBMonticulosMin.TabIndex = 57
        Me.CHBMonticulosMin.Text = "MONTICULOS MINIMO"
        Me.CHBMonticulosMin.UseVisualStyleBackColor = True
        '
        'CHBShellSort
        '
        Me.CHBShellSort.AutoSize = True
        Me.CHBShellSort.Location = New System.Drawing.Point(758, 456)
        Me.CHBShellSort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHBShellSort.Name = "CHBShellSort"
        Me.CHBShellSort.Size = New System.Drawing.Size(135, 24)
        Me.CHBShellSort.TabIndex = 56
        Me.CHBShellSort.Text = "SHELL SORT"
        Me.CHBShellSort.UseVisualStyleBackColor = True
        '
        'CHBRadix
        '
        Me.CHBRadix.AutoSize = True
        Me.CHBRadix.Location = New System.Drawing.Point(758, 420)
        Me.CHBRadix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHBRadix.Name = "CHBRadix"
        Me.CHBRadix.Size = New System.Drawing.Size(134, 24)
        Me.CHBRadix.TabIndex = 55
        Me.CHBRadix.Text = "RADIX SORT"
        Me.CHBRadix.UseVisualStyleBackColor = True
        '
        'CHBArbolBinario
        '
        Me.CHBArbolBinario.AutoSize = True
        Me.CHBArbolBinario.Location = New System.Drawing.Point(758, 385)
        Me.CHBArbolBinario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHBArbolBinario.Name = "CHBArbolBinario"
        Me.CHBArbolBinario.Size = New System.Drawing.Size(161, 24)
        Me.CHBArbolBinario.TabIndex = 54
        Me.CHBArbolBinario.Text = "ARBOL BINARIO"
        Me.CHBArbolBinario.UseVisualStyleBackColor = True
        '
        'CHBMezclaNatural
        '
        Me.CHBMezclaNatural.AutoSize = True
        Me.CHBMezclaNatural.Location = New System.Drawing.Point(793, 349)
        Me.CHBMezclaNatural.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHBMezclaNatural.Name = "CHBMezclaNatural"
        Me.CHBMezclaNatural.Size = New System.Drawing.Size(179, 24)
        Me.CHBMezclaNatural.TabIndex = 53
        Me.CHBMezclaNatural.Text = "MEZCLA NATURAL"
        Me.CHBMezclaNatural.UseVisualStyleBackColor = True
        '
        'CHBMezclaDirecta
        '
        Me.CHBMezclaDirecta.AutoSize = True
        Me.CHBMezclaDirecta.Location = New System.Drawing.Point(758, 314)
        Me.CHBMezclaDirecta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHBMezclaDirecta.Name = "CHBMezclaDirecta"
        Me.CHBMezclaDirecta.Size = New System.Drawing.Size(175, 24)
        Me.CHBMezclaDirecta.TabIndex = 52
        Me.CHBMezclaDirecta.Text = "MEZCLA DIRECTA"
        Me.CHBMezclaDirecta.UseVisualStyleBackColor = True
        '
        'CHBCuentas
        '
        Me.CHBCuentas.AutoSize = True
        Me.CHBCuentas.Location = New System.Drawing.Point(758, 279)
        Me.CHBCuentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHBCuentas.Name = "CHBCuentas"
        Me.CHBCuentas.Size = New System.Drawing.Size(111, 24)
        Me.CHBCuentas.TabIndex = 51
        Me.CHBCuentas.Text = "CUENTAS"
        Me.CHBCuentas.UseVisualStyleBackColor = True
        '
        'CHBBucketSort
        '
        Me.CHBBucketSort.AutoSize = True
        Me.CHBBucketSort.Location = New System.Drawing.Point(758, 243)
        Me.CHBBucketSort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHBBucketSort.Name = "CHBBucketSort"
        Me.CHBBucketSort.Size = New System.Drawing.Size(147, 24)
        Me.CHBBucketSort.TabIndex = 50
        Me.CHBBucketSort.Text = "BUCKET SORT"
        Me.CHBBucketSort.UseVisualStyleBackColor = True
        '
        'CHBInsercion
        '
        Me.CHBInsercion.AutoSize = True
        Me.CHBInsercion.Location = New System.Drawing.Point(758, 208)
        Me.CHBInsercion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHBInsercion.Name = "CHBInsercion"
        Me.CHBInsercion.Size = New System.Drawing.Size(124, 24)
        Me.CHBInsercion.TabIndex = 49
        Me.CHBInsercion.Text = "INSERCION"
        Me.CHBInsercion.UseVisualStyleBackColor = True
        '
        'CHBBurbujaBid
        '
        Me.CHBBurbujaBid.AutoSize = True
        Me.CHBBurbujaBid.Location = New System.Drawing.Point(793, 173)
        Me.CHBBurbujaBid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHBBurbujaBid.Name = "CHBBurbujaBid"
        Me.CHBBurbujaBid.Size = New System.Drawing.Size(242, 24)
        Me.CHBBurbujaBid.TabIndex = 48
        Me.CHBBurbujaBid.Text = "BURBUJA BIDIRECCIONAL"
        Me.CHBBurbujaBid.UseVisualStyleBackColor = True
        '
        'CHBBurbuja
        '
        Me.CHBBurbuja.AutoSize = True
        Me.CHBBurbuja.Location = New System.Drawing.Point(758, 137)
        Me.CHBBurbuja.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHBBurbuja.Name = "CHBBurbuja"
        Me.CHBBurbuja.Size = New System.Drawing.Size(112, 24)
        Me.CHBBurbuja.TabIndex = 47
        Me.CHBBurbuja.Text = "BURBUJA"
        Me.CHBBurbuja.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(147, 648)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(0, 20)
        Me.label5.TabIndex = 46
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(530, 617)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(0, 20)
        Me.label4.TabIndex = 45
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(530, 583)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(0, 20)
        Me.label3.TabIndex = 44
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(146, 617)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(0, 20)
        Me.label2.TabIndex = 43
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(147, 583)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(0, 20)
        Me.label1.TabIndex = 42
        '
        'lstOrdenado
        '
        Me.lstOrdenado.FormattingEnabled = True
        Me.lstOrdenado.ItemHeight = 20
        Me.lstOrdenado.Location = New System.Drawing.Point(421, 246)
        Me.lstOrdenado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstOrdenado.Name = "lstOrdenado"
        Me.lstOrdenado.Size = New System.Drawing.Size(164, 364)
        Me.lstOrdenado.TabIndex = 41
        '
        'lstDesordenado
        '
        Me.lstDesordenado.FormattingEnabled = True
        Me.lstDesordenado.ItemHeight = 20
        Me.lstDesordenado.Location = New System.Drawing.Point(113, 246)
        Me.lstDesordenado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstDesordenado.Name = "lstDesordenado"
        Me.lstDesordenado.Size = New System.Drawing.Size(164, 364)
        Me.lstDesordenado.TabIndex = 40
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Location = New System.Drawing.Point(609, 154)
        Me.btnOrdenar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(112, 35)
        Me.btnOrdenar.TabIndex = 39
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(609, 99)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(84, 32)
        Me.btnOk.TabIndex = 38
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblTamaño
        '
        Me.lblTamaño.AutoSize = True
        Me.lblTamaño.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTamaño.Location = New System.Drawing.Point(51, 100)
        Me.lblTamaño.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTamaño.Name = "lblTamaño"
        Me.lblTamaño.Size = New System.Drawing.Size(306, 45)
        Me.lblTamaño.TabIndex = 37
        Me.lblTamaño.Text = "Tamaño del vector:"
        '
        'txtTamaño
        '
        Me.txtTamaño.Location = New System.Drawing.Point(357, 100)
        Me.txtTamaño.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTamaño.Name = "txtTamaño"
        Me.txtTamaño.Size = New System.Drawing.Size(228, 26)
        Me.txtTamaño.TabIndex = 36
        '
        'MetodosOrdenamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 766)
        Me.Controls.Add(Me.CHBQuickSort)
        Me.Controls.Add(Me.CHBMonticulosMax)
        Me.Controls.Add(Me.CHBMonticulosMin)
        Me.Controls.Add(Me.CHBShellSort)
        Me.Controls.Add(Me.CHBRadix)
        Me.Controls.Add(Me.CHBArbolBinario)
        Me.Controls.Add(Me.CHBMezclaNatural)
        Me.Controls.Add(Me.CHBMezclaDirecta)
        Me.Controls.Add(Me.CHBCuentas)
        Me.Controls.Add(Me.CHBBucketSort)
        Me.Controls.Add(Me.CHBInsercion)
        Me.Controls.Add(Me.CHBBurbujaBid)
        Me.Controls.Add(Me.CHBBurbuja)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lstOrdenado)
        Me.Controls.Add(Me.lstDesordenado)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblTamaño)
        Me.Controls.Add(Me.txtTamaño)
        Me.Name = "MetodosOrdenamiento"
        Me.Text = "MetodosOrdenamiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents CHBQuickSort As CheckBox
    Private WithEvents CHBMonticulosMax As CheckBox
    Private WithEvents CHBMonticulosMin As CheckBox
    Private WithEvents CHBShellSort As CheckBox
    Private WithEvents CHBRadix As CheckBox
    Private WithEvents CHBArbolBinario As CheckBox
    Private WithEvents CHBMezclaNatural As CheckBox
    Private WithEvents CHBMezclaDirecta As CheckBox
    Private WithEvents CHBCuentas As CheckBox
    Private WithEvents CHBBucketSort As CheckBox
    Private WithEvents CHBInsercion As CheckBox
    Private WithEvents CHBBurbujaBid As CheckBox
    Private WithEvents CHBBurbuja As CheckBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents lstOrdenado As ListBox
    Private WithEvents lstDesordenado As ListBox
    Private WithEvents btnOrdenar As Button
    Private WithEvents btnOk As Button
    Private WithEvents lblTamaño As Label
    Private WithEvents txtTamaño As TextBox
End Class
