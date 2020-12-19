Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Proyecto_Final1

    Class ArbolBinario

        Private raiz As Nodo

        Private cant As Integer

        Private altura As Integer

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

        Private s As String

        Private Overloads Sub PreOrden(ByVal r As Nodo)
            If (Not (r) Is Nothing) Then
                Me.s = (Me.s _
                            + (r.Dato + " "))
                Me.PreOrden(r.izquierdo)
                Me.PreOrden(r.derecho)
            End If

        End Sub

        Public Overloads Function PreOrden() As String
            Me.s = ""
            Me.PreOrden(Me.raiz)
            Return Me.s
        End Function

        Private Overloads Sub InOrden(ByVal r As Nodo)
            If (Not (r) Is Nothing) Then
                Me.InOrden(r.izquierdo)
                Me.s = (Me.s _
                            + (r.Dato + " "))
                Me.InOrden(r.derecho)
            End If

        End Sub

        Public Overloads Function InOrden() As String
            Me.s = ""
            Me.InOrden(Me.raiz)
            Return Me.s
        End Function

        Private Overloads Sub PostOrden(ByVal r As Nodo)
            If (Not (r) Is Nothing) Then
                Me.PostOrden(r.izquierdo)
                Me.PostOrden(r.derecho)
                Me.s = (Me.s _
                            + (r.Dato + " "))
            End If

        End Sub

        Public Overloads Function PostOrden() As String
            Me.s = ""
            Me.PostOrden(Me.raiz)
            Return Me.s
        End Function

        Public Function Buscar(ByVal b As Integer) As Boolean
            Dim r As Nodo = Me.raiz

            While (Not (r) Is Nothing)
                If (b = r.Dato) Then
                    Return True
                End If

                If (r.Dato > b) Then
                    If (r.izquierdo Is Nothing) Then
                        Return False
                    End If

                    r = r.izquierdo
                Else
                    If (r.derecho Is Nothing) Then
                        Return False
                    End If

                    r = r.derecho
                End If


            End While

            Return False
        End Function

        Public Sub Borrar(ByVal b As Integer)
            If (Me.raiz Is Nothing) Then
                Return
            End If

            If Not Me.Buscar(b) Then
                Return
            End If

            Dim r As Nodo = Me.raiz
            Dim Aux As Nodo = Nothing

            While (r.Dato <> b)
                Aux = r
                If (r.Dato > b) Then
                    r = r.izquierdo
                Else
                    r = r.derecho
                End If


            End While

            If (r = Me.raiz) Then
                If (Not (r.derecho) Is Nothing) Then
                    r = r.derecho

                    While (Not (r.izquierdo) Is Nothing)
                        Aux = r
                        r = r.izquierdo

                    End While

                    Me.raiz.Dato = r.Dato
                    Aux.izquierdo = r.derecho
                    Return
                End If

                If (Not (r.izquierdo) Is Nothing) Then
                    r = r.izquierdo
                    Aux = r

                    While (Not (r.derecho) Is Nothing)
                        r = r.derecho

                    End While

                    Me.raiz.Dato = r.Dato
                    Aux.derecho = Aux.derecho.izquierdo
                    Return
                Else
                    Me.raiz = Nothing
                End If

            End If

            If ((r.derecho Is Nothing) _
                        AndAlso (r.izquierdo Is Nothing)) Then
                If (b = Aux.izquierdo.Dato) Then
                    Aux.izquierdo = Nothing
                Else
                    Aux.derecho = Nothing
                End If

            Else
                Dim r2 As Nodo = r
                If (Not (r.derecho) Is Nothing) Then
                    r = r.derecho

                    While (Not (r.izquierdo) Is Nothing)
                        Aux = r
                        r = r.izquierdo

                    End While

                    r2.Dato = r.Dato
                    Aux.izquierdo = Aux.izquierdo.derecho
                    Return
                End If

                If (Not (r.izquierdo) Is Nothing) Then
                    r = r.izquierdo

                    While (Not (r.derecho) Is Nothing)
                        Aux = r
                        r = r.derecho

                    End While

                    r2.Dato = r.Dato
                    Aux.derecho = Aux.derecho.izquierdo
                    Return
                Else
                    Me.raiz = Nothing
                End If

            End If

        End Sub
    End Class
End Namespace
