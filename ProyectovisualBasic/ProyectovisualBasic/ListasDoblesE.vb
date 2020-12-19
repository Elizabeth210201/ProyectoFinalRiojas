Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_Final1

    Class ListasDoblesE

        Private head As Nodo

        Private bottom As Nodo

        Public Sub New()
            MyBase.New
            Me.head = Nothing
            Me.bottom = Nothing
        End Sub

        'Ingresar Datos
        Public Sub Ingresar(ByVal d As Nodo)
            '  Nodo actual = new Nodo();
            Dim ne As Nodo = New Nodo
            ne = d
            '   actual = head;
            'unico nodo//Cuando la lista esta vac�a 
            If (Me.head Is Nothing) Then
                Me.head = ne
                Me.bottom = ne
                Return
            End If

            'Inicio
            If (ne.Dato < Me.head.Dato) Then
                ne.Siguiente = Me.head
                Me.head.Anterior = ne
                Me.head = ne
                Return
            End If

            'recorrer
            Dim h As Nodo = Me.head

            While (Not (h.Siguiente) Is Nothing)
                If (ne.Dato < h.Siguiente.Dato) Then
                    Exit While
                End If

                h = h.Siguiente

            End While

            ne.Siguiente = h.Siguiente
            h.Siguiente = ne
        End Sub

        Public Sub recorrerhaciaatras(ByVal d As Nodo)
            Dim nodito As Nodo = New Nodo
            nodito = d
            If (Me.bottom Is Nothing) Then
                Me.bottom = d
            End If

            If (Not (Me.bottom) Is Nothing) Then
                If (nodito.Dato > Me.bottom.Dato) Then
                    nodito.Anterior = Me.bottom
                    Me.bottom = nodito
                End If

                If (nodito.Dato < Me.head.Dato) Then
                    nodito.Siguiente = Me.bottom.Anterior
                    nodito.Anterior = nodito
                End If

            End If

        End Sub

        Public Function Buscar(ByVal d As Integer) As Boolean
            Dim h As Nodo = Me.head

            While (Not (h) Is Nothing)
                If (d < h.Dato) Then
                    Return False
                End If

                If (d = h.Dato) Then
                    Return True
                End If

                h = h.Siguiente

            End While

            Return False
        End Function

        'Eliminar dato espec�fico
        Public Sub borrar(ByVal d As Integer)
            If (Me.head Is Nothing) Then
                Return
            End If

            If Not Me.Buscar(d) Then
                Return
            End If

            If (d = Me.head.Dato) Then
                Me.head = Me.head.Siguiente
                Me.head = Me.head.Anterior
                Return
            End If

            Dim h As Nodo = Me.head

            While (h.Anterior Is Nothing)
                If (d = h.Anterior.Dato) Then
                    h.Anterior = h.Anterior.Anterior
                    Return
                End If

                h = h.Anterior

            End While

        End Sub

        'Eliminar primer dato
        Public Sub borrarPrimero()
            Me.head = Me.head.Siguiente
            Me.head.Anterior = Nothing
        End Sub

        'Eliminar ultimo dato
        Public Sub borrarUltimo()
            If (Me.bottom.Anterior Is Nothing) Then
                Me.head = Nothing
                Me.bottom = Nothing
            Else
                Me.bottom = Me.bottom.Anterior
                Me.bottom.Siguiente = Nothing
            End If

        End Sub

        'Recorrer de cabeza a cola
        Public Function RecorrerAdelante() As String
            Dim h As Nodo = Me.head
            Dim s As String = ""

            While (Not (h) Is Nothing)
                s = (s _
                            + (h.Dato + "-"))
                h = h.Siguiente

            End While

            Return s
        End Function

        'Recorrer de cola a cabeza
        Public Function RecorrerAtras() As String
            Dim b As Nodo = Me.bottom
            Dim s As String = ""

            While (Not (b) Is Nothing)
                s = (s _
                            + (b.Dato + "-"))
                b = b.Anterior

            End While

            Return s
        End Function
    End Class
End Namespace