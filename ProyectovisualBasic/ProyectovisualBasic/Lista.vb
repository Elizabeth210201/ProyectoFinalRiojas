Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_Final1

    Class Lista

        'Variable(s)
        Public head As Nodo1

        'Propiedades
        Public Property Head As Nodo1
            Get
                Return Me.head
            End Get
            Set
                Me.head = Value
            End Set
        End Property

        'Constructores
        Public Sub New()
            MyBase.New
            Me.head = Nothing
        End Sub

        'Metodos
        Public Sub Agregar(ByVal nuevo As Nodo1)
            If (Me.head Is Nothing) Then
                Me.head = nuevo
                Return
            End If

            Dim copia As Nodo1 = Me.head

            While (Not (copia.Siguiente) Is Nothing)
                copia = copia.siguiente

            End While

            copia.Siguiente = nuevo
        End Sub

        Public Function Buscar(ByVal valor As Integer) As Boolean
            If (Me.head Is Nothing) Then
                Return False
            End If

            Dim copia As Nodo1 = Me.head

            While (Not (copia) Is Nothing)
                If (copia.Valor = valor) Then
                    Return True
                End If

                copia = copia.siguiente

            End While

            Return False
        End Function

        Public Function SeleccionarCamino(ByVal valor As Integer) As GrafosConListas
            If (Me.head Is Nothing) Then
                Return Nothing
            End If

            Dim copia As Nodo1 = Me.head

            While (Not (copia) Is Nothing)
                If (copia.Valor = valor) Then
                    Return copia.Lazos
                End If

                copia = copia.siguiente

            End While

            Return Nothing
        End Function

        Public Sub EliminarLazos(ByVal valor As Integer)
            Dim copia As Nodo1 = Me.head

            While (Not (copia) Is Nothing)
                Dim camino As GrafosConListas = copia.Lazos
                camino.Eliminar(valor)
                copia = copia.siguiente

            End While

        End Sub

        Public Sub Eliminar(ByVal valor As Integer)
            If (Me.head Is Nothing) Then
                Return
            End If

            If (Me.head.Valor = valor) Then
                Me.head = Me.head.siguiente
                Return
            End If

            Dim copia As Nodo1 = Me.head
            Dim auxiliar As Nodo1 = Me.head

            While (Not (copia) Is Nothing)
                If (copia.Valor = valor) Then
                    auxiliar.Siguiente = copia.Siguiente
                    Return
                End If

                auxiliar = copia
                copia = copia.siguiente

            End While

        End Sub

        Public Overrides Function ToString() As String
            Dim grafo As String = ""
            Dim copia As Nodo1 = Me.head

            While (Not (copia) Is Nothing)
                grafo = (grafo + ("[" _
                            + (copia.Valor + "]")))
                Dim camino As GrafosConListas = copia.Lazos
                grafo = (grafo + camino.ToString)
                copia = copia.siguiente
                grafo = (grafo + Environment.NewLine)

            End While

            Return grafo
        End Function
    End Class
End Namespace