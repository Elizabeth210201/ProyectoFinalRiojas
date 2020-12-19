Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_Final1

    Class Pila

        Private head As Nodo

        Public Sub New()
            MyBase.New
            Me.head = Nothing
        End Sub

        Public Function pila_vacia() As Boolean
            If (Me.head Is Nothing) Then
                Return True
            Else
                Return False
            End If

        End Function

        Public Sub Push(ByVal n As Nodo)
            If (Me.head Is Nothing) Then
                Me.head = n
                Return
            End If

            n.Siguiente = Me.head
            Me.head = n
            Return
        End Sub

        Public Function Pop() As Nodo
            Dim h As Nodo = Me.head
            Me.head = Me.head.Siguiente
            Return h
        End Function
    End Class
End Namespace