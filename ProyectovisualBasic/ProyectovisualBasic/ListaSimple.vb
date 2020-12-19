Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_Final1

    Class ListaSimple

        'Variables
        Private Head As Nodo

        'Constructores 
        Public Sub New()
            MyBase.New
            Me.Head = Nothing
        End Sub

        'Propiedades
        'Metodos
        'Insertar
        Public Sub Insertar(ByVal n As Nodo)
            'unico nodo//Cuando la lista esta vac�a 
            If (Me.Head Is Nothing) Then
                Me.Head = n
                Return
            End If

            If Me.Buscar(n.Dato) Then
                Return
            End If

            'Inicio
            If (n.Dato < Me.Head.Dato) Then
                n.Siguiente = Me.Head
                Me.Head = n
                Return
            End If

            Dim h As Nodo = Me.Head

            While (Not (h.Siguiente) Is Nothing)
                If (n.Dato < h.Siguiente.Dato) Then
                    Exit While
                End If

                h = h.Siguiente

            End While

            n.Siguiente = h.Siguiente
            h.Siguiente = n
        End Sub

        Public Function Contar() As Integer
            Dim h As Nodo = Me.Head
            Dim i As Integer = 0

            While (Not (h) Is Nothing)
                i = (i + 1)
                h = h.Siguiente

            End While

            Return i
        End Function

        Public Function MostrarDatos() As String
            Dim h As Nodo = Me.Head
            Dim s As String = ""

            While (Not (h) Is Nothing)
                s = (s _
                            + (h.Dato + ","))
                h = h.Siguiente

            End While

            Return s
        End Function

        Public Function Buscar(ByVal b As Integer) As Boolean
            Dim h As Nodo = Me.Head

            While (Not (h) Is Nothing)
                If (b < h.Dato) Then
                    Return False
                End If

                If (b = h.Dato) Then
                    Return True
                End If

                h = h.Siguiente

            End While

            Return False
        End Function

        Public Sub Eliminar(ByVal b As Integer)
            Dim h As Nodo = Me.Head
            If (Me.Head Is Nothing) Then
                Return
            End If

            ' !  = Not
            If Not Me.Buscar(b) Then
                Return
            End If

            'Borrar al inicio
            If (b = Me.Head.Dato) Then
                Me.Head = Me.Head.Siguiente
                Return
            End If


            While (Not (h.Siguiente) Is Nothing)
                If (b = h.Siguiente.Dato) Then
                    h.Siguiente = h.Siguiente.Siguiente
                    Return
                End If

                h = h.Siguiente

            End While

        End Sub
    End Class
End Namespace