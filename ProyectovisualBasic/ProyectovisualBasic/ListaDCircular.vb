Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_Final1

    Class ListaDCircular

        Private head As Nodo

        Public Sub New()
            MyBase.New
            Me.head = Nothing
        End Sub

        Public Sub Insertar(ByVal n As Nodo)
            'return;
            'unico nodo - lista vacia
            If (Me.head Is Nothing) Then
                n.Anterior = n
                n.Siguiente = n
                Me.head = n
                Return
            End If

            If Me.Buscar(n.Dato) Then
                Return
            End If

            'Inicio
            If (n.Dato < Me.head.Dato) Then
                n.Siguiente = Me.head
                n.Anterior = Me.head.Anterior
                Me.head.Anterior = n
                Me.head.Siguiente = n
                Me.head = n
                Return
            End If

            'recorrer
            Dim h As Nodo = Me.head
            Dim a As Boolean = False

            While (h.Siguiente <> Me.head)
                If (n.Dato < h.Siguiente.Dato) Then
                    h.Siguiente.Anterior = n
                    n.Siguiente = h.Siguiente
                    a = True
                    Exit While
                End If

                h = h.Siguiente

            End While

            'insertar final
            n.Anterior = h
            h.Siguiente = n
            If a Then
                Return
            Else
                Me.head.Anterior = n
                Me.head.Anterior.Siguiente = Me.head
            End If

        End Sub

        Public Function Contar() As Integer
            Dim h As Nodo = Me.head
            Dim i As Integer = 0

            Do Until (h <> Me.head)
                i = (i + 1)
                h = h.Siguiente

            Loop

            Return i
        End Function

        Public Function MostrarDatos() As String
            Dim h As Nodo = Me.head
            Dim s As String = ""

            Do Until (h <> Me.head)
                s = (s _
                            + (h.Dato + " - "))
                h = h.Siguiente

            Loop

            Return s
        End Function

        Public Function MostrarDatosAnt() As String
            Dim h As Nodo = Me.head
            Dim s As String = ""

            Do Until (h <> Me.head)
                s = (s _
                            + (h.Anterior.Dato + " - "))
                h = h.Anterior

            Loop

            Return s
        End Function

        Public Function Buscar(ByVal b As Integer) As Boolean
            Dim h As Nodo = Me.head

            Do Until (h <> Me.head)
                If (b < h.Dato) Then
                    Return False
                End If

                If (b = h.Dato) Then
                    Return True
                End If

                h = h.Siguiente

            Loop

            Return False
        End Function

        Public Sub Borrar(ByVal n As Integer)
            If (Me.head Is Nothing) Then
                Return
            End If

            If Not Me.Buscar(n) Then
                Return
            End If

            'Inicio
            If (n = Me.head.Dato) Then
                Me.head.Anterior.Siguiente = Me.head.Siguiente
                Me.head.Siguiente.Anterior = Me.head.Anterior
                Me.head = Me.head.Siguiente
                Return
            End If

            Dim h As Nodo = Me.head

            Do Until (h <> Me.head)
                If (n = h.Siguiente.Dato) Then
                    If (h.Siguiente.Siguiente <> Me.head) Then
                        h.Siguiente = h.Siguiente.Siguiente
                        h.Siguiente.Anterior = h
                        Return
                    Else
                        h.Siguiente = Me.head
                        Me.head.Anterior = Me.head.Anterior.Anterior
                        Return
                    End If

                End If

                h = h.Siguiente

            Loop

        End Sub
    End Class
End Namespace