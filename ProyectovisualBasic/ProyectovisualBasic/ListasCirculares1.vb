Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_Final1

    Class ListasCirculares1

        Private head As Nodo

        Private ultimo As Nodo

        'Nodo anterior;
        Public Sub New()
            MyBase.New
            Me.head = Nothing
        End Sub

        Public Sub New(ByVal nuevo As Nodo)
            MyBase.New
            Me.head = nuevo
        End Sub

        Public Property Head As Nodo
            Get
                Return Me.head
            End Get
            Set
                Me.head = Value
            End Set
        End Property

        Public ReadOnly Property CantidadNodos As Integer
            Get
                Dim cantidad As Integer = 0
                Dim h As Nodo = Me.head

                While h <> Me.head
                    cantidad = (cantidad + 1)
                    h = h.Siguiente

                End While

                Return cantidad
            End Get
        End Property

        Public Sub Insertar(ByVal nuevo As Nodo)
            'insertar cuando la lista est� vac�a
            If Me.head Is Nothing Then
                Me.head = nuevo
                Me.head.Siguiente = nuevo
                Me.ultimo = nuevo
                Return
            End If

            'insertar al inicio
            If nuevo.Dato < Me.head.Dato Then
                nuevo.Siguiente = Me.head
                Me.head = nuevo
                Me.ultimo.Siguiente = nuevo
                Return
            End If

            Dim h As Nodo = Me.head.Siguiente
            Dim a As Nodo = Me.head

            While h <> Me.head
                'insertar entre dos nodos
                If (nuevo.Dato < h.Dato) Then
                    nuevo.Siguiente = h
                    a.Siguiente = nuevo
                    Return
                End If

                a = h
                h = h.Siguiente

            End While

            'insertar al final
            nuevo.Siguiente = Me.head
            a.Siguiente = nuevo
            Me.ultimo = nuevo
        End Sub

        Public Function Mostrar() As String
            If Me.head Is Nothing Then
                Return ""
            End If

            Dim s As String = Me.head.Dato + ""
            Dim h As Nodo = Me.head.Siguiente

            While h <> Me.head
                s = s _
                            + (Environment.NewLine + h.Dato)
                h = h.Siguiente

            End While

            Return s
        End Function

        Public Sub Eliminar(ByVal dato As Integer)
            If Me.head Is Nothing Then
                Return
            End If

            'Eliminar el �nico nodo en la lista
            If Me.head.Dato = dato _
                        AndAlso (Me.head.Siguiente = Me.head)) Then
                Me.head = Nothing
                Me.ultimo = Nothing
                Return
            End If

            'Eliminar el nodo apuntado por head
            If Me.head.Dato = dato Then
                Me.head = Me.head.Siguiente
                Me.ultimo.Siguiente = Me.head
                Return
            End If

            'Eliminar entre dos nodos
            Dim h As Nodo = Me.head.Siguiente

            While h <> Me.head
                If h.Siguiente.Dato = dato Then
                    Exit While
                End If

                h = h.Siguiente

            End While

            h.Siguiente = h.Siguiente.Siguiente
        End Sub

        Public Function Buscar(ByVal dato As Integer) As Boolean
            If Me.head Is Nothing Then
                Return False
            End If

            If Me.head.Dato = dato Then
                Return True
            End If

            Dim h As Nodo = Me.head.Siguiente

            While h <> Me.head
                If h.Dato = dato Then
                    Return True
                End If

                h = h.Siguiente

            End While

            Return False
        End Function
    End Class
End Namespace