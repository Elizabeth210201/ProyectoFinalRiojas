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

    Public Class Pilas
        Inherits Form

        Private pila As Pila

        Public Sub New()
            MyBase.New
            InitializeComponent
            Me.pila = New Pila
        End Sub

        Private Sub btnPush_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim n As Nodo
            Dim d As Integer = Integer.Parse(textBox1.Text)
            n = New Nodo
            n.Dato = d
            n.Siguiente = Nothing
            Me.pila.Push(n)
            txtDato.Clear
            txtDato.Focus
            listBox1.Items.Add(d)
        End Sub

        Private Sub btnPop_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.pila.pila_vacia Then
                MessageBox.Show("pila vacia")
                Return
            End If

            Dim n As Nodo
            n = Me.pila.Pop
            MessageBox.Show(("salio " + n.Dato))
            Dim a As Integer
            a = n.Dato
            listBox1.Items.Remove(a)
        End Sub

        Private Sub label1_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub listBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub txtDato_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub label2_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'Pilas
            '
            Me.ClientSize = New System.Drawing.Size(278, 244)
            Me.Name = "Pilas"
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace