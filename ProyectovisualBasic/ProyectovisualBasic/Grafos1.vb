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

    Public Class Grafos1
        Inherits Form

        Private lista As Lista = New Lista

        Private grafo As Lista = New Lista

        Private caminos As GrafosConListas = New GrafosConListas

        Private nuevo As Nodo1

        Public Sub New()
            MyBase.New
            InitializeComponent
        End Sub

        Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (txtDato.Text = "") Then
                Return
            End If

            If Me.grafo.Buscar(Integer.Parse(txtDato.Text)) Then
                Return
            End If

            Me.caminos = New GrafosConListas
            Me.nuevo = New Nodo1(Integer.Parse(txtDato.Text), Nothing, Me.caminos)
            Me.grafo.Agregar(Me.nuevo)
            Nodos.Items.Add(txtDato.Text)
            Union.Items.Add(txtDato.Text)
            Nodos.SelectedIndex = 0
            Union.SelectedIndex = 0
            Nodos.Focus
            txtDato.Clear
            lblResultado.Text = ("RESULTADO: " _
                        + (Environment.NewLine _
                        + (Environment.NewLine + Me.grafo.ToString)))
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (txtDato.Text = "") Then
                Return
            End If

            Me.grafo.Eliminar(Integer.Parse(txtDato.Text))
            Me.grafo.EliminarLazos(Integer.Parse(txtDato.Text))
            Nodos.Items.Remove(txtDato.Text)
            Union.Items.Remove(txtDato.Text)
            Nodos.SelectedIndex = 0
            Union.SelectedIndex = 0
            lblResultado.Text = ("RESULTADO: " _
                        + (Environment.NewLine _
                        + (Environment.NewLine + Me.grafo.ToString)))
            txtDato.Clear
        End Sub

        Private Sub btnAgregarArista_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.nuevo = New Nodo1(Integer.Parse(Union.Text), Nothing, Nothing)
            Me.grafo.SeleccionarCamino(Integer.Parse(Nodos.Text)).Agregar(Me.nuevo)
            'caminos.Agregar - nuevo;
            lblResultado.Text = ("RESULTADO: " _
                        + (Environment.NewLine _
                        + (Environment.NewLine + Me.grafo.ToString)))
            txtDato.Clear
        End Sub

        Private Sub btnEliminarArista_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.grafo.SeleccionarCamino(Integer.Parse(Nodos.Text)).Eliminar(Integer.Parse(Union.Text))
            txtDato.Clear
            lblResultado.Text = "RESULTADO: "
        End Sub
    End Class
End Namespace