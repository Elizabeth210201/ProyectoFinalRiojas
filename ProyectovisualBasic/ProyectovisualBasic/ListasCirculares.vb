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

    Public Class ListasCirculares
        Inherits Form

        Private lista As ListasCirculares1 = New ListasCirculares1

        Private nuevo As Nodo

        Public Sub New()
            MyBase.New
            InitializeComponent
        End Sub

        Private Sub btnInsertar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                If Me.lista.Buscar(Integer.Parse(txtDato.Text)) Then
                    MessageBox.Show("Ya existe este dato")
                    Return
                End If

                Me.nuevo = New Nodo(Int32.Parse(txtDato.Text))
                Me.lista.Insertar(Me.nuevo)
                txtDato.Clear
                txtDato.Focus
                txtLista.Text = Me.lista.Mostrar.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Sub

        Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Me.lista.Eliminar(Int32.Parse(txtDato.Text))
                txtDato.Clear
                txtDato.Focus
                txtLista.Text = Me.lista.Mostrar.ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Sub
    End Class
End Namespace