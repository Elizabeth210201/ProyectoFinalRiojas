<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetodosDeOrdenamiento
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
        Me.CHBQuickSort.Location = New System.Drawing.Point(858, 630)
        Me.CHBQuickSort.Margin = New System.Windows.Forms.Padding(6)
        Me.CHBQuickSort.Name = "CHBQuickSort"
        Me.CHBQuickSort.Size = New System.Drawing.Size(163, 29)
        Me.CHBQuickSort.TabIndex = 54
        Me.CHBQuickSort.Text = "QUICK SORT"
        Me.CHBQuickSort.UseVisualStyleBackColor = True
        '
        'CHBMonticulosMax
        '
        Me.CHBMonticulosMax.AutoSize = True
        Me.CHBMonticulosMax.Location = New System.Drawing.Point(902, 587)
        Me.CHBMonticulosMax.Margin = New System.Windows.Forms.Padding(6)
        Me.CHBMonticulosMax.Name = "CHBMonticulosMax"
        Me.CHBMonticulosMax.Size = New System.Drawing.Size(261, 29)
        Me.CHBMonticulosMax.TabIndex = 53
        Me.CHBMonticulosMax.Text = "MONTICULOS MAXIMO"
        Me.CHBMonticulosMax.UseVisualStyleBackColor = True
        '
        'CHBMonticulosMin
        '
        Me.CHBMonticulosMin.AutoSize = True
        Me.CHBMonticulosMin.Location = New System.Drawing.Point(860, 545)
        Me.CHBMonticulosMin.Margin = New System.Windows.Forms.Padding(6)
        Me.CHBMonticulosMin.Name = "CHBMonticulosMin"
        Me.CHBMonticulosMin.Size = New System.Drawing.Size(252, 29)
        Me.CHBMonticulosMin.TabIndex = 52
        Me.CHBMonticulosMin.Text = "MONTICULOS MINIMO"
        Me.CHBMonticulosMin.UseVisualStyleBackColor = True
        '
        'CHBShellSort
        '
        Me.CHBShellSort.AutoSize = True
        Me.CHBShellSort.Location = New System.Drawing.Point(860, 503)
        Me.CHBShellSort.Margin = New System.Windows.Forms.Padding(6)
        Me.CHBShellSort.Name = "CHBShellSort"
        Me.CHBShellSort.Size = New System.Drawing.Size(162, 29)
        Me.CHBShellSort.TabIndex = 51
        Me.CHBShellSort.Text = "SHELL SORT"
        Me.CHBShellSort.UseVisualStyleBackColor = True
        '
        'CHBRadix
        '
        Me.CHBRadix.AutoSize = True
        Me.CHBRadix.Location = New System.Drawing.Point(860, 460)
        Me.CHBRadix.Margin = New System.Windows.Forms.Padding(6)
        Me.CHBRadix.Name = "CHBRadix"
        Me.CHBRadix.Size = New System.Drawing.Size(159, 29)
        Me.CHBRadix.TabIndex = 50
        Me.CHBRadix.Text = "RADIX SORT"
        Me.CHBRadix.UseVisualStyleBackColor = True
        '
        'CHBArbolBinario
        '
        Me.CHBArbolBinario.AutoSize = True
        Me.CHBArbolBinario.Location = New System.Drawing.Point(860, 418)
        Me.CHBArbolBinario.Margin = New System.Windows.Forms.Padding(6)
        Me.CHBArbolBinario.Name = "CHBArbolBinario"
        Me.CHBArbolBinario.Size = New System.Drawing.Size(190, 29)
        Me.CHBArbolBinario.TabIndex = 49
        Me.CHBArbolBinario.Text = "ARBOL BINARIO"
        Me.CHBArbolBinario.UseVisualStyleBackColor = True
        '
        'CHBMezclaNatural
        '
        Me.CHBMezclaNatural.AutoSize = True
        Me.CHBMezclaNatural.Location = New System.Drawing.Point(902, 375)
        Me.CHBMezclaNatural.Margin = New System.Windows.Forms.Padding(6)
        Me.CHBMezclaNatural.Name = "CHBMezclaNatural"
        Me.CHBMezclaNatural.Size = New System.Drawing.Size(218, 29)
        Me.CHBMezclaNatural.TabIndex = 48
        Me.CHBMezclaNatural.Text = "MEZCLA NATURAL"
        Me.CHBMezclaNatural.UseVisualStyleBackColor = True
        '
        'CHBMezclaDirecta
        '
        Me.CHBMezclaDirecta.AutoSize = True
        Me.CHBMezclaDirecta.Location = New System.Drawing.Point(860, 333)
        Me.CHBMezclaDirecta.Margin = New System.Windows.Forms.Padding(6)
        Me.CHBMezclaDirecta.Name = "CHBMezclaDirecta"
        Me.CHBMezclaDirecta.Size = New System.Drawing.Size(212, 29)
        Me.CHBMezclaDirecta.TabIndex = 47
        Me.CHBMezclaDirecta.Text = "MEZCLA DIRECTA"
        Me.CHBMezclaDirecta.UseVisualStyleBackColor = True
        '
        'CHBCuentas
        '
        Me.CHBCuentas.AutoSize = True
        Me.CHBCuentas.Location = New System.Drawing.Point(860, 290)
        Me.CHBCuentas.Margin = New System.Windows.Forms.Padding(6)
        Me.CHBCuentas.Name = "CHBCuentas"
        Me.CHBCuentas.Size = New System.Drawing.Size(135, 29)
        Me.CHBCuentas.TabIndex = 46
        Me.CHBCuentas.Text = "CUENTAS"
        Me.CHBCuentas.UseVisualStyleBackColor = True
        '
        'CHBBucketSort
        '
        Me.CHBBucketSort.AutoSize = True
        Me.CHBBucketSort.Location = New System.Drawing.Point(860, 248)
        Me.CHBBucketSort.Margin = New System.Windows.Forms.Padding(6)
        Me.CHBBucketSort.Name = "CHBBucketSort"
        Me.CHBBucketSort.Size = New System.Drawing.Size(181, 29)
        Me.CHBBucketSort.TabIndex = 45
        Me.CHBBucketSort.Text = "BUCKET SORT"
        Me.CHBBucketSort.UseVisualStyleBackColor = True
        '
        'CHBInsercion
        '
        Me.CHBInsercion.AutoSize = True
        Me.CHBInsercion.Location = New System.Drawing.Point(860, 205)
        Me.CHBInsercion.Margin = New System.Windows.Forms.Padding(6)
        Me.CHBInsercion.Name = "CHBInsercion"
        Me.CHBInsercion.Size = New System.Drawing.Size(147, 29)
        Me.CHBInsercion.TabIndex = 44
        Me.CHBInsercion.Text = "INSERCION"
        Me.CHBInsercion.UseVisualStyleBackColor = True
        '
        'CHBBurbujaBid
        '
        Me.CHBBurbujaBid.AutoSize = True
        Me.CHBBurbujaBid.Location = New System.Drawing.Point(902, 163)
        Me.CHBBurbujaBid.Margin = New System.Windows.Forms.Padding(6)
        Me.CHBBurbujaBid.Name = "CHBBurbujaBid"
        Me.CHBBurbujaBid.Size = New System.Drawing.Size(288, 29)
        Me.CHBBurbujaBid.TabIndex = 43
        Me.CHBBurbujaBid.Text = "BURBUJA BIDIRECCIONAL"
        Me.CHBBurbujaBid.UseVisualStyleBackColor = True
        '
        'CHBBurbuja
        '
        Me.CHBBurbuja.AutoSize = True
        Me.CHBBurbuja.Location = New System.Drawing.Point(860, 120)
        Me.CHBBurbuja.Margin = New System.Windows.Forms.Padding(6)
        Me.CHBBurbuja.Name = "CHBBurbuja"
        Me.CHBBurbuja.Size = New System.Drawing.Size(130, 29)
        Me.CHBBurbuja.TabIndex = 42
        Me.CHBBurbuja.Text = "BURBUJA"
        Me.CHBBurbuja.UseVisualStyleBackColor = True
        '
        'lstOrdenado
        '
        Me.lstOrdenado.FormattingEnabled = True
        Me.lstOrdenado.ItemHeight = 24
        Me.lstOrdenado.Location = New System.Drawing.Point(447, 251)
        Me.lstOrdenado.Margin = New System.Windows.Forms.Padding(6)
        Me.lstOrdenado.Name = "lstOrdenado"
        Me.lstOrdenado.Size = New System.Drawing.Size(200, 436)
        Me.lstOrdenado.TabIndex = 41
        '
        'lstDesordenado
        '
        Me.lstDesordenado.FormattingEnabled = True
        Me.lstDesordenado.ItemHeight = 24
        Me.lstDesordenado.Location = New System.Drawing.Point(71, 251)
        Me.lstDesordenado.Margin = New System.Windows.Forms.Padding(6)
        Me.lstDesordenado.Name = "lstDesordenado"
        Me.lstDesordenado.Size = New System.Drawing.Size(200, 436)
        Me.lstDesordenado.TabIndex = 40
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Location = New System.Drawing.Point(678, 141)
        Me.btnOrdenar.Margin = New System.Windows.Forms.Padding(6)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(138, 42)
        Me.btnOrdenar.TabIndex = 39
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(678, 74)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(6)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(103, 39)
        Me.btnOk.TabIndex = 38
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblTamaño
        '
        Me.lblTamaño.AutoSize = True
        Me.lblTamaño.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTamaño.Location = New System.Drawing.Point(-4, 76)
        Me.lblTamaño.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTamaño.Name = "lblTamaño"
        Me.lblTamaño.Size = New System.Drawing.Size(348, 52)
        Me.lblTamaño.TabIndex = 37
        Me.lblTamaño.Text = "Tamaño del vector:"
        '
        'txtTamaño
        '
        Me.txtTamaño.Location = New System.Drawing.Point(370, 76)
        Me.txtTamaño.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTamaño.Name = "txtTamaño"
        Me.txtTamaño.Size = New System.Drawing.Size(277, 29)
        Me.txtTamaño.TabIndex = 36
        '
        'MetodosDeOrdenamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 760)
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
        Me.Controls.Add(Me.lstOrdenado)
        Me.Controls.Add(Me.lstDesordenado)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblTamaño)
        Me.Controls.Add(Me.txtTamaño)
        Me.Name = "MetodosDeOrdenamiento"
        Me.Text = "MetodosDeOrdenamiento"
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
    Private WithEvents lstOrdenado As ListBox
    Private WithEvents lstDesordenado As ListBox
    Private WithEvents btnOrdenar As Button
    Private WithEvents btnOk As Button
    Private WithEvents lblTamaño As Label
    Private WithEvents txtTamaño As TextBox
End Class
