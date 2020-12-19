Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_Final1

    Class Ordenar

        Private raiz As Nodo

        Private s As String

        'int cont = 0;
        Public Sub New()
            MyBase.New
            Me.raiz = Nothing
        End Sub

        Public Overloads Sub Insertar(ByVal n As Nodo)
            Me.Insertar(Me.raiz, n)
        End Sub

        Public Overloads Sub Insertar(ByRef raiz As Nodo, ByVal n As Nodo)
            If (Me.raiz Is Nothing) Then
                Me.raiz = n
                Return
            ElseIf (n.Dato < Me.raiz.Dato) Then
                Me.Insertar(Me.raiz.izquierdo, n)
            Else
                Me.Insertar(Me.raiz.derecho, n)
            End If

        End Sub

        Private Overloads Sub InOrden(ByVal r As Nodo)
            If (Not (r) Is Nothing) Then
                Me.InOrden(r.izquierdo)
                Me.s = (Me.s _
                            + (r.Dato + " "))
                Me.InOrden(r.derecho)
            End If

        End Sub

        Public Overloads Function InOrden() As String
            Me.s = " "
            Me.InOrden(Me.raiz)
            Return Me.s
        End Function

        '-----------------------Monticulos
        Public Sub HeapSortAscending(ByVal arr() As Integer)
            Dim heap_size As Integer = (arr.Length - 1)
            Dim i As Integer = (heap_size / 2)
            Do While (i >= 0)
                Me.MaxHepify(arr, heap_size, i)
                i = (i - 1)
            Loop

            Dim k As Integer = (arr.Length - 1)
            Do While (k >= 0)
                Dim tmpa As Integer = arr(k)
                arr(k) = arr(0)
                arr(0) = tmpa
                heap_size = (heap_size - 1)
                Me.MaxHepify(arr, heap_size, 0)
                k = (k - 1)
            Loop

        End Sub

        Public Sub MaxHepify(ByVal arr() As Integer, ByVal heapSize As Integer, ByVal index As Integer)
            Dim l As Integer = ((2 * index) _
                        + 1)
            Dim r As Integer = ((2 * index) _
                        + 2)
            Dim largest As Integer = index
            If ((l <= heapSize) _
                        AndAlso (arr(l) < arr(index))) Then
                largest = l
            Else
                largest = index
            End If

            If ((r <= heapSize) _
                        AndAlso (arr(r) < arr(largest))) Then
                largest = r
            End If

            If (largest <> index) Then
                Dim tmp As Integer = arr(index)
                arr(index) = arr(largest)
                arr(largest) = tmp
                Me.MaxHepify(arr, heapSize, largest)
            End If

        End Sub

        Public Sub HeapSortMinimo(ByVal input() As Integer)
            Dim heapSize As Integer = (input.Length - 1)
            'modificado
            Dim p As Integer = (heapSize / 2)
            Do While (p >= 0)
                Me.MinHeapify(input, heapSize, p)
                p = (p - 1)
            Loop

            Dim i As Integer = (input.Length - 1)
            Do While (i >= 0)
                Dim temp As Integer = input(i)
                input(i) = input(0)
                input(0) = temp
                heapSize = (heapSize - 1)
                Me.MinHeapify(input, heapSize, 0)
                i = (i - 1)
            Loop

        End Sub

        Public Sub MinHeapify(ByVal input() As Integer, ByVal heapSize As Integer, ByVal index As Integer)
            Dim left As Integer = ((index * 2) _
                        + 1)
            Dim right As Integer = ((2 * index) _
                        + 2)
            Dim largest As Integer = index
            If ((left <= heapSize) _
                        AndAlso (input(left) > input(index))) Then
                largest = left
            Else
                largest = index
            End If

            If ((right <= heapSize) _
                        AndAlso (input(right) > input(largest))) Then
                largest = right
            End If

            If (largest <> index) Then
                Dim temp As Integer = input(index)
                input(index) = input(largest)
                input(largest) = temp
                Me.MinHeapify(input, heapSize, largest)
            End If

        End Sub
    End Class
End Namespace