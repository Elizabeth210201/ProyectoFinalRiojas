Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Proyecto_Final1

    Public Class MetodosOrdenamiento
        Inherits Form

        Private ord As Ordenar

        Private vector() As Integer

        Private a As Integer

        Private r As Random

        Private fusion As Integer

        Private pasadas As Integer

        Private intercambios As Integer

        Private Shared cuentas As Integer

        Private Shared recorridos As Integer

        Public Sub New()
            MyBase.New
            InitializeComponent
            cuentas = 0

            recorridos = 0
            Me.ord = New Ordenar
        End Sub

        Private Sub btnOrdenar_Click(ByVal sender As Object, ByVal e As EventArgs)
            lstOrdenado.Items.Clear
            label4.Text = ""
            label5.Text = ""
            label2.Text = ""
            label3.Text = ""
            If (CHBBurbuja.Checked = True) Then
                Dim fi As DateTime = DateTime.Now
                Me.vector = MetodosOrdenamiento.ordenamientoCuentas(Me.vector)
                Dim i As Integer = 0
                Do While (i < Me.vector.Length)
                    lstOrdenado.Items.Add(Me.vector(i))
                    i = (i + 1)
                Loop

                Dim ff As DateTime = DateTime.Now
                label1.Text = ("Tiempo: " _
                            + (ff - fi))
                label2.Text = ("Cuentas: " + cuentas)
                label5.Text = ("Recorridos: " + recorridos)
            End If

            If (CHBBurbujaBid.Checked = True) Then
                Dim fi As DateTime = DateTime.Now
                Me.OrdBubujaBidireccional(Me.vector)
                Dim i As Integer = 0
                Do While (i < Me.vector.Length)
                    lstOrdenado.Items.Add(Me.vector(i))
                    i = (i + 1)
                Loop

                Dim ff As DateTime = DateTime.Now
                label1.Text = ("Tiempo: " _
                            + (ff - fi))
                label5.Text = ("Intercambios: " + Me.intercambios)
                label2.Text = ("Pasadas: " + Me.pasadas)
            End If

            If (CHBInsercion.Checked = True) Then
                Dim fi As DateTime = DateTime.Now
                Me.InsercionDirecta(Me.vector)
                Dim i As Integer = 0
                Do While (i < Me.vector.Length)
                    lstOrdenado.Items.Add(Me.vector(i))
                    i = (i + 1)
                Loop

                Dim ff As DateTime = DateTime.Now
                label1.Text = ("Tiempo: " _
                            + (ff - fi))
                label5.Text = ("Intercambios: " + Me.intercambios)
                label2.Text = ("Pasadas: " + Me.pasadas)
            End If

            If (CHBBucketSort.Checked = True) Then
                Dim fi As DateTime = DateTime.Now
                Dim N As Integer
                N = Integer.Parse(txtTama, o.Text)
                Me.bucketsort(Me.vector, N)
                Dim i As Integer = 0
                Do While (i < Me.vector.Length)
                    lstOrdenado.Items.Add(Me.vector(i))
                    i = (i + 1)
                Loop

                Dim ff As DateTime = DateTime.Now
                label1.Text = ("Tiempo: " _
                            + (ff - fi))
                label2.Text = ("Pasadas: " + Me.pasadas)
            End If

            If (CHBCuentas.Checked = True) Then
                Dim fi As DateTime = DateTime.Now
                Me.vector = MetodosOrdenamiento.ordenamientoCuentas(Me.vector)
                Dim i As Integer = 0
                Do While (i < Me.vector.Length)
                    lstOrdenado.Items.Add(Me.vector(i))
                    i = (i + 1)
                Loop

                Dim ff As DateTime = DateTime.Now
                label1.Text = ("Tiempo: " _
                            + (ff - fi))
                label2.Text = ("Cuentas: " + cuentas)
                label5.Text = ("Recorridos: " + recorridos)
            End If

            If (CHBMezclaDirecta.Checked = True) Then
                Dim fi As DateTime = DateTime.Now
                Me.mezclaDirecta(Me.vector)
                Dim i As Integer = 0
                Do While (i < Me.vector.Length)
                    lstOrdenado.Items.Add(Me.vector(i))
                    i = (i + 1)
                Loop

                Dim ff As DateTime = DateTime.Now
                label1.Text = ("Tiempo: " _
                            + (ff - fi))
                label2.Text = ("Fusiones: " + Me.fusion)
            End If

            If (CHBMezclaNatural.Checked = True) Then
                Dim fi As DateTime = DateTime.Now
                Me.mezclaNatural(Me.vector)
                Dim i As Integer = 0
                Do While (i < Me.vector.Length)
                    lstOrdenado.Items.Add(Me.vector(i))
                    i = (i + 1)
                Loop

                Dim ff As DateTime = DateTime.Now
                label1.Text = ("Tiempo: " _
                            + (ff - fi))
                label2.Text = ("Fusiones: " + Me.a)
            End If

            If (CHBArbolBinario.Checked = True) Then
                Dim time As DateTime = DateTime.Now
                label1.Text = (Me.ord.InOrden + " ")
                Dim datos() As String = label1.Text.Split(Microsoft.VisualBasic.ChrW(32))
                Dim i As Integer = 0
                Do While (i < datos.Length)
                    lstOrdenado.Items.Add(datos(i))
                    i = (i + 1)
                Loop

                label1.Text = " "
                Dim time2 As DateTime = DateTime.Now
                Dim total As TimeSpan = New TimeSpan((time2.Ticks - time.Ticks))
                label1.Text = ("Tiempo: " + total.ToString)
            End If

            If (CHBRadix.Checked = True) Then
                Dim fi As DateTime = DateTime.Now
                Me.Radix(Me.vector)
                Dim ff As DateTime = DateTime.Now
                label1.Text = ("Tiempo: " _
                            + (ff - fi))
            End If

            If (CHBShellSort.Checked = True) Then
                Dim fi As DateTime = DateTime.Now
                Me.ShellSort(Me.vector, True)
                Dim i As Integer = 0
                Do While (i < Me.vector.Length)
                    lstOrdenado.Items.Add(Me.vector(i))
                    i = (i + 1)
                Loop

                Dim ff As DateTime = DateTime.Now
                label1.Text = ("Tiempo: " _
                            + (ff - fi))
                label5.Text = ("Intercambios: " + Me.intercambios)
                label2.Text = ("Pasadas: " + Me.pasadas)
            End If

            If (CHBMonticulosMin.Checked = True) Then
                Dim fi As DateTime = DateTime.Now
                Dim min As Ordenar = New Ordenar
                min.HeapSortMinimo(Me.vector)
                Dim m As Integer = 0
                Do While (m < Me.vector.Length)
                    lstOrdenado.Items.Add(Me.vector(m))
                    m = (m + 1)
                Loop

                Dim ff As DateTime = DateTime.Now
                label1.Text = ("Tiempo: " _
                            + (ff - fi))
            End If

            If (CHBMonticulosMax.Checked = True) Then
                Dim f1 As DateTime = DateTime.Now
                Dim max As Ordenar = New Ordenar
                max.HeapSortAscending(Me.vector)
                Dim j As Integer = 0
                Do While (j < Me.vector.Length)
                    lstOrdenado.Items.Add(Me.vector(j))
                    j = (j + 1)
                Loop

                Dim f2 As DateTime = DateTime.Now
                label1.Text = ("Tiempo: " _
                            + (f2 - f1))
            End If

            If (CHBQuickSort.Checked = True) Then
                Dim fi As DateTime = DateTime.Now
                MetodosOrdenamiento.Quicksort(Me.vector, 0, (Me.vector.Length - 1))
                Dim i As Integer = 0
                Do While (i < Me.vector.Length)
                    lstOrdenado.Items.Add(Me.vector(i))
                    i = (i + 1)
                Loop

                Dim ff As DateTime = DateTime.Now
                label1.Text = ("Tiempo: " _
                            + (ff - fi))
                label5.Text = ("Intercambios: " + Me.intercambios)
                label2.Text = ("Pasadas: " + Me.pasadas)
            End If

        End Sub

        Private Sub bucketsort(ByVal vector() As Integer, ByVal N As Integer)
            Dim Ti As DateTime = DateTime.Now
            Me.pasadas = 0
            If (N <= 0) Then
                Return
            End If

            ' el Array esta vacio
            Dim min As Integer = Me.vector(0)
            Dim max As Integer = min
            Dim r As Integer = 1
            Do While (Me.r < N)
                If (Me.vector(Me.r) > max) Then
                    max = Me.vector(Me.r)
                ElseIf (Me.vector(Me.r) < min) Then
                    min = Me.vector(Me.r)
                End If

                Me.r = (Me.r + 1)
            Loop

            Dim bucket() As Integer = New Integer((((max _
                        - (min / 5)) _
                        + 1)) - 1) {}
            ' Crear casilleros
            Me.pasadas = ((max _
                        - (min / 5)) _
                        + 1)
            Dim u As Integer = 0
            Do While (u < N)
                bucket((Me.vector(u) - min)) = (bucket((Me.vector(u) - min)) + 1)
                u = (u + 1)
            Loop

            'contando cada dato
            Dim i As Integer = 0
            Dim b As Integer = 0
            Do While (b < bucket.Length)
                Dim j As Integer = 0
                Do While (j < bucket(b))
                    Me.vector(i + +) = (b + min)
                    j = (j + 1)
                Loop

                b = (b + 1)
            Loop

            Dim Tf As DateTime = DateTime.Now
            label1.Text = ((Ti - Tf) _
                        + "Tiempo: ")
        End Sub

        Public Shared Function ordenamientoCuentas(ByVal vector() As Integer) As Integer()
            Dim vectorOrdenado() As Integer = New Integer((Me.vector.Length) - 1) {}
            ' arreglo ordenado = metodo
            ' encontrar mayor y menor
            Dim valorMinimo As Integer = Me.vector(0)
            Dim valorMaximo As Integer = Me.vector(0)
            Dim i As Integer = 1
            Do While (i < Me.vector.Length)
                If (Me.vector(i) < valorMinimo) Then
                    valorMinimo = Me.vector(i)
                End If

                'recorrer para encontrar el menor
                If (Me.vector(i) > valorMaximo) Then
                    valorMaximo = Me.vector(i)
                End If

                'recorrer para encontrar el mayor
                i = (i + 1)
            Loop

            ' iniciar arreglo de frecuencias
            Dim vectorAuxiliar() As Integer = New Integer((((valorMaximo - valorMinimo) _
                        + 1)) - 1) {}
            'arreglo de auxiliar de frecuencias
            ' iniciar las frecuencias
            Dim i As Integer = 0
            Do While (i < Me.vector.Length)
                vectorAuxiliar((Me.vector(i) - valorMinimo)) = (vectorAuxiliar((Me.vector(i) - valorMinimo)) + 1)
                cuentas = (cuentas + 1)
                i = (i + 1)
            Loop

            ' recalcular
            vectorAuxiliar(0) = (vectorAuxiliar(0) - 1)
            Dim i As Integer = 1
            Do While (i < vectorAuxiliar.Length)
                vectorAuxiliar(i) = (vectorAuxiliar(i) + vectorAuxiliar((i - 1)))
                recorridos = (recorridos + 1)
                i = (i + 1)
            Loop

            ' Acomodar el Arreglo
            Dim i As Integer = (Me.vector.Length - 1)
            Do While (i >= 0)
                vectorOrdenado(vectorAuxiliar[vector[iUnknown-valorMinimoUnknown--) = Me.vector(i)
                i = (i - 1)
            Loop

            Return vectorOrdenado
        End Function

        Public Function ShellSort(ByVal array() As Int32, ByVal tipo As Boolean) As String
            Dim a As String = ""
            Dim salto As Integer = 0
            Dim sw As Integer = 0
            Dim auxi As Integer = 0
            Dim e As Integer = 0
            Dim izq As Integer = 0
            Dim der As Integer = 0
            der = (array.Length - 1)
            salto = (array.Length / 2)
            Me.pasadas = 0
            Me.intercambios = 0
            Dim fi As DateTime = DateTime.Now

            Do Until (izq < der)
                Me.pasadas = (Me.pasadas + 1)
                Dim i As Integer = izq
                Do While (i < der)
                    If (array(i) > array((i + 1))) Then
                        Me.intercambios = (Me.intercambios + 1)
                        auxi = array(i)
                        array(i) = array((i + 1))
                        array((i + 1)) = auxi
                    End If

                    i = (i + 1)
                Loop

                izq = (izq + 1)
                der = (der - 1)

            Loop

            Dim ff As DateTime = DateTime.Now
            label1.Text = ("Tiempo: " _
                        + (ff - fi))

            While (salto > 0)
                sw = 1

                While (sw <> 0)
                    sw = 0
                    e = 1
                    If (tipo = True) Then

                        While (e _
                                    <= (array.Length - salto))
                            If (array((e - 1)) > array(((e - 1) _
                                        + salto))) Then
                                auxi = array(((e - 1) _
                                            + salto))
                                array(((e - 1) _
                                            + salto)) = array((e - 1))
                                array((e - 1)) = auxi
                                sw = 1
                                Me.intercambios = (Me.intercambios + 1)
                            End If

                            e = (e + 1)

                        End While

                    Else

                        While (e _
                                    <= (array.Length - salto))
                            If (array((e - 1)) < array(((e - 1) _
                                        + salto))) Then
                                auxi = array(((e - 1) _
                                            + salto))
                                array(((e - 1) _
                                            + salto)) = array((e - 1))
                                array((e - 1)) = auxi
                                sw = 1
                                Me.intercambios = (Me.intercambios + 1)
                            End If

                            e = (e + 1)

                        End While

                    End If

                    salto = (salto / 2)
                    Me.pasadas = (Me.pasadas + 1)

                End While


            End While

            Dim i As Integer = 0
            Do While (i < Me.vector.Length)
                Me.a = (Me.a _
                            + (Me.vector(i) + Environment.NewLine))
                i = (i + 1)
            Loop

            Return Me.a
        End Function

        Private Sub OrdenamientoBurbuja(ByVal vector() As Integer)
            Dim aux As Integer = 0
            Me.pasadas = 0
            Me.intercambios = 0
            Dim i As Integer = 0
            Do While (i < Me.vector.Length)
                Me.vector(i) = Convert.ToInt32(lstDesordenado.Items(i).ToString)
                i = (i + 1)
            Loop

            Dim x As Integer = 0
            Dim i As Integer = 1
            Do While (i < Me.vector.Length)
                x = 0
                Dim j As Integer = 0
                Do While (j _
                            < (Me.vector.Length - 1))
                    If (Me.vector(j) > Me.vector((j + 1))) Then
                        x = (x + 1)
                        Me.intercambios = (Me.intercambios + 1)
                        aux = Me.vector(j)
                        Me.vector(j) = Me.vector((j + 1))
                        Me.vector((j + 1)) = aux
                    End If

                    j = (j + 1)
                Loop

                If (x = 0) Then
                    Return
                End If

                Me.pasadas = (Me.pasadas + 1)
                i = (i + 1)
            Loop

        End Sub

        Private Sub OrdBubujaBidireccional(ByVal vector() As Integer)
            Dim der As Integer = 0
            Dim izq As Integer = 0
            Dim aux As Integer = 0
            der = (Me.vector.Length - 1)
            Me.pasadas = 0
            Me.intercambios = 0
            Dim fi As DateTime = DateTime.Now
            Dim i As Integer = 0
            Do While (i < Me.vector.Length)
                Me.vector(i) = Convert.ToInt32(lstDesordenado.Items(i).ToString)
                i = (i + 1)
            Loop


            Do Until (izq < der)
                Me.pasadas = (Me.pasadas + 1)
                Dim i As Integer = izq
                Do While (i < der)
                    If (Me.vector(i) > Me.vector((i + 1))) Then
                        Me.intercambios = (Me.intercambios + 1)
                        aux = Me.vector(i)
                        Me.vector(i) = Me.vector((i + 1))
                        Me.vector((i + 1)) = aux
                    End If

                    i = (i + 1)
                Loop

                Dim j As Integer = der
                Do While (j > izq)
                    If (Me.vector(j) < Me.vector((j - 1))) Then
                        Me.intercambios = (Me.intercambios + 1)
                        aux = Me.vector(j)
                        Me.vector(j) = Me.vector((j - 1))
                        Me.vector((j - 1)) = aux
                    End If

                    j = (j - 1)
                Loop

                izq = (izq + 1)
                der = (der - 1)

            Loop

            Dim ff As DateTime = DateTime.Now
            label1.Text = ("Tiempo: " _
                        + (ff - fi))
        End Sub

        Public Shared Sub Quicksort(ByVal elements() As Integer, ByVal left As Integer, ByVal right As Integer)
            Dim i As Integer = left
            Dim j As Integer = right
            Dim pasadas As Integer = 0
            Dim intercambios As Integer = 0
            Dim pivot As Integer = elements(((left + right) _
                        / 2))

            While (i <= j)

                While (elements(i).CompareTo(pivot) < 0)
                    i = (i + 1)

                End While


                While (elements(j).CompareTo(pivot) > 0)
                    j = (j - 1)

                End While

                If (i <= j) Then
                    ' Swap
                    Dim tmp As Integer = elements(i)
                    elements(i) = elements(j)
                    elements(j) = tmp
                    i = (i + 1)
                    j = (j - 1)
                    Me.intercambios = (Me.intercambios + 1)
                End If

                Me.pasadas = (Me.pasadas + 1)

            End While

            ' Recursive calls
            If (left < j) Then
                MetodosOrdenamiento.Quicksort(elements, left, j)
            End If

            If (i < right) Then
                MetodosOrdenamiento.Quicksort(elements, i, right)
            End If

        End Sub

        Public Sub Radix(ByVal vector() As Integer)
            Me.pasadas = 0
            Dim t() As Integer = New Integer((Me.vector.Length) - 1) {}
            Dim r As Integer = 4
            Dim b As Integer = Me.vector.Length
            Dim count() As Integer = New Integer(((1 + Me.r)) - 1) {}
            Dim pref() As Integer = New Integer(((1 + Me.r)) - 1) {}
            Dim grupos As Integer = CType(Math.Ceiling((CType(b, Double) / CType(Me.r, Double))), Integer)
            Dim mask As Integer = ((1 + Me.r) _
                        - 1)
            Dim shift As Integer = 0
            Do While (c < grupos)
                c = (c + 1)
            Loop

            Dim c As Integer = 0
            shift = (shift + Me.r)
            Dim i As Integer = 0
            Do While (i < count.Length)
                count(i) = 0
                i = (i + 1)
            Loop

            Dim j As Integer = 0
            Do While (j < Me.vector.Length)
                count(((Me.vector(j) + shift) _
                            And mask)) = (count(((Me.vector(j) + shift) _
                            And mask)) + 1)
                j = (j + 1)
            Loop

            pref(0) = 0
            Dim i As Integer = 1
            Do While (i < count.Length)
                pref(i) = (pref((i - 1)) + count((i - 1)))
                i = (i + 1)
            Loop

            Dim i As Integer = 0
            Do While (i < Me.vector.Length)
                t(pref[(vector[iUnknown>>shiftUnknown&maskUnknown++) = Me.vector(i)
                i = (i + 1)
            Loop

            Me.pasadas = (Me.pasadas + 1)
            t.CopyTo(Me.vector, 0)
            Dim i As Integer = 0
            Do While (i < Me.vector.Length)
                lstOrdenado.Items.Add(Me.vector(i))
                i = (i + 1)
            Loop

            label2.Text = ("Pasadas:  " _
                        + (Me.pasadas + ""))
        End Sub

        Private Sub InsercionDirecta(ByVal vector() As Integer)
            Dim fi As DateTime = DateTime.Now
            Dim Aux As Integer = 0
            Dim j As Integer
            Dim i As Integer
            Me.pasadas = 0
            Me.intercambios = 0
            i = 0
            Do While (i < Me.vector.Length)
                Me.vector(i) = Convert.ToInt32(lstDesordenado.Items(i).ToString)
                i = (i + 1)
            Loop

            i = 1
            Do While (i _
                        <= (Me.vector.Length - 1))
                Aux = Me.vector(i)
                j = i

                While ((j > 0) _
                            AndAlso (Aux < Me.vector((j - 1))))
                    Me.intercambios = (Me.intercambios + 1)
                    Me.vector(j) = Me.vector(--j)

                End While

                Me.vector(j) = Aux
                Me.pasadas = (Me.pasadas + 1)
                i = (i + 1)
            Loop

            Dim ff As DateTime = DateTime.Now
            label1.Text = ("Tiempo: " _
                        + (ff - fi))
        End Sub

        Public Sub mezclaDirecta(ByVal arreglo() As Integer)
            Dim k As Integer
            Dim i As Integer
            Dim j As Integer
            'si hay que ordenar
            If (arreglo.Length > 1) Then
                'tama�o sub lista izquierda
                Dim nElementosIzq As Integer = (arreglo.Length / 2)
                'tama�o sub lista derecha
                Dim nElementosDer As Integer = (arreglo.Length - nElementosIzq)
                Dim arregloizq() As Integer
                arregloizq = New Integer((nElementosIzq) - 1) {}
                Dim arregloder() As Integer
                arregloder = New Integer((nElementosDer) - 1) {}
                'copiar elementos izq
                i = 0
                Do While (i < nElementosIzq)
                    arregloizq(i) = arreglo(i)
                    i = (i + 1)
                Loop

                'copiar elementos der
                i = nElementosIzq
                Do While (i _
                            < (nElementosIzq + nElementosDer))
                    arregloder((i - nElementosIzq)) = arreglo(i)
                    i = (i + 1)
                Loop

                'recursividad
                Me.mezclaDirecta(arregloizq)
                Me.mezclaDirecta(arregloder)
                i = 0
                j = 0
                k = 0

                While ((arregloizq.Length <> j) _
                            AndAlso (arregloder.Length <> k))
                    If (arregloizq(j) < arregloder(k)) Then
                        arreglo(i) = arregloizq(j)
                        i = (i + 1)
                        j = (j + 1)
                    Else
                        arreglo(i) = arregloder(k)
                        i = (i + 1)
                        k = (k + 1)
                    End If

                    Me.fusion = (Me.fusion + 1)

                End While


                While (arregloizq.Length <> j)
                    arreglo(i) = arregloizq(j)
                    i = (i + 1)
                    j = (j + 1)

                End While


                While (arregloder.Length <> k)
                    arreglo(i) = arregloder(k)
                    i = (i + 1)
                    k = (k + 1)

                End While

                Me.fusion = (Me.fusion + 1)
            End If

        End Sub

        Public Sub mezclaNatural(ByVal arreglo() As Integer)
            Dim der As Integer = derecha
            Dim izquierda As Integer = 0
            Dim izq As Integer = 0
            Dim derecha As Integer = (arreglo.Length - 1)
            Dim ordenado As Boolean = False

            Do Until Not ordenado
                ordenado = True
                izquierda = 0

                While (izquierda < derecha)
                    izq = izquierda

                    While ((izq < derecha) _
                                AndAlso (arreglo(izq) <= arreglo((izq + 1))))
                        izq = (izq + 1)

                    End While

                    der = (izq + 1)

                    While ((der _
                                = (derecha - 1)) _
                                OrElse ((der < derecha) _
                                AndAlso (arreglo(der) <= arreglo((der + 1)))))
                        der = (der + 1)

                    End While

                    Me.a = (Me.a + 1)
                    If (der <= derecha) Then
                        Me.mezclaDirecta2(arreglo)
                        ordenado = False
                        Me.a = (Me.a + 1)
                    End If

                    Me.a = (Me.a + 1)
                    izquierda = izq
                    Me.a = (Me.a + 1)

                End While

                Me.a = (Me.a + 1)

            Loop

        End Sub

        Public Sub mezclaDirecta2(ByVal arreglo() As Integer)
            Dim k As Integer
            Dim i As Integer
            Dim j As Integer
            If (arreglo.Length > 1) Then
                Dim nElementosIzq As Integer = (arreglo.Length / 2)
                Dim nElementosDer As Integer = (arreglo.Length - nElementosIzq)
                Dim arregloizq() As Integer
                arregloizq = New Integer((nElementosIzq) - 1) {}
                Dim arregloder() As Integer
                arregloder = New Integer((nElementosDer) - 1) {}
                'copiar elementos izq
                i = 0
                Do While (i < nElementosIzq)
                    arregloizq(i) = arreglo(i)
                    i = (i + 1)
                Loop

                'copiar elementos der
                i = nElementosIzq
                Do While (i _
                            < (nElementosIzq + nElementosDer))
                    arregloder((i - nElementosIzq)) = arreglo(i)
                    i = (i + 1)
                Loop

                'recursividad
                Me.mezclaDirecta(arregloizq)
                Me.mezclaDirecta(arregloder)
                i = 0
                j = 0
                k = 0

                While ((arregloizq.Length <> j) _
                            AndAlso (arregloder.Length <> k))
                    If (arregloizq(j) < arregloder(k)) Then
                        arreglo(i) = arregloizq(j)
                        i = (i + 1)
                        j = (j + 1)
                    Else
                        arreglo(i) = arregloder(k)
                        i = (i + 1)
                        k = (k + 1)
                    End If

                    Me.a = (Me.a + 1)

                End While

                'arreglo final

                While (arregloizq.Length <> j)
                    arreglo(i) = arregloizq(j)
                    i = (i + 1)
                    j = (j + 1)

                End While


                While (arregloder.Length <> k)
                    arreglo(i) = arregloder(k)
                    i = (i + 1)
                    k = (k + 1)

                End While

                Me.a = (Me.a + 1)
            End If

        End Sub

        Private Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.vector = New Integer((Integer.Parse(txtTama, o.Text)) - 1) {}
            Me.r = New Random
            Dim n As Nodo
            Dim i As Integer = 0
            Do While (i < Me.vector.Length)
                n = New Nodo
                n.derecho = Nothing
                n.izquierdo = Nothing
                Me.vector(i) = Me.r.Next(0, 1000)
                lstDesordenado.Items.Add(Me.vector(i))
                n.Dato = Me.vector(i)
                Me.ord.Insertar(n)
                i = (i + 1)
            Loop

            Dim o.Focus As txtTama
        End Sub
    End Class
End Namespace