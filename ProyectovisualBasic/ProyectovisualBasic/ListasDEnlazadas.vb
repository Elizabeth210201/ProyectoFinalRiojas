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

    Public Class ListasDEnlazadas
        Inherits Form

        Private lista As ListasDoblesE

        Public Sub New()
            MyBase.New
            InitializeComponent
            Me.lista = New ListasDoblesE
        End Sub

        Private Sub btnIngresar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim n As Nodo = New Nodo(Integer.Parse(txtDatos.Text), Nothing, Nothing)
            Dim d As Integer = Integer.Parse(txtDatos.Text)
            n = New Nodo
            n.Dato = d
            n.Siguiente = Nothing
            n.Anterior = Nothing
            Me.lista.Ingresar(n)
            Me.lista.recorrerhaciaatras(n)
            txtDatos.Clear
            txtDatos.Focus
        End Sub

        Private Sub btnRecorrerAdelante_Click(ByVal sender As Object, ByVal e As EventArgs)
            lblDato.Text = Me.lista.RecorrerAdelante.ToString
        End Sub

        Private Sub btnAtras_Click(ByVal sender As Object, ByVal e As EventArgs)
            lblDato.Text = Me.lista.RecorrerAtras.ToString
        End Sub

        Private Sub bntBorrarPrimero_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.lista.borrarPrimero()
        End Sub

        Private Sub bntBorrarUltimo_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.lista.borrarUltimo()
        End Sub

        Private Sub btnBorrar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.lista.borrar(Integer.Parse(txtDatos.Text))
        End Sub

        Private Sub label1_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub label2_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub lblDato_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub txtDatos_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

        End Sub
    End Class
End Namespace