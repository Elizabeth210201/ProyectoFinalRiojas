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

    Public Class ListasDCirculares
        Inherits Form

        Private lista As ListaDCircular1

        Public Sub New()
            MyBase.New
            InitializeComponent
            Me.lista = New ListaDCircular1
        End Sub

        Private Sub btnInsertar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim n As Nodo
            Dim d As Integer = Int32.Parse(txtInsertar.Text)
            n = New Nodo
            n.Dato = d
            n.Siguiente = Nothing
            n.Anterior = Nothing
            Me.lista.Insertar(n)
            txtInsertar.Clear
            txtInsertar.Focus
        End Sub

        Private Sub btnMostrarDatos_Click(ByVal sender As Object, ByVal e As EventArgs)
            lblContar.Text = Me.lista.MostrarDatos
            lblContarDes.Text = Me.lista.MostrarDatosAnt
        End Sub

        Private Sub btnContar_Click(ByVal sender As Object, ByVal e As EventArgs)
            lblContar.Text = (Me.lista.Contar + "")
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.lista.Buscar(Integer.Parse(txtInsertar.Text)) Then
                lblContar.Text = "Si est�"
            Else
                lblContar.Text = "No est�"
            End If

        End Sub

        Private Sub btnBorrar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.lista.Borrar(Integer.Parse(txtInsertar.Text))
        End Sub

        Private Sub lblContar_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub lblContarDes_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub txtInsertar_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

        End Sub
    End Class
End Namespace