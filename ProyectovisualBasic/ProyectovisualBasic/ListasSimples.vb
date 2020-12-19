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

    Public Class ListasSimples
        Inherits Form

        Private lista As ListaSimple

        Public Sub New()
            MyBase.New
            InitializeComponent
            Me.lista = New ListaSimple
        End Sub

        Private Sub btn1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim n As Nodo
            Dim d As Integer = Integer.Parse(txtDato.Text)
            n = New Nodo
            n.Dato = d
            n.Siguiente = Nothing
            Me.lista.Insertar(n)
            txtDato.Clear
            txtDato.Focus
        End Sub

        Private Sub btn2_Click(ByVal sender As Object, ByVal e As EventArgs)
            textBox1.Text = Me.lista.Contar.ToString
        End Sub

        Private Sub btn3_Click(ByVal sender As Object, ByVal e As EventArgs)
            textBox1.Text = Me.lista.MostrarDatos.ToString
        End Sub

        Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.lista.Buscar(Integer.Parse(txtDato.Text)) Then
                textBox1.Text = "Si esta"
            Else
                textBox1.Text = "No esta "
            End If

        End Sub

        Private Sub btnBorrar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.lista.Eliminar(Integer.Parse(txtDato.Text))
        End Sub
    End Class
End Namespace