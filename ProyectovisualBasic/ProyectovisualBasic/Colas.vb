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

    Public Class Colas
        Inherits Form

        Private valor As Cola = New Cola

        Public Sub New()
            MyBase.New
            InitializeComponent
        End Sub

        Private Sub btnCrear_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim n As Integer = Integer.Parse(txtMaximo.Text)
            Me.valor = New Cola(n)
            MessageBox.Show("Cola Creada")
        End Sub

        Private Sub btnEncolar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim n As Integer
            n = Integer.Parse(txtNumero.Text)
            If (n Is Nothing) Then
                MessageBox.Show("INGRESE UN DATO")
            Else
                Me.valor.encolar(n)
                txtNumero.Clear
                txtNumero.Focus
            End If

        End Sub

        Private Sub btnDesencolar_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim n As Integer
            n = Me.valor.desencolar
            MessageBox.Show(("Sali� " + n))
        End Sub
    End Class
End Namespace