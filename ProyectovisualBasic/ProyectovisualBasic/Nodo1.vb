Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_Final1

    Class Nodo1

        'Variables
        Public valor As Integer

        Public siguiente As Nodo1

        Public lazos As GrafosConListas

        'Propiedades
        Public ReadOnly Property Valor As Integer
            Get
                Return Me.valor
            End Get
        End Property

        Public Property Siguiente As Nodo1
            Get
                Return Me.siguiente
            End Get
            Set
                Me.siguiente = Value
            End Set
        End Property

        Public Property Lazos As GrafosConListas
            Get
                Return Me.lazos
            End Get
            Set
                Me.lazos = Value
            End Set
        End Property

        'Constructores
        Public Sub New(ByVal valor As Integer, ByVal Siguiente As Nodo1, ByVal lazos As GrafosConListas)
            MyBase.New
            Me.valor = Me.valor
            Me.siguiente = Me.siguiente
            Me.lazos = Me.lazos
        End Sub
    End Class
End Namespace
