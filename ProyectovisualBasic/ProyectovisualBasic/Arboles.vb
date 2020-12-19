Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Proyecto_Final1

    Public Class Arboles
        Inherits Form

        Private arbol As ArbolBinario

        Public Sub New()
            MyBase.New
            InitializeComponent
            Me.arbol = New ArbolBinario
        End Sub

        Private Sub btnInsertar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim n As Nodo
            Dim d As Integer = Integer.Parse(txtDato.Text)
            n = New Nodo
            n.Dato = d
            n.derecho = Nothing
            n.izquierdo = Nothing
            Me.arbol.Insertar(n)
            lblArbol.Text = (d + " ")
            txtDato.Clear
            txtDato.Focus
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.arbol.Buscar(Integer.Parse(txtDato.Text)) Then
                lblResultado.Text = "Dato encontrado"
            Else
                lblResultado.Text = "Dato  no encontrado"
            End If

        End Sub

        Private Sub btnPreOrden_Click(ByVal sender As Object, ByVal e As EventArgs)
            lblArbol.Text = (Me.arbol.PreOrden + " ")
        End Sub

        Private Sub btnEnOrden_Click(ByVal sender As Object, ByVal e As EventArgs)
            lblArbol.Text = (Me.arbol.InOrden + " ")
        End Sub

        Private Sub btnPostOrden_Click(ByVal sender As Object, ByVal e As EventArgs)
            lblArbol.Text = (Me.arbol.PostOrden + " ")
        End Sub

        Private Sub btnBorrar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.arbol.Borrar(Integer.Parse(txtDato.Text))
        End Sub
    End Class
End Namespace