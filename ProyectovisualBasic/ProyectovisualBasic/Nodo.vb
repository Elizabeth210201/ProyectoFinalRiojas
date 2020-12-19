Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_Final1

    Class Nodo

        'VARIVABLES//
        Private dato As Integer

        Private siguiente As Nodo

        Private anterior As Nodo

        Public izquierdo As Nodo

        Public derecho As Nodo

        Public Sub New(ByVal info As Integer)
            MyBase.New
            Me.dato = info
        End Sub

        'CONSTRUCTORES//
        'Nodo
        Public Sub New()
            MyBase.New
            Me.dato = 0
            Me.siguiente = Nothing
            Me.anterior = Nothing
            Me.dato = 0
            Me.izquierdo = Nothing
            Me.derecho = Nothing
        End Sub

        'Componentes que contiene el nodo
        Public Sub New(ByVal d As Integer, ByVal s As Nodo, ByVal a As Nodo)
            MyBase.New
            Me.dato = d
            Me.siguiente = s
            Me.anterior = a
        End Sub

        'PROPIEDADES O METODOS//
        'Dato
        Public Property Dato As Integer
            Get
                Return Me.dato
            End Get
            Set
                Me.dato = Value
            End Set
        End Property

        'Siguiente
        Public Property Siguiente As Nodo
            Get
                Return Me.siguiente
            End Get
            Set
                Me.siguiente = Value
            End Set
        End Property

        'Anterior
        Public Property Anterior As Nodo
            Get
                Return Me.anterior
            End Get
            Set
                Me.anterior = Value
            End Set
        End Property
    End Class
End Namespace