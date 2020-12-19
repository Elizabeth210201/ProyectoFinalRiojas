Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Proyecto_Final1

    Class Cola

        Private maximo As Integer

        Private frente As Integer

        Private atras As Integer

        Private lacola() As Integer

        Public Sub New()
            MyBase.New

        End Sub

        Public Sub New(ByVal max As Integer)
            MyBase.New
            Me.frente = -1
            Me.atras = -1
            Me.maximo = max
            Me.lacola = New Integer((max) - 1) {}
        End Sub

        Public Function cola_llena() As Boolean
            If (Me.atras _
                        = (Me.maximo - 1)) Then
                Return True
            Else
                Return False
            End If

        End Function

        Public Function cola_vacia() As Boolean
            If (Me.frente = -1) Then
                Return True
            Else
                Return False
            End If

        End Function

        Public Sub encolar(ByVal n As Integer)
            If (Me.cola_llena = True) Then
                MessageBox.Show("cola llena")
            Else
                Me.atras = (Me.atras + 1)
                Me.lacola(Me.atras) = n
                If (Me.atras = 0) Then
                    Me.frente = 0
                End If

            End If

        End Sub

        Public Function desencolar() As Integer
            Dim n As Integer = 0
            If (Me.cola_vacia = True) Then
                MessageBox.Show("cola vacia")
                Return n
            Else
                n = Me.lacola(Me.frente)
                If (Me.frente = Me.atras) Then
                    Me.frente = -1
                    Me.atras = -1
                Else
                    Me.frente = (Me.frente + 1)
                End If

                Return n
            End If

        End Function
    End Class
End Namespace
